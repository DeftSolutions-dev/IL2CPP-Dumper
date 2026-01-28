// ========================================================
// Dumped by @desirepro
// Assembly: System.Configuration.dll
// Classes:  10
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: System.Configuration.ConfigurationElement
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.Configuration.ConfigurationPropertyCollection get_Properties()
  System.Boolean IsModified()
  System.Void Reset(System.Configuration.ConfigurationElement parentElement)
  System.Void ResetModified()
END_CLASS

CLASS: System.Configuration.ConfigurationSection
TYPE:  class
TOKEN: 0x2000003
EXTENDS: ConfigurationElement
FIELDS:
METHODS:
  System.Void DeserializeSection(System.Xml.XmlReader reader)
  System.Boolean IsModified()
  System.Void ResetModified()
  System.String SerializeSection(System.Configuration.ConfigurationElement parentElement, System.String name, System.Configuration.ConfigurationSaveMode saveMode)
END_CLASS

CLASS: System.Configuration.ConfigurationSaveMode
TYPE:  struct
TOKEN: 0x2000004
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  System.Configuration.ConfigurationSaveModeFull  // 0x0
  public    static  System.Configuration.ConfigurationSaveModeMinimal  // 0x0
  public    static  System.Configuration.ConfigurationSaveModeModified  // 0x0
METHODS:
END_CLASS

CLASS: System.Configuration.ConfigurationPropertyCollection
TYPE:  class
TOKEN: 0x2000005
FIELDS:
METHODS:
END_CLASS

CLASS: System.Configuration.ConfigurationElementCollection
TYPE:  class
TOKEN: 0x2000006
EXTENDS: ConfigurationElement
FIELDS:
METHODS:
END_CLASS

CLASS: System.Configuration.ConfigurationCollectionAttribute
TYPE:  class
TOKEN: 0x2000007
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor(System.Type itemType)
END_CLASS

CLASS: System.Configuration.ConfigurationSectionGroup
TYPE:  class
TOKEN: 0x2000008
FIELDS:
METHODS:
END_CLASS

CLASS: System.Configuration.IgnoreSection
TYPE:  class
TOKEN: 0x2000009
EXTENDS: ConfigurationSection
FIELDS:
METHODS:
  System.Void .ctor()
  System.Configuration.ConfigurationPropertyCollection get_Properties()
  System.Void DeserializeSection(System.Xml.XmlReader xmlReader)
  System.Boolean IsModified()
  System.Void Reset(System.Configuration.ConfigurationElement parentSection)
  System.Void ResetModified()
  System.String SerializeSection(System.Configuration.ConfigurationElement parentSection, System.String name, System.Configuration.ConfigurationSaveMode saveMode)
END_CLASS

CLASS: Unity.ThrowStub
TYPE:  class
TOKEN: 0x200000A
EXTENDS: ObjectDisposedException
FIELDS:
METHODS:
  System.Void ThrowNotSupportedException()
END_CLASS

