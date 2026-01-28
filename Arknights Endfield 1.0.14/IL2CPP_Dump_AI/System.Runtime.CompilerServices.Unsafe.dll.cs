// ========================================================
// Dumped by @desirepro
// Assembly: System.Runtime.CompilerServices.Unsafe.dll
// Classes:  4
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: System.Runtime.CompilerServices.Unsafe
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  T ReadUnaligned(System.Byte& source)
  System.Void WriteUnaligned(System.Byte& destination, T value)
  System.Int32 SizeOf()
  System.Void CopyBlockUnaligned(System.Byte& destination, System.Byte& source, System.UInt32 byteCount)
  T As(System.Object o)
  T& AsRef(System.Void* source)
  T& AsRef(T& source)
  TTo& As(TFrom& source)
  T& Add(T& source, System.Int32 elementOffset)
  T& AddByteOffset(T& source, System.IntPtr byteOffset)
END_CLASS

CLASS: System.Runtime.CompilerServices.IsReadOnlyAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.Versioning.NonVersionableAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

