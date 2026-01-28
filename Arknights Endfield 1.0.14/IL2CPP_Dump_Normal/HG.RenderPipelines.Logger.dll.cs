// ========================================================
// Dumped by @desirepro
// Assembly: HG.RenderPipelines.Logger.dll
// Classes:  4
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace HG.Rendering
{

    // TypeToken: 0x2000002
    public class HGRPLogger
    {
        // Methods
        private System.Void LogWarning(System.String message) { }
        private System.Void LogWarning(System.String message, T param1) { }
        private System.Void LogWarning(UnityEngine.Object context, System.String message) { }
        private System.Void LogError(System.String message) { }
        private System.Void LogError(System.String message, T param1) { }
        private System.Void LogError(System.String message, T1 param1, T2 param2) { }
        private System.Void LogError(System.String message, T1 param1, T2 param2, T3 param3, T4 param4) { }
        private System.Void LogCritical(System.String message) { }
        private System.Void LogCritical(System.String message, T param1) { }
        private System.Void LogCritical(System.String message, T1 param1, T2 param2) { }
        private System.Void LogException(System.Exception e) { }
        private System.Void LogImportant(System.String message) { }

    }

}

namespace IFix
{

    // TypeToken: 0x2000003
    public class ILFixDynamicMethodWrapper
    {
        // Fields
        private IFix.Core.VirtualMachine virtualMachine;        // 0x10
        private System.Int32 methodId;        // 0x18
        private System.Object anonObj;        // 0x20
        public static IFix.ILFixDynamicMethodWrapper[] wrapperArray;        // 0x0

        // Methods
        private System.Void __Gen_Wrap_0(System.Object P0) { }
        private System.Void __Gen_Wrap_1(System.Object P0, System.Object P1) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000004
    public class WrappersManagerImpl
    {
        // Methods
        private IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id) { }
        private System.Boolean IsPatched(System.Int32 id) { }

    }

}

