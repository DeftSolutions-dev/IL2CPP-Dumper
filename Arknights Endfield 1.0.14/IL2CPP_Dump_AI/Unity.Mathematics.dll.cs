// ========================================================
// Dumped by @desirepro
// Assembly: Unity.Mathematics.dll
// Classes:  94
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: RotationOrder
TYPE:  struct
TOKEN: 0x2000005
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Unity.Mathematics.math.RotationOrderXYZ  // 0x0
  public    static  Unity.Mathematics.math.RotationOrderXZY  // 0x0
  public    static  Unity.Mathematics.math.RotationOrderYXZ  // 0x0
  public    static  Unity.Mathematics.math.RotationOrderYZX  // 0x0
  public    static  Unity.Mathematics.math.RotationOrderZXY  // 0x0
  public    static  Unity.Mathematics.math.RotationOrderZYX  // 0x0
  public    static  Unity.Mathematics.math.RotationOrderDefault  // 0x0
METHODS:
END_CLASS

CLASS: ShuffleComponent
TYPE:  struct
TOKEN: 0x2000006
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Unity.Mathematics.math.ShuffleComponentLeftX  // 0x0
  public    static  Unity.Mathematics.math.ShuffleComponentLeftY  // 0x0
  public    static  Unity.Mathematics.math.ShuffleComponentLeftZ  // 0x0
  public    static  Unity.Mathematics.math.ShuffleComponentLeftW  // 0x0
  public    static  Unity.Mathematics.math.ShuffleComponentRightX  // 0x0
  public    static  Unity.Mathematics.math.ShuffleComponentRightY  // 0x0
  public    static  Unity.Mathematics.math.ShuffleComponentRightZ  // 0x0
  public    static  Unity.Mathematics.math.ShuffleComponentRightW  // 0x0
METHODS:
END_CLASS

CLASS: LongDoubleUnion
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int64                    longValue  // 0x10
  public            System.Double                   doubleValue  // 0x10
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x2000009
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x200000E
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x2000013
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x2000018
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x200001D
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x2000022
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x2000027
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x200002C
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x2000031
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x2000037
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x2000039
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x200003B
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x200003D
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x2000042
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x2000047
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x2000051
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x2000056
FIELDS:
METHODS:
END_CLASS

CLASS: DebuggerProxy
TYPE:  class
TOKEN: 0x200005B
FIELDS:
METHODS:
END_CLASS

CLASS: Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstructionAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Unity.Mathematics.AffineTransform
TYPE:  struct
TOKEN: 0x2000003
FIELDS:
  public            Unity.Mathematics.float3x3      rs  // 0x10
  public            Unity.Mathematics.float3        t  // 0x34
  public    static readonly Unity.Mathematics.AffineTransformidentity  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation)
  System.Void .ctor(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 scale)
  System.Void .ctor(Unity.Mathematics.float3 translation, Unity.Mathematics.float3x3 rotationScale)
  System.Void .ctor(Unity.Mathematics.float3x3 rotationScale)
  System.Void .ctor(Unity.Mathematics.RigidTransform rigid)
  System.Void .ctor(Unity.Mathematics.float3x4 m)
  System.Void .ctor(Unity.Mathematics.float4x4 m)
  System.Boolean Equals(Unity.Mathematics.AffineTransform rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.math
TYPE:  class
TOKEN: 0x2000004
FIELDS:
  public    static  System.Double                   E_DBL  // 0x0
  public    static  System.Double                   LOG2E_DBL  // 0x0
  public    static  System.Double                   LOG10E_DBL  // 0x0
  public    static  System.Double                   LN2_DBL  // 0x0
  public    static  System.Double                   LN10_DBL  // 0x0
  public    static  System.Double                   PI_DBL  // 0x0
  public    static  System.Double                   PI2_DBL  // 0x0
  public    static  System.Double                   PIHALF_DBL  // 0x0
  public    static  System.Double                   TAU_DBL  // 0x0
  public    static  System.Double                   TODEGREES_DBL  // 0x0
  public    static  System.Double                   TORADIANS_DBL  // 0x0
  public    static  System.Double                   SQRT2_DBL  // 0x0
  public    static  System.Double                   EPSILON_DBL  // 0x0
  public    static  System.Double                   INFINITY_DBL  // 0x0
  public    static  System.Double                   NAN_DBL  // 0x0
  public    static  System.Single                   FLT_MIN_NORMAL  // 0x0
  public    static  System.Double                   DBL_MIN_NORMAL  // 0x0
  public    static  System.Single                   E  // 0x0
  public    static  System.Single                   LOG2E  // 0x0
  public    static  System.Single                   LOG10E  // 0x0
  public    static  System.Single                   LN2  // 0x0
  public    static  System.Single                   LN10  // 0x0
  public    static  System.Single                   PI  // 0x0
  public    static  System.Single                   PI2  // 0x0
  public    static  System.Single                   PIHALF  // 0x0
  public    static  System.Single                   TAU  // 0x0
  public    static  System.Single                   TODEGREES  // 0x0
  public    static  System.Single                   TORADIANS  // 0x0
  public    static  System.Single                   SQRT2  // 0x0
  public    static  System.Single                   EPSILON  // 0x0
  public    static  System.Single                   INFINITY  // 0x0
  public    static  System.Single                   NAN  // 0x0
METHODS:
  Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation)
  Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 scale)
  Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3 translation, Unity.Mathematics.float3x3 rotationScale)
  Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3x3 rotationScale)
  Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float4x4 m)
  Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.float3x4 m)
  Unity.Mathematics.AffineTransform AffineTransform(Unity.Mathematics.RigidTransform rigid)
  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.AffineTransform transform)
  Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.AffineTransform transform)
  Unity.Mathematics.AffineTransform mul(Unity.Mathematics.AffineTransform a, Unity.Mathematics.AffineTransform b)
  Unity.Mathematics.AffineTransform mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.AffineTransform b)
  Unity.Mathematics.AffineTransform mul(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float3x3 b)
  Unity.Mathematics.float4 mul(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float4 pos)
  Unity.Mathematics.float3 rotate(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float3 dir)
  Unity.Mathematics.float3 transform(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float3 pos)
  Unity.Mathematics.AffineTransform inverse(Unity.Mathematics.AffineTransform a)
  System.Void decompose(Unity.Mathematics.AffineTransform a, Unity.Mathematics.float3& translation, Unity.Mathematics.quaternion& rotation, Unity.Mathematics.float3& scale)
  System.UInt32 hash(Unity.Mathematics.AffineTransform a)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.AffineTransform a)
  Unity.Mathematics.bool2 bool2(System.Boolean x, System.Boolean y)
  Unity.Mathematics.bool2 bool2(Unity.Mathematics.bool2 xy)
  Unity.Mathematics.bool2 bool2(System.Boolean v)
  System.UInt32 hash(Unity.Mathematics.bool2 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.bool2 v)
  System.Boolean shuffle(Unity.Mathematics.bool2 left, Unity.Mathematics.bool2 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.bool2 shuffle(Unity.Mathematics.bool2 left, Unity.Mathematics.bool2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.bool3 shuffle(Unity.Mathematics.bool2 left, Unity.Mathematics.bool2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.bool4 shuffle(Unity.Mathematics.bool2 left, Unity.Mathematics.bool2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.Boolean select_shuffle_component(Unity.Mathematics.bool2 a, Unity.Mathematics.bool2 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.bool2x2 bool2x2(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1)
  Unity.Mathematics.bool2x2 bool2x2(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11)
  Unity.Mathematics.bool2x2 bool2x2(System.Boolean v)
  Unity.Mathematics.bool2x2 transpose(Unity.Mathematics.bool2x2 v)
  System.UInt32 hash(Unity.Mathematics.bool2x2 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.bool2x2 v)
  Unity.Mathematics.bool2x3 bool2x3(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1, Unity.Mathematics.bool2 c2)
  Unity.Mathematics.bool2x3 bool2x3(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12)
  Unity.Mathematics.bool2x3 bool2x3(System.Boolean v)
  Unity.Mathematics.bool3x2 transpose(Unity.Mathematics.bool2x3 v)
  System.UInt32 hash(Unity.Mathematics.bool2x3 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.bool2x3 v)
  Unity.Mathematics.bool2x4 bool2x4(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1, Unity.Mathematics.bool2 c2, Unity.Mathematics.bool2 c3)
  Unity.Mathematics.bool2x4 bool2x4(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13)
  Unity.Mathematics.bool2x4 bool2x4(System.Boolean v)
  Unity.Mathematics.bool4x2 transpose(Unity.Mathematics.bool2x4 v)
  System.UInt32 hash(Unity.Mathematics.bool2x4 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.bool2x4 v)
  Unity.Mathematics.bool3 bool3(System.Boolean x, System.Boolean y, System.Boolean z)
  Unity.Mathematics.bool3 bool3(System.Boolean x, Unity.Mathematics.bool2 yz)
  Unity.Mathematics.bool3 bool3(Unity.Mathematics.bool2 xy, System.Boolean z)
  Unity.Mathematics.bool3 bool3(Unity.Mathematics.bool3 xyz)
  Unity.Mathematics.bool3 bool3(System.Boolean v)
  System.UInt32 hash(Unity.Mathematics.bool3 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.bool3 v)
  System.Boolean shuffle(Unity.Mathematics.bool3 left, Unity.Mathematics.bool3 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.bool2 shuffle(Unity.Mathematics.bool3 left, Unity.Mathematics.bool3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.bool3 shuffle(Unity.Mathematics.bool3 left, Unity.Mathematics.bool3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.bool4 shuffle(Unity.Mathematics.bool3 left, Unity.Mathematics.bool3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.Boolean select_shuffle_component(Unity.Mathematics.bool3 a, Unity.Mathematics.bool3 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.bool3x2 bool3x2(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1)
  Unity.Mathematics.bool3x2 bool3x2(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11, System.Boolean m20, System.Boolean m21)
  Unity.Mathematics.bool3x2 bool3x2(System.Boolean v)
  Unity.Mathematics.bool2x3 transpose(Unity.Mathematics.bool3x2 v)
  System.UInt32 hash(Unity.Mathematics.bool3x2 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.bool3x2 v)
  Unity.Mathematics.bool3x3 bool3x3(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1, Unity.Mathematics.bool3 c2)
  Unity.Mathematics.bool3x3 bool3x3(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m20, System.Boolean m21, System.Boolean m22)
  Unity.Mathematics.bool3x3 bool3x3(System.Boolean v)
  Unity.Mathematics.bool3x3 transpose(Unity.Mathematics.bool3x3 v)
  System.UInt32 hash(Unity.Mathematics.bool3x3 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.bool3x3 v)
  Unity.Mathematics.bool3x4 bool3x4(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1, Unity.Mathematics.bool3 c2, Unity.Mathematics.bool3 c3)
  Unity.Mathematics.bool3x4 bool3x4(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m23)
  Unity.Mathematics.bool3x4 bool3x4(System.Boolean v)
  Unity.Mathematics.bool4x3 transpose(Unity.Mathematics.bool3x4 v)
  System.UInt32 hash(Unity.Mathematics.bool3x4 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.bool3x4 v)
  Unity.Mathematics.bool4 bool4(System.Boolean x, System.Boolean y, System.Boolean z, System.Boolean w)
  Unity.Mathematics.bool4 bool4(System.Boolean x, System.Boolean y, Unity.Mathematics.bool2 zw)
  Unity.Mathematics.bool4 bool4(System.Boolean x, Unity.Mathematics.bool2 yz, System.Boolean w)
  Unity.Mathematics.bool4 bool4(System.Boolean x, Unity.Mathematics.bool3 yzw)
  Unity.Mathematics.bool4 bool4(Unity.Mathematics.bool2 xy, System.Boolean z, System.Boolean w)
  Unity.Mathematics.bool4 bool4(Unity.Mathematics.bool2 xy, Unity.Mathematics.bool2 zw)
  Unity.Mathematics.bool4 bool4(Unity.Mathematics.bool3 xyz, System.Boolean w)
  Unity.Mathematics.bool4 bool4(Unity.Mathematics.bool4 xyzw)
  Unity.Mathematics.bool4 bool4(System.Boolean v)
  System.UInt32 hash(Unity.Mathematics.bool4 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.bool4 v)
  System.Boolean shuffle(Unity.Mathematics.bool4 left, Unity.Mathematics.bool4 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.bool2 shuffle(Unity.Mathematics.bool4 left, Unity.Mathematics.bool4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.bool3 shuffle(Unity.Mathematics.bool4 left, Unity.Mathematics.bool4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.bool4 shuffle(Unity.Mathematics.bool4 left, Unity.Mathematics.bool4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.Boolean select_shuffle_component(Unity.Mathematics.bool4 a, Unity.Mathematics.bool4 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.bool4x2 bool4x2(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1)
  Unity.Mathematics.bool4x2 bool4x2(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11, System.Boolean m20, System.Boolean m21, System.Boolean m30, System.Boolean m31)
  Unity.Mathematics.bool4x2 bool4x2(System.Boolean v)
  Unity.Mathematics.bool2x4 transpose(Unity.Mathematics.bool4x2 v)
  System.UInt32 hash(Unity.Mathematics.bool4x2 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.bool4x2 v)
  Unity.Mathematics.bool4x3 bool4x3(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1, Unity.Mathematics.bool4 c2)
  Unity.Mathematics.bool4x3 bool4x3(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m30, System.Boolean m31, System.Boolean m32)
  Unity.Mathematics.bool4x3 bool4x3(System.Boolean v)
  Unity.Mathematics.bool3x4 transpose(Unity.Mathematics.bool4x3 v)
  System.UInt32 hash(Unity.Mathematics.bool4x3 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.bool4x3 v)
  Unity.Mathematics.bool4x4 bool4x4(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1, Unity.Mathematics.bool4 c2, Unity.Mathematics.bool4 c3)
  Unity.Mathematics.bool4x4 bool4x4(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m23, System.Boolean m30, System.Boolean m31, System.Boolean m32, System.Boolean m33)
  Unity.Mathematics.bool4x4 bool4x4(System.Boolean v)
  Unity.Mathematics.bool4x4 transpose(Unity.Mathematics.bool4x4 v)
  System.UInt32 hash(Unity.Mathematics.bool4x4 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.bool4x4 v)
  Unity.Mathematics.double2 double2(System.Double x, System.Double y)
  Unity.Mathematics.double2 double2(Unity.Mathematics.double2 xy)
  Unity.Mathematics.double2 double2(System.Double v)
  Unity.Mathematics.double2 double2(System.Boolean v)
  Unity.Mathematics.double2 double2(Unity.Mathematics.bool2 v)
  Unity.Mathematics.double2 double2(System.Int32 v)
  Unity.Mathematics.double2 double2(Unity.Mathematics.int2 v)
  Unity.Mathematics.double2 double2(System.UInt32 v)
  Unity.Mathematics.double2 double2(Unity.Mathematics.uint2 v)
  Unity.Mathematics.double2 double2(Unity.Mathematics.half v)
  Unity.Mathematics.double2 double2(Unity.Mathematics.half2 v)
  Unity.Mathematics.double2 double2(System.Single v)
  Unity.Mathematics.double2 double2(Unity.Mathematics.float2 v)
  System.UInt32 hash(Unity.Mathematics.double2 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.double2 v)
  System.Double shuffle(Unity.Mathematics.double2 left, Unity.Mathematics.double2 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.double2 shuffle(Unity.Mathematics.double2 left, Unity.Mathematics.double2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.double3 shuffle(Unity.Mathematics.double2 left, Unity.Mathematics.double2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.double4 shuffle(Unity.Mathematics.double2 left, Unity.Mathematics.double2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.Double select_shuffle_component(Unity.Mathematics.double2 a, Unity.Mathematics.double2 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1)
  Unity.Mathematics.double2x2 double2x2(System.Double m00, System.Double m01, System.Double m10, System.Double m11)
  Unity.Mathematics.double2x2 double2x2(System.Double v)
  Unity.Mathematics.double2x2 double2x2(System.Boolean v)
  Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.bool2x2 v)
  Unity.Mathematics.double2x2 double2x2(System.Int32 v)
  Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.int2x2 v)
  Unity.Mathematics.double2x2 double2x2(System.UInt32 v)
  Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.uint2x2 v)
  Unity.Mathematics.double2x2 double2x2(System.Single v)
  Unity.Mathematics.double2x2 double2x2(Unity.Mathematics.float2x2 v)
  Unity.Mathematics.double2x2 transpose(Unity.Mathematics.double2x2 v)
  Unity.Mathematics.double2x2 inverse(Unity.Mathematics.double2x2 m)
  System.Double determinant(Unity.Mathematics.double2x2 m)
  System.UInt32 hash(Unity.Mathematics.double2x2 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.double2x2 v)
  Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1, Unity.Mathematics.double2 c2)
  Unity.Mathematics.double2x3 double2x3(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12)
  Unity.Mathematics.double2x3 double2x3(System.Double v)
  Unity.Mathematics.double2x3 double2x3(System.Boolean v)
  Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.bool2x3 v)
  Unity.Mathematics.double2x3 double2x3(System.Int32 v)
  Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.int2x3 v)
  Unity.Mathematics.double2x3 double2x3(System.UInt32 v)
  Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.uint2x3 v)
  Unity.Mathematics.double2x3 double2x3(System.Single v)
  Unity.Mathematics.double2x3 double2x3(Unity.Mathematics.float2x3 v)
  Unity.Mathematics.double3x2 transpose(Unity.Mathematics.double2x3 v)
  System.UInt32 hash(Unity.Mathematics.double2x3 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.double2x3 v)
  Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1, Unity.Mathematics.double2 c2, Unity.Mathematics.double2 c3)
  Unity.Mathematics.double2x4 double2x4(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13)
  Unity.Mathematics.double2x4 double2x4(System.Double v)
  Unity.Mathematics.double2x4 double2x4(System.Boolean v)
  Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.bool2x4 v)
  Unity.Mathematics.double2x4 double2x4(System.Int32 v)
  Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.int2x4 v)
  Unity.Mathematics.double2x4 double2x4(System.UInt32 v)
  Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.uint2x4 v)
  Unity.Mathematics.double2x4 double2x4(System.Single v)
  Unity.Mathematics.double2x4 double2x4(Unity.Mathematics.float2x4 v)
  Unity.Mathematics.double4x2 transpose(Unity.Mathematics.double2x4 v)
  System.UInt32 hash(Unity.Mathematics.double2x4 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.double2x4 v)
  Unity.Mathematics.double3 double3(System.Double x, System.Double y, System.Double z)
  Unity.Mathematics.double3 double3(System.Double x, Unity.Mathematics.double2 yz)
  Unity.Mathematics.double3 double3(Unity.Mathematics.double2 xy, System.Double z)
  Unity.Mathematics.double3 double3(Unity.Mathematics.double3 xyz)
  Unity.Mathematics.double3 double3(System.Double v)
  Unity.Mathematics.double3 double3(System.Boolean v)
  Unity.Mathematics.double3 double3(Unity.Mathematics.bool3 v)
  Unity.Mathematics.double3 double3(System.Int32 v)
  Unity.Mathematics.double3 double3(Unity.Mathematics.int3 v)
  Unity.Mathematics.double3 double3(System.UInt32 v)
  Unity.Mathematics.double3 double3(Unity.Mathematics.uint3 v)
  Unity.Mathematics.double3 double3(Unity.Mathematics.half v)
  Unity.Mathematics.double3 double3(Unity.Mathematics.half3 v)
  Unity.Mathematics.double3 double3(System.Single v)
  Unity.Mathematics.double3 double3(Unity.Mathematics.float3 v)
  System.UInt32 hash(Unity.Mathematics.double3 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.double3 v)
  System.Double shuffle(Unity.Mathematics.double3 left, Unity.Mathematics.double3 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.double2 shuffle(Unity.Mathematics.double3 left, Unity.Mathematics.double3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.double3 shuffle(Unity.Mathematics.double3 left, Unity.Mathematics.double3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.double4 shuffle(Unity.Mathematics.double3 left, Unity.Mathematics.double3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.Double select_shuffle_component(Unity.Mathematics.double3 a, Unity.Mathematics.double3 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1)
  Unity.Mathematics.double3x2 double3x2(System.Double m00, System.Double m01, System.Double m10, System.Double m11, System.Double m20, System.Double m21)
  Unity.Mathematics.double3x2 double3x2(System.Double v)
  Unity.Mathematics.double3x2 double3x2(System.Boolean v)
  Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.bool3x2 v)
  Unity.Mathematics.double3x2 double3x2(System.Int32 v)
  Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.int3x2 v)
  Unity.Mathematics.double3x2 double3x2(System.UInt32 v)
  Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.uint3x2 v)
  Unity.Mathematics.double3x2 double3x2(System.Single v)
  Unity.Mathematics.double3x2 double3x2(Unity.Mathematics.float3x2 v)
  Unity.Mathematics.double2x3 transpose(Unity.Mathematics.double3x2 v)
  System.UInt32 hash(Unity.Mathematics.double3x2 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.double3x2 v)
  Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1, Unity.Mathematics.double3 c2)
  Unity.Mathematics.double3x3 double3x3(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12, System.Double m20, System.Double m21, System.Double m22)
  Unity.Mathematics.double3x3 double3x3(System.Double v)
  Unity.Mathematics.double3x3 double3x3(System.Boolean v)
  Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.bool3x3 v)
  Unity.Mathematics.double3x3 double3x3(System.Int32 v)
  Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.int3x3 v)
  Unity.Mathematics.double3x3 double3x3(System.UInt32 v)
  Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.uint3x3 v)
  Unity.Mathematics.double3x3 double3x3(System.Single v)
  Unity.Mathematics.double3x3 double3x3(Unity.Mathematics.float3x3 v)
  Unity.Mathematics.double3x3 transpose(Unity.Mathematics.double3x3 v)
  Unity.Mathematics.double3x3 inverse(Unity.Mathematics.double3x3 m)
  System.Double determinant(Unity.Mathematics.double3x3 m)
  System.UInt32 hash(Unity.Mathematics.double3x3 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.double3x3 v)
  Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1, Unity.Mathematics.double3 c2, Unity.Mathematics.double3 c3)
  Unity.Mathematics.double3x4 double3x4(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13, System.Double m20, System.Double m21, System.Double m22, System.Double m23)
  Unity.Mathematics.double3x4 double3x4(System.Double v)
  Unity.Mathematics.double3x4 double3x4(System.Boolean v)
  Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.bool3x4 v)
  Unity.Mathematics.double3x4 double3x4(System.Int32 v)
  Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.int3x4 v)
  Unity.Mathematics.double3x4 double3x4(System.UInt32 v)
  Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.uint3x4 v)
  Unity.Mathematics.double3x4 double3x4(System.Single v)
  Unity.Mathematics.double3x4 double3x4(Unity.Mathematics.float3x4 v)
  Unity.Mathematics.double4x3 transpose(Unity.Mathematics.double3x4 v)
  Unity.Mathematics.double3x4 fastinverse(Unity.Mathematics.double3x4 m)
  System.UInt32 hash(Unity.Mathematics.double3x4 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.double3x4 v)
  Unity.Mathematics.double4 double4(System.Double x, System.Double y, System.Double z, System.Double w)
  Unity.Mathematics.double4 double4(System.Double x, System.Double y, Unity.Mathematics.double2 zw)
  Unity.Mathematics.double4 double4(System.Double x, Unity.Mathematics.double2 yz, System.Double w)
  Unity.Mathematics.double4 double4(System.Double x, Unity.Mathematics.double3 yzw)
  Unity.Mathematics.double4 double4(Unity.Mathematics.double2 xy, System.Double z, System.Double w)
  Unity.Mathematics.double4 double4(Unity.Mathematics.double2 xy, Unity.Mathematics.double2 zw)
  Unity.Mathematics.double4 double4(Unity.Mathematics.double3 xyz, System.Double w)
  Unity.Mathematics.double4 double4(Unity.Mathematics.double4 xyzw)
  Unity.Mathematics.double4 double4(System.Double v)
  Unity.Mathematics.double4 double4(System.Boolean v)
  Unity.Mathematics.double4 double4(Unity.Mathematics.bool4 v)
  Unity.Mathematics.double4 double4(System.Int32 v)
  Unity.Mathematics.double4 double4(Unity.Mathematics.int4 v)
  Unity.Mathematics.double4 double4(System.UInt32 v)
  Unity.Mathematics.double4 double4(Unity.Mathematics.uint4 v)
  Unity.Mathematics.double4 double4(Unity.Mathematics.half v)
  Unity.Mathematics.double4 double4(Unity.Mathematics.half4 v)
  Unity.Mathematics.double4 double4(System.Single v)
  Unity.Mathematics.double4 double4(Unity.Mathematics.float4 v)
  System.UInt32 hash(Unity.Mathematics.double4 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.double4 v)
  System.Double shuffle(Unity.Mathematics.double4 left, Unity.Mathematics.double4 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.double2 shuffle(Unity.Mathematics.double4 left, Unity.Mathematics.double4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.double3 shuffle(Unity.Mathematics.double4 left, Unity.Mathematics.double4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.double4 shuffle(Unity.Mathematics.double4 left, Unity.Mathematics.double4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.Double select_shuffle_component(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1)
  Unity.Mathematics.double4x2 double4x2(System.Double m00, System.Double m01, System.Double m10, System.Double m11, System.Double m20, System.Double m21, System.Double m30, System.Double m31)
  Unity.Mathematics.double4x2 double4x2(System.Double v)
  Unity.Mathematics.double4x2 double4x2(System.Boolean v)
  Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.bool4x2 v)
  Unity.Mathematics.double4x2 double4x2(System.Int32 v)
  Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.int4x2 v)
  Unity.Mathematics.double4x2 double4x2(System.UInt32 v)
  Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.uint4x2 v)
  Unity.Mathematics.double4x2 double4x2(System.Single v)
  Unity.Mathematics.double4x2 double4x2(Unity.Mathematics.float4x2 v)
  Unity.Mathematics.double2x4 transpose(Unity.Mathematics.double4x2 v)
  System.UInt32 hash(Unity.Mathematics.double4x2 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.double4x2 v)
  Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1, Unity.Mathematics.double4 c2)
  Unity.Mathematics.double4x3 double4x3(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12, System.Double m20, System.Double m21, System.Double m22, System.Double m30, System.Double m31, System.Double m32)
  Unity.Mathematics.double4x3 double4x3(System.Double v)
  Unity.Mathematics.double4x3 double4x3(System.Boolean v)
  Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.bool4x3 v)
  Unity.Mathematics.double4x3 double4x3(System.Int32 v)
  Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.int4x3 v)
  Unity.Mathematics.double4x3 double4x3(System.UInt32 v)
  Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.uint4x3 v)
  Unity.Mathematics.double4x3 double4x3(System.Single v)
  Unity.Mathematics.double4x3 double4x3(Unity.Mathematics.float4x3 v)
  Unity.Mathematics.double3x4 transpose(Unity.Mathematics.double4x3 v)
  System.UInt32 hash(Unity.Mathematics.double4x3 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.double4x3 v)
  Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1, Unity.Mathematics.double4 c2, Unity.Mathematics.double4 c3)
  Unity.Mathematics.double4x4 double4x4(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13, System.Double m20, System.Double m21, System.Double m22, System.Double m23, System.Double m30, System.Double m31, System.Double m32, System.Double m33)
  Unity.Mathematics.double4x4 double4x4(System.Double v)
  Unity.Mathematics.double4x4 double4x4(System.Boolean v)
  Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.bool4x4 v)
  Unity.Mathematics.double4x4 double4x4(System.Int32 v)
  Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.int4x4 v)
  Unity.Mathematics.double4x4 double4x4(System.UInt32 v)
  Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.uint4x4 v)
  Unity.Mathematics.double4x4 double4x4(System.Single v)
  Unity.Mathematics.double4x4 double4x4(Unity.Mathematics.float4x4 v)
  Unity.Mathematics.double3 rotate(Unity.Mathematics.double4x4 a, Unity.Mathematics.double3 b)
  Unity.Mathematics.double3 transform(Unity.Mathematics.double4x4 a, Unity.Mathematics.double3 b)
  Unity.Mathematics.double4x4 transpose(Unity.Mathematics.double4x4 v)
  Unity.Mathematics.double4x4 inverse(Unity.Mathematics.double4x4 m)
  Unity.Mathematics.double4x4 fastinverse(Unity.Mathematics.double4x4 m)
  System.Double determinant(Unity.Mathematics.double4x4 m)
  System.UInt32 hash(Unity.Mathematics.double4x4 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.double4x4 v)
  Unity.Mathematics.float2 float2(System.Single x, System.Single y)
  Unity.Mathematics.float2 float2(Unity.Mathematics.float2 xy)
  Unity.Mathematics.float2 float2(System.Single v)
  Unity.Mathematics.float2 float2(System.Boolean v)
  Unity.Mathematics.float2 float2(Unity.Mathematics.bool2 v)
  Unity.Mathematics.float2 float2(System.Int32 v)
  Unity.Mathematics.float2 float2(Unity.Mathematics.int2 v)
  Unity.Mathematics.float2 float2(System.UInt32 v)
  Unity.Mathematics.float2 float2(Unity.Mathematics.uint2 v)
  Unity.Mathematics.float2 float2(Unity.Mathematics.half v)
  Unity.Mathematics.float2 float2(Unity.Mathematics.half2 v)
  Unity.Mathematics.float2 float2(System.Double v)
  Unity.Mathematics.float2 float2(Unity.Mathematics.double2 v)
  System.UInt32 hash(Unity.Mathematics.float2 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.float2 v)
  System.Single shuffle(Unity.Mathematics.float2 left, Unity.Mathematics.float2 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.float2 shuffle(Unity.Mathematics.float2 left, Unity.Mathematics.float2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.float3 shuffle(Unity.Mathematics.float2 left, Unity.Mathematics.float2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.float4 shuffle(Unity.Mathematics.float2 left, Unity.Mathematics.float2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.Single select_shuffle_component(Unity.Mathematics.float2 a, Unity.Mathematics.float2 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1)
  Unity.Mathematics.float2x2 float2x2(System.Single m00, System.Single m01, System.Single m10, System.Single m11)
  Unity.Mathematics.float2x2 float2x2(System.Single v)
  Unity.Mathematics.float2x2 float2x2(System.Boolean v)
  Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.bool2x2 v)
  Unity.Mathematics.float2x2 float2x2(System.Int32 v)
  Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.int2x2 v)
  Unity.Mathematics.float2x2 float2x2(System.UInt32 v)
  Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.uint2x2 v)
  Unity.Mathematics.float2x2 float2x2(System.Double v)
  Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.double2x2 v)
  Unity.Mathematics.float2x2 transpose(Unity.Mathematics.float2x2 v)
  Unity.Mathematics.float2x2 inverse(Unity.Mathematics.float2x2 m)
  System.Single determinant(Unity.Mathematics.float2x2 m)
  System.UInt32 hash(Unity.Mathematics.float2x2 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.float2x2 v)
  Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1, Unity.Mathematics.float2 c2)
  Unity.Mathematics.float2x3 float2x3(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12)
  Unity.Mathematics.float2x3 float2x3(System.Single v)
  Unity.Mathematics.float2x3 float2x3(System.Boolean v)
  Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.bool2x3 v)
  Unity.Mathematics.float2x3 float2x3(System.Int32 v)
  Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.int2x3 v)
  Unity.Mathematics.float2x3 float2x3(System.UInt32 v)
  Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.uint2x3 v)
  Unity.Mathematics.float2x3 float2x3(System.Double v)
  Unity.Mathematics.float2x3 float2x3(Unity.Mathematics.double2x3 v)
  Unity.Mathematics.float3x2 transpose(Unity.Mathematics.float2x3 v)
  System.UInt32 hash(Unity.Mathematics.float2x3 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.float2x3 v)
  Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1, Unity.Mathematics.float2 c2, Unity.Mathematics.float2 c3)
  Unity.Mathematics.float2x4 float2x4(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13)
  Unity.Mathematics.float2x4 float2x4(System.Single v)
  Unity.Mathematics.float2x4 float2x4(System.Boolean v)
  Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.bool2x4 v)
  Unity.Mathematics.float2x4 float2x4(System.Int32 v)
  Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.int2x4 v)
  Unity.Mathematics.float2x4 float2x4(System.UInt32 v)
  Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.uint2x4 v)
  Unity.Mathematics.float2x4 float2x4(System.Double v)
  Unity.Mathematics.float2x4 float2x4(Unity.Mathematics.double2x4 v)
  Unity.Mathematics.float4x2 transpose(Unity.Mathematics.float2x4 v)
  System.UInt32 hash(Unity.Mathematics.float2x4 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.float2x4 v)
  Unity.Mathematics.float3 float3(System.Single x, System.Single y, System.Single z)
  Unity.Mathematics.float3 float3(System.Single x, Unity.Mathematics.float2 yz)
  Unity.Mathematics.float3 float3(Unity.Mathematics.float2 xy, System.Single z)
  Unity.Mathematics.float3 float3(Unity.Mathematics.float3 xyz)
  Unity.Mathematics.float3 float3(System.Single v)
  Unity.Mathematics.float3 float3(System.Boolean v)
  Unity.Mathematics.float3 float3(Unity.Mathematics.bool3 v)
  Unity.Mathematics.float3 float3(System.Int32 v)
  Unity.Mathematics.float3 float3(Unity.Mathematics.int3 v)
  Unity.Mathematics.float3 float3(System.UInt32 v)
  Unity.Mathematics.float3 float3(Unity.Mathematics.uint3 v)
  Unity.Mathematics.float3 float3(Unity.Mathematics.half v)
  Unity.Mathematics.float3 float3(Unity.Mathematics.half3 v)
  Unity.Mathematics.float3 float3(System.Double v)
  Unity.Mathematics.float3 float3(Unity.Mathematics.double3 v)
  System.UInt32 hash(Unity.Mathematics.float3 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.float3 v)
  System.Single shuffle(Unity.Mathematics.float3 left, Unity.Mathematics.float3 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.float2 shuffle(Unity.Mathematics.float3 left, Unity.Mathematics.float3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.float3 shuffle(Unity.Mathematics.float3 left, Unity.Mathematics.float3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.float4 shuffle(Unity.Mathematics.float3 left, Unity.Mathematics.float3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.Single select_shuffle_component(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1)
  Unity.Mathematics.float3x2 float3x2(System.Single m00, System.Single m01, System.Single m10, System.Single m11, System.Single m20, System.Single m21)
  Unity.Mathematics.float3x2 float3x2(System.Single v)
  Unity.Mathematics.float3x2 float3x2(System.Boolean v)
  Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.bool3x2 v)
  Unity.Mathematics.float3x2 float3x2(System.Int32 v)
  Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.int3x2 v)
  Unity.Mathematics.float3x2 float3x2(System.UInt32 v)
  Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.uint3x2 v)
  Unity.Mathematics.float3x2 float3x2(System.Double v)
  Unity.Mathematics.float3x2 float3x2(Unity.Mathematics.double3x2 v)
  Unity.Mathematics.float2x3 transpose(Unity.Mathematics.float3x2 v)
  System.UInt32 hash(Unity.Mathematics.float3x2 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.float3x2 v)
  Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2)
  Unity.Mathematics.float3x3 float3x3(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12, System.Single m20, System.Single m21, System.Single m22)
  Unity.Mathematics.float3x3 float3x3(System.Single v)
  Unity.Mathematics.float3x3 float3x3(System.Boolean v)
  Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.bool3x3 v)
  Unity.Mathematics.float3x3 float3x3(System.Int32 v)
  Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.int3x3 v)
  Unity.Mathematics.float3x3 float3x3(System.UInt32 v)
  Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.uint3x3 v)
  Unity.Mathematics.float3x3 float3x3(System.Double v)
  Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.double3x3 v)
  Unity.Mathematics.float3x3 transpose(Unity.Mathematics.float3x3 v)
  Unity.Mathematics.float3x3 inverse(Unity.Mathematics.float3x3 m)
  System.Single determinant(Unity.Mathematics.float3x3 m)
  System.UInt32 hash(Unity.Mathematics.float3x3 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.float3x3 v)
  Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, Unity.Mathematics.float3 c3)
  Unity.Mathematics.float3x4 float3x4(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13, System.Single m20, System.Single m21, System.Single m22, System.Single m23)
  Unity.Mathematics.float3x4 float3x4(System.Single v)
  Unity.Mathematics.float3x4 float3x4(System.Boolean v)
  Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.bool3x4 v)
  Unity.Mathematics.float3x4 float3x4(System.Int32 v)
  Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.int3x4 v)
  Unity.Mathematics.float3x4 float3x4(System.UInt32 v)
  Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.uint3x4 v)
  Unity.Mathematics.float3x4 float3x4(System.Double v)
  Unity.Mathematics.float3x4 float3x4(Unity.Mathematics.double3x4 v)
  Unity.Mathematics.float4x3 transpose(Unity.Mathematics.float3x4 v)
  Unity.Mathematics.float3x4 fastinverse(Unity.Mathematics.float3x4 m)
  System.UInt32 hash(Unity.Mathematics.float3x4 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.float3x4 v)
  Unity.Mathematics.float4 float4(System.Single x, System.Single y, System.Single z, System.Single w)
  Unity.Mathematics.float4 float4(System.Single x, System.Single y, Unity.Mathematics.float2 zw)
  Unity.Mathematics.float4 float4(System.Single x, Unity.Mathematics.float2 yz, System.Single w)
  Unity.Mathematics.float4 float4(System.Single x, Unity.Mathematics.float3 yzw)
  Unity.Mathematics.float4 float4(Unity.Mathematics.float2 xy, System.Single z, System.Single w)
  Unity.Mathematics.float4 float4(Unity.Mathematics.float2 xy, Unity.Mathematics.float2 zw)
  Unity.Mathematics.float4 float4(Unity.Mathematics.float3 xyz, System.Single w)
  Unity.Mathematics.float4 float4(Unity.Mathematics.float4 xyzw)
  Unity.Mathematics.float4 float4(System.Single v)
  Unity.Mathematics.float4 float4(System.Boolean v)
  Unity.Mathematics.float4 float4(Unity.Mathematics.bool4 v)
  Unity.Mathematics.float4 float4(System.Int32 v)
  Unity.Mathematics.float4 float4(Unity.Mathematics.int4 v)
  Unity.Mathematics.float4 float4(System.UInt32 v)
  Unity.Mathematics.float4 float4(Unity.Mathematics.uint4 v)
  Unity.Mathematics.float4 float4(Unity.Mathematics.half v)
  Unity.Mathematics.float4 float4(Unity.Mathematics.half4 v)
  Unity.Mathematics.float4 float4(System.Double v)
  Unity.Mathematics.float4 float4(Unity.Mathematics.double4 v)
  System.UInt32 hash(Unity.Mathematics.float4 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.float4 v)
  System.Single shuffle(Unity.Mathematics.float4 left, Unity.Mathematics.float4 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.float2 shuffle(Unity.Mathematics.float4 left, Unity.Mathematics.float4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.float3 shuffle(Unity.Mathematics.float4 left, Unity.Mathematics.float4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.float4 shuffle(Unity.Mathematics.float4 left, Unity.Mathematics.float4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.Single select_shuffle_component(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1)
  Unity.Mathematics.float4x2 float4x2(System.Single m00, System.Single m01, System.Single m10, System.Single m11, System.Single m20, System.Single m21, System.Single m30, System.Single m31)
  Unity.Mathematics.float4x2 float4x2(System.Single v)
  Unity.Mathematics.float4x2 float4x2(System.Boolean v)
  Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.bool4x2 v)
  Unity.Mathematics.float4x2 float4x2(System.Int32 v)
  Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.int4x2 v)
  Unity.Mathematics.float4x2 float4x2(System.UInt32 v)
  Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.uint4x2 v)
  Unity.Mathematics.float4x2 float4x2(System.Double v)
  Unity.Mathematics.float4x2 float4x2(Unity.Mathematics.double4x2 v)
  Unity.Mathematics.float2x4 transpose(Unity.Mathematics.float4x2 v)
  System.UInt32 hash(Unity.Mathematics.float4x2 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.float4x2 v)
  Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2)
  Unity.Mathematics.float4x3 float4x3(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12, System.Single m20, System.Single m21, System.Single m22, System.Single m30, System.Single m31, System.Single m32)
  Unity.Mathematics.float4x3 float4x3(System.Single v)
  Unity.Mathematics.float4x3 float4x3(System.Boolean v)
  Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.bool4x3 v)
  Unity.Mathematics.float4x3 float4x3(System.Int32 v)
  Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.int4x3 v)
  Unity.Mathematics.float4x3 float4x3(System.UInt32 v)
  Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.uint4x3 v)
  Unity.Mathematics.float4x3 float4x3(System.Double v)
  Unity.Mathematics.float4x3 float4x3(Unity.Mathematics.double4x3 v)
  Unity.Mathematics.float3x4 transpose(Unity.Mathematics.float4x3 v)
  System.UInt32 hash(Unity.Mathematics.float4x3 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.float4x3 v)
  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2, Unity.Mathematics.float4 c3)
  Unity.Mathematics.float4x4 float4x4(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13, System.Single m20, System.Single m21, System.Single m22, System.Single m23, System.Single m30, System.Single m31, System.Single m32, System.Single m33)
  Unity.Mathematics.float4x4 float4x4(System.Single v)
  Unity.Mathematics.float4x4 float4x4(System.Boolean v)
  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.bool4x4 v)
  Unity.Mathematics.float4x4 float4x4(System.Int32 v)
  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.int4x4 v)
  Unity.Mathematics.float4x4 float4x4(System.UInt32 v)
  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.uint4x4 v)
  Unity.Mathematics.float4x4 float4x4(System.Double v)
  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.double4x4 v)
  Unity.Mathematics.float3 rotate(Unity.Mathematics.float4x4 a, Unity.Mathematics.float3 b)
  Unity.Mathematics.float3 transform(Unity.Mathematics.float4x4 a, Unity.Mathematics.float3 b)
  Unity.Mathematics.float4x4 transpose(Unity.Mathematics.float4x4 v)
  Unity.Mathematics.float4x4 inverse(Unity.Mathematics.float4x4 m)
  Unity.Mathematics.float4x4 fastinverse(Unity.Mathematics.float4x4 m)
  System.Single determinant(Unity.Mathematics.float4x4 m)
  System.UInt32 hash(Unity.Mathematics.float4x4 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.float4x4 v)
  Unity.Mathematics.half half(Unity.Mathematics.half x)
  Unity.Mathematics.half half(System.Single v)
  Unity.Mathematics.half half(System.Double v)
  System.UInt32 hash(Unity.Mathematics.half v)
  Unity.Mathematics.half2 half2(Unity.Mathematics.half x, Unity.Mathematics.half y)
  Unity.Mathematics.half2 half2(Unity.Mathematics.half2 xy)
  Unity.Mathematics.half2 half2(Unity.Mathematics.half v)
  Unity.Mathematics.half2 half2(System.Single v)
  Unity.Mathematics.half2 half2(Unity.Mathematics.float2 v)
  Unity.Mathematics.half2 half2(System.Double v)
  Unity.Mathematics.half2 half2(Unity.Mathematics.double2 v)
  System.UInt32 hash(Unity.Mathematics.half2 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.half2 v)
  Unity.Mathematics.half3 half3(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half z)
  Unity.Mathematics.half3 half3(Unity.Mathematics.half x, Unity.Mathematics.half2 yz)
  Unity.Mathematics.half3 half3(Unity.Mathematics.half2 xy, Unity.Mathematics.half z)
  Unity.Mathematics.half3 half3(Unity.Mathematics.half3 xyz)
  Unity.Mathematics.half3 half3(Unity.Mathematics.half v)
  Unity.Mathematics.half3 half3(System.Single v)
  Unity.Mathematics.half3 half3(Unity.Mathematics.float3 v)
  Unity.Mathematics.half3 half3(System.Double v)
  Unity.Mathematics.half3 half3(Unity.Mathematics.double3 v)
  System.UInt32 hash(Unity.Mathematics.half3 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.half3 v)
  Unity.Mathematics.half4 half4(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half z, Unity.Mathematics.half w)
  Unity.Mathematics.half4 half4(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half2 zw)
  Unity.Mathematics.half4 half4(Unity.Mathematics.half x, Unity.Mathematics.half2 yz, Unity.Mathematics.half w)
  Unity.Mathematics.half4 half4(Unity.Mathematics.half x, Unity.Mathematics.half3 yzw)
  Unity.Mathematics.half4 half4(Unity.Mathematics.half2 xy, Unity.Mathematics.half z, Unity.Mathematics.half w)
  Unity.Mathematics.half4 half4(Unity.Mathematics.half2 xy, Unity.Mathematics.half2 zw)
  Unity.Mathematics.half4 half4(Unity.Mathematics.half3 xyz, Unity.Mathematics.half w)
  Unity.Mathematics.half4 half4(Unity.Mathematics.half4 xyzw)
  Unity.Mathematics.half4 half4(Unity.Mathematics.half v)
  Unity.Mathematics.half4 half4(System.Single v)
  Unity.Mathematics.half4 half4(Unity.Mathematics.float4 v)
  Unity.Mathematics.half4 half4(System.Double v)
  Unity.Mathematics.half4 half4(Unity.Mathematics.double4 v)
  System.UInt32 hash(Unity.Mathematics.half4 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.half4 v)
  Unity.Mathematics.int2 int2(System.Int32 x, System.Int32 y)
  Unity.Mathematics.int2 int2(Unity.Mathematics.int2 xy)
  Unity.Mathematics.int2 int2(System.Int32 v)
  Unity.Mathematics.int2 int2(System.Boolean v)
  Unity.Mathematics.int2 int2(Unity.Mathematics.bool2 v)
  Unity.Mathematics.int2 int2(System.UInt32 v)
  Unity.Mathematics.int2 int2(Unity.Mathematics.uint2 v)
  Unity.Mathematics.int2 int2(System.Single v)
  Unity.Mathematics.int2 int2(Unity.Mathematics.float2 v)
  Unity.Mathematics.int2 int2(System.Double v)
  Unity.Mathematics.int2 int2(Unity.Mathematics.double2 v)
  System.UInt32 hash(Unity.Mathematics.int2 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.int2 v)
  System.Int32 shuffle(Unity.Mathematics.int2 left, Unity.Mathematics.int2 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.int2 shuffle(Unity.Mathematics.int2 left, Unity.Mathematics.int2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.int3 shuffle(Unity.Mathematics.int2 left, Unity.Mathematics.int2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.int4 shuffle(Unity.Mathematics.int2 left, Unity.Mathematics.int2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.Int32 select_shuffle_component(Unity.Mathematics.int2 a, Unity.Mathematics.int2 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1)
  Unity.Mathematics.int2x2 int2x2(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11)
  Unity.Mathematics.int2x2 int2x2(System.Int32 v)
  Unity.Mathematics.int2x2 int2x2(System.Boolean v)
  Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.bool2x2 v)
  Unity.Mathematics.int2x2 int2x2(System.UInt32 v)
  Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.uint2x2 v)
  Unity.Mathematics.int2x2 int2x2(System.Single v)
  Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.float2x2 v)
  Unity.Mathematics.int2x2 int2x2(System.Double v)
  Unity.Mathematics.int2x2 int2x2(Unity.Mathematics.double2x2 v)
  Unity.Mathematics.int2x2 transpose(Unity.Mathematics.int2x2 v)
  System.Int32 determinant(Unity.Mathematics.int2x2 m)
  System.UInt32 hash(Unity.Mathematics.int2x2 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.int2x2 v)
  Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1, Unity.Mathematics.int2 c2)
  Unity.Mathematics.int2x3 int2x3(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12)
  Unity.Mathematics.int2x3 int2x3(System.Int32 v)
  Unity.Mathematics.int2x3 int2x3(System.Boolean v)
  Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.bool2x3 v)
  Unity.Mathematics.int2x3 int2x3(System.UInt32 v)
  Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.uint2x3 v)
  Unity.Mathematics.int2x3 int2x3(System.Single v)
  Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.float2x3 v)
  Unity.Mathematics.int2x3 int2x3(System.Double v)
  Unity.Mathematics.int2x3 int2x3(Unity.Mathematics.double2x3 v)
  Unity.Mathematics.int3x2 transpose(Unity.Mathematics.int2x3 v)
  System.UInt32 hash(Unity.Mathematics.int2x3 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.int2x3 v)
  Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1, Unity.Mathematics.int2 c2, Unity.Mathematics.int2 c3)
  Unity.Mathematics.int2x4 int2x4(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13)
  Unity.Mathematics.int2x4 int2x4(System.Int32 v)
  Unity.Mathematics.int2x4 int2x4(System.Boolean v)
  Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.bool2x4 v)
  Unity.Mathematics.int2x4 int2x4(System.UInt32 v)
  Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.uint2x4 v)
  Unity.Mathematics.int2x4 int2x4(System.Single v)
  Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.float2x4 v)
  Unity.Mathematics.int2x4 int2x4(System.Double v)
  Unity.Mathematics.int2x4 int2x4(Unity.Mathematics.double2x4 v)
  Unity.Mathematics.int4x2 transpose(Unity.Mathematics.int2x4 v)
  System.UInt32 hash(Unity.Mathematics.int2x4 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.int2x4 v)
  Unity.Mathematics.int3 int3(System.Int32 x, System.Int32 y, System.Int32 z)
  Unity.Mathematics.int3 int3(System.Int32 x, Unity.Mathematics.int2 yz)
  Unity.Mathematics.int3 int3(Unity.Mathematics.int2 xy, System.Int32 z)
  Unity.Mathematics.int3 int3(Unity.Mathematics.int3 xyz)
  Unity.Mathematics.int3 int3(System.Int32 v)
  Unity.Mathematics.int3 int3(System.Boolean v)
  Unity.Mathematics.int3 int3(Unity.Mathematics.bool3 v)
  Unity.Mathematics.int3 int3(System.UInt32 v)
  Unity.Mathematics.int3 int3(Unity.Mathematics.uint3 v)
  Unity.Mathematics.int3 int3(System.Single v)
  Unity.Mathematics.int3 int3(Unity.Mathematics.float3 v)
  Unity.Mathematics.int3 int3(System.Double v)
  Unity.Mathematics.int3 int3(Unity.Mathematics.double3 v)
  System.UInt32 hash(Unity.Mathematics.int3 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.int3 v)
  System.Int32 shuffle(Unity.Mathematics.int3 left, Unity.Mathematics.int3 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.int2 shuffle(Unity.Mathematics.int3 left, Unity.Mathematics.int3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.int3 shuffle(Unity.Mathematics.int3 left, Unity.Mathematics.int3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.int4 shuffle(Unity.Mathematics.int3 left, Unity.Mathematics.int3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.Int32 select_shuffle_component(Unity.Mathematics.int3 a, Unity.Mathematics.int3 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1)
  Unity.Mathematics.int3x2 int3x2(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11, System.Int32 m20, System.Int32 m21)
  Unity.Mathematics.int3x2 int3x2(System.Int32 v)
  Unity.Mathematics.int3x2 int3x2(System.Boolean v)
  Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.bool3x2 v)
  Unity.Mathematics.int3x2 int3x2(System.UInt32 v)
  Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.uint3x2 v)
  Unity.Mathematics.int3x2 int3x2(System.Single v)
  Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.float3x2 v)
  Unity.Mathematics.int3x2 int3x2(System.Double v)
  Unity.Mathematics.int3x2 int3x2(Unity.Mathematics.double3x2 v)
  Unity.Mathematics.int2x3 transpose(Unity.Mathematics.int3x2 v)
  System.UInt32 hash(Unity.Mathematics.int3x2 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.int3x2 v)
  Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1, Unity.Mathematics.int3 c2)
  Unity.Mathematics.int3x3 int3x3(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m20, System.Int32 m21, System.Int32 m22)
  Unity.Mathematics.int3x3 int3x3(System.Int32 v)
  Unity.Mathematics.int3x3 int3x3(System.Boolean v)
  Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.bool3x3 v)
  Unity.Mathematics.int3x3 int3x3(System.UInt32 v)
  Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.uint3x3 v)
  Unity.Mathematics.int3x3 int3x3(System.Single v)
  Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.float3x3 v)
  Unity.Mathematics.int3x3 int3x3(System.Double v)
  Unity.Mathematics.int3x3 int3x3(Unity.Mathematics.double3x3 v)
  Unity.Mathematics.int3x3 transpose(Unity.Mathematics.int3x3 v)
  System.Int32 determinant(Unity.Mathematics.int3x3 m)
  System.UInt32 hash(Unity.Mathematics.int3x3 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.int3x3 v)
  Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1, Unity.Mathematics.int3 c2, Unity.Mathematics.int3 c3)
  Unity.Mathematics.int3x4 int3x4(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m23)
  Unity.Mathematics.int3x4 int3x4(System.Int32 v)
  Unity.Mathematics.int3x4 int3x4(System.Boolean v)
  Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.bool3x4 v)
  Unity.Mathematics.int3x4 int3x4(System.UInt32 v)
  Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.uint3x4 v)
  Unity.Mathematics.int3x4 int3x4(System.Single v)
  Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.float3x4 v)
  Unity.Mathematics.int3x4 int3x4(System.Double v)
  Unity.Mathematics.int3x4 int3x4(Unity.Mathematics.double3x4 v)
  Unity.Mathematics.int4x3 transpose(Unity.Mathematics.int3x4 v)
  System.UInt32 hash(Unity.Mathematics.int3x4 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.int3x4 v)
  Unity.Mathematics.int4 int4(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w)
  Unity.Mathematics.int4 int4(System.Int32 x, System.Int32 y, Unity.Mathematics.int2 zw)
  Unity.Mathematics.int4 int4(System.Int32 x, Unity.Mathematics.int2 yz, System.Int32 w)
  Unity.Mathematics.int4 int4(System.Int32 x, Unity.Mathematics.int3 yzw)
  Unity.Mathematics.int4 int4(Unity.Mathematics.int2 xy, System.Int32 z, System.Int32 w)
  Unity.Mathematics.int4 int4(Unity.Mathematics.int2 xy, Unity.Mathematics.int2 zw)
  Unity.Mathematics.int4 int4(Unity.Mathematics.int3 xyz, System.Int32 w)
  Unity.Mathematics.int4 int4(Unity.Mathematics.int4 xyzw)
  Unity.Mathematics.int4 int4(System.Int32 v)
  Unity.Mathematics.int4 int4(System.Boolean v)
  Unity.Mathematics.int4 int4(Unity.Mathematics.bool4 v)
  Unity.Mathematics.int4 int4(System.UInt32 v)
  Unity.Mathematics.int4 int4(Unity.Mathematics.uint4 v)
  Unity.Mathematics.int4 int4(System.Single v)
  Unity.Mathematics.int4 int4(Unity.Mathematics.float4 v)
  Unity.Mathematics.int4 int4(System.Double v)
  Unity.Mathematics.int4 int4(Unity.Mathematics.double4 v)
  System.UInt32 hash(Unity.Mathematics.int4 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.int4 v)
  System.Int32 shuffle(Unity.Mathematics.int4 left, Unity.Mathematics.int4 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.int2 shuffle(Unity.Mathematics.int4 left, Unity.Mathematics.int4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.int3 shuffle(Unity.Mathematics.int4 left, Unity.Mathematics.int4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.int4 shuffle(Unity.Mathematics.int4 left, Unity.Mathematics.int4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.Int32 select_shuffle_component(Unity.Mathematics.int4 a, Unity.Mathematics.int4 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1)
  Unity.Mathematics.int4x2 int4x2(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11, System.Int32 m20, System.Int32 m21, System.Int32 m30, System.Int32 m31)
  Unity.Mathematics.int4x2 int4x2(System.Int32 v)
  Unity.Mathematics.int4x2 int4x2(System.Boolean v)
  Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.bool4x2 v)
  Unity.Mathematics.int4x2 int4x2(System.UInt32 v)
  Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.uint4x2 v)
  Unity.Mathematics.int4x2 int4x2(System.Single v)
  Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.float4x2 v)
  Unity.Mathematics.int4x2 int4x2(System.Double v)
  Unity.Mathematics.int4x2 int4x2(Unity.Mathematics.double4x2 v)
  Unity.Mathematics.int2x4 transpose(Unity.Mathematics.int4x2 v)
  System.UInt32 hash(Unity.Mathematics.int4x2 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.int4x2 v)
  Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1, Unity.Mathematics.int4 c2)
  Unity.Mathematics.int4x3 int4x3(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m30, System.Int32 m31, System.Int32 m32)
  Unity.Mathematics.int4x3 int4x3(System.Int32 v)
  Unity.Mathematics.int4x3 int4x3(System.Boolean v)
  Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.bool4x3 v)
  Unity.Mathematics.int4x3 int4x3(System.UInt32 v)
  Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.uint4x3 v)
  Unity.Mathematics.int4x3 int4x3(System.Single v)
  Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.float4x3 v)
  Unity.Mathematics.int4x3 int4x3(System.Double v)
  Unity.Mathematics.int4x3 int4x3(Unity.Mathematics.double4x3 v)
  Unity.Mathematics.int3x4 transpose(Unity.Mathematics.int4x3 v)
  System.UInt32 hash(Unity.Mathematics.int4x3 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.int4x3 v)
  Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1, Unity.Mathematics.int4 c2, Unity.Mathematics.int4 c3)
  Unity.Mathematics.int4x4 int4x4(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m23, System.Int32 m30, System.Int32 m31, System.Int32 m32, System.Int32 m33)
  Unity.Mathematics.int4x4 int4x4(System.Int32 v)
  Unity.Mathematics.int4x4 int4x4(System.Boolean v)
  Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.bool4x4 v)
  Unity.Mathematics.int4x4 int4x4(System.UInt32 v)
  Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.uint4x4 v)
  Unity.Mathematics.int4x4 int4x4(System.Single v)
  Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.float4x4 v)
  Unity.Mathematics.int4x4 int4x4(System.Double v)
  Unity.Mathematics.int4x4 int4x4(Unity.Mathematics.double4x4 v)
  Unity.Mathematics.int4x4 transpose(Unity.Mathematics.int4x4 v)
  System.Int32 determinant(Unity.Mathematics.int4x4 m)
  System.UInt32 hash(Unity.Mathematics.int4x4 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.int4x4 v)
  System.Int32 asint(System.UInt32 x)
  Unity.Mathematics.int2 asint(Unity.Mathematics.uint2 x)
  Unity.Mathematics.int3 asint(Unity.Mathematics.uint3 x)
  Unity.Mathematics.int4 asint(Unity.Mathematics.uint4 x)
  System.Int32 asint(System.Single x)
  Unity.Mathematics.int2 asint(Unity.Mathematics.float2 x)
  Unity.Mathematics.int3 asint(Unity.Mathematics.float3 x)
  Unity.Mathematics.int4 asint(Unity.Mathematics.float4 x)
  System.UInt32 asuint(System.Int32 x)
  Unity.Mathematics.uint2 asuint(Unity.Mathematics.int2 x)
  Unity.Mathematics.uint3 asuint(Unity.Mathematics.int3 x)
  Unity.Mathematics.uint4 asuint(Unity.Mathematics.int4 x)
  System.UInt32 asuint(System.Single x)
  Unity.Mathematics.uint2 asuint(Unity.Mathematics.float2 x)
  Unity.Mathematics.uint3 asuint(Unity.Mathematics.float3 x)
  Unity.Mathematics.uint4 asuint(Unity.Mathematics.float4 x)
  System.Int64 aslong(System.UInt64 x)
  System.Int64 aslong(System.Double x)
  System.UInt64 asulong(System.Int64 x)
  System.UInt64 asulong(System.Double x)
  System.Single asfloat(System.Int32 x)
  Unity.Mathematics.float2 asfloat(Unity.Mathematics.int2 x)
  Unity.Mathematics.float3 asfloat(Unity.Mathematics.int3 x)
  Unity.Mathematics.float4 asfloat(Unity.Mathematics.int4 x)
  System.Single asfloat(System.UInt32 x)
  Unity.Mathematics.float2 asfloat(Unity.Mathematics.uint2 x)
  Unity.Mathematics.float3 asfloat(Unity.Mathematics.uint3 x)
  Unity.Mathematics.float4 asfloat(Unity.Mathematics.uint4 x)
  System.Int32 bitmask(Unity.Mathematics.bool4 value)
  System.Double asdouble(System.Int64 x)
  System.Double asdouble(System.UInt64 x)
  System.Boolean isfinite(System.Single x)
  Unity.Mathematics.bool2 isfinite(Unity.Mathematics.float2 x)
  Unity.Mathematics.bool3 isfinite(Unity.Mathematics.float3 x)
  Unity.Mathematics.bool4 isfinite(Unity.Mathematics.float4 x)
  System.Boolean isfinite(System.Double x)
  Unity.Mathematics.bool2 isfinite(Unity.Mathematics.double2 x)
  Unity.Mathematics.bool3 isfinite(Unity.Mathematics.double3 x)
  Unity.Mathematics.bool4 isfinite(Unity.Mathematics.double4 x)
  System.Boolean isinf(System.Single x)
  Unity.Mathematics.bool2 isinf(Unity.Mathematics.float2 x)
  Unity.Mathematics.bool3 isinf(Unity.Mathematics.float3 x)
  Unity.Mathematics.bool4 isinf(Unity.Mathematics.float4 x)
  System.Boolean isinf(System.Double x)
  Unity.Mathematics.bool2 isinf(Unity.Mathematics.double2 x)
  Unity.Mathematics.bool3 isinf(Unity.Mathematics.double3 x)
  Unity.Mathematics.bool4 isinf(Unity.Mathematics.double4 x)
  System.Boolean isnan(System.Single x)
  Unity.Mathematics.bool2 isnan(Unity.Mathematics.float2 x)
  Unity.Mathematics.bool3 isnan(Unity.Mathematics.float3 x)
  Unity.Mathematics.bool4 isnan(Unity.Mathematics.float4 x)
  System.Boolean isnan(System.Double x)
  Unity.Mathematics.bool2 isnan(Unity.Mathematics.double2 x)
  Unity.Mathematics.bool3 isnan(Unity.Mathematics.double3 x)
  Unity.Mathematics.bool4 isnan(Unity.Mathematics.double4 x)
  System.Boolean ispow2(System.Int32 x)
  Unity.Mathematics.bool2 ispow2(Unity.Mathematics.int2 x)
  Unity.Mathematics.bool3 ispow2(Unity.Mathematics.int3 x)
  Unity.Mathematics.bool4 ispow2(Unity.Mathematics.int4 x)
  System.Boolean ispow2(System.UInt32 x)
  Unity.Mathematics.bool2 ispow2(Unity.Mathematics.uint2 x)
  Unity.Mathematics.bool3 ispow2(Unity.Mathematics.uint3 x)
  Unity.Mathematics.bool4 ispow2(Unity.Mathematics.uint4 x)
  System.Int32 min(System.Int32 x, System.Int32 y)
  Unity.Mathematics.int2 min(Unity.Mathematics.int2 x, Unity.Mathematics.int2 y)
  Unity.Mathematics.int3 min(Unity.Mathematics.int3 x, Unity.Mathematics.int3 y)
  Unity.Mathematics.int4 min(Unity.Mathematics.int4 x, Unity.Mathematics.int4 y)
  System.UInt32 min(System.UInt32 x, System.UInt32 y)
  Unity.Mathematics.uint2 min(Unity.Mathematics.uint2 x, Unity.Mathematics.uint2 y)
  Unity.Mathematics.uint3 min(Unity.Mathematics.uint3 x, Unity.Mathematics.uint3 y)
  Unity.Mathematics.uint4 min(Unity.Mathematics.uint4 x, Unity.Mathematics.uint4 y)
  System.Int64 min(System.Int64 x, System.Int64 y)
  System.UInt64 min(System.UInt64 x, System.UInt64 y)
  System.Single min(System.Single x, System.Single y)
  Unity.Mathematics.float2 min(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  Unity.Mathematics.float3 min(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  Unity.Mathematics.float4 min(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  System.Double min(System.Double x, System.Double y)
  Unity.Mathematics.double2 min(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y)
  Unity.Mathematics.double3 min(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  Unity.Mathematics.double4 min(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y)
  System.Int32 max(System.Int32 x, System.Int32 y)
  Unity.Mathematics.int2 max(Unity.Mathematics.int2 x, Unity.Mathematics.int2 y)
  Unity.Mathematics.int3 max(Unity.Mathematics.int3 x, Unity.Mathematics.int3 y)
  Unity.Mathematics.int4 max(Unity.Mathematics.int4 x, Unity.Mathematics.int4 y)
  System.UInt32 max(System.UInt32 x, System.UInt32 y)
  Unity.Mathematics.uint2 max(Unity.Mathematics.uint2 x, Unity.Mathematics.uint2 y)
  Unity.Mathematics.uint3 max(Unity.Mathematics.uint3 x, Unity.Mathematics.uint3 y)
  Unity.Mathematics.uint4 max(Unity.Mathematics.uint4 x, Unity.Mathematics.uint4 y)
  System.Int64 max(System.Int64 x, System.Int64 y)
  System.UInt64 max(System.UInt64 x, System.UInt64 y)
  System.Single max(System.Single x, System.Single y)
  Unity.Mathematics.float2 max(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  Unity.Mathematics.float3 max(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  Unity.Mathematics.float4 max(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  System.Double max(System.Double x, System.Double y)
  Unity.Mathematics.double2 max(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y)
  Unity.Mathematics.double3 max(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  Unity.Mathematics.double4 max(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y)
  System.Single lerp(System.Single start, System.Single end, System.Single t)
  Unity.Mathematics.float2 lerp(Unity.Mathematics.float2 start, Unity.Mathematics.float2 end, System.Single t)
  Unity.Mathematics.float3 lerp(Unity.Mathematics.float3 start, Unity.Mathematics.float3 end, System.Single t)
  Unity.Mathematics.float4 lerp(Unity.Mathematics.float4 start, Unity.Mathematics.float4 end, System.Single t)
  Unity.Mathematics.float2 lerp(Unity.Mathematics.float2 start, Unity.Mathematics.float2 end, Unity.Mathematics.float2 t)
  Unity.Mathematics.float3 lerp(Unity.Mathematics.float3 start, Unity.Mathematics.float3 end, Unity.Mathematics.float3 t)
  Unity.Mathematics.float4 lerp(Unity.Mathematics.float4 start, Unity.Mathematics.float4 end, Unity.Mathematics.float4 t)
  System.Double lerp(System.Double start, System.Double end, System.Double t)
  Unity.Mathematics.double2 lerp(Unity.Mathematics.double2 start, Unity.Mathematics.double2 end, System.Double t)
  Unity.Mathematics.double3 lerp(Unity.Mathematics.double3 start, Unity.Mathematics.double3 end, System.Double t)
  Unity.Mathematics.double4 lerp(Unity.Mathematics.double4 start, Unity.Mathematics.double4 end, System.Double t)
  Unity.Mathematics.double2 lerp(Unity.Mathematics.double2 start, Unity.Mathematics.double2 end, Unity.Mathematics.double2 t)
  Unity.Mathematics.double3 lerp(Unity.Mathematics.double3 start, Unity.Mathematics.double3 end, Unity.Mathematics.double3 t)
  Unity.Mathematics.double4 lerp(Unity.Mathematics.double4 start, Unity.Mathematics.double4 end, Unity.Mathematics.double4 t)
  System.Single unlerp(System.Single start, System.Single end, System.Single x)
  Unity.Mathematics.float2 unlerp(Unity.Mathematics.float2 start, Unity.Mathematics.float2 end, Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 unlerp(Unity.Mathematics.float3 start, Unity.Mathematics.float3 end, Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 unlerp(Unity.Mathematics.float4 start, Unity.Mathematics.float4 end, Unity.Mathematics.float4 x)
  System.Double unlerp(System.Double start, System.Double end, System.Double x)
  Unity.Mathematics.double2 unlerp(Unity.Mathematics.double2 start, Unity.Mathematics.double2 end, Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 unlerp(Unity.Mathematics.double3 start, Unity.Mathematics.double3 end, Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 unlerp(Unity.Mathematics.double4 start, Unity.Mathematics.double4 end, Unity.Mathematics.double4 x)
  System.Single remap(System.Single srcStart, System.Single srcEnd, System.Single dstStart, System.Single dstEnd, System.Single x)
  Unity.Mathematics.float2 remap(Unity.Mathematics.float2 srcStart, Unity.Mathematics.float2 srcEnd, Unity.Mathematics.float2 dstStart, Unity.Mathematics.float2 dstEnd, Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 remap(Unity.Mathematics.float3 srcStart, Unity.Mathematics.float3 srcEnd, Unity.Mathematics.float3 dstStart, Unity.Mathematics.float3 dstEnd, Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 remap(Unity.Mathematics.float4 srcStart, Unity.Mathematics.float4 srcEnd, Unity.Mathematics.float4 dstStart, Unity.Mathematics.float4 dstEnd, Unity.Mathematics.float4 x)
  System.Double remap(System.Double srcStart, System.Double srcEnd, System.Double dstStart, System.Double dstEnd, System.Double x)
  Unity.Mathematics.double2 remap(Unity.Mathematics.double2 srcStart, Unity.Mathematics.double2 srcEnd, Unity.Mathematics.double2 dstStart, Unity.Mathematics.double2 dstEnd, Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 remap(Unity.Mathematics.double3 srcStart, Unity.Mathematics.double3 srcEnd, Unity.Mathematics.double3 dstStart, Unity.Mathematics.double3 dstEnd, Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 remap(Unity.Mathematics.double4 srcStart, Unity.Mathematics.double4 srcEnd, Unity.Mathematics.double4 dstStart, Unity.Mathematics.double4 dstEnd, Unity.Mathematics.double4 x)
  System.Int32 mad(System.Int32 mulA, System.Int32 mulB, System.Int32 addC)
  Unity.Mathematics.int2 mad(Unity.Mathematics.int2 mulA, Unity.Mathematics.int2 mulB, Unity.Mathematics.int2 addC)
  Unity.Mathematics.int3 mad(Unity.Mathematics.int3 mulA, Unity.Mathematics.int3 mulB, Unity.Mathematics.int3 addC)
  Unity.Mathematics.int4 mad(Unity.Mathematics.int4 mulA, Unity.Mathematics.int4 mulB, Unity.Mathematics.int4 addC)
  System.UInt32 mad(System.UInt32 mulA, System.UInt32 mulB, System.UInt32 addC)
  Unity.Mathematics.uint2 mad(Unity.Mathematics.uint2 mulA, Unity.Mathematics.uint2 mulB, Unity.Mathematics.uint2 addC)
  Unity.Mathematics.uint3 mad(Unity.Mathematics.uint3 mulA, Unity.Mathematics.uint3 mulB, Unity.Mathematics.uint3 addC)
  Unity.Mathematics.uint4 mad(Unity.Mathematics.uint4 mulA, Unity.Mathematics.uint4 mulB, Unity.Mathematics.uint4 addC)
  System.Int64 mad(System.Int64 mulA, System.Int64 mulB, System.Int64 addC)
  System.UInt64 mad(System.UInt64 mulA, System.UInt64 mulB, System.UInt64 addC)
  System.Single mad(System.Single mulA, System.Single mulB, System.Single addC)
  Unity.Mathematics.float2 mad(Unity.Mathematics.float2 mulA, Unity.Mathematics.float2 mulB, Unity.Mathematics.float2 addC)
  Unity.Mathematics.float3 mad(Unity.Mathematics.float3 mulA, Unity.Mathematics.float3 mulB, Unity.Mathematics.float3 addC)
  Unity.Mathematics.float4 mad(Unity.Mathematics.float4 mulA, Unity.Mathematics.float4 mulB, Unity.Mathematics.float4 addC)
  System.Double mad(System.Double mulA, System.Double mulB, System.Double addC)
  Unity.Mathematics.double2 mad(Unity.Mathematics.double2 mulA, Unity.Mathematics.double2 mulB, Unity.Mathematics.double2 addC)
  Unity.Mathematics.double3 mad(Unity.Mathematics.double3 mulA, Unity.Mathematics.double3 mulB, Unity.Mathematics.double3 addC)
  Unity.Mathematics.double4 mad(Unity.Mathematics.double4 mulA, Unity.Mathematics.double4 mulB, Unity.Mathematics.double4 addC)
  System.Int32 clamp(System.Int32 valueToClamp, System.Int32 lowerBound, System.Int32 upperBound)
  Unity.Mathematics.int2 clamp(Unity.Mathematics.int2 valueToClamp, Unity.Mathematics.int2 lowerBound, Unity.Mathematics.int2 upperBound)
  Unity.Mathematics.int3 clamp(Unity.Mathematics.int3 valueToClamp, Unity.Mathematics.int3 lowerBound, Unity.Mathematics.int3 upperBound)
  Unity.Mathematics.int4 clamp(Unity.Mathematics.int4 valueToClamp, Unity.Mathematics.int4 lowerBound, Unity.Mathematics.int4 upperBound)
  System.UInt32 clamp(System.UInt32 valueToClamp, System.UInt32 lowerBound, System.UInt32 upperBound)
  Unity.Mathematics.uint2 clamp(Unity.Mathematics.uint2 valueToClamp, Unity.Mathematics.uint2 lowerBound, Unity.Mathematics.uint2 upperBound)
  Unity.Mathematics.uint3 clamp(Unity.Mathematics.uint3 valueToClamp, Unity.Mathematics.uint3 lowerBound, Unity.Mathematics.uint3 upperBound)
  Unity.Mathematics.uint4 clamp(Unity.Mathematics.uint4 valueToClamp, Unity.Mathematics.uint4 lowerBound, Unity.Mathematics.uint4 upperBound)
  System.Int64 clamp(System.Int64 valueToClamp, System.Int64 lowerBound, System.Int64 upperBound)
  System.UInt64 clamp(System.UInt64 valueToClamp, System.UInt64 lowerBound, System.UInt64 upperBound)
  System.Single clamp(System.Single valueToClamp, System.Single lowerBound, System.Single upperBound)
  Unity.Mathematics.float2 clamp(Unity.Mathematics.float2 valueToClamp, Unity.Mathematics.float2 lowerBound, Unity.Mathematics.float2 upperBound)
  Unity.Mathematics.float3 clamp(Unity.Mathematics.float3 valueToClamp, Unity.Mathematics.float3 lowerBound, Unity.Mathematics.float3 upperBound)
  Unity.Mathematics.float4 clamp(Unity.Mathematics.float4 valueToClamp, Unity.Mathematics.float4 lowerBound, Unity.Mathematics.float4 upperBound)
  System.Double clamp(System.Double valueToClamp, System.Double lowerBound, System.Double upperBound)
  Unity.Mathematics.double2 clamp(Unity.Mathematics.double2 valueToClamp, Unity.Mathematics.double2 lowerBound, Unity.Mathematics.double2 upperBound)
  Unity.Mathematics.double3 clamp(Unity.Mathematics.double3 valueToClamp, Unity.Mathematics.double3 lowerBound, Unity.Mathematics.double3 upperBound)
  Unity.Mathematics.double4 clamp(Unity.Mathematics.double4 valueToClamp, Unity.Mathematics.double4 lowerBound, Unity.Mathematics.double4 upperBound)
  System.Single saturate(System.Single x)
  Unity.Mathematics.float2 saturate(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 saturate(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 saturate(Unity.Mathematics.float4 x)
  System.Double saturate(System.Double x)
  Unity.Mathematics.double2 saturate(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 saturate(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 saturate(Unity.Mathematics.double4 x)
  System.Int32 abs(System.Int32 x)
  Unity.Mathematics.int2 abs(Unity.Mathematics.int2 x)
  Unity.Mathematics.int3 abs(Unity.Mathematics.int3 x)
  Unity.Mathematics.int4 abs(Unity.Mathematics.int4 x)
  System.Int64 abs(System.Int64 x)
  System.Single abs(System.Single x)
  Unity.Mathematics.float2 abs(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 abs(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 abs(Unity.Mathematics.float4 x)
  System.Double abs(System.Double x)
  Unity.Mathematics.double2 abs(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 abs(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 abs(Unity.Mathematics.double4 x)
  System.Int32 dot(System.Int32 x, System.Int32 y)
  System.Int32 dot(Unity.Mathematics.int2 x, Unity.Mathematics.int2 y)
  System.Int32 dot(Unity.Mathematics.int3 x, Unity.Mathematics.int3 y)
  System.Int32 dot(Unity.Mathematics.int4 x, Unity.Mathematics.int4 y)
  System.UInt32 dot(System.UInt32 x, System.UInt32 y)
  System.UInt32 dot(Unity.Mathematics.uint2 x, Unity.Mathematics.uint2 y)
  System.UInt32 dot(Unity.Mathematics.uint3 x, Unity.Mathematics.uint3 y)
  System.UInt32 dot(Unity.Mathematics.uint4 x, Unity.Mathematics.uint4 y)
  System.Single dot(System.Single x, System.Single y)
  System.Single dot(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  System.Single dot(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  System.Single dot(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  System.Double dot(System.Double x, System.Double y)
  System.Double dot(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y)
  System.Double dot(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  System.Double dot(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y)
  System.Single tan(System.Single x)
  Unity.Mathematics.float2 tan(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 tan(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 tan(Unity.Mathematics.float4 x)
  System.Double tan(System.Double x)
  Unity.Mathematics.double2 tan(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 tan(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 tan(Unity.Mathematics.double4 x)
  System.Single tanh(System.Single x)
  Unity.Mathematics.float2 tanh(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 tanh(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 tanh(Unity.Mathematics.float4 x)
  System.Double tanh(System.Double x)
  Unity.Mathematics.double2 tanh(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 tanh(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 tanh(Unity.Mathematics.double4 x)
  System.Single atan(System.Single x)
  Unity.Mathematics.float2 atan(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 atan(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 atan(Unity.Mathematics.float4 x)
  System.Double atan(System.Double x)
  Unity.Mathematics.double2 atan(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 atan(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 atan(Unity.Mathematics.double4 x)
  System.Single atan2(System.Single y, System.Single x)
  Unity.Mathematics.float2 atan2(Unity.Mathematics.float2 y, Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 atan2(Unity.Mathematics.float3 y, Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 atan2(Unity.Mathematics.float4 y, Unity.Mathematics.float4 x)
  System.Double atan2(System.Double y, System.Double x)
  Unity.Mathematics.double2 atan2(Unity.Mathematics.double2 y, Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 atan2(Unity.Mathematics.double3 y, Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 atan2(Unity.Mathematics.double4 y, Unity.Mathematics.double4 x)
  System.Single cos(System.Single x)
  Unity.Mathematics.float2 cos(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 cos(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 cos(Unity.Mathematics.float4 x)
  System.Double cos(System.Double x)
  Unity.Mathematics.double2 cos(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 cos(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 cos(Unity.Mathematics.double4 x)
  System.Single cosh(System.Single x)
  Unity.Mathematics.float2 cosh(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 cosh(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 cosh(Unity.Mathematics.float4 x)
  System.Double cosh(System.Double x)
  Unity.Mathematics.double2 cosh(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 cosh(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 cosh(Unity.Mathematics.double4 x)
  System.Single acos(System.Single x)
  Unity.Mathematics.float2 acos(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 acos(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 acos(Unity.Mathematics.float4 x)
  System.Double acos(System.Double x)
  Unity.Mathematics.double2 acos(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 acos(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 acos(Unity.Mathematics.double4 x)
  System.Single sin(System.Single x)
  Unity.Mathematics.float2 sin(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 sin(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 sin(Unity.Mathematics.float4 x)
  System.Double sin(System.Double x)
  Unity.Mathematics.double2 sin(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 sin(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 sin(Unity.Mathematics.double4 x)
  System.Single sinh(System.Single x)
  Unity.Mathematics.float2 sinh(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 sinh(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 sinh(Unity.Mathematics.float4 x)
  System.Double sinh(System.Double x)
  Unity.Mathematics.double2 sinh(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 sinh(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 sinh(Unity.Mathematics.double4 x)
  System.Single asin(System.Single x)
  Unity.Mathematics.float2 asin(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 asin(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 asin(Unity.Mathematics.float4 x)
  System.Double asin(System.Double x)
  Unity.Mathematics.double2 asin(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 asin(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 asin(Unity.Mathematics.double4 x)
  System.Single floor(System.Single x)
  Unity.Mathematics.float2 floor(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 floor(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 floor(Unity.Mathematics.float4 x)
  System.Double floor(System.Double x)
  Unity.Mathematics.double2 floor(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 floor(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 floor(Unity.Mathematics.double4 x)
  System.Single ceil(System.Single x)
  Unity.Mathematics.float2 ceil(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 ceil(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 ceil(Unity.Mathematics.float4 x)
  System.Double ceil(System.Double x)
  Unity.Mathematics.double2 ceil(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 ceil(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 ceil(Unity.Mathematics.double4 x)
  System.Single round(System.Single x)
  Unity.Mathematics.float2 round(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 round(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 round(Unity.Mathematics.float4 x)
  System.Double round(System.Double x)
  Unity.Mathematics.double2 round(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 round(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 round(Unity.Mathematics.double4 x)
  System.Single trunc(System.Single x)
  Unity.Mathematics.float2 trunc(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 trunc(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 trunc(Unity.Mathematics.float4 x)
  System.Double trunc(System.Double x)
  Unity.Mathematics.double2 trunc(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 trunc(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 trunc(Unity.Mathematics.double4 x)
  System.Single frac(System.Single x)
  Unity.Mathematics.float2 frac(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 frac(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 frac(Unity.Mathematics.float4 x)
  System.Double frac(System.Double x)
  Unity.Mathematics.double2 frac(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 frac(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 frac(Unity.Mathematics.double4 x)
  System.Single rcp(System.Single x)
  Unity.Mathematics.float2 rcp(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 rcp(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 rcp(Unity.Mathematics.float4 x)
  System.Double rcp(System.Double x)
  Unity.Mathematics.double2 rcp(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 rcp(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 rcp(Unity.Mathematics.double4 x)
  System.Int32 sign(System.Int32 x)
  Unity.Mathematics.int2 sign(Unity.Mathematics.int2 x)
  Unity.Mathematics.int3 sign(Unity.Mathematics.int3 x)
  Unity.Mathematics.int4 sign(Unity.Mathematics.int4 x)
  System.Single sign(System.Single x)
  Unity.Mathematics.float2 sign(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 sign(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 sign(Unity.Mathematics.float4 x)
  System.Double sign(System.Double x)
  Unity.Mathematics.double2 sign(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 sign(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 sign(Unity.Mathematics.double4 x)
  System.Single pow(System.Single x, System.Single y)
  Unity.Mathematics.float2 pow(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  Unity.Mathematics.float3 pow(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  Unity.Mathematics.float4 pow(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  System.Double pow(System.Double x, System.Double y)
  Unity.Mathematics.double2 pow(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y)
  Unity.Mathematics.double3 pow(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  Unity.Mathematics.double4 pow(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y)
  System.Single exp(System.Single x)
  Unity.Mathematics.float2 exp(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 exp(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 exp(Unity.Mathematics.float4 x)
  System.Double exp(System.Double x)
  Unity.Mathematics.double2 exp(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 exp(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 exp(Unity.Mathematics.double4 x)
  System.Single exp2(System.Single x)
  Unity.Mathematics.float2 exp2(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 exp2(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 exp2(Unity.Mathematics.float4 x)
  System.Double exp2(System.Double x)
  Unity.Mathematics.double2 exp2(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 exp2(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 exp2(Unity.Mathematics.double4 x)
  System.Single exp10(System.Single x)
  Unity.Mathematics.float2 exp10(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 exp10(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 exp10(Unity.Mathematics.float4 x)
  System.Double exp10(System.Double x)
  Unity.Mathematics.double2 exp10(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 exp10(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 exp10(Unity.Mathematics.double4 x)
  System.Single log(System.Single x)
  Unity.Mathematics.float2 log(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 log(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 log(Unity.Mathematics.float4 x)
  System.Double log(System.Double x)
  Unity.Mathematics.double2 log(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 log(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 log(Unity.Mathematics.double4 x)
  System.Single log2(System.Single x)
  Unity.Mathematics.float2 log2(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 log2(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 log2(Unity.Mathematics.float4 x)
  System.Double log2(System.Double x)
  Unity.Mathematics.double2 log2(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 log2(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 log2(Unity.Mathematics.double4 x)
  System.Single log10(System.Single x)
  Unity.Mathematics.float2 log10(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 log10(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 log10(Unity.Mathematics.float4 x)
  System.Double log10(System.Double x)
  Unity.Mathematics.double2 log10(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 log10(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 log10(Unity.Mathematics.double4 x)
  System.Single fmod(System.Single x, System.Single y)
  Unity.Mathematics.float2 fmod(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  Unity.Mathematics.float3 fmod(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  Unity.Mathematics.float4 fmod(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  System.Double fmod(System.Double x, System.Double y)
  Unity.Mathematics.double2 fmod(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y)
  Unity.Mathematics.double3 fmod(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  Unity.Mathematics.double4 fmod(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y)
  System.Single modf(System.Single x, System.Single& i)
  Unity.Mathematics.float2 modf(Unity.Mathematics.float2 x, Unity.Mathematics.float2& i)
  Unity.Mathematics.float3 modf(Unity.Mathematics.float3 x, Unity.Mathematics.float3& i)
  Unity.Mathematics.float4 modf(Unity.Mathematics.float4 x, Unity.Mathematics.float4& i)
  System.Double modf(System.Double x, System.Double& i)
  Unity.Mathematics.double2 modf(Unity.Mathematics.double2 x, Unity.Mathematics.double2& i)
  Unity.Mathematics.double3 modf(Unity.Mathematics.double3 x, Unity.Mathematics.double3& i)
  Unity.Mathematics.double4 modf(Unity.Mathematics.double4 x, Unity.Mathematics.double4& i)
  System.Single sqrt(System.Single x)
  Unity.Mathematics.float2 sqrt(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 sqrt(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 sqrt(Unity.Mathematics.float4 x)
  System.Double sqrt(System.Double x)
  Unity.Mathematics.double2 sqrt(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 sqrt(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 sqrt(Unity.Mathematics.double4 x)
  System.Single rsqrt(System.Single x)
  Unity.Mathematics.float2 rsqrt(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 rsqrt(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 rsqrt(Unity.Mathematics.float4 x)
  System.Double rsqrt(System.Double x)
  Unity.Mathematics.double2 rsqrt(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 rsqrt(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 rsqrt(Unity.Mathematics.double4 x)
  Unity.Mathematics.float2 normalize(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 normalize(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 normalize(Unity.Mathematics.float4 x)
  Unity.Mathematics.double2 normalize(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 normalize(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 normalize(Unity.Mathematics.double4 x)
  Unity.Mathematics.float2 normalizesafe(Unity.Mathematics.float2 x, Unity.Mathematics.float2 defaultvalue)
  Unity.Mathematics.float3 normalizesafe(Unity.Mathematics.float3 x, Unity.Mathematics.float3 defaultvalue)
  Unity.Mathematics.float4 normalizesafe(Unity.Mathematics.float4 x, Unity.Mathematics.float4 defaultvalue)
  Unity.Mathematics.double2 normalizesafe(Unity.Mathematics.double2 x, Unity.Mathematics.double2 defaultvalue)
  Unity.Mathematics.double3 normalizesafe(Unity.Mathematics.double3 x, Unity.Mathematics.double3 defaultvalue)
  Unity.Mathematics.double4 normalizesafe(Unity.Mathematics.double4 x, Unity.Mathematics.double4 defaultvalue)
  System.Single length(System.Single x)
  System.Single length(Unity.Mathematics.float2 x)
  System.Single length(Unity.Mathematics.float3 x)
  System.Single length(Unity.Mathematics.float4 x)
  System.Double length(System.Double x)
  System.Double length(Unity.Mathematics.double2 x)
  System.Double length(Unity.Mathematics.double3 x)
  System.Double length(Unity.Mathematics.double4 x)
  System.Single lengthsq(System.Single x)
  System.Single lengthsq(Unity.Mathematics.float2 x)
  System.Single lengthsq(Unity.Mathematics.float3 x)
  System.Single lengthsq(Unity.Mathematics.float4 x)
  System.Double lengthsq(System.Double x)
  System.Double lengthsq(Unity.Mathematics.double2 x)
  System.Double lengthsq(Unity.Mathematics.double3 x)
  System.Double lengthsq(Unity.Mathematics.double4 x)
  System.Single distance(System.Single x, System.Single y)
  System.Single distance(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  System.Single distance(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  System.Single distance(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  System.Double distance(System.Double x, System.Double y)
  System.Double distance(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y)
  System.Double distance(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  System.Double distance(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y)
  System.Single distancesq(System.Single x, System.Single y)
  System.Single distancesq(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  System.Single distancesq(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  System.Single distancesq(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  System.Double distancesq(System.Double x, System.Double y)
  System.Double distancesq(Unity.Mathematics.double2 x, Unity.Mathematics.double2 y)
  System.Double distancesq(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  System.Double distancesq(Unity.Mathematics.double4 x, Unity.Mathematics.double4 y)
  Unity.Mathematics.float3 cross(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  Unity.Mathematics.double3 cross(Unity.Mathematics.double3 x, Unity.Mathematics.double3 y)
  System.Single smoothstep(System.Single xMin, System.Single xMax, System.Single x)
  Unity.Mathematics.float2 smoothstep(Unity.Mathematics.float2 xMin, Unity.Mathematics.float2 xMax, Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 smoothstep(Unity.Mathematics.float3 xMin, Unity.Mathematics.float3 xMax, Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 smoothstep(Unity.Mathematics.float4 xMin, Unity.Mathematics.float4 xMax, Unity.Mathematics.float4 x)
  System.Double smoothstep(System.Double xMin, System.Double xMax, System.Double x)
  Unity.Mathematics.double2 smoothstep(Unity.Mathematics.double2 xMin, Unity.Mathematics.double2 xMax, Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 smoothstep(Unity.Mathematics.double3 xMin, Unity.Mathematics.double3 xMax, Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 smoothstep(Unity.Mathematics.double4 xMin, Unity.Mathematics.double4 xMax, Unity.Mathematics.double4 x)
  System.Boolean any(Unity.Mathematics.bool2 x)
  System.Boolean any(Unity.Mathematics.bool3 x)
  System.Boolean any(Unity.Mathematics.bool4 x)
  System.Boolean any(Unity.Mathematics.int2 x)
  System.Boolean any(Unity.Mathematics.int3 x)
  System.Boolean any(Unity.Mathematics.int4 x)
  System.Boolean any(Unity.Mathematics.uint2 x)
  System.Boolean any(Unity.Mathematics.uint3 x)
  System.Boolean any(Unity.Mathematics.uint4 x)
  System.Boolean any(Unity.Mathematics.float2 x)
  System.Boolean any(Unity.Mathematics.float3 x)
  System.Boolean any(Unity.Mathematics.float4 x)
  System.Boolean any(Unity.Mathematics.double2 x)
  System.Boolean any(Unity.Mathematics.double3 x)
  System.Boolean any(Unity.Mathematics.double4 x)
  System.Boolean all(Unity.Mathematics.bool2 x)
  System.Boolean all(Unity.Mathematics.bool3 x)
  System.Boolean all(Unity.Mathematics.bool4 x)
  System.Boolean all(Unity.Mathematics.int2 x)
  System.Boolean all(Unity.Mathematics.int3 x)
  System.Boolean all(Unity.Mathematics.int4 x)
  System.Boolean all(Unity.Mathematics.uint2 x)
  System.Boolean all(Unity.Mathematics.uint3 x)
  System.Boolean all(Unity.Mathematics.uint4 x)
  System.Boolean all(Unity.Mathematics.float2 x)
  System.Boolean all(Unity.Mathematics.float3 x)
  System.Boolean all(Unity.Mathematics.float4 x)
  System.Boolean all(Unity.Mathematics.double2 x)
  System.Boolean all(Unity.Mathematics.double3 x)
  System.Boolean all(Unity.Mathematics.double4 x)
  System.Int32 select(System.Int32 falseValue, System.Int32 trueValue, System.Boolean test)
  Unity.Mathematics.int2 select(Unity.Mathematics.int2 falseValue, Unity.Mathematics.int2 trueValue, System.Boolean test)
  Unity.Mathematics.int3 select(Unity.Mathematics.int3 falseValue, Unity.Mathematics.int3 trueValue, System.Boolean test)
  Unity.Mathematics.int4 select(Unity.Mathematics.int4 falseValue, Unity.Mathematics.int4 trueValue, System.Boolean test)
  Unity.Mathematics.int2 select(Unity.Mathematics.int2 falseValue, Unity.Mathematics.int2 trueValue, Unity.Mathematics.bool2 test)
  Unity.Mathematics.int3 select(Unity.Mathematics.int3 falseValue, Unity.Mathematics.int3 trueValue, Unity.Mathematics.bool3 test)
  Unity.Mathematics.int4 select(Unity.Mathematics.int4 falseValue, Unity.Mathematics.int4 trueValue, Unity.Mathematics.bool4 test)
  System.UInt32 select(System.UInt32 falseValue, System.UInt32 trueValue, System.Boolean test)
  Unity.Mathematics.uint2 select(Unity.Mathematics.uint2 falseValue, Unity.Mathematics.uint2 trueValue, System.Boolean test)
  Unity.Mathematics.uint3 select(Unity.Mathematics.uint3 falseValue, Unity.Mathematics.uint3 trueValue, System.Boolean test)
  Unity.Mathematics.uint4 select(Unity.Mathematics.uint4 falseValue, Unity.Mathematics.uint4 trueValue, System.Boolean test)
  Unity.Mathematics.uint2 select(Unity.Mathematics.uint2 falseValue, Unity.Mathematics.uint2 trueValue, Unity.Mathematics.bool2 test)
  Unity.Mathematics.uint3 select(Unity.Mathematics.uint3 falseValue, Unity.Mathematics.uint3 trueValue, Unity.Mathematics.bool3 test)
  Unity.Mathematics.uint4 select(Unity.Mathematics.uint4 falseValue, Unity.Mathematics.uint4 trueValue, Unity.Mathematics.bool4 test)
  System.Int64 select(System.Int64 falseValue, System.Int64 trueValue, System.Boolean test)
  System.UInt64 select(System.UInt64 falseValue, System.UInt64 trueValue, System.Boolean test)
  System.Single select(System.Single falseValue, System.Single trueValue, System.Boolean test)
  Unity.Mathematics.float2 select(Unity.Mathematics.float2 falseValue, Unity.Mathematics.float2 trueValue, System.Boolean test)
  Unity.Mathematics.float3 select(Unity.Mathematics.float3 falseValue, Unity.Mathematics.float3 trueValue, System.Boolean test)
  Unity.Mathematics.float4 select(Unity.Mathematics.float4 falseValue, Unity.Mathematics.float4 trueValue, System.Boolean test)
  Unity.Mathematics.float2 select(Unity.Mathematics.float2 falseValue, Unity.Mathematics.float2 trueValue, Unity.Mathematics.bool2 test)
  Unity.Mathematics.float3 select(Unity.Mathematics.float3 falseValue, Unity.Mathematics.float3 trueValue, Unity.Mathematics.bool3 test)
  Unity.Mathematics.float4 select(Unity.Mathematics.float4 falseValue, Unity.Mathematics.float4 trueValue, Unity.Mathematics.bool4 test)
  System.Double select(System.Double falseValue, System.Double trueValue, System.Boolean test)
  Unity.Mathematics.double2 select(Unity.Mathematics.double2 falseValue, Unity.Mathematics.double2 trueValue, System.Boolean test)
  Unity.Mathematics.double3 select(Unity.Mathematics.double3 falseValue, Unity.Mathematics.double3 trueValue, System.Boolean test)
  Unity.Mathematics.double4 select(Unity.Mathematics.double4 falseValue, Unity.Mathematics.double4 trueValue, System.Boolean test)
  Unity.Mathematics.double2 select(Unity.Mathematics.double2 falseValue, Unity.Mathematics.double2 trueValue, Unity.Mathematics.bool2 test)
  Unity.Mathematics.double3 select(Unity.Mathematics.double3 falseValue, Unity.Mathematics.double3 trueValue, Unity.Mathematics.bool3 test)
  Unity.Mathematics.double4 select(Unity.Mathematics.double4 falseValue, Unity.Mathematics.double4 trueValue, Unity.Mathematics.bool4 test)
  System.Single step(System.Single threshold, System.Single x)
  Unity.Mathematics.float2 step(Unity.Mathematics.float2 threshold, Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 step(Unity.Mathematics.float3 threshold, Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 step(Unity.Mathematics.float4 threshold, Unity.Mathematics.float4 x)
  System.Double step(System.Double threshold, System.Double x)
  Unity.Mathematics.double2 step(Unity.Mathematics.double2 threshold, Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 step(Unity.Mathematics.double3 threshold, Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 step(Unity.Mathematics.double4 threshold, Unity.Mathematics.double4 x)
  Unity.Mathematics.float2 reflect(Unity.Mathematics.float2 i, Unity.Mathematics.float2 n)
  Unity.Mathematics.float3 reflect(Unity.Mathematics.float3 i, Unity.Mathematics.float3 n)
  Unity.Mathematics.float4 reflect(Unity.Mathematics.float4 i, Unity.Mathematics.float4 n)
  Unity.Mathematics.double2 reflect(Unity.Mathematics.double2 i, Unity.Mathematics.double2 n)
  Unity.Mathematics.double3 reflect(Unity.Mathematics.double3 i, Unity.Mathematics.double3 n)
  Unity.Mathematics.double4 reflect(Unity.Mathematics.double4 i, Unity.Mathematics.double4 n)
  Unity.Mathematics.float2 refract(Unity.Mathematics.float2 i, Unity.Mathematics.float2 n, System.Single indexOfRefraction)
  Unity.Mathematics.float3 refract(Unity.Mathematics.float3 i, Unity.Mathematics.float3 n, System.Single indexOfRefraction)
  Unity.Mathematics.float4 refract(Unity.Mathematics.float4 i, Unity.Mathematics.float4 n, System.Single indexOfRefraction)
  Unity.Mathematics.double2 refract(Unity.Mathematics.double2 i, Unity.Mathematics.double2 n, System.Double indexOfRefraction)
  Unity.Mathematics.double3 refract(Unity.Mathematics.double3 i, Unity.Mathematics.double3 n, System.Double indexOfRefraction)
  Unity.Mathematics.double4 refract(Unity.Mathematics.double4 i, Unity.Mathematics.double4 n, System.Double indexOfRefraction)
  Unity.Mathematics.float2 project(Unity.Mathematics.float2 a, Unity.Mathematics.float2 ontoB)
  Unity.Mathematics.float3 project(Unity.Mathematics.float3 a, Unity.Mathematics.float3 ontoB)
  Unity.Mathematics.float4 project(Unity.Mathematics.float4 a, Unity.Mathematics.float4 ontoB)
  Unity.Mathematics.float2 projectsafe(Unity.Mathematics.float2 a, Unity.Mathematics.float2 ontoB, Unity.Mathematics.float2 defaultValue)
  Unity.Mathematics.float3 projectsafe(Unity.Mathematics.float3 a, Unity.Mathematics.float3 ontoB, Unity.Mathematics.float3 defaultValue)
  Unity.Mathematics.float4 projectsafe(Unity.Mathematics.float4 a, Unity.Mathematics.float4 ontoB, Unity.Mathematics.float4 defaultValue)
  Unity.Mathematics.double2 project(Unity.Mathematics.double2 a, Unity.Mathematics.double2 ontoB)
  Unity.Mathematics.double3 project(Unity.Mathematics.double3 a, Unity.Mathematics.double3 ontoB)
  Unity.Mathematics.double4 project(Unity.Mathematics.double4 a, Unity.Mathematics.double4 ontoB)
  Unity.Mathematics.double2 projectsafe(Unity.Mathematics.double2 a, Unity.Mathematics.double2 ontoB, Unity.Mathematics.double2 defaultValue)
  Unity.Mathematics.double3 projectsafe(Unity.Mathematics.double3 a, Unity.Mathematics.double3 ontoB, Unity.Mathematics.double3 defaultValue)
  Unity.Mathematics.double4 projectsafe(Unity.Mathematics.double4 a, Unity.Mathematics.double4 ontoB, Unity.Mathematics.double4 defaultValue)
  Unity.Mathematics.float2 faceforward(Unity.Mathematics.float2 n, Unity.Mathematics.float2 i, Unity.Mathematics.float2 ng)
  Unity.Mathematics.float3 faceforward(Unity.Mathematics.float3 n, Unity.Mathematics.float3 i, Unity.Mathematics.float3 ng)
  Unity.Mathematics.float4 faceforward(Unity.Mathematics.float4 n, Unity.Mathematics.float4 i, Unity.Mathematics.float4 ng)
  Unity.Mathematics.double2 faceforward(Unity.Mathematics.double2 n, Unity.Mathematics.double2 i, Unity.Mathematics.double2 ng)
  Unity.Mathematics.double3 faceforward(Unity.Mathematics.double3 n, Unity.Mathematics.double3 i, Unity.Mathematics.double3 ng)
  Unity.Mathematics.double4 faceforward(Unity.Mathematics.double4 n, Unity.Mathematics.double4 i, Unity.Mathematics.double4 ng)
  System.Void sincos(System.Single x, System.Single& s, System.Single& c)
  System.Void sincos(Unity.Mathematics.float2 x, Unity.Mathematics.float2& s, Unity.Mathematics.float2& c)
  System.Void sincos(Unity.Mathematics.float3 x, Unity.Mathematics.float3& s, Unity.Mathematics.float3& c)
  System.Void sincos(Unity.Mathematics.float4 x, Unity.Mathematics.float4& s, Unity.Mathematics.float4& c)
  System.Void sincos(System.Double x, System.Double& s, System.Double& c)
  System.Void sincos(Unity.Mathematics.double2 x, Unity.Mathematics.double2& s, Unity.Mathematics.double2& c)
  System.Void sincos(Unity.Mathematics.double3 x, Unity.Mathematics.double3& s, Unity.Mathematics.double3& c)
  System.Void sincos(Unity.Mathematics.double4 x, Unity.Mathematics.double4& s, Unity.Mathematics.double4& c)
  System.Int32 countbits(System.Int32 x)
  Unity.Mathematics.int2 countbits(Unity.Mathematics.int2 x)
  Unity.Mathematics.int3 countbits(Unity.Mathematics.int3 x)
  Unity.Mathematics.int4 countbits(Unity.Mathematics.int4 x)
  System.Int32 countbits(System.UInt32 x)
  Unity.Mathematics.int2 countbits(Unity.Mathematics.uint2 x)
  Unity.Mathematics.int3 countbits(Unity.Mathematics.uint3 x)
  Unity.Mathematics.int4 countbits(Unity.Mathematics.uint4 x)
  System.Int32 countbits(System.UInt64 x)
  System.Int32 countbits(System.Int64 x)
  System.Int32 lzcnt(System.Int32 x)
  Unity.Mathematics.int2 lzcnt(Unity.Mathematics.int2 x)
  Unity.Mathematics.int3 lzcnt(Unity.Mathematics.int3 x)
  Unity.Mathematics.int4 lzcnt(Unity.Mathematics.int4 x)
  System.Int32 lzcnt(System.UInt32 x)
  Unity.Mathematics.int2 lzcnt(Unity.Mathematics.uint2 x)
  Unity.Mathematics.int3 lzcnt(Unity.Mathematics.uint3 x)
  Unity.Mathematics.int4 lzcnt(Unity.Mathematics.uint4 x)
  System.Int32 lzcnt(System.Int64 x)
  System.Int32 lzcnt(System.UInt64 x)
  System.Int32 tzcnt(System.Int32 x)
  Unity.Mathematics.int2 tzcnt(Unity.Mathematics.int2 x)
  Unity.Mathematics.int3 tzcnt(Unity.Mathematics.int3 x)
  Unity.Mathematics.int4 tzcnt(Unity.Mathematics.int4 x)
  System.Int32 tzcnt(System.UInt32 x)
  Unity.Mathematics.int2 tzcnt(Unity.Mathematics.uint2 x)
  Unity.Mathematics.int3 tzcnt(Unity.Mathematics.uint3 x)
  Unity.Mathematics.int4 tzcnt(Unity.Mathematics.uint4 x)
  System.Int32 tzcnt(System.Int64 x)
  System.Int32 tzcnt(System.UInt64 x)
  System.Int32 reversebits(System.Int32 x)
  Unity.Mathematics.int2 reversebits(Unity.Mathematics.int2 x)
  Unity.Mathematics.int3 reversebits(Unity.Mathematics.int3 x)
  Unity.Mathematics.int4 reversebits(Unity.Mathematics.int4 x)
  System.UInt32 reversebits(System.UInt32 x)
  Unity.Mathematics.uint2 reversebits(Unity.Mathematics.uint2 x)
  Unity.Mathematics.uint3 reversebits(Unity.Mathematics.uint3 x)
  Unity.Mathematics.uint4 reversebits(Unity.Mathematics.uint4 x)
  System.Int64 reversebits(System.Int64 x)
  System.UInt64 reversebits(System.UInt64 x)
  System.Int32 rol(System.Int32 x, System.Int32 n)
  Unity.Mathematics.int2 rol(Unity.Mathematics.int2 x, System.Int32 n)
  Unity.Mathematics.int3 rol(Unity.Mathematics.int3 x, System.Int32 n)
  Unity.Mathematics.int4 rol(Unity.Mathematics.int4 x, System.Int32 n)
  System.UInt32 rol(System.UInt32 x, System.Int32 n)
  Unity.Mathematics.uint2 rol(Unity.Mathematics.uint2 x, System.Int32 n)
  Unity.Mathematics.uint3 rol(Unity.Mathematics.uint3 x, System.Int32 n)
  Unity.Mathematics.uint4 rol(Unity.Mathematics.uint4 x, System.Int32 n)
  System.Int64 rol(System.Int64 x, System.Int32 n)
  System.UInt64 rol(System.UInt64 x, System.Int32 n)
  System.Int32 ror(System.Int32 x, System.Int32 n)
  Unity.Mathematics.int2 ror(Unity.Mathematics.int2 x, System.Int32 n)
  Unity.Mathematics.int3 ror(Unity.Mathematics.int3 x, System.Int32 n)
  Unity.Mathematics.int4 ror(Unity.Mathematics.int4 x, System.Int32 n)
  System.UInt32 ror(System.UInt32 x, System.Int32 n)
  Unity.Mathematics.uint2 ror(Unity.Mathematics.uint2 x, System.Int32 n)
  Unity.Mathematics.uint3 ror(Unity.Mathematics.uint3 x, System.Int32 n)
  Unity.Mathematics.uint4 ror(Unity.Mathematics.uint4 x, System.Int32 n)
  System.Int64 ror(System.Int64 x, System.Int32 n)
  System.UInt64 ror(System.UInt64 x, System.Int32 n)
  System.Int32 ceilpow2(System.Int32 x)
  Unity.Mathematics.int2 ceilpow2(Unity.Mathematics.int2 x)
  Unity.Mathematics.int3 ceilpow2(Unity.Mathematics.int3 x)
  Unity.Mathematics.int4 ceilpow2(Unity.Mathematics.int4 x)
  System.UInt32 ceilpow2(System.UInt32 x)
  Unity.Mathematics.uint2 ceilpow2(Unity.Mathematics.uint2 x)
  Unity.Mathematics.uint3 ceilpow2(Unity.Mathematics.uint3 x)
  Unity.Mathematics.uint4 ceilpow2(Unity.Mathematics.uint4 x)
  System.Int64 ceilpow2(System.Int64 x)
  System.UInt64 ceilpow2(System.UInt64 x)
  System.Int32 ceillog2(System.Int32 x)
  Unity.Mathematics.int2 ceillog2(Unity.Mathematics.int2 x)
  Unity.Mathematics.int3 ceillog2(Unity.Mathematics.int3 x)
  Unity.Mathematics.int4 ceillog2(Unity.Mathematics.int4 x)
  System.Int32 ceillog2(System.UInt32 x)
  Unity.Mathematics.int2 ceillog2(Unity.Mathematics.uint2 x)
  Unity.Mathematics.int3 ceillog2(Unity.Mathematics.uint3 x)
  Unity.Mathematics.int4 ceillog2(Unity.Mathematics.uint4 x)
  System.Int32 floorlog2(System.Int32 x)
  Unity.Mathematics.int2 floorlog2(Unity.Mathematics.int2 x)
  Unity.Mathematics.int3 floorlog2(Unity.Mathematics.int3 x)
  Unity.Mathematics.int4 floorlog2(Unity.Mathematics.int4 x)
  System.Int32 floorlog2(System.UInt32 x)
  Unity.Mathematics.int2 floorlog2(Unity.Mathematics.uint2 x)
  Unity.Mathematics.int3 floorlog2(Unity.Mathematics.uint3 x)
  Unity.Mathematics.int4 floorlog2(Unity.Mathematics.uint4 x)
  System.Single radians(System.Single x)
  Unity.Mathematics.float2 radians(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 radians(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 radians(Unity.Mathematics.float4 x)
  System.Double radians(System.Double x)
  Unity.Mathematics.double2 radians(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 radians(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 radians(Unity.Mathematics.double4 x)
  System.Single degrees(System.Single x)
  Unity.Mathematics.float2 degrees(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 degrees(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 degrees(Unity.Mathematics.float4 x)
  System.Double degrees(System.Double x)
  Unity.Mathematics.double2 degrees(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 degrees(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 degrees(Unity.Mathematics.double4 x)
  System.Int32 cmin(Unity.Mathematics.int2 x)
  System.Int32 cmin(Unity.Mathematics.int3 x)
  System.Int32 cmin(Unity.Mathematics.int4 x)
  System.UInt32 cmin(Unity.Mathematics.uint2 x)
  System.UInt32 cmin(Unity.Mathematics.uint3 x)
  System.UInt32 cmin(Unity.Mathematics.uint4 x)
  System.Single cmin(Unity.Mathematics.float2 x)
  System.Single cmin(Unity.Mathematics.float3 x)
  System.Single cmin(Unity.Mathematics.float4 x)
  System.Double cmin(Unity.Mathematics.double2 x)
  System.Double cmin(Unity.Mathematics.double3 x)
  System.Double cmin(Unity.Mathematics.double4 x)
  System.Int32 cmax(Unity.Mathematics.int2 x)
  System.Int32 cmax(Unity.Mathematics.int3 x)
  System.Int32 cmax(Unity.Mathematics.int4 x)
  System.UInt32 cmax(Unity.Mathematics.uint2 x)
  System.UInt32 cmax(Unity.Mathematics.uint3 x)
  System.UInt32 cmax(Unity.Mathematics.uint4 x)
  System.Single cmax(Unity.Mathematics.float2 x)
  System.Single cmax(Unity.Mathematics.float3 x)
  System.Single cmax(Unity.Mathematics.float4 x)
  System.Double cmax(Unity.Mathematics.double2 x)
  System.Double cmax(Unity.Mathematics.double3 x)
  System.Double cmax(Unity.Mathematics.double4 x)
  System.Int32 csum(Unity.Mathematics.int2 x)
  System.Int32 csum(Unity.Mathematics.int3 x)
  System.Int32 csum(Unity.Mathematics.int4 x)
  System.UInt32 csum(Unity.Mathematics.uint2 x)
  System.UInt32 csum(Unity.Mathematics.uint3 x)
  System.UInt32 csum(Unity.Mathematics.uint4 x)
  System.Single csum(Unity.Mathematics.float2 x)
  System.Single csum(Unity.Mathematics.float3 x)
  System.Single csum(Unity.Mathematics.float4 x)
  System.Double csum(Unity.Mathematics.double2 x)
  System.Double csum(Unity.Mathematics.double3 x)
  System.Double csum(Unity.Mathematics.double4 x)
  System.Single square(System.Single x)
  Unity.Mathematics.float2 square(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 square(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 square(Unity.Mathematics.float4 x)
  System.Double square(System.Double x)
  Unity.Mathematics.double2 square(Unity.Mathematics.double2 x)
  Unity.Mathematics.double3 square(Unity.Mathematics.double3 x)
  Unity.Mathematics.double4 square(Unity.Mathematics.double4 x)
  System.Int32 square(System.Int32 x)
  Unity.Mathematics.int2 square(Unity.Mathematics.int2 x)
  Unity.Mathematics.int3 square(Unity.Mathematics.int3 x)
  Unity.Mathematics.int4 square(Unity.Mathematics.int4 x)
  System.UInt32 square(System.UInt32 x)
  Unity.Mathematics.uint2 square(Unity.Mathematics.uint2 x)
  Unity.Mathematics.uint3 square(Unity.Mathematics.uint3 x)
  Unity.Mathematics.uint4 square(Unity.Mathematics.uint4 x)
  System.Int32 compress(System.Int32* output, System.Int32 index, Unity.Mathematics.int4 val, Unity.Mathematics.bool4 mask)
  System.Int32 compress(System.UInt32* output, System.Int32 index, Unity.Mathematics.uint4 val, Unity.Mathematics.bool4 mask)
  System.Int32 compress(System.Single* output, System.Int32 index, Unity.Mathematics.float4 val, Unity.Mathematics.bool4 mask)
  System.Single f16tof32(System.UInt32 x)
  Unity.Mathematics.float2 f16tof32(Unity.Mathematics.uint2 x)
  Unity.Mathematics.float3 f16tof32(Unity.Mathematics.uint3 x)
  Unity.Mathematics.float4 f16tof32(Unity.Mathematics.uint4 x)
  System.UInt32 f32tof16(System.Single x)
  Unity.Mathematics.uint2 f32tof16(Unity.Mathematics.float2 x)
  Unity.Mathematics.uint3 f32tof16(Unity.Mathematics.float3 x)
  Unity.Mathematics.uint4 f32tof16(Unity.Mathematics.float4 x)
  System.Void orthonormal_basis(Unity.Mathematics.float3 normal, Unity.Mathematics.float3& basis1, Unity.Mathematics.float3& basis2)
  System.Void orthonormal_basis(Unity.Mathematics.double3 normal, Unity.Mathematics.double3& basis1, Unity.Mathematics.double3& basis2)
  System.Single chgsign(System.Single x, System.Single y)
  Unity.Mathematics.float2 chgsign(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y)
  Unity.Mathematics.float3 chgsign(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y)
  Unity.Mathematics.float4 chgsign(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y)
  System.UInt32 read32_little_endian(System.Void* pBuffer)
  System.UInt32 hash_with_unaligned_loads(System.Void* pBuffer, System.Int32 numBytes, System.UInt32 seed)
  System.UInt32 hash_without_unaligned_loads(System.Void* pBuffer, System.Int32 numBytes, System.UInt32 seed)
  System.UInt32 hash(System.Void* pBuffer, System.Int32 numBytes, System.UInt32 seed)
  Unity.Mathematics.float3 up()
  Unity.Mathematics.float3 down()
  Unity.Mathematics.float3 forward()
  Unity.Mathematics.float3 back()
  Unity.Mathematics.float3 left()
  Unity.Mathematics.float3 right()
  Unity.Mathematics.float3 EulerXYZ(Unity.Mathematics.quaternion q)
  Unity.Mathematics.float3 EulerXZY(Unity.Mathematics.quaternion q)
  Unity.Mathematics.float3 EulerYXZ(Unity.Mathematics.quaternion q)
  Unity.Mathematics.float3 EulerYZX(Unity.Mathematics.quaternion q)
  Unity.Mathematics.float3 EulerZXY(Unity.Mathematics.quaternion q)
  Unity.Mathematics.float3 EulerZYX(Unity.Mathematics.quaternion q)
  Unity.Mathematics.float3 Euler(Unity.Mathematics.quaternion q, Unity.Mathematics.math.RotationOrder order)
  Unity.Mathematics.float3x3 mulScale(Unity.Mathematics.float3x3 m, Unity.Mathematics.float3 s)
  Unity.Mathematics.float3x3 scaleMul(Unity.Mathematics.float3 s, Unity.Mathematics.float3x3 m)
  Unity.Mathematics.float4 unpacklo(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b)
  Unity.Mathematics.double4 unpacklo(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b)
  Unity.Mathematics.float4 unpackhi(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b)
  Unity.Mathematics.double4 unpackhi(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b)
  Unity.Mathematics.float4 movelh(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b)
  Unity.Mathematics.double4 movelh(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b)
  Unity.Mathematics.float4 movehl(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b)
  Unity.Mathematics.double4 movehl(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b)
  System.UInt32 fold_to_uint(System.Double x)
  Unity.Mathematics.uint2 fold_to_uint(Unity.Mathematics.double2 x)
  Unity.Mathematics.uint3 fold_to_uint(Unity.Mathematics.double3 x)
  Unity.Mathematics.uint4 fold_to_uint(Unity.Mathematics.double4 x)
  Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.float4x4 f4x4)
  Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.quaternion rotation)
  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.float3x3 rotation, Unity.Mathematics.float3 translation)
  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 translation)
  Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.RigidTransform transform)
  Unity.Mathematics.float3x3 orthonormalize(Unity.Mathematics.float3x3 i)
  Unity.Mathematics.float3x3 pseudoinverse(Unity.Mathematics.float3x3 m)
  System.Single mul(System.Single a, System.Single b)
  System.Single mul(Unity.Mathematics.float2 a, Unity.Mathematics.float2 b)
  Unity.Mathematics.float2 mul(Unity.Mathematics.float2 a, Unity.Mathematics.float2x2 b)
  Unity.Mathematics.float3 mul(Unity.Mathematics.float2 a, Unity.Mathematics.float2x3 b)
  Unity.Mathematics.float4 mul(Unity.Mathematics.float2 a, Unity.Mathematics.float2x4 b)
  System.Single mul(Unity.Mathematics.float3 a, Unity.Mathematics.float3 b)
  Unity.Mathematics.float2 mul(Unity.Mathematics.float3 a, Unity.Mathematics.float3x2 b)
  Unity.Mathematics.float3 mul(Unity.Mathematics.float3 a, Unity.Mathematics.float3x3 b)
  Unity.Mathematics.float4 mul(Unity.Mathematics.float3 a, Unity.Mathematics.float3x4 b)
  System.Single mul(Unity.Mathematics.float4 a, Unity.Mathematics.float4 b)
  Unity.Mathematics.float2 mul(Unity.Mathematics.float4 a, Unity.Mathematics.float4x2 b)
  Unity.Mathematics.float3 mul(Unity.Mathematics.float4 a, Unity.Mathematics.float4x3 b)
  Unity.Mathematics.float4 mul(Unity.Mathematics.float4 a, Unity.Mathematics.float4x4 b)
  Unity.Mathematics.float2 mul(Unity.Mathematics.float2x2 a, Unity.Mathematics.float2 b)
  Unity.Mathematics.float2x2 mul(Unity.Mathematics.float2x2 a, Unity.Mathematics.float2x2 b)
  Unity.Mathematics.float2x3 mul(Unity.Mathematics.float2x2 a, Unity.Mathematics.float2x3 b)
  Unity.Mathematics.float2x4 mul(Unity.Mathematics.float2x2 a, Unity.Mathematics.float2x4 b)
  Unity.Mathematics.float2 mul(Unity.Mathematics.float2x3 a, Unity.Mathematics.float3 b)
  Unity.Mathematics.float2x2 mul(Unity.Mathematics.float2x3 a, Unity.Mathematics.float3x2 b)
  Unity.Mathematics.float2x3 mul(Unity.Mathematics.float2x3 a, Unity.Mathematics.float3x3 b)
  Unity.Mathematics.float2x4 mul(Unity.Mathematics.float2x3 a, Unity.Mathematics.float3x4 b)
  Unity.Mathematics.float2 mul(Unity.Mathematics.float2x4 a, Unity.Mathematics.float4 b)
  Unity.Mathematics.float2x2 mul(Unity.Mathematics.float2x4 a, Unity.Mathematics.float4x2 b)
  Unity.Mathematics.float2x3 mul(Unity.Mathematics.float2x4 a, Unity.Mathematics.float4x3 b)
  Unity.Mathematics.float2x4 mul(Unity.Mathematics.float2x4 a, Unity.Mathematics.float4x4 b)
  Unity.Mathematics.float3 mul(Unity.Mathematics.float3x2 a, Unity.Mathematics.float2 b)
  Unity.Mathematics.float3x2 mul(Unity.Mathematics.float3x2 a, Unity.Mathematics.float2x2 b)
  Unity.Mathematics.float3x3 mul(Unity.Mathematics.float3x2 a, Unity.Mathematics.float2x3 b)
  Unity.Mathematics.float3x4 mul(Unity.Mathematics.float3x2 a, Unity.Mathematics.float2x4 b)
  Unity.Mathematics.float3 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3 b)
  Unity.Mathematics.float3x2 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3x2 b)
  Unity.Mathematics.float3x3 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3x3 b)
  Unity.Mathematics.float3x4 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3x4 b)
  Unity.Mathematics.float3 mul(Unity.Mathematics.float3x4 a, Unity.Mathematics.float4 b)
  Unity.Mathematics.float3x2 mul(Unity.Mathematics.float3x4 a, Unity.Mathematics.float4x2 b)
  Unity.Mathematics.float3x3 mul(Unity.Mathematics.float3x4 a, Unity.Mathematics.float4x3 b)
  Unity.Mathematics.float3x4 mul(Unity.Mathematics.float3x4 a, Unity.Mathematics.float4x4 b)
  Unity.Mathematics.float4 mul(Unity.Mathematics.float4x2 a, Unity.Mathematics.float2 b)
  Unity.Mathematics.float4x2 mul(Unity.Mathematics.float4x2 a, Unity.Mathematics.float2x2 b)
  Unity.Mathematics.float4x3 mul(Unity.Mathematics.float4x2 a, Unity.Mathematics.float2x3 b)
  Unity.Mathematics.float4x4 mul(Unity.Mathematics.float4x2 a, Unity.Mathematics.float2x4 b)
  Unity.Mathematics.float4 mul(Unity.Mathematics.float4x3 a, Unity.Mathematics.float3 b)
  Unity.Mathematics.float4x2 mul(Unity.Mathematics.float4x3 a, Unity.Mathematics.float3x2 b)
  Unity.Mathematics.float4x3 mul(Unity.Mathematics.float4x3 a, Unity.Mathematics.float3x3 b)
  Unity.Mathematics.float4x4 mul(Unity.Mathematics.float4x3 a, Unity.Mathematics.float3x4 b)
  Unity.Mathematics.float4 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4 b)
  Unity.Mathematics.float4x2 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4x2 b)
  Unity.Mathematics.float4x3 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4x3 b)
  Unity.Mathematics.float4x4 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4x4 b)
  System.Double mul(System.Double a, System.Double b)
  System.Double mul(Unity.Mathematics.double2 a, Unity.Mathematics.double2 b)
  Unity.Mathematics.double2 mul(Unity.Mathematics.double2 a, Unity.Mathematics.double2x2 b)
  Unity.Mathematics.double3 mul(Unity.Mathematics.double2 a, Unity.Mathematics.double2x3 b)
  Unity.Mathematics.double4 mul(Unity.Mathematics.double2 a, Unity.Mathematics.double2x4 b)
  System.Double mul(Unity.Mathematics.double3 a, Unity.Mathematics.double3 b)
  Unity.Mathematics.double2 mul(Unity.Mathematics.double3 a, Unity.Mathematics.double3x2 b)
  Unity.Mathematics.double3 mul(Unity.Mathematics.double3 a, Unity.Mathematics.double3x3 b)
  Unity.Mathematics.double4 mul(Unity.Mathematics.double3 a, Unity.Mathematics.double3x4 b)
  System.Double mul(Unity.Mathematics.double4 a, Unity.Mathematics.double4 b)
  Unity.Mathematics.double2 mul(Unity.Mathematics.double4 a, Unity.Mathematics.double4x2 b)
  Unity.Mathematics.double3 mul(Unity.Mathematics.double4 a, Unity.Mathematics.double4x3 b)
  Unity.Mathematics.double4 mul(Unity.Mathematics.double4 a, Unity.Mathematics.double4x4 b)
  Unity.Mathematics.double2 mul(Unity.Mathematics.double2x2 a, Unity.Mathematics.double2 b)
  Unity.Mathematics.double2x2 mul(Unity.Mathematics.double2x2 a, Unity.Mathematics.double2x2 b)
  Unity.Mathematics.double2x3 mul(Unity.Mathematics.double2x2 a, Unity.Mathematics.double2x3 b)
  Unity.Mathematics.double2x4 mul(Unity.Mathematics.double2x2 a, Unity.Mathematics.double2x4 b)
  Unity.Mathematics.double2 mul(Unity.Mathematics.double2x3 a, Unity.Mathematics.double3 b)
  Unity.Mathematics.double2x2 mul(Unity.Mathematics.double2x3 a, Unity.Mathematics.double3x2 b)
  Unity.Mathematics.double2x3 mul(Unity.Mathematics.double2x3 a, Unity.Mathematics.double3x3 b)
  Unity.Mathematics.double2x4 mul(Unity.Mathematics.double2x3 a, Unity.Mathematics.double3x4 b)
  Unity.Mathematics.double2 mul(Unity.Mathematics.double2x4 a, Unity.Mathematics.double4 b)
  Unity.Mathematics.double2x2 mul(Unity.Mathematics.double2x4 a, Unity.Mathematics.double4x2 b)
  Unity.Mathematics.double2x3 mul(Unity.Mathematics.double2x4 a, Unity.Mathematics.double4x3 b)
  Unity.Mathematics.double2x4 mul(Unity.Mathematics.double2x4 a, Unity.Mathematics.double4x4 b)
  Unity.Mathematics.double3 mul(Unity.Mathematics.double3x2 a, Unity.Mathematics.double2 b)
  Unity.Mathematics.double3x2 mul(Unity.Mathematics.double3x2 a, Unity.Mathematics.double2x2 b)
  Unity.Mathematics.double3x3 mul(Unity.Mathematics.double3x2 a, Unity.Mathematics.double2x3 b)
  Unity.Mathematics.double3x4 mul(Unity.Mathematics.double3x2 a, Unity.Mathematics.double2x4 b)
  Unity.Mathematics.double3 mul(Unity.Mathematics.double3x3 a, Unity.Mathematics.double3 b)
  Unity.Mathematics.double3x2 mul(Unity.Mathematics.double3x3 a, Unity.Mathematics.double3x2 b)
  Unity.Mathematics.double3x3 mul(Unity.Mathematics.double3x3 a, Unity.Mathematics.double3x3 b)
  Unity.Mathematics.double3x4 mul(Unity.Mathematics.double3x3 a, Unity.Mathematics.double3x4 b)
  Unity.Mathematics.double3 mul(Unity.Mathematics.double3x4 a, Unity.Mathematics.double4 b)
  Unity.Mathematics.double3x2 mul(Unity.Mathematics.double3x4 a, Unity.Mathematics.double4x2 b)
  Unity.Mathematics.double3x3 mul(Unity.Mathematics.double3x4 a, Unity.Mathematics.double4x3 b)
  Unity.Mathematics.double3x4 mul(Unity.Mathematics.double3x4 a, Unity.Mathematics.double4x4 b)
  Unity.Mathematics.double4 mul(Unity.Mathematics.double4x2 a, Unity.Mathematics.double2 b)
  Unity.Mathematics.double4x2 mul(Unity.Mathematics.double4x2 a, Unity.Mathematics.double2x2 b)
  Unity.Mathematics.double4x3 mul(Unity.Mathematics.double4x2 a, Unity.Mathematics.double2x3 b)
  Unity.Mathematics.double4x4 mul(Unity.Mathematics.double4x2 a, Unity.Mathematics.double2x4 b)
  Unity.Mathematics.double4 mul(Unity.Mathematics.double4x3 a, Unity.Mathematics.double3 b)
  Unity.Mathematics.double4x2 mul(Unity.Mathematics.double4x3 a, Unity.Mathematics.double3x2 b)
  Unity.Mathematics.double4x3 mul(Unity.Mathematics.double4x3 a, Unity.Mathematics.double3x3 b)
  Unity.Mathematics.double4x4 mul(Unity.Mathematics.double4x3 a, Unity.Mathematics.double3x4 b)
  Unity.Mathematics.double4 mul(Unity.Mathematics.double4x4 a, Unity.Mathematics.double4 b)
  Unity.Mathematics.double4x2 mul(Unity.Mathematics.double4x4 a, Unity.Mathematics.double4x2 b)
  Unity.Mathematics.double4x3 mul(Unity.Mathematics.double4x4 a, Unity.Mathematics.double4x3 b)
  Unity.Mathematics.double4x4 mul(Unity.Mathematics.double4x4 a, Unity.Mathematics.double4x4 b)
  System.Int32 mul(System.Int32 a, System.Int32 b)
  System.Int32 mul(Unity.Mathematics.int2 a, Unity.Mathematics.int2 b)
  Unity.Mathematics.int2 mul(Unity.Mathematics.int2 a, Unity.Mathematics.int2x2 b)
  Unity.Mathematics.int3 mul(Unity.Mathematics.int2 a, Unity.Mathematics.int2x3 b)
  Unity.Mathematics.int4 mul(Unity.Mathematics.int2 a, Unity.Mathematics.int2x4 b)
  System.Int32 mul(Unity.Mathematics.int3 a, Unity.Mathematics.int3 b)
  Unity.Mathematics.int2 mul(Unity.Mathematics.int3 a, Unity.Mathematics.int3x2 b)
  Unity.Mathematics.int3 mul(Unity.Mathematics.int3 a, Unity.Mathematics.int3x3 b)
  Unity.Mathematics.int4 mul(Unity.Mathematics.int3 a, Unity.Mathematics.int3x4 b)
  System.Int32 mul(Unity.Mathematics.int4 a, Unity.Mathematics.int4 b)
  Unity.Mathematics.int2 mul(Unity.Mathematics.int4 a, Unity.Mathematics.int4x2 b)
  Unity.Mathematics.int3 mul(Unity.Mathematics.int4 a, Unity.Mathematics.int4x3 b)
  Unity.Mathematics.int4 mul(Unity.Mathematics.int4 a, Unity.Mathematics.int4x4 b)
  Unity.Mathematics.int2 mul(Unity.Mathematics.int2x2 a, Unity.Mathematics.int2 b)
  Unity.Mathematics.int2x2 mul(Unity.Mathematics.int2x2 a, Unity.Mathematics.int2x2 b)
  Unity.Mathematics.int2x3 mul(Unity.Mathematics.int2x2 a, Unity.Mathematics.int2x3 b)
  Unity.Mathematics.int2x4 mul(Unity.Mathematics.int2x2 a, Unity.Mathematics.int2x4 b)
  Unity.Mathematics.int2 mul(Unity.Mathematics.int2x3 a, Unity.Mathematics.int3 b)
  Unity.Mathematics.int2x2 mul(Unity.Mathematics.int2x3 a, Unity.Mathematics.int3x2 b)
  Unity.Mathematics.int2x3 mul(Unity.Mathematics.int2x3 a, Unity.Mathematics.int3x3 b)
  Unity.Mathematics.int2x4 mul(Unity.Mathematics.int2x3 a, Unity.Mathematics.int3x4 b)
  Unity.Mathematics.int2 mul(Unity.Mathematics.int2x4 a, Unity.Mathematics.int4 b)
  Unity.Mathematics.int2x2 mul(Unity.Mathematics.int2x4 a, Unity.Mathematics.int4x2 b)
  Unity.Mathematics.int2x3 mul(Unity.Mathematics.int2x4 a, Unity.Mathematics.int4x3 b)
  Unity.Mathematics.int2x4 mul(Unity.Mathematics.int2x4 a, Unity.Mathematics.int4x4 b)
  Unity.Mathematics.int3 mul(Unity.Mathematics.int3x2 a, Unity.Mathematics.int2 b)
  Unity.Mathematics.int3x2 mul(Unity.Mathematics.int3x2 a, Unity.Mathematics.int2x2 b)
  Unity.Mathematics.int3x3 mul(Unity.Mathematics.int3x2 a, Unity.Mathematics.int2x3 b)
  Unity.Mathematics.int3x4 mul(Unity.Mathematics.int3x2 a, Unity.Mathematics.int2x4 b)
  Unity.Mathematics.int3 mul(Unity.Mathematics.int3x3 a, Unity.Mathematics.int3 b)
  Unity.Mathematics.int3x2 mul(Unity.Mathematics.int3x3 a, Unity.Mathematics.int3x2 b)
  Unity.Mathematics.int3x3 mul(Unity.Mathematics.int3x3 a, Unity.Mathematics.int3x3 b)
  Unity.Mathematics.int3x4 mul(Unity.Mathematics.int3x3 a, Unity.Mathematics.int3x4 b)
  Unity.Mathematics.int3 mul(Unity.Mathematics.int3x4 a, Unity.Mathematics.int4 b)
  Unity.Mathematics.int3x2 mul(Unity.Mathematics.int3x4 a, Unity.Mathematics.int4x2 b)
  Unity.Mathematics.int3x3 mul(Unity.Mathematics.int3x4 a, Unity.Mathematics.int4x3 b)
  Unity.Mathematics.int3x4 mul(Unity.Mathematics.int3x4 a, Unity.Mathematics.int4x4 b)
  Unity.Mathematics.int4 mul(Unity.Mathematics.int4x2 a, Unity.Mathematics.int2 b)
  Unity.Mathematics.int4x2 mul(Unity.Mathematics.int4x2 a, Unity.Mathematics.int2x2 b)
  Unity.Mathematics.int4x3 mul(Unity.Mathematics.int4x2 a, Unity.Mathematics.int2x3 b)
  Unity.Mathematics.int4x4 mul(Unity.Mathematics.int4x2 a, Unity.Mathematics.int2x4 b)
  Unity.Mathematics.int4 mul(Unity.Mathematics.int4x3 a, Unity.Mathematics.int3 b)
  Unity.Mathematics.int4x2 mul(Unity.Mathematics.int4x3 a, Unity.Mathematics.int3x2 b)
  Unity.Mathematics.int4x3 mul(Unity.Mathematics.int4x3 a, Unity.Mathematics.int3x3 b)
  Unity.Mathematics.int4x4 mul(Unity.Mathematics.int4x3 a, Unity.Mathematics.int3x4 b)
  Unity.Mathematics.int4 mul(Unity.Mathematics.int4x4 a, Unity.Mathematics.int4 b)
  Unity.Mathematics.int4x2 mul(Unity.Mathematics.int4x4 a, Unity.Mathematics.int4x2 b)
  Unity.Mathematics.int4x3 mul(Unity.Mathematics.int4x4 a, Unity.Mathematics.int4x3 b)
  Unity.Mathematics.int4x4 mul(Unity.Mathematics.int4x4 a, Unity.Mathematics.int4x4 b)
  System.UInt32 mul(System.UInt32 a, System.UInt32 b)
  System.UInt32 mul(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2 b)
  Unity.Mathematics.uint2 mul(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2x2 b)
  Unity.Mathematics.uint3 mul(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2x3 b)
  Unity.Mathematics.uint4 mul(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2x4 b)
  System.UInt32 mul(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3 b)
  Unity.Mathematics.uint2 mul(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3x2 b)
  Unity.Mathematics.uint3 mul(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3x3 b)
  Unity.Mathematics.uint4 mul(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3x4 b)
  System.UInt32 mul(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4 b)
  Unity.Mathematics.uint2 mul(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4x2 b)
  Unity.Mathematics.uint3 mul(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4x3 b)
  Unity.Mathematics.uint4 mul(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4x4 b)
  Unity.Mathematics.uint2 mul(Unity.Mathematics.uint2x2 a, Unity.Mathematics.uint2 b)
  Unity.Mathematics.uint2x2 mul(Unity.Mathematics.uint2x2 a, Unity.Mathematics.uint2x2 b)
  Unity.Mathematics.uint2x3 mul(Unity.Mathematics.uint2x2 a, Unity.Mathematics.uint2x3 b)
  Unity.Mathematics.uint2x4 mul(Unity.Mathematics.uint2x2 a, Unity.Mathematics.uint2x4 b)
  Unity.Mathematics.uint2 mul(Unity.Mathematics.uint2x3 a, Unity.Mathematics.uint3 b)
  Unity.Mathematics.uint2x2 mul(Unity.Mathematics.uint2x3 a, Unity.Mathematics.uint3x2 b)
  Unity.Mathematics.uint2x3 mul(Unity.Mathematics.uint2x3 a, Unity.Mathematics.uint3x3 b)
  Unity.Mathematics.uint2x4 mul(Unity.Mathematics.uint2x3 a, Unity.Mathematics.uint3x4 b)
  Unity.Mathematics.uint2 mul(Unity.Mathematics.uint2x4 a, Unity.Mathematics.uint4 b)
  Unity.Mathematics.uint2x2 mul(Unity.Mathematics.uint2x4 a, Unity.Mathematics.uint4x2 b)
  Unity.Mathematics.uint2x3 mul(Unity.Mathematics.uint2x4 a, Unity.Mathematics.uint4x3 b)
  Unity.Mathematics.uint2x4 mul(Unity.Mathematics.uint2x4 a, Unity.Mathematics.uint4x4 b)
  Unity.Mathematics.uint3 mul(Unity.Mathematics.uint3x2 a, Unity.Mathematics.uint2 b)
  Unity.Mathematics.uint3x2 mul(Unity.Mathematics.uint3x2 a, Unity.Mathematics.uint2x2 b)
  Unity.Mathematics.uint3x3 mul(Unity.Mathematics.uint3x2 a, Unity.Mathematics.uint2x3 b)
  Unity.Mathematics.uint3x4 mul(Unity.Mathematics.uint3x2 a, Unity.Mathematics.uint2x4 b)
  Unity.Mathematics.uint3 mul(Unity.Mathematics.uint3x3 a, Unity.Mathematics.uint3 b)
  Unity.Mathematics.uint3x2 mul(Unity.Mathematics.uint3x3 a, Unity.Mathematics.uint3x2 b)
  Unity.Mathematics.uint3x3 mul(Unity.Mathematics.uint3x3 a, Unity.Mathematics.uint3x3 b)
  Unity.Mathematics.uint3x4 mul(Unity.Mathematics.uint3x3 a, Unity.Mathematics.uint3x4 b)
  Unity.Mathematics.uint3 mul(Unity.Mathematics.uint3x4 a, Unity.Mathematics.uint4 b)
  Unity.Mathematics.uint3x2 mul(Unity.Mathematics.uint3x4 a, Unity.Mathematics.uint4x2 b)
  Unity.Mathematics.uint3x3 mul(Unity.Mathematics.uint3x4 a, Unity.Mathematics.uint4x3 b)
  Unity.Mathematics.uint3x4 mul(Unity.Mathematics.uint3x4 a, Unity.Mathematics.uint4x4 b)
  Unity.Mathematics.uint4 mul(Unity.Mathematics.uint4x2 a, Unity.Mathematics.uint2 b)
  Unity.Mathematics.uint4x2 mul(Unity.Mathematics.uint4x2 a, Unity.Mathematics.uint2x2 b)
  Unity.Mathematics.uint4x3 mul(Unity.Mathematics.uint4x2 a, Unity.Mathematics.uint2x3 b)
  Unity.Mathematics.uint4x4 mul(Unity.Mathematics.uint4x2 a, Unity.Mathematics.uint2x4 b)
  Unity.Mathematics.uint4 mul(Unity.Mathematics.uint4x3 a, Unity.Mathematics.uint3 b)
  Unity.Mathematics.uint4x2 mul(Unity.Mathematics.uint4x3 a, Unity.Mathematics.uint3x2 b)
  Unity.Mathematics.uint4x3 mul(Unity.Mathematics.uint4x3 a, Unity.Mathematics.uint3x3 b)
  Unity.Mathematics.uint4x4 mul(Unity.Mathematics.uint4x3 a, Unity.Mathematics.uint3x4 b)
  Unity.Mathematics.uint4 mul(Unity.Mathematics.uint4x4 a, Unity.Mathematics.uint4 b)
  Unity.Mathematics.uint4x2 mul(Unity.Mathematics.uint4x4 a, Unity.Mathematics.uint4x2 b)
  Unity.Mathematics.uint4x3 mul(Unity.Mathematics.uint4x4 a, Unity.Mathematics.uint4x3 b)
  Unity.Mathematics.uint4x4 mul(Unity.Mathematics.uint4x4 a, Unity.Mathematics.uint4x4 b)
  Unity.Mathematics.quaternion quaternion(System.Single x, System.Single y, System.Single z, System.Single w)
  Unity.Mathematics.quaternion quaternion(Unity.Mathematics.float4 value)
  Unity.Mathematics.quaternion quaternion(Unity.Mathematics.float3x3 m)
  Unity.Mathematics.quaternion quaternion(Unity.Mathematics.float4x4 m)
  Unity.Mathematics.quaternion conjugate(Unity.Mathematics.quaternion q)
  Unity.Mathematics.quaternion inverse(Unity.Mathematics.quaternion q)
  System.Single dot(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b)
  System.Single length(Unity.Mathematics.quaternion q)
  System.Single lengthsq(Unity.Mathematics.quaternion q)
  Unity.Mathematics.quaternion normalize(Unity.Mathematics.quaternion q)
  Unity.Mathematics.quaternion normalizesafe(Unity.Mathematics.quaternion q)
  Unity.Mathematics.quaternion normalizesafe(Unity.Mathematics.quaternion q, Unity.Mathematics.quaternion defaultvalue)
  Unity.Mathematics.quaternion unitexp(Unity.Mathematics.quaternion q)
  Unity.Mathematics.quaternion exp(Unity.Mathematics.quaternion q)
  Unity.Mathematics.quaternion unitlog(Unity.Mathematics.quaternion q)
  Unity.Mathematics.quaternion log(Unity.Mathematics.quaternion q)
  Unity.Mathematics.quaternion mul(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b)
  Unity.Mathematics.float3 mul(Unity.Mathematics.quaternion q, Unity.Mathematics.float3 v)
  Unity.Mathematics.float3 rotate(Unity.Mathematics.quaternion q, Unity.Mathematics.float3 v)
  Unity.Mathematics.quaternion nlerp(Unity.Mathematics.quaternion q1, Unity.Mathematics.quaternion q2, System.Single t)
  Unity.Mathematics.quaternion slerp(Unity.Mathematics.quaternion q1, Unity.Mathematics.quaternion q2, System.Single t)
  System.Single angle(Unity.Mathematics.quaternion q1, Unity.Mathematics.quaternion q2)
  Unity.Mathematics.quaternion rotation(Unity.Mathematics.float3x3 m)
  Unity.Mathematics.float3x3 adj(Unity.Mathematics.float3x3 m, System.Single& det)
  System.Boolean adjInverse(Unity.Mathematics.float3x3 m, Unity.Mathematics.float3x3& i, System.Single epsilon)
  System.UInt32 hash(Unity.Mathematics.quaternion q)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.quaternion q)
  Unity.Mathematics.float3 forward(Unity.Mathematics.quaternion q)
  Unity.Mathematics.RigidTransform RigidTransform(Unity.Mathematics.quaternion rot, Unity.Mathematics.float3 pos)
  Unity.Mathematics.RigidTransform RigidTransform(Unity.Mathematics.float3x3 rotation, Unity.Mathematics.float3 translation)
  Unity.Mathematics.RigidTransform RigidTransform(Unity.Mathematics.float4x4 transform)
  Unity.Mathematics.RigidTransform inverse(Unity.Mathematics.RigidTransform t)
  Unity.Mathematics.RigidTransform mul(Unity.Mathematics.RigidTransform a, Unity.Mathematics.RigidTransform b)
  Unity.Mathematics.float4 mul(Unity.Mathematics.RigidTransform a, Unity.Mathematics.float4 pos)
  Unity.Mathematics.float3 rotate(Unity.Mathematics.RigidTransform a, Unity.Mathematics.float3 dir)
  Unity.Mathematics.float3 transform(Unity.Mathematics.RigidTransform a, Unity.Mathematics.float3 pos)
  System.UInt32 hash(Unity.Mathematics.RigidTransform t)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.RigidTransform t)
  Unity.Mathematics.uint2 uint2(System.UInt32 x, System.UInt32 y)
  Unity.Mathematics.uint2 uint2(Unity.Mathematics.uint2 xy)
  Unity.Mathematics.uint2 uint2(System.UInt32 v)
  Unity.Mathematics.uint2 uint2(System.Boolean v)
  Unity.Mathematics.uint2 uint2(Unity.Mathematics.bool2 v)
  Unity.Mathematics.uint2 uint2(System.Int32 v)
  Unity.Mathematics.uint2 uint2(Unity.Mathematics.int2 v)
  Unity.Mathematics.uint2 uint2(System.Single v)
  Unity.Mathematics.uint2 uint2(Unity.Mathematics.float2 v)
  Unity.Mathematics.uint2 uint2(System.Double v)
  Unity.Mathematics.uint2 uint2(Unity.Mathematics.double2 v)
  System.UInt32 hash(Unity.Mathematics.uint2 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.uint2 v)
  System.UInt32 shuffle(Unity.Mathematics.uint2 left, Unity.Mathematics.uint2 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.uint2 shuffle(Unity.Mathematics.uint2 left, Unity.Mathematics.uint2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.uint3 shuffle(Unity.Mathematics.uint2 left, Unity.Mathematics.uint2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.uint4 shuffle(Unity.Mathematics.uint2 left, Unity.Mathematics.uint2 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.UInt32 select_shuffle_component(Unity.Mathematics.uint2 a, Unity.Mathematics.uint2 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1)
  Unity.Mathematics.uint2x2 uint2x2(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11)
  Unity.Mathematics.uint2x2 uint2x2(System.UInt32 v)
  Unity.Mathematics.uint2x2 uint2x2(System.Boolean v)
  Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.bool2x2 v)
  Unity.Mathematics.uint2x2 uint2x2(System.Int32 v)
  Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.int2x2 v)
  Unity.Mathematics.uint2x2 uint2x2(System.Single v)
  Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.float2x2 v)
  Unity.Mathematics.uint2x2 uint2x2(System.Double v)
  Unity.Mathematics.uint2x2 uint2x2(Unity.Mathematics.double2x2 v)
  Unity.Mathematics.uint2x2 transpose(Unity.Mathematics.uint2x2 v)
  System.UInt32 hash(Unity.Mathematics.uint2x2 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.uint2x2 v)
  Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1, Unity.Mathematics.uint2 c2)
  Unity.Mathematics.uint2x3 uint2x3(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12)
  Unity.Mathematics.uint2x3 uint2x3(System.UInt32 v)
  Unity.Mathematics.uint2x3 uint2x3(System.Boolean v)
  Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.bool2x3 v)
  Unity.Mathematics.uint2x3 uint2x3(System.Int32 v)
  Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.int2x3 v)
  Unity.Mathematics.uint2x3 uint2x3(System.Single v)
  Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.float2x3 v)
  Unity.Mathematics.uint2x3 uint2x3(System.Double v)
  Unity.Mathematics.uint2x3 uint2x3(Unity.Mathematics.double2x3 v)
  Unity.Mathematics.uint3x2 transpose(Unity.Mathematics.uint2x3 v)
  System.UInt32 hash(Unity.Mathematics.uint2x3 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.uint2x3 v)
  Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1, Unity.Mathematics.uint2 c2, Unity.Mathematics.uint2 c3)
  Unity.Mathematics.uint2x4 uint2x4(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13)
  Unity.Mathematics.uint2x4 uint2x4(System.UInt32 v)
  Unity.Mathematics.uint2x4 uint2x4(System.Boolean v)
  Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.bool2x4 v)
  Unity.Mathematics.uint2x4 uint2x4(System.Int32 v)
  Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.int2x4 v)
  Unity.Mathematics.uint2x4 uint2x4(System.Single v)
  Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.float2x4 v)
  Unity.Mathematics.uint2x4 uint2x4(System.Double v)
  Unity.Mathematics.uint2x4 uint2x4(Unity.Mathematics.double2x4 v)
  Unity.Mathematics.uint4x2 transpose(Unity.Mathematics.uint2x4 v)
  System.UInt32 hash(Unity.Mathematics.uint2x4 v)
  Unity.Mathematics.uint2 hashwide(Unity.Mathematics.uint2x4 v)
  Unity.Mathematics.uint3 uint3(System.UInt32 x, System.UInt32 y, System.UInt32 z)
  Unity.Mathematics.uint3 uint3(System.UInt32 x, Unity.Mathematics.uint2 yz)
  Unity.Mathematics.uint3 uint3(Unity.Mathematics.uint2 xy, System.UInt32 z)
  Unity.Mathematics.uint3 uint3(Unity.Mathematics.uint3 xyz)
  Unity.Mathematics.uint3 uint3(System.UInt32 v)
  Unity.Mathematics.uint3 uint3(System.Boolean v)
  Unity.Mathematics.uint3 uint3(Unity.Mathematics.bool3 v)
  Unity.Mathematics.uint3 uint3(System.Int32 v)
  Unity.Mathematics.uint3 uint3(Unity.Mathematics.int3 v)
  Unity.Mathematics.uint3 uint3(System.Single v)
  Unity.Mathematics.uint3 uint3(Unity.Mathematics.float3 v)
  Unity.Mathematics.uint3 uint3(System.Double v)
  Unity.Mathematics.uint3 uint3(Unity.Mathematics.double3 v)
  System.UInt32 hash(Unity.Mathematics.uint3 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.uint3 v)
  System.UInt32 shuffle(Unity.Mathematics.uint3 left, Unity.Mathematics.uint3 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.uint2 shuffle(Unity.Mathematics.uint3 left, Unity.Mathematics.uint3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.uint3 shuffle(Unity.Mathematics.uint3 left, Unity.Mathematics.uint3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.uint4 shuffle(Unity.Mathematics.uint3 left, Unity.Mathematics.uint3 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.UInt32 select_shuffle_component(Unity.Mathematics.uint3 a, Unity.Mathematics.uint3 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1)
  Unity.Mathematics.uint3x2 uint3x2(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11, System.UInt32 m20, System.UInt32 m21)
  Unity.Mathematics.uint3x2 uint3x2(System.UInt32 v)
  Unity.Mathematics.uint3x2 uint3x2(System.Boolean v)
  Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.bool3x2 v)
  Unity.Mathematics.uint3x2 uint3x2(System.Int32 v)
  Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.int3x2 v)
  Unity.Mathematics.uint3x2 uint3x2(System.Single v)
  Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.float3x2 v)
  Unity.Mathematics.uint3x2 uint3x2(System.Double v)
  Unity.Mathematics.uint3x2 uint3x2(Unity.Mathematics.double3x2 v)
  Unity.Mathematics.uint2x3 transpose(Unity.Mathematics.uint3x2 v)
  System.UInt32 hash(Unity.Mathematics.uint3x2 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.uint3x2 v)
  Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1, Unity.Mathematics.uint3 c2)
  Unity.Mathematics.uint3x3 uint3x3(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22)
  Unity.Mathematics.uint3x3 uint3x3(System.UInt32 v)
  Unity.Mathematics.uint3x3 uint3x3(System.Boolean v)
  Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.bool3x3 v)
  Unity.Mathematics.uint3x3 uint3x3(System.Int32 v)
  Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.int3x3 v)
  Unity.Mathematics.uint3x3 uint3x3(System.Single v)
  Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.float3x3 v)
  Unity.Mathematics.uint3x3 uint3x3(System.Double v)
  Unity.Mathematics.uint3x3 uint3x3(Unity.Mathematics.double3x3 v)
  Unity.Mathematics.uint3x3 transpose(Unity.Mathematics.uint3x3 v)
  System.UInt32 hash(Unity.Mathematics.uint3x3 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.uint3x3 v)
  Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1, Unity.Mathematics.uint3 c2, Unity.Mathematics.uint3 c3)
  Unity.Mathematics.uint3x4 uint3x4(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m23)
  Unity.Mathematics.uint3x4 uint3x4(System.UInt32 v)
  Unity.Mathematics.uint3x4 uint3x4(System.Boolean v)
  Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.bool3x4 v)
  Unity.Mathematics.uint3x4 uint3x4(System.Int32 v)
  Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.int3x4 v)
  Unity.Mathematics.uint3x4 uint3x4(System.Single v)
  Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.float3x4 v)
  Unity.Mathematics.uint3x4 uint3x4(System.Double v)
  Unity.Mathematics.uint3x4 uint3x4(Unity.Mathematics.double3x4 v)
  Unity.Mathematics.uint4x3 transpose(Unity.Mathematics.uint3x4 v)
  System.UInt32 hash(Unity.Mathematics.uint3x4 v)
  Unity.Mathematics.uint3 hashwide(Unity.Mathematics.uint3x4 v)
  Unity.Mathematics.uint4 uint4(System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w)
  Unity.Mathematics.uint4 uint4(System.UInt32 x, System.UInt32 y, Unity.Mathematics.uint2 zw)
  Unity.Mathematics.uint4 uint4(System.UInt32 x, Unity.Mathematics.uint2 yz, System.UInt32 w)
  Unity.Mathematics.uint4 uint4(System.UInt32 x, Unity.Mathematics.uint3 yzw)
  Unity.Mathematics.uint4 uint4(Unity.Mathematics.uint2 xy, System.UInt32 z, System.UInt32 w)
  Unity.Mathematics.uint4 uint4(Unity.Mathematics.uint2 xy, Unity.Mathematics.uint2 zw)
  Unity.Mathematics.uint4 uint4(Unity.Mathematics.uint3 xyz, System.UInt32 w)
  Unity.Mathematics.uint4 uint4(Unity.Mathematics.uint4 xyzw)
  Unity.Mathematics.uint4 uint4(System.UInt32 v)
  Unity.Mathematics.uint4 uint4(System.Boolean v)
  Unity.Mathematics.uint4 uint4(Unity.Mathematics.bool4 v)
  Unity.Mathematics.uint4 uint4(System.Int32 v)
  Unity.Mathematics.uint4 uint4(Unity.Mathematics.int4 v)
  Unity.Mathematics.uint4 uint4(System.Single v)
  Unity.Mathematics.uint4 uint4(Unity.Mathematics.float4 v)
  Unity.Mathematics.uint4 uint4(System.Double v)
  Unity.Mathematics.uint4 uint4(Unity.Mathematics.double4 v)
  System.UInt32 hash(Unity.Mathematics.uint4 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.uint4 v)
  System.UInt32 shuffle(Unity.Mathematics.uint4 left, Unity.Mathematics.uint4 right, Unity.Mathematics.math.ShuffleComponent x)
  Unity.Mathematics.uint2 shuffle(Unity.Mathematics.uint4 left, Unity.Mathematics.uint4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y)
  Unity.Mathematics.uint3 shuffle(Unity.Mathematics.uint4 left, Unity.Mathematics.uint4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z)
  Unity.Mathematics.uint4 shuffle(Unity.Mathematics.uint4 left, Unity.Mathematics.uint4 right, Unity.Mathematics.math.ShuffleComponent x, Unity.Mathematics.math.ShuffleComponent y, Unity.Mathematics.math.ShuffleComponent z, Unity.Mathematics.math.ShuffleComponent w)
  System.UInt32 select_shuffle_component(Unity.Mathematics.uint4 a, Unity.Mathematics.uint4 b, Unity.Mathematics.math.ShuffleComponent component)
  Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1)
  Unity.Mathematics.uint4x2 uint4x2(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11, System.UInt32 m20, System.UInt32 m21, System.UInt32 m30, System.UInt32 m31)
  Unity.Mathematics.uint4x2 uint4x2(System.UInt32 v)
  Unity.Mathematics.uint4x2 uint4x2(System.Boolean v)
  Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.bool4x2 v)
  Unity.Mathematics.uint4x2 uint4x2(System.Int32 v)
  Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.int4x2 v)
  Unity.Mathematics.uint4x2 uint4x2(System.Single v)
  Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.float4x2 v)
  Unity.Mathematics.uint4x2 uint4x2(System.Double v)
  Unity.Mathematics.uint4x2 uint4x2(Unity.Mathematics.double4x2 v)
  Unity.Mathematics.uint2x4 transpose(Unity.Mathematics.uint4x2 v)
  System.UInt32 hash(Unity.Mathematics.uint4x2 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.uint4x2 v)
  Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1, Unity.Mathematics.uint4 c2)
  Unity.Mathematics.uint4x3 uint4x3(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m30, System.UInt32 m31, System.UInt32 m32)
  Unity.Mathematics.uint4x3 uint4x3(System.UInt32 v)
  Unity.Mathematics.uint4x3 uint4x3(System.Boolean v)
  Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.bool4x3 v)
  Unity.Mathematics.uint4x3 uint4x3(System.Int32 v)
  Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.int4x3 v)
  Unity.Mathematics.uint4x3 uint4x3(System.Single v)
  Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.float4x3 v)
  Unity.Mathematics.uint4x3 uint4x3(System.Double v)
  Unity.Mathematics.uint4x3 uint4x3(Unity.Mathematics.double4x3 v)
  Unity.Mathematics.uint3x4 transpose(Unity.Mathematics.uint4x3 v)
  System.UInt32 hash(Unity.Mathematics.uint4x3 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.uint4x3 v)
  Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1, Unity.Mathematics.uint4 c2, Unity.Mathematics.uint4 c3)
  Unity.Mathematics.uint4x4 uint4x4(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m23, System.UInt32 m30, System.UInt32 m31, System.UInt32 m32, System.UInt32 m33)
  Unity.Mathematics.uint4x4 uint4x4(System.UInt32 v)
  Unity.Mathematics.uint4x4 uint4x4(System.Boolean v)
  Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.bool4x4 v)
  Unity.Mathematics.uint4x4 uint4x4(System.Int32 v)
  Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.int4x4 v)
  Unity.Mathematics.uint4x4 uint4x4(System.Single v)
  Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.float4x4 v)
  Unity.Mathematics.uint4x4 uint4x4(System.Double v)
  Unity.Mathematics.uint4x4 uint4x4(Unity.Mathematics.double4x4 v)
  Unity.Mathematics.uint4x4 transpose(Unity.Mathematics.uint4x4 v)
  System.UInt32 hash(Unity.Mathematics.uint4x4 v)
  Unity.Mathematics.uint4 hashwide(Unity.Mathematics.uint4x4 v)
END_CLASS

CLASS: Unity.Mathematics.bool2
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Boolean                  x  // 0x10
  public            System.Boolean                  y  // 0x11
METHODS:
  System.Void .ctor(System.Boolean x, System.Boolean y)
  System.Void .ctor(Unity.Mathematics.bool2 xy)
  System.Void .ctor(System.Boolean v)
  Unity.Mathematics.bool2 op_Implicit(System.Boolean v)
  System.Boolean Equals(Unity.Mathematics.bool2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool2x2
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            Unity.Mathematics.bool2         c0  // 0x10
  public            Unity.Mathematics.bool2         c1  // 0x12
METHODS:
  System.Void .ctor(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1)
  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11)
  System.Void .ctor(System.Boolean v)
  System.Boolean Equals(Unity.Mathematics.bool2x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool2x3
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            Unity.Mathematics.bool2         c0  // 0x10
  public            Unity.Mathematics.bool2         c1  // 0x12
  public            Unity.Mathematics.bool2         c2  // 0x14
METHODS:
  System.Void .ctor(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1, Unity.Mathematics.bool2 c2)
  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12)
  System.Void .ctor(System.Boolean v)
  System.Boolean Equals(Unity.Mathematics.bool2x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool2x4
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            Unity.Mathematics.bool2         c0  // 0x10
  public            Unity.Mathematics.bool2         c1  // 0x12
  public            Unity.Mathematics.bool2         c2  // 0x14
  public            Unity.Mathematics.bool2         c3  // 0x16
METHODS:
  System.Void .ctor(Unity.Mathematics.bool2 c0, Unity.Mathematics.bool2 c1, Unity.Mathematics.bool2 c2, Unity.Mathematics.bool2 c3)
  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13)
  System.Void .ctor(System.Boolean v)
  System.Boolean Equals(Unity.Mathematics.bool2x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool3
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            System.Boolean                  x  // 0x10
  public            System.Boolean                  y  // 0x11
  public            System.Boolean                  z  // 0x12
METHODS:
  System.Void .ctor(System.Boolean x, System.Boolean y, System.Boolean z)
  System.Void .ctor(System.Boolean x, Unity.Mathematics.bool2 yz)
  System.Void .ctor(Unity.Mathematics.bool2 xy, System.Boolean z)
  System.Void .ctor(Unity.Mathematics.bool3 xyz)
  System.Void .ctor(System.Boolean v)
  Unity.Mathematics.bool3 op_Implicit(System.Boolean v)
  Unity.Mathematics.bool3 op_BitwiseAnd(Unity.Mathematics.bool3 lhs, Unity.Mathematics.bool3 rhs)
  Unity.Mathematics.bool3 op_BitwiseOr(Unity.Mathematics.bool3 lhs, Unity.Mathematics.bool3 rhs)
  System.Boolean Equals(Unity.Mathematics.bool3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool3x2
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            Unity.Mathematics.bool3         c0  // 0x10
  public            Unity.Mathematics.bool3         c1  // 0x13
METHODS:
  System.Void .ctor(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1)
  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11, System.Boolean m20, System.Boolean m21)
  System.Void .ctor(System.Boolean v)
  System.Boolean Equals(Unity.Mathematics.bool3x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool3x3
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public            Unity.Mathematics.bool3         c0  // 0x10
  public            Unity.Mathematics.bool3         c1  // 0x13
  public            Unity.Mathematics.bool3         c2  // 0x16
METHODS:
  System.Void .ctor(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1, Unity.Mathematics.bool3 c2)
  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m20, System.Boolean m21, System.Boolean m22)
  System.Void .ctor(System.Boolean v)
  System.Boolean Equals(Unity.Mathematics.bool3x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool3x4
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            Unity.Mathematics.bool3         c0  // 0x10
  public            Unity.Mathematics.bool3         c1  // 0x13
  public            Unity.Mathematics.bool3         c2  // 0x16
  public            Unity.Mathematics.bool3         c3  // 0x19
METHODS:
  System.Void .ctor(Unity.Mathematics.bool3 c0, Unity.Mathematics.bool3 c1, Unity.Mathematics.bool3 c2, Unity.Mathematics.bool3 c3)
  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m23)
  System.Void .ctor(System.Boolean v)
  System.Boolean Equals(Unity.Mathematics.bool3x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool4
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public            System.Boolean                  x  // 0x10
  public            System.Boolean                  y  // 0x11
  public            System.Boolean                  z  // 0x12
  public            System.Boolean                  w  // 0x13
METHODS:
  System.Void .ctor(System.Boolean x, System.Boolean y, System.Boolean z, System.Boolean w)
  System.Void .ctor(System.Boolean x, System.Boolean y, Unity.Mathematics.bool2 zw)
  System.Void .ctor(System.Boolean x, Unity.Mathematics.bool2 yz, System.Boolean w)
  System.Void .ctor(System.Boolean x, Unity.Mathematics.bool3 yzw)
  System.Void .ctor(Unity.Mathematics.bool2 xy, System.Boolean z, System.Boolean w)
  System.Void .ctor(Unity.Mathematics.bool2 xy, Unity.Mathematics.bool2 zw)
  System.Void .ctor(Unity.Mathematics.bool3 xyz, System.Boolean w)
  System.Void .ctor(Unity.Mathematics.bool4 xyzw)
  System.Void .ctor(System.Boolean v)
  Unity.Mathematics.bool4 op_Implicit(System.Boolean v)
  System.Void set_Item(System.Int32 index, System.Boolean value)
  System.Boolean Equals(Unity.Mathematics.bool4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool4x2
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            Unity.Mathematics.bool4         c0  // 0x10
  public            Unity.Mathematics.bool4         c1  // 0x14
METHODS:
  System.Void .ctor(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1)
  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m10, System.Boolean m11, System.Boolean m20, System.Boolean m21, System.Boolean m30, System.Boolean m31)
  System.Void .ctor(System.Boolean v)
  System.Boolean Equals(Unity.Mathematics.bool4x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool4x3
TYPE:  struct
TOKEN: 0x2000015
FIELDS:
  public            Unity.Mathematics.bool4         c0  // 0x10
  public            Unity.Mathematics.bool4         c1  // 0x14
  public            Unity.Mathematics.bool4         c2  // 0x18
METHODS:
  System.Void .ctor(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1, Unity.Mathematics.bool4 c2)
  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m30, System.Boolean m31, System.Boolean m32)
  System.Void .ctor(System.Boolean v)
  System.Boolean Equals(Unity.Mathematics.bool4x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.bool4x4
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            Unity.Mathematics.bool4         c0  // 0x10
  public            Unity.Mathematics.bool4         c1  // 0x14
  public            Unity.Mathematics.bool4         c2  // 0x18
  public            Unity.Mathematics.bool4         c3  // 0x1C
METHODS:
  System.Void .ctor(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1, Unity.Mathematics.bool4 c2, Unity.Mathematics.bool4 c3)
  System.Void .ctor(System.Boolean m00, System.Boolean m01, System.Boolean m02, System.Boolean m03, System.Boolean m10, System.Boolean m11, System.Boolean m12, System.Boolean m13, System.Boolean m20, System.Boolean m21, System.Boolean m22, System.Boolean m23, System.Boolean m30, System.Boolean m31, System.Boolean m32, System.Boolean m33)
  System.Void .ctor(System.Boolean v)
  System.Boolean Equals(Unity.Mathematics.bool4x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
END_CLASS

CLASS: Unity.Mathematics.double2
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Double                   x  // 0x10
  public            System.Double                   y  // 0x18
METHODS:
  System.Void .ctor(System.Double x, System.Double y)
  System.Void .ctor(Unity.Mathematics.double2 xy)
  System.Void .ctor(System.Double v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int2 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint2 v)
  System.Void .ctor(Unity.Mathematics.half v)
  System.Void .ctor(Unity.Mathematics.half2 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float2 v)
  Unity.Mathematics.double2 op_Implicit(System.Double v)
  Unity.Mathematics.double2 op_Implicit(System.Int32 v)
  Unity.Mathematics.double2 op_Implicit(Unity.Mathematics.int2 v)
  Unity.Mathematics.double2 op_Implicit(System.UInt32 v)
  Unity.Mathematics.double2 op_Implicit(Unity.Mathematics.uint2 v)
  Unity.Mathematics.double2 op_Implicit(System.Single v)
  Unity.Mathematics.double2 op_Implicit(Unity.Mathematics.float2 v)
  Unity.Mathematics.double2 op_Multiply(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs)
  Unity.Mathematics.double2 op_Multiply(Unity.Mathematics.double2 lhs, System.Double rhs)
  Unity.Mathematics.double2 op_Multiply(System.Double lhs, Unity.Mathematics.double2 rhs)
  Unity.Mathematics.double2 op_Addition(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs)
  Unity.Mathematics.double2 op_Subtraction(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs)
  Unity.Mathematics.double2 op_Subtraction(System.Double lhs, Unity.Mathematics.double2 rhs)
  Unity.Mathematics.double2 op_Division(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs)
  Unity.Mathematics.double2 op_Division(System.Double lhs, Unity.Mathematics.double2 rhs)
  Unity.Mathematics.bool2 op_LessThan(Unity.Mathematics.double2 lhs, System.Double rhs)
  Unity.Mathematics.bool2 op_GreaterThanOrEqual(Unity.Mathematics.double2 lhs, Unity.Mathematics.double2 rhs)
  Unity.Mathematics.double2 op_UnaryNegation(Unity.Mathematics.double2 val)
  Unity.Mathematics.bool2 op_Equality(Unity.Mathematics.double2 lhs, System.Double rhs)
  System.Boolean Equals(Unity.Mathematics.double2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double2x2
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            Unity.Mathematics.double2       c0  // 0x10
  public            Unity.Mathematics.double2       c1  // 0x20
  public    static readonly Unity.Mathematics.double2x2     identity  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1)
  System.Void .ctor(System.Double m00, System.Double m01, System.Double m10, System.Double m11)
  System.Void .ctor(System.Double v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2x2 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int2x2 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint2x2 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float2x2 v)
  Unity.Mathematics.double2x2 op_Multiply(Unity.Mathematics.double2x2 lhs, System.Double rhs)
  System.Boolean Equals(Unity.Mathematics.double2x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.double2x3
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            Unity.Mathematics.double2       c0  // 0x10
  public            Unity.Mathematics.double2       c1  // 0x20
  public            Unity.Mathematics.double2       c2  // 0x30
METHODS:
  System.Void .ctor(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1, Unity.Mathematics.double2 c2)
  System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12)
  System.Void .ctor(System.Double v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2x3 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int2x3 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint2x3 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float2x3 v)
  System.Boolean Equals(Unity.Mathematics.double2x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double2x4
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  public            Unity.Mathematics.double2       c0  // 0x10
  public            Unity.Mathematics.double2       c1  // 0x20
  public            Unity.Mathematics.double2       c2  // 0x30
  public            Unity.Mathematics.double2       c3  // 0x40
METHODS:
  System.Void .ctor(Unity.Mathematics.double2 c0, Unity.Mathematics.double2 c1, Unity.Mathematics.double2 c2, Unity.Mathematics.double2 c3)
  System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13)
  System.Void .ctor(System.Double v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2x4 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int2x4 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint2x4 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float2x4 v)
  System.Boolean Equals(Unity.Mathematics.double2x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double3
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Double                   x  // 0x10
  public            System.Double                   y  // 0x18
  public            System.Double                   z  // 0x20
METHODS:
  System.Void .ctor(System.Double x, System.Double y, System.Double z)
  System.Void .ctor(System.Double x, Unity.Mathematics.double2 yz)
  System.Void .ctor(Unity.Mathematics.double2 xy, System.Double z)
  System.Void .ctor(Unity.Mathematics.double3 xyz)
  System.Void .ctor(System.Double v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int3 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint3 v)
  System.Void .ctor(Unity.Mathematics.half v)
  System.Void .ctor(Unity.Mathematics.half3 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float3 v)
  Unity.Mathematics.double3 op_Implicit(System.Double v)
  Unity.Mathematics.double3 op_Implicit(System.Int32 v)
  Unity.Mathematics.double3 op_Implicit(Unity.Mathematics.int3 v)
  Unity.Mathematics.double3 op_Implicit(System.UInt32 v)
  Unity.Mathematics.double3 op_Implicit(Unity.Mathematics.uint3 v)
  Unity.Mathematics.double3 op_Implicit(System.Single v)
  Unity.Mathematics.double3 op_Implicit(Unity.Mathematics.float3 v)
  Unity.Mathematics.double3 op_Multiply(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs)
  Unity.Mathematics.double3 op_Multiply(Unity.Mathematics.double3 lhs, System.Double rhs)
  Unity.Mathematics.double3 op_Multiply(System.Double lhs, Unity.Mathematics.double3 rhs)
  Unity.Mathematics.double3 op_Addition(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs)
  Unity.Mathematics.double3 op_Subtraction(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs)
  Unity.Mathematics.double3 op_Subtraction(System.Double lhs, Unity.Mathematics.double3 rhs)
  Unity.Mathematics.double3 op_Division(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs)
  Unity.Mathematics.double3 op_Division(System.Double lhs, Unity.Mathematics.double3 rhs)
  Unity.Mathematics.bool3 op_LessThan(Unity.Mathematics.double3 lhs, System.Double rhs)
  Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.double3 lhs, Unity.Mathematics.double3 rhs)
  Unity.Mathematics.double3 op_UnaryNegation(Unity.Mathematics.double3 val)
  Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.double3 lhs, System.Double rhs)
  Unity.Mathematics.double3 get_yzx()
  Unity.Mathematics.double3 get_zxy()
  System.Boolean Equals(Unity.Mathematics.double3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double3x2
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            Unity.Mathematics.double3       c0  // 0x10
  public            Unity.Mathematics.double3       c1  // 0x28
METHODS:
  System.Void .ctor(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1)
  System.Void .ctor(System.Double m00, System.Double m01, System.Double m10, System.Double m11, System.Double m20, System.Double m21)
  System.Void .ctor(System.Double v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3x2 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int3x2 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint3x2 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float3x2 v)
  System.Boolean Equals(Unity.Mathematics.double3x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double3x3
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            Unity.Mathematics.double3       c0  // 0x10
  public            Unity.Mathematics.double3       c1  // 0x28
  public            Unity.Mathematics.double3       c2  // 0x40
  public    static readonly Unity.Mathematics.double3x3     identity  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1, Unity.Mathematics.double3 c2)
  System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12, System.Double m20, System.Double m21, System.Double m22)
  System.Void .ctor(System.Double v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3x3 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int3x3 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint3x3 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float3x3 v)
  Unity.Mathematics.double3x3 op_Multiply(Unity.Mathematics.double3x3 lhs, System.Double rhs)
  System.Boolean Equals(Unity.Mathematics.double3x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.double3x4
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            Unity.Mathematics.double3       c0  // 0x10
  public            Unity.Mathematics.double3       c1  // 0x28
  public            Unity.Mathematics.double3       c2  // 0x40
  public            Unity.Mathematics.double3       c3  // 0x58
METHODS:
  System.Void .ctor(Unity.Mathematics.double3 c0, Unity.Mathematics.double3 c1, Unity.Mathematics.double3 c2, Unity.Mathematics.double3 c3)
  System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13, System.Double m20, System.Double m21, System.Double m22, System.Double m23)
  System.Void .ctor(System.Double v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3x4 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int3x4 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint3x4 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float3x4 v)
  System.Boolean Equals(Unity.Mathematics.double3x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double4
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            System.Double                   x  // 0x10
  public            System.Double                   y  // 0x18
  public            System.Double                   z  // 0x20
  public            System.Double                   w  // 0x28
METHODS:
  System.Void .ctor(System.Double x, System.Double y, System.Double z, System.Double w)
  System.Void .ctor(System.Double x, System.Double y, Unity.Mathematics.double2 zw)
  System.Void .ctor(System.Double x, Unity.Mathematics.double2 yz, System.Double w)
  System.Void .ctor(System.Double x, Unity.Mathematics.double3 yzw)
  System.Void .ctor(Unity.Mathematics.double2 xy, System.Double z, System.Double w)
  System.Void .ctor(Unity.Mathematics.double2 xy, Unity.Mathematics.double2 zw)
  System.Void .ctor(Unity.Mathematics.double3 xyz, System.Double w)
  System.Void .ctor(Unity.Mathematics.double4 xyzw)
  System.Void .ctor(System.Double v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int4 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint4 v)
  System.Void .ctor(Unity.Mathematics.half v)
  System.Void .ctor(Unity.Mathematics.half4 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float4 v)
  Unity.Mathematics.double4 op_Implicit(System.Double v)
  Unity.Mathematics.double4 op_Implicit(System.Int32 v)
  Unity.Mathematics.double4 op_Implicit(Unity.Mathematics.int4 v)
  Unity.Mathematics.double4 op_Implicit(System.UInt32 v)
  Unity.Mathematics.double4 op_Implicit(Unity.Mathematics.uint4 v)
  Unity.Mathematics.double4 op_Implicit(System.Single v)
  Unity.Mathematics.double4 op_Implicit(Unity.Mathematics.float4 v)
  Unity.Mathematics.double4 op_Multiply(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs)
  Unity.Mathematics.double4 op_Multiply(Unity.Mathematics.double4 lhs, System.Double rhs)
  Unity.Mathematics.double4 op_Multiply(System.Double lhs, Unity.Mathematics.double4 rhs)
  Unity.Mathematics.double4 op_Addition(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs)
  Unity.Mathematics.double4 op_Subtraction(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs)
  Unity.Mathematics.double4 op_Subtraction(System.Double lhs, Unity.Mathematics.double4 rhs)
  Unity.Mathematics.double4 op_Division(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs)
  Unity.Mathematics.double4 op_Division(System.Double lhs, Unity.Mathematics.double4 rhs)
  Unity.Mathematics.bool4 op_LessThan(Unity.Mathematics.double4 lhs, System.Double rhs)
  Unity.Mathematics.bool4 op_GreaterThanOrEqual(Unity.Mathematics.double4 lhs, Unity.Mathematics.double4 rhs)
  Unity.Mathematics.double4 op_UnaryNegation(Unity.Mathematics.double4 val)
  Unity.Mathematics.bool4 op_Equality(Unity.Mathematics.double4 lhs, System.Double rhs)
  Unity.Mathematics.double3 get_xyz()
  System.Boolean Equals(Unity.Mathematics.double4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double4x2
TYPE:  struct
TOKEN: 0x2000023
FIELDS:
  public            Unity.Mathematics.double4       c0  // 0x10
  public            Unity.Mathematics.double4       c1  // 0x30
METHODS:
  System.Void .ctor(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1)
  System.Void .ctor(System.Double m00, System.Double m01, System.Double m10, System.Double m11, System.Double m20, System.Double m21, System.Double m30, System.Double m31)
  System.Void .ctor(System.Double v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4x2 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int4x2 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint4x2 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float4x2 v)
  System.Boolean Equals(Unity.Mathematics.double4x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double4x3
TYPE:  struct
TOKEN: 0x2000024
FIELDS:
  public            Unity.Mathematics.double4       c0  // 0x10
  public            Unity.Mathematics.double4       c1  // 0x30
  public            Unity.Mathematics.double4       c2  // 0x50
METHODS:
  System.Void .ctor(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1, Unity.Mathematics.double4 c2)
  System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m10, System.Double m11, System.Double m12, System.Double m20, System.Double m21, System.Double m22, System.Double m30, System.Double m31, System.Double m32)
  System.Void .ctor(System.Double v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4x3 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int4x3 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint4x3 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float4x3 v)
  System.Boolean Equals(Unity.Mathematics.double4x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.double4x4
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  public            Unity.Mathematics.double4       c0  // 0x10
  public            Unity.Mathematics.double4       c1  // 0x30
  public            Unity.Mathematics.double4       c2  // 0x50
  public            Unity.Mathematics.double4       c3  // 0x70
  public    static readonly Unity.Mathematics.double4x4     identity  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.double4 c0, Unity.Mathematics.double4 c1, Unity.Mathematics.double4 c2, Unity.Mathematics.double4 c3)
  System.Void .ctor(System.Double m00, System.Double m01, System.Double m02, System.Double m03, System.Double m10, System.Double m11, System.Double m12, System.Double m13, System.Double m20, System.Double m21, System.Double m22, System.Double m23, System.Double m30, System.Double m31, System.Double m32, System.Double m33)
  System.Void .ctor(System.Double v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4x4 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int4x4 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint4x4 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float4x4 v)
  System.Boolean Equals(Unity.Mathematics.double4x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.float2
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public    static readonly Unity.Mathematics.float2        zero  // 0x0
METHODS:
  System.Void .ctor(System.Single x, System.Single y)
  System.Void .ctor(Unity.Mathematics.float2 xy)
  System.Void .ctor(System.Single v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int2 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint2 v)
  System.Void .ctor(Unity.Mathematics.half v)
  System.Void .ctor(Unity.Mathematics.half2 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double2 v)
  Unity.Mathematics.float2 op_Implicit(System.Single v)
  Unity.Mathematics.float2 op_Implicit(System.Int32 v)
  Unity.Mathematics.float2 op_Implicit(Unity.Mathematics.int2 v)
  Unity.Mathematics.float2 op_Implicit(System.UInt32 v)
  Unity.Mathematics.float2 op_Implicit(Unity.Mathematics.uint2 v)
  Unity.Mathematics.float2 op_Explicit(System.Double v)
  Unity.Mathematics.float2 op_Explicit(Unity.Mathematics.double2 v)
  Unity.Mathematics.float2 op_Multiply(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs)
  Unity.Mathematics.float2 op_Multiply(Unity.Mathematics.float2 lhs, System.Single rhs)
  Unity.Mathematics.float2 op_Multiply(System.Single lhs, Unity.Mathematics.float2 rhs)
  Unity.Mathematics.float2 op_Addition(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs)
  Unity.Mathematics.float2 op_Addition(Unity.Mathematics.float2 lhs, System.Single rhs)
  Unity.Mathematics.float2 op_Subtraction(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs)
  Unity.Mathematics.float2 op_Subtraction(Unity.Mathematics.float2 lhs, System.Single rhs)
  Unity.Mathematics.float2 op_Subtraction(System.Single lhs, Unity.Mathematics.float2 rhs)
  Unity.Mathematics.float2 op_Division(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs)
  Unity.Mathematics.float2 op_Division(Unity.Mathematics.float2 lhs, System.Single rhs)
  Unity.Mathematics.float2 op_Division(System.Single lhs, Unity.Mathematics.float2 rhs)
  Unity.Mathematics.float2 op_Modulus(Unity.Mathematics.float2 lhs, System.Single rhs)
  Unity.Mathematics.bool2 op_LessThan(Unity.Mathematics.float2 lhs, System.Single rhs)
  Unity.Mathematics.bool2 op_LessThanOrEqual(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs)
  Unity.Mathematics.bool2 op_GreaterThanOrEqual(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs)
  Unity.Mathematics.float2 op_UnaryNegation(Unity.Mathematics.float2 val)
  Unity.Mathematics.bool2 op_Equality(Unity.Mathematics.float2 lhs, System.Single rhs)
  Unity.Mathematics.float4 get_xyxy()
  Unity.Mathematics.float2 get_xy()
  Unity.Mathematics.float2 get_yx()
  System.Boolean Equals(Unity.Mathematics.float2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  UnityEngine.Vector2 op_Implicit(Unity.Mathematics.float2 v)
  Unity.Mathematics.float2 op_Implicit(UnityEngine.Vector2 v)
END_CLASS

CLASS: Unity.Mathematics.float2x2
TYPE:  struct
TOKEN: 0x2000028
FIELDS:
  public            Unity.Mathematics.float2        c0  // 0x10
  public            Unity.Mathematics.float2        c1  // 0x18
  public    static readonly Unity.Mathematics.float2x2      identity  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1)
  System.Void .ctor(System.Single m00, System.Single m01, System.Single m10, System.Single m11)
  System.Void .ctor(System.Single v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2x2 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int2x2 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint2x2 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double2x2 v)
  Unity.Mathematics.float2x2 op_Multiply(Unity.Mathematics.float2x2 lhs, System.Single rhs)
  System.Boolean Equals(Unity.Mathematics.float2x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.float2x3
TYPE:  struct
TOKEN: 0x2000029
FIELDS:
  public            Unity.Mathematics.float2        c0  // 0x10
  public            Unity.Mathematics.float2        c1  // 0x18
  public            Unity.Mathematics.float2        c2  // 0x20
METHODS:
  System.Void .ctor(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1, Unity.Mathematics.float2 c2)
  System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12)
  System.Void .ctor(System.Single v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2x3 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int2x3 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint2x3 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double2x3 v)
  System.Boolean Equals(Unity.Mathematics.float2x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.float2x4
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            Unity.Mathematics.float2        c0  // 0x10
  public            Unity.Mathematics.float2        c1  // 0x18
  public            Unity.Mathematics.float2        c2  // 0x20
  public            Unity.Mathematics.float2        c3  // 0x28
METHODS:
  System.Void .ctor(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1, Unity.Mathematics.float2 c2, Unity.Mathematics.float2 c3)
  System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13)
  System.Void .ctor(System.Single v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2x4 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int2x4 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint2x4 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double2x4 v)
  System.Boolean Equals(Unity.Mathematics.float2x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.float3
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public            System.Single                   z  // 0x18
  public    static readonly Unity.Mathematics.float3        zero  // 0x0
METHODS:
  System.Void .ctor(System.Single x, System.Single y, System.Single z)
  System.Void .ctor(System.Single x, Unity.Mathematics.float2 yz)
  System.Void .ctor(Unity.Mathematics.float2 xy, System.Single z)
  System.Void .ctor(Unity.Mathematics.float3 xyz)
  System.Void .ctor(System.Single v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int3 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint3 v)
  System.Void .ctor(Unity.Mathematics.half v)
  System.Void .ctor(Unity.Mathematics.half3 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double3 v)
  Unity.Mathematics.float3 op_Implicit(System.Single v)
  Unity.Mathematics.float3 op_Explicit(System.Boolean v)
  Unity.Mathematics.float3 op_Explicit(Unity.Mathematics.bool3 v)
  Unity.Mathematics.float3 op_Implicit(System.Int32 v)
  Unity.Mathematics.float3 op_Implicit(Unity.Mathematics.int3 v)
  Unity.Mathematics.float3 op_Implicit(System.UInt32 v)
  Unity.Mathematics.float3 op_Implicit(Unity.Mathematics.uint3 v)
  Unity.Mathematics.float3 op_Implicit(Unity.Mathematics.half v)
  Unity.Mathematics.float3 op_Implicit(Unity.Mathematics.half3 v)
  Unity.Mathematics.float3 op_Explicit(System.Double v)
  Unity.Mathematics.float3 op_Explicit(Unity.Mathematics.double3 v)
  Unity.Mathematics.float3 op_Multiply(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.float3 op_Multiply(Unity.Mathematics.float3 lhs, System.Single rhs)
  Unity.Mathematics.float3 op_Multiply(System.Single lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.float3 op_Addition(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.float3 op_Addition(Unity.Mathematics.float3 lhs, System.Single rhs)
  Unity.Mathematics.float3 op_Addition(System.Single lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.float3 op_Subtraction(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.float3 op_Subtraction(Unity.Mathematics.float3 lhs, System.Single rhs)
  Unity.Mathematics.float3 op_Subtraction(System.Single lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.float3 op_Division(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.float3 op_Division(Unity.Mathematics.float3 lhs, System.Single rhs)
  Unity.Mathematics.float3 op_Division(System.Single lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.float3 op_Modulus(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.float3 op_Modulus(Unity.Mathematics.float3 lhs, System.Single rhs)
  Unity.Mathematics.float3 op_Modulus(System.Single lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.float3 op_Increment(Unity.Mathematics.float3 val)
  Unity.Mathematics.float3 op_Decrement(Unity.Mathematics.float3 val)
  Unity.Mathematics.bool3 op_LessThan(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.bool3 op_LessThan(Unity.Mathematics.float3 lhs, System.Single rhs)
  Unity.Mathematics.bool3 op_LessThan(System.Single lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.bool3 op_LessThanOrEqual(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.bool3 op_LessThanOrEqual(Unity.Mathematics.float3 lhs, System.Single rhs)
  Unity.Mathematics.bool3 op_LessThanOrEqual(System.Single lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.bool3 op_GreaterThan(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.bool3 op_GreaterThan(Unity.Mathematics.float3 lhs, System.Single rhs)
  Unity.Mathematics.bool3 op_GreaterThan(System.Single lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.float3 lhs, System.Single rhs)
  Unity.Mathematics.bool3 op_GreaterThanOrEqual(System.Single lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.float3 op_UnaryNegation(Unity.Mathematics.float3 val)
  Unity.Mathematics.float3 op_UnaryPlus(Unity.Mathematics.float3 val)
  Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.float3 lhs, System.Single rhs)
  Unity.Mathematics.bool3 op_Equality(System.Single lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.bool3 op_Inequality(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.bool3 op_Inequality(Unity.Mathematics.float3 lhs, System.Single rhs)
  Unity.Mathematics.bool3 op_Inequality(System.Single lhs, Unity.Mathematics.float3 rhs)
  Unity.Mathematics.float4 get_xxxx()
  Unity.Mathematics.float4 get_xxxy()
  Unity.Mathematics.float4 get_xxxz()
  Unity.Mathematics.float4 get_xxyx()
  Unity.Mathematics.float4 get_xxyy()
  Unity.Mathematics.float4 get_xxyz()
  Unity.Mathematics.float4 get_xxzx()
  Unity.Mathematics.float4 get_xxzy()
  Unity.Mathematics.float4 get_xxzz()
  Unity.Mathematics.float4 get_xyxx()
  Unity.Mathematics.float4 get_xyxy()
  Unity.Mathematics.float4 get_xyxz()
  Unity.Mathematics.float4 get_xyyx()
  Unity.Mathematics.float4 get_xyyy()
  Unity.Mathematics.float4 get_xyyz()
  Unity.Mathematics.float4 get_xyzx()
  Unity.Mathematics.float4 get_xyzy()
  Unity.Mathematics.float4 get_xyzz()
  Unity.Mathematics.float4 get_xzxx()
  Unity.Mathematics.float4 get_xzxy()
  Unity.Mathematics.float4 get_xzxz()
  Unity.Mathematics.float4 get_xzyx()
  Unity.Mathematics.float4 get_xzyy()
  Unity.Mathematics.float4 get_xzyz()
  Unity.Mathematics.float4 get_xzzx()
  Unity.Mathematics.float4 get_xzzy()
  Unity.Mathematics.float4 get_xzzz()
  Unity.Mathematics.float4 get_yxxx()
  Unity.Mathematics.float4 get_yxxy()
  Unity.Mathematics.float4 get_yxxz()
  Unity.Mathematics.float4 get_yxyx()
  Unity.Mathematics.float4 get_yxyy()
  Unity.Mathematics.float4 get_yxyz()
  Unity.Mathematics.float4 get_yxzx()
  Unity.Mathematics.float4 get_yxzy()
  Unity.Mathematics.float4 get_yxzz()
  Unity.Mathematics.float4 get_yyxx()
  Unity.Mathematics.float4 get_yyxy()
  Unity.Mathematics.float4 get_yyxz()
  Unity.Mathematics.float4 get_yyyx()
  Unity.Mathematics.float4 get_yyyy()
  Unity.Mathematics.float4 get_yyyz()
  Unity.Mathematics.float4 get_yyzx()
  Unity.Mathematics.float4 get_yyzy()
  Unity.Mathematics.float4 get_yyzz()
  Unity.Mathematics.float4 get_yzxx()
  Unity.Mathematics.float4 get_yzxy()
  Unity.Mathematics.float4 get_yzxz()
  Unity.Mathematics.float4 get_yzyx()
  Unity.Mathematics.float4 get_yzyy()
  Unity.Mathematics.float4 get_yzyz()
  Unity.Mathematics.float4 get_yzzx()
  Unity.Mathematics.float4 get_yzzy()
  Unity.Mathematics.float4 get_yzzz()
  Unity.Mathematics.float4 get_zxxx()
  Unity.Mathematics.float4 get_zxxy()
  Unity.Mathematics.float4 get_zxxz()
  Unity.Mathematics.float4 get_zxyx()
  Unity.Mathematics.float4 get_zxyy()
  Unity.Mathematics.float4 get_zxyz()
  Unity.Mathematics.float4 get_zxzx()
  Unity.Mathematics.float4 get_zxzy()
  Unity.Mathematics.float4 get_zxzz()
  Unity.Mathematics.float4 get_zyxx()
  Unity.Mathematics.float4 get_zyxy()
  Unity.Mathematics.float4 get_zyxz()
  Unity.Mathematics.float4 get_zyyx()
  Unity.Mathematics.float4 get_zyyy()
  Unity.Mathematics.float4 get_zyyz()
  Unity.Mathematics.float4 get_zyzx()
  Unity.Mathematics.float4 get_zyzy()
  Unity.Mathematics.float4 get_zyzz()
  Unity.Mathematics.float4 get_zzxx()
  Unity.Mathematics.float4 get_zzxy()
  Unity.Mathematics.float4 get_zzxz()
  Unity.Mathematics.float4 get_zzyx()
  Unity.Mathematics.float4 get_zzyy()
  Unity.Mathematics.float4 get_zzyz()
  Unity.Mathematics.float4 get_zzzx()
  Unity.Mathematics.float4 get_zzzy()
  Unity.Mathematics.float4 get_zzzz()
  Unity.Mathematics.float3 get_xxx()
  Unity.Mathematics.float3 get_xxy()
  Unity.Mathematics.float3 get_xxz()
  Unity.Mathematics.float3 get_xyx()
  Unity.Mathematics.float3 get_xyy()
  Unity.Mathematics.float3 get_xyz()
  System.Void set_xyz(Unity.Mathematics.float3 value)
  Unity.Mathematics.float3 get_xzx()
  Unity.Mathematics.float3 get_xzy()
  System.Void set_xzy(Unity.Mathematics.float3 value)
  Unity.Mathematics.float3 get_xzz()
  Unity.Mathematics.float3 get_yxx()
  Unity.Mathematics.float3 get_yxy()
  Unity.Mathematics.float3 get_yxz()
  System.Void set_yxz(Unity.Mathematics.float3 value)
  Unity.Mathematics.float3 get_yyx()
  Unity.Mathematics.float3 get_yyy()
  Unity.Mathematics.float3 get_yyz()
  Unity.Mathematics.float3 get_yzx()
  System.Void set_yzx(Unity.Mathematics.float3 value)
  Unity.Mathematics.float3 get_yzy()
  Unity.Mathematics.float3 get_yzz()
  Unity.Mathematics.float3 get_zxx()
  Unity.Mathematics.float3 get_zxy()
  System.Void set_zxy(Unity.Mathematics.float3 value)
  Unity.Mathematics.float3 get_zxz()
  Unity.Mathematics.float3 get_zyx()
  System.Void set_zyx(Unity.Mathematics.float3 value)
  Unity.Mathematics.float3 get_zyy()
  Unity.Mathematics.float3 get_zyz()
  Unity.Mathematics.float3 get_zzx()
  Unity.Mathematics.float3 get_zzy()
  Unity.Mathematics.float3 get_zzz()
  Unity.Mathematics.float2 get_xx()
  Unity.Mathematics.float2 get_xy()
  System.Void set_xy(Unity.Mathematics.float2 value)
  Unity.Mathematics.float2 get_xz()
  System.Void set_xz(Unity.Mathematics.float2 value)
  Unity.Mathematics.float2 get_yx()
  System.Void set_yx(Unity.Mathematics.float2 value)
  Unity.Mathematics.float2 get_yy()
  Unity.Mathematics.float2 get_yz()
  System.Void set_yz(Unity.Mathematics.float2 value)
  Unity.Mathematics.float2 get_zx()
  System.Void set_zx(Unity.Mathematics.float2 value)
  Unity.Mathematics.float2 get_zy()
  System.Void set_zy(Unity.Mathematics.float2 value)
  Unity.Mathematics.float2 get_zz()
  System.Single get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Single value)
  System.Boolean Equals(Unity.Mathematics.float3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  UnityEngine.Vector3 op_Implicit(Unity.Mathematics.float3 v)
  Unity.Mathematics.float3 op_Implicit(UnityEngine.Vector3 v)
END_CLASS

CLASS: Unity.Mathematics.float3x2
TYPE:  struct
TOKEN: 0x200002D
FIELDS:
  public            Unity.Mathematics.float3        c0  // 0x10
  public            Unity.Mathematics.float3        c1  // 0x1C
METHODS:
  System.Void .ctor(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1)
  System.Void .ctor(System.Single m00, System.Single m01, System.Single m10, System.Single m11, System.Single m20, System.Single m21)
  System.Void .ctor(System.Single v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3x2 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int3x2 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint3x2 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double3x2 v)
  Unity.Mathematics.float3x2 op_Implicit(System.Int32 v)
  Unity.Mathematics.float3x2 op_Multiply(Unity.Mathematics.float3x2 lhs, System.Single rhs)
  Unity.Mathematics.float3x2 op_Addition(Unity.Mathematics.float3x2 lhs, Unity.Mathematics.float3x2 rhs)
  Unity.Mathematics.float3x2 op_Subtraction(Unity.Mathematics.float3x2 lhs, Unity.Mathematics.float3x2 rhs)
  Unity.Mathematics.float3x2 op_Division(Unity.Mathematics.float3x2 lhs, System.Single rhs)
  System.Boolean Equals(Unity.Mathematics.float3x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.float3x3
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            Unity.Mathematics.float3        c0  // 0x10
  public            Unity.Mathematics.float3        c1  // 0x1C
  public            Unity.Mathematics.float3        c2  // 0x28
  public    static readonly Unity.Mathematics.float3x3      identity  // 0x0
  public    static readonly Unity.Mathematics.float3x3      zero  // 0x24
METHODS:
  System.Void .ctor(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2)
  System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12, System.Single m20, System.Single m21, System.Single m22)
  System.Void .ctor(System.Single v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3x3 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int3x3 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint3x3 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double3x3 v)
  Unity.Mathematics.float3x3 op_Implicit(System.Int32 v)
  Unity.Mathematics.float3x3 op_Multiply(Unity.Mathematics.float3x3 lhs, System.Single rhs)
  Unity.Mathematics.float3x3 op_Addition(Unity.Mathematics.float3x3 lhs, Unity.Mathematics.float3x3 rhs)
  Unity.Mathematics.float3& get_Item(System.Int32 index)
  System.Boolean Equals(Unity.Mathematics.float3x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .ctor(Unity.Mathematics.float4x4 f4x4)
  System.Void .ctor(Unity.Mathematics.quaternion q)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.float3x4
TYPE:  struct
TOKEN: 0x200002F
FIELDS:
  public            Unity.Mathematics.float3        c0  // 0x10
  public            Unity.Mathematics.float3        c1  // 0x1C
  public            Unity.Mathematics.float3        c2  // 0x28
  public            Unity.Mathematics.float3        c3  // 0x34
  public    static readonly Unity.Mathematics.float3x4      zero  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2, Unity.Mathematics.float3 c3)
  System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13, System.Single m20, System.Single m21, System.Single m22, System.Single m23)
  System.Void .ctor(System.Single v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3x4 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int3x4 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint3x4 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double3x4 v)
  Unity.Mathematics.float3x4 op_Implicit(System.Int32 v)
  Unity.Mathematics.float3& get_Item(System.Int32 index)
  System.Boolean Equals(Unity.Mathematics.float3x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.float4
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public            System.Single                   x  // 0x10
  public            System.Single                   y  // 0x14
  public            System.Single                   z  // 0x18
  public            System.Single                   w  // 0x1C
  public    static readonly Unity.Mathematics.float4        zero  // 0x0
METHODS:
  System.Void .ctor(System.Single x, System.Single y, System.Single z, System.Single w)
  System.Void .ctor(System.Single x, System.Single y, Unity.Mathematics.float2 zw)
  System.Void .ctor(System.Single x, Unity.Mathematics.float2 yz, System.Single w)
  System.Void .ctor(System.Single x, Unity.Mathematics.float3 yzw)
  System.Void .ctor(Unity.Mathematics.float2 xy, System.Single z, System.Single w)
  System.Void .ctor(Unity.Mathematics.float2 xy, Unity.Mathematics.float2 zw)
  System.Void .ctor(Unity.Mathematics.float3 xyz, System.Single w)
  System.Void .ctor(Unity.Mathematics.float4 xyzw)
  System.Void .ctor(System.Single v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int4 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint4 v)
  System.Void .ctor(Unity.Mathematics.half v)
  System.Void .ctor(Unity.Mathematics.half4 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double4 v)
  Unity.Mathematics.float4 op_Implicit(System.Single v)
  Unity.Mathematics.float4 op_Implicit(System.Int32 v)
  Unity.Mathematics.float4 op_Implicit(Unity.Mathematics.int4 v)
  Unity.Mathematics.float4 op_Implicit(System.UInt32 v)
  Unity.Mathematics.float4 op_Implicit(Unity.Mathematics.uint4 v)
  Unity.Mathematics.float4 op_Implicit(Unity.Mathematics.half4 v)
  Unity.Mathematics.float4 op_Explicit(System.Double v)
  Unity.Mathematics.float4 op_Explicit(Unity.Mathematics.double4 v)
  Unity.Mathematics.float4 op_Multiply(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs)
  Unity.Mathematics.float4 op_Multiply(Unity.Mathematics.float4 lhs, System.Single rhs)
  Unity.Mathematics.float4 op_Multiply(System.Single lhs, Unity.Mathematics.float4 rhs)
  Unity.Mathematics.float4 op_Addition(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs)
  Unity.Mathematics.float4 op_Addition(Unity.Mathematics.float4 lhs, System.Single rhs)
  Unity.Mathematics.float4 op_Subtraction(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs)
  Unity.Mathematics.float4 op_Subtraction(Unity.Mathematics.float4 lhs, System.Single rhs)
  Unity.Mathematics.float4 op_Subtraction(System.Single lhs, Unity.Mathematics.float4 rhs)
  Unity.Mathematics.float4 op_Division(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs)
  Unity.Mathematics.float4 op_Division(Unity.Mathematics.float4 lhs, System.Single rhs)
  Unity.Mathematics.float4 op_Division(System.Single lhs, Unity.Mathematics.float4 rhs)
  Unity.Mathematics.bool4 op_LessThan(Unity.Mathematics.float4 lhs, System.Single rhs)
  Unity.Mathematics.bool4 op_GreaterThan(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs)
  Unity.Mathematics.bool4 op_GreaterThanOrEqual(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs)
  Unity.Mathematics.float4 op_UnaryNegation(Unity.Mathematics.float4 val)
  Unity.Mathematics.bool4 op_Equality(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs)
  Unity.Mathematics.bool4 op_Equality(Unity.Mathematics.float4 lhs, System.Single rhs)
  Unity.Mathematics.float4 get_xxzz()
  Unity.Mathematics.float4 get_xyzx()
  Unity.Mathematics.float4 get_xzxz()
  Unity.Mathematics.float4 get_yyww()
  Unity.Mathematics.float4 get_yzxy()
  Unity.Mathematics.float4 get_yzxz()
  Unity.Mathematics.float4 get_yzxw()
  Unity.Mathematics.float4 get_zxyy()
  Unity.Mathematics.float4 get_zxyz()
  Unity.Mathematics.float4 get_zwxy()
  Unity.Mathematics.float4 get_wzyx()
  Unity.Mathematics.float4 get_wwwx()
  Unity.Mathematics.float4 get_wwww()
  Unity.Mathematics.float3 get_xxx()
  Unity.Mathematics.float3 get_xyz()
  System.Void set_xyz(Unity.Mathematics.float3 value)
  Unity.Mathematics.float3 get_xyw()
  Unity.Mathematics.float3 get_yxw()
  Unity.Mathematics.float3 get_yzx()
  Unity.Mathematics.float3 get_zwx()
  Unity.Mathematics.float3 get_wzy()
  Unity.Mathematics.float3 get_www()
  Unity.Mathematics.float2 get_xx()
  Unity.Mathematics.float2 get_xy()
  System.Void set_xy(Unity.Mathematics.float2 value)
  Unity.Mathematics.float2 get_xz()
  Unity.Mathematics.float2 get_yy()
  Unity.Mathematics.float2 get_yw()
  Unity.Mathematics.float2 get_zw()
  Unity.Mathematics.float2 get_wz()
  System.Single get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Single value)
  System.Boolean Equals(Unity.Mathematics.float4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  Unity.Mathematics.float4 op_Implicit(UnityEngine.Vector4 v)
  UnityEngine.Vector4 op_Implicit(Unity.Mathematics.float4 v)
END_CLASS

CLASS: Unity.Mathematics.float4x2
TYPE:  struct
TOKEN: 0x2000032
FIELDS:
  public            Unity.Mathematics.float4        c0  // 0x10
  public            Unity.Mathematics.float4        c1  // 0x20
METHODS:
  System.Void .ctor(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1)
  System.Void .ctor(System.Single m00, System.Single m01, System.Single m10, System.Single m11, System.Single m20, System.Single m21, System.Single m30, System.Single m31)
  System.Void .ctor(System.Single v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4x2 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int4x2 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint4x2 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double4x2 v)
  System.Boolean Equals(Unity.Mathematics.float4x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.float4x3
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  public            Unity.Mathematics.float4        c0  // 0x10
  public            Unity.Mathematics.float4        c1  // 0x20
  public            Unity.Mathematics.float4        c2  // 0x30
METHODS:
  System.Void .ctor(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2)
  System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m10, System.Single m11, System.Single m12, System.Single m20, System.Single m21, System.Single m22, System.Single m30, System.Single m31, System.Single m32)
  System.Void .ctor(System.Single v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4x3 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int4x3 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint4x3 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double4x3 v)
  Unity.Mathematics.float4x3 op_Implicit(System.Int32 v)
  Unity.Mathematics.float4x3 op_Multiply(Unity.Mathematics.float4x3 lhs, Unity.Mathematics.float4x3 rhs)
  Unity.Mathematics.float4x3 op_Multiply(Unity.Mathematics.float4x3 lhs, System.Single rhs)
  Unity.Mathematics.float4x3 op_Addition(Unity.Mathematics.float4x3 lhs, Unity.Mathematics.float4x3 rhs)
  Unity.Mathematics.float4& get_Item(System.Int32 index)
  System.Boolean Equals(Unity.Mathematics.float4x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.float4x4
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            Unity.Mathematics.float4        c0  // 0x10
  public            Unity.Mathematics.float4        c1  // 0x20
  public            Unity.Mathematics.float4        c2  // 0x30
  public            Unity.Mathematics.float4        c3  // 0x40
  public    static readonly Unity.Mathematics.float4x4      identity  // 0x0
  public    static readonly Unity.Mathematics.float4x4      zero  // 0x40
METHODS:
  System.Void .ctor(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2, Unity.Mathematics.float4 c3)
  System.Void .ctor(System.Single m00, System.Single m01, System.Single m02, System.Single m03, System.Single m10, System.Single m11, System.Single m12, System.Single m13, System.Single m20, System.Single m21, System.Single m22, System.Single m23, System.Single m30, System.Single m31, System.Single m32, System.Single m33)
  System.Void .ctor(System.Single v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4x4 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int4x4 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint4x4 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double4x4 v)
  Unity.Mathematics.float4x4 op_Implicit(System.Single v)
  Unity.Mathematics.float4x4 op_Implicit(System.Int32 v)
  Unity.Mathematics.float4x4 op_Multiply(Unity.Mathematics.float4x4 lhs, System.Single rhs)
  Unity.Mathematics.bool4x4 op_Equality(Unity.Mathematics.float4x4 lhs, Unity.Mathematics.float4x4 rhs)
  Unity.Mathematics.float4& get_Item(System.Int32 index)
  System.Boolean Equals(Unity.Mathematics.float4x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  Unity.Mathematics.float4x4 op_Implicit(UnityEngine.Matrix4x4 m)
  UnityEngine.Matrix4x4 op_Implicit(Unity.Mathematics.float4x4 m)
  System.Void .ctor(Unity.Mathematics.float3x3 rotation, Unity.Mathematics.float3 translation)
  System.Void .ctor(Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 translation)
  System.Void .ctor(Unity.Mathematics.RigidTransform transform)
  Unity.Mathematics.float4x4 Ortho(System.Single width, System.Single height, System.Single near, System.Single far)
  Unity.Mathematics.float4x4 TRS(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 scale)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.half
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            System.UInt16                   value  // 0x10
  public    static readonly Unity.Mathematics.half          zero  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.half x)
  System.Void .ctor(System.Single v)
  System.Void .ctor(System.Double v)
  Unity.Mathematics.half op_Explicit(System.Single v)
  Unity.Mathematics.half op_Explicit(System.Double v)
  System.Single op_Implicit(Unity.Mathematics.half d)
  System.Double op_Implicit(Unity.Mathematics.half d)
  System.Boolean op_Equality(Unity.Mathematics.half lhs, Unity.Mathematics.half rhs)
  System.Boolean Equals(Unity.Mathematics.half rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.half2
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  public            Unity.Mathematics.half          x  // 0x10
  public            Unity.Mathematics.half          y  // 0x12
METHODS:
  System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half y)
  System.Void .ctor(Unity.Mathematics.half2 xy)
  System.Void .ctor(Unity.Mathematics.half v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float2 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double2 v)
  Unity.Mathematics.half2 op_Explicit(Unity.Mathematics.float2 v)
  System.Boolean Equals(Unity.Mathematics.half2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.half3
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            Unity.Mathematics.half          x  // 0x10
  public            Unity.Mathematics.half          y  // 0x12
  public            Unity.Mathematics.half          z  // 0x14
METHODS:
  System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half z)
  System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half2 yz)
  System.Void .ctor(Unity.Mathematics.half2 xy, Unity.Mathematics.half z)
  System.Void .ctor(Unity.Mathematics.half3 xyz)
  System.Void .ctor(Unity.Mathematics.half v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float3 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double3 v)
  Unity.Mathematics.half3 op_Explicit(Unity.Mathematics.float3 v)
  System.Boolean Equals(Unity.Mathematics.half3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.half4
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  public            Unity.Mathematics.half          x  // 0x10
  public            Unity.Mathematics.half          y  // 0x12
  public            Unity.Mathematics.half          z  // 0x14
  public            Unity.Mathematics.half          w  // 0x16
  public    static readonly Unity.Mathematics.half4         zero  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half z, Unity.Mathematics.half w)
  System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half y, Unity.Mathematics.half2 zw)
  System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half2 yz, Unity.Mathematics.half w)
  System.Void .ctor(Unity.Mathematics.half x, Unity.Mathematics.half3 yzw)
  System.Void .ctor(Unity.Mathematics.half2 xy, Unity.Mathematics.half z, Unity.Mathematics.half w)
  System.Void .ctor(Unity.Mathematics.half2 xy, Unity.Mathematics.half2 zw)
  System.Void .ctor(Unity.Mathematics.half3 xyz, Unity.Mathematics.half w)
  System.Void .ctor(Unity.Mathematics.half4 xyzw)
  System.Void .ctor(Unity.Mathematics.half v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float4 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double4 v)
  Unity.Mathematics.half4 op_Explicit(Unity.Mathematics.float4 v)
  System.Boolean Equals(Unity.Mathematics.half4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int2
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            System.Int32                    x  // 0x10
  public            System.Int32                    y  // 0x14
  public    static readonly Unity.Mathematics.int2          zero  // 0x0
METHODS:
  System.Void .ctor(System.Int32 x, System.Int32 y)
  System.Void .ctor(Unity.Mathematics.int2 xy)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint2 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float2 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double2 v)
  Unity.Mathematics.int2 op_Implicit(System.Int32 v)
  Unity.Mathematics.int2 op_Explicit(System.UInt32 v)
  Unity.Mathematics.int2 op_Explicit(Unity.Mathematics.uint2 v)
  Unity.Mathematics.int2 op_Explicit(System.Single v)
  Unity.Mathematics.int2 op_Explicit(Unity.Mathematics.float2 v)
  Unity.Mathematics.int2 op_Explicit(System.Double v)
  Unity.Mathematics.int2 op_Explicit(Unity.Mathematics.double2 v)
  Unity.Mathematics.int2 op_Multiply(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs)
  Unity.Mathematics.int2 op_Multiply(Unity.Mathematics.int2 lhs, System.Int32 rhs)
  Unity.Mathematics.int2 op_Addition(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs)
  Unity.Mathematics.int2 op_Addition(Unity.Mathematics.int2 lhs, System.Int32 rhs)
  Unity.Mathematics.int2 op_Subtraction(Unity.Mathematics.int2 lhs, System.Int32 rhs)
  Unity.Mathematics.int2 op_Division(Unity.Mathematics.int2 lhs, System.Int32 rhs)
  Unity.Mathematics.bool2 op_GreaterThan(Unity.Mathematics.int2 lhs, System.Int32 rhs)
  Unity.Mathematics.bool2 op_GreaterThanOrEqual(Unity.Mathematics.int2 lhs, System.Int32 rhs)
  Unity.Mathematics.int2 op_UnaryNegation(Unity.Mathematics.int2 val)
  Unity.Mathematics.int2 op_RightShift(Unity.Mathematics.int2 x, System.Int32 n)
  Unity.Mathematics.int2 op_BitwiseOr(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs)
  Unity.Mathematics.int2 get_xy()
  System.Void set_Item(System.Int32 index, System.Int32 value)
  System.Boolean Equals(Unity.Mathematics.int2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int2x2
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  public            Unity.Mathematics.int2          c0  // 0x10
  public            Unity.Mathematics.int2          c1  // 0x18
  public    static readonly Unity.Mathematics.int2x2        identity  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1)
  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2x2 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint2x2 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float2x2 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double2x2 v)
  System.Boolean Equals(Unity.Mathematics.int2x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.int2x3
TYPE:  struct
TOKEN: 0x200003F
FIELDS:
  public            Unity.Mathematics.int2          c0  // 0x10
  public            Unity.Mathematics.int2          c1  // 0x18
  public            Unity.Mathematics.int2          c2  // 0x20
METHODS:
  System.Void .ctor(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1, Unity.Mathematics.int2 c2)
  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2x3 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint2x3 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float2x3 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double2x3 v)
  Unity.Mathematics.int2& get_Item(System.Int32 index)
  System.Boolean Equals(Unity.Mathematics.int2x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int2x4
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  public            Unity.Mathematics.int2          c0  // 0x10
  public            Unity.Mathematics.int2          c1  // 0x18
  public            Unity.Mathematics.int2          c2  // 0x20
  public            Unity.Mathematics.int2          c3  // 0x28
METHODS:
  System.Void .ctor(Unity.Mathematics.int2 c0, Unity.Mathematics.int2 c1, Unity.Mathematics.int2 c2, Unity.Mathematics.int2 c3)
  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2x4 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint2x4 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float2x4 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double2x4 v)
  System.Boolean Equals(Unity.Mathematics.int2x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int3
TYPE:  struct
TOKEN: 0x2000041
FIELDS:
  public            System.Int32                    x  // 0x10
  public            System.Int32                    y  // 0x14
  public            System.Int32                    z  // 0x18
  public    static readonly Unity.Mathematics.int3          zero  // 0x0
METHODS:
  System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 z)
  System.Void .ctor(System.Int32 x, Unity.Mathematics.int2 yz)
  System.Void .ctor(Unity.Mathematics.int2 xy, System.Int32 z)
  System.Void .ctor(Unity.Mathematics.int3 xyz)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint3 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float3 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double3 v)
  Unity.Mathematics.int3 op_Implicit(System.Int32 v)
  Unity.Mathematics.int3 op_Explicit(System.UInt32 v)
  Unity.Mathematics.int3 op_Explicit(Unity.Mathematics.uint3 v)
  Unity.Mathematics.int3 op_Explicit(System.Single v)
  Unity.Mathematics.int3 op_Explicit(Unity.Mathematics.float3 v)
  Unity.Mathematics.int3 op_Explicit(System.Double v)
  Unity.Mathematics.int3 op_Explicit(Unity.Mathematics.double3 v)
  Unity.Mathematics.int3 op_Multiply(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs)
  Unity.Mathematics.int3 op_Multiply(Unity.Mathematics.int3 lhs, System.Int32 rhs)
  Unity.Mathematics.int3 op_Addition(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs)
  Unity.Mathematics.int3 op_Addition(Unity.Mathematics.int3 lhs, System.Int32 rhs)
  Unity.Mathematics.int3 op_Subtraction(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs)
  Unity.Mathematics.int3 op_Subtraction(Unity.Mathematics.int3 lhs, System.Int32 rhs)
  Unity.Mathematics.int3 op_Division(Unity.Mathematics.int3 lhs, System.Int32 rhs)
  Unity.Mathematics.bool3 op_LessThanOrEqual(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs)
  Unity.Mathematics.bool3 op_GreaterThan(Unity.Mathematics.int3 lhs, System.Int32 rhs)
  Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs)
  Unity.Mathematics.bool3 op_GreaterThanOrEqual(Unity.Mathematics.int3 lhs, System.Int32 rhs)
  Unity.Mathematics.int3 op_UnaryNegation(Unity.Mathematics.int3 val)
  Unity.Mathematics.int3 op_RightShift(Unity.Mathematics.int3 x, System.Int32 n)
  Unity.Mathematics.bool3 op_Inequality(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs)
  Unity.Mathematics.bool3 op_Inequality(Unity.Mathematics.int3 lhs, System.Int32 rhs)
  Unity.Mathematics.int3 op_BitwiseOr(Unity.Mathematics.int3 lhs, Unity.Mathematics.int3 rhs)
  System.Void set_xyz(Unity.Mathematics.int3 value)
  Unity.Mathematics.int3 get_xzy()
  Unity.Mathematics.int2 get_xy()
  System.Void set_xy(Unity.Mathematics.int2 value)
  Unity.Mathematics.int2 get_yz()
  Unity.Mathematics.int2 get_zx()
  System.Int32 get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Int32 value)
  System.Boolean Equals(Unity.Mathematics.int3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int3x2
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  public            Unity.Mathematics.int3          c0  // 0x10
  public            Unity.Mathematics.int3          c1  // 0x1C
METHODS:
  System.Void .ctor(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1)
  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11, System.Int32 m20, System.Int32 m21)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3x2 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint3x2 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float3x2 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double3x2 v)
  System.Boolean Equals(Unity.Mathematics.int3x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int3x3
TYPE:  struct
TOKEN: 0x2000044
FIELDS:
  public            Unity.Mathematics.int3          c0  // 0x10
  public            Unity.Mathematics.int3          c1  // 0x1C
  public            Unity.Mathematics.int3          c2  // 0x28
  public    static readonly Unity.Mathematics.int3x3        identity  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1, Unity.Mathematics.int3 c2)
  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m20, System.Int32 m21, System.Int32 m22)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3x3 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint3x3 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float3x3 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double3x3 v)
  System.Boolean Equals(Unity.Mathematics.int3x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.int3x4
TYPE:  struct
TOKEN: 0x2000045
FIELDS:
  public            Unity.Mathematics.int3          c0  // 0x10
  public            Unity.Mathematics.int3          c1  // 0x1C
  public            Unity.Mathematics.int3          c2  // 0x28
  public            Unity.Mathematics.int3          c3  // 0x34
METHODS:
  System.Void .ctor(Unity.Mathematics.int3 c0, Unity.Mathematics.int3 c1, Unity.Mathematics.int3 c2, Unity.Mathematics.int3 c3)
  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m23)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3x4 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint3x4 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float3x4 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double3x4 v)
  System.Boolean Equals(Unity.Mathematics.int3x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int4
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  public            System.Int32                    x  // 0x10
  public            System.Int32                    y  // 0x14
  public            System.Int32                    z  // 0x18
  public            System.Int32                    w  // 0x1C
  public    static readonly Unity.Mathematics.int4          zero  // 0x0
METHODS:
  System.Void .ctor(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w)
  System.Void .ctor(System.Int32 x, System.Int32 y, Unity.Mathematics.int2 zw)
  System.Void .ctor(System.Int32 x, Unity.Mathematics.int2 yz, System.Int32 w)
  System.Void .ctor(System.Int32 x, Unity.Mathematics.int3 yzw)
  System.Void .ctor(Unity.Mathematics.int2 xy, System.Int32 z, System.Int32 w)
  System.Void .ctor(Unity.Mathematics.int2 xy, Unity.Mathematics.int2 zw)
  System.Void .ctor(Unity.Mathematics.int3 xyz, System.Int32 w)
  System.Void .ctor(Unity.Mathematics.int4 xyzw)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint4 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float4 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double4 v)
  Unity.Mathematics.int4 op_Implicit(System.Int32 v)
  Unity.Mathematics.int4 op_Explicit(System.UInt32 v)
  Unity.Mathematics.int4 op_Explicit(Unity.Mathematics.uint4 v)
  Unity.Mathematics.int4 op_Explicit(System.Single v)
  Unity.Mathematics.int4 op_Explicit(Unity.Mathematics.float4 v)
  Unity.Mathematics.int4 op_Explicit(System.Double v)
  Unity.Mathematics.int4 op_Explicit(Unity.Mathematics.double4 v)
  Unity.Mathematics.int4 op_Multiply(Unity.Mathematics.int4 lhs, Unity.Mathematics.int4 rhs)
  Unity.Mathematics.int4 op_Multiply(Unity.Mathematics.int4 lhs, System.Int32 rhs)
  Unity.Mathematics.int4 op_Addition(Unity.Mathematics.int4 lhs, Unity.Mathematics.int4 rhs)
  Unity.Mathematics.int4 op_Addition(Unity.Mathematics.int4 lhs, System.Int32 rhs)
  Unity.Mathematics.int4 op_Subtraction(Unity.Mathematics.int4 lhs, System.Int32 rhs)
  Unity.Mathematics.bool4 op_GreaterThan(Unity.Mathematics.int4 lhs, System.Int32 rhs)
  Unity.Mathematics.bool4 op_GreaterThanOrEqual(Unity.Mathematics.int4 lhs, System.Int32 rhs)
  Unity.Mathematics.int4 op_UnaryNegation(Unity.Mathematics.int4 val)
  Unity.Mathematics.int4 op_RightShift(Unity.Mathematics.int4 x, System.Int32 n)
  Unity.Mathematics.int4 op_BitwiseOr(Unity.Mathematics.int4 lhs, Unity.Mathematics.int4 rhs)
  System.Int32 get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.Int32 value)
  System.Boolean Equals(Unity.Mathematics.int4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int4x2
TYPE:  struct
TOKEN: 0x2000048
FIELDS:
  public            Unity.Mathematics.int4          c0  // 0x10
  public            Unity.Mathematics.int4          c1  // 0x20
METHODS:
  System.Void .ctor(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1)
  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m10, System.Int32 m11, System.Int32 m20, System.Int32 m21, System.Int32 m30, System.Int32 m31)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4x2 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint4x2 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float4x2 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double4x2 v)
  System.Boolean Equals(Unity.Mathematics.int4x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int4x3
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  public            Unity.Mathematics.int4          c0  // 0x10
  public            Unity.Mathematics.int4          c1  // 0x20
  public            Unity.Mathematics.int4          c2  // 0x30
METHODS:
  System.Void .ctor(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1, Unity.Mathematics.int4 c2)
  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m30, System.Int32 m31, System.Int32 m32)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4x3 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint4x3 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float4x3 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double4x3 v)
  System.Boolean Equals(Unity.Mathematics.int4x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.int4x4
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
  public            Unity.Mathematics.int4          c0  // 0x10
  public            Unity.Mathematics.int4          c1  // 0x20
  public            Unity.Mathematics.int4          c2  // 0x30
  public            Unity.Mathematics.int4          c3  // 0x40
  public    static readonly Unity.Mathematics.int4x4        identity  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.int4 c0, Unity.Mathematics.int4 c1, Unity.Mathematics.int4 c2, Unity.Mathematics.int4 c3)
  System.Void .ctor(System.Int32 m00, System.Int32 m01, System.Int32 m02, System.Int32 m03, System.Int32 m10, System.Int32 m11, System.Int32 m12, System.Int32 m13, System.Int32 m20, System.Int32 m21, System.Int32 m22, System.Int32 m23, System.Int32 m30, System.Int32 m31, System.Int32 m32, System.Int32 m33)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4x4 v)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(Unity.Mathematics.uint4x4 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float4x4 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double4x4 v)
  System.Boolean Equals(Unity.Mathematics.int4x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.quaternion
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  public            Unity.Mathematics.float4        value  // 0x10
  public    static readonly Unity.Mathematics.quaternion    identity  // 0x0
METHODS:
  UnityEngine.Quaternion op_Implicit(Unity.Mathematics.quaternion q)
  Unity.Mathematics.quaternion op_Implicit(UnityEngine.Quaternion q)
  System.Void .ctor(System.Single x, System.Single y, System.Single z, System.Single w)
  System.Void .ctor(Unity.Mathematics.float4 value)
  Unity.Mathematics.quaternion op_Implicit(Unity.Mathematics.float4 v)
  System.Void .ctor(Unity.Mathematics.float3x3 m)
  System.Void .ctor(Unity.Mathematics.float4x4 m)
  Unity.Mathematics.quaternion AxisAngle(Unity.Mathematics.float3 axis, System.Single angle)
  Unity.Mathematics.quaternion EulerXYZ(Unity.Mathematics.float3 xyz)
  Unity.Mathematics.quaternion EulerXZY(Unity.Mathematics.float3 xyz)
  Unity.Mathematics.quaternion EulerYXZ(Unity.Mathematics.float3 xyz)
  Unity.Mathematics.quaternion EulerYZX(Unity.Mathematics.float3 xyz)
  Unity.Mathematics.quaternion EulerZXY(Unity.Mathematics.float3 xyz)
  Unity.Mathematics.quaternion EulerZYX(Unity.Mathematics.float3 xyz)
  Unity.Mathematics.quaternion EulerXYZ(System.Single x, System.Single y, System.Single z)
  Unity.Mathematics.quaternion EulerXZY(System.Single x, System.Single y, System.Single z)
  Unity.Mathematics.quaternion EulerYXZ(System.Single x, System.Single y, System.Single z)
  Unity.Mathematics.quaternion EulerYZX(System.Single x, System.Single y, System.Single z)
  Unity.Mathematics.quaternion EulerZXY(System.Single x, System.Single y, System.Single z)
  Unity.Mathematics.quaternion EulerZYX(System.Single x, System.Single y, System.Single z)
  Unity.Mathematics.quaternion Euler(Unity.Mathematics.float3 xyz, Unity.Mathematics.math.RotationOrder order)
  Unity.Mathematics.quaternion Euler(System.Single x, System.Single y, System.Single z, Unity.Mathematics.math.RotationOrder order)
  Unity.Mathematics.quaternion RotateX(System.Single angle)
  Unity.Mathematics.quaternion RotateY(System.Single angle)
  Unity.Mathematics.quaternion RotateZ(System.Single angle)
  Unity.Mathematics.quaternion LookRotation(Unity.Mathematics.float3 forward, Unity.Mathematics.float3 up)
  Unity.Mathematics.quaternion LookRotationSafe(Unity.Mathematics.float3 forward, Unity.Mathematics.float3 up)
  System.Boolean Equals(Unity.Mathematics.quaternion x)
  System.Boolean Equals(System.Object x)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.noise
TYPE:  class
TOKEN: 0x200004C
FIELDS:
METHODS:
  System.Single cnoise(Unity.Mathematics.float2 P)
  System.Single pnoise(Unity.Mathematics.float2 P, Unity.Mathematics.float2 rep)
  Unity.Mathematics.float2 mod289(Unity.Mathematics.float2 x)
  Unity.Mathematics.float3 mod289(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 mod289(Unity.Mathematics.float4 x)
  Unity.Mathematics.float3 permute(Unity.Mathematics.float3 x)
  Unity.Mathematics.float4 permute(Unity.Mathematics.float4 x)
  Unity.Mathematics.float4 taylorInvSqrt(Unity.Mathematics.float4 r)
  Unity.Mathematics.float2 fade(Unity.Mathematics.float2 t)
  System.Single snoise(Unity.Mathematics.float2 v)
END_CLASS

CLASS: Unity.Mathematics.Random
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  public            System.UInt32                   state  // 0x10
METHODS:
  System.Void .ctor(System.UInt32 seed)
  Unity.Mathematics.Random CreateFromIndex(System.UInt32 index)
  System.UInt32 WangHash(System.UInt32 n)
  System.Single NextFloat()
  Unity.Mathematics.float3 NextFloat3()
  System.UInt32 NextState()
END_CLASS

CLASS: Unity.Mathematics.RigidTransform
TYPE:  struct
TOKEN: 0x200004E
FIELDS:
  public            Unity.Mathematics.quaternion    rot  // 0x10
  public            Unity.Mathematics.float3        pos  // 0x20
  public    static readonly Unity.Mathematics.RigidTransformidentity  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 translation)
  System.Void .ctor(Unity.Mathematics.float3x3 rotation, Unity.Mathematics.float3 translation)
  System.Void .ctor(Unity.Mathematics.float4x4 transform)
  System.Boolean Equals(Unity.Mathematics.RigidTransform x)
  System.Boolean Equals(System.Object x)
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.svd
TYPE:  class
TOKEN: 0x200004F
FIELDS:
METHODS:
  System.Void condSwap(System.Boolean c, System.Single& x, System.Single& y)
  System.Void condNegSwap(System.Boolean c, Unity.Mathematics.float3& x, Unity.Mathematics.float3& y)
  Unity.Mathematics.quaternion condNegSwapQuat(System.Boolean c, Unity.Mathematics.quaternion q, Unity.Mathematics.float4 mask)
  System.Void sortSingularValues(Unity.Mathematics.float3x3& b, Unity.Mathematics.quaternion& v)
  Unity.Mathematics.quaternion approxGivensQuat(Unity.Mathematics.float3 pq, Unity.Mathematics.float4 mask)
  Unity.Mathematics.quaternion qrGivensQuat(Unity.Mathematics.float2 pq, Unity.Mathematics.float4 mask)
  Unity.Mathematics.quaternion givensQRFactorization(Unity.Mathematics.float3x3 b, Unity.Mathematics.float3x3& r)
  Unity.Mathematics.quaternion jacobiIteration(Unity.Mathematics.float3x3& s, System.Int32 iterations)
  Unity.Mathematics.float3 singularValuesDecomposition(Unity.Mathematics.float3x3 a, Unity.Mathematics.quaternion& u, Unity.Mathematics.quaternion& v)
  Unity.Mathematics.float3 rcpsafe(Unity.Mathematics.float3 x, System.Single epsilon)
  Unity.Mathematics.float3x3 svdInverse(Unity.Mathematics.float3x3 a)
  Unity.Mathematics.quaternion svdRotation(Unity.Mathematics.float3x3 a)
END_CLASS

CLASS: Unity.Mathematics.uint2
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  public            System.UInt32                   x  // 0x10
  public            System.UInt32                   y  // 0x14
METHODS:
  System.Void .ctor(System.UInt32 x, System.UInt32 y)
  System.Void .ctor(Unity.Mathematics.uint2 xy)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int2 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float2 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double2 v)
  Unity.Mathematics.uint2 op_Implicit(System.UInt32 v)
  Unity.Mathematics.uint2 op_Explicit(System.Int32 v)
  Unity.Mathematics.uint2 op_Explicit(Unity.Mathematics.int2 v)
  Unity.Mathematics.uint2 op_Explicit(System.Single v)
  Unity.Mathematics.uint2 op_Explicit(Unity.Mathematics.float2 v)
  Unity.Mathematics.uint2 op_Explicit(System.Double v)
  Unity.Mathematics.uint2 op_Explicit(Unity.Mathematics.double2 v)
  Unity.Mathematics.uint2 op_Multiply(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs)
  Unity.Mathematics.uint2 op_Multiply(Unity.Mathematics.uint2 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint2 op_Addition(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs)
  Unity.Mathematics.uint2 op_Addition(Unity.Mathematics.uint2 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint2 op_Subtraction(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs)
  Unity.Mathematics.uint2 op_Subtraction(Unity.Mathematics.uint2 lhs, System.UInt32 rhs)
  Unity.Mathematics.bool2 op_GreaterThan(Unity.Mathematics.uint2 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint2 op_LeftShift(Unity.Mathematics.uint2 x, System.Int32 n)
  Unity.Mathematics.uint2 op_RightShift(Unity.Mathematics.uint2 x, System.Int32 n)
  Unity.Mathematics.bool2 op_Equality(Unity.Mathematics.uint2 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint2 op_BitwiseAnd(Unity.Mathematics.uint2 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint2 op_BitwiseOr(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs)
  Unity.Mathematics.uint2 op_ExclusiveOr(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs)
  System.Boolean Equals(Unity.Mathematics.uint2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint2x2
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  public            Unity.Mathematics.uint2         c0  // 0x10
  public            Unity.Mathematics.uint2         c1  // 0x18
  public    static readonly Unity.Mathematics.uint2x2       identity  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1)
  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2x2 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int2x2 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float2x2 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double2x2 v)
  System.Boolean Equals(Unity.Mathematics.uint2x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.uint2x3
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  public            Unity.Mathematics.uint2         c0  // 0x10
  public            Unity.Mathematics.uint2         c1  // 0x18
  public            Unity.Mathematics.uint2         c2  // 0x20
METHODS:
  System.Void .ctor(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1, Unity.Mathematics.uint2 c2)
  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2x3 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int2x3 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float2x3 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double2x3 v)
  System.Boolean Equals(Unity.Mathematics.uint2x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint2x4
TYPE:  struct
TOKEN: 0x2000054
FIELDS:
  public            Unity.Mathematics.uint2         c0  // 0x10
  public            Unity.Mathematics.uint2         c1  // 0x18
  public            Unity.Mathematics.uint2         c2  // 0x20
  public            Unity.Mathematics.uint2         c3  // 0x28
METHODS:
  System.Void .ctor(Unity.Mathematics.uint2 c0, Unity.Mathematics.uint2 c1, Unity.Mathematics.uint2 c2, Unity.Mathematics.uint2 c3)
  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool2x4 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int2x4 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float2x4 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double2x4 v)
  System.Boolean Equals(Unity.Mathematics.uint2x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint3
TYPE:  struct
TOKEN: 0x2000055
FIELDS:
  public            System.UInt32                   x  // 0x10
  public            System.UInt32                   y  // 0x14
  public            System.UInt32                   z  // 0x18
METHODS:
  System.Void .ctor(System.UInt32 x, System.UInt32 y, System.UInt32 z)
  System.Void .ctor(System.UInt32 x, Unity.Mathematics.uint2 yz)
  System.Void .ctor(Unity.Mathematics.uint2 xy, System.UInt32 z)
  System.Void .ctor(Unity.Mathematics.uint3 xyz)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int3 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float3 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double3 v)
  Unity.Mathematics.uint3 op_Implicit(System.UInt32 v)
  Unity.Mathematics.uint3 op_Explicit(System.Int32 v)
  Unity.Mathematics.uint3 op_Explicit(Unity.Mathematics.int3 v)
  Unity.Mathematics.uint3 op_Explicit(System.Single v)
  Unity.Mathematics.uint3 op_Explicit(Unity.Mathematics.float3 v)
  Unity.Mathematics.uint3 op_Explicit(System.Double v)
  Unity.Mathematics.uint3 op_Explicit(Unity.Mathematics.double3 v)
  Unity.Mathematics.uint3 op_Multiply(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs)
  Unity.Mathematics.uint3 op_Multiply(Unity.Mathematics.uint3 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint3 op_Addition(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs)
  Unity.Mathematics.uint3 op_Addition(Unity.Mathematics.uint3 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint3 op_Subtraction(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs)
  Unity.Mathematics.uint3 op_Subtraction(Unity.Mathematics.uint3 lhs, System.UInt32 rhs)
  Unity.Mathematics.bool3 op_GreaterThan(Unity.Mathematics.uint3 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint3 op_LeftShift(Unity.Mathematics.uint3 x, System.Int32 n)
  Unity.Mathematics.uint3 op_RightShift(Unity.Mathematics.uint3 x, System.Int32 n)
  Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.uint3 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint3 op_BitwiseAnd(Unity.Mathematics.uint3 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint3 op_BitwiseOr(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs)
  Unity.Mathematics.uint3 op_BitwiseOr(System.UInt32 lhs, Unity.Mathematics.uint3 rhs)
  Unity.Mathematics.uint3 op_ExclusiveOr(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs)
  Unity.Mathematics.uint4 get_xyzz()
  System.UInt32 get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.UInt32 value)
  System.Boolean Equals(Unity.Mathematics.uint3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint3x2
TYPE:  struct
TOKEN: 0x2000057
FIELDS:
  public            Unity.Mathematics.uint3         c0  // 0x10
  public            Unity.Mathematics.uint3         c1  // 0x1C
METHODS:
  System.Void .ctor(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1)
  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11, System.UInt32 m20, System.UInt32 m21)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3x2 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int3x2 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float3x2 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double3x2 v)
  System.Boolean Equals(Unity.Mathematics.uint3x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint3x3
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  public            Unity.Mathematics.uint3         c0  // 0x10
  public            Unity.Mathematics.uint3         c1  // 0x1C
  public            Unity.Mathematics.uint3         c2  // 0x28
  public    static readonly Unity.Mathematics.uint3x3       identity  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1, Unity.Mathematics.uint3 c2)
  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3x3 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int3x3 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float3x3 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double3x3 v)
  System.Boolean Equals(Unity.Mathematics.uint3x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
END_CLASS

CLASS: Unity.Mathematics.uint3x4
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  public            Unity.Mathematics.uint3         c0  // 0x10
  public            Unity.Mathematics.uint3         c1  // 0x1C
  public            Unity.Mathematics.uint3         c2  // 0x28
  public            Unity.Mathematics.uint3         c3  // 0x34
METHODS:
  System.Void .ctor(Unity.Mathematics.uint3 c0, Unity.Mathematics.uint3 c1, Unity.Mathematics.uint3 c2, Unity.Mathematics.uint3 c3)
  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m23)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool3x4 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int3x4 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float3x4 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double3x4 v)
  System.Boolean Equals(Unity.Mathematics.uint3x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint4
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
  public            System.UInt32                   x  // 0x10
  public            System.UInt32                   y  // 0x14
  public            System.UInt32                   z  // 0x18
  public            System.UInt32                   w  // 0x1C
METHODS:
  System.Void .ctor(System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w)
  System.Void .ctor(System.UInt32 x, System.UInt32 y, Unity.Mathematics.uint2 zw)
  System.Void .ctor(System.UInt32 x, Unity.Mathematics.uint2 yz, System.UInt32 w)
  System.Void .ctor(System.UInt32 x, Unity.Mathematics.uint3 yzw)
  System.Void .ctor(Unity.Mathematics.uint2 xy, System.UInt32 z, System.UInt32 w)
  System.Void .ctor(Unity.Mathematics.uint2 xy, Unity.Mathematics.uint2 zw)
  System.Void .ctor(Unity.Mathematics.uint3 xyz, System.UInt32 w)
  System.Void .ctor(Unity.Mathematics.uint4 xyzw)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int4 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float4 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double4 v)
  Unity.Mathematics.uint4 op_Implicit(System.UInt32 v)
  Unity.Mathematics.uint4 op_Explicit(System.Int32 v)
  Unity.Mathematics.uint4 op_Explicit(Unity.Mathematics.int4 v)
  Unity.Mathematics.uint4 op_Explicit(System.Single v)
  Unity.Mathematics.uint4 op_Explicit(Unity.Mathematics.float4 v)
  Unity.Mathematics.uint4 op_Explicit(System.Double v)
  Unity.Mathematics.uint4 op_Explicit(Unity.Mathematics.double4 v)
  Unity.Mathematics.uint4 op_Multiply(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs)
  Unity.Mathematics.uint4 op_Multiply(Unity.Mathematics.uint4 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint4 op_Multiply(System.UInt32 lhs, Unity.Mathematics.uint4 rhs)
  Unity.Mathematics.uint4 op_Addition(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs)
  Unity.Mathematics.uint4 op_Addition(Unity.Mathematics.uint4 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint4 op_Subtraction(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs)
  Unity.Mathematics.uint4 op_Subtraction(Unity.Mathematics.uint4 lhs, System.UInt32 rhs)
  Unity.Mathematics.bool4 op_GreaterThan(Unity.Mathematics.uint4 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint4 op_LeftShift(Unity.Mathematics.uint4 x, System.Int32 n)
  Unity.Mathematics.uint4 op_RightShift(Unity.Mathematics.uint4 x, System.Int32 n)
  Unity.Mathematics.bool4 op_Equality(Unity.Mathematics.uint4 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint4 op_OnesComplement(Unity.Mathematics.uint4 val)
  Unity.Mathematics.uint4 op_BitwiseAnd(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs)
  Unity.Mathematics.uint4 op_BitwiseAnd(Unity.Mathematics.uint4 lhs, System.UInt32 rhs)
  Unity.Mathematics.uint4 op_BitwiseOr(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs)
  Unity.Mathematics.uint4 op_ExclusiveOr(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs)
  System.UInt32 get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, System.UInt32 value)
  System.Boolean Equals(Unity.Mathematics.uint4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint4x2
TYPE:  struct
TOKEN: 0x200005C
FIELDS:
  public            Unity.Mathematics.uint4         c0  // 0x10
  public            Unity.Mathematics.uint4         c1  // 0x20
METHODS:
  System.Void .ctor(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1)
  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m10, System.UInt32 m11, System.UInt32 m20, System.UInt32 m21, System.UInt32 m30, System.UInt32 m31)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4x2 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int4x2 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float4x2 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double4x2 v)
  System.Boolean Equals(Unity.Mathematics.uint4x2 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint4x3
TYPE:  struct
TOKEN: 0x200005D
FIELDS:
  public            Unity.Mathematics.uint4         c0  // 0x10
  public            Unity.Mathematics.uint4         c1  // 0x20
  public            Unity.Mathematics.uint4         c2  // 0x30
METHODS:
  System.Void .ctor(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1, Unity.Mathematics.uint4 c2)
  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m30, System.UInt32 m31, System.UInt32 m32)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4x3 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int4x3 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float4x3 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double4x3 v)
  System.Boolean Equals(Unity.Mathematics.uint4x3 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
END_CLASS

CLASS: Unity.Mathematics.uint4x4
TYPE:  struct
TOKEN: 0x200005E
FIELDS:
  public            Unity.Mathematics.uint4         c0  // 0x10
  public            Unity.Mathematics.uint4         c1  // 0x20
  public            Unity.Mathematics.uint4         c2  // 0x30
  public            Unity.Mathematics.uint4         c3  // 0x40
  public    static readonly Unity.Mathematics.uint4x4       identity  // 0x0
METHODS:
  System.Void .ctor(Unity.Mathematics.uint4 c0, Unity.Mathematics.uint4 c1, Unity.Mathematics.uint4 c2, Unity.Mathematics.uint4 c3)
  System.Void .ctor(System.UInt32 m00, System.UInt32 m01, System.UInt32 m02, System.UInt32 m03, System.UInt32 m10, System.UInt32 m11, System.UInt32 m12, System.UInt32 m13, System.UInt32 m20, System.UInt32 m21, System.UInt32 m22, System.UInt32 m23, System.UInt32 m30, System.UInt32 m31, System.UInt32 m32, System.UInt32 m33)
  System.Void .ctor(System.UInt32 v)
  System.Void .ctor(System.Boolean v)
  System.Void .ctor(Unity.Mathematics.bool4x4 v)
  System.Void .ctor(System.Int32 v)
  System.Void .ctor(Unity.Mathematics.int4x4 v)
  System.Void .ctor(System.Single v)
  System.Void .ctor(Unity.Mathematics.float4x4 v)
  System.Void .ctor(System.Double v)
  System.Void .ctor(Unity.Mathematics.double4x4 v)
  System.Boolean Equals(Unity.Mathematics.uint4x4 rhs)
  System.Boolean Equals(System.Object o)
  System.Int32 GetHashCode()
  System.String ToString()
  System.String ToString(System.String format, System.IFormatProvider formatProvider)
  System.Void .cctor()
END_CLASS

