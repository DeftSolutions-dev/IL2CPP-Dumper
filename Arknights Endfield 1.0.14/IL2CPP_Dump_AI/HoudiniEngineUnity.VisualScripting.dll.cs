// ========================================================
// Dumped by @desirepro
// Assembly: HoudiniEngineUnity.VisualScripting.dll
// Classes:  7
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: HoudiniEngineUnity.HEU_InstantiateHDA
TYPE:  class
TOKEN: 0x2000002
EXTENDS: ManualEventUnit`1
FIELDS:
  public            HoudiniEngineUnity.HEU_UnitButtontriggerButton  // 0x80
  public            Unity.VisualScripting.ValueInputinputPath  // 0x88
  public            Unity.VisualScripting.ValueInputinputAsync  // 0x90
  public            Unity.VisualScripting.ValueInputinputPosition  // 0x98
  public            Unity.VisualScripting.ValueOutputoutputHDARoot  // 0xA0
  public            Unity.VisualScripting.ValueOutputoutputHDAAsset  // 0xA8
  public            Unity.VisualScripting.ValueOutputoutputSuccess  // 0xB0
  private           HoudiniEngineUnity.HEU_HoudiniAssetRoothdaRoot  // 0xB8
  private           HoudiniEngineUnity.HEU_HoudiniAssethdaAsset  // 0xC0
  private           System.Boolean                  bSuccess  // 0xC8
METHODS:
  System.String get_hookName()
  System.Void Definition()
  System.Void TriggerButton(Unity.VisualScripting.GraphReference reference)
  System.Void .ctor()
  HoudiniEngineUnity.HEU_HoudiniAssetRoot <Definition>b__12_0(Unity.VisualScripting.Flow flow)
  HoudiniEngineUnity.HEU_HoudiniAsset <Definition>b__12_1(Unity.VisualScripting.Flow flow)
  System.Boolean <Definition>b__12_2(Unity.VisualScripting.Flow flow)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_ModifyHDA
TYPE:  class
TOKEN: 0x2000004
EXTENDS: ManualEventUnit`1
FIELDS:
  public            HoudiniEngineUnity.HEU_UnitButtontriggerButton  // 0x80
  public            Unity.VisualScripting.ValueInputinputHDA  // 0x88
  public            Unity.VisualScripting.ValueOutputoutputHDAAsset  // 0x90
  private           HoudiniEngineUnity.HEU_HoudiniAssethdaAsset  // 0x98
METHODS:
  System.String get_hookName()
  System.Void Definition()
  System.Void TriggerButton(Unity.VisualScripting.GraphReference reference)
  System.Void .ctor()
  HoudiniEngineUnity.HEU_HoudiniAsset <Definition>b__6_0(Unity.VisualScripting.Flow flow)
END_CLASS

CLASS: HoudiniEngineUnity.HEU_UnitButton
TYPE:  class
TOKEN: 0x2000006
FIELDS:
  public            System.Action                   action  // 0x10
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: HoudiniEngineUnity.HEU_UnitButtonAttribute
TYPE:  class
TOKEN: 0x2000007
EXTENDS: Attribute
FIELDS:
  public            System.String                   functionName  // 0x10
  public            System.String                   buttonLabel  // 0x18
  public            System.Int32                    buttonWidth  // 0x20
METHODS:
  System.Void .ctor(System.String fnName, System.String btnLabel, System.Int32 btnWidth)
END_CLASS

