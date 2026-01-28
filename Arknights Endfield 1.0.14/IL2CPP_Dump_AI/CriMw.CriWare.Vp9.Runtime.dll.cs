// ========================================================
// Dumped by @desirepro
// Assembly: CriMw.CriWare.Vp9.Runtime.dll
// Classes:  7
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000005
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000006
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: CriWare.CriManaVp9
TYPE:  class
TOKEN: 0x2000007
FIELDS:
  private   static  System.String                   scriptVersionString  // 0x0
  public    static  System.String                   cri_mana_vp9_name  // 0x0
METHODS:
  System.Boolean SupportCurrentPlatform()
  System.Void SetupVp9Decoder()
  System.IntPtr criWareUnity_GetAllocateFunc()
  System.IntPtr criWareUnity_GetDeallocateFunc()
  System.IntPtr criManaUnity_GetAllocatorManager()
  System.Void criMvPly_AttachCodecInterface(System.Int32 codec_type, System.IntPtr codec_if, System.IntPtr codecalpha_if)
  System.Void criVvp9_SetUserAllocator(System.IntPtr alloc_func, System.IntPtr free_func, System.IntPtr usr_obj)
  System.IntPtr criVvp9_GetInterface()
  System.IntPtr criVvp9_GetAlphaInterface()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

