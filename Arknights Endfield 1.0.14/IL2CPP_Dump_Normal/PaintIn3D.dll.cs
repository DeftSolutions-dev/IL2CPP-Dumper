// ========================================================
// Dumped by @desirepro
// Assembly: PaintIn3D.dll
// Classes:  164
// Date:     Jan 27 2026 21:51:21
// ========================================================

using System;
using System.Collections.Generic;

    // TypeToken: 0x2000008
    public class StringEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000A
    public struct ChannelType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dChannelCounterEvent.ChannelType Red;        // 0x0
        public static PaintIn3D.P3dChannelCounterEvent.ChannelType Green;        // 0x0
        public static PaintIn3D.P3dChannelCounterEvent.ChannelType Blue;        // 0x0
        public static PaintIn3D.P3dChannelCounterEvent.ChannelType Alpha;        // 0x0

    }

    // TypeToken: 0x200000C
    public struct ChannelType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dChannelCounterFill.ChannelType Red;        // 0x0
        public static PaintIn3D.P3dChannelCounterFill.ChannelType Green;        // 0x0
        public static PaintIn3D.P3dChannelCounterFill.ChannelType Blue;        // 0x0
        public static PaintIn3D.P3dChannelCounterFill.ChannelType Alpha;        // 0x0

    }

    // TypeToken: 0x200000E
    public class StringEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000F
    public struct ChannelType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dChannelCounterText.ChannelType Red;        // 0x0
        public static PaintIn3D.P3dChannelCounterText.ChannelType Green;        // 0x0
        public static PaintIn3D.P3dChannelCounterText.ChannelType Blue;        // 0x0
        public static PaintIn3D.P3dChannelCounterText.ChannelType Alpha;        // 0x0

    }

    // TypeToken: 0x2000013
    public class StringEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001B
    public struct PhaseType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitBetween.PhaseType Update;        // 0x0
        public static PaintIn3D.P3dHitBetween.PhaseType FixedUpdate;        // 0x0

    }

    // TypeToken: 0x200001C
    public struct OrientationType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitBetween.OrientationType WorldUp;        // 0x0
        public static PaintIn3D.P3dHitBetween.OrientationType CameraUp;        // 0x0
        public static PaintIn3D.P3dHitBetween.OrientationType ThisRotation;        // 0x0
        public static PaintIn3D.P3dHitBetween.OrientationType ThisLocalRotation;        // 0x0
        public static PaintIn3D.P3dHitBetween.OrientationType CustomRotation;        // 0x0
        public static PaintIn3D.P3dHitBetween.OrientationType CustomLocalRotation;        // 0x0

    }

    // TypeToken: 0x200001D
    public struct NormalType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitBetween.NormalType HitNormal;        // 0x0
        public static PaintIn3D.P3dHitBetween.NormalType RayDirection;        // 0x0

    }

    // TypeToken: 0x200001E
    public struct EmitType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitBetween.EmitType PointsIn3D;        // 0x0
        public static PaintIn3D.P3dHitBetween.EmitType PointsOnUV;        // 0x0
        public static PaintIn3D.P3dHitBetween.EmitType TrianglesIn3D;        // 0x0

    }

    // TypeToken: 0x2000021
    public struct EmitType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitCollisions.EmitType PointsIn3D;        // 0x0
        public static PaintIn3D.P3dHitCollisions.EmitType PointsOnUV;        // 0x0
        public static PaintIn3D.P3dHitCollisions.EmitType TrianglesIn3D;        // 0x0

    }

    // TypeToken: 0x2000022
    public struct OrientationType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitCollisions.OrientationType WorldUp;        // 0x0
        public static PaintIn3D.P3dHitCollisions.OrientationType CameraUp;        // 0x0

    }

    // TypeToken: 0x2000023
    public struct PressureType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitCollisions.PressureType Constant;        // 0x0
        public static PaintIn3D.P3dHitCollisions.PressureType ImpactSpeed;        // 0x0

    }

    // TypeToken: 0x2000025
    public struct PhaseType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitNearby.PhaseType ManuallyOnly;        // 0x0
        public static PaintIn3D.P3dHitNearby.PhaseType Update;        // 0x0
        public static PaintIn3D.P3dHitNearby.PhaseType FixedUpdate;        // 0x0

    }

    // TypeToken: 0x2000027
    public struct EmitType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitParticles.EmitType PointsIn3D;        // 0x0
        public static PaintIn3D.P3dHitParticles.EmitType PointsOnUV;        // 0x0
        public static PaintIn3D.P3dHitParticles.EmitType TrianglesIn3D;        // 0x0

    }

    // TypeToken: 0x2000028
    public struct OrientationType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitParticles.OrientationType WorldUp;        // 0x0
        public static PaintIn3D.P3dHitParticles.OrientationType CameraUp;        // 0x0

    }

    // TypeToken: 0x2000029
    public struct NormalType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitParticles.NormalType ParticleVelocity;        // 0x0
        public static PaintIn3D.P3dHitParticles.NormalType CollisionNormal;        // 0x0

    }

    // TypeToken: 0x200002A
    public struct PressureType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitParticles.PressureType Constant;        // 0x0
        public static PaintIn3D.P3dHitParticles.PressureType Distance;        // 0x0
        public static PaintIn3D.P3dHitParticles.PressureType Speed;        // 0x0

    }

    // TypeToken: 0x200002C
    public class Link : Link
    {
        // Fields
        public System.Single Age;        // 0x18
        public System.Boolean Down;        // 0x1C
        public System.Int32 State;        // 0x20
        public System.Single Distance;        // 0x24
        public UnityEngine.Vector2 ScreenDelta;        // 0x28
        public UnityEngine.Vector2 ScreenOld;        // 0x30
        public System.Collections.Generic.List<UnityEngine.Vector2> History;        // 0x38

        // Methods
        private System.Void Move(UnityEngine.Vector2 screenNew) { }
        private System.Boolean TryMove(UnityEngine.Vector2 screenNew) { }
        private System.Void Clear() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002D
    public struct FrequencyType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitScreen.FrequencyType PixelInterval;        // 0x0
        public static PaintIn3D.P3dHitScreen.FrequencyType ScaledPixelInterval;        // 0x0
        public static PaintIn3D.P3dHitScreen.FrequencyType TimeInterval;        // 0x0
        public static PaintIn3D.P3dHitScreen.FrequencyType OnceOnRelease;        // 0x0
        public static PaintIn3D.P3dHitScreen.FrequencyType OnceOnPress;        // 0x0
        public static PaintIn3D.P3dHitScreen.FrequencyType OnceEveryFrame;        // 0x0

    }

    // TypeToken: 0x200002F
    public struct RotationType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitScreenBase.RotationType Normal;        // 0x0
        public static PaintIn3D.P3dHitScreenBase.RotationType World;        // 0x0
        public static PaintIn3D.P3dHitScreenBase.RotationType ThisRotation;        // 0x0
        public static PaintIn3D.P3dHitScreenBase.RotationType ThisLocalRotation;        // 0x0
        public static PaintIn3D.P3dHitScreenBase.RotationType CustomRotation;        // 0x0
        public static PaintIn3D.P3dHitScreenBase.RotationType CustomLocalRotation;        // 0x0

    }

    // TypeToken: 0x2000030
    public struct RelativeType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitScreenBase.RelativeType WorldUp;        // 0x0
        public static PaintIn3D.P3dHitScreenBase.RelativeType CameraUp;        // 0x0
        public static PaintIn3D.P3dHitScreenBase.RelativeType DrawAngle;        // 0x0

    }

    // TypeToken: 0x2000031
    public struct DirectionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitScreenBase.DirectionType HitNormal;        // 0x0
        public static PaintIn3D.P3dHitScreenBase.DirectionType RayDirection;        // 0x0
        public static PaintIn3D.P3dHitScreenBase.DirectionType CameraDirection;        // 0x0

    }

    // TypeToken: 0x2000032
    public struct EmitType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitScreenBase.EmitType PointsIn3D;        // 0x0
        public static PaintIn3D.P3dHitScreenBase.EmitType PointsOnUV;        // 0x0
        public static PaintIn3D.P3dHitScreenBase.EmitType TrianglesIn3D;        // 0x0

    }

    // TypeToken: 0x2000033
    public struct ButtonTypes
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitScreenBase.ButtonTypes LeftMouse;        // 0x0
        public static PaintIn3D.P3dHitScreenBase.ButtonTypes RightMouse;        // 0x0
        public static PaintIn3D.P3dHitScreenBase.ButtonTypes MiddleMouse;        // 0x0
        public static PaintIn3D.P3dHitScreenBase.ButtonTypes Touch;        // 0x0

    }

    // TypeToken: 0x2000036
    public struct FrequencyType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitScreenLine.FrequencyType StartAndEnd;        // 0x0
        public static PaintIn3D.P3dHitScreenLine.FrequencyType PixelInterval;        // 0x0
        public static PaintIn3D.P3dHitScreenLine.FrequencyType ScaledPixelInterval;        // 0x0
        public static PaintIn3D.P3dHitScreenLine.FrequencyType StretchedPixelInterval;        // 0x0
        public static PaintIn3D.P3dHitScreenLine.FrequencyType StretchedScaledPixelInterval;        // 0x0
        public static PaintIn3D.P3dHitScreenLine.FrequencyType Once;        // 0x0

    }

    // TypeToken: 0x2000038
    public struct PhaseType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitThrough.PhaseType Update;        // 0x0
        public static PaintIn3D.P3dHitThrough.PhaseType FixedUpdate;        // 0x0

    }

    // TypeToken: 0x2000039
    public struct OrientationType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dHitThrough.OrientationType WorldUp;        // 0x0
        public static PaintIn3D.P3dHitThrough.OrientationType CameraUp;        // 0x0

    }

    // TypeToken: 0x2000046
    public class Pair
    {
        // Fields
        public UnityEngine.Mesh Source;        // 0x10
        public UnityEngine.Mesh Output;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000047
    public class Ring
    {
        // Fields
        public System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Point> Points;        // 0x10

        // Methods
        private PaintIn3D.P3dSeamFixer.Point GetPoint(System.Int32 index) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000048
    public class Edge
    {
        // Fields
        public System.Boolean Used;        // 0x10
        public PaintIn3D.P3dSeamFixer.Point PointA;        // 0x18
        public PaintIn3D.P3dSeamFixer.Point PointB;        // 0x20
        public System.Boolean Flip;        // 0x28

        // Methods
        private System.Boolean Match(PaintIn3D.P3dSeamFixer.Point a, PaintIn3D.P3dSeamFixer.Point b) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000049
    public class Point
    {
        // Fields
        public System.Int32 Index;        // 0x10
        public UnityEngine.Vector2 Coord;        // 0x14
        public PaintIn3D.P3dSeamFixer.Insertion Outer;        // 0x20
        public System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Edge> Edges;        // 0x28

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004A
    public class Insertion
    {
        // Fields
        public System.Int32 Index;        // 0x10
        public System.Int32 NewIndex;        // 0x14
        public UnityEngine.Vector2 NewCoord;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004E
    public struct BlendType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dModifyAngleRandom.BlendType Replace;        // 0x0
        public static PaintIn3D.P3dModifyAngleRandom.BlendType Multiply;        // 0x0
        public static PaintIn3D.P3dModifyAngleRandom.BlendType Increment;        // 0x0

    }

    // TypeToken: 0x2000050
    public struct BlendType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dModifyColorRandom.BlendType Replace;        // 0x0
        public static PaintIn3D.P3dModifyColorRandom.BlendType Multiply;        // 0x0
        public static PaintIn3D.P3dModifyColorRandom.BlendType Increment;        // 0x0

    }

    // TypeToken: 0x2000052
    public struct BlendType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dModifyHardnessPressure.BlendType Replace;        // 0x0
        public static PaintIn3D.P3dModifyHardnessPressure.BlendType Multiply;        // 0x0
        public static PaintIn3D.P3dModifyHardnessPressure.BlendType Increment;        // 0x0

    }

    // TypeToken: 0x2000054
    public struct BlendType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dModifyHardnessRandom.BlendType Replace;        // 0x0
        public static PaintIn3D.P3dModifyHardnessRandom.BlendType Multiply;        // 0x0
        public static PaintIn3D.P3dModifyHardnessRandom.BlendType Increment;        // 0x0

    }

    // TypeToken: 0x2000056
    public struct BlendType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dModifyOpacityPressure.BlendType Replace;        // 0x0
        public static PaintIn3D.P3dModifyOpacityPressure.BlendType Multiply;        // 0x0
        public static PaintIn3D.P3dModifyOpacityPressure.BlendType Increment;        // 0x0

    }

    // TypeToken: 0x2000058
    public struct BlendType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dModifyOpacityRandom.BlendType Replace;        // 0x0
        public static PaintIn3D.P3dModifyOpacityRandom.BlendType Multiply;        // 0x0
        public static PaintIn3D.P3dModifyOpacityRandom.BlendType Increment;        // 0x0

    }

    // TypeToken: 0x200005B
    public struct BlendType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dModifyRadiusPressure.BlendType Replace;        // 0x0
        public static PaintIn3D.P3dModifyRadiusPressure.BlendType Multiply;        // 0x0
        public static PaintIn3D.P3dModifyRadiusPressure.BlendType Increment;        // 0x0

    }

    // TypeToken: 0x200005D
    public struct BlendType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dModifyRadiusRandom.BlendType Replace;        // 0x0
        public static PaintIn3D.P3dModifyRadiusRandom.BlendType Multiply;        // 0x0
        public static PaintIn3D.P3dModifyRadiusRandom.BlendType Increment;        // 0x0

    }

    // TypeToken: 0x200005F
    public struct BlendType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dModifyScaleRandom.BlendType Replace;        // 0x0
        public static PaintIn3D.P3dModifyScaleRandom.BlendType Multiply;        // 0x0
        public static PaintIn3D.P3dModifyScaleRandom.BlendType Increment;        // 0x0

    }

    // TypeToken: 0x200006A
    public class Contribution
    {
        // Fields
        public PaintIn3D.P3dColorCounter Counter;        // 0x10
        public System.Int32 Solid;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200006C
    public class Contribution
    {
        // Fields
        public PaintIn3D.P3dColor Color;        // 0x10
        public System.Int32 Count;        // 0x18
        public System.Single Ratio;        // 0x1C
        public System.Byte R;        // 0x20
        public System.Byte G;        // 0x21
        public System.Byte B;        // 0x22
        public System.Byte A;        // 0x23
        public static System.Collections.Generic.Stack<PaintIn3D.P3dColorCounter.Contribution> Pool;        // 0x0

        // Methods
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000072
    public struct Coord
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dCoordCopier.Coord First;        // 0x0
        public static PaintIn3D.P3dCoordCopier.Coord Second;        // 0x0
        public static PaintIn3D.P3dCoordCopier.Coord Third;        // 0x0
        public static PaintIn3D.P3dCoordCopier.Coord Fourth;        // 0x0
        public static PaintIn3D.P3dCoordCopier.Coord None;        // 0x0

    }

    // TypeToken: 0x2000076
    public class TextureData
    {
        // Fields
        public System.String Name;        // 0x10
        public PaintIn3D.P3dBlendMode BlendMode;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000077
    public class Entry
    {
        // Fields
        public System.String Path;        // 0x10
        public System.String Property;        // 0x18

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200007E
    public class Link
    {
        // Fields
        public System.Object Owner;        // 0x10
        public UnityEngine.Vector3 Position;        // 0x18
        public UnityEngine.Vector3 EndPosition;        // 0x24
        public System.Single Age;        // 0x30
        public System.Boolean Preview;        // 0x34

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000082
    public class MeshData
    {
        // Fields
        private UnityEngine.Vector3[] positions;        // 0x10
        private System.Int32[] indices;        // 0x18
        private System.Int32 total;        // 0x20

        // Methods
        private System.Void Update(UnityEngine.Mesh mesh) { }
        private System.Boolean GetTrianglePositions(UnityEngine.RaycastHit hit, UnityEngine.Vector3& positionA, UnityEngine.Vector3& positionB, UnityEngine.Vector3& positionC) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000084
    public struct UseMeshType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dModel.UseMeshType AsIs;        // 0x0
        public static PaintIn3D.P3dModel.UseMeshType AutoSeamFix;        // 0x0

    }

    // TypeToken: 0x2000088
    public struct ActivationType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dPaintable.ActivationType Awake;        // 0x0
        public static PaintIn3D.P3dPaintable.ActivationType OnEnable;        // 0x0
        public static PaintIn3D.P3dPaintable.ActivationType Start;        // 0x0
        public static PaintIn3D.P3dPaintable.ActivationType OnFirstUse;        // 0x0

    }

    // TypeToken: 0x200008C
    public struct UndoRedoType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dPaintableTexture.UndoRedoType None;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.UndoRedoType FullTextureCopy;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.UndoRedoType LocalCommandCopy;        // 0x0

    }

    // TypeToken: 0x200008D
    public struct SaveLoadType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dPaintableTexture.SaveLoadType Manual;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.SaveLoadType Automatic;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.SaveLoadType SemiManual;        // 0x0

    }

    // TypeToken: 0x200008E
    public struct MipType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dPaintableTexture.MipType Auto;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.MipType On;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.MipType Off;        // 0x0

    }

    // TypeToken: 0x200008F
    public struct FilterType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dPaintableTexture.FilterType Auto;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.FilterType Point;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.FilterType Bilinear;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.FilterType Trilinear;        // 0x0

    }

    // TypeToken: 0x2000090
    public struct AnisoType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dPaintableTexture.AnisoType Auto;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.AnisoType Off;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.AnisoType One;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.AnisoType Four;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.AnisoType Eight;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.AnisoType Sixteen;        // 0x0

    }

    // TypeToken: 0x2000091
    public struct WrapType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dPaintableTexture.WrapType Auto;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.WrapType Repeat;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.WrapType Clamp;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.WrapType Mirror;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.WrapType MirrorOnce;        // 0x0

    }

    // TypeToken: 0x2000092
    public struct ExistingType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dPaintableTexture.ExistingType Ignore;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.ExistingType Use;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.ExistingType UseAndKeep;        // 0x0

    }

    // TypeToken: 0x2000093
    public struct ConversionType
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dPaintableTexture.ConversionType None;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.ConversionType Normal;        // 0x0
        public static PaintIn3D.P3dPaintableTexture.ConversionType Premultiply;        // 0x0

    }

    // TypeToken: 0x2000094
    public class PaintableTextureEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000098
    public class Link
    {
        // Fields
        public System.Object Owner;        // 0x10
        public UnityEngine.Vector3 Position;        // 0x18
        public System.Single Age;        // 0x24
        public System.Boolean Preview;        // 0x28
        public UnityEngine.Vector3 LastPosition;        // 0x2C
        public System.Single LastPressure;        // 0x38
        public System.Int32 LastPriority;        // 0x3C
        public UnityEngine.Quaternion LastRotation;        // 0x40

        // Methods
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009A
    public class ColorEvent : UnityEvent`1
    {
        // Methods
        private System.Void .ctor() { }

    }

namespace PaintIn3D
{

    // TypeToken: 0x2000002
    public class P3dButtonClearAll : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
    {
        // Fields
        private System.Boolean clearStates;        // 0x18

        // Methods
        private System.Void set_ClearStates(System.Boolean value) { }
        private System.Boolean get_ClearStates() { }
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void ClearAll() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000003
    public class P3dButtonRedoAll : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
    {
        // Methods
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void RedoAll() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000004
    public class P3dButtonUndoAll : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
    {
        // Methods
        private System.Void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData) { }
        private System.Void UndoAll() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000005
    public class P3dChangeCounterEvent : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<PaintIn3D.P3dChangeCounter> counters;        // 0x18
        private UnityEngine.Vector2 range;        // 0x20
        private System.Boolean inside;        // 0x28
        private UnityEngine.Events.UnityEvent onInside;        // 0x30
        private UnityEngine.Events.UnityEvent onOutside;        // 0x38

        // Methods
        private System.Collections.Generic.List<PaintIn3D.P3dChangeCounter> get_Counters() { }
        private System.Void set_Range(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_Range() { }
        private System.Void set_Inside(System.Boolean value) { }
        private System.Boolean get_Inside() { }
        private UnityEngine.Events.UnityEvent get_OnInside() { }
        private UnityEngine.Events.UnityEvent get_OnOutside() { }
        private System.Single get_Ratio() { }
        private System.Void Update() { }
        private System.Void UpdateInside(System.Single ratio) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000006
    public class P3dChangeCounterFill : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<PaintIn3D.P3dChangeCounter> counters;        // 0x18
        private System.Boolean inverse;        // 0x20
        private UnityEngine.UI.Image cachedImage;        // 0x28

        // Methods
        private System.Collections.Generic.List<PaintIn3D.P3dChangeCounter> get_Counters() { }
        private System.Void set_Inverse(System.Boolean value) { }
        private System.Boolean get_Inverse() { }
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000007
    public class P3dChangeCounterText : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<PaintIn3D.P3dChangeCounter> counters;        // 0x18
        private System.Boolean inverse;        // 0x20
        private System.Int32 decimalPlaces;        // 0x24
        private System.String format;        // 0x28
        private PaintIn3D.P3dChangeCounterText.StringEvent onString;        // 0x30

        // Methods
        private System.Collections.Generic.List<PaintIn3D.P3dChangeCounter> get_Counters() { }
        private System.Void set_Inverse(System.Boolean value) { }
        private System.Boolean get_Inverse() { }
        private System.Void set_DecimalPlaces(System.Int32 value) { }
        private System.Int32 get_DecimalPlaces() { }
        private System.Void set_Format(System.String value) { }
        private System.String get_Format() { }
        private PaintIn3D.P3dChangeCounterText.StringEvent get_OnString() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000009
    public class P3dChannelCounterEvent : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<PaintIn3D.P3dChannelCounter> counters;        // 0x18
        private PaintIn3D.P3dChannelCounterEvent.ChannelType channel;        // 0x20
        private UnityEngine.Vector2 range;        // 0x24
        private System.Boolean inside;        // 0x2C
        private UnityEngine.Events.UnityEvent onInside;        // 0x30
        private UnityEngine.Events.UnityEvent onOutside;        // 0x38

        // Methods
        private System.Collections.Generic.List<PaintIn3D.P3dChannelCounter> get_Counters() { }
        private System.Void set_Channel(PaintIn3D.P3dChannelCounterEvent.ChannelType value) { }
        private PaintIn3D.P3dChannelCounterEvent.ChannelType get_Channel() { }
        private System.Void set_Range(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_Range() { }
        private System.Void set_Inside(System.Boolean value) { }
        private System.Boolean get_Inside() { }
        private UnityEngine.Events.UnityEvent get_OnInside() { }
        private UnityEngine.Events.UnityEvent get_OnOutside() { }
        private System.Single get_Ratio() { }
        private System.Void Update() { }
        private System.Void UpdateInside(System.Single ratio) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000B
    public class P3dChannelCounterFill : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<PaintIn3D.P3dChannelCounter> counters;        // 0x18
        private PaintIn3D.P3dChannelCounterFill.ChannelType channel;        // 0x20
        private System.Boolean inverse;        // 0x24
        private UnityEngine.UI.Image cachedImage;        // 0x28

        // Methods
        private System.Collections.Generic.List<PaintIn3D.P3dChannelCounter> get_Counters() { }
        private System.Void set_Channel(PaintIn3D.P3dChannelCounterFill.ChannelType value) { }
        private PaintIn3D.P3dChannelCounterFill.ChannelType get_Channel() { }
        private System.Void set_Inverse(System.Boolean value) { }
        private System.Boolean get_Inverse() { }
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200000D
    public class P3dChannelCounterText : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<PaintIn3D.P3dChannelCounter> counters;        // 0x18
        private PaintIn3D.P3dChannelCounterText.ChannelType channel;        // 0x20
        private System.Boolean inverse;        // 0x24
        private System.Int32 decimalPlaces;        // 0x28
        private System.String format;        // 0x30
        private PaintIn3D.P3dChannelCounterText.StringEvent onString;        // 0x38

        // Methods
        private System.Collections.Generic.List<PaintIn3D.P3dChannelCounter> get_Counters() { }
        private System.Void set_Channel(PaintIn3D.P3dChannelCounterText.ChannelType value) { }
        private PaintIn3D.P3dChannelCounterText.ChannelType get_Channel() { }
        private System.Void set_Inverse(System.Boolean value) { }
        private System.Boolean get_Inverse() { }
        private System.Void set_DecimalPlaces(System.Int32 value) { }
        private System.Int32 get_DecimalPlaces() { }
        private System.Void set_Format(System.String value) { }
        private System.String get_Format() { }
        private PaintIn3D.P3dChannelCounterText.StringEvent get_OnString() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000010
    public class P3dColorCounterEvent : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<PaintIn3D.P3dColorCounter> counters;        // 0x18
        private PaintIn3D.P3dColor color;        // 0x20
        private UnityEngine.Vector2 range;        // 0x28
        private System.Boolean inside;        // 0x30
        private UnityEngine.Events.UnityEvent onInside;        // 0x38
        private UnityEngine.Events.UnityEvent onOutside;        // 0x40

        // Methods
        private System.Collections.Generic.List<PaintIn3D.P3dColorCounter> get_Counters() { }
        private System.Void set_Color(PaintIn3D.P3dColor value) { }
        private PaintIn3D.P3dColor get_Color() { }
        private System.Void set_Range(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_Range() { }
        private System.Void set_Inside(System.Boolean value) { }
        private System.Boolean get_Inside() { }
        private UnityEngine.Events.UnityEvent get_OnInside() { }
        private UnityEngine.Events.UnityEvent get_OnOutside() { }
        private System.Single get_Ratio() { }
        private System.Void Update() { }
        private System.Void UpdateInside(System.Single ratio) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000011
    public class P3dColorCounterFill : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<PaintIn3D.P3dColorCounter> counters;        // 0x18
        private PaintIn3D.P3dColor color;        // 0x20
        private System.Boolean inverse;        // 0x28
        private UnityEngine.UI.Image cachedImage;        // 0x30

        // Methods
        private System.Collections.Generic.List<PaintIn3D.P3dColorCounter> get_Counters() { }
        private System.Void set_Color(PaintIn3D.P3dColor value) { }
        private PaintIn3D.P3dColor get_Color() { }
        private System.Void set_Inverse(System.Boolean value) { }
        private System.Boolean get_Inverse() { }
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000012
    public class P3dColorCounterText : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<PaintIn3D.P3dColorCounter> counters;        // 0x18
        private PaintIn3D.P3dColor color;        // 0x20
        private System.Boolean inverse;        // 0x28
        private System.Int32 decimalPlaces;        // 0x2C
        private System.String format;        // 0x30
        private PaintIn3D.P3dColorCounterText.StringEvent onString;        // 0x38

        // Methods
        private System.Collections.Generic.List<PaintIn3D.P3dColorCounter> get_Counters() { }
        private System.Void set_Color(PaintIn3D.P3dColor value) { }
        private PaintIn3D.P3dColor get_Color() { }
        private System.Void set_Inverse(System.Boolean value) { }
        private System.Boolean get_Inverse() { }
        private System.Void set_DecimalPlaces(System.Int32 value) { }
        private System.Int32 get_DecimalPlaces() { }
        private System.Void set_Format(System.String value) { }
        private System.String get_Format() { }
        private PaintIn3D.P3dColorCounterText.StringEvent get_OnString() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000014
    public class P3dPaintDebug : MonoBehaviour, IHitPoint, IHit, IHitLine, IHitTriangle, IHitQuad
    {
        // Fields
        private UnityEngine.Color color;        // 0x18
        private System.Single duration;        // 0x28
        private System.Single size;        // 0x2C

        // Methods
        private System.Void set_Color(UnityEngine.Color value) { }
        private UnityEngine.Color get_Color() { }
        private System.Void set_Duration(System.Single value) { }
        private System.Single get_Duration() { }
        private System.Void set_Size(System.Single value) { }
        private System.Single get_Size() { }
        private System.Void HandleHitPoint(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void HandleHitLine(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Quaternion rotation, System.Boolean clip) { }
        private System.Void HandleHitTriangle(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC, UnityEngine.Quaternion rotation) { }
        private System.Void HandleHitQuad(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2, UnityEngine.Quaternion rotation, System.Boolean clip) { }
        private UnityEngine.Color GetColor(System.Boolean preview, System.Single pressure, UnityEngine.Color color) { }
        private System.Void DrawArrow(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Color tint) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000015
    public class P3dCommandDecal : P3dCommand
    {
        // Fields
        public PaintIn3D.P3dBlendMode Blend;        // 0x70
        public System.Boolean In3D;        // 0xA8
        public UnityEngine.Vector3 Position;        // 0xAC
        public UnityEngine.Vector3 EndPosition;        // 0xB8
        public UnityEngine.Vector3 Position2;        // 0xC4
        public UnityEngine.Vector3 EndPosition2;        // 0xD0
        public System.Int32 Extrusions;        // 0xDC
        public System.Boolean Clip;        // 0xE0
        public UnityEngine.Matrix4x4 Matrix;        // 0xE4
        public UnityEngine.Vector3 Direction;        // 0x124
        public UnityEngine.Color Color;        // 0x130
        public System.Single Opacity;        // 0x140
        public System.Single Hardness;        // 0x144
        public System.Single Wrapping;        // 0x148
        public PaintIn3D.P3dHashedTexture Texture;        // 0x150
        public PaintIn3D.P3dHashedTexture Shape;        // 0x160
        public UnityEngine.Vector4 ShapeChannel;        // 0x170
        public UnityEngine.Vector2 NormalFront;        // 0x180
        public UnityEngine.Vector2 NormalBack;        // 0x188
        public PaintIn3D.P3dHashedTexture TileTexture;        // 0x190
        public UnityEngine.Matrix4x4 TileMatrix;        // 0x1A0
        public System.Single TileOpacity;        // 0x1E0
        public System.Single TileTransition;        // 0x1E4
        public UnityEngine.Matrix4x4 MaskMatrix;        // 0x1E8
        public PaintIn3D.P3dHashedTexture MaskShape;        // 0x228
        public UnityEngine.Vector4 MaskChannel;        // 0x238
        public UnityEngine.Vector3 MaskStretch;        // 0x248
        public static PaintIn3D.P3dCommandDecal Instance;        // 0x0
        private static System.Collections.Generic.Stack<PaintIn3D.P3dCommandDecal> pool;        // 0x8
        private static UnityEngine.Material cachedSpotMaterial;        // 0x10
        private static UnityEngine.Material cachedLineMaterial;        // 0x18
        private static UnityEngine.Material cachedQuadMaterial;        // 0x20
        private static UnityEngine.Material cachedLineClipMaterial;        // 0x28
        private static UnityEngine.Material cachedQuadClipMaterial;        // 0x30
        private static System.Int32 cachedSpotMaterialHash;        // 0x38
        private static System.Int32 cachedLineMaterialHash;        // 0x3C
        private static System.Int32 cachedQuadMaterialHash;        // 0x40
        private static System.Int32 cachedLineClipMaterialHash;        // 0x44
        private static System.Int32 cachedQuadClipMaterialHash;        // 0x48
        private static System.Int32 _In3D;        // 0x4C
        private static System.Int32 _Position;        // 0x50
        private static System.Int32 _EndPosition;        // 0x54
        private static System.Int32 _Position2;        // 0x58
        private static System.Int32 _EndPosition2;        // 0x5C
        private static System.Int32 _Matrix;        // 0x60
        private static System.Int32 _Direction;        // 0x64
        private static System.Int32 _Color;        // 0x68
        private static System.Int32 _Opacity;        // 0x6C
        private static System.Int32 _Hardness;        // 0x70
        private static System.Int32 _Wrapping;        // 0x74
        private static System.Int32 _Texture;        // 0x78
        private static System.Int32 _Shape;        // 0x7C
        private static System.Int32 _ShapeChannel;        // 0x80
        private static System.Int32 _NormalFront;        // 0x84
        private static System.Int32 _NormalBack;        // 0x88
        private static System.Int32 _TileTexture;        // 0x8C
        private static System.Int32 _TileMatrix;        // 0x90
        private static System.Int32 _TileOpacity;        // 0x94
        private static System.Int32 _TileTransition;        // 0x98
        private static System.Int32 _MaskMatrix;        // 0x9C
        private static System.Int32 _MaskTexture;        // 0xA0
        private static System.Int32 _MaskChannel;        // 0xA4
        private static System.Int32 _MaskStretch;        // 0xA8

        // Methods
        private System.Boolean get_RequireMesh() { }
        private System.Void .cctor() { }
        private System.Void Apply(UnityEngine.Material material) { }
        private System.Void Pool() { }
        private System.Void Transform(UnityEngine.Matrix4x4 posMatrix, UnityEngine.Matrix4x4 rotMatrix) { }
        private PaintIn3D.P3dCommand SpawnCopy() { }
        private System.Void Apply(PaintIn3D.P3dPaintableTexture paintableTexture) { }
        private System.Void SetShape(UnityEngine.Quaternion rotation, UnityEngine.Vector3 size, System.Single angle) { }
        private System.Void SetLocation(UnityEngine.Vector3 position, System.Boolean in3D) { }
        private System.Void SetLocation(UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, System.Boolean in3D, System.Boolean clip) { }
        private System.Void SetLocation(UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC, System.Boolean in3D) { }
        private System.Void SetLocation(UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2, System.Boolean in3D, System.Boolean clip) { }
        private System.Void ClearMask() { }
        private System.Void SetMask(UnityEngine.Matrix4x4 matrix, UnityEngine.Texture shape, PaintIn3D.P3dChannel channel, UnityEngine.Vector3 stretch) { }
        private System.Void ApplyAspect(UnityEngine.Texture texture) { }
        private System.Void SetMaterial(PaintIn3D.P3dBlendMode blendMode, UnityEngine.Texture texture, UnityEngine.Texture shape, PaintIn3D.P3dChannel shapeChannel, System.Single hardness, System.Single wrapping, System.Single normalBack, System.Single normalFront, System.Single normalFade, UnityEngine.Color color, System.Single opacity, UnityEngine.Texture tileTexture, UnityEngine.Matrix4x4 tileMatrix, System.Single tileOpacity, System.Single tileTransition) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000016
    public class P3dCommandFill : P3dCommand
    {
        // Fields
        public PaintIn3D.P3dBlendMode Blend;        // 0x70
        public PaintIn3D.P3dHashedTexture Texture;        // 0xA8
        public UnityEngine.Color Color;        // 0xB8
        public System.Single Opacity;        // 0xC8
        public System.Single Minimum;        // 0xCC
        public static PaintIn3D.P3dCommandFill Instance;        // 0x0
        private static System.Collections.Generic.Stack<PaintIn3D.P3dCommandFill> pool;        // 0x8
        private static UnityEngine.Material cachedMaterial;        // 0x10
        private static System.Int32 cachedMaterialHash;        // 0x18
        private static System.Int32 _Buffer;        // 0x1C
        private static System.Int32 _BufferSize;        // 0x20
        private static System.Int32 _Texture;        // 0x24
        private static System.Int32 _Color;        // 0x28
        private static System.Int32 _Opacity;        // 0x2C
        private static System.Int32 _Minimum;        // 0x30

        // Methods
        private System.Boolean get_RequireMesh() { }
        private System.Void .cctor() { }
        private UnityEngine.RenderTexture Blit(UnityEngine.RenderTexture main, PaintIn3D.P3dBlendMode blendMode, UnityEngine.Texture texture, UnityEngine.Color color, System.Single opacity, System.Single minimum) { }
        private System.Void Blit(UnityEngine.RenderTexture& main, UnityEngine.RenderTexture& swap, PaintIn3D.P3dBlendMode blendMode, UnityEngine.Texture texture, UnityEngine.Color color, System.Single opacity, System.Single minimum) { }
        private System.Void Apply(UnityEngine.Material material) { }
        private System.Void Pool() { }
        private System.Void Transform(UnityEngine.Matrix4x4 posMatrix, UnityEngine.Matrix4x4 rotMatrix) { }
        private PaintIn3D.P3dCommand SpawnCopy() { }
        private System.Void Apply(PaintIn3D.P3dPaintableTexture paintableTexture) { }
        private UnityEngine.Material SetMaterial(PaintIn3D.P3dBlendMode blendMode, UnityEngine.Texture texture, UnityEngine.Color color, System.Single opacity, System.Single minimum) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000017
    public class P3dCommandReplace : P3dCommand
    {
        // Fields
        public PaintIn3D.P3dHashedTexture Texture;        // 0x70
        public UnityEngine.Color Color;        // 0x80
        public static PaintIn3D.P3dCommandReplace Instance;        // 0x0
        private static System.Collections.Generic.Stack<PaintIn3D.P3dCommandReplace> pool;        // 0x8
        private static UnityEngine.Material cachedMaterial;        // 0x10
        private static System.Int32 cachedMaterialHash;        // 0x18
        private static System.Int32 _Texture;        // 0x1C
        private static System.Int32 _Color;        // 0x20

        // Methods
        private System.Boolean get_RequireMesh() { }
        private System.Void .cctor() { }
        private System.Void Blit(UnityEngine.RenderTexture renderTexture, UnityEngine.Texture texture, UnityEngine.Color tint) { }
        private System.Void BlitFast(UnityEngine.RenderTexture renderTexture, UnityEngine.Texture texture, UnityEngine.Color tint) { }
        private System.Void Apply(UnityEngine.Material material) { }
        private System.Void Pool() { }
        private System.Void Transform(UnityEngine.Matrix4x4 posMatrix, UnityEngine.Matrix4x4 rotMatrix) { }
        private PaintIn3D.P3dCommand SpawnCopy() { }
        private UnityEngine.Material SetMaterial(UnityEngine.Texture texture, UnityEngine.Color color) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000018
    public class P3dCommandReplaceChannels : P3dCommand
    {
        // Fields
        public PaintIn3D.P3dHashedTexture TextureR;        // 0x70
        public PaintIn3D.P3dHashedTexture TextureG;        // 0x80
        public PaintIn3D.P3dHashedTexture TextureB;        // 0x90
        public PaintIn3D.P3dHashedTexture TextureA;        // 0xA0
        public UnityEngine.Vector4 ChannelR;        // 0xB0
        public UnityEngine.Vector4 ChannelG;        // 0xC0
        public UnityEngine.Vector4 ChannelB;        // 0xD0
        public UnityEngine.Vector4 ChannelA;        // 0xE0
        public static PaintIn3D.P3dCommandReplaceChannels Instance;        // 0x0
        private static System.Collections.Generic.Stack<PaintIn3D.P3dCommandReplaceChannels> pool;        // 0x8
        private static UnityEngine.Material cachedMaterial;        // 0x10
        private static System.Int32 cachedMaterialHash;        // 0x18
        private static System.Int32 _TextureR;        // 0x1C
        private static System.Int32 _TextureG;        // 0x20
        private static System.Int32 _TextureB;        // 0x24
        private static System.Int32 _TextureA;        // 0x28
        private static System.Int32 _ChannelR;        // 0x2C
        private static System.Int32 _ChannelG;        // 0x30
        private static System.Int32 _ChannelB;        // 0x34
        private static System.Int32 _ChannelA;        // 0x38

        // Methods
        private System.Boolean get_RequireMesh() { }
        private System.Void .cctor() { }
        private System.Void Blit(UnityEngine.RenderTexture renderTexture, UnityEngine.Texture textureR, UnityEngine.Texture textureG, UnityEngine.Texture textureB, UnityEngine.Texture textureA, UnityEngine.Vector4 channelR, UnityEngine.Vector4 channelG, UnityEngine.Vector4 channelB, UnityEngine.Vector4 channelA, UnityEngine.Vector4 channels) { }
        private System.Void BlitFast(UnityEngine.RenderTexture renderTexture, UnityEngine.Texture textureR, UnityEngine.Texture textureG, UnityEngine.Texture textureB, UnityEngine.Texture textureA, UnityEngine.Vector4 channelR, UnityEngine.Vector4 channelG, UnityEngine.Vector4 channelB, UnityEngine.Vector4 channelA) { }
        private System.Void Apply(UnityEngine.Material material) { }
        private System.Void Pool() { }
        private System.Void Transform(UnityEngine.Matrix4x4 posMatrix, UnityEngine.Matrix4x4 rotMatrix) { }
        private PaintIn3D.P3dCommand SpawnCopy() { }
        private UnityEngine.Material SetMaterial(UnityEngine.Texture textureR, UnityEngine.Texture textureG, UnityEngine.Texture textureB, UnityEngine.Texture textureA, UnityEngine.Vector4 channelR, UnityEngine.Vector4 channelG, UnityEngine.Vector4 channelB, UnityEngine.Vector4 channelA) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000019
    public class P3dCommandSphere : P3dCommand
    {
        // Fields
        public PaintIn3D.P3dBlendMode Blend;        // 0x70
        public System.Boolean In3D;        // 0xA8
        public UnityEngine.Vector3 Position;        // 0xAC
        public UnityEngine.Vector3 EndPosition;        // 0xB8
        public UnityEngine.Vector3 Position2;        // 0xC4
        public UnityEngine.Vector3 EndPosition2;        // 0xD0
        public System.Int32 Extrusions;        // 0xDC
        public System.Boolean Clip;        // 0xE0
        public UnityEngine.Matrix4x4 Matrix;        // 0xE4
        public UnityEngine.Color Color;        // 0x124
        public System.Single Opacity;        // 0x134
        public System.Single Hardness;        // 0x138
        public PaintIn3D.P3dHashedTexture TileTexture;        // 0x140
        public UnityEngine.Matrix4x4 TileMatrix;        // 0x150
        public System.Single TileOpacity;        // 0x190
        public System.Single TileTransition;        // 0x194
        public UnityEngine.Matrix4x4 MaskMatrix;        // 0x198
        public PaintIn3D.P3dHashedTexture MaskShape;        // 0x1D8
        public UnityEngine.Vector4 MaskChannel;        // 0x1E8
        public UnityEngine.Vector3 MaskStretch;        // 0x1F8
        public static PaintIn3D.P3dCommandSphere Instance;        // 0x0
        private static System.Collections.Generic.Stack<PaintIn3D.P3dCommandSphere> pool;        // 0x8
        private static UnityEngine.Material cachedSpotMaterial;        // 0x10
        private static UnityEngine.Material cachedLineMaterial;        // 0x18
        private static UnityEngine.Material cachedQuadMaterial;        // 0x20
        private static UnityEngine.Material cachedLineClipMaterial;        // 0x28
        private static UnityEngine.Material cachedQuadClipMaterial;        // 0x30
        private static System.Int32 cachedSpotMaterialHash;        // 0x38
        private static System.Int32 cachedLineMaterialHash;        // 0x3C
        private static System.Int32 cachedQuadMaterialHash;        // 0x40
        private static System.Int32 cachedLineClipMaterialHash;        // 0x44
        private static System.Int32 cachedQuadClipMaterialHash;        // 0x48
        private static System.Int32 _In3D;        // 0x4C
        private static System.Int32 _Position;        // 0x50
        private static System.Int32 _EndPosition;        // 0x54
        private static System.Int32 _Position2;        // 0x58
        private static System.Int32 _EndPosition2;        // 0x5C
        private static System.Int32 _Matrix;        // 0x60
        private static System.Int32 _Color;        // 0x64
        private static System.Int32 _Opacity;        // 0x68
        private static System.Int32 _Hardness;        // 0x6C
        private static System.Int32 _TileTexture;        // 0x70
        private static System.Int32 _TileMatrix;        // 0x74
        private static System.Int32 _TileOpacity;        // 0x78
        private static System.Int32 _TileTransition;        // 0x7C
        private static System.Int32 _MaskMatrix;        // 0x80
        private static System.Int32 _MaskTexture;        // 0x84
        private static System.Int32 _MaskChannel;        // 0x88
        private static System.Int32 _MaskStretch;        // 0x8C

        // Methods
        private System.Boolean get_RequireMesh() { }
        private System.Void .cctor() { }
        private System.Void Apply(UnityEngine.Material material) { }
        private System.Void Pool() { }
        private System.Void Transform(UnityEngine.Matrix4x4 posMatrix, UnityEngine.Matrix4x4 rotMatrix) { }
        private PaintIn3D.P3dCommand SpawnCopy() { }
        private System.Void Apply(PaintIn3D.P3dPaintableTexture paintableTexture) { }
        private System.Void SetLocation(UnityEngine.Vector3 position, System.Boolean in3D) { }
        private System.Void SetLocation(UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, System.Boolean in3D, System.Boolean clip) { }
        private System.Void SetLocation(UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC, System.Boolean in3D) { }
        private System.Void SetLocation(UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2, System.Boolean in3D, System.Boolean clip) { }
        private System.Void ClearMask() { }
        private System.Void SetMask(UnityEngine.Matrix4x4 matrix, UnityEngine.Texture shape, PaintIn3D.P3dChannel channel, UnityEngine.Vector3 stretch) { }
        private System.Void ApplyAspect(UnityEngine.Texture texture) { }
        private System.Void SetShape(System.Single radius) { }
        private System.Void SetShape(UnityEngine.Quaternion rotation, UnityEngine.Vector3 size, System.Single angle) { }
        private System.Void SetMaterial(PaintIn3D.P3dBlendMode blendMode, System.Single hardness, UnityEngine.Color color, System.Single opacity, UnityEngine.Texture tileTexture, UnityEngine.Matrix4x4 tileMatrix, System.Single tileOpacity, System.Single tileTransition) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001A
    public class P3dHitBetween : MonoBehaviour
    {
        // Fields
        private PaintIn3D.P3dHitBetween.PhaseType paintIn;        // 0x18
        private System.Single interval;        // 0x1C
        private UnityEngine.Transform pointA;        // 0x20
        private UnityEngine.Transform pointB;        // 0x28
        private System.Single fraction;        // 0x30
        private UnityEngine.LayerMask layers;        // 0x34
        private PaintIn3D.P3dHitBetween.OrientationType orientation;        // 0x38
        private UnityEngine.Camera _camera;        // 0x40
        private UnityEngine.Transform customTransform;        // 0x48
        private PaintIn3D.P3dHitBetween.NormalType normal;        // 0x50
        private System.Single offset;        // 0x54
        private System.Boolean preview;        // 0x58
        private System.Int32 priority;        // 0x5C
        private System.Single pressure;        // 0x60
        private PaintIn3D.P3dHitBetween.EmitType emit;        // 0x64
        private UnityEngine.Transform point;        // 0x68
        private UnityEngine.LineRenderer line;        // 0x70
        private PaintIn3D.P3dPointConnector connector;        // 0x78
        private System.Single current;        // 0x80

        // Methods
        private System.Void set_PaintIn(PaintIn3D.P3dHitBetween.PhaseType value) { }
        private PaintIn3D.P3dHitBetween.PhaseType get_PaintIn() { }
        private System.Void set_Interval(System.Single value) { }
        private System.Single get_Interval() { }
        private System.Void set_PointA(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_PointA() { }
        private System.Void set_PointB(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_PointB() { }
        private System.Single get_Fraction() { }
        private System.Void set_Layers(UnityEngine.LayerMask value) { }
        private UnityEngine.LayerMask get_Layers() { }
        private System.Void set_Orientation(PaintIn3D.P3dHitBetween.OrientationType value) { }
        private PaintIn3D.P3dHitBetween.OrientationType get_Orientation() { }
        private System.Void set_Camera(UnityEngine.Camera value) { }
        private UnityEngine.Camera get_Camera() { }
        private System.Void set_CustomTransform(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_CustomTransform() { }
        private System.Void set_Normal(PaintIn3D.P3dHitBetween.NormalType value) { }
        private PaintIn3D.P3dHitBetween.NormalType get_Normal() { }
        private System.Void set_Offset(System.Single value) { }
        private System.Single get_Offset() { }
        private System.Void set_Preview(System.Boolean value) { }
        private System.Boolean get_Preview() { }
        private System.Void set_Priority(System.Int32 value) { }
        private System.Int32 get_Priority() { }
        private System.Void set_Pressure(System.Single value) { }
        private System.Single get_Pressure() { }
        private System.Void set_Draw(PaintIn3D.P3dHitBetween.EmitType value) { }
        private PaintIn3D.P3dHitBetween.EmitType get_Draw() { }
        private System.Void set_Point(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_Point() { }
        private System.Void set_Line(UnityEngine.LineRenderer value) { }
        private UnityEngine.LineRenderer get_Line() { }
        private PaintIn3D.P3dPointConnector get_Connector() { }
        private System.Void ManuallyHitNow() { }
        private System.Void ClearHitCache() { }
        private System.Void ResetConnections() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Update() { }
        private System.Void LateUpdate() { }
        private System.Void FixedUpdate() { }
        private System.Void SubmitHit(System.Boolean preview) { }
        private System.Void CalcHitData(UnityEngine.Vector3 hitPoint, UnityEngine.Vector3 hitNormal, UnityEngine.Ray ray, UnityEngine.Vector3& finalPosition, UnityEngine.Quaternion& finalRotation) { }
        private System.Void UpdatePointAndLine() { }
        private System.Void UpdateHit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200001F
    public class P3dHitCache
    {
        // Fields
        private System.Boolean cached;        // 0x10
        private System.Collections.Generic.List<PaintIn3D.IHitPoint> hitPoints;        // 0x18
        private System.Collections.Generic.List<PaintIn3D.IHitLine> hitLines;        // 0x20
        private System.Collections.Generic.List<PaintIn3D.IHitTriangle> hitTriangles;        // 0x28
        private System.Collections.Generic.List<PaintIn3D.IHitQuad> hitQuads;        // 0x30
        private System.Collections.Generic.List<PaintIn3D.IHitCoord> hitCoords;        // 0x38
        private static System.Collections.Generic.List<PaintIn3D.IHit> hits;        // 0x0

        // Methods
        private System.Boolean get_Cached() { }
        private System.Void InvokePoint(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void InvokeLine(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Quaternion rotation, System.Boolean clip) { }
        private System.Void InvokeTriangle(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, UnityEngine.RaycastHit hit, UnityEngine.Quaternion rotation) { }
        private System.Void InvokeTriangle(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC, UnityEngine.Quaternion rotation) { }
        private System.Void InvokeQuad(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2, UnityEngine.Quaternion rotation, System.Boolean clip) { }
        private System.Void InvokeCoord(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation) { }
        private System.Void Clear() { }
        private System.Void Cache(UnityEngine.GameObject gameObject) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000020
    public class P3dHitCollisions : MonoBehaviour
    {
        // Fields
        private PaintIn3D.P3dHitCollisions.EmitType emit;        // 0x18
        private System.Single raycastDistance;        // 0x1C
        private UnityEngine.LayerMask layers;        // 0x20
        private System.Boolean onlyUseFirstContact;        // 0x24
        private System.Single delay;        // 0x28
        private PaintIn3D.P3dHitCollisions.OrientationType orientation;        // 0x2C
        private UnityEngine.Camera _camera;        // 0x30
        private System.Boolean preview;        // 0x38
        private System.Single threshold;        // 0x3C
        private PaintIn3D.P3dHitCollisions.PressureType pressureMode;        // 0x40
        private System.Single pressureMin;        // 0x44
        private System.Single pressureMax;        // 0x48
        private System.Single pressureConstant;        // 0x4C
        private System.Single pressureMultiplier;        // 0x50
        private System.Single offset;        // 0x54
        private System.Int32 priority;        // 0x58
        private UnityEngine.GameObject root;        // 0x60
        private System.Single cooldown;        // 0x68
        private PaintIn3D.P3dHitCache hitCache;        // 0x70

        // Methods
        private System.Void set_Emit(PaintIn3D.P3dHitCollisions.EmitType value) { }
        private PaintIn3D.P3dHitCollisions.EmitType get_Emit() { }
        private System.Void set_RaycastDistance(System.Single value) { }
        private System.Single get_RaycastDistance() { }
        private System.Void set_Layers(UnityEngine.LayerMask value) { }
        private UnityEngine.LayerMask get_Layers() { }
        private System.Void set_OnlyUseFirstContact(System.Boolean value) { }
        private System.Boolean get_OnlyUseFirstContact() { }
        private System.Void set_Delay(System.Single value) { }
        private System.Single get_Delay() { }
        private System.Void set_Orientation(PaintIn3D.P3dHitCollisions.OrientationType value) { }
        private PaintIn3D.P3dHitCollisions.OrientationType get_Orientation() { }
        private System.Void set_Camera(UnityEngine.Camera value) { }
        private UnityEngine.Camera get_Camera() { }
        private System.Void set_Preview(System.Boolean value) { }
        private System.Boolean get_Preview() { }
        private System.Void set_Threshold(System.Single value) { }
        private System.Single get_Threshold() { }
        private System.Void set_PressureMode(PaintIn3D.P3dHitCollisions.PressureType value) { }
        private PaintIn3D.P3dHitCollisions.PressureType get_PressureMode() { }
        private System.Void set_PressureMin(System.Single value) { }
        private System.Single get_PressureMin() { }
        private System.Void set_PressureMax(System.Single value) { }
        private System.Single get_PressureMax() { }
        private System.Void set_PressureConstant(System.Single value) { }
        private System.Single get_PressureConstant() { }
        private System.Void set_PressureMultiplier(System.Single value) { }
        private System.Single get_PressureMultiplier() { }
        private System.Void set_Offset(System.Single value) { }
        private System.Single get_Offset() { }
        private System.Void set_Priority(System.Int32 value) { }
        private System.Int32 get_Priority() { }
        private System.Void set_Root(UnityEngine.GameObject value) { }
        private UnityEngine.GameObject get_Root() { }
        private PaintIn3D.P3dHitCache get_HitCache() { }
        private System.Void ClearHitCache() { }
        private System.Void OnCollisionEnter(UnityEngine.Collision collision) { }
        private System.Void OnCollisionStay(UnityEngine.Collision collision) { }
        private System.Void Update() { }
        private System.Boolean TryGetRaycastHit(UnityEngine.ContactPoint contact, UnityEngine.RaycastHit& hit) { }
        private System.Void CheckCollision(UnityEngine.Collision collision) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000024
    public class P3dHitNearby : MonoBehaviour
    {
        // Fields
        private PaintIn3D.P3dHitNearby.PhaseType paintIn;        // 0x18
        private System.Single interval;        // 0x1C
        private System.Boolean preview;        // 0x20
        private System.Int32 priority;        // 0x24
        private System.Single pressure;        // 0x28
        private PaintIn3D.P3dPointConnector connector;        // 0x30
        private System.Single current;        // 0x38
        private UnityEngine.Vector3 lastPosition;        // 0x3C

        // Methods
        private System.Void set_PaintIn(PaintIn3D.P3dHitNearby.PhaseType value) { }
        private PaintIn3D.P3dHitNearby.PhaseType get_PaintIn() { }
        private System.Void set_Interval(System.Single value) { }
        private System.Single get_Interval() { }
        private System.Void set_Preview(System.Boolean value) { }
        private System.Boolean get_Preview() { }
        private System.Void set_Priority(System.Int32 value) { }
        private System.Int32 get_Priority() { }
        private System.Void set_Pressure(System.Single value) { }
        private System.Single get_Pressure() { }
        private PaintIn3D.P3dPointConnector get_Connector() { }
        private System.Void ManuallyHitNow() { }
        private System.Void ClearHitCache() { }
        private System.Void ResetConnections() { }
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void FixedUpdate() { }
        private System.Void SubmitHit(System.Boolean preview) { }
        private System.Void UpdateHit() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000026
    public class P3dHitParticles : MonoBehaviour
    {
        // Fields
        private PaintIn3D.P3dHitParticles.EmitType emit;        // 0x18
        private System.Single raycastDistance;        // 0x1C
        private UnityEngine.LayerMask layers;        // 0x20
        private PaintIn3D.P3dHitParticles.OrientationType orientation;        // 0x24
        private UnityEngine.Camera _camera;        // 0x28
        private PaintIn3D.P3dHitParticles.NormalType normal;        // 0x30
        private System.Single offset;        // 0x34
        private System.Int32 skip;        // 0x38
        private System.Boolean preview;        // 0x3C
        private System.Int32 priority;        // 0x40
        private PaintIn3D.P3dHitParticles.PressureType pressureMode;        // 0x44
        private System.Single pressureMin;        // 0x48
        private System.Single pressureMax;        // 0x4C
        private System.Single pressureConstant;        // 0x50
        private System.Single pressureMultiplier;        // 0x54
        private UnityEngine.GameObject root;        // 0x58
        private UnityEngine.ParticleSystem cachedParticleSystem;        // 0x60
        private System.Boolean cachedParticleSystemSet;        // 0x68
        private static System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> particleCollisionEvents;        // 0x0
        private PaintIn3D.P3dHitCache hitCache;        // 0x70
        private System.Int32 skipCounter;        // 0x78

        // Methods
        private System.Void set_Emit(PaintIn3D.P3dHitParticles.EmitType value) { }
        private PaintIn3D.P3dHitParticles.EmitType get_Emit() { }
        private System.Void set_RaycastDistance(System.Single value) { }
        private System.Single get_RaycastDistance() { }
        private System.Void set_Layers(UnityEngine.LayerMask value) { }
        private UnityEngine.LayerMask get_Layers() { }
        private System.Void set_Orientation(PaintIn3D.P3dHitParticles.OrientationType value) { }
        private PaintIn3D.P3dHitParticles.OrientationType get_Orientation() { }
        private System.Void set_Camera(UnityEngine.Camera value) { }
        private UnityEngine.Camera get_Camera() { }
        private System.Void set_Normal(PaintIn3D.P3dHitParticles.NormalType value) { }
        private PaintIn3D.P3dHitParticles.NormalType get_Normal() { }
        private System.Void set_Offset(System.Single value) { }
        private System.Single get_Offset() { }
        private System.Void set_Skip(System.Int32 value) { }
        private System.Int32 get_Skip() { }
        private System.Void set_Preview(System.Boolean value) { }
        private System.Boolean get_Preview() { }
        private System.Void set_Priority(System.Int32 value) { }
        private System.Int32 get_Priority() { }
        private System.Void set_PressureMode(PaintIn3D.P3dHitParticles.PressureType value) { }
        private PaintIn3D.P3dHitParticles.PressureType get_PressureMode() { }
        private System.Void set_PressureMin(System.Single value) { }
        private System.Single get_PressureMin() { }
        private System.Void set_PressureMax(System.Single value) { }
        private System.Single get_PressureMax() { }
        private System.Void set_PressureConstant(System.Single value) { }
        private System.Single get_PressureConstant() { }
        private System.Void set_PressureMultiplier(System.Single value) { }
        private System.Single get_PressureMultiplier() { }
        private System.Void set_Root(UnityEngine.GameObject value) { }
        private UnityEngine.GameObject get_Root() { }
        private PaintIn3D.P3dHitCache get_HitCache() { }
        private System.Void ClearHitCache() { }
        private System.Boolean TryGetRaycastHit(UnityEngine.ParticleCollisionEvent collision, UnityEngine.RaycastHit& hit) { }
        private System.Void OnParticleCollision(UnityEngine.GameObject hitGameObject) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200002B
    public class P3dHitScreen : P3dHitScreenBase
    {
        // Fields
        private PaintIn3D.P3dHitScreen.FrequencyType frequency;        // 0x70
        private System.Single interval;        // 0x74
        private PaintIn3D.P3dPointConnector connector;        // 0x78
        private System.Collections.Generic.List<PaintIn3D.P3dHitScreen.Link> links;        // 0x80

        // Methods
        private System.Void set_Frequency(PaintIn3D.P3dHitScreen.FrequencyType value) { }
        private PaintIn3D.P3dHitScreen.FrequencyType get_Frequency() { }
        private System.Void set_Interval(System.Single value) { }
        private System.Single get_Interval() { }
        private PaintIn3D.P3dPointConnector get_Connector() { }
        private System.Void ClearHitCache() { }
        private System.Void ResetConnections() { }
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void HandleFingerUpdate(CW.Common.CwInputManager.Finger finger, System.Boolean down, System.Boolean up) { }
        private System.Void HandleFingerUp(CW.Common.CwInputManager.Finger finger) { }
        private System.Void PaintSmooth(PaintIn3D.P3dHitScreen.Link link, System.Boolean down, System.Single pixelSpacing) { }
        private System.Void OnFingerUp(PaintIn3D.P3dHitScreen.Link link) { }
        private System.Void PaintInterval(PaintIn3D.P3dHitScreen.Link link, System.Boolean down) { }
        private System.Void PaintRelease(PaintIn3D.P3dHitScreen.Link link, System.Boolean up) { }
        private System.Void PaintPress(PaintIn3D.P3dHitScreen.Link link, System.Boolean down) { }
        private System.Void PaintEvery(PaintIn3D.P3dHitScreen.Link link, System.Boolean down) { }
        private System.Void RecordAndPaintAt(PaintIn3D.P3dHitScreen.Link link, UnityEngine.Vector2 screenNew, UnityEngine.Vector2 screenOld, System.Boolean preview, System.Single pressure, System.Object owner) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200002E
    public class P3dHitScreenBase : MonoBehaviour
    {
        // Fields
        private UnityEngine.Camera _camera;        // 0x18
        private UnityEngine.LayerMask layers;        // 0x20
        private PaintIn3D.P3dHitScreenBase.ButtonTypes requiredButtons;        // 0x24
        private UnityEngine.KeyCode requiredKey;        // 0x28
        private UnityEngine.LayerMask guiLayers;        // 0x2C
        private PaintIn3D.P3dHitScreenBase.EmitType emit;        // 0x30
        private PaintIn3D.P3dHitScreenBase.RotationType rotateTo;        // 0x34
        private PaintIn3D.P3dHitScreenBase.DirectionType normalDirection;        // 0x38
        private PaintIn3D.P3dHitScreenBase.RelativeType normalRelativeTo;        // 0x3C
        private UnityEngine.Transform customTransform;        // 0x40
        private System.Single normalOffset;        // 0x48
        private System.Single mouseOffset;        // 0x4C
        private System.Single touchOffset;        // 0x50
        protected System.Boolean storeStates;        // 0x54
        protected System.Boolean showPreview;        // 0x55
        private System.Int32 priority;        // 0x58
        protected System.Collections.Generic.List<CW.Common.CwInputManager.Finger> fingers;        // 0x60
        protected System.Boolean keyPressed;        // 0x68

        // Methods
        private System.Void set_Camera(UnityEngine.Camera value) { }
        private UnityEngine.Camera get_Camera() { }
        private System.Void set_Layers(UnityEngine.LayerMask value) { }
        private UnityEngine.LayerMask get_Layers() { }
        private System.Void set_RequiredButtons(PaintIn3D.P3dHitScreenBase.ButtonTypes value) { }
        private PaintIn3D.P3dHitScreenBase.ButtonTypes get_RequiredButtons() { }
        private System.Void set_RequiredKey(UnityEngine.KeyCode value) { }
        private UnityEngine.KeyCode get_RequiredKey() { }
        private System.Void set_GuiLayers(UnityEngine.LayerMask value) { }
        private UnityEngine.LayerMask get_GuiLayers() { }
        private System.Void set_Emit(PaintIn3D.P3dHitScreenBase.EmitType value) { }
        private PaintIn3D.P3dHitScreenBase.EmitType get_Emit() { }
        private System.Void set_RotateTo(PaintIn3D.P3dHitScreenBase.RotationType value) { }
        private PaintIn3D.P3dHitScreenBase.RotationType get_RotateTo() { }
        private System.Void set_NormalDirection(PaintIn3D.P3dHitScreenBase.DirectionType value) { }
        private PaintIn3D.P3dHitScreenBase.DirectionType get_NormalDirection() { }
        private System.Void set_NormalRelativeTo(PaintIn3D.P3dHitScreenBase.RelativeType value) { }
        private PaintIn3D.P3dHitScreenBase.RelativeType get_NormalRelativeTo() { }
        private System.Void set_CustomTransform(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_CustomTransform() { }
        private System.Void set_NormalOffset(System.Single value) { }
        private System.Single get_NormalOffset() { }
        private System.Void set_MouseOffset(System.Single value) { }
        private System.Single get_MouseOffset() { }
        private System.Void set_TouchOffset(System.Single value) { }
        private System.Single get_TouchOffset() { }
        private System.Void set_StoreStates(System.Boolean value) { }
        private System.Boolean get_StoreStates() { }
        private System.Void set_ShowPreview(System.Boolean value) { }
        private System.Boolean get_ShowPreview() { }
        private System.Void set_Priority(System.Int32 value) { }
        private System.Int32 get_Priority() { }
        private System.Boolean get_NeedsDrawAngle() { }
        private System.Void OnEnable() { }
        private System.Void LateUpdate() { }
        private System.Void HandleFingerUpdate(CW.Common.CwInputManager.Finger finger, System.Boolean down, System.Boolean up) { }
        private System.Void HandleFingerUp(CW.Common.CwInputManager.Finger finger) { }
        private System.Void OnDisable() { }
        private System.Boolean FingerWentDown(CW.Common.CwInputManager.Finger finger) { }
        private System.Void HandleFingerDown(CW.Common.CwInputManager.Finger finger) { }
        private System.Void DoQuery(UnityEngine.Vector2 screenPosition, UnityEngine.Camera& camera, UnityEngine.Ray& ray, UnityEngine.RaycastHit& hit3D, UnityEngine.RaycastHit2D& hit2D) { }
        private System.Void PaintAt(PaintIn3D.P3dPointConnector connector, PaintIn3D.P3dHitCache hitCache, UnityEngine.Vector2 screenPosition, UnityEngine.Vector2 screenPositionOld, System.Boolean preview, System.Single pressure, System.Object owner) { }
        private System.Void CalcHitData(UnityEngine.Vector3 hitPoint, UnityEngine.Vector3 hitNormal, UnityEngine.Ray ray, UnityEngine.Camera camera, UnityEngine.Vector2 screenPositionOld, UnityEngine.Vector3& finalPosition, UnityEngine.Quaternion& finalRotation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000034
    public class P3dHitScreenFill : P3dHitScreen
    {
        // Fields
        private System.Single fillSpacing;        // 0x88

        // Methods
        private System.Void set_FillSpacing(System.Single value) { }
        private System.Single get_FillSpacing() { }
        private System.Void OnFingerUp(PaintIn3D.P3dHitScreen.Link link) { }
        private UnityEngine.Rect GetArea(System.Collections.Generic.List<UnityEngine.Vector2> points) { }
        private System.Double LineSide(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 p) { }
        private System.Boolean Contains(System.Collections.Generic.List<UnityEngine.Vector2> points, UnityEngine.Vector2 xy) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000035
    public class P3dHitScreenLine : P3dHitScreenBase
    {
        // Fields
        private PaintIn3D.P3dHitScreenLine.FrequencyType frequency;        // 0x70
        private System.Single interval;        // 0x74
        private System.Single position;        // 0x78
        private System.Single pixelOffset;        // 0x7C
        private PaintIn3D.P3dPointConnector connector;        // 0x80

        // Methods
        private System.Void set_Frequency(PaintIn3D.P3dHitScreenLine.FrequencyType value) { }
        private PaintIn3D.P3dHitScreenLine.FrequencyType get_Frequency() { }
        private System.Void set_Interval(System.Single value) { }
        private System.Single get_Interval() { }
        private System.Void set_Position(System.Single value) { }
        private System.Single get_Position() { }
        private System.Void set_PixelOffset(System.Single value) { }
        private System.Single get_PixelOffset() { }
        private PaintIn3D.P3dPointConnector get_Connector() { }
        private System.Void ClearHitCache() { }
        private System.Void ResetConnections() { }
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void HandleFingerUpdate(CW.Common.CwInputManager.Finger finger, System.Boolean down, System.Boolean up) { }
        private System.Void PaintStartEnd(CW.Common.CwInputManager.Finger finger, System.Boolean up) { }
        private System.Void PaintStartInterval(CW.Common.CwInputManager.Finger finger, System.Boolean up, System.Single pixelSpacing, System.Boolean stretch) { }
        private System.Void PaintOne(CW.Common.CwInputManager.Finger finger, System.Boolean up, System.Single frac, System.Single pixelOff) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000037
    public class P3dHitThrough : MonoBehaviour
    {
        // Fields
        private PaintIn3D.P3dHitThrough.PhaseType paintIn;        // 0x18
        private System.Single interval;        // 0x1C
        private UnityEngine.Transform pointA;        // 0x20
        private UnityEngine.Transform pointB;        // 0x28
        private PaintIn3D.P3dHitThrough.OrientationType orientation;        // 0x30
        private UnityEngine.Camera _camera;        // 0x38
        private System.Single pressure;        // 0x40
        private System.Boolean preview;        // 0x44
        private System.Int32 priority;        // 0x48
        private UnityEngine.LineRenderer line;        // 0x50
        private PaintIn3D.P3dLineConnector connector;        // 0x58
        private System.Single current;        // 0x60

        // Methods
        private System.Void set_PaintIn(PaintIn3D.P3dHitThrough.PhaseType value) { }
        private PaintIn3D.P3dHitThrough.PhaseType get_PaintIn() { }
        private System.Void set_Interval(System.Single value) { }
        private System.Single get_Interval() { }
        private System.Void set_PointA(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_PointA() { }
        private System.Void set_PointB(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_PointB() { }
        private System.Void set_Orientation(PaintIn3D.P3dHitThrough.OrientationType value) { }
        private PaintIn3D.P3dHitThrough.OrientationType get_Orientation() { }
        private System.Void set_Camera(UnityEngine.Camera value) { }
        private UnityEngine.Camera get_Camera() { }
        private System.Void set_Pressure(System.Single value) { }
        private System.Single get_Pressure() { }
        private System.Void set_Preview(System.Boolean value) { }
        private System.Boolean get_Preview() { }
        private System.Void set_Priority(System.Int32 value) { }
        private System.Int32 get_Priority() { }
        private System.Void set_Line(UnityEngine.LineRenderer value) { }
        private UnityEngine.LineRenderer get_Line() { }
        private PaintIn3D.P3dLineConnector get_Connector() { }
        private System.Void ManuallyHitNow() { }
        private System.Void ClearHitCache() { }
        private System.Void ResetConnections() { }
        private System.Void OnEnable() { }
        private System.Void Update() { }
        private System.Void LateUpdate() { }
        private System.Void FixedUpdate() { }
        private System.Void SubmitHit(System.Boolean preview) { }
        private System.Void UpdateHit() { }
        private System.Void UpdatePointAndLine() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200003A
    public interface IClone
    {
        // Methods
        private System.Void Transform(UnityEngine.Matrix4x4& posMatrix, UnityEngine.Matrix4x4& rotMatrix) { }

    }

    // TypeToken: 0x200003B
    public interface IHit
    {
    }

    // TypeToken: 0x200003C
    public interface IHitCoord : IHit
    {
        // Methods
        private System.Void HandleHitCoord(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation) { }

    }

    // TypeToken: 0x200003D
    public interface IHitLine : IHit
    {
        // Methods
        private System.Void HandleHitLine(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Quaternion rotation, System.Boolean clip) { }

    }

    // TypeToken: 0x200003E
    public interface IHitPoint : IHit
    {
        // Methods
        private System.Void HandleHitPoint(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }

    }

    // TypeToken: 0x200003F
    public interface IHitQuad : IHit
    {
        // Methods
        private System.Void HandleHitQuad(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2, UnityEngine.Quaternion rotation, System.Boolean clip) { }

    }

    // TypeToken: 0x2000040
    public interface IHitTriangle : IHit
    {
        // Methods
        private System.Void HandleHitTriangle(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC, UnityEngine.Quaternion rotation) { }

    }

    // TypeToken: 0x2000041
    public interface IBrowsable
    {
        // Methods
        private System.String GetCategory() { }
        private System.String GetTitle() { }
        private UnityEngine.Texture2D GetIcon() { }
        private UnityEngine.Object GetObject() { }

    }

    // TypeToken: 0x2000042
    public class P3dHitScreen_InEditor : P3dHitScreen
    {
        // Methods
        private System.Void DoQuery(UnityEngine.Vector2 screenPosition, UnityEngine.Camera& camera, UnityEngine.Ray& ray, UnityEngine.RaycastHit& hit3D, UnityEngine.RaycastHit2D& hit2D) { }
        private System.Void LateUpdate() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000043
    public class P3dMaterial : MonoBehaviour, IBrowsable
    {
        // Fields
        private System.String category;        // 0x18
        private UnityEngine.Texture2D icon;        // 0x20
        private System.Collections.Generic.List<UnityEngine.Texture> textures;        // 0x28
        private static System.Collections.Generic.List<PaintIn3D.P3dMaterial> cachedMaterials;        // 0x0

        // Methods
        private System.Void set_Category(System.String value) { }
        private System.String get_Category() { }
        private System.Void set_Icon(UnityEngine.Texture2D value) { }
        private UnityEngine.Texture2D get_Icon() { }
        private System.Collections.Generic.List<UnityEngine.Texture> get_Textures() { }
        private System.Collections.Generic.List<PaintIn3D.P3dMaterial> get_CachedMaterials() { }
        private System.Void ClearCache() { }
        private System.String GetCategory() { }
        private System.String GetTitle() { }
        private UnityEngine.Texture2D GetIcon() { }
        private UnityEngine.Object GetObject() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000044
    public class P3dPreset : MonoBehaviour
    {
        // Fields
        private System.String title;        // 0x18
        private System.Boolean addMaterialCloner;        // 0x20
        private static System.Collections.Generic.List<PaintIn3D.P3dPreset> cachedPresets;        // 0x0

        // Methods
        private System.Void set_Title(System.String value) { }
        private System.String get_Title() { }
        private System.Void set_AddMaterialCloner(System.Boolean value) { }
        private System.Boolean get_AddMaterialCloner() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000045
    public class P3dSeamFixer : ScriptableObject
    {
        // Fields
        private UnityEngine.Mesh source;        // 0x18
        private UnityEngine.Mesh mesh;        // 0x20
        private System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Pair> meshes;        // 0x28
        private PaintIn3D.P3dCoord coord;        // 0x30
        private System.Single threshold;        // 0x34
        private System.Single border;        // 0x38
        private static System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> cacheFirst;        // 0x0
        private static System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> cacheSecond;        // 0x8
        private static System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> cacheThird;        // 0x10
        private static System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> cacheFourth;        // 0x18

        // Methods
        private System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Pair> get_Meshes() { }
        private System.Void set_Coord(PaintIn3D.P3dCoord value) { }
        private PaintIn3D.P3dCoord get_Coord() { }
        private System.Void set_Threshold(System.Single value) { }
        private System.Single get_Threshold() { }
        private System.Void set_Border(System.Single value) { }
        private System.Single get_Border() { }
        private UnityEngine.Mesh GetCachedMesh(UnityEngine.Mesh source, PaintIn3D.P3dCoord coord, System.Boolean allowGeneration) { }
        private UnityEngine.Mesh TryGetCachedMesh(System.Collections.Generic.Dictionary<UnityEngine.Mesh,UnityEngine.Mesh> cache, UnityEngine.Mesh source, PaintIn3D.P3dCoord coord, System.Boolean allowGeneration) { }
        private System.Void AddMesh(UnityEngine.Mesh mesh) { }
        private System.Void ConvertLegacy() { }
        private System.Void Generate() { }
        private System.Void Generate(UnityEngine.Mesh source, UnityEngine.Mesh output, PaintIn3D.P3dCoord coord, System.Single threshold, System.Single border) { }
        private System.Void AddCoord(System.Collections.Generic.List<UnityEngine.Vector4> coords, PaintIn3D.P3dSeamFixer.Insertion insertion, System.Boolean write) { }
        private System.Void FixSeams(UnityEngine.Mesh source, UnityEngine.Mesh output, System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> submeshes, System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Ring> rings, System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Insertion> insertions, PaintIn3D.P3dCoord coord) { }
        private System.Void TraceEdges(PaintIn3D.P3dSeamFixer.Ring ring, PaintIn3D.P3dSeamFixer.Point point) { }
        private System.Void AddPoint(System.Collections.Generic.Dictionary<UnityEngine.Vector2,PaintIn3D.P3dSeamFixer.Point> points, UnityEngine.Vector2 coord, System.Int32 index) { }
        private System.Void AddTriangle(System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Edge> edges, PaintIn3D.P3dSeamFixer.Point pointA, PaintIn3D.P3dSeamFixer.Point pointB, PaintIn3D.P3dSeamFixer.Point pointC) { }
        private System.Void AddTriangle2(System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Edge> edges, PaintIn3D.P3dSeamFixer.Point pointA, PaintIn3D.P3dSeamFixer.Point pointB, PaintIn3D.P3dSeamFixer.Point pointC, System.Boolean flip) { }
        private System.Void RemoveOrAddEdge(System.Collections.Generic.List<PaintIn3D.P3dSeamFixer.Edge> edges, PaintIn3D.P3dSeamFixer.Point pointA, PaintIn3D.P3dSeamFixer.Point pointB, System.Boolean flip) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004B
    public class P3dShape : MonoBehaviour, IBrowsable
    {
        // Fields
        private System.String category;        // 0x18
        private UnityEngine.Texture2D icon;        // 0x20
        private static System.Collections.Generic.List<PaintIn3D.P3dShape> cachedShapes;        // 0x0

        // Methods
        private System.Void set_Category(System.String value) { }
        private System.String get_Category() { }
        private System.Void set_Icon(UnityEngine.Texture2D value) { }
        private UnityEngine.Texture2D get_Icon() { }
        private System.Collections.Generic.List<PaintIn3D.P3dShape> get_CachedShapes() { }
        private System.Void ClearCache() { }
        private System.String GetCategory() { }
        private System.String GetTitle() { }
        private UnityEngine.Texture2D GetIcon() { }
        private UnityEngine.Object GetObject() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004C
    public class P3dTool : MonoBehaviour, IBrowsable
    {
        // Fields
        private System.String category;        // 0x18
        private UnityEngine.Texture2D icon;        // 0x20
        private static System.Collections.Generic.List<PaintIn3D.P3dTool> cachedTools;        // 0x0

        // Methods
        private System.Void set_Category(System.String value) { }
        private System.String get_Category() { }
        private System.Void set_Icon(UnityEngine.Texture2D value) { }
        private UnityEngine.Texture2D get_Icon() { }
        private System.Collections.Generic.List<PaintIn3D.P3dTool> get_CachedTools() { }
        private System.Void ClearCache() { }
        private System.String GetCategory() { }
        private System.String GetTitle() { }
        private UnityEngine.Texture2D GetIcon() { }
        private UnityEngine.Object GetObject() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200004D
    public class P3dModifyAngleRandom : P3dModifier
    {
        // Fields
        public static System.String Group;        // 0x0
        public static System.String Title;        // 0x8
        private System.Single min;        // 0x18
        private System.Single max;        // 0x1C
        private PaintIn3D.P3dModifyAngleRandom.BlendType blend;        // 0x20

        // Methods
        private System.Void set_Min(System.Single value) { }
        private System.Single get_Min() { }
        private System.Void set_Max(System.Single value) { }
        private System.Single get_Max() { }
        private System.Void set_Blend(PaintIn3D.P3dModifyAngleRandom.BlendType value) { }
        private PaintIn3D.P3dModifyAngleRandom.BlendType get_Blend() { }
        private System.Void OnModifyAngle(System.Single& angle, System.Single pressure) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200004F
    public class P3dModifyColorRandom : P3dModifier
    {
        // Fields
        public static System.String Group;        // 0x0
        public static System.String Title;        // 0x8
        private UnityEngine.Gradient gradient;        // 0x18
        private PaintIn3D.P3dModifyColorRandom.BlendType blend;        // 0x20

        // Methods
        private UnityEngine.Gradient get_Gradient() { }
        private System.Void set_Blend(PaintIn3D.P3dModifyColorRandom.BlendType value) { }
        private PaintIn3D.P3dModifyColorRandom.BlendType get_Blend() { }
        private System.Void OnModifyColor(UnityEngine.Color& color, System.Single pressure) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000051
    public class P3dModifyHardnessPressure : P3dModifier
    {
        // Fields
        public static System.String Group;        // 0x0
        public static System.String Title;        // 0x8
        private System.Single hardness;        // 0x18
        private PaintIn3D.P3dModifyHardnessPressure.BlendType blend;        // 0x1C

        // Methods
        private System.Void set_Hardness(System.Single value) { }
        private System.Single get_Hardness() { }
        private System.Void set_Blend(PaintIn3D.P3dModifyHardnessPressure.BlendType value) { }
        private PaintIn3D.P3dModifyHardnessPressure.BlendType get_Blend() { }
        private System.Void OnModifyHardness(System.Single& currentHardness, System.Single pressure) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000053
    public class P3dModifyHardnessRandom : P3dModifier
    {
        // Fields
        public static System.String Group;        // 0x0
        public static System.String Title;        // 0x8
        private System.Single min;        // 0x18
        private System.Single max;        // 0x1C
        private PaintIn3D.P3dModifyHardnessRandom.BlendType blend;        // 0x20

        // Methods
        private System.Void set_Min(System.Single value) { }
        private System.Single get_Min() { }
        private System.Void set_Max(System.Single value) { }
        private System.Single get_Max() { }
        private System.Void set_Blend(PaintIn3D.P3dModifyHardnessRandom.BlendType value) { }
        private PaintIn3D.P3dModifyHardnessRandom.BlendType get_Blend() { }
        private System.Void OnModifyHardness(System.Single& hardness, System.Single pressure) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000055
    public class P3dModifyOpacityPressure : P3dModifier
    {
        // Fields
        public static System.String Group;        // 0x0
        public static System.String Title;        // 0x8
        private System.Single opacity;        // 0x18
        private PaintIn3D.P3dModifyOpacityPressure.BlendType blend;        // 0x1C

        // Methods
        private System.Void set_Opacity(System.Single value) { }
        private System.Single get_Opacity() { }
        private System.Void set_Blend(PaintIn3D.P3dModifyOpacityPressure.BlendType value) { }
        private PaintIn3D.P3dModifyOpacityPressure.BlendType get_Blend() { }
        private System.Void OnModifyOpacity(System.Single& currentOpacity, System.Single pressure) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000057
    public class P3dModifyOpacityRandom : P3dModifier
    {
        // Fields
        public static System.String Group;        // 0x0
        public static System.String Title;        // 0x8
        private System.Single min;        // 0x18
        private System.Single max;        // 0x1C
        private PaintIn3D.P3dModifyOpacityRandom.BlendType blend;        // 0x20

        // Methods
        private System.Void set_Min(System.Single value) { }
        private System.Single get_Min() { }
        private System.Void set_Max(System.Single value) { }
        private System.Single get_Max() { }
        private System.Void set_Blend(PaintIn3D.P3dModifyOpacityRandom.BlendType value) { }
        private PaintIn3D.P3dModifyOpacityRandom.BlendType get_Blend() { }
        private System.Void OnModifyOpacity(System.Single& opacity, System.Single pressure) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000059
    public class P3dModifyPositionRandom : P3dModifier
    {
        // Fields
        public static System.String Group;        // 0x0
        public static System.String Title;        // 0x8
        private System.Single radius;        // 0x18

        // Methods
        private System.Void set_Radius(System.Single value) { }
        private System.Single get_Radius() { }
        private System.Void OnModifyPosition(UnityEngine.Vector3& position, System.Single pressure) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005A
    public class P3dModifyRadiusPressure : P3dModifier
    {
        // Fields
        public static System.String Group;        // 0x0
        public static System.String Title;        // 0x8
        private System.Single radius;        // 0x18
        private PaintIn3D.P3dModifyRadiusPressure.BlendType blend;        // 0x1C

        // Methods
        private System.Void set_Radius(System.Single value) { }
        private System.Single get_Radius() { }
        private System.Void set_Blend(PaintIn3D.P3dModifyRadiusPressure.BlendType value) { }
        private PaintIn3D.P3dModifyRadiusPressure.BlendType get_Blend() { }
        private System.Void OnModifyRadius(System.Single& currentRadius, System.Single pressure) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005C
    public class P3dModifyRadiusRandom : P3dModifier
    {
        // Fields
        public static System.String Group;        // 0x0
        public static System.String Title;        // 0x8
        private System.Single min;        // 0x18
        private System.Single max;        // 0x1C
        private PaintIn3D.P3dModifyRadiusRandom.BlendType blend;        // 0x20

        // Methods
        private System.Void set_Min(System.Single value) { }
        private System.Single get_Min() { }
        private System.Void set_Max(System.Single value) { }
        private System.Single get_Max() { }
        private System.Void set_Blend(PaintIn3D.P3dModifyRadiusRandom.BlendType value) { }
        private PaintIn3D.P3dModifyRadiusRandom.BlendType get_Blend() { }
        private System.Void OnModifyRadius(System.Single& radius, System.Single pressure) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200005E
    public class P3dModifyScaleRandom : P3dModifier
    {
        // Fields
        public static System.String Group;        // 0x0
        public static System.String Title;        // 0x8
        private UnityEngine.Vector3 min;        // 0x18
        private UnityEngine.Vector3 max;        // 0x24
        private PaintIn3D.P3dModifyScaleRandom.BlendType blend;        // 0x30
        private System.Boolean uniform;        // 0x34

        // Methods
        private System.Void set_Min(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_Min() { }
        private System.Void set_Max(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_Max() { }
        private System.Void set_Blend(PaintIn3D.P3dModifyScaleRandom.BlendType value) { }
        private PaintIn3D.P3dModifyScaleRandom.BlendType get_Blend() { }
        private System.Void set_Uniform(System.Boolean value) { }
        private System.Boolean get_Uniform() { }
        private System.Void OnModifyScale(UnityEngine.Vector3& scale, System.Single pressure) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000060
    public class P3dModifyTexturePressure : P3dModifier
    {
        // Fields
        public static System.String Group;        // 0x0
        public static System.String Title;        // 0x8
        private UnityEngine.Texture texture;        // 0x18
        private System.Single pressureMin;        // 0x20
        private System.Single pressureMax;        // 0x24

        // Methods
        private System.Void set_Texture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_Texture() { }
        private System.Void set_PressureMin(System.Single value) { }
        private System.Single get_PressureMin() { }
        private System.Void set_PressureMax(System.Single value) { }
        private System.Single get_PressureMax() { }
        private System.Void OnModifyTexture(UnityEngine.Texture& currentTexture, System.Single pressure) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000061
    public class P3dModifyTextureRandom : P3dModifier
    {
        // Fields
        public static System.String Group;        // 0x0
        public static System.String Title;        // 0x8
        private System.Collections.Generic.List<UnityEngine.Texture> textures;        // 0x18

        // Methods
        private System.Collections.Generic.List<UnityEngine.Texture> get_Textures() { }
        private System.Void OnModifyTexture(UnityEngine.Texture& texture, System.Single pressure) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000062
    public struct P3dBlendMode
    {
        // Fields
        public static System.Int32 ALPHA_BLEND;        // 0x0
        public static System.Int32 ALPHA_BLEND_INVERSE;        // 0x0
        public static System.Int32 PREMULTIPLIED;        // 0x0
        public static System.Int32 ADDITIVE;        // 0x0
        public static System.Int32 ADDITIVE_SOFT;        // 0x0
        public static System.Int32 SUBTRACTIVE;        // 0x0
        public static System.Int32 SUBTRACTIVE_SOFT;        // 0x0
        public static System.Int32 REPLACE;        // 0x0
        public static System.Int32 REPLACE_ORIGINAL;        // 0x0
        public static System.Int32 REPLACE_CUSTOM;        // 0x0
        public static System.Int32 MULTIPLY_INVERSE_RGB;        // 0x0
        public static System.Int32 BLUR;        // 0x0
        public static System.Int32 NORMAL_BLEND;        // 0x0
        public static System.Int32 NORMAL_REPLACE;        // 0x0
        public static System.Int32 FLOW;        // 0x0
        public static System.Int32 NORMAL_REPLACE_ORIGINAL;        // 0x0
        public static System.Int32 NORMAL_REPLACE_CUSTOM;        // 0x0
        public static System.Int32 COUNT;        // 0x0
        public static readonly System.String[] NAMES;        // 0x0
        public System.Int32 Index;        // 0x10
        public UnityEngine.Color Color;        // 0x14
        public UnityEngine.Texture Texture;        // 0x28
        public System.Single Kernel;        // 0x30
        public UnityEngine.Vector4 Channels;        // 0x34
        private static System.Int32 _Channels;        // 0x8
        private static System.Int32 _ReplaceColor;        // 0xC
        private static System.Int32 _ReplaceTexture;        // 0x10
        private static System.Int32 _ReplaceTextureSize;        // 0x14
        private static System.Int32 _Kernel;        // 0x18

        // Methods
        private PaintIn3D.P3dBlendMode AlphaBlend(UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode AlphaBlendInverse(UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode Premultiplied(UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode Additive(UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode AdditiveSoft(UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode Subtractive(UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode SubtractiveSoft(UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode Replace(UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode ReplaceOriginal(UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode ReplaceCustom(UnityEngine.Color color, UnityEngine.Texture texture, UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode MultiplyInverseRGB(UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode Blur(System.Single kernel, UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode NormalBlend(UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode NormalReplace(UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode Flow(System.Single kernel, UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode NormalReplaceOriginal(UnityEngine.Vector4 channels) { }
        private PaintIn3D.P3dBlendMode NormalReplaceCustom(UnityEngine.Color color, UnityEngine.Texture texture, UnityEngine.Vector4 channels) { }
        private System.Void Apply(UnityEngine.Material material) { }
        private System.String GetName(System.Int32 index) { }
        private System.Boolean op_Equality(PaintIn3D.P3dBlendMode a, System.Int32 b) { }
        private System.Boolean op_Inequality(PaintIn3D.P3dBlendMode a, System.Int32 b) { }
        private System.Int32 op_Implicit(PaintIn3D.P3dBlendMode a) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000063
    public class P3dBlit
    {
        // Fields
        private static UnityEngine.Material cachedWhite;        // 0x0
        private static System.Boolean cachedWhiteSet;        // 0x8
        private static UnityEngine.Material cachedTexture;        // 0x10
        private static System.Boolean cachedTextureSet;        // 0x18
        private static UnityEngine.Material cachedNormal;        // 0x20
        private static System.Boolean cachedNormalSet;        // 0x28
        private static UnityEngine.Material cachedPremultiply;        // 0x30
        private static System.Boolean cachedPremultiplySet;        // 0x38
        private static System.Int32 _Buffer;        // 0x3C
        private static System.Int32 _BufferSize;        // 0x40
        private static System.Int32 _Texture;        // 0x44
        private static System.Int32 _Color;        // 0x48

        // Methods
        private System.Void White(UnityEngine.RenderTexture rendertexture, UnityEngine.Mesh mesh, System.Int32 submesh, PaintIn3D.P3dCoord coord) { }
        private System.Void Texture(UnityEngine.RenderTexture rendertexture, UnityEngine.Mesh mesh, System.Int32 submesh, UnityEngine.Texture texture, PaintIn3D.P3dCoord coord) { }
        private System.Void Normal(UnityEngine.RenderTexture rendertexture, UnityEngine.Texture texture) { }
        private System.Void Premultiply(UnityEngine.RenderTexture rendertexture, UnityEngine.Texture texture, UnityEngine.Color tint) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000064
    public class P3dChangeCounter : P3dPaintableTextureMonitorMask
    {
        // Fields
        public static System.Collections.Generic.LinkedList<PaintIn3D.P3dChangeCounter> Instances;        // 0x0
        private System.Collections.Generic.LinkedListNode<PaintIn3D.P3dChangeCounter> instancesNode;        // 0x98
        private System.Single threshold;        // 0xA0
        private UnityEngine.Texture texture;        // 0xA8
        private UnityEngine.Color color;        // 0xB0
        private System.Int32 count;        // 0xC0
        private PaintIn3D.P3dReader changeReader;        // 0xC8
        protected Unity.Collections.NativeArray<UnityEngine.Color32> changePixels;        // 0xD0

        // Methods
        private System.Void set_Threshold(System.Single value) { }
        private System.Single get_Threshold() { }
        private System.Void set_Texture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_Texture() { }
        private System.Void set_Color(UnityEngine.Color value) { }
        private UnityEngine.Color get_Color() { }
        private System.Int32 get_Count() { }
        private System.Single get_Ratio() { }
        private PaintIn3D.P3dReader get_ChangeReader() { }
        private System.Void MarkChangeReaderAsDirty() { }
        private System.Int64 GetTotal(System.Collections.Generic.ICollection<PaintIn3D.P3dChangeCounter> counters) { }
        private System.Int64 GetCount(System.Collections.Generic.ICollection<PaintIn3D.P3dChangeCounter> counters) { }
        private System.Single GetRatio(System.Collections.Generic.ICollection<PaintIn3D.P3dChangeCounter> counters) { }
        private System.Void HandleCompleteChange(Unity.Collections.NativeArray<UnityEngine.Color32> pixels) { }
        private System.Void HandleComplete(System.Int32 boost) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void Update() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000065
    public struct P3dChannel
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dChannel Red;        // 0x0
        public static PaintIn3D.P3dChannel Green;        // 0x0
        public static PaintIn3D.P3dChannel Blue;        // 0x0
        public static PaintIn3D.P3dChannel Alpha;        // 0x0

    }

    // TypeToken: 0x2000066
    public class P3dChannelCounter : P3dPaintableTextureMonitorMask
    {
        // Fields
        public static System.Collections.Generic.LinkedList<PaintIn3D.P3dChannelCounter> Instances;        // 0x0
        private System.Collections.Generic.LinkedListNode<PaintIn3D.P3dChannelCounter> instancesNode;        // 0x98
        private System.Single threshold;        // 0xA0
        private System.Int32 countR;        // 0xA4
        private System.Int32 countG;        // 0xA8
        private System.Int32 countB;        // 0xAC
        private System.Int32 countA;        // 0xB0

        // Methods
        private System.Void set_Threshold(System.Single value) { }
        private System.Single get_Threshold() { }
        private System.Int32 get_CountR() { }
        private System.Int32 get_CountG() { }
        private System.Int32 get_CountB() { }
        private System.Int32 get_CountA() { }
        private System.Single get_RatioR() { }
        private System.Single get_RatioG() { }
        private System.Single get_RatioB() { }
        private System.Single get_RatioA() { }
        private UnityEngine.Vector4 get_RatioRGBA() { }
        private System.Int64 GetTotal(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters) { }
        private System.Int64 GetCountR(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters) { }
        private System.Int64 GetCountG(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters) { }
        private System.Int64 GetCountB(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters) { }
        private System.Int64 GetCountA(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters) { }
        private System.Single GetRatioR(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters) { }
        private System.Single GetRatioG(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters) { }
        private System.Single GetRatioB(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters) { }
        private System.Single GetRatioA(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters) { }
        private UnityEngine.Vector4 GetRatioRGBA(System.Collections.Generic.ICollection<PaintIn3D.P3dChannelCounter> counters) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void HandleComplete(System.Int32 boost) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000067
    public class P3dClone : MonoBehaviour, IClone
    {
        // Fields
        public static System.Int32 MatrixCount;        // 0x0
        public static System.Int32 ClonerCount;        // 0x4
        private static System.Collections.Generic.List<UnityEngine.Matrix4x4> tempPosMatrices;        // 0x8
        private static System.Collections.Generic.List<UnityEngine.Matrix4x4> tempRotMatrices;        // 0x10
        private static System.Collections.Generic.List<PaintIn3D.IClone> tempCloners;        // 0x18
        private static System.Collections.Generic.LinkedList<PaintIn3D.P3dClone> instances;        // 0x20
        private System.Collections.Generic.LinkedListNode<PaintIn3D.P3dClone> instancesNode;        // 0x18

        // Methods
        private System.Void Transform(UnityEngine.Matrix4x4& posMatrix, UnityEngine.Matrix4x4& rotMatrix) { }
        private System.Collections.Generic.LinkedList<PaintIn3D.P3dClone> get_Instances() { }
        private System.Void BuildCloners(System.Collections.Generic.List<PaintIn3D.IClone> cloners) { }
        private System.Void Clone(PaintIn3D.P3dCommand command, System.Int32 clonerIndex, System.Int32 matrixIndex) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000068
    public class P3dCloneMirror : P3dClone
    {
        // Fields
        private System.Boolean flip;        // 0x20

        // Methods
        private System.Void set_Flip(System.Boolean value) { }
        private System.Boolean get_Flip() { }
        private System.Void Transform(UnityEngine.Matrix4x4& posMatrix, UnityEngine.Matrix4x4& rotMatrix) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000069
    public class P3dColor : MonoBehaviour
    {
        // Fields
        private UnityEngine.Color color;        // 0x18
        private System.Collections.Generic.List<PaintIn3D.P3dColor.Contribution> contributions;        // 0x28
        private static System.Collections.Generic.LinkedList<PaintIn3D.P3dColor> instances;        // 0x0
        private System.Collections.Generic.LinkedListNode<PaintIn3D.P3dColor> instancesNode;        // 0x30

        // Methods
        private System.Void set_Color(UnityEngine.Color value) { }
        private UnityEngine.Color get_Color() { }
        private System.Collections.Generic.LinkedList<PaintIn3D.P3dColor> get_Instances() { }
        private System.Int32 get_Total() { }
        private System.Int32 get_Solid() { }
        private System.Single get_Ratio() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void Contribute(PaintIn3D.P3dColorCounter counter, System.Int32 solid) { }
        private System.Boolean TryGetContribution(PaintIn3D.P3dColorCounter counter, PaintIn3D.P3dColor.Contribution& contribution) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006B
    public class P3dColorCounter : P3dPaintableTextureMonitorMask
    {
        // Fields
        public static System.Collections.Generic.LinkedList<PaintIn3D.P3dColorCounter> Instances;        // 0x0
        private System.Collections.Generic.LinkedListNode<PaintIn3D.P3dColorCounter> instancesNode;        // 0x98
        private System.Single threshold;        // 0xA0
        private System.Collections.Generic.List<PaintIn3D.P3dColorCounter.Contribution> contributions;        // 0xA8

        // Methods
        private System.Void set_Threshold(System.Single value) { }
        private System.Single get_Threshold() { }
        private System.Collections.Generic.List<PaintIn3D.P3dColorCounter.Contribution> get_Contributions() { }
        private System.Int64 GetTotal(System.Collections.Generic.ICollection<PaintIn3D.P3dColorCounter> counters) { }
        private System.Int64 GetCount(PaintIn3D.P3dColor color, System.Collections.Generic.ICollection<PaintIn3D.P3dColorCounter> counters) { }
        private System.Single GetRatio(PaintIn3D.P3dColor color, System.Collections.Generic.ICollection<PaintIn3D.P3dColorCounter> counters) { }
        private System.Int32 Count(PaintIn3D.P3dColor color) { }
        private System.Single Ratio(PaintIn3D.P3dColor color) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void HandleComplete(System.Int32 boost) { }
        private System.Void ClearContributions() { }
        private System.Void PrepareContributions() { }
        private System.Void Contribute(System.Int32 scale) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006D
    public class P3dCommand
    {
        // Fields
        public System.Int32 Index;        // 0x10
        public System.Boolean Preview;        // 0x14
        public System.Int32 Priority;        // 0x18
        public PaintIn3D.P3dHashedMaterial Material;        // 0x20
        public System.Int32 Pass;        // 0x30
        public PaintIn3D.P3dHashedModel Model;        // 0x38
        public System.Int32 Submesh;        // 0x48
        public PaintIn3D.P3dHashedTexture LocalMaskTexture;        // 0x50
        public UnityEngine.Vector4 LocalMaskChannel;        // 0x60
        private static System.Int32 _LocalMaskTexture;        // 0x0
        private static System.Int32 _LocalMaskChannel;        // 0x4

        // Methods
        private System.Void BuildMaterial(UnityEngine.Material& material, System.Int32& materialHash, System.String path, System.String keyword) { }
        private System.Int32 Compare(PaintIn3D.P3dCommand a, PaintIn3D.P3dCommand b) { }
        private System.Boolean get_RequireMesh() { }
        private System.Void SetState(System.Boolean preview, System.Int32 priority) { }
        private System.Void Apply(UnityEngine.Material material) { }
        private System.Void Pool() { }
        private System.Void Transform(UnityEngine.Matrix4x4 posMatrix, UnityEngine.Matrix4x4 rotMatrix) { }
        private PaintIn3D.P3dCommand SpawnCopy() { }
        private PaintIn3D.P3dCommand SpawnCopyLocal(UnityEngine.Transform transform) { }
        private PaintIn3D.P3dCommand SpawnCopyWorld(UnityEngine.Transform transform) { }
        private T SpawnCopy(System.Collections.Generic.Stack<T> pool) { }
        private System.Void Apply(PaintIn3D.P3dPaintableTexture paintableTexture) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200006E
    public class P3dCommon
    {
        // Fields
        public static System.String HelpUrlPrefix;        // 0x0
        public static System.String ComponentMenuPrefix;        // 0x0
        public static System.String ComponentHitMenuPrefix;        // 0x0
        public static System.Action<UnityEngine.Camera> OnCameraDraw;        // 0x0
        private static System.Int32 _Coord;        // 0x8
        private static UnityEngine.Mesh sphereMesh;        // 0x10
        private static System.Boolean sphereMeshSet;        // 0x18
        private static UnityEngine.Mesh quadMesh;        // 0x20
        private static System.Boolean quadMeshSet;        // 0x28
        private static UnityEngine.Texture2D tempReadTexture;        // 0x30

        // Methods
        private System.Void .cctor() { }
        private System.Single RatioToPercentage(System.Single ratio01, System.Int32 decimalPlaces) { }
        private UnityEngine.RenderTexture GetRenderTexture(UnityEngine.RenderTexture other) { }
        private UnityEngine.RenderTexture GetRenderTexture(UnityEngine.RenderTextureDescriptor desc, UnityEngine.RenderTexture other) { }
        private UnityEngine.RenderTexture GetRenderTexture(UnityEngine.RenderTextureDescriptor desc) { }
        private UnityEngine.RenderTexture GetRenderTexture(UnityEngine.RenderTextureDescriptor desc, System.Boolean sRGB) { }
        private UnityEngine.RenderTexture ReleaseRenderTexture(UnityEngine.RenderTexture renderTexture) { }
        private UnityEngine.Quaternion NormalToCameraRotation(UnityEngine.Vector3 normal, UnityEngine.Camera optionalCamera) { }
        private UnityEngine.Vector3 GetCameraUp(UnityEngine.Camera camera) { }
        private System.Boolean CanReadPixels(UnityEngine.TextureFormat format) { }
        private System.Void ReadPixelsLinearGamma(UnityEngine.Texture2D texture2D, UnityEngine.RenderTexture renderTexture) { }
        private System.Void ReadPixels(UnityEngine.Texture2D texture2D, UnityEngine.RenderTexture renderTexture) { }
        private System.Boolean Downsample(UnityEngine.RenderTexture renderTexture, System.Int32 steps, UnityEngine.RenderTexture& temporary) { }
        private System.Boolean HasMipMaps(UnityEngine.Texture texture) { }
        private UnityEngine.Mesh GetSphereMesh() { }
        private UnityEngine.Mesh GetMesh(UnityEngine.GameObject root, UnityEngine.Mesh mesh) { }
        private UnityEngine.Mesh GetQuadMesh() { }
        private UnityEngine.Color GetPixel(UnityEngine.RenderTexture renderTexture, UnityEngine.Vector2 uv, System.Boolean mipMaps) { }
        private UnityEngine.Texture2D GetReadableCopy(UnityEngine.Texture texture, UnityEngine.TextureFormat format, System.Boolean mipMaps, System.Int32 width, System.Int32 height) { }
        private System.Void SaveBytes(System.String saveName, System.Byte[] data, System.Boolean save) { }
        private System.Byte[] LoadBytes(System.String saveName) { }
        private System.Boolean SaveExists(System.String saveName) { }
        private System.Void ClearSave(System.String saveName, System.Boolean save) { }
        private UnityEngine.Vector3 GetPosition(UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition) { }
        private UnityEngine.Vector3 GetPosition(UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC) { }
        private UnityEngine.Vector3 GetPosition(UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2) { }
        private System.Single GetRadius(UnityEngine.Vector3 size) { }
        private System.Single GetRadius(UnityEngine.Vector3 size, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition) { }
        private System.Single GetRadius(UnityEngine.Vector3 size, UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC) { }
        private System.Single GetRadius(UnityEngine.Vector3 size, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2) { }
        private UnityEngine.Vector3 ScaleAspect(UnityEngine.Vector3 size, System.Single aspect) { }
        private System.Single GetAspect(UnityEngine.Texture textureA, UnityEngine.Texture textureB) { }
        private System.Void Blit(UnityEngine.RenderTexture renderTexture, UnityEngine.Texture other) { }
        private System.Void Blit(UnityEngine.RenderTexture renderTexture, UnityEngine.Material material, System.Int32 pass) { }
        private UnityEngine.Vector4 IndexToVector(System.Int32 index) { }
        private System.Void Draw(UnityEngine.Material material, System.Int32 pass, UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, System.Int32 subMesh, PaintIn3D.P3dCoord coord) { }
        private System.Void Draw(UnityEngine.Material material, System.Int32 pass) { }
        private UnityEngine.Texture2D CreateTexture(System.Int32 width, System.Int32 height, UnityEngine.TextureFormat format, System.Boolean mipMaps) { }
        private UnityEngine.Material GetMaterial(UnityEngine.Renderer renderer, System.Int32 materialIndex) { }
        private UnityEngine.Material CloneMaterial(UnityEngine.GameObject gameObject, System.Int32 materialIndex) { }
        private UnityEngine.Material AddMaterial(UnityEngine.Renderer renderer, UnityEngine.Shader shader, System.Int32 materialIndex) { }
        private UnityEngine.Shader LoadShader(System.String shaderName) { }
        private UnityEngine.Material BuildMaterial(UnityEngine.Shader shader) { }
        private UnityEngine.Material BuildMaterial(System.String shaderName, System.String keyword) { }

    }

    // TypeToken: 0x2000070
    public struct P3dCoord
    {
        // Fields
        public System.Int32 value__;        // 0x10
        public static PaintIn3D.P3dCoord First;        // 0x0
        public static PaintIn3D.P3dCoord Second;        // 0x0
        public static PaintIn3D.P3dCoord Third;        // 0x0
        public static PaintIn3D.P3dCoord Fourth;        // 0x0

    }

    // TypeToken: 0x2000071
    public class P3dCoordCopier : ScriptableObject
    {
        // Fields
        private UnityEngine.Mesh source;        // 0x18
        private PaintIn3D.P3dCoordCopier.Coord first;        // 0x20
        private PaintIn3D.P3dCoordCopier.Coord second;        // 0x24
        private PaintIn3D.P3dCoordCopier.Coord third;        // 0x28
        private PaintIn3D.P3dCoordCopier.Coord fourth;        // 0x2C
        private UnityEngine.Mesh mesh;        // 0x30
        private static System.Collections.Generic.List<UnityEngine.BoneWeight> boneWeights;        // 0x0
        private static System.Collections.Generic.List<UnityEngine.Color32> colors;        // 0x8
        private static System.Collections.Generic.List<UnityEngine.Vector3> positions;        // 0x10
        private static System.Collections.Generic.List<UnityEngine.Vector3> normals;        // 0x18
        private static System.Collections.Generic.List<UnityEngine.Vector4> tangents;        // 0x20
        private static System.Collections.Generic.List<UnityEngine.Vector4> coords0;        // 0x28
        private static System.Collections.Generic.List<UnityEngine.Vector4> coords1;        // 0x30
        private static System.Collections.Generic.List<UnityEngine.Vector4> coords2;        // 0x38
        private static System.Collections.Generic.List<UnityEngine.Vector4> coords3;        // 0x40
        private static System.Collections.Generic.List<UnityEngine.Vector4> coordsNone;        // 0x48
        private static System.Collections.Generic.List<System.Int32> indices;        // 0x50

        // Methods
        private System.Void set_Source(UnityEngine.Mesh value) { }
        private UnityEngine.Mesh get_Source() { }
        private System.Void set_First(PaintIn3D.P3dCoordCopier.Coord value) { }
        private PaintIn3D.P3dCoordCopier.Coord get_First() { }
        private System.Void set_Second(PaintIn3D.P3dCoordCopier.Coord value) { }
        private PaintIn3D.P3dCoordCopier.Coord get_Second() { }
        private System.Void set_Third(PaintIn3D.P3dCoordCopier.Coord value) { }
        private PaintIn3D.P3dCoordCopier.Coord get_Third() { }
        private System.Void set_Fourth(PaintIn3D.P3dCoordCopier.Coord value) { }
        private PaintIn3D.P3dCoordCopier.Coord get_Fourth() { }
        private System.Collections.Generic.List<UnityEngine.Vector4> GetCoords(PaintIn3D.P3dCoordCopier.Coord coord) { }
        private System.Void Generate() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000073
    public class P3dGraduallyFade : MonoBehaviour
    {
        // Fields
        private PaintIn3D.P3dPaintableTexture paintableTexture;        // 0x18
        private System.Single threshold;        // 0x20
        private System.Single speed;        // 0x24
        private PaintIn3D.P3dBlendMode blendMode;        // 0x28
        private UnityEngine.Texture blendTexture;        // 0x60
        private PaintIn3D.P3dPaintableTexture blendPaintableTexture;        // 0x68
        private UnityEngine.Color blendColor;        // 0x70
        private UnityEngine.Texture maskTexture;        // 0x80
        private PaintIn3D.P3dPaintableTexture maskPaintableTexture;        // 0x88
        private PaintIn3D.P3dChannel maskChannel;        // 0x90
        private System.Single counter;        // 0x94

        // Methods
        private System.Void set_PaintableTexture(PaintIn3D.P3dPaintableTexture value) { }
        private PaintIn3D.P3dPaintableTexture get_PaintableTexture() { }
        private System.Void set_Threshold(System.Single value) { }
        private System.Single get_Threshold() { }
        private System.Void set_Speed(System.Single value) { }
        private System.Single get_Speed() { }
        private System.Void set_BlendMode(PaintIn3D.P3dBlendMode value) { }
        private PaintIn3D.P3dBlendMode get_BlendMode() { }
        private System.Void set_BlendTexture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_BlendTexture() { }
        private System.Void set_BlendPaintableTexture(PaintIn3D.P3dPaintableTexture value) { }
        private PaintIn3D.P3dPaintableTexture get_BlendPaintableTexture() { }
        private System.Void set_BlendColor(UnityEngine.Color value) { }
        private UnityEngine.Color get_BlendColor() { }
        private System.Void set_MaskTexture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_MaskTexture() { }
        private System.Void set_MaskPaintableTexture(PaintIn3D.P3dPaintableTexture value) { }
        private PaintIn3D.P3dPaintableTexture get_MaskPaintableTexture() { }
        private System.Void set_MaskChannel(PaintIn3D.P3dChannel value) { }
        private PaintIn3D.P3dChannel get_MaskChannel() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000074
    public struct P3dGroup
    {
        // Fields
        private System.Int32 index;        // 0x10

        // Methods
        private System.Void .ctor(System.Int32 newIndex) { }
        private System.Int32 op_Implicit(PaintIn3D.P3dGroup group) { }
        private PaintIn3D.P3dGroup op_Implicit(System.Int32 index) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000075
    public class P3dGroupData : ScriptableObject
    {
        // Fields
        private System.Int32 index;        // 0x18
        private System.Collections.Generic.List<PaintIn3D.P3dGroupData.TextureData> textureDatas;        // 0x20
        private System.String shaderData;        // 0x28
        private System.Collections.Generic.List<PaintIn3D.P3dGroupData.Entry> entries;        // 0x30

        // Methods
        private System.Void set_Index(System.Int32 value) { }
        private System.Int32 get_Index() { }
        private System.Collections.Generic.List<PaintIn3D.P3dGroupData.TextureData> get_TextureDatas() { }
        private System.Void set_ShaderData(System.String value) { }
        private System.String get_ShaderData() { }
        private System.Void TryGetShaderSlotName(System.String shaderPath, System.String& propertyName) { }
        private System.Boolean Supports(UnityEngine.Shader shader) { }
        private System.String GetName(System.Boolean prefixNumber) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000078
    public struct P3dHash
    {
        // Fields
        private System.Int32 v;        // 0x10

        // Methods
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Void .ctor(System.Int32 newValue) { }
        private System.Int32 op_Implicit(PaintIn3D.P3dHash hash) { }
        private PaintIn3D.P3dHash op_Implicit(System.Int32 index) { }
        private System.String ToString() { }

    }

    // TypeToken: 0x2000079
    public struct P3dHashedMaterial
    {
        // Fields
        private UnityEngine.Material instance;        // 0x10
        private System.Int32 hash;        // 0x18

        // Methods
        private System.Void .ctor(UnityEngine.Material newInstance, System.Int32 newHash) { }
        private System.Boolean TryGetInstance(UnityEngine.Material& model) { }

    }

    // TypeToken: 0x200007A
    public struct P3dHashedModel
    {
        // Fields
        private PaintIn3D.P3dModel instance;        // 0x10
        private PaintIn3D.P3dHash hash;        // 0x18

        // Methods
        private PaintIn3D.P3dHashedModel op_Implicit(PaintIn3D.P3dModel newInstance) { }
        private System.Boolean TryGetInstance(PaintIn3D.P3dModel& model) { }

    }

    // TypeToken: 0x200007B
    public struct P3dHashedTexture
    {
        // Fields
        private UnityEngine.Texture instance;        // 0x10
        private PaintIn3D.P3dHash hash;        // 0x18

        // Methods
        private PaintIn3D.P3dHashedTexture op_Implicit(UnityEngine.Texture newInstance) { }
        private UnityEngine.Texture op_Implicit(PaintIn3D.P3dHashedTexture hashed) { }
        private System.Boolean TryGetInstance(UnityEngine.Texture& texture) { }

    }

    // TypeToken: 0x200007C
    public struct P3dHit
    {
        // Fields
        public UnityEngine.Transform Root;        // 0x10
        public UnityEngine.Vector2 First;        // 0x18
        public UnityEngine.Vector2 Second;        // 0x20

        // Methods
        private System.Void .ctor(UnityEngine.RaycastHit hit) { }

    }

    // TypeToken: 0x200007D
    public class P3dLineConnector
    {
        // Fields
        private System.Single hitSpacing;        // 0x10
        private System.Int32 hitLimit;        // 0x14
        protected System.Boolean connectHits;        // 0x18
        protected System.Boolean clipConnected;        // 0x19
        private System.Collections.Generic.List<PaintIn3D.P3dLineConnector.Link> links;        // 0x20
        private static System.Collections.Generic.Stack<PaintIn3D.P3dLineConnector.Link> linkPool;        // 0x0
        protected PaintIn3D.P3dHitCache hitCache;        // 0x28

        // Methods
        private System.Void set_HitSpacing(System.Single value) { }
        private System.Single get_HitSpacing() { }
        private System.Void set_HitLimit(System.Int32 value) { }
        private System.Int32 get_HitLimit() { }
        private System.Void set_ConnectHits(System.Boolean value) { }
        private System.Boolean get_ConnectHits() { }
        private System.Void set_ClipConnected(System.Boolean value) { }
        private System.Boolean get_ClipConnected() { }
        private PaintIn3D.P3dHitCache get_HitCache() { }
        private System.Void ClearHitCache() { }
        private System.Void ResetConnections() { }
        private System.Void BreakHits(System.Object owner) { }
        private System.Void SubmitLine(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Quaternion rotation, System.Object owner) { }
        private System.Void Update() { }
        private System.Boolean TryGetLink(System.Object owner, PaintIn3D.P3dLineConnector.Link& link) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200007F
    public class P3dMask : MonoBehaviour
    {
        // Fields
        private UnityEngine.Texture texture;        // 0x18
        private PaintIn3D.P3dChannel channel;        // 0x20
        private UnityEngine.Vector2 stretch;        // 0x24
        private static System.Collections.Generic.LinkedList<PaintIn3D.P3dMask> instances;        // 0x0
        private System.Collections.Generic.LinkedListNode<PaintIn3D.P3dMask> instancesNode;        // 0x30

        // Methods
        private System.Void set_Texture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_Texture() { }
        private System.Void set_Channel(PaintIn3D.P3dChannel value) { }
        private PaintIn3D.P3dChannel get_Channel() { }
        private System.Void set_Stretch(UnityEngine.Vector2 value) { }
        private UnityEngine.Vector2 get_Stretch() { }
        private System.Collections.Generic.LinkedList<PaintIn3D.P3dMask> get_Instances() { }
        private UnityEngine.Matrix4x4 get_Matrix() { }
        private PaintIn3D.P3dMask Find(UnityEngine.Vector3 position, UnityEngine.LayerMask layers) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000080
    public class P3dMaterialCloner : MonoBehaviour
    {
        // Fields
        private System.Int32 index;        // 0x18
        private UnityEngine.Renderer cachedRenderer;        // 0x20
        private System.Boolean cachedRendererSet;        // 0x28
        private PaintIn3D.P3dPaintable cachedPaintable;        // 0x30
        private System.Boolean cachedPaintableSet;        // 0x38
        private System.Boolean activated;        // 0x39
        private UnityEngine.Material current;        // 0x40
        private UnityEngine.Material original;        // 0x48

        // Methods
        private System.Void set_Index(System.Int32 value) { }
        private System.Int32 get_Index() { }
        private UnityEngine.Renderer get_CachedRenderer() { }
        private PaintIn3D.P3dPaintable get_CachedPaintable() { }
        private UnityEngine.Material get_Original() { }
        private UnityEngine.Material get_Current() { }
        private System.Boolean get_Activated() { }
        private System.Void Activate() { }
        private System.Void Deactivate() { }
        private System.Void ReplaceAll(UnityEngine.Material from, UnityEngine.Material to) { }
        private System.Void Replace(UnityEngine.Renderer renderer, UnityEngine.Material[] materials, UnityEngine.Material oldMaterial, UnityEngine.Material newMaterial) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000081
    public class P3dMeshCache
    {
        // Fields
        private static System.Collections.Generic.Dictionary<UnityEngine.Mesh,PaintIn3D.P3dMeshCache.MeshData> cachedData;        // 0x0

        // Methods
        private System.Boolean GetTrianglePositions(UnityEngine.RaycastHit hit, UnityEngine.Vector3& positionA, UnityEngine.Vector3& positionB, UnityEngine.Vector3& positionC) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000083
    public class P3dModel : MonoBehaviour
    {
        // Fields
        protected PaintIn3D.P3dPaintable paintable;        // 0x18
        protected System.Boolean includeScale;        // 0x20
        protected PaintIn3D.P3dModel.UseMeshType useMesh;        // 0x24
        protected PaintIn3D.P3dHash hash;        // 0x28
        private UnityEngine.Renderer cachedRenderer;        // 0x30
        private System.Boolean cachedRendererSet;        // 0x38
        private UnityEngine.SkinnedMeshRenderer cachedSkinned;        // 0x40
        private UnityEngine.MeshFilter cachedFilter;        // 0x48
        private System.Boolean cachedSkinnedSet;        // 0x50
        private UnityEngine.Transform cachedTransform;        // 0x58
        private UnityEngine.GameObject cachedGameObject;        // 0x60
        private UnityEngine.Material[] materials;        // 0x68
        private System.Boolean materialsSet;        // 0x70
        private UnityEngine.Mesh bakedMesh;        // 0x78
        private System.Boolean bakedMeshSet;        // 0x80
        protected System.Boolean prepared;        // 0x81
        private UnityEngine.Mesh preparedMesh;        // 0x88
        private UnityEngine.Matrix4x4 preparedMatrix;        // 0x90
        private System.Int32[] preparedTriangles;        // 0xD0
        private UnityEngine.Vector3[] preparedPositions;        // 0xD8
        private UnityEngine.Vector2[] preparedCoord0;        // 0xE0
        private UnityEngine.Vector2[] preparedCoord1;        // 0xE8
        private static System.Collections.Generic.List<PaintIn3D.P3dModel> tempModels;        // 0x0
        private static System.Collections.Generic.LinkedList<PaintIn3D.P3dModel> instances;        // 0x8
        private System.Collections.Generic.LinkedListNode<PaintIn3D.P3dModel> instancesNode;        // 0xF0

        // Methods
        private System.Void set_Paintable(PaintIn3D.P3dPaintable value) { }
        private PaintIn3D.P3dPaintable get_Paintable() { }
        private System.Void set_IncludeScale(System.Boolean value) { }
        private System.Boolean get_IncludeScale() { }
        private System.Void set_UseMesh(PaintIn3D.P3dModel.UseMeshType value) { }
        private PaintIn3D.P3dModel.UseMeshType get_UseMesh() { }
        private System.Void set_Hash(PaintIn3D.P3dHash value) { }
        private PaintIn3D.P3dHash get_Hash() { }
        private System.Collections.Generic.LinkedList<PaintIn3D.P3dModel> get_Instances() { }
        private System.Void set_Prepared(System.Boolean value) { }
        private System.Boolean get_Prepared() { }
        private UnityEngine.Mesh get_PreparedMesh() { }
        private UnityEngine.GameObject get_CachedGameObject() { }
        private UnityEngine.Renderer get_CachedRenderer() { }
        private UnityEngine.Material[] get_Materials() { }
        private System.Int32 GetMaterialIndex(UnityEngine.Material material) { }
        private System.Void CacheRenderer() { }
        private System.Void DirtyMaterials() { }
        private System.Collections.Generic.List<PaintIn3D.P3dModel> FindOverlap(UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask) { }
        private System.Void GetPreparedPoints(System.Int32 triangleIndex, UnityEngine.Vector3& pointA, UnityEngine.Vector3& pointB, UnityEngine.Vector3& pointC) { }
        private System.Void GetPreparedCoords0(System.Int32 triangleIndex, UnityEngine.Vector2& coordA, UnityEngine.Vector2& coordB, UnityEngine.Vector2& coordC) { }
        private System.Void GetPreparedCoords1(System.Int32 triangleIndex, UnityEngine.Vector2& coordA, UnityEngine.Vector2& coordB, UnityEngine.Vector2& coordC) { }
        private System.Int32 GetSubmesh(PaintIn3D.P3dPaintableTexture paintableTexture) { }
        private System.Void GetPrepared(UnityEngine.Mesh& mesh, UnityEngine.Matrix4x4& matrix, PaintIn3D.P3dCoord coord) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000085
    public class P3dModifier
    {
        // Fields
        private System.Boolean preview;        // 0x10
        private System.Boolean unique;        // 0x11

        // Methods
        private System.Void set_Preview(System.Boolean value) { }
        private System.Boolean get_Preview() { }
        private System.Void set_Unique(System.Boolean value) { }
        private System.Boolean get_Unique() { }
        private System.Void ModifyAngle(System.Single& angle, System.Single pressure) { }
        private System.Void OnModifyAngle(System.Single& angle, System.Single pressure) { }
        private System.Void ModifyColor(UnityEngine.Color& color, System.Single pressure) { }
        private System.Void OnModifyColor(UnityEngine.Color& color, System.Single pressure) { }
        private System.Void ModifyHardness(System.Single& hardness, System.Single pressure) { }
        private System.Void OnModifyHardness(System.Single& hardness, System.Single pressure) { }
        private System.Void ModifyOpacity(System.Single& opacity, System.Single pressure) { }
        private System.Void OnModifyOpacity(System.Single& opacity, System.Single pressure) { }
        private System.Void ModifyRadius(System.Single& radius, System.Single pressure) { }
        private System.Void OnModifyRadius(System.Single& radius, System.Single pressure) { }
        private System.Void ModifyScale(UnityEngine.Vector3& scale, System.Single pressure) { }
        private System.Void OnModifyScale(UnityEngine.Vector3& scale, System.Single pressure) { }
        private System.Void ModifyTexture(UnityEngine.Texture& texture, System.Single pressure) { }
        private System.Void OnModifyTexture(UnityEngine.Texture& texture, System.Single pressure) { }
        private System.Void ModifyPosition(UnityEngine.Vector3& position, System.Single pressure) { }
        private System.Void OnModifyPosition(UnityEngine.Vector3& position, System.Single pressure) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000086
    public class P3dModifierList
    {
        // Fields
        private System.Collections.Generic.List<PaintIn3D.P3dModifier> modifiers;        // 0x10

        // Methods
        private System.Int32 get_Count() { }
        private System.Collections.Generic.List<PaintIn3D.P3dModifier> get_Instances() { }
        private System.Void ModifyAngle(System.Single& angle, System.Boolean preview, System.Single pressure) { }
        private System.Void ModifyColor(UnityEngine.Color& color, System.Boolean preview, System.Single pressure) { }
        private System.Void ModifyHardness(System.Single& hardness, System.Boolean preview, System.Single pressure) { }
        private System.Void ModifyOpacity(System.Single& opacity, System.Boolean preview, System.Single pressure) { }
        private System.Void ModifyRadius(System.Single& radius, System.Boolean preview, System.Single pressure) { }
        private System.Void ModifyScale(UnityEngine.Vector3& scale, System.Boolean preview, System.Single pressure) { }
        private System.Void ModifyTexture(UnityEngine.Texture& texture, System.Boolean preview, System.Single pressure) { }
        private System.Void ModifyPosition(UnityEngine.Vector3& position, System.Boolean preview, System.Single pressure) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000087
    public class P3dPaintable : P3dModel
    {
        // Fields
        private PaintIn3D.P3dPaintable.ActivationType activation;        // 0xF8
        private UnityEngine.Vector3 baseScale;        // 0xFC
        private System.Collections.Generic.List<UnityEngine.Renderer> otherRenderers;        // 0x108
        private UnityEngine.Events.UnityEvent onActivating;        // 0x110
        private UnityEngine.Events.UnityEvent onActivated;        // 0x118
        private System.Boolean activated;        // 0x120
        private System.Collections.Generic.HashSet<PaintIn3D.P3dPaintableTexture> paintableTextures;        // 0x128
        private static System.Collections.Generic.List<PaintIn3D.P3dMaterialCloner> materialCloners;        // 0x0
        private System.Collections.Generic.List<PaintIn3D.P3dPaintableTexture> tempPaintableTextures;        // 0x130

        // Methods
        private System.Void set_Paintable(PaintIn3D.P3dPaintable value) { }
        private PaintIn3D.P3dPaintable get_Paintable() { }
        private System.Void set_Activation(PaintIn3D.P3dPaintable.ActivationType value) { }
        private PaintIn3D.P3dPaintable.ActivationType get_Activation() { }
        private System.Void set_BaseScale(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_BaseScale() { }
        private System.Void set_OtherRenderers(System.Collections.Generic.List<UnityEngine.Renderer> value) { }
        private System.Collections.Generic.List<UnityEngine.Renderer> get_OtherRenderers() { }
        private UnityEngine.Events.UnityEvent get_OnActivating() { }
        private UnityEngine.Events.UnityEvent get_OnActivated() { }
        private System.Boolean get_Activated() { }
        private System.Collections.Generic.HashSet<PaintIn3D.P3dPaintableTexture> get_PaintableTextures() { }
        private System.Void RemoveComponents() { }
        private System.Void ScaleSize(System.Int32& width, System.Int32& height) { }
        private System.Void Activate() { }
        private System.Void AddPaintableTextures(UnityEngine.Transform root) { }
        private System.Void Deactivate() { }
        private System.Void ClearAll(UnityEngine.Color color) { }
        private System.Void ClearAll(UnityEngine.Texture texture, UnityEngine.Color color) { }
        private System.Void Register(PaintIn3D.P3dPaintableTexture paintableTexture) { }
        private System.Void Unregister(PaintIn3D.P3dPaintableTexture paintableTexture) { }
        private System.Void Awake() { }
        private System.Void OnEnable() { }
        private System.Void Start() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000089
    public class P3dPaintableManager : MonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.LinkedList<PaintIn3D.P3dPaintableManager> instances;        // 0x0
        private System.Collections.Generic.LinkedListNode<PaintIn3D.P3dPaintableManager> instancesNode;        // 0x18

        // Methods
        private System.Collections.Generic.LinkedList<PaintIn3D.P3dPaintableManager> get_Instances() { }
        private PaintIn3D.P3dPaintableManager GetOrCreateInstance() { }
        private System.Void SubmitAll(PaintIn3D.P3dCommand command, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, PaintIn3D.P3dGroup group, PaintIn3D.P3dModel targetModel, PaintIn3D.P3dPaintableTexture targetTexture) { }
        private System.Void DoSubmitAll(PaintIn3D.P3dCommand command, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, PaintIn3D.P3dGroup group, PaintIn3D.P3dModel targetModel, PaintIn3D.P3dPaintableTexture targetTexture) { }
        private System.Void SubmitAll(PaintIn3D.P3dCommand command, UnityEngine.Vector3 position, System.Single radius, System.Int32 layerMask, PaintIn3D.P3dGroup group) { }
        private System.Void SubmitAll(PaintIn3D.P3dCommand command, PaintIn3D.P3dModel model, PaintIn3D.P3dGroup group) { }
        private PaintIn3D.P3dCommand Submit(PaintIn3D.P3dCommand command, PaintIn3D.P3dModel model, PaintIn3D.P3dPaintableTexture paintableTexture) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void LateUpdate() { }
        private System.Void ClearAll() { }
        private System.Void UpdateAll() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200008A
    public class P3dPaintableState
    {
        // Fields
        public UnityEngine.RenderTexture Texture;        // 0x10
        public System.Collections.Generic.List<PaintIn3D.P3dCommand> Commands;        // 0x18
        private static System.Collections.Generic.Stack<PaintIn3D.P3dPaintableState> pool;        // 0x0

        // Methods
        private PaintIn3D.P3dPaintableState Pop() { }
        private System.Void Write(UnityEngine.RenderTexture current) { }
        private System.Void Write(System.Collections.Generic.List<PaintIn3D.P3dCommand> commands) { }
        private System.Void Write(UnityEngine.RenderTexture current, System.Collections.Generic.List<PaintIn3D.P3dCommand> commands) { }
        private System.Void Clear() { }
        private System.Void Pool() { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200008B
    public class P3dPaintableTexture : MonoBehaviour
    {
        // Fields
        private PaintIn3D.P3dSlot slot;        // 0x18
        private PaintIn3D.P3dCoord coord;        // 0x28
        private PaintIn3D.P3dGroup group;        // 0x2C
        private PaintIn3D.P3dPaintableTexture.UndoRedoType undoRedo;        // 0x30
        private System.Int32 stateLimit;        // 0x34
        private PaintIn3D.P3dPaintableTexture.SaveLoadType saveLoad;        // 0x38
        private System.String saveName;        // 0x40
        private System.Int32 width;        // 0x48
        private System.Int32 height;        // 0x4C
        private UnityEngine.Texture texture;        // 0x50
        private UnityEngine.Color color;        // 0x58
        private UnityEngine.RenderTextureFormat format;        // 0x68
        private PaintIn3D.P3dPaintableTexture.MipType mipMaps;        // 0x6C
        private PaintIn3D.P3dPaintableTexture.FilterType filter;        // 0x70
        private PaintIn3D.P3dPaintableTexture.AnisoType aniso;        // 0x74
        private PaintIn3D.P3dPaintableTexture.WrapType wrapU;        // 0x78
        private PaintIn3D.P3dPaintableTexture.WrapType wrapV;        // 0x7C
        private PaintIn3D.P3dPaintableTexture.ExistingType existing;        // 0x80
        private PaintIn3D.P3dPaintableTexture.ConversionType conversion;        // 0x84
        private UnityEngine.Texture localMaskTexture;        // 0x88
        private PaintIn3D.P3dChannel localMaskChannel;        // 0x90
        private System.String shaderKeyword;        // 0x98
        protected PaintIn3D.P3dHash hash;        // 0xA0
        private System.Boolean isDummy;        // 0xA4
        private System.String output;        // 0xA8
        private System.Action<PaintIn3D.P3dCommand> OnAddCommand;        // 0xB0
        private static System.Action<PaintIn3D.P3dPaintableTexture,PaintIn3D.P3dCommand> OnAddCommandGlobal;        // 0x0
        public static System.Action<PaintIn3D.P3dPaintableTexture> OnInstanceAdded;        // 0x8
        public static System.Action<PaintIn3D.P3dPaintableTexture> OnInstanceRemoved;        // 0x10
        private System.Action<System.Boolean> OnModified;        // 0xB8
        private System.Boolean activated;        // 0xC0
        private UnityEngine.RenderTexture current;        // 0xC8
        private UnityEngine.RenderTexture preview;        // 0xD0
        private System.Collections.Generic.List<PaintIn3D.P3dPaintableState> paintableStates;        // 0xD8
        private System.Int32 stateIndex;        // 0xE0
        private PaintIn3D.P3dPaintable paintable;        // 0xE8
        private System.Boolean paintableSet;        // 0xF0
        private UnityEngine.Material material;        // 0xF8
        private System.Boolean materialSet;        // 0x100
        private UnityEngine.Texture oldTexture;        // 0x108
        private System.Collections.Generic.List<PaintIn3D.P3dCommand> paintCommands;        // 0x110
        private System.Collections.Generic.List<PaintIn3D.P3dCommand> previewCommands;        // 0x118
        private System.Collections.Generic.List<PaintIn3D.P3dCommand> localCommands;        // 0x120
        private static System.Collections.Generic.List<PaintIn3D.P3dPaintableTexture> tempPaintableTextures;        // 0x18
        private static System.Collections.Generic.LinkedList<PaintIn3D.P3dPaintableTexture> instances;        // 0x20
        private System.Collections.Generic.LinkedListNode<PaintIn3D.P3dPaintableTexture> instancesNode;        // 0x128
        private static System.Int32 _Buffer;        // 0x28
        private static System.Int32 _BufferSize;        // 0x2C

        // Methods
        private System.Void set_Slot(PaintIn3D.P3dSlot value) { }
        private PaintIn3D.P3dSlot get_Slot() { }
        private System.Void set_Coord(PaintIn3D.P3dCoord value) { }
        private PaintIn3D.P3dCoord get_Coord() { }
        private System.Void set_Group(PaintIn3D.P3dGroup value) { }
        private PaintIn3D.P3dGroup get_Group() { }
        private System.Void set_UndoRedo(PaintIn3D.P3dPaintableTexture.UndoRedoType value) { }
        private PaintIn3D.P3dPaintableTexture.UndoRedoType get_UndoRedo() { }
        private System.Void set_StateLimit(System.Int32 value) { }
        private System.Int32 get_StateLimit() { }
        private System.Void set_SaveLoad(PaintIn3D.P3dPaintableTexture.SaveLoadType value) { }
        private PaintIn3D.P3dPaintableTexture.SaveLoadType get_SaveLoad() { }
        private System.Void set_SaveName(System.String value) { }
        private System.String get_SaveName() { }
        private System.Void set_Width(System.Int32 value) { }
        private System.Int32 get_Width() { }
        private System.Void set_Height(System.Int32 value) { }
        private System.Int32 get_Height() { }
        private System.Void set_Texture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_Texture() { }
        private System.Void set_Color(UnityEngine.Color value) { }
        private UnityEngine.Color get_Color() { }
        private System.Void set_Format(UnityEngine.RenderTextureFormat value) { }
        private UnityEngine.RenderTextureFormat get_Format() { }
        private System.Void set_MipMaps(PaintIn3D.P3dPaintableTexture.MipType value) { }
        private PaintIn3D.P3dPaintableTexture.MipType get_MipMaps() { }
        private System.Void set_Filter(PaintIn3D.P3dPaintableTexture.FilterType value) { }
        private PaintIn3D.P3dPaintableTexture.FilterType get_Filter() { }
        private System.Void set_Aniso(PaintIn3D.P3dPaintableTexture.AnisoType value) { }
        private PaintIn3D.P3dPaintableTexture.AnisoType get_Aniso() { }
        private System.Void set_WrapU(PaintIn3D.P3dPaintableTexture.WrapType value) { }
        private PaintIn3D.P3dPaintableTexture.WrapType get_WrapU() { }
        private System.Void set_WrapV(PaintIn3D.P3dPaintableTexture.WrapType value) { }
        private PaintIn3D.P3dPaintableTexture.WrapType get_WrapV() { }
        private System.Void set_Existing(PaintIn3D.P3dPaintableTexture.ExistingType value) { }
        private PaintIn3D.P3dPaintableTexture.ExistingType get_Existing() { }
        private System.Void set_Conversion(PaintIn3D.P3dPaintableTexture.ConversionType value) { }
        private PaintIn3D.P3dPaintableTexture.ConversionType get_Conversion() { }
        private System.Void set_LocalMaskTexture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_LocalMaskTexture() { }
        private System.Void set_LocalMaskChannel(PaintIn3D.P3dChannel value) { }
        private PaintIn3D.P3dChannel get_LocalMaskChannel() { }
        private System.Void set_ShaderKeyword(System.String value) { }
        private System.String get_ShaderKeyword() { }
        private System.Void set_Hash(PaintIn3D.P3dHash value) { }
        private PaintIn3D.P3dHash get_Hash() { }
        private System.Void set_IsDummy(System.Boolean value) { }
        private System.Boolean get_IsDummy() { }
        private System.Void set_Output(System.String value) { }
        private System.String get_Output() { }
        private System.Void add_OnAddCommand(System.Action<PaintIn3D.P3dCommand> value) { }
        private System.Void remove_OnAddCommand(System.Action<PaintIn3D.P3dCommand> value) { }
        private System.Void add_OnAddCommandGlobal(System.Action<PaintIn3D.P3dPaintableTexture,PaintIn3D.P3dCommand> value) { }
        private System.Void remove_OnAddCommandGlobal(System.Action<PaintIn3D.P3dPaintableTexture,PaintIn3D.P3dCommand> value) { }
        private System.Void add_OnModified(System.Action<System.Boolean> value) { }
        private System.Void remove_OnModified(System.Action<System.Boolean> value) { }
        private System.Collections.Generic.LinkedList<PaintIn3D.P3dPaintableTexture> get_Instances() { }
        private System.Boolean get_Activated() { }
        private System.Boolean get_CanUndo() { }
        private System.Boolean get_CanRedo() { }
        private System.Collections.Generic.List<PaintIn3D.P3dPaintableState> get_States() { }
        private System.Int32 get_StateIndex() { }
        private UnityEngine.Material get_Material() { }
        private PaintIn3D.P3dPaintable get_Paintable() { }
        private System.Void set_Current(UnityEngine.RenderTexture value) { }
        private UnityEngine.RenderTexture get_Current() { }
        private UnityEngine.RenderTexture get_Preview() { }
        private System.Collections.Generic.List<PaintIn3D.P3dPaintableTexture> FilterAll(PaintIn3D.P3dModel model, PaintIn3D.P3dGroup group) { }
        private System.Void ClearStates() { }
        private System.Void StoreState() { }
        private System.Void Undo() { }
        private System.Void Redo() { }
        private System.Void SetColor(System.String html) { }
        private UnityEngine.Vector2 GetCoord(PaintIn3D.P3dHit& hit) { }
        private UnityEngine.Vector2 GetCoord(UnityEngine.RaycastHit& hit) { }
        private System.Boolean StatesContainTextureOrCommands() { }
        private System.Boolean LastStateWithTextureOr0(System.Int32& startIndex) { }
        private System.Void RebuildFromCommands() { }
        private System.Void AddState() { }
        private System.Void TrimFuture() { }
        private System.Void TrimPast() { }
        private System.Void NotifyOnModified(System.Boolean preview) { }
        private UnityEngine.Texture2D GetReadableCopy(System.Boolean convertBack) { }
        private System.Byte[] GetPngData(System.Boolean convertBack) { }
        private System.Byte[] GetTgaData(System.Boolean convertBack) { }
        private System.Void Clear() { }
        private System.Void Clear(UnityEngine.Texture texture, UnityEngine.Color tint, System.Boolean updateMips) { }
        private System.Void Replace() { }
        private System.Void Replace(UnityEngine.Texture texture, UnityEngine.Color tint) { }
        private System.Boolean Resize(System.Int32 width, System.Int32 height, System.Boolean copyContents) { }
        private System.Void Save() { }
        private System.Void Save(System.String saveName) { }
        private System.Void Load() { }
        private System.Void Load(System.String saveName, System.Boolean replace) { }
        private System.Void LoadFromData(System.Byte[] data, System.Boolean allowResize) { }
        private System.Void HidePreview() { }
        private System.Void HideAllPreviews() { }
        private System.Void ClearSave() { }
        private System.Void ClearSave(System.String saveName) { }
        private System.Void UpdateMaterial() { }
        private System.Void CopySize() { }
        private System.Void CopyTexture() { }
        private System.Void Activate() { }
        private System.Void Deactivate() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnApplicationPause(System.Boolean paused) { }
        private System.Void OnDestroy() { }
        private System.Void AddCommand(PaintIn3D.P3dCommand command) { }
        private System.Boolean get_CommandsPending() { }
        private System.Void ClearCommands() { }
        private System.Void ExecuteCommands(System.Boolean sendNotifications, System.Boolean doSort) { }
        private System.Void ExecuteCommands(System.Collections.Generic.List<PaintIn3D.P3dCommand> commands, System.Boolean sendNotifications, UnityEngine.RenderTexture main, UnityEngine.RenderTexture& swap) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000095
    public class P3dPaintableTextureMonitor : MonoBehaviour
    {
        // Fields
        private PaintIn3D.P3dPaintableTexture paintableTexture;        // 0x18
        private System.Single interval;        // 0x20
        private System.Boolean async;        // 0x24
        protected System.Int32 downsampleSteps;        // 0x28
        private System.Action OnUpdated;        // 0x30
        protected PaintIn3D.P3dPaintableTexture registeredPaintableTexture;        // 0x38
        private System.Single cooldown;        // 0x40
        private PaintIn3D.P3dReader currentReader;        // 0x48
        protected Unity.Collections.NativeArray<UnityEngine.Color32> currentPixels;        // 0x50

        // Methods
        private System.Void set_PaintableTexture(PaintIn3D.P3dPaintableTexture value) { }
        private PaintIn3D.P3dPaintableTexture get_PaintableTexture() { }
        private System.Void set_Interval(System.Single value) { }
        private System.Single get_Interval() { }
        private System.Void set_Async(System.Boolean value) { }
        private System.Boolean get_Async() { }
        private System.Void set_DownsampleSteps(System.Int32 value) { }
        private System.Int32 get_DownsampleSteps() { }
        private System.Void add_OnUpdated(System.Action value) { }
        private System.Void remove_OnUpdated(System.Action value) { }
        private System.Boolean get_Registered() { }
        private PaintIn3D.P3dReader get_CurrentReader() { }
        private System.Void MarkCurrentReaderAsDirty() { }
        private System.Void Register() { }
        private System.Void Unregister() { }
        private System.Void InvokeOnUpdated() { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void Update() { }
        private System.Void HandleCompleteCurrent(Unity.Collections.NativeArray<UnityEngine.Color32> pixels) { }
        private System.Void HandleModified(System.Boolean preview) { }
        private System.Void HandleComplete(System.Int32 boost) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000096
    public class P3dPaintableTextureMonitorMask : P3dPaintableTextureMonitor
    {
        // Fields
        private UnityEngine.Mesh maskMesh;        // 0x60
        private System.Int32 maskSubmesh;        // 0x68
        private UnityEngine.Texture maskTexture;        // 0x70
        private PaintIn3D.P3dChannel maskChannel;        // 0x78
        protected System.Int32 total;        // 0x7C
        private PaintIn3D.P3dReader maskReader;        // 0x80
        protected Unity.Collections.NativeArray<System.Byte> maskPixels;        // 0x88

        // Methods
        private System.Void set_MaskMesh(UnityEngine.Mesh value) { }
        private UnityEngine.Mesh get_MaskMesh() { }
        private System.Void set_MaskSubmesh(System.Int32 value) { }
        private System.Int32 get_MaskSubmesh() { }
        private System.Void set_MaskTexture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_MaskTexture() { }
        private System.Void set_MaskChannel(PaintIn3D.P3dChannel value) { }
        private PaintIn3D.P3dChannel get_MaskChannel() { }
        private System.Int32 get_Total() { }
        private PaintIn3D.P3dReader get_MaskReader() { }
        private System.Void MarkMaskReaderAsDirty() { }
        private System.Void HandleCompleteMask(Unity.Collections.NativeArray<UnityEngine.Color32> pixels) { }
        private System.Void OnEnable() { }
        private System.Void OnDisable() { }
        private System.Void OnDestroy() { }
        private System.Void Update() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x2000097
    public class P3dPointConnector
    {
        // Fields
        private System.Single hitSpacing;        // 0x10
        private System.Int32 hitLimit;        // 0x14
        protected System.Boolean connectHits;        // 0x18
        protected System.Boolean clipConnected;        // 0x19
        private System.Collections.Generic.List<PaintIn3D.P3dPointConnector.Link> links;        // 0x20
        private static System.Collections.Generic.Stack<PaintIn3D.P3dPointConnector.Link> linkPool;        // 0x0
        protected PaintIn3D.P3dHitCache hitCache;        // 0x28

        // Methods
        private System.Void set_HitSpacing(System.Single value) { }
        private System.Single get_HitSpacing() { }
        private System.Void set_HitLimit(System.Int32 value) { }
        private System.Int32 get_HitLimit() { }
        private System.Void set_ConnectHits(System.Boolean value) { }
        private System.Boolean get_ConnectHits() { }
        private System.Void set_ClipConnected(System.Boolean value) { }
        private System.Boolean get_ClipConnected() { }
        private PaintIn3D.P3dHitCache get_HitCache() { }
        private System.Void ClearHitCache() { }
        private System.Void ResetConnections() { }
        private System.Void BreakHits(System.Object owner) { }
        private System.Void SubmitLastPoint(UnityEngine.GameObject gameObject, System.Boolean preview, System.Object owner) { }
        private System.Void SubmitPoint(UnityEngine.GameObject gameObject, System.Boolean preview, System.Int32 priority, System.Single pressure, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Object owner) { }
        private System.Void Update() { }
        private System.Boolean TryGetLink(System.Object owner, PaintIn3D.P3dPointConnector.Link& link) { }
        private System.Void .ctor() { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x2000099
    public class P3dReadColor : MonoBehaviour, IHitCoord, IHit
    {
        // Fields
        private PaintIn3D.P3dGroup group;        // 0x18
        private System.Boolean preview;        // 0x1C
        private UnityEngine.Color color;        // 0x20
        private PaintIn3D.P3dReadColor.ColorEvent onColor;        // 0x30

        // Methods
        private System.Void set_Group(PaintIn3D.P3dGroup value) { }
        private PaintIn3D.P3dGroup get_Group() { }
        private System.Void set_Preview(System.Boolean value) { }
        private System.Boolean get_Preview() { }
        private System.Void set_Color(UnityEngine.Color value) { }
        private UnityEngine.Color get_Color() { }
        private PaintIn3D.P3dReadColor.ColorEvent get_OnColor() { }
        private System.Void HandleHitCoord(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009B
    public class P3dReader
    {
        // Fields
        private UnityEngine.Rendering.AsyncGPUReadbackRequest request;        // 0x10
        private System.Boolean dirty;        // 0x20
        private System.Boolean requested;        // 0x21
        private UnityEngine.RenderTexture buffer;        // 0x28
        private UnityEngine.Vector2Int originalSize;        // 0x30
        private UnityEngine.Vector2Int downsampledSize;        // 0x38
        private System.Int32 downsampleSteps;        // 0x40
        private System.Int32 downsampleBoost;        // 0x44
        private UnityEngine.Texture2D tempTexture;        // 0x48
        private System.Action<Unity.Collections.NativeArray<UnityEngine.Color32>> OnComplete;        // 0x50

        // Methods
        private System.Void add_OnComplete(System.Action<Unity.Collections.NativeArray<UnityEngine.Color32>> value) { }
        private System.Void remove_OnComplete(System.Action<Unity.Collections.NativeArray<UnityEngine.Color32>> value) { }
        private System.Boolean get_Dirty() { }
        private System.Boolean get_Requested() { }
        private UnityEngine.Vector2Int get_OriginalSize() { }
        private System.Int32 get_DownsampleSteps() { }
        private UnityEngine.Vector2Int get_DownsampledSize() { }
        private System.Int32 get_DownsampleBoost() { }
        private System.Void MarkAsDirty() { }
        private System.Void UpdateRequest() { }
        private System.Boolean NeedsUpdating(PaintIn3D.P3dReader reader, Unity.Collections.NativeArray<T> array, UnityEngine.RenderTexture texture, System.Int32 downsampleSteps) { }
        private System.Void Request(UnityEngine.RenderTexture texture, System.Int32 downsample, System.Boolean async) { }
        private System.Void Release() { }
        private System.Void CompleteDirectly() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x200009C
    public class P3dSerialization
    {
        // Fields
        public static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Material> HashToMaterial;        // 0x0
        public static System.Collections.Generic.Dictionary<UnityEngine.Material,System.Int32> MaterialToHash;        // 0x8
        public static System.Collections.Generic.Dictionary<PaintIn3D.P3dHash,PaintIn3D.P3dModel> HashToModel;        // 0x10
        public static System.Collections.Generic.Dictionary<PaintIn3D.P3dModel,PaintIn3D.P3dHash> ModelToHash;        // 0x18
        public static System.Collections.Generic.Dictionary<PaintIn3D.P3dHash,UnityEngine.Texture> HashToTexture;        // 0x20
        public static System.Collections.Generic.Dictionary<UnityEngine.Texture,PaintIn3D.P3dHash> TextureToHash;        // 0x28
        public static System.Collections.Generic.Dictionary<PaintIn3D.P3dHash,PaintIn3D.P3dPaintableTexture> HashToPaintableTexture;        // 0x30
        public static System.Collections.Generic.Dictionary<PaintIn3D.P3dPaintableTexture,PaintIn3D.P3dHash> PaintableTextureToHash;        // 0x38

        // Methods
        private System.Void TryRegister(PaintIn3D.P3dPaintableTexture paintableTexture, PaintIn3D.P3dHash hash) { }
        private System.Void TryRegister(PaintIn3D.P3dModel model, PaintIn3D.P3dHash hash) { }
        private System.Void TryRegister(UnityEngine.Texture texture, PaintIn3D.P3dHash hash) { }
        private System.Void TryRegister(T obj, PaintIn3D.P3dHash hash, System.Collections.Generic.Dictionary<PaintIn3D.P3dHash,T> hashToObj, System.Collections.Generic.Dictionary<T,PaintIn3D.P3dHash> objToHash) { }
        private System.Int32 TryRegister(UnityEngine.Material material) { }
        private System.Int32 GetStableStringHash(System.String s) { }
        private System.Void .cctor() { }

    }

    // TypeToken: 0x200009D
    public struct P3dSlot
    {
        // Fields
        public System.Int32 Index;        // 0x10
        public System.String Name;        // 0x18

        // Methods
        private System.Void .ctor(System.Int32 newIndex, System.String newName) { }
        private UnityEngine.Texture FindTexture(UnityEngine.GameObject gameObject) { }
        private System.Boolean IsTransformed(UnityEngine.GameObject gameObject) { }
        private System.Boolean Equals(System.Object obj) { }
        private System.Int32 GetHashCode() { }
        private System.Boolean op_Equality(PaintIn3D.P3dSlot a, PaintIn3D.P3dSlot b) { }
        private System.Boolean op_Inequality(PaintIn3D.P3dSlot a, PaintIn3D.P3dSlot b) { }

    }

    // TypeToken: 0x200009E
    public class P3dStateManager
    {
        // Methods
        private System.Boolean get_CanUndo() { }
        private System.Boolean get_CanRedo() { }
        private System.Void StoreAllStates() { }
        private System.Void ClearAllStates() { }
        private System.Void UndoAll() { }
        private System.Void RedoAll() { }

    }

    // TypeToken: 0x200009F
    public class P3dTextureHash : MonoBehaviour
    {
        // Fields
        private UnityEngine.Texture texture;        // 0x18
        private PaintIn3D.P3dHash hash;        // 0x20

        // Methods
        private System.Void set_Texture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_Texture() { }
        private System.Void set_Hash(PaintIn3D.P3dHash value) { }
        private PaintIn3D.P3dHash get_Hash() { }
        private System.Void OnEnable() { }
        private System.Void OnDestroy() { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A0
    public class P3dPaintDecal : MonoBehaviour, IHitPoint, IHit, IHitLine, IHitTriangle, IHitQuad, IHitCoord
    {
        // Fields
        private UnityEngine.LayerMask layers;        // 0x18
        private PaintIn3D.P3dModel targetModel;        // 0x20
        private PaintIn3D.P3dGroup group;        // 0x28
        private PaintIn3D.P3dPaintableTexture targetTexture;        // 0x30
        private PaintIn3D.P3dBlendMode blendMode;        // 0x38
        private UnityEngine.Texture texture;        // 0x70
        private UnityEngine.Texture shape;        // 0x78
        private PaintIn3D.P3dChannel shapeChannel;        // 0x80
        private UnityEngine.Color color;        // 0x84
        private System.Single opacity;        // 0x94
        private System.Single angle;        // 0x98
        private UnityEngine.Vector3 scale;        // 0x9C
        private System.Single radius;        // 0xA8
        private System.Single hardness;        // 0xAC
        private System.Single wrapping;        // 0xB0
        private System.Single normalFront;        // 0xB4
        private System.Single normalBack;        // 0xB8
        private System.Single normalFade;        // 0xBC
        private UnityEngine.Texture tileTexture;        // 0xC0
        private UnityEngine.Transform tileTransform;        // 0xC8
        private System.Single tileOpacity;        // 0xD0
        private System.Single tileTransition;        // 0xD4
        private PaintIn3D.P3dModifierList modifiers;        // 0xD8

        // Methods
        private System.Void set_Layers(UnityEngine.LayerMask value) { }
        private UnityEngine.LayerMask get_Layers() { }
        private System.Void set_TargetModel(PaintIn3D.P3dModel value) { }
        private PaintIn3D.P3dModel get_TargetModel() { }
        private System.Void set_Group(PaintIn3D.P3dGroup value) { }
        private PaintIn3D.P3dGroup get_Group() { }
        private System.Void set_TargetTexture(PaintIn3D.P3dPaintableTexture value) { }
        private PaintIn3D.P3dPaintableTexture get_TargetTexture() { }
        private System.Void set_BlendMode(PaintIn3D.P3dBlendMode value) { }
        private PaintIn3D.P3dBlendMode get_BlendMode() { }
        private System.Void set_Texture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_Texture() { }
        private System.Void set_Shape(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_Shape() { }
        private System.Void set_ShapeChannel(PaintIn3D.P3dChannel value) { }
        private PaintIn3D.P3dChannel get_ShapeChannel() { }
        private System.Void set_Color(UnityEngine.Color value) { }
        private UnityEngine.Color get_Color() { }
        private System.Void set_Opacity(System.Single value) { }
        private System.Single get_Opacity() { }
        private System.Void set_Angle(System.Single value) { }
        private System.Single get_Angle() { }
        private System.Void set_Scale(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_Scale() { }
        private System.Void set_Radius(System.Single value) { }
        private System.Single get_Radius() { }
        private System.Void set_Hardness(System.Single value) { }
        private System.Single get_Hardness() { }
        private System.Void set_Wrapping(System.Single value) { }
        private System.Single get_Wrapping() { }
        private System.Void set_NormalFront(System.Single value) { }
        private System.Single get_NormalFront() { }
        private System.Void set_NormalBack(System.Single value) { }
        private System.Single get_NormalBack() { }
        private System.Void set_NormalFade(System.Single value) { }
        private System.Single get_NormalFade() { }
        private System.Void set_TileTexture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_TileTexture() { }
        private System.Void set_TileTransform(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_TileTransform() { }
        private System.Void set_TileOpacity(System.Single value) { }
        private System.Single get_TileOpacity() { }
        private System.Void set_TileTransition(System.Single value) { }
        private System.Single get_TileTransition() { }
        private PaintIn3D.P3dModifierList get_Modifiers() { }
        private System.Void FlipHorizontal() { }
        private System.Void FlipVertical() { }
        private System.Void IncrementOpacity(System.Single delta) { }
        private System.Void IncrementAngle(System.Single degrees) { }
        private System.Void MultiplyScale(System.Single multiplier) { }
        private System.Void MultiplyHardness(System.Single multiplier) { }
        private System.Void HandleHitPoint(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void HandleHitLine(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Quaternion rotation, System.Boolean clip) { }
        private System.Void HandleHitTriangle(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC, UnityEngine.Quaternion rotation) { }
        private System.Void HandleHitQuad(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2, UnityEngine.Quaternion rotation, System.Boolean clip) { }
        private System.Void HandleHitCoord(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation) { }
        private UnityEngine.Vector3 HandleHitCommon(System.Boolean preview, System.Single pressure, System.Int32 seed, UnityEngine.Quaternion rotation) { }
        private System.Void HandleMaskCommon(UnityEngine.Vector3 worldPosition) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A1
    public class P3dPaintFill : MonoBehaviour, IHitCoord, IHit
    {
        // Fields
        private PaintIn3D.P3dGroup group;        // 0x18
        private PaintIn3D.P3dBlendMode blendMode;        // 0x20
        private UnityEngine.Texture texture;        // 0x58
        private UnityEngine.Color color;        // 0x60
        private System.Single opacity;        // 0x70
        private System.Single minimum;        // 0x74
        private PaintIn3D.P3dModifierList modifiers;        // 0x78

        // Methods
        private System.Void set_Group(PaintIn3D.P3dGroup value) { }
        private PaintIn3D.P3dGroup get_Group() { }
        private System.Void set_BlendMode(PaintIn3D.P3dBlendMode value) { }
        private PaintIn3D.P3dBlendMode get_BlendMode() { }
        private System.Void set_Texture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_Texture() { }
        private System.Void set_Color(UnityEngine.Color value) { }
        private UnityEngine.Color get_Color() { }
        private System.Void set_Opacity(System.Single value) { }
        private System.Single get_Opacity() { }
        private System.Void set_Minimum(System.Single value) { }
        private System.Single get_Minimum() { }
        private PaintIn3D.P3dModifierList get_Modifiers() { }
        private System.Void IncrementOpacity(System.Single delta) { }
        private System.Void HandleHitCoord(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A2
    public class P3dPaintReplace : MonoBehaviour, IHitCoord, IHit
    {
        // Fields
        private PaintIn3D.P3dGroup group;        // 0x18
        private UnityEngine.Texture texture;        // 0x20
        private UnityEngine.Color color;        // 0x28
        private PaintIn3D.P3dModifierList modifiers;        // 0x38

        // Methods
        private System.Void set_Group(PaintIn3D.P3dGroup value) { }
        private PaintIn3D.P3dGroup get_Group() { }
        private System.Void set_Texture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_Texture() { }
        private System.Void set_Color(UnityEngine.Color value) { }
        private UnityEngine.Color get_Color() { }
        private PaintIn3D.P3dModifierList get_Modifiers() { }
        private System.Void HandleHitCoord(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A3
    public class P3dPaintReplaceChannels : MonoBehaviour, IHitCoord, IHit
    {
        // Fields
        private PaintIn3D.P3dGroup group;        // 0x18
        private UnityEngine.Texture textureR;        // 0x20
        private UnityEngine.Texture textureG;        // 0x28
        private UnityEngine.Texture textureB;        // 0x30
        private UnityEngine.Texture textureA;        // 0x38
        private UnityEngine.Vector4 channelR;        // 0x40
        private UnityEngine.Vector4 channelG;        // 0x50
        private UnityEngine.Vector4 channelB;        // 0x60
        private UnityEngine.Vector4 channelA;        // 0x70

        // Methods
        private System.Void set_Group(PaintIn3D.P3dGroup value) { }
        private PaintIn3D.P3dGroup get_Group() { }
        private System.Void set_TextureR(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_TextureR() { }
        private System.Void set_TextureG(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_TextureG() { }
        private System.Void set_TextureB(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_TextureB() { }
        private System.Void set_TextureA(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_TextureA() { }
        private System.Void set_ChannelR(UnityEngine.Vector4 value) { }
        private UnityEngine.Vector4 get_ChannelR() { }
        private System.Void set_ChannelG(UnityEngine.Vector4 value) { }
        private UnityEngine.Vector4 get_ChannelG() { }
        private System.Void set_ChannelB(UnityEngine.Vector4 value) { }
        private UnityEngine.Vector4 get_ChannelB() { }
        private System.Void set_ChannelA(UnityEngine.Vector4 value) { }
        private UnityEngine.Vector4 get_ChannelA() { }
        private System.Void HandleHitCoord(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation) { }
        private System.Void .ctor() { }

    }

    // TypeToken: 0x20000A4
    public class P3dPaintSphere : MonoBehaviour, IHitPoint, IHit, IHitLine, IHitTriangle, IHitQuad, IHitCoord
    {
        // Fields
        private UnityEngine.LayerMask layers;        // 0x18
        private PaintIn3D.P3dGroup group;        // 0x1C
        private PaintIn3D.P3dModel targetModel;        // 0x20
        private PaintIn3D.P3dPaintableTexture targetTexture;        // 0x28
        private PaintIn3D.P3dBlendMode blendMode;        // 0x30
        private UnityEngine.Color color;        // 0x68
        private System.Single opacity;        // 0x78
        private System.Single angle;        // 0x7C
        private UnityEngine.Vector3 scale;        // 0x80
        private System.Single radius;        // 0x8C
        private System.Single hardness;        // 0x90
        private UnityEngine.Texture tileTexture;        // 0x98
        private UnityEngine.Transform tileTransform;        // 0xA0
        private System.Single tileOpacity;        // 0xA8
        private System.Single tileTransition;        // 0xAC
        private PaintIn3D.P3dModifierList modifiers;        // 0xB0

        // Methods
        private System.Void set_Layers(UnityEngine.LayerMask value) { }
        private UnityEngine.LayerMask get_Layers() { }
        private System.Void set_Group(PaintIn3D.P3dGroup value) { }
        private PaintIn3D.P3dGroup get_Group() { }
        private System.Void set_TargetModel(PaintIn3D.P3dModel value) { }
        private PaintIn3D.P3dModel get_TargetModel() { }
        private System.Void set_TargetTexture(PaintIn3D.P3dPaintableTexture value) { }
        private PaintIn3D.P3dPaintableTexture get_TargetTexture() { }
        private System.Void set_BlendMode(PaintIn3D.P3dBlendMode value) { }
        private PaintIn3D.P3dBlendMode get_BlendMode() { }
        private System.Void set_Color(UnityEngine.Color value) { }
        private UnityEngine.Color get_Color() { }
        private System.Void set_Opacity(System.Single value) { }
        private System.Single get_Opacity() { }
        private System.Void set_Angle(System.Single value) { }
        private System.Single get_Angle() { }
        private System.Void set_Scale(UnityEngine.Vector3 value) { }
        private UnityEngine.Vector3 get_Scale() { }
        private System.Void set_Radius(System.Single value) { }
        private System.Single get_Radius() { }
        private System.Void set_Hardness(System.Single value) { }
        private System.Single get_Hardness() { }
        private System.Void set_TileTexture(UnityEngine.Texture value) { }
        private UnityEngine.Texture get_TileTexture() { }
        private System.Void set_TileTransform(UnityEngine.Transform value) { }
        private UnityEngine.Transform get_TileTransform() { }
        private System.Void set_TileOpacity(System.Single value) { }
        private System.Single get_TileOpacity() { }
        private System.Void set_TileTransition(System.Single value) { }
        private System.Single get_TileTransition() { }
        private PaintIn3D.P3dModifierList get_Modifiers() { }
        private System.Void IncrementOpacity(System.Single delta) { }
        private System.Void IncrementAngle(System.Single degrees) { }
        private System.Void MultiplyRadius(System.Single multiplier) { }
        private System.Void MultiplyScale(System.Single multiplier) { }
        private System.Void HandleHitPoint(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation) { }
        private System.Void HandleHitLine(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Quaternion rotation, System.Boolean clip) { }
        private System.Void HandleHitTriangle(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 positionA, UnityEngine.Vector3 positionB, UnityEngine.Vector3 positionC, UnityEngine.Quaternion rotation) { }
        private System.Void HandleHitQuad(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, UnityEngine.Vector3 position, UnityEngine.Vector3 endPosition, UnityEngine.Vector3 position2, UnityEngine.Vector3 endPosition2, UnityEngine.Quaternion rotation, System.Boolean clip) { }
        private System.Void HandleHitCoord(System.Boolean preview, System.Int32 priority, System.Single pressure, System.Int32 seed, PaintIn3D.P3dHit hit, UnityEngine.Quaternion rotation) { }
        private UnityEngine.Vector3 HandleHitCommon(System.Boolean preview, System.Single pressure, System.Int32 seed, UnityEngine.Quaternion rotation) { }
        private System.Void HandleMaskCommon(UnityEngine.Vector3 worldPosition) { }
        private System.Void .ctor() { }

    }

}

