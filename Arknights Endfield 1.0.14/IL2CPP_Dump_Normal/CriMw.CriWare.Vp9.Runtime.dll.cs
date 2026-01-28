// ========================================================
// Dumped by @desirepro
// Assembly: CriMw.CriWare.Vp9.Runtime.dll
// Classes:  7
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace Beyond.SourceGenerator
{

    // TypeToken: 0x2000003
    public class AnimatorBlackboardAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class DataNAttribute : Attribute
    {
        // Fields
        public System.Int32 capacity;        // 0x10
        public System.Int32 tSize;        // 0x14
        public System.Boolean ring;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class ECSComponentAttribute : Attribute
    {
        // Fields
        public System.Runtime.InteropServices.LayoutKind layoutKind;        // 0x10
        public System.Boolean isTag;        // 0x14

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class CameraControlConfigAttribute : Attribute
    {
        // Methods
        private System.Void .ctor() { }

    }

}

namespace CriWare
{

    // TypeToken: 0x2000007
    public class CriManaVp9
    {
        // Fields
        private static System.String scriptVersionString;        // 0x0
        public static System.String cri_mana_vp9_name;        // 0x0

        // Methods
        private System.Boolean SupportCurrentPlatform() { }
        private System.Void SetupVp9Decoder() { }
        private System.IntPtr criWareUnity_GetAllocateFunc() { }
        private System.IntPtr criWareUnity_GetDeallocateFunc() { }
        private System.IntPtr criManaUnity_GetAllocatorManager() { }
        private System.Void criMvPly_AttachCodecInterface(System.Int32 codec_type, System.IntPtr codec_if, System.IntPtr codecalpha_if) { }
        private System.Void criVvp9_SetUserAllocator(System.IntPtr alloc_func, System.IntPtr free_func, System.IntPtr usr_obj) { }
        private System.IntPtr criVvp9_GetInterface() { }
        private System.IntPtr criVvp9_GetAlphaInterface() { }

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

