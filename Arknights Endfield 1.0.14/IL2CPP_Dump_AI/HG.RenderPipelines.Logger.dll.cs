// ========================================================
// Dumped by @desirepro
// Assembly: HG.RenderPipelines.Logger.dll
// Classes:  4
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: HG.Rendering.HGRPLogger
TYPE:  class
TOKEN: 0x2000002
FIELDS:
METHODS:
  System.Void LogWarning(System.String message)
  System.Void LogWarning(System.String message, T param1)
  System.Void LogWarning(UnityEngine.Object context, System.String message)
  System.Void LogError(System.String message)
  System.Void LogError(System.String message, T param1)
  System.Void LogError(System.String message, T1 param1, T2 param2)
  System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3, T4 param4)
  System.Void LogCritical(System.String message)
  System.Void LogCritical(System.String message, T param1)
  System.Void LogCritical(System.String message, T1 param1, T2 param2)
  System.Void LogException(System.Exception e)
  System.Void LogImportant(System.String message)
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000003
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void __Gen_Wrap_0(System.Object P0)
  System.Void __Gen_Wrap_1(System.Object P0, System.Object P1)
  System.Void .cctor()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000004
FIELDS:
METHODS:
  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  System.Boolean IsPatched(System.Int32 id)
END_CLASS

