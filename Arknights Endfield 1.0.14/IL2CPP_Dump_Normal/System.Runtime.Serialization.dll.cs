// ========================================================
// Dumped by @desirepro
// Assembly: System.Runtime.Serialization.dll
// Classes:  5
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace System.Runtime.Serialization
{

    // TypeToken: 0x2000002
    public class DataContractAttribute : Attribute
    {
        // Fields
        private System.Boolean isReference;        // 0x10

        // Methods
        private System.Boolean get_IsReference() { }

    }

    // TypeToken: 0x2000003
    public class DataMemberAttribute : Attribute
    {
        // Fields
        private System.String name;        // 0x10
        private System.Int32 order;        // 0x18
        private System.Boolean isRequired;        // 0x1C
        private System.Boolean emitDefaultValue;        // 0x1D

        // Methods
        private System.String get_Name() { }
        private System.Int32 get_Order() { }
        private System.Boolean get_IsRequired() { }
        private System.Boolean get_EmitDefaultValue() { }

    }

    // TypeToken: 0x2000004
    public class EnumMemberAttribute : Attribute
    {
        // Fields
        private System.String value;        // 0x10

        // Methods
        private System.Void .ctor() { }
        private System.String get_Value() { }

    }

    // TypeToken: 0x2000005
    public class IgnoreDataMemberAttribute : Attribute
    {
    }

}

