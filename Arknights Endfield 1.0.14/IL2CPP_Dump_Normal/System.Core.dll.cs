// ========================================================
// Dumped by @desirepro
// Assembly: System.Core.dll
// Classes:  673
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000002
    public class SR
    {
        // Methods
        private System.String GetString(System.String name) { }
        private System.String Format(System.String resourceFormat, System.Object[] args) { }
        private System.String Format(System.String resourceFormat, System.Object p1) { }
        private System.String Format(System.String resourceFormat, System.Object p1, System.Object p2) { }
        private System.String Format(System.String resourceFormat, System.Object p1, System.Object p2, System.Object p3) { }

    }

    // TypeToken: 0x200001D
    public class Iterator`1, IEnumerable`1, IEnumerable, IEnumerator`1, IDisposable, IEnumerator
    {
        // Fields
        private System.Int32 threadId;        // 0x0
        private System.Int32 state;        // 0x0
        private TSource current;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private TSource get_Current() { }
        private System.Linq.Enumerable.Iterator<TSource> Clone() { }
        private System.Void Dispose() { }
        private System.Collections.Generic.IEnumerator<TSource> GetEnumerator() { }
        private System.Boolean MoveNext() { }
        private System.Collections.Generic.IEnumerable<TResult> Select(System.Func<TSource,TResult> selector) { }
        private System.Collections.Generic.IEnumerable<TSource> Where(System.Func<TSource,System.Boolean> predicate) { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200001E
    public class WhereEnumerableIterator`1 : Iterator`1
    {
        // Fields
        private System.Collections.Generic.IEnumerable<TSource> source;        // 0x0
        private System.Func<TSource,System.Boolean> predicate;        // 0x0
        private System.Collections.Generic.IEnumerator<TSource> enumerator;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate) { }
        private System.Linq.Enumerable.Iterator<TSource> Clone() { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Collections.Generic.IEnumerable<TResult> Select(System.Func<TSource,TResult> selector) { }
        private System.Collections.Generic.IEnumerable<TSource> Where(System.Func<TSource,System.Boolean> predicate) { }

    }

    // TypeToken: 0x200001F
    public class WhereArrayIterator`1 : Iterator`1
    {
        // Fields
        private TSource[] source;        // 0x0
        private System.Func<TSource,System.Boolean> predicate;        // 0x0
        private System.Int32 index;        // 0x0

        // Methods
        private System.Void .ctor(TSource[] source, System.Func<TSource,System.Boolean> predicate) { }
        private System.Linq.Enumerable.Iterator<TSource> Clone() { }
        private System.Boolean MoveNext() { }
        private System.Collections.Generic.IEnumerable<TResult> Select(System.Func<TSource,TResult> selector) { }
        private System.Collections.Generic.IEnumerable<TSource> Where(System.Func<TSource,System.Boolean> predicate) { }

    }

    // TypeToken: 0x2000020
    public class WhereListIterator`1 : Iterator`1
    {
        // Fields
        private System.Collections.Generic.List<TSource> source;        // 0x0
        private System.Func<TSource,System.Boolean> predicate;        // 0x0
        private System.Collections.Generic.List.Enumerator<TSource> enumerator;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.List<TSource> source, System.Func<TSource,System.Boolean> predicate) { }
        private System.Linq.Enumerable.Iterator<TSource> Clone() { }
        private System.Boolean MoveNext() { }
        private System.Collections.Generic.IEnumerable<TResult> Select(System.Func<TSource,TResult> selector) { }
        private System.Collections.Generic.IEnumerable<TSource> Where(System.Func<TSource,System.Boolean> predicate) { }

    }

    // TypeToken: 0x2000021
    public class WhereSelectEnumerableIterator`2 : Iterator`1
    {
        // Fields
        private System.Collections.Generic.IEnumerable<TSource> source;        // 0x0
        private System.Func<TSource,System.Boolean> predicate;        // 0x0
        private System.Func<TSource,TResult> selector;        // 0x0
        private System.Collections.Generic.IEnumerator<TSource> enumerator;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate, System.Func<TSource,TResult> selector) { }
        private System.Linq.Enumerable.Iterator<TResult> Clone() { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private System.Collections.Generic.IEnumerable<TResult2> Select(System.Func<TResult,TResult2> selector) { }
        private System.Collections.Generic.IEnumerable<TResult> Where(System.Func<TResult,System.Boolean> predicate) { }

    }

    // TypeToken: 0x2000022
    public class WhereSelectArrayIterator`2 : Iterator`1
    {
        // Fields
        private TSource[] source;        // 0x0
        private System.Func<TSource,System.Boolean> predicate;        // 0x0
        private System.Func<TSource,TResult> selector;        // 0x0
        private System.Int32 index;        // 0x0

        // Methods
        private System.Void .ctor(TSource[] source, System.Func<TSource,System.Boolean> predicate, System.Func<TSource,TResult> selector) { }
        private System.Linq.Enumerable.Iterator<TResult> Clone() { }
        private System.Boolean MoveNext() { }
        private System.Collections.Generic.IEnumerable<TResult2> Select(System.Func<TResult,TResult2> selector) { }
        private System.Collections.Generic.IEnumerable<TResult> Where(System.Func<TResult,System.Boolean> predicate) { }

    }

    // TypeToken: 0x2000023
    public class WhereSelectListIterator`2 : Iterator`1
    {
        // Fields
        private System.Collections.Generic.List<TSource> source;        // 0x0
        private System.Func<TSource,System.Boolean> predicate;        // 0x0
        private System.Func<TSource,TResult> selector;        // 0x0
        private System.Collections.Generic.List.Enumerator<TSource> enumerator;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.List<TSource> source, System.Func<TSource,System.Boolean> predicate, System.Func<TSource,TResult> selector) { }
        private System.Linq.Enumerable.Iterator<TResult> Clone() { }
        private System.Boolean MoveNext() { }
        private System.Collections.Generic.IEnumerable<TResult2> Select(System.Func<TResult,TResult2> selector) { }
        private System.Collections.Generic.IEnumerable<TResult> Where(System.Func<TResult,System.Boolean> predicate) { }

    }

    // TypeToken: 0x200003B
    public class Grouping, IGrouping`2, IEnumerable`1, IEnumerable, IList`1, ICollection`1
    {
        // Fields
        private TKey key;        // 0x0
        private System.Int32 hashCode;        // 0x0
        private TElement[] elements;        // 0x0
        private System.Int32 count;        // 0x0
        private System.Linq.Lookup.Grouping<TKey,TElement> hashNext;        // 0x0
        private System.Linq.Lookup.Grouping<TKey,TElement> next;        // 0x0

        // Methods
        private System.Void Add(TElement element) { }
        private System.Collections.Generic.IEnumerator<TElement> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private TKey get_Key() { }
        private System.Int32 System.Collections.Generic.ICollection<TElement>.get_Count() { }
        private System.Boolean System.Collections.Generic.ICollection<TElement>.get_IsReadOnly() { }
        private System.Void System.Collections.Generic.ICollection<TElement>.Add(TElement item) { }
        private System.Void System.Collections.Generic.ICollection<TElement>.Clear() { }
        private System.Boolean System.Collections.Generic.ICollection<TElement>.Contains(TElement item) { }
        private System.Void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, System.Int32 arrayIndex) { }
        private System.Boolean System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }
        private System.Int32 System.Collections.Generic.IList<TElement>.IndexOf(TElement item) { }
        private System.Void System.Collections.Generic.IList<TElement>.Insert(System.Int32 index, TElement item) { }
        private System.Void System.Collections.Generic.IList<TElement>.RemoveAt(System.Int32 index) { }
        private TElement System.Collections.Generic.IList<TElement>.get_Item(System.Int32 index) { }
        private System.Void System.Collections.Generic.IList<TElement>.set_Item(System.Int32 index, TElement value) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003F
    public struct Slot
    {
        // Fields
        private System.Int32 hashCode;        // 0x0
        private TElement value;        // 0x0
        private System.Int32 next;        // 0x0

    }

    // TypeToken: 0x2000050
    public class BinaryExpressionProxy
    {
    }

    // TypeToken: 0x2000051
    public class BlockExpressionProxy
    {
    }

    // TypeToken: 0x2000052
    public class CatchBlockProxy
    {
    }

    // TypeToken: 0x2000053
    public class ConditionalExpressionProxy
    {
    }

    // TypeToken: 0x2000054
    public class ConstantExpressionProxy
    {
    }

    // TypeToken: 0x2000055
    public class DebugInfoExpressionProxy
    {
    }

    // TypeToken: 0x2000056
    public class DefaultExpressionProxy
    {
    }

    // TypeToken: 0x2000057
    public class GotoExpressionProxy
    {
    }

    // TypeToken: 0x2000058
    public class IndexExpressionProxy
    {
    }

    // TypeToken: 0x2000059
    public class InvocationExpressionProxy
    {
    }

    // TypeToken: 0x200005A
    public class LabelExpressionProxy
    {
    }

    // TypeToken: 0x200005B
    public class LambdaExpressionProxy
    {
    }

    // TypeToken: 0x200005C
    public class ListInitExpressionProxy
    {
    }

    // TypeToken: 0x200005D
    public class LoopExpressionProxy
    {
    }

    // TypeToken: 0x200005E
    public class MemberExpressionProxy
    {
    }

    // TypeToken: 0x200005F
    public class MemberInitExpressionProxy
    {
    }

    // TypeToken: 0x2000060
    public class MethodCallExpressionProxy
    {
    }

    // TypeToken: 0x2000061
    public class NewArrayExpressionProxy
    {
    }

    // TypeToken: 0x2000062
    public class NewExpressionProxy
    {
    }

    // TypeToken: 0x2000063
    public class ParameterExpressionProxy
    {
    }

    // TypeToken: 0x2000064
    public class RuntimeVariablesExpressionProxy
    {
    }

    // TypeToken: 0x2000065
    public class SwitchCaseProxy
    {
    }

    // TypeToken: 0x2000066
    public class SwitchExpressionProxy
    {
    }

    // TypeToken: 0x2000067
    public class TryExpressionProxy
    {
    }

    // TypeToken: 0x2000068
    public class TypeBinaryExpressionProxy
    {
    }

    // TypeToken: 0x2000069
    public class UnaryExpressionProxy
    {
    }

    // TypeToken: 0x200006A
    public class ExtensionInfo
    {
        // Fields
        private readonly System.Linq.Expressions.ExpressionType NodeType;        // 0x10
        private readonly System.Type Type;        // 0x18

    }

    // TypeToken: 0x20000CC
    public class AddInt16 : AddInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CD
    public class AddInt32 : AddInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CE
    public class AddInt64 : AddInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000CF
    public class AddUInt16 : AddInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D0
    public class AddUInt32 : AddInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D1
    public class AddUInt64 : AddInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D2
    public class AddSingle : AddInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D3
    public class AddDouble : AddInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D5
    public class AddOvfInt16 : AddOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D6
    public class AddOvfInt32 : AddOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D7
    public class AddOvfInt64 : AddOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D8
    public class AddOvfUInt16 : AddOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000D9
    public class AddOvfUInt32 : AddOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DA
    public class AddOvfUInt64 : AddOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DC
    public class AndSByte : AndInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DD
    public class AndInt16 : AndInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DE
    public class AndInt32 : AndInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000DF
    public class AndInt64 : AndInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E0
    public class AndByte : AndInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E1
    public class AndUInt16 : AndInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E2
    public class AndUInt32 : AndInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E3
    public class AndUInt64 : AndInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000E4
    public class AndBoolean : AndInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000106
    public class DecrementInt16 : DecrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000107
    public class DecrementInt32 : DecrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000108
    public class DecrementInt64 : DecrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000109
    public class DecrementUInt16 : DecrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010A
    public class DecrementUInt32 : DecrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010B
    public class DecrementUInt64 : DecrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010C
    public class DecrementSingle : DecrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200010D
    public class DecrementDouble : DecrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000110
    public class DivInt16 : DivInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000111
    public class DivInt32 : DivInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000112
    public class DivInt64 : DivInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000113
    public class DivUInt16 : DivInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000114
    public class DivUInt32 : DivInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000115
    public class DivUInt64 : DivInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000116
    public class DivSingle : DivInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000117
    public class DivDouble : DivInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000119
    public class EqualBoolean : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011A
    public class EqualSByte : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011B
    public class EqualInt16 : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011C
    public class EqualChar : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011D
    public class EqualInt32 : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011E
    public class EqualInt64 : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200011F
    public class EqualByte : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000120
    public class EqualUInt16 : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000121
    public class EqualUInt32 : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000122
    public class EqualUInt64 : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000123
    public class EqualSingle : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000124
    public class EqualDouble : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000125
    public class EqualReference : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000126
    public class EqualBooleanLiftedToNull : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000127
    public class EqualSByteLiftedToNull : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000128
    public class EqualInt16LiftedToNull : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000129
    public class EqualCharLiftedToNull : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012A
    public class EqualInt32LiftedToNull : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012B
    public class EqualInt64LiftedToNull : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012C
    public class EqualByteLiftedToNull : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012D
    public class EqualUInt16LiftedToNull : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012E
    public class EqualUInt32LiftedToNull : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200012F
    public class EqualUInt64LiftedToNull : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000130
    public class EqualSingleLiftedToNull : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000131
    public class EqualDoubleLiftedToNull : EqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000133
    public class ExclusiveOrSByte : ExclusiveOrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000134
    public class ExclusiveOrInt16 : ExclusiveOrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000135
    public class ExclusiveOrInt32 : ExclusiveOrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000136
    public class ExclusiveOrInt64 : ExclusiveOrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000137
    public class ExclusiveOrByte : ExclusiveOrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000138
    public class ExclusiveOrUInt16 : ExclusiveOrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000139
    public class ExclusiveOrUInt32 : ExclusiveOrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013A
    public class ExclusiveOrUInt64 : ExclusiveOrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200013B
    public class ExclusiveOrBoolean : ExclusiveOrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000142
    public class GreaterThanSByte : GreaterThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000143
    public class GreaterThanInt16 : GreaterThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000144
    public class GreaterThanChar : GreaterThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000145
    public class GreaterThanInt32 : GreaterThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000146
    public class GreaterThanInt64 : GreaterThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000147
    public class GreaterThanByte : GreaterThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000148
    public class GreaterThanUInt16 : GreaterThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000149
    public class GreaterThanUInt32 : GreaterThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200014A
    public class GreaterThanUInt64 : GreaterThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200014B
    public class GreaterThanSingle : GreaterThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200014C
    public class GreaterThanDouble : GreaterThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200014E
    public class GreaterThanOrEqualSByte : GreaterThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200014F
    public class GreaterThanOrEqualInt16 : GreaterThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000150
    public class GreaterThanOrEqualChar : GreaterThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000151
    public class GreaterThanOrEqualInt32 : GreaterThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000152
    public class GreaterThanOrEqualInt64 : GreaterThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000153
    public class GreaterThanOrEqualByte : GreaterThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000154
    public class GreaterThanOrEqualUInt16 : GreaterThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000155
    public class GreaterThanOrEqualUInt32 : GreaterThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000156
    public class GreaterThanOrEqualUInt64 : GreaterThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000157
    public class GreaterThanOrEqualSingle : GreaterThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000158
    public class GreaterThanOrEqualDouble : GreaterThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200015A
    public class IncrementInt16 : IncrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015B
    public class IncrementInt32 : IncrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015C
    public class IncrementInt64 : IncrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015D
    public class IncrementUInt16 : IncrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015E
    public class IncrementUInt32 : IncrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200015F
    public class IncrementUInt64 : IncrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000160
    public class IncrementSingle : IncrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000161
    public class IncrementDouble : IncrementInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000164
    public class DebugView
    {
        // Fields
        private readonly System.Linq.Expressions.Interpreter.InstructionArray _array;        // 0x10

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Interpreter.InstructionArray array) { }
        private System.Linq.Expressions.Interpreter.InstructionList.DebugView.InstructionView[] GetInstructionViews(System.Boolean includeDebugCookies) { }
        private System.Int32 <GetInstructionViews>b__4_0(System.Int32 index) { }

    }

    // TypeToken: 0x2000167
    public struct InstructionView
    {
        // Fields
        private readonly System.Int32 _index;        // 0x10
        private readonly System.Int32 _stackDepth;        // 0x14
        private readonly System.Int32 _continuationsDepth;        // 0x18
        private readonly System.String _name;        // 0x20
        private readonly System.Linq.Expressions.Interpreter.Instruction _instruction;        // 0x28

        // Methods
        private System.String GetValue() { }
        private System.Void .ctor(System.Linq.Expressions.Interpreter.Instruction instruction, System.String name, System.Int32 index, System.Int32 stackDepth, System.Int32 continuationsDepth) { }

    }

    // TypeToken: 0x2000166
    public class DebugView
    {
        // Methods
        private System.Linq.Expressions.Interpreter.InstructionList.DebugView.InstructionView[] GetInstructionViews(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Interpreter.Instruction> instructions, System.Collections.Generic.IReadOnlyList<System.Object> objects, System.Func<System.Int32,System.Int32> labelIndexer, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.KeyValuePair<System.Int32,System.Object>> debugCookies) { }

    }

    // TypeToken: 0x2000170
    public class LeftShiftSByte : LeftShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000171
    public class LeftShiftInt16 : LeftShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000172
    public class LeftShiftInt32 : LeftShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000173
    public class LeftShiftInt64 : LeftShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000174
    public class LeftShiftByte : LeftShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000175
    public class LeftShiftUInt16 : LeftShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000176
    public class LeftShiftUInt32 : LeftShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000177
    public class LeftShiftUInt64 : LeftShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000179
    public class LessThanSByte : LessThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200017A
    public class LessThanInt16 : LessThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200017B
    public class LessThanChar : LessThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200017C
    public class LessThanInt32 : LessThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200017D
    public class LessThanInt64 : LessThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200017E
    public class LessThanByte : LessThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200017F
    public class LessThanUInt16 : LessThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000180
    public class LessThanUInt32 : LessThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000181
    public class LessThanUInt64 : LessThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000182
    public class LessThanSingle : LessThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000183
    public class LessThanDouble : LessThanInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000185
    public class LessThanOrEqualSByte : LessThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000186
    public class LessThanOrEqualInt16 : LessThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000187
    public class LessThanOrEqualChar : LessThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000188
    public class LessThanOrEqualInt32 : LessThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000189
    public class LessThanOrEqualInt64 : LessThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200018A
    public class LessThanOrEqualByte : LessThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200018B
    public class LessThanOrEqualUInt16 : LessThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200018C
    public class LessThanOrEqualUInt32 : LessThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200018D
    public class LessThanOrEqualUInt64 : LessThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200018E
    public class LessThanOrEqualSingle : LessThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200018F
    public class LessThanOrEqualDouble : LessThanOrEqualInstruction
    {
        // Methods
        private System.Void .ctor(System.Object nullValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000196
    public class DebugInfoComparer, IComparer`1
    {
        // Methods
        private System.Int32 System.Collections.Generic.IComparer<System.Linq.Expressions.Interpreter.DebugInfo>.Compare(System.Linq.Expressions.Interpreter.DebugInfo d1, System.Linq.Expressions.Interpreter.DebugInfo d2) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000199
    public class QuoteVisitor : ExpressionVisitor
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Int32> _definedParameters;        // 0x10
        public readonly System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression> _hoistedParameters;        // 0x18

        // Methods
        private System.Linq.Expressions.Expression VisitParameter(System.Linq.Expressions.ParameterExpression node) { }
        private System.Linq.Expressions.Expression VisitBlock(System.Linq.Expressions.BlockExpression node) { }
        private System.Linq.Expressions.CatchBlock VisitCatchBlock(System.Linq.Expressions.CatchBlock node) { }
        private System.Linq.Expressions.Expression VisitLambda(System.Linq.Expressions.Expression<T> node) { }
        private System.Void PushParameters(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { }
        private System.Void PopParameters(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001A3
    public class DebugViewPrinter
    {
        // Fields
        private readonly System.Linq.Expressions.Interpreter.Interpreter _interpreter;        // 0x10
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.Int32> _tryStart;        // 0x18
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.String> _handlerEnter;        // 0x20
        private readonly System.Collections.Generic.Dictionary<System.Int32,System.Int32> _handlerExit;        // 0x28
        private System.String _indent;        // 0x30

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Interpreter.Interpreter interpreter) { }
        private System.Void Analyze() { }
        private System.Void AddTryStart(System.Int32 index) { }
        private System.Void AddHandlerExit(System.Int32 index) { }
        private System.Void Indent() { }
        private System.Void Dedent() { }
        private System.String ToString() { }
        private System.Void EmitExits(System.Text.StringBuilder sb, System.Int32 index) { }

    }

    // TypeToken: 0x20001B2
    public class Reference : InitializeLocalInstruction, IBoxableInstruction
    {
        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index) { }
        private System.String get_InstructionName() { }

    }

    // TypeToken: 0x20001B3
    public class ImmutableValue : InitializeLocalInstruction, IBoxableInstruction
    {
        // Fields
        private readonly System.Object _defaultValue;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 index, System.Object defaultValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index) { }
        private System.String get_InstructionName() { }

    }

    // TypeToken: 0x20001B4
    public class ImmutableBox : InitializeLocalInstruction
    {
        // Fields
        private readonly System.Object _defaultValue;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 index, System.Object defaultValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.String get_InstructionName() { }

    }

    // TypeToken: 0x20001B5
    public class ImmutableRefBox : InitializeLocalInstruction
    {
        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.String get_InstructionName() { }

    }

    // TypeToken: 0x20001B6
    public class ParameterBox : InitializeLocalInstruction
    {
        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.String get_InstructionName() { }

    }

    // TypeToken: 0x20001B7
    public class Parameter : InitializeLocalInstruction, IBoxableInstruction
    {
        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index) { }
        private System.String get_InstructionName() { }

    }

    // TypeToken: 0x20001B8
    public class MutableValue : InitializeLocalInstruction, IBoxableInstruction
    {
        // Fields
        private readonly System.Type _type;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 index, System.Type type) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index) { }
        private System.String get_InstructionName() { }

    }

    // TypeToken: 0x20001B9
    public class MutableBox : InitializeLocalInstruction
    {
        // Fields
        private readonly System.Type _type;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 index, System.Type type) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.String get_InstructionName() { }

    }

    // TypeToken: 0x20001BE
    public class VariableScope
    {
        // Fields
        public readonly System.Int32 Start;        // 0x10
        public System.Int32 Stop;        // 0x14
        public readonly System.Linq.Expressions.Interpreter.LocalVariable Variable;        // 0x18
        public readonly System.Linq.Expressions.Interpreter.LocalVariables.VariableScope Parent;        // 0x20
        public System.Collections.Generic.List<System.Linq.Expressions.Interpreter.LocalVariables.VariableScope> ChildScopes;        // 0x28

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Interpreter.LocalVariable variable, System.Int32 start, System.Linq.Expressions.Interpreter.LocalVariables.VariableScope parent) { }

    }

    // TypeToken: 0x20001C0
    public class ModuloInt16 : ModuloInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C1
    public class ModuloInt32 : ModuloInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C2
    public class ModuloInt64 : ModuloInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C3
    public class ModuloUInt16 : ModuloInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C4
    public class ModuloUInt32 : ModuloInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C5
    public class ModuloUInt64 : ModuloInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C6
    public class ModuloSingle : ModuloInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C7
    public class ModuloDouble : ModuloInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001C9
    public class MulInt16 : MulInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001CA
    public class MulInt32 : MulInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001CB
    public class MulInt64 : MulInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001CC
    public class MulUInt16 : MulInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001CD
    public class MulUInt32 : MulInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001CE
    public class MulUInt64 : MulInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001CF
    public class MulSingle : MulInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D0
    public class MulDouble : MulInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D2
    public class MulOvfInt16 : MulOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D3
    public class MulOvfInt32 : MulOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D4
    public class MulOvfInt64 : MulOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D5
    public class MulOvfUInt16 : MulOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D6
    public class MulOvfUInt32 : MulOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D7
    public class MulOvfUInt64 : MulOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001D9
    public class NegateInt16 : NegateInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DA
    public class NegateInt32 : NegateInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DB
    public class NegateInt64 : NegateInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DC
    public class NegateSingle : NegateInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DD
    public class NegateDouble : NegateInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001DF
    public class NegateCheckedInt32 : NegateCheckedInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E0
    public class NegateCheckedInt16 : NegateCheckedInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E1
    public class NegateCheckedInt64 : NegateCheckedInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E5
    public class NotEqualBoolean : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E6
    public class NotEqualSByte : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E7
    public class NotEqualInt16 : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E8
    public class NotEqualChar : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001E9
    public class NotEqualInt32 : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EA
    public class NotEqualInt64 : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EB
    public class NotEqualByte : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EC
    public class NotEqualUInt16 : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001ED
    public class NotEqualUInt32 : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EE
    public class NotEqualUInt64 : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001EF
    public class NotEqualSingle : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F0
    public class NotEqualDouble : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F1
    public class NotEqualReference : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F2
    public class NotEqualSByteLiftedToNull : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F3
    public class NotEqualInt16LiftedToNull : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F4
    public class NotEqualCharLiftedToNull : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F5
    public class NotEqualInt32LiftedToNull : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F6
    public class NotEqualInt64LiftedToNull : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F7
    public class NotEqualByteLiftedToNull : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F8
    public class NotEqualUInt16LiftedToNull : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001F9
    public class NotEqualUInt32LiftedToNull : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001FA
    public class NotEqualUInt64LiftedToNull : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001FB
    public class NotEqualSingleLiftedToNull : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001FC
    public class NotEqualDoubleLiftedToNull : NotEqualInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001FE
    public class NotBoolean : NotInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001FF
    public class NotInt64 : NotInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000200
    public class NotInt32 : NotInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000201
    public class NotInt16 : NotInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000202
    public class NotUInt64 : NotInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000203
    public class NotUInt32 : NotInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000204
    public class NotUInt16 : NotInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000205
    public class NotByte : NotInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000206
    public class NotSByte : NotInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000209
    public class Unchecked : NumericConvertInstruction
    {
        // Methods
        private System.String get_InstructionName() { }
        private System.Void .ctor(System.TypeCode from, System.TypeCode to, System.Boolean isLiftedToNull) { }
        private System.Object Convert(System.Object obj) { }
        private System.Object ConvertInt32(System.Int32 obj) { }
        private System.Object ConvertInt64(System.Int64 obj) { }
        private System.Object ConvertUInt64(System.UInt64 obj) { }
        private System.Object ConvertDouble(System.Double obj) { }

    }

    // TypeToken: 0x200020A
    public class Checked : NumericConvertInstruction
    {
        // Methods
        private System.String get_InstructionName() { }
        private System.Void .ctor(System.TypeCode from, System.TypeCode to, System.Boolean isLiftedToNull) { }
        private System.Object Convert(System.Object obj) { }
        private System.Object ConvertInt32(System.Int32 obj) { }
        private System.Object ConvertInt64(System.Int64 obj) { }
        private System.Object ConvertUInt64(System.UInt64 obj) { }
        private System.Object ConvertDouble(System.Double obj) { }

    }

    // TypeToken: 0x200020B
    public class ToUnderlying : NumericConvertInstruction
    {
        // Methods
        private System.String get_InstructionName() { }
        private System.Void .ctor(System.TypeCode to, System.Boolean isLiftedToNull) { }
        private System.Object Convert(System.Object obj) { }

    }

    // TypeToken: 0x200020D
    public class OrSByte : OrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020E
    public class OrInt16 : OrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200020F
    public class OrInt32 : OrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000210
    public class OrInt64 : OrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000211
    public class OrByte : OrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000212
    public class OrUInt16 : OrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000213
    public class OrUInt32 : OrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000214
    public class OrUInt64 : OrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000215
    public class OrBoolean : OrInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000217
    public class RightShiftSByte : RightShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000218
    public class RightShiftInt16 : RightShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000219
    public class RightShiftInt32 : RightShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021A
    public class RightShiftInt64 : RightShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021B
    public class RightShiftByte : RightShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021C
    public class RightShiftUInt16 : RightShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021D
    public class RightShiftUInt32 : RightShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200021E
    public class RightShiftUInt64 : RightShiftInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000225
    public class SubInt16 : SubInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000226
    public class SubInt32 : SubInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000227
    public class SubInt64 : SubInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000228
    public class SubUInt16 : SubInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000229
    public class SubUInt32 : SubInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022A
    public class SubUInt64 : SubInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022B
    public class SubSingle : SubInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022C
    public class SubDouble : SubInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022E
    public class SubOvfInt16 : SubOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200022F
    public class SubOvfInt32 : SubOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000230
    public class SubOvfInt64 : SubOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000231
    public class SubOvfUInt16 : SubOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000232
    public class SubOvfUInt32 : SubOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000233
    public class SubOvfUInt64 : SubOvfInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000239
    public class HasValue : NullableMethodCallInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023A
    public class GetValue : NullableMethodCallInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023B
    public class GetValueOrDefault : NullableMethodCallInstruction
    {
        // Fields
        private readonly System.Type _defaultValueType;        // 0x10

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo mi) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200023C
    public class GetValueOrDefault1 : NullableMethodCallInstruction
    {
        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023D
    public class EqualsClass : NullableMethodCallInstruction
    {
        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023E
    public class ToStringClass : NullableMethodCallInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200023F
    public class GetHashCodeClass : NullableMethodCallInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000241
    public class CastInstructionT`1 : CastInstruction
    {
        // Methods
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000243
    public class Ref : CastInstructionNoT
    {
        // Methods
        private System.Void .ctor(System.Type t) { }
        private System.Void ConvertNull(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000244
    public class Value : CastInstructionNoT
    {
        // Methods
        private System.Void .ctor(System.Type t) { }
        private System.Void ConvertNull(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000242
    public class CastInstructionNoT : CastInstruction
    {
        // Fields
        private readonly System.Type _t;        // 0x10

        // Methods
        private System.Void .ctor(System.Type t) { }
        private System.Linq.Expressions.Interpreter.CastInstruction Create(System.Type t) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void ConvertNull(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000248
    public class ExpressionQuoter : ExpressionVisitor
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> _variables;        // 0x10
        private readonly System.Linq.Expressions.Interpreter.InterpretedFrame _frame;        // 0x18
        private readonly System.Collections.Generic.Stack<System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>> _shadowedVars;        // 0x20

        // Methods
        private System.Void .ctor(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> hoistedVariables, System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Linq.Expressions.Expression VisitLambda(System.Linq.Expressions.Expression<T> node) { }
        private System.Linq.Expressions.Expression VisitBlock(System.Linq.Expressions.BlockExpression node) { }
        private System.Linq.Expressions.CatchBlock VisitCatchBlock(System.Linq.Expressions.CatchBlock node) { }
        private System.Linq.Expressions.Expression VisitParameter(System.Linq.Expressions.ParameterExpression node) { }
        private System.Runtime.CompilerServices.IStrongBox GetBox(System.Linq.Expressions.ParameterExpression variable) { }

    }

    // TypeToken: 0x2000254
    public class LambdaSignature`1
    {
        // Fields
        private static System.Runtime.CompilerServices.CallSiteBinder.LambdaSignature<T> s_instance;        // 0x0
        private readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> Parameters;        // 0x0
        private readonly System.Linq.Expressions.LabelTarget ReturnLabel;        // 0x0

        // Methods
        private System.Runtime.CompilerServices.CallSiteBinder.LambdaSignature<T> get_Instance() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000258
    public class Enumerator, IEnumerator`1, IDisposable, IEnumerator
    {
        // Fields
        private readonly System.Runtime.CompilerServices.ReadOnlyCollectionBuilder<T> _builder;        // 0x0
        private readonly System.Int32 _version;        // 0x0
        private System.Int32 _index;        // 0x0
        private T _current;        // 0x0

        // Methods
        private System.Void .ctor(System.Runtime.CompilerServices.ReadOnlyCollectionBuilder<T> builder) { }
        private T get_Current() { }
        private System.Void Dispose() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Boolean MoveNext() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x2000260
    public struct AndNode
    {
        // Fields
        private System.Int32 Depth;        // 0x10
        private System.Linq.Expressions.Expression Node;        // 0x18

    }

    // TypeToken: 0x200025F
    public class TestBuilder
    {
        // Fields
        private readonly System.Collections.Generic.HashSet<System.Dynamic.BindingRestrictions> _unique;        // 0x10
        private readonly System.Collections.Generic.Stack<System.Dynamic.BindingRestrictions.TestBuilder.AndNode> _tests;        // 0x18

        // Methods
        private System.Void Append(System.Dynamic.BindingRestrictions restrictions) { }
        private System.Linq.Expressions.Expression ToExpression() { }
        private System.Void Push(System.Linq.Expressions.Expression node, System.Int32 depth) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000261
    public class MergedRestriction : BindingRestrictions
    {
        // Fields
        private readonly System.Dynamic.BindingRestrictions Left;        // 0x10
        private readonly System.Dynamic.BindingRestrictions Right;        // 0x18

        // Methods
        private System.Void .ctor(System.Dynamic.BindingRestrictions left, System.Dynamic.BindingRestrictions right) { }
        private System.Linq.Expressions.Expression GetExpression() { }

    }

    // TypeToken: 0x2000262
    public class CustomRestriction : BindingRestrictions
    {
        // Fields
        private readonly System.Linq.Expressions.Expression _expression;        // 0x10

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression expression) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Linq.Expressions.Expression GetExpression() { }

    }

    // TypeToken: 0x2000263
    public class TypeRestriction : BindingRestrictions
    {
        // Fields
        private readonly System.Linq.Expressions.Expression _expression;        // 0x10
        private readonly System.Type _type;        // 0x18

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression parameter, System.Type type) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Linq.Expressions.Expression GetExpression() { }

    }

    // TypeToken: 0x2000264
    public class InstanceRestriction : BindingRestrictions
    {
        // Fields
        private readonly System.Linq.Expressions.Expression _expression;        // 0x10
        private readonly System.Object _instance;        // 0x18

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression parameter, System.Object instance) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Linq.Expressions.Expression GetExpression() { }

    }

    // TypeToken: 0x2000265
    public class BindingRestrictionsProxy
    {
    }

    // TypeToken: 0x200026E
    public class KeyCollectionDebugView
    {
    }

    // TypeToken: 0x200026F
    public class KeyCollection, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly System.Dynamic.ExpandoObject _expando;        // 0x10
        private readonly System.Int32 _expandoVersion;        // 0x18
        private readonly System.Int32 _expandoCount;        // 0x1C
        private readonly System.Dynamic.ExpandoObject.ExpandoData _expandoData;        // 0x20

        // Methods
        private System.Void .ctor(System.Dynamic.ExpandoObject expando) { }
        private System.Void CheckVersion() { }
        private System.Void Add(System.String item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.String item) { }
        private System.Void CopyTo(System.String[] array, System.Int32 arrayIndex) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean Remove(System.String item) { }
        private System.Collections.Generic.IEnumerator<System.String> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000271
    public class ValueCollectionDebugView
    {
    }

    // TypeToken: 0x2000272
    public class ValueCollection, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly System.Dynamic.ExpandoObject _expando;        // 0x10
        private readonly System.Int32 _expandoVersion;        // 0x18
        private readonly System.Int32 _expandoCount;        // 0x1C
        private readonly System.Dynamic.ExpandoObject.ExpandoData _expandoData;        // 0x20

        // Methods
        private System.Void .ctor(System.Dynamic.ExpandoObject expando) { }
        private System.Void CheckVersion() { }
        private System.Void Add(System.Object item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.Object item) { }
        private System.Void CopyTo(System.Object[] array, System.Int32 arrayIndex) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean Remove(System.Object item) { }
        private System.Collections.Generic.IEnumerator<System.Object> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000274
    public class MetaExpando : DynamicMetaObject
    {
        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression expression, System.Dynamic.ExpandoObject value) { }
        private System.Dynamic.DynamicMetaObject BindGetOrInvokeMember(System.Dynamic.DynamicMetaObjectBinder binder, System.String name, System.Boolean ignoreCase, System.Dynamic.DynamicMetaObject fallback, System.Func<System.Dynamic.DynamicMetaObject,System.Dynamic.DynamicMetaObject> fallbackInvoke) { }
        private System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder) { }
        private System.Dynamic.DynamicMetaObject BindInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value) { }
        private System.Dynamic.DynamicMetaObject BindDeleteMember(System.Dynamic.DeleteMemberBinder binder) { }
        private System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames() { }
        private System.Dynamic.DynamicMetaObject AddDynamicTestAndDefer(System.Dynamic.DynamicMetaObjectBinder binder, System.Dynamic.ExpandoClass klass, System.Dynamic.ExpandoClass originalClass, System.Dynamic.DynamicMetaObject succeeds) { }
        private System.Dynamic.ExpandoClass GetClassEnsureIndex(System.String name, System.Boolean caseInsensitive, System.Dynamic.ExpandoObject obj, System.Dynamic.ExpandoClass& klass, System.Int32& index) { }
        private System.Linq.Expressions.Expression GetLimitedSelf() { }
        private System.Dynamic.BindingRestrictions GetRestrictions() { }
        private System.Dynamic.ExpandoObject get_Value() { }

    }

    // TypeToken: 0x2000277
    public class ExpandoData
    {
        // Fields
        private static System.Dynamic.ExpandoObject.ExpandoData Empty;        // 0x0
        private readonly System.Dynamic.ExpandoClass Class;        // 0x10
        private readonly System.Object[] _dataArray;        // 0x18
        private System.Int32 _version;        // 0x20

        // Methods
        private System.Object get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Object value) { }
        private System.Int32 get_Version() { }
        private System.Int32 get_Length() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Dynamic.ExpandoClass klass, System.Object[] data, System.Int32 version) { }
        private System.Dynamic.ExpandoObject.ExpandoData UpdateClass(System.Dynamic.ExpandoClass newClass) { }
        private System.Int32 GetAlignedSize(System.Int32 len) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000282
    public class Entry
    {
        // Fields
        private readonly System.Int32 _hash;        // 0x0
        private readonly TKey _key;        // 0x0
        private readonly TValue _value;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 hash, TKey key, TValue value) { }

    }

    // TypeToken: 0x2000295
    public struct ElementCount
    {
        // Fields
        private System.Int32 uniqueCount;        // 0x0
        private System.Int32 unfoundCount;        // 0x0

    }

    // TypeToken: 0x2000296
    public struct Slot
    {
        // Fields
        private System.Int32 hashCode;        // 0x0
        private System.Int32 next;        // 0x0
        private T value;        // 0x0

    }

    // TypeToken: 0x2000297
    public struct Enumerator, IEnumerator`1, IDisposable, IEnumerator
    {
        // Fields
        private System.Collections.Generic.HashSet<T> _set;        // 0x0
        private System.Int32 _index;        // 0x0
        private System.Int32 _version;        // 0x0
        private T _current;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.HashSet<T> set) { }
        private System.Void Dispose() { }
        private System.Boolean MoveNext() { }
        private T get_Current() { }
        private System.Object System.Collections.IEnumerator.get_Current() { }
        private System.Void System.Collections.IEnumerator.Reset() { }

    }

    // TypeToken: 0x200029D
    public struct TimeoutTracker
    {
        // Fields
        private System.Int32 m_total;        // 0x10
        private System.Int32 m_start;        // 0x14

        // Methods
        private System.Void .ctor(System.Int32 millisecondsTimeout) { }
        private System.Int32 get_RemainingMilliseconds() { }
        private System.Boolean get_IsExpired() { }

    }

    // TypeToken: 0x200029F
    public struct __StaticArrayInitTypeSize=120
    {
    }

    // TypeToken: 0x20002A0
    public struct __StaticArrayInitTypeSize=256
    {
    }

    // TypeToken: 0x20002A1
    public struct __StaticArrayInitTypeSize=1024
    {
    }

namespace Microsoft.Win32.SafeHandles
{

    // TypeToken: 0x2000003
    public class SafeMemoryMappedFileHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // Methods
        private System.Void .ctor(System.IntPtr preexistingHandle, System.Boolean ownsHandle) { }
        private System.Boolean ReleaseHandle() { }

    }

    // TypeToken: 0x2000004
    public class SafeMemoryMappedViewHandle : SafeBuffer
    {
        // Fields
        private System.IntPtr mmap_handle;        // 0x28

        // Methods
        private System.Void .ctor(System.IntPtr mmap_handle, System.IntPtr base_address, System.Int64 size) { }
        private System.Void Flush() { }
        private System.Boolean ReleaseHandle() { }

    }

}

namespace System
{

    // TypeToken: 0x2000005
    public class Action`9 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }

    }

    // TypeToken: 0x2000006
    public class Action`10 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }

    }

    // TypeToken: 0x2000007
    public class Action`11 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }

    }

    // TypeToken: 0x2000008
    public class Action`12 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }

    }

    // TypeToken: 0x2000009
    public class Action`13 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }

    }

    // TypeToken: 0x200000A
    public class Action`14 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }

    }

    // TypeToken: 0x200000B
    public class Action`15 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }

    }

    // TypeToken: 0x200000C
    public class Action`16 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private System.Void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) { }

    }

    // TypeToken: 0x200000D
    public class Func`10 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }

    }

    // TypeToken: 0x200000E
    public class Func`11 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }

    }

    // TypeToken: 0x200000F
    public class Func`12 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }

    }

    // TypeToken: 0x2000010
    public class Func`13 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }

    }

    // TypeToken: 0x2000011
    public class Func`14 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }

    }

    // TypeToken: 0x2000012
    public class Func`15 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }

    }

    // TypeToken: 0x2000013
    public class Func`16 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }

    }

    // TypeToken: 0x2000014
    public class Func`17 : MulticastDelegate
    {
        // Methods
        private System.Void .ctor(System.Object object, System.IntPtr method) { }
        private TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) { }

    }

    // TypeToken: 0x2000015
    public class MonoUtil
    {
        // Fields
        public static readonly System.Boolean IsUnix;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

}

namespace System.Collections.Generic
{

    // TypeToken: 0x2000292
    public struct ArrayBuilder`1
    {
        // Fields
        private T[] _array;        // 0x0
        private System.Int32 _count;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 capacity) { }
        private T[] ToArray() { }
        private System.Void UncheckedAdd(T item) { }

    }

    // TypeToken: 0x2000293
    public class BitHelper
    {
        // Fields
        private readonly System.Int32 _length;        // 0x10
        private readonly System.Int32* _arrayPtr;        // 0x18
        private readonly System.Int32[] _array;        // 0x20
        private readonly System.Boolean _useStackAlloc;        // 0x28

        // Methods
        private System.Void .ctor(System.Int32* bitArrayPtr, System.Int32 length) { }
        private System.Void .ctor(System.Int32[] bitArray, System.Int32 length) { }
        private System.Void MarkBit(System.Int32 bitPosition) { }
        private System.Boolean IsMarked(System.Int32 bitPosition) { }
        private System.Int32 ToIntArrayLength(System.Int32 n) { }

    }

    // TypeToken: 0x2000294
    public class HashSet`1, ICollection`1, IEnumerable`1, IEnumerable, ISet`1, IReadOnlyCollection`1, ISerializable, IDeserializationCallback
    {
        // Fields
        private static System.Int32 Lower31BitMask;        // 0x0
        private static System.Int32 StackAllocThreshold;        // 0x0
        private static System.Int32 ShrinkThreshold;        // 0x0
        private static System.String CapacityName;        // 0x0
        private static System.String ElementsName;        // 0x0
        private static System.String ComparerName;        // 0x0
        private static System.String VersionName;        // 0x0
        private System.Int32[] _buckets;        // 0x0
        private System.Collections.Generic.HashSet.Slot<T>[] _slots;        // 0x0
        private System.Int32 _count;        // 0x0
        private System.Int32 _lastIndex;        // 0x0
        private System.Int32 _freeList;        // 0x0
        private System.Collections.Generic.IEqualityComparer<T> _comparer;        // 0x0
        private System.Int32 _version;        // 0x0
        private System.Runtime.Serialization.SerializationInfo _siInfo;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Collections.Generic.IEqualityComparer<T> comparer) { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<T> collection) { }
        private System.Void .ctor(System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IEqualityComparer<T> comparer) { }
        private System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void CopyFrom(System.Collections.Generic.HashSet<T> source) { }
        private System.Void .ctor(System.Int32 capacity, System.Collections.Generic.IEqualityComparer<T> comparer) { }
        private System.Void System.Collections.Generic.ICollection<T>.Add(T item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(T item) { }
        private System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        private System.Boolean Remove(T item) { }
        private System.Int32 get_Count() { }
        private System.Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
        private System.Collections.Generic.HashSet.Enumerator<T> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        private System.Void OnDeserialization(System.Object sender) { }
        private System.Boolean Add(T item) { }
        private System.Boolean TryGetValue(T equalValue, T& actualValue) { }
        private System.Void UnionWith(System.Collections.Generic.IEnumerable<T> other) { }
        private System.Void IntersectWith(System.Collections.Generic.IEnumerable<T> other) { }
        private System.Void ExceptWith(System.Collections.Generic.IEnumerable<T> other) { }
        private System.Void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> other) { }
        private System.Boolean IsSubsetOf(System.Collections.Generic.IEnumerable<T> other) { }
        private System.Boolean IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other) { }
        private System.Boolean IsSupersetOf(System.Collections.Generic.IEnumerable<T> other) { }
        private System.Boolean IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other) { }
        private System.Boolean Overlaps(System.Collections.Generic.IEnumerable<T> other) { }
        private System.Boolean SetEquals(System.Collections.Generic.IEnumerable<T> other) { }
        private System.Void CopyTo(T[] array) { }
        private System.Void CopyTo(T[] array, System.Int32 arrayIndex, System.Int32 count) { }
        private System.Int32 RemoveWhere(System.Predicate<T> match) { }
        private System.Collections.Generic.IEqualityComparer<T> get_Comparer() { }
        private System.Int32 EnsureCapacity(System.Int32 capacity) { }
        private System.Void TrimExcess() { }
        private System.Collections.Generic.IEqualityComparer<System.Collections.Generic.HashSet<T>> CreateSetComparer() { }
        private System.Int32 Initialize(System.Int32 capacity) { }
        private System.Void IncreaseCapacity() { }
        private System.Void SetCapacity(System.Int32 newSize) { }
        private System.Boolean AddIfNotPresent(T value) { }
        private System.Void AddValue(System.Int32 index, System.Int32 hashCode, T value) { }
        private System.Boolean ContainsAllElements(System.Collections.Generic.IEnumerable<T> other) { }
        private System.Boolean IsSubsetOfHashSetWithSameEC(System.Collections.Generic.HashSet<T> other) { }
        private System.Void IntersectWithHashSetWithSameEC(System.Collections.Generic.HashSet<T> other) { }
        private System.Void IntersectWithEnumerable(System.Collections.Generic.IEnumerable<T> other) { }
        private System.Int32 InternalIndexOf(T item) { }
        private System.Void SymmetricExceptWithUniqueHashSet(System.Collections.Generic.HashSet<T> other) { }
        private System.Void SymmetricExceptWithEnumerable(System.Collections.Generic.IEnumerable<T> other) { }
        private System.Boolean AddOrGetLocation(T value, System.Int32& location) { }
        private System.Collections.Generic.HashSet.ElementCount<T> CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable<T> other, System.Boolean returnIfUnfound) { }
        private System.Boolean HashSetEquals(System.Collections.Generic.HashSet<T> set1, System.Collections.Generic.HashSet<T> set2, System.Collections.Generic.IEqualityComparer<T> comparer) { }
        private System.Boolean AreEqualityComparersEqual(System.Collections.Generic.HashSet<T> set1, System.Collections.Generic.HashSet<T> set2) { }
        private System.Int32 InternalGetHashCode(T item) { }

    }

    // TypeToken: 0x2000298
    public class HashSetEqualityComparer`1, IEqualityComparer`1
    {
        // Fields
        private readonly System.Collections.Generic.IEqualityComparer<T> _comparer;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Boolean Equals(System.Collections.Generic.HashSet<T> x, System.Collections.Generic.HashSet<T> y) { }
        private System.Int32 GetHashCode(System.Collections.Generic.HashSet<T> obj) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x2000299
    public class ICollectionDebugView`1
    {
    }

}

namespace System.Dynamic
{

    // TypeToken: 0x200025D
    public class BinaryOperationBinder : DynamicMetaObjectBinder
    {
        // Fields
        private readonly System.Linq.Expressions.ExpressionType <Operation>k__BackingField;        // 0x18

        // Methods
        private System.Linq.Expressions.ExpressionType get_Operation() { }
        private System.Dynamic.DynamicMetaObject FallbackBinaryOperation(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject arg) { }
        private System.Dynamic.DynamicMetaObject FallbackBinaryOperation(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject arg, System.Dynamic.DynamicMetaObject errorSuggestion) { }
        private System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }

    }

    // TypeToken: 0x200025E
    public class BindingRestrictions
    {
        // Fields
        public static readonly System.Dynamic.BindingRestrictions Empty;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Linq.Expressions.Expression GetExpression() { }
        private System.Dynamic.BindingRestrictions Merge(System.Dynamic.BindingRestrictions restrictions) { }
        private System.Dynamic.BindingRestrictions GetTypeRestriction(System.Linq.Expressions.Expression expression, System.Type type) { }
        private System.Dynamic.BindingRestrictions GetTypeRestriction(System.Dynamic.DynamicMetaObject obj) { }
        private System.Dynamic.BindingRestrictions GetInstanceRestriction(System.Linq.Expressions.Expression expression, System.Object instance) { }
        private System.Linq.Expressions.Expression ToExpression() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000266
    public class ConvertBinder : DynamicMetaObjectBinder
    {
        // Fields
        private readonly System.Type <Type>k__BackingField;        // 0x18

        // Methods
        private System.Type get_Type() { }
        private System.Dynamic.DynamicMetaObject FallbackConvert(System.Dynamic.DynamicMetaObject target) { }
        private System.Dynamic.DynamicMetaObject FallbackConvert(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion) { }
        private System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }

    }

    // TypeToken: 0x2000267
    public class CreateInstanceBinder : DynamicMetaObjectBinder
    {
        // Methods
        private System.Dynamic.DynamicMetaObject FallbackCreateInstance(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Dynamic.DynamicMetaObject FallbackCreateInstance(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion) { }
        private System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }

    }

    // TypeToken: 0x2000268
    public class DeleteIndexBinder : DynamicMetaObjectBinder
    {
        // Methods
        private System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Dynamic.DynamicMetaObject FallbackDeleteIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes) { }
        private System.Dynamic.DynamicMetaObject FallbackDeleteIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject errorSuggestion) { }

    }

    // TypeToken: 0x2000269
    public class DeleteMemberBinder : DynamicMetaObjectBinder
    {
        // Fields
        private readonly System.String <Name>k__BackingField;        // 0x18
        private readonly System.Boolean <IgnoreCase>k__BackingField;        // 0x20

        // Methods
        private System.String get_Name() { }
        private System.Boolean get_IgnoreCase() { }
        private System.Dynamic.DynamicMetaObject FallbackDeleteMember(System.Dynamic.DynamicMetaObject target) { }
        private System.Dynamic.DynamicMetaObject FallbackDeleteMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion) { }
        private System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }

    }

    // TypeToken: 0x200026A
    public class DynamicMetaObject
    {
        // Fields
        public static readonly System.Dynamic.DynamicMetaObject[] EmptyMetaObjects;        // 0x0
        private static readonly System.Object s_noValueSentinel;        // 0x8
        private readonly System.Object _value;        // 0x10
        private readonly System.Linq.Expressions.Expression <Expression>k__BackingField;        // 0x18
        private readonly System.Dynamic.BindingRestrictions <Restrictions>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression expression, System.Dynamic.BindingRestrictions restrictions) { }
        private System.Void .ctor(System.Linq.Expressions.Expression expression, System.Dynamic.BindingRestrictions restrictions, System.Object value) { }
        private System.Linq.Expressions.Expression get_Expression() { }
        private System.Dynamic.BindingRestrictions get_Restrictions() { }
        private System.Object get_Value() { }
        private System.Boolean get_HasValue() { }
        private System.Type get_RuntimeType() { }
        private System.Type get_LimitType() { }
        private System.Dynamic.DynamicMetaObject BindConvert(System.Dynamic.ConvertBinder binder) { }
        private System.Dynamic.DynamicMetaObject BindGetMember(System.Dynamic.GetMemberBinder binder) { }
        private System.Dynamic.DynamicMetaObject BindSetMember(System.Dynamic.SetMemberBinder binder, System.Dynamic.DynamicMetaObject value) { }
        private System.Dynamic.DynamicMetaObject BindDeleteMember(System.Dynamic.DeleteMemberBinder binder) { }
        private System.Dynamic.DynamicMetaObject BindGetIndex(System.Dynamic.GetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes) { }
        private System.Dynamic.DynamicMetaObject BindSetIndex(System.Dynamic.SetIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value) { }
        private System.Dynamic.DynamicMetaObject BindDeleteIndex(System.Dynamic.DeleteIndexBinder binder, System.Dynamic.DynamicMetaObject[] indexes) { }
        private System.Dynamic.DynamicMetaObject BindInvokeMember(System.Dynamic.InvokeMemberBinder binder, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Dynamic.DynamicMetaObject BindInvoke(System.Dynamic.InvokeBinder binder, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Dynamic.DynamicMetaObject BindCreateInstance(System.Dynamic.CreateInstanceBinder binder, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Dynamic.DynamicMetaObject BindUnaryOperation(System.Dynamic.UnaryOperationBinder binder) { }
        private System.Dynamic.DynamicMetaObject BindBinaryOperation(System.Dynamic.BinaryOperationBinder binder, System.Dynamic.DynamicMetaObject arg) { }
        private System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames() { }
        private System.Dynamic.DynamicMetaObject Create(System.Object value, System.Linq.Expressions.Expression expression) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200026B
    public class DynamicMetaObjectBinder : CallSiteBinder
    {
        // Methods
        private System.Void .ctor() { }
        private System.Type get_ReturnType() { }
        private System.Linq.Expressions.Expression Bind(System.Object[] args, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters, System.Linq.Expressions.LabelTarget returnLabel) { }
        private System.Dynamic.DynamicMetaObject[] CreateArgumentMetaObjects(System.Object[] args, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters) { }
        private System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Linq.Expressions.Expression GetUpdateExpression(System.Type type) { }
        private System.Boolean get_IsStandardBinder() { }

    }

    // TypeToken: 0x200026C
    public class ExpandoClass
    {
        // Fields
        private readonly System.String[] _keys;        // 0x10
        private readonly System.Int32 _hashCode;        // 0x18
        private System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.WeakReference>> _transitions;        // 0x20
        private static readonly System.Dynamic.ExpandoClass Empty;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.String[] keys, System.Int32 hashCode) { }
        private System.Dynamic.ExpandoClass FindNewClass(System.String newKey) { }
        private System.Collections.Generic.List<System.WeakReference> GetTransitionList(System.Int32 hashCode) { }
        private System.Int32 GetValueIndex(System.String name, System.Boolean caseInsensitive, System.Dynamic.ExpandoObject obj) { }
        private System.Int32 GetValueIndexCaseSensitive(System.String name) { }
        private System.Int32 GetValueIndexCaseInsensitive(System.String name, System.Dynamic.ExpandoObject obj) { }
        private System.String[] get_Keys() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200026D
    public class ExpandoObject, IDynamicMetaObjectProvider, IDictionary`2, ICollection`1, IEnumerable`1, IEnumerable, INotifyPropertyChanged
    {
        // Fields
        private static readonly System.Reflection.MethodInfo s_expandoTryGetValue;        // 0x0
        private static readonly System.Reflection.MethodInfo s_expandoTrySetValue;        // 0x8
        private static readonly System.Reflection.MethodInfo s_expandoTryDeleteValue;        // 0x10
        private static readonly System.Reflection.MethodInfo s_expandoPromoteClass;        // 0x18
        private static readonly System.Reflection.MethodInfo s_expandoCheckVersion;        // 0x20
        private readonly System.Object LockObject;        // 0x10
        private System.Dynamic.ExpandoObject.ExpandoData _data;        // 0x18
        private System.Int32 _count;        // 0x20
        private static readonly System.Object Uninitialized;        // 0x28
        private System.ComponentModel.PropertyChangedEventHandler _propertyChanged;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Boolean TryGetValue(System.Object indexClass, System.Int32 index, System.String name, System.Boolean ignoreCase, System.Object& value) { }
        private System.Void TrySetValue(System.Object indexClass, System.Int32 index, System.Object value, System.String name, System.Boolean ignoreCase, System.Boolean add) { }
        private System.Boolean TryDeleteValue(System.Object indexClass, System.Int32 index, System.String name, System.Boolean ignoreCase, System.Object deleteValue) { }
        private System.Boolean IsDeletedMember(System.Int32 index) { }
        private System.Dynamic.ExpandoClass get_Class() { }
        private System.Dynamic.ExpandoObject.ExpandoData PromoteClassCore(System.Dynamic.ExpandoClass oldClass, System.Dynamic.ExpandoClass newClass) { }
        private System.Void PromoteClass(System.Object oldClass, System.Object newClass) { }
        private System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter) { }
        private System.Void TryAddMember(System.String key, System.Object value) { }
        private System.Boolean TryGetValueForKey(System.String key, System.Object& value) { }
        private System.Boolean ExpandoContainsKey(System.String key) { }
        private System.Collections.Generic.ICollection<System.String> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Keys() { }
        private System.Collections.Generic.ICollection<System.Object> System.Collections.Generic.IDictionary<System.String,System.Object>.get_Values() { }
        private System.Object System.Collections.Generic.IDictionary<System.String,System.Object>.get_Item(System.String key) { }
        private System.Void System.Collections.Generic.IDictionary<System.String,System.Object>.set_Item(System.String key, System.Object value) { }
        private System.Void System.Collections.Generic.IDictionary<System.String,System.Object>.Add(System.String key, System.Object value) { }
        private System.Boolean System.Collections.Generic.IDictionary<System.String,System.Object>.ContainsKey(System.String key) { }
        private System.Boolean System.Collections.Generic.IDictionary<System.String,System.Object>.Remove(System.String key) { }
        private System.Boolean System.Collections.Generic.IDictionary<System.String,System.Object>.TryGetValue(System.String key, System.Object& value) { }
        private System.Int32 System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Count() { }
        private System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }
        private System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(System.Collections.Generic.KeyValuePair<System.String,System.Object> item) { }
        private System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Clear() { }
        private System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(System.Collections.Generic.KeyValuePair<System.String,System.Object> item) { }
        private System.Void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String,System.Object>[] array, System.Int32 arrayIndex) { }
        private System.Boolean System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(System.Collections.Generic.KeyValuePair<System.String,System.Object> item) { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>> GetExpandoEnumerator(System.Dynamic.ExpandoObject.ExpandoData data, System.Int32 version) { }
        private System.Void System.ComponentModel.INotifyPropertyChanged.add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void System.ComponentModel.INotifyPropertyChanged.remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler value) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000279
    public class GetIndexBinder : DynamicMetaObjectBinder
    {
        // Methods
        private System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Dynamic.DynamicMetaObject FallbackGetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes) { }
        private System.Dynamic.DynamicMetaObject FallbackGetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject errorSuggestion) { }

    }

    // TypeToken: 0x200027A
    public class GetMemberBinder : DynamicMetaObjectBinder
    {
        // Fields
        private readonly System.String <Name>k__BackingField;        // 0x18
        private readonly System.Boolean <IgnoreCase>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.String name, System.Boolean ignoreCase) { }
        private System.Type get_ReturnType() { }
        private System.String get_Name() { }
        private System.Boolean get_IgnoreCase() { }
        private System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target) { }
        private System.Dynamic.DynamicMetaObject FallbackGetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion) { }
        private System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Boolean get_IsStandardBinder() { }

    }

    // TypeToken: 0x200027B
    public interface IDynamicMetaObjectProvider
    {
        // Methods
        private System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { }

    }

    // TypeToken: 0x200027C
    public class InvokeBinder : DynamicMetaObjectBinder
    {
        // Methods
        private System.Dynamic.DynamicMetaObject FallbackInvoke(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Dynamic.DynamicMetaObject FallbackInvoke(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion) { }
        private System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }

    }

    // TypeToken: 0x200027D
    public class InvokeMemberBinder : DynamicMetaObjectBinder
    {
        // Fields
        private readonly System.String <Name>k__BackingField;        // 0x18
        private readonly System.Boolean <IgnoreCase>k__BackingField;        // 0x20

        // Methods
        private System.String get_Name() { }
        private System.Boolean get_IgnoreCase() { }
        private System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Dynamic.DynamicMetaObject FallbackInvokeMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Dynamic.DynamicMetaObject FallbackInvokeMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion) { }
        private System.Dynamic.DynamicMetaObject FallbackInvoke(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args, System.Dynamic.DynamicMetaObject errorSuggestion) { }

    }

    // TypeToken: 0x200027E
    public class SetIndexBinder : DynamicMetaObjectBinder
    {
        // Methods
        private System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Dynamic.DynamicMetaObject FallbackSetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value) { }
        private System.Dynamic.DynamicMetaObject FallbackSetIndex(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] indexes, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion) { }

    }

    // TypeToken: 0x200027F
    public class SetMemberBinder : DynamicMetaObjectBinder
    {
        // Fields
        private readonly System.String <Name>k__BackingField;        // 0x18
        private readonly System.Boolean <IgnoreCase>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.String name, System.Boolean ignoreCase) { }
        private System.Type get_ReturnType() { }
        private System.String get_Name() { }
        private System.Boolean get_IgnoreCase() { }
        private System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }
        private System.Boolean get_IsStandardBinder() { }
        private System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value) { }
        private System.Dynamic.DynamicMetaObject FallbackSetMember(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject value, System.Dynamic.DynamicMetaObject errorSuggestion) { }

    }

    // TypeToken: 0x2000280
    public class UnaryOperationBinder : DynamicMetaObjectBinder
    {
        // Methods
        private System.Dynamic.DynamicMetaObject FallbackUnaryOperation(System.Dynamic.DynamicMetaObject target) { }
        private System.Dynamic.DynamicMetaObject FallbackUnaryOperation(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject errorSuggestion) { }
        private System.Dynamic.DynamicMetaObject Bind(System.Dynamic.DynamicMetaObject target, System.Dynamic.DynamicMetaObject[] args) { }

    }

}

namespace System.Dynamic.Utils
{

    // TypeToken: 0x2000281
    public class CacheDict`2
    {
        // Fields
        private readonly System.Int32 _mask;        // 0x0
        private readonly System.Dynamic.Utils.CacheDict.Entry<TKey,TValue>[] _entries;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 size) { }
        private System.Int32 AlignSize(System.Int32 size) { }
        private System.Boolean TryGetValue(TKey key, TValue& value) { }
        private System.Void Add(TKey key, TValue value) { }
        private System.Void set_Item(TKey key, TValue value) { }

    }

    // TypeToken: 0x2000283
    public class CollectionExtensions
    {
        // Methods
        private System.Runtime.CompilerServices.TrueReadOnlyCollection<T> AddFirst(System.Collections.ObjectModel.ReadOnlyCollection<T> list, T item) { }
        private T[] AddLast(T[] array, T item) { }
        private T[] RemoveFirst(T[] array) { }
        private T[] RemoveLast(T[] array) { }
        private System.Collections.ObjectModel.ReadOnlyCollection<T> ToReadOnly(System.Collections.Generic.IEnumerable<T> enumerable) { }

    }

    // TypeToken: 0x2000284
    public class ContractUtils
    {
        // Methods
        private System.Exception get_Unreachable() { }
        private System.Void Requires(System.Boolean precondition, System.String paramName) { }
        private System.Void RequiresNotNull(System.Object value, System.String paramName) { }
        private System.Void RequiresNotNull(System.Object value, System.String paramName, System.Int32 index) { }
        private System.Void RequiresNotNullItems(System.Collections.Generic.IList<T> array, System.String arrayName) { }
        private System.String GetParamName(System.String paramName, System.Int32 index) { }
        private System.Void RequiresArrayRange(System.Collections.Generic.IList<T> array, System.Int32 offset, System.Int32 count, System.String offsetName, System.String countName) { }

    }

    // TypeToken: 0x2000285
    public class EmptyReadOnlyCollection`1
    {
        // Fields
        public static readonly System.Collections.ObjectModel.ReadOnlyCollection<T> Instance;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000286
    public class ExpressionUtils
    {
        // Methods
        private System.Collections.ObjectModel.ReadOnlyCollection<T> ReturnReadOnly(System.Collections.Generic.IReadOnlyList<T>& collection) { }
        private T ReturnObject(System.Object collectionOrT) { }
        private System.Void ValidateArgumentTypes(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>& arguments, System.String methodParamName) { }
        private System.Void ValidateArgumentCount(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind, System.Int32 count, System.Reflection.ParameterInfo[] pis) { }
        private System.Linq.Expressions.Expression ValidateOneArgument(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind, System.Linq.Expressions.Expression arguments, System.Reflection.ParameterInfo pi, System.String methodParamName, System.String argumentParamName, System.Int32 index) { }
        private System.Void RequiresCanRead(System.Linq.Expressions.Expression expression, System.String paramName) { }
        private System.Void RequiresCanRead(System.Linq.Expressions.Expression expression, System.String paramName, System.Int32 idx) { }
        private System.Boolean TryQuote(System.Type parameterType, System.Linq.Expressions.Expression& argument) { }
        private System.Reflection.ParameterInfo[] GetParametersForValidation(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind) { }
        private System.Boolean SameElements(System.Collections.Generic.IEnumerable<T>& replacement, System.Collections.Generic.IReadOnlyList<T> current) { }
        private System.Boolean SameElementsInCollection(System.Collections.Generic.ICollection<T> replacement, System.Collections.Generic.IReadOnlyList<T> current) { }
        private System.Void ValidateArgumentCount(System.Linq.Expressions.LambdaExpression lambda) { }

    }

    // TypeToken: 0x2000287
    public class ExpressionVisitorUtils
    {
        // Methods
        private System.Linq.Expressions.Expression[] VisitBlockExpressions(System.Linq.Expressions.ExpressionVisitor visitor, System.Linq.Expressions.BlockExpression block) { }
        private System.Linq.Expressions.ParameterExpression[] VisitParameters(System.Linq.Expressions.ExpressionVisitor visitor, System.Linq.Expressions.IParameterProvider nodes, System.String callerName) { }
        private System.Linq.Expressions.Expression[] VisitArguments(System.Linq.Expressions.ExpressionVisitor visitor, System.Linq.Expressions.IArgumentProvider nodes) { }

    }

    // TypeToken: 0x2000288
    public class TypeExtensions
    {
        // Fields
        private static readonly System.Dynamic.Utils.CacheDict<System.Reflection.MethodBase,System.Reflection.ParameterInfo[]> s_paramInfoCache;        // 0x0

        // Methods
        private System.Reflection.MethodInfo GetAnyStaticMethodValidated(System.Type type, System.String name, System.Type[] types) { }
        private System.Boolean MatchesArgumentTypes(System.Reflection.MethodInfo mi, System.Type[] argTypes) { }
        private System.Type GetReturnType(System.Reflection.MethodBase mi) { }
        private System.TypeCode GetTypeCode(System.Type type) { }
        private System.Reflection.ParameterInfo[] GetParametersCached(System.Reflection.MethodBase method) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000289
    public class TypeUtils
    {
        // Fields
        private static readonly System.Type[] s_arrayAssignableInterfaces;        // 0x0

        // Methods
        private System.Type GetNonNullableType(System.Type type) { }
        private System.Type GetNullableType(System.Type type) { }
        private System.Boolean IsNullableType(System.Type type) { }
        private System.Boolean IsNullableOrReferenceType(System.Type type) { }
        private System.Boolean IsBool(System.Type type) { }
        private System.Boolean IsNumeric(System.Type type) { }
        private System.Boolean IsInteger(System.Type type) { }
        private System.Boolean IsArithmetic(System.Type type) { }
        private System.Boolean IsUnsignedInt(System.Type type) { }
        private System.Boolean IsIntegerOrBool(System.Type type) { }
        private System.Boolean IsNumericOrBool(System.Type type) { }
        private System.Boolean IsValidInstanceType(System.Reflection.MemberInfo member, System.Type instanceType) { }
        private System.Boolean HasIdentityPrimitiveOrNullableConversionTo(System.Type source, System.Type dest) { }
        private System.Boolean HasReferenceConversionTo(System.Type source, System.Type dest) { }
        private System.Boolean StrictHasReferenceConversionTo(System.Type source, System.Type dest, System.Boolean skipNonArray) { }
        private System.Boolean HasArrayToInterfaceConversion(System.Type source, System.Type dest) { }
        private System.Boolean HasInterfaceToArrayConversion(System.Type source, System.Type dest) { }
        private System.Boolean IsCovariant(System.Type t) { }
        private System.Boolean IsContravariant(System.Type t) { }
        private System.Boolean IsInvariant(System.Type t) { }
        private System.Boolean IsDelegate(System.Type t) { }
        private System.Boolean IsLegalExplicitVariantDelegateConversion(System.Type source, System.Type dest) { }
        private System.Boolean IsConvertible(System.Type type) { }
        private System.Boolean HasReferenceEquality(System.Type left, System.Type right) { }
        private System.Boolean HasBuiltInEqualityOperator(System.Type left, System.Type right) { }
        private System.Boolean IsImplicitlyConvertibleTo(System.Type source, System.Type destination) { }
        private System.Reflection.MethodInfo GetUserDefinedCoercionMethod(System.Type convertFrom, System.Type convertToType) { }
        private System.Reflection.MethodInfo FindConversionOperator(System.Reflection.MethodInfo[] methods, System.Type typeFrom, System.Type typeTo) { }
        private System.Boolean IsImplicitNumericConversion(System.Type source, System.Type destination) { }
        private System.Boolean IsImplicitReferenceConversion(System.Type source, System.Type destination) { }
        private System.Boolean IsImplicitBoxingConversion(System.Type source, System.Type destination) { }
        private System.Boolean IsImplicitNullableConversion(System.Type source, System.Type destination) { }
        private System.Type FindGenericType(System.Type definition, System.Type type) { }
        private System.Reflection.MethodInfo GetBooleanOperator(System.Type type, System.String name) { }
        private System.Type GetNonRefType(System.Type type) { }
        private System.Boolean AreEquivalent(System.Type t1, System.Type t2) { }
        private System.Boolean AreReferenceAssignable(System.Type dest, System.Type src) { }
        private System.Boolean IsSameOrSubclass(System.Type type, System.Type subType) { }
        private System.Void ValidateType(System.Type type, System.String paramName) { }
        private System.Void ValidateType(System.Type type, System.String paramName, System.Boolean allowByRef, System.Boolean allowPointer) { }
        private System.Boolean ValidateType(System.Type type, System.String paramName, System.Int32 index) { }
        private System.Reflection.MethodInfo GetInvokeMethod(System.Type delegateType) { }
        private System.Void .cctor() { }

    }

}

namespace System.IO
{

    // TypeToken: 0x200028B
    public struct HandleInheritability
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.IO.HandleInheritability None;        // 0x0
        public static System.IO.HandleInheritability Inheritable;        // 0x0

    }

}

namespace System.IO.MemoryMappedFiles
{

    // TypeToken: 0x200028C
    public struct MemoryMappedFileAccess
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.IO.MemoryMappedFiles.MemoryMappedFileAccess ReadWrite;        // 0x0
        public static System.IO.MemoryMappedFiles.MemoryMappedFileAccess Read;        // 0x0
        public static System.IO.MemoryMappedFiles.MemoryMappedFileAccess Write;        // 0x0
        public static System.IO.MemoryMappedFiles.MemoryMappedFileAccess CopyOnWrite;        // 0x0
        public static System.IO.MemoryMappedFiles.MemoryMappedFileAccess ReadExecute;        // 0x0
        public static System.IO.MemoryMappedFiles.MemoryMappedFileAccess ReadWriteExecute;        // 0x0

    }

    // TypeToken: 0x200028D
    public struct MemoryMappedFileOptions
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.IO.MemoryMappedFiles.MemoryMappedFileOptions None;        // 0x0
        public static System.IO.MemoryMappedFiles.MemoryMappedFileOptions DelayAllocatePages;        // 0x0

    }

    // TypeToken: 0x200028E
    public class MemoryMappedViewAccessor : UnmanagedMemoryAccessor
    {
        // Fields
        private System.IO.MemoryMappedFiles.MemoryMappedView m_view;        // 0x30

        // Methods
        private System.Void .ctor(System.IO.MemoryMappedFiles.MemoryMappedView view) { }
        private Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle get_SafeMemoryMappedViewHandle() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Flush() { }

    }

    // TypeToken: 0x200028F
    public class MemoryMapImpl
    {
        // Methods
        private System.IntPtr OpenFileInternal(System.Char* path, System.Int32 path_length, System.IO.FileMode mode, System.Char* mapName, System.Int32 mapName_length, System.Int64& capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileOptions options, System.Int32& error) { }
        private System.IntPtr OpenHandleInternal(System.IntPtr handle, System.Char* mapName, System.Int32 mapName_length, System.Int64& capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileOptions options, System.Int32& error) { }
        private System.Void CloseMapping(System.IntPtr handle) { }
        private System.Void Flush(System.IntPtr file_handle) { }
        private System.Void ConfigureHandleInheritability(System.IntPtr handle, System.IO.HandleInheritability inheritability) { }
        private System.Boolean Unmap(System.IntPtr mmap_handle) { }
        private System.Int32 MapInternal(System.IntPtr handle, System.Int64 offset, System.Int64& size, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IntPtr& mmap_handle, System.IntPtr& base_address) { }
        private System.Void Map(System.IntPtr handle, System.Int64 offset, System.Int64& size, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IntPtr& mmap_handle, System.IntPtr& base_address) { }
        private System.Exception CreateException(System.Int32 error, System.String path) { }
        private System.Int32 StringLength(System.String a) { }
        private System.Void CheckString(System.String name, System.String value) { }
        private System.IntPtr OpenFile(System.String path, System.IO.FileMode mode, System.String mapName, System.Int64& capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileOptions options) { }
        private System.IntPtr OpenHandle(System.IntPtr handle, System.String mapName, System.Int64& capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileOptions options) { }

    }

    // TypeToken: 0x2000290
    public class MemoryMappedFile, IDisposable
    {
        // Fields
        private System.IO.FileStream stream;        // 0x10
        private System.Boolean keepOpen;        // 0x18
        private Microsoft.Win32.SafeHandles.SafeMemoryMappedFileHandle handle;        // 0x20

        // Methods
        private System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(System.String path, System.IO.FileMode mode) { }
        private System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(System.String path, System.IO.FileMode mode, System.String mapName, System.Int64 capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { }
        private System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(System.IO.FileStream fileStream, System.String mapName, System.Int64 capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.HandleInheritability inheritability, System.Boolean leaveOpen) { }
        private System.IO.MemoryMappedFiles.MemoryMappedViewAccessor CreateViewAccessor(System.Int64 offset, System.Int64 size, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { }
        private System.Void .ctor() { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.IO.FileAccess GetFileAccess(System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { }

    }

    // TypeToken: 0x2000291
    public class MemoryMappedView, IDisposable
    {
        // Fields
        private Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle m_viewHandle;        // 0x10
        private System.Int64 m_pointerOffset;        // 0x18
        private System.Int64 m_size;        // 0x20
        private System.IO.MemoryMappedFiles.MemoryMappedFileAccess m_access;        // 0x28

        // Methods
        private System.Void .ctor(Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle viewHandle, System.Int64 pointerOffset, System.Int64 size, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { }
        private Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle get_ViewHandle() { }
        private System.Int64 get_PointerOffset() { }
        private System.Int64 get_Size() { }
        private System.IO.MemoryMappedFiles.MemoryMappedFileAccess get_Access() { }
        private System.IO.MemoryMappedFiles.MemoryMappedView Create(System.IntPtr handle, System.Int64 offset, System.Int64 size, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { }
        private System.Void Flush(System.IntPtr capacity) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void Dispose() { }
        private System.Boolean get_IsClosed() { }

    }

}

namespace System.Linq
{

    // TypeToken: 0x200001B
    public class Error
    {
        // Methods
        private System.Exception ArgumentNull(System.String s) { }
        private System.Exception ArgumentOutOfRange(System.String s) { }
        private System.Exception MoreThanOneElement() { }
        private System.Exception MoreThanOneMatch() { }
        private System.Exception NoElements() { }
        private System.Exception NoMatch() { }
        private System.Exception NotSupported() { }

    }

    // TypeToken: 0x200001C
    public class Enumerable
    {
        // Methods
        private System.Collections.Generic.IEnumerable<TSource> Where(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate) { }
        private System.Collections.Generic.IEnumerable<TResult> Select(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TResult> selector) { }
        private System.Func<TSource,System.Boolean> CombinePredicates(System.Func<TSource,System.Boolean> predicate1, System.Func<TSource,System.Boolean> predicate2) { }
        private System.Func<TSource,TResult> CombineSelectors(System.Func<TSource,TMiddle> selector1, System.Func<TMiddle,TResult> selector2) { }
        private System.Collections.Generic.IEnumerable<TResult> SelectMany(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> selector) { }
        private System.Collections.Generic.IEnumerable<TResult> SelectManyIterator(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TResult>> selector) { }
        private System.Collections.Generic.IEnumerable<TResult> SelectMany(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource,TCollection,TResult> resultSelector) { }
        private System.Collections.Generic.IEnumerable<TResult> SelectManyIterator(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource,TCollection,TResult> resultSelector) { }
        private System.Collections.Generic.IEnumerable<TSource> Skip(System.Collections.Generic.IEnumerable<TSource> source, System.Int32 count) { }
        private System.Collections.Generic.IEnumerable<TSource> SkipIterator(System.Collections.Generic.IEnumerable<TSource> source, System.Int32 count) { }
        private System.Collections.Generic.IEnumerable<TResult> Join(System.Collections.Generic.IEnumerable<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter,TKey> outerKeySelector, System.Func<TInner,TKey> innerKeySelector, System.Func<TOuter,TInner,TResult> resultSelector) { }
        private System.Collections.Generic.IEnumerable<TResult> JoinIterator(System.Collections.Generic.IEnumerable<TOuter> outer, System.Collections.Generic.IEnumerable<TInner> inner, System.Func<TOuter,TKey> outerKeySelector, System.Func<TInner,TKey> innerKeySelector, System.Func<TOuter,TInner,TResult> resultSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        private System.Linq.IOrderedEnumerable<TSource> OrderBy(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector) { }
        private System.Linq.IOrderedEnumerable<TSource> OrderByDescending(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector) { }
        private System.Linq.IOrderedEnumerable<TSource> ThenBy(System.Linq.IOrderedEnumerable<TSource> source, System.Func<TSource,TKey> keySelector) { }
        private System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey,TSource>> GroupBy(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector) { }
        private System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey,TElement>> GroupBy(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector, System.Func<TSource,TElement> elementSelector) { }
        private System.Collections.Generic.IEnumerable<TSource> Concat(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { }
        private System.Collections.Generic.IEnumerable<TSource> ConcatIterator(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { }
        private System.Collections.Generic.IEnumerable<TSource> Prepend(System.Collections.Generic.IEnumerable<TSource> source, TSource element) { }
        private System.Collections.Generic.IEnumerable<TSource> PrependIterator(System.Collections.Generic.IEnumerable<TSource> source, TSource element) { }
        private System.Collections.Generic.IEnumerable<TSource> Distinct(System.Collections.Generic.IEnumerable<TSource> source) { }
        private System.Collections.Generic.IEnumerable<TSource> Distinct(System.Collections.Generic.IEnumerable<TSource> source, System.Collections.Generic.IEqualityComparer<TSource> comparer) { }
        private System.Collections.Generic.IEnumerable<TSource> DistinctIterator(System.Collections.Generic.IEnumerable<TSource> source, System.Collections.Generic.IEqualityComparer<TSource> comparer) { }
        private System.Collections.Generic.IEnumerable<TSource> Union(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { }
        private System.Collections.Generic.IEnumerable<TSource> UnionIterator(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { }
        private System.Collections.Generic.IEnumerable<TSource> Intersect(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { }
        private System.Collections.Generic.IEnumerable<TSource> IntersectIterator(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { }
        private System.Collections.Generic.IEnumerable<TSource> Reverse(System.Collections.Generic.IEnumerable<TSource> source) { }
        private System.Collections.Generic.IEnumerable<TSource> ReverseIterator(System.Collections.Generic.IEnumerable<TSource> source) { }
        private System.Boolean SequenceEqual(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second) { }
        private System.Boolean SequenceEqual(System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second, System.Collections.Generic.IEqualityComparer<TSource> comparer) { }
        private System.Collections.Generic.IEnumerable<TSource> AsEnumerable(System.Collections.Generic.IEnumerable<TSource> source) { }
        private TSource[] ToArray(System.Collections.Generic.IEnumerable<TSource> source) { }
        private System.Collections.Generic.List<TSource> ToList(System.Collections.Generic.IEnumerable<TSource> source) { }
        private System.Collections.Generic.Dictionary<TKey,TSource> ToDictionary(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector) { }
        private System.Collections.Generic.Dictionary<TKey,TElement> ToDictionary(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector, System.Func<TSource,TElement> elementSelector) { }
        private System.Collections.Generic.Dictionary<TKey,TElement> ToDictionary(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector, System.Func<TSource,TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        private System.Collections.Generic.IEnumerable<TResult> OfType(System.Collections.IEnumerable source) { }
        private System.Collections.Generic.IEnumerable<TResult> OfTypeIterator(System.Collections.IEnumerable source) { }
        private System.Collections.Generic.IEnumerable<TResult> Cast(System.Collections.IEnumerable source) { }
        private System.Collections.Generic.IEnumerable<TResult> CastIterator(System.Collections.IEnumerable source) { }
        private TSource First(System.Collections.Generic.IEnumerable<TSource> source) { }
        private TSource First(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate) { }
        private TSource FirstOrDefault(System.Collections.Generic.IEnumerable<TSource> source) { }
        private TSource FirstOrDefault(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate) { }
        private TSource Last(System.Collections.Generic.IEnumerable<TSource> source) { }
        private TSource LastOrDefault(System.Collections.Generic.IEnumerable<TSource> source) { }
        private TSource LastOrDefault(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate) { }
        private TSource Single(System.Collections.Generic.IEnumerable<TSource> source) { }
        private TSource Single(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate) { }
        private TSource SingleOrDefault(System.Collections.Generic.IEnumerable<TSource> source) { }
        private TSource SingleOrDefault(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate) { }
        private TSource ElementAt(System.Collections.Generic.IEnumerable<TSource> source, System.Int32 index) { }
        private System.Collections.Generic.IEnumerable<System.Int32> Range(System.Int32 start, System.Int32 count) { }
        private System.Collections.Generic.IEnumerable<System.Int32> RangeIterator(System.Int32 start, System.Int32 count) { }
        private System.Collections.Generic.IEnumerable<TResult> Repeat(TResult element, System.Int32 count) { }
        private System.Collections.Generic.IEnumerable<TResult> RepeatIterator(TResult element, System.Int32 count) { }
        private System.Collections.Generic.IEnumerable<TResult> Empty() { }
        private System.Boolean Any(System.Collections.Generic.IEnumerable<TSource> source) { }
        private System.Boolean Any(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate) { }
        private System.Boolean All(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate) { }
        private System.Int32 Count(System.Collections.Generic.IEnumerable<TSource> source) { }
        private System.Int32 Count(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.Boolean> predicate) { }
        private System.Boolean Contains(System.Collections.Generic.IEnumerable<TSource> source, TSource value) { }
        private System.Boolean Contains(System.Collections.Generic.IEnumerable<TSource> source, TSource value, System.Collections.Generic.IEqualityComparer<TSource> comparer) { }
        private TSource Aggregate(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TSource,TSource> func) { }
        private TAccumulate Aggregate(System.Collections.Generic.IEnumerable<TSource> source, TAccumulate seed, System.Func<TAccumulate,TSource,TAccumulate> func) { }
        private System.Int32 Min(System.Collections.Generic.IEnumerable<System.Int32> source) { }
        private System.Int32 Max(System.Collections.Generic.IEnumerable<System.Int32> source) { }
        private System.Collections.Generic.HashSet<TSource> ToHashSet(System.Collections.Generic.IEnumerable<TSource> source) { }
        private System.Collections.Generic.HashSet<TSource> ToHashSet(System.Collections.Generic.IEnumerable<TSource> source, System.Collections.Generic.IEqualityComparer<TSource> comparer) { }

    }

    // TypeToken: 0x2000034
    public class EmptyEnumerable`1
    {
        // Fields
        public static readonly TElement[] Instance;        // 0x0

        // Methods
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000035
    public class IdentityFunction`1
    {
        // Methods
        private System.Func<TElement,TElement> get_Instance() { }

    }

    // TypeToken: 0x2000037
    public interface IOrderedEnumerable`1 : IEnumerable`1, IEnumerable
    {
        // Methods
        private System.Linq.IOrderedEnumerable<TElement> CreateOrderedEnumerable(System.Func<TElement,TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer, System.Boolean descending) { }

    }

    // TypeToken: 0x2000038
    public interface IGrouping`2 : IEnumerable`1, IEnumerable
    {
        // Methods
        private TKey get_Key() { }

    }

    // TypeToken: 0x2000039
    public interface ILookup`2 : IEnumerable`1, IEnumerable
    {
    }

    // TypeToken: 0x200003A
    public class Lookup`2, IEnumerable`1, IEnumerable, ILookup`2
    {
        // Fields
        private System.Collections.Generic.IEqualityComparer<TKey> comparer;        // 0x0
        private System.Linq.Lookup.Grouping<TKey,TElement>[] groupings;        // 0x0
        private System.Linq.Lookup.Grouping<TKey,TElement> lastGrouping;        // 0x0
        private System.Int32 count;        // 0x0

        // Methods
        private System.Linq.Lookup<TKey,TElement> Create(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector, System.Func<TSource,TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        private System.Linq.Lookup<TKey,TElement> CreateForJoin(System.Collections.Generic.IEnumerable<TElement> source, System.Func<TElement,TKey> keySelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        private System.Void .ctor(System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        private System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Int32 InternalGetHashCode(TKey key) { }
        private System.Linq.Lookup.Grouping<TKey,TElement> GetGrouping(TKey key, System.Boolean create) { }
        private System.Void Resize() { }

    }

    // TypeToken: 0x200003E
    public class Set`1
    {
        // Fields
        private System.Int32[] buckets;        // 0x0
        private System.Linq.Set.Slot<TElement>[] slots;        // 0x0
        private System.Int32 count;        // 0x0
        private System.Int32 freeList;        // 0x0
        private System.Collections.Generic.IEqualityComparer<TElement> comparer;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IEqualityComparer<TElement> comparer) { }
        private System.Boolean Add(TElement value) { }
        private System.Boolean Remove(TElement value) { }
        private System.Boolean Find(TElement value, System.Boolean add) { }
        private System.Void Resize() { }
        private System.Int32 InternalGetHashCode(TElement value) { }

    }

    // TypeToken: 0x2000040
    public class GroupedEnumerable`3, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Collections.Generic.IEnumerable<TSource> source;        // 0x0
        private System.Func<TSource,TKey> keySelector;        // 0x0
        private System.Func<TSource,TElement> elementSelector;        // 0x0
        private System.Collections.Generic.IEqualityComparer<TKey> comparer;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector, System.Func<TSource,TElement> elementSelector, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        private System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000041
    public class OrderedEnumerable`1, IOrderedEnumerable`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private System.Collections.Generic.IEnumerable<TElement> source;        // 0x0

        // Methods
        private System.Collections.Generic.IEnumerator<TElement> GetEnumerator() { }
        private System.Linq.EnumerableSorter<TElement> GetEnumerableSorter(System.Linq.EnumerableSorter<TElement> next) { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Linq.IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(System.Func<TElement,TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer, System.Boolean descending) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000043
    public class OrderedEnumerable`2 : OrderedEnumerable`1
    {
        // Fields
        private System.Linq.OrderedEnumerable<TElement> parent;        // 0x0
        private System.Func<TElement,TKey> keySelector;        // 0x0
        private System.Collections.Generic.IComparer<TKey> comparer;        // 0x0
        private System.Boolean descending;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IEnumerable<TElement> source, System.Func<TElement,TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer, System.Boolean descending) { }
        private System.Linq.EnumerableSorter<TElement> GetEnumerableSorter(System.Linq.EnumerableSorter<TElement> next) { }

    }

    // TypeToken: 0x2000044
    public class EnumerableSorter`1
    {
        // Methods
        private System.Void ComputeKeys(TElement[] elements, System.Int32 count) { }
        private System.Int32 CompareKeys(System.Int32 index1, System.Int32 index2) { }
        private System.Int32[] Sort(TElement[] elements, System.Int32 count) { }
        private System.Void QuickSort(System.Int32[] map, System.Int32 left, System.Int32 right) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public class EnumerableSorter`2 : EnumerableSorter`1
    {
        // Fields
        private System.Func<TElement,TKey> keySelector;        // 0x0
        private System.Collections.Generic.IComparer<TKey> comparer;        // 0x0
        private System.Boolean descending;        // 0x0
        private System.Linq.EnumerableSorter<TElement> next;        // 0x0
        private TKey[] keys;        // 0x0

        // Methods
        private System.Void .ctor(System.Func<TElement,TKey> keySelector, System.Collections.Generic.IComparer<TKey> comparer, System.Boolean descending, System.Linq.EnumerableSorter<TElement> next) { }
        private System.Void ComputeKeys(TElement[] elements, System.Int32 count) { }
        private System.Int32 CompareKeys(System.Int32 index1, System.Int32 index2) { }

    }

    // TypeToken: 0x2000046
    public struct Buffer`1
    {
        // Fields
        private TElement[] items;        // 0x0
        private System.Int32 count;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.IEnumerable<TElement> source) { }
        private TElement[] ToArray() { }

    }

}

namespace System.Linq.Expressions
{

    // TypeToken: 0x2000047
    public class CachedReflectionInfo
    {
        // Fields
        private static System.Reflection.MethodInfo s_CallSiteOps_SetNotMatched;        // 0x0
        private static System.Reflection.MethodInfo s_CallSiteOps_CreateMatchmaker;        // 0x8
        private static System.Reflection.MethodInfo s_CallSiteOps_GetMatch;        // 0x10
        private static System.Reflection.MethodInfo s_CallSiteOps_ClearMatch;        // 0x18
        private static System.Reflection.MethodInfo s_CallSiteOps_UpdateRules;        // 0x20
        private static System.Reflection.MethodInfo s_CallSiteOps_GetRules;        // 0x28
        private static System.Reflection.MethodInfo s_CallSiteOps_GetRuleCache;        // 0x30
        private static System.Reflection.MethodInfo s_CallSiteOps_GetCachedRules;        // 0x38
        private static System.Reflection.MethodInfo s_CallSiteOps_AddRule;        // 0x40
        private static System.Reflection.MethodInfo s_CallSiteOps_MoveRule;        // 0x48
        private static System.Reflection.MethodInfo s_CallSiteOps_Bind;        // 0x50
        private static System.Reflection.MethodInfo s_String_op_Equality_String_String;        // 0x58
        private static System.Reflection.MethodInfo s_Math_Pow_Double_Double;        // 0x60

        // Methods
        private System.Reflection.MethodInfo get_CallSiteOps_SetNotMatched() { }
        private System.Reflection.MethodInfo get_CallSiteOps_CreateMatchmaker() { }
        private System.Reflection.MethodInfo get_CallSiteOps_GetMatch() { }
        private System.Reflection.MethodInfo get_CallSiteOps_ClearMatch() { }
        private System.Reflection.MethodInfo get_CallSiteOps_UpdateRules() { }
        private System.Reflection.MethodInfo get_CallSiteOps_GetRules() { }
        private System.Reflection.MethodInfo get_CallSiteOps_GetRuleCache() { }
        private System.Reflection.MethodInfo get_CallSiteOps_GetCachedRules() { }
        private System.Reflection.MethodInfo get_CallSiteOps_AddRule() { }
        private System.Reflection.MethodInfo get_CallSiteOps_MoveRule() { }
        private System.Reflection.MethodInfo get_CallSiteOps_Bind() { }
        private System.Reflection.MethodInfo get_String_op_Equality_String_String() { }
        private System.Reflection.MethodInfo get_Math_Pow_Double_Double() { }

    }

    // TypeToken: 0x2000048
    public class BinaryExpression : Expression
    {
        // Fields
        private readonly System.Linq.Expressions.Expression <Right>k__BackingField;        // 0x10
        private readonly System.Linq.Expressions.Expression <Left>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { }
        private System.Boolean get_CanReduce() { }
        private System.Boolean IsOpAssignment(System.Linq.Expressions.ExpressionType op) { }
        private System.Linq.Expressions.Expression get_Right() { }
        private System.Linq.Expressions.Expression get_Left() { }
        private System.Reflection.MethodInfo get_Method() { }
        private System.Reflection.MethodInfo GetMethod() { }
        private System.Linq.Expressions.BinaryExpression Update(System.Linq.Expressions.Expression left, System.Linq.Expressions.LambdaExpression conversion, System.Linq.Expressions.Expression right) { }
        private System.Linq.Expressions.Expression Reduce() { }
        private System.Linq.Expressions.ExpressionType GetBinaryOpFromAssignmentOp(System.Linq.Expressions.ExpressionType op) { }
        private System.Linq.Expressions.Expression ReduceVariable() { }
        private System.Linq.Expressions.Expression ReduceMember() { }
        private System.Linq.Expressions.Expression ReduceIndex() { }
        private System.Linq.Expressions.LambdaExpression get_Conversion() { }
        private System.Linq.Expressions.LambdaExpression GetConversion() { }
        private System.Boolean get_IsLifted() { }
        private System.Boolean get_IsLiftedToNull() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Boolean get_IsLiftedLogical() { }
        private System.Boolean get_IsReferenceComparison() { }
        private System.Linq.Expressions.Expression ReduceUserdefinedLifted() { }

    }

    // TypeToken: 0x2000049
    public class LogicalBinaryExpression : BinaryExpression
    {
        // Fields
        private readonly System.Linq.Expressions.ExpressionType <NodeType>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.Linq.Expressions.ExpressionType nodeType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }

    }

    // TypeToken: 0x200004A
    public class AssignBinaryExpression : BinaryExpression
    {
        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }

    }

    // TypeToken: 0x200004B
    public class CoalesceConversionBinaryExpression : BinaryExpression
    {
        // Fields
        private readonly System.Linq.Expressions.LambdaExpression _conversion;        // 0x20

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.LambdaExpression GetConversion() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Type get_Type() { }

    }

    // TypeToken: 0x200004C
    public class OpAssignMethodConversionBinaryExpression : MethodBinaryExpression
    {
        // Fields
        private readonly System.Linq.Expressions.LambdaExpression _conversion;        // 0x38

        // Methods
        private System.Void .ctor(System.Linq.Expressions.ExpressionType nodeType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Type type, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.LambdaExpression GetConversion() { }

    }

    // TypeToken: 0x200004D
    public class SimpleBinaryExpression : BinaryExpression
    {
        // Fields
        private readonly System.Linq.Expressions.ExpressionType <NodeType>k__BackingField;        // 0x20
        private readonly System.Type <Type>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(System.Linq.Expressions.ExpressionType nodeType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Type type) { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Type get_Type() { }

    }

    // TypeToken: 0x200004E
    public class MethodBinaryExpression : SimpleBinaryExpression
    {
        // Fields
        private readonly System.Reflection.MethodInfo _method;        // 0x30

        // Methods
        private System.Void .ctor(System.Linq.Expressions.ExpressionType nodeType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Type type, System.Reflection.MethodInfo method) { }
        private System.Reflection.MethodInfo GetMethod() { }

    }

    // TypeToken: 0x200004F
    public class Expression
    {
        // Fields
        private static readonly System.Dynamic.Utils.CacheDict<System.Type,System.Reflection.MethodInfo> s_lambdaDelegateCache;        // 0x0
        private static System.Dynamic.Utils.CacheDict<System.Type,System.Func<System.Linq.Expressions.Expression,System.String,System.Boolean,System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>,System.Linq.Expressions.LambdaExpression>> s_lambdaFactories;        // 0x8
        private static System.Runtime.CompilerServices.ConditionalWeakTable<System.Linq.Expressions.Expression,System.Linq.Expressions.Expression.ExtensionInfo> s_legacyCtorSupportTable;        // 0x10

        // Methods
        private System.Linq.Expressions.BinaryExpression Assign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { }
        private System.Linq.Expressions.BinaryExpression GetUserDefinedBinaryOperator(System.Linq.Expressions.ExpressionType binaryType, System.String name, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull) { }
        private System.Linq.Expressions.BinaryExpression GetMethodBasedBinaryOperator(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Boolean liftToNull) { }
        private System.Linq.Expressions.BinaryExpression GetMethodBasedAssignOperator(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion, System.Boolean liftToNull) { }
        private System.Linq.Expressions.BinaryExpression GetUserDefinedBinaryOperatorOrThrow(System.Linq.Expressions.ExpressionType binaryType, System.String name, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull) { }
        private System.Linq.Expressions.BinaryExpression GetUserDefinedAssignOperatorOrThrow(System.Linq.Expressions.ExpressionType binaryType, System.String name, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Linq.Expressions.LambdaExpression conversion, System.Boolean liftToNull) { }
        private System.Reflection.MethodInfo GetUserDefinedBinaryOperator(System.Linq.Expressions.ExpressionType binaryType, System.Type leftType, System.Type rightType, System.String name) { }
        private System.Boolean IsLiftingConditionalLogicalOperator(System.Type left, System.Type right, System.Reflection.MethodInfo method, System.Linq.Expressions.ExpressionType binaryType) { }
        private System.Boolean ParameterIsAssignable(System.Reflection.ParameterInfo pi, System.Type argType) { }
        private System.Void ValidateParamswithOperandsOrThrow(System.Type paramType, System.Type operandType, System.Linq.Expressions.ExpressionType exprType, System.String name) { }
        private System.Void ValidateOperator(System.Reflection.MethodInfo method) { }
        private System.Void ValidateMethodInfo(System.Reflection.MethodInfo method, System.String paramName) { }
        private System.Boolean IsNullComparison(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { }
        private System.Boolean IsNullConstant(System.Linq.Expressions.Expression e) { }
        private System.Void ValidateUserDefinedConditionalLogicOperator(System.Linq.Expressions.ExpressionType nodeType, System.Type left, System.Type right, System.Reflection.MethodInfo method) { }
        private System.Void VerifyOpTrueFalse(System.Linq.Expressions.ExpressionType nodeType, System.Type left, System.Reflection.MethodInfo opTrue, System.String paramName) { }
        private System.Boolean IsValidLiftedConditionalLogicalOperator(System.Type left, System.Type right, System.Reflection.ParameterInfo[] pms) { }
        private System.Linq.Expressions.BinaryExpression MakeBinary(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression MakeBinary(System.Linq.Expressions.ExpressionType binaryType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.BinaryExpression Equal(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { }
        private System.Linq.Expressions.BinaryExpression Equal(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression ReferenceEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { }
        private System.Linq.Expressions.BinaryExpression NotEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { }
        private System.Linq.Expressions.BinaryExpression NotEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression ReferenceNotEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { }
        private System.Linq.Expressions.BinaryExpression GetEqualityComparisonOperator(System.Linq.Expressions.ExpressionType binaryType, System.String opName, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull) { }
        private System.Linq.Expressions.BinaryExpression GreaterThan(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression LessThan(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression GreaterThanOrEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression LessThanOrEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression GetComparisonOperator(System.Linq.Expressions.ExpressionType binaryType, System.String opName, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftToNull) { }
        private System.Linq.Expressions.BinaryExpression AndAlso(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { }
        private System.Linq.Expressions.BinaryExpression AndAlso(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression OrElse(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression Coalesce(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Type ValidateCoalesceArgTypes(System.Type left, System.Type right) { }
        private System.Linq.Expressions.BinaryExpression Add(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression AddAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Void ValidateOpAssignConversionLambda(System.Linq.Expressions.LambdaExpression conversion, System.Linq.Expressions.Expression left, System.Reflection.MethodInfo method, System.Linq.Expressions.ExpressionType nodeType) { }
        private System.Linq.Expressions.BinaryExpression AddAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.BinaryExpression AddChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression Subtract(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression SubtractAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.BinaryExpression SubtractAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.BinaryExpression SubtractChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression Divide(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression DivideAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.BinaryExpression Modulo(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression ModuloAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.BinaryExpression Multiply(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression MultiplyAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.BinaryExpression MultiplyAssignChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.BinaryExpression MultiplyChecked(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Boolean IsSimpleShift(System.Type left, System.Type right) { }
        private System.Type GetResultTypeOfShift(System.Type left, System.Type right) { }
        private System.Linq.Expressions.BinaryExpression LeftShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression LeftShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.BinaryExpression RightShift(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression RightShiftAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.BinaryExpression And(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression AndAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.BinaryExpression Or(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression OrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.BinaryExpression ExclusiveOr(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression ExclusiveOrAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.BinaryExpression Power(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.BinaryExpression PowerAssign(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Reflection.MethodInfo method, System.Linq.Expressions.LambdaExpression conversion) { }
        private System.Linq.Expressions.BinaryExpression ArrayIndex(System.Linq.Expressions.Expression array, System.Linq.Expressions.Expression index) { }
        private System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) { }
        private System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) { }
        private System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) { }
        private System.Linq.Expressions.BlockExpression Block(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4) { }
        private System.Linq.Expressions.BlockExpression Block(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) { }
        private System.Linq.Expressions.BlockExpression Block(System.Type type, System.Linq.Expressions.Expression[] expressions) { }
        private System.Linq.Expressions.BlockExpression Block(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) { }
        private System.Linq.Expressions.BlockExpression Block(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] expressions) { }
        private System.Linq.Expressions.BlockExpression Block(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] expressions) { }
        private System.Linq.Expressions.BlockExpression Block(System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) { }
        private System.Linq.Expressions.BlockExpression Block(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> variables, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) { }
        private System.Linq.Expressions.BlockExpression BlockCore(System.Type type, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> expressions) { }
        private System.Void ValidateVariables(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> varList, System.String collectionName) { }
        private System.Linq.Expressions.BlockExpression GetOptimizedBlockExpression(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> expressions) { }
        private System.Linq.Expressions.CatchBlock MakeCatchBlock(System.Type type, System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression filter) { }
        private System.Linq.Expressions.ConditionalExpression Condition(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse) { }
        private System.Linq.Expressions.ConditionalExpression Condition(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse, System.Type type) { }
        private System.Linq.Expressions.ConditionalExpression IfThen(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue) { }
        private System.Linq.Expressions.ConstantExpression Constant(System.Object value) { }
        private System.Linq.Expressions.ConstantExpression Constant(System.Object value, System.Type type) { }
        private System.Linq.Expressions.DefaultExpression Empty() { }
        private System.Linq.Expressions.DefaultExpression Default(System.Type type) { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Type get_Type() { }
        private System.Boolean get_CanReduce() { }
        private System.Linq.Expressions.Expression Reduce() { }
        private System.Linq.Expressions.Expression VisitChildren(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Linq.Expressions.Expression ReduceAndCheck() { }
        private System.String ToString() { }
        private System.Void RequiresCanRead(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> items, System.String paramName) { }
        private System.Void RequiresCanWrite(System.Linq.Expressions.Expression expression, System.String paramName) { }
        private System.Linq.Expressions.GotoExpression Break(System.Linq.Expressions.LabelTarget target) { }
        private System.Linq.Expressions.GotoExpression Return(System.Linq.Expressions.LabelTarget target) { }
        private System.Linq.Expressions.GotoExpression Return(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value) { }
        private System.Linq.Expressions.GotoExpression Goto(System.Linq.Expressions.LabelTarget target, System.Type type) { }
        private System.Linq.Expressions.GotoExpression Goto(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value) { }
        private System.Linq.Expressions.GotoExpression MakeGoto(System.Linq.Expressions.GotoExpressionKind kind, System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value, System.Type type) { }
        private System.Void ValidateGoto(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression& value, System.String targetParameter, System.String valueParameter, System.Type type) { }
        private System.Void ValidateGotoType(System.Type expectedType, System.Linq.Expressions.Expression& value, System.String paramName) { }
        private System.Linq.Expressions.IndexExpression MakeIndex(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { }
        private System.Linq.Expressions.IndexExpression ArrayAccess(System.Linq.Expressions.Expression array, System.Linq.Expressions.Expression[] indexes) { }
        private System.Linq.Expressions.IndexExpression ArrayAccess(System.Linq.Expressions.Expression array, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> indexes) { }
        private System.Linq.Expressions.IndexExpression Property(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { }
        private System.Linq.Expressions.IndexExpression MakeIndexProperty(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, System.String paramName, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> argList) { }
        private System.Void ValidateIndexedProperty(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, System.String paramName, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>& argList) { }
        private System.Void ValidateAccessor(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] indexes, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>& arguments, System.String paramName) { }
        private System.Void ValidateAccessorArgumentTypes(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] indexes, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>& arguments, System.String paramName) { }
        private System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression) { }
        private System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Linq.Expressions.Expression arg0) { }
        private System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) { }
        private System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) { }
        private System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) { }
        private System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4) { }
        private System.Linq.Expressions.InvocationExpression Invoke(System.Linq.Expressions.Expression expression, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { }
        private System.Reflection.MethodInfo GetInvokeMethod(System.Linq.Expressions.Expression expression) { }
        private System.Linq.Expressions.LabelExpression Label(System.Linq.Expressions.LabelTarget target) { }
        private System.Linq.Expressions.LabelExpression Label(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression defaultValue) { }
        private System.Linq.Expressions.LabelTarget Label() { }
        private System.Linq.Expressions.LabelTarget Label(System.String name) { }
        private System.Linq.Expressions.LabelTarget Label(System.Type type) { }
        private System.Linq.Expressions.LabelTarget Label(System.Type type, System.String name) { }
        private System.Linq.Expressions.LambdaExpression CreateLambda(System.Type delegateType, System.Linq.Expressions.Expression body, System.String name, System.Boolean tailCall, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters) { }
        private System.Linq.Expressions.Expression<TDelegate> Lambda(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters) { }
        private System.Linq.Expressions.Expression<TDelegate> Lambda(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { }
        private System.Linq.Expressions.Expression<TDelegate> Lambda(System.Linq.Expressions.Expression body, System.Boolean tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { }
        private System.Linq.Expressions.Expression<TDelegate> Lambda(System.Linq.Expressions.Expression body, System.String name, System.Boolean tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { }
        private System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters) { }
        private System.Linq.Expressions.LambdaExpression Lambda(System.Type delegateType, System.Linq.Expressions.Expression body, System.String name, System.Boolean tailCall, System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression> parameters) { }
        private System.Void ValidateLambdaArgs(System.Type delegateType, System.Linq.Expressions.Expression& body, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters, System.String paramName) { }
        private System.Linq.Expressions.LoopExpression Loop(System.Linq.Expressions.Expression body, System.Linq.Expressions.LabelTarget break, System.Linq.Expressions.LabelTarget continue) { }
        private System.Linq.Expressions.MemberExpression Field(System.Linq.Expressions.Expression expression, System.Reflection.FieldInfo field) { }
        private System.Linq.Expressions.MemberExpression Field(System.Linq.Expressions.Expression expression, System.String fieldName) { }
        private System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, System.String propertyName) { }
        private System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, System.Reflection.PropertyInfo property) { }
        private System.Linq.Expressions.MemberExpression Property(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo propertyAccessor) { }
        private System.Reflection.PropertyInfo GetProperty(System.Reflection.MethodInfo mi, System.String paramName, System.Int32 index) { }
        private System.Boolean CheckMethod(System.Reflection.MethodInfo method, System.Reflection.MethodInfo propertyMethod) { }
        private System.Linq.Expressions.MemberExpression MakeMemberAccess(System.Linq.Expressions.Expression expression, System.Reflection.MemberInfo member) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression[] arguments) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Reflection.MethodInfo method, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Linq.Expressions.Expression[] arguments) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.String methodName, System.Type[] typeArguments, System.Linq.Expressions.Expression[] arguments) { }
        private System.Linq.Expressions.MethodCallExpression Call(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments) { }
        private System.Reflection.ParameterInfo[] ValidateMethodAndGetParameters(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method) { }
        private System.Void ValidateStaticOrInstanceMethod(System.Linq.Expressions.Expression instance, System.Reflection.MethodInfo method) { }
        private System.Void ValidateCallInstanceType(System.Type instanceType, System.Reflection.MethodInfo method) { }
        private System.Void ValidateArgumentTypes(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>& arguments, System.String methodParamName) { }
        private System.Reflection.ParameterInfo[] GetParametersForValidation(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind) { }
        private System.Void ValidateArgumentCount(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind, System.Int32 count, System.Reflection.ParameterInfo[] pis) { }
        private System.Linq.Expressions.Expression ValidateOneArgument(System.Reflection.MethodBase method, System.Linq.Expressions.ExpressionType nodeKind, System.Linq.Expressions.Expression arg, System.Reflection.ParameterInfo pi, System.String methodParamName, System.String argumentParamName) { }
        private System.Boolean TryQuote(System.Type parameterType, System.Linq.Expressions.Expression& argument) { }
        private System.Reflection.MethodInfo FindMethod(System.Type type, System.String methodName, System.Type[] typeArgs, System.Linq.Expressions.Expression[] args, System.Reflection.BindingFlags flags) { }
        private System.Boolean IsCompatible(System.Reflection.MethodBase m, System.Linq.Expressions.Expression[] arguments) { }
        private System.Reflection.MethodInfo ApplyTypeArgs(System.Reflection.MethodInfo m, System.Type[] typeArgs) { }
        private System.Linq.Expressions.NewArrayExpression NewArrayInit(System.Type type, System.Linq.Expressions.Expression[] initializers) { }
        private System.Linq.Expressions.NewArrayExpression NewArrayInit(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> initializers) { }
        private System.Linq.Expressions.NewArrayExpression NewArrayBounds(System.Type type, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> bounds) { }
        private System.Linq.Expressions.ParameterExpression Parameter(System.Type type) { }
        private System.Linq.Expressions.ParameterExpression Parameter(System.Type type, System.String name) { }
        private System.Linq.Expressions.ParameterExpression Variable(System.Type type, System.String name) { }
        private System.Void Validate(System.Type type, System.Boolean allowByRef) { }
        private System.Linq.Expressions.TryExpression TryFinally(System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression finally) { }
        private System.Linq.Expressions.TryExpression MakeTry(System.Type type, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression finally, System.Linq.Expressions.Expression fault, System.Collections.Generic.IEnumerable<System.Linq.Expressions.CatchBlock> handlers) { }
        private System.Void ValidateTryAndCatchHaveSameType(System.Type type, System.Linq.Expressions.Expression tryBody, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock> handlers) { }
        private System.Linq.Expressions.TypeBinaryExpression TypeIs(System.Linq.Expressions.Expression expression, System.Type type) { }
        private System.Linq.Expressions.TypeBinaryExpression TypeEqual(System.Linq.Expressions.Expression expression, System.Type type) { }
        private System.Linq.Expressions.UnaryExpression MakeUnary(System.Linq.Expressions.ExpressionType unaryType, System.Linq.Expressions.Expression operand, System.Type type, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression GetUserDefinedUnaryOperatorOrThrow(System.Linq.Expressions.ExpressionType unaryType, System.String name, System.Linq.Expressions.Expression operand) { }
        private System.Linq.Expressions.UnaryExpression GetUserDefinedUnaryOperator(System.Linq.Expressions.ExpressionType unaryType, System.String name, System.Linq.Expressions.Expression operand) { }
        private System.Linq.Expressions.UnaryExpression GetMethodBasedUnaryOperator(System.Linq.Expressions.ExpressionType unaryType, System.Linq.Expressions.Expression operand, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression GetUserDefinedCoercionOrThrow(System.Linq.Expressions.ExpressionType coercionType, System.Linq.Expressions.Expression expression, System.Type convertToType) { }
        private System.Linq.Expressions.UnaryExpression GetUserDefinedCoercion(System.Linq.Expressions.ExpressionType coercionType, System.Linq.Expressions.Expression expression, System.Type convertToType) { }
        private System.Linq.Expressions.UnaryExpression GetMethodBasedCoercionOperator(System.Linq.Expressions.ExpressionType unaryType, System.Linq.Expressions.Expression operand, System.Type convertToType, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression Negate(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression UnaryPlus(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression NegateChecked(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression Not(System.Linq.Expressions.Expression expression) { }
        private System.Linq.Expressions.UnaryExpression Not(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression IsFalse(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression IsTrue(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression OnesComplement(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression TypeAs(System.Linq.Expressions.Expression expression, System.Type type) { }
        private System.Linq.Expressions.UnaryExpression Unbox(System.Linq.Expressions.Expression expression, System.Type type) { }
        private System.Linq.Expressions.UnaryExpression Convert(System.Linq.Expressions.Expression expression, System.Type type) { }
        private System.Linq.Expressions.UnaryExpression Convert(System.Linq.Expressions.Expression expression, System.Type type, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression ConvertChecked(System.Linq.Expressions.Expression expression, System.Type type, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression ArrayLength(System.Linq.Expressions.Expression array) { }
        private System.Linq.Expressions.UnaryExpression Quote(System.Linq.Expressions.Expression expression) { }
        private System.Linq.Expressions.UnaryExpression Throw(System.Linq.Expressions.Expression value, System.Type type) { }
        private System.Linq.Expressions.UnaryExpression Increment(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression Decrement(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression PreIncrementAssign(System.Linq.Expressions.Expression expression) { }
        private System.Linq.Expressions.UnaryExpression PreIncrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression PreDecrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression PostIncrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression PostDecrementAssign(System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.UnaryExpression MakeOpAssignUnary(System.Linq.Expressions.ExpressionType kind, System.Linq.Expressions.Expression expression, System.Reflection.MethodInfo method) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006B
    public class BlockExpression : Expression
    {
        // Methods
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> get_Expressions() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> get_Variables() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.Expression GetExpression(System.Int32 index) { }
        private System.Int32 get_ExpressionCount() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> GetOrMakeVariables() { }
        private System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args) { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> ReturnReadOnlyExpressions(System.Linq.Expressions.BlockExpression provider, System.Object& collection) { }

    }

    // TypeToken: 0x200006C
    public class Block2 : BlockExpression
    {
        // Fields
        private System.Object _arg0;        // 0x10
        private readonly System.Linq.Expressions.Expression _arg1;        // 0x18

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) { }
        private System.Linq.Expressions.Expression GetExpression(System.Int32 index) { }
        private System.Int32 get_ExpressionCount() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions() { }
        private System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args) { }

    }

    // TypeToken: 0x200006D
    public class Block3 : BlockExpression
    {
        // Fields
        private System.Object _arg0;        // 0x10
        private readonly System.Linq.Expressions.Expression _arg1;        // 0x18
        private readonly System.Linq.Expressions.Expression _arg2;        // 0x20

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) { }
        private System.Linq.Expressions.Expression GetExpression(System.Int32 index) { }
        private System.Int32 get_ExpressionCount() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions() { }
        private System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args) { }

    }

    // TypeToken: 0x200006E
    public class Block4 : BlockExpression
    {
        // Fields
        private System.Object _arg0;        // 0x10
        private readonly System.Linq.Expressions.Expression _arg1;        // 0x18
        private readonly System.Linq.Expressions.Expression _arg2;        // 0x20
        private readonly System.Linq.Expressions.Expression _arg3;        // 0x28

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) { }
        private System.Linq.Expressions.Expression GetExpression(System.Int32 index) { }
        private System.Int32 get_ExpressionCount() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions() { }
        private System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args) { }

    }

    // TypeToken: 0x200006F
    public class Block5 : BlockExpression
    {
        // Fields
        private System.Object _arg0;        // 0x10
        private readonly System.Linq.Expressions.Expression _arg1;        // 0x18
        private readonly System.Linq.Expressions.Expression _arg2;        // 0x20
        private readonly System.Linq.Expressions.Expression _arg3;        // 0x28
        private readonly System.Linq.Expressions.Expression _arg4;        // 0x30

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4) { }
        private System.Linq.Expressions.Expression GetExpression(System.Int32 index) { }
        private System.Int32 get_ExpressionCount() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions() { }
        private System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args) { }

    }

    // TypeToken: 0x2000070
    public class BlockN : BlockExpression
    {
        // Fields
        private System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> _expressions;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> expressions) { }
        private System.Linq.Expressions.Expression GetExpression(System.Int32 index) { }
        private System.Int32 get_ExpressionCount() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions() { }
        private System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args) { }

    }

    // TypeToken: 0x2000071
    public class ScopeExpression : BlockExpression
    {
        // Fields
        private System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> _variables;        // 0x10

        // Methods
        private System.Void .ctor(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> variables) { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> GetOrMakeVariables() { }
        private System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> get_VariablesList() { }
        private System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> ReuseOrValidateVariables(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables) { }

    }

    // TypeToken: 0x2000072
    public class Scope1 : ScopeExpression
    {
        // Fields
        private System.Object _body;        // 0x18

        // Methods
        private System.Void .ctor(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression body) { }
        private System.Void .ctor(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> variables, System.Object body) { }
        private System.Linq.Expressions.Expression GetExpression(System.Int32 index) { }
        private System.Int32 get_ExpressionCount() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions() { }
        private System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args) { }

    }

    // TypeToken: 0x2000073
    public class ScopeN : ScopeExpression
    {
        // Fields
        private System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> _body;        // 0x18

        // Methods
        private System.Void .ctor(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> variables, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> body) { }
        private System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> get_Body() { }
        private System.Linq.Expressions.Expression GetExpression(System.Int32 index) { }
        private System.Int32 get_ExpressionCount() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> GetOrMakeExpressions() { }
        private System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args) { }

    }

    // TypeToken: 0x2000074
    public class ScopeWithType : ScopeN
    {
        // Fields
        private readonly System.Type <Type>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> variables, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> expressions, System.Type type) { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.BlockExpression Rewrite(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> variables, System.Linq.Expressions.Expression[] args) { }

    }

    // TypeToken: 0x2000075
    public class BlockExpressionList, IList`1, ICollection`1, IEnumerable`1, IEnumerable
    {
        // Fields
        private readonly System.Linq.Expressions.BlockExpression _block;        // 0x10
        private readonly System.Linq.Expressions.Expression _arg0;        // 0x18

        // Methods
        private System.Void .ctor(System.Linq.Expressions.BlockExpression provider, System.Linq.Expressions.Expression arg0) { }
        private System.Int32 IndexOf(System.Linq.Expressions.Expression item) { }
        private System.Void Insert(System.Int32 index, System.Linq.Expressions.Expression item) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private System.Linq.Expressions.Expression get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, System.Linq.Expressions.Expression value) { }
        private System.Void Add(System.Linq.Expressions.Expression item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(System.Linq.Expressions.Expression item) { }
        private System.Void CopyTo(System.Linq.Expressions.Expression[] array, System.Int32 index) { }
        private System.Int32 get_Count() { }
        private System.Boolean get_IsReadOnly() { }
        private System.Boolean Remove(System.Linq.Expressions.Expression item) { }
        private System.Collections.Generic.IEnumerator<System.Linq.Expressions.Expression> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

    }

    // TypeToken: 0x2000077
    public class CatchBlock
    {
        // Fields
        private readonly System.Linq.Expressions.ParameterExpression <Variable>k__BackingField;        // 0x10
        private readonly System.Type <Test>k__BackingField;        // 0x18
        private readonly System.Linq.Expressions.Expression <Body>k__BackingField;        // 0x20
        private readonly System.Linq.Expressions.Expression <Filter>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(System.Type test, System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression filter) { }
        private System.Linq.Expressions.ParameterExpression get_Variable() { }
        private System.Type get_Test() { }
        private System.Linq.Expressions.Expression get_Body() { }
        private System.Linq.Expressions.Expression get_Filter() { }
        private System.String ToString() { }
        private System.Linq.Expressions.CatchBlock Update(System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Expression filter, System.Linq.Expressions.Expression body) { }

    }

    // TypeToken: 0x2000078
    public class ArrayBuilderExtensions
    {
        // Methods
        private System.Collections.ObjectModel.ReadOnlyCollection<T> ToReadOnly(System.Collections.Generic.ArrayBuilder<T> builder) { }

    }

    // TypeToken: 0x2000079
    public struct AnalyzeTypeIsResult
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Linq.Expressions.AnalyzeTypeIsResult KnownFalse;        // 0x0
        public static System.Linq.Expressions.AnalyzeTypeIsResult KnownTrue;        // 0x0
        public static System.Linq.Expressions.AnalyzeTypeIsResult KnownAssignable;        // 0x0
        public static System.Linq.Expressions.AnalyzeTypeIsResult Unknown;        // 0x0

    }

    // TypeToken: 0x200007A
    public class ConstantCheck
    {
        // Methods
        private System.Linq.Expressions.AnalyzeTypeIsResult AnalyzeTypeIs(System.Linq.Expressions.TypeBinaryExpression typeIs) { }
        private System.Linq.Expressions.AnalyzeTypeIsResult AnalyzeTypeIs(System.Linq.Expressions.Expression operand, System.Type testType) { }

    }

    // TypeToken: 0x200007B
    public class ConditionalExpression : Expression
    {
        // Fields
        private readonly System.Linq.Expressions.Expression <Test>k__BackingField;        // 0x10
        private readonly System.Linq.Expressions.Expression <IfTrue>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue) { }
        private System.Linq.Expressions.ConditionalExpression Make(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse, System.Type type) { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.Expression get_Test() { }
        private System.Linq.Expressions.Expression get_IfTrue() { }
        private System.Linq.Expressions.Expression get_IfFalse() { }
        private System.Linq.Expressions.Expression GetFalse() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Linq.Expressions.ConditionalExpression Update(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse) { }

    }

    // TypeToken: 0x200007C
    public class FullConditionalExpression : ConditionalExpression
    {
        // Fields
        private readonly System.Linq.Expressions.Expression _false;        // 0x20

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse) { }
        private System.Linq.Expressions.Expression GetFalse() { }

    }

    // TypeToken: 0x200007D
    public class FullConditionalExpressionWithType : FullConditionalExpression
    {
        // Fields
        private readonly System.Type <Type>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression test, System.Linq.Expressions.Expression ifTrue, System.Linq.Expressions.Expression ifFalse, System.Type type) { }
        private System.Type get_Type() { }

    }

    // TypeToken: 0x200007E
    public class ConstantExpression : Expression
    {
        // Fields
        private readonly System.Object <Value>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Object value) { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Object get_Value() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }

    }

    // TypeToken: 0x200007F
    public class TypedConstantExpression : ConstantExpression
    {
        // Fields
        private readonly System.Type <Type>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Object value, System.Type type) { }
        private System.Type get_Type() { }

    }

    // TypeToken: 0x2000080
    public class DebugInfoExpression : Expression
    {
        // Fields
        private readonly System.Linq.Expressions.SymbolDocumentInfo <Document>k__BackingField;        // 0x10

        // Methods
        private System.Int32 get_StartLine() { }
        private System.Int32 get_EndLine() { }
        private System.Linq.Expressions.SymbolDocumentInfo get_Document() { }
        private System.Boolean get_IsClear() { }

    }

    // TypeToken: 0x2000081
    public class DefaultExpression : Expression
    {
        // Fields
        private readonly System.Type <Type>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Type type) { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }

    }

    // TypeToken: 0x2000082
    public class ElementInit, IArgumentProvider
    {
        // Fields
        private readonly System.Reflection.MethodInfo <AddMethod>k__BackingField;        // 0x10
        private readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> <Arguments>k__BackingField;        // 0x18

        // Methods
        private System.Reflection.MethodInfo get_AddMethod() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> get_Arguments() { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }

    }

    // TypeToken: 0x2000083
    public class Error
    {
        // Methods
        private System.Exception ReducibleMustOverrideReduce() { }
        private System.Exception InvalidMetaObjectCreated(System.Object p0) { }
        private System.Exception AmbiguousMatchInExpandoObject(System.Object p0) { }
        private System.Exception SameKeyExistsInExpando(System.Object key) { }
        private System.Exception KeyDoesNotExistInExpando(System.Object p0) { }
        private System.Exception CollectionModifiedWhileEnumerating() { }
        private System.Exception CollectionReadOnly() { }
        private System.Exception MustReduceToDifferent() { }
        private System.Exception BinderNotCompatibleWithCallSite(System.Object p0, System.Object p1, System.Object p2) { }
        private System.Exception DynamicBindingNeedsRestrictions(System.Object p0, System.Object p1) { }
        private System.Exception DynamicObjectResultNotAssignable(System.Object p0, System.Object p1, System.Object p2, System.Object p3) { }
        private System.Exception DynamicBinderResultNotAssignable(System.Object p0, System.Object p1, System.Object p2) { }
        private System.Exception BindingCannotBeNull() { }
        private System.Exception ReducedNotCompatible() { }
        private System.Exception SetterHasNoParams(System.String paramName) { }
        private System.Exception PropertyCannotHaveRefType(System.String paramName) { }
        private System.Exception IndexesOfSetGetMustMatch(System.String paramName) { }
        private System.Exception TypeParameterIsNotDelegate(System.Object p0) { }
        private System.Exception FirstArgumentMustBeCallSite() { }
        private System.Exception AccessorsCannotHaveVarArgs(System.String paramName) { }
        private System.Exception AccessorsCannotHaveByRefArgs(System.String paramName) { }
        private System.Exception AccessorsCannotHaveByRefArgs(System.String paramName, System.Int32 index) { }
        private System.Exception TypeMustBeDerivedFromSystemDelegate() { }
        private System.Exception NoOrInvalidRuleProduced() { }
        private System.Exception BoundsCannotBeLessThanOne(System.String paramName) { }
        private System.Exception TypeMustNotBeByRef(System.String paramName) { }
        private System.Exception TypeMustNotBePointer(System.String paramName) { }
        private System.Exception SetterMustBeVoid(System.String paramName) { }
        private System.Exception PropertyTypeMustMatchGetter(System.String paramName) { }
        private System.Exception PropertyTypeMustMatchSetter(System.String paramName) { }
        private System.Exception BothAccessorsMustBeStatic(System.String paramName) { }
        private System.Exception OnlyStaticFieldsHaveNullInstance(System.String paramName) { }
        private System.Exception OnlyStaticPropertiesHaveNullInstance(System.String paramName) { }
        private System.Exception OnlyStaticMethodsHaveNullInstance() { }
        private System.Exception PropertyTypeCannotBeVoid(System.String paramName) { }
        private System.Exception InvalidUnboxType(System.String paramName) { }
        private System.Exception ExpressionMustBeWriteable(System.String paramName) { }
        private System.Exception ArgumentMustNotHaveValueType(System.String paramName) { }
        private System.Exception MustBeReducible() { }
        private System.Exception LabelMustBeVoidOrHaveExpression(System.String paramName) { }
        private System.Exception LabelTypeMustBeVoid(System.String paramName) { }
        private System.Exception QuotedExpressionMustBeLambda(System.String paramName) { }
        private System.Exception VariableMustNotBeByRef(System.Object p0, System.Object p1, System.String paramName) { }
        private System.Exception VariableMustNotBeByRef(System.Object p0, System.Object p1, System.String paramName, System.Int32 index) { }
        private System.Exception DuplicateVariable(System.Object p0, System.String paramName) { }
        private System.Exception DuplicateVariable(System.Object p0, System.String paramName, System.Int32 index) { }
        private System.Exception FaultCannotHaveCatchOrFinally(System.String paramName) { }
        private System.Exception TryMustHaveCatchFinallyOrFault() { }
        private System.Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }
        private System.Exception ExtensionNodeMustOverrideProperty(System.Object p0) { }
        private System.Exception UserDefinedOperatorMustBeStatic(System.Object p0, System.String paramName) { }
        private System.Exception UserDefinedOperatorMustNotBeVoid(System.Object p0, System.String paramName) { }
        private System.Exception CoercionOperatorNotDefined(System.Object p0, System.Object p1) { }
        private System.Exception UnaryOperatorNotDefined(System.Object p0, System.Object p1) { }
        private System.Exception BinaryOperatorNotDefined(System.Object p0, System.Object p1, System.Object p2) { }
        private System.Exception ReferenceEqualityNotDefined(System.Object p0, System.Object p1) { }
        private System.Exception OperandTypesDoNotMatchParameters(System.Object p0, System.Object p1) { }
        private System.Exception OverloadOperatorTypeDoesNotMatchConversionType(System.Object p0, System.Object p1) { }
        private System.Exception ConversionIsNotSupportedForArithmeticTypes() { }
        private System.Exception ArgumentMustBeArray(System.String paramName) { }
        private System.Exception ArgumentMustBeBoolean(System.String paramName) { }
        private System.Exception ArgumentMustBeInteger(System.String paramName) { }
        private System.Exception ArgumentMustBeInteger(System.String paramName, System.Int32 index) { }
        private System.Exception ArgumentMustBeArrayIndexType(System.String paramName) { }
        private System.Exception ArgumentMustBeSingleDimensionalArrayType(System.String paramName) { }
        private System.Exception ArgumentTypesMustMatch() { }
        private System.Exception CannotAutoInitializeValueTypeMemberThroughProperty(System.Object p0) { }
        private System.Exception IncorrectTypeForTypeAs(System.Object p0, System.String paramName) { }
        private System.Exception CoalesceUsedOnNonNullType() { }
        private System.Exception ExpressionTypeCannotInitializeArrayType(System.Object p0, System.Object p1) { }
        private System.Exception ExpressionTypeDoesNotMatchReturn(System.Object p0, System.Object p1) { }
        private System.Exception ExpressionTypeDoesNotMatchAssignment(System.Object p0, System.Object p1) { }
        private System.Exception ExpressionTypeDoesNotMatchLabel(System.Object p0, System.Object p1) { }
        private System.Exception ExpressionTypeNotInvocable(System.Object p0, System.String paramName) { }
        private System.Exception InstanceFieldNotDefinedForType(System.Object p0, System.Object p1) { }
        private System.Exception FieldInfoNotDefinedForType(System.Object p0, System.Object p1, System.Object p2) { }
        private System.Exception IncorrectNumberOfIndexes() { }
        private System.Exception IncorrectNumberOfLambdaDeclarationParameters() { }
        private System.Exception LambdaTypeMustBeDerivedFromSystemDelegate(System.String paramName) { }
        private System.Exception MemberNotFieldOrProperty(System.Object p0, System.String paramName) { }
        private System.Exception MethodContainsGenericParameters(System.Object p0, System.String paramName) { }
        private System.Exception MethodIsGeneric(System.Object p0, System.String paramName) { }
        private System.Exception MethodNotPropertyAccessor(System.Object p0, System.Object p1, System.String paramName) { }
        private System.Exception MethodNotPropertyAccessor(System.Object p0, System.Object p1, System.String paramName, System.Int32 index) { }
        private System.Exception PropertyDoesNotHaveAccessor(System.Object p0, System.String paramName) { }
        private System.Exception ParameterExpressionNotValidAsDelegate(System.Object p0, System.Object p1) { }
        private System.Exception PropertyNotDefinedForType(System.Object p0, System.Object p1, System.String paramName) { }
        private System.Exception InstancePropertyNotDefinedForType(System.Object p0, System.Object p1, System.String paramName) { }
        private System.Exception InstanceAndMethodTypeMismatch(System.Object p0, System.Object p1, System.Object p2) { }
        private System.Exception UnhandledBinary(System.Object p0, System.String paramName) { }
        private System.Exception UnhandledUnary(System.Object p0, System.String paramName) { }
        private System.Exception UserDefinedOpMustHaveConsistentTypes(System.Object p0, System.Object p1) { }
        private System.Exception UserDefinedOpMustHaveValidReturnType(System.Object p0, System.Object p1) { }
        private System.Exception LogicalOperatorMustHaveBooleanOperators(System.Object p0, System.Object p1) { }
        private System.Exception MethodWithArgsDoesNotExistOnType(System.Object p0, System.Object p1) { }
        private System.Exception GenericMethodWithArgsDoesNotExistOnType(System.Object p0, System.Object p1) { }
        private System.Exception MethodWithMoreThanOneMatch(System.Object p0, System.Object p1) { }
        private System.Exception ArgumentCannotBeOfTypeVoid(System.String paramName) { }
        private System.Exception OutOfRange(System.String paramName, System.Object p1) { }
        private System.Exception LabelTargetAlreadyDefined(System.Object p0) { }
        private System.Exception LabelTargetUndefined(System.Object p0) { }
        private System.Exception ControlCannotLeaveFinally() { }
        private System.Exception ControlCannotLeaveFilterTest() { }
        private System.Exception AmbiguousJump(System.Object p0) { }
        private System.Exception ControlCannotEnterTry() { }
        private System.Exception ControlCannotEnterExpression() { }
        private System.Exception NonLocalJumpWithValue(System.Object p0) { }
        private System.Exception InvalidLvalue(System.Linq.Expressions.ExpressionType p0) { }
        private System.Exception RethrowRequiresCatch() { }
        private System.Exception MustRewriteToSameNode(System.Object p0, System.Object p1, System.Object p2) { }
        private System.Exception MustRewriteChildToSameType(System.Object p0, System.Object p1, System.Object p2) { }
        private System.Exception MustRewriteWithoutMethod(System.Object p0, System.Object p1) { }
        private System.Exception ArgumentOutOfRange(System.String paramName) { }
        private System.Exception NotSupported() { }
        private System.Exception NonAbstractConstructorRequired() { }
        private System.Exception InvalidProgram() { }
        private System.Exception EnumerationIsDone() { }
        private System.Exception TypeContainsGenericParameters(System.Object p0, System.String paramName) { }
        private System.Exception TypeContainsGenericParameters(System.Object p0, System.String paramName, System.Int32 index) { }
        private System.Exception TypeIsGeneric(System.Object p0, System.String paramName) { }
        private System.Exception TypeIsGeneric(System.Object p0, System.String paramName, System.Int32 index) { }
        private System.Exception IncorrectNumberOfConstructorArguments() { }
        private System.Exception ExpressionTypeDoesNotMatchMethodParameter(System.Object p0, System.Object p1, System.Object p2, System.String paramName) { }
        private System.Exception ExpressionTypeDoesNotMatchMethodParameter(System.Object p0, System.Object p1, System.Object p2, System.String paramName, System.Int32 index) { }
        private System.Exception ExpressionTypeDoesNotMatchParameter(System.Object p0, System.Object p1, System.String paramName) { }
        private System.Exception ExpressionTypeDoesNotMatchParameter(System.Object p0, System.Object p1, System.String paramName, System.Int32 index) { }
        private System.Exception IncorrectNumberOfLambdaArguments() { }
        private System.Exception IncorrectNumberOfMethodCallArguments(System.Object p0, System.String paramName) { }
        private System.Exception ExpressionTypeDoesNotMatchConstructorParameter(System.Object p0, System.Object p1, System.String paramName) { }
        private System.Exception ExpressionTypeDoesNotMatchConstructorParameter(System.Object p0, System.Object p1, System.String paramName, System.Int32 index) { }
        private System.Exception ExpressionMustBeReadable(System.String paramName) { }
        private System.Exception ExpressionMustBeReadable(System.String paramName, System.Int32 index) { }
        private System.Exception InvalidArgumentValue(System.String paramName) { }
        private System.Exception InvalidNullValue(System.Type type, System.String paramName) { }
        private System.Exception InvalidTypeException(System.Object value, System.Type type, System.String paramName) { }
        private System.String GetParamName(System.String paramName, System.Int32 index) { }

    }

    // TypeToken: 0x2000084
    public class ExpressionStringBuilder : ExpressionVisitor
    {
        // Fields
        private readonly System.Text.StringBuilder _out;        // 0x10
        private System.Collections.Generic.Dictionary<System.Object,System.Int32> _ids;        // 0x18

        // Methods
        private System.Void .ctor() { }
        private System.String ToString() { }
        private System.Int32 GetLabelId(System.Linq.Expressions.LabelTarget label) { }
        private System.Int32 GetParamId(System.Linq.Expressions.ParameterExpression p) { }
        private System.Int32 GetId(System.Object o) { }
        private System.Void Out(System.String s) { }
        private System.Void Out(System.Char c) { }
        private System.String ExpressionToString(System.Linq.Expressions.Expression node) { }
        private System.String CatchBlockToString(System.Linq.Expressions.CatchBlock node) { }
        private System.Void VisitExpressions(System.Char open, System.Collections.ObjectModel.ReadOnlyCollection<T> expressions, System.Char close) { }
        private System.Void VisitExpressions(System.Char open, System.Collections.ObjectModel.ReadOnlyCollection<T> expressions, System.Char close, System.String seperator) { }
        private System.Linq.Expressions.Expression VisitBinary(System.Linq.Expressions.BinaryExpression node) { }
        private System.Linq.Expressions.Expression VisitParameter(System.Linq.Expressions.ParameterExpression node) { }
        private System.Linq.Expressions.Expression VisitLambda(System.Linq.Expressions.Expression<T> node) { }
        private System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node) { }
        private System.Linq.Expressions.Expression VisitConstant(System.Linq.Expressions.ConstantExpression node) { }
        private System.Void OutMember(System.Linq.Expressions.Expression instance, System.Reflection.MemberInfo member) { }
        private System.Linq.Expressions.Expression VisitMember(System.Linq.Expressions.MemberExpression node) { }
        private System.Linq.Expressions.Expression VisitInvocation(System.Linq.Expressions.InvocationExpression node) { }
        private System.Linq.Expressions.Expression VisitMethodCall(System.Linq.Expressions.MethodCallExpression node) { }
        private System.Linq.Expressions.Expression VisitNewArray(System.Linq.Expressions.NewArrayExpression node) { }
        private System.Linq.Expressions.Expression VisitTypeBinary(System.Linq.Expressions.TypeBinaryExpression node) { }
        private System.Linq.Expressions.Expression VisitUnary(System.Linq.Expressions.UnaryExpression node) { }
        private System.Linq.Expressions.Expression VisitBlock(System.Linq.Expressions.BlockExpression node) { }
        private System.Linq.Expressions.Expression VisitDefault(System.Linq.Expressions.DefaultExpression node) { }
        private System.Linq.Expressions.Expression VisitLabel(System.Linq.Expressions.LabelExpression node) { }
        private System.Linq.Expressions.Expression VisitGoto(System.Linq.Expressions.GotoExpression node) { }
        private System.Linq.Expressions.Expression VisitLoop(System.Linq.Expressions.LoopExpression node) { }
        private System.Linq.Expressions.CatchBlock VisitCatchBlock(System.Linq.Expressions.CatchBlock node) { }
        private System.Linq.Expressions.Expression VisitTry(System.Linq.Expressions.TryExpression node) { }
        private System.Linq.Expressions.Expression VisitIndex(System.Linq.Expressions.IndexExpression node) { }
        private System.Linq.Expressions.Expression VisitExtension(System.Linq.Expressions.Expression node) { }
        private System.Void DumpLabel(System.Linq.Expressions.LabelTarget target) { }
        private System.Boolean IsBool(System.Linq.Expressions.Expression node) { }

    }

    // TypeToken: 0x2000085
    public struct ExpressionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Linq.Expressions.ExpressionType Add;        // 0x0
        public static System.Linq.Expressions.ExpressionType AddChecked;        // 0x0
        public static System.Linq.Expressions.ExpressionType And;        // 0x0
        public static System.Linq.Expressions.ExpressionType AndAlso;        // 0x0
        public static System.Linq.Expressions.ExpressionType ArrayLength;        // 0x0
        public static System.Linq.Expressions.ExpressionType ArrayIndex;        // 0x0
        public static System.Linq.Expressions.ExpressionType Call;        // 0x0
        public static System.Linq.Expressions.ExpressionType Coalesce;        // 0x0
        public static System.Linq.Expressions.ExpressionType Conditional;        // 0x0
        public static System.Linq.Expressions.ExpressionType Constant;        // 0x0
        public static System.Linq.Expressions.ExpressionType Convert;        // 0x0
        public static System.Linq.Expressions.ExpressionType ConvertChecked;        // 0x0
        public static System.Linq.Expressions.ExpressionType Divide;        // 0x0
        public static System.Linq.Expressions.ExpressionType Equal;        // 0x0
        public static System.Linq.Expressions.ExpressionType ExclusiveOr;        // 0x0
        public static System.Linq.Expressions.ExpressionType GreaterThan;        // 0x0
        public static System.Linq.Expressions.ExpressionType GreaterThanOrEqual;        // 0x0
        public static System.Linq.Expressions.ExpressionType Invoke;        // 0x0
        public static System.Linq.Expressions.ExpressionType Lambda;        // 0x0
        public static System.Linq.Expressions.ExpressionType LeftShift;        // 0x0
        public static System.Linq.Expressions.ExpressionType LessThan;        // 0x0
        public static System.Linq.Expressions.ExpressionType LessThanOrEqual;        // 0x0
        public static System.Linq.Expressions.ExpressionType ListInit;        // 0x0
        public static System.Linq.Expressions.ExpressionType MemberAccess;        // 0x0
        public static System.Linq.Expressions.ExpressionType MemberInit;        // 0x0
        public static System.Linq.Expressions.ExpressionType Modulo;        // 0x0
        public static System.Linq.Expressions.ExpressionType Multiply;        // 0x0
        public static System.Linq.Expressions.ExpressionType MultiplyChecked;        // 0x0
        public static System.Linq.Expressions.ExpressionType Negate;        // 0x0
        public static System.Linq.Expressions.ExpressionType UnaryPlus;        // 0x0
        public static System.Linq.Expressions.ExpressionType NegateChecked;        // 0x0
        public static System.Linq.Expressions.ExpressionType New;        // 0x0
        public static System.Linq.Expressions.ExpressionType NewArrayInit;        // 0x0
        public static System.Linq.Expressions.ExpressionType NewArrayBounds;        // 0x0
        public static System.Linq.Expressions.ExpressionType Not;        // 0x0
        public static System.Linq.Expressions.ExpressionType NotEqual;        // 0x0
        public static System.Linq.Expressions.ExpressionType Or;        // 0x0
        public static System.Linq.Expressions.ExpressionType OrElse;        // 0x0
        public static System.Linq.Expressions.ExpressionType Parameter;        // 0x0
        public static System.Linq.Expressions.ExpressionType Power;        // 0x0
        public static System.Linq.Expressions.ExpressionType Quote;        // 0x0
        public static System.Linq.Expressions.ExpressionType RightShift;        // 0x0
        public static System.Linq.Expressions.ExpressionType Subtract;        // 0x0
        public static System.Linq.Expressions.ExpressionType SubtractChecked;        // 0x0
        public static System.Linq.Expressions.ExpressionType TypeAs;        // 0x0
        public static System.Linq.Expressions.ExpressionType TypeIs;        // 0x0
        public static System.Linq.Expressions.ExpressionType Assign;        // 0x0
        public static System.Linq.Expressions.ExpressionType Block;        // 0x0
        public static System.Linq.Expressions.ExpressionType DebugInfo;        // 0x0
        public static System.Linq.Expressions.ExpressionType Decrement;        // 0x0
        public static System.Linq.Expressions.ExpressionType Dynamic;        // 0x0
        public static System.Linq.Expressions.ExpressionType Default;        // 0x0
        public static System.Linq.Expressions.ExpressionType Extension;        // 0x0
        public static System.Linq.Expressions.ExpressionType Goto;        // 0x0
        public static System.Linq.Expressions.ExpressionType Increment;        // 0x0
        public static System.Linq.Expressions.ExpressionType Index;        // 0x0
        public static System.Linq.Expressions.ExpressionType Label;        // 0x0
        public static System.Linq.Expressions.ExpressionType RuntimeVariables;        // 0x0
        public static System.Linq.Expressions.ExpressionType Loop;        // 0x0
        public static System.Linq.Expressions.ExpressionType Switch;        // 0x0
        public static System.Linq.Expressions.ExpressionType Throw;        // 0x0
        public static System.Linq.Expressions.ExpressionType Try;        // 0x0
        public static System.Linq.Expressions.ExpressionType Unbox;        // 0x0
        public static System.Linq.Expressions.ExpressionType AddAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType AndAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType DivideAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType ExclusiveOrAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType LeftShiftAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType ModuloAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType MultiplyAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType OrAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType PowerAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType RightShiftAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType SubtractAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType AddAssignChecked;        // 0x0
        public static System.Linq.Expressions.ExpressionType MultiplyAssignChecked;        // 0x0
        public static System.Linq.Expressions.ExpressionType SubtractAssignChecked;        // 0x0
        public static System.Linq.Expressions.ExpressionType PreIncrementAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType PreDecrementAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType PostIncrementAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType PostDecrementAssign;        // 0x0
        public static System.Linq.Expressions.ExpressionType TypeEqual;        // 0x0
        public static System.Linq.Expressions.ExpressionType OnesComplement;        // 0x0
        public static System.Linq.Expressions.ExpressionType IsTrue;        // 0x0
        public static System.Linq.Expressions.ExpressionType IsFalse;        // 0x0

    }

    // TypeToken: 0x2000086
    public class ExpressionVisitor
    {
        // Methods
        private System.Void .ctor() { }
        private System.Linq.Expressions.Expression Visit(System.Linq.Expressions.Expression node) { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> Visit(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> nodes) { }
        private System.Linq.Expressions.Expression[] VisitArguments(System.Linq.Expressions.IArgumentProvider nodes) { }
        private System.Linq.Expressions.ParameterExpression[] VisitParameters(System.Linq.Expressions.IParameterProvider nodes, System.String callerName) { }
        private System.Collections.ObjectModel.ReadOnlyCollection<T> Visit(System.Collections.ObjectModel.ReadOnlyCollection<T> nodes, System.Func<T,T> elementVisitor) { }
        private T VisitAndConvert(T node, System.String callerName) { }
        private System.Collections.ObjectModel.ReadOnlyCollection<T> VisitAndConvert(System.Collections.ObjectModel.ReadOnlyCollection<T> nodes, System.String callerName) { }
        private System.Linq.Expressions.Expression VisitBinary(System.Linq.Expressions.BinaryExpression node) { }
        private System.Linq.Expressions.Expression VisitBlock(System.Linq.Expressions.BlockExpression node) { }
        private System.Linq.Expressions.Expression VisitConditional(System.Linq.Expressions.ConditionalExpression node) { }
        private System.Linq.Expressions.Expression VisitConstant(System.Linq.Expressions.ConstantExpression node) { }
        private System.Linq.Expressions.Expression VisitDefault(System.Linq.Expressions.DefaultExpression node) { }
        private System.Linq.Expressions.Expression VisitExtension(System.Linq.Expressions.Expression node) { }
        private System.Linq.Expressions.Expression VisitGoto(System.Linq.Expressions.GotoExpression node) { }
        private System.Linq.Expressions.Expression VisitInvocation(System.Linq.Expressions.InvocationExpression node) { }
        private System.Linq.Expressions.LabelTarget VisitLabelTarget(System.Linq.Expressions.LabelTarget node) { }
        private System.Linq.Expressions.Expression VisitLabel(System.Linq.Expressions.LabelExpression node) { }
        private System.Linq.Expressions.Expression VisitLambda(System.Linq.Expressions.Expression<T> node) { }
        private System.Linq.Expressions.Expression VisitLoop(System.Linq.Expressions.LoopExpression node) { }
        private System.Linq.Expressions.Expression VisitMember(System.Linq.Expressions.MemberExpression node) { }
        private System.Linq.Expressions.Expression VisitIndex(System.Linq.Expressions.IndexExpression node) { }
        private System.Linq.Expressions.Expression VisitMethodCall(System.Linq.Expressions.MethodCallExpression node) { }
        private System.Linq.Expressions.Expression VisitNewArray(System.Linq.Expressions.NewArrayExpression node) { }
        private System.Linq.Expressions.Expression VisitParameter(System.Linq.Expressions.ParameterExpression node) { }
        private System.Linq.Expressions.CatchBlock VisitCatchBlock(System.Linq.Expressions.CatchBlock node) { }
        private System.Linq.Expressions.Expression VisitTry(System.Linq.Expressions.TryExpression node) { }
        private System.Linq.Expressions.Expression VisitTypeBinary(System.Linq.Expressions.TypeBinaryExpression node) { }
        private System.Linq.Expressions.Expression VisitUnary(System.Linq.Expressions.UnaryExpression node) { }
        private System.Linq.Expressions.UnaryExpression ValidateUnary(System.Linq.Expressions.UnaryExpression before, System.Linq.Expressions.UnaryExpression after) { }
        private System.Linq.Expressions.BinaryExpression ValidateBinary(System.Linq.Expressions.BinaryExpression before, System.Linq.Expressions.BinaryExpression after) { }
        private System.Void ValidateChildType(System.Type before, System.Type after, System.String methodName) { }

    }

    // TypeToken: 0x2000087
    public struct GotoExpressionKind
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Linq.Expressions.GotoExpressionKind Goto;        // 0x0
        public static System.Linq.Expressions.GotoExpressionKind Return;        // 0x0
        public static System.Linq.Expressions.GotoExpressionKind Break;        // 0x0
        public static System.Linq.Expressions.GotoExpressionKind Continue;        // 0x0

    }

    // TypeToken: 0x2000088
    public class GotoExpression : Expression
    {
        // Fields
        private readonly System.Type <Type>k__BackingField;        // 0x10
        private readonly System.Linq.Expressions.Expression <Value>k__BackingField;        // 0x18
        private readonly System.Linq.Expressions.LabelTarget <Target>k__BackingField;        // 0x20
        private readonly System.Linq.Expressions.GotoExpressionKind <Kind>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(System.Linq.Expressions.GotoExpressionKind kind, System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value, System.Type type) { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Linq.Expressions.Expression get_Value() { }
        private System.Linq.Expressions.LabelTarget get_Target() { }
        private System.Linq.Expressions.GotoExpressionKind get_Kind() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Linq.Expressions.GotoExpression Update(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression value) { }

    }

    // TypeToken: 0x2000089
    public interface IArgumentProvider
    {
        // Methods
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }

    }

    // TypeToken: 0x200008A
    public interface IParameterProvider
    {
        // Methods
        private System.Linq.Expressions.ParameterExpression GetParameter(System.Int32 index) { }
        private System.Int32 get_ParameterCount() { }

    }

    // TypeToken: 0x200008B
    public class IndexExpression : Expression, IArgumentProvider
    {
        // Fields
        private System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> _arguments;        // 0x10
        private readonly System.Linq.Expressions.Expression <Object>k__BackingField;        // 0x18
        private readonly System.Reflection.PropertyInfo <Indexer>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression instance, System.Reflection.PropertyInfo indexer, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> arguments) { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.Expression get_Object() { }
        private System.Reflection.PropertyInfo get_Indexer() { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Linq.Expressions.Expression Rewrite(System.Linq.Expressions.Expression instance, System.Linq.Expressions.Expression[] arguments) { }

    }

    // TypeToken: 0x200008C
    public class InvocationExpression : Expression, IArgumentProvider
    {
        // Fields
        private readonly System.Type <Type>k__BackingField;        // 0x10
        private readonly System.Linq.Expressions.Expression <Expression>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression expression, System.Type returnType) { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Linq.Expressions.Expression get_Expression() { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments) { }

    }

    // TypeToken: 0x200008D
    public class InvocationExpressionN : InvocationExpression
    {
        // Fields
        private System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> _arguments;        // 0x20

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression lambda, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> arguments, System.Type returnType) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments) { }

    }

    // TypeToken: 0x200008E
    public class InvocationExpression0 : InvocationExpression
    {
        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression lambda, System.Type returnType) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments) { }

    }

    // TypeToken: 0x200008F
    public class InvocationExpression1 : InvocationExpression
    {
        // Fields
        private System.Object _arg0;        // 0x20

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression lambda, System.Type returnType, System.Linq.Expressions.Expression arg0) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments) { }

    }

    // TypeToken: 0x2000090
    public class InvocationExpression2 : InvocationExpression
    {
        // Fields
        private System.Object _arg0;        // 0x20
        private readonly System.Linq.Expressions.Expression _arg1;        // 0x28

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression lambda, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments) { }

    }

    // TypeToken: 0x2000091
    public class InvocationExpression3 : InvocationExpression
    {
        // Fields
        private System.Object _arg0;        // 0x20
        private readonly System.Linq.Expressions.Expression _arg1;        // 0x28
        private readonly System.Linq.Expressions.Expression _arg2;        // 0x30

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression lambda, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments) { }

    }

    // TypeToken: 0x2000092
    public class InvocationExpression4 : InvocationExpression
    {
        // Fields
        private System.Object _arg0;        // 0x20
        private readonly System.Linq.Expressions.Expression _arg1;        // 0x28
        private readonly System.Linq.Expressions.Expression _arg2;        // 0x30
        private readonly System.Linq.Expressions.Expression _arg3;        // 0x38

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression lambda, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments) { }

    }

    // TypeToken: 0x2000093
    public class InvocationExpression5 : InvocationExpression
    {
        // Fields
        private System.Object _arg0;        // 0x20
        private readonly System.Linq.Expressions.Expression _arg1;        // 0x28
        private readonly System.Linq.Expressions.Expression _arg2;        // 0x30
        private readonly System.Linq.Expressions.Expression _arg3;        // 0x38
        private readonly System.Linq.Expressions.Expression _arg4;        // 0x40

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression lambda, System.Type returnType, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.InvocationExpression Rewrite(System.Linq.Expressions.Expression lambda, System.Linq.Expressions.Expression[] arguments) { }

    }

    // TypeToken: 0x2000094
    public class LabelExpression : Expression
    {
        // Fields
        private readonly System.Linq.Expressions.LabelTarget <Target>k__BackingField;        // 0x10
        private readonly System.Linq.Expressions.Expression <DefaultValue>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Linq.Expressions.LabelTarget label, System.Linq.Expressions.Expression defaultValue) { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Linq.Expressions.LabelTarget get_Target() { }
        private System.Linq.Expressions.Expression get_DefaultValue() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Linq.Expressions.LabelExpression Update(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Expression defaultValue) { }

    }

    // TypeToken: 0x2000095
    public class LabelTarget
    {
        // Fields
        private readonly System.String <Name>k__BackingField;        // 0x10
        private readonly System.Type <Type>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Type type, System.String name) { }
        private System.String get_Name() { }
        private System.Type get_Type() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000096
    public class LambdaExpression : Expression, IParameterProvider
    {
        // Fields
        private readonly System.Linq.Expressions.Expression _body;        // 0x10

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression body) { }
        private System.Type get_Type() { }
        private System.Type get_TypeCore() { }
        private System.Type get_PublicType() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.String get_Name() { }
        private System.String get_NameCore() { }
        private System.Linq.Expressions.Expression get_Body() { }
        private System.Type get_ReturnType() { }
        private System.Boolean get_TailCall() { }
        private System.Boolean get_TailCallCore() { }
        private System.Linq.Expressions.ParameterExpression System.Linq.Expressions.IParameterProvider.GetParameter(System.Int32 index) { }
        private System.Linq.Expressions.ParameterExpression GetParameter(System.Int32 index) { }
        private System.Int32 System.Linq.Expressions.IParameterProvider.get_ParameterCount() { }
        private System.Int32 get_ParameterCount() { }

    }

    // TypeToken: 0x2000097
    public class Expression`1 : LambdaExpression
    {
        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression body) { }
        private System.Type get_TypeCore() { }
        private System.Type get_PublicType() { }
        private TDelegate Compile() { }
        private TDelegate Compile(System.Boolean preferInterpretation) { }
        private System.Linq.Expressions.Expression<TDelegate> Rewrite(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters) { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }

    }

    // TypeToken: 0x2000098
    public class ExpressionCreator`1
    {
        // Methods
        private System.Linq.Expressions.LambdaExpression CreateExpressionFunc(System.Linq.Expressions.Expression body, System.String name, System.Boolean tailCall, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters) { }

    }

    // TypeToken: 0x2000099
    public class Expression0`1 : Expression`1
    {
        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression body) { }
        private System.Int32 get_ParameterCount() { }
        private System.Linq.Expressions.ParameterExpression GetParameter(System.Int32 index) { }
        private System.Linq.Expressions.Expression<TDelegate> Rewrite(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters) { }

    }

    // TypeToken: 0x200009A
    public class Expression1`1 : Expression`1
    {
        // Fields
        private System.Object _par0;        // 0x0

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression par0) { }
        private System.Int32 get_ParameterCount() { }
        private System.Linq.Expressions.ParameterExpression GetParameter(System.Int32 index) { }
        private System.Linq.Expressions.Expression<TDelegate> Rewrite(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters) { }

    }

    // TypeToken: 0x200009B
    public class Expression2`1 : Expression`1
    {
        // Fields
        private System.Object _par0;        // 0x0
        private readonly System.Linq.Expressions.ParameterExpression _par1;        // 0x0

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression par0, System.Linq.Expressions.ParameterExpression par1) { }
        private System.Int32 get_ParameterCount() { }
        private System.Linq.Expressions.ParameterExpression GetParameter(System.Int32 index) { }
        private System.Linq.Expressions.Expression<TDelegate> Rewrite(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters) { }

    }

    // TypeToken: 0x200009C
    public class Expression3`1 : Expression`1
    {
        // Fields
        private System.Object _par0;        // 0x0
        private readonly System.Linq.Expressions.ParameterExpression _par1;        // 0x0
        private readonly System.Linq.Expressions.ParameterExpression _par2;        // 0x0

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression par0, System.Linq.Expressions.ParameterExpression par1, System.Linq.Expressions.ParameterExpression par2) { }
        private System.Int32 get_ParameterCount() { }
        private System.Linq.Expressions.ParameterExpression GetParameter(System.Int32 index) { }
        private System.Linq.Expressions.Expression<TDelegate> Rewrite(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters) { }

    }

    // TypeToken: 0x200009D
    public class ExpressionN`1 : Expression`1
    {
        // Fields
        private System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> _parameters;        // 0x0

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression body, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> parameters) { }
        private System.Int32 get_ParameterCount() { }
        private System.Linq.Expressions.ParameterExpression GetParameter(System.Int32 index) { }
        private System.Linq.Expressions.Expression<TDelegate> Rewrite(System.Linq.Expressions.Expression body, System.Linq.Expressions.ParameterExpression[] parameters) { }

    }

    // TypeToken: 0x200009E
    public class FullExpression`1 : ExpressionN`1
    {
        // Fields
        private readonly System.String <NameCore>k__BackingField;        // 0x0
        private readonly System.Boolean <TailCallCore>k__BackingField;        // 0x0

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression body, System.String name, System.Boolean tailCall, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.ParameterExpression> parameters) { }
        private System.String get_NameCore() { }
        private System.Boolean get_TailCallCore() { }

    }

    // TypeToken: 0x200009F
    public class ListInitExpression : Expression
    {
        // Fields
        private readonly System.Linq.Expressions.NewExpression <NewExpression>k__BackingField;        // 0x10
        private readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> <Initializers>k__BackingField;        // 0x18

        // Methods
        private System.Linq.Expressions.NewExpression get_NewExpression() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> get_Initializers() { }

    }

    // TypeToken: 0x20000A0
    public class LoopExpression : Expression
    {
        // Fields
        private readonly System.Linq.Expressions.Expression <Body>k__BackingField;        // 0x10
        private readonly System.Linq.Expressions.LabelTarget <BreakLabel>k__BackingField;        // 0x18
        private readonly System.Linq.Expressions.LabelTarget <ContinueLabel>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression body, System.Linq.Expressions.LabelTarget break, System.Linq.Expressions.LabelTarget continue) { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Linq.Expressions.Expression get_Body() { }
        private System.Linq.Expressions.LabelTarget get_BreakLabel() { }
        private System.Linq.Expressions.LabelTarget get_ContinueLabel() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Linq.Expressions.LoopExpression Update(System.Linq.Expressions.LabelTarget breakLabel, System.Linq.Expressions.LabelTarget continueLabel, System.Linq.Expressions.Expression body) { }

    }

    // TypeToken: 0x20000A1
    public class MemberAssignment : MemberBinding
    {
        // Fields
        private readonly System.Linq.Expressions.Expression _expression;        // 0x20

        // Methods
        private System.Linq.Expressions.Expression get_Expression() { }

    }

    // TypeToken: 0x20000A2
    public struct MemberBindingType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Linq.Expressions.MemberBindingType Assignment;        // 0x0
        public static System.Linq.Expressions.MemberBindingType MemberBinding;        // 0x0
        public static System.Linq.Expressions.MemberBindingType ListBinding;        // 0x0

    }

    // TypeToken: 0x20000A3
    public class MemberBinding
    {
        // Fields
        private readonly System.Linq.Expressions.MemberBindingType <BindingType>k__BackingField;        // 0x10
        private readonly System.Reflection.MemberInfo <Member>k__BackingField;        // 0x18

        // Methods
        private System.Linq.Expressions.MemberBindingType get_BindingType() { }
        private System.Reflection.MemberInfo get_Member() { }

    }

    // TypeToken: 0x20000A4
    public class MemberExpression : Expression
    {
        // Fields
        private readonly System.Linq.Expressions.Expression <Expression>k__BackingField;        // 0x10

        // Methods
        private System.Reflection.MemberInfo get_Member() { }
        private System.Linq.Expressions.Expression get_Expression() { }
        private System.Void .ctor(System.Linq.Expressions.Expression expression) { }
        private System.Linq.Expressions.PropertyExpression Make(System.Linq.Expressions.Expression expression, System.Reflection.PropertyInfo property) { }
        private System.Linq.Expressions.FieldExpression Make(System.Linq.Expressions.Expression expression, System.Reflection.FieldInfo field) { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Reflection.MemberInfo GetMember() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Linq.Expressions.MemberExpression Update(System.Linq.Expressions.Expression expression) { }

    }

    // TypeToken: 0x20000A5
    public class FieldExpression : MemberExpression
    {
        // Fields
        private readonly System.Reflection.FieldInfo _field;        // 0x18

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression expression, System.Reflection.FieldInfo member) { }
        private System.Reflection.MemberInfo GetMember() { }
        private System.Type get_Type() { }

    }

    // TypeToken: 0x20000A6
    public class PropertyExpression : MemberExpression
    {
        // Fields
        private readonly System.Reflection.PropertyInfo _property;        // 0x18

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression expression, System.Reflection.PropertyInfo member) { }
        private System.Reflection.MemberInfo GetMember() { }
        private System.Type get_Type() { }

    }

    // TypeToken: 0x20000A7
    public class MemberInitExpression : Expression
    {
        // Fields
        private readonly System.Linq.Expressions.NewExpression <NewExpression>k__BackingField;        // 0x10
        private readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> <Bindings>k__BackingField;        // 0x18

        // Methods
        private System.Linq.Expressions.NewExpression get_NewExpression() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> get_Bindings() { }

    }

    // TypeToken: 0x20000A8
    public class MemberListBinding : MemberBinding
    {
        // Fields
        private readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> <Initializers>k__BackingField;        // 0x20

        // Methods
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> get_Initializers() { }

    }

    // TypeToken: 0x20000A9
    public class MemberMemberBinding : MemberBinding
    {
        // Fields
        private readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> <Bindings>k__BackingField;        // 0x20

        // Methods
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> get_Bindings() { }

    }

    // TypeToken: 0x20000AA
    public class MethodCallExpression : Expression, IArgumentProvider
    {
        // Fields
        private readonly System.Reflection.MethodInfo <Method>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.Expression GetInstance() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Type get_Type() { }
        private System.Reflection.MethodInfo get_Method() { }
        private System.Linq.Expressions.Expression get_Object() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }

    }

    // TypeToken: 0x20000AB
    public class InstanceMethodCallExpression : MethodCallExpression, IArgumentProvider
    {
        // Fields
        private readonly System.Linq.Expressions.Expression _instance;        // 0x18

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression instance) { }
        private System.Linq.Expressions.Expression GetInstance() { }

    }

    // TypeToken: 0x20000AC
    public class MethodCallExpressionN : MethodCallExpression, IArgumentProvider
    {
        // Fields
        private System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> _arguments;        // 0x18

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }

    }

    // TypeToken: 0x20000AD
    public class InstanceMethodCallExpressionN : InstanceMethodCallExpression, IArgumentProvider
    {
        // Fields
        private System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> _arguments;        // 0x20

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }

    }

    // TypeToken: 0x20000AE
    public class MethodCallExpression0 : MethodCallExpression, IArgumentProvider
    {
        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }

    }

    // TypeToken: 0x20000AF
    public class MethodCallExpression1 : MethodCallExpression, IArgumentProvider
    {
        // Fields
        private System.Object _arg0;        // 0x18

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }

    }

    // TypeToken: 0x20000B0
    public class MethodCallExpression2 : MethodCallExpression, IArgumentProvider
    {
        // Fields
        private System.Object _arg0;        // 0x18
        private readonly System.Linq.Expressions.Expression _arg1;        // 0x20

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }

    }

    // TypeToken: 0x20000B1
    public class MethodCallExpression3 : MethodCallExpression, IArgumentProvider
    {
        // Fields
        private System.Object _arg0;        // 0x18
        private readonly System.Linq.Expressions.Expression _arg1;        // 0x20
        private readonly System.Linq.Expressions.Expression _arg2;        // 0x28

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }

    }

    // TypeToken: 0x20000B2
    public class MethodCallExpression4 : MethodCallExpression, IArgumentProvider
    {
        // Fields
        private System.Object _arg0;        // 0x18
        private readonly System.Linq.Expressions.Expression _arg1;        // 0x20
        private readonly System.Linq.Expressions.Expression _arg2;        // 0x28
        private readonly System.Linq.Expressions.Expression _arg3;        // 0x30

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }

    }

    // TypeToken: 0x20000B3
    public class MethodCallExpression5 : MethodCallExpression, IArgumentProvider
    {
        // Fields
        private System.Object _arg0;        // 0x18
        private readonly System.Linq.Expressions.Expression _arg1;        // 0x20
        private readonly System.Linq.Expressions.Expression _arg2;        // 0x28
        private readonly System.Linq.Expressions.Expression _arg3;        // 0x30
        private readonly System.Linq.Expressions.Expression _arg4;        // 0x38

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2, System.Linq.Expressions.Expression arg3, System.Linq.Expressions.Expression arg4) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }

    }

    // TypeToken: 0x20000B4
    public class InstanceMethodCallExpression0 : InstanceMethodCallExpression, IArgumentProvider
    {
        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression instance) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }

    }

    // TypeToken: 0x20000B5
    public class InstanceMethodCallExpression1 : InstanceMethodCallExpression, IArgumentProvider
    {
        // Fields
        private System.Object _arg0;        // 0x20

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression instance, System.Linq.Expressions.Expression arg0) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }

    }

    // TypeToken: 0x20000B6
    public class InstanceMethodCallExpression2 : InstanceMethodCallExpression, IArgumentProvider
    {
        // Fields
        private System.Object _arg0;        // 0x20
        private readonly System.Linq.Expressions.Expression _arg1;        // 0x28

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression instance, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }

    }

    // TypeToken: 0x20000B7
    public class InstanceMethodCallExpression3 : InstanceMethodCallExpression, IArgumentProvider
    {
        // Fields
        private System.Object _arg0;        // 0x20
        private readonly System.Linq.Expressions.Expression _arg1;        // 0x28
        private readonly System.Linq.Expressions.Expression _arg2;        // 0x30

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo method, System.Linq.Expressions.Expression instance, System.Linq.Expressions.Expression arg0, System.Linq.Expressions.Expression arg1, System.Linq.Expressions.Expression arg2) { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }
        private System.Int32 get_ArgumentCount() { }
        private System.Linq.Expressions.MethodCallExpression Rewrite(System.Linq.Expressions.Expression instance, System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> args) { }

    }

    // TypeToken: 0x20000B8
    public class NewArrayExpression : Expression
    {
        // Fields
        private readonly System.Type <Type>k__BackingField;        // 0x10
        private readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> <Expressions>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Type type, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> expressions) { }
        private System.Linq.Expressions.NewArrayExpression Make(System.Linq.Expressions.ExpressionType nodeType, System.Type type, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> expressions) { }
        private System.Type get_Type() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> get_Expressions() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Linq.Expressions.NewArrayExpression Update(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> expressions) { }

    }

    // TypeToken: 0x20000B9
    public class NewArrayInitExpression : NewArrayExpression
    {
        // Methods
        private System.Void .ctor(System.Type type, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> expressions) { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }

    }

    // TypeToken: 0x20000BA
    public class NewArrayBoundsExpression : NewArrayExpression
    {
        // Methods
        private System.Void .ctor(System.Type type, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> expressions) { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }

    }

    // TypeToken: 0x20000BB
    public class NewExpression : Expression
    {
        // Fields
        private System.Collections.Generic.IReadOnlyList<System.Linq.Expressions.Expression> _arguments;        // 0x10
        private readonly System.Reflection.ConstructorInfo <Constructor>k__BackingField;        // 0x18

        // Methods
        private System.Reflection.ConstructorInfo get_Constructor() { }
        private System.Linq.Expressions.Expression GetArgument(System.Int32 index) { }

    }

    // TypeToken: 0x20000BC
    public class ParameterExpression : Expression
    {
        // Fields
        private readonly System.String <Name>k__BackingField;        // 0x10

        // Methods
        private System.Void .ctor(System.String name) { }
        private System.Linq.Expressions.ParameterExpression Make(System.Type type, System.String name, System.Boolean isByRef) { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.String get_Name() { }
        private System.Boolean get_IsByRef() { }
        private System.Boolean GetIsByRef() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }

    }

    // TypeToken: 0x20000BD
    public class ByRefParameterExpression : TypedParameterExpression
    {
        // Methods
        private System.Void .ctor(System.Type type, System.String name) { }
        private System.Boolean GetIsByRef() { }

    }

    // TypeToken: 0x20000BE
    public class TypedParameterExpression : ParameterExpression
    {
        // Fields
        private readonly System.Type <Type>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Type type, System.String name) { }
        private System.Type get_Type() { }

    }

    // TypeToken: 0x20000BF
    public class PrimitiveParameterExpression`1 : ParameterExpression
    {
        // Methods
        private System.Void .ctor(System.String name) { }
        private System.Type get_Type() { }

    }

    // TypeToken: 0x20000C0
    public class RuntimeVariablesExpression : Expression
    {
        // Fields
        private readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> <Variables>k__BackingField;        // 0x10

        // Methods
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> get_Variables() { }

    }

    // TypeToken: 0x20000C1
    public class StackGuard
    {
        // Fields
        private System.Int32 _executionStackCount;        // 0x10

        // Methods
        private System.Boolean TryEnterOnCurrentStack() { }
        private System.Void RunOnEmptyStack(System.Action<T1,T2> action, T1 arg1, T2 arg2) { }
        private R RunOnEmptyStackCore(System.Func<System.Object,R> action, System.Object state) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000C3
    public class Strings
    {
        // Methods
        private System.String get_ReducibleMustOverrideReduce() { }
        private System.String get_MustReduceToDifferent() { }
        private System.String get_ReducedNotCompatible() { }
        private System.String get_SetterHasNoParams() { }
        private System.String get_PropertyCannotHaveRefType() { }
        private System.String get_IndexesOfSetGetMustMatch() { }
        private System.String get_AccessorsCannotHaveVarArgs() { }
        private System.String get_AccessorsCannotHaveByRefArgs() { }
        private System.String get_BoundsCannotBeLessThanOne() { }
        private System.String get_TypeMustNotBeByRef() { }
        private System.String get_TypeMustNotBePointer() { }
        private System.String get_SetterMustBeVoid() { }
        private System.String get_PropertyTypeMustMatchGetter() { }
        private System.String get_PropertyTypeMustMatchSetter() { }
        private System.String get_BothAccessorsMustBeStatic() { }
        private System.String get_OnlyStaticFieldsHaveNullInstance() { }
        private System.String get_OnlyStaticPropertiesHaveNullInstance() { }
        private System.String get_OnlyStaticMethodsHaveNullInstance() { }
        private System.String get_PropertyTypeCannotBeVoid() { }
        private System.String get_InvalidUnboxType() { }
        private System.String get_ExpressionMustBeWriteable() { }
        private System.String get_ArgumentMustNotHaveValueType() { }
        private System.String get_MustBeReducible() { }
        private System.String get_LabelMustBeVoidOrHaveExpression() { }
        private System.String get_LabelTypeMustBeVoid() { }
        private System.String get_QuotedExpressionMustBeLambda() { }
        private System.String get_CollectionModifiedWhileEnumerating() { }
        private System.String VariableMustNotBeByRef(System.Object p0, System.Object p1) { }
        private System.String get_CollectionReadOnly() { }
        private System.String AmbiguousMatchInExpandoObject(System.Object p0) { }
        private System.String SameKeyExistsInExpando(System.Object p0) { }
        private System.String KeyDoesNotExistInExpando(System.Object p0) { }
        private System.String InvalidMetaObjectCreated(System.Object p0) { }
        private System.String BinderNotCompatibleWithCallSite(System.Object p0, System.Object p1, System.Object p2) { }
        private System.String DynamicBindingNeedsRestrictions(System.Object p0, System.Object p1) { }
        private System.String DynamicObjectResultNotAssignable(System.Object p0, System.Object p1, System.Object p2, System.Object p3) { }
        private System.String DynamicBinderResultNotAssignable(System.Object p0, System.Object p1, System.Object p2) { }
        private System.String get_BindingCannotBeNull() { }
        private System.String DuplicateVariable(System.Object p0) { }
        private System.String TypeParameterIsNotDelegate(System.Object p0) { }
        private System.String get_NoOrInvalidRuleProduced() { }
        private System.String get_TypeMustBeDerivedFromSystemDelegate() { }
        private System.String get_FirstArgumentMustBeCallSite() { }
        private System.String get_FaultCannotHaveCatchOrFinally() { }
        private System.String get_TryMustHaveCatchFinallyOrFault() { }
        private System.String get_BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }
        private System.String ExtensionNodeMustOverrideProperty(System.Object p0) { }
        private System.String UserDefinedOperatorMustBeStatic(System.Object p0) { }
        private System.String UserDefinedOperatorMustNotBeVoid(System.Object p0) { }
        private System.String CoercionOperatorNotDefined(System.Object p0, System.Object p1) { }
        private System.String UnaryOperatorNotDefined(System.Object p0, System.Object p1) { }
        private System.String BinaryOperatorNotDefined(System.Object p0, System.Object p1, System.Object p2) { }
        private System.String ReferenceEqualityNotDefined(System.Object p0, System.Object p1) { }
        private System.String OperandTypesDoNotMatchParameters(System.Object p0, System.Object p1) { }
        private System.String OverloadOperatorTypeDoesNotMatchConversionType(System.Object p0, System.Object p1) { }
        private System.String get_ConversionIsNotSupportedForArithmeticTypes() { }
        private System.String get_ArgumentMustBeArray() { }
        private System.String get_ArgumentMustBeBoolean() { }
        private System.String get_ArgumentMustBeInteger() { }
        private System.String get_ArgumentMustBeArrayIndexType() { }
        private System.String get_ArgumentMustBeSingleDimensionalArrayType() { }
        private System.String get_ArgumentTypesMustMatch() { }
        private System.String CannotAutoInitializeValueTypeMemberThroughProperty(System.Object p0) { }
        private System.String IncorrectTypeForTypeAs(System.Object p0) { }
        private System.String get_CoalesceUsedOnNonNullType() { }
        private System.String ExpressionTypeCannotInitializeArrayType(System.Object p0, System.Object p1) { }
        private System.String ExpressionTypeDoesNotMatchReturn(System.Object p0, System.Object p1) { }
        private System.String ExpressionTypeDoesNotMatchAssignment(System.Object p0, System.Object p1) { }
        private System.String ExpressionTypeDoesNotMatchLabel(System.Object p0, System.Object p1) { }
        private System.String ExpressionTypeNotInvocable(System.Object p0) { }
        private System.String InstanceFieldNotDefinedForType(System.Object p0, System.Object p1) { }
        private System.String FieldInfoNotDefinedForType(System.Object p0, System.Object p1, System.Object p2) { }
        private System.String get_IncorrectNumberOfIndexes() { }
        private System.String get_IncorrectNumberOfLambdaDeclarationParameters() { }
        private System.String get_LambdaTypeMustBeDerivedFromSystemDelegate() { }
        private System.String MemberNotFieldOrProperty(System.Object p0) { }
        private System.String MethodContainsGenericParameters(System.Object p0) { }
        private System.String MethodIsGeneric(System.Object p0) { }
        private System.String MethodNotPropertyAccessor(System.Object p0, System.Object p1) { }
        private System.String PropertyDoesNotHaveAccessor(System.Object p0) { }
        private System.String ParameterExpressionNotValidAsDelegate(System.Object p0, System.Object p1) { }
        private System.String PropertyNotDefinedForType(System.Object p0, System.Object p1) { }
        private System.String InstancePropertyNotDefinedForType(System.Object p0, System.Object p1) { }
        private System.String InstanceAndMethodTypeMismatch(System.Object p0, System.Object p1, System.Object p2) { }
        private System.String UnhandledBinary(System.Object p0) { }
        private System.String UnhandledUnary(System.Object p0) { }
        private System.String UserDefinedOpMustHaveConsistentTypes(System.Object p0, System.Object p1) { }
        private System.String UserDefinedOpMustHaveValidReturnType(System.Object p0, System.Object p1) { }
        private System.String LogicalOperatorMustHaveBooleanOperators(System.Object p0, System.Object p1) { }
        private System.String MethodWithArgsDoesNotExistOnType(System.Object p0, System.Object p1) { }
        private System.String GenericMethodWithArgsDoesNotExistOnType(System.Object p0, System.Object p1) { }
        private System.String MethodWithMoreThanOneMatch(System.Object p0, System.Object p1) { }
        private System.String get_ArgumentCannotBeOfTypeVoid() { }
        private System.String OutOfRange(System.Object p0, System.Object p1) { }
        private System.String LabelTargetAlreadyDefined(System.Object p0) { }
        private System.String LabelTargetUndefined(System.Object p0) { }
        private System.String get_ControlCannotLeaveFinally() { }
        private System.String get_ControlCannotLeaveFilterTest() { }
        private System.String AmbiguousJump(System.Object p0) { }
        private System.String get_ControlCannotEnterTry() { }
        private System.String get_ControlCannotEnterExpression() { }
        private System.String NonLocalJumpWithValue(System.Object p0) { }
        private System.String InvalidLvalue(System.Object p0) { }
        private System.String get_RethrowRequiresCatch() { }
        private System.String MustRewriteToSameNode(System.Object p0, System.Object p1, System.Object p2) { }
        private System.String MustRewriteChildToSameType(System.Object p0, System.Object p1, System.Object p2) { }
        private System.String MustRewriteWithoutMethod(System.Object p0, System.Object p1) { }
        private System.String get_NonAbstractConstructorRequired() { }
        private System.String get_ExpressionMustBeReadable() { }
        private System.String ExpressionTypeDoesNotMatchConstructorParameter(System.Object p0, System.Object p1) { }
        private System.String get_EnumerationIsDone() { }
        private System.String TypeContainsGenericParameters(System.Object p0) { }
        private System.String TypeIsGeneric(System.Object p0) { }
        private System.String get_InvalidArgumentValue() { }
        private System.String InvalidNullValue(System.Object p0) { }
        private System.String InvalidObjectType(System.Object p0, System.Object p1) { }
        private System.String ExpressionTypeDoesNotMatchMethodParameter(System.Object p0, System.Object p1, System.Object p2) { }
        private System.String ExpressionTypeDoesNotMatchParameter(System.Object p0, System.Object p1) { }
        private System.String IncorrectNumberOfMethodCallArguments(System.Object p0) { }
        private System.String get_IncorrectNumberOfLambdaArguments() { }
        private System.String get_IncorrectNumberOfConstructorArguments() { }

    }

    // TypeToken: 0x20000C4
    public class SwitchCase
    {
        // Fields
        private readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> <TestValues>k__BackingField;        // 0x10
        private readonly System.Linq.Expressions.Expression <Body>k__BackingField;        // 0x18

        // Methods
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression> get_TestValues() { }
        private System.Linq.Expressions.Expression get_Body() { }

    }

    // TypeToken: 0x20000C5
    public class SwitchExpression : Expression
    {
        // Fields
        private readonly System.Linq.Expressions.Expression <SwitchValue>k__BackingField;        // 0x10
        private readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase> <Cases>k__BackingField;        // 0x18
        private readonly System.Linq.Expressions.Expression <DefaultBody>k__BackingField;        // 0x20
        private readonly System.Reflection.MethodInfo <Comparison>k__BackingField;        // 0x28

        // Methods
        private System.Linq.Expressions.Expression get_SwitchValue() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.SwitchCase> get_Cases() { }
        private System.Linq.Expressions.Expression get_DefaultBody() { }
        private System.Reflection.MethodInfo get_Comparison() { }

    }

    // TypeToken: 0x20000C6
    public class SymbolDocumentInfo
    {
        // Fields
        private readonly System.String <FileName>k__BackingField;        // 0x10
        private static readonly System.Guid DocumentType_Text;        // 0x0

        // Methods
        private System.String get_FileName() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000C7
    public class TryExpression : Expression
    {
        // Fields
        private readonly System.Type <Type>k__BackingField;        // 0x10
        private readonly System.Linq.Expressions.Expression <Body>k__BackingField;        // 0x18
        private readonly System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock> <Handlers>k__BackingField;        // 0x20
        private readonly System.Linq.Expressions.Expression <Finally>k__BackingField;        // 0x28
        private readonly System.Linq.Expressions.Expression <Fault>k__BackingField;        // 0x30

        // Methods
        private System.Void .ctor(System.Type type, System.Linq.Expressions.Expression body, System.Linq.Expressions.Expression finally, System.Linq.Expressions.Expression fault, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock> handlers) { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Linq.Expressions.Expression get_Body() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.CatchBlock> get_Handlers() { }
        private System.Linq.Expressions.Expression get_Finally() { }
        private System.Linq.Expressions.Expression get_Fault() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Linq.Expressions.TryExpression Update(System.Linq.Expressions.Expression body, System.Collections.Generic.IEnumerable<System.Linq.Expressions.CatchBlock> handlers, System.Linq.Expressions.Expression finally, System.Linq.Expressions.Expression fault) { }

    }

    // TypeToken: 0x20000C8
    public class TypeBinaryExpression : Expression
    {
        // Fields
        private readonly System.Linq.Expressions.ExpressionType <NodeType>k__BackingField;        // 0x10
        private readonly System.Linq.Expressions.Expression <Expression>k__BackingField;        // 0x18
        private readonly System.Type <TypeOperand>k__BackingField;        // 0x20

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression expression, System.Type typeOperand, System.Linq.Expressions.ExpressionType nodeType) { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Linq.Expressions.Expression get_Expression() { }
        private System.Type get_TypeOperand() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Linq.Expressions.TypeBinaryExpression Update(System.Linq.Expressions.Expression expression) { }

    }

    // TypeToken: 0x20000C9
    public class UnaryExpression : Expression
    {
        // Fields
        private readonly System.Type <Type>k__BackingField;        // 0x10
        private readonly System.Linq.Expressions.ExpressionType <NodeType>k__BackingField;        // 0x18
        private readonly System.Linq.Expressions.Expression <Operand>k__BackingField;        // 0x20
        private readonly System.Reflection.MethodInfo <Method>k__BackingField;        // 0x28

        // Methods
        private System.Void .ctor(System.Linq.Expressions.ExpressionType nodeType, System.Linq.Expressions.Expression expression, System.Type type, System.Reflection.MethodInfo method) { }
        private System.Type get_Type() { }
        private System.Linq.Expressions.ExpressionType get_NodeType() { }
        private System.Linq.Expressions.Expression get_Operand() { }
        private System.Reflection.MethodInfo get_Method() { }
        private System.Boolean get_IsLifted() { }
        private System.Boolean get_IsLiftedToNull() { }
        private System.Linq.Expressions.Expression Accept(System.Linq.Expressions.ExpressionVisitor visitor) { }
        private System.Boolean get_CanReduce() { }
        private System.Linq.Expressions.Expression Reduce() { }
        private System.Boolean get_IsPrefix() { }
        private System.Linq.Expressions.UnaryExpression FunctionalOp(System.Linq.Expressions.Expression operand) { }
        private System.Linq.Expressions.Expression ReduceVariable() { }
        private System.Linq.Expressions.Expression ReduceMember() { }
        private System.Linq.Expressions.Expression ReduceIndex() { }
        private System.Linq.Expressions.UnaryExpression Update(System.Linq.Expressions.Expression operand) { }

    }

    // TypeToken: 0x20000CA
    public class Utils
    {
        // Fields
        public static readonly System.Object BoxedFalse;        // 0x0
        public static readonly System.Object BoxedTrue;        // 0x8
        public static readonly System.Object BoxedIntM1;        // 0x10
        public static readonly System.Object BoxedInt0;        // 0x18
        public static readonly System.Object BoxedInt1;        // 0x20
        public static readonly System.Object BoxedInt2;        // 0x28
        public static readonly System.Object BoxedInt3;        // 0x30
        public static readonly System.Object BoxedDefaultSByte;        // 0x38
        public static readonly System.Object BoxedDefaultChar;        // 0x40
        public static readonly System.Object BoxedDefaultInt16;        // 0x48
        public static readonly System.Object BoxedDefaultInt64;        // 0x50
        public static readonly System.Object BoxedDefaultByte;        // 0x58
        public static readonly System.Object BoxedDefaultUInt16;        // 0x60
        public static readonly System.Object BoxedDefaultUInt32;        // 0x68
        public static readonly System.Object BoxedDefaultUInt64;        // 0x70
        public static readonly System.Object BoxedDefaultSingle;        // 0x78
        public static readonly System.Object BoxedDefaultDouble;        // 0x80
        public static readonly System.Object BoxedDefaultDecimal;        // 0x88
        public static readonly System.Object BoxedDefaultDateTime;        // 0x90
        private static readonly System.Linq.Expressions.ConstantExpression s_true;        // 0x98
        private static readonly System.Linq.Expressions.ConstantExpression s_false;        // 0xA0
        private static readonly System.Linq.Expressions.ConstantExpression s_m1;        // 0xA8
        private static readonly System.Linq.Expressions.ConstantExpression s_0;        // 0xB0
        private static readonly System.Linq.Expressions.ConstantExpression s_1;        // 0xB8
        private static readonly System.Linq.Expressions.ConstantExpression s_2;        // 0xC0
        private static readonly System.Linq.Expressions.ConstantExpression s_3;        // 0xC8
        public static readonly System.Linq.Expressions.DefaultExpression Empty;        // 0xD0
        public static readonly System.Linq.Expressions.ConstantExpression Null;        // 0xD8

        // Methods
        private System.Linq.Expressions.ConstantExpression Constant(System.Boolean value) { }
        private System.Linq.Expressions.ConstantExpression Constant(System.Int32 value) { }
        private System.Void .cctor() { }

    }

}

namespace System.Linq.Expressions.Interpreter
{

    // TypeToken: 0x20000CB
    public class AddInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_Single;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_Double;        // 0x38

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x20000D4
    public class AddOvfInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x28

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x20000DB
    public class AndInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_SByte;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_Byte;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x38
        private static System.Linq.Expressions.Interpreter.Instruction s_Boolean;        // 0x40

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x20000E5
    public class NewArrayInitInstruction : Instruction
    {
        // Fields
        private readonly System.Type _elementType;        // 0x10
        private readonly System.Int32 _elementCount;        // 0x18

        // Methods
        private System.Void .ctor(System.Type elementType, System.Int32 elementCount) { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x20000E6
    public class NewArrayInstruction : Instruction
    {
        // Fields
        private readonly System.Type _elementType;        // 0x10

        // Methods
        private System.Void .ctor(System.Type elementType) { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x20000E7
    public class NewArrayBoundsInstruction : Instruction
    {
        // Fields
        private readonly System.Type _elementType;        // 0x10
        private readonly System.Int32 _rank;        // 0x18

        // Methods
        private System.Void .ctor(System.Type elementType, System.Int32 rank) { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x20000E8
    public class GetArrayItemInstruction : Instruction
    {
        // Fields
        private static readonly System.Linq.Expressions.Interpreter.GetArrayItemInstruction Instance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000E9
    public class SetArrayItemInstruction : Instruction
    {
        // Fields
        private static readonly System.Linq.Expressions.Interpreter.SetArrayItemInstruction Instance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_ConsumedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000EA
    public class ArrayLengthInstruction : Instruction
    {
        // Fields
        public static readonly System.Linq.Expressions.Interpreter.ArrayLengthInstruction Instance;        // 0x0

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000EB
    public class ConvertHelper
    {
        // Methods
        private System.Int32 ToInt32NoNull(System.Object val) { }

    }

    // TypeToken: 0x20000EC
    public struct RuntimeLabel
    {
        // Fields
        public readonly System.Int32 Index;        // 0x10
        public readonly System.Int32 StackDepth;        // 0x14
        public readonly System.Int32 ContinuationStackDepth;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 index, System.Int32 continuationStackDepth, System.Int32 stackDepth) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20000ED
    public class BranchLabel
    {
        // Fields
        private System.Int32 _targetIndex;        // 0x10
        private System.Int32 _stackDepth;        // 0x14
        private System.Int32 _continuationStackDepth;        // 0x18
        private System.Collections.Generic.List<System.Int32> _forwardBranchFixups;        // 0x20
        private System.Int32 <LabelIndex>k__BackingField;        // 0x28

        // Methods
        private System.Int32 get_LabelIndex() { }
        private System.Void set_LabelIndex(System.Int32 value) { }
        private System.Boolean get_HasRuntimeLabel() { }
        private System.Int32 get_TargetIndex() { }
        private System.Linq.Expressions.Interpreter.RuntimeLabel ToRuntimeLabel() { }
        private System.Void Mark(System.Linq.Expressions.Interpreter.InstructionList instructions) { }
        private System.Void AddBranch(System.Linq.Expressions.Interpreter.InstructionList instructions, System.Int32 branchIndex) { }
        private System.Void FixupBranch(System.Linq.Expressions.Interpreter.InstructionList instructions, System.Int32 branchIndex) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EE
    public class CallInstruction : Instruction
    {
        // Methods
        private System.Int32 get_ArgumentCount() { }
        private System.String get_InstructionName() { }
        private System.Linq.Expressions.Interpreter.CallInstruction Create(System.Reflection.MethodInfo info) { }
        private System.Linq.Expressions.Interpreter.CallInstruction Create(System.Reflection.MethodInfo info, System.Reflection.ParameterInfo[] parameters) { }
        private System.Linq.Expressions.Interpreter.CallInstruction GetArrayAccessor(System.Reflection.MethodInfo info, System.Int32 argumentCount) { }
        private System.Void ArrayItemSetter1(System.Array array, System.Int32 index0, System.Object value) { }
        private System.Void ArrayItemSetter2(System.Array array, System.Int32 index0, System.Int32 index1, System.Object value) { }
        private System.Void ArrayItemSetter3(System.Array array, System.Int32 index0, System.Int32 index1, System.Int32 index2, System.Object value) { }
        private System.Int32 get_ConsumedStack() { }
        private System.Boolean TryGetLightLambdaTarget(System.Object instance, System.Linq.Expressions.Interpreter.LightLambda& lightLambda) { }
        private System.Object InterpretLambdaInvoke(System.Linq.Expressions.Interpreter.LightLambda targetLambda, System.Object[] args) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000EF
    public class MethodInfoCallInstruction : CallInstruction
    {
        // Fields
        protected readonly System.Reflection.MethodInfo _target;        // 0x10
        protected readonly System.Int32 _argumentCount;        // 0x18

        // Methods
        private System.Int32 get_ArgumentCount() { }
        private System.Void .ctor(System.Reflection.MethodInfo target, System.Int32 argumentCount) { }
        private System.Int32 get_ProducedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Object[] GetArgs(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Int32 first, System.Int32 skip) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20000F0
    public class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction
    {
        // Fields
        private readonly System.Linq.Expressions.Interpreter.ByRefUpdater[] _byrefArgs;        // 0x20

        // Methods
        private System.Void .ctor(System.Reflection.MethodInfo target, System.Int32 argumentCount, System.Linq.Expressions.Interpreter.ByRefUpdater[] byrefArgs) { }
        private System.Int32 get_ProducedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x20000F1
    public class OffsetInstruction : Instruction
    {
        // Fields
        protected System.Int32 _offset;        // 0x10

        // Methods
        private System.Linq.Expressions.Interpreter.Instruction[] get_Cache() { }
        private System.Linq.Expressions.Interpreter.Instruction Fixup(System.Int32 offset) { }
        private System.String ToDebugString(System.Int32 instructionIndex, System.Object cookie, System.Func<System.Int32,System.Int32> labelIndexer, System.Collections.Generic.IReadOnlyList<System.Object> objects) { }
        private System.String ToString() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F2
    public class BranchFalseInstruction : OffsetInstruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction[] s_cache;        // 0x0

        // Methods
        private System.Linq.Expressions.Interpreter.Instruction[] get_Cache() { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F3
    public class BranchTrueInstruction : OffsetInstruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction[] s_cache;        // 0x0

        // Methods
        private System.Linq.Expressions.Interpreter.Instruction[] get_Cache() { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F4
    public class CoalescingBranchInstruction : OffsetInstruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction[] s_cache;        // 0x0

        // Methods
        private System.Linq.Expressions.Interpreter.Instruction[] get_Cache() { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000F5
    public class BranchInstruction : OffsetInstruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction[][][] s_caches;        // 0x0
        private readonly System.Boolean _hasResult;        // 0x18
        private readonly System.Boolean _hasValue;        // 0x19

        // Methods
        private System.Linq.Expressions.Interpreter.Instruction[] get_Cache() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Boolean hasResult, System.Boolean hasValue) { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x20000F6
    public class IndexedBranchInstruction : Instruction
    {
        // Fields
        private readonly System.Int32 _labelIndex;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 labelIndex) { }
        private System.Linq.Expressions.Interpreter.RuntimeLabel GetLabel(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.String ToDebugString(System.Int32 instructionIndex, System.Object cookie, System.Func<System.Int32,System.Int32> labelIndexer, System.Collections.Generic.IReadOnlyList<System.Object> objects) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20000F7
    public class GotoInstruction : IndexedBranchInstruction
    {
        // Fields
        private static readonly System.Linq.Expressions.Interpreter.GotoInstruction[] s_cache;        // 0x0
        private readonly System.Boolean _hasResult;        // 0x18
        private readonly System.Boolean _hasValue;        // 0x19
        private readonly System.Boolean _labelTargetGetsValue;        // 0x1A

        // Methods
        private System.String get_InstructionName() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.Void .ctor(System.Int32 targetIndex, System.Boolean hasResult, System.Boolean hasValue, System.Boolean labelTargetGetsValue) { }
        private System.Linq.Expressions.Interpreter.GotoInstruction Create(System.Int32 labelIndex, System.Boolean hasResult, System.Boolean hasValue, System.Boolean labelTargetGetsValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000F8
    public class EnterTryCatchFinallyInstruction : IndexedBranchInstruction
    {
        // Fields
        private readonly System.Boolean _hasFinally;        // 0x18
        private System.Linq.Expressions.Interpreter.TryCatchFinallyHandler _tryHandler;        // 0x20

        // Methods
        private System.Void SetTryHandler(System.Linq.Expressions.Interpreter.TryCatchFinallyHandler tryHandler) { }
        private System.Linq.Expressions.Interpreter.TryCatchFinallyHandler get_Handler() { }
        private System.Int32 get_ProducedContinuations() { }
        private System.Void .ctor(System.Int32 targetIndex, System.Boolean hasFinally) { }
        private System.Linq.Expressions.Interpreter.EnterTryCatchFinallyInstruction CreateTryFinally(System.Int32 labelIndex) { }
        private System.Linq.Expressions.Interpreter.EnterTryCatchFinallyInstruction CreateTryCatch() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.String get_InstructionName() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20000F9
    public class EnterTryFaultInstruction : IndexedBranchInstruction
    {
        // Fields
        private System.Linq.Expressions.Interpreter.TryFaultHandler _tryHandler;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 targetIndex) { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ProducedContinuations() { }
        private System.Linq.Expressions.Interpreter.TryFaultHandler get_Handler() { }
        private System.Void SetTryHandler(System.Linq.Expressions.Interpreter.TryFaultHandler tryHandler) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x20000FA
    public class EnterFinallyInstruction : IndexedBranchInstruction
    {
        // Fields
        private static readonly System.Linq.Expressions.Interpreter.EnterFinallyInstruction[] s_cache;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 labelIndex) { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ProducedStack() { }
        private System.Int32 get_ConsumedContinuations() { }
        private System.Linq.Expressions.Interpreter.EnterFinallyInstruction Create(System.Int32 labelIndex) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000FB
    public class LeaveFinallyInstruction : Instruction
    {
        // Fields
        private static readonly System.Linq.Expressions.Interpreter.Instruction Instance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_ConsumedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000FC
    public class EnterFaultInstruction : IndexedBranchInstruction
    {
        // Fields
        private static readonly System.Linq.Expressions.Interpreter.EnterFaultInstruction[] s_cache;        // 0x0

        // Methods
        private System.Void .ctor(System.Int32 labelIndex) { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ProducedStack() { }
        private System.Linq.Expressions.Interpreter.EnterFaultInstruction Create(System.Int32 labelIndex) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000FD
    public class LeaveFaultInstruction : Instruction
    {
        // Fields
        private static readonly System.Linq.Expressions.Interpreter.Instruction Instance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ConsumedContinuations() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000FE
    public class EnterExceptionFilterInstruction : Instruction
    {
        // Fields
        private static readonly System.Linq.Expressions.Interpreter.EnterExceptionFilterInstruction Instance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ProducedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20000FF
    public class LeaveExceptionFilterInstruction : Instruction
    {
        // Fields
        private static readonly System.Linq.Expressions.Interpreter.LeaveExceptionFilterInstruction Instance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000100
    public class EnterExceptionHandlerInstruction : Instruction
    {
        // Fields
        private static readonly System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstruction Void;        // 0x0
        private static readonly System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstruction NonVoid;        // 0x8
        private readonly System.Boolean _hasValue;        // 0x10

        // Methods
        private System.Void .ctor(System.Boolean hasValue) { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000101
    public class LeaveExceptionHandlerInstruction : IndexedBranchInstruction
    {
        // Fields
        private static readonly System.Linq.Expressions.Interpreter.LeaveExceptionHandlerInstruction[] s_cache;        // 0x0
        private readonly System.Boolean _hasValue;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 labelIndex, System.Boolean hasValue) { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.Linq.Expressions.Interpreter.LeaveExceptionHandlerInstruction Create(System.Int32 labelIndex, System.Boolean hasValue) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000102
    public class ThrowInstruction : Instruction
    {
        // Fields
        private static readonly System.Linq.Expressions.Interpreter.ThrowInstruction Throw;        // 0x0
        private static readonly System.Linq.Expressions.Interpreter.ThrowInstruction VoidThrow;        // 0x8
        private static readonly System.Linq.Expressions.Interpreter.ThrowInstruction Rethrow;        // 0x10
        private static readonly System.Linq.Expressions.Interpreter.ThrowInstruction VoidRethrow;        // 0x18
        private readonly System.Boolean _hasResult;        // 0x10
        private readonly System.Boolean _rethrow;        // 0x11

        // Methods
        private System.Void .ctor(System.Boolean hasResult, System.Boolean isRethrow) { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ProducedStack() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Exception WrapThrownObject(System.Object thrown) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000103
    public class IntSwitchInstruction`1 : Instruction
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<T,System.Int32> _cases;        // 0x0

        // Methods
        private System.Void .ctor(System.Collections.Generic.Dictionary<T,System.Int32> cases) { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000104
    public class StringSwitchInstruction : Instruction
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.String,System.Int32> _cases;        // 0x10
        private readonly System.Runtime.CompilerServices.StrongBox<System.Int32> _nullCase;        // 0x18

        // Methods
        private System.Void .ctor(System.Collections.Generic.Dictionary<System.String,System.Int32> cases, System.Runtime.CompilerServices.StrongBox<System.Int32> nullCase) { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000105
    public class DecrementInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_Single;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_Double;        // 0x38

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x200010E
    public class DefaultValueInstruction : Instruction
    {
        // Fields
        private readonly System.Type _type;        // 0x10

        // Methods
        private System.Void .ctor(System.Type type) { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200010F
    public class DivInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_Single;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_Double;        // 0x38

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x2000118
    public class EqualInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_reference;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Boolean;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_SByte;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_Char;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_Byte;        // 0x38
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x40
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x48
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x50
        private static System.Linq.Expressions.Interpreter.Instruction s_Single;        // 0x58
        private static System.Linq.Expressions.Interpreter.Instruction s_Double;        // 0x60
        private static System.Linq.Expressions.Interpreter.Instruction s_BooleanLiftedToNull;        // 0x68
        private static System.Linq.Expressions.Interpreter.Instruction s_SByteLiftedToNull;        // 0x70
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16LiftedToNull;        // 0x78
        private static System.Linq.Expressions.Interpreter.Instruction s_CharLiftedToNull;        // 0x80
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32LiftedToNull;        // 0x88
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64LiftedToNull;        // 0x90
        private static System.Linq.Expressions.Interpreter.Instruction s_ByteLiftedToNull;        // 0x98
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16LiftedToNull;        // 0xA0
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32LiftedToNull;        // 0xA8
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64LiftedToNull;        // 0xB0
        private static System.Linq.Expressions.Interpreter.Instruction s_SingleLiftedToNull;        // 0xB8
        private static System.Linq.Expressions.Interpreter.Instruction s_DoubleLiftedToNull;        // 0xC0

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type, System.Boolean liftedToNull) { }

    }

    // TypeToken: 0x2000132
    public class ExclusiveOrInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_SByte;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_Byte;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x38
        private static System.Linq.Expressions.Interpreter.Instruction s_Boolean;        // 0x40

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x200013C
    public class FieldInstruction : Instruction
    {
        // Fields
        protected readonly System.Reflection.FieldInfo _field;        // 0x10

        // Methods
        private System.Void .ctor(System.Reflection.FieldInfo field) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200013D
    public class LoadStaticFieldInstruction : FieldInstruction
    {
        // Methods
        private System.Void .ctor(System.Reflection.FieldInfo field) { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ProducedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200013E
    public class LoadFieldInstruction : FieldInstruction
    {
        // Methods
        private System.Void .ctor(System.Reflection.FieldInfo field) { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x200013F
    public class StoreFieldInstruction : FieldInstruction
    {
        // Methods
        private System.Void .ctor(System.Reflection.FieldInfo field) { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000140
    public class StoreStaticFieldInstruction : FieldInstruction
    {
        // Methods
        private System.Void .ctor(System.Reflection.FieldInfo field) { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000141
    public class GreaterThanInstruction : Instruction
    {
        // Fields
        private readonly System.Object _nullValue;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_SByte;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Char;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_Byte;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x38
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x40
        private static System.Linq.Expressions.Interpreter.Instruction s_Single;        // 0x48
        private static System.Linq.Expressions.Interpreter.Instruction s_Double;        // 0x50
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSByte;        // 0x58
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt16;        // 0x60
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullChar;        // 0x68
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt32;        // 0x70
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt64;        // 0x78
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullByte;        // 0x80
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt16;        // 0x88
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt32;        // 0x90
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt64;        // 0x98
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSingle;        // 0xA0
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullDouble;        // 0xA8

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor(System.Object nullValue) { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type, System.Boolean liftedToNull) { }

    }

    // TypeToken: 0x200014D
    public class GreaterThanOrEqualInstruction : Instruction
    {
        // Fields
        private readonly System.Object _nullValue;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_SByte;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Char;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_Byte;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x38
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x40
        private static System.Linq.Expressions.Interpreter.Instruction s_Single;        // 0x48
        private static System.Linq.Expressions.Interpreter.Instruction s_Double;        // 0x50
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSByte;        // 0x58
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt16;        // 0x60
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullChar;        // 0x68
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt32;        // 0x70
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt64;        // 0x78
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullByte;        // 0x80
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt16;        // 0x88
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt32;        // 0x90
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt64;        // 0x98
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSingle;        // 0xA0
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullDouble;        // 0xA8

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor(System.Object nullValue) { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type, System.Boolean liftedToNull) { }

    }

    // TypeToken: 0x2000159
    public class IncrementInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_Single;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_Double;        // 0x38

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x2000162
    public class Instruction
    {
        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.Int32 get_ConsumedContinuations() { }
        private System.Int32 get_ProducedContinuations() { }
        private System.Int32 get_StackBalance() { }
        private System.Int32 get_ContinuationsBalance() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.String get_InstructionName() { }
        private System.String ToString() { }
        private System.String ToDebugString(System.Int32 instructionIndex, System.Object cookie, System.Func<System.Int32,System.Int32> labelIndexer, System.Collections.Generic.IReadOnlyList<System.Object> objects) { }
        private System.Void NullCheck(System.Object o) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000163
    public struct InstructionArray
    {
        // Fields
        private readonly System.Int32 MaxStackDepth;        // 0x10
        private readonly System.Int32 MaxContinuationDepth;        // 0x14
        private readonly System.Linq.Expressions.Interpreter.Instruction[] Instructions;        // 0x18
        private readonly System.Object[] Objects;        // 0x20
        private readonly System.Linq.Expressions.Interpreter.RuntimeLabel[] Labels;        // 0x28
        private readonly System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32,System.Object>> DebugCookies;        // 0x30

        // Methods
        private System.Void .ctor(System.Int32 maxStackDepth, System.Int32 maxContinuationDepth, System.Linq.Expressions.Interpreter.Instruction[] instructions, System.Object[] objects, System.Linq.Expressions.Interpreter.RuntimeLabel[] labels, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32,System.Object>> debugCookies) { }

    }

    // TypeToken: 0x2000165
    public class InstructionList
    {
        // Fields
        private readonly System.Collections.Generic.List<System.Linq.Expressions.Interpreter.Instruction> _instructions;        // 0x10
        private System.Collections.Generic.List<System.Object> _objects;        // 0x18
        private System.Int32 _currentStackDepth;        // 0x20
        private System.Int32 _maxStackDepth;        // 0x24
        private System.Int32 _currentContinuationsDepth;        // 0x28
        private System.Int32 _maxContinuationDepth;        // 0x2C
        private System.Int32 _runtimeLabelCount;        // 0x30
        private System.Collections.Generic.List<System.Linq.Expressions.Interpreter.BranchLabel> _labels;        // 0x38
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32,System.Object>> _debugCookies;        // 0x40
        private static System.Linq.Expressions.Interpreter.Instruction s_null;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_true;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_false;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction[] s_Ints;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction[] s_loadObjectCached;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction[] s_loadLocal;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction[] s_loadLocalBoxed;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction[] s_loadLocalFromClosure;        // 0x38
        private static System.Linq.Expressions.Interpreter.Instruction[] s_loadLocalFromClosureBoxed;        // 0x40
        private static System.Linq.Expressions.Interpreter.Instruction[] s_assignLocal;        // 0x48
        private static System.Linq.Expressions.Interpreter.Instruction[] s_storeLocal;        // 0x50
        private static System.Linq.Expressions.Interpreter.Instruction[] s_assignLocalBoxed;        // 0x58
        private static System.Linq.Expressions.Interpreter.Instruction[] s_storeLocalBoxed;        // 0x60
        private static System.Linq.Expressions.Interpreter.Instruction[] s_assignLocalToClosure;        // 0x68
        private static readonly System.Collections.Generic.Dictionary<System.Reflection.FieldInfo,System.Linq.Expressions.Interpreter.Instruction> s_loadFields;        // 0x70
        private static readonly System.Linq.Expressions.Interpreter.RuntimeLabel[] s_emptyRuntimeLabels;        // 0x78

        // Methods
        private System.Void Emit(System.Linq.Expressions.Interpreter.Instruction instruction) { }
        private System.Void UpdateStackDepth(System.Linq.Expressions.Interpreter.Instruction instruction) { }
        private System.Void UnEmit() { }
        private System.Int32 get_Count() { }
        private System.Int32 get_CurrentStackDepth() { }
        private System.Int32 get_CurrentContinuationsDepth() { }
        private System.Linq.Expressions.Interpreter.Instruction GetInstruction(System.Int32 index) { }
        private System.Linq.Expressions.Interpreter.InstructionArray ToArray() { }
        private System.Void EmitLoad(System.Object value) { }
        private System.Void EmitLoad(System.Boolean value) { }
        private System.Void EmitLoad(System.Object value, System.Type type) { }
        private System.Void EmitDup() { }
        private System.Void EmitPop() { }
        private System.Void SwitchToBoxed(System.Int32 index, System.Int32 instructionIndex) { }
        private System.Void EmitLoadLocal(System.Int32 index) { }
        private System.Void EmitLoadLocalBoxed(System.Int32 index) { }
        private System.Linq.Expressions.Interpreter.Instruction LoadLocalBoxed(System.Int32 index) { }
        private System.Void EmitLoadLocalFromClosure(System.Int32 index) { }
        private System.Void EmitLoadLocalFromClosureBoxed(System.Int32 index) { }
        private System.Void EmitAssignLocal(System.Int32 index) { }
        private System.Void EmitStoreLocal(System.Int32 index) { }
        private System.Void EmitAssignLocalBoxed(System.Int32 index) { }
        private System.Linq.Expressions.Interpreter.Instruction AssignLocalBoxed(System.Int32 index) { }
        private System.Void EmitStoreLocalBoxed(System.Int32 index) { }
        private System.Linq.Expressions.Interpreter.Instruction StoreLocalBoxed(System.Int32 index) { }
        private System.Void EmitAssignLocalToClosure(System.Int32 index) { }
        private System.Void EmitStoreLocalToClosure(System.Int32 index) { }
        private System.Void EmitInitializeLocal(System.Int32 index, System.Type type) { }
        private System.Void EmitInitializeParameter(System.Int32 index) { }
        private System.Linq.Expressions.Interpreter.Instruction Parameter(System.Int32 index) { }
        private System.Linq.Expressions.Interpreter.Instruction ParameterBox(System.Int32 index) { }
        private System.Linq.Expressions.Interpreter.Instruction InitReference(System.Int32 index) { }
        private System.Linq.Expressions.Interpreter.Instruction InitImmutableRefBox(System.Int32 index) { }
        private System.Void EmitNewRuntimeVariables(System.Int32 count) { }
        private System.Void EmitGetArrayItem() { }
        private System.Void EmitSetArrayItem() { }
        private System.Void EmitNewArray(System.Type elementType) { }
        private System.Void EmitNewArrayBounds(System.Type elementType, System.Int32 rank) { }
        private System.Void EmitNewArrayInit(System.Type elementType, System.Int32 elementCount) { }
        private System.Void EmitAdd(System.Type type, System.Boolean checked) { }
        private System.Void EmitSub(System.Type type, System.Boolean checked) { }
        private System.Void EmitMul(System.Type type, System.Boolean checked) { }
        private System.Void EmitDiv(System.Type type) { }
        private System.Void EmitModulo(System.Type type) { }
        private System.Void EmitExclusiveOr(System.Type type) { }
        private System.Void EmitAnd(System.Type type) { }
        private System.Void EmitOr(System.Type type) { }
        private System.Void EmitLeftShift(System.Type type) { }
        private System.Void EmitRightShift(System.Type type) { }
        private System.Void EmitEqual(System.Type type, System.Boolean liftedToNull) { }
        private System.Void EmitNotEqual(System.Type type, System.Boolean liftedToNull) { }
        private System.Void EmitLessThan(System.Type type, System.Boolean liftedToNull) { }
        private System.Void EmitLessThanOrEqual(System.Type type, System.Boolean liftedToNull) { }
        private System.Void EmitGreaterThan(System.Type type, System.Boolean liftedToNull) { }
        private System.Void EmitGreaterThanOrEqual(System.Type type, System.Boolean liftedToNull) { }
        private System.Void EmitNumericConvertChecked(System.TypeCode from, System.TypeCode to, System.Boolean isLiftedToNull) { }
        private System.Void EmitNumericConvertUnchecked(System.TypeCode from, System.TypeCode to, System.Boolean isLiftedToNull) { }
        private System.Void EmitConvertToUnderlying(System.TypeCode to, System.Boolean isLiftedToNull) { }
        private System.Void EmitCast(System.Type toType) { }
        private System.Void EmitCastToEnum(System.Type toType) { }
        private System.Void EmitCastReferenceToEnum(System.Type toType) { }
        private System.Void EmitNot(System.Type type) { }
        private System.Void EmitDefaultValue(System.Type type) { }
        private System.Void EmitNew(System.Reflection.ConstructorInfo constructorInfo, System.Reflection.ParameterInfo[] parameters) { }
        private System.Void EmitByRefNew(System.Reflection.ConstructorInfo constructorInfo, System.Reflection.ParameterInfo[] parameters, System.Linq.Expressions.Interpreter.ByRefUpdater[] updaters) { }
        private System.Void EmitCreateDelegate(System.Linq.Expressions.Interpreter.LightDelegateCreator creator) { }
        private System.Void EmitTypeEquals() { }
        private System.Void EmitArrayLength() { }
        private System.Void EmitNegate(System.Type type) { }
        private System.Void EmitNegateChecked(System.Type type) { }
        private System.Void EmitIncrement(System.Type type) { }
        private System.Void EmitDecrement(System.Type type) { }
        private System.Void EmitTypeIs(System.Type type) { }
        private System.Void EmitTypeAs(System.Type type) { }
        private System.Void EmitLoadField(System.Reflection.FieldInfo field) { }
        private System.Linq.Expressions.Interpreter.Instruction GetLoadField(System.Reflection.FieldInfo field) { }
        private System.Void EmitStoreField(System.Reflection.FieldInfo field) { }
        private System.Void EmitCall(System.Reflection.MethodInfo method) { }
        private System.Void EmitCall(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters) { }
        private System.Void EmitByRefCall(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters, System.Linq.Expressions.Interpreter.ByRefUpdater[] byrefArgs) { }
        private System.Void EmitNullableCall(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters) { }
        private System.Linq.Expressions.Interpreter.RuntimeLabel[] BuildRuntimeLabels() { }
        private System.Linq.Expressions.Interpreter.BranchLabel MakeLabel() { }
        private System.Void FixupBranch(System.Int32 branchIndex, System.Int32 offset) { }
        private System.Int32 EnsureLabelIndex(System.Linq.Expressions.Interpreter.BranchLabel label) { }
        private System.Int32 MarkRuntimeLabel() { }
        private System.Void MarkLabel(System.Linq.Expressions.Interpreter.BranchLabel label) { }
        private System.Void EmitGoto(System.Linq.Expressions.Interpreter.BranchLabel label, System.Boolean hasResult, System.Boolean hasValue, System.Boolean labelTargetGetsValue) { }
        private System.Void EmitBranch(System.Linq.Expressions.Interpreter.OffsetInstruction instruction, System.Linq.Expressions.Interpreter.BranchLabel label) { }
        private System.Void EmitBranch(System.Linq.Expressions.Interpreter.BranchLabel label) { }
        private System.Void EmitBranch(System.Linq.Expressions.Interpreter.BranchLabel label, System.Boolean hasResult, System.Boolean hasValue) { }
        private System.Void EmitCoalescingBranch(System.Linq.Expressions.Interpreter.BranchLabel leftNotNull) { }
        private System.Void EmitBranchTrue(System.Linq.Expressions.Interpreter.BranchLabel elseLabel) { }
        private System.Void EmitBranchFalse(System.Linq.Expressions.Interpreter.BranchLabel elseLabel) { }
        private System.Void EmitThrow() { }
        private System.Void EmitThrowVoid() { }
        private System.Void EmitRethrow() { }
        private System.Void EmitRethrowVoid() { }
        private System.Void EmitEnterTryFinally(System.Linq.Expressions.Interpreter.BranchLabel finallyStartLabel) { }
        private System.Void EmitEnterTryCatch() { }
        private System.Linq.Expressions.Interpreter.EnterTryFaultInstruction EmitEnterTryFault(System.Linq.Expressions.Interpreter.BranchLabel tryEnd) { }
        private System.Void EmitEnterFinally(System.Linq.Expressions.Interpreter.BranchLabel finallyStartLabel) { }
        private System.Void EmitLeaveFinally() { }
        private System.Void EmitEnterFault(System.Linq.Expressions.Interpreter.BranchLabel faultStartLabel) { }
        private System.Void EmitLeaveFault() { }
        private System.Void EmitEnterExceptionFilter() { }
        private System.Void EmitLeaveExceptionFilter() { }
        private System.Void EmitEnterExceptionHandlerNonVoid() { }
        private System.Void EmitEnterExceptionHandlerVoid() { }
        private System.Void EmitLeaveExceptionHandler(System.Boolean hasValue, System.Linq.Expressions.Interpreter.BranchLabel tryExpressionEndLabel) { }
        private System.Void EmitIntSwitch(System.Collections.Generic.Dictionary<T,System.Int32> cases) { }
        private System.Void EmitStringSwitch(System.Collections.Generic.Dictionary<System.String,System.Int32> cases, System.Runtime.CompilerServices.StrongBox<System.Int32> nullCase) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000168
    public class InterpretedFrame
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.InterpretedFrame s_currentFrame;        // 0xFFFFFFFF
        private readonly System.Linq.Expressions.Interpreter.Interpreter Interpreter;        // 0x10
        private System.Linq.Expressions.Interpreter.InterpretedFrame _parent;        // 0x18
        private readonly System.Int32[] _continuations;        // 0x20
        private System.Int32 _continuationIndex;        // 0x28
        private System.Int32 _pendingContinuation;        // 0x2C
        private System.Object _pendingValue;        // 0x30
        public readonly System.Object[] Data;        // 0x38
        public readonly System.Runtime.CompilerServices.IStrongBox[] Closure;        // 0x40
        public System.Int32 StackIndex;        // 0x48
        public System.Int32 InstructionIndex;        // 0x4C

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Interpreter.Interpreter interpreter, System.Runtime.CompilerServices.IStrongBox[] closure) { }
        private System.Linq.Expressions.Interpreter.DebugInfo GetDebugInfo(System.Int32 instructionIndex) { }
        private System.String get_Name() { }
        private System.Void Push(System.Object value) { }
        private System.Void Push(System.Boolean value) { }
        private System.Void Push(System.Int32 value) { }
        private System.Void Push(System.Byte value) { }
        private System.Void Push(System.SByte value) { }
        private System.Void Push(System.Int16 value) { }
        private System.Void Push(System.UInt16 value) { }
        private System.Object Pop() { }
        private System.Void SetStackDepth(System.Int32 depth) { }
        private System.Object Peek() { }
        private System.Void Dup() { }
        private System.Linq.Expressions.Interpreter.InterpretedFrame get_Parent() { }
        private System.Collections.Generic.IEnumerable<System.Linq.Expressions.Interpreter.InterpretedFrameInfo> GetStackTraceDebugInfo() { }
        private System.Void SaveTraceToException(System.Exception exception) { }
        private System.Linq.Expressions.Interpreter.InterpretedFrame Enter() { }
        private System.Void Leave(System.Linq.Expressions.Interpreter.InterpretedFrame prevFrame) { }
        private System.Boolean IsJumpHappened() { }
        private System.Void RemoveContinuation() { }
        private System.Void PushContinuation(System.Int32 continuation) { }
        private System.Int32 YieldToCurrentContinuation() { }
        private System.Int32 YieldToPendingContinuation() { }
        private System.Void PushPendingContinuation() { }
        private System.Void PopPendingContinuation() { }
        private System.Int32 Goto(System.Int32 labelIndex, System.Object value, System.Boolean gotoExceptionHandler) { }

    }

    // TypeToken: 0x200016A
    public class Interpreter
    {
        // Fields
        private static readonly System.Object NoValue;        // 0x0
        private readonly System.Linq.Expressions.Interpreter.InstructionArray _instructions;        // 0x10
        private readonly System.Object[] _objects;        // 0x38
        private readonly System.Linq.Expressions.Interpreter.RuntimeLabel[] _labels;        // 0x40
        private readonly System.Linq.Expressions.Interpreter.DebugInfo[] _debugInfos;        // 0x48
        private readonly System.String <Name>k__BackingField;        // 0x50
        private readonly System.Int32 <LocalCount>k__BackingField;        // 0x58
        private readonly System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> <ClosureVariables>k__BackingField;        // 0x60

        // Methods
        private System.Void .ctor(System.String name, System.Linq.Expressions.Interpreter.LocalVariables locals, System.Linq.Expressions.Interpreter.InstructionArray instructions, System.Linq.Expressions.Interpreter.DebugInfo[] debugInfos) { }
        private System.String get_Name() { }
        private System.Int32 get_LocalCount() { }
        private System.Int32 get_ClosureSize() { }
        private System.Linq.Expressions.Interpreter.InstructionArray get_Instructions() { }
        private System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> get_ClosureVariables() { }
        private System.Void Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200016B
    public class LabelInfo
    {
        // Fields
        private readonly System.Linq.Expressions.LabelTarget _node;        // 0x10
        private System.Linq.Expressions.Interpreter.BranchLabel _label;        // 0x18
        private System.Object _definitions;        // 0x20
        private readonly System.Collections.Generic.List<System.Linq.Expressions.Interpreter.LabelScopeInfo> _references;        // 0x28
        private System.Boolean _acrossBlockJump;        // 0x30

        // Methods
        private System.Void .ctor(System.Linq.Expressions.LabelTarget node) { }
        private System.Linq.Expressions.Interpreter.BranchLabel GetLabel(System.Linq.Expressions.Interpreter.LightCompiler compiler) { }
        private System.Void Reference(System.Linq.Expressions.Interpreter.LabelScopeInfo block) { }
        private System.Void Define(System.Linq.Expressions.Interpreter.LabelScopeInfo block) { }
        private System.Void ValidateJump(System.Linq.Expressions.Interpreter.LabelScopeInfo reference) { }
        private System.Void ValidateFinish() { }
        private System.Void EnsureLabel(System.Linq.Expressions.Interpreter.LightCompiler compiler) { }
        private System.Boolean DefinedIn(System.Linq.Expressions.Interpreter.LabelScopeInfo scope) { }
        private System.Boolean get_HasDefinitions() { }
        private System.Linq.Expressions.Interpreter.LabelScopeInfo FirstDefinition() { }
        private System.Void AddDefinition(System.Linq.Expressions.Interpreter.LabelScopeInfo scope) { }
        private System.Boolean get_HasMultipleDefinitions() { }
        private T CommonNode(T first, T second, System.Func<T,T> parent) { }

    }

    // TypeToken: 0x200016D
    public struct LabelScopeKind
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Linq.Expressions.Interpreter.LabelScopeKind Statement;        // 0x0
        public static System.Linq.Expressions.Interpreter.LabelScopeKind Block;        // 0x0
        public static System.Linq.Expressions.Interpreter.LabelScopeKind Switch;        // 0x0
        public static System.Linq.Expressions.Interpreter.LabelScopeKind Lambda;        // 0x0
        public static System.Linq.Expressions.Interpreter.LabelScopeKind Try;        // 0x0
        public static System.Linq.Expressions.Interpreter.LabelScopeKind Catch;        // 0x0
        public static System.Linq.Expressions.Interpreter.LabelScopeKind Finally;        // 0x0
        public static System.Linq.Expressions.Interpreter.LabelScopeKind Filter;        // 0x0
        public static System.Linq.Expressions.Interpreter.LabelScopeKind Expression;        // 0x0

    }

    // TypeToken: 0x200016E
    public class LabelScopeInfo
    {
        // Fields
        private System.Linq.Expressions.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget,System.Linq.Expressions.Interpreter.LabelInfo> _labels;        // 0x10
        private readonly System.Linq.Expressions.Interpreter.LabelScopeKind Kind;        // 0x18
        private readonly System.Linq.Expressions.Interpreter.LabelScopeInfo Parent;        // 0x20

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Interpreter.LabelScopeInfo parent, System.Linq.Expressions.Interpreter.LabelScopeKind kind) { }
        private System.Boolean get_CanJumpInto() { }
        private System.Boolean ContainsTarget(System.Linq.Expressions.LabelTarget target) { }
        private System.Boolean TryGetLabelInfo(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Interpreter.LabelInfo& info) { }
        private System.Void AddLabelInfo(System.Linq.Expressions.LabelTarget target, System.Linq.Expressions.Interpreter.LabelInfo info) { }

    }

    // TypeToken: 0x200016F
    public class LeftShiftInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_SByte;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_Byte;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x38

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x2000178
    public class LessThanInstruction : Instruction
    {
        // Fields
        private readonly System.Object _nullValue;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_SByte;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Char;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_Byte;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x38
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x40
        private static System.Linq.Expressions.Interpreter.Instruction s_Single;        // 0x48
        private static System.Linq.Expressions.Interpreter.Instruction s_Double;        // 0x50
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSByte;        // 0x58
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt16;        // 0x60
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullChar;        // 0x68
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt32;        // 0x70
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt64;        // 0x78
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullByte;        // 0x80
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt16;        // 0x88
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt32;        // 0x90
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt64;        // 0x98
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSingle;        // 0xA0
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullDouble;        // 0xA8

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor(System.Object nullValue) { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type, System.Boolean liftedToNull) { }

    }

    // TypeToken: 0x2000184
    public class LessThanOrEqualInstruction : Instruction
    {
        // Fields
        private readonly System.Object _nullValue;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_SByte;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Char;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_Byte;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x38
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x40
        private static System.Linq.Expressions.Interpreter.Instruction s_Single;        // 0x48
        private static System.Linq.Expressions.Interpreter.Instruction s_Double;        // 0x50
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSByte;        // 0x58
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt16;        // 0x60
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullChar;        // 0x68
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt32;        // 0x70
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt64;        // 0x78
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullByte;        // 0x80
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt16;        // 0x88
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt32;        // 0x90
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt64;        // 0x98
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSingle;        // 0xA0
        private static System.Linq.Expressions.Interpreter.Instruction s_liftedToNullDouble;        // 0xA8

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor(System.Object nullValue) { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type, System.Boolean liftedToNull) { }

    }

    // TypeToken: 0x2000190
    public class ExceptionFilter
    {
        // Fields
        public readonly System.Int32 LabelIndex;        // 0x10
        public readonly System.Int32 StartIndex;        // 0x14
        public readonly System.Int32 EndIndex;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 labelIndex, System.Int32 start, System.Int32 end) { }

    }

    // TypeToken: 0x2000191
    public class ExceptionHandler
    {
        // Fields
        private readonly System.Type _exceptionType;        // 0x10
        public readonly System.Int32 LabelIndex;        // 0x18
        public readonly System.Int32 HandlerStartIndex;        // 0x1C
        public readonly System.Int32 HandlerEndIndex;        // 0x20
        public readonly System.Linq.Expressions.Interpreter.ExceptionFilter Filter;        // 0x28

        // Methods
        private System.Void .ctor(System.Int32 labelIndex, System.Int32 handlerStartIndex, System.Int32 handlerEndIndex, System.Type exceptionType, System.Linq.Expressions.Interpreter.ExceptionFilter filter) { }
        private System.Boolean Matches(System.Type exceptionType) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000192
    public class TryCatchFinallyHandler
    {
        // Fields
        private readonly System.Int32 TryStartIndex;        // 0x10
        private readonly System.Int32 TryEndIndex;        // 0x14
        private readonly System.Int32 FinallyStartIndex;        // 0x18
        private readonly System.Int32 FinallyEndIndex;        // 0x1C
        private readonly System.Int32 GotoEndTargetIndex;        // 0x20
        private readonly System.Linq.Expressions.Interpreter.ExceptionHandler[] _handlers;        // 0x28

        // Methods
        private System.Boolean get_IsFinallyBlockExist() { }
        private System.Linq.Expressions.Interpreter.ExceptionHandler[] get_Handlers() { }
        private System.Boolean get_IsCatchBlockExist() { }
        private System.Void .ctor(System.Int32 tryStart, System.Int32 tryEnd, System.Int32 gotoEndTargetIndex, System.Linq.Expressions.Interpreter.ExceptionHandler[] handlers) { }
        private System.Void .ctor(System.Int32 tryStart, System.Int32 tryEnd, System.Int32 gotoEndLabelIndex, System.Int32 finallyStart, System.Int32 finallyEnd, System.Linq.Expressions.Interpreter.ExceptionHandler[] handlers) { }
        private System.Boolean HasHandler(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Exception exception, System.Linq.Expressions.Interpreter.ExceptionHandler& handler, System.Object& unwrappedException) { }
        private System.Boolean FilterPasses(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Object& exception, System.Linq.Expressions.Interpreter.ExceptionFilter filter) { }

    }

    // TypeToken: 0x2000193
    public class TryFaultHandler
    {
        // Fields
        private readonly System.Int32 TryStartIndex;        // 0x10
        private readonly System.Int32 TryEndIndex;        // 0x14
        private readonly System.Int32 FinallyStartIndex;        // 0x18
        private readonly System.Int32 FinallyEndIndex;        // 0x1C

        // Methods
        private System.Void .ctor(System.Int32 tryStart, System.Int32 tryEnd, System.Int32 finallyStart, System.Int32 finallyEnd) { }

    }

    // TypeToken: 0x2000194
    public class RethrowException : Exception
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000195
    public class DebugInfo
    {
        // Fields
        public System.Int32 StartLine;        // 0x10
        public System.Int32 EndLine;        // 0x14
        public System.Int32 Index;        // 0x18
        public System.String FileName;        // 0x20
        public System.Boolean IsClear;        // 0x28
        private static readonly System.Linq.Expressions.Interpreter.DebugInfo.DebugInfoComparer s_debugComparer;        // 0x0

        // Methods
        private System.Linq.Expressions.Interpreter.DebugInfo GetMatchingDebugInfo(System.Linq.Expressions.Interpreter.DebugInfo[] debugInfos, System.Int32 index) { }
        private System.String ToString() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000197
    public struct InterpretedFrameInfo
    {
        // Fields
        private readonly System.String _methodName;        // 0x10
        private readonly System.Linq.Expressions.Interpreter.DebugInfo _debugInfo;        // 0x18

        // Methods
        private System.Void .ctor(System.String methodName, System.Linq.Expressions.Interpreter.DebugInfo info) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000198
    public class LightCompiler
    {
        // Fields
        private readonly System.Linq.Expressions.Interpreter.InstructionList _instructions;        // 0x10
        private readonly System.Linq.Expressions.Interpreter.LocalVariables _locals;        // 0x18
        private readonly System.Collections.Generic.List<System.Linq.Expressions.Interpreter.DebugInfo> _debugInfos;        // 0x20
        private readonly System.Linq.Expressions.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget,System.Linq.Expressions.Interpreter.LabelInfo> _treeLabels;        // 0x28
        private System.Linq.Expressions.Interpreter.LabelScopeInfo _labelBlock;        // 0x30
        private readonly System.Collections.Generic.Stack<System.Linq.Expressions.ParameterExpression> _exceptionForRethrowStack;        // 0x38
        private readonly System.Linq.Expressions.Interpreter.LightCompiler _parent;        // 0x40
        private readonly System.Linq.Expressions.StackGuard _guard;        // 0x48
        private static readonly System.Linq.Expressions.Interpreter.LocalDefinition[] s_emptyLocals;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Linq.Expressions.Interpreter.LightCompiler parent) { }
        private System.Linq.Expressions.Interpreter.InstructionList get_Instructions() { }
        private System.Linq.Expressions.Interpreter.LightDelegateCreator CompileTop(System.Linq.Expressions.LambdaExpression node) { }
        private System.Linq.Expressions.Interpreter.Interpreter MakeInterpreter(System.String lambdaName) { }
        private System.Void CompileConstantExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileDefaultExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileDefaultExpression(System.Type type) { }
        private System.Linq.Expressions.Interpreter.LocalVariable EnsureAvailableForClosure(System.Linq.Expressions.ParameterExpression expr) { }
        private System.Linq.Expressions.Interpreter.LocalVariable ResolveLocal(System.Linq.Expressions.ParameterExpression variable) { }
        private System.Void CompileGetVariable(System.Linq.Expressions.ParameterExpression variable) { }
        private System.Void EmitCopyValueType(System.Type valueType) { }
        private System.Void LoadLocalNoValueTypeCopy(System.Linq.Expressions.ParameterExpression variable) { }
        private System.Boolean MaybeMutableValueType(System.Type type) { }
        private System.Void CompileGetBoxedVariable(System.Linq.Expressions.ParameterExpression variable) { }
        private System.Void CompileSetVariable(System.Linq.Expressions.ParameterExpression variable, System.Boolean isVoid) { }
        private System.Void CompileParameterExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileBlockExpression(System.Linq.Expressions.Expression expr, System.Boolean asVoid) { }
        private System.Linq.Expressions.Interpreter.LocalDefinition[] CompileBlockStart(System.Linq.Expressions.BlockExpression node) { }
        private System.Void CompileBlockEnd(System.Linq.Expressions.Interpreter.LocalDefinition[] locals) { }
        private System.Void CompileIndexExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void EmitIndexGet(System.Linq.Expressions.IndexExpression index) { }
        private System.Void CompileIndexAssignment(System.Linq.Expressions.BinaryExpression node, System.Boolean asVoid) { }
        private System.Void CompileMemberAssignment(System.Linq.Expressions.BinaryExpression node, System.Boolean asVoid) { }
        private System.Void CompileMemberAssignment(System.Boolean asVoid, System.Reflection.MemberInfo refMember, System.Linq.Expressions.Expression value, System.Boolean forBinding) { }
        private System.Void CompileVariableAssignment(System.Linq.Expressions.BinaryExpression node, System.Boolean asVoid) { }
        private System.Void CompileAssignBinaryExpression(System.Linq.Expressions.Expression expr, System.Boolean asVoid) { }
        private System.Void CompileBinaryExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftedToNull) { }
        private System.Void CompileNotEqual(System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right, System.Boolean liftedToNull) { }
        private System.Void CompileComparison(System.Linq.Expressions.BinaryExpression node) { }
        private System.Void CompileArithmetic(System.Linq.Expressions.ExpressionType nodeType, System.Linq.Expressions.Expression left, System.Linq.Expressions.Expression right) { }
        private System.Void CompileConvertUnaryExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileConvertToType(System.Type typeFrom, System.Type typeTo, System.Boolean isChecked, System.Boolean isLiftedToNull) { }
        private System.Void CompileNotExpression(System.Linq.Expressions.UnaryExpression node) { }
        private System.Void CompileUnaryExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void EmitUnaryMethodCall(System.Linq.Expressions.UnaryExpression node) { }
        private System.Void EmitUnaryBoolCheck(System.Linq.Expressions.UnaryExpression node) { }
        private System.Void CompileAndAlsoBinaryExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileOrElseBinaryExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileLogicalBinaryExpression(System.Linq.Expressions.BinaryExpression b, System.Boolean andAlso) { }
        private System.Void CompileMethodLogicalBinaryExpression(System.Linq.Expressions.BinaryExpression expr, System.Boolean andAlso) { }
        private System.Void CompileLiftedLogicalBinaryExpression(System.Linq.Expressions.BinaryExpression node, System.Boolean andAlso) { }
        private System.Void CompileUnliftedLogicalBinaryExpression(System.Linq.Expressions.BinaryExpression expr, System.Boolean andAlso) { }
        private System.Void CompileConditionalExpression(System.Linq.Expressions.Expression expr, System.Boolean asVoid) { }
        private System.Void CompileLoopExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileSwitchExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileIntSwitchExpression(System.Linq.Expressions.SwitchExpression node) { }
        private System.Void CompileStringSwitchExpression(System.Linq.Expressions.SwitchExpression node) { }
        private System.Void CompileLabelExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileGotoExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void PushLabelBlock(System.Linq.Expressions.Interpreter.LabelScopeKind type) { }
        private System.Void PopLabelBlock(System.Linq.Expressions.Interpreter.LabelScopeKind kind) { }
        private System.Linq.Expressions.Interpreter.LabelInfo EnsureLabel(System.Linq.Expressions.LabelTarget node) { }
        private System.Linq.Expressions.Interpreter.LabelInfo ReferenceLabel(System.Linq.Expressions.LabelTarget node) { }
        private System.Linq.Expressions.Interpreter.LabelInfo DefineLabel(System.Linq.Expressions.LabelTarget node) { }
        private System.Boolean TryPushLabelBlock(System.Linq.Expressions.Expression node) { }
        private System.Void DefineBlockLabels(System.Linq.Expressions.Expression node) { }
        private System.Void CheckRethrow() { }
        private System.Void CompileThrowUnaryExpression(System.Linq.Expressions.Expression expr, System.Boolean asVoid) { }
        private System.Void CompileTryExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileTryFaultExpression(System.Linq.Expressions.TryExpression expr) { }
        private System.Void CompileMethodCallExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileMethodCallExpression(System.Linq.Expressions.Expression object, System.Reflection.MethodInfo method, System.Linq.Expressions.IArgumentProvider arguments) { }
        private System.Linq.Expressions.Interpreter.ByRefUpdater CompileArrayIndexAddress(System.Linq.Expressions.Expression array, System.Linq.Expressions.Expression index, System.Int32 argumentIndex) { }
        private System.Void EmitThisForMethodCall(System.Linq.Expressions.Expression node) { }
        private System.Boolean ShouldWritebackNode(System.Linq.Expressions.Expression node) { }
        private System.Linq.Expressions.Interpreter.ByRefUpdater CompileAddress(System.Linq.Expressions.Expression node, System.Int32 index) { }
        private System.Linq.Expressions.Interpreter.ByRefUpdater CompileMultiDimArrayAccess(System.Linq.Expressions.Expression array, System.Linq.Expressions.IArgumentProvider arguments, System.Int32 index) { }
        private System.Void CompileNewExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileMemberExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileMember(System.Linq.Expressions.Expression from, System.Reflection.MemberInfo member, System.Boolean forBinding) { }
        private System.Void CompileNewArrayExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileDebugInfoExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileRuntimeVariablesExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileLambdaExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileCoalesceBinaryExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileInvocationExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileListInitExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileListInit(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ElementInit> initializers) { }
        private System.Void CompileMemberInitExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileMemberInit(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.MemberBinding> bindings) { }
        private System.Type GetMemberType(System.Reflection.MemberInfo member) { }
        private System.Void CompileQuoteUnaryExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileUnboxUnaryExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileTypeEqualExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileTypeAsExpression(System.Linq.Expressions.UnaryExpression node) { }
        private System.Void CompileTypeIsExpression(System.Linq.Expressions.Expression expr) { }
        private System.Void Compile(System.Linq.Expressions.Expression expr, System.Boolean asVoid) { }
        private System.Void CompileAsVoid(System.Linq.Expressions.Expression expr) { }
        private System.Void CompileNoLabelPush(System.Linq.Expressions.Expression expr) { }
        private System.Void Compile(System.Linq.Expressions.Expression expr) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200019B
    public class ByRefUpdater
    {
        // Fields
        public readonly System.Int32 ArgumentIndex;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 argumentIndex) { }
        private System.Void Update(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Object value) { }
        private System.Void UndefineTemps(System.Linq.Expressions.Interpreter.InstructionList instructions, System.Linq.Expressions.Interpreter.LocalVariables locals) { }

    }

    // TypeToken: 0x200019C
    public class ParameterByRefUpdater : ByRefUpdater
    {
        // Fields
        private readonly System.Linq.Expressions.Interpreter.LocalVariable _parameter;        // 0x18

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Interpreter.LocalVariable parameter, System.Int32 argumentIndex) { }
        private System.Void Update(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Object value) { }

    }

    // TypeToken: 0x200019D
    public class ArrayByRefUpdater : ByRefUpdater
    {
        // Fields
        private readonly System.Linq.Expressions.Interpreter.LocalDefinition _array;        // 0x18
        private readonly System.Linq.Expressions.Interpreter.LocalDefinition _index;        // 0x28

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Interpreter.LocalDefinition array, System.Linq.Expressions.Interpreter.LocalDefinition index, System.Int32 argumentIndex) { }
        private System.Void Update(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Object value) { }
        private System.Void UndefineTemps(System.Linq.Expressions.Interpreter.InstructionList instructions, System.Linq.Expressions.Interpreter.LocalVariables locals) { }

    }

    // TypeToken: 0x200019E
    public class FieldByRefUpdater : ByRefUpdater
    {
        // Fields
        private readonly System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition> _object;        // 0x18
        private readonly System.Reflection.FieldInfo _field;        // 0x30

        // Methods
        private System.Void .ctor(System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition> obj, System.Reflection.FieldInfo field, System.Int32 argumentIndex) { }
        private System.Void Update(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Object value) { }
        private System.Void UndefineTemps(System.Linq.Expressions.Interpreter.InstructionList instructions, System.Linq.Expressions.Interpreter.LocalVariables locals) { }

    }

    // TypeToken: 0x200019F
    public class PropertyByRefUpdater : ByRefUpdater
    {
        // Fields
        private readonly System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition> _object;        // 0x18
        private readonly System.Reflection.PropertyInfo _property;        // 0x30

        // Methods
        private System.Void .ctor(System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition> obj, System.Reflection.PropertyInfo property, System.Int32 argumentIndex) { }
        private System.Void Update(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Object value) { }
        private System.Void UndefineTemps(System.Linq.Expressions.Interpreter.InstructionList instructions, System.Linq.Expressions.Interpreter.LocalVariables locals) { }

    }

    // TypeToken: 0x20001A0
    public class IndexMethodByRefUpdater : ByRefUpdater
    {
        // Fields
        private readonly System.Reflection.MethodInfo _indexer;        // 0x18
        private readonly System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition> _obj;        // 0x20
        private readonly System.Linq.Expressions.Interpreter.LocalDefinition[] _args;        // 0x38

        // Methods
        private System.Void .ctor(System.Nullable<System.Linq.Expressions.Interpreter.LocalDefinition> obj, System.Linq.Expressions.Interpreter.LocalDefinition[] args, System.Reflection.MethodInfo indexer, System.Int32 argumentIndex) { }
        private System.Void Update(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Object value) { }
        private System.Void UndefineTemps(System.Linq.Expressions.Interpreter.InstructionList instructions, System.Linq.Expressions.Interpreter.LocalVariables locals) { }

    }

    // TypeToken: 0x20001A1
    public class LightDelegateCreator
    {
        // Fields
        private readonly System.Linq.Expressions.LambdaExpression _lambda;        // 0x10
        private readonly System.Linq.Expressions.Interpreter.Interpreter <Interpreter>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Interpreter.Interpreter interpreter, System.Linq.Expressions.LambdaExpression lambda) { }
        private System.Linq.Expressions.Interpreter.Interpreter get_Interpreter() { }
        private System.Delegate CreateDelegate() { }
        private System.Delegate CreateDelegate(System.Runtime.CompilerServices.IStrongBox[] closure) { }

    }

    // TypeToken: 0x20001A2
    public class LightLambda
    {
        // Fields
        private readonly System.Runtime.CompilerServices.IStrongBox[] _closure;        // 0x10
        private readonly System.Linq.Expressions.Interpreter.Interpreter _interpreter;        // 0x18
        private static readonly System.Dynamic.Utils.CacheDict<System.Type,System.Func<System.Linq.Expressions.Interpreter.LightLambda,System.Delegate>> _runCache;        // 0x0
        private readonly System.Linq.Expressions.Interpreter.LightDelegateCreator _delegateCreator;        // 0x20

        // Methods
        private TRet Run0() { }
        private System.Void RunVoid0() { }
        private System.Delegate MakeRun0(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid0(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run1(T0 arg0) { }
        private System.Void RunVoid1(T0 arg0) { }
        private System.Delegate MakeRun1(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid1(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run2(T0 arg0, T1 arg1) { }
        private System.Void RunVoid2(T0 arg0, T1 arg1) { }
        private System.Delegate MakeRun2(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid2(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run3(T0 arg0, T1 arg1, T2 arg2) { }
        private System.Void RunVoid3(T0 arg0, T1 arg1, T2 arg2) { }
        private System.Delegate MakeRun3(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid3(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run4(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
        private System.Void RunVoid4(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
        private System.Delegate MakeRun4(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid4(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run5(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private System.Void RunVoid5(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
        private System.Delegate MakeRun5(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid5(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run6(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        private System.Void RunVoid6(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
        private System.Delegate MakeRun6(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid6(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run7(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        private System.Void RunVoid7(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
        private System.Delegate MakeRun7(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid7(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run8(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
        private System.Void RunVoid8(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
        private System.Delegate MakeRun8(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid8(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run9(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
        private System.Void RunVoid9(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
        private System.Delegate MakeRun9(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid9(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run10(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
        private System.Void RunVoid10(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
        private System.Delegate MakeRun10(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid10(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run11(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
        private System.Void RunVoid11(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
        private System.Delegate MakeRun11(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid11(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run12(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
        private System.Void RunVoid12(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
        private System.Delegate MakeRun12(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid12(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run13(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
        private System.Void RunVoid13(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
        private System.Delegate MakeRun13(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid13(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run14(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
        private System.Void RunVoid14(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
        private System.Delegate MakeRun14(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid14(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private TRet Run15(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
        private System.Void RunVoid15(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
        private System.Delegate MakeRun15(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Delegate MakeRunVoid15(System.Linq.Expressions.Interpreter.LightLambda lambda) { }
        private System.Void .ctor(System.Linq.Expressions.Interpreter.LightDelegateCreator delegateCreator, System.Runtime.CompilerServices.IStrongBox[] closure) { }
        private System.String get_DebugView() { }
        private System.Func<System.Linq.Expressions.Interpreter.LightLambda,System.Delegate> GetRunDelegateCtor(System.Type delegateType) { }
        private System.Func<System.Linq.Expressions.Interpreter.LightLambda,System.Delegate> MakeRunDelegateCtor(System.Type delegateType) { }
        private System.Delegate CreateCustomDelegate(System.Type delegateType) { }
        private System.Delegate MakeDelegate(System.Type delegateType) { }
        private System.Linq.Expressions.Interpreter.InterpretedFrame MakeFrame() { }
        private System.Void RunVoidRef2(T0& arg0, T1& arg1) { }
        private System.Object Run(System.Object[] arguments) { }
        private System.Object RunVoid(System.Object[] arguments) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001A5
    public interface IBoxableInstruction
    {
        // Methods
        private System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index) { }

    }

    // TypeToken: 0x20001A6
    public class LocalAccessInstruction : Instruction
    {
        // Fields
        private readonly System.Int32 _index;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.String ToDebugString(System.Int32 instructionIndex, System.Object cookie, System.Func<System.Int32,System.Int32> labelIndexer, System.Collections.Generic.IReadOnlyList<System.Object> objects) { }

    }

    // TypeToken: 0x20001A7
    public class LoadLocalInstruction : LocalAccessInstruction, IBoxableInstruction
    {
        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index) { }

    }

    // TypeToken: 0x20001A8
    public class LoadLocalBoxedInstruction : LocalAccessInstruction
    {
        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x20001A9
    public class LoadLocalFromClosureInstruction : LocalAccessInstruction
    {
        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x20001AA
    public class LoadLocalFromClosureBoxedInstruction : LocalAccessInstruction
    {
        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x20001AB
    public class AssignLocalInstruction : LocalAccessInstruction, IBoxableInstruction
    {
        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index) { }

    }

    // TypeToken: 0x20001AC
    public class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction
    {
        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.Int32 get_ConsumedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Linq.Expressions.Interpreter.Instruction BoxIfIndexMatches(System.Int32 index) { }

    }

    // TypeToken: 0x20001AD
    public class AssignLocalBoxedInstruction : LocalAccessInstruction
    {
        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x20001AE
    public class StoreLocalBoxedInstruction : LocalAccessInstruction
    {
        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.Int32 get_ConsumedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x20001AF
    public class AssignLocalToClosureInstruction : LocalAccessInstruction
    {
        // Methods
        private System.Void .ctor(System.Int32 index) { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x20001B0
    public class ValueTypeCopyInstruction : Instruction
    {
        // Fields
        public static readonly System.Linq.Expressions.Interpreter.ValueTypeCopyInstruction Instruction;        // 0x0

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x20001B1
    public class InitializeLocalInstruction : LocalAccessInstruction
    {
        // Methods
        private System.Void .ctor(System.Int32 index) { }

    }

    // TypeToken: 0x20001BA
    public class RuntimeVariablesInstruction : Instruction
    {
        // Fields
        private readonly System.Int32 _count;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 count) { }
        private System.Int32 get_ProducedStack() { }
        private System.Int32 get_ConsumedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x20001BB
    public class LocalVariable
    {
        // Fields
        public readonly System.Int32 Index;        // 0x10
        private System.Int32 _flags;        // 0x14

        // Methods
        private System.Boolean get_IsBoxed() { }
        private System.Void set_IsBoxed(System.Boolean value) { }
        private System.Boolean get_InClosure() { }
        private System.Void .ctor(System.Int32 index, System.Boolean closure) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20001BC
    public struct LocalDefinition
    {
        // Fields
        private readonly System.Int32 <Index>k__BackingField;        // 0x10
        private readonly System.Linq.Expressions.ParameterExpression <Parameter>k__BackingField;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 localIndex, System.Linq.Expressions.ParameterExpression parameter) { }
        private System.Int32 get_Index() { }
        private System.Linq.Expressions.ParameterExpression get_Parameter() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }

    }

    // TypeToken: 0x20001BD
    public class LocalVariables
    {
        // Fields
        private readonly System.Linq.Expressions.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariables.VariableScope> _variables;        // 0x10
        private System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> _closureVariables;        // 0x18
        private System.Int32 _localCount;        // 0x20
        private System.Int32 _maxLocalCount;        // 0x24

        // Methods
        private System.Linq.Expressions.Interpreter.LocalDefinition DefineLocal(System.Linq.Expressions.ParameterExpression variable, System.Int32 start) { }
        private System.Void UndefineLocal(System.Linq.Expressions.Interpreter.LocalDefinition definition, System.Int32 end) { }
        private System.Void Box(System.Linq.Expressions.ParameterExpression variable, System.Linq.Expressions.Interpreter.InstructionList instructions) { }
        private System.Int32 get_LocalCount() { }
        private System.Boolean TryGetLocalOrClosure(System.Linq.Expressions.ParameterExpression var, System.Linq.Expressions.Interpreter.LocalVariable& local) { }
        private System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> get_ClosureVariables() { }
        private System.Linq.Expressions.Interpreter.LocalVariable AddClosureVariable(System.Linq.Expressions.ParameterExpression variable) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20001BF
    public class ModuloInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_Single;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_Double;        // 0x38

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x20001C8
    public class MulInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_Single;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_Double;        // 0x38

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x20001D1
    public class MulOvfInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x28

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x20001D8
    public class NegateInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_Single;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_Double;        // 0x20

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x20001DE
    public class NegateCheckedInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x10

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x20001E2
    public class NewInstruction : Instruction
    {
        // Fields
        protected readonly System.Reflection.ConstructorInfo _constructor;        // 0x10
        protected readonly System.Int32 _argumentCount;        // 0x18

        // Methods
        private System.Void .ctor(System.Reflection.ConstructorInfo constructor, System.Int32 argumentCount) { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Object[] GetArgs(System.Linq.Expressions.Interpreter.InterpretedFrame frame, System.Int32 first) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x20001E3
    public class ByRefNewInstruction : NewInstruction
    {
        // Fields
        private readonly System.Linq.Expressions.Interpreter.ByRefUpdater[] _byrefArgs;        // 0x20

        // Methods
        private System.Void .ctor(System.Reflection.ConstructorInfo target, System.Int32 argumentCount, System.Linq.Expressions.Interpreter.ByRefUpdater[] byrefArgs) { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x20001E4
    public class NotEqualInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_reference;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Boolean;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_SByte;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_Char;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_Byte;        // 0x38
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x40
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x48
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x50
        private static System.Linq.Expressions.Interpreter.Instruction s_Single;        // 0x58
        private static System.Linq.Expressions.Interpreter.Instruction s_Double;        // 0x60
        private static System.Linq.Expressions.Interpreter.Instruction s_SByteLiftedToNull;        // 0x68
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16LiftedToNull;        // 0x70
        private static System.Linq.Expressions.Interpreter.Instruction s_CharLiftedToNull;        // 0x78
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32LiftedToNull;        // 0x80
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64LiftedToNull;        // 0x88
        private static System.Linq.Expressions.Interpreter.Instruction s_ByteLiftedToNull;        // 0x90
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16LiftedToNull;        // 0x98
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32LiftedToNull;        // 0xA0
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64LiftedToNull;        // 0xA8
        private static System.Linq.Expressions.Interpreter.Instruction s_SingleLiftedToNull;        // 0xB0
        private static System.Linq.Expressions.Interpreter.Instruction s_DoubleLiftedToNull;        // 0xB8

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type, System.Boolean liftedToNull) { }

    }

    // TypeToken: 0x20001FD
    public class NotInstruction : Instruction
    {
        // Fields
        public static System.Linq.Expressions.Interpreter.Instruction s_Boolean;        // 0x0
        public static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x8
        public static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x10
        public static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x18
        public static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x20
        public static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x28
        public static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x30
        public static System.Linq.Expressions.Interpreter.Instruction s_Byte;        // 0x38
        public static System.Linq.Expressions.Interpreter.Instruction s_SByte;        // 0x40

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x2000207
    public class NullCheckInstruction : Instruction
    {
        // Fields
        public static readonly System.Linq.Expressions.Interpreter.Instruction Instance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000208
    public class NumericConvertInstruction : Instruction
    {
        // Fields
        private readonly System.TypeCode _from;        // 0x10
        private readonly System.TypeCode _to;        // 0x14
        private readonly System.Boolean _isLiftedToNull;        // 0x18

        // Methods
        private System.Void .ctor(System.TypeCode from, System.TypeCode to, System.Boolean isLiftedToNull) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Object Convert(System.Object obj) { }
        private System.String get_InstructionName() { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String ToString() { }

    }

    // TypeToken: 0x200020C
    public class OrInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_SByte;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_Byte;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x38
        private static System.Linq.Expressions.Interpreter.Instruction s_Boolean;        // 0x40

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x2000216
    public class RightShiftInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_SByte;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_Byte;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x38

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x200021F
    public class RuntimeVariables, IRuntimeVariables
    {
        // Fields
        private readonly System.Runtime.CompilerServices.IStrongBox[] _boxes;        // 0x10

        // Methods
        private System.Void .ctor(System.Runtime.CompilerServices.IStrongBox[] boxes) { }
        private System.Runtime.CompilerServices.IRuntimeVariables Create(System.Runtime.CompilerServices.IStrongBox[] boxes) { }

    }

    // TypeToken: 0x2000220
    public class LoadObjectInstruction : Instruction
    {
        // Fields
        private readonly System.Object _value;        // 0x10

        // Methods
        private System.Void .ctor(System.Object value) { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000221
    public class LoadCachedObjectInstruction : Instruction
    {
        // Fields
        private readonly System.UInt32 _index;        // 0x10

        // Methods
        private System.Void .ctor(System.UInt32 index) { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.String ToDebugString(System.Int32 instructionIndex, System.Object cookie, System.Func<System.Int32,System.Int32> labelIndexer, System.Collections.Generic.IReadOnlyList<System.Object> objects) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000222
    public class PopInstruction : Instruction
    {
        // Fields
        private static readonly System.Linq.Expressions.Interpreter.PopInstruction Instance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_ConsumedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000223
    public class DupInstruction : Instruction
    {
        // Fields
        private static readonly System.Linq.Expressions.Interpreter.DupInstruction Instance;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000224
    public class SubInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x28
        private static System.Linq.Expressions.Interpreter.Instruction s_Single;        // 0x30
        private static System.Linq.Expressions.Interpreter.Instruction s_Double;        // 0x38

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x200022D
    public class SubOvfInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.Instruction s_Int16;        // 0x0
        private static System.Linq.Expressions.Interpreter.Instruction s_Int32;        // 0x8
        private static System.Linq.Expressions.Interpreter.Instruction s_Int64;        // 0x10
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt16;        // 0x18
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt32;        // 0x20
        private static System.Linq.Expressions.Interpreter.Instruction s_UInt64;        // 0x28

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type type) { }

    }

    // TypeToken: 0x2000234
    public class CreateDelegateInstruction : Instruction
    {
        // Fields
        private readonly System.Linq.Expressions.Interpreter.LightDelegateCreator _creator;        // 0x10

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Interpreter.LightDelegateCreator delegateCreator) { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000235
    public class TypeIsInstruction : Instruction
    {
        // Fields
        private readonly System.Type _type;        // 0x10

        // Methods
        private System.Void .ctor(System.Type type) { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000236
    public class TypeAsInstruction : Instruction
    {
        // Fields
        private readonly System.Type _type;        // 0x10

        // Methods
        private System.Void .ctor(System.Type type) { }
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000237
    public class TypeEqualsInstruction : Instruction
    {
        // Fields
        public static readonly System.Linq.Expressions.Interpreter.TypeEqualsInstruction Instance;        // 0x0

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000238
    public class NullableMethodCallInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_hasValue;        // 0x0
        private static System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_value;        // 0x8
        private static System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_equals;        // 0x10
        private static System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_getHashCode;        // 0x18
        private static System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_getValueOrDefault1;        // 0x20
        private static System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_toString;        // 0x28

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Void .ctor() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.String method, System.Int32 argCount, System.Reflection.MethodInfo mi) { }
        private System.Linq.Expressions.Interpreter.Instruction CreateGetValue() { }

    }

    // TypeToken: 0x2000240
    public class CastInstruction : Instruction
    {
        // Fields
        private static System.Linq.Expressions.Interpreter.CastInstruction s_Boolean;        // 0x0
        private static System.Linq.Expressions.Interpreter.CastInstruction s_Byte;        // 0x8
        private static System.Linq.Expressions.Interpreter.CastInstruction s_Char;        // 0x10
        private static System.Linq.Expressions.Interpreter.CastInstruction s_DateTime;        // 0x18
        private static System.Linq.Expressions.Interpreter.CastInstruction s_Decimal;        // 0x20
        private static System.Linq.Expressions.Interpreter.CastInstruction s_Double;        // 0x28
        private static System.Linq.Expressions.Interpreter.CastInstruction s_Int16;        // 0x30
        private static System.Linq.Expressions.Interpreter.CastInstruction s_Int32;        // 0x38
        private static System.Linq.Expressions.Interpreter.CastInstruction s_Int64;        // 0x40
        private static System.Linq.Expressions.Interpreter.CastInstruction s_SByte;        // 0x48
        private static System.Linq.Expressions.Interpreter.CastInstruction s_Single;        // 0x50
        private static System.Linq.Expressions.Interpreter.CastInstruction s_String;        // 0x58
        private static System.Linq.Expressions.Interpreter.CastInstruction s_UInt16;        // 0x60
        private static System.Linq.Expressions.Interpreter.CastInstruction s_UInt32;        // 0x68
        private static System.Linq.Expressions.Interpreter.CastInstruction s_UInt64;        // 0x70

        // Methods
        private System.Int32 get_ConsumedStack() { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Linq.Expressions.Interpreter.Instruction Create(System.Type t) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000245
    public class CastToEnumInstruction : CastInstruction
    {
        // Fields
        private readonly System.Type _t;        // 0x10

        // Methods
        private System.Void .ctor(System.Type t) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000246
    public class CastReferenceToEnumInstruction : CastInstruction
    {
        // Fields
        private readonly System.Type _t;        // 0x10

        // Methods
        private System.Void .ctor(System.Type t) { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000247
    public class QuoteInstruction : Instruction
    {
        // Fields
        private readonly System.Linq.Expressions.Expression _operand;        // 0x10
        private readonly System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> _hoistedVariables;        // 0x18

        // Methods
        private System.Void .ctor(System.Linq.Expressions.Expression operand, System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Interpreter.LocalVariable> hoistedVariables) { }
        private System.Int32 get_ProducedStack() { }
        private System.String get_InstructionName() { }
        private System.Int32 Run(System.Linq.Expressions.Interpreter.InterpretedFrame frame) { }

    }

    // TypeToken: 0x2000249
    public class DelegateHelpers
    {
        // Methods
        private System.Type MakeDelegate(System.Type[] types) { }

    }

    // TypeToken: 0x200024B
    public class ScriptingRuntimeHelpers
    {
        // Methods
        private System.Object Int32ToObject(System.Int32 i) { }
        private System.Object GetPrimitiveDefaultValue(System.Type type) { }

    }

    // TypeToken: 0x200024C
    public class ExceptionHelpers
    {
        // Methods
        private System.Void UnwrapAndRethrow(System.Reflection.TargetInvocationException exception) { }

    }

    // TypeToken: 0x200024D
    public class HybridReferenceDictionary`2
    {
        // Fields
        private System.Collections.Generic.KeyValuePair<TKey,TValue>[] _keysAndValues;        // 0x0
        private System.Collections.Generic.Dictionary<TKey,TValue> _dict;        // 0x0

        // Methods
        private System.Boolean TryGetValue(TKey key, TValue& value) { }
        private System.Void Remove(TKey key) { }
        private System.Boolean ContainsKey(TKey key) { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumeratorWorker() { }
        private TValue get_Item(TKey key) { }
        private System.Void set_Item(TKey key, TValue value) { }
        private System.Void .ctor() { }

    }

}

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x200024F
    public class RuntimeOps
    {
        // Methods
        private System.Boolean ExpandoTryGetValue(System.Dynamic.ExpandoObject expando, System.Object indexClass, System.Int32 index, System.String name, System.Boolean ignoreCase, System.Object& value) { }
        private System.Object ExpandoTrySetValue(System.Dynamic.ExpandoObject expando, System.Object indexClass, System.Int32 index, System.Object value, System.String name, System.Boolean ignoreCase) { }
        private System.Boolean ExpandoTryDeleteValue(System.Dynamic.ExpandoObject expando, System.Object indexClass, System.Int32 index, System.String name, System.Boolean ignoreCase) { }
        private System.Boolean ExpandoCheckVersion(System.Dynamic.ExpandoObject expando, System.Object version) { }
        private System.Void ExpandoPromoteClass(System.Dynamic.ExpandoObject expando, System.Object oldClass, System.Object newClass) { }

    }

    // TypeToken: 0x2000250
    public class CallSite
    {
        // Fields
        private readonly System.Runtime.CompilerServices.CallSiteBinder _binder;        // 0x10
        private System.Boolean _match;        // 0x18

        // Methods
        private System.Void .ctor(System.Runtime.CompilerServices.CallSiteBinder binder) { }
        private System.Runtime.CompilerServices.CallSiteBinder get_Binder() { }

    }

    // TypeToken: 0x2000251
    public class CallSite`1 : CallSite
    {
        // Fields
        public T Target;        // 0x0
        private T[] Rules;        // 0x0
        private static T s_cachedUpdate;        // 0x0
        private static T s_cachedNoMatch;        // 0x0

        // Methods
        private T get_Update() { }
        private System.Void .ctor(System.Runtime.CompilerServices.CallSiteBinder binder) { }
        private System.Void .ctor() { }
        private System.Runtime.CompilerServices.CallSite<T> CreateMatchMaker() { }
        private System.Runtime.CompilerServices.CallSite<T> Create(System.Runtime.CompilerServices.CallSiteBinder binder) { }
        private T GetUpdateDelegate() { }
        private T GetUpdateDelegate(T& addr) { }
        private System.Void AddRule(T newRule) { }
        private System.Void MoveRule(System.Int32 i) { }
        private T MakeUpdateDelegate() { }
        private T CreateCustomUpdateDelegate(System.Reflection.MethodInfo invoke) { }
        private T CreateCustomNoMatchDelegate(System.Reflection.MethodInfo invoke) { }
        private System.Linq.Expressions.Expression Convert(System.Linq.Expressions.Expression arg, System.Type type) { }

    }

    // TypeToken: 0x2000253
    public class CallSiteBinder
    {
        // Fields
        private System.Collections.Generic.Dictionary<System.Type,System.Object> Cache;        // 0x10
        private static readonly System.Linq.Expressions.LabelTarget <UpdateLabel>k__BackingField;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Linq.Expressions.LabelTarget get_UpdateLabel() { }
        private System.Linq.Expressions.Expression Bind(System.Object[] args, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression> parameters, System.Linq.Expressions.LabelTarget returnLabel) { }
        private T BindDelegate(System.Runtime.CompilerServices.CallSite<T> site, System.Object[] args) { }
        private T BindCore(System.Runtime.CompilerServices.CallSite<T> site, System.Object[] args) { }
        private System.Void CacheTarget(T target) { }
        private System.Linq.Expressions.Expression<T> Stitch(System.Linq.Expressions.Expression binding, System.Runtime.CompilerServices.CallSiteBinder.LambdaSignature<T> signature) { }
        private System.Runtime.CompilerServices.RuleCache<T> GetRuleCache() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000255
    public class CallSiteOps
    {
        // Methods
        private System.Runtime.CompilerServices.CallSite<T> CreateMatchmaker(System.Runtime.CompilerServices.CallSite<T> site) { }
        private System.Boolean SetNotMatched(System.Runtime.CompilerServices.CallSite site) { }
        private System.Boolean GetMatch(System.Runtime.CompilerServices.CallSite site) { }
        private System.Void ClearMatch(System.Runtime.CompilerServices.CallSite site) { }
        private System.Void AddRule(System.Runtime.CompilerServices.CallSite<T> site, T rule) { }
        private System.Void UpdateRules(System.Runtime.CompilerServices.CallSite<T> this, System.Int32 matched) { }
        private T[] GetRules(System.Runtime.CompilerServices.CallSite<T> site) { }
        private System.Runtime.CompilerServices.RuleCache<T> GetRuleCache(System.Runtime.CompilerServices.CallSite<T> site) { }
        private System.Void MoveRule(System.Runtime.CompilerServices.RuleCache<T> cache, T rule, System.Int32 i) { }
        private T[] GetCachedRules(System.Runtime.CompilerServices.RuleCache<T> cache) { }
        private T Bind(System.Runtime.CompilerServices.CallSiteBinder binder, System.Runtime.CompilerServices.CallSite<T> site, System.Object[] args) { }

    }

    // TypeToken: 0x2000256
    public interface IRuntimeVariables
    {
    }

    // TypeToken: 0x2000257
    public class ReadOnlyCollectionBuilder`1, IList`1, ICollection`1, IEnumerable`1, IEnumerable, IList, ICollection
    {
        // Fields
        private T[] _items;        // 0x0
        private System.Int32 _size;        // 0x0
        private System.Int32 _version;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(System.Int32 capacity) { }
        private System.Void set_Capacity(System.Int32 value) { }
        private System.Int32 get_Count() { }
        private System.Int32 IndexOf(T item) { }
        private System.Void Insert(System.Int32 index, T item) { }
        private System.Void RemoveAt(System.Int32 index) { }
        private T get_Item(System.Int32 index) { }
        private System.Void set_Item(System.Int32 index, T value) { }
        private System.Void Add(T item) { }
        private System.Void Clear() { }
        private System.Boolean Contains(T item) { }
        private System.Void CopyTo(T[] array, System.Int32 arrayIndex) { }
        private System.Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
        private System.Boolean Remove(T item) { }
        private System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
        private System.Boolean System.Collections.IList.get_IsReadOnly() { }
        private System.Int32 System.Collections.IList.Add(System.Object value) { }
        private System.Boolean System.Collections.IList.Contains(System.Object value) { }
        private System.Int32 System.Collections.IList.IndexOf(System.Object value) { }
        private System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value) { }
        private System.Boolean System.Collections.IList.get_IsFixedSize() { }
        private System.Void System.Collections.IList.Remove(System.Object value) { }
        private System.Object System.Collections.IList.get_Item(System.Int32 index) { }
        private System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value) { }
        private System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index) { }
        private System.Boolean System.Collections.ICollection.get_IsSynchronized() { }
        private System.Object System.Collections.ICollection.get_SyncRoot() { }
        private T[] ToArray() { }
        private System.Collections.ObjectModel.ReadOnlyCollection<T> ToReadOnlyCollection() { }
        private System.Void EnsureCapacity(System.Int32 min) { }
        private System.Boolean IsCompatibleObject(System.Object value) { }
        private System.Void ValidateNullValue(System.Object value, System.String argument) { }

    }

    // TypeToken: 0x2000259
    public class RuleCache`1
    {
        // Fields
        private T[] _rules;        // 0x0
        private readonly System.Object _cacheLock;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private T[] GetRules() { }
        private System.Void MoveRule(T rule, System.Int32 i) { }
        private System.Void AddRule(T newRule) { }
        private T[] AddOrInsert(T[] rules, T item) { }

    }

    // TypeToken: 0x200025A
    public class TrueReadOnlyCollection`1 : ReadOnlyCollection`1
    {
        // Methods
        private System.Void .ctor(T[] list) { }

    }

    // TypeToken: 0x200025B
    public class StrongBox`1, IStrongBox
    {
        // Fields
        public T Value;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .ctor(T value) { }
        private System.Object System.Runtime.CompilerServices.IStrongBox.get_Value() { }
        private System.Void System.Runtime.CompilerServices.IStrongBox.set_Value(System.Object value) { }

    }

    // TypeToken: 0x200025C
    public interface IStrongBox
    {
        // Methods
        private System.Object get_Value() { }
        private System.Void set_Value(System.Object value) { }

    }

}

namespace System.Security.Cryptography
{

    // TypeToken: 0x2000016
    public class AesManaged : Aes
    {
        // Fields
        private System.Security.Cryptography.RijndaelManaged m_rijndael;        // 0x48

        // Methods
        private System.Void .ctor() { }
        private System.Int32 get_FeedbackSize() { }
        private System.Byte[] get_IV() { }
        private System.Void set_IV(System.Byte[] value) { }
        private System.Byte[] get_Key() { }
        private System.Void set_Key(System.Byte[] value) { }
        private System.Int32 get_KeySize() { }
        private System.Void set_KeySize(System.Int32 value) { }
        private System.Security.Cryptography.CipherMode get_Mode() { }
        private System.Void set_Mode(System.Security.Cryptography.CipherMode value) { }
        private System.Security.Cryptography.PaddingMode get_Padding() { }
        private System.Void set_Padding(System.Security.Cryptography.PaddingMode value) { }
        private System.Security.Cryptography.ICryptoTransform CreateDecryptor() { }
        private System.Security.Cryptography.ICryptoTransform CreateDecryptor(System.Byte[] key, System.Byte[] iv) { }
        private System.Security.Cryptography.ICryptoTransform CreateEncryptor() { }
        private System.Security.Cryptography.ICryptoTransform CreateEncryptor(System.Byte[] key, System.Byte[] iv) { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void GenerateIV() { }
        private System.Void GenerateKey() { }

    }

    // TypeToken: 0x2000017
    public class AesCryptoServiceProvider : Aes
    {
        // Methods
        private System.Void .ctor() { }
        private System.Void GenerateIV() { }
        private System.Void GenerateKey() { }
        private System.Security.Cryptography.ICryptoTransform CreateDecryptor(System.Byte[] key, System.Byte[] iv) { }
        private System.Security.Cryptography.ICryptoTransform CreateEncryptor(System.Byte[] key, System.Byte[] iv) { }
        private System.Byte[] get_IV() { }
        private System.Void set_IV(System.Byte[] value) { }
        private System.Byte[] get_Key() { }
        private System.Void set_Key(System.Byte[] value) { }
        private System.Int32 get_KeySize() { }
        private System.Void set_KeySize(System.Int32 value) { }
        private System.Int32 get_FeedbackSize() { }
        private System.Security.Cryptography.CipherMode get_Mode() { }
        private System.Void set_Mode(System.Security.Cryptography.CipherMode value) { }
        private System.Security.Cryptography.PaddingMode get_Padding() { }
        private System.Void set_Padding(System.Security.Cryptography.PaddingMode value) { }
        private System.Security.Cryptography.ICryptoTransform CreateDecryptor() { }
        private System.Security.Cryptography.ICryptoTransform CreateEncryptor() { }
        private System.Void Dispose(System.Boolean disposing) { }

    }

    // TypeToken: 0x2000018
    public class AesTransform : SymmetricTransform
    {
        // Fields
        private System.UInt32[] expandedKey;        // 0x58
        private System.Int32 Nk;        // 0x60
        private System.Int32 Nr;        // 0x64
        private static readonly System.UInt32[] Rcon;        // 0x0
        private static readonly System.Byte[] SBox;        // 0x8
        private static readonly System.Byte[] iSBox;        // 0x10
        private static readonly System.UInt32[] T0;        // 0x18
        private static readonly System.UInt32[] T1;        // 0x20
        private static readonly System.UInt32[] T2;        // 0x28
        private static readonly System.UInt32[] T3;        // 0x30
        private static readonly System.UInt32[] iT0;        // 0x38
        private static readonly System.UInt32[] iT1;        // 0x40
        private static readonly System.UInt32[] iT2;        // 0x48
        private static readonly System.UInt32[] iT3;        // 0x50

        // Methods
        private System.Void .ctor(System.Security.Cryptography.Aes algo, System.Boolean encryption, System.Byte[] key, System.Byte[] iv) { }
        private System.Void ECB(System.Byte[] input, System.Byte[] output) { }
        private System.UInt32 SubByte(System.UInt32 a) { }
        private System.Void Encrypt128(System.Byte[] indata, System.Byte[] outdata, System.UInt32[] ekey) { }
        private System.Void Decrypt128(System.Byte[] indata, System.Byte[] outdata, System.UInt32[] ekey) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000019
    public class SHA256CryptoServiceProvider : SHA256
    {
        // Fields
        private static System.Byte[] Empty;        // 0x0
        private System.Security.Cryptography.SHA256 hash;        // 0x28

        // Methods
        private System.Void .ctor() { }
        private System.Void Initialize() { }
        private System.Void HashCore(System.Byte[] array, System.Int32 ibStart, System.Int32 cbSize) { }
        private System.Byte[] HashFinal() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Void .cctor() { }

    }

}

namespace System.Security.Cryptography.X509Certificates
{

    // TypeToken: 0x200001A
    public class RSACertificateExtensions
    {
        // Methods
        private System.Security.Cryptography.RSA GetRSAPublicKey(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }

    }

}

namespace System.Threading
{

    // TypeToken: 0x200029A
    public struct LockRecursionPolicy
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Threading.LockRecursionPolicy NoRecursion;        // 0x0
        public static System.Threading.LockRecursionPolicy SupportsRecursion;        // 0x0

    }

    // TypeToken: 0x200029B
    public class ReaderWriterCount
    {
        // Fields
        public System.Int64 lockID;        // 0x10
        public System.Int32 readercount;        // 0x18
        public System.Int32 writercount;        // 0x1C
        public System.Int32 upgradecount;        // 0x20
        public System.Threading.ReaderWriterCount next;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200029C
    public class ReaderWriterLockSlim, IDisposable
    {
        // Fields
        private System.Boolean fIsReentrant;        // 0x10
        private System.Int32 myLock;        // 0x14
        private System.UInt32 numWriteWaiters;        // 0x18
        private System.UInt32 numReadWaiters;        // 0x1C
        private System.UInt32 numWriteUpgradeWaiters;        // 0x20
        private System.UInt32 numUpgradeWaiters;        // 0x24
        private System.Boolean fNoWaiters;        // 0x28
        private System.Int32 upgradeLockOwnerId;        // 0x2C
        private System.Int32 writeLockOwnerId;        // 0x30
        private System.Threading.EventWaitHandle writeEvent;        // 0x38
        private System.Threading.EventWaitHandle readEvent;        // 0x40
        private System.Threading.EventWaitHandle upgradeEvent;        // 0x48
        private System.Threading.EventWaitHandle waitUpgradeEvent;        // 0x50
        private static System.Int64 s_nextLockID;        // 0x0
        private System.Int64 lockID;        // 0x58
        private static System.Threading.ReaderWriterCount t_rwc;        // 0xFFFFFFFF
        private System.Boolean fUpgradeThreadHoldingRead;        // 0x60
        private System.UInt32 owners;        // 0x64
        private System.Boolean fDisposed;        // 0x68

        // Methods
        private System.Void InitializeThreadCounts() { }
        private System.Void .ctor() { }
        private System.Void .ctor(System.Threading.LockRecursionPolicy recursionPolicy) { }
        private System.Boolean IsRWEntryEmpty(System.Threading.ReaderWriterCount rwc) { }
        private System.Boolean IsRwHashEntryChanged(System.Threading.ReaderWriterCount lrwc) { }
        private System.Threading.ReaderWriterCount GetThreadRWCount(System.Boolean dontAllocate) { }
        private System.Void EnterWriteLock() { }
        private System.Boolean TryEnterWriteLock(System.Int32 millisecondsTimeout) { }
        private System.Boolean TryEnterWriteLock(System.Threading.ReaderWriterLockSlim.TimeoutTracker timeout) { }
        private System.Boolean TryEnterWriteLockCore(System.Threading.ReaderWriterLockSlim.TimeoutTracker timeout) { }
        private System.Void EnterUpgradeableReadLock() { }
        private System.Boolean TryEnterUpgradeableReadLock(System.Int32 millisecondsTimeout) { }
        private System.Boolean TryEnterUpgradeableReadLock(System.Threading.ReaderWriterLockSlim.TimeoutTracker timeout) { }
        private System.Boolean TryEnterUpgradeableReadLockCore(System.Threading.ReaderWriterLockSlim.TimeoutTracker timeout) { }
        private System.Void ExitWriteLock() { }
        private System.Void ExitUpgradeableReadLock() { }
        private System.Void LazyCreateEvent(System.Threading.EventWaitHandle& waitEvent, System.Boolean makeAutoResetEvent) { }
        private System.Boolean WaitOnEvent(System.Threading.EventWaitHandle waitEvent, System.UInt32& numWaiters, System.Threading.ReaderWriterLockSlim.TimeoutTracker timeout, System.Boolean isWriteWaiter) { }
        private System.Void ExitAndWakeUpAppropriateWaiters() { }
        private System.Void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }
        private System.Void ExitAndWakeUpAppropriateReadWaiters() { }
        private System.Boolean IsWriterAcquired() { }
        private System.Void SetWriterAcquired() { }
        private System.Void ClearWriterAcquired() { }
        private System.Void SetWritersWaiting() { }
        private System.Void ClearWritersWaiting() { }
        private System.Void SetUpgraderWaiting() { }
        private System.Void ClearUpgraderWaiting() { }
        private System.UInt32 GetNumReaders() { }
        private System.Void EnterMyLock() { }
        private System.Void EnterMyLockSpin() { }
        private System.Void ExitMyLock() { }
        private System.Void SpinWait(System.Int32 SpinCount) { }
        private System.Void Dispose() { }
        private System.Void Dispose(System.Boolean disposing) { }
        private System.Boolean get_IsReadLockHeld() { }
        private System.Boolean get_IsUpgradeableReadLockHeld() { }
        private System.Boolean get_IsWriteLockHeld() { }
        private System.Int32 get_RecursiveReadCount() { }
        private System.Int32 get_RecursiveUpgradeCount() { }
        private System.Int32 get_RecursiveWriteCount() { }
        private System.Int32 get_WaitingReadCount() { }
        private System.Int32 get_WaitingUpgradeCount() { }
        private System.Int32 get_WaitingWriteCount() { }

    }

}

