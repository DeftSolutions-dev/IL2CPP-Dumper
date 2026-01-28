// ========================================================
// Dumped by @desirepro
// Assembly: VFSEditor.dll
// Classes:  7
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000003
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class DataNAttribute : Attribute
    {
        // Fields
        public System.Int32 capacity;        // 0x10
        public System.Int32 tSize;        // 0x14
        public System.Boolean ring;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace Beyond.VFS.Editor
{

    // TypeToken: 0x2000007
    public class VFSEditorUnsafeUtils
    {
        // Methods
        private System.Void TryGetBundleDeps(Beyond.ManifestBinary.ManifestDataBinary manifestDataBinary, Beyond.ManifestBinary.ManifestDataBinary.Bundle bundle, System.Collections.Generic.List<Beyond.ManifestBinary.ManifestDataBinary.Bundle>& bundles) { }
        private System.Void TryGetBundleDirectDeps(Beyond.ManifestBinary.ManifestDataBinary manifestDataBinary, Beyond.ManifestBinary.ManifestDataBinary.Bundle bundle, System.Collections.Generic.List<Beyond.ManifestBinary.ManifestDataBinary.Bundle>& bundles) { }
        private System.Void TryGetBundleDirectReverseDeps(Beyond.ManifestBinary.ManifestDataBinary manifestDataBinary, Beyond.ManifestBinary.ManifestDataBinary.Bundle bundle, System.Collections.Generic.List<Beyond.ManifestBinary.ManifestDataBinary.Bundle>& bundles) { }
        private System.Void _TryGetBundleDeps(Beyond.ManifestBinary.ManifestDataBinary manifestDataBinary, Beyond.ManifestBinary.ManifestDataBinary.Bundle bundle, System.Collections.Generic.List<Beyond.ManifestBinary.ManifestDataBinary.Bundle>& bundles) { }
        private System.String GetLogBundleName(Beyond.ManifestBinary.RuntimeManifestBinary manifestBinary, Beyond.ManifestBinary.ManifestDataBinary.Bundle bundle) { }
        private System.String GetLogAssetPath(Beyond.ManifestBinary.RuntimeManifestBinary manifestBinary, Beyond.ManifestBinary.ManifestDataBinary.AssetInfo asset) { }
        private System.Void .ctor() { }

    }

}

namespace HG.Rendering.Runtime
{

    // TypeToken: 0x2000002
    public class HGConstantBufferLayoutAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

