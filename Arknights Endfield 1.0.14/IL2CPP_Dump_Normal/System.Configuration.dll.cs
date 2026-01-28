// ========================================================
// Dumped by @desirepro
// Assembly: System.Configuration.dll
// Classes:  10
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace System.Configuration
{

    // TypeToken: 0x2000002
    public class ConfigurationElement
    {
        // Methods
        private System.Configuration.ConfigurationPropertyCollection get_Properties() { }
        private System.Boolean IsModified() { }
        private System.Void Reset(System.Configuration.ConfigurationElement parentElement) { }
        private System.Void ResetModified() { }

    }

    // TypeToken: 0x2000003
    public class ConfigurationSection : ConfigurationElement
    {
        // Methods
        private System.Void DeserializeSection(System.Xml.XmlReader reader) { }
        private System.Boolean IsModified() { }
        private System.Void ResetModified() { }
        private System.String SerializeSection(System.Configuration.ConfigurationElement parentElement, System.String name, System.Configuration.ConfigurationSaveMode saveMode) { }

    }

    // TypeToken: 0x2000004
    public struct ConfigurationSaveMode
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static System.Configuration.ConfigurationSaveMode Full;        // 0x0
        public static System.Configuration.ConfigurationSaveMode Minimal;        // 0x0
        public static System.Configuration.ConfigurationSaveMode Modified;        // 0x0

    }

    // TypeToken: 0x2000005
    public class ConfigurationPropertyCollection
    {
    }

    // TypeToken: 0x2000006
    public class ConfigurationElementCollection : ConfigurationElement
    {
    }

    // TypeToken: 0x2000007
    public class ConfigurationCollectionAttribute : Attribute
    {
        // Methods
        private System.Void .ctor(System.Type itemType) { }

    }

    // TypeToken: 0x2000008
    public class ConfigurationSectionGroup
    {
    }

    // TypeToken: 0x2000009
    public class IgnoreSection : ConfigurationSection
    {
        // Methods
        private System.Void .ctor() { }
        private System.Configuration.ConfigurationPropertyCollection get_Properties() { }
        private System.Void DeserializeSection(System.Xml.XmlReader xmlReader) { }
        private System.Boolean IsModified() { }
        private System.Void Reset(System.Configuration.ConfigurationElement parentSection) { }
        private System.Void ResetModified() { }
        private System.String SerializeSection(System.Configuration.ConfigurationElement parentSection, System.String name, System.Configuration.ConfigurationSaveMode saveMode) { }

    }

}

namespace Unity
{

    // TypeToken: 0x200000A
    public class ThrowStub : ObjectDisposedException
    {
        // Methods
        private System.Void ThrowNotSupportedException() { }

    }

}

