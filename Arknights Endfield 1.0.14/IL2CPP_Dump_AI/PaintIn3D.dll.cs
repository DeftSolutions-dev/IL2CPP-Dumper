// ========================================================
// Dumped by @desirepro
// Assembly: PaintIn3D.dll
// Classes:  164
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: StringEvent
TYPE:  class
TOKEN: 0x2000008
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ChannelType
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dChannelCounterEvent.ChannelTypeRed  // 0x0
  public    static  PaintIn3D.P3dChannelCounterEvent.ChannelTypeGreen  // 0x0
  public    static  PaintIn3D.P3dChannelCounterEvent.ChannelTypeBlue  // 0x0
  public    static  PaintIn3D.P3dChannelCounterEvent.ChannelTypeAlpha  // 0x0
METHODS:
END_CLASS

CLASS: ChannelType
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dChannelCounterFill.ChannelTypeRed  // 0x0
  public    static  PaintIn3D.P3dChannelCounterFill.ChannelTypeGreen  // 0x0
  public    static  PaintIn3D.P3dChannelCounterFill.ChannelTypeBlue  // 0x0
  public    static  PaintIn3D.P3dChannelCounterFill.ChannelTypeAlpha  // 0x0
METHODS:
END_CLASS

CLASS: StringEvent
TYPE:  class
TOKEN: 0x200000E
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ChannelType
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dChannelCounterText.ChannelTypeRed  // 0x0
  public    static  PaintIn3D.P3dChannelCounterText.ChannelTypeGreen  // 0x0
  public    static  PaintIn3D.P3dChannelCounterText.ChannelTypeBlue  // 0x0
  public    static  PaintIn3D.P3dChannelCounterText.ChannelTypeAlpha  // 0x0
METHODS:
END_CLASS

CLASS: StringEvent
TYPE:  class
TOKEN: 0x2000013
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PhaseType
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitBetween.PhaseTypeUpdate  // 0x0
  public    static  PaintIn3D.P3dHitBetween.PhaseTypeFixedUpdate  // 0x0
METHODS:
END_CLASS

CLASS: OrientationType
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitBetween.OrientationTypeWorldUp  // 0x0
  public    static  PaintIn3D.P3dHitBetween.OrientationTypeCameraUp  // 0x0
  public    static  PaintIn3D.P3dHitBetween.OrientationTypeThisRotation  // 0x0
  public    static  PaintIn3D.P3dHitBetween.OrientationTypeThisLocalRotation  // 0x0
  public    static  PaintIn3D.P3dHitBetween.OrientationTypeCustomRotation  // 0x0
  public    static  PaintIn3D.P3dHitBetween.OrientationTypeCustomLocalRotation  // 0x0
METHODS:
END_CLASS

CLASS: NormalType
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitBetween.NormalTypeHitNormal  // 0x0
  public    static  PaintIn3D.P3dHitBetween.NormalTypeRayDirection  // 0x0
METHODS:
END_CLASS

CLASS: EmitType
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitBetween.EmitTypePointsIn3D  // 0x0
  public    static  PaintIn3D.P3dHitBetween.EmitTypePointsOnUV  // 0x0
  public    static  PaintIn3D.P3dHitBetween.EmitTypeTrianglesIn3D  // 0x0
METHODS:
END_CLASS

CLASS: EmitType
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitCollisions.EmitTypePointsIn3D  // 0x0
  public    static  PaintIn3D.P3dHitCollisions.EmitTypePointsOnUV  // 0x0
  public    static  PaintIn3D.P3dHitCollisions.EmitTypeTrianglesIn3D  // 0x0
METHODS:
END_CLASS

CLASS: OrientationType
TYPE:  struct
TOKEN: 0x2000022
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitCollisions.OrientationTypeWorldUp  // 0x0
  public    static  PaintIn3D.P3dHitCollisions.OrientationTypeCameraUp  // 0x0
METHODS:
END_CLASS

CLASS: PressureType
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitCollisions.PressureTypeConstant  // 0x0
  public    static  PaintIn3D.P3dHitCollisions.PressureTypeImpactSpeed  // 0x0
METHODS:
END_CLASS

CLASS: PhaseType
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitNearby.PhaseTypeManuallyOnly  // 0x0
  public    static  PaintIn3D.P3dHitNearby.PhaseTypeUpdate  // 0x0
  public    static  PaintIn3D.P3dHitNearby.PhaseTypeFixedUpdate  // 0x0
METHODS:
END_CLASS

CLASS: EmitType
TYPE:  struct
TOKEN: 0x2000027
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitParticles.EmitTypePointsIn3D  // 0x0
  public    static  PaintIn3D.P3dHitParticles.EmitTypePointsOnUV  // 0x0
  public    static  PaintIn3D.P3dHitParticles.EmitTypeTrianglesIn3D  // 0x0
METHODS:
END_CLASS

CLASS: OrientationType
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitParticles.OrientationTypeWorldUp  // 0x0
  public    static  PaintIn3D.P3dHitParticles.OrientationTypeCameraUp  // 0x0
METHODS:
END_CLASS

CLASS: NormalType
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitParticles.NormalTypeParticleVelocity  // 0x0
  public    static  PaintIn3D.P3dHitParticles.NormalTypeCollisionNormal  // 0x0
METHODS:
END_CLASS

CLASS: PressureType
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitParticles.PressureTypeConstant  // 0x0
  public    static  PaintIn3D.P3dHitParticles.PressureTypeDistance  // 0x0
  public    static  PaintIn3D.P3dHitParticles.PressureTypeSpeed  // 0x0
METHODS:
END_CLASS

CLASS: Link
TYPE:  class
TOKEN: 0x200002C
EXTENDS: Link
FIELDS:
  public            System.Single                   Age  // 0x18
  public            System.Boolean                  Down  // 0x1C
  public            System.Int32                    State  // 0x20
  public            System.Single                   Distance  // 0x24
  public            UnityEngine.Vector2             ScreenDelta  // 0x28
  public            UnityEngine.Vector2             ScreenOld  // 0x30
  public            System.Collections.Generic.List<UnityEngine.Vector2>History  // 0x38
METHODS:
  System.Void Move(UnityEngine.Vector2 screenNew)
  System.Boolean TryMove(UnityEngine.Vector2 screenNew)
  System.Void Clear()
  System.Void .ctor()
END_CLASS

CLASS: FrequencyType
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitScreen.FrequencyTypePixelInterval  // 0x0
  public    static  PaintIn3D.P3dHitScreen.FrequencyTypeScaledPixelInterval  // 0x0
  public    static  PaintIn3D.P3dHitScreen.FrequencyTypeTimeInterval  // 0x0
  public    static  PaintIn3D.P3dHitScreen.FrequencyTypeOnceOnRelease  // 0x0
  public    static  PaintIn3D.P3dHitScreen.FrequencyTypeOnceOnPress  // 0x0
  public    static  PaintIn3D.P3dHitScreen.FrequencyTypeOnceEveryFrame  // 0x0
METHODS:
END_CLASS

CLASS: RotationType
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitScreenBase.RotationTypeNormal  // 0x0
  public    static  PaintIn3D.P3dHitScreenBase.RotationTypeWorld  // 0x0
  public    static  PaintIn3D.P3dHitScreenBase.RotationTypeThisRotation  // 0x0
  public    static  PaintIn3D.P3dHitScreenBase.RotationTypeThisLocalRotation  // 0x0
  public    static  PaintIn3D.P3dHitScreenBase.RotationTypeCustomRotation  // 0x0
  public    static  PaintIn3D.P3dHitScreenBase.RotationTypeCustomLocalRotation  // 0x0
METHODS:
END_CLASS

CLASS: RelativeType
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitScreenBase.RelativeTypeWorldUp  // 0x0
  public    static  PaintIn3D.P3dHitScreenBase.RelativeTypeCameraUp  // 0x0
  public    static  PaintIn3D.P3dHitScreenBase.RelativeTypeDrawAngle  // 0x0
METHODS:
END_CLASS

CLASS: DirectionType
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitScreenBase.DirectionTypeHitNormal  // 0x0
  public    static  PaintIn3D.P3dHitScreenBase.DirectionTypeRayDirection  // 0x0
  public    static  PaintIn3D.P3dHitScreenBase.DirectionTypeCameraDirection  // 0x0
METHODS:
END_CLASS

CLASS: EmitType
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitScreenBase.EmitTypePointsIn3D  // 0x0
  public    static  PaintIn3D.P3dHitScreenBase.EmitTypePointsOnUV  // 0x0
  public    static  PaintIn3D.P3dHitScreenBase.EmitTypeTrianglesIn3D  // 0x0
METHODS:
END_CLASS

CLASS: ButtonTypes
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitScreenBase.ButtonTypesLeftMouse  // 0x0
  public    static  PaintIn3D.P3dHitScreenBase.ButtonTypesRightMouse  // 0x0
  public    static  PaintIn3D.P3dHitScreenBase.ButtonTypesMiddleMouse  // 0x0
  public    static  PaintIn3D.P3dHitScreenBase.ButtonTypesTouch  // 0x0
METHODS:
END_CLASS

CLASS: FrequencyType
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitScreenLine.FrequencyTypeStartAndEnd  // 0x0
  public    static  PaintIn3D.P3dHitScreenLine.FrequencyTypePixelInterval  // 0x0
  public    static  PaintIn3D.P3dHitScreenLine.FrequencyTypeScaledPixelInterval  // 0x0
  public    static  PaintIn3D.P3dHitScreenLine.FrequencyTypeStretchedPixelInterval  // 0x0
  public    static  PaintIn3D.P3dHitScreenLine.FrequencyTypeStretchedScaledPixelInterval  // 0x0
  public    static  PaintIn3D.P3dHitScreenLine.FrequencyTypeOnce  // 0x0
METHODS:
END_CLASS

CLASS: PhaseType
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitThrough.PhaseTypeUpdate  // 0x0
  public    static  PaintIn3D.P3dHitThrough.PhaseTypeFixedUpdate  // 0x0
METHODS:
END_CLASS

CLASS: OrientationType
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dHitThrough.OrientationTypeWorldUp  // 0x0
  public    static  PaintIn3D.P3dHitThrough.OrientationTypeCameraUp  // 0x0
METHODS:
END_CLASS

CLASS: Pair
TYPE:  class
TOKEN: 0x2000046
FIELDS:
  public            UnityEngine.Mesh                Source  // 0x10
  public            UnityEngine.Mesh                Output  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Ring
TYPE:  class
TOKEN: 0x2000047
FIELDS:
  public            System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Point>Points  // 0x10
METHODS:
  PaintIn3D.P3dSeamFixer.Point GetPoint(System.Int32 index)
  System.Void .ctor()
END_CLASS

CLASS: Edge
TYPE:  class
TOKEN: 0x2000048
FIELDS:
  public            System.Boolean                  Used  // 0x10
  public            PaintIn3D.P3dSeamFixer.Point    PointA  // 0x18
  public            PaintIn3D.P3dSeamFixer.Point    PointB  // 0x20
  public            System.Boolean                  Flip  // 0x28
METHODS:
  System.Boolean Match(PaintIn3D.P3dSeamFixer.Point a, PaintIn3D.P3dSeamFixer.Point b)
  System.Void .ctor()
END_CLASS

CLASS: Point
TYPE:  class
TOKEN: 0x2000049
FIELDS:
  public            System.Int32                    Index  // 0x10
  public            UnityEngine.Vector2             Coord  // 0x14
  public            PaintIn3D.P3dSeamFixer.InsertionOuter  // 0x20
  public            System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Edge>Edges  // 0x28
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Insertion
TYPE:  class
TOKEN: 0x200004A
FIELDS:
  public            System.Int32                    Index  // 0x10
  public            System.Int32                    NewIndex  // 0x14
  public            UnityEngine.Vector2             NewCoord  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: BlendType
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dModifyAngleRandom.BlendTypeReplace  // 0x0
  public    static  PaintIn3D.P3dModifyAngleRandom.BlendTypeMultiply  // 0x0
  public    static  PaintIn3D.P3dModifyAngleRandom.BlendTypeIncrement  // 0x0
METHODS:
END_CLASS

CLASS: BlendType
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dModifyColorRandom.BlendTypeReplace  // 0x0
  public    static  PaintIn3D.P3dModifyColorRandom.BlendTypeMultiply  // 0x0
  public    static  PaintIn3D.P3dModifyColorRandom.BlendTypeIncrement  // 0x0
METHODS:
END_CLASS

CLASS: BlendType
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dModifyHardnessPressure.BlendTypeReplace  // 0x0
  public    static  PaintIn3D.P3dModifyHardnessPressure.BlendTypeMultiply  // 0x0
  public    static  PaintIn3D.P3dModifyHardnessPressure.BlendTypeIncrement  // 0x0
METHODS:
END_CLASS

CLASS: BlendType
TYPE:  struct
TOKEN: 0x2000054
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dModifyHardnessRandom.BlendTypeReplace  // 0x0
  public    static  PaintIn3D.P3dModifyHardnessRandom.BlendTypeMultiply  // 0x0
  public    static  PaintIn3D.P3dModifyHardnessRandom.BlendTypeIncrement  // 0x0
METHODS:
END_CLASS

CLASS: BlendType
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dModifyOpacityPressure.BlendTypeReplace  // 0x0
  public    static  PaintIn3D.P3dModifyOpacityPressure.BlendTypeMultiply  // 0x0
  public    static  PaintIn3D.P3dModifyOpacityPressure.BlendTypeIncrement  // 0x0
METHODS:
END_CLASS

CLASS: BlendType
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dModifyOpacityRandom.BlendTypeReplace  // 0x0
  public    static  PaintIn3D.P3dModifyOpacityRandom.BlendTypeMultiply  // 0x0
  public    static  PaintIn3D.P3dModifyOpacityRandom.BlendTypeIncrement  // 0x0
METHODS:
END_CLASS

CLASS: BlendType
TYPE:  struct
TOKEN: 0x200005B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dModifyRadiusPressure.BlendTypeReplace  // 0x0
  public    static  PaintIn3D.P3dModifyRadiusPressure.BlendTypeMultiply  // 0x0
  public    static  PaintIn3D.P3dModifyRadiusPressure.BlendTypeIncrement  // 0x0
METHODS:
END_CLASS

CLASS: BlendType
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dModifyRadiusRandom.BlendTypeReplace  // 0x0
  public    static  PaintIn3D.P3dModifyRadiusRandom.BlendTypeMultiply  // 0x0
  public    static  PaintIn3D.P3dModifyRadiusRandom.BlendTypeIncrement  // 0x0
METHODS:
END_CLASS

CLASS: BlendType
TYPE:  struct
TOKEN: 0x200005F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dModifyScaleRandom.BlendTypeReplace  // 0x0
  public    static  PaintIn3D.P3dModifyScaleRandom.BlendTypeMultiply  // 0x0
  public    static  PaintIn3D.P3dModifyScaleRandom.BlendTypeIncrement  // 0x0
METHODS:
END_CLASS

CLASS: Contribution
TYPE:  class
TOKEN: 0x200006A
FIELDS:
  public            PaintIn3D.P3dColorCounter       Counter  // 0x10
  public            System.Int32                    Solid  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Contribution
TYPE:  class
TOKEN: 0x200006C
FIELDS:
  public            PaintIn3D.P3dColor              Color  // 0x10
  public            System.Int32                    Count  // 0x18
  public            System.Single                   Ratio  // 0x1C
  public            System.Byte                     R  // 0x20
  public            System.Byte                     G  // 0x21
  public            System.Byte                     B  // 0x22
  public            System.Byte                     A  // 0x23
  public    static  System.Collections.Generic.Stack<PaintIn3D.P3dColorCounter.Contribution>Pool  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Coord
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dCoordCopier.Coord  First  // 0x0
  public    static  PaintIn3D.P3dCoordCopier.Coord  Second  // 0x0
  public    static  PaintIn3D.P3dCoordCopier.Coord  Third  // 0x0
  public    static  PaintIn3D.P3dCoordCopier.Coord  Fourth  // 0x0
  public    static  PaintIn3D.P3dCoordCopier.Coord  None  // 0x0
METHODS:
END_CLASS

CLASS: TextureData
TYPE:  class
TOKEN: 0x2000076
FIELDS:
  public            System.String                   Name  // 0x10
  public            PaintIn3D.P3dBlendMode          BlendMode  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Entry
TYPE:  class
TOKEN: 0x2000077
FIELDS:
  public            System.String                   Path  // 0x10
  public            System.String                   Property  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Link
TYPE:  class
TOKEN: 0x200007E
FIELDS:
  public            System.Object                   Owner  // 0x10
  public            UnityEngine.Vector3             Position  // 0x18
  public            UnityEngine.Vector3             EndPosition  // 0x24
  public            System.Single                   Age  // 0x30
  public            System.Boolean                  Preview  // 0x34
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: MeshData
TYPE:  class
TOKEN: 0x2000082
FIELDS:
  private           UnityEngine.Vector3[]           positions  // 0x10
  private           System.Int32[]                  indices  // 0x18
  private           System.Int32                    total  // 0x20
METHODS:
  System.Void Update(UnityEngine.Mesh mesh)
  System.Boolean GetTrianglePositions(UnityEngine.RaycastHit hit, UnityEngine.Vector3& positionA, UnityEngine.Vector3& positionB, UnityEngine.Vector3& positionC)
  System.Void .ctor()
END_CLASS

CLASS: UseMeshType
TYPE:  struct
TOKEN: 0x2000084
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dModel.UseMeshType  AsIs  // 0x0
  public    static  PaintIn3D.P3dModel.UseMeshType  AutoSeamFix  // 0x0
METHODS:
END_CLASS

CLASS: ActivationType
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dPaintable.ActivationTypeAwake  // 0x0
  public    static  PaintIn3D.P3dPaintable.ActivationTypeOnEnable  // 0x0
  public    static  PaintIn3D.P3dPaintable.ActivationTypeStart  // 0x0
  public    static  PaintIn3D.P3dPaintable.ActivationTypeOnFirstUse  // 0x0
METHODS:
END_CLASS

CLASS: UndoRedoType
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dPaintableTexture.UndoRedoTypeNone  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.UndoRedoTypeFullTextureCopy  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.UndoRedoTypeLocalCommandCopy  // 0x0
METHODS:
END_CLASS

CLASS: SaveLoadType
TYPE:  struct
TOKEN: 0x200008D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dPaintableTexture.SaveLoadTypeManual  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.SaveLoadTypeAutomatic  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.SaveLoadTypeSemiManual  // 0x0
METHODS:
END_CLASS

CLASS: MipType
TYPE:  struct
TOKEN: 0x200008E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dPaintableTexture.MipTypeAuto  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.MipTypeOn  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.MipTypeOff  // 0x0
METHODS:
END_CLASS

CLASS: FilterType
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dPaintableTexture.FilterTypeAuto  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.FilterTypePoint  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.FilterTypeBilinear  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.FilterTypeTrilinear  // 0x0
METHODS:
END_CLASS

CLASS: AnisoType
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dPaintableTexture.AnisoTypeAuto  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.AnisoTypeOff  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.AnisoTypeOne  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.AnisoTypeFour  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.AnisoTypeEight  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.AnisoTypeSixteen  // 0x0
METHODS:
END_CLASS

CLASS: WrapType
TYPE:  struct
TOKEN: 0x2000091
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dPaintableTexture.WrapTypeAuto  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.WrapTypeRepeat  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.WrapTypeClamp  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.WrapTypeMirror  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.WrapTypeMirrorOnce  // 0x0
METHODS:
END_CLASS

CLASS: ExistingType
TYPE:  struct
TOKEN: 0x2000092
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dPaintableTexture.ExistingTypeIgnore  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.ExistingTypeUse  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.ExistingTypeUseAndKeep  // 0x0
METHODS:
END_CLASS

CLASS: ConversionType
TYPE:  struct
TOKEN: 0x2000093
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dPaintableTexture.ConversionTypeNone  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.ConversionTypeNormal  // 0x0
  public    static  PaintIn3D.P3dPaintableTexture.ConversionTypePremultiply  // 0x0
METHODS:
END_CLASS

CLASS: PaintableTextureEvent
TYPE:  class
TOKEN: 0x2000094
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Link
TYPE:  class
TOKEN: 0x2000098
FIELDS:
  public            System.Object                   Owner  // 0x10
  public            UnityEngine.Vector3             Position  // 0x18
  public            System.Single                   Age  // 0x24
  public            System.Boolean                  Preview  // 0x28
  public            UnityEngine.Vector3             LastPosition  // 0x2C
  public            System.Single                   LastPressure  // 0x38
  public            System.Int32                    LastPriority  // 0x3C
  public            UnityEngine.Quaternion          LastRotation  // 0x40
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ColorEvent
TYPE:  class
TOKEN: 0x200009A
EXTENDS: UnityEvent`1
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dButtonClearAll
TYPE:  class
TOKEN: 0x2000002
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Boolean                  clearStates  // 0x18
METHODS:
  System.Void set_ClearStates(System.Boolean value)
  System.Boolean get_ClearStates()
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void ClearAll()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dButtonRedoAll
TYPE:  class
TOKEN: 0x2000003
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void RedoAll()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dButtonUndoAll
TYPE:  class
TOKEN: 0x2000004
EXTENDS: MonoBehaviour
FIELDS:
METHODS:
  System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
  System.Void UndoAll()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dChangeCounterEvent
TYPE:  class
TOKEN: 0x2000005
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<PaintIn3D.P3dChangeCounter>counters  // 0x18
  private           UnityEngine.Vector2             range  // 0x20
  private           System.Boolean                  inside  // 0x28
  private           UnityEngine.Events.UnityEvent   onInside  // 0x30
  private           UnityEngine.Events.UnityEvent   onOutside  // 0x38
METHODS:
  System.Collections.Generic.List<PaintIn3D.P3dChangeCounter> get_Counters()
  System.Void set_Range(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_Range()
  System.Void set_Inside(System.Boolean value)
  System.Boolean get_Inside()
  UnityEngine.Events.UnityEvent get_OnInside()
  UnityEngine.Events.UnityEvent get_OnOutside()
  System.Single get_Ratio()
  System.Void Update()
  System.Void UpdateInside(System.Single ratio)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dChangeCounterFill
TYPE:  class
TOKEN: 0x2000006
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<PaintIn3D.P3dChangeCounter>counters  // 0x18
  private           System.Boolean                  inverse  // 0x20
  private           UnityEngine.UI.Image            cachedImage  // 0x28
METHODS:
  System.Collections.Generic.List<PaintIn3D.P3dChangeCounter> get_Counters()
  System.Void set_Inverse(System.Boolean value)
  System.Boolean get_Inverse()
  System.Void OnEnable()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dChangeCounterText
TYPE:  class
TOKEN: 0x2000007
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<PaintIn3D.P3dChangeCounter>counters  // 0x18
  private           System.Boolean                  inverse  // 0x20
  private           System.Int32                    decimalPlaces  // 0x24
  private           System.String                   format  // 0x28
  private           PaintIn3D.P3dChangeCounterText.StringEventonString  // 0x30
METHODS:
  System.Collections.Generic.List<PaintIn3D.P3dChangeCounter> get_Counters()
  System.Void set_Inverse(System.Boolean value)
  System.Boolean get_Inverse()
  System.Void set_DecimalPlaces(System.Int32 value)
  System.Int32 get_DecimalPlaces()
  System.Void set_Format(System.String value)
  System.String get_Format()
  PaintIn3D.P3dChangeCounterText.StringEvent get_OnString()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dChannelCounterEvent
TYPE:  class
TOKEN: 0x2000009
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<PaintIn3D.P3dChannelCounter>counters  // 0x18
  private           PaintIn3D.P3dChannelCounterEvent.ChannelTypechannel  // 0x20
  private           UnityEngine.Vector2             range  // 0x24
  private           System.Boolean                  inside  // 0x2C
  private           UnityEngine.Events.UnityEvent   onInside  // 0x30
  private           UnityEngine.Events.UnityEvent   onOutside  // 0x38
METHODS:
  System.Collections.Generic.List<PaintIn3D.P3dChannelCounter> get_Counters()
  System.Void set_Channel(PaintIn3D.P3dChannelCounterEvent.ChannelType value)
  PaintIn3D.P3dChannelCounterEvent.ChannelType get_Channel()
  System.Void set_Range(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_Range()
  System.Void set_Inside(System.Boolean value)
  System.Boolean get_Inside()
  UnityEngine.Events.UnityEvent get_OnInside()
  UnityEngine.Events.UnityEvent get_OnOutside()
  System.Single get_Ratio()
  System.Void Update()
  System.Void UpdateInside(System.Single ratio)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dChannelCounterFill
TYPE:  class
TOKEN: 0x200000B
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<PaintIn3D.P3dChannelCounter>counters  // 0x18
  private           PaintIn3D.P3dChannelCounterFill.ChannelTypechannel  // 0x20
  private           System.Boolean                  inverse  // 0x24
  private           UnityEngine.UI.Image            cachedImage  // 0x28
METHODS:
  System.Collections.Generic.List<PaintIn3D.P3dChannelCounter> get_Counters()
  System.Void set_Channel(PaintIn3D.P3dChannelCounterFill.ChannelType value)
  PaintIn3D.P3dChannelCounterFill.ChannelType get_Channel()
  System.Void set_Inverse(System.Boolean value)
  System.Boolean get_Inverse()
  System.Void OnEnable()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dChannelCounterText
TYPE:  class
TOKEN: 0x200000D
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<PaintIn3D.P3dChannelCounter>counters  // 0x18
  private           PaintIn3D.P3dChannelCounterText.ChannelTypechannel  // 0x20
  private           System.Boolean                  inverse  // 0x24
  private           System.Int32                    decimalPlaces  // 0x28
  private           System.String                   format  // 0x30
  private           PaintIn3D.P3dChannelCounterText.StringEventonString  // 0x38
METHODS:
  System.Collections.Generic.List<PaintIn3D.P3dChannelCounter> get_Counters()
  System.Void set_Channel(PaintIn3D.P3dChannelCounterText.ChannelType value)
  PaintIn3D.P3dChannelCounterText.ChannelType get_Channel()
  System.Void set_Inverse(System.Boolean value)
  System.Boolean get_Inverse()
  System.Void set_DecimalPlaces(System.Int32 value)
  System.Int32 get_DecimalPlaces()
  System.Void set_Format(System.String value)
  System.String get_Format()
  PaintIn3D.P3dChannelCounterText.StringEvent get_OnString()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dColorCounterEvent
TYPE:  class
TOKEN: 0x2000010
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<PaintIn3D.P3dColorCounter>counters  // 0x18
  private           PaintIn3D.P3dColor              color  // 0x20
  private           UnityEngine.Vector2             range  // 0x28
  private           System.Boolean                  inside  // 0x30
  private           UnityEngine.Events.UnityEvent   onInside  // 0x38
  private           UnityEngine.Events.UnityEvent   onOutside  // 0x40
METHODS:
  System.Collections.Generic.List<PaintIn3D.P3dColorCounter> get_Counters()
  System.Void set_Color(PaintIn3D.P3dColor value)
  PaintIn3D.P3dColor get_Color()
  System.Void set_Range(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_Range()
  System.Void set_Inside(System.Boolean value)
  System.Boolean get_Inside()
  UnityEngine.Events.UnityEvent get_OnInside()
  UnityEngine.Events.UnityEvent get_OnOutside()
  System.Single get_Ratio()
  System.Void Update()
  System.Void UpdateInside(System.Single ratio)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dColorCounterFill
TYPE:  class
TOKEN: 0x2000011
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<PaintIn3D.P3dColorCounter>counters  // 0x18
  private           PaintIn3D.P3dColor              color  // 0x20
  private           System.Boolean                  inverse  // 0x28
  private           UnityEngine.UI.Image            cachedImage  // 0x30
METHODS:
  System.Collections.Generic.List<PaintIn3D.P3dColorCounter> get_Counters()
  System.Void set_Color(PaintIn3D.P3dColor value)
  PaintIn3D.P3dColor get_Color()
  System.Void set_Inverse(System.Boolean value)
  System.Boolean get_Inverse()
  System.Void OnEnable()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dColorCounterText
TYPE:  class
TOKEN: 0x2000012
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Collections.Generic.List<PaintIn3D.P3dColorCounter>counters  // 0x18
  private           PaintIn3D.P3dColor              color  // 0x20
  private           System.Boolean                  inverse  // 0x28
  private           System.Int32                    decimalPlaces  // 0x2C
  private           System.String                   format  // 0x30
  private           PaintIn3D.P3dColorCounterText.StringEventonString  // 0x38
METHODS:
  System.Collections.Generic.List<PaintIn3D.P3dColorCounter> get_Counters()
  System.Void set_Color(PaintIn3D.P3dColor value)
  PaintIn3D.P3dColor get_Color()
  System.Void set_Inverse(System.Boolean value)
  System.Boolean get_Inverse()
  System.Void set_DecimalPlaces(System.Int32 value)
  System.Int32 get_DecimalPlaces()
  System.Void set_Format(System.String value)
  System.String get_Format()
  PaintIn3D.P3dColorCounterText.StringEvent get_OnString()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dPaintDebug
TYPE:  class
TOKEN: 0x2000014
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Color               color  // 0x18
  private           System.Single                   duration  // 0x28
  private           System.Single                   size  // 0x2C
METHODS:
  System.Void set_Color(UnityEngine.Color value)
  UnityEngine.Color get_Color()
  System.Void set_Duration(System.Single value)
  System.Single get_Duration()
  System.Void set_Size(System.Single value)
  System.Single get_Size()
  System.Void HandleHitPoint(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void HandleHitLine(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Quaternion rotation, System.Boolean clip)
  System.Void HandleHitTriangle(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC, UnityEngine.Quaternion rotation)
  System.Void HandleHitQuad(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2, UnityEngine.Quaternion rotation, System.Boolean clip)
  UnityEngine.Color GetColor(System.Boolean preview, System.Single pressure, UnityEngine.Color color)
  System.Void DrawArrow(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Color tint)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dCommandDecal
TYPE:  class
TOKEN: 0x2000015
EXTENDS: P3dCommand
FIELDS:
  public            PaintIn3D.P3dBlendMode          Blend  // 0x70
  public            System.Boolean                  In3D  // 0xA8
  public            UnityEngine.Vector3             Position  // 0xAC
  public            UnityEngine.Vector3             EndPosition  // 0xB8
  public            UnityEngine.Vector3             Position2  // 0xC4
  public            UnityEngine.Vector3             EndPosition2  // 0xD0
  public            System.Int32                    Extrusions  // 0xDC
  public            System.Boolean                  Clip  // 0xE0
  public            UnityEngine.Matrix4x4           Matrix  // 0xE4
  public            UnityEngine.Vector3             Direction  // 0x124
  public            UnityEngine.Color               Color  // 0x130
  public            System.Single                   Opacity  // 0x140
  public            System.Single                   Hardness  // 0x144
  public            System.Single                   Wrapping  // 0x148
  public            PaintIn3D.P3dHashedTexture      Texture  // 0x150
  public            PaintIn3D.P3dHashedTexture      Shape  // 0x160
  public            UnityEngine.Vector4             ShapeChannel  // 0x170
  public            UnityEngine.Vector2             NormalFront  // 0x180
  public            UnityEngine.Vector2             NormalBack  // 0x188
  public            PaintIn3D.P3dHashedTexture      TileTexture  // 0x190
  public            UnityEngine.Matrix4x4           TileMatrix  // 0x1A0
  public            System.Single                   TileOpacity  // 0x1E0
  public            System.Single                   TileTransition  // 0x1E4
  public            UnityEngine.Matrix4x4           MaskMatrix  // 0x1E8
  public            PaintIn3D.P3dHashedTexture      MaskShape  // 0x228
  public            UnityEngine.Vector4             MaskChannel  // 0x238
  public            UnityEngine.Vector3             MaskStretch  // 0x248
  public    static  PaintIn3D.P3dCommandDecal       Instance  // 0x0
  private   static  System.Collections.Generic.Stack<PaintIn3D.P3dCommandDecal>pool  // 0x8
  private   static  UnityEngine.Material            cachedSpotMaterial  // 0x10
  private   static  UnityEngine.Material            cachedLineMaterial  // 0x18
  private   static  UnityEngine.Material            cachedQuadMaterial  // 0x20
  private   static  UnityEngine.Material            cachedLineClipMaterial  // 0x28
  private   static  UnityEngine.Material            cachedQuadClipMaterial  // 0x30
  private   static  System.Int32                    cachedSpotMaterialHash  // 0x38
  private   static  System.Int32                    cachedLineMaterialHash  // 0x3C
  private   static  System.Int32                    cachedQuadMaterialHash  // 0x40
  private   static  System.Int32                    cachedLineClipMaterialHash  // 0x44
  private   static  System.Int32                    cachedQuadClipMaterialHash  // 0x48
  private   static  System.Int32                    _In3D  // 0x4C
  private   static  System.Int32                    _Position  // 0x50
  private   static  System.Int32                    _EndPosition  // 0x54
  private   static  System.Int32                    _Position2  // 0x58
  private   static  System.Int32                    _EndPosition2  // 0x5C
  private   static  System.Int32                    _Matrix  // 0x60
  private   static  System.Int32                    _Direction  // 0x64
  private   static  System.Int32                    _Color  // 0x68
  private   static  System.Int32                    _Opacity  // 0x6C
  private   static  System.Int32                    _Hardness  // 0x70
  private   static  System.Int32                    _Wrapping  // 0x74
  private   static  System.Int32                    _Texture  // 0x78
  private   static  System.Int32                    _Shape  // 0x7C
  private   static  System.Int32                    _ShapeChannel  // 0x80
  private   static  System.Int32                    _NormalFront  // 0x84
  private   static  System.Int32                    _NormalBack  // 0x88
  private   static  System.Int32                    _TileTexture  // 0x8C
  private   static  System.Int32                    _TileMatrix  // 0x90
  private   static  System.Int32                    _TileOpacity  // 0x94
  private   static  System.Int32                    _TileTransition  // 0x98
  private   static  System.Int32                    _MaskMatrix  // 0x9C
  private   static  System.Int32                    _MaskTexture  // 0xA0
  private   static  System.Int32                    _MaskChannel  // 0xA4
  private   static  System.Int32                    _MaskStretch  // 0xA8
METHODS:
  System.Boolean get_RequireMesh()
  System.Void .cctor()
  System.Void Apply(UnityEngine.Material material)
  System.Void Pool()
  System.Void Transform(UnityEngine.Matrix4x4 posMatrix, UnityEngine.Matrix4x4 rotMatrix)
  PaintIn3D.P3dCommand SpawnCopy()
  System.Void Apply(PaintIn3D.P3dPaintableTexture paintableTexture)
  System.Void SetShape(UnityEngine.Quaternion rotation, UnityEngine.Vector3 size, System.Single angle)
  System.Void SetLocation(UnityEngine.Vector3 position, System.Boolean in3D)
  System.Void SetLocation(UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, System.Boolean in3D, System.Boolean clip)
  System.Void SetLocation(UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC, System.Boolean in3D)
  System.Void SetLocation(UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2, System.Boolean in3D, System.Boolean clip)
  System.Void ClearMask()
  System.Void SetMask(UnityEngine.Matrix4x4 matrix, UnityEngine.Texture shape, PaintIn3D.P3dChannel channel, UnityEngine.Vector3 stretch)
  System.Void ApplyAspect(UnityEngine.Texture texture)
  System.Void SetMaterial(PaintIn3D.P3dBlendMode blendMode, UnityEngine.Texture texture, UnityEngine.Texture shape, PaintIn3D.P3dChannel shapeChannel, System.Single hardness, System.Single wrapping, System.Single normalBack, System.Single normalFront, System.Single normalFade, UnityEngine.Color color, System.Single opacity, UnityEngine.Texture tileTexture, UnityEngine.Matrix4x4 tileMatrix, System.Single tileOpacity, System.Single tileTransition)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dCommandFill
TYPE:  class
TOKEN: 0x2000016
EXTENDS: P3dCommand
FIELDS:
  public            PaintIn3D.P3dBlendMode          Blend  // 0x70
  public            PaintIn3D.P3dHashedTexture      Texture  // 0xA8
  public            UnityEngine.Color               Color  // 0xB8
  public            System.Single                   Opacity  // 0xC8
  public            System.Single                   Minimum  // 0xCC
  public    static  PaintIn3D.P3dCommandFill        Instance  // 0x0
  private   static  System.Collections.Generic.Stack<PaintIn3D.P3dCommandFill>pool  // 0x8
  private   static  UnityEngine.Material            cachedMaterial  // 0x10
  private   static  System.Int32                    cachedMaterialHash  // 0x18
  private   static  System.Int32                    _Buffer  // 0x1C
  private   static  System.Int32                    _BufferSize  // 0x20
  private   static  System.Int32                    _Texture  // 0x24
  private   static  System.Int32                    _Color  // 0x28
  private   static  System.Int32                    _Opacity  // 0x2C
  private   static  System.Int32                    _Minimum  // 0x30
METHODS:
  System.Boolean get_RequireMesh()
  System.Void .cctor()
  UnityEngine.RenderTexture Blit(UnityEngine.RenderTexture main, PaintIn3D.P3dBlendMode blendMode, UnityEngine.Texture texture, UnityEngine.Color color, System.Single opacity, System.Single minimum)
  System.Void Blit(UnityEngine.RenderTexture& main, UnityEngine.RenderTexture& swap, PaintIn3D.P3dBlendMode blendMode, UnityEngine.Texture texture, UnityEngine.Color color, System.Single opacity, System.Single minimum)
  System.Void Apply(UnityEngine.Material material)
  System.Void Pool()
  System.Void Transform(UnityEngine.Matrix4x4 posMatrix, UnityEngine.Matrix4x4 rotMatrix)
  PaintIn3D.P3dCommand SpawnCopy()
  System.Void Apply(PaintIn3D.P3dPaintableTexture paintableTexture)
  UnityEngine.Material SetMaterial(PaintIn3D.P3dBlendMode blendMode, UnityEngine.Texture texture, UnityEngine.Color color, System.Single opacity, System.Single minimum)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dCommandReplace
TYPE:  class
TOKEN: 0x2000017
EXTENDS: P3dCommand
FIELDS:
  public            PaintIn3D.P3dHashedTexture      Texture  // 0x70
  public            UnityEngine.Color               Color  // 0x80
  public    static  PaintIn3D.P3dCommandReplace     Instance  // 0x0
  private   static  System.Collections.Generic.Stack<PaintIn3D.P3dCommandReplace>pool  // 0x8
  private   static  UnityEngine.Material            cachedMaterial  // 0x10
  private   static  System.Int32                    cachedMaterialHash  // 0x18
  private   static  System.Int32                    _Texture  // 0x1C
  private   static  System.Int32                    _Color  // 0x20
METHODS:
  System.Boolean get_RequireMesh()
  System.Void .cctor()
  System.Void Blit(UnityEngine.RenderTexture renderTexture, UnityEngine.Texture texture, UnityEngine.Color tint)
  System.Void BlitFast(UnityEngine.RenderTexture renderTexture, UnityEngine.Texture texture, UnityEngine.Color tint)
  System.Void Apply(UnityEngine.Material material)
  System.Void Pool()
  System.Void Transform(UnityEngine.Matrix4x4 posMatrix, UnityEngine.Matrix4x4 rotMatrix)
  PaintIn3D.P3dCommand SpawnCopy()
  UnityEngine.Material SetMaterial(UnityEngine.Texture texture, UnityEngine.Color color)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dCommandReplaceChannels
TYPE:  class
TOKEN: 0x2000018
EXTENDS: P3dCommand
FIELDS:
  public            PaintIn3D.P3dHashedTexture      TextureR  // 0x70
  public            PaintIn3D.P3dHashedTexture      TextureG  // 0x80
  public            PaintIn3D.P3dHashedTexture      TextureB  // 0x90
  public            PaintIn3D.P3dHashedTexture      TextureA  // 0xA0
  public            UnityEngine.Vector4             ChannelR  // 0xB0
  public            UnityEngine.Vector4             ChannelG  // 0xC0
  public            UnityEngine.Vector4             ChannelB  // 0xD0
  public            UnityEngine.Vector4             ChannelA  // 0xE0
  public    static  PaintIn3D.P3dCommandReplaceChannelsInstance  // 0x0
  private   static  System.Collections.Generic.Stack<PaintIn3D.P3dCommandReplaceChannels>pool  // 0x8
  private   static  UnityEngine.Material            cachedMaterial  // 0x10
  private   static  System.Int32                    cachedMaterialHash  // 0x18
  private   static  System.Int32                    _TextureR  // 0x1C
  private   static  System.Int32                    _TextureG  // 0x20
  private   static  System.Int32                    _TextureB  // 0x24
  private   static  System.Int32                    _TextureA  // 0x28
  private   static  System.Int32                    _ChannelR  // 0x2C
  private   static  System.Int32                    _ChannelG  // 0x30
  private   static  System.Int32                    _ChannelB  // 0x34
  private   static  System.Int32                    _ChannelA  // 0x38
METHODS:
  System.Boolean get_RequireMesh()
  System.Void .cctor()
  System.Void Blit(UnityEngine.RenderTexture renderTexture, UnityEngine.Texture textureR, UnityEngine.Texture textureG, UnityEngine.Texture textureB, UnityEngine.Texture textureA, UnityEngine.Vector4 channelR, UnityEngine.Vector4 channelG, UnityEngine.Vector4 channelB, UnityEngine.Vector4 channelA, UnityEngine.Vector4 channels)
  System.Void BlitFast(UnityEngine.RenderTexture renderTexture, UnityEngine.Texture textureR, UnityEngine.Texture textureG, UnityEngine.Texture textureB, UnityEngine.Texture textureA, UnityEngine.Vector4 channelR, UnityEngine.Vector4 channelG, UnityEngine.Vector4 channelB, UnityEngine.Vector4 channelA)
  System.Void Apply(UnityEngine.Material material)
  System.Void Pool()
  System.Void Transform(UnityEngine.Matrix4x4 posMatrix, UnityEngine.Matrix4x4 rotMatrix)
  PaintIn3D.P3dCommand SpawnCopy()
  UnityEngine.Material SetMaterial(UnityEngine.Texture textureR, UnityEngine.Texture textureG, UnityEngine.Texture textureB, UnityEngine.Texture textureA, UnityEngine.Vector4 channelR, UnityEngine.Vector4 channelG, UnityEngine.Vector4 channelB, UnityEngine.Vector4 channelA)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dCommandSphere
TYPE:  class
TOKEN: 0x2000019
EXTENDS: P3dCommand
FIELDS:
  public            PaintIn3D.P3dBlendMode          Blend  // 0x70
  public            System.Boolean                  In3D  // 0xA8
  public            UnityEngine.Vector3             Position  // 0xAC
  public            UnityEngine.Vector3             EndPosition  // 0xB8
  public            UnityEngine.Vector3             Position2  // 0xC4
  public            UnityEngine.Vector3             EndPosition2  // 0xD0
  public            System.Int32                    Extrusions  // 0xDC
  public            System.Boolean                  Clip  // 0xE0
  public            UnityEngine.Matrix4x4           Matrix  // 0xE4
  public            UnityEngine.Color               Color  // 0x124
  public            System.Single                   Opacity  // 0x134
  public            System.Single                   Hardness  // 0x138
  public            PaintIn3D.P3dHashedTexture      TileTexture  // 0x140
  public            UnityEngine.Matrix4x4           TileMatrix  // 0x150
  public            System.Single                   TileOpacity  // 0x190
  public            System.Single                   TileTransition  // 0x194
  public            UnityEngine.Matrix4x4           MaskMatrix  // 0x198
  public            PaintIn3D.P3dHashedTexture      MaskShape  // 0x1D8
  public            UnityEngine.Vector4             MaskChannel  // 0x1E8
  public            UnityEngine.Vector3             MaskStretch  // 0x1F8
  public    static  PaintIn3D.P3dCommandSphere      Instance  // 0x0
  private   static  System.Collections.Generic.Stack<PaintIn3D.P3dCommandSphere>pool  // 0x8
  private   static  UnityEngine.Material            cachedSpotMaterial  // 0x10
  private   static  UnityEngine.Material            cachedLineMaterial  // 0x18
  private   static  UnityEngine.Material            cachedQuadMaterial  // 0x20
  private   static  UnityEngine.Material            cachedLineClipMaterial  // 0x28
  private   static  UnityEngine.Material            cachedQuadClipMaterial  // 0x30
  private   static  System.Int32                    cachedSpotMaterialHash  // 0x38
  private   static  System.Int32                    cachedLineMaterialHash  // 0x3C
  private   static  System.Int32                    cachedQuadMaterialHash  // 0x40
  private   static  System.Int32                    cachedLineClipMaterialHash  // 0x44
  private   static  System.Int32                    cachedQuadClipMaterialHash  // 0x48
  private   static  System.Int32                    _In3D  // 0x4C
  private   static  System.Int32                    _Position  // 0x50
  private   static  System.Int32                    _EndPosition  // 0x54
  private   static  System.Int32                    _Position2  // 0x58
  private   static  System.Int32                    _EndPosition2  // 0x5C
  private   static  System.Int32                    _Matrix  // 0x60
  private   static  System.Int32                    _Color  // 0x64
  private   static  System.Int32                    _Opacity  // 0x68
  private   static  System.Int32                    _Hardness  // 0x6C
  private   static  System.Int32                    _TileTexture  // 0x70
  private   static  System.Int32                    _TileMatrix  // 0x74
  private   static  System.Int32                    _TileOpacity  // 0x78
  private   static  System.Int32                    _TileTransition  // 0x7C
  private   static  System.Int32                    _MaskMatrix  // 0x80
  private   static  System.Int32                    _MaskTexture  // 0x84
  private   static  System.Int32                    _MaskChannel  // 0x88
  private   static  System.Int32                    _MaskStretch  // 0x8C
METHODS:
  System.Boolean get_RequireMesh()
  System.Void .cctor()
  System.Void Apply(UnityEngine.Material material)
  System.Void Pool()
  System.Void Transform(UnityEngine.Matrix4x4 posMatrix, UnityEngine.Matrix4x4 rotMatrix)
  PaintIn3D.P3dCommand SpawnCopy()
  System.Void Apply(PaintIn3D.P3dPaintableTexture paintableTexture)
  System.Void SetLocation(UnityEngine.Vector3 position, System.Boolean in3D)
  System.Void SetLocation(UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, System.Boolean in3D, System.Boolean clip)
  System.Void SetLocation(UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC, System.Boolean in3D)
  System.Void SetLocation(UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2, System.Boolean in3D, System.Boolean clip)
  System.Void ClearMask()
  System.Void SetMask(UnityEngine.Matrix4x4 matrix, UnityEngine.Texture shape, PaintIn3D.P3dChannel channel, UnityEngine.Vector3 stretch)
  System.Void ApplyAspect(UnityEngine.Texture texture)
  System.Void SetShape(System.Single radius)
  System.Void SetShape(UnityEngine.Quaternion rotation, UnityEngine.Vector3 size, System.Single angle)
  System.Void SetMaterial(PaintIn3D.P3dBlendMode blendMode, System.Single hardness, UnityEngine.Color color, System.Single opacity, UnityEngine.Texture tileTexture, UnityEngine.Matrix4x4 tileMatrix, System.Single tileOpacity, System.Single tileTransition)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dHitBetween
TYPE:  class
TOKEN: 0x200001A
EXTENDS: MonoBehaviour
FIELDS:
  private           PaintIn3D.P3dHitBetween.PhaseTypepaintIn  // 0x18
  private           System.Single                   interval  // 0x1C
  private           UnityEngine.Transform           pointA  // 0x20
  private           UnityEngine.Transform           pointB  // 0x28
  private           System.Single                   fraction  // 0x30
  private           UnityEngine.LayerMask           layers  // 0x34
  private           PaintIn3D.P3dHitBetween.OrientationTypeorientation  // 0x38
  private           UnityEngine.Camera              _camera  // 0x40
  private           UnityEngine.Transform           customTransform  // 0x48
  private           PaintIn3D.P3dHitBetween.NormalTypenormal  // 0x50
  private           System.Single                   offset  // 0x54
  private           System.Boolean                  preview  // 0x58
  private           System.Int32                    priority  // 0x5C
  private           System.Single                   pressure  // 0x60
  private           PaintIn3D.P3dHitBetween.EmitTypeemit  // 0x64
  private           UnityEngine.Transform           point  // 0x68
  private           UnityEngine.LineRenderer        line  // 0x70
  private           PaintIn3D.P3dPointConnector     connector  // 0x78
  private           System.Single                   current  // 0x80
METHODS:
  System.Void set_PaintIn(PaintIn3D.P3dHitBetween.PhaseType value)
  PaintIn3D.P3dHitBetween.PhaseType get_PaintIn()
  System.Void set_Interval(System.Single value)
  System.Single get_Interval()
  System.Void set_PointA(UnityEngine.Transform value)
  UnityEngine.Transform get_PointA()
  System.Void set_PointB(UnityEngine.Transform value)
  UnityEngine.Transform get_PointB()
  System.Single get_Fraction()
  System.Void set_Layers(UnityEngine.LayerMask value)
  UnityEngine.LayerMask get_Layers()
  System.Void set_Orientation(PaintIn3D.P3dHitBetween.OrientationType value)
  PaintIn3D.P3dHitBetween.OrientationType get_Orientation()
  System.Void set_Camera(UnityEngine.Camera value)
  UnityEngine.Camera get_Camera()
  System.Void set_CustomTransform(UnityEngine.Transform value)
  UnityEngine.Transform get_CustomTransform()
  System.Void set_Normal(PaintIn3D.P3dHitBetween.NormalType value)
  PaintIn3D.P3dHitBetween.NormalType get_Normal()
  System.Void set_Offset(System.Single value)
  System.Single get_Offset()
  System.Void set_Preview(System.Boolean value)
  System.Boolean get_Preview()
  System.Void set_Priority(System.Int32 value)
  System.Int32 get_Priority()
  System.Void set_Pressure(System.Single value)
  System.Single get_Pressure()
  System.Void set_Draw(PaintIn3D.P3dHitBetween.EmitType value)
  PaintIn3D.P3dHitBetween.EmitType get_Draw()
  System.Void set_Point(UnityEngine.Transform value)
  UnityEngine.Transform get_Point()
  System.Void set_Line(UnityEngine.LineRenderer value)
  UnityEngine.LineRenderer get_Line()
  PaintIn3D.P3dPointConnector get_Connector()
  System.Void ManuallyHitNow()
  System.Void ClearHitCache()
  System.Void ResetConnections()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Update()
  System.Void LateUpdate()
  System.Void FixedUpdate()
  System.Void SubmitHit(System.Boolean preview)
  System.Void CalcHitData(UnityEngine.Vector3 hitPoint, UnityEngine.Vector3 hitNormal, UnityEngine.Ray ray, UnityEngine.Vector3& finalPosition, UnityEngine.Quaternion& finalRotation)
  System.Void UpdatePointAndLine()
  System.Void UpdateHit()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dHitCache
TYPE:  class
TOKEN: 0x200001F
FIELDS:
  private           System.Boolean                  cached  // 0x10
  private           System.Collections.Generic.List<PaintIn3D.IHitPoint>hitPoints  // 0x18
  private           System.Collections.Generic.List<PaintIn3D.IHitLine>hitLines  // 0x20
  private           System.Collections.Generic.List<PaintIn3D.IHitTriangle>hitTriangles  // 0x28
  private           System.Collections.Generic.List<PaintIn3D.IHitQuad>hitQuads  // 0x30
  private           System.Collections.Generic.List<PaintIn3D.IHitCoord>hitCoords  // 0x38
  private   static  System.Collections.Generic.List<PaintIn3D.IHit>hits  // 0x0
METHODS:
  System.Boolean get_Cached()
  System.Void InvokePoint(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void InvokeLine(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Quaternion rotation, System.Boolean clip)
  System.Void InvokeTriangle(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, UnityEngine.RaycastHit hit, UnityEngine.Quaternion rotation)
  System.Void InvokeTriangle(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC, UnityEngine.Quaternion rotation)
  System.Void InvokeQuad(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2, UnityEngine.Quaternion rotation, System.Boolean clip)
  System.Void InvokeCoord(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation)
  System.Void Clear()
  System.Void Cache(UnityEngine.GameObject gameObject)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dHitCollisions
TYPE:  class
TOKEN: 0x2000020
EXTENDS: MonoBehaviour
FIELDS:
  private           PaintIn3D.P3dHitCollisions.EmitTypeemit  // 0x18
  private           System.Single                   raycastDistance  // 0x1C
  private           UnityEngine.LayerMask           layers  // 0x20
  private           System.Boolean                  onlyUseFirstContact  // 0x24
  private           System.Single                   delay  // 0x28
  private           PaintIn3D.P3dHitCollisions.OrientationTypeorientation  // 0x2C
  private           UnityEngine.Camera              _camera  // 0x30
  private           System.Boolean                  preview  // 0x38
  private           System.Single                   threshold  // 0x3C
  private           PaintIn3D.P3dHitCollisions.PressureTypepressureMode  // 0x40
  private           System.Single                   pressureMin  // 0x44
  private           System.Single                   pressureMax  // 0x48
  private           System.Single                   pressureConstant  // 0x4C
  private           System.Single                   pressureMultiplier  // 0x50
  private           System.Single                   offset  // 0x54
  private           System.Int32                    priority  // 0x58
  private           UnityEngine.GameObject          root  // 0x60
  private           System.Single                   cooldown  // 0x68
  private           PaintIn3D.P3dHitCache           hitCache  // 0x70
METHODS:
  System.Void set_Emit(PaintIn3D.P3dHitCollisions.EmitType value)
  PaintIn3D.P3dHitCollisions.EmitType get_Emit()
  System.Void set_RaycastDistance(System.Single value)
  System.Single get_RaycastDistance()
  System.Void set_Layers(UnityEngine.LayerMask value)
  UnityEngine.LayerMask get_Layers()
  System.Void set_OnlyUseFirstContact(System.Boolean value)
  System.Boolean get_OnlyUseFirstContact()
  System.Void set_Delay(System.Single value)
  System.Single get_Delay()
  System.Void set_Orientation(PaintIn3D.P3dHitCollisions.OrientationType value)
  PaintIn3D.P3dHitCollisions.OrientationType get_Orientation()
  System.Void set_Camera(UnityEngine.Camera value)
  UnityEngine.Camera get_Camera()
  System.Void set_Preview(System.Boolean value)
  System.Boolean get_Preview()
  System.Void set_Threshold(System.Single value)
  System.Single get_Threshold()
  System.Void set_PressureMode(PaintIn3D.P3dHitCollisions.PressureType value)
  PaintIn3D.P3dHitCollisions.PressureType get_PressureMode()
  System.Void set_PressureMin(System.Single value)
  System.Single get_PressureMin()
  System.Void set_PressureMax(System.Single value)
  System.Single get_PressureMax()
  System.Void set_PressureConstant(System.Single value)
  System.Single get_PressureConstant()
  System.Void set_PressureMultiplier(System.Single value)
  System.Single get_PressureMultiplier()
  System.Void set_Offset(System.Single value)
  System.Single get_Offset()
  System.Void set_Priority(System.Int32 value)
  System.Int32 get_Priority()
  System.Void set_Root(UnityEngine.GameObject value)
  UnityEngine.GameObject get_Root()
  PaintIn3D.P3dHitCache get_HitCache()
  System.Void ClearHitCache()
  System.Void OnCollisionEnter(UnityEngine.Collision collision)
  System.Void OnCollisionStay(UnityEngine.Collision collision)
  System.Void Update()
  System.Boolean TryGetRaycastHit(UnityEngine.ContactPoint contact, UnityEngine.RaycastHit& hit)
  System.Void CheckCollision(UnityEngine.Collision collision)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dHitNearby
TYPE:  class
TOKEN: 0x2000024
EXTENDS: MonoBehaviour
FIELDS:
  private           PaintIn3D.P3dHitNearby.PhaseTypepaintIn  // 0x18
  private           System.Single                   interval  // 0x1C
  private           System.Boolean                  preview  // 0x20
  private           System.Int32                    priority  // 0x24
  private           System.Single                   pressure  // 0x28
  private           PaintIn3D.P3dPointConnector     connector  // 0x30
  private           System.Single                   current  // 0x38
  private           UnityEngine.Vector3             lastPosition  // 0x3C
METHODS:
  System.Void set_PaintIn(PaintIn3D.P3dHitNearby.PhaseType value)
  PaintIn3D.P3dHitNearby.PhaseType get_PaintIn()
  System.Void set_Interval(System.Single value)
  System.Single get_Interval()
  System.Void set_Preview(System.Boolean value)
  System.Boolean get_Preview()
  System.Void set_Priority(System.Int32 value)
  System.Int32 get_Priority()
  System.Void set_Pressure(System.Single value)
  System.Single get_Pressure()
  PaintIn3D.P3dPointConnector get_Connector()
  System.Void ManuallyHitNow()
  System.Void ClearHitCache()
  System.Void ResetConnections()
  System.Void OnEnable()
  System.Void Update()
  System.Void FixedUpdate()
  System.Void SubmitHit(System.Boolean preview)
  System.Void UpdateHit()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dHitParticles
TYPE:  class
TOKEN: 0x2000026
EXTENDS: MonoBehaviour
FIELDS:
  private           PaintIn3D.P3dHitParticles.EmitTypeemit  // 0x18
  private           System.Single                   raycastDistance  // 0x1C
  private           UnityEngine.LayerMask           layers  // 0x20
  private           PaintIn3D.P3dHitParticles.OrientationTypeorientation  // 0x24
  private           UnityEngine.Camera              _camera  // 0x28
  private           PaintIn3D.P3dHitParticles.NormalTypenormal  // 0x30
  private           System.Single                   offset  // 0x34
  private           System.Int32                    skip  // 0x38
  private           System.Boolean                  preview  // 0x3C
  private           System.Int32                    priority  // 0x40
  private           PaintIn3D.P3dHitParticles.PressureTypepressureMode  // 0x44
  private           System.Single                   pressureMin  // 0x48
  private           System.Single                   pressureMax  // 0x4C
  private           System.Single                   pressureConstant  // 0x50
  private           System.Single                   pressureMultiplier  // 0x54
  private           UnityEngine.GameObject          root  // 0x58
  private           UnityEngine.ParticleSystem      cachedParticleSystem  // 0x60
  private           System.Boolean                  cachedParticleSystemSet  // 0x68
  private   static  System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent>particleCollisionEvents  // 0x0
  private           PaintIn3D.P3dHitCache           hitCache  // 0x70
  private           System.Int32                    skipCounter  // 0x78
METHODS:
  System.Void set_Emit(PaintIn3D.P3dHitParticles.EmitType value)
  PaintIn3D.P3dHitParticles.EmitType get_Emit()
  System.Void set_RaycastDistance(System.Single value)
  System.Single get_RaycastDistance()
  System.Void set_Layers(UnityEngine.LayerMask value)
  UnityEngine.LayerMask get_Layers()
  System.Void set_Orientation(PaintIn3D.P3dHitParticles.OrientationType value)
  PaintIn3D.P3dHitParticles.OrientationType get_Orientation()
  System.Void set_Camera(UnityEngine.Camera value)
  UnityEngine.Camera get_Camera()
  System.Void set_Normal(PaintIn3D.P3dHitParticles.NormalType value)
  PaintIn3D.P3dHitParticles.NormalType get_Normal()
  System.Void set_Offset(System.Single value)
  System.Single get_Offset()
  System.Void set_Skip(System.Int32 value)
  System.Int32 get_Skip()
  System.Void set_Preview(System.Boolean value)
  System.Boolean get_Preview()
  System.Void set_Priority(System.Int32 value)
  System.Int32 get_Priority()
  System.Void set_PressureMode(PaintIn3D.P3dHitParticles.PressureType value)
  PaintIn3D.P3dHitParticles.PressureType get_PressureMode()
  System.Void set_PressureMin(System.Single value)
  System.Single get_PressureMin()
  System.Void set_PressureMax(System.Single value)
  System.Single get_PressureMax()
  System.Void set_PressureConstant(System.Single value)
  System.Single get_PressureConstant()
  System.Void set_PressureMultiplier(System.Single value)
  System.Single get_PressureMultiplier()
  System.Void set_Root(UnityEngine.GameObject value)
  UnityEngine.GameObject get_Root()
  PaintIn3D.P3dHitCache get_HitCache()
  System.Void ClearHitCache()
  System.Boolean TryGetRaycastHit(UnityEngine.ParticleCollisionEvent collision, UnityEngine.RaycastHit& hit)
  System.Void OnParticleCollision(UnityEngine.GameObject hitGameObject)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dHitScreen
TYPE:  class
TOKEN: 0x200002B
EXTENDS: P3dHitScreenBase
FIELDS:
  private           PaintIn3D.P3dHitScreen.FrequencyTypefrequency  // 0x70
  private           System.Single                   interval  // 0x74
  private           PaintIn3D.P3dPointConnector     connector  // 0x78
  private           System.Collections.Generic.List<PaintIn3D.P3dHitScreen.Link>links  // 0x80
METHODS:
  System.Void set_Frequency(PaintIn3D.P3dHitScreen.FrequencyType value)
  PaintIn3D.P3dHitScreen.FrequencyType get_Frequency()
  System.Void set_Interval(System.Single value)
  System.Single get_Interval()
  PaintIn3D.P3dPointConnector get_Connector()
  System.Void ClearHitCache()
  System.Void ResetConnections()
  System.Void OnEnable()
  System.Void Update()
  System.Void HandleFingerUpdate(CW.Common.CwInputManager.Finger finger, System.Boolean down, System.Boolean up)
  System.Void HandleFingerUp(CW.Common.CwInputManager.Finger finger)
  System.Void PaintSmooth(PaintIn3D.P3dHitScreen.Link link, System.Boolean down, System.Single pixelSpacing)
  System.Void OnFingerUp(PaintIn3D.P3dHitScreen.Link link)
  System.Void PaintInterval(PaintIn3D.P3dHitScreen.Link link, System.Boolean down)
  System.Void PaintRelease(PaintIn3D.P3dHitScreen.Link link, System.Boolean up)
  System.Void PaintPress(PaintIn3D.P3dHitScreen.Link link, System.Boolean down)
  System.Void PaintEvery(PaintIn3D.P3dHitScreen.Link link, System.Boolean down)
  System.Void RecordAndPaintAt(PaintIn3D.P3dHitScreen.Link link, UnityEngine.Vector2 screenNew, UnityEngine.Vector2 screenOld, System.Boolean preview, System.Single pressure, System.Object owner)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dHitScreenBase
TYPE:  class
TOKEN: 0x200002E
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Camera              _camera  // 0x18
  private           UnityEngine.LayerMask           layers  // 0x20
  private           PaintIn3D.P3dHitScreenBase.ButtonTypesrequiredButtons  // 0x24
  private           UnityEngine.KeyCode             requiredKey  // 0x28
  private           UnityEngine.LayerMask           guiLayers  // 0x2C
  private           PaintIn3D.P3dHitScreenBase.EmitTypeemit  // 0x30
  private           PaintIn3D.P3dHitScreenBase.RotationTyperotateTo  // 0x34
  private           PaintIn3D.P3dHitScreenBase.DirectionTypenormalDirection  // 0x38
  private           PaintIn3D.P3dHitScreenBase.RelativeTypenormalRelativeTo  // 0x3C
  private           UnityEngine.Transform           customTransform  // 0x40
  private           System.Single                   normalOffset  // 0x48
  private           System.Single                   mouseOffset  // 0x4C
  private           System.Single                   touchOffset  // 0x50
  protected         System.Boolean                  storeStates  // 0x54
  protected         System.Boolean                  showPreview  // 0x55
  private           System.Int32                    priority  // 0x58
  protected         System.Collections.Generic.List<CW.Common.CwInputManager.Finger>fingers  // 0x60
  protected         System.Boolean                  keyPressed  // 0x68
METHODS:
  System.Void set_Camera(UnityEngine.Camera value)
  UnityEngine.Camera get_Camera()
  System.Void set_Layers(UnityEngine.LayerMask value)
  UnityEngine.LayerMask get_Layers()
  System.Void set_RequiredButtons(PaintIn3D.P3dHitScreenBase.ButtonTypes value)
  PaintIn3D.P3dHitScreenBase.ButtonTypes get_RequiredButtons()
  System.Void set_RequiredKey(UnityEngine.KeyCode value)
  UnityEngine.KeyCode get_RequiredKey()
  System.Void set_GuiLayers(UnityEngine.LayerMask value)
  UnityEngine.LayerMask get_GuiLayers()
  System.Void set_Emit(PaintIn3D.P3dHitScreenBase.EmitType value)
  PaintIn3D.P3dHitScreenBase.EmitType get_Emit()
  System.Void set_RotateTo(PaintIn3D.P3dHitScreenBase.RotationType value)
  PaintIn3D.P3dHitScreenBase.RotationType get_RotateTo()
  System.Void set_NormalDirection(PaintIn3D.P3dHitScreenBase.DirectionType value)
  PaintIn3D.P3dHitScreenBase.DirectionType get_NormalDirection()
  System.Void set_NormalRelativeTo(PaintIn3D.P3dHitScreenBase.RelativeType value)
  PaintIn3D.P3dHitScreenBase.RelativeType get_NormalRelativeTo()
  System.Void set_CustomTransform(UnityEngine.Transform value)
  UnityEngine.Transform get_CustomTransform()
  System.Void set_NormalOffset(System.Single value)
  System.Single get_NormalOffset()
  System.Void set_MouseOffset(System.Single value)
  System.Single get_MouseOffset()
  System.Void set_TouchOffset(System.Single value)
  System.Single get_TouchOffset()
  System.Void set_StoreStates(System.Boolean value)
  System.Boolean get_StoreStates()
  System.Void set_ShowPreview(System.Boolean value)
  System.Boolean get_ShowPreview()
  System.Void set_Priority(System.Int32 value)
  System.Int32 get_Priority()
  System.Boolean get_NeedsDrawAngle()
  System.Void OnEnable()
  System.Void LateUpdate()
  System.Void HandleFingerUpdate(CW.Common.CwInputManager.Finger finger, System.Boolean down, System.Boolean up)
  System.Void HandleFingerUp(CW.Common.CwInputManager.Finger finger)
  System.Void OnDisable()
  System.Boolean FingerWentDown(CW.Common.CwInputManager.Finger finger)
  System.Void HandleFingerDown(CW.Common.CwInputManager.Finger finger)
  System.Void DoQuery(UnityEngine.Vector2 screenPosition, UnityEngine.Camera& camera, UnityEngine.Ray& ray, UnityEngine.RaycastHit& hit3D, UnityEngine.RaycastHit2D& hit2D)
  System.Void PaintAt(PaintIn3D.P3dPointConnector connector, PaintIn3D.P3dHitCache hitCache, UnityEngine.Vector2 screenPosition, UnityEngine.Vector2 screenPositionOld, System.Boolean preview, System.Single pressure, System.Object owner)
  System.Void CalcHitData(UnityEngine.Vector3 hitPoint, UnityEngine.Vector3 hitNormal, UnityEngine.Ray ray, UnityEngine.Camera camera, UnityEngine.Vector2 screenPositionOld, UnityEngine.Vector3& finalPosition, UnityEngine.Quaternion& finalRotation)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dHitScreenFill
TYPE:  class
TOKEN: 0x2000034
EXTENDS: P3dHitScreen
FIELDS:
  private           System.Single                   fillSpacing  // 0x88
METHODS:
  System.Void set_FillSpacing(System.Single value)
  System.Single get_FillSpacing()
  System.Void OnFingerUp(PaintIn3D.P3dHitScreen.Link link)
  UnityEngine.Rect GetArea(System.Collections.Generic.List<UnityEngine.Vector2> points)
  System.Double LineSide(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 p)
  System.Boolean Contains(System.Collections.Generic.List<UnityEngine.Vector2> points, UnityEngine.Vector2 xy)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dHitScreenLine
TYPE:  class
TOKEN: 0x2000035
EXTENDS: P3dHitScreenBase
FIELDS:
  private           PaintIn3D.P3dHitScreenLine.FrequencyTypefrequency  // 0x70
  private           System.Single                   interval  // 0x74
  private           System.Single                   position  // 0x78
  private           System.Single                   pixelOffset  // 0x7C
  private           PaintIn3D.P3dPointConnector     connector  // 0x80
METHODS:
  System.Void set_Frequency(PaintIn3D.P3dHitScreenLine.FrequencyType value)
  PaintIn3D.P3dHitScreenLine.FrequencyType get_Frequency()
  System.Void set_Interval(System.Single value)
  System.Single get_Interval()
  System.Void set_Position(System.Single value)
  System.Single get_Position()
  System.Void set_PixelOffset(System.Single value)
  System.Single get_PixelOffset()
  PaintIn3D.P3dPointConnector get_Connector()
  System.Void ClearHitCache()
  System.Void ResetConnections()
  System.Void OnEnable()
  System.Void Update()
  System.Void HandleFingerUpdate(CW.Common.CwInputManager.Finger finger, System.Boolean down, System.Boolean up)
  System.Void PaintStartEnd(CW.Common.CwInputManager.Finger finger, System.Boolean up)
  System.Void PaintStartInterval(CW.Common.CwInputManager.Finger finger, System.Boolean up, System.Single pixelSpacing, System.Boolean stretch)
  System.Void PaintOne(CW.Common.CwInputManager.Finger finger, System.Boolean up, System.Single frac, System.Single pixelOff)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dHitThrough
TYPE:  class
TOKEN: 0x2000037
EXTENDS: MonoBehaviour
FIELDS:
  private           PaintIn3D.P3dHitThrough.PhaseTypepaintIn  // 0x18
  private           System.Single                   interval  // 0x1C
  private           UnityEngine.Transform           pointA  // 0x20
  private           UnityEngine.Transform           pointB  // 0x28
  private           PaintIn3D.P3dHitThrough.OrientationTypeorientation  // 0x30
  private           UnityEngine.Camera              _camera  // 0x38
  private           System.Single                   pressure  // 0x40
  private           System.Boolean                  preview  // 0x44
  private           System.Int32                    priority  // 0x48
  private           UnityEngine.LineRenderer        line  // 0x50
  private           PaintIn3D.P3dLineConnector      connector  // 0x58
  private           System.Single                   current  // 0x60
METHODS:
  System.Void set_PaintIn(PaintIn3D.P3dHitThrough.PhaseType value)
  PaintIn3D.P3dHitThrough.PhaseType get_PaintIn()
  System.Void set_Interval(System.Single value)
  System.Single get_Interval()
  System.Void set_PointA(UnityEngine.Transform value)
  UnityEngine.Transform get_PointA()
  System.Void set_PointB(UnityEngine.Transform value)
  UnityEngine.Transform get_PointB()
  System.Void set_Orientation(PaintIn3D.P3dHitThrough.OrientationType value)
  PaintIn3D.P3dHitThrough.OrientationType get_Orientation()
  System.Void set_Camera(UnityEngine.Camera value)
  UnityEngine.Camera get_Camera()
  System.Void set_Pressure(System.Single value)
  System.Single get_Pressure()
  System.Void set_Preview(System.Boolean value)
  System.Boolean get_Preview()
  System.Void set_Priority(System.Int32 value)
  System.Int32 get_Priority()
  System.Void set_Line(UnityEngine.LineRenderer value)
  UnityEngine.LineRenderer get_Line()
  PaintIn3D.P3dLineConnector get_Connector()
  System.Void ManuallyHitNow()
  System.Void ClearHitCache()
  System.Void ResetConnections()
  System.Void OnEnable()
  System.Void Update()
  System.Void LateUpdate()
  System.Void FixedUpdate()
  System.Void SubmitHit(System.Boolean preview)
  System.Void UpdateHit()
  System.Void UpdatePointAndLine()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.IClone
TYPE:  interface
TOKEN: 0x200003A
FIELDS:
METHODS:
  System.Void Transform(UnityEngine.Matrix4x4& posMatrix, UnityEngine.Matrix4x4& rotMatrix)
END_CLASS

CLASS: PaintIn3D.IHit
TYPE:  interface
TOKEN: 0x200003B
FIELDS:
METHODS:
END_CLASS

CLASS: PaintIn3D.IHitCoord
TYPE:  interface
TOKEN: 0x200003C
FIELDS:
METHODS:
  System.Void HandleHitCoord(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation)
END_CLASS

CLASS: PaintIn3D.IHitLine
TYPE:  interface
TOKEN: 0x200003D
FIELDS:
METHODS:
  System.Void HandleHitLine(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Quaternion rotation, System.Boolean clip)
END_CLASS

CLASS: PaintIn3D.IHitPoint
TYPE:  interface
TOKEN: 0x200003E
FIELDS:
METHODS:
  System.Void HandleHitPoint(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
END_CLASS

CLASS: PaintIn3D.IHitQuad
TYPE:  interface
TOKEN: 0x200003F
FIELDS:
METHODS:
  System.Void HandleHitQuad(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2, UnityEngine.Quaternion rotation, System.Boolean clip)
END_CLASS

CLASS: PaintIn3D.IHitTriangle
TYPE:  interface
TOKEN: 0x2000040
FIELDS:
METHODS:
  System.Void HandleHitTriangle(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC, UnityEngine.Quaternion rotation)
END_CLASS

CLASS: PaintIn3D.IBrowsable
TYPE:  interface
TOKEN: 0x2000041
FIELDS:
METHODS:
  System.String GetCategory()
  System.String GetTitle()
  UnityEngine.Texture2D GetIcon()
  UnityEngine.Object GetObject()
END_CLASS

CLASS: PaintIn3D.P3dHitScreen_InEditor
TYPE:  class
TOKEN: 0x2000042
EXTENDS: P3dHitScreen
FIELDS:
METHODS:
  System.Void DoQuery(UnityEngine.Vector2 screenPosition, UnityEngine.Camera& camera, UnityEngine.Ray& ray, UnityEngine.RaycastHit& hit3D, UnityEngine.RaycastHit2D& hit2D)
  System.Void LateUpdate()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dMaterial
TYPE:  class
TOKEN: 0x2000043
EXTENDS: MonoBehaviour
FIELDS:
  private           System.String                   category  // 0x18
  private           UnityEngine.Texture2D           icon  // 0x20
  private           System.Collections.Generic.List<UnityEngine.Texture>textures  // 0x28
  private   static  System.Collections.Generic.List<PaintIn3D.P3dMaterial>cachedMaterials  // 0x0
METHODS:
  System.Void set_Category(System.String value)
  System.String get_Category()
  System.Void set_Icon(UnityEngine.Texture2D value)
  UnityEngine.Texture2D get_Icon()
  System.Collections.Generic.List<UnityEngine.Texture> get_Textures()
  System.Collections.Generic.List<PaintIn3D.P3dMaterial> get_CachedMaterials()
  System.Void ClearCache()
  System.String GetCategory()
  System.String GetTitle()
  UnityEngine.Texture2D GetIcon()
  UnityEngine.Object GetObject()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dPreset
TYPE:  class
TOKEN: 0x2000044
EXTENDS: MonoBehaviour
FIELDS:
  private           System.String                   title  // 0x18
  private           System.Boolean                  addMaterialCloner  // 0x20
  private   static  System.Collections.Generic.List<PaintIn3D.P3dPreset>cachedPresets  // 0x0
METHODS:
  System.Void set_Title(System.String value)
  System.String get_Title()
  System.Void set_AddMaterialCloner(System.Boolean value)
  System.Boolean get_AddMaterialCloner()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dSeamFixer
TYPE:  class
TOKEN: 0x2000045
EXTENDS: ScriptableObject
FIELDS:
  private           UnityEngine.Mesh                source  // 0x18
  private           UnityEngine.Mesh                mesh  // 0x20
  private           System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Pair>meshes  // 0x28
  private           PaintIn3D.P3dCoord              coord  // 0x30
  private           System.Single                   threshold  // 0x34
  private           System.Single                   border  // 0x38
  private   static  System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh>cacheFirst  // 0x0
  private   static  System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh>cacheSecond  // 0x8
  private   static  System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh>cacheThird  // 0x10
  private   static  System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh>cacheFourth  // 0x18
METHODS:
  System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Pair> get_Meshes()
  System.Void set_Coord(PaintIn3D.P3dCoord value)
  PaintIn3D.P3dCoord get_Coord()
  System.Void set_Threshold(System.Single value)
  System.Single get_Threshold()
  System.Void set_Border(System.Single value)
  System.Single get_Border()
  UnityEngine.Mesh GetCachedMesh(UnityEngine.Mesh source, PaintIn3D.P3dCoord coord, System.Boolean allowGeneration)
  UnityEngine.Mesh TryGetCachedMesh(System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> cache, UnityEngine.Mesh source, PaintIn3D.P3dCoord coord, System.Boolean allowGeneration)
  System.Void AddMesh(UnityEngine.Mesh mesh)
  System.Void ConvertLegacy()
  System.Void Generate()
  System.Void Generate(UnityEngine.Mesh source, UnityEngine.Mesh output, PaintIn3D.P3dCoord coord, System.Single threshold, System.Single border)
  System.Void AddCoord(System.Collections.Generic.List<UnityEngine.Vector4> coords, PaintIn3D.P3dSeamFixer.Insertion insertion, System.Boolean write)
  System.Void FixSeams(UnityEngine.Mesh source, UnityEngine.Mesh output, System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> submeshes, System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Ring> rings, System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Insertion> insertions, PaintIn3D.P3dCoord coord)
  System.Void TraceEdges(PaintIn3D.P3dSeamFixer.Ring ring, PaintIn3D.P3dSeamFixer.Point point)
  System.Void AddPoint(System.Collections.Generic.Dictionary<UnityEngine.Vector2,PaintIn3D.P3dSeamFixer.Point> points, UnityEngine.Vector2 coord, System.Int32 index)
  System.Void AddTriangle(System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Edge> edges, PaintIn3D.P3dSeamFixer.Point pointA, PaintIn3D.P3dSeamFixer.Point pointB, PaintIn3D.P3dSeamFixer.Point pointC)
  System.Void AddTriangle2(System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Edge> edges, PaintIn3D.P3dSeamFixer.Point pointA, PaintIn3D.P3dSeamFixer.Point pointB, PaintIn3D.P3dSeamFixer.Point pointC, System.Boolean flip)
  System.Void RemoveOrAddEdge(System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Edge> edges, PaintIn3D.P3dSeamFixer.Point pointA, PaintIn3D.P3dSeamFixer.Point pointB, System.Boolean flip)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dShape
TYPE:  class
TOKEN: 0x200004B
EXTENDS: MonoBehaviour
FIELDS:
  private           System.String                   category  // 0x18
  private           UnityEngine.Texture2D           icon  // 0x20
  private   static  System.Collections.Generic.List<PaintIn3D.P3dShape>cachedShapes  // 0x0
METHODS:
  System.Void set_Category(System.String value)
  System.String get_Category()
  System.Void set_Icon(UnityEngine.Texture2D value)
  UnityEngine.Texture2D get_Icon()
  System.Collections.Generic.List<PaintIn3D.P3dShape> get_CachedShapes()
  System.Void ClearCache()
  System.String GetCategory()
  System.String GetTitle()
  UnityEngine.Texture2D GetIcon()
  UnityEngine.Object GetObject()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dTool
TYPE:  class
TOKEN: 0x200004C
EXTENDS: MonoBehaviour
FIELDS:
  private           System.String                   category  // 0x18
  private           UnityEngine.Texture2D           icon  // 0x20
  private   static  System.Collections.Generic.List<PaintIn3D.P3dTool>cachedTools  // 0x0
METHODS:
  System.Void set_Category(System.String value)
  System.String get_Category()
  System.Void set_Icon(UnityEngine.Texture2D value)
  UnityEngine.Texture2D get_Icon()
  System.Collections.Generic.List<PaintIn3D.P3dTool> get_CachedTools()
  System.Void ClearCache()
  System.String GetCategory()
  System.String GetTitle()
  UnityEngine.Texture2D GetIcon()
  UnityEngine.Object GetObject()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dModifyAngleRandom
TYPE:  class
TOKEN: 0x200004D
EXTENDS: P3dModifier
FIELDS:
  public    static  System.String                   Group  // 0x0
  public    static  System.String                   Title  // 0x8
  private           System.Single                   min  // 0x18
  private           System.Single                   max  // 0x1C
  private           PaintIn3D.P3dModifyAngleRandom.BlendTypeblend  // 0x20
METHODS:
  System.Void set_Min(System.Single value)
  System.Single get_Min()
  System.Void set_Max(System.Single value)
  System.Single get_Max()
  System.Void set_Blend(PaintIn3D.P3dModifyAngleRandom.BlendType value)
  PaintIn3D.P3dModifyAngleRandom.BlendType get_Blend()
  System.Void OnModifyAngle(System.Single& angle, System.Single pressure)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dModifyColorRandom
TYPE:  class
TOKEN: 0x200004F
EXTENDS: P3dModifier
FIELDS:
  public    static  System.String                   Group  // 0x0
  public    static  System.String                   Title  // 0x8
  private           UnityEngine.Gradient            gradient  // 0x18
  private           PaintIn3D.P3dModifyColorRandom.BlendTypeblend  // 0x20
METHODS:
  UnityEngine.Gradient get_Gradient()
  System.Void set_Blend(PaintIn3D.P3dModifyColorRandom.BlendType value)
  PaintIn3D.P3dModifyColorRandom.BlendType get_Blend()
  System.Void OnModifyColor(UnityEngine.Color& color, System.Single pressure)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dModifyHardnessPressure
TYPE:  class
TOKEN: 0x2000051
EXTENDS: P3dModifier
FIELDS:
  public    static  System.String                   Group  // 0x0
  public    static  System.String                   Title  // 0x8
  private           System.Single                   hardness  // 0x18
  private           PaintIn3D.P3dModifyHardnessPressure.BlendTypeblend  // 0x1C
METHODS:
  System.Void set_Hardness(System.Single value)
  System.Single get_Hardness()
  System.Void set_Blend(PaintIn3D.P3dModifyHardnessPressure.BlendType value)
  PaintIn3D.P3dModifyHardnessPressure.BlendType get_Blend()
  System.Void OnModifyHardness(System.Single& currentHardness, System.Single pressure)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dModifyHardnessRandom
TYPE:  class
TOKEN: 0x2000053
EXTENDS: P3dModifier
FIELDS:
  public    static  System.String                   Group  // 0x0
  public    static  System.String                   Title  // 0x8
  private           System.Single                   min  // 0x18
  private           System.Single                   max  // 0x1C
  private           PaintIn3D.P3dModifyHardnessRandom.BlendTypeblend  // 0x20
METHODS:
  System.Void set_Min(System.Single value)
  System.Single get_Min()
  System.Void set_Max(System.Single value)
  System.Single get_Max()
  System.Void set_Blend(PaintIn3D.P3dModifyHardnessRandom.BlendType value)
  PaintIn3D.P3dModifyHardnessRandom.BlendType get_Blend()
  System.Void OnModifyHardness(System.Single& hardness, System.Single pressure)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dModifyOpacityPressure
TYPE:  class
TOKEN: 0x2000055
EXTENDS: P3dModifier
FIELDS:
  public    static  System.String                   Group  // 0x0
  public    static  System.String                   Title  // 0x8
  private           System.Single                   opacity  // 0x18
  private           PaintIn3D.P3dModifyOpacityPressure.BlendTypeblend  // 0x1C
METHODS:
  System.Void set_Opacity(System.Single value)
  System.Single get_Opacity()
  System.Void set_Blend(PaintIn3D.P3dModifyOpacityPressure.BlendType value)
  PaintIn3D.P3dModifyOpacityPressure.BlendType get_Blend()
  System.Void OnModifyOpacity(System.Single& currentOpacity, System.Single pressure)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dModifyOpacityRandom
TYPE:  class
TOKEN: 0x2000057
EXTENDS: P3dModifier
FIELDS:
  public    static  System.String                   Group  // 0x0
  public    static  System.String                   Title  // 0x8
  private           System.Single                   min  // 0x18
  private           System.Single                   max  // 0x1C
  private           PaintIn3D.P3dModifyOpacityRandom.BlendTypeblend  // 0x20
METHODS:
  System.Void set_Min(System.Single value)
  System.Single get_Min()
  System.Void set_Max(System.Single value)
  System.Single get_Max()
  System.Void set_Blend(PaintIn3D.P3dModifyOpacityRandom.BlendType value)
  PaintIn3D.P3dModifyOpacityRandom.BlendType get_Blend()
  System.Void OnModifyOpacity(System.Single& opacity, System.Single pressure)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dModifyPositionRandom
TYPE:  class
TOKEN: 0x2000059
EXTENDS: P3dModifier
FIELDS:
  public    static  System.String                   Group  // 0x0
  public    static  System.String                   Title  // 0x8
  private           System.Single                   radius  // 0x18
METHODS:
  System.Void set_Radius(System.Single value)
  System.Single get_Radius()
  System.Void OnModifyPosition(UnityEngine.Vector3& position, System.Single pressure)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dModifyRadiusPressure
TYPE:  class
TOKEN: 0x200005A
EXTENDS: P3dModifier
FIELDS:
  public    static  System.String                   Group  // 0x0
  public    static  System.String                   Title  // 0x8
  private           System.Single                   radius  // 0x18
  private           PaintIn3D.P3dModifyRadiusPressure.BlendTypeblend  // 0x1C
METHODS:
  System.Void set_Radius(System.Single value)
  System.Single get_Radius()
  System.Void set_Blend(PaintIn3D.P3dModifyRadiusPressure.BlendType value)
  PaintIn3D.P3dModifyRadiusPressure.BlendType get_Blend()
  System.Void OnModifyRadius(System.Single& currentRadius, System.Single pressure)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dModifyRadiusRandom
TYPE:  class
TOKEN: 0x200005C
EXTENDS: P3dModifier
FIELDS:
  public    static  System.String                   Group  // 0x0
  public    static  System.String                   Title  // 0x8
  private           System.Single                   min  // 0x18
  private           System.Single                   max  // 0x1C
  private           PaintIn3D.P3dModifyRadiusRandom.BlendTypeblend  // 0x20
METHODS:
  System.Void set_Min(System.Single value)
  System.Single get_Min()
  System.Void set_Max(System.Single value)
  System.Single get_Max()
  System.Void set_Blend(PaintIn3D.P3dModifyRadiusRandom.BlendType value)
  PaintIn3D.P3dModifyRadiusRandom.BlendType get_Blend()
  System.Void OnModifyRadius(System.Single& radius, System.Single pressure)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dModifyScaleRandom
TYPE:  class
TOKEN: 0x200005E
EXTENDS: P3dModifier
FIELDS:
  public    static  System.String                   Group  // 0x0
  public    static  System.String                   Title  // 0x8
  private           UnityEngine.Vector3             min  // 0x18
  private           UnityEngine.Vector3             max  // 0x24
  private           PaintIn3D.P3dModifyScaleRandom.BlendTypeblend  // 0x30
  private           System.Boolean                  uniform  // 0x34
METHODS:
  System.Void set_Min(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_Min()
  System.Void set_Max(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_Max()
  System.Void set_Blend(PaintIn3D.P3dModifyScaleRandom.BlendType value)
  PaintIn3D.P3dModifyScaleRandom.BlendType get_Blend()
  System.Void set_Uniform(System.Boolean value)
  System.Boolean get_Uniform()
  System.Void OnModifyScale(UnityEngine.Vector3& scale, System.Single pressure)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dModifyTexturePressure
TYPE:  class
TOKEN: 0x2000060
EXTENDS: P3dModifier
FIELDS:
  public    static  System.String                   Group  // 0x0
  public    static  System.String                   Title  // 0x8
  private           UnityEngine.Texture             texture  // 0x18
  private           System.Single                   pressureMin  // 0x20
  private           System.Single                   pressureMax  // 0x24
METHODS:
  System.Void set_Texture(UnityEngine.Texture value)
  UnityEngine.Texture get_Texture()
  System.Void set_PressureMin(System.Single value)
  System.Single get_PressureMin()
  System.Void set_PressureMax(System.Single value)
  System.Single get_PressureMax()
  System.Void OnModifyTexture(UnityEngine.Texture& currentTexture, System.Single pressure)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dModifyTextureRandom
TYPE:  class
TOKEN: 0x2000061
EXTENDS: P3dModifier
FIELDS:
  public    static  System.String                   Group  // 0x0
  public    static  System.String                   Title  // 0x8
  private           System.Collections.Generic.List<UnityEngine.Texture>textures  // 0x18
METHODS:
  System.Collections.Generic.List<UnityEngine.Texture> get_Textures()
  System.Void OnModifyTexture(UnityEngine.Texture& texture, System.Single pressure)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dBlendMode
TYPE:  struct
TOKEN: 0x2000062
FIELDS:
  public    static  System.Int32                    ALPHA_BLEND  // 0x0
  public    static  System.Int32                    ALPHA_BLEND_INVERSE  // 0x0
  public    static  System.Int32                    PREMULTIPLIED  // 0x0
  public    static  System.Int32                    ADDITIVE  // 0x0
  public    static  System.Int32                    ADDITIVE_SOFT  // 0x0
  public    static  System.Int32                    SUBTRACTIVE  // 0x0
  public    static  System.Int32                    SUBTRACTIVE_SOFT  // 0x0
  public    static  System.Int32                    REPLACE  // 0x0
  public    static  System.Int32                    REPLACE_ORIGINAL  // 0x0
  public    static  System.Int32                    REPLACE_CUSTOM  // 0x0
  public    static  System.Int32                    MULTIPLY_INVERSE_RGB  // 0x0
  public    static  System.Int32                    BLUR  // 0x0
  public    static  System.Int32                    NORMAL_BLEND  // 0x0
  public    static  System.Int32                    NORMAL_REPLACE  // 0x0
  public    static  System.Int32                    FLOW  // 0x0
  public    static  System.Int32                    NORMAL_REPLACE_ORIGINAL  // 0x0
  public    static  System.Int32                    NORMAL_REPLACE_CUSTOM  // 0x0
  public    static  System.Int32                    COUNT  // 0x0
  public    static readonly System.String[]                 NAMES  // 0x0
  public            System.Int32                    Index  // 0x10
  public            UnityEngine.Color               Color  // 0x14
  public            UnityEngine.Texture             Texture  // 0x28
  public            System.Single                   Kernel  // 0x30
  public            UnityEngine.Vector4             Channels  // 0x34
  private   static  System.Int32                    _Channels  // 0x8
  private   static  System.Int32                    _ReplaceColor  // 0xC
  private   static  System.Int32                    _ReplaceTexture  // 0x10
  private   static  System.Int32                    _ReplaceTextureSize  // 0x14
  private   static  System.Int32                    _Kernel  // 0x18
METHODS:
  PaintIn3D.P3dBlendMode AlphaBlend(UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode AlphaBlendInverse(UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode Premultiplied(UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode Additive(UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode AdditiveSoft(UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode Subtractive(UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode SubtractiveSoft(UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode Replace(UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode ReplaceOriginal(UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode ReplaceCustom(UnityEngine.Color color, UnityEngine.Texture texture, UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode MultiplyInverseRGB(UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode Blur(System.Single kernel, UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode NormalBlend(UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode NormalReplace(UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode Flow(System.Single kernel, UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode NormalReplaceOriginal(UnityEngine.Vector4 channels)
  PaintIn3D.P3dBlendMode NormalReplaceCustom(UnityEngine.Color color, UnityEngine.Texture texture, UnityEngine.Vector4 channels)
  System.Void Apply(UnityEngine.Material material)
  System.String GetName(System.Int32 index)
  System.Boolean op_Equality(PaintIn3D.P3dBlendMode a, System.Int32 b)
  System.Boolean op_Inequality(PaintIn3D.P3dBlendMode a, System.Int32 b)
  System.Int32 op_Implicit(PaintIn3D.P3dBlendMode a)
  System.Int32 GetHashCode()
  System.Boolean Equals(System.Object obj)
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dBlit
TYPE:  class
TOKEN: 0x2000063
FIELDS:
  private   static  UnityEngine.Material            cachedWhite  // 0x0
  private   static  System.Boolean                  cachedWhiteSet  // 0x8
  private   static  UnityEngine.Material            cachedTexture  // 0x10
  private   static  System.Boolean                  cachedTextureSet  // 0x18
  private   static  UnityEngine.Material            cachedNormal  // 0x20
  private   static  System.Boolean                  cachedNormalSet  // 0x28
  private   static  UnityEngine.Material            cachedPremultiply  // 0x30
  private   static  System.Boolean                  cachedPremultiplySet  // 0x38
  private   static  System.Int32                    _Buffer  // 0x3C
  private   static  System.Int32                    _BufferSize  // 0x40
  private   static  System.Int32                    _Texture  // 0x44
  private   static  System.Int32                    _Color  // 0x48
METHODS:
  System.Void White(UnityEngine.RenderTexture rendertexture, UnityEngine.Mesh mesh, System.Int32 submesh, PaintIn3D.P3dCoord coord)
  System.Void Texture(UnityEngine.RenderTexture rendertexture, UnityEngine.Mesh mesh, System.Int32 submesh, UnityEngine.Texture texture, PaintIn3D.P3dCoord coord)
  System.Void Normal(UnityEngine.RenderTexture rendertexture, UnityEngine.Texture texture)
  System.Void Premultiply(UnityEngine.RenderTexture rendertexture, UnityEngine.Texture texture, UnityEngine.Color tint)
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dChangeCounter
TYPE:  class
TOKEN: 0x2000064
EXTENDS: P3dPaintableTextureMonitorMask
FIELDS:
  public    static  System.Collections.Generic.LinkedList<PaintIn3D.P3dChangeCounter>Instances  // 0x0
  private           System.Collections.Generic.LinkedListNode<PaintIn3D.P3dChangeCounter>instancesNode  // 0x98
  private           System.Single                   threshold  // 0xA0
  private           UnityEngine.Texture             texture  // 0xA8
  private           UnityEngine.Color               color  // 0xB0
  private           System.Int32                    count  // 0xC0
  private           PaintIn3D.P3dReader             changeReader  // 0xC8
  protected         Unity.Collections.NativeArray<UnityEngine.Color32>changePixels  // 0xD0
METHODS:
  System.Void set_Threshold(System.Single value)
  System.Single get_Threshold()
  System.Void set_Texture(UnityEngine.Texture value)
  UnityEngine.Texture get_Texture()
  System.Void set_Color(UnityEngine.Color value)
  UnityEngine.Color get_Color()
  System.Int32 get_Count()
  System.Single get_Ratio()
  PaintIn3D.P3dReader get_ChangeReader()
  System.Void MarkChangeReaderAsDirty()
  System.Int64 GetTotal(System.Collections.Generic.ICollection<PaintIn3D.P3dChangeCounter> counters)
  System.Int64 GetCount(System.Collections.Generic.ICollection<PaintIn3D.P3dChangeCounter> counters)
  System.Single GetRatio(System.Collections.Generic.ICollection<PaintIn3D.P3dChangeCounter> counters)
  System.Void HandleCompleteChange(Unity.Collections.NativeArray<UnityEngine.Color32> pixels)
  System.Void HandleComplete(System.Int32 boost)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void Update()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dChannel
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dChannel            Red  // 0x0
  public    static  PaintIn3D.P3dChannel            Green  // 0x0
  public    static  PaintIn3D.P3dChannel            Blue  // 0x0
  public    static  PaintIn3D.P3dChannel            Alpha  // 0x0
METHODS:
END_CLASS

CLASS: PaintIn3D.P3dChannelCounter
TYPE:  class
TOKEN: 0x2000066
EXTENDS: P3dPaintableTextureMonitorMask
FIELDS:
  public    static  System.Collections.Generic.LinkedList<PaintIn3D.P3dChannelCounter>Instances  // 0x0
  private           System.Collections.Generic.LinkedListNode<PaintIn3D.P3dChannelCounter>instancesNode  // 0x98
  private           System.Single                   threshold  // 0xA0
  private           System.Int32                    countR  // 0xA4
  private           System.Int32                    countG  // 0xA8
  private           System.Int32                    countB  // 0xAC
  private           System.Int32                    countA  // 0xB0
METHODS:
  System.Void set_Threshold(System.Single value)
  System.Single get_Threshold()
  System.Int32 get_CountR()
  System.Int32 get_CountG()
  System.Int32 get_CountB()
  System.Int32 get_CountA()
  System.Single get_RatioR()
  System.Single get_RatioG()
  System.Single get_RatioB()
  System.Single get_RatioA()
  UnityEngine.Vector4 get_RatioRGBA()
  System.Int64 GetTotal(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters)
  System.Int64 GetCountR(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters)
  System.Int64 GetCountG(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters)
  System.Int64 GetCountB(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters)
  System.Int64 GetCountA(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters)
  System.Single GetRatioR(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters)
  System.Single GetRatioG(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters)
  System.Single GetRatioB(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters)
  System.Single GetRatioA(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters)
  UnityEngine.Vector4 GetRatioRGBA(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void HandleComplete(System.Int32 boost)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dClone
TYPE:  class
TOKEN: 0x2000067
EXTENDS: MonoBehaviour
FIELDS:
  public    static  System.Int32                    MatrixCount  // 0x0
  public    static  System.Int32                    ClonerCount  // 0x4
  private   static  System.Collections.Generic.List<UnityEngine.Matrix4x4>tempPosMatrices  // 0x8
  private   static  System.Collections.Generic.List<UnityEngine.Matrix4x4>tempRotMatrices  // 0x10
  private   static  System.Collections.Generic.List<PaintIn3D.IClone>tempCloners  // 0x18
  private   static  System.Collections.Generic.LinkedList<PaintIn3D.P3dClone>instances  // 0x20
  private           System.Collections.Generic.LinkedListNode<PaintIn3D.P3dClone>instancesNode  // 0x18
METHODS:
  System.Void Transform(UnityEngine.Matrix4x4& posMatrix, UnityEngine.Matrix4x4& rotMatrix)
  System.Collections.Generic.LinkedList<PaintIn3D.P3dClone> get_Instances()
  System.Void BuildCloners(System.Collections.Generic.List<PaintIn3D.IClone> cloners)
  System.Void Clone(PaintIn3D.P3dCommand command, System.Int32 clonerIndex, System.Int32 matrixIndex)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dCloneMirror
TYPE:  class
TOKEN: 0x2000068
EXTENDS: P3dClone
FIELDS:
  private           System.Boolean                  flip  // 0x20
METHODS:
  System.Void set_Flip(System.Boolean value)
  System.Boolean get_Flip()
  System.Void Transform(UnityEngine.Matrix4x4& posMatrix, UnityEngine.Matrix4x4& rotMatrix)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dColor
TYPE:  class
TOKEN: 0x2000069
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Color               color  // 0x18
  private           System.Collections.Generic.List<PaintIn3D.P3dColor.Contribution>contributions  // 0x28
  private   static  System.Collections.Generic.LinkedList<PaintIn3D.P3dColor>instances  // 0x0
  private           System.Collections.Generic.LinkedListNode<PaintIn3D.P3dColor>instancesNode  // 0x30
METHODS:
  System.Void set_Color(UnityEngine.Color value)
  UnityEngine.Color get_Color()
  System.Collections.Generic.LinkedList<PaintIn3D.P3dColor> get_Instances()
  System.Int32 get_Total()
  System.Int32 get_Solid()
  System.Single get_Ratio()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Contribute(PaintIn3D.P3dColorCounter counter, System.Int32 solid)
  System.Boolean TryGetContribution(PaintIn3D.P3dColorCounter counter, PaintIn3D.P3dColor.Contribution& contribution)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dColorCounter
TYPE:  class
TOKEN: 0x200006B
EXTENDS: P3dPaintableTextureMonitorMask
FIELDS:
  public    static  System.Collections.Generic.LinkedList<PaintIn3D.P3dColorCounter>Instances  // 0x0
  private           System.Collections.Generic.LinkedListNode<PaintIn3D.P3dColorCounter>instancesNode  // 0x98
  private           System.Single                   threshold  // 0xA0
  private           System.Collections.Generic.List<PaintIn3D.P3dColorCounter.Contribution>contributions  // 0xA8
METHODS:
  System.Void set_Threshold(System.Single value)
  System.Single get_Threshold()
  System.Collections.Generic.List<PaintIn3D.P3dColorCounter.Contribution> get_Contributions()
  System.Int64 GetTotal(System.Collections.Generic.ICollection<PaintIn3D.P3dColorCounter> counters)
  System.Int64 GetCount(PaintIn3D.P3dColor color, System.Collections.Generic.ICollection<PaintIn3D.P3dColorCounter> counters)
  System.Single GetRatio(PaintIn3D.P3dColor color, System.Collections.Generic.ICollection<PaintIn3D.P3dColorCounter> counters)
  System.Int32 Count(PaintIn3D.P3dColor color)
  System.Single Ratio(PaintIn3D.P3dColor color)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void HandleComplete(System.Int32 boost)
  System.Void ClearContributions()
  System.Void PrepareContributions()
  System.Void Contribute(System.Int32 scale)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dCommand
TYPE:  class
TOKEN: 0x200006D
FIELDS:
  public            System.Int32                    Index  // 0x10
  public            System.Boolean                  Preview  // 0x14
  public            System.Int32                    Priority  // 0x18
  public            PaintIn3D.P3dHashedMaterial     Material  // 0x20
  public            System.Int32                    Pass  // 0x30
  public            PaintIn3D.P3dHashedModel        Model  // 0x38
  public            System.Int32                    Submesh  // 0x48
  public            PaintIn3D.P3dHashedTexture      LocalMaskTexture  // 0x50
  public            UnityEngine.Vector4             LocalMaskChannel  // 0x60
  private   static  System.Int32                    _LocalMaskTexture  // 0x0
  private   static  System.Int32                    _LocalMaskChannel  // 0x4
METHODS:
  System.Void BuildMaterial(UnityEngine.Material& material, System.Int32& materialHash, System.String path, System.String keyword)
  System.Int32 Compare(PaintIn3D.P3dCommand a, PaintIn3D.P3dCommand b)
  System.Boolean get_RequireMesh()
  System.Void SetState(System.Boolean preview, System.Int32 priority)
  System.Void Apply(UnityEngine.Material material)
  System.Void Pool()
  System.Void Transform(UnityEngine.Matrix4x4 posMatrix, UnityEngine.Matrix4x4 rotMatrix)
  PaintIn3D.P3dCommand SpawnCopy()
  PaintIn3D.P3dCommand SpawnCopyLocal(UnityEngine.Transform transform)
  PaintIn3D.P3dCommand SpawnCopyWorld(UnityEngine.Transform transform)
  T SpawnCopy(System.Collections.Generic.Stack<T> pool)
  System.Void Apply(PaintIn3D.P3dPaintableTexture paintableTexture)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dCommon
TYPE:  class
TOKEN: 0x200006E
FIELDS:
  public    static  System.String                   HelpUrlPrefix  // 0x0
  public    static  System.String                   ComponentMenuPrefix  // 0x0
  public    static  System.String                   ComponentHitMenuPrefix  // 0x0
  public    static  System.Action<UnityEngine.Camera>OnCameraDraw  // 0x0
  private   static  System.Int32                    _Coord  // 0x8
  private   static  UnityEngine.Mesh                sphereMesh  // 0x10
  private   static  System.Boolean                  sphereMeshSet  // 0x18
  private   static  UnityEngine.Mesh                quadMesh  // 0x20
  private   static  System.Boolean                  quadMeshSet  // 0x28
  private   static  UnityEngine.Texture2D           tempReadTexture  // 0x30
METHODS:
  System.Void .cctor()
  System.Single RatioToPercentage(System.Single ratio01, System.Int32 decimalPlaces)
  UnityEngine.RenderTexture GetRenderTexture(UnityEngine.RenderTexture other)
  UnityEngine.RenderTexture GetRenderTexture(UnityEngine.RenderTextureDescriptor desc, UnityEngine.RenderTexture other)
  UnityEngine.RenderTexture GetRenderTexture(UnityEngine.RenderTextureDescriptor desc)
  UnityEngine.RenderTexture GetRenderTexture(UnityEngine.RenderTextureDescriptor desc, System.Boolean sRGB)
  UnityEngine.RenderTexture ReleaseRenderTexture(UnityEngine.RenderTexture renderTexture)
  UnityEngine.Quaternion NormalToCameraRotation(UnityEngine.Vector3 normal, UnityEngine.Camera optionalCamera)
  UnityEngine.Vector3 GetCameraUp(UnityEngine.Camera camera)
  System.Boolean CanReadPixels(UnityEngine.TextureFormat format)
  System.Void ReadPixelsLinearGamma(UnityEngine.Texture2D texture2D, UnityEngine.RenderTexture renderTexture)
  System.Void ReadPixels(UnityEngine.Texture2D texture2D, UnityEngine.RenderTexture renderTexture)
  System.Boolean Downsample(UnityEngine.RenderTexture renderTexture, System.Int32 steps, UnityEngine.RenderTexture& temporary)
  System.Boolean HasMipMaps(UnityEngine.Texture texture)
  UnityEngine.Mesh GetSphereMesh()
  UnityEngine.Mesh GetMesh(UnityEngine.GameObject root, UnityEngine.Mesh mesh)
  UnityEngine.Mesh GetQuadMesh()
  UnityEngine.Color GetPixel(UnityEngine.RenderTexture renderTexture, UnityEngine.Vector2 uv, System.Boolean mipMaps)
  UnityEngine.Texture2D GetReadableCopy(UnityEngine.Texture texture, UnityEngine.TextureFormat format, System.Boolean mipMaps, System.Int32 width, System.Int32 height)
  System.Void SaveBytes(System.String saveName, System.Byte[] data, System.Boolean save)
  System.Byte[] LoadBytes(System.String saveName)
  System.Boolean SaveExists(System.String saveName)
  System.Void ClearSave(System.String saveName, System.Boolean save)
  UnityEngine.Vector3 GetPosition(UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition)
  UnityEngine.Vector3 GetPosition(UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC)
  UnityEngine.Vector3 GetPosition(UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2)
  System.Single GetRadius(UnityEngine.Vector3 size)
  System.Single GetRadius(UnityEngine.Vector3 size, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition)
  System.Single GetRadius(UnityEngine.Vector3 size, UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC)
  System.Single GetRadius(UnityEngine.Vector3 size, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2)
  UnityEngine.Vector3 ScaleAspect(UnityEngine.Vector3 size, System.Single aspect)
  System.Single GetAspect(UnityEngine.Texture textureA, UnityEngine.Texture textureB)
  System.Void Blit(UnityEngine.RenderTexture renderTexture, UnityEngine.Texture other)
  System.Void Blit(UnityEngine.RenderTexture renderTexture, UnityEngine.Material material, System.Int32 pass)
  UnityEngine.Vector4 IndexToVector(System.Int32 index)
  System.Void Draw(UnityEngine.Material material, System.Int32 pass, UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, System.Int32 subMesh, PaintIn3D.P3dCoord coord)
  System.Void Draw(UnityEngine.Material material, System.Int32 pass)
  UnityEngine.Texture2D CreateTexture(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean mipMaps)
  UnityEngine.Material GetMaterial(UnityEngine.Renderer renderer, System.Int32 materialIndex)
  UnityEngine.Material CloneMaterial(UnityEngine.GameObject gameObject, System.Int32 materialIndex)
  UnityEngine.Material AddMaterial(UnityEngine.Renderer renderer, UnityEngine.Shader shader, System.Int32 materialIndex)
  UnityEngine.Shader LoadShader(System.String shaderName)
  UnityEngine.Material BuildMaterial(UnityEngine.Shader shader)
  UnityEngine.Material BuildMaterial(System.String shaderName, System.String keyword)
END_CLASS

CLASS: PaintIn3D.P3dCoord
TYPE:  struct
TOKEN: 0x2000070
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  PaintIn3D.P3dCoord              First  // 0x0
  public    static  PaintIn3D.P3dCoord              Second  // 0x0
  public    static  PaintIn3D.P3dCoord              Third  // 0x0
  public    static  PaintIn3D.P3dCoord              Fourth  // 0x0
METHODS:
END_CLASS

CLASS: PaintIn3D.P3dCoordCopier
TYPE:  class
TOKEN: 0x2000071
EXTENDS: ScriptableObject
FIELDS:
  private           UnityEngine.Mesh                source  // 0x18
  private           PaintIn3D.P3dCoordCopier.Coord  first  // 0x20
  private           PaintIn3D.P3dCoordCopier.Coord  second  // 0x24
  private           PaintIn3D.P3dCoordCopier.Coord  third  // 0x28
  private           PaintIn3D.P3dCoordCopier.Coord  fourth  // 0x2C
  private           UnityEngine.Mesh                mesh  // 0x30
  private   static  System.Collections.Generic.List<UnityEngine.BoneWeight>boneWeights  // 0x0
  private   static  System.Collections.Generic.List<UnityEngine.Color32>colors  // 0x8
  private   static  System.Collections.Generic.List<UnityEngine.Vector3>positions  // 0x10
  private   static  System.Collections.Generic.List<UnityEngine.Vector3>normals  // 0x18
  private   static  System.Collections.Generic.List<UnityEngine.Vector4>tangents  // 0x20
  private   static  System.Collections.Generic.List<UnityEngine.Vector4>coords0  // 0x28
  private   static  System.Collections.Generic.List<UnityEngine.Vector4>coords1  // 0x30
  private   static  System.Collections.Generic.List<UnityEngine.Vector4>coords2  // 0x38
  private   static  System.Collections.Generic.List<UnityEngine.Vector4>coords3  // 0x40
  private   static  System.Collections.Generic.List<UnityEngine.Vector4>coordsNone  // 0x48
  private   static  System.Collections.Generic.List<System.Int32>indices  // 0x50
METHODS:
  System.Void set_Source(UnityEngine.Mesh value)
  UnityEngine.Mesh get_Source()
  System.Void set_First(PaintIn3D.P3dCoordCopier.Coord value)
  PaintIn3D.P3dCoordCopier.Coord get_First()
  System.Void set_Second(PaintIn3D.P3dCoordCopier.Coord value)
  PaintIn3D.P3dCoordCopier.Coord get_Second()
  System.Void set_Third(PaintIn3D.P3dCoordCopier.Coord value)
  PaintIn3D.P3dCoordCopier.Coord get_Third()
  System.Void set_Fourth(PaintIn3D.P3dCoordCopier.Coord value)
  PaintIn3D.P3dCoordCopier.Coord get_Fourth()
  System.Collections.Generic.List<UnityEngine.Vector4> GetCoords(PaintIn3D.P3dCoordCopier.Coord coord)
  System.Void Generate()
  System.Void OnDestroy()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dGraduallyFade
TYPE:  class
TOKEN: 0x2000073
EXTENDS: MonoBehaviour
FIELDS:
  private           PaintIn3D.P3dPaintableTexture   paintableTexture  // 0x18
  private           System.Single                   threshold  // 0x20
  private           System.Single                   speed  // 0x24
  private           PaintIn3D.P3dBlendMode          blendMode  // 0x28
  private           UnityEngine.Texture             blendTexture  // 0x60
  private           PaintIn3D.P3dPaintableTexture   blendPaintableTexture  // 0x68
  private           UnityEngine.Color               blendColor  // 0x70
  private           UnityEngine.Texture             maskTexture  // 0x80
  private           PaintIn3D.P3dPaintableTexture   maskPaintableTexture  // 0x88
  private           PaintIn3D.P3dChannel            maskChannel  // 0x90
  private           System.Single                   counter  // 0x94
METHODS:
  System.Void set_PaintableTexture(PaintIn3D.P3dPaintableTexture value)
  PaintIn3D.P3dPaintableTexture get_PaintableTexture()
  System.Void set_Threshold(System.Single value)
  System.Single get_Threshold()
  System.Void set_Speed(System.Single value)
  System.Single get_Speed()
  System.Void set_BlendMode(PaintIn3D.P3dBlendMode value)
  PaintIn3D.P3dBlendMode get_BlendMode()
  System.Void set_BlendTexture(UnityEngine.Texture value)
  UnityEngine.Texture get_BlendTexture()
  System.Void set_BlendPaintableTexture(PaintIn3D.P3dPaintableTexture value)
  PaintIn3D.P3dPaintableTexture get_BlendPaintableTexture()
  System.Void set_BlendColor(UnityEngine.Color value)
  UnityEngine.Color get_BlendColor()
  System.Void set_MaskTexture(UnityEngine.Texture value)
  UnityEngine.Texture get_MaskTexture()
  System.Void set_MaskPaintableTexture(PaintIn3D.P3dPaintableTexture value)
  PaintIn3D.P3dPaintableTexture get_MaskPaintableTexture()
  System.Void set_MaskChannel(PaintIn3D.P3dChannel value)
  PaintIn3D.P3dChannel get_MaskChannel()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dGroup
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  private           System.Int32                    index  // 0x10
METHODS:
  System.Void .ctor(System.Int32 newIndex)
  System.Int32 op_Implicit(PaintIn3D.P3dGroup group)
  PaintIn3D.P3dGroup op_Implicit(System.Int32 index)
  System.String ToString()
END_CLASS

CLASS: PaintIn3D.P3dGroupData
TYPE:  class
TOKEN: 0x2000075
EXTENDS: ScriptableObject
FIELDS:
  private           System.Int32                    index  // 0x18
  private           System.Collections.Generic.List<PaintIn3D.P3dGroupData.TextureData>textureDatas  // 0x20
  private           System.String                   shaderData  // 0x28
  private           System.Collections.Generic.List<PaintIn3D.P3dGroupData.Entry>entries  // 0x30
METHODS:
  System.Void set_Index(System.Int32 value)
  System.Int32 get_Index()
  System.Collections.Generic.List<PaintIn3D.P3dGroupData.TextureData> get_TextureDatas()
  System.Void set_ShaderData(System.String value)
  System.String get_ShaderData()
  System.Void TryGetShaderSlotName(System.String shaderPath, System.String& propertyName)
  System.Boolean Supports(UnityEngine.Shader shader)
  System.String GetName(System.Boolean prefixNumber)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dHash
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  private           System.Int32                    v  // 0x10
METHODS:
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Void .ctor(System.Int32 newValue)
  System.Int32 op_Implicit(PaintIn3D.P3dHash hash)
  PaintIn3D.P3dHash op_Implicit(System.Int32 index)
  System.String ToString()
END_CLASS

CLASS: PaintIn3D.P3dHashedMaterial
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  private           UnityEngine.Material            instance  // 0x10
  private           System.Int32                    hash  // 0x18
METHODS:
  System.Void .ctor(UnityEngine.Material newInstance, System.Int32 newHash)
  System.Boolean TryGetInstance(UnityEngine.Material& model)
END_CLASS

CLASS: PaintIn3D.P3dHashedModel
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  private           PaintIn3D.P3dModel              instance  // 0x10
  private           PaintIn3D.P3dHash               hash  // 0x18
METHODS:
  PaintIn3D.P3dHashedModel op_Implicit(PaintIn3D.P3dModel newInstance)
  System.Boolean TryGetInstance(PaintIn3D.P3dModel& model)
END_CLASS

CLASS: PaintIn3D.P3dHashedTexture
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  private           UnityEngine.Texture             instance  // 0x10
  private           PaintIn3D.P3dHash               hash  // 0x18
METHODS:
  PaintIn3D.P3dHashedTexture op_Implicit(UnityEngine.Texture newInstance)
  UnityEngine.Texture op_Implicit(PaintIn3D.P3dHashedTexture hashed)
  System.Boolean TryGetInstance(UnityEngine.Texture& texture)
END_CLASS

CLASS: PaintIn3D.P3dHit
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  public            UnityEngine.Transform           Root  // 0x10
  public            UnityEngine.Vector2             First  // 0x18
  public            UnityEngine.Vector2             Second  // 0x20
METHODS:
  System.Void .ctor(UnityEngine.RaycastHit hit)
END_CLASS

CLASS: PaintIn3D.P3dLineConnector
TYPE:  class
TOKEN: 0x200007D
FIELDS:
  private           System.Single                   hitSpacing  // 0x10
  private           System.Int32                    hitLimit  // 0x14
  protected         System.Boolean                  connectHits  // 0x18
  protected         System.Boolean                  clipConnected  // 0x19
  private           System.Collections.Generic.List<PaintIn3D.P3dLineConnector.Link>links  // 0x20
  private   static  System.Collections.Generic.Stack<PaintIn3D.P3dLineConnector.Link>linkPool  // 0x0
  protected         PaintIn3D.P3dHitCache           hitCache  // 0x28
METHODS:
  System.Void set_HitSpacing(System.Single value)
  System.Single get_HitSpacing()
  System.Void set_HitLimit(System.Int32 value)
  System.Int32 get_HitLimit()
  System.Void set_ConnectHits(System.Boolean value)
  System.Boolean get_ConnectHits()
  System.Void set_ClipConnected(System.Boolean value)
  System.Boolean get_ClipConnected()
  PaintIn3D.P3dHitCache get_HitCache()
  System.Void ClearHitCache()
  System.Void ResetConnections()
  System.Void BreakHits(System.Object owner)
  System.Void SubmitLine(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Quaternion rotation, System.Object owner)
  System.Void Update()
  System.Boolean TryGetLink(System.Object owner, PaintIn3D.P3dLineConnector.Link& link)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dMask
TYPE:  class
TOKEN: 0x200007F
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Texture             texture  // 0x18
  private           PaintIn3D.P3dChannel            channel  // 0x20
  private           UnityEngine.Vector2             stretch  // 0x24
  private   static  System.Collections.Generic.LinkedList<PaintIn3D.P3dMask>instances  // 0x0
  private           System.Collections.Generic.LinkedListNode<PaintIn3D.P3dMask>instancesNode  // 0x30
METHODS:
  System.Void set_Texture(UnityEngine.Texture value)
  UnityEngine.Texture get_Texture()
  System.Void set_Channel(PaintIn3D.P3dChannel value)
  PaintIn3D.P3dChannel get_Channel()
  System.Void set_Stretch(UnityEngine.Vector2 value)
  UnityEngine.Vector2 get_Stretch()
  System.Collections.Generic.LinkedList<PaintIn3D.P3dMask> get_Instances()
  UnityEngine.Matrix4x4 get_Matrix()
  PaintIn3D.P3dMask Find(UnityEngine.Vector3 position, UnityEngine.LayerMask layers)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dMaterialCloner
TYPE:  class
TOKEN: 0x2000080
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Int32                    index  // 0x18
  private           UnityEngine.Renderer            cachedRenderer  // 0x20
  private           System.Boolean                  cachedRendererSet  // 0x28
  private           PaintIn3D.P3dPaintable          cachedPaintable  // 0x30
  private           System.Boolean                  cachedPaintableSet  // 0x38
  private           System.Boolean                  activated  // 0x39
  private           UnityEngine.Material            current  // 0x40
  private           UnityEngine.Material            original  // 0x48
METHODS:
  System.Void set_Index(System.Int32 value)
  System.Int32 get_Index()
  UnityEngine.Renderer get_CachedRenderer()
  PaintIn3D.P3dPaintable get_CachedPaintable()
  UnityEngine.Material get_Original()
  UnityEngine.Material get_Current()
  System.Boolean get_Activated()
  System.Void Activate()
  System.Void Deactivate()
  System.Void ReplaceAll(UnityEngine.Material from, UnityEngine.Material to)
  System.Void Replace(UnityEngine.Renderer renderer, UnityEngine.Material[] materials, UnityEngine.Material oldMaterial, UnityEngine.Material newMaterial)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dMeshCache
TYPE:  class
TOKEN: 0x2000081
FIELDS:
  private   static  System.Collections.Generic.Dictionary<UnityEngine.Mesh,PaintIn3D.P3dMeshCache.MeshData>cachedData  // 0x0
METHODS:
  System.Boolean GetTrianglePositions(UnityEngine.RaycastHit hit, UnityEngine.Vector3& positionA, UnityEngine.Vector3& positionB, UnityEngine.Vector3& positionC)
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dModel
TYPE:  class
TOKEN: 0x2000083
EXTENDS: MonoBehaviour
FIELDS:
  protected         PaintIn3D.P3dPaintable          paintable  // 0x18
  protected         System.Boolean                  includeScale  // 0x20
  protected         PaintIn3D.P3dModel.UseMeshType  useMesh  // 0x24
  protected         PaintIn3D.P3dHash               hash  // 0x28
  private           UnityEngine.Renderer            cachedRenderer  // 0x30
  private           System.Boolean                  cachedRendererSet  // 0x38
  private           UnityEngine.SkinnedMeshRenderer cachedSkinned  // 0x40
  private           UnityEngine.MeshFilter          cachedFilter  // 0x48
  private           System.Boolean                  cachedSkinnedSet  // 0x50
  private           UnityEngine.Transform           cachedTransform  // 0x58
  private           UnityEngine.GameObject          cachedGameObject  // 0x60
  private           UnityEngine.Material[]          materials  // 0x68
  private           System.Boolean                  materialsSet  // 0x70
  private           UnityEngine.Mesh                bakedMesh  // 0x78
  private           System.Boolean                  bakedMeshSet  // 0x80
  protected         System.Boolean                  prepared  // 0x81
  private           UnityEngine.Mesh                preparedMesh  // 0x88
  private           UnityEngine.Matrix4x4           preparedMatrix  // 0x90
  private           System.Int32[]                  preparedTriangles  // 0xD0
  private           UnityEngine.Vector3[]           preparedPositions  // 0xD8
  private           UnityEngine.Vector2[]           preparedCoord0  // 0xE0
  private           UnityEngine.Vector2[]           preparedCoord1  // 0xE8
  private   static  System.Collections.Generic.List<PaintIn3D.P3dModel>tempModels  // 0x0
  private   static  System.Collections.Generic.LinkedList<PaintIn3D.P3dModel>instances  // 0x8
  private           System.Collections.Generic.LinkedListNode<PaintIn3D.P3dModel>instancesNode  // 0xF0
METHODS:
  System.Void set_Paintable(PaintIn3D.P3dPaintable value)
  PaintIn3D.P3dPaintable get_Paintable()
  System.Void set_IncludeScale(System.Boolean value)
  System.Boolean get_IncludeScale()
  System.Void set_UseMesh(PaintIn3D.P3dModel.UseMeshType value)
  PaintIn3D.P3dModel.UseMeshType get_UseMesh()
  System.Void set_Hash(PaintIn3D.P3dHash value)
  PaintIn3D.P3dHash get_Hash()
  System.Collections.Generic.LinkedList<PaintIn3D.P3dModel> get_Instances()
  System.Void set_Prepared(System.Boolean value)
  System.Boolean get_Prepared()
  UnityEngine.Mesh get_PreparedMesh()
  UnityEngine.GameObject get_CachedGameObject()
  UnityEngine.Renderer get_CachedRenderer()
  UnityEngine.Material[] get_Materials()
  System.Int32 GetMaterialIndex(UnityEngine.Material material)
  System.Void CacheRenderer()
  System.Void DirtyMaterials()
  System.Collections.Generic.List<PaintIn3D.P3dModel> FindOverlap(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask)
  System.Void GetPreparedPoints(System.Int32 triangleIndex, UnityEngine.Vector3& pointA, UnityEngine.Vector3& pointB, UnityEngine.Vector3& pointC)
  System.Void GetPreparedCoords0(System.Int32 triangleIndex, UnityEngine.Vector2& coordA, UnityEngine.Vector2& coordB, UnityEngine.Vector2& coordC)
  System.Void GetPreparedCoords1(System.Int32 triangleIndex, UnityEngine.Vector2& coordA, UnityEngine.Vector2& coordB, UnityEngine.Vector2& coordC)
  System.Int32 GetSubmesh(PaintIn3D.P3dPaintableTexture paintableTexture)
  System.Void GetPrepared(UnityEngine.Mesh& mesh, UnityEngine.Matrix4x4& matrix, PaintIn3D.P3dCoord coord)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dModifier
TYPE:  class
TOKEN: 0x2000085
FIELDS:
  private           System.Boolean                  preview  // 0x10
  private           System.Boolean                  unique  // 0x11
METHODS:
  System.Void set_Preview(System.Boolean value)
  System.Boolean get_Preview()
  System.Void set_Unique(System.Boolean value)
  System.Boolean get_Unique()
  System.Void ModifyAngle(System.Single& angle, System.Single pressure)
  System.Void OnModifyAngle(System.Single& angle, System.Single pressure)
  System.Void ModifyColor(UnityEngine.Color& color, System.Single pressure)
  System.Void OnModifyColor(UnityEngine.Color& color, System.Single pressure)
  System.Void ModifyHardness(System.Single& hardness, System.Single pressure)
  System.Void OnModifyHardness(System.Single& hardness, System.Single pressure)
  System.Void ModifyOpacity(System.Single& opacity, System.Single pressure)
  System.Void OnModifyOpacity(System.Single& opacity, System.Single pressure)
  System.Void ModifyRadius(System.Single& radius, System.Single pressure)
  System.Void OnModifyRadius(System.Single& radius, System.Single pressure)
  System.Void ModifyScale(UnityEngine.Vector3& scale, System.Single pressure)
  System.Void OnModifyScale(UnityEngine.Vector3& scale, System.Single pressure)
  System.Void ModifyTexture(UnityEngine.Texture& texture, System.Single pressure)
  System.Void OnModifyTexture(UnityEngine.Texture& texture, System.Single pressure)
  System.Void ModifyPosition(UnityEngine.Vector3& position, System.Single pressure)
  System.Void OnModifyPosition(UnityEngine.Vector3& position, System.Single pressure)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dModifierList
TYPE:  class
TOKEN: 0x2000086
FIELDS:
  private           System.Collections.Generic.List<PaintIn3D.P3dModifier>modifiers  // 0x10
METHODS:
  System.Int32 get_Count()
  System.Collections.Generic.List<PaintIn3D.P3dModifier> get_Instances()
  System.Void ModifyAngle(System.Single& angle, System.Boolean preview, System.Single pressure)
  System.Void ModifyColor(UnityEngine.Color& color, System.Boolean preview, System.Single pressure)
  System.Void ModifyHardness(System.Single& hardness, System.Boolean preview, System.Single pressure)
  System.Void ModifyOpacity(System.Single& opacity, System.Boolean preview, System.Single pressure)
  System.Void ModifyRadius(System.Single& radius, System.Boolean preview, System.Single pressure)
  System.Void ModifyScale(UnityEngine.Vector3& scale, System.Boolean preview, System.Single pressure)
  System.Void ModifyTexture(UnityEngine.Texture& texture, System.Boolean preview, System.Single pressure)
  System.Void ModifyPosition(UnityEngine.Vector3& position, System.Boolean preview, System.Single pressure)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dPaintable
TYPE:  class
TOKEN: 0x2000087
EXTENDS: P3dModel
FIELDS:
  private           PaintIn3D.P3dPaintable.ActivationTypeactivation  // 0xF8
  private           UnityEngine.Vector3             baseScale  // 0xFC
  private           System.Collections.Generic.List<UnityEngine.Renderer>otherRenderers  // 0x108
  private           UnityEngine.Events.UnityEvent   onActivating  // 0x110
  private           UnityEngine.Events.UnityEvent   onActivated  // 0x118
  private           System.Boolean                  activated  // 0x120
  private           System.Collections.Generic.HashSet<PaintIn3D.P3dPaintableTexture>paintableTextures  // 0x128
  private   static  System.Collections.Generic.List<PaintIn3D.P3dMaterialCloner>materialCloners  // 0x0
  private           System.Collections.Generic.List<PaintIn3D.P3dPaintableTexture>tempPaintableTextures  // 0x130
METHODS:
  System.Void set_Paintable(PaintIn3D.P3dPaintable value)
  PaintIn3D.P3dPaintable get_Paintable()
  System.Void set_Activation(PaintIn3D.P3dPaintable.ActivationType value)
  PaintIn3D.P3dPaintable.ActivationType get_Activation()
  System.Void set_BaseScale(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_BaseScale()
  System.Void set_OtherRenderers(System.Collections.Generic.List<UnityEngine.Renderer> value)
  System.Collections.Generic.List<UnityEngine.Renderer> get_OtherRenderers()
  UnityEngine.Events.UnityEvent get_OnActivating()
  UnityEngine.Events.UnityEvent get_OnActivated()
  System.Boolean get_Activated()
  System.Collections.Generic.HashSet<PaintIn3D.P3dPaintableTexture> get_PaintableTextures()
  System.Void RemoveComponents()
  System.Void ScaleSize(System.Int32& width, System.Int32& height)
  System.Void Activate()
  System.Void AddPaintableTextures(UnityEngine.Transform root)
  System.Void Deactivate()
  System.Void ClearAll(UnityEngine.Color color)
  System.Void ClearAll(UnityEngine.Texture texture, UnityEngine.Color color)
  System.Void Register(PaintIn3D.P3dPaintableTexture paintableTexture)
  System.Void Unregister(PaintIn3D.P3dPaintableTexture paintableTexture)
  System.Void Awake()
  System.Void OnEnable()
  System.Void Start()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dPaintableManager
TYPE:  class
TOKEN: 0x2000089
EXTENDS: MonoBehaviour
FIELDS:
  private   static  System.Collections.Generic.LinkedList<PaintIn3D.P3dPaintableManager>instances  // 0x0
  private           System.Collections.Generic.LinkedListNode<PaintIn3D.P3dPaintableManager>instancesNode  // 0x18
METHODS:
  System.Collections.Generic.LinkedList<PaintIn3D.P3dPaintableManager> get_Instances()
  PaintIn3D.P3dPaintableManager GetOrCreateInstance()
  System.Void SubmitAll(PaintIn3D.P3dCommand command, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, PaintIn3D.P3dGroup group, PaintIn3D.P3dModel targetModel, PaintIn3D.P3dPaintableTexture targetTexture)
  System.Void DoSubmitAll(PaintIn3D.P3dCommand command, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, PaintIn3D.P3dGroup group, PaintIn3D.P3dModel targetModel, PaintIn3D.P3dPaintableTexture targetTexture)
  System.Void SubmitAll(PaintIn3D.P3dCommand command, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, PaintIn3D.P3dGroup group)
  System.Void SubmitAll(PaintIn3D.P3dCommand command, PaintIn3D.P3dModel model, PaintIn3D.P3dGroup group)
  PaintIn3D.P3dCommand Submit(PaintIn3D.P3dCommand command, PaintIn3D.P3dModel model, PaintIn3D.P3dPaintableTexture paintableTexture)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void LateUpdate()
  System.Void ClearAll()
  System.Void UpdateAll()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dPaintableState
TYPE:  class
TOKEN: 0x200008A
FIELDS:
  public            UnityEngine.RenderTexture       Texture  // 0x10
  public            System.Collections.Generic.List<PaintIn3D.P3dCommand>Commands  // 0x18
  private   static  System.Collections.Generic.Stack<PaintIn3D.P3dPaintableState>pool  // 0x0
METHODS:
  PaintIn3D.P3dPaintableState Pop()
  System.Void Write(UnityEngine.RenderTexture current)
  System.Void Write(System.Collections.Generic.List<PaintIn3D.P3dCommand> commands)
  System.Void Write(UnityEngine.RenderTexture current, System.Collections.Generic.List<PaintIn3D.P3dCommand> commands)
  System.Void Clear()
  System.Void Pool()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dPaintableTexture
TYPE:  class
TOKEN: 0x200008B
EXTENDS: MonoBehaviour
FIELDS:
  private           PaintIn3D.P3dSlot               slot  // 0x18
  private           PaintIn3D.P3dCoord              coord  // 0x28
  private           PaintIn3D.P3dGroup              group  // 0x2C
  private           PaintIn3D.P3dPaintableTexture.UndoRedoTypeundoRedo  // 0x30
  private           System.Int32                    stateLimit  // 0x34
  private           PaintIn3D.P3dPaintableTexture.SaveLoadTypesaveLoad  // 0x38
  private           System.String                   saveName  // 0x40
  private           System.Int32                    width  // 0x48
  private           System.Int32                    height  // 0x4C
  private           UnityEngine.Texture             texture  // 0x50
  private           UnityEngine.Color               color  // 0x58
  private           UnityEngine.RenderTextureFormat format  // 0x68
  private           PaintIn3D.P3dPaintableTexture.MipTypemipMaps  // 0x6C
  private           PaintIn3D.P3dPaintableTexture.FilterTypefilter  // 0x70
  private           PaintIn3D.P3dPaintableTexture.AnisoTypeaniso  // 0x74
  private           PaintIn3D.P3dPaintableTexture.WrapTypewrapU  // 0x78
  private           PaintIn3D.P3dPaintableTexture.WrapTypewrapV  // 0x7C
  private           PaintIn3D.P3dPaintableTexture.ExistingTypeexisting  // 0x80
  private           PaintIn3D.P3dPaintableTexture.ConversionTypeconversion  // 0x84
  private           UnityEngine.Texture             localMaskTexture  // 0x88
  private           PaintIn3D.P3dChannel            localMaskChannel  // 0x90
  private           System.String                   shaderKeyword  // 0x98
  protected         PaintIn3D.P3dHash               hash  // 0xA0
  private           System.Boolean                  isDummy  // 0xA4
  private           System.String                   output  // 0xA8
  private           System.Action<PaintIn3D.P3dCommand>OnAddCommand  // 0xB0
  private   static  System.Action<PaintIn3D.P3dPaintableTexture,PaintIn3D.P3dCommand>OnAddCommandGlobal  // 0x0
  public    static  System.Action<PaintIn3D.P3dPaintableTexture>OnInstanceAdded  // 0x8
  public    static  System.Action<PaintIn3D.P3dPaintableTexture>OnInstanceRemoved  // 0x10
  private           System.Action<System.Boolean>   OnModified  // 0xB8
  private           System.Boolean                  activated  // 0xC0
  private           UnityEngine.RenderTexture       current  // 0xC8
  private           UnityEngine.RenderTexture       preview  // 0xD0
  private           System.Collections.Generic.List<PaintIn3D.P3dPaintableState>paintableStates  // 0xD8
  private           System.Int32                    stateIndex  // 0xE0
  private           PaintIn3D.P3dPaintable          paintable  // 0xE8
  private           System.Boolean                  paintableSet  // 0xF0
  private           UnityEngine.Material            material  // 0xF8
  private           System.Boolean                  materialSet  // 0x100
  private           UnityEngine.Texture             oldTexture  // 0x108
  private           System.Collections.Generic.List<PaintIn3D.P3dCommand>paintCommands  // 0x110
  private           System.Collections.Generic.List<PaintIn3D.P3dCommand>previewCommands  // 0x118
  private           System.Collections.Generic.List<PaintIn3D.P3dCommand>localCommands  // 0x120
  private   static  System.Collections.Generic.List<PaintIn3D.P3dPaintableTexture>tempPaintableTextures  // 0x18
  private   static  System.Collections.Generic.LinkedList<PaintIn3D.P3dPaintableTexture>instances  // 0x20
  private           System.Collections.Generic.LinkedListNode<PaintIn3D.P3dPaintableTexture>instancesNode  // 0x128
  private   static  System.Int32                    _Buffer  // 0x28
  private   static  System.Int32                    _BufferSize  // 0x2C
METHODS:
  System.Void set_Slot(PaintIn3D.P3dSlot value)
  PaintIn3D.P3dSlot get_Slot()
  System.Void set_Coord(PaintIn3D.P3dCoord value)
  PaintIn3D.P3dCoord get_Coord()
  System.Void set_Group(PaintIn3D.P3dGroup value)
  PaintIn3D.P3dGroup get_Group()
  System.Void set_UndoRedo(PaintIn3D.P3dPaintableTexture.UndoRedoType value)
  PaintIn3D.P3dPaintableTexture.UndoRedoType get_UndoRedo()
  System.Void set_StateLimit(System.Int32 value)
  System.Int32 get_StateLimit()
  System.Void set_SaveLoad(PaintIn3D.P3dPaintableTexture.SaveLoadType value)
  PaintIn3D.P3dPaintableTexture.SaveLoadType get_SaveLoad()
  System.Void set_SaveName(System.String value)
  System.String get_SaveName()
  System.Void set_Width(System.Int32 value)
  System.Int32 get_Width()
  System.Void set_Height(System.Int32 value)
  System.Int32 get_Height()
  System.Void set_Texture(UnityEngine.Texture value)
  UnityEngine.Texture get_Texture()
  System.Void set_Color(UnityEngine.Color value)
  UnityEngine.Color get_Color()
  System.Void set_Format(UnityEngine.RenderTextureFormat value)
  UnityEngine.RenderTextureFormat get_Format()
  System.Void set_MipMaps(PaintIn3D.P3dPaintableTexture.MipType value)
  PaintIn3D.P3dPaintableTexture.MipType get_MipMaps()
  System.Void set_Filter(PaintIn3D.P3dPaintableTexture.FilterType value)
  PaintIn3D.P3dPaintableTexture.FilterType get_Filter()
  System.Void set_Aniso(PaintIn3D.P3dPaintableTexture.AnisoType value)
  PaintIn3D.P3dPaintableTexture.AnisoType get_Aniso()
  System.Void set_WrapU(PaintIn3D.P3dPaintableTexture.WrapType value)
  PaintIn3D.P3dPaintableTexture.WrapType get_WrapU()
  System.Void set_WrapV(PaintIn3D.P3dPaintableTexture.WrapType value)
  PaintIn3D.P3dPaintableTexture.WrapType get_WrapV()
  System.Void set_Existing(PaintIn3D.P3dPaintableTexture.ExistingType value)
  PaintIn3D.P3dPaintableTexture.ExistingType get_Existing()
  System.Void set_Conversion(PaintIn3D.P3dPaintableTexture.ConversionType value)
  PaintIn3D.P3dPaintableTexture.ConversionType get_Conversion()
  System.Void set_LocalMaskTexture(UnityEngine.Texture value)
  UnityEngine.Texture get_LocalMaskTexture()
  System.Void set_LocalMaskChannel(PaintIn3D.P3dChannel value)
  PaintIn3D.P3dChannel get_LocalMaskChannel()
  System.Void set_ShaderKeyword(System.String value)
  System.String get_ShaderKeyword()
  System.Void set_Hash(PaintIn3D.P3dHash value)
  PaintIn3D.P3dHash get_Hash()
  System.Void set_IsDummy(System.Boolean value)
  System.Boolean get_IsDummy()
  System.Void set_Output(System.String value)
  System.String get_Output()
  System.Void add_OnAddCommand(System.Action<PaintIn3D.P3dCommand> value)
  System.Void remove_OnAddCommand(System.Action<PaintIn3D.P3dCommand> value)
  System.Void add_OnAddCommandGlobal(System.Action<PaintIn3D.P3dPaintableTexture,PaintIn3D.P3dCommand> value)
  System.Void remove_OnAddCommandGlobal(System.Action<PaintIn3D.P3dPaintableTexture,PaintIn3D.P3dCommand> value)
  System.Void add_OnModified(System.Action<System.Boolean> value)
  System.Void remove_OnModified(System.Action<System.Boolean> value)
  System.Collections.Generic.LinkedList<PaintIn3D.P3dPaintableTexture> get_Instances()
  System.Boolean get_Activated()
  System.Boolean get_CanUndo()
  System.Boolean get_CanRedo()
  System.Collections.Generic.List<PaintIn3D.P3dPaintableState> get_States()
  System.Int32 get_StateIndex()
  UnityEngine.Material get_Material()
  PaintIn3D.P3dPaintable get_Paintable()
  System.Void set_Current(UnityEngine.RenderTexture value)
  UnityEngine.RenderTexture get_Current()
  UnityEngine.RenderTexture get_Preview()
  System.Collections.Generic.List<PaintIn3D.P3dPaintableTexture> FilterAll(PaintIn3D.P3dModel model, PaintIn3D.P3dGroup group)
  System.Void ClearStates()
  System.Void StoreState()
  System.Void Undo()
  System.Void Redo()
  System.Void SetColor(System.String html)
  UnityEngine.Vector2 GetCoord(PaintIn3D.P3dHit& hit)
  UnityEngine.Vector2 GetCoord(UnityEngine.RaycastHit& hit)
  System.Boolean StatesContainTextureOrCommands()
  System.Boolean LastStateWithTextureOr0(System.Int32& startIndex)
  System.Void RebuildFromCommands()
  System.Void AddState()
  System.Void TrimFuture()
  System.Void TrimPast()
  System.Void NotifyOnModified(System.Boolean preview)
  UnityEngine.Texture2D GetReadableCopy(System.Boolean convertBack)
  System.Byte[] GetPngData(System.Boolean convertBack)
  System.Byte[] GetTgaData(System.Boolean convertBack)
  System.Void Clear()
  System.Void Clear(UnityEngine.Texture texture, UnityEngine.Color tint, System.Boolean updateMips)
  System.Void Replace()
  System.Void Replace(UnityEngine.Texture texture, UnityEngine.Color tint)
  System.Boolean Resize(System.Int32 width, System.Int32 height, System.Boolean copyContents)
  System.Void Save()
  System.Void Save(System.String saveName)
  System.Void Load()
  System.Void Load(System.String saveName, System.Boolean replace)
  System.Void LoadFromData(System.Byte[] data, System.Boolean allowResize)
  System.Void HidePreview()
  System.Void HideAllPreviews()
  System.Void ClearSave()
  System.Void ClearSave(System.String saveName)
  System.Void UpdateMaterial()
  System.Void CopySize()
  System.Void CopyTexture()
  System.Void Activate()
  System.Void Deactivate()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnApplicationPause(System.Boolean paused)
  System.Void OnDestroy()
  System.Void AddCommand(PaintIn3D.P3dCommand command)
  System.Boolean get_CommandsPending()
  System.Void ClearCommands()
  System.Void ExecuteCommands(System.Boolean sendNotifications, System.Boolean doSort)
  System.Void ExecuteCommands(System.Collections.Generic.List<PaintIn3D.P3dCommand> commands, System.Boolean sendNotifications, UnityEngine.RenderTexture main, UnityEngine.RenderTexture& swap)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dPaintableTextureMonitor
TYPE:  class
TOKEN: 0x2000095
EXTENDS: MonoBehaviour
FIELDS:
  private           PaintIn3D.P3dPaintableTexture   paintableTexture  // 0x18
  private           System.Single                   interval  // 0x20
  private           System.Boolean                  async  // 0x24
  protected         System.Int32                    downsampleSteps  // 0x28
  private           System.Action                   OnUpdated  // 0x30
  protected         PaintIn3D.P3dPaintableTexture   registeredPaintableTexture  // 0x38
  private           System.Single                   cooldown  // 0x40
  private           PaintIn3D.P3dReader             currentReader  // 0x48
  protected         Unity.Collections.NativeArray<UnityEngine.Color32>currentPixels  // 0x50
METHODS:
  System.Void set_PaintableTexture(PaintIn3D.P3dPaintableTexture value)
  PaintIn3D.P3dPaintableTexture get_PaintableTexture()
  System.Void set_Interval(System.Single value)
  System.Single get_Interval()
  System.Void set_Async(System.Boolean value)
  System.Boolean get_Async()
  System.Void set_DownsampleSteps(System.Int32 value)
  System.Int32 get_DownsampleSteps()
  System.Void add_OnUpdated(System.Action value)
  System.Void remove_OnUpdated(System.Action value)
  System.Boolean get_Registered()
  PaintIn3D.P3dReader get_CurrentReader()
  System.Void MarkCurrentReaderAsDirty()
  System.Void Register()
  System.Void Unregister()
  System.Void InvokeOnUpdated()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void Update()
  System.Void HandleCompleteCurrent(Unity.Collections.NativeArray<UnityEngine.Color32> pixels)
  System.Void HandleModified(System.Boolean preview)
  System.Void HandleComplete(System.Int32 boost)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dPaintableTextureMonitorMask
TYPE:  class
TOKEN: 0x2000096
EXTENDS: P3dPaintableTextureMonitor
FIELDS:
  private           UnityEngine.Mesh                maskMesh  // 0x60
  private           System.Int32                    maskSubmesh  // 0x68
  private           UnityEngine.Texture             maskTexture  // 0x70
  private           PaintIn3D.P3dChannel            maskChannel  // 0x78
  protected         System.Int32                    total  // 0x7C
  private           PaintIn3D.P3dReader             maskReader  // 0x80
  protected         Unity.Collections.NativeArray<System.Byte>maskPixels  // 0x88
METHODS:
  System.Void set_MaskMesh(UnityEngine.Mesh value)
  UnityEngine.Mesh get_MaskMesh()
  System.Void set_MaskSubmesh(System.Int32 value)
  System.Int32 get_MaskSubmesh()
  System.Void set_MaskTexture(UnityEngine.Texture value)
  UnityEngine.Texture get_MaskTexture()
  System.Void set_MaskChannel(PaintIn3D.P3dChannel value)
  PaintIn3D.P3dChannel get_MaskChannel()
  System.Int32 get_Total()
  PaintIn3D.P3dReader get_MaskReader()
  System.Void MarkMaskReaderAsDirty()
  System.Void HandleCompleteMask(Unity.Collections.NativeArray<UnityEngine.Color32> pixels)
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void Update()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dPointConnector
TYPE:  class
TOKEN: 0x2000097
FIELDS:
  private           System.Single                   hitSpacing  // 0x10
  private           System.Int32                    hitLimit  // 0x14
  protected         System.Boolean                  connectHits  // 0x18
  protected         System.Boolean                  clipConnected  // 0x19
  private           System.Collections.Generic.List<PaintIn3D.P3dPointConnector.Link>links  // 0x20
  private   static  System.Collections.Generic.Stack<PaintIn3D.P3dPointConnector.Link>linkPool  // 0x0
  protected         PaintIn3D.P3dHitCache           hitCache  // 0x28
METHODS:
  System.Void set_HitSpacing(System.Single value)
  System.Single get_HitSpacing()
  System.Void set_HitLimit(System.Int32 value)
  System.Int32 get_HitLimit()
  System.Void set_ConnectHits(System.Boolean value)
  System.Boolean get_ConnectHits()
  System.Void set_ClipConnected(System.Boolean value)
  System.Boolean get_ClipConnected()
  PaintIn3D.P3dHitCache get_HitCache()
  System.Void ClearHitCache()
  System.Void ResetConnections()
  System.Void BreakHits(System.Object owner)
  System.Void SubmitLastPoint(UnityEngine.GameObject gameObject, System.Boolean preview, System.Object owner)
  System.Void SubmitPoint(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Object owner)
  System.Void Update()
  System.Boolean TryGetLink(System.Object owner, PaintIn3D.P3dPointConnector.Link& link)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dReadColor
TYPE:  class
TOKEN: 0x2000099
EXTENDS: MonoBehaviour
FIELDS:
  private           PaintIn3D.P3dGroup              group  // 0x18
  private           System.Boolean                  preview  // 0x1C
  private           UnityEngine.Color               color  // 0x20
  private           PaintIn3D.P3dReadColor.ColorEventonColor  // 0x30
METHODS:
  System.Void set_Group(PaintIn3D.P3dGroup value)
  PaintIn3D.P3dGroup get_Group()
  System.Void set_Preview(System.Boolean value)
  System.Boolean get_Preview()
  System.Void set_Color(UnityEngine.Color value)
  UnityEngine.Color get_Color()
  PaintIn3D.P3dReadColor.ColorEvent get_OnColor()
  System.Void HandleHitCoord(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dReader
TYPE:  class
TOKEN: 0x200009B
FIELDS:
  private           UnityEngine.Rendering.AsyncGPUReadbackRequestrequest  // 0x10
  private           System.Boolean                  dirty  // 0x20
  private           System.Boolean                  requested  // 0x21
  private           UnityEngine.RenderTexture       buffer  // 0x28
  private           UnityEngine.Vector2Int          originalSize  // 0x30
  private           UnityEngine.Vector2Int          downsampledSize  // 0x38
  private           System.Int32                    downsampleSteps  // 0x40
  private           System.Int32                    downsampleBoost  // 0x44
  private           UnityEngine.Texture2D           tempTexture  // 0x48
  private           System.Action<Unity.Collections.NativeArray<UnityEngine.Color32>>OnComplete  // 0x50
METHODS:
  System.Void add_OnComplete(System.Action<Unity.Collections.NativeArray<UnityEngine.Color32>> value)
  System.Void remove_OnComplete(System.Action<Unity.Collections.NativeArray<UnityEngine.Color32>> value)
  System.Boolean get_Dirty()
  System.Boolean get_Requested()
  UnityEngine.Vector2Int get_OriginalSize()
  System.Int32 get_DownsampleSteps()
  UnityEngine.Vector2Int get_DownsampledSize()
  System.Int32 get_DownsampleBoost()
  System.Void MarkAsDirty()
  System.Void UpdateRequest()
  System.Boolean NeedsUpdating(PaintIn3D.P3dReader reader, Unity.Collections.NativeArray<T> array, UnityEngine.RenderTexture texture, System.Int32 downsampleSteps)
  System.Void Request(UnityEngine.RenderTexture texture, System.Int32 downsample, System.Boolean async)
  System.Void Release()
  System.Void CompleteDirectly()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dSerialization
TYPE:  class
TOKEN: 0x200009C
FIELDS:
  public    static  System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Material>HashToMaterial  // 0x0
  public    static  System.Collections.Generic.Dictionary<UnityEngine.Material,System.Int32>MaterialToHash  // 0x8
  public    static  System.Collections.Generic.Dictionary<PaintIn3D.P3dHash,PaintIn3D.P3dModel>HashToModel  // 0x10
  public    static  System.Collections.Generic.Dictionary<PaintIn3D.P3dModel,PaintIn3D.P3dHash>ModelToHash  // 0x18
  public    static  System.Collections.Generic.Dictionary<PaintIn3D.P3dHash,UnityEngine.Texture>HashToTexture  // 0x20
  public    static  System.Collections.Generic.Dictionary<UnityEngine.Texture,PaintIn3D.P3dHash>TextureToHash  // 0x28
  public    static  System.Collections.Generic.Dictionary<PaintIn3D.P3dHash,PaintIn3D.P3dPaintableTexture>HashToPaintableTexture  // 0x30
  public    static  System.Collections.Generic.Dictionary<PaintIn3D.P3dPaintableTexture,PaintIn3D.P3dHash>PaintableTextureToHash  // 0x38
METHODS:
  System.Void TryRegister(PaintIn3D.P3dPaintableTexture paintableTexture, PaintIn3D.P3dHash hash)
  System.Void TryRegister(PaintIn3D.P3dModel model, PaintIn3D.P3dHash hash)
  System.Void TryRegister(UnityEngine.Texture texture, PaintIn3D.P3dHash hash)
  System.Void TryRegister(T obj, PaintIn3D.P3dHash hash, System.Collections.Generic.Dictionary<PaintIn3D.P3dHash,T> hashToObj, System.Collections.Generic.Dictionary<T,PaintIn3D.P3dHash> objToHash)
  System.Int32 TryRegister(UnityEngine.Material material)
  System.Int32 GetStableStringHash(System.String s)
  System.Void .cctor()
END_CLASS

CLASS: PaintIn3D.P3dSlot
TYPE:  struct
TOKEN: 0x200009D
FIELDS:
  public            System.Int32                    Index  // 0x10
  public            System.String                   Name  // 0x18
METHODS:
  System.Void .ctor(System.Int32 newIndex, System.String newName)
  UnityEngine.Texture FindTexture(UnityEngine.GameObject gameObject)
  System.Boolean IsTransformed(UnityEngine.GameObject gameObject)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(PaintIn3D.P3dSlot a, PaintIn3D.P3dSlot b)
  System.Boolean op_Inequality(PaintIn3D.P3dSlot a, PaintIn3D.P3dSlot b)
END_CLASS

CLASS: PaintIn3D.P3dStateManager
TYPE:  class
TOKEN: 0x200009E
FIELDS:
METHODS:
  System.Boolean get_CanUndo()
  System.Boolean get_CanRedo()
  System.Void StoreAllStates()
  System.Void ClearAllStates()
  System.Void UndoAll()
  System.Void RedoAll()
END_CLASS

CLASS: PaintIn3D.P3dTextureHash
TYPE:  class
TOKEN: 0x200009F
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.Texture             texture  // 0x18
  private           PaintIn3D.P3dHash               hash  // 0x20
METHODS:
  System.Void set_Texture(UnityEngine.Texture value)
  UnityEngine.Texture get_Texture()
  System.Void set_Hash(PaintIn3D.P3dHash value)
  PaintIn3D.P3dHash get_Hash()
  System.Void OnEnable()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dPaintDecal
TYPE:  class
TOKEN: 0x20000A0
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.LayerMask           layers  // 0x18
  private           PaintIn3D.P3dModel              targetModel  // 0x20
  private           PaintIn3D.P3dGroup              group  // 0x28
  private           PaintIn3D.P3dPaintableTexture   targetTexture  // 0x30
  private           PaintIn3D.P3dBlendMode          blendMode  // 0x38
  private           UnityEngine.Texture             texture  // 0x70
  private           UnityEngine.Texture             shape  // 0x78
  private           PaintIn3D.P3dChannel            shapeChannel  // 0x80
  private           UnityEngine.Color               color  // 0x84
  private           System.Single                   opacity  // 0x94
  private           System.Single                   angle  // 0x98
  private           UnityEngine.Vector3             scale  // 0x9C
  private           System.Single                   radius  // 0xA8
  private           System.Single                   hardness  // 0xAC
  private           System.Single                   wrapping  // 0xB0
  private           System.Single                   normalFront  // 0xB4
  private           System.Single                   normalBack  // 0xB8
  private           System.Single                   normalFade  // 0xBC
  private           UnityEngine.Texture             tileTexture  // 0xC0
  private           UnityEngine.Transform           tileTransform  // 0xC8
  private           System.Single                   tileOpacity  // 0xD0
  private           System.Single                   tileTransition  // 0xD4
  private           PaintIn3D.P3dModifierList       modifiers  // 0xD8
METHODS:
  System.Void set_Layers(UnityEngine.LayerMask value)
  UnityEngine.LayerMask get_Layers()
  System.Void set_TargetModel(PaintIn3D.P3dModel value)
  PaintIn3D.P3dModel get_TargetModel()
  System.Void set_Group(PaintIn3D.P3dGroup value)
  PaintIn3D.P3dGroup get_Group()
  System.Void set_TargetTexture(PaintIn3D.P3dPaintableTexture value)
  PaintIn3D.P3dPaintableTexture get_TargetTexture()
  System.Void set_BlendMode(PaintIn3D.P3dBlendMode value)
  PaintIn3D.P3dBlendMode get_BlendMode()
  System.Void set_Texture(UnityEngine.Texture value)
  UnityEngine.Texture get_Texture()
  System.Void set_Shape(UnityEngine.Texture value)
  UnityEngine.Texture get_Shape()
  System.Void set_ShapeChannel(PaintIn3D.P3dChannel value)
  PaintIn3D.P3dChannel get_ShapeChannel()
  System.Void set_Color(UnityEngine.Color value)
  UnityEngine.Color get_Color()
  System.Void set_Opacity(System.Single value)
  System.Single get_Opacity()
  System.Void set_Angle(System.Single value)
  System.Single get_Angle()
  System.Void set_Scale(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_Scale()
  System.Void set_Radius(System.Single value)
  System.Single get_Radius()
  System.Void set_Hardness(System.Single value)
  System.Single get_Hardness()
  System.Void set_Wrapping(System.Single value)
  System.Single get_Wrapping()
  System.Void set_NormalFront(System.Single value)
  System.Single get_NormalFront()
  System.Void set_NormalBack(System.Single value)
  System.Single get_NormalBack()
  System.Void set_NormalFade(System.Single value)
  System.Single get_NormalFade()
  System.Void set_TileTexture(UnityEngine.Texture value)
  UnityEngine.Texture get_TileTexture()
  System.Void set_TileTransform(UnityEngine.Transform value)
  UnityEngine.Transform get_TileTransform()
  System.Void set_TileOpacity(System.Single value)
  System.Single get_TileOpacity()
  System.Void set_TileTransition(System.Single value)
  System.Single get_TileTransition()
  PaintIn3D.P3dModifierList get_Modifiers()
  System.Void FlipHorizontal()
  System.Void FlipVertical()
  System.Void IncrementOpacity(System.Single delta)
  System.Void IncrementAngle(System.Single degrees)
  System.Void MultiplyScale(System.Single multiplier)
  System.Void MultiplyHardness(System.Single multiplier)
  System.Void HandleHitPoint(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void HandleHitLine(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Quaternion rotation, System.Boolean clip)
  System.Void HandleHitTriangle(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC, UnityEngine.Quaternion rotation)
  System.Void HandleHitQuad(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2, UnityEngine.Quaternion rotation, System.Boolean clip)
  System.Void HandleHitCoord(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation)
  UnityEngine.Vector3 HandleHitCommon(System.Boolean preview, System.Single pressure, System.Int32 seed, UnityEngine.Quaternion rotation)
  System.Void HandleMaskCommon(UnityEngine.Vector3 worldPosition)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dPaintFill
TYPE:  class
TOKEN: 0x20000A1
EXTENDS: MonoBehaviour
FIELDS:
  private           PaintIn3D.P3dGroup              group  // 0x18
  private           PaintIn3D.P3dBlendMode          blendMode  // 0x20
  private           UnityEngine.Texture             texture  // 0x58
  private           UnityEngine.Color               color  // 0x60
  private           System.Single                   opacity  // 0x70
  private           System.Single                   minimum  // 0x74
  private           PaintIn3D.P3dModifierList       modifiers  // 0x78
METHODS:
  System.Void set_Group(PaintIn3D.P3dGroup value)
  PaintIn3D.P3dGroup get_Group()
  System.Void set_BlendMode(PaintIn3D.P3dBlendMode value)
  PaintIn3D.P3dBlendMode get_BlendMode()
  System.Void set_Texture(UnityEngine.Texture value)
  UnityEngine.Texture get_Texture()
  System.Void set_Color(UnityEngine.Color value)
  UnityEngine.Color get_Color()
  System.Void set_Opacity(System.Single value)
  System.Single get_Opacity()
  System.Void set_Minimum(System.Single value)
  System.Single get_Minimum()
  PaintIn3D.P3dModifierList get_Modifiers()
  System.Void IncrementOpacity(System.Single delta)
  System.Void HandleHitCoord(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dPaintReplace
TYPE:  class
TOKEN: 0x20000A2
EXTENDS: MonoBehaviour
FIELDS:
  private           PaintIn3D.P3dGroup              group  // 0x18
  private           UnityEngine.Texture             texture  // 0x20
  private           UnityEngine.Color               color  // 0x28
  private           PaintIn3D.P3dModifierList       modifiers  // 0x38
METHODS:
  System.Void set_Group(PaintIn3D.P3dGroup value)
  PaintIn3D.P3dGroup get_Group()
  System.Void set_Texture(UnityEngine.Texture value)
  UnityEngine.Texture get_Texture()
  System.Void set_Color(UnityEngine.Color value)
  UnityEngine.Color get_Color()
  PaintIn3D.P3dModifierList get_Modifiers()
  System.Void HandleHitCoord(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dPaintReplaceChannels
TYPE:  class
TOKEN: 0x20000A3
EXTENDS: MonoBehaviour
FIELDS:
  private           PaintIn3D.P3dGroup              group  // 0x18
  private           UnityEngine.Texture             textureR  // 0x20
  private           UnityEngine.Texture             textureG  // 0x28
  private           UnityEngine.Texture             textureB  // 0x30
  private           UnityEngine.Texture             textureA  // 0x38
  private           UnityEngine.Vector4             channelR  // 0x40
  private           UnityEngine.Vector4             channelG  // 0x50
  private           UnityEngine.Vector4             channelB  // 0x60
  private           UnityEngine.Vector4             channelA  // 0x70
METHODS:
  System.Void set_Group(PaintIn3D.P3dGroup value)
  PaintIn3D.P3dGroup get_Group()
  System.Void set_TextureR(UnityEngine.Texture value)
  UnityEngine.Texture get_TextureR()
  System.Void set_TextureG(UnityEngine.Texture value)
  UnityEngine.Texture get_TextureG()
  System.Void set_TextureB(UnityEngine.Texture value)
  UnityEngine.Texture get_TextureB()
  System.Void set_TextureA(UnityEngine.Texture value)
  UnityEngine.Texture get_TextureA()
  System.Void set_ChannelR(UnityEngine.Vector4 value)
  UnityEngine.Vector4 get_ChannelR()
  System.Void set_ChannelG(UnityEngine.Vector4 value)
  UnityEngine.Vector4 get_ChannelG()
  System.Void set_ChannelB(UnityEngine.Vector4 value)
  UnityEngine.Vector4 get_ChannelB()
  System.Void set_ChannelA(UnityEngine.Vector4 value)
  UnityEngine.Vector4 get_ChannelA()
  System.Void HandleHitCoord(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation)
  System.Void .ctor()
END_CLASS

CLASS: PaintIn3D.P3dPaintSphere
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: MonoBehaviour
FIELDS:
  private           UnityEngine.LayerMask           layers  // 0x18
  private           PaintIn3D.P3dGroup              group  // 0x1C
  private           PaintIn3D.P3dModel              targetModel  // 0x20
  private           PaintIn3D.P3dPaintableTexture   targetTexture  // 0x28
  private           PaintIn3D.P3dBlendMode          blendMode  // 0x30
  private           UnityEngine.Color               color  // 0x68
  private           System.Single                   opacity  // 0x78
  private           System.Single                   angle  // 0x7C
  private           UnityEngine.Vector3             scale  // 0x80
  private           System.Single                   radius  // 0x8C
  private           System.Single                   hardness  // 0x90
  private           UnityEngine.Texture             tileTexture  // 0x98
  private           UnityEngine.Transform           tileTransform  // 0xA0
  private           System.Single                   tileOpacity  // 0xA8
  private           System.Single                   tileTransition  // 0xAC
  private           PaintIn3D.P3dModifierList       modifiers  // 0xB0
METHODS:
  System.Void set_Layers(UnityEngine.LayerMask value)
  UnityEngine.LayerMask get_Layers()
  System.Void set_Group(PaintIn3D.P3dGroup value)
  PaintIn3D.P3dGroup get_Group()
  System.Void set_TargetModel(PaintIn3D.P3dModel value)
  PaintIn3D.P3dModel get_TargetModel()
  System.Void set_TargetTexture(PaintIn3D.P3dPaintableTexture value)
  PaintIn3D.P3dPaintableTexture get_TargetTexture()
  System.Void set_BlendMode(PaintIn3D.P3dBlendMode value)
  PaintIn3D.P3dBlendMode get_BlendMode()
  System.Void set_Color(UnityEngine.Color value)
  UnityEngine.Color get_Color()
  System.Void set_Opacity(System.Single value)
  System.Single get_Opacity()
  System.Void set_Angle(System.Single value)
  System.Single get_Angle()
  System.Void set_Scale(UnityEngine.Vector3 value)
  UnityEngine.Vector3 get_Scale()
  System.Void set_Radius(System.Single value)
  System.Single get_Radius()
  System.Void set_Hardness(System.Single value)
  System.Single get_Hardness()
  System.Void set_TileTexture(UnityEngine.Texture value)
  UnityEngine.Texture get_TileTexture()
  System.Void set_TileTransform(UnityEngine.Transform value)
  UnityEngine.Transform get_TileTransform()
  System.Void set_TileOpacity(System.Single value)
  System.Single get_TileOpacity()
  System.Void set_TileTransition(System.Single value)
  System.Single get_TileTransition()
  PaintIn3D.P3dModifierList get_Modifiers()
  System.Void IncrementOpacity(System.Single delta)
  System.Void IncrementAngle(System.Single degrees)
  System.Void MultiplyRadius(System.Single multiplier)
  System.Void MultiplyScale(System.Single multiplier)
  System.Void HandleHitPoint(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
  System.Void HandleHitLine(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Quaternion rotation, System.Boolean clip)
  System.Void HandleHitTriangle(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC, UnityEngine.Quaternion rotation)
  System.Void HandleHitQuad(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2, UnityEngine.Quaternion rotation, System.Boolean clip)
  System.Void HandleHitCoord(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation)
  UnityEngine.Vector3 HandleHitCommon(System.Boolean preview, System.Single pressure, System.Int32 seed, UnityEngine.Quaternion rotation)
  System.Void HandleMaskCommon(UnityEngine.Vector3 worldPosition)
  System.Void .ctor()
END_CLASS

