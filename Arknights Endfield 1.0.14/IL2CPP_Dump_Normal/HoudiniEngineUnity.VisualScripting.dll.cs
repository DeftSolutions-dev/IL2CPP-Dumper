// ========================================================
// Dumped by @desirepro
// Assembly: HoudiniEngineUnity.VisualScripting.dll
// Classes:  7
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

namespace HoudiniEngineUnity
{

    // TypeToken: 0x2000002
    public class HEU_InstantiateHDA : ManualEventUnit`1
    {
        // Fields
        public HoudiniEngineUnity.HEU_UnitButton triggerButton;        // 0x80
        public Unity.VisualScripting.ValueInput inputPath;        // 0x88
        public Unity.VisualScripting.ValueInput inputAsync;        // 0x90
        public Unity.VisualScripting.ValueInput inputPosition;        // 0x98
        public Unity.VisualScripting.ValueOutput outputHDARoot;        // 0xA0
        public Unity.VisualScripting.ValueOutput outputHDAAsset;        // 0xA8
        public Unity.VisualScripting.ValueOutput outputSuccess;        // 0xB0
        private HoudiniEngineUnity.HEU_HoudiniAssetRoot hdaRoot;        // 0xB8
        private HoudiniEngineUnity.HEU_HoudiniAsset hdaAsset;        // 0xC0
        private System.Boolean bSuccess;        // 0xC8

        // Methods
        private System.String get_hookName() { }
        private System.Void Definition() { }
        private System.Void TriggerButton(Unity.VisualScripting.GraphReference reference) { }
        private System.Void .ctor() { }
        private HoudiniEngineUnity.HEU_HoudiniAssetRoot <Definition>b__12_0(Unity.VisualScripting.Flow flow) { }
        private HoudiniEngineUnity.HEU_HoudiniAsset <Definition>b__12_1(Unity.VisualScripting.Flow flow) { }
        private System.Boolean <Definition>b__12_2(Unity.VisualScripting.Flow flow) { }

    }

    // TypeToken: 0x2000004
    public class HEU_ModifyHDA : ManualEventUnit`1
    {
        // Fields
        public HoudiniEngineUnity.HEU_UnitButton triggerButton;        // 0x80
        public Unity.VisualScripting.ValueInput inputHDA;        // 0x88
        public Unity.VisualScripting.ValueOutput outputHDAAsset;        // 0x90
        private HoudiniEngineUnity.HEU_HoudiniAsset hdaAsset;        // 0x98

        // Methods
        private System.String get_hookName() { }
        private System.Void Definition() { }
        private System.Void TriggerButton(Unity.VisualScripting.GraphReference reference) { }
        private System.Void .ctor() { }
        private HoudiniEngineUnity.HEU_HoudiniAsset <Definition>b__6_0(Unity.VisualScripting.Flow flow) { }

    }

    // TypeToken: 0x2000006
    public class HEU_UnitButton
    {
        // Fields
        public System.Action action;        // 0x10

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class HEU_UnitButtonAttribute : Attribute
    {
        // Fields
        public System.String functionName;        // 0x10
        public System.String buttonLabel;        // 0x18
        public System.Int32 buttonWidth;        // 0x20

        // Methods
        private System.Void .ctor(System.String fnName, System.String btnLabel, System.Int32 btnWidth) { }

    }

}

