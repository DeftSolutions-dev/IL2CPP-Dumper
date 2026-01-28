// ========================================================
// Dumped by @desirepro
// Assembly: System.Core.dll
// Classes:  673
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: SR
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.String GetString(System.String name)
  System.String Format(System.String resourceFormat, System.Object[] args)
  System.String Format(System.String resourceFormat, System.Object p1)
  System.String Format(System.String resourceFormat, System.Object p1, System.Object p2)
  System.String Format(System.String resourceFormat, System.Object p1, System.Object p2, System.Object p3)
END_CLASS

CLASS: Iterator`1
TYPE:  class
TOKEN: 0x200001D
FIELDS:
  private           System.Int32                    threadId  // 0x0
  private           System.Int32                    state  // 0x0
  private           TSource                         current  // 0x0
METHODS:
  System.Void .ctor()
  TSource get_Current()
  System.Linq.Enumerable.Iterator<TSource> Clone()
  System.Void Dispose()
  System.Collections.Generic.IEnumerator<TSource> GetEnumerator()
  System.Boolean MoveNext()
  System.Collections.Generic.IEnumerable<TResult> Select(System.Func<TSource,TResult> selector)
  System.Collections.Generic.IEnumerable<TSource> Where(System.Func<TSource,System.Boolean> predicate)
  System.Object System.Collections.IEnumerator.get_Current()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: WhereEnumerableIterator`1
TYPE:  class
TOKEN: 0x200001E
EXTENDS: Iterator`1
FIELDS:
  private           System.Collections.Generic.IEnumerable<TSource>source  // 0x0
  private           System.Func<TSource,System.Boolean>predicate  // 0x0
  private           System.Collections.Generic.IEnumerator<TSource>enumerator  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate)
  System.Linq.Enumerable.Iterator<TSource> Clone()
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Collections.Generic.IEnumerable<TResult> Select(System.Func<TSource,TResult> selector)
  System.Collections.Generic.IEnumerable<TSource> Where(System.Func<TSource,System.Boolean> predicate)
END_CLASS

CLASS: WhereArrayIterator`1
TYPE:  class
TOKEN: 0x200001F
EXTENDS: Iterator`1
FIELDS:
  private           TSource[]                       source  // 0x0
  private           System.Func<TSource,System.Boolean>predicate  // 0x0
  private           System.Int32                    index  // 0x0
METHODS:
  System.Void .ctor(TSource[] source, System.Func<TSource,System.Boolean> predicate)
  System.Linq.Enumerable.Iterator<TSource> Clone()
  System.Boolean MoveNext()
  System.Collections.Generic.IEnumerable<TResult> Select(System.Func<TSource,TResult> selector)
  System.Collections.Generic.IEnumerable<TSource> Where(System.Func<TSource,System.Boolean> predicate)
END_CLASS

CLASS: WhereListIterator`1
TYPE:  class
TOKEN: 0x2000020
EXTENDS: Iterator`1
FIELDS:
  private           System.Collections.Generic.List<TSource>source  // 0x0
  private           System.Func<TSource,System.Boolean>predicate  // 0x0
  private           System.Collections.Generic.List.Enumerator<TSource>enumerator  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.List<TSource> source, System.Func<TSource,System.Boolean> predicate)
  System.Linq.Enumerable.Iterator<TSource> Clone()
  System.Boolean MoveNext()
  System.Collections.Generic.IEnumerable<TResult> Select(System.Func<TSource,TResult> selector)
  System.Collections.Generic.IEnumerable<TSource> Where(System.Func<TSource,System.Boolean> predicate)
END_CLASS

CLASS: WhereSelectEnumerableIterator`2
TYPE:  class
TOKEN: 0x2000021
EXTENDS: Iterator`1
FIELDS:
  private           System.Collections.Generic.IEnumerable<TSource>source  // 0x0
  private           System.Func<TSource,System.Boolean>predicate  // 0x0
  private           System.Func<TSource,TResult>    selector  // 0x0
  private           System.Collections.Generic.IEnumerator<TSource>enumerator  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate, System.Func<TSource,TResult> selector)
  System.Linq.Enumerable.Iterator<TResult> Clone()
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Collections.Generic.IEnumerable<TResult2> Select(System.Func<TResult,TResult2> selector)
  System.Collections.Generic.IEnumerable<TResult> Where(System.Func<TResult,System.Boolean> predicate)
END_CLASS

CLASS: WhereSelectArrayIterator`2
TYPE:  class
TOKEN: 0x2000022
EXTENDS: Iterator`1
FIELDS:
  private           TSource[]                       source  // 0x0
  private           System.Func<TSource,System.Boolean>predicate  // 0x0
  private           System.Func<TSource,TResult>    selector  // 0x0
  private           System.Int32                    index  // 0x0
METHODS:
  System.Void .ctor(TSource[] source, System.Func<TSource,System.Boolean> predicate, System.Func<TSource,TResult> selector)
  System.Linq.Enumerable.Iterator<TResult> Clone()
  System.Boolean MoveNext()
  System.Collections.Generic.IEnumerable<TResult2> Select(System.Func<TResult,TResult2> selector)
  System.Collections.Generic.IEnumerable<TResult> Where(System.Func<TResult,System.Boolean> predicate)
END_CLASS

CLASS: WhereSelectListIterator`2
TYPE:  class
TOKEN: 0x2000023
EXTENDS: Iterator`1
FIELDS:
  private           System.Collections.Generic.List<TSource>source  // 0x0
  private           System.Func<TSource,System.Boolean>predicate  // 0x0
  private           System.Func<TSource,TResult>    selector  // 0x0
  private           System.Collections.Generic.List.Enumerator<TSource>enumerator  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.List<TSource> source, System.Func<TSource,System.Boolean> predicate, System.Func<TSource,TResult> selector)
  System.Linq.Enumerable.Iterator<TResult> Clone()
  System.Boolean MoveNext()
  System.Collections.Generic.IEnumerable<TResult2> Select(System.Func<TResult,TResult2> selector)
  System.Collections.Generic.IEnumerable<TResult> Where(System.Func<TResult,System.Boolean> predicate)
END_CLASS

CLASS: Grouping
TYPE:  class
TOKEN: 0x200003B
FIELDS:
  private           TKey                            key  // 0x0
  private           System.Int32                    hashCode  // 0x0
  private           TElement[]                      elements  // 0x0
  private           System.Int32                    count  // 0x0
  private           System.Linq.Lookup.Grouping<TKey,TElement>hashNext  // 0x0
  private           System.Linq.Lookup.Grouping<TKey,TElement>next  // 0x0
METHODS:
  System.Void Add(TElement element)
  System.Collections.Generic.IEnumerator<TElement> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  TKey get_Key()
  System.Int32 System.Collections.Generic.ICollection<TElement>.get_Count()
  System.Boolean System.Collections.Generic.ICollection<TElement>.get_IsReadOnly()
  System.Void System.Collections.Generic.ICollection<TElement>.Add(TElement item)
  System.Void System.Collections.Generic.ICollection<TElement>.Clear()
  System.Boolean System.Collections.Generic.ICollection<TElement>.Contains(TElement item)
  System.Void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, System.Int32 arrayIndex)
  System.Boolean System.Collections.Generic.ICollection<TElement>.Remove(TElement item)
  System.Int32 System.Collections.Generic.IList<TElement>.IndexOf(TElement item)
  System.Void System.Collections.Generic.IList<TElement>.Insert(System.Int32 index, TElement item)
  System.Void System.Collections.Generic.IList<TElement>.RemoveAt(System.Int32 index)
  TElement System.Collections.Generic.IList<TElement>.get_Item(System.Int32 index)
  System.Void System.Collections.Generic.IList<TElement>.set_Item(System.Int32 index, TElement value)
  System.Void .ctor()
END_CLASS

CLASS: Slot
TYPE:  struct
TOKEN: 0x200003F
FIELDS:
  private           System.Int32                    hashCode  // 0x0
  private           TElement                        value  // 0x0
  private           System.Int32                    next  // 0x0
METHODS:
END_CLASS

CLASS: BinaryExpressionProxy
TYPE:  class
TOKEN: 0x2000050
FIELDS:
METHODS:
END_CLASS

CLASS: BlockExpressionProxy
TYPE:  class
TOKEN: 0x2000051
FIELDS:
METHODS:
END_CLASS

CLASS: CatchBlockProxy
TYPE:  class
TOKEN: 0x2000052
FIELDS:
METHODS:
END_CLASS

CLASS: ConditionalExpressionProxy
TYPE:  class
TOKEN: 0x2000053
FIELDS:
METHODS:
END_CLASS

CLASS: ConstantExpressionProxy
TYPE:  class
TOKEN: 0x2000054
FIELDS:
METHODS:
END_CLASS

CLASS: DebugInfoExpressionProxy
TYPE:  class
TOKEN: 0x2000055
FIELDS:
METHODS:
END_CLASS

CLASS: DefaultExpressionProxy
TYPE:  class
TOKEN: 0x2000056
FIELDS:
METHODS:
END_CLASS

CLASS: GotoExpressionProxy
TYPE:  class
TOKEN: 0x2000057
FIELDS:
METHODS:
END_CLASS

CLASS: IndexExpressionProxy
TYPE:  class
TOKEN: 0x2000058
FIELDS:
METHODS:
END_CLASS

CLASS: InvocationExpressionProxy
TYPE:  class
TOKEN: 0x2000059
FIELDS:
METHODS:
END_CLASS

CLASS: LabelExpressionProxy
TYPE:  class
TOKEN: 0x200005A
FIELDS:
METHODS:
END_CLASS

CLASS: LambdaExpressionProxy
TYPE:  class
TOKEN: 0x200005B
FIELDS:
METHODS:
END_CLASS

CLASS: ListInitExpressionProxy
TYPE:  class
TOKEN: 0x200005C
FIELDS:
METHODS:
END_CLASS

CLASS: LoopExpressionProxy
TYPE:  class
TOKEN: 0x200005D
FIELDS:
METHODS:
END_CLASS

CLASS: MemberExpressionProxy
TYPE:  class
TOKEN: 0x200005E
FIELDS:
METHODS:
END_CLASS

CLASS: MemberInitExpressionProxy
TYPE:  class
TOKEN: 0x200005F
FIELDS:
METHODS:
END_CLASS

CLASS: MethodCallExpressionProxy
TYPE:  class
TOKEN: 0x2000060
FIELDS:
METHODS:
END_CLASS

CLASS: NewArrayExpressionProxy
TYPE:  class
TOKEN: 0x2000061
FIELDS:
METHODS:
END_CLASS

CLASS: NewExpressionProxy
TYPE:  class
TOKEN: 0x2000062
FIELDS:
METHODS:
END_CLASS

CLASS: ParameterExpressionProxy
TYPE:  class
TOKEN: 0x2000063
FIELDS:
METHODS:
END_CLASS

CLASS: RuntimeVariablesExpressionProxy
TYPE:  class
TOKEN: 0x2000064
FIELDS:
METHODS:
END_CLASS

CLASS: SwitchCaseProxy
TYPE:  class
TOKEN: 0x2000065
FIELDS:
METHODS:
END_CLASS

CLASS: SwitchExpressionProxy
TYPE:  class
TOKEN: 0x2000066
FIELDS:
METHODS:
END_CLASS

CLASS: TryExpressionProxy
TYPE:  class
TOKEN: 0x2000067
FIELDS:
METHODS:
END_CLASS

CLASS: TypeBinaryExpressionProxy
TYPE:  class
TOKEN: 0x2000068
FIELDS:
METHODS:
END_CLASS

CLASS: UnaryExpressionProxy
TYPE:  class
TOKEN: 0x2000069
FIELDS:
METHODS:
END_CLASS

CLASS: ExtensionInfo
TYPE:  class
TOKEN: 0x200006A
FIELDS:
  private   readonly System.Linq.Expressions.ExpressionTypeNodeType  // 0x10
  private   readonly System.Type                     Type  // 0x18
METHODS:
END_CLASS

CLASS: AddInt16
TYPE:  class
TOKEN: 0x20000CC
EXTENDS: AddInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AddInt32
TYPE:  class
TOKEN: 0x20000CD
EXTENDS: AddInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AddInt64
TYPE:  class
TOKEN: 0x20000CE
EXTENDS: AddInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AddUInt16
TYPE:  class
TOKEN: 0x20000CF
EXTENDS: AddInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AddUInt32
TYPE:  class
TOKEN: 0x20000D0
EXTENDS: AddInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AddUInt64
TYPE:  class
TOKEN: 0x20000D1
EXTENDS: AddInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AddSingle
TYPE:  class
TOKEN: 0x20000D2
EXTENDS: AddInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AddDouble
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: AddInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AddOvfInt16
TYPE:  class
TOKEN: 0x20000D5
EXTENDS: AddOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AddOvfInt32
TYPE:  class
TOKEN: 0x20000D6
EXTENDS: AddOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AddOvfInt64
TYPE:  class
TOKEN: 0x20000D7
EXTENDS: AddOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AddOvfUInt16
TYPE:  class
TOKEN: 0x20000D8
EXTENDS: AddOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AddOvfUInt32
TYPE:  class
TOKEN: 0x20000D9
EXTENDS: AddOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AddOvfUInt64
TYPE:  class
TOKEN: 0x20000DA
EXTENDS: AddOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AndSByte
TYPE:  class
TOKEN: 0x20000DC
EXTENDS: AndInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AndInt16
TYPE:  class
TOKEN: 0x20000DD
EXTENDS: AndInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AndInt32
TYPE:  class
TOKEN: 0x20000DE
EXTENDS: AndInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AndInt64
TYPE:  class
TOKEN: 0x20000DF
EXTENDS: AndInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AndByte
TYPE:  class
TOKEN: 0x20000E0
EXTENDS: AndInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AndUInt16
TYPE:  class
TOKEN: 0x20000E1
EXTENDS: AndInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AndUInt32
TYPE:  class
TOKEN: 0x20000E2
EXTENDS: AndInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AndUInt64
TYPE:  class
TOKEN: 0x20000E3
EXTENDS: AndInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: AndBoolean
TYPE:  class
TOKEN: 0x20000E4
EXTENDS: AndInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DecrementInt16
TYPE:  class
TOKEN: 0x2000106
EXTENDS: DecrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DecrementInt32
TYPE:  class
TOKEN: 0x2000107
EXTENDS: DecrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DecrementInt64
TYPE:  class
TOKEN: 0x2000108
EXTENDS: DecrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DecrementUInt16
TYPE:  class
TOKEN: 0x2000109
EXTENDS: DecrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DecrementUInt32
TYPE:  class
TOKEN: 0x200010A
EXTENDS: DecrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DecrementUInt64
TYPE:  class
TOKEN: 0x200010B
EXTENDS: DecrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DecrementSingle
TYPE:  class
TOKEN: 0x200010C
EXTENDS: DecrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DecrementDouble
TYPE:  class
TOKEN: 0x200010D
EXTENDS: DecrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DivInt16
TYPE:  class
TOKEN: 0x2000110
EXTENDS: DivInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DivInt32
TYPE:  class
TOKEN: 0x2000111
EXTENDS: DivInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DivInt64
TYPE:  class
TOKEN: 0x2000112
EXTENDS: DivInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DivUInt16
TYPE:  class
TOKEN: 0x2000113
EXTENDS: DivInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DivUInt32
TYPE:  class
TOKEN: 0x2000114
EXTENDS: DivInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DivUInt64
TYPE:  class
TOKEN: 0x2000115
EXTENDS: DivInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DivSingle
TYPE:  class
TOKEN: 0x2000116
EXTENDS: DivInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DivDouble
TYPE:  class
TOKEN: 0x2000117
EXTENDS: DivInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualBoolean
TYPE:  class
TOKEN: 0x2000119
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualSByte
TYPE:  class
TOKEN: 0x200011A
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualInt16
TYPE:  class
TOKEN: 0x200011B
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualChar
TYPE:  class
TOKEN: 0x200011C
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualInt32
TYPE:  class
TOKEN: 0x200011D
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualInt64
TYPE:  class
TOKEN: 0x200011E
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualByte
TYPE:  class
TOKEN: 0x200011F
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualUInt16
TYPE:  class
TOKEN: 0x2000120
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualUInt32
TYPE:  class
TOKEN: 0x2000121
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualUInt64
TYPE:  class
TOKEN: 0x2000122
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualSingle
TYPE:  class
TOKEN: 0x2000123
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualDouble
TYPE:  class
TOKEN: 0x2000124
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualReference
TYPE:  class
TOKEN: 0x2000125
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualBooleanLiftedToNull
TYPE:  class
TOKEN: 0x2000126
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualSByteLiftedToNull
TYPE:  class
TOKEN: 0x2000127
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualInt16LiftedToNull
TYPE:  class
TOKEN: 0x2000128
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualCharLiftedToNull
TYPE:  class
TOKEN: 0x2000129
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualInt32LiftedToNull
TYPE:  class
TOKEN: 0x200012A
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualInt64LiftedToNull
TYPE:  class
TOKEN: 0x200012B
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualByteLiftedToNull
TYPE:  class
TOKEN: 0x200012C
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualUInt16LiftedToNull
TYPE:  class
TOKEN: 0x200012D
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualUInt32LiftedToNull
TYPE:  class
TOKEN: 0x200012E
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualUInt64LiftedToNull
TYPE:  class
TOKEN: 0x200012F
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualSingleLiftedToNull
TYPE:  class
TOKEN: 0x2000130
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualDoubleLiftedToNull
TYPE:  class
TOKEN: 0x2000131
EXTENDS: EqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ExclusiveOrSByte
TYPE:  class
TOKEN: 0x2000133
EXTENDS: ExclusiveOrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ExclusiveOrInt16
TYPE:  class
TOKEN: 0x2000134
EXTENDS: ExclusiveOrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ExclusiveOrInt32
TYPE:  class
TOKEN: 0x2000135
EXTENDS: ExclusiveOrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ExclusiveOrInt64
TYPE:  class
TOKEN: 0x2000136
EXTENDS: ExclusiveOrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ExclusiveOrByte
TYPE:  class
TOKEN: 0x2000137
EXTENDS: ExclusiveOrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ExclusiveOrUInt16
TYPE:  class
TOKEN: 0x2000138
EXTENDS: ExclusiveOrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ExclusiveOrUInt32
TYPE:  class
TOKEN: 0x2000139
EXTENDS: ExclusiveOrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ExclusiveOrUInt64
TYPE:  class
TOKEN: 0x200013A
EXTENDS: ExclusiveOrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ExclusiveOrBoolean
TYPE:  class
TOKEN: 0x200013B
EXTENDS: ExclusiveOrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: GreaterThanSByte
TYPE:  class
TOKEN: 0x2000142
EXTENDS: GreaterThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanInt16
TYPE:  class
TOKEN: 0x2000143
EXTENDS: GreaterThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanChar
TYPE:  class
TOKEN: 0x2000144
EXTENDS: GreaterThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanInt32
TYPE:  class
TOKEN: 0x2000145
EXTENDS: GreaterThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanInt64
TYPE:  class
TOKEN: 0x2000146
EXTENDS: GreaterThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanByte
TYPE:  class
TOKEN: 0x2000147
EXTENDS: GreaterThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanUInt16
TYPE:  class
TOKEN: 0x2000148
EXTENDS: GreaterThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanUInt32
TYPE:  class
TOKEN: 0x2000149
EXTENDS: GreaterThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanUInt64
TYPE:  class
TOKEN: 0x200014A
EXTENDS: GreaterThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanSingle
TYPE:  class
TOKEN: 0x200014B
EXTENDS: GreaterThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanDouble
TYPE:  class
TOKEN: 0x200014C
EXTENDS: GreaterThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanOrEqualSByte
TYPE:  class
TOKEN: 0x200014E
EXTENDS: GreaterThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanOrEqualInt16
TYPE:  class
TOKEN: 0x200014F
EXTENDS: GreaterThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanOrEqualChar
TYPE:  class
TOKEN: 0x2000150
EXTENDS: GreaterThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanOrEqualInt32
TYPE:  class
TOKEN: 0x2000151
EXTENDS: GreaterThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanOrEqualInt64
TYPE:  class
TOKEN: 0x2000152
EXTENDS: GreaterThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanOrEqualByte
TYPE:  class
TOKEN: 0x2000153
EXTENDS: GreaterThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanOrEqualUInt16
TYPE:  class
TOKEN: 0x2000154
EXTENDS: GreaterThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanOrEqualUInt32
TYPE:  class
TOKEN: 0x2000155
EXTENDS: GreaterThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanOrEqualUInt64
TYPE:  class
TOKEN: 0x2000156
EXTENDS: GreaterThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanOrEqualSingle
TYPE:  class
TOKEN: 0x2000157
EXTENDS: GreaterThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GreaterThanOrEqualDouble
TYPE:  class
TOKEN: 0x2000158
EXTENDS: GreaterThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: IncrementInt16
TYPE:  class
TOKEN: 0x200015A
EXTENDS: IncrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: IncrementInt32
TYPE:  class
TOKEN: 0x200015B
EXTENDS: IncrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: IncrementInt64
TYPE:  class
TOKEN: 0x200015C
EXTENDS: IncrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: IncrementUInt16
TYPE:  class
TOKEN: 0x200015D
EXTENDS: IncrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: IncrementUInt32
TYPE:  class
TOKEN: 0x200015E
EXTENDS: IncrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: IncrementUInt64
TYPE:  class
TOKEN: 0x200015F
EXTENDS: IncrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: IncrementSingle
TYPE:  class
TOKEN: 0x2000160
EXTENDS: IncrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: IncrementDouble
TYPE:  class
TOKEN: 0x2000161
EXTENDS: IncrementInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: DebugView
TYPE:  class
TOKEN: 0x2000164
FIELDS:
  private   readonly System.Linq.Expressions.Interpreter.InstructionArray_array  // 0x10
METHODS:
  System.Void .ctor(System.Linq.Expressions.Interpreter.InstructionArray array)
  System.Linq.Expressions.Interpreter.InstructionList.DebugView.InstructionView[] GetInstructionViews(System.Boolean includeDebugCookies)
  System.Int32 <GetInstructionViews>b__4_0(System.Int32 index)
END_CLASS

CLASS: InstructionView
TYPE:  struct
TOKEN: 0x2000167
FIELDS:
  private   readonly System.Int32                    _index  // 0x10
  private   readonly System.Int32                    _stackDepth  // 0x14
  private   readonly System.Int32                    _continuationsDepth  // 0x18
  private   readonly System.String                   _name  // 0x20
  private   readonly System.Linq.Expressions.Interpreter.Instruction_instruction  // 0x28
METHODS:
  System.String GetValue()
  System.Void .ctor(System.Linq.Expressions.Interpreter.Instruction instruction, System.String name, System.Int32 index, System.Int32 stackDepth, System.Int32 continuationsDepth)
END_CLASS

CLASS: DebugView
TYPE:  class
TOKEN: 0x2000166
FIELDS:
METHODS:
  System.Linq.Expressions.Interpreter.InstructionList.DebugView.InstructionView[] GetInstructionViews(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Interpreter.Instruction> instructions, System.Collections.Generic.IReadOnlyList<System.Object> objects, System.Func<System.Int32,System.Int32> labelIndexer, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.KeyValuePair<System.Int32,System.Object>> debugCookies)
END_CLASS

CLASS: LeftShiftSByte
TYPE:  class
TOKEN: 0x2000170
EXTENDS: LeftShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: LeftShiftInt16
TYPE:  class
TOKEN: 0x2000171
EXTENDS: LeftShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: LeftShiftInt32
TYPE:  class
TOKEN: 0x2000172
EXTENDS: LeftShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: LeftShiftInt64
TYPE:  class
TOKEN: 0x2000173
EXTENDS: LeftShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: LeftShiftByte
TYPE:  class
TOKEN: 0x2000174
EXTENDS: LeftShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: LeftShiftUInt16
TYPE:  class
TOKEN: 0x2000175
EXTENDS: LeftShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: LeftShiftUInt32
TYPE:  class
TOKEN: 0x2000176
EXTENDS: LeftShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: LeftShiftUInt64
TYPE:  class
TOKEN: 0x2000177
EXTENDS: LeftShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: LessThanSByte
TYPE:  class
TOKEN: 0x2000179
EXTENDS: LessThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanInt16
TYPE:  class
TOKEN: 0x200017A
EXTENDS: LessThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanChar
TYPE:  class
TOKEN: 0x200017B
EXTENDS: LessThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanInt32
TYPE:  class
TOKEN: 0x200017C
EXTENDS: LessThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanInt64
TYPE:  class
TOKEN: 0x200017D
EXTENDS: LessThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanByte
TYPE:  class
TOKEN: 0x200017E
EXTENDS: LessThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanUInt16
TYPE:  class
TOKEN: 0x200017F
EXTENDS: LessThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanUInt32
TYPE:  class
TOKEN: 0x2000180
EXTENDS: LessThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanUInt64
TYPE:  class
TOKEN: 0x2000181
EXTENDS: LessThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanSingle
TYPE:  class
TOKEN: 0x2000182
EXTENDS: LessThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanDouble
TYPE:  class
TOKEN: 0x2000183
EXTENDS: LessThanInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanOrEqualSByte
TYPE:  class
TOKEN: 0x2000185
EXTENDS: LessThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanOrEqualInt16
TYPE:  class
TOKEN: 0x2000186
EXTENDS: LessThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanOrEqualChar
TYPE:  class
TOKEN: 0x2000187
EXTENDS: LessThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanOrEqualInt32
TYPE:  class
TOKEN: 0x2000188
EXTENDS: LessThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanOrEqualInt64
TYPE:  class
TOKEN: 0x2000189
EXTENDS: LessThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanOrEqualByte
TYPE:  class
TOKEN: 0x200018A
EXTENDS: LessThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanOrEqualUInt16
TYPE:  class
TOKEN: 0x200018B
EXTENDS: LessThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanOrEqualUInt32
TYPE:  class
TOKEN: 0x200018C
EXTENDS: LessThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanOrEqualUInt64
TYPE:  class
TOKEN: 0x200018D
EXTENDS: LessThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanOrEqualSingle
TYPE:  class
TOKEN: 0x200018E
EXTENDS: LessThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: LessThanOrEqualDouble
TYPE:  class
TOKEN: 0x200018F
EXTENDS: LessThanOrEqualInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Object nullValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: DebugInfoComparer
TYPE:  class
TOKEN: 0x2000196
FIELDS:
METHODS:
  System.Int32 System.Collections.Generic.IComparer<System.Linq.Expressions.Interpreter.DebugInfo>.Compare(System.Linq.Expressions.Interpreter.DebugInfo d1, System.Linq.Expressions.Interpreter.DebugInfo d2)
  System.Void .ctor()
END_CLASS

CLASS: QuoteVisitor
TYPE:  class
TOKEN: 0x2000199
EXTENDS: ExpressionVisitor
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Int32>_definedParameters  // 0x10
  public    readonly System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>_hoistedParameters  // 0x18
METHODS:
  System.Linq.Expressions.Expression VisitParameter(System.Linq.Expressions.ParameterExpression node)
  System.Linq.Expressions.Expression VisitBlock(System.Linq.Expressions.BlockExpression node)
  System.Linq.Expressions.CatchBlock VisitCatchBlock(System.Linq.Expressions.CatchBlock node)
  System.Linq.Expressions.Expression VisitLambda(System.Linq.Expressions.Expression<T> node)
  System.Void PushParameters(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters)
  System.Void PopParameters(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters)
  System.Void .ctor()
END_CLASS

CLASS: DebugViewPrinter
TYPE:  class
TOKEN: 0x20001A3
FIELDS:
  private   readonly System.Linq.Expressions.Interpreter.Interpreter_interpreter  // 0x10
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Int32>_tryStart  // 0x18
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.String>_handlerEnter  // 0x20
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Int32>_handlerExit  // 0x28
  private           System.String                   _indent  // 0x30
METHODS:
  System.Void .ctor(System.Linq.Expressions.Interpreter.Interpreter interpreter)
  System.Void Analyze()
  System.Void AddTryStart(System.Int32 index)
  System.Void AddHandlerExit(System.Int32 index)
  System.Void Indent()
  System.Void Dedent()
  System.String ToString()
  System.Void EmitExits(System.Text.StringBuilder sb, System.Int32 index)
END_CLASS

CLASS: Reference
TYPE:  class
TOKEN: 0x20001B2
EXTENDS: InitializeLocalInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 index)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index)
  System.String get_InstructionName()
END_CLASS

CLASS: ImmutableValue
TYPE:  class
TOKEN: 0x20001B3
EXTENDS: InitializeLocalInstruction
FIELDS:
  private   readonly System.Object                   _defaultValue  // 0x18
METHODS:
  System.Void .ctor(System.Int32 index, System.Object defaultValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index)
  System.String get_InstructionName()
END_CLASS

CLASS: ImmutableBox
TYPE:  class
TOKEN: 0x20001B4
EXTENDS: InitializeLocalInstruction
FIELDS:
  private   readonly System.Object                   _defaultValue  // 0x18
METHODS:
  System.Void .ctor(System.Int32 index, System.Object defaultValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.String get_InstructionName()
END_CLASS

CLASS: ImmutableRefBox
TYPE:  class
TOKEN: 0x20001B5
EXTENDS: InitializeLocalInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 index)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.String get_InstructionName()
END_CLASS

CLASS: ParameterBox
TYPE:  class
TOKEN: 0x20001B6
EXTENDS: InitializeLocalInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 index)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.String get_InstructionName()
END_CLASS

CLASS: Parameter
TYPE:  class
TOKEN: 0x20001B7
EXTENDS: InitializeLocalInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 index)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index)
  System.String get_InstructionName()
END_CLASS

CLASS: MutableValue
TYPE:  class
TOKEN: 0x20001B8
EXTENDS: InitializeLocalInstruction
FIELDS:
  private   readonly System.Type                     _type  // 0x18
METHODS:
  System.Void .ctor(System.Int32 index, System.Type type)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index)
  System.String get_InstructionName()
END_CLASS

CLASS: MutableBox
TYPE:  class
TOKEN: 0x20001B9
EXTENDS: InitializeLocalInstruction
FIELDS:
  private   readonly System.Type                     _type  // 0x18
METHODS:
  System.Void .ctor(System.Int32 index, System.Type type)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.String get_InstructionName()
END_CLASS

CLASS: VariableScope
TYPE:  class
TOKEN: 0x20001BE
FIELDS:
  public    readonly System.Int32                    Start  // 0x10
  public            System.Int32                    Stop  // 0x14
  public    readonly System.Linq.Expressions.Interpreter.LocalVariableVariable  // 0x18
  public    readonly System.Linq.Expressions.Interpreter.LocalVariables.VariableScopeParent  // 0x20
  public            System.Collections.Generic.List<System.Linq.Expressions.Interpreter.LocalVariables.VariableScope>ChildScopes  // 0x28
METHODS:
  System.Void .ctor(System.Linq.Expressions.Interpreter.LocalVariable variable, System.Int32 start, System.Linq.Expressions.Interpreter.LocalVariables.VariableScope parent)
END_CLASS

CLASS: ModuloInt16
TYPE:  class
TOKEN: 0x20001C0
EXTENDS: ModuloInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ModuloInt32
TYPE:  class
TOKEN: 0x20001C1
EXTENDS: ModuloInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ModuloInt64
TYPE:  class
TOKEN: 0x20001C2
EXTENDS: ModuloInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ModuloUInt16
TYPE:  class
TOKEN: 0x20001C3
EXTENDS: ModuloInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ModuloUInt32
TYPE:  class
TOKEN: 0x20001C4
EXTENDS: ModuloInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ModuloUInt64
TYPE:  class
TOKEN: 0x20001C5
EXTENDS: ModuloInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ModuloSingle
TYPE:  class
TOKEN: 0x20001C6
EXTENDS: ModuloInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ModuloDouble
TYPE:  class
TOKEN: 0x20001C7
EXTENDS: ModuloInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: MulInt16
TYPE:  class
TOKEN: 0x20001C9
EXTENDS: MulInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: MulInt32
TYPE:  class
TOKEN: 0x20001CA
EXTENDS: MulInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: MulInt64
TYPE:  class
TOKEN: 0x20001CB
EXTENDS: MulInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: MulUInt16
TYPE:  class
TOKEN: 0x20001CC
EXTENDS: MulInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: MulUInt32
TYPE:  class
TOKEN: 0x20001CD
EXTENDS: MulInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: MulUInt64
TYPE:  class
TOKEN: 0x20001CE
EXTENDS: MulInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: MulSingle
TYPE:  class
TOKEN: 0x20001CF
EXTENDS: MulInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: MulDouble
TYPE:  class
TOKEN: 0x20001D0
EXTENDS: MulInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: MulOvfInt16
TYPE:  class
TOKEN: 0x20001D2
EXTENDS: MulOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: MulOvfInt32
TYPE:  class
TOKEN: 0x20001D3
EXTENDS: MulOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: MulOvfInt64
TYPE:  class
TOKEN: 0x20001D4
EXTENDS: MulOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: MulOvfUInt16
TYPE:  class
TOKEN: 0x20001D5
EXTENDS: MulOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: MulOvfUInt32
TYPE:  class
TOKEN: 0x20001D6
EXTENDS: MulOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: MulOvfUInt64
TYPE:  class
TOKEN: 0x20001D7
EXTENDS: MulOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NegateInt16
TYPE:  class
TOKEN: 0x20001D9
EXTENDS: NegateInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NegateInt32
TYPE:  class
TOKEN: 0x20001DA
EXTENDS: NegateInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NegateInt64
TYPE:  class
TOKEN: 0x20001DB
EXTENDS: NegateInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NegateSingle
TYPE:  class
TOKEN: 0x20001DC
EXTENDS: NegateInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NegateDouble
TYPE:  class
TOKEN: 0x20001DD
EXTENDS: NegateInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NegateCheckedInt32
TYPE:  class
TOKEN: 0x20001DF
EXTENDS: NegateCheckedInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NegateCheckedInt16
TYPE:  class
TOKEN: 0x20001E0
EXTENDS: NegateCheckedInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NegateCheckedInt64
TYPE:  class
TOKEN: 0x20001E1
EXTENDS: NegateCheckedInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualBoolean
TYPE:  class
TOKEN: 0x20001E5
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualSByte
TYPE:  class
TOKEN: 0x20001E6
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualInt16
TYPE:  class
TOKEN: 0x20001E7
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualChar
TYPE:  class
TOKEN: 0x20001E8
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualInt32
TYPE:  class
TOKEN: 0x20001E9
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualInt64
TYPE:  class
TOKEN: 0x20001EA
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualByte
TYPE:  class
TOKEN: 0x20001EB
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualUInt16
TYPE:  class
TOKEN: 0x20001EC
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualUInt32
TYPE:  class
TOKEN: 0x20001ED
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualUInt64
TYPE:  class
TOKEN: 0x20001EE
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualSingle
TYPE:  class
TOKEN: 0x20001EF
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualDouble
TYPE:  class
TOKEN: 0x20001F0
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualReference
TYPE:  class
TOKEN: 0x20001F1
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualSByteLiftedToNull
TYPE:  class
TOKEN: 0x20001F2
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualInt16LiftedToNull
TYPE:  class
TOKEN: 0x20001F3
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualCharLiftedToNull
TYPE:  class
TOKEN: 0x20001F4
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualInt32LiftedToNull
TYPE:  class
TOKEN: 0x20001F5
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualInt64LiftedToNull
TYPE:  class
TOKEN: 0x20001F6
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualByteLiftedToNull
TYPE:  class
TOKEN: 0x20001F7
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualUInt16LiftedToNull
TYPE:  class
TOKEN: 0x20001F8
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualUInt32LiftedToNull
TYPE:  class
TOKEN: 0x20001F9
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualUInt64LiftedToNull
TYPE:  class
TOKEN: 0x20001FA
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualSingleLiftedToNull
TYPE:  class
TOKEN: 0x20001FB
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotEqualDoubleLiftedToNull
TYPE:  class
TOKEN: 0x20001FC
EXTENDS: NotEqualInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotBoolean
TYPE:  class
TOKEN: 0x20001FE
EXTENDS: NotInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotInt64
TYPE:  class
TOKEN: 0x20001FF
EXTENDS: NotInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotInt32
TYPE:  class
TOKEN: 0x2000200
EXTENDS: NotInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotInt16
TYPE:  class
TOKEN: 0x2000201
EXTENDS: NotInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotUInt64
TYPE:  class
TOKEN: 0x2000202
EXTENDS: NotInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotUInt32
TYPE:  class
TOKEN: 0x2000203
EXTENDS: NotInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotUInt16
TYPE:  class
TOKEN: 0x2000204
EXTENDS: NotInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotByte
TYPE:  class
TOKEN: 0x2000205
EXTENDS: NotInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: NotSByte
TYPE:  class
TOKEN: 0x2000206
EXTENDS: NotInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: Unchecked
TYPE:  class
TOKEN: 0x2000209
EXTENDS: NumericConvertInstruction
FIELDS:
METHODS:
  System.String get_InstructionName()
  System.Void .ctor(System.TypeCode from, System.TypeCode to, System.Boolean isLiftedToNull)
  System.Object Convert(System.Object obj)
  System.Object ConvertInt32(System.Int32 obj)
  System.Object ConvertInt64(System.Int64 obj)
  System.Object ConvertUInt64(System.UInt64 obj)
  System.Object ConvertDouble(System.Double obj)
END_CLASS

CLASS: Checked
TYPE:  class
TOKEN: 0x200020A
EXTENDS: NumericConvertInstruction
FIELDS:
METHODS:
  System.String get_InstructionName()
  System.Void .ctor(System.TypeCode from, System.TypeCode to, System.Boolean isLiftedToNull)
  System.Object Convert(System.Object obj)
  System.Object ConvertInt32(System.Int32 obj)
  System.Object ConvertInt64(System.Int64 obj)
  System.Object ConvertUInt64(System.UInt64 obj)
  System.Object ConvertDouble(System.Double obj)
END_CLASS

CLASS: ToUnderlying
TYPE:  class
TOKEN: 0x200020B
EXTENDS: NumericConvertInstruction
FIELDS:
METHODS:
  System.String get_InstructionName()
  System.Void .ctor(System.TypeCode to, System.Boolean isLiftedToNull)
  System.Object Convert(System.Object obj)
END_CLASS

CLASS: OrSByte
TYPE:  class
TOKEN: 0x200020D
EXTENDS: OrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: OrInt16
TYPE:  class
TOKEN: 0x200020E
EXTENDS: OrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: OrInt32
TYPE:  class
TOKEN: 0x200020F
EXTENDS: OrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: OrInt64
TYPE:  class
TOKEN: 0x2000210
EXTENDS: OrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: OrByte
TYPE:  class
TOKEN: 0x2000211
EXTENDS: OrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: OrUInt16
TYPE:  class
TOKEN: 0x2000212
EXTENDS: OrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: OrUInt32
TYPE:  class
TOKEN: 0x2000213
EXTENDS: OrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: OrUInt64
TYPE:  class
TOKEN: 0x2000214
EXTENDS: OrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: OrBoolean
TYPE:  class
TOKEN: 0x2000215
EXTENDS: OrInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: RightShiftSByte
TYPE:  class
TOKEN: 0x2000217
EXTENDS: RightShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: RightShiftInt16
TYPE:  class
TOKEN: 0x2000218
EXTENDS: RightShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: RightShiftInt32
TYPE:  class
TOKEN: 0x2000219
EXTENDS: RightShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: RightShiftInt64
TYPE:  class
TOKEN: 0x200021A
EXTENDS: RightShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: RightShiftByte
TYPE:  class
TOKEN: 0x200021B
EXTENDS: RightShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: RightShiftUInt16
TYPE:  class
TOKEN: 0x200021C
EXTENDS: RightShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: RightShiftUInt32
TYPE:  class
TOKEN: 0x200021D
EXTENDS: RightShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: RightShiftUInt64
TYPE:  class
TOKEN: 0x200021E
EXTENDS: RightShiftInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: SubInt16
TYPE:  class
TOKEN: 0x2000225
EXTENDS: SubInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: SubInt32
TYPE:  class
TOKEN: 0x2000226
EXTENDS: SubInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: SubInt64
TYPE:  class
TOKEN: 0x2000227
EXTENDS: SubInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: SubUInt16
TYPE:  class
TOKEN: 0x2000228
EXTENDS: SubInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: SubUInt32
TYPE:  class
TOKEN: 0x2000229
EXTENDS: SubInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: SubUInt64
TYPE:  class
TOKEN: 0x200022A
EXTENDS: SubInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: SubSingle
TYPE:  class
TOKEN: 0x200022B
EXTENDS: SubInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: SubDouble
TYPE:  class
TOKEN: 0x200022C
EXTENDS: SubInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: SubOvfInt16
TYPE:  class
TOKEN: 0x200022E
EXTENDS: SubOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: SubOvfInt32
TYPE:  class
TOKEN: 0x200022F
EXTENDS: SubOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: SubOvfInt64
TYPE:  class
TOKEN: 0x2000230
EXTENDS: SubOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: SubOvfUInt16
TYPE:  class
TOKEN: 0x2000231
EXTENDS: SubOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: SubOvfUInt32
TYPE:  class
TOKEN: 0x2000232
EXTENDS: SubOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: SubOvfUInt64
TYPE:  class
TOKEN: 0x2000233
EXTENDS: SubOvfInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: HasValue
TYPE:  class
TOKEN: 0x2000239
EXTENDS: NullableMethodCallInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: GetValue
TYPE:  class
TOKEN: 0x200023A
EXTENDS: NullableMethodCallInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: GetValueOrDefault
TYPE:  class
TOKEN: 0x200023B
EXTENDS: NullableMethodCallInstruction
FIELDS:
  private   readonly System.Type                     _defaultValueType  // 0x10
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo mi)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: GetValueOrDefault1
TYPE:  class
TOKEN: 0x200023C
EXTENDS: NullableMethodCallInstruction
FIELDS:
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: EqualsClass
TYPE:  class
TOKEN: 0x200023D
EXTENDS: NullableMethodCallInstruction
FIELDS:
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: ToStringClass
TYPE:  class
TOKEN: 0x200023E
EXTENDS: NullableMethodCallInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: GetHashCodeClass
TYPE:  class
TOKEN: 0x200023F
EXTENDS: NullableMethodCallInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: CastInstructionT`1
TYPE:  class
TOKEN: 0x2000241
EXTENDS: CastInstruction
FIELDS:
METHODS:
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: Ref
TYPE:  class
TOKEN: 0x2000243
EXTENDS: CastInstructionNoT
FIELDS:
METHODS:
  System.Void .ctor(System.Type t)
  System.Void ConvertNull(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: Value
TYPE:  class
TOKEN: 0x2000244
EXTENDS: CastInstructionNoT
FIELDS:
METHODS:
  System.Void .ctor(System.Type t)
  System.Void ConvertNull(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: CastInstructionNoT
TYPE:  class
TOKEN: 0x2000242
EXTENDS: CastInstruction
FIELDS:
  private   readonly System.Type                     _t  // 0x10
METHODS:
  System.Void .ctor(System.Type t)
  System.Linq.Expressions.Interpreter.CastInstruction Create(System.Type t)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void ConvertNull(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: ExpressionQuoter
TYPE:  class
TOKEN: 0x2000248
EXTENDS: ExpressionVisitor
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable>_variables  // 0x10
  private   readonly System.Linq.Expressions.Interpreter.InterpretedFrame_frame  // 0x18
  private   readonly System.Collections.Generic.Stack<System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>>_shadowedVars  // 0x20
METHODS:
  System.Void .ctor(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> hoistedVariables, System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Linq.Expressions.Expression VisitLambda(System.Linq.Expressions.Expression<T> node)
  System.Linq.Expressions.Expression VisitBlock(System.Linq.Expressions.BlockExpression node)
  System.Linq.Expressions.CatchBlock VisitCatchBlock(System.Linq.Expressions.CatchBlock node)
  System.Linq.Expressions.Expression VisitParameter(System.Linq.Expressions.ParameterExpression node)
  System.Runtime.CompilerServices.IStrongBox GetBox(System.Linq.Expressions.ParameterExpression variable)
END_CLASS

CLASS: LambdaSignature`1
TYPE:  class
TOKEN: 0x2000254
FIELDS:
  private   static  System.Runtime.CompilerServices.CallSiteBinder.LambdaSignature<T>s_instance  // 0x0
  private   readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>Parameters  // 0x0
  private   readonly System.Linq.Expressions.LabelTargetReturnLabel  // 0x0
METHODS:
  System.Runtime.CompilerServices.CallSiteBinder.LambdaSignature<T> get_Instance()
  System.Void .ctor()
END_CLASS

CLASS: Enumerator
TYPE:  class
TOKEN: 0x2000258
FIELDS:
  private   readonly System.Runtime.CompilerServices.ReadOnlyCollectionBuilder<T>_builder  // 0x0
  private   readonly System.Int32                    _version  // 0x0
  private           System.Int32                    _index  // 0x0
  private           T                               _current  // 0x0
METHODS:
  System.Void .ctor(System.Runtime.CompilerServices.ReadOnlyCollectionBuilder<T> builder)
  T get_Current()
  System.Void Dispose()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Boolean MoveNext()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: AndNode
TYPE:  struct
TOKEN: 0x2000260
FIELDS:
  private           System.Int32                    Depth  // 0x10
  private           System.Linq.Expressions.ExpressionNode  // 0x18
METHODS:
END_CLASS

CLASS: TestBuilder
TYPE:  class
TOKEN: 0x200025F
FIELDS:
  private   readonly System.Collections.Generic.HashSet<System.Dynamic.BindingRestrictions>_unique  // 0x10
  private   readonly System.Collections.Generic.Stack<System.Dynamic.BindingRestrictions.TestBuilder.AndNode>_tests  // 0x18
METHODS:
  System.Void Append(System.Dynamic.BindingRestrictions restrictions)
  System.Linq.Expressions.Expression ToExpression()
  System.Void Push(System.Linq.Expressions.Expression node, System.Int32 depth)
  System.Void .ctor()
END_CLASS

CLASS: MergedRestriction
TYPE:  class
TOKEN: 0x2000261
EXTENDS: BindingRestrictions
FIELDS:
  private   readonly System.Dynamic.BindingRestrictionsLeft  // 0x10
  private   readonly System.Dynamic.BindingRestrictionsRight  // 0x18
METHODS:
  System.Void .ctor(System.Dynamic.BindingRestrictions left, System.Dynamic.BindingRestrictions right)
  System.Linq.Expressions.Expression GetExpression()
END_CLASS

CLASS: CustomRestriction
TYPE:  class
TOKEN: 0x2000262
EXTENDS: BindingRestrictions
FIELDS:
  private   readonly System.Linq.Expressions.Expression_expression  // 0x10
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression expression)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Linq.Expressions.Expression GetExpression()
END_CLASS

CLASS: TypeRestriction
TYPE:  class
TOKEN: 0x2000263
EXTENDS: BindingRestrictions
FIELDS:
  private   readonly System.Linq.Expressions.Expression_expression  // 0x10
  private   readonly System.Type                     _type  // 0x18
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression parameter, System.Type type)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Linq.Expressions.Expression GetExpression()
END_CLASS

CLASS: InstanceRestriction
TYPE:  class
TOKEN: 0x2000264
EXTENDS: BindingRestrictions
FIELDS:
  private   readonly System.Linq.Expressions.Expression_expression  // 0x10
  private   readonly System.Object                   _instance  // 0x18
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression parameter, System.Object instance)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Linq.Expressions.Expression GetExpression()
END_CLASS

CLASS: BindingRestrictionsProxy
TYPE:  class
TOKEN: 0x2000265
FIELDS:
METHODS:
END_CLASS

CLASS: KeyCollectionDebugView
TYPE:  class
TOKEN: 0x200026E
FIELDS:
METHODS:
END_CLASS

CLASS: KeyCollection
TYPE:  class
TOKEN: 0x200026F
FIELDS:
  private   readonly System.Dynamic.ExpandoObject    _expando  // 0x10
  private   readonly System.Int32                    _expandoVersion  // 0x18
  private   readonly System.Int32                    _expandoCount  // 0x1C
  private   readonly System.Dynamic.ExpandoObject.ExpandoData_expandoData  // 0x20
METHODS:
  System.Void .ctor(System.Dynamic.ExpandoObject expando)
  System.Void CheckVersion()
  System.Void Add(System.String item)
  System.Void Clear()
  System.Boolean Contains(System.String item)
  System.Void CopyTo(System.String[] array, System.Int32 arrayIndex)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Boolean Remove(System.String item)
  System.Collections.Generic.IEnumerator<System.String> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: ValueCollectionDebugView
TYPE:  class
TOKEN: 0x2000271
FIELDS:
METHODS:
END_CLASS

CLASS: ValueCollection
TYPE:  class
TOKEN: 0x2000272
FIELDS:
  private   readonly System.Dynamic.ExpandoObject    _expando  // 0x10
  private   readonly System.Int32                    _expandoVersion  // 0x18
  private   readonly System.Int32                    _expandoCount  // 0x1C
  private   readonly System.Dynamic.ExpandoObject.ExpandoData_expandoData  // 0x20
METHODS:
  System.Void .ctor(System.Dynamic.ExpandoObject expando)
  System.Void CheckVersion()
  System.Void Add(System.Object item)
  System.Void Clear()
  System.Boolean Contains(System.Object item)
  System.Void CopyTo(System.Object[] array, System.Int32 arrayIndex)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Boolean Remove(System.Object item)
  System.Collections.Generic.IEnumerator<System.Object> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: MetaExpando
TYPE:  class
TOKEN: 0x2000274
EXTENDS: DynamicMetaObject
FIELDS:
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression expression, System.Dynamic.ExpandoObject value)
  System.Dynamic.DynamicMetaObject BindGetOrInvokeMember(System.Dynamic.DynamicMetaObjectBinder binder, System.String name, System.Boolean ignoreCase, System.Dynamic.DynamicMetaObject fallback, System.Func<System.Dynamic.DynamicMetaObject,System.Dynamic.DynamicMetaObject> fallbackInvoke)
  System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder)
  System.Dynamic.DynamicMetaObject BindInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Dynamic.DynamicMetaObject[] args)
  System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value)
  System.Dynamic.DynamicMetaObject BindDeleteMember(System.Dynamic.DeleteMemberBinder binder)
  System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames()
  System.Dynamic.DynamicMetaObject AddDynamicTestAndDefer(System.Dynamic.DynamicMetaObjectBinder binder, System.Dynamic.ExpandoClass klass, System.Dynamic.ExpandoClass originalClass, System.Dynamic.DynamicMetaObject succeeds)
  System.Dynamic.ExpandoClass GetClassEnsureIndex(System.String name, System.Boolean caseInsensitive, System.Dynamic.ExpandoObject obj, System.Dynamic.ExpandoClass& klass, System.Int32& index)
  System.Linq.Expressions.Expression GetLimitedSelf()
  System.Dynamic.BindingRestrictions GetRestrictions()
  System.Dynamic.ExpandoObject get_Value()
END_CLASS

CLASS: ExpandoData
TYPE:  class
TOKEN: 0x2000277
FIELDS:
  private   static  System.Dynamic.ExpandoObject.ExpandoDataEmpty  // 0x0
  private   readonly System.Dynamic.ExpandoClass     Class  // 0x10
  private   readonly System.Object[]                 _dataArray  // 0x18
  private           System.Int32                    _version  // 0x20
METHODS:
  System.Object get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Object value)
  System.Int32 get_Version()
  System.Int32 get_Length()
  System.Void .ctor()
  System.Void .ctor(System.Dynamic.ExpandoClass klass, System.Object[] data, System.Int32 version)
  System.Dynamic.ExpandoObject.ExpandoData UpdateClass(System.Dynamic.ExpandoClass newClass)
  System.Int32 GetAlignedSize(System.Int32 len)
  System.Void .cctor()
END_CLASS

CLASS: Entry
TYPE:  class
TOKEN: 0x2000282
FIELDS:
  private   readonly System.Int32                    _hash  // 0x0
  private   readonly TKey                            _key  // 0x0
  private   readonly TValue                          _value  // 0x0
METHODS:
  System.Void .ctor(System.Int32 hash, TKey key, TValue value)
END_CLASS

CLASS: ElementCount
TYPE:  struct
TOKEN: 0x2000295
FIELDS:
  private           System.Int32                    uniqueCount  // 0x0
  private           System.Int32                    unfoundCount  // 0x0
METHODS:
END_CLASS

CLASS: Slot
TYPE:  struct
TOKEN: 0x2000296
FIELDS:
  private           System.Int32                    hashCode  // 0x0
  private           System.Int32                    next  // 0x0
  private           T                               value  // 0x0
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000297
FIELDS:
  private           System.Collections.Generic.HashSet<T>_set  // 0x0
  private           System.Int32                    _index  // 0x0
  private           System.Int32                    _version  // 0x0
  private           T                               _current  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.HashSet<T> set)
  System.Void Dispose()
  System.Boolean MoveNext()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void System.Collections.IEnumerator.Reset()
END_CLASS

CLASS: TimeoutTracker
TYPE:  struct
TOKEN: 0x200029D
FIELDS:
  private           System.Int32                    m_total  // 0x10
  private           System.Int32                    m_start  // 0x14
METHODS:
  System.Void .ctor(System.Int32 millisecondsTimeout)
  System.Int32 get_RemainingMilliseconds()
  System.Boolean get_IsExpired()
END_CLASS

CLASS: __StaticArrayInitTypeSize=120
TYPE:  struct
TOKEN: 0x200029F
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=256
TYPE:  struct
TOKEN: 0x20002A0
FIELDS:
METHODS:
END_CLASS

CLASS: __StaticArrayInitTypeSize=1024
TYPE:  struct
TOKEN: 0x20002A1
FIELDS:
METHODS:
END_CLASS

CLASS: Microsoft.Win32.SafeHandles.SafeMemoryMappedFileHandle
TYPE:  class
TOKEN: 0x2000003
EXTENDS: SafeHandleZeroOrMinusOneIsInvalid
FIELDS:
METHODS:
  System.Void .ctor(System.IntPtr preexistingHandle, System.Boolean ownsHandle)
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle
TYPE:  class
TOKEN: 0x2000004
EXTENDS: SafeBuffer
FIELDS:
  private           System.IntPtr                   mmap_handle  // 0x28
METHODS:
  System.Void .ctor(System.IntPtr mmap_handle, System.IntPtr base_address, System.Int64 size)
  System.Void Flush()
  System.Boolean ReleaseHandle()
END_CLASS

CLASS: System.Action`9
TYPE:  class
TOKEN: 0x2000005
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
END_CLASS

CLASS: System.Action`10
TYPE:  class
TOKEN: 0x2000006
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
END_CLASS

CLASS: System.Action`11
TYPE:  class
TOKEN: 0x2000007
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
END_CLASS

CLASS: System.Action`12
TYPE:  class
TOKEN: 0x2000008
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
END_CLASS

CLASS: System.Action`13
TYPE:  class
TOKEN: 0x2000009
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
END_CLASS

CLASS: System.Action`14
TYPE:  class
TOKEN: 0x200000A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
END_CLASS

CLASS: System.Action`15
TYPE:  class
TOKEN: 0x200000B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
END_CLASS

CLASS: System.Action`16
TYPE:  class
TOKEN: 0x200000C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
END_CLASS

CLASS: System.Func`10
TYPE:  class
TOKEN: 0x200000D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
END_CLASS

CLASS: System.Func`11
TYPE:  class
TOKEN: 0x200000E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
END_CLASS

CLASS: System.Func`12
TYPE:  class
TOKEN: 0x200000F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
END_CLASS

CLASS: System.Func`13
TYPE:  class
TOKEN: 0x2000010
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
END_CLASS

CLASS: System.Func`14
TYPE:  class
TOKEN: 0x2000011
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
END_CLASS

CLASS: System.Func`15
TYPE:  class
TOKEN: 0x2000012
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
END_CLASS

CLASS: System.Func`16
TYPE:  class
TOKEN: 0x2000013
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15)
END_CLASS

CLASS: System.Func`17
TYPE:  class
TOKEN: 0x2000014
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
END_CLASS

CLASS: System.MonoUtil
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  public    static readonly System.Boolean                  IsUnix  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: System.Collections.Generic.ArrayBuilder`1
TYPE:  struct
TOKEN: 0x2000292
FIELDS:
  private           T[]                             _array  // 0x0
  private           System.Int32                    _count  // 0x0
METHODS:
  System.Void .ctor(System.Int32 capacity)
  T[] ToArray()
  System.Void UncheckedAdd(T item)
END_CLASS

CLASS: System.Collections.Generic.BitHelper
TYPE:  class
TOKEN: 0x2000293
FIELDS:
  private   readonly System.Int32                    _length  // 0x10
  private   readonly System.Int32*                   _arrayPtr  // 0x18
  private   readonly System.Int32[]                  _array  // 0x20
  private   readonly System.Boolean                  _useStackAlloc  // 0x28
METHODS:
  System.Void .ctor(System.Int32* bitArrayPtr, System.Int32 length)
  System.Void .ctor(System.Int32[] bitArray, System.Int32 length)
  System.Void MarkBit(System.Int32 bitPosition)
  System.Boolean IsMarked(System.Int32 bitPosition)
  System.Int32 ToIntArrayLength(System.Int32 n)
END_CLASS

CLASS: System.Collections.Generic.HashSet`1
TYPE:  class
TOKEN: 0x2000294
FIELDS:
  private   static  System.Int32                    Lower31BitMask  // 0x0
  private   static  System.Int32                    StackAllocThreshold  // 0x0
  private   static  System.Int32                    ShrinkThreshold  // 0x0
  private   static  System.String                   CapacityName  // 0x0
  private   static  System.String                   ElementsName  // 0x0
  private   static  System.String                   ComparerName  // 0x0
  private   static  System.String                   VersionName  // 0x0
  private           System.Int32[]                  _buckets  // 0x0
  private           System.Collections.Generic.HashSet.Slot<T>[]_slots  // 0x0
  private           System.Int32                    _count  // 0x0
  private           System.Int32                    _lastIndex  // 0x0
  private           System.Int32                    _freeList  // 0x0
  private           System.Collections.Generic.IEqualityComparer<T>_comparer  // 0x0
  private           System.Int32                    _version  // 0x0
  private           System.Runtime.Serialization.SerializationInfo_siInfo  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Collections.Generic.IEqualityComparer<T> comparer)
  System.Void .ctor(System.Int32 capacity)
  System.Void .ctor(System.Collections.Generic.IEnumerable<T> collection)
  System.Void .ctor(System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IEqualityComparer<T> comparer)
  System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void CopyFrom(System.Collections.Generic.HashSet<T> source)
  System.Void .ctor(System.Int32 capacity, System.Collections.Generic.IEqualityComparer<T> comparer)
  System.Void System.Collections.Generic.ICollection<T>.Add(T item)
  System.Void Clear()
  System.Boolean Contains(T item)
  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  System.Boolean Remove(T item)
  System.Int32 get_Count()
  System.Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly()
  System.Collections.Generic.HashSet.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
  System.Void OnDeserialization(System.Object sender)
  System.Boolean Add(T item)
  System.Boolean TryGetValue(T equalValue, T& actualValue)
  System.Void UnionWith(System.Collections.Generic.IEnumerable<T> other)
  System.Void IntersectWith(System.Collections.Generic.IEnumerable<T> other)
  System.Void ExceptWith(System.Collections.Generic.IEnumerable<T> other)
  System.Void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> other)
  System.Boolean IsSubsetOf(System.Collections.Generic.IEnumerable<T> other)
  System.Boolean IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other)
  System.Boolean IsSupersetOf(System.Collections.Generic.IEnumerable<T> other)
  System.Boolean IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other)
  System.Boolean Overlaps(System.Collections.Generic.IEnumerable<T> other)
  System.Boolean SetEquals(System.Collections.Generic.IEnumerable<T> other)
  System.Void CopyTo(T[] array)
  System.Void CopyTo(T[] array, System.Int32 arrayIndex, System.Int32 count)
  System.Int32 RemoveWhere(System.Predicate<T> match)
  System.Collections.Generic.IEqualityComparer<T> get_Comparer()
  System.Int32 EnsureCapacity(System.Int32 capacity)
  System.Void TrimExcess()
  System.Collections.Generic.IEqualityComparer<System.Collections.Generic.HashSet<T>> CreateSetComparer()
  System.Int32 Initialize(System.Int32 capacity)
  System.Void IncreaseCapacity()
  System.Void SetCapacity(System.Int32 newSize)
  System.Boolean AddIfNotPresent(T value)
  System.Void AddValue(System.Int32 index, System.Int32 hashCode, T value)
  System.Boolean ContainsAllElements(System.Collections.Generic.IEnumerable<T> other)
  System.Boolean IsSubsetOfHashSetWithSameEC(System.Collections.Generic.HashSet<T> other)
  System.Void IntersectWithHashSetWithSameEC(System.Collections.Generic.HashSet<T> other)
  System.Void IntersectWithEnumerable(System.Collections.Generic.IEnumerable<T> other)
  System.Int32 InternalIndexOf(T item)
  System.Void SymmetricExceptWithUniqueHashSet(System.Collections.Generic.HashSet<T> other)
  System.Void SymmetricExceptWithEnumerable(System.Collections.Generic.IEnumerable<T> other)
  System.Boolean AddOrGetLocation(T value, System.Int32& location)
  System.Collections.Generic.HashSet.ElementCount<T> CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable<T> other, System.Boolean returnIfUnfound)
  System.Boolean HashSetEquals(System.Collections.Generic.HashSet<T> set1, System.Collections.Generic.HashSet<T> set2, System.Collections.Generic.IEqualityComparer<T> comparer)
  System.Boolean AreEqualityComparersEqual(System.Collections.Generic.HashSet<T> set1, System.Collections.Generic.HashSet<T> set2)
  System.Int32 InternalGetHashCode(T item)
END_CLASS

CLASS: System.Collections.Generic.HashSetEqualityComparer`1
TYPE:  class
TOKEN: 0x2000298
FIELDS:
  private   readonly System.Collections.Generic.IEqualityComparer<T>_comparer  // 0x0
METHODS:
  System.Void .ctor()
  System.Boolean Equals(System.Collections.Generic.HashSet<T> x, System.Collections.Generic.HashSet<T> y)
  System.Int32 GetHashCode(System.Collections.Generic.HashSet<T> obj)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: System.Collections.Generic.ICollectionDebugView`1
TYPE:  class
TOKEN: 0x2000299
FIELDS:
METHODS:
END_CLASS

CLASS: System.Dynamic.BinaryOperationBinder
TYPE:  class
TOKEN: 0x200025D
EXTENDS: DynamicMetaObjectBinder
FIELDS:
  private   readonly System.Linq.Expressions.ExpressionType<Operation>k__BackingField  // 0x18
METHODS:
  System.Linq.Expressions.ExpressionType get_Operation()
  System.Dynamic.DynamicMetaObject FallbackBinaryOperation(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject arg)
  System.Dynamic.DynamicMetaObject FallbackBinaryOperation(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject arg, System.Dynamic.DynamicMetaObject errorSuggestion)
  System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
END_CLASS

CLASS: System.Dynamic.BindingRestrictions
TYPE:  class
TOKEN: 0x200025E
FIELDS:
  public    static readonly System.Dynamic.BindingRestrictionsEmpty  // 0x0
METHODS:
  System.Void .ctor()
  System.Linq.Expressions.Expression GetExpression()
  System.Dynamic.BindingRestrictions Merge(System.Dynamic.BindingRestrictions restrictions)
  System.Dynamic.BindingRestrictions GetTypeRestriction(System.Linq.Expressions.Expression expression, System.Type type)
  System.Dynamic.BindingRestrictions GetTypeRestriction(System.Dynamic.DynamicMetaObject obj)
  System.Dynamic.BindingRestrictions GetInstanceRestriction(System.Linq.Expressions.Expression expression, System.Object instance)
  System.Linq.Expressions.Expression ToExpression()
  System.Void .cctor()
END_CLASS

CLASS: System.Dynamic.ConvertBinder
TYPE:  class
TOKEN: 0x2000266
EXTENDS: DynamicMetaObjectBinder
FIELDS:
  private   readonly System.Type                     <Type>k__BackingField  // 0x18
METHODS:
  System.Type get_Type()
  System.Dynamic.DynamicMetaObject FallbackConvert(System.Dynamic.DynamicMetaObject target)
  System.Dynamic.DynamicMetaObject FallbackConvert(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion)
  System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
END_CLASS

CLASS: System.Dynamic.CreateInstanceBinder
TYPE:  class
TOKEN: 0x2000267
EXTENDS: DynamicMetaObjectBinder
FIELDS:
METHODS:
  System.Dynamic.DynamicMetaObject FallbackCreateInstance(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
  System.Dynamic.DynamicMetaObject FallbackCreateInstance(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion)
  System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
END_CLASS

CLASS: System.Dynamic.DeleteIndexBinder
TYPE:  class
TOKEN: 0x2000268
EXTENDS: DynamicMetaObjectBinder
FIELDS:
METHODS:
  System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
  System.Dynamic.DynamicMetaObject FallbackDeleteIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes)
  System.Dynamic.DynamicMetaObject FallbackDeleteIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject errorSuggestion)
END_CLASS

CLASS: System.Dynamic.DeleteMemberBinder
TYPE:  class
TOKEN: 0x2000269
EXTENDS: DynamicMetaObjectBinder
FIELDS:
  private   readonly System.String                   <Name>k__BackingField  // 0x18
  private   readonly System.Boolean                  <IgnoreCase>k__BackingField  // 0x20
METHODS:
  System.String get_Name()
  System.Boolean get_IgnoreCase()
  System.Dynamic.DynamicMetaObject FallbackDeleteMember(System.Dynamic.DynamicMetaObject target)
  System.Dynamic.DynamicMetaObject FallbackDeleteMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion)
  System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
END_CLASS

CLASS: System.Dynamic.DynamicMetaObject
TYPE:  class
TOKEN: 0x200026A
FIELDS:
  public    static readonly System.Dynamic.DynamicMetaObject[]EmptyMetaObjects  // 0x0
  private   static readonly System.Object                   s_noValueSentinel  // 0x8
  private   readonly System.Object                   _value  // 0x10
  private   readonly System.Linq.Expressions.Expression<Expression>k__BackingField  // 0x18
  private   readonly System.Dynamic.BindingRestrictions<Restrictions>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression expression, System.Dynamic.BindingRestrictions restrictions)
  System.Void .ctor(System.Linq.Expressions.Expression expression, System.Dynamic.BindingRestrictions restrictions, System.Object value)
  System.Linq.Expressions.Expression get_Expression()
  System.Dynamic.BindingRestrictions get_Restrictions()
  System.Object get_Value()
  System.Boolean get_HasValue()
  System.Type get_RuntimeType()
  System.Type get_LimitType()
  System.Dynamic.DynamicMetaObject BindConvert(System.Dynamic.ConvertBinder binder)
  System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder)
  System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value)
  System.Dynamic.DynamicMetaObject BindDeleteMember(System.Dynamic.DeleteMemberBinder binder)
  System.Dynamic.DynamicMetaObject BindGetIndex(System.Dynamic.GetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes)
  System.Dynamic.DynamicMetaObject BindSetIndex(System.Dynamic.SetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value)
  System.Dynamic.DynamicMetaObject BindDeleteIndex(System.Dynamic.DeleteIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes)
  System.Dynamic.DynamicMetaObject BindInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Dynamic.DynamicMetaObject[] args)
  System.Dynamic.DynamicMetaObject BindInvoke(System.Dynamic.InvokeBinder binder, System.Dynamic.DynamicMetaObject[] args)
  System.Dynamic.DynamicMetaObject BindCreateInstance(System.Dynamic.CreateInstanceBinder binder, System.Dynamic.DynamicMetaObject[] args)
  System.Dynamic.DynamicMetaObject BindUnaryOperation(System.Dynamic.UnaryOperationBinder binder)
  System.Dynamic.DynamicMetaObject BindBinaryOperation(System.Dynamic.BinaryOperationBinder binder, System.Dynamic.DynamicMetaObject arg)
  System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames()
  System.Dynamic.DynamicMetaObject Create(System.Object value, System.Linq.Expressions.Expression expression)
  System.Void .cctor()
END_CLASS

CLASS: System.Dynamic.DynamicMetaObjectBinder
TYPE:  class
TOKEN: 0x200026B
EXTENDS: CallSiteBinder
FIELDS:
METHODS:
  System.Void .ctor()
  System.Type get_ReturnType()
  System.Linq.Expressions.Expression Bind(System.Object[] args, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters, System.Linq.Expressions.LabelTarget returnLabel)
  System.Dynamic.DynamicMetaObject[] CreateArgumentMetaObjects(System.Object[] args, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters)
  System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
  System.Linq.Expressions.Expression GetUpdateExpression(System.Type type)
  System.Boolean get_IsStandardBinder()
END_CLASS

CLASS: System.Dynamic.ExpandoClass
TYPE:  class
TOKEN: 0x200026C
FIELDS:
  private   readonly System.String[]                 _keys  // 0x10
  private   readonly System.Int32                    _hashCode  // 0x18
  private           System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.WeakReference>>_transitions  // 0x20
  private   static readonly System.Dynamic.ExpandoClass     Empty  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String[] keys, System.Int32 hashCode)
  System.Dynamic.ExpandoClass FindNewClass(System.String newKey)
  System.Collections.Generic.List<System.WeakReference> GetTransitionList(System.Int32 hashCode)
  System.Int32 GetValueIndex(System.String name, System.Boolean caseInsensitive, System.Dynamic.ExpandoObject obj)
  System.Int32 GetValueIndexCaseSensitive(System.String name)
  System.Int32 GetValueIndexCaseInsensitive(System.String name, System.Dynamic.ExpandoObject obj)
  System.String[] get_Keys()
  System.Void .cctor()
END_CLASS

CLASS: System.Dynamic.ExpandoObject
TYPE:  class
TOKEN: 0x200026D
FIELDS:
  private   static readonly System.Reflection.MethodInfo    s_expandoTryGetValue  // 0x0
  private   static readonly System.Reflection.MethodInfo    s_expandoTrySetValue  // 0x8
  private   static readonly System.Reflection.MethodInfo    s_expandoTryDeleteValue  // 0x10
  private   static readonly System.Reflection.MethodInfo    s_expandoPromoteClass  // 0x18
  private   static readonly System.Reflection.MethodInfo    s_expandoCheckVersion  // 0x20
  private   readonly System.Object                   LockObject  // 0x10
  private           System.Dynamic.ExpandoObject.ExpandoData_data  // 0x18
  private           System.Int32                    _count  // 0x20
  private   static readonly System.Object                   Uninitialized  // 0x28
  private           System.ComponentModel.PropertyChangedEventHandler_propertyChanged  // 0x28
METHODS:
  System.Void .ctor()
  System.Boolean TryGetValue(System.Object indexClass, System.Int32 index, System.String name, System.Boolean ignoreCase, System.Object& value)
  System.Void TrySetValue(System.Object indexClass, System.Int32 index, System.Object value, System.String name, System.Boolean ignoreCase, System.Boolean add)
  System.Boolean TryDeleteValue(System.Object indexClass, System.Int32 index, System.String name, System.Boolean ignoreCase, System.Object deleteValue)
  System.Boolean IsDeletedMember(System.Int32 index)
  System.Dynamic.ExpandoClass get_Class()
  System.Dynamic.ExpandoObject.ExpandoData PromoteClassCore(System.Dynamic.ExpandoClass oldClass, System.Dynamic.ExpandoClass newClass)
  System.Void PromoteClass(System.Object oldClass, System.Object newClass)
  System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter)
  System.Void TryAddMember(System.String key, System.Object value)
  System.Boolean TryGetValueForKey(System.String key, System.Object& value)
  System.Boolean ExpandoContainsKey(System.String key)
  System.Collections.Generic.ICollection<System.String> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys()
  System.Collections.Generic.ICollection<System.Object> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values()
  System.Object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(System.String key)
  System.Void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(System.String key, System.Object value)
  System.Void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(System.String key, System.Object value)
  System.Boolean System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(System.String key)
  System.Boolean System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(System.String key)
  System.Boolean System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(System.String key, System.Object& value)
  System.Int32 System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count()
  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly()
  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(System.Collections.Generic.KeyValuePair<System.String,System.Object> item)
  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear()
  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(System.Collections.Generic.KeyValuePair<System.String,System.Object> item)
  System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String,System.Object>[] array, System.Int32 arrayIndex)
  System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(System.Collections.Generic.KeyValuePair<System.String,System.Object> item)
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>> GetExpandoEnumerator(System.Dynamic.ExpandoObject.ExpandoData data, System.Int32 version)
  System.Void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value)
  System.Void .cctor()
END_CLASS

CLASS: System.Dynamic.GetIndexBinder
TYPE:  class
TOKEN: 0x2000279
EXTENDS: DynamicMetaObjectBinder
FIELDS:
METHODS:
  System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
  System.Dynamic.DynamicMetaObject FallbackGetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes)
  System.Dynamic.DynamicMetaObject FallbackGetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject errorSuggestion)
END_CLASS

CLASS: System.Dynamic.GetMemberBinder
TYPE:  class
TOKEN: 0x200027A
EXTENDS: DynamicMetaObjectBinder
FIELDS:
  private   readonly System.String                   <Name>k__BackingField  // 0x18
  private   readonly System.Boolean                  <IgnoreCase>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.String name, System.Boolean ignoreCase)
  System.Type get_ReturnType()
  System.String get_Name()
  System.Boolean get_IgnoreCase()
  System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target)
  System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion)
  System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
  System.Boolean get_IsStandardBinder()
END_CLASS

CLASS: System.Dynamic.IDynamicMetaObjectProvider
TYPE:  interface
TOKEN: 0x200027B
FIELDS:
METHODS:
  System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter)
END_CLASS

CLASS: System.Dynamic.InvokeBinder
TYPE:  class
TOKEN: 0x200027C
EXTENDS: DynamicMetaObjectBinder
FIELDS:
METHODS:
  System.Dynamic.DynamicMetaObject FallbackInvoke(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
  System.Dynamic.DynamicMetaObject FallbackInvoke(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion)
  System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
END_CLASS

CLASS: System.Dynamic.InvokeMemberBinder
TYPE:  class
TOKEN: 0x200027D
EXTENDS: DynamicMetaObjectBinder
FIELDS:
  private   readonly System.String                   <Name>k__BackingField  // 0x18
  private   readonly System.Boolean                  <IgnoreCase>k__BackingField  // 0x20
METHODS:
  System.String get_Name()
  System.Boolean get_IgnoreCase()
  System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
  System.Dynamic.DynamicMetaObject FallbackInvokeMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
  System.Dynamic.DynamicMetaObject FallbackInvokeMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion)
  System.Dynamic.DynamicMetaObject FallbackInvoke(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion)
END_CLASS

CLASS: System.Dynamic.SetIndexBinder
TYPE:  class
TOKEN: 0x200027E
EXTENDS: DynamicMetaObjectBinder
FIELDS:
METHODS:
  System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
  System.Dynamic.DynamicMetaObject FallbackSetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value)
  System.Dynamic.DynamicMetaObject FallbackSetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion)
END_CLASS

CLASS: System.Dynamic.SetMemberBinder
TYPE:  class
TOKEN: 0x200027F
EXTENDS: DynamicMetaObjectBinder
FIELDS:
  private   readonly System.String                   <Name>k__BackingField  // 0x18
  private   readonly System.Boolean                  <IgnoreCase>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.String name, System.Boolean ignoreCase)
  System.Type get_ReturnType()
  System.String get_Name()
  System.Boolean get_IgnoreCase()
  System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
  System.Boolean get_IsStandardBinder()
  System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value)
  System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion)
END_CLASS

CLASS: System.Dynamic.UnaryOperationBinder
TYPE:  class
TOKEN: 0x2000280
EXTENDS: DynamicMetaObjectBinder
FIELDS:
METHODS:
  System.Dynamic.DynamicMetaObject FallbackUnaryOperation(System.Dynamic.DynamicMetaObject target)
  System.Dynamic.DynamicMetaObject FallbackUnaryOperation(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion)
  System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args)
END_CLASS

CLASS: System.Dynamic.Utils.CacheDict`2
TYPE:  class
TOKEN: 0x2000281
FIELDS:
  private   readonly System.Int32                    _mask  // 0x0
  private   readonly System.Dynamic.Utils.CacheDict.Entry<TKey,TValue>[]_entries  // 0x0
METHODS:
  System.Void .ctor(System.Int32 size)
  System.Int32 AlignSize(System.Int32 size)
  System.Boolean TryGetValue(TKey key, TValue& value)
  System.Void Add(TKey key, TValue value)
  System.Void set_Item(TKey key, TValue value)
END_CLASS

CLASS: System.Dynamic.Utils.CollectionExtensions
TYPE:  class
TOKEN: 0x2000283
FIELDS:
METHODS:
  System.Runtime.CompilerServices.TrueReadOnlyCollection<T> AddFirst(System.Collections.ObjectModel.ReadOnlyCollection<T> list, T item)
  T[] AddLast(T[] array, T item)
  T[] RemoveFirst(T[] array)
  T[] RemoveLast(T[] array)
  System.Collections.ObjectModel.ReadOnlyCollection<T> ToReadOnly(System.Collections.Generic.IEnumerable<T> enumerable)
END_CLASS

CLASS: System.Dynamic.Utils.ContractUtils
TYPE:  class
TOKEN: 0x2000284
FIELDS:
METHODS:
  System.Exception get_Unreachable()
  System.Void Requires(System.Boolean precondition, System.String paramName)
  System.Void RequiresNotNull(System.Object value, System.String paramName)
  System.Void RequiresNotNull(System.Object value, System.String paramName, System.Int32 index)
  System.Void RequiresNotNullItems(System.Collections.Generic.IList<T> array, System.String arrayName)
  System.String GetParamName(System.String paramName, System.Int32 index)
  System.Void RequiresArrayRange(System.Collections.Generic.IList<T> array, System.Int32 offset, System.Int32 count, System.String offsetName, System.String countName)
END_CLASS

CLASS: System.Dynamic.Utils.EmptyReadOnlyCollection`1
TYPE:  class
TOKEN: 0x2000285
FIELDS:
  public    static readonly System.Collections.ObjectModel.ReadOnlyCollection<T>Instance  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: System.Dynamic.Utils.ExpressionUtils
TYPE:  class
TOKEN: 0x2000286
FIELDS:
METHODS:
  System.Collections.ObjectModel.ReadOnlyCollection<T> ReturnReadOnly(System.Collections.Generic.IReadOnlyList<T>& collection)
  T ReturnObject(System.Object collectionOrT)
  System.Void ValidateArgumentTypes(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>& arguments, System.String methodParamName)
  System.Void ValidateArgumentCount(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind, System.Int32 count, System.Reflection.ParameterInfo[] pis)
  System.Linq.Expressions.Expression ValidateOneArgument(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind, System.Linq.Expressions.Expression arguments, System.Reflection.ParameterInfo pi, System.String methodParamName, System.String argumentParamName, System.Int32 index)
  System.Void RequiresCanRead(System.Linq.Expressions.Expression expression, System.String paramName)
  System.Void RequiresCanRead(System.Linq.Expressions.Expression expression, System.String paramName, System.Int32 idx)
  System.Boolean TryQuote(System.Type parameterType, System.Linq.Expressions.Expression& argument)
  System.Reflection.ParameterInfo[] GetParametersForValidation(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind)
  System.Boolean SameElements(System.Collections.Generic.IEnumerable<T>& replacement, System.Collections.Generic.IReadOnlyList<T> current)
  System.Boolean SameElementsInCollection(System.Collections.Generic.ICollection<T> replacement, System.Collections.Generic.IReadOnlyList<T> current)
  System.Void ValidateArgumentCount(System.Linq.Expressions.LambdaExpression lambda)
END_CLASS

CLASS: System.Dynamic.Utils.ExpressionVisitorUtils
TYPE:  class
TOKEN: 0x2000287
FIELDS:
METHODS:
  System.Linq.Expressions.Expression[] VisitBlockExpressions(System.Linq.Expressions.ExpressionVisitor visitor, System.Linq.Expressions.BlockExpression block)
  System.Linq.Expressions.ParameterExpression[] VisitParameters(System.Linq.Expressions.ExpressionVisitor visitor, System.Linq.Expressions.IParameterProvider nodes, System.String callerName)
  System.Linq.Expressions.Expression[] VisitArguments(System.Linq.Expressions.ExpressionVisitor visitor, System.Linq.Expressions.IArgumentProvider nodes)
END_CLASS

CLASS: System.Dynamic.Utils.TypeExtensions
TYPE:  class
TOKEN: 0x2000288
FIELDS:
  private   static readonly System.Dynamic.Utils.CacheDict<System.Reflection.MethodBase,System.Reflection.ParameterInfo[]>s_paramInfoCache  // 0x0
METHODS:
  System.Reflection.MethodInfo GetAnyStaticMethodValidated(System.Type type, System.String name, System.Type[] types)
  System.Boolean MatchesArgumentTypes(System.Reflection.MethodInfo mi, System.Type[] argTypes)
  System.Type GetReturnType(System.Reflection.MethodBase mi)
  System.TypeCode GetTypeCode(System.Type type)
  System.Reflection.ParameterInfo[] GetParametersCached(System.Reflection.MethodBase method)
  System.Void .cctor()
END_CLASS

CLASS: System.Dynamic.Utils.TypeUtils
TYPE:  class
TOKEN: 0x2000289
FIELDS:
  private   static readonly System.Type[]                   s_arrayAssignableInterfaces  // 0x0
METHODS:
  System.Type GetNonNullableType(System.Type type)
  System.Type GetNullableType(System.Type type)
  System.Boolean IsNullableType(System.Type type)
  System.Boolean IsNullableOrReferenceType(System.Type type)
  System.Boolean IsBool(System.Type type)
  System.Boolean IsNumeric(System.Type type)
  System.Boolean IsInteger(System.Type type)
  System.Boolean IsArithmetic(System.Type type)
  System.Boolean IsUnsignedInt(System.Type type)
  System.Boolean IsIntegerOrBool(System.Type type)
  System.Boolean IsNumericOrBool(System.Type type)
  System.Boolean IsValidInstanceType(System.Reflection.MemberInfo member, System.Type instanceType)
  System.Boolean HasIdentityPrimitiveOrNullableConversionTo(System.Type source, System.Type dest)
  System.Boolean HasReferenceConversionTo(System.Type source, System.Type dest)
  System.Boolean StrictHasReferenceConversionTo(System.Type source, System.Type dest, System.Boolean skipNonArray)
  System.Boolean HasArrayToInterfaceConversion(System.Type source, System.Type dest)
  System.Boolean HasInterfaceToArrayConversion(System.Type source, System.Type dest)
  System.Boolean IsCovariant(System.Type t)
  System.Boolean IsContravariant(System.Type t)
  System.Boolean IsInvariant(System.Type t)
  System.Boolean IsDelegate(System.Type t)
  System.Boolean IsLegalExplicitVariantDelegateConversion(System.Type source, System.Type dest)
  System.Boolean IsConvertible(System.Type type)
  System.Boolean HasReferenceEquality(System.Type left, System.Type right)
  System.Boolean HasBuiltInEqualityOperator(System.Type left, System.Type right)
  System.Boolean IsImplicitlyConvertibleTo(System.Type source, System.Type destination)
  System.Reflection.MethodInfo GetUserDefinedCoercionMethod(System.Type convertFrom, System.Type convertToType)
  System.Reflection.MethodInfo FindConversionOperator(System.Reflection.MethodInfo[] methods, System.Type typeFrom, System.Type typeTo)
  System.Boolean IsImplicitNumericConversion(System.Type source, System.Type destination)
  System.Boolean IsImplicitReferenceConversion(System.Type source, System.Type destination)
  System.Boolean IsImplicitBoxingConversion(System.Type source, System.Type destination)
  System.Boolean IsImplicitNullableConversion(System.Type source, System.Type destination)
  System.Type FindGenericType(System.Type definition, System.Type type)
  System.Reflection.MethodInfo GetBooleanOperator(System.Type type, System.String name)
  System.Type GetNonRefType(System.Type type)
  System.Boolean AreEquivalent(System.Type t1, System.Type t2)
  System.Boolean AreReferenceAssignable(System.Type dest, System.Type src)
  System.Boolean IsSameOrSubclass(System.Type type, System.Type subType)
  System.Void ValidateType(System.Type type, System.String paramName)
  System.Void ValidateType(System.Type type, System.String paramName, System.Boolean allowByRef, System.Boolean allowPointer)
  System.Boolean ValidateType(System.Type type, System.String paramName, System.Int32 index)
  System.Reflection.MethodInfo GetInvokeMethod(System.Type delegateType)
  System.Void .cctor()
END_CLASS

CLASS: System.IO.HandleInheritability
TYPE:  struct
TOKEN: 0x200028B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.IO.HandleInheritability  None  // 0x0
  public    static  System.IO.HandleInheritability  Inheritable  // 0x0
METHODS:
END_CLASS

CLASS: System.IO.MemoryMappedFiles.MemoryMappedFileAccess
TYPE:  struct
TOKEN: 0x200028C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.IO.MemoryMappedFiles.MemoryMappedFileAccessReadWrite  // 0x0
  public    static  System.IO.MemoryMappedFiles.MemoryMappedFileAccessRead  // 0x0
  public    static  System.IO.MemoryMappedFiles.MemoryMappedFileAccessWrite  // 0x0
  public    static  System.IO.MemoryMappedFiles.MemoryMappedFileAccessCopyOnWrite  // 0x0
  public    static  System.IO.MemoryMappedFiles.MemoryMappedFileAccessReadExecute  // 0x0
  public    static  System.IO.MemoryMappedFiles.MemoryMappedFileAccessReadWriteExecute  // 0x0
METHODS:
END_CLASS

CLASS: System.IO.MemoryMappedFiles.MemoryMappedFileOptions
TYPE:  struct
TOKEN: 0x200028D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.IO.MemoryMappedFiles.MemoryMappedFileOptionsNone  // 0x0
  public    static  System.IO.MemoryMappedFiles.MemoryMappedFileOptionsDelayAllocatePages  // 0x0
METHODS:
END_CLASS

CLASS: System.IO.MemoryMappedFiles.MemoryMappedViewAccessor
TYPE:  class
TOKEN: 0x200028E
EXTENDS: UnmanagedMemoryAccessor
FIELDS:
  private           System.IO.MemoryMappedFiles.MemoryMappedViewm_view  // 0x30
METHODS:
  System.Void .ctor(System.IO.MemoryMappedFiles.MemoryMappedView view)
  Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle get_SafeMemoryMappedViewHandle()
  System.Void Dispose(System.Boolean disposing)
  System.Void Flush()
END_CLASS

CLASS: System.IO.MemoryMappedFiles.MemoryMapImpl
TYPE:  class
TOKEN: 0x200028F
FIELDS:
METHODS:
  System.IntPtr OpenFileInternal(System.Char* path, System.Int32 path_length, System.IO.FileMode mode, System.Char* mapName, System.Int32 mapName_length, System.Int64& capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileOptions options, System.Int32& error)
  System.IntPtr OpenHandleInternal(System.IntPtr handle, System.Char* mapName, System.Int32 mapName_length, System.Int64& capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileOptions options, System.Int32& error)
  System.Void CloseMapping(System.IntPtr handle)
  System.Void Flush(System.IntPtr file_handle)
  System.Void ConfigureHandleInheritability(System.IntPtr handle, System.IO.HandleInheritability inheritability)
  System.Boolean Unmap(System.IntPtr mmap_handle)
  System.Int32 MapInternal(System.IntPtr handle, System.Int64 offset, System.Int64& size, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IntPtr& mmap_handle, System.IntPtr& base_address)
  System.Void Map(System.IntPtr handle, System.Int64 offset, System.Int64& size, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IntPtr& mmap_handle, System.IntPtr& base_address)
  System.Exception CreateException(System.Int32 error, System.String path)
  System.Int32 StringLength(System.String a)
  System.Void CheckString(System.String name, System.String value)
  System.IntPtr OpenFile(System.String path, System.IO.FileMode mode, System.String mapName, System.Int64& capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileOptions options)
  System.IntPtr OpenHandle(System.IntPtr handle, System.String mapName, System.Int64& capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileOptions options)
END_CLASS

CLASS: System.IO.MemoryMappedFiles.MemoryMappedFile
TYPE:  class
TOKEN: 0x2000290
FIELDS:
  private           System.IO.FileStream            stream  // 0x10
  private           System.Boolean                  keepOpen  // 0x18
  private           Microsoft.Win32.SafeHandles.SafeMemoryMappedFileHandlehandle  // 0x20
METHODS:
  System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(System.String path, System.IO.FileMode mode)
  System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(System.String path, System.IO.FileMode mode, System.String mapName, System.Int64 capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access)
  System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(System.IO.FileStream fileStream, System.String mapName, System.Int64 capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.HandleInheritability inheritability, System.Boolean leaveOpen)
  System.IO.MemoryMappedFiles.MemoryMappedViewAccessor CreateViewAccessor(System.Int64 offset, System.Int64 size, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access)
  System.Void .ctor()
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.IO.FileAccess GetFileAccess(System.IO.MemoryMappedFiles.MemoryMappedFileAccess access)
END_CLASS

CLASS: System.IO.MemoryMappedFiles.MemoryMappedView
TYPE:  class
TOKEN: 0x2000291
FIELDS:
  private           Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandlem_viewHandle  // 0x10
  private           System.Int64                    m_pointerOffset  // 0x18
  private           System.Int64                    m_size  // 0x20
  private           System.IO.MemoryMappedFiles.MemoryMappedFileAccessm_access  // 0x28
METHODS:
  System.Void .ctor(Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle viewHandle, System.Int64 pointerOffset, System.Int64 size, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access)
  Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle get_ViewHandle()
  System.Int64 get_PointerOffset()
  System.Int64 get_Size()
  System.IO.MemoryMappedFiles.MemoryMappedFileAccess get_Access()
  System.IO.MemoryMappedFiles.MemoryMappedView Create(System.IntPtr handle, System.Int64 offset, System.Int64 size, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access)
  System.Void Flush(System.IntPtr capacity)
  System.Void Dispose(System.Boolean disposing)
  System.Void Dispose()
  System.Boolean get_IsClosed()
END_CLASS

CLASS: System.Linq.Error
TYPE:  class
TOKEN: 0x200001B
FIELDS:
METHODS:
  System.Exception ArgumentNull(System.String s)
  System.Exception ArgumentOutOfRange(System.String s)
  System.Exception MoreThanOneElement()
  System.Exception MoreThanOneMatch()
  System.Exception NoElements()
  System.Exception NoMatch()
  System.Exception NotSupported()
END_CLASS

CLASS: System.Linq.Enumerable
TYPE:  class
TOKEN: 0x200001C
FIELDS:
METHODS:
  System.Collections.Generic.IEnumerable<TSource> Where(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate)
  System.Collections.Generic.IEnumerable<TResult> Select(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TResult> selector)
  System.Func<TSource,System.Boolean> CombinePredicates(System.Func<TSource,System.Boolean> predicate1, System.Func<TSource,System.Boolean> predicate2)
  System.Func<TSource,TResult> CombineSelectors(System.Func<TSource,TMiddle> selector1, System.Func<TMiddle,TResult> selector2)
  System.Collections.Generic.IEnumerable<TResult> SelectMany(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> selector)
  System.Collections.Generic.IEnumerable<TResult> SelectManyIterator(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> selector)
  System.Collections.Generic.IEnumerable<TResult> SelectMany(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource,TCollection,TResult> resultSelector)
  System.Collections.Generic.IEnumerable<TResult> SelectManyIterator(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource,TCollection,TResult> resultSelector)
  System.Collections.Generic.IEnumerable<TSource> Skip(System.Collections.Generic.IEnumerable<TSource> source, System.Int32 count)
  System.Collections.Generic.IEnumerable<TSource> SkipIterator(System.Collections.Generic.IEnumerable<TSource> source, System.Int32 count)
  System.Collections.Generic.IEnumerable<TResult> Join(System.Collections.Generic.IEnumerable<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter,TKey> outerKeySelector, System.Func<TInner,TKey> innerKeySelector, System.Func<TOuter,TInner,TResult> resultSelector)
  System.Collections.Generic.IEnumerable<TResult> JoinIterator(System.Collections.Generic.IEnumerable<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter,TKey> outerKeySelector, System.Func<TInner,TKey> innerKeySelector, System.Func<TOuter,TInner,TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
  System.Linq.IOrderedEnumerable<TSource> OrderBy(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector)
  System.Linq.IOrderedEnumerable<TSource> OrderByDescending(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector)
  System.Linq.IOrderedEnumerable<TSource> ThenBy(System.Linq.IOrderedEnumerable<TSource> source, System.Func<TSource,TKey> keySelector)
  System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey,TSource>> GroupBy(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector)
  System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey,TElement>> GroupBy(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector, System.Func<TSource,TElement> elementSelector)
  System.Collections.Generic.IEnumerable<TSource> Concat(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second)
  System.Collections.Generic.IEnumerable<TSource> ConcatIterator(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second)
  System.Collections.Generic.IEnumerable<TSource> Prepend(System.Collections.Generic.IEnumerable<TSource> source, TSource element)
  System.Collections.Generic.IEnumerable<TSource> PrependIterator(System.Collections.Generic.IEnumerable<TSource> source, TSource element)
  System.Collections.Generic.IEnumerable<TSource> Distinct(System.Collections.Generic.IEnumerable<TSource> source)
  System.Collections.Generic.IEnumerable<TSource> Distinct(System.Collections.Generic.IEnumerable<TSource> source, System.Collections.Generic.IEqualityComparer<TSource> comparer)
  System.Collections.Generic.IEnumerable<TSource> DistinctIterator(System.Collections.Generic.IEnumerable<TSource> source, System.Collections.Generic.IEqualityComparer<TSource> comparer)
  System.Collections.Generic.IEnumerable<TSource> Union(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second)
  System.Collections.Generic.IEnumerable<TSource> UnionIterator(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer)
  System.Collections.Generic.IEnumerable<TSource> Intersect(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second)
  System.Collections.Generic.IEnumerable<TSource> IntersectIterator(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer)
  System.Collections.Generic.IEnumerable<TSource> Reverse(System.Collections.Generic.IEnumerable<TSource> source)
  System.Collections.Generic.IEnumerable<TSource> ReverseIterator(System.Collections.Generic.IEnumerable<TSource> source)
  System.Boolean SequenceEqual(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second)
  System.Boolean SequenceEqual(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer)
  System.Collections.Generic.IEnumerable<TSource> AsEnumerable(System.Collections.Generic.IEnumerable<TSource> source)
  TSource[] ToArray(System.Collections.Generic.IEnumerable<TSource> source)
  System.Collections.Generic.List<TSource> ToList(System.Collections.Generic.IEnumerable<TSource> source)
  System.Collections.Generic.Dictionary<TKey,TSource> ToDictionary(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector)
  System.Collections.Generic.Dictionary<TKey,TElement> ToDictionary(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector, System.Func<TSource,TElement> elementSelector)
  System.Collections.Generic.Dictionary<TKey,TElement> ToDictionary(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector, System.Func<TSource,TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
  System.Collections.Generic.IEnumerable<TResult> OfType(System.Collections.IEnumerable source)
  System.Collections.Generic.IEnumerable<TResult> OfTypeIterator(System.Collections.IEnumerable source)
  System.Collections.Generic.IEnumerable<TResult> Cast(System.Collections.IEnumerable source)
  System.Collections.Generic.IEnumerable<TResult> CastIterator(System.Collections.IEnumerable source)
  TSource First(System.Collections.Generic.IEnumerable<TSource> source)
  TSource First(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate)
  TSource FirstOrDefault(System.Collections.Generic.IEnumerable<TSource> source)
  TSource FirstOrDefault(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate)
  TSource Last(System.Collections.Generic.IEnumerable<TSource> source)
  TSource LastOrDefault(System.Collections.Generic.IEnumerable<TSource> source)
  TSource LastOrDefault(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate)
  TSource Single(System.Collections.Generic.IEnumerable<TSource> source)
  TSource Single(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate)
  TSource SingleOrDefault(System.Collections.Generic.IEnumerable<TSource> source)
  TSource SingleOrDefault(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate)
  TSource ElementAt(System.Collections.Generic.IEnumerable<TSource> source, System.Int32 index)
  System.Collections.Generic.IEnumerable<System.Int32> Range(System.Int32 start, System.Int32 count)
  System.Collections.Generic.IEnumerable<System.Int32> RangeIterator(System.Int32 start, System.Int32 count)
  System.Collections.Generic.IEnumerable<TResult> Repeat(TResult element, System.Int32 count)
  System.Collections.Generic.IEnumerable<TResult> RepeatIterator(TResult element, System.Int32 count)
  System.Collections.Generic.IEnumerable<TResult> Empty()
  System.Boolean Any(System.Collections.Generic.IEnumerable<TSource> source)
  System.Boolean Any(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate)
  System.Boolean All(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate)
  System.Int32 Count(System.Collections.Generic.IEnumerable<TSource> source)
  System.Int32 Count(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate)
  System.Boolean Contains(System.Collections.Generic.IEnumerable<TSource> source, TSource value)
  System.Boolean Contains(System.Collections.Generic.IEnumerable<TSource> source, TSource value, System.Collections.Generic.IEqualityComparer<TSource> comparer)
  TSource Aggregate(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TSource,TSource> func)
  TAccumulate Aggregate(System.Collections.Generic.IEnumerable<TSource> source, TAccumulate seed, System.Func<TAccumulate,TSource,TAccumulate> func)
  System.Int32 Min(System.Collections.Generic.IEnumerable<System.Int32> source)
  System.Int32 Max(System.Collections.Generic.IEnumerable<System.Int32> source)
  System.Collections.Generic.HashSet<TSource> ToHashSet(System.Collections.Generic.IEnumerable<TSource> source)
  System.Collections.Generic.HashSet<TSource> ToHashSet(System.Collections.Generic.IEnumerable<TSource> source, System.Collections.Generic.IEqualityComparer<TSource> comparer)
END_CLASS

CLASS: System.Linq.EmptyEnumerable`1
TYPE:  class
TOKEN: 0x2000034
FIELDS:
  public    static readonly TElement[]                      Instance  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.IdentityFunction`1
TYPE:  class
TOKEN: 0x2000035
FIELDS:
METHODS:
  System.Func<TElement,TElement> get_Instance()
END_CLASS

CLASS: System.Linq.IOrderedEnumerable`1
TYPE:  interface
TOKEN: 0x2000037
FIELDS:
METHODS:
  System.Linq.IOrderedEnumerable<TElement> CreateOrderedEnumerable(System.Func<TElement,TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer, System.Boolean descending)
END_CLASS

CLASS: System.Linq.IGrouping`2
TYPE:  interface
TOKEN: 0x2000038
FIELDS:
METHODS:
  TKey get_Key()
END_CLASS

CLASS: System.Linq.ILookup`2
TYPE:  interface
TOKEN: 0x2000039
FIELDS:
METHODS:
END_CLASS

CLASS: System.Linq.Lookup`2
TYPE:  class
TOKEN: 0x200003A
FIELDS:
  private           System.Collections.Generic.IEqualityComparer<TKey>comparer  // 0x0
  private           System.Linq.Lookup.Grouping<TKey,TElement>[]groupings  // 0x0
  private           System.Linq.Lookup.Grouping<TKey,TElement>lastGrouping  // 0x0
  private           System.Int32                    count  // 0x0
METHODS:
  System.Linq.Lookup<TKey,TElement> Create(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector, System.Func<TSource,TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
  System.Linq.Lookup<TKey,TElement> CreateForJoin(System.Collections.Generic.IEnumerable<TElement> source, System.Func<TElement,TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
  System.Void .ctor(System.Collections.Generic.IEqualityComparer<TKey> comparer)
  System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Int32 InternalGetHashCode(TKey key)
  System.Linq.Lookup.Grouping<TKey,TElement> GetGrouping(TKey key, System.Boolean create)
  System.Void Resize()
END_CLASS

CLASS: System.Linq.Set`1
TYPE:  class
TOKEN: 0x200003E
FIELDS:
  private           System.Int32[]                  buckets  // 0x0
  private           System.Linq.Set.Slot<TElement>[]slots  // 0x0
  private           System.Int32                    count  // 0x0
  private           System.Int32                    freeList  // 0x0
  private           System.Collections.Generic.IEqualityComparer<TElement>comparer  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IEqualityComparer<TElement> comparer)
  System.Boolean Add(TElement value)
  System.Boolean Remove(TElement value)
  System.Boolean Find(TElement value, System.Boolean add)
  System.Void Resize()
  System.Int32 InternalGetHashCode(TElement value)
END_CLASS

CLASS: System.Linq.GroupedEnumerable`3
TYPE:  class
TOKEN: 0x2000040
FIELDS:
  private           System.Collections.Generic.IEnumerable<TSource>source  // 0x0
  private           System.Func<TSource,TKey>       keySelector  // 0x0
  private           System.Func<TSource,TElement>   elementSelector  // 0x0
  private           System.Collections.Generic.IEqualityComparer<TKey>comparer  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector, System.Func<TSource,TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer)
  System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: System.Linq.OrderedEnumerable`1
TYPE:  class
TOKEN: 0x2000041
FIELDS:
  private           System.Collections.Generic.IEnumerable<TElement>source  // 0x0
METHODS:
  System.Collections.Generic.IEnumerator<TElement> GetEnumerator()
  System.Linq.EnumerableSorter<TElement> GetEnumerableSorter(System.Linq.EnumerableSorter<TElement> next)
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Linq.IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(System.Func<TElement,TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer, System.Boolean descending)
  System.Void .ctor()
END_CLASS

CLASS: System.Linq.OrderedEnumerable`2
TYPE:  class
TOKEN: 0x2000043
EXTENDS: OrderedEnumerable`1
FIELDS:
  private           System.Linq.OrderedEnumerable<TElement>parent  // 0x0
  private           System.Func<TElement,TKey>      keySelector  // 0x0
  private           System.Collections.Generic.IComparer<TKey>comparer  // 0x0
  private           System.Boolean                  descending  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IEnumerable<TElement> source, System.Func<TElement,TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer, System.Boolean descending)
  System.Linq.EnumerableSorter<TElement> GetEnumerableSorter(System.Linq.EnumerableSorter<TElement> next)
END_CLASS

CLASS: System.Linq.EnumerableSorter`1
TYPE:  class
TOKEN: 0x2000044
FIELDS:
METHODS:
  System.Void ComputeKeys(TElement[] elements, System.Int32 count)
  System.Int32 CompareKeys(System.Int32 index1, System.Int32 index2)
  System.Int32[] Sort(TElement[] elements, System.Int32 count)
  System.Void QuickSort(System.Int32[] map, System.Int32 left, System.Int32 right)
  System.Void .ctor()
END_CLASS

CLASS: System.Linq.EnumerableSorter`2
TYPE:  class
TOKEN: 0x2000045
EXTENDS: EnumerableSorter`1
FIELDS:
  private           System.Func<TElement,TKey>      keySelector  // 0x0
  private           System.Collections.Generic.IComparer<TKey>comparer  // 0x0
  private           System.Boolean                  descending  // 0x0
  private           System.Linq.EnumerableSorter<TElement>next  // 0x0
  private           TKey[]                          keys  // 0x0
METHODS:
  System.Void .ctor(System.Func<TElement,TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer, System.Boolean descending, System.Linq.EnumerableSorter<TElement> next)
  System.Void ComputeKeys(TElement[] elements, System.Int32 count)
  System.Int32 CompareKeys(System.Int32 index1, System.Int32 index2)
END_CLASS

CLASS: System.Linq.Buffer`1
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  private           TElement[]                      items  // 0x0
  private           System.Int32                    count  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.IEnumerable<TElement> source)
  TElement[] ToArray()
END_CLASS

CLASS: System.Linq.Expressions.CachedReflectionInfo
TYPE:  class
TOKEN: 0x2000047
FIELDS:
  private   static  System.Reflection.MethodInfo    s_CallSiteOps_SetNotMatched  // 0x0
  private   static  System.Reflection.MethodInfo    s_CallSiteOps_CreateMatchmaker  // 0x8
  private   static  System.Reflection.MethodInfo    s_CallSiteOps_GetMatch  // 0x10
  private   static  System.Reflection.MethodInfo    s_CallSiteOps_ClearMatch  // 0x18
  private   static  System.Reflection.MethodInfo    s_CallSiteOps_UpdateRules  // 0x20
  private   static  System.Reflection.MethodInfo    s_CallSiteOps_GetRules  // 0x28
  private   static  System.Reflection.MethodInfo    s_CallSiteOps_GetRuleCache  // 0x30
  private   static  System.Reflection.MethodInfo    s_CallSiteOps_GetCachedRules  // 0x38
  private   static  System.Reflection.MethodInfo    s_CallSiteOps_AddRule  // 0x40
  private   static  System.Reflection.MethodInfo    s_CallSiteOps_MoveRule  // 0x48
  private   static  System.Reflection.MethodInfo    s_CallSiteOps_Bind  // 0x50
  private   static  System.Reflection.MethodInfo    s_String_op_Equality_String_String  // 0x58
  private   static  System.Reflection.MethodInfo    s_Math_Pow_Double_Double  // 0x60
METHODS:
  System.Reflection.MethodInfo get_CallSiteOps_SetNotMatched()
  System.Reflection.MethodInfo get_CallSiteOps_CreateMatchmaker()
  System.Reflection.MethodInfo get_CallSiteOps_GetMatch()
  System.Reflection.MethodInfo get_CallSiteOps_ClearMatch()
  System.Reflection.MethodInfo get_CallSiteOps_UpdateRules()
  System.Reflection.MethodInfo get_CallSiteOps_GetRules()
  System.Reflection.MethodInfo get_CallSiteOps_GetRuleCache()
  System.Reflection.MethodInfo get_CallSiteOps_GetCachedRules()
  System.Reflection.MethodInfo get_CallSiteOps_AddRule()
  System.Reflection.MethodInfo get_CallSiteOps_MoveRule()
  System.Reflection.MethodInfo get_CallSiteOps_Bind()
  System.Reflection.MethodInfo get_String_op_Equality_String_String()
  System.Reflection.MethodInfo get_Math_Pow_Double_Double()
END_CLASS

CLASS: System.Linq.Expressions.BinaryExpression
TYPE:  class
TOKEN: 0x2000048
EXTENDS: Expression
FIELDS:
  private   readonly System.Linq.Expressions.Expression<Right>k__BackingField  // 0x10
  private   readonly System.Linq.Expressions.Expression<Left>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right)
  System.Boolean get_CanReduce()
  System.Boolean IsOpAssignment(System.Linq.Expressions.ExpressionType op)
  System.Linq.Expressions.Expression get_Right()
  System.Linq.Expressions.Expression get_Left()
  System.Reflection.MethodInfo get_Method()
  System.Reflection.MethodInfo GetMethod()
  System.Linq.Expressions.BinaryExpression Update(System.Linq.Expressions.Expression left, System.Linq.Expressions.LambdaExpression conversion, System.Linq.Expressions.Expression right)
  System.Linq.Expressions.Expression Reduce()
  System.Linq.Expressions.ExpressionType GetBinaryOpFromAssignmentOp(System.Linq.Expressions.ExpressionType op)
  System.Linq.Expressions.Expression ReduceVariable()
  System.Linq.Expressions.Expression ReduceMember()
  System.Linq.Expressions.Expression ReduceIndex()
  System.Linq.Expressions.LambdaExpression get_Conversion()
  System.Linq.Expressions.LambdaExpression GetConversion()
  System.Boolean get_IsLifted()
  System.Boolean get_IsLiftedToNull()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Boolean get_IsLiftedLogical()
  System.Boolean get_IsReferenceComparison()
  System.Linq.Expressions.Expression ReduceUserdefinedLifted()
END_CLASS

CLASS: System.Linq.Expressions.LogicalBinaryExpression
TYPE:  class
TOKEN: 0x2000049
EXTENDS: BinaryExpression
FIELDS:
  private   readonly System.Linq.Expressions.ExpressionType<NodeType>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.Linq.Expressions.ExpressionType nodeType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right)
  System.Type get_Type()
  System.Linq.Expressions.ExpressionType get_NodeType()
END_CLASS

CLASS: System.Linq.Expressions.AssignBinaryExpression
TYPE:  class
TOKEN: 0x200004A
EXTENDS: BinaryExpression
FIELDS:
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right)
  System.Type get_Type()
  System.Linq.Expressions.ExpressionType get_NodeType()
END_CLASS

CLASS: System.Linq.Expressions.CoalesceConversionBinaryExpression
TYPE:  class
TOKEN: 0x200004B
EXTENDS: BinaryExpression
FIELDS:
  private   readonly System.Linq.Expressions.LambdaExpression_conversion  // 0x20
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.LambdaExpression GetConversion()
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Type get_Type()
END_CLASS

CLASS: System.Linq.Expressions.OpAssignMethodConversionBinaryExpression
TYPE:  class
TOKEN: 0x200004C
EXTENDS: MethodBinaryExpression
FIELDS:
  private   readonly System.Linq.Expressions.LambdaExpression_conversion  // 0x38
METHODS:
  System.Void .ctor(System.Linq.Expressions.ExpressionType nodeType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Type type, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.LambdaExpression GetConversion()
END_CLASS

CLASS: System.Linq.Expressions.SimpleBinaryExpression
TYPE:  class
TOKEN: 0x200004D
EXTENDS: BinaryExpression
FIELDS:
  private   readonly System.Linq.Expressions.ExpressionType<NodeType>k__BackingField  // 0x20
  private   readonly System.Type                     <Type>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(System.Linq.Expressions.ExpressionType nodeType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Type type)
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Type get_Type()
END_CLASS

CLASS: System.Linq.Expressions.MethodBinaryExpression
TYPE:  class
TOKEN: 0x200004E
EXTENDS: SimpleBinaryExpression
FIELDS:
  private   readonly System.Reflection.MethodInfo    _method  // 0x30
METHODS:
  System.Void .ctor(System.Linq.Expressions.ExpressionType nodeType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Type type, System.Reflection.MethodInfo method)
  System.Reflection.MethodInfo GetMethod()
END_CLASS

CLASS: System.Linq.Expressions.Expression
TYPE:  class
TOKEN: 0x200004F
FIELDS:
  private   static readonly System.Dynamic.Utils.CacheDict<System.Type,System.Reflection.MethodInfo>s_lambdaDelegateCache  // 0x0
  private   static  System.Dynamic.Utils.CacheDict<System.Type,System.Func<System.Linq.Expressions.Expression,System.String,System.Boolean,System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>,System.Linq.Expressions.LambdaExpression>>s_lambdaFactories  // 0x8
  private   static  System.Runtime.CompilerServices.ConditionalWeakTable<System.Linq.Expressions.Expression,System.Linq.Expressions.Expression.ExtensionInfo>s_legacyCtorSupportTable  // 0x10
METHODS:
  System.Linq.Expressions.BinaryExpression Assign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right)
  System.Linq.Expressions.BinaryExpression GetUserDefinedBinaryOperator(System.Linq.Expressions.ExpressionType binaryType, System.String name, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull)
  System.Linq.Expressions.BinaryExpression GetMethodBasedBinaryOperator(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Boolean liftToNull)
  System.Linq.Expressions.BinaryExpression GetMethodBasedAssignOperator(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion, System.Boolean liftToNull)
  System.Linq.Expressions.BinaryExpression GetUserDefinedBinaryOperatorOrThrow(System.Linq.Expressions.ExpressionType binaryType, System.String name, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull)
  System.Linq.Expressions.BinaryExpression GetUserDefinedAssignOperatorOrThrow(System.Linq.Expressions.ExpressionType binaryType, System.String name, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Linq.Expressions.LambdaExpression conversion, System.Boolean liftToNull)
  System.Reflection.MethodInfo GetUserDefinedBinaryOperator(System.Linq.Expressions.ExpressionType binaryType, System.Type leftType, System.Type rightType, System.String name)
  System.Boolean IsLiftingConditionalLogicalOperator(System.Type left, System.Type right, System.Reflection.MethodInfo method, System.Linq.Expressions.ExpressionType binaryType)
  System.Boolean ParameterIsAssignable(System.Reflection.ParameterInfo pi, System.Type argType)
  System.Void ValidateParamswithOperandsOrThrow(System.Type paramType, System.Type operandType, System.Linq.Expressions.ExpressionType exprType, System.String name)
  System.Void ValidateOperator(System.Reflection.MethodInfo method)
  System.Void ValidateMethodInfo(System.Reflection.MethodInfo method, System.String paramName)
  System.Boolean IsNullComparison(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right)
  System.Boolean IsNullConstant(System.Linq.Expressions.Expression e)
  System.Void ValidateUserDefinedConditionalLogicOperator(System.Linq.Expressions.ExpressionType nodeType, System.Type left, System.Type right, System.Reflection.MethodInfo method)
  System.Void VerifyOpTrueFalse(System.Linq.Expressions.ExpressionType nodeType, System.Type left, System.Reflection.MethodInfo opTrue, System.String paramName)
  System.Boolean IsValidLiftedConditionalLogicalOperator(System.Type left, System.Type right, System.Reflection.ParameterInfo[] pms)
  System.Linq.Expressions.BinaryExpression MakeBinary(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression MakeBinary(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.BinaryExpression Equal(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right)
  System.Linq.Expressions.BinaryExpression Equal(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression ReferenceEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right)
  System.Linq.Expressions.BinaryExpression NotEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right)
  System.Linq.Expressions.BinaryExpression NotEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression ReferenceNotEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right)
  System.Linq.Expressions.BinaryExpression GetEqualityComparisonOperator(System.Linq.Expressions.ExpressionType binaryType, System.String opName, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull)
  System.Linq.Expressions.BinaryExpression GreaterThan(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression LessThan(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression GreaterThanOrEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression LessThanOrEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression GetComparisonOperator(System.Linq.Expressions.ExpressionType binaryType, System.String opName, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull)
  System.Linq.Expressions.BinaryExpression AndAlso(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right)
  System.Linq.Expressions.BinaryExpression AndAlso(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression OrElse(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression Coalesce(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Linq.Expressions.LambdaExpression conversion)
  System.Type ValidateCoalesceArgTypes(System.Type left, System.Type right)
  System.Linq.Expressions.BinaryExpression Add(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression AddAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Void ValidateOpAssignConversionLambda(System.Linq.Expressions.LambdaExpression conversion, System.Linq.Expressions.Expression left, System.Reflection.MethodInfo method, System.Linq.Expressions.ExpressionType nodeType)
  System.Linq.Expressions.BinaryExpression AddAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.BinaryExpression AddChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression Subtract(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression SubtractAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.BinaryExpression SubtractAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.BinaryExpression SubtractChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression Divide(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression DivideAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.BinaryExpression Modulo(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression ModuloAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.BinaryExpression Multiply(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression MultiplyAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.BinaryExpression MultiplyAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.BinaryExpression MultiplyChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Boolean IsSimpleShift(System.Type left, System.Type right)
  System.Type GetResultTypeOfShift(System.Type left, System.Type right)
  System.Linq.Expressions.BinaryExpression LeftShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression LeftShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.BinaryExpression RightShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression RightShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.BinaryExpression And(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression AndAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.BinaryExpression Or(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression OrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.BinaryExpression ExclusiveOr(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression ExclusiveOrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.BinaryExpression Power(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method)
  System.Linq.Expressions.BinaryExpression PowerAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion)
  System.Linq.Expressions.BinaryExpression ArrayIndex(System.Linq.Expressions.Expression array, System.Linq.Expressions.Expression index)
  System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1)
  System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2)
  System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3)
  System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4)
  System.Linq.Expressions.BlockExpression Block(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions)
  System.Linq.Expressions.BlockExpression Block(System.Type type, System.Linq.Expressions.Expression[] expressions)
  System.Linq.Expressions.BlockExpression Block(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions)
  System.Linq.Expressions.BlockExpression Block(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] expressions)
  System.Linq.Expressions.BlockExpression Block(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] expressions)
  System.Linq.Expressions.BlockExpression Block(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions)
  System.Linq.Expressions.BlockExpression Block(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions)
  System.Linq.Expressions.BlockExpression BlockCore(System.Type type, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> expressions)
  System.Void ValidateVariables(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> varList, System.String collectionName)
  System.Linq.Expressions.BlockExpression GetOptimizedBlockExpression(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> expressions)
  System.Linq.Expressions.CatchBlock MakeCatchBlock(System.Type type, System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression filter)
  System.Linq.Expressions.ConditionalExpression Condition(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse)
  System.Linq.Expressions.ConditionalExpression Condition(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse, System.Type type)
  System.Linq.Expressions.ConditionalExpression IfThen(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue)
  System.Linq.Expressions.ConstantExpression Constant(System.Object value)
  System.Linq.Expressions.ConstantExpression Constant(System.Object value, System.Type type)
  System.Linq.Expressions.DefaultExpression Empty()
  System.Linq.Expressions.DefaultExpression Default(System.Type type)
  System.Void .ctor()
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Type get_Type()
  System.Boolean get_CanReduce()
  System.Linq.Expressions.Expression Reduce()
  System.Linq.Expressions.Expression VisitChildren(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Linq.Expressions.Expression ReduceAndCheck()
  System.String ToString()
  System.Void RequiresCanRead(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> items, System.String paramName)
  System.Void RequiresCanWrite(System.Linq.Expressions.Expression expression, System.String paramName)
  System.Linq.Expressions.GotoExpression Break(System.Linq.Expressions.LabelTarget target)
  System.Linq.Expressions.GotoExpression Return(System.Linq.Expressions.LabelTarget target)
  System.Linq.Expressions.GotoExpression Return(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value)
  System.Linq.Expressions.GotoExpression Goto(System.Linq.Expressions.LabelTarget target, System.Type type)
  System.Linq.Expressions.GotoExpression Goto(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value)
  System.Linq.Expressions.GotoExpression MakeGoto(System.Linq.Expressions.GotoExpressionKind kind, System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value, System.Type type)
  System.Void ValidateGoto(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression& value, System.String targetParameter, System.String valueParameter, System.Type type)
  System.Void ValidateGotoType(System.Type expectedType, System.Linq.Expressions.Expression& value, System.String paramName)
  System.Linq.Expressions.IndexExpression MakeIndex(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments)
  System.Linq.Expressions.IndexExpression ArrayAccess(System.Linq.Expressions.Expression array, System.Linq.Expressions.Expression[] indexes)
  System.Linq.Expressions.IndexExpression ArrayAccess(System.Linq.Expressions.Expression array, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> indexes)
  System.Linq.Expressions.IndexExpression Property(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments)
  System.Linq.Expressions.IndexExpression MakeIndexProperty(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, System.String paramName, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> argList)
  System.Void ValidateIndexedProperty(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, System.String paramName, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>& argList)
  System.Void ValidateAccessor(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] indexes, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>& arguments, System.String paramName)
  System.Void ValidateAccessorArgumentTypes(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] indexes, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>& arguments, System.String paramName)
  System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression)
  System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Linq.Expressions.Expression arg0)
  System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1)
  System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2)
  System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3)
  System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4)
  System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments)
  System.Reflection.MethodInfo GetInvokeMethod(System.Linq.Expressions.Expression expression)
  System.Linq.Expressions.LabelExpression Label(System.Linq.Expressions.LabelTarget target)
  System.Linq.Expressions.LabelExpression Label(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression defaultValue)
  System.Linq.Expressions.LabelTarget Label()
  System.Linq.Expressions.LabelTarget Label(System.String name)
  System.Linq.Expressions.LabelTarget Label(System.Type type)
  System.Linq.Expressions.LabelTarget Label(System.Type type, System.String name)
  System.Linq.Expressions.LambdaExpression CreateLambda(System.Type delegateType, System.Linq.Expressions.Expression body, System.String name, System.Boolean tailCall, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters)
  System.Linq.Expressions.Expression<TDelegate> Lambda(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters)
  System.Linq.Expressions.Expression<TDelegate> Lambda(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters)
  System.Linq.Expressions.Expression<TDelegate> Lambda(System.Linq.Expressions.Expression body, System.Boolean tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters)
  System.Linq.Expressions.Expression<TDelegate> Lambda(System.Linq.Expressions.Expression body, System.String name, System.Boolean tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters)
  System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters)
  System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, System.String name, System.Boolean tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters)
  System.Void ValidateLambdaArgs(System.Type delegateType, System.Linq.Expressions.Expression& body, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters, System.String paramName)
  System.Linq.Expressions.LoopExpression Loop(System.Linq.Expressions.Expression body, System.Linq.Expressions.LabelTarget break, System.Linq.Expressions.LabelTarget continue)
  System.Linq.Expressions.MemberExpression Field(System.Linq.Expressions.Expression expression, System.Reflection.FieldInfo field)
  System.Linq.Expressions.MemberExpression Field(System.Linq.Expressions.Expression expression, System.String fieldName)
  System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, System.String propertyName)
  System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, System.Reflection.PropertyInfo property)
  System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo propertyAccessor)
  System.Reflection.PropertyInfo GetProperty(System.Reflection.MethodInfo mi, System.String paramName, System.Int32 index)
  System.Boolean CheckMethod(System.Reflection.MethodInfo method, System.Reflection.MethodInfo propertyMethod)
  System.Linq.Expressions.MemberExpression MakeMemberAccess(System.Linq.Expressions.Expression expression, System.Reflection.MemberInfo member)
  System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method)
  System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0)
  System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1)
  System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2)
  System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3)
  System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4)
  System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression[] arguments)
  System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments)
  System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method)
  System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Linq.Expressions.Expression[] arguments)
  System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0)
  System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1)
  System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2)
  System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.String methodName, System.Type[] typeArguments, System.Linq.Expressions.Expression[] arguments)
  System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments)
  System.Reflection.ParameterInfo[] ValidateMethodAndGetParameters(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method)
  System.Void ValidateStaticOrInstanceMethod(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method)
  System.Void ValidateCallInstanceType(System.Type instanceType, System.Reflection.MethodInfo method)
  System.Void ValidateArgumentTypes(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>& arguments, System.String methodParamName)
  System.Reflection.ParameterInfo[] GetParametersForValidation(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind)
  System.Void ValidateArgumentCount(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind, System.Int32 count, System.Reflection.ParameterInfo[] pis)
  System.Linq.Expressions.Expression ValidateOneArgument(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind, System.Linq.Expressions.Expression arg, System.Reflection.ParameterInfo pi, System.String methodParamName, System.String argumentParamName)
  System.Boolean TryQuote(System.Type parameterType, System.Linq.Expressions.Expression& argument)
  System.Reflection.MethodInfo FindMethod(System.Type type, System.String methodName, System.Type[] typeArgs, System.Linq.Expressions.Expression[] args, System.Reflection.BindingFlags flags)
  System.Boolean IsCompatible(System.Reflection.MethodBase m, System.Linq.Expressions.Expression[] arguments)
  System.Reflection.MethodInfo ApplyTypeArgs(System.Reflection.MethodInfo m, System.Type[] typeArgs)
  System.Linq.Expressions.NewArrayExpression NewArrayInit(System.Type type, System.Linq.Expressions.Expression[] initializers)
  System.Linq.Expressions.NewArrayExpression NewArrayInit(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> initializers)
  System.Linq.Expressions.NewArrayExpression NewArrayBounds(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> bounds)
  System.Linq.Expressions.ParameterExpression Parameter(System.Type type)
  System.Linq.Expressions.ParameterExpression Parameter(System.Type type, System.String name)
  System.Linq.Expressions.ParameterExpression Variable(System.Type type, System.String name)
  System.Void Validate(System.Type type, System.Boolean allowByRef)
  System.Linq.Expressions.TryExpression TryFinally(System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression finally)
  System.Linq.Expressions.TryExpression MakeTry(System.Type type, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression finally, System.Linq.Expressions.Expression fault, System.Collections.Generic.IEnumerable<System.Linq.Expressions.CatchBlock> handlers)
  System.Void ValidateTryAndCatchHaveSameType(System.Type type, System.Linq.Expressions.Expression tryBody, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock> handlers)
  System.Linq.Expressions.TypeBinaryExpression TypeIs(System.Linq.Expressions.Expression expression, System.Type type)
  System.Linq.Expressions.TypeBinaryExpression TypeEqual(System.Linq.Expressions.Expression expression, System.Type type)
  System.Linq.Expressions.UnaryExpression MakeUnary(System.Linq.Expressions.ExpressionType unaryType, System.Linq.Expressions.Expression operand, System.Type type, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression GetUserDefinedUnaryOperatorOrThrow(System.Linq.Expressions.ExpressionType unaryType, System.String name, System.Linq.Expressions.Expression operand)
  System.Linq.Expressions.UnaryExpression GetUserDefinedUnaryOperator(System.Linq.Expressions.ExpressionType unaryType, System.String name, System.Linq.Expressions.Expression operand)
  System.Linq.Expressions.UnaryExpression GetMethodBasedUnaryOperator(System.Linq.Expressions.ExpressionType unaryType, System.Linq.Expressions.Expression operand, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression GetUserDefinedCoercionOrThrow(System.Linq.Expressions.ExpressionType coercionType, System.Linq.Expressions.Expression expression, System.Type convertToType)
  System.Linq.Expressions.UnaryExpression GetUserDefinedCoercion(System.Linq.Expressions.ExpressionType coercionType, System.Linq.Expressions.Expression expression, System.Type convertToType)
  System.Linq.Expressions.UnaryExpression GetMethodBasedCoercionOperator(System.Linq.Expressions.ExpressionType unaryType, System.Linq.Expressions.Expression operand, System.Type convertToType, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression Negate(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression UnaryPlus(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression NegateChecked(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression Not(System.Linq.Expressions.Expression expression)
  System.Linq.Expressions.UnaryExpression Not(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression IsFalse(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression IsTrue(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression OnesComplement(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression TypeAs(System.Linq.Expressions.Expression expression, System.Type type)
  System.Linq.Expressions.UnaryExpression Unbox(System.Linq.Expressions.Expression expression, System.Type type)
  System.Linq.Expressions.UnaryExpression Convert(System.Linq.Expressions.Expression expression, System.Type type)
  System.Linq.Expressions.UnaryExpression Convert(System.Linq.Expressions.Expression expression, System.Type type, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression ConvertChecked(System.Linq.Expressions.Expression expression, System.Type type, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression ArrayLength(System.Linq.Expressions.Expression array)
  System.Linq.Expressions.UnaryExpression Quote(System.Linq.Expressions.Expression expression)
  System.Linq.Expressions.UnaryExpression Throw(System.Linq.Expressions.Expression value, System.Type type)
  System.Linq.Expressions.UnaryExpression Increment(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression Decrement(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression PreIncrementAssign(System.Linq.Expressions.Expression expression)
  System.Linq.Expressions.UnaryExpression PreIncrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression PreDecrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression PostIncrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression PostDecrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method)
  System.Linq.Expressions.UnaryExpression MakeOpAssignUnary(System.Linq.Expressions.ExpressionType kind, System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.BlockExpression
TYPE:  class
TOKEN: 0x200006B
EXTENDS: Expression
FIELDS:
METHODS:
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> get_Expressions()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> get_Variables()
  System.Void .ctor()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Type get_Type()
  System.Linq.Expressions.Expression GetExpression(System.Int32 index)
  System.Int32 get_ExpressionCount()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> GetOrMakeVariables()
  System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args)
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> ReturnReadOnlyExpressions(System.Linq.Expressions.BlockExpression provider, System.Object& collection)
END_CLASS

CLASS: System.Linq.Expressions.Block2
TYPE:  class
TOKEN: 0x200006C
EXTENDS: BlockExpression
FIELDS:
  private           System.Object                   _arg0  // 0x10
  private   readonly System.Linq.Expressions.Expression_arg1  // 0x18
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1)
  System.Linq.Expressions.Expression GetExpression(System.Int32 index)
  System.Int32 get_ExpressionCount()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions()
  System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args)
END_CLASS

CLASS: System.Linq.Expressions.Block3
TYPE:  class
TOKEN: 0x200006D
EXTENDS: BlockExpression
FIELDS:
  private           System.Object                   _arg0  // 0x10
  private   readonly System.Linq.Expressions.Expression_arg1  // 0x18
  private   readonly System.Linq.Expressions.Expression_arg2  // 0x20
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2)
  System.Linq.Expressions.Expression GetExpression(System.Int32 index)
  System.Int32 get_ExpressionCount()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions()
  System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args)
END_CLASS

CLASS: System.Linq.Expressions.Block4
TYPE:  class
TOKEN: 0x200006E
EXTENDS: BlockExpression
FIELDS:
  private           System.Object                   _arg0  // 0x10
  private   readonly System.Linq.Expressions.Expression_arg1  // 0x18
  private   readonly System.Linq.Expressions.Expression_arg2  // 0x20
  private   readonly System.Linq.Expressions.Expression_arg3  // 0x28
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3)
  System.Linq.Expressions.Expression GetExpression(System.Int32 index)
  System.Int32 get_ExpressionCount()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions()
  System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args)
END_CLASS

CLASS: System.Linq.Expressions.Block5
TYPE:  class
TOKEN: 0x200006F
EXTENDS: BlockExpression
FIELDS:
  private           System.Object                   _arg0  // 0x10
  private   readonly System.Linq.Expressions.Expression_arg1  // 0x18
  private   readonly System.Linq.Expressions.Expression_arg2  // 0x20
  private   readonly System.Linq.Expressions.Expression_arg3  // 0x28
  private   readonly System.Linq.Expressions.Expression_arg4  // 0x30
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4)
  System.Linq.Expressions.Expression GetExpression(System.Int32 index)
  System.Int32 get_ExpressionCount()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions()
  System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args)
END_CLASS

CLASS: System.Linq.Expressions.BlockN
TYPE:  class
TOKEN: 0x2000070
EXTENDS: BlockExpression
FIELDS:
  private           System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression>_expressions  // 0x10
METHODS:
  System.Void .ctor(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> expressions)
  System.Linq.Expressions.Expression GetExpression(System.Int32 index)
  System.Int32 get_ExpressionCount()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions()
  System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args)
END_CLASS

CLASS: System.Linq.Expressions.ScopeExpression
TYPE:  class
TOKEN: 0x2000071
EXTENDS: BlockExpression
FIELDS:
  private           System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression>_variables  // 0x10
METHODS:
  System.Void .ctor(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> variables)
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> GetOrMakeVariables()
  System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> get_VariablesList()
  System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> ReuseOrValidateVariables(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables)
END_CLASS

CLASS: System.Linq.Expressions.Scope1
TYPE:  class
TOKEN: 0x2000072
EXTENDS: ScopeExpression
FIELDS:
  private           System.Object                   _body  // 0x18
METHODS:
  System.Void .ctor(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression body)
  System.Void .ctor(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> variables, System.Object body)
  System.Linq.Expressions.Expression GetExpression(System.Int32 index)
  System.Int32 get_ExpressionCount()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions()
  System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args)
END_CLASS

CLASS: System.Linq.Expressions.ScopeN
TYPE:  class
TOKEN: 0x2000073
EXTENDS: ScopeExpression
FIELDS:
  private           System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression>_body  // 0x18
METHODS:
  System.Void .ctor(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> variables, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> body)
  System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> get_Body()
  System.Linq.Expressions.Expression GetExpression(System.Int32 index)
  System.Int32 get_ExpressionCount()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions()
  System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args)
END_CLASS

CLASS: System.Linq.Expressions.ScopeWithType
TYPE:  class
TOKEN: 0x2000074
EXTENDS: ScopeN
FIELDS:
  private   readonly System.Type                     <Type>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> variables, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> expressions, System.Type type)
  System.Type get_Type()
  System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args)
END_CLASS

CLASS: System.Linq.Expressions.BlockExpressionList
TYPE:  class
TOKEN: 0x2000075
FIELDS:
  private   readonly System.Linq.Expressions.BlockExpression_block  // 0x10
  private   readonly System.Linq.Expressions.Expression_arg0  // 0x18
METHODS:
  System.Void .ctor(System.Linq.Expressions.BlockExpression provider, System.Linq.Expressions.Expression arg0)
  System.Int32 IndexOf(System.Linq.Expressions.Expression item)
  System.Void Insert(System.Int32 index, System.Linq.Expressions.Expression item)
  System.Void RemoveAt(System.Int32 index)
  System.Linq.Expressions.Expression get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Linq.Expressions.Expression value)
  System.Void Add(System.Linq.Expressions.Expression item)
  System.Void Clear()
  System.Boolean Contains(System.Linq.Expressions.Expression item)
  System.Void CopyTo(System.Linq.Expressions.Expression[] array, System.Int32 index)
  System.Int32 get_Count()
  System.Boolean get_IsReadOnly()
  System.Boolean Remove(System.Linq.Expressions.Expression item)
  System.Collections.Generic.IEnumerator<System.Linq.Expressions.Expression> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
END_CLASS

CLASS: System.Linq.Expressions.CatchBlock
TYPE:  class
TOKEN: 0x2000077
FIELDS:
  private   readonly System.Linq.Expressions.ParameterExpression<Variable>k__BackingField  // 0x10
  private   readonly System.Type                     <Test>k__BackingField  // 0x18
  private   readonly System.Linq.Expressions.Expression<Body>k__BackingField  // 0x20
  private   readonly System.Linq.Expressions.Expression<Filter>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(System.Type test, System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression filter)
  System.Linq.Expressions.ParameterExpression get_Variable()
  System.Type get_Test()
  System.Linq.Expressions.Expression get_Body()
  System.Linq.Expressions.Expression get_Filter()
  System.String ToString()
  System.Linq.Expressions.CatchBlock Update(System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Expression filter, System.Linq.Expressions.Expression body)
END_CLASS

CLASS: System.Linq.Expressions.ArrayBuilderExtensions
TYPE:  class
TOKEN: 0x2000078
FIELDS:
METHODS:
  System.Collections.ObjectModel.ReadOnlyCollection<T> ToReadOnly(System.Collections.Generic.ArrayBuilder<T> builder)
END_CLASS

CLASS: System.Linq.Expressions.AnalyzeTypeIsResult
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Linq.Expressions.AnalyzeTypeIsResultKnownFalse  // 0x0
  public    static  System.Linq.Expressions.AnalyzeTypeIsResultKnownTrue  // 0x0
  public    static  System.Linq.Expressions.AnalyzeTypeIsResultKnownAssignable  // 0x0
  public    static  System.Linq.Expressions.AnalyzeTypeIsResultUnknown  // 0x0
METHODS:
END_CLASS

CLASS: System.Linq.Expressions.ConstantCheck
TYPE:  class
TOKEN: 0x200007A
FIELDS:
METHODS:
  System.Linq.Expressions.AnalyzeTypeIsResult AnalyzeTypeIs(System.Linq.Expressions.TypeBinaryExpression typeIs)
  System.Linq.Expressions.AnalyzeTypeIsResult AnalyzeTypeIs(System.Linq.Expressions.Expression operand, System.Type testType)
END_CLASS

CLASS: System.Linq.Expressions.ConditionalExpression
TYPE:  class
TOKEN: 0x200007B
EXTENDS: Expression
FIELDS:
  private   readonly System.Linq.Expressions.Expression<Test>k__BackingField  // 0x10
  private   readonly System.Linq.Expressions.Expression<IfTrue>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue)
  System.Linq.Expressions.ConditionalExpression Make(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse, System.Type type)
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Type get_Type()
  System.Linq.Expressions.Expression get_Test()
  System.Linq.Expressions.Expression get_IfTrue()
  System.Linq.Expressions.Expression get_IfFalse()
  System.Linq.Expressions.Expression GetFalse()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Linq.Expressions.ConditionalExpression Update(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse)
END_CLASS

CLASS: System.Linq.Expressions.FullConditionalExpression
TYPE:  class
TOKEN: 0x200007C
EXTENDS: ConditionalExpression
FIELDS:
  private   readonly System.Linq.Expressions.Expression_false  // 0x20
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse)
  System.Linq.Expressions.Expression GetFalse()
END_CLASS

CLASS: System.Linq.Expressions.FullConditionalExpressionWithType
TYPE:  class
TOKEN: 0x200007D
EXTENDS: FullConditionalExpression
FIELDS:
  private   readonly System.Type                     <Type>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse, System.Type type)
  System.Type get_Type()
END_CLASS

CLASS: System.Linq.Expressions.ConstantExpression
TYPE:  class
TOKEN: 0x200007E
EXTENDS: Expression
FIELDS:
  private   readonly System.Object                   <Value>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Object value)
  System.Type get_Type()
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Object get_Value()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
END_CLASS

CLASS: System.Linq.Expressions.TypedConstantExpression
TYPE:  class
TOKEN: 0x200007F
EXTENDS: ConstantExpression
FIELDS:
  private   readonly System.Type                     <Type>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Object value, System.Type type)
  System.Type get_Type()
END_CLASS

CLASS: System.Linq.Expressions.DebugInfoExpression
TYPE:  class
TOKEN: 0x2000080
EXTENDS: Expression
FIELDS:
  private   readonly System.Linq.Expressions.SymbolDocumentInfo<Document>k__BackingField  // 0x10
METHODS:
  System.Int32 get_StartLine()
  System.Int32 get_EndLine()
  System.Linq.Expressions.SymbolDocumentInfo get_Document()
  System.Boolean get_IsClear()
END_CLASS

CLASS: System.Linq.Expressions.DefaultExpression
TYPE:  class
TOKEN: 0x2000081
EXTENDS: Expression
FIELDS:
  private   readonly System.Type                     <Type>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Type type)
  System.Type get_Type()
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
END_CLASS

CLASS: System.Linq.Expressions.ElementInit
TYPE:  class
TOKEN: 0x2000082
FIELDS:
  private   readonly System.Reflection.MethodInfo    <AddMethod>k__BackingField  // 0x10
  private   readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression><Arguments>k__BackingField  // 0x18
METHODS:
  System.Reflection.MethodInfo get_AddMethod()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> get_Arguments()
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
END_CLASS

CLASS: System.Linq.Expressions.Error
TYPE:  class
TOKEN: 0x2000083
FIELDS:
METHODS:
  System.Exception ReducibleMustOverrideReduce()
  System.Exception InvalidMetaObjectCreated(System.Object p0)
  System.Exception AmbiguousMatchInExpandoObject(System.Object p0)
  System.Exception SameKeyExistsInExpando(System.Object key)
  System.Exception KeyDoesNotExistInExpando(System.Object p0)
  System.Exception CollectionModifiedWhileEnumerating()
  System.Exception CollectionReadOnly()
  System.Exception MustReduceToDifferent()
  System.Exception BinderNotCompatibleWithCallSite(System.Object p0, System.Object p1, System.Object p2)
  System.Exception DynamicBindingNeedsRestrictions(System.Object p0, System.Object p1)
  System.Exception DynamicObjectResultNotAssignable(System.Object p0, System.Object p1, System.Object p2, System.Object p3)
  System.Exception DynamicBinderResultNotAssignable(System.Object p0, System.Object p1, System.Object p2)
  System.Exception BindingCannotBeNull()
  System.Exception ReducedNotCompatible()
  System.Exception SetterHasNoParams(System.String paramName)
  System.Exception PropertyCannotHaveRefType(System.String paramName)
  System.Exception IndexesOfSetGetMustMatch(System.String paramName)
  System.Exception TypeParameterIsNotDelegate(System.Object p0)
  System.Exception FirstArgumentMustBeCallSite()
  System.Exception AccessorsCannotHaveVarArgs(System.String paramName)
  System.Exception AccessorsCannotHaveByRefArgs(System.String paramName)
  System.Exception AccessorsCannotHaveByRefArgs(System.String paramName, System.Int32 index)
  System.Exception TypeMustBeDerivedFromSystemDelegate()
  System.Exception NoOrInvalidRuleProduced()
  System.Exception BoundsCannotBeLessThanOne(System.String paramName)
  System.Exception TypeMustNotBeByRef(System.String paramName)
  System.Exception TypeMustNotBePointer(System.String paramName)
  System.Exception SetterMustBeVoid(System.String paramName)
  System.Exception PropertyTypeMustMatchGetter(System.String paramName)
  System.Exception PropertyTypeMustMatchSetter(System.String paramName)
  System.Exception BothAccessorsMustBeStatic(System.String paramName)
  System.Exception OnlyStaticFieldsHaveNullInstance(System.String paramName)
  System.Exception OnlyStaticPropertiesHaveNullInstance(System.String paramName)
  System.Exception OnlyStaticMethodsHaveNullInstance()
  System.Exception PropertyTypeCannotBeVoid(System.String paramName)
  System.Exception InvalidUnboxType(System.String paramName)
  System.Exception ExpressionMustBeWriteable(System.String paramName)
  System.Exception ArgumentMustNotHaveValueType(System.String paramName)
  System.Exception MustBeReducible()
  System.Exception LabelMustBeVoidOrHaveExpression(System.String paramName)
  System.Exception LabelTypeMustBeVoid(System.String paramName)
  System.Exception QuotedExpressionMustBeLambda(System.String paramName)
  System.Exception VariableMustNotBeByRef(System.Object p0, System.Object p1, System.String paramName)
  System.Exception VariableMustNotBeByRef(System.Object p0, System.Object p1, System.String paramName, System.Int32 index)
  System.Exception DuplicateVariable(System.Object p0, System.String paramName)
  System.Exception DuplicateVariable(System.Object p0, System.String paramName, System.Int32 index)
  System.Exception FaultCannotHaveCatchOrFinally(System.String paramName)
  System.Exception TryMustHaveCatchFinallyOrFault()
  System.Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry()
  System.Exception ExtensionNodeMustOverrideProperty(System.Object p0)
  System.Exception UserDefinedOperatorMustBeStatic(System.Object p0, System.String paramName)
  System.Exception UserDefinedOperatorMustNotBeVoid(System.Object p0, System.String paramName)
  System.Exception CoercionOperatorNotDefined(System.Object p0, System.Object p1)
  System.Exception UnaryOperatorNotDefined(System.Object p0, System.Object p1)
  System.Exception BinaryOperatorNotDefined(System.Object p0, System.Object p1, System.Object p2)
  System.Exception ReferenceEqualityNotDefined(System.Object p0, System.Object p1)
  System.Exception OperandTypesDoNotMatchParameters(System.Object p0, System.Object p1)
  System.Exception OverloadOperatorTypeDoesNotMatchConversionType(System.Object p0, System.Object p1)
  System.Exception ConversionIsNotSupportedForArithmeticTypes()
  System.Exception ArgumentMustBeArray(System.String paramName)
  System.Exception ArgumentMustBeBoolean(System.String paramName)
  System.Exception ArgumentMustBeInteger(System.String paramName)
  System.Exception ArgumentMustBeInteger(System.String paramName, System.Int32 index)
  System.Exception ArgumentMustBeArrayIndexType(System.String paramName)
  System.Exception ArgumentMustBeSingleDimensionalArrayType(System.String paramName)
  System.Exception ArgumentTypesMustMatch()
  System.Exception CannotAutoInitializeValueTypeMemberThroughProperty(System.Object p0)
  System.Exception IncorrectTypeForTypeAs(System.Object p0, System.String paramName)
  System.Exception CoalesceUsedOnNonNullType()
  System.Exception ExpressionTypeCannotInitializeArrayType(System.Object p0, System.Object p1)
  System.Exception ExpressionTypeDoesNotMatchReturn(System.Object p0, System.Object p1)
  System.Exception ExpressionTypeDoesNotMatchAssignment(System.Object p0, System.Object p1)
  System.Exception ExpressionTypeDoesNotMatchLabel(System.Object p0, System.Object p1)
  System.Exception ExpressionTypeNotInvocable(System.Object p0, System.String paramName)
  System.Exception InstanceFieldNotDefinedForType(System.Object p0, System.Object p1)
  System.Exception FieldInfoNotDefinedForType(System.Object p0, System.Object p1, System.Object p2)
  System.Exception IncorrectNumberOfIndexes()
  System.Exception IncorrectNumberOfLambdaDeclarationParameters()
  System.Exception LambdaTypeMustBeDerivedFromSystemDelegate(System.String paramName)
  System.Exception MemberNotFieldOrProperty(System.Object p0, System.String paramName)
  System.Exception MethodContainsGenericParameters(System.Object p0, System.String paramName)
  System.Exception MethodIsGeneric(System.Object p0, System.String paramName)
  System.Exception MethodNotPropertyAccessor(System.Object p0, System.Object p1, System.String paramName)
  System.Exception MethodNotPropertyAccessor(System.Object p0, System.Object p1, System.String paramName, System.Int32 index)
  System.Exception PropertyDoesNotHaveAccessor(System.Object p0, System.String paramName)
  System.Exception ParameterExpressionNotValidAsDelegate(System.Object p0, System.Object p1)
  System.Exception PropertyNotDefinedForType(System.Object p0, System.Object p1, System.String paramName)
  System.Exception InstancePropertyNotDefinedForType(System.Object p0, System.Object p1, System.String paramName)
  System.Exception InstanceAndMethodTypeMismatch(System.Object p0, System.Object p1, System.Object p2)
  System.Exception UnhandledBinary(System.Object p0, System.String paramName)
  System.Exception UnhandledUnary(System.Object p0, System.String paramName)
  System.Exception UserDefinedOpMustHaveConsistentTypes(System.Object p0, System.Object p1)
  System.Exception UserDefinedOpMustHaveValidReturnType(System.Object p0, System.Object p1)
  System.Exception LogicalOperatorMustHaveBooleanOperators(System.Object p0, System.Object p1)
  System.Exception MethodWithArgsDoesNotExistOnType(System.Object p0, System.Object p1)
  System.Exception GenericMethodWithArgsDoesNotExistOnType(System.Object p0, System.Object p1)
  System.Exception MethodWithMoreThanOneMatch(System.Object p0, System.Object p1)
  System.Exception ArgumentCannotBeOfTypeVoid(System.String paramName)
  System.Exception OutOfRange(System.String paramName, System.Object p1)
  System.Exception LabelTargetAlreadyDefined(System.Object p0)
  System.Exception LabelTargetUndefined(System.Object p0)
  System.Exception ControlCannotLeaveFinally()
  System.Exception ControlCannotLeaveFilterTest()
  System.Exception AmbiguousJump(System.Object p0)
  System.Exception ControlCannotEnterTry()
  System.Exception ControlCannotEnterExpression()
  System.Exception NonLocalJumpWithValue(System.Object p0)
  System.Exception InvalidLvalue(System.Linq.Expressions.ExpressionType p0)
  System.Exception RethrowRequiresCatch()
  System.Exception MustRewriteToSameNode(System.Object p0, System.Object p1, System.Object p2)
  System.Exception MustRewriteChildToSameType(System.Object p0, System.Object p1, System.Object p2)
  System.Exception MustRewriteWithoutMethod(System.Object p0, System.Object p1)
  System.Exception ArgumentOutOfRange(System.String paramName)
  System.Exception NotSupported()
  System.Exception NonAbstractConstructorRequired()
  System.Exception InvalidProgram()
  System.Exception EnumerationIsDone()
  System.Exception TypeContainsGenericParameters(System.Object p0, System.String paramName)
  System.Exception TypeContainsGenericParameters(System.Object p0, System.String paramName, System.Int32 index)
  System.Exception TypeIsGeneric(System.Object p0, System.String paramName)
  System.Exception TypeIsGeneric(System.Object p0, System.String paramName, System.Int32 index)
  System.Exception IncorrectNumberOfConstructorArguments()
  System.Exception ExpressionTypeDoesNotMatchMethodParameter(System.Object p0, System.Object p1, System.Object p2, System.String paramName)
  System.Exception ExpressionTypeDoesNotMatchMethodParameter(System.Object p0, System.Object p1, System.Object p2, System.String paramName, System.Int32 index)
  System.Exception ExpressionTypeDoesNotMatchParameter(System.Object p0, System.Object p1, System.String paramName)
  System.Exception ExpressionTypeDoesNotMatchParameter(System.Object p0, System.Object p1, System.String paramName, System.Int32 index)
  System.Exception IncorrectNumberOfLambdaArguments()
  System.Exception IncorrectNumberOfMethodCallArguments(System.Object p0, System.String paramName)
  System.Exception ExpressionTypeDoesNotMatchConstructorParameter(System.Object p0, System.Object p1, System.String paramName)
  System.Exception ExpressionTypeDoesNotMatchConstructorParameter(System.Object p0, System.Object p1, System.String paramName, System.Int32 index)
  System.Exception ExpressionMustBeReadable(System.String paramName)
  System.Exception ExpressionMustBeReadable(System.String paramName, System.Int32 index)
  System.Exception InvalidArgumentValue(System.String paramName)
  System.Exception InvalidNullValue(System.Type type, System.String paramName)
  System.Exception InvalidTypeException(System.Object value, System.Type type, System.String paramName)
  System.String GetParamName(System.String paramName, System.Int32 index)
END_CLASS

CLASS: System.Linq.Expressions.ExpressionStringBuilder
TYPE:  class
TOKEN: 0x2000084
EXTENDS: ExpressionVisitor
FIELDS:
  private   readonly System.Text.StringBuilder       _out  // 0x10
  private           System.Collections.Generic.Dictionary<System.Object,System.Int32>_ids  // 0x18
METHODS:
  System.Void .ctor()
  System.String ToString()
  System.Int32 GetLabelId(System.Linq.Expressions.LabelTarget label)
  System.Int32 GetParamId(System.Linq.Expressions.ParameterExpression p)
  System.Int32 GetId(System.Object o)
  System.Void Out(System.String s)
  System.Void Out(System.Char c)
  System.String ExpressionToString(System.Linq.Expressions.Expression node)
  System.String CatchBlockToString(System.Linq.Expressions.CatchBlock node)
  System.Void VisitExpressions(System.Char open, System.Collections.ObjectModel.ReadOnlyCollection<T> expressions, System.Char close)
  System.Void VisitExpressions(System.Char open, System.Collections.ObjectModel.ReadOnlyCollection<T> expressions, System.Char close, System.String seperator)
  System.Linq.Expressions.Expression VisitBinary(System.Linq.Expressions.BinaryExpression node)
  System.Linq.Expressions.Expression VisitParameter(System.Linq.Expressions.ParameterExpression node)
  System.Linq.Expressions.Expression VisitLambda(System.Linq.Expressions.Expression<T> node)
  System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node)
  System.Linq.Expressions.Expression VisitConstant(System.Linq.Expressions.ConstantExpression node)
  System.Void OutMember(System.Linq.Expressions.Expression instance, System.Reflection.MemberInfo member)
  System.Linq.Expressions.Expression VisitMember(System.Linq.Expressions.MemberExpression node)
  System.Linq.Expressions.Expression VisitInvocation(System.Linq.Expressions.InvocationExpression node)
  System.Linq.Expressions.Expression VisitMethodCall(System.Linq.Expressions.MethodCallExpression node)
  System.Linq.Expressions.Expression VisitNewArray(System.Linq.Expressions.NewArrayExpression node)
  System.Linq.Expressions.Expression VisitTypeBinary(System.Linq.Expressions.TypeBinaryExpression node)
  System.Linq.Expressions.Expression VisitUnary(System.Linq.Expressions.UnaryExpression node)
  System.Linq.Expressions.Expression VisitBlock(System.Linq.Expressions.BlockExpression node)
  System.Linq.Expressions.Expression VisitDefault(System.Linq.Expressions.DefaultExpression node)
  System.Linq.Expressions.Expression VisitLabel(System.Linq.Expressions.LabelExpression node)
  System.Linq.Expressions.Expression VisitGoto(System.Linq.Expressions.GotoExpression node)
  System.Linq.Expressions.Expression VisitLoop(System.Linq.Expressions.LoopExpression node)
  System.Linq.Expressions.CatchBlock VisitCatchBlock(System.Linq.Expressions.CatchBlock node)
  System.Linq.Expressions.Expression VisitTry(System.Linq.Expressions.TryExpression node)
  System.Linq.Expressions.Expression VisitIndex(System.Linq.Expressions.IndexExpression node)
  System.Linq.Expressions.Expression VisitExtension(System.Linq.Expressions.Expression node)
  System.Void DumpLabel(System.Linq.Expressions.LabelTarget target)
  System.Boolean IsBool(System.Linq.Expressions.Expression node)
END_CLASS

CLASS: System.Linq.Expressions.ExpressionType
TYPE:  struct
TOKEN: 0x2000085
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Linq.Expressions.ExpressionTypeAdd  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeAddChecked  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeAnd  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeAndAlso  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeArrayLength  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeArrayIndex  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeCall  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeCoalesce  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeConditional  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeConstant  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeConvert  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeConvertChecked  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeDivide  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeEqual  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeExclusiveOr  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeGreaterThan  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeGreaterThanOrEqual  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeInvoke  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeLambda  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeLeftShift  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeLessThan  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeLessThanOrEqual  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeListInit  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeMemberAccess  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeMemberInit  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeModulo  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeMultiply  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeMultiplyChecked  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeNegate  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeUnaryPlus  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeNegateChecked  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeNew  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeNewArrayInit  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeNewArrayBounds  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeNot  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeNotEqual  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeOr  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeOrElse  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeParameter  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypePower  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeQuote  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeRightShift  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeSubtract  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeSubtractChecked  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeTypeAs  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeTypeIs  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeBlock  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeDebugInfo  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeDecrement  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeDynamic  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeDefault  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeExtension  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeGoto  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeIncrement  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeIndex  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeLabel  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeRuntimeVariables  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeLoop  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeSwitch  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeThrow  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeTry  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeUnbox  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeAddAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeAndAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeDivideAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeExclusiveOrAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeLeftShiftAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeModuloAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeMultiplyAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeOrAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypePowerAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeRightShiftAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeSubtractAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeAddAssignChecked  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeMultiplyAssignChecked  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeSubtractAssignChecked  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypePreIncrementAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypePreDecrementAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypePostIncrementAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypePostDecrementAssign  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeTypeEqual  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeOnesComplement  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeIsTrue  // 0x0
  public    static  System.Linq.Expressions.ExpressionTypeIsFalse  // 0x0
METHODS:
END_CLASS

CLASS: System.Linq.Expressions.ExpressionVisitor
TYPE:  class
TOKEN: 0x2000086
FIELDS:
METHODS:
  System.Void .ctor()
  System.Linq.Expressions.Expression Visit(System.Linq.Expressions.Expression node)
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Visit(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> nodes)
  System.Linq.Expressions.Expression[] VisitArguments(System.Linq.Expressions.IArgumentProvider nodes)
  System.Linq.Expressions.ParameterExpression[] VisitParameters(System.Linq.Expressions.IParameterProvider nodes, System.String callerName)
  System.Collections.ObjectModel.ReadOnlyCollection<T> Visit(System.Collections.ObjectModel.ReadOnlyCollection<T> nodes, System.Func<T,T> elementVisitor)
  T VisitAndConvert(T node, System.String callerName)
  System.Collections.ObjectModel.ReadOnlyCollection<T> VisitAndConvert(System.Collections.ObjectModel.ReadOnlyCollection<T> nodes, System.String callerName)
  System.Linq.Expressions.Expression VisitBinary(System.Linq.Expressions.BinaryExpression node)
  System.Linq.Expressions.Expression VisitBlock(System.Linq.Expressions.BlockExpression node)
  System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node)
  System.Linq.Expressions.Expression VisitConstant(System.Linq.Expressions.ConstantExpression node)
  System.Linq.Expressions.Expression VisitDefault(System.Linq.Expressions.DefaultExpression node)
  System.Linq.Expressions.Expression VisitExtension(System.Linq.Expressions.Expression node)
  System.Linq.Expressions.Expression VisitGoto(System.Linq.Expressions.GotoExpression node)
  System.Linq.Expressions.Expression VisitInvocation(System.Linq.Expressions.InvocationExpression node)
  System.Linq.Expressions.LabelTarget VisitLabelTarget(System.Linq.Expressions.LabelTarget node)
  System.Linq.Expressions.Expression VisitLabel(System.Linq.Expressions.LabelExpression node)
  System.Linq.Expressions.Expression VisitLambda(System.Linq.Expressions.Expression<T> node)
  System.Linq.Expressions.Expression VisitLoop(System.Linq.Expressions.LoopExpression node)
  System.Linq.Expressions.Expression VisitMember(System.Linq.Expressions.MemberExpression node)
  System.Linq.Expressions.Expression VisitIndex(System.Linq.Expressions.IndexExpression node)
  System.Linq.Expressions.Expression VisitMethodCall(System.Linq.Expressions.MethodCallExpression node)
  System.Linq.Expressions.Expression VisitNewArray(System.Linq.Expressions.NewArrayExpression node)
  System.Linq.Expressions.Expression VisitParameter(System.Linq.Expressions.ParameterExpression node)
  System.Linq.Expressions.CatchBlock VisitCatchBlock(System.Linq.Expressions.CatchBlock node)
  System.Linq.Expressions.Expression VisitTry(System.Linq.Expressions.TryExpression node)
  System.Linq.Expressions.Expression VisitTypeBinary(System.Linq.Expressions.TypeBinaryExpression node)
  System.Linq.Expressions.Expression VisitUnary(System.Linq.Expressions.UnaryExpression node)
  System.Linq.Expressions.UnaryExpression ValidateUnary(System.Linq.Expressions.UnaryExpression before, System.Linq.Expressions.UnaryExpression after)
  System.Linq.Expressions.BinaryExpression ValidateBinary(System.Linq.Expressions.BinaryExpression before, System.Linq.Expressions.BinaryExpression after)
  System.Void ValidateChildType(System.Type before, System.Type after, System.String methodName)
END_CLASS

CLASS: System.Linq.Expressions.GotoExpressionKind
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Linq.Expressions.GotoExpressionKindGoto  // 0x0
  public    static  System.Linq.Expressions.GotoExpressionKindReturn  // 0x0
  public    static  System.Linq.Expressions.GotoExpressionKindBreak  // 0x0
  public    static  System.Linq.Expressions.GotoExpressionKindContinue  // 0x0
METHODS:
END_CLASS

CLASS: System.Linq.Expressions.GotoExpression
TYPE:  class
TOKEN: 0x2000088
EXTENDS: Expression
FIELDS:
  private   readonly System.Type                     <Type>k__BackingField  // 0x10
  private   readonly System.Linq.Expressions.Expression<Value>k__BackingField  // 0x18
  private   readonly System.Linq.Expressions.LabelTarget<Target>k__BackingField  // 0x20
  private   readonly System.Linq.Expressions.GotoExpressionKind<Kind>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(System.Linq.Expressions.GotoExpressionKind kind, System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value, System.Type type)
  System.Type get_Type()
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Linq.Expressions.Expression get_Value()
  System.Linq.Expressions.LabelTarget get_Target()
  System.Linq.Expressions.GotoExpressionKind get_Kind()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Linq.Expressions.GotoExpression Update(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value)
END_CLASS

CLASS: System.Linq.Expressions.IArgumentProvider
TYPE:  interface
TOKEN: 0x2000089
FIELDS:
METHODS:
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
END_CLASS

CLASS: System.Linq.Expressions.IParameterProvider
TYPE:  interface
TOKEN: 0x200008A
FIELDS:
METHODS:
  System.Linq.Expressions.ParameterExpression GetParameter(System.Int32 index)
  System.Int32 get_ParameterCount()
END_CLASS

CLASS: System.Linq.Expressions.IndexExpression
TYPE:  class
TOKEN: 0x200008B
EXTENDS: Expression
FIELDS:
  private           System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression>_arguments  // 0x10
  private   readonly System.Linq.Expressions.Expression<Object>k__BackingField  // 0x18
  private   readonly System.Reflection.PropertyInfo  <Indexer>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> arguments)
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Type get_Type()
  System.Linq.Expressions.Expression get_Object()
  System.Reflection.PropertyInfo get_Indexer()
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Linq.Expressions.Expression Rewrite(System.Linq.Expressions.Expression instance, System.Linq.Expressions.Expression[] arguments)
END_CLASS

CLASS: System.Linq.Expressions.InvocationExpression
TYPE:  class
TOKEN: 0x200008C
EXTENDS: Expression
FIELDS:
  private   readonly System.Type                     <Type>k__BackingField  // 0x10
  private   readonly System.Linq.Expressions.Expression<Expression>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression expression, System.Type returnType)
  System.Type get_Type()
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Linq.Expressions.Expression get_Expression()
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments)
END_CLASS

CLASS: System.Linq.Expressions.InvocationExpressionN
TYPE:  class
TOKEN: 0x200008D
EXTENDS: InvocationExpression
FIELDS:
  private           System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression>_arguments  // 0x20
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression lambda, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> arguments, System.Type returnType)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments)
END_CLASS

CLASS: System.Linq.Expressions.InvocationExpression0
TYPE:  class
TOKEN: 0x200008E
EXTENDS: InvocationExpression
FIELDS:
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression lambda, System.Type returnType)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments)
END_CLASS

CLASS: System.Linq.Expressions.InvocationExpression1
TYPE:  class
TOKEN: 0x200008F
EXTENDS: InvocationExpression
FIELDS:
  private           System.Object                   _arg0  // 0x20
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression lambda, System.Type returnType, System.Linq.Expressions.Expression arg0)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments)
END_CLASS

CLASS: System.Linq.Expressions.InvocationExpression2
TYPE:  class
TOKEN: 0x2000090
EXTENDS: InvocationExpression
FIELDS:
  private           System.Object                   _arg0  // 0x20
  private   readonly System.Linq.Expressions.Expression_arg1  // 0x28
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression lambda, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments)
END_CLASS

CLASS: System.Linq.Expressions.InvocationExpression3
TYPE:  class
TOKEN: 0x2000091
EXTENDS: InvocationExpression
FIELDS:
  private           System.Object                   _arg0  // 0x20
  private   readonly System.Linq.Expressions.Expression_arg1  // 0x28
  private   readonly System.Linq.Expressions.Expression_arg2  // 0x30
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression lambda, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments)
END_CLASS

CLASS: System.Linq.Expressions.InvocationExpression4
TYPE:  class
TOKEN: 0x2000092
EXTENDS: InvocationExpression
FIELDS:
  private           System.Object                   _arg0  // 0x20
  private   readonly System.Linq.Expressions.Expression_arg1  // 0x28
  private   readonly System.Linq.Expressions.Expression_arg2  // 0x30
  private   readonly System.Linq.Expressions.Expression_arg3  // 0x38
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression lambda, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments)
END_CLASS

CLASS: System.Linq.Expressions.InvocationExpression5
TYPE:  class
TOKEN: 0x2000093
EXTENDS: InvocationExpression
FIELDS:
  private           System.Object                   _arg0  // 0x20
  private   readonly System.Linq.Expressions.Expression_arg1  // 0x28
  private   readonly System.Linq.Expressions.Expression_arg2  // 0x30
  private   readonly System.Linq.Expressions.Expression_arg3  // 0x38
  private   readonly System.Linq.Expressions.Expression_arg4  // 0x40
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression lambda, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments)
END_CLASS

CLASS: System.Linq.Expressions.LabelExpression
TYPE:  class
TOKEN: 0x2000094
EXTENDS: Expression
FIELDS:
  private   readonly System.Linq.Expressions.LabelTarget<Target>k__BackingField  // 0x10
  private   readonly System.Linq.Expressions.Expression<DefaultValue>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Linq.Expressions.LabelTarget label, System.Linq.Expressions.Expression defaultValue)
  System.Type get_Type()
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Linq.Expressions.LabelTarget get_Target()
  System.Linq.Expressions.Expression get_DefaultValue()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Linq.Expressions.LabelExpression Update(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression defaultValue)
END_CLASS

CLASS: System.Linq.Expressions.LabelTarget
TYPE:  class
TOKEN: 0x2000095
FIELDS:
  private   readonly System.String                   <Name>k__BackingField  // 0x10
  private   readonly System.Type                     <Type>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Type type, System.String name)
  System.String get_Name()
  System.Type get_Type()
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.LambdaExpression
TYPE:  class
TOKEN: 0x2000096
EXTENDS: Expression
FIELDS:
  private   readonly System.Linq.Expressions.Expression_body  // 0x10
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression body)
  System.Type get_Type()
  System.Type get_TypeCore()
  System.Type get_PublicType()
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.String get_Name()
  System.String get_NameCore()
  System.Linq.Expressions.Expression get_Body()
  System.Type get_ReturnType()
  System.Boolean get_TailCall()
  System.Boolean get_TailCallCore()
  System.Linq.Expressions.ParameterExpression System.Linq.Expressions.IParameterProvider.GetParameter(System.Int32 index)
  System.Linq.Expressions.ParameterExpression GetParameter(System.Int32 index)
  System.Int32 System.Linq.Expressions.IParameterProvider.get_ParameterCount()
  System.Int32 get_ParameterCount()
END_CLASS

CLASS: System.Linq.Expressions.Expression`1
TYPE:  class
TOKEN: 0x2000097
EXTENDS: LambdaExpression
FIELDS:
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression body)
  System.Type get_TypeCore()
  System.Type get_PublicType()
  TDelegate Compile()
  TDelegate Compile(System.Boolean preferInterpretation)
  System.Linq.Expressions.Expression<TDelegate> Rewrite(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters)
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
END_CLASS

CLASS: System.Linq.Expressions.ExpressionCreator`1
TYPE:  class
TOKEN: 0x2000098
FIELDS:
METHODS:
  System.Linq.Expressions.LambdaExpression CreateExpressionFunc(System.Linq.Expressions.Expression body, System.String name, System.Boolean tailCall, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters)
END_CLASS

CLASS: System.Linq.Expressions.Expression0`1
TYPE:  class
TOKEN: 0x2000099
EXTENDS: Expression`1
FIELDS:
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression body)
  System.Int32 get_ParameterCount()
  System.Linq.Expressions.ParameterExpression GetParameter(System.Int32 index)
  System.Linq.Expressions.Expression<TDelegate> Rewrite(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters)
END_CLASS

CLASS: System.Linq.Expressions.Expression1`1
TYPE:  class
TOKEN: 0x200009A
EXTENDS: Expression`1
FIELDS:
  private           System.Object                   _par0  // 0x0
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression par0)
  System.Int32 get_ParameterCount()
  System.Linq.Expressions.ParameterExpression GetParameter(System.Int32 index)
  System.Linq.Expressions.Expression<TDelegate> Rewrite(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters)
END_CLASS

CLASS: System.Linq.Expressions.Expression2`1
TYPE:  class
TOKEN: 0x200009B
EXTENDS: Expression`1
FIELDS:
  private           System.Object                   _par0  // 0x0
  private   readonly System.Linq.Expressions.ParameterExpression_par1  // 0x0
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression par0, System.Linq.Expressions.ParameterExpression par1)
  System.Int32 get_ParameterCount()
  System.Linq.Expressions.ParameterExpression GetParameter(System.Int32 index)
  System.Linq.Expressions.Expression<TDelegate> Rewrite(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters)
END_CLASS

CLASS: System.Linq.Expressions.Expression3`1
TYPE:  class
TOKEN: 0x200009C
EXTENDS: Expression`1
FIELDS:
  private           System.Object                   _par0  // 0x0
  private   readonly System.Linq.Expressions.ParameterExpression_par1  // 0x0
  private   readonly System.Linq.Expressions.ParameterExpression_par2  // 0x0
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression par0, System.Linq.Expressions.ParameterExpression par1, System.Linq.Expressions.ParameterExpression par2)
  System.Int32 get_ParameterCount()
  System.Linq.Expressions.ParameterExpression GetParameter(System.Int32 index)
  System.Linq.Expressions.Expression<TDelegate> Rewrite(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters)
END_CLASS

CLASS: System.Linq.Expressions.ExpressionN`1
TYPE:  class
TOKEN: 0x200009D
EXTENDS: Expression`1
FIELDS:
  private           System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression>_parameters  // 0x0
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression body, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> parameters)
  System.Int32 get_ParameterCount()
  System.Linq.Expressions.ParameterExpression GetParameter(System.Int32 index)
  System.Linq.Expressions.Expression<TDelegate> Rewrite(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters)
END_CLASS

CLASS: System.Linq.Expressions.FullExpression`1
TYPE:  class
TOKEN: 0x200009E
EXTENDS: ExpressionN`1
FIELDS:
  private   readonly System.String                   <NameCore>k__BackingField  // 0x0
  private   readonly System.Boolean                  <TailCallCore>k__BackingField  // 0x0
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression body, System.String name, System.Boolean tailCall, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> parameters)
  System.String get_NameCore()
  System.Boolean get_TailCallCore()
END_CLASS

CLASS: System.Linq.Expressions.ListInitExpression
TYPE:  class
TOKEN: 0x200009F
EXTENDS: Expression
FIELDS:
  private   readonly System.Linq.Expressions.NewExpression<NewExpression>k__BackingField  // 0x10
  private   readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit><Initializers>k__BackingField  // 0x18
METHODS:
  System.Linq.Expressions.NewExpression get_NewExpression()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> get_Initializers()
END_CLASS

CLASS: System.Linq.Expressions.LoopExpression
TYPE:  class
TOKEN: 0x20000A0
EXTENDS: Expression
FIELDS:
  private   readonly System.Linq.Expressions.Expression<Body>k__BackingField  // 0x10
  private   readonly System.Linq.Expressions.LabelTarget<BreakLabel>k__BackingField  // 0x18
  private   readonly System.Linq.Expressions.LabelTarget<ContinueLabel>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression body, System.Linq.Expressions.LabelTarget break, System.Linq.Expressions.LabelTarget continue)
  System.Type get_Type()
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Linq.Expressions.Expression get_Body()
  System.Linq.Expressions.LabelTarget get_BreakLabel()
  System.Linq.Expressions.LabelTarget get_ContinueLabel()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Linq.Expressions.LoopExpression Update(System.Linq.Expressions.LabelTarget breakLabel, System.Linq.Expressions.LabelTarget continueLabel, System.Linq.Expressions.Expression body)
END_CLASS

CLASS: System.Linq.Expressions.MemberAssignment
TYPE:  class
TOKEN: 0x20000A1
EXTENDS: MemberBinding
FIELDS:
  private   readonly System.Linq.Expressions.Expression_expression  // 0x20
METHODS:
  System.Linq.Expressions.Expression get_Expression()
END_CLASS

CLASS: System.Linq.Expressions.MemberBindingType
TYPE:  struct
TOKEN: 0x20000A2
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Linq.Expressions.MemberBindingTypeAssignment  // 0x0
  public    static  System.Linq.Expressions.MemberBindingTypeMemberBinding  // 0x0
  public    static  System.Linq.Expressions.MemberBindingTypeListBinding  // 0x0
METHODS:
END_CLASS

CLASS: System.Linq.Expressions.MemberBinding
TYPE:  class
TOKEN: 0x20000A3
FIELDS:
  private   readonly System.Linq.Expressions.MemberBindingType<BindingType>k__BackingField  // 0x10
  private   readonly System.Reflection.MemberInfo    <Member>k__BackingField  // 0x18
METHODS:
  System.Linq.Expressions.MemberBindingType get_BindingType()
  System.Reflection.MemberInfo get_Member()
END_CLASS

CLASS: System.Linq.Expressions.MemberExpression
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: Expression
FIELDS:
  private   readonly System.Linq.Expressions.Expression<Expression>k__BackingField  // 0x10
METHODS:
  System.Reflection.MemberInfo get_Member()
  System.Linq.Expressions.Expression get_Expression()
  System.Void .ctor(System.Linq.Expressions.Expression expression)
  System.Linq.Expressions.PropertyExpression Make(System.Linq.Expressions.Expression expression, System.Reflection.PropertyInfo property)
  System.Linq.Expressions.FieldExpression Make(System.Linq.Expressions.Expression expression, System.Reflection.FieldInfo field)
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Reflection.MemberInfo GetMember()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Linq.Expressions.MemberExpression Update(System.Linq.Expressions.Expression expression)
END_CLASS

CLASS: System.Linq.Expressions.FieldExpression
TYPE:  class
TOKEN: 0x20000A5
EXTENDS: MemberExpression
FIELDS:
  private   readonly System.Reflection.FieldInfo     _field  // 0x18
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression expression, System.Reflection.FieldInfo member)
  System.Reflection.MemberInfo GetMember()
  System.Type get_Type()
END_CLASS

CLASS: System.Linq.Expressions.PropertyExpression
TYPE:  class
TOKEN: 0x20000A6
EXTENDS: MemberExpression
FIELDS:
  private   readonly System.Reflection.PropertyInfo  _property  // 0x18
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression expression, System.Reflection.PropertyInfo member)
  System.Reflection.MemberInfo GetMember()
  System.Type get_Type()
END_CLASS

CLASS: System.Linq.Expressions.MemberInitExpression
TYPE:  class
TOKEN: 0x20000A7
EXTENDS: Expression
FIELDS:
  private   readonly System.Linq.Expressions.NewExpression<NewExpression>k__BackingField  // 0x10
  private   readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding><Bindings>k__BackingField  // 0x18
METHODS:
  System.Linq.Expressions.NewExpression get_NewExpression()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> get_Bindings()
END_CLASS

CLASS: System.Linq.Expressions.MemberListBinding
TYPE:  class
TOKEN: 0x20000A8
EXTENDS: MemberBinding
FIELDS:
  private   readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit><Initializers>k__BackingField  // 0x20
METHODS:
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> get_Initializers()
END_CLASS

CLASS: System.Linq.Expressions.MemberMemberBinding
TYPE:  class
TOKEN: 0x20000A9
EXTENDS: MemberBinding
FIELDS:
  private   readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding><Bindings>k__BackingField  // 0x20
METHODS:
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> get_Bindings()
END_CLASS

CLASS: System.Linq.Expressions.MethodCallExpression
TYPE:  class
TOKEN: 0x20000AA
EXTENDS: Expression
FIELDS:
  private   readonly System.Reflection.MethodInfo    <Method>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method)
  System.Linq.Expressions.Expression GetInstance()
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Type get_Type()
  System.Reflection.MethodInfo get_Method()
  System.Linq.Expressions.Expression get_Object()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
END_CLASS

CLASS: System.Linq.Expressions.InstanceMethodCallExpression
TYPE:  class
TOKEN: 0x20000AB
EXTENDS: MethodCallExpression
FIELDS:
  private   readonly System.Linq.Expressions.Expression_instance  // 0x18
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression instance)
  System.Linq.Expressions.Expression GetInstance()
END_CLASS

CLASS: System.Linq.Expressions.MethodCallExpressionN
TYPE:  class
TOKEN: 0x20000AC
EXTENDS: MethodCallExpression
FIELDS:
  private           System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression>_arguments  // 0x18
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
END_CLASS

CLASS: System.Linq.Expressions.InstanceMethodCallExpressionN
TYPE:  class
TOKEN: 0x20000AD
EXTENDS: InstanceMethodCallExpression
FIELDS:
  private           System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression>_arguments  // 0x20
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
END_CLASS

CLASS: System.Linq.Expressions.MethodCallExpression0
TYPE:  class
TOKEN: 0x20000AE
EXTENDS: MethodCallExpression
FIELDS:
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
END_CLASS

CLASS: System.Linq.Expressions.MethodCallExpression1
TYPE:  class
TOKEN: 0x20000AF
EXTENDS: MethodCallExpression
FIELDS:
  private           System.Object                   _arg0  // 0x18
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
END_CLASS

CLASS: System.Linq.Expressions.MethodCallExpression2
TYPE:  class
TOKEN: 0x20000B0
EXTENDS: MethodCallExpression
FIELDS:
  private           System.Object                   _arg0  // 0x18
  private   readonly System.Linq.Expressions.Expression_arg1  // 0x20
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
END_CLASS

CLASS: System.Linq.Expressions.MethodCallExpression3
TYPE:  class
TOKEN: 0x20000B1
EXTENDS: MethodCallExpression
FIELDS:
  private           System.Object                   _arg0  // 0x18
  private   readonly System.Linq.Expressions.Expression_arg1  // 0x20
  private   readonly System.Linq.Expressions.Expression_arg2  // 0x28
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
END_CLASS

CLASS: System.Linq.Expressions.MethodCallExpression4
TYPE:  class
TOKEN: 0x20000B2
EXTENDS: MethodCallExpression
FIELDS:
  private           System.Object                   _arg0  // 0x18
  private   readonly System.Linq.Expressions.Expression_arg1  // 0x20
  private   readonly System.Linq.Expressions.Expression_arg2  // 0x28
  private   readonly System.Linq.Expressions.Expression_arg3  // 0x30
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
END_CLASS

CLASS: System.Linq.Expressions.MethodCallExpression5
TYPE:  class
TOKEN: 0x20000B3
EXTENDS: MethodCallExpression
FIELDS:
  private           System.Object                   _arg0  // 0x18
  private   readonly System.Linq.Expressions.Expression_arg1  // 0x20
  private   readonly System.Linq.Expressions.Expression_arg2  // 0x28
  private   readonly System.Linq.Expressions.Expression_arg3  // 0x30
  private   readonly System.Linq.Expressions.Expression_arg4  // 0x38
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
END_CLASS

CLASS: System.Linq.Expressions.InstanceMethodCallExpression0
TYPE:  class
TOKEN: 0x20000B4
EXTENDS: InstanceMethodCallExpression
FIELDS:
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression instance)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
END_CLASS

CLASS: System.Linq.Expressions.InstanceMethodCallExpression1
TYPE:  class
TOKEN: 0x20000B5
EXTENDS: InstanceMethodCallExpression
FIELDS:
  private           System.Object                   _arg0  // 0x20
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression instance, System.Linq.Expressions.Expression arg0)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
END_CLASS

CLASS: System.Linq.Expressions.InstanceMethodCallExpression2
TYPE:  class
TOKEN: 0x20000B6
EXTENDS: InstanceMethodCallExpression
FIELDS:
  private           System.Object                   _arg0  // 0x20
  private   readonly System.Linq.Expressions.Expression_arg1  // 0x28
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression instance, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
END_CLASS

CLASS: System.Linq.Expressions.InstanceMethodCallExpression3
TYPE:  class
TOKEN: 0x20000B7
EXTENDS: InstanceMethodCallExpression
FIELDS:
  private           System.Object                   _arg0  // 0x20
  private   readonly System.Linq.Expressions.Expression_arg1  // 0x28
  private   readonly System.Linq.Expressions.Expression_arg2  // 0x30
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression instance, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2)
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
  System.Int32 get_ArgumentCount()
  System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args)
END_CLASS

CLASS: System.Linq.Expressions.NewArrayExpression
TYPE:  class
TOKEN: 0x20000B8
EXTENDS: Expression
FIELDS:
  private   readonly System.Type                     <Type>k__BackingField  // 0x10
  private   readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression><Expressions>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Type type, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> expressions)
  System.Linq.Expressions.NewArrayExpression Make(System.Linq.Expressions.ExpressionType nodeType, System.Type type, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> expressions)
  System.Type get_Type()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> get_Expressions()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Linq.Expressions.NewArrayExpression Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions)
END_CLASS

CLASS: System.Linq.Expressions.NewArrayInitExpression
TYPE:  class
TOKEN: 0x20000B9
EXTENDS: NewArrayExpression
FIELDS:
METHODS:
  System.Void .ctor(System.Type type, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> expressions)
  System.Linq.Expressions.ExpressionType get_NodeType()
END_CLASS

CLASS: System.Linq.Expressions.NewArrayBoundsExpression
TYPE:  class
TOKEN: 0x20000BA
EXTENDS: NewArrayExpression
FIELDS:
METHODS:
  System.Void .ctor(System.Type type, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> expressions)
  System.Linq.Expressions.ExpressionType get_NodeType()
END_CLASS

CLASS: System.Linq.Expressions.NewExpression
TYPE:  class
TOKEN: 0x20000BB
EXTENDS: Expression
FIELDS:
  private           System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression>_arguments  // 0x10
  private   readonly System.Reflection.ConstructorInfo<Constructor>k__BackingField  // 0x18
METHODS:
  System.Reflection.ConstructorInfo get_Constructor()
  System.Linq.Expressions.Expression GetArgument(System.Int32 index)
END_CLASS

CLASS: System.Linq.Expressions.ParameterExpression
TYPE:  class
TOKEN: 0x20000BC
EXTENDS: Expression
FIELDS:
  private   readonly System.String                   <Name>k__BackingField  // 0x10
METHODS:
  System.Void .ctor(System.String name)
  System.Linq.Expressions.ParameterExpression Make(System.Type type, System.String name, System.Boolean isByRef)
  System.Type get_Type()
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.String get_Name()
  System.Boolean get_IsByRef()
  System.Boolean GetIsByRef()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
END_CLASS

CLASS: System.Linq.Expressions.ByRefParameterExpression
TYPE:  class
TOKEN: 0x20000BD
EXTENDS: TypedParameterExpression
FIELDS:
METHODS:
  System.Void .ctor(System.Type type, System.String name)
  System.Boolean GetIsByRef()
END_CLASS

CLASS: System.Linq.Expressions.TypedParameterExpression
TYPE:  class
TOKEN: 0x20000BE
EXTENDS: ParameterExpression
FIELDS:
  private   readonly System.Type                     <Type>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Type type, System.String name)
  System.Type get_Type()
END_CLASS

CLASS: System.Linq.Expressions.PrimitiveParameterExpression`1
TYPE:  class
TOKEN: 0x20000BF
EXTENDS: ParameterExpression
FIELDS:
METHODS:
  System.Void .ctor(System.String name)
  System.Type get_Type()
END_CLASS

CLASS: System.Linq.Expressions.RuntimeVariablesExpression
TYPE:  class
TOKEN: 0x20000C0
EXTENDS: Expression
FIELDS:
  private   readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression><Variables>k__BackingField  // 0x10
METHODS:
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> get_Variables()
END_CLASS

CLASS: System.Linq.Expressions.StackGuard
TYPE:  class
TOKEN: 0x20000C1
FIELDS:
  private           System.Int32                    _executionStackCount  // 0x10
METHODS:
  System.Boolean TryEnterOnCurrentStack()
  System.Void RunOnEmptyStack(System.Action<T1,T2> action, T1 arg1, T2 arg2)
  R RunOnEmptyStackCore(System.Func<System.Object,R> action, System.Object state)
  System.Void .ctor()
END_CLASS

CLASS: System.Linq.Expressions.Strings
TYPE:  class
TOKEN: 0x20000C3
FIELDS:
METHODS:
  System.String get_ReducibleMustOverrideReduce()
  System.String get_MustReduceToDifferent()
  System.String get_ReducedNotCompatible()
  System.String get_SetterHasNoParams()
  System.String get_PropertyCannotHaveRefType()
  System.String get_IndexesOfSetGetMustMatch()
  System.String get_AccessorsCannotHaveVarArgs()
  System.String get_AccessorsCannotHaveByRefArgs()
  System.String get_BoundsCannotBeLessThanOne()
  System.String get_TypeMustNotBeByRef()
  System.String get_TypeMustNotBePointer()
  System.String get_SetterMustBeVoid()
  System.String get_PropertyTypeMustMatchGetter()
  System.String get_PropertyTypeMustMatchSetter()
  System.String get_BothAccessorsMustBeStatic()
  System.String get_OnlyStaticFieldsHaveNullInstance()
  System.String get_OnlyStaticPropertiesHaveNullInstance()
  System.String get_OnlyStaticMethodsHaveNullInstance()
  System.String get_PropertyTypeCannotBeVoid()
  System.String get_InvalidUnboxType()
  System.String get_ExpressionMustBeWriteable()
  System.String get_ArgumentMustNotHaveValueType()
  System.String get_MustBeReducible()
  System.String get_LabelMustBeVoidOrHaveExpression()
  System.String get_LabelTypeMustBeVoid()
  System.String get_QuotedExpressionMustBeLambda()
  System.String get_CollectionModifiedWhileEnumerating()
  System.String VariableMustNotBeByRef(System.Object p0, System.Object p1)
  System.String get_CollectionReadOnly()
  System.String AmbiguousMatchInExpandoObject(System.Object p0)
  System.String SameKeyExistsInExpando(System.Object p0)
  System.String KeyDoesNotExistInExpando(System.Object p0)
  System.String InvalidMetaObjectCreated(System.Object p0)
  System.String BinderNotCompatibleWithCallSite(System.Object p0, System.Object p1, System.Object p2)
  System.String DynamicBindingNeedsRestrictions(System.Object p0, System.Object p1)
  System.String DynamicObjectResultNotAssignable(System.Object p0, System.Object p1, System.Object p2, System.Object p3)
  System.String DynamicBinderResultNotAssignable(System.Object p0, System.Object p1, System.Object p2)
  System.String get_BindingCannotBeNull()
  System.String DuplicateVariable(System.Object p0)
  System.String TypeParameterIsNotDelegate(System.Object p0)
  System.String get_NoOrInvalidRuleProduced()
  System.String get_TypeMustBeDerivedFromSystemDelegate()
  System.String get_FirstArgumentMustBeCallSite()
  System.String get_FaultCannotHaveCatchOrFinally()
  System.String get_TryMustHaveCatchFinallyOrFault()
  System.String get_BodyOfCatchMustHaveSameTypeAsBodyOfTry()
  System.String ExtensionNodeMustOverrideProperty(System.Object p0)
  System.String UserDefinedOperatorMustBeStatic(System.Object p0)
  System.String UserDefinedOperatorMustNotBeVoid(System.Object p0)
  System.String CoercionOperatorNotDefined(System.Object p0, System.Object p1)
  System.String UnaryOperatorNotDefined(System.Object p0, System.Object p1)
  System.String BinaryOperatorNotDefined(System.Object p0, System.Object p1, System.Object p2)
  System.String ReferenceEqualityNotDefined(System.Object p0, System.Object p1)
  System.String OperandTypesDoNotMatchParameters(System.Object p0, System.Object p1)
  System.String OverloadOperatorTypeDoesNotMatchConversionType(System.Object p0, System.Object p1)
  System.String get_ConversionIsNotSupportedForArithmeticTypes()
  System.String get_ArgumentMustBeArray()
  System.String get_ArgumentMustBeBoolean()
  System.String get_ArgumentMustBeInteger()
  System.String get_ArgumentMustBeArrayIndexType()
  System.String get_ArgumentMustBeSingleDimensionalArrayType()
  System.String get_ArgumentTypesMustMatch()
  System.String CannotAutoInitializeValueTypeMemberThroughProperty(System.Object p0)
  System.String IncorrectTypeForTypeAs(System.Object p0)
  System.String get_CoalesceUsedOnNonNullType()
  System.String ExpressionTypeCannotInitializeArrayType(System.Object p0, System.Object p1)
  System.String ExpressionTypeDoesNotMatchReturn(System.Object p0, System.Object p1)
  System.String ExpressionTypeDoesNotMatchAssignment(System.Object p0, System.Object p1)
  System.String ExpressionTypeDoesNotMatchLabel(System.Object p0, System.Object p1)
  System.String ExpressionTypeNotInvocable(System.Object p0)
  System.String InstanceFieldNotDefinedForType(System.Object p0, System.Object p1)
  System.String FieldInfoNotDefinedForType(System.Object p0, System.Object p1, System.Object p2)
  System.String get_IncorrectNumberOfIndexes()
  System.String get_IncorrectNumberOfLambdaDeclarationParameters()
  System.String get_LambdaTypeMustBeDerivedFromSystemDelegate()
  System.String MemberNotFieldOrProperty(System.Object p0)
  System.String MethodContainsGenericParameters(System.Object p0)
  System.String MethodIsGeneric(System.Object p0)
  System.String MethodNotPropertyAccessor(System.Object p0, System.Object p1)
  System.String PropertyDoesNotHaveAccessor(System.Object p0)
  System.String ParameterExpressionNotValidAsDelegate(System.Object p0, System.Object p1)
  System.String PropertyNotDefinedForType(System.Object p0, System.Object p1)
  System.String InstancePropertyNotDefinedForType(System.Object p0, System.Object p1)
  System.String InstanceAndMethodTypeMismatch(System.Object p0, System.Object p1, System.Object p2)
  System.String UnhandledBinary(System.Object p0)
  System.String UnhandledUnary(System.Object p0)
  System.String UserDefinedOpMustHaveConsistentTypes(System.Object p0, System.Object p1)
  System.String UserDefinedOpMustHaveValidReturnType(System.Object p0, System.Object p1)
  System.String LogicalOperatorMustHaveBooleanOperators(System.Object p0, System.Object p1)
  System.String MethodWithArgsDoesNotExistOnType(System.Object p0, System.Object p1)
  System.String GenericMethodWithArgsDoesNotExistOnType(System.Object p0, System.Object p1)
  System.String MethodWithMoreThanOneMatch(System.Object p0, System.Object p1)
  System.String get_ArgumentCannotBeOfTypeVoid()
  System.String OutOfRange(System.Object p0, System.Object p1)
  System.String LabelTargetAlreadyDefined(System.Object p0)
  System.String LabelTargetUndefined(System.Object p0)
  System.String get_ControlCannotLeaveFinally()
  System.String get_ControlCannotLeaveFilterTest()
  System.String AmbiguousJump(System.Object p0)
  System.String get_ControlCannotEnterTry()
  System.String get_ControlCannotEnterExpression()
  System.String NonLocalJumpWithValue(System.Object p0)
  System.String InvalidLvalue(System.Object p0)
  System.String get_RethrowRequiresCatch()
  System.String MustRewriteToSameNode(System.Object p0, System.Object p1, System.Object p2)
  System.String MustRewriteChildToSameType(System.Object p0, System.Object p1, System.Object p2)
  System.String MustRewriteWithoutMethod(System.Object p0, System.Object p1)
  System.String get_NonAbstractConstructorRequired()
  System.String get_ExpressionMustBeReadable()
  System.String ExpressionTypeDoesNotMatchConstructorParameter(System.Object p0, System.Object p1)
  System.String get_EnumerationIsDone()
  System.String TypeContainsGenericParameters(System.Object p0)
  System.String TypeIsGeneric(System.Object p0)
  System.String get_InvalidArgumentValue()
  System.String InvalidNullValue(System.Object p0)
  System.String InvalidObjectType(System.Object p0, System.Object p1)
  System.String ExpressionTypeDoesNotMatchMethodParameter(System.Object p0, System.Object p1, System.Object p2)
  System.String ExpressionTypeDoesNotMatchParameter(System.Object p0, System.Object p1)
  System.String IncorrectNumberOfMethodCallArguments(System.Object p0)
  System.String get_IncorrectNumberOfLambdaArguments()
  System.String get_IncorrectNumberOfConstructorArguments()
END_CLASS

CLASS: System.Linq.Expressions.SwitchCase
TYPE:  class
TOKEN: 0x20000C4
FIELDS:
  private   readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression><TestValues>k__BackingField  // 0x10
  private   readonly System.Linq.Expressions.Expression<Body>k__BackingField  // 0x18
METHODS:
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> get_TestValues()
  System.Linq.Expressions.Expression get_Body()
END_CLASS

CLASS: System.Linq.Expressions.SwitchExpression
TYPE:  class
TOKEN: 0x20000C5
EXTENDS: Expression
FIELDS:
  private   readonly System.Linq.Expressions.Expression<SwitchValue>k__BackingField  // 0x10
  private   readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase><Cases>k__BackingField  // 0x18
  private   readonly System.Linq.Expressions.Expression<DefaultBody>k__BackingField  // 0x20
  private   readonly System.Reflection.MethodInfo    <Comparison>k__BackingField  // 0x28
METHODS:
  System.Linq.Expressions.Expression get_SwitchValue()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase> get_Cases()
  System.Linq.Expressions.Expression get_DefaultBody()
  System.Reflection.MethodInfo get_Comparison()
END_CLASS

CLASS: System.Linq.Expressions.SymbolDocumentInfo
TYPE:  class
TOKEN: 0x20000C6
FIELDS:
  private   readonly System.String                   <FileName>k__BackingField  // 0x10
  private   static readonly System.Guid                     DocumentType_Text  // 0x0
METHODS:
  System.String get_FileName()
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.TryExpression
TYPE:  class
TOKEN: 0x20000C7
EXTENDS: Expression
FIELDS:
  private   readonly System.Type                     <Type>k__BackingField  // 0x10
  private   readonly System.Linq.Expressions.Expression<Body>k__BackingField  // 0x18
  private   readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock><Handlers>k__BackingField  // 0x20
  private   readonly System.Linq.Expressions.Expression<Finally>k__BackingField  // 0x28
  private   readonly System.Linq.Expressions.Expression<Fault>k__BackingField  // 0x30
METHODS:
  System.Void .ctor(System.Type type, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression finally, System.Linq.Expressions.Expression fault, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock> handlers)
  System.Type get_Type()
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Linq.Expressions.Expression get_Body()
  System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock> get_Handlers()
  System.Linq.Expressions.Expression get_Finally()
  System.Linq.Expressions.Expression get_Fault()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Linq.Expressions.TryExpression Update(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.CatchBlock> handlers, System.Linq.Expressions.Expression finally, System.Linq.Expressions.Expression fault)
END_CLASS

CLASS: System.Linq.Expressions.TypeBinaryExpression
TYPE:  class
TOKEN: 0x20000C8
EXTENDS: Expression
FIELDS:
  private   readonly System.Linq.Expressions.ExpressionType<NodeType>k__BackingField  // 0x10
  private   readonly System.Linq.Expressions.Expression<Expression>k__BackingField  // 0x18
  private   readonly System.Type                     <TypeOperand>k__BackingField  // 0x20
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression expression, System.Type typeOperand, System.Linq.Expressions.ExpressionType nodeType)
  System.Type get_Type()
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Linq.Expressions.Expression get_Expression()
  System.Type get_TypeOperand()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Linq.Expressions.TypeBinaryExpression Update(System.Linq.Expressions.Expression expression)
END_CLASS

CLASS: System.Linq.Expressions.UnaryExpression
TYPE:  class
TOKEN: 0x20000C9
EXTENDS: Expression
FIELDS:
  private   readonly System.Type                     <Type>k__BackingField  // 0x10
  private   readonly System.Linq.Expressions.ExpressionType<NodeType>k__BackingField  // 0x18
  private   readonly System.Linq.Expressions.Expression<Operand>k__BackingField  // 0x20
  private   readonly System.Reflection.MethodInfo    <Method>k__BackingField  // 0x28
METHODS:
  System.Void .ctor(System.Linq.Expressions.ExpressionType nodeType, System.Linq.Expressions.Expression expression, System.Type type, System.Reflection.MethodInfo method)
  System.Type get_Type()
  System.Linq.Expressions.ExpressionType get_NodeType()
  System.Linq.Expressions.Expression get_Operand()
  System.Reflection.MethodInfo get_Method()
  System.Boolean get_IsLifted()
  System.Boolean get_IsLiftedToNull()
  System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor)
  System.Boolean get_CanReduce()
  System.Linq.Expressions.Expression Reduce()
  System.Boolean get_IsPrefix()
  System.Linq.Expressions.UnaryExpression FunctionalOp(System.Linq.Expressions.Expression operand)
  System.Linq.Expressions.Expression ReduceVariable()
  System.Linq.Expressions.Expression ReduceMember()
  System.Linq.Expressions.Expression ReduceIndex()
  System.Linq.Expressions.UnaryExpression Update(System.Linq.Expressions.Expression operand)
END_CLASS

CLASS: System.Linq.Expressions.Utils
TYPE:  class
TOKEN: 0x20000CA
FIELDS:
  public    static readonly System.Object                   BoxedFalse  // 0x0
  public    static readonly System.Object                   BoxedTrue  // 0x8
  public    static readonly System.Object                   BoxedIntM1  // 0x10
  public    static readonly System.Object                   BoxedInt0  // 0x18
  public    static readonly System.Object                   BoxedInt1  // 0x20
  public    static readonly System.Object                   BoxedInt2  // 0x28
  public    static readonly System.Object                   BoxedInt3  // 0x30
  public    static readonly System.Object                   BoxedDefaultSByte  // 0x38
  public    static readonly System.Object                   BoxedDefaultChar  // 0x40
  public    static readonly System.Object                   BoxedDefaultInt16  // 0x48
  public    static readonly System.Object                   BoxedDefaultInt64  // 0x50
  public    static readonly System.Object                   BoxedDefaultByte  // 0x58
  public    static readonly System.Object                   BoxedDefaultUInt16  // 0x60
  public    static readonly System.Object                   BoxedDefaultUInt32  // 0x68
  public    static readonly System.Object                   BoxedDefaultUInt64  // 0x70
  public    static readonly System.Object                   BoxedDefaultSingle  // 0x78
  public    static readonly System.Object                   BoxedDefaultDouble  // 0x80
  public    static readonly System.Object                   BoxedDefaultDecimal  // 0x88
  public    static readonly System.Object                   BoxedDefaultDateTime  // 0x90
  private   static readonly System.Linq.Expressions.ConstantExpressions_true  // 0x98
  private   static readonly System.Linq.Expressions.ConstantExpressions_false  // 0xA0
  private   static readonly System.Linq.Expressions.ConstantExpressions_m1  // 0xA8
  private   static readonly System.Linq.Expressions.ConstantExpressions_0  // 0xB0
  private   static readonly System.Linq.Expressions.ConstantExpressions_1  // 0xB8
  private   static readonly System.Linq.Expressions.ConstantExpressions_2  // 0xC0
  private   static readonly System.Linq.Expressions.ConstantExpressions_3  // 0xC8
  public    static readonly System.Linq.Expressions.DefaultExpressionEmpty  // 0xD0
  public    static readonly System.Linq.Expressions.ConstantExpressionNull  // 0xD8
METHODS:
  System.Linq.Expressions.ConstantExpression Constant(System.Boolean value)
  System.Linq.Expressions.ConstantExpression Constant(System.Int32 value)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.AddInstruction
TYPE:  class
TOKEN: 0x20000CB
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_Single  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_Double  // 0x38
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.AddOvfInstruction
TYPE:  class
TOKEN: 0x20000D4
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x28
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.AndInstruction
TYPE:  class
TOKEN: 0x20000DB
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_SByte  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_Byte  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x38
  private   static  System.Linq.Expressions.Interpreter.Instructions_Boolean  // 0x40
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.NewArrayInitInstruction
TYPE:  class
TOKEN: 0x20000E5
EXTENDS: Instruction
FIELDS:
  private   readonly System.Type                     _elementType  // 0x10
  private   readonly System.Int32                    _elementCount  // 0x18
METHODS:
  System.Void .ctor(System.Type elementType, System.Int32 elementCount)
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.NewArrayInstruction
TYPE:  class
TOKEN: 0x20000E6
EXTENDS: Instruction
FIELDS:
  private   readonly System.Type                     _elementType  // 0x10
METHODS:
  System.Void .ctor(System.Type elementType)
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.NewArrayBoundsInstruction
TYPE:  class
TOKEN: 0x20000E7
EXTENDS: Instruction
FIELDS:
  private   readonly System.Type                     _elementType  // 0x10
  private   readonly System.Int32                    _rank  // 0x18
METHODS:
  System.Void .ctor(System.Type elementType, System.Int32 rank)
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.GetArrayItemInstruction
TYPE:  class
TOKEN: 0x20000E8
EXTENDS: Instruction
FIELDS:
  private   static readonly System.Linq.Expressions.Interpreter.GetArrayItemInstructionInstance  // 0x0
METHODS:
  System.Void .ctor()
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.SetArrayItemInstruction
TYPE:  class
TOKEN: 0x20000E9
EXTENDS: Instruction
FIELDS:
  private   static readonly System.Linq.Expressions.Interpreter.SetArrayItemInstructionInstance  // 0x0
METHODS:
  System.Void .ctor()
  System.Int32 get_ConsumedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ArrayLengthInstruction
TYPE:  class
TOKEN: 0x20000EA
EXTENDS: Instruction
FIELDS:
  public    static readonly System.Linq.Expressions.Interpreter.ArrayLengthInstructionInstance  // 0x0
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ConvertHelper
TYPE:  class
TOKEN: 0x20000EB
FIELDS:
METHODS:
  System.Int32 ToInt32NoNull(System.Object val)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.RuntimeLabel
TYPE:  struct
TOKEN: 0x20000EC
FIELDS:
  public    readonly System.Int32                    Index  // 0x10
  public    readonly System.Int32                    StackDepth  // 0x14
  public    readonly System.Int32                    ContinuationStackDepth  // 0x18
METHODS:
  System.Void .ctor(System.Int32 index, System.Int32 continuationStackDepth, System.Int32 stackDepth)
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.BranchLabel
TYPE:  class
TOKEN: 0x20000ED
FIELDS:
  private           System.Int32                    _targetIndex  // 0x10
  private           System.Int32                    _stackDepth  // 0x14
  private           System.Int32                    _continuationStackDepth  // 0x18
  private           System.Collections.Generic.List<System.Int32>_forwardBranchFixups  // 0x20
  private           System.Int32                    <LabelIndex>k__BackingField  // 0x28
METHODS:
  System.Int32 get_LabelIndex()
  System.Void set_LabelIndex(System.Int32 value)
  System.Boolean get_HasRuntimeLabel()
  System.Int32 get_TargetIndex()
  System.Linq.Expressions.Interpreter.RuntimeLabel ToRuntimeLabel()
  System.Void Mark(System.Linq.Expressions.Interpreter.InstructionList instructions)
  System.Void AddBranch(System.Linq.Expressions.Interpreter.InstructionList instructions, System.Int32 branchIndex)
  System.Void FixupBranch(System.Linq.Expressions.Interpreter.InstructionList instructions, System.Int32 branchIndex)
  System.Void .ctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.CallInstruction
TYPE:  class
TOKEN: 0x20000EE
EXTENDS: Instruction
FIELDS:
METHODS:
  System.Int32 get_ArgumentCount()
  System.String get_InstructionName()
  System.Linq.Expressions.Interpreter.CallInstruction Create(System.Reflection.MethodInfo info)
  System.Linq.Expressions.Interpreter.CallInstruction Create(System.Reflection.MethodInfo info, System.Reflection.ParameterInfo[] parameters)
  System.Linq.Expressions.Interpreter.CallInstruction GetArrayAccessor(System.Reflection.MethodInfo info, System.Int32 argumentCount)
  System.Void ArrayItemSetter1(System.Array array, System.Int32 index0, System.Object value)
  System.Void ArrayItemSetter2(System.Array array, System.Int32 index0, System.Int32 index1, System.Object value)
  System.Void ArrayItemSetter3(System.Array array, System.Int32 index0, System.Int32 index1, System.Int32 index2, System.Object value)
  System.Int32 get_ConsumedStack()
  System.Boolean TryGetLightLambdaTarget(System.Object instance, System.Linq.Expressions.Interpreter.LightLambda& lightLambda)
  System.Object InterpretLambdaInvoke(System.Linq.Expressions.Interpreter.LightLambda targetLambda, System.Object[] args)
  System.Void .ctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.MethodInfoCallInstruction
TYPE:  class
TOKEN: 0x20000EF
EXTENDS: CallInstruction
FIELDS:
  protected readonly System.Reflection.MethodInfo    _target  // 0x10
  protected readonly System.Int32                    _argumentCount  // 0x18
METHODS:
  System.Int32 get_ArgumentCount()
  System.Void .ctor(System.Reflection.MethodInfo target, System.Int32 argumentCount)
  System.Int32 get_ProducedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Object[] GetArgs(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Int32 first, System.Int32 skip)
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ByRefMethodInfoCallInstruction
TYPE:  class
TOKEN: 0x20000F0
EXTENDS: MethodInfoCallInstruction
FIELDS:
  private   readonly System.Linq.Expressions.Interpreter.ByRefUpdater[]_byrefArgs  // 0x20
METHODS:
  System.Void .ctor(System.Reflection.MethodInfo target, System.Int32 argumentCount, System.Linq.Expressions.Interpreter.ByRefUpdater[] byrefArgs)
  System.Int32 get_ProducedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.OffsetInstruction
TYPE:  class
TOKEN: 0x20000F1
EXTENDS: Instruction
FIELDS:
  protected         System.Int32                    _offset  // 0x10
METHODS:
  System.Linq.Expressions.Interpreter.Instruction[] get_Cache()
  System.Linq.Expressions.Interpreter.Instruction Fixup(System.Int32 offset)
  System.String ToDebugString(System.Int32 instructionIndex, System.Object cookie, System.Func<System.Int32,System.Int32> labelIndexer, System.Collections.Generic.IReadOnlyList<System.Object> objects)
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.BranchFalseInstruction
TYPE:  class
TOKEN: 0x20000F2
EXTENDS: OffsetInstruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instruction[]s_cache  // 0x0
METHODS:
  System.Linq.Expressions.Interpreter.Instruction[] get_Cache()
  System.String get_InstructionName()
  System.Int32 get_ConsumedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.BranchTrueInstruction
TYPE:  class
TOKEN: 0x20000F3
EXTENDS: OffsetInstruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instruction[]s_cache  // 0x0
METHODS:
  System.Linq.Expressions.Interpreter.Instruction[] get_Cache()
  System.String get_InstructionName()
  System.Int32 get_ConsumedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.CoalescingBranchInstruction
TYPE:  class
TOKEN: 0x20000F4
EXTENDS: OffsetInstruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instruction[]s_cache  // 0x0
METHODS:
  System.Linq.Expressions.Interpreter.Instruction[] get_Cache()
  System.String get_InstructionName()
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.BranchInstruction
TYPE:  class
TOKEN: 0x20000F5
EXTENDS: OffsetInstruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instruction[][][]s_caches  // 0x0
  private   readonly System.Boolean                  _hasResult  // 0x18
  private   readonly System.Boolean                  _hasValue  // 0x19
METHODS:
  System.Linq.Expressions.Interpreter.Instruction[] get_Cache()
  System.Void .ctor()
  System.Void .ctor(System.Boolean hasResult, System.Boolean hasValue)
  System.String get_InstructionName()
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.IndexedBranchInstruction
TYPE:  class
TOKEN: 0x20000F6
EXTENDS: Instruction
FIELDS:
  private   readonly System.Int32                    _labelIndex  // 0x10
METHODS:
  System.Void .ctor(System.Int32 labelIndex)
  System.Linq.Expressions.Interpreter.RuntimeLabel GetLabel(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.String ToDebugString(System.Int32 instructionIndex, System.Object cookie, System.Func<System.Int32,System.Int32> labelIndexer, System.Collections.Generic.IReadOnlyList<System.Object> objects)
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.GotoInstruction
TYPE:  class
TOKEN: 0x20000F7
EXTENDS: IndexedBranchInstruction
FIELDS:
  private   static readonly System.Linq.Expressions.Interpreter.GotoInstruction[]s_cache  // 0x0
  private   readonly System.Boolean                  _hasResult  // 0x18
  private   readonly System.Boolean                  _hasValue  // 0x19
  private   readonly System.Boolean                  _labelTargetGetsValue  // 0x1A
METHODS:
  System.String get_InstructionName()
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.Void .ctor(System.Int32 targetIndex, System.Boolean hasResult, System.Boolean hasValue, System.Boolean labelTargetGetsValue)
  System.Linq.Expressions.Interpreter.GotoInstruction Create(System.Int32 labelIndex, System.Boolean hasResult, System.Boolean hasValue, System.Boolean labelTargetGetsValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.EnterTryCatchFinallyInstruction
TYPE:  class
TOKEN: 0x20000F8
EXTENDS: IndexedBranchInstruction
FIELDS:
  private   readonly System.Boolean                  _hasFinally  // 0x18
  private           System.Linq.Expressions.Interpreter.TryCatchFinallyHandler_tryHandler  // 0x20
METHODS:
  System.Void SetTryHandler(System.Linq.Expressions.Interpreter.TryCatchFinallyHandler tryHandler)
  System.Linq.Expressions.Interpreter.TryCatchFinallyHandler get_Handler()
  System.Int32 get_ProducedContinuations()
  System.Void .ctor(System.Int32 targetIndex, System.Boolean hasFinally)
  System.Linq.Expressions.Interpreter.EnterTryCatchFinallyInstruction CreateTryFinally(System.Int32 labelIndex)
  System.Linq.Expressions.Interpreter.EnterTryCatchFinallyInstruction CreateTryCatch()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.String get_InstructionName()
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.EnterTryFaultInstruction
TYPE:  class
TOKEN: 0x20000F9
EXTENDS: IndexedBranchInstruction
FIELDS:
  private           System.Linq.Expressions.Interpreter.TryFaultHandler_tryHandler  // 0x18
METHODS:
  System.Void .ctor(System.Int32 targetIndex)
  System.String get_InstructionName()
  System.Int32 get_ProducedContinuations()
  System.Linq.Expressions.Interpreter.TryFaultHandler get_Handler()
  System.Void SetTryHandler(System.Linq.Expressions.Interpreter.TryFaultHandler tryHandler)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.EnterFinallyInstruction
TYPE:  class
TOKEN: 0x20000FA
EXTENDS: IndexedBranchInstruction
FIELDS:
  private   static readonly System.Linq.Expressions.Interpreter.EnterFinallyInstruction[]s_cache  // 0x0
METHODS:
  System.Void .ctor(System.Int32 labelIndex)
  System.String get_InstructionName()
  System.Int32 get_ProducedStack()
  System.Int32 get_ConsumedContinuations()
  System.Linq.Expressions.Interpreter.EnterFinallyInstruction Create(System.Int32 labelIndex)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LeaveFinallyInstruction
TYPE:  class
TOKEN: 0x20000FB
EXTENDS: Instruction
FIELDS:
  private   static readonly System.Linq.Expressions.Interpreter.InstructionInstance  // 0x0
METHODS:
  System.Void .ctor()
  System.Int32 get_ConsumedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.EnterFaultInstruction
TYPE:  class
TOKEN: 0x20000FC
EXTENDS: IndexedBranchInstruction
FIELDS:
  private   static readonly System.Linq.Expressions.Interpreter.EnterFaultInstruction[]s_cache  // 0x0
METHODS:
  System.Void .ctor(System.Int32 labelIndex)
  System.String get_InstructionName()
  System.Int32 get_ProducedStack()
  System.Linq.Expressions.Interpreter.EnterFaultInstruction Create(System.Int32 labelIndex)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LeaveFaultInstruction
TYPE:  class
TOKEN: 0x20000FD
EXTENDS: Instruction
FIELDS:
  private   static readonly System.Linq.Expressions.Interpreter.InstructionInstance  // 0x0
METHODS:
  System.Void .ctor()
  System.Int32 get_ConsumedStack()
  System.Int32 get_ConsumedContinuations()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.EnterExceptionFilterInstruction
TYPE:  class
TOKEN: 0x20000FE
EXTENDS: Instruction
FIELDS:
  private   static readonly System.Linq.Expressions.Interpreter.EnterExceptionFilterInstructionInstance  // 0x0
METHODS:
  System.Void .ctor()
  System.String get_InstructionName()
  System.Int32 get_ProducedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LeaveExceptionFilterInstruction
TYPE:  class
TOKEN: 0x20000FF
EXTENDS: Instruction
FIELDS:
  private   static readonly System.Linq.Expressions.Interpreter.LeaveExceptionFilterInstructionInstance  // 0x0
METHODS:
  System.Void .ctor()
  System.String get_InstructionName()
  System.Int32 get_ConsumedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstruction
TYPE:  class
TOKEN: 0x2000100
EXTENDS: Instruction
FIELDS:
  private   static readonly System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstructionVoid  // 0x0
  private   static readonly System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstructionNonVoid  // 0x8
  private   readonly System.Boolean                  _hasValue  // 0x10
METHODS:
  System.Void .ctor(System.Boolean hasValue)
  System.String get_InstructionName()
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LeaveExceptionHandlerInstruction
TYPE:  class
TOKEN: 0x2000101
EXTENDS: IndexedBranchInstruction
FIELDS:
  private   static readonly System.Linq.Expressions.Interpreter.LeaveExceptionHandlerInstruction[]s_cache  // 0x0
  private   readonly System.Boolean                  _hasValue  // 0x18
METHODS:
  System.Void .ctor(System.Int32 labelIndex, System.Boolean hasValue)
  System.String get_InstructionName()
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.Linq.Expressions.Interpreter.LeaveExceptionHandlerInstruction Create(System.Int32 labelIndex, System.Boolean hasValue)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ThrowInstruction
TYPE:  class
TOKEN: 0x2000102
EXTENDS: Instruction
FIELDS:
  private   static readonly System.Linq.Expressions.Interpreter.ThrowInstructionThrow  // 0x0
  private   static readonly System.Linq.Expressions.Interpreter.ThrowInstructionVoidThrow  // 0x8
  private   static readonly System.Linq.Expressions.Interpreter.ThrowInstructionRethrow  // 0x10
  private   static readonly System.Linq.Expressions.Interpreter.ThrowInstructionVoidRethrow  // 0x18
  private   readonly System.Boolean                  _hasResult  // 0x10
  private   readonly System.Boolean                  _rethrow  // 0x11
METHODS:
  System.Void .ctor(System.Boolean hasResult, System.Boolean isRethrow)
  System.String get_InstructionName()
  System.Int32 get_ProducedStack()
  System.Int32 get_ConsumedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Exception WrapThrownObject(System.Object thrown)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.IntSwitchInstruction`1
TYPE:  class
TOKEN: 0x2000103
EXTENDS: Instruction
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<T,System.Int32>_cases  // 0x0
METHODS:
  System.Void .ctor(System.Collections.Generic.Dictionary<T,System.Int32> cases)
  System.String get_InstructionName()
  System.Int32 get_ConsumedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.StringSwitchInstruction
TYPE:  class
TOKEN: 0x2000104
EXTENDS: Instruction
FIELDS:
  private   readonly System.Collections.Generic.Dictionary<System.String,System.Int32>_cases  // 0x10
  private   readonly System.Runtime.CompilerServices.StrongBox<System.Int32>_nullCase  // 0x18
METHODS:
  System.Void .ctor(System.Collections.Generic.Dictionary<System.String,System.Int32> cases, System.Runtime.CompilerServices.StrongBox<System.Int32> nullCase)
  System.String get_InstructionName()
  System.Int32 get_ConsumedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.DecrementInstruction
TYPE:  class
TOKEN: 0x2000105
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_Single  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_Double  // 0x38
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.DefaultValueInstruction
TYPE:  class
TOKEN: 0x200010E
EXTENDS: Instruction
FIELDS:
  private   readonly System.Type                     _type  // 0x10
METHODS:
  System.Void .ctor(System.Type type)
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.DivInstruction
TYPE:  class
TOKEN: 0x200010F
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_Single  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_Double  // 0x38
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.EqualInstruction
TYPE:  class
TOKEN: 0x2000118
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_reference  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Boolean  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_SByte  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_Char  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_Byte  // 0x38
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x40
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x48
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x50
  private   static  System.Linq.Expressions.Interpreter.Instructions_Single  // 0x58
  private   static  System.Linq.Expressions.Interpreter.Instructions_Double  // 0x60
  private   static  System.Linq.Expressions.Interpreter.Instructions_BooleanLiftedToNull  // 0x68
  private   static  System.Linq.Expressions.Interpreter.Instructions_SByteLiftedToNull  // 0x70
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16LiftedToNull  // 0x78
  private   static  System.Linq.Expressions.Interpreter.Instructions_CharLiftedToNull  // 0x80
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32LiftedToNull  // 0x88
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64LiftedToNull  // 0x90
  private   static  System.Linq.Expressions.Interpreter.Instructions_ByteLiftedToNull  // 0x98
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16LiftedToNull  // 0xA0
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32LiftedToNull  // 0xA8
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64LiftedToNull  // 0xB0
  private   static  System.Linq.Expressions.Interpreter.Instructions_SingleLiftedToNull  // 0xB8
  private   static  System.Linq.Expressions.Interpreter.Instructions_DoubleLiftedToNull  // 0xC0
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type, System.Boolean liftedToNull)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ExclusiveOrInstruction
TYPE:  class
TOKEN: 0x2000132
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_SByte  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_Byte  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x38
  private   static  System.Linq.Expressions.Interpreter.Instructions_Boolean  // 0x40
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.FieldInstruction
TYPE:  class
TOKEN: 0x200013C
EXTENDS: Instruction
FIELDS:
  protected readonly System.Reflection.FieldInfo     _field  // 0x10
METHODS:
  System.Void .ctor(System.Reflection.FieldInfo field)
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LoadStaticFieldInstruction
TYPE:  class
TOKEN: 0x200013D
EXTENDS: FieldInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Reflection.FieldInfo field)
  System.String get_InstructionName()
  System.Int32 get_ProducedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LoadFieldInstruction
TYPE:  class
TOKEN: 0x200013E
EXTENDS: FieldInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Reflection.FieldInfo field)
  System.String get_InstructionName()
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.StoreFieldInstruction
TYPE:  class
TOKEN: 0x200013F
EXTENDS: FieldInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Reflection.FieldInfo field)
  System.String get_InstructionName()
  System.Int32 get_ConsumedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.StoreStaticFieldInstruction
TYPE:  class
TOKEN: 0x2000140
EXTENDS: FieldInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Reflection.FieldInfo field)
  System.String get_InstructionName()
  System.Int32 get_ConsumedStack()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.GreaterThanInstruction
TYPE:  class
TOKEN: 0x2000141
EXTENDS: Instruction
FIELDS:
  private   readonly System.Object                   _nullValue  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_SByte  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Char  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_Byte  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x38
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x40
  private   static  System.Linq.Expressions.Interpreter.Instructions_Single  // 0x48
  private   static  System.Linq.Expressions.Interpreter.Instructions_Double  // 0x50
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullSByte  // 0x58
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullInt16  // 0x60
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullChar  // 0x68
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullInt32  // 0x70
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullInt64  // 0x78
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullByte  // 0x80
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullUInt16  // 0x88
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullUInt32  // 0x90
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullUInt64  // 0x98
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullSingle  // 0xA0
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullDouble  // 0xA8
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor(System.Object nullValue)
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type, System.Boolean liftedToNull)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.GreaterThanOrEqualInstruction
TYPE:  class
TOKEN: 0x200014D
EXTENDS: Instruction
FIELDS:
  private   readonly System.Object                   _nullValue  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_SByte  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Char  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_Byte  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x38
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x40
  private   static  System.Linq.Expressions.Interpreter.Instructions_Single  // 0x48
  private   static  System.Linq.Expressions.Interpreter.Instructions_Double  // 0x50
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullSByte  // 0x58
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullInt16  // 0x60
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullChar  // 0x68
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullInt32  // 0x70
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullInt64  // 0x78
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullByte  // 0x80
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullUInt16  // 0x88
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullUInt32  // 0x90
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullUInt64  // 0x98
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullSingle  // 0xA0
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullDouble  // 0xA8
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor(System.Object nullValue)
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type, System.Boolean liftedToNull)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.IncrementInstruction
TYPE:  class
TOKEN: 0x2000159
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_Single  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_Double  // 0x38
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.Instruction
TYPE:  class
TOKEN: 0x2000162
FIELDS:
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.Int32 get_ConsumedContinuations()
  System.Int32 get_ProducedContinuations()
  System.Int32 get_StackBalance()
  System.Int32 get_ContinuationsBalance()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.String get_InstructionName()
  System.String ToString()
  System.String ToDebugString(System.Int32 instructionIndex, System.Object cookie, System.Func<System.Int32,System.Int32> labelIndexer, System.Collections.Generic.IReadOnlyList<System.Object> objects)
  System.Void NullCheck(System.Object o)
  System.Void .ctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.InstructionArray
TYPE:  struct
TOKEN: 0x2000163
FIELDS:
  private   readonly System.Int32                    MaxStackDepth  // 0x10
  private   readonly System.Int32                    MaxContinuationDepth  // 0x14
  private   readonly System.Linq.Expressions.Interpreter.Instruction[]Instructions  // 0x18
  private   readonly System.Object[]                 Objects  // 0x20
  private   readonly System.Linq.Expressions.Interpreter.RuntimeLabel[]Labels  // 0x28
  private   readonly System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32,System.Object>>DebugCookies  // 0x30
METHODS:
  System.Void .ctor(System.Int32 maxStackDepth, System.Int32 maxContinuationDepth, System.Linq.Expressions.Interpreter.Instruction[] instructions, System.Object[] objects, System.Linq.Expressions.Interpreter.RuntimeLabel[] labels, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32,System.Object>> debugCookies)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.InstructionList
TYPE:  class
TOKEN: 0x2000165
FIELDS:
  private   readonly System.Collections.Generic.List<System.Linq.Expressions.Interpreter.Instruction>_instructions  // 0x10
  private           System.Collections.Generic.List<System.Object>_objects  // 0x18
  private           System.Int32                    _currentStackDepth  // 0x20
  private           System.Int32                    _maxStackDepth  // 0x24
  private           System.Int32                    _currentContinuationsDepth  // 0x28
  private           System.Int32                    _maxContinuationDepth  // 0x2C
  private           System.Int32                    _runtimeLabelCount  // 0x30
  private           System.Collections.Generic.List<System.Linq.Expressions.Interpreter.BranchLabel>_labels  // 0x38
  private           System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32,System.Object>>_debugCookies  // 0x40
  private   static  System.Linq.Expressions.Interpreter.Instructions_null  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_true  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_false  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instruction[]s_Ints  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instruction[]s_loadObjectCached  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instruction[]s_loadLocal  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instruction[]s_loadLocalBoxed  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instruction[]s_loadLocalFromClosure  // 0x38
  private   static  System.Linq.Expressions.Interpreter.Instruction[]s_loadLocalFromClosureBoxed  // 0x40
  private   static  System.Linq.Expressions.Interpreter.Instruction[]s_assignLocal  // 0x48
  private   static  System.Linq.Expressions.Interpreter.Instruction[]s_storeLocal  // 0x50
  private   static  System.Linq.Expressions.Interpreter.Instruction[]s_assignLocalBoxed  // 0x58
  private   static  System.Linq.Expressions.Interpreter.Instruction[]s_storeLocalBoxed  // 0x60
  private   static  System.Linq.Expressions.Interpreter.Instruction[]s_assignLocalToClosure  // 0x68
  private   static readonly System.Collections.Generic.Dictionary<System.Reflection.FieldInfo,System.Linq.Expressions.Interpreter.Instruction>s_loadFields  // 0x70
  private   static readonly System.Linq.Expressions.Interpreter.RuntimeLabel[]s_emptyRuntimeLabels  // 0x78
METHODS:
  System.Void Emit(System.Linq.Expressions.Interpreter.Instruction instruction)
  System.Void UpdateStackDepth(System.Linq.Expressions.Interpreter.Instruction instruction)
  System.Void UnEmit()
  System.Int32 get_Count()
  System.Int32 get_CurrentStackDepth()
  System.Int32 get_CurrentContinuationsDepth()
  System.Linq.Expressions.Interpreter.Instruction GetInstruction(System.Int32 index)
  System.Linq.Expressions.Interpreter.InstructionArray ToArray()
  System.Void EmitLoad(System.Object value)
  System.Void EmitLoad(System.Boolean value)
  System.Void EmitLoad(System.Object value, System.Type type)
  System.Void EmitDup()
  System.Void EmitPop()
  System.Void SwitchToBoxed(System.Int32 index, System.Int32 instructionIndex)
  System.Void EmitLoadLocal(System.Int32 index)
  System.Void EmitLoadLocalBoxed(System.Int32 index)
  System.Linq.Expressions.Interpreter.Instruction LoadLocalBoxed(System.Int32 index)
  System.Void EmitLoadLocalFromClosure(System.Int32 index)
  System.Void EmitLoadLocalFromClosureBoxed(System.Int32 index)
  System.Void EmitAssignLocal(System.Int32 index)
  System.Void EmitStoreLocal(System.Int32 index)
  System.Void EmitAssignLocalBoxed(System.Int32 index)
  System.Linq.Expressions.Interpreter.Instruction AssignLocalBoxed(System.Int32 index)
  System.Void EmitStoreLocalBoxed(System.Int32 index)
  System.Linq.Expressions.Interpreter.Instruction StoreLocalBoxed(System.Int32 index)
  System.Void EmitAssignLocalToClosure(System.Int32 index)
  System.Void EmitStoreLocalToClosure(System.Int32 index)
  System.Void EmitInitializeLocal(System.Int32 index, System.Type type)
  System.Void EmitInitializeParameter(System.Int32 index)
  System.Linq.Expressions.Interpreter.Instruction Parameter(System.Int32 index)
  System.Linq.Expressions.Interpreter.Instruction ParameterBox(System.Int32 index)
  System.Linq.Expressions.Interpreter.Instruction InitReference(System.Int32 index)
  System.Linq.Expressions.Interpreter.Instruction InitImmutableRefBox(System.Int32 index)
  System.Void EmitNewRuntimeVariables(System.Int32 count)
  System.Void EmitGetArrayItem()
  System.Void EmitSetArrayItem()
  System.Void EmitNewArray(System.Type elementType)
  System.Void EmitNewArrayBounds(System.Type elementType, System.Int32 rank)
  System.Void EmitNewArrayInit(System.Type elementType, System.Int32 elementCount)
  System.Void EmitAdd(System.Type type, System.Boolean checked)
  System.Void EmitSub(System.Type type, System.Boolean checked)
  System.Void EmitMul(System.Type type, System.Boolean checked)
  System.Void EmitDiv(System.Type type)
  System.Void EmitModulo(System.Type type)
  System.Void EmitExclusiveOr(System.Type type)
  System.Void EmitAnd(System.Type type)
  System.Void EmitOr(System.Type type)
  System.Void EmitLeftShift(System.Type type)
  System.Void EmitRightShift(System.Type type)
  System.Void EmitEqual(System.Type type, System.Boolean liftedToNull)
  System.Void EmitNotEqual(System.Type type, System.Boolean liftedToNull)
  System.Void EmitLessThan(System.Type type, System.Boolean liftedToNull)
  System.Void EmitLessThanOrEqual(System.Type type, System.Boolean liftedToNull)
  System.Void EmitGreaterThan(System.Type type, System.Boolean liftedToNull)
  System.Void EmitGreaterThanOrEqual(System.Type type, System.Boolean liftedToNull)
  System.Void EmitNumericConvertChecked(System.TypeCode from, System.TypeCode to, System.Boolean isLiftedToNull)
  System.Void EmitNumericConvertUnchecked(System.TypeCode from, System.TypeCode to, System.Boolean isLiftedToNull)
  System.Void EmitConvertToUnderlying(System.TypeCode to, System.Boolean isLiftedToNull)
  System.Void EmitCast(System.Type toType)
  System.Void EmitCastToEnum(System.Type toType)
  System.Void EmitCastReferenceToEnum(System.Type toType)
  System.Void EmitNot(System.Type type)
  System.Void EmitDefaultValue(System.Type type)
  System.Void EmitNew(System.Reflection.ConstructorInfo constructorInfo, System.Reflection.ParameterInfo[] parameters)
  System.Void EmitByRefNew(System.Reflection.ConstructorInfo constructorInfo, System.Reflection.ParameterInfo[] parameters, System.Linq.Expressions.Interpreter.ByRefUpdater[] updaters)
  System.Void EmitCreateDelegate(System.Linq.Expressions.Interpreter.LightDelegateCreator creator)
  System.Void EmitTypeEquals()
  System.Void EmitArrayLength()
  System.Void EmitNegate(System.Type type)
  System.Void EmitNegateChecked(System.Type type)
  System.Void EmitIncrement(System.Type type)
  System.Void EmitDecrement(System.Type type)
  System.Void EmitTypeIs(System.Type type)
  System.Void EmitTypeAs(System.Type type)
  System.Void EmitLoadField(System.Reflection.FieldInfo field)
  System.Linq.Expressions.Interpreter.Instruction GetLoadField(System.Reflection.FieldInfo field)
  System.Void EmitStoreField(System.Reflection.FieldInfo field)
  System.Void EmitCall(System.Reflection.MethodInfo method)
  System.Void EmitCall(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters)
  System.Void EmitByRefCall(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters, System.Linq.Expressions.Interpreter.ByRefUpdater[] byrefArgs)
  System.Void EmitNullableCall(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters)
  System.Linq.Expressions.Interpreter.RuntimeLabel[] BuildRuntimeLabels()
  System.Linq.Expressions.Interpreter.BranchLabel MakeLabel()
  System.Void FixupBranch(System.Int32 branchIndex, System.Int32 offset)
  System.Int32 EnsureLabelIndex(System.Linq.Expressions.Interpreter.BranchLabel label)
  System.Int32 MarkRuntimeLabel()
  System.Void MarkLabel(System.Linq.Expressions.Interpreter.BranchLabel label)
  System.Void EmitGoto(System.Linq.Expressions.Interpreter.BranchLabel label, System.Boolean hasResult, System.Boolean hasValue, System.Boolean labelTargetGetsValue)
  System.Void EmitBranch(System.Linq.Expressions.Interpreter.OffsetInstruction instruction, System.Linq.Expressions.Interpreter.BranchLabel label)
  System.Void EmitBranch(System.Linq.Expressions.Interpreter.BranchLabel label)
  System.Void EmitBranch(System.Linq.Expressions.Interpreter.BranchLabel label, System.Boolean hasResult, System.Boolean hasValue)
  System.Void EmitCoalescingBranch(System.Linq.Expressions.Interpreter.BranchLabel leftNotNull)
  System.Void EmitBranchTrue(System.Linq.Expressions.Interpreter.BranchLabel elseLabel)
  System.Void EmitBranchFalse(System.Linq.Expressions.Interpreter.BranchLabel elseLabel)
  System.Void EmitThrow()
  System.Void EmitThrowVoid()
  System.Void EmitRethrow()
  System.Void EmitRethrowVoid()
  System.Void EmitEnterTryFinally(System.Linq.Expressions.Interpreter.BranchLabel finallyStartLabel)
  System.Void EmitEnterTryCatch()
  System.Linq.Expressions.Interpreter.EnterTryFaultInstruction EmitEnterTryFault(System.Linq.Expressions.Interpreter.BranchLabel tryEnd)
  System.Void EmitEnterFinally(System.Linq.Expressions.Interpreter.BranchLabel finallyStartLabel)
  System.Void EmitLeaveFinally()
  System.Void EmitEnterFault(System.Linq.Expressions.Interpreter.BranchLabel faultStartLabel)
  System.Void EmitLeaveFault()
  System.Void EmitEnterExceptionFilter()
  System.Void EmitLeaveExceptionFilter()
  System.Void EmitEnterExceptionHandlerNonVoid()
  System.Void EmitEnterExceptionHandlerVoid()
  System.Void EmitLeaveExceptionHandler(System.Boolean hasValue, System.Linq.Expressions.Interpreter.BranchLabel tryExpressionEndLabel)
  System.Void EmitIntSwitch(System.Collections.Generic.Dictionary<T,System.Int32> cases)
  System.Void EmitStringSwitch(System.Collections.Generic.Dictionary<System.String,System.Int32> cases, System.Runtime.CompilerServices.StrongBox<System.Int32> nullCase)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.InterpretedFrame
TYPE:  class
TOKEN: 0x2000168
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.InterpretedFrames_currentFrame  // 0xFFFFFFFF
  private   readonly System.Linq.Expressions.Interpreter.InterpreterInterpreter  // 0x10
  private           System.Linq.Expressions.Interpreter.InterpretedFrame_parent  // 0x18
  private   readonly System.Int32[]                  _continuations  // 0x20
  private           System.Int32                    _continuationIndex  // 0x28
  private           System.Int32                    _pendingContinuation  // 0x2C
  private           System.Object                   _pendingValue  // 0x30
  public    readonly System.Object[]                 Data  // 0x38
  public    readonly System.Runtime.CompilerServices.IStrongBox[]Closure  // 0x40
  public            System.Int32                    StackIndex  // 0x48
  public            System.Int32                    InstructionIndex  // 0x4C
METHODS:
  System.Void .ctor(System.Linq.Expressions.Interpreter.Interpreter interpreter, System.Runtime.CompilerServices.IStrongBox[] closure)
  System.Linq.Expressions.Interpreter.DebugInfo GetDebugInfo(System.Int32 instructionIndex)
  System.String get_Name()
  System.Void Push(System.Object value)
  System.Void Push(System.Boolean value)
  System.Void Push(System.Int32 value)
  System.Void Push(System.Byte value)
  System.Void Push(System.SByte value)
  System.Void Push(System.Int16 value)
  System.Void Push(System.UInt16 value)
  System.Object Pop()
  System.Void SetStackDepth(System.Int32 depth)
  System.Object Peek()
  System.Void Dup()
  System.Linq.Expressions.Interpreter.InterpretedFrame get_Parent()
  System.Collections.Generic.IEnumerable<System.Linq.Expressions.Interpreter.InterpretedFrameInfo> GetStackTraceDebugInfo()
  System.Void SaveTraceToException(System.Exception exception)
  System.Linq.Expressions.Interpreter.InterpretedFrame Enter()
  System.Void Leave(System.Linq.Expressions.Interpreter.InterpretedFrame prevFrame)
  System.Boolean IsJumpHappened()
  System.Void RemoveContinuation()
  System.Void PushContinuation(System.Int32 continuation)
  System.Int32 YieldToCurrentContinuation()
  System.Int32 YieldToPendingContinuation()
  System.Void PushPendingContinuation()
  System.Void PopPendingContinuation()
  System.Int32 Goto(System.Int32 labelIndex, System.Object value, System.Boolean gotoExceptionHandler)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.Interpreter
TYPE:  class
TOKEN: 0x200016A
FIELDS:
  private   static readonly System.Object                   NoValue  // 0x0
  private   readonly System.Linq.Expressions.Interpreter.InstructionArray_instructions  // 0x10
  private   readonly System.Object[]                 _objects  // 0x38
  private   readonly System.Linq.Expressions.Interpreter.RuntimeLabel[]_labels  // 0x40
  private   readonly System.Linq.Expressions.Interpreter.DebugInfo[]_debugInfos  // 0x48
  private   readonly System.String                   <Name>k__BackingField  // 0x50
  private   readonly System.Int32                    <LocalCount>k__BackingField  // 0x58
  private   readonly System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable><ClosureVariables>k__BackingField  // 0x60
METHODS:
  System.Void .ctor(System.String name, System.Linq.Expressions.Interpreter.LocalVariables locals, System.Linq.Expressions.Interpreter.InstructionArray instructions, System.Linq.Expressions.Interpreter.DebugInfo[] debugInfos)
  System.String get_Name()
  System.Int32 get_LocalCount()
  System.Int32 get_ClosureSize()
  System.Linq.Expressions.Interpreter.InstructionArray get_Instructions()
  System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> get_ClosureVariables()
  System.Void Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LabelInfo
TYPE:  class
TOKEN: 0x200016B
FIELDS:
  private   readonly System.Linq.Expressions.LabelTarget_node  // 0x10
  private           System.Linq.Expressions.Interpreter.BranchLabel_label  // 0x18
  private           System.Object                   _definitions  // 0x20
  private   readonly System.Collections.Generic.List<System.Linq.Expressions.Interpreter.LabelScopeInfo>_references  // 0x28
  private           System.Boolean                  _acrossBlockJump  // 0x30
METHODS:
  System.Void .ctor(System.Linq.Expressions.LabelTarget node)
  System.Linq.Expressions.Interpreter.BranchLabel GetLabel(System.Linq.Expressions.Interpreter.LightCompiler compiler)
  System.Void Reference(System.Linq.Expressions.Interpreter.LabelScopeInfo block)
  System.Void Define(System.Linq.Expressions.Interpreter.LabelScopeInfo block)
  System.Void ValidateJump(System.Linq.Expressions.Interpreter.LabelScopeInfo reference)
  System.Void ValidateFinish()
  System.Void EnsureLabel(System.Linq.Expressions.Interpreter.LightCompiler compiler)
  System.Boolean DefinedIn(System.Linq.Expressions.Interpreter.LabelScopeInfo scope)
  System.Boolean get_HasDefinitions()
  System.Linq.Expressions.Interpreter.LabelScopeInfo FirstDefinition()
  System.Void AddDefinition(System.Linq.Expressions.Interpreter.LabelScopeInfo scope)
  System.Boolean get_HasMultipleDefinitions()
  T CommonNode(T first, T second, System.Func<T,T> parent)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LabelScopeKind
TYPE:  struct
TOKEN: 0x200016D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Linq.Expressions.Interpreter.LabelScopeKindStatement  // 0x0
  public    static  System.Linq.Expressions.Interpreter.LabelScopeKindBlock  // 0x0
  public    static  System.Linq.Expressions.Interpreter.LabelScopeKindSwitch  // 0x0
  public    static  System.Linq.Expressions.Interpreter.LabelScopeKindLambda  // 0x0
  public    static  System.Linq.Expressions.Interpreter.LabelScopeKindTry  // 0x0
  public    static  System.Linq.Expressions.Interpreter.LabelScopeKindCatch  // 0x0
  public    static  System.Linq.Expressions.Interpreter.LabelScopeKindFinally  // 0x0
  public    static  System.Linq.Expressions.Interpreter.LabelScopeKindFilter  // 0x0
  public    static  System.Linq.Expressions.Interpreter.LabelScopeKindExpression  // 0x0
METHODS:
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LabelScopeInfo
TYPE:  class
TOKEN: 0x200016E
FIELDS:
  private           System.Linq.Expressions.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget,System.Linq.Expressions.Interpreter.LabelInfo>_labels  // 0x10
  private   readonly System.Linq.Expressions.Interpreter.LabelScopeKindKind  // 0x18
  private   readonly System.Linq.Expressions.Interpreter.LabelScopeInfoParent  // 0x20
METHODS:
  System.Void .ctor(System.Linq.Expressions.Interpreter.LabelScopeInfo parent, System.Linq.Expressions.Interpreter.LabelScopeKind kind)
  System.Boolean get_CanJumpInto()
  System.Boolean ContainsTarget(System.Linq.Expressions.LabelTarget target)
  System.Boolean TryGetLabelInfo(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Interpreter.LabelInfo& info)
  System.Void AddLabelInfo(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Interpreter.LabelInfo info)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LeftShiftInstruction
TYPE:  class
TOKEN: 0x200016F
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_SByte  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_Byte  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x38
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LessThanInstruction
TYPE:  class
TOKEN: 0x2000178
EXTENDS: Instruction
FIELDS:
  private   readonly System.Object                   _nullValue  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_SByte  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Char  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_Byte  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x38
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x40
  private   static  System.Linq.Expressions.Interpreter.Instructions_Single  // 0x48
  private   static  System.Linq.Expressions.Interpreter.Instructions_Double  // 0x50
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullSByte  // 0x58
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullInt16  // 0x60
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullChar  // 0x68
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullInt32  // 0x70
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullInt64  // 0x78
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullByte  // 0x80
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullUInt16  // 0x88
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullUInt32  // 0x90
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullUInt64  // 0x98
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullSingle  // 0xA0
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullDouble  // 0xA8
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor(System.Object nullValue)
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type, System.Boolean liftedToNull)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LessThanOrEqualInstruction
TYPE:  class
TOKEN: 0x2000184
EXTENDS: Instruction
FIELDS:
  private   readonly System.Object                   _nullValue  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_SByte  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Char  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_Byte  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x38
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x40
  private   static  System.Linq.Expressions.Interpreter.Instructions_Single  // 0x48
  private   static  System.Linq.Expressions.Interpreter.Instructions_Double  // 0x50
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullSByte  // 0x58
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullInt16  // 0x60
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullChar  // 0x68
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullInt32  // 0x70
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullInt64  // 0x78
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullByte  // 0x80
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullUInt16  // 0x88
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullUInt32  // 0x90
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullUInt64  // 0x98
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullSingle  // 0xA0
  private   static  System.Linq.Expressions.Interpreter.Instructions_liftedToNullDouble  // 0xA8
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor(System.Object nullValue)
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type, System.Boolean liftedToNull)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ExceptionFilter
TYPE:  class
TOKEN: 0x2000190
FIELDS:
  public    readonly System.Int32                    LabelIndex  // 0x10
  public    readonly System.Int32                    StartIndex  // 0x14
  public    readonly System.Int32                    EndIndex  // 0x18
METHODS:
  System.Void .ctor(System.Int32 labelIndex, System.Int32 start, System.Int32 end)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ExceptionHandler
TYPE:  class
TOKEN: 0x2000191
FIELDS:
  private   readonly System.Type                     _exceptionType  // 0x10
  public    readonly System.Int32                    LabelIndex  // 0x18
  public    readonly System.Int32                    HandlerStartIndex  // 0x1C
  public    readonly System.Int32                    HandlerEndIndex  // 0x20
  public    readonly System.Linq.Expressions.Interpreter.ExceptionFilterFilter  // 0x28
METHODS:
  System.Void .ctor(System.Int32 labelIndex, System.Int32 handlerStartIndex, System.Int32 handlerEndIndex, System.Type exceptionType, System.Linq.Expressions.Interpreter.ExceptionFilter filter)
  System.Boolean Matches(System.Type exceptionType)
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.TryCatchFinallyHandler
TYPE:  class
TOKEN: 0x2000192
FIELDS:
  private   readonly System.Int32                    TryStartIndex  // 0x10
  private   readonly System.Int32                    TryEndIndex  // 0x14
  private   readonly System.Int32                    FinallyStartIndex  // 0x18
  private   readonly System.Int32                    FinallyEndIndex  // 0x1C
  private   readonly System.Int32                    GotoEndTargetIndex  // 0x20
  private   readonly System.Linq.Expressions.Interpreter.ExceptionHandler[]_handlers  // 0x28
METHODS:
  System.Boolean get_IsFinallyBlockExist()
  System.Linq.Expressions.Interpreter.ExceptionHandler[] get_Handlers()
  System.Boolean get_IsCatchBlockExist()
  System.Void .ctor(System.Int32 tryStart, System.Int32 tryEnd, System.Int32 gotoEndTargetIndex, System.Linq.Expressions.Interpreter.ExceptionHandler[] handlers)
  System.Void .ctor(System.Int32 tryStart, System.Int32 tryEnd, System.Int32 gotoEndLabelIndex, System.Int32 finallyStart, System.Int32 finallyEnd, System.Linq.Expressions.Interpreter.ExceptionHandler[] handlers)
  System.Boolean HasHandler(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Exception exception, System.Linq.Expressions.Interpreter.ExceptionHandler& handler, System.Object& unwrappedException)
  System.Boolean FilterPasses(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Object& exception, System.Linq.Expressions.Interpreter.ExceptionFilter filter)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.TryFaultHandler
TYPE:  class
TOKEN: 0x2000193
FIELDS:
  private   readonly System.Int32                    TryStartIndex  // 0x10
  private   readonly System.Int32                    TryEndIndex  // 0x14
  private   readonly System.Int32                    FinallyStartIndex  // 0x18
  private   readonly System.Int32                    FinallyEndIndex  // 0x1C
METHODS:
  System.Void .ctor(System.Int32 tryStart, System.Int32 tryEnd, System.Int32 finallyStart, System.Int32 finallyEnd)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.RethrowException
TYPE:  class
TOKEN: 0x2000194
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.DebugInfo
TYPE:  class
TOKEN: 0x2000195
FIELDS:
  public            System.Int32                    StartLine  // 0x10
  public            System.Int32                    EndLine  // 0x14
  public            System.Int32                    Index  // 0x18
  public            System.String                   FileName  // 0x20
  public            System.Boolean                  IsClear  // 0x28
  private   static readonly System.Linq.Expressions.Interpreter.DebugInfo.DebugInfoComparers_debugComparer  // 0x0
METHODS:
  System.Linq.Expressions.Interpreter.DebugInfo GetMatchingDebugInfo(System.Linq.Expressions.Interpreter.DebugInfo[] debugInfos, System.Int32 index)
  System.String ToString()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.InterpretedFrameInfo
TYPE:  struct
TOKEN: 0x2000197
FIELDS:
  private   readonly System.String                   _methodName  // 0x10
  private   readonly System.Linq.Expressions.Interpreter.DebugInfo_debugInfo  // 0x18
METHODS:
  System.Void .ctor(System.String methodName, System.Linq.Expressions.Interpreter.DebugInfo info)
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LightCompiler
TYPE:  class
TOKEN: 0x2000198
FIELDS:
  private   readonly System.Linq.Expressions.Interpreter.InstructionList_instructions  // 0x10
  private   readonly System.Linq.Expressions.Interpreter.LocalVariables_locals  // 0x18
  private   readonly System.Collections.Generic.List<System.Linq.Expressions.Interpreter.DebugInfo>_debugInfos  // 0x20
  private   readonly System.Linq.Expressions.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget,System.Linq.Expressions.Interpreter.LabelInfo>_treeLabels  // 0x28
  private           System.Linq.Expressions.Interpreter.LabelScopeInfo_labelBlock  // 0x30
  private   readonly System.Collections.Generic.Stack<System.Linq.Expressions.ParameterExpression>_exceptionForRethrowStack  // 0x38
  private   readonly System.Linq.Expressions.Interpreter.LightCompiler_parent  // 0x40
  private   readonly System.Linq.Expressions.StackGuard_guard  // 0x48
  private   static readonly System.Linq.Expressions.Interpreter.LocalDefinition[]s_emptyLocals  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Linq.Expressions.Interpreter.LightCompiler parent)
  System.Linq.Expressions.Interpreter.InstructionList get_Instructions()
  System.Linq.Expressions.Interpreter.LightDelegateCreator CompileTop(System.Linq.Expressions.LambdaExpression node)
  System.Linq.Expressions.Interpreter.Interpreter MakeInterpreter(System.String lambdaName)
  System.Void CompileConstantExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileDefaultExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileDefaultExpression(System.Type type)
  System.Linq.Expressions.Interpreter.LocalVariable EnsureAvailableForClosure(System.Linq.Expressions.ParameterExpression expr)
  System.Linq.Expressions.Interpreter.LocalVariable ResolveLocal(System.Linq.Expressions.ParameterExpression variable)
  System.Void CompileGetVariable(System.Linq.Expressions.ParameterExpression variable)
  System.Void EmitCopyValueType(System.Type valueType)
  System.Void LoadLocalNoValueTypeCopy(System.Linq.Expressions.ParameterExpression variable)
  System.Boolean MaybeMutableValueType(System.Type type)
  System.Void CompileGetBoxedVariable(System.Linq.Expressions.ParameterExpression variable)
  System.Void CompileSetVariable(System.Linq.Expressions.ParameterExpression variable, System.Boolean isVoid)
  System.Void CompileParameterExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileBlockExpression(System.Linq.Expressions.Expression expr, System.Boolean asVoid)
  System.Linq.Expressions.Interpreter.LocalDefinition[] CompileBlockStart(System.Linq.Expressions.BlockExpression node)
  System.Void CompileBlockEnd(System.Linq.Expressions.Interpreter.LocalDefinition[] locals)
  System.Void CompileIndexExpression(System.Linq.Expressions.Expression expr)
  System.Void EmitIndexGet(System.Linq.Expressions.IndexExpression index)
  System.Void CompileIndexAssignment(System.Linq.Expressions.BinaryExpression node, System.Boolean asVoid)
  System.Void CompileMemberAssignment(System.Linq.Expressions.BinaryExpression node, System.Boolean asVoid)
  System.Void CompileMemberAssignment(System.Boolean asVoid, System.Reflection.MemberInfo refMember, System.Linq.Expressions.Expression value, System.Boolean forBinding)
  System.Void CompileVariableAssignment(System.Linq.Expressions.BinaryExpression node, System.Boolean asVoid)
  System.Void CompileAssignBinaryExpression(System.Linq.Expressions.Expression expr, System.Boolean asVoid)
  System.Void CompileBinaryExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftedToNull)
  System.Void CompileNotEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftedToNull)
  System.Void CompileComparison(System.Linq.Expressions.BinaryExpression node)
  System.Void CompileArithmetic(System.Linq.Expressions.ExpressionType nodeType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right)
  System.Void CompileConvertUnaryExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileConvertToType(System.Type typeFrom, System.Type typeTo, System.Boolean isChecked, System.Boolean isLiftedToNull)
  System.Void CompileNotExpression(System.Linq.Expressions.UnaryExpression node)
  System.Void CompileUnaryExpression(System.Linq.Expressions.Expression expr)
  System.Void EmitUnaryMethodCall(System.Linq.Expressions.UnaryExpression node)
  System.Void EmitUnaryBoolCheck(System.Linq.Expressions.UnaryExpression node)
  System.Void CompileAndAlsoBinaryExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileOrElseBinaryExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileLogicalBinaryExpression(System.Linq.Expressions.BinaryExpression b, System.Boolean andAlso)
  System.Void CompileMethodLogicalBinaryExpression(System.Linq.Expressions.BinaryExpression expr, System.Boolean andAlso)
  System.Void CompileLiftedLogicalBinaryExpression(System.Linq.Expressions.BinaryExpression node, System.Boolean andAlso)
  System.Void CompileUnliftedLogicalBinaryExpression(System.Linq.Expressions.BinaryExpression expr, System.Boolean andAlso)
  System.Void CompileConditionalExpression(System.Linq.Expressions.Expression expr, System.Boolean asVoid)
  System.Void CompileLoopExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileSwitchExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileIntSwitchExpression(System.Linq.Expressions.SwitchExpression node)
  System.Void CompileStringSwitchExpression(System.Linq.Expressions.SwitchExpression node)
  System.Void CompileLabelExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileGotoExpression(System.Linq.Expressions.Expression expr)
  System.Void PushLabelBlock(System.Linq.Expressions.Interpreter.LabelScopeKind type)
  System.Void PopLabelBlock(System.Linq.Expressions.Interpreter.LabelScopeKind kind)
  System.Linq.Expressions.Interpreter.LabelInfo EnsureLabel(System.Linq.Expressions.LabelTarget node)
  System.Linq.Expressions.Interpreter.LabelInfo ReferenceLabel(System.Linq.Expressions.LabelTarget node)
  System.Linq.Expressions.Interpreter.LabelInfo DefineLabel(System.Linq.Expressions.LabelTarget node)
  System.Boolean TryPushLabelBlock(System.Linq.Expressions.Expression node)
  System.Void DefineBlockLabels(System.Linq.Expressions.Expression node)
  System.Void CheckRethrow()
  System.Void CompileThrowUnaryExpression(System.Linq.Expressions.Expression expr, System.Boolean asVoid)
  System.Void CompileTryExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileTryFaultExpression(System.Linq.Expressions.TryExpression expr)
  System.Void CompileMethodCallExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileMethodCallExpression(System.Linq.Expressions.Expression object, System.Reflection.MethodInfo method, System.Linq.Expressions.IArgumentProvider arguments)
  System.Linq.Expressions.Interpreter.ByRefUpdater CompileArrayIndexAddress(System.Linq.Expressions.Expression array, System.Linq.Expressions.Expression index, System.Int32 argumentIndex)
  System.Void EmitThisForMethodCall(System.Linq.Expressions.Expression node)
  System.Boolean ShouldWritebackNode(System.Linq.Expressions.Expression node)
  System.Linq.Expressions.Interpreter.ByRefUpdater CompileAddress(System.Linq.Expressions.Expression node, System.Int32 index)
  System.Linq.Expressions.Interpreter.ByRefUpdater CompileMultiDimArrayAccess(System.Linq.Expressions.Expression array, System.Linq.Expressions.IArgumentProvider arguments, System.Int32 index)
  System.Void CompileNewExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileMemberExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileMember(System.Linq.Expressions.Expression from, System.Reflection.MemberInfo member, System.Boolean forBinding)
  System.Void CompileNewArrayExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileDebugInfoExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileRuntimeVariablesExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileLambdaExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileCoalesceBinaryExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileInvocationExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileListInitExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileListInit(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> initializers)
  System.Void CompileMemberInitExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileMemberInit(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> bindings)
  System.Type GetMemberType(System.Reflection.MemberInfo member)
  System.Void CompileQuoteUnaryExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileUnboxUnaryExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileTypeEqualExpression(System.Linq.Expressions.Expression expr)
  System.Void CompileTypeAsExpression(System.Linq.Expressions.UnaryExpression node)
  System.Void CompileTypeIsExpression(System.Linq.Expressions.Expression expr)
  System.Void Compile(System.Linq.Expressions.Expression expr, System.Boolean asVoid)
  System.Void CompileAsVoid(System.Linq.Expressions.Expression expr)
  System.Void CompileNoLabelPush(System.Linq.Expressions.Expression expr)
  System.Void Compile(System.Linq.Expressions.Expression expr)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ByRefUpdater
TYPE:  class
TOKEN: 0x200019B
FIELDS:
  public    readonly System.Int32                    ArgumentIndex  // 0x10
METHODS:
  System.Void .ctor(System.Int32 argumentIndex)
  System.Void Update(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Object value)
  System.Void UndefineTemps(System.Linq.Expressions.Interpreter.InstructionList instructions, System.Linq.Expressions.Interpreter.LocalVariables locals)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ParameterByRefUpdater
TYPE:  class
TOKEN: 0x200019C
EXTENDS: ByRefUpdater
FIELDS:
  private   readonly System.Linq.Expressions.Interpreter.LocalVariable_parameter  // 0x18
METHODS:
  System.Void .ctor(System.Linq.Expressions.Interpreter.LocalVariable parameter, System.Int32 argumentIndex)
  System.Void Update(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Object value)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ArrayByRefUpdater
TYPE:  class
TOKEN: 0x200019D
EXTENDS: ByRefUpdater
FIELDS:
  private   readonly System.Linq.Expressions.Interpreter.LocalDefinition_array  // 0x18
  private   readonly System.Linq.Expressions.Interpreter.LocalDefinition_index  // 0x28
METHODS:
  System.Void .ctor(System.Linq.Expressions.Interpreter.LocalDefinition array, System.Linq.Expressions.Interpreter.LocalDefinition index, System.Int32 argumentIndex)
  System.Void Update(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Object value)
  System.Void UndefineTemps(System.Linq.Expressions.Interpreter.InstructionList instructions, System.Linq.Expressions.Interpreter.LocalVariables locals)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.FieldByRefUpdater
TYPE:  class
TOKEN: 0x200019E
EXTENDS: ByRefUpdater
FIELDS:
  private   readonly System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition>_object  // 0x18
  private   readonly System.Reflection.FieldInfo     _field  // 0x30
METHODS:
  System.Void .ctor(System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition> obj, System.Reflection.FieldInfo field, System.Int32 argumentIndex)
  System.Void Update(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Object value)
  System.Void UndefineTemps(System.Linq.Expressions.Interpreter.InstructionList instructions, System.Linq.Expressions.Interpreter.LocalVariables locals)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.PropertyByRefUpdater
TYPE:  class
TOKEN: 0x200019F
EXTENDS: ByRefUpdater
FIELDS:
  private   readonly System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition>_object  // 0x18
  private   readonly System.Reflection.PropertyInfo  _property  // 0x30
METHODS:
  System.Void .ctor(System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition> obj, System.Reflection.PropertyInfo property, System.Int32 argumentIndex)
  System.Void Update(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Object value)
  System.Void UndefineTemps(System.Linq.Expressions.Interpreter.InstructionList instructions, System.Linq.Expressions.Interpreter.LocalVariables locals)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.IndexMethodByRefUpdater
TYPE:  class
TOKEN: 0x20001A0
EXTENDS: ByRefUpdater
FIELDS:
  private   readonly System.Reflection.MethodInfo    _indexer  // 0x18
  private   readonly System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition>_obj  // 0x20
  private   readonly System.Linq.Expressions.Interpreter.LocalDefinition[]_args  // 0x38
METHODS:
  System.Void .ctor(System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition> obj, System.Linq.Expressions.Interpreter.LocalDefinition[] args, System.Reflection.MethodInfo indexer, System.Int32 argumentIndex)
  System.Void Update(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Object value)
  System.Void UndefineTemps(System.Linq.Expressions.Interpreter.InstructionList instructions, System.Linq.Expressions.Interpreter.LocalVariables locals)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LightDelegateCreator
TYPE:  class
TOKEN: 0x20001A1
FIELDS:
  private   readonly System.Linq.Expressions.LambdaExpression_lambda  // 0x10
  private   readonly System.Linq.Expressions.Interpreter.Interpreter<Interpreter>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Linq.Expressions.Interpreter.Interpreter interpreter, System.Linq.Expressions.LambdaExpression lambda)
  System.Linq.Expressions.Interpreter.Interpreter get_Interpreter()
  System.Delegate CreateDelegate()
  System.Delegate CreateDelegate(System.Runtime.CompilerServices.IStrongBox[] closure)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LightLambda
TYPE:  class
TOKEN: 0x20001A2
FIELDS:
  private   readonly System.Runtime.CompilerServices.IStrongBox[]_closure  // 0x10
  private   readonly System.Linq.Expressions.Interpreter.Interpreter_interpreter  // 0x18
  private   static readonly System.Dynamic.Utils.CacheDict<System.Type,System.Func<System.Linq.Expressions.Interpreter.LightLambda,System.Delegate>>_runCache  // 0x0
  private   readonly System.Linq.Expressions.Interpreter.LightDelegateCreator_delegateCreator  // 0x20
METHODS:
  TRet Run0()
  System.Void RunVoid0()
  System.Delegate MakeRun0(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid0(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run1(T0 arg0)
  System.Void RunVoid1(T0 arg0)
  System.Delegate MakeRun1(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid1(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run2(T0 arg0, T1 arg1)
  System.Void RunVoid2(T0 arg0, T1 arg1)
  System.Delegate MakeRun2(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid2(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run3(T0 arg0, T1 arg1, T2 arg2)
  System.Void RunVoid3(T0 arg0, T1 arg1, T2 arg2)
  System.Delegate MakeRun3(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid3(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run4(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
  System.Void RunVoid4(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
  System.Delegate MakeRun4(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid4(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run5(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  System.Void RunVoid5(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
  System.Delegate MakeRun5(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid5(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run6(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  System.Void RunVoid6(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
  System.Delegate MakeRun6(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid6(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run7(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  System.Void RunVoid7(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
  System.Delegate MakeRun7(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid7(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run8(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
  System.Void RunVoid8(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
  System.Delegate MakeRun8(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid8(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run9(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
  System.Void RunVoid9(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
  System.Delegate MakeRun9(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid9(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run10(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
  System.Void RunVoid10(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
  System.Delegate MakeRun10(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid10(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run11(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
  System.Void RunVoid11(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
  System.Delegate MakeRun11(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid11(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run12(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
  System.Void RunVoid12(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
  System.Delegate MakeRun12(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid12(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run13(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
  System.Void RunVoid13(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
  System.Delegate MakeRun13(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid13(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run14(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
  System.Void RunVoid14(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
  System.Delegate MakeRun14(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid14(System.Linq.Expressions.Interpreter.LightLambda lambda)
  TRet Run15(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
  System.Void RunVoid15(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
  System.Delegate MakeRun15(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Delegate MakeRunVoid15(System.Linq.Expressions.Interpreter.LightLambda lambda)
  System.Void .ctor(System.Linq.Expressions.Interpreter.LightDelegateCreator delegateCreator, System.Runtime.CompilerServices.IStrongBox[] closure)
  System.String get_DebugView()
  System.Func<System.Linq.Expressions.Interpreter.LightLambda,System.Delegate> GetRunDelegateCtor(System.Type delegateType)
  System.Func<System.Linq.Expressions.Interpreter.LightLambda,System.Delegate> MakeRunDelegateCtor(System.Type delegateType)
  System.Delegate CreateCustomDelegate(System.Type delegateType)
  System.Delegate MakeDelegate(System.Type delegateType)
  System.Linq.Expressions.Interpreter.InterpretedFrame MakeFrame()
  System.Void RunVoidRef2(T0& arg0, T1& arg1)
  System.Object Run(System.Object[] arguments)
  System.Object RunVoid(System.Object[] arguments)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.IBoxableInstruction
TYPE:  interface
TOKEN: 0x20001A5
FIELDS:
METHODS:
  System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LocalAccessInstruction
TYPE:  class
TOKEN: 0x20001A6
EXTENDS: Instruction
FIELDS:
  private   readonly System.Int32                    _index  // 0x10
METHODS:
  System.Void .ctor(System.Int32 index)
  System.String ToDebugString(System.Int32 instructionIndex, System.Object cookie, System.Func<System.Int32,System.Int32> labelIndexer, System.Collections.Generic.IReadOnlyList<System.Object> objects)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LoadLocalInstruction
TYPE:  class
TOKEN: 0x20001A7
EXTENDS: LocalAccessInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 index)
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LoadLocalBoxedInstruction
TYPE:  class
TOKEN: 0x20001A8
EXTENDS: LocalAccessInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 index)
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LoadLocalFromClosureInstruction
TYPE:  class
TOKEN: 0x20001A9
EXTENDS: LocalAccessInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 index)
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LoadLocalFromClosureBoxedInstruction
TYPE:  class
TOKEN: 0x20001AA
EXTENDS: LocalAccessInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 index)
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.AssignLocalInstruction
TYPE:  class
TOKEN: 0x20001AB
EXTENDS: LocalAccessInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 index)
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.StoreLocalInstruction
TYPE:  class
TOKEN: 0x20001AC
EXTENDS: LocalAccessInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 index)
  System.Int32 get_ConsumedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.AssignLocalBoxedInstruction
TYPE:  class
TOKEN: 0x20001AD
EXTENDS: LocalAccessInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 index)
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.StoreLocalBoxedInstruction
TYPE:  class
TOKEN: 0x20001AE
EXTENDS: LocalAccessInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 index)
  System.Int32 get_ConsumedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.AssignLocalToClosureInstruction
TYPE:  class
TOKEN: 0x20001AF
EXTENDS: LocalAccessInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 index)
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ValueTypeCopyInstruction
TYPE:  class
TOKEN: 0x20001B0
EXTENDS: Instruction
FIELDS:
  public    static readonly System.Linq.Expressions.Interpreter.ValueTypeCopyInstructionInstruction  // 0x0
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.InitializeLocalInstruction
TYPE:  class
TOKEN: 0x20001B1
EXTENDS: LocalAccessInstruction
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 index)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.RuntimeVariablesInstruction
TYPE:  class
TOKEN: 0x20001BA
EXTENDS: Instruction
FIELDS:
  private   readonly System.Int32                    _count  // 0x10
METHODS:
  System.Void .ctor(System.Int32 count)
  System.Int32 get_ProducedStack()
  System.Int32 get_ConsumedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LocalVariable
TYPE:  class
TOKEN: 0x20001BB
FIELDS:
  public    readonly System.Int32                    Index  // 0x10
  private           System.Int32                    _flags  // 0x14
METHODS:
  System.Boolean get_IsBoxed()
  System.Void set_IsBoxed(System.Boolean value)
  System.Boolean get_InClosure()
  System.Void .ctor(System.Int32 index, System.Boolean closure)
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LocalDefinition
TYPE:  struct
TOKEN: 0x20001BC
FIELDS:
  private   readonly System.Int32                    <Index>k__BackingField  // 0x10
  private   readonly System.Linq.Expressions.ParameterExpression<Parameter>k__BackingField  // 0x18
METHODS:
  System.Void .ctor(System.Int32 localIndex, System.Linq.Expressions.ParameterExpression parameter)
  System.Int32 get_Index()
  System.Linq.Expressions.ParameterExpression get_Parameter()
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LocalVariables
TYPE:  class
TOKEN: 0x20001BD
FIELDS:
  private   readonly System.Linq.Expressions.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariables.VariableScope>_variables  // 0x10
  private           System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable>_closureVariables  // 0x18
  private           System.Int32                    _localCount  // 0x20
  private           System.Int32                    _maxLocalCount  // 0x24
METHODS:
  System.Linq.Expressions.Interpreter.LocalDefinition DefineLocal(System.Linq.Expressions.ParameterExpression variable, System.Int32 start)
  System.Void UndefineLocal(System.Linq.Expressions.Interpreter.LocalDefinition definition, System.Int32 end)
  System.Void Box(System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Interpreter.InstructionList instructions)
  System.Int32 get_LocalCount()
  System.Boolean TryGetLocalOrClosure(System.Linq.Expressions.ParameterExpression var, System.Linq.Expressions.Interpreter.LocalVariable& local)
  System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> get_ClosureVariables()
  System.Linq.Expressions.Interpreter.LocalVariable AddClosureVariable(System.Linq.Expressions.ParameterExpression variable)
  System.Void .ctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ModuloInstruction
TYPE:  class
TOKEN: 0x20001BF
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_Single  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_Double  // 0x38
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.MulInstruction
TYPE:  class
TOKEN: 0x20001C8
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_Single  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_Double  // 0x38
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.MulOvfInstruction
TYPE:  class
TOKEN: 0x20001D1
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x28
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.NegateInstruction
TYPE:  class
TOKEN: 0x20001D8
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_Single  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_Double  // 0x20
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.NegateCheckedInstruction
TYPE:  class
TOKEN: 0x20001DE
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x10
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.NewInstruction
TYPE:  class
TOKEN: 0x20001E2
EXTENDS: Instruction
FIELDS:
  protected readonly System.Reflection.ConstructorInfo_constructor  // 0x10
  protected readonly System.Int32                    _argumentCount  // 0x18
METHODS:
  System.Void .ctor(System.Reflection.ConstructorInfo constructor, System.Int32 argumentCount)
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Object[] GetArgs(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Int32 first)
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ByRefNewInstruction
TYPE:  class
TOKEN: 0x20001E3
EXTENDS: NewInstruction
FIELDS:
  private   readonly System.Linq.Expressions.Interpreter.ByRefUpdater[]_byrefArgs  // 0x20
METHODS:
  System.Void .ctor(System.Reflection.ConstructorInfo target, System.Int32 argumentCount, System.Linq.Expressions.Interpreter.ByRefUpdater[] byrefArgs)
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.NotEqualInstruction
TYPE:  class
TOKEN: 0x20001E4
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_reference  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Boolean  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_SByte  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_Char  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_Byte  // 0x38
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x40
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x48
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x50
  private   static  System.Linq.Expressions.Interpreter.Instructions_Single  // 0x58
  private   static  System.Linq.Expressions.Interpreter.Instructions_Double  // 0x60
  private   static  System.Linq.Expressions.Interpreter.Instructions_SByteLiftedToNull  // 0x68
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16LiftedToNull  // 0x70
  private   static  System.Linq.Expressions.Interpreter.Instructions_CharLiftedToNull  // 0x78
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32LiftedToNull  // 0x80
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64LiftedToNull  // 0x88
  private   static  System.Linq.Expressions.Interpreter.Instructions_ByteLiftedToNull  // 0x90
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16LiftedToNull  // 0x98
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32LiftedToNull  // 0xA0
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64LiftedToNull  // 0xA8
  private   static  System.Linq.Expressions.Interpreter.Instructions_SingleLiftedToNull  // 0xB0
  private   static  System.Linq.Expressions.Interpreter.Instructions_DoubleLiftedToNull  // 0xB8
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type, System.Boolean liftedToNull)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.NotInstruction
TYPE:  class
TOKEN: 0x20001FD
EXTENDS: Instruction
FIELDS:
  public    static  System.Linq.Expressions.Interpreter.Instructions_Boolean  // 0x0
  public    static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x8
  public    static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x10
  public    static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x18
  public    static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x20
  public    static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x28
  public    static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x30
  public    static  System.Linq.Expressions.Interpreter.Instructions_Byte  // 0x38
  public    static  System.Linq.Expressions.Interpreter.Instructions_SByte  // 0x40
METHODS:
  System.Void .ctor()
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.NullCheckInstruction
TYPE:  class
TOKEN: 0x2000207
EXTENDS: Instruction
FIELDS:
  public    static readonly System.Linq.Expressions.Interpreter.InstructionInstance  // 0x0
METHODS:
  System.Void .ctor()
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.NumericConvertInstruction
TYPE:  class
TOKEN: 0x2000208
EXTENDS: Instruction
FIELDS:
  private   readonly System.TypeCode                 _from  // 0x10
  private   readonly System.TypeCode                 _to  // 0x14
  private   readonly System.Boolean                  _isLiftedToNull  // 0x18
METHODS:
  System.Void .ctor(System.TypeCode from, System.TypeCode to, System.Boolean isLiftedToNull)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Object Convert(System.Object obj)
  System.String get_InstructionName()
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.OrInstruction
TYPE:  class
TOKEN: 0x200020C
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_SByte  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_Byte  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x38
  private   static  System.Linq.Expressions.Interpreter.Instructions_Boolean  // 0x40
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.RightShiftInstruction
TYPE:  class
TOKEN: 0x2000216
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_SByte  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_Byte  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x38
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.RuntimeVariables
TYPE:  class
TOKEN: 0x200021F
FIELDS:
  private   readonly System.Runtime.CompilerServices.IStrongBox[]_boxes  // 0x10
METHODS:
  System.Void .ctor(System.Runtime.CompilerServices.IStrongBox[] boxes)
  System.Runtime.CompilerServices.IRuntimeVariables Create(System.Runtime.CompilerServices.IStrongBox[] boxes)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LoadObjectInstruction
TYPE:  class
TOKEN: 0x2000220
EXTENDS: Instruction
FIELDS:
  private   readonly System.Object                   _value  // 0x10
METHODS:
  System.Void .ctor(System.Object value)
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.LoadCachedObjectInstruction
TYPE:  class
TOKEN: 0x2000221
EXTENDS: Instruction
FIELDS:
  private   readonly System.UInt32                   _index  // 0x10
METHODS:
  System.Void .ctor(System.UInt32 index)
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.String ToDebugString(System.Int32 instructionIndex, System.Object cookie, System.Func<System.Int32,System.Int32> labelIndexer, System.Collections.Generic.IReadOnlyList<System.Object> objects)
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.PopInstruction
TYPE:  class
TOKEN: 0x2000222
EXTENDS: Instruction
FIELDS:
  private   static readonly System.Linq.Expressions.Interpreter.PopInstructionInstance  // 0x0
METHODS:
  System.Void .ctor()
  System.Int32 get_ConsumedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.DupInstruction
TYPE:  class
TOKEN: 0x2000223
EXTENDS: Instruction
FIELDS:
  private   static readonly System.Linq.Expressions.Interpreter.DupInstructionInstance  // 0x0
METHODS:
  System.Void .ctor()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.SubInstruction
TYPE:  class
TOKEN: 0x2000224
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x28
  private   static  System.Linq.Expressions.Interpreter.Instructions_Single  // 0x30
  private   static  System.Linq.Expressions.Interpreter.Instructions_Double  // 0x38
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.SubOvfInstruction
TYPE:  class
TOKEN: 0x200022D
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int16  // 0x0
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int32  // 0x8
  private   static  System.Linq.Expressions.Interpreter.Instructions_Int64  // 0x10
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt16  // 0x18
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt32  // 0x20
  private   static  System.Linq.Expressions.Interpreter.Instructions_UInt64  // 0x28
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.CreateDelegateInstruction
TYPE:  class
TOKEN: 0x2000234
EXTENDS: Instruction
FIELDS:
  private   readonly System.Linq.Expressions.Interpreter.LightDelegateCreator_creator  // 0x10
METHODS:
  System.Void .ctor(System.Linq.Expressions.Interpreter.LightDelegateCreator delegateCreator)
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.TypeIsInstruction
TYPE:  class
TOKEN: 0x2000235
EXTENDS: Instruction
FIELDS:
  private   readonly System.Type                     _type  // 0x10
METHODS:
  System.Void .ctor(System.Type type)
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.TypeAsInstruction
TYPE:  class
TOKEN: 0x2000236
EXTENDS: Instruction
FIELDS:
  private   readonly System.Type                     _type  // 0x10
METHODS:
  System.Void .ctor(System.Type type)
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.String ToString()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.TypeEqualsInstruction
TYPE:  class
TOKEN: 0x2000237
EXTENDS: Instruction
FIELDS:
  public    static readonly System.Linq.Expressions.Interpreter.TypeEqualsInstructionInstance  // 0x0
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
  System.Void .cctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.NullableMethodCallInstruction
TYPE:  class
TOKEN: 0x2000238
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.NullableMethodCallInstructions_hasValue  // 0x0
  private   static  System.Linq.Expressions.Interpreter.NullableMethodCallInstructions_value  // 0x8
  private   static  System.Linq.Expressions.Interpreter.NullableMethodCallInstructions_equals  // 0x10
  private   static  System.Linq.Expressions.Interpreter.NullableMethodCallInstructions_getHashCode  // 0x18
  private   static  System.Linq.Expressions.Interpreter.NullableMethodCallInstructions_getValueOrDefault1  // 0x20
  private   static  System.Linq.Expressions.Interpreter.NullableMethodCallInstructions_toString  // 0x28
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Void .ctor()
  System.Linq.Expressions.Interpreter.Instruction Create(System.String method, System.Int32 argCount, System.Reflection.MethodInfo mi)
  System.Linq.Expressions.Interpreter.Instruction CreateGetValue()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.CastInstruction
TYPE:  class
TOKEN: 0x2000240
EXTENDS: Instruction
FIELDS:
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_Boolean  // 0x0
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_Byte  // 0x8
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_Char  // 0x10
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_DateTime  // 0x18
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_Decimal  // 0x20
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_Double  // 0x28
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_Int16  // 0x30
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_Int32  // 0x38
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_Int64  // 0x40
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_SByte  // 0x48
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_Single  // 0x50
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_String  // 0x58
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_UInt16  // 0x60
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_UInt32  // 0x68
  private   static  System.Linq.Expressions.Interpreter.CastInstructions_UInt64  // 0x70
METHODS:
  System.Int32 get_ConsumedStack()
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Linq.Expressions.Interpreter.Instruction Create(System.Type t)
  System.Void .ctor()
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.CastToEnumInstruction
TYPE:  class
TOKEN: 0x2000245
EXTENDS: CastInstruction
FIELDS:
  private   readonly System.Type                     _t  // 0x10
METHODS:
  System.Void .ctor(System.Type t)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.CastReferenceToEnumInstruction
TYPE:  class
TOKEN: 0x2000246
EXTENDS: CastInstruction
FIELDS:
  private   readonly System.Type                     _t  // 0x10
METHODS:
  System.Void .ctor(System.Type t)
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.QuoteInstruction
TYPE:  class
TOKEN: 0x2000247
EXTENDS: Instruction
FIELDS:
  private   readonly System.Linq.Expressions.Expression_operand  // 0x10
  private   readonly System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable>_hoistedVariables  // 0x18
METHODS:
  System.Void .ctor(System.Linq.Expressions.Expression operand, System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> hoistedVariables)
  System.Int32 get_ProducedStack()
  System.String get_InstructionName()
  System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.DelegateHelpers
TYPE:  class
TOKEN: 0x2000249
FIELDS:
METHODS:
  System.Type MakeDelegate(System.Type[] types)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ScriptingRuntimeHelpers
TYPE:  class
TOKEN: 0x200024B
FIELDS:
METHODS:
  System.Object Int32ToObject(System.Int32 i)
  System.Object GetPrimitiveDefaultValue(System.Type type)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.ExceptionHelpers
TYPE:  class
TOKEN: 0x200024C
FIELDS:
METHODS:
  System.Void UnwrapAndRethrow(System.Reflection.TargetInvocationException exception)
END_CLASS

CLASS: System.Linq.Expressions.Interpreter.HybridReferenceDictionary`2
TYPE:  class
TOKEN: 0x200024D
FIELDS:
  private           System.Collections.Generic.KeyValuePair<TKey,TValue>[]_keysAndValues  // 0x0
  private           System.Collections.Generic.Dictionary<TKey,TValue>_dict  // 0x0
METHODS:
  System.Boolean TryGetValue(TKey key, TValue& value)
  System.Void Remove(TKey key)
  System.Boolean ContainsKey(TKey key)
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator()
  System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumeratorWorker()
  TValue get_Item(TKey key)
  System.Void set_Item(TKey key, TValue value)
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.RuntimeOps
TYPE:  class
TOKEN: 0x200024F
FIELDS:
METHODS:
  System.Boolean ExpandoTryGetValue(System.Dynamic.ExpandoObject expando, System.Object indexClass, System.Int32 index, System.String name, System.Boolean ignoreCase, System.Object& value)
  System.Object ExpandoTrySetValue(System.Dynamic.ExpandoObject expando, System.Object indexClass, System.Int32 index, System.Object value, System.String name, System.Boolean ignoreCase)
  System.Boolean ExpandoTryDeleteValue(System.Dynamic.ExpandoObject expando, System.Object indexClass, System.Int32 index, System.String name, System.Boolean ignoreCase)
  System.Boolean ExpandoCheckVersion(System.Dynamic.ExpandoObject expando, System.Object version)
  System.Void ExpandoPromoteClass(System.Dynamic.ExpandoObject expando, System.Object oldClass, System.Object newClass)
END_CLASS

CLASS: System.Runtime.CompilerServices.CallSite
TYPE:  class
TOKEN: 0x2000250
FIELDS:
  private   readonly System.Runtime.CompilerServices.CallSiteBinder_binder  // 0x10
  private           System.Boolean                  _match  // 0x18
METHODS:
  System.Void .ctor(System.Runtime.CompilerServices.CallSiteBinder binder)
  System.Runtime.CompilerServices.CallSiteBinder get_Binder()
END_CLASS

CLASS: System.Runtime.CompilerServices.CallSite`1
TYPE:  class
TOKEN: 0x2000251
EXTENDS: CallSite
FIELDS:
  public            T                               Target  // 0x0
  private           T[]                             Rules  // 0x0
  private   static  T                               s_cachedUpdate  // 0x0
  private   static  T                               s_cachedNoMatch  // 0x0
METHODS:
  T get_Update()
  System.Void .ctor(System.Runtime.CompilerServices.CallSiteBinder binder)
  System.Void .ctor()
  System.Runtime.CompilerServices.CallSite<T> CreateMatchMaker()
  System.Runtime.CompilerServices.CallSite<T> Create(System.Runtime.CompilerServices.CallSiteBinder binder)
  T GetUpdateDelegate()
  T GetUpdateDelegate(T& addr)
  System.Void AddRule(T newRule)
  System.Void MoveRule(System.Int32 i)
  T MakeUpdateDelegate()
  T CreateCustomUpdateDelegate(System.Reflection.MethodInfo invoke)
  T CreateCustomNoMatchDelegate(System.Reflection.MethodInfo invoke)
  System.Linq.Expressions.Expression Convert(System.Linq.Expressions.Expression arg, System.Type type)
END_CLASS

CLASS: System.Runtime.CompilerServices.CallSiteBinder
TYPE:  class
TOKEN: 0x2000253
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Type,System.Object>Cache  // 0x10
  private   static readonly System.Linq.Expressions.LabelTarget<UpdateLabel>k__BackingField  // 0x0
METHODS:
  System.Void .ctor()
  System.Linq.Expressions.LabelTarget get_UpdateLabel()
  System.Linq.Expressions.Expression Bind(System.Object[] args, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters, System.Linq.Expressions.LabelTarget returnLabel)
  T BindDelegate(System.Runtime.CompilerServices.CallSite<T> site, System.Object[] args)
  T BindCore(System.Runtime.CompilerServices.CallSite<T> site, System.Object[] args)
  System.Void CacheTarget(T target)
  System.Linq.Expressions.Expression<T> Stitch(System.Linq.Expressions.Expression binding, System.Runtime.CompilerServices.CallSiteBinder.LambdaSignature<T> signature)
  System.Runtime.CompilerServices.RuleCache<T> GetRuleCache()
  System.Void .cctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.CallSiteOps
TYPE:  class
TOKEN: 0x2000255
FIELDS:
METHODS:
  System.Runtime.CompilerServices.CallSite<T> CreateMatchmaker(System.Runtime.CompilerServices.CallSite<T> site)
  System.Boolean SetNotMatched(System.Runtime.CompilerServices.CallSite site)
  System.Boolean GetMatch(System.Runtime.CompilerServices.CallSite site)
  System.Void ClearMatch(System.Runtime.CompilerServices.CallSite site)
  System.Void AddRule(System.Runtime.CompilerServices.CallSite<T> site, T rule)
  System.Void UpdateRules(System.Runtime.CompilerServices.CallSite<T> this, System.Int32 matched)
  T[] GetRules(System.Runtime.CompilerServices.CallSite<T> site)
  System.Runtime.CompilerServices.RuleCache<T> GetRuleCache(System.Runtime.CompilerServices.CallSite<T> site)
  System.Void MoveRule(System.Runtime.CompilerServices.RuleCache<T> cache, T rule, System.Int32 i)
  T[] GetCachedRules(System.Runtime.CompilerServices.RuleCache<T> cache)
  T Bind(System.Runtime.CompilerServices.CallSiteBinder binder, System.Runtime.CompilerServices.CallSite<T> site, System.Object[] args)
END_CLASS

CLASS: System.Runtime.CompilerServices.IRuntimeVariables
TYPE:  interface
TOKEN: 0x2000256
FIELDS:
METHODS:
END_CLASS

CLASS: System.Runtime.CompilerServices.ReadOnlyCollectionBuilder`1
TYPE:  class
TOKEN: 0x2000257
FIELDS:
  private           T[]                             _items  // 0x0
  private           System.Int32                    _size  // 0x0
  private           System.Int32                    _version  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 capacity)
  System.Void set_Capacity(System.Int32 value)
  System.Int32 get_Count()
  System.Int32 IndexOf(T item)
  System.Void Insert(System.Int32 index, T item)
  System.Void RemoveAt(System.Int32 index)
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  System.Void Add(T item)
  System.Void Clear()
  System.Boolean Contains(T item)
  System.Void CopyTo(T[] array, System.Int32 arrayIndex)
  System.Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly()
  System.Boolean Remove(T item)
  System.Collections.Generic.IEnumerator<T> GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  System.Boolean System.Collections.IList.get_IsReadOnly()
  System.Int32 System.Collections.IList.Add(System.Object value)
  System.Boolean System.Collections.IList.Contains(System.Object value)
  System.Int32 System.Collections.IList.IndexOf(System.Object value)
  System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
  System.Boolean System.Collections.IList.get_IsFixedSize()
  System.Void System.Collections.IList.Remove(System.Object value)
  System.Object System.Collections.IList.get_Item(System.Int32 index)
  System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
  System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
  System.Boolean System.Collections.ICollection.get_IsSynchronized()
  System.Object System.Collections.ICollection.get_SyncRoot()
  T[] ToArray()
  System.Collections.ObjectModel.ReadOnlyCollection<T> ToReadOnlyCollection()
  System.Void EnsureCapacity(System.Int32 min)
  System.Boolean IsCompatibleObject(System.Object value)
  System.Void ValidateNullValue(System.Object value, System.String argument)
END_CLASS

CLASS: System.Runtime.CompilerServices.RuleCache`1
TYPE:  class
TOKEN: 0x2000259
FIELDS:
  private           T[]                             _rules  // 0x0
  private   readonly System.Object                   _cacheLock  // 0x0
METHODS:
  System.Void .ctor()
  T[] GetRules()
  System.Void MoveRule(T rule, System.Int32 i)
  System.Void AddRule(T newRule)
  T[] AddOrInsert(T[] rules, T item)
END_CLASS

CLASS: System.Runtime.CompilerServices.TrueReadOnlyCollection`1
TYPE:  class
TOKEN: 0x200025A
EXTENDS: ReadOnlyCollection`1
FIELDS:
METHODS:
  System.Void .ctor(T[] list)
END_CLASS

CLASS: System.Runtime.CompilerServices.StrongBox`1
TYPE:  class
TOKEN: 0x200025B
FIELDS:
  public            T                               Value  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(T value)
  System.Object System.Runtime.CompilerServices.IStrongBox.get_Value()
  System.Void System.Runtime.CompilerServices.IStrongBox.set_Value(System.Object value)
END_CLASS

CLASS: System.Runtime.CompilerServices.IStrongBox
TYPE:  interface
TOKEN: 0x200025C
FIELDS:
METHODS:
  System.Object get_Value()
  System.Void set_Value(System.Object value)
END_CLASS

CLASS: System.Security.Cryptography.AesManaged
TYPE:  class
TOKEN: 0x2000016
EXTENDS: Aes
FIELDS:
  private           System.Security.Cryptography.RijndaelManagedm_rijndael  // 0x48
METHODS:
  System.Void .ctor()
  System.Int32 get_FeedbackSize()
  System.Byte[] get_IV()
  System.Void set_IV(System.Byte[] value)
  System.Byte[] get_Key()
  System.Void set_Key(System.Byte[] value)
  System.Int32 get_KeySize()
  System.Void set_KeySize(System.Int32 value)
  System.Security.Cryptography.CipherMode get_Mode()
  System.Void set_Mode(System.Security.Cryptography.CipherMode value)
  System.Security.Cryptography.PaddingMode get_Padding()
  System.Void set_Padding(System.Security.Cryptography.PaddingMode value)
  System.Security.Cryptography.ICryptoTransform CreateDecryptor()
  System.Security.Cryptography.ICryptoTransform CreateDecryptor(System.Byte[] key, System.Byte[] iv)
  System.Security.Cryptography.ICryptoTransform CreateEncryptor()
  System.Security.Cryptography.ICryptoTransform CreateEncryptor(System.Byte[] key, System.Byte[] iv)
  System.Void Dispose(System.Boolean disposing)
  System.Void GenerateIV()
  System.Void GenerateKey()
END_CLASS

CLASS: System.Security.Cryptography.AesCryptoServiceProvider
TYPE:  class
TOKEN: 0x2000017
EXTENDS: Aes
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void GenerateIV()
  System.Void GenerateKey()
  System.Security.Cryptography.ICryptoTransform CreateDecryptor(System.Byte[] key, System.Byte[] iv)
  System.Security.Cryptography.ICryptoTransform CreateEncryptor(System.Byte[] key, System.Byte[] iv)
  System.Byte[] get_IV()
  System.Void set_IV(System.Byte[] value)
  System.Byte[] get_Key()
  System.Void set_Key(System.Byte[] value)
  System.Int32 get_KeySize()
  System.Void set_KeySize(System.Int32 value)
  System.Int32 get_FeedbackSize()
  System.Security.Cryptography.CipherMode get_Mode()
  System.Void set_Mode(System.Security.Cryptography.CipherMode value)
  System.Security.Cryptography.PaddingMode get_Padding()
  System.Void set_Padding(System.Security.Cryptography.PaddingMode value)
  System.Security.Cryptography.ICryptoTransform CreateDecryptor()
  System.Security.Cryptography.ICryptoTransform CreateEncryptor()
  System.Void Dispose(System.Boolean disposing)
END_CLASS

CLASS: System.Security.Cryptography.AesTransform
TYPE:  class
TOKEN: 0x2000018
EXTENDS: SymmetricTransform
FIELDS:
  private           System.UInt32[]                 expandedKey  // 0x58
  private           System.Int32                    Nk  // 0x60
  private           System.Int32                    Nr  // 0x64
  private   static readonly System.UInt32[]                 Rcon  // 0x0
  private   static readonly System.Byte[]                   SBox  // 0x8
  private   static readonly System.Byte[]                   iSBox  // 0x10
  private   static readonly System.UInt32[]                 T0  // 0x18
  private   static readonly System.UInt32[]                 T1  // 0x20
  private   static readonly System.UInt32[]                 T2  // 0x28
  private   static readonly System.UInt32[]                 T3  // 0x30
  private   static readonly System.UInt32[]                 iT0  // 0x38
  private   static readonly System.UInt32[]                 iT1  // 0x40
  private   static readonly System.UInt32[]                 iT2  // 0x48
  private   static readonly System.UInt32[]                 iT3  // 0x50
METHODS:
  System.Void .ctor(System.Security.Cryptography.Aes algo, System.Boolean encryption, System.Byte[] key, System.Byte[] iv)
  System.Void ECB(System.Byte[] input, System.Byte[] output)
  System.UInt32 SubByte(System.UInt32 a)
  System.Void Encrypt128(System.Byte[] indata, System.Byte[] outdata, System.UInt32[] ekey)
  System.Void Decrypt128(System.Byte[] indata, System.Byte[] outdata, System.UInt32[] ekey)
  System.Void .cctor()
END_CLASS

CLASS: System.Security.Cryptography.SHA256CryptoServiceProvider
TYPE:  class
TOKEN: 0x2000019
EXTENDS: SHA256
FIELDS:
  private   static  System.Byte[]                   Empty  // 0x0
  private           System.Security.Cryptography.SHA256hash  // 0x28
METHODS:
  System.Void .ctor()
  System.Void Initialize()
  System.Void HashCore(System.Byte[] array, System.Int32 ibStart, System.Int32 cbSize)
  System.Byte[] HashFinal()
  System.Void Dispose(System.Boolean disposing)
  System.Void .cctor()
END_CLASS

CLASS: System.Security.Cryptography.X509Certificates.RSACertificateExtensions
TYPE:  class
TOKEN: 0x200001A
FIELDS:
METHODS:
  System.Security.Cryptography.RSA GetRSAPublicKey(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
END_CLASS

CLASS: System.Threading.LockRecursionPolicy
TYPE:  struct
TOKEN: 0x200029A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Threading.LockRecursionPolicyNoRecursion  // 0x0
  public    static  System.Threading.LockRecursionPolicySupportsRecursion  // 0x0
METHODS:
END_CLASS

CLASS: System.Threading.ReaderWriterCount
TYPE:  class
TOKEN: 0x200029B
FIELDS:
  public            System.Int64                    lockID  // 0x10
  public            System.Int32                    readercount  // 0x18
  public            System.Int32                    writercount  // 0x1C
  public            System.Int32                    upgradecount  // 0x20
  public            System.Threading.ReaderWriterCountnext  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Threading.ReaderWriterLockSlim
TYPE:  class
TOKEN: 0x200029C
FIELDS:
  private           System.Boolean                  fIsReentrant  // 0x10
  private           System.Int32                    myLock  // 0x14
  private           System.UInt32                   numWriteWaiters  // 0x18
  private           System.UInt32                   numReadWaiters  // 0x1C
  private           System.UInt32                   numWriteUpgradeWaiters  // 0x20
  private           System.UInt32                   numUpgradeWaiters  // 0x24
  private           System.Boolean                  fNoWaiters  // 0x28
  private           System.Int32                    upgradeLockOwnerId  // 0x2C
  private           System.Int32                    writeLockOwnerId  // 0x30
  private           System.Threading.EventWaitHandlewriteEvent  // 0x38
  private           System.Threading.EventWaitHandlereadEvent  // 0x40
  private           System.Threading.EventWaitHandleupgradeEvent  // 0x48
  private           System.Threading.EventWaitHandlewaitUpgradeEvent  // 0x50
  private   static  System.Int64                    s_nextLockID  // 0x0
  private           System.Int64                    lockID  // 0x58
  private   static  System.Threading.ReaderWriterCountt_rwc  // 0xFFFFFFFF
  private           System.Boolean                  fUpgradeThreadHoldingRead  // 0x60
  private           System.UInt32                   owners  // 0x64
  private           System.Boolean                  fDisposed  // 0x68
METHODS:
  System.Void InitializeThreadCounts()
  System.Void .ctor()
  System.Void .ctor(System.Threading.LockRecursionPolicy recursionPolicy)
  System.Boolean IsRWEntryEmpty(System.Threading.ReaderWriterCount rwc)
  System.Boolean IsRwHashEntryChanged(System.Threading.ReaderWriterCount lrwc)
  System.Threading.ReaderWriterCount GetThreadRWCount(System.Boolean dontAllocate)
  System.Void EnterWriteLock()
  System.Boolean TryEnterWriteLock(System.Int32 millisecondsTimeout)
  System.Boolean TryEnterWriteLock(System.Threading.ReaderWriterLockSlim.TimeoutTracker timeout)
  System.Boolean TryEnterWriteLockCore(System.Threading.ReaderWriterLockSlim.TimeoutTracker timeout)
  System.Void EnterUpgradeableReadLock()
  System.Boolean TryEnterUpgradeableReadLock(System.Int32 millisecondsTimeout)
  System.Boolean TryEnterUpgradeableReadLock(System.Threading.ReaderWriterLockSlim.TimeoutTracker timeout)
  System.Boolean TryEnterUpgradeableReadLockCore(System.Threading.ReaderWriterLockSlim.TimeoutTracker timeout)
  System.Void ExitWriteLock()
  System.Void ExitUpgradeableReadLock()
  System.Void LazyCreateEvent(System.Threading.EventWaitHandle& waitEvent, System.Boolean makeAutoResetEvent)
  System.Boolean WaitOnEvent(System.Threading.EventWaitHandle waitEvent, System.UInt32& numWaiters, System.Threading.ReaderWriterLockSlim.TimeoutTracker timeout, System.Boolean isWriteWaiter)
  System.Void ExitAndWakeUpAppropriateWaiters()
  System.Void ExitAndWakeUpAppropriateWaitersPreferringWriters()
  System.Void ExitAndWakeUpAppropriateReadWaiters()
  System.Boolean IsWriterAcquired()
  System.Void SetWriterAcquired()
  System.Void ClearWriterAcquired()
  System.Void SetWritersWaiting()
  System.Void ClearWritersWaiting()
  System.Void SetUpgraderWaiting()
  System.Void ClearUpgraderWaiting()
  System.UInt32 GetNumReaders()
  System.Void EnterMyLock()
  System.Void EnterMyLockSpin()
  System.Void ExitMyLock()
  System.Void SpinWait(System.Int32 SpinCount)
  System.Void Dispose()
  System.Void Dispose(System.Boolean disposing)
  System.Boolean get_IsReadLockHeld()
  System.Boolean get_IsUpgradeableReadLockHeld()
  System.Boolean get_IsWriteLockHeld()
  System.Int32 get_RecursiveReadCount()
  System.Int32 get_RecursiveUpgradeCount()
  System.Int32 get_RecursiveWriteCount()
  System.Int32 get_WaitingReadCount()
  System.Int32 get_WaitingUpgradeCount()
  System.Int32 get_WaitingWriteCount()
END_CLASS

