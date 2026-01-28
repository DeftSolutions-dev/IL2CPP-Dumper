// ========================================================
// Dumped by @desirepro
// Assembly: System.Runtime.CompilerServices.Unsafe.dll
// Classes:  4
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{

    // TypeToken: 0x2000002
    public class Unsafe
    {
        // Methods
        private T ReadUnaligned(System.Byte& source) { }
        private System.Void WriteUnaligned(System.Byte& destination, T value) { }
        private System.Int32 SizeOf() { }
        private System.Void CopyBlockUnaligned(System.Byte& destination, System.Byte& source, System.UInt32 byteCount) { }
        private T As(System.Object o) { }
        private T& AsRef(System.Void* source) { }
        private T& AsRef(T& source) { }
        private TTo& As(TFrom& source) { }
        private T& Add(T& source, System.Int32 elementOffset) { }
        private T& AddByteOffset(T& source, System.IntPtr byteOffset) { }

    }

    // TypeToken: 0x2000004
    public class IsReadOnlyAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace System.Runtime.Versioning
{

    // TypeToken: 0x2000003
    public class NonVersionableAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

