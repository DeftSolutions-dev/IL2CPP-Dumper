// ========================================================
// Dumped by @desirepro
// Assembly: VFSEditor.dll
// Classes:  7
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000006
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.VFS.Editor.VFSEditorUnsafeUtils
TYPE:  class
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.Void TryGetBundleDeps(Beyond.ManifestBinary.ManifestDataBinary manifestDataBinary, Beyond.ManifestBinary.ManifestDataBinary.Bundle bundle, System.Collections.Generic.List<Beyond.ManifestBinary.ManifestDataBinary.Bundle>& bundles)
  System.Void TryGetBundleDirectDeps(Beyond.ManifestBinary.ManifestDataBinary manifestDataBinary, Beyond.ManifestBinary.ManifestDataBinary.Bundle bundle, System.Collections.Generic.List<Beyond.ManifestBinary.ManifestDataBinary.Bundle>& bundles)
  System.Void TryGetBundleDirectReverseDeps(Beyond.ManifestBinary.ManifestDataBinary manifestDataBinary, Beyond.ManifestBinary.ManifestDataBinary.Bundle bundle, System.Collections.Generic.List<Beyond.ManifestBinary.ManifestDataBinary.Bundle>& bundles)
  System.Void _TryGetBundleDeps(Beyond.ManifestBinary.ManifestDataBinary manifestDataBinary, Beyond.ManifestBinary.ManifestDataBinary.Bundle bundle, System.Collections.Generic.List<Beyond.ManifestBinary.ManifestDataBinary.Bundle>& bundles)
  System.String GetLogBundleName(Beyond.ManifestBinary.RuntimeManifestBinary manifestBinary, Beyond.ManifestBinary.ManifestDataBinary.Bundle bundle)
  System.String GetLogAssetPath(Beyond.ManifestBinary.RuntimeManifestBinary manifestBinary, Beyond.ManifestBinary.ManifestDataBinary.AssetInfo asset)
  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

