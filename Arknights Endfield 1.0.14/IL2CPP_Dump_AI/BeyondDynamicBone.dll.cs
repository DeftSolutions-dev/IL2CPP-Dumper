// ========================================================
// Dumped by @desirepro
// Assembly: BeyondDynamicBone.dll
// Classes:  633
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: GenerateSelectionJob
TYPE:  struct
TOKEN: 0x200000C
FIELDS:
  public            System.Int32                    offset  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positionList  // 0x18
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributeList  // 0x28
  public            System.Int32                    attributeMapWidth  // 0x38
  public            Unity.Mathematics.float4x4      toM  // 0x3C
  public            Unity.Mathematics.int2          xySize  // 0x7C
  public            BeyondDynamicBone.ExBitFlag8    attributeReadFlag  // 0x84
  public            Unity.Collections.NativeArray<UnityEngine.Color32>attributeMapData  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.float2>uvs  // 0x98
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>vertexs  // 0xA8
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: RenderMeshInfo
TYPE:  class
TOKEN: 0x200000D
FIELDS:
  public            System.Int32                    renderHandle  // 0x10
  public            BeyondDynamicBone.VirtualMeshContainerrenderMeshContainer  // 0x18
  public            BeyondDynamicBone.DataChunk     mappingChunk  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: PaintMapData
TYPE:  class
TOKEN: 0x200000E
FIELDS:
  public    static  System.Byte                     ReadFlag_Fixed  // 0x0
  public    static  System.Byte                     ReadFlag_Move  // 0x0
  public    static  System.Byte                     ReadFlag_Limit  // 0x0
  public            UnityEngine.Color32[]           paintData  // 0x10
  public            System.Int32                    paintMapWidth  // 0x18
  public            System.Int32                    paintMapHeight  // 0x1C
  public            BeyondDynamicBone.ExBitFlag8    paintReadFlag  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: ClothType
TYPE:  struct
TOKEN: 0x200000F
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.ClothProcess.ClothTypeMeshCloth  // 0x0
  public    static  BeyondDynamicBone.ClothProcess.ClothTypeBoneCloth  // 0x0
  public    static  BeyondDynamicBone.ClothProcess.ClothTypeBoneSpring  // 0x0
METHODS:
END_CLASS

CLASS: PaintMode
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.ClothSerializeData.PaintModeManual  // 0x0
  public    static  BeyondDynamicBone.ClothSerializeData.PaintModeTexture_Fixed_Move  // 0x0
  public    static  BeyondDynamicBone.ClothSerializeData.PaintModeTexture_Fixed_Move_Limit  // 0x0
METHODS:
END_CLASS

CLASS: AnimatorAbilityLevel
TYPE:  struct
TOKEN: 0x2000018
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.ClothSerializeData.AnimatorAbilityLevelOnlyPlayerOrBoss  // 0x0
  public    static  BeyondDynamicBone.ClothSerializeData.AnimatorAbilityLevelAICharOrElite  // 0x0
  public    static  BeyondDynamicBone.ClothSerializeData.AnimatorAbilityLevelDefaultOrAtmosphere  // 0x0
METHODS:
END_CLASS

CLASS: TempBuffer
TYPE:  class
TOKEN: 0x2000019
FIELDS:
  private           BeyondDynamicBone.ClothProcess.ClothTypeclothType  // 0x10
  private           System.Collections.Generic.List<UnityEngine.Renderer>sourceRenderers  // 0x18
  private           BeyondDynamicBone.ClothMeshWriteModemeshWriteMode  // 0x20
  private           BeyondDynamicBone.ClothSerializeData.PaintModepaintMode  // 0x24
  private           System.Collections.Generic.List<UnityEngine.Texture2D>paintMaps  // 0x28
  private           System.Collections.Generic.List<UnityEngine.Transform>rootBones  // 0x30
  private           System.Collections.Generic.List<UnityEngine.Transform>ignoreFromRootBones  // 0x38
  private           BeyondDynamicBone.RenderSetupData.BoneConnectionModeconnectionMode  // 0x40
  private           System.Single                   rotationalInterpolation  // 0x44
  private           System.Single                   rootRotation  // 0x48
  private           BeyondDynamicBone.ClothUpdateModeupdateMode  // 0x4C
  private           System.Int32                    clothAnimatorLODThreshold  // 0x50
  private           System.Int32                    clothAnimatorAbilityLODThreshold  // 0x54
  private           System.Single                   clothLodFadeTime  // 0x58
  private           System.Single                   animationPoseRatio  // 0x5C
  private           System.Single                   clothSimulateWeight  // 0x60
  private           BeyondDynamicBone.ReductionSettingsreductionSetting  // 0x68
  private           BeyondDynamicBone.CustomSkinningSettingscustomSkinningSetting  // 0x70
  private           BeyondDynamicBone.NormalAlignmentSettingsnormalAlignmentSetting  // 0x78
  private           BeyondDynamicBone.ClothNormalAxisnormalAxis  // 0x80
  private           System.Collections.Generic.List<BeyondDynamicBone.ColliderComponent>colliderList  // 0x88
  private           System.Collections.Generic.List<UnityEngine.Transform>collisionBones  // 0x90
  private           BeyondDynamicBone.BeyondBoneClothsynchronization  // 0x98
  private           System.Single                   stablizationTimeAfterReset  // 0xA0
  private           System.Single                   blendWeight  // 0xA4
  private           BeyondDynamicBone.CullingSettingscullingSetting  // 0xA8
  private           UnityEngine.Transform           anchor  // 0xB0
  private           System.Single                   anchorInertia  // 0xB8
METHODS:
  System.Void .ctor(BeyondDynamicBone.ClothSerializeData sdata)
  System.Void Push(BeyondDynamicBone.ClothSerializeData sdata)
  System.Void Pop(BeyondDynamicBone.ClothSerializeData sdata)
END_CLASS

CLASS: Direction
TYPE:  struct
TOKEN: 0x200001E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.BeyondBoneCapsuleCollider.DirectionX  // 0x0
  public    static  BeyondDynamicBone.BeyondBoneCapsuleCollider.DirectionY  // 0x0
  public    static  BeyondDynamicBone.BeyondBoneCapsuleCollider.DirectionZ  // 0x0
METHODS:
END_CLASS

CLASS: RestorationSerializeData
TYPE:  class
TOKEN: 0x2000028
FIELDS:
  public            System.Boolean                  useAngleRestoration  // 0x10
  public            BeyondDynamicBone.CurveSerializeDatastiffness  // 0x18
  public            System.Single                   velocityAttenuation  // 0x20
  public            System.Single                   gravityFalloff  // 0x24
METHODS:
  System.Void .ctor()
  System.Void DataValidate()
  BeyondDynamicBone.AngleConstraint.RestorationSerializeData Clone()
END_CLASS

CLASS: LimitSerializeData
TYPE:  class
TOKEN: 0x2000029
FIELDS:
  public            System.Boolean                  useAngleLimit  // 0x10
  public            BeyondDynamicBone.CurveSerializeDatalimitAngle  // 0x18
  public            System.Single                   stiffness  // 0x20
METHODS:
  System.Void .ctor()
  System.Void DataValidate()
  BeyondDynamicBone.AngleConstraint.LimitSerializeData Clone()
END_CLASS

CLASS: AngleConstraintParams
TYPE:  struct
TOKEN: 0x200002A
FIELDS:
  public            System.Boolean                  useAngleRestoration  // 0x10
  public            Unity.Mathematics.float4x4      restorationStiffness  // 0x14
  public            System.Single                   restorationVelocityAttenuation  // 0x54
  public            System.Single                   restorationGravityFalloff  // 0x58
  public            System.Boolean                  useAngleLimit  // 0x5C
  public            Unity.Mathematics.float4x4      limitCurveData  // 0x60
  public            System.Single                   limitstiffness  // 0xA0
METHODS:
  System.Void Convert(BeyondDynamicBone.AngleConstraint.RestorationSerializeData restorationData, BeyondDynamicBone.AngleConstraint.LimitSerializeData limitData)
END_CLASS

CLASS: AngleConstraintJob
TYPE:  struct
TOKEN: 0x200002B
FIELDS:
  public            Unity.Mathematics.float4        simulationPower  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>stepBaseLineIndexArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x40
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x50
  public            Unity.Collections.NativeArray<System.Single>vertexDepths  // 0x60
  public            Unity.Collections.NativeArray<System.Int32>vertexParentIndices  // 0x70
  public            Unity.Collections.NativeArray<System.UInt16>baseLineStartDataIndices  // 0x80
  public            Unity.Collections.NativeArray<System.UInt16>baseLineDataCounts  // 0x90
  public            Unity.Collections.NativeArray<System.UInt16>baseLineData  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityPosArray  // 0xC0
  public            Unity.Collections.NativeArray<System.Single>frictionArray  // 0xD0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>stepBasicPositionBuffer  // 0xE0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>stepBasicRotationBuffer  // 0xF0
  public            Unity.Collections.NativeArray<System.Single>lengthBufferArray  // 0x100
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPosBufferArray  // 0x110
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>localRotBufferArray  // 0x120
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotationBufferArray  // 0x130
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>restorationVectorBufferArray  // 0x140
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x150
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: PointColliderCollisionConstraintKernel_000000DB$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200002E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: PointColliderCollisionConstraintKernel_000000DB$BurstDirectCall
TYPE:  class
TOKEN: 0x200002F
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32 index)
END_CLASS

CLASS: PointColliderCollisionConstraintRangeKernel_000000DC$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000030
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: PointColliderCollisionConstraintRangeKernel_000000DC$BurstDirectCall
TYPE:  class
TOKEN: 0x2000031
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* lengthPtr)
END_CLASS

CLASS: PointColliderCollisionConstraintJobKernels
TYPE:  class
TOKEN: 0x200002D
FIELDS:
METHODS:
  System.Void PointColliderCollisionConstraintKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32 index)
  System.Void PointColliderCollisionConstraintRangeKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* lengthPtr)
  System.Single PointSphereColliderDetection(Unity.Mathematics.float3& nextpos, Unity.Mathematics.float3& basePos, System.Single radius, BeyondDynamicBone.AABB& aabb, BeyondDynamicBone.ColliderManager.WorkData& cwork, System.Boolean isSpring, System.Single maxLength, Unity.Mathematics.float3& normal)
  System.Single PointPlaneColliderDetction(Unity.Mathematics.float3& nextpos, System.Single radius, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal)
  System.Single PointCapsuleColliderDetection(Unity.Mathematics.float3& nextpos, System.Single radius, BeyondDynamicBone.AABB& aabb, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal)
  System.Void PointColliderCollisionConstraintKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32 index)
  System.Void PointColliderCollisionConstraintRangeKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* basePosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* lengthPtr)
END_CLASS

CLASS: EdgeColliderCollisionConstraintKernel_000000E0$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000033
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: EdgeColliderCollisionConstraintKernel_000000E0$BurstDirectCall
TYPE:  class
TOKEN: 0x2000034
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index)
END_CLASS

CLASS: EdgeColliderCollisionConstraintRangeKernel_000000E1$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000035
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: EdgeColliderCollisionConstraintRangeKernel_000000E1$BurstDirectCall
TYPE:  class
TOKEN: 0x2000036
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr)
END_CLASS

CLASS: EdgeColliderCollisionConstraintJobKernels
TYPE:  class
TOKEN: 0x2000032
FIELDS:
METHODS:
  System.Void EdgeColliderCollisionConstraintKernel(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index)
  System.Void EdgeColliderCollisionConstraintRangeKernel(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr)
  System.Single EdgeSphereColliderDetection(Unity.Mathematics.float3x2& nextPosE, Unity.Mathematics.float2& radiusE, BeyondDynamicBone.AABB& aabbE, System.Single cfr, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal)
  System.Single EdgeCapsuleColliderDetection(Unity.Mathematics.float3x2& nextPosE, Unity.Mathematics.float2& radiusE, BeyondDynamicBone.AABB& aabbE, System.Single cfr, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal)
  System.Single EdgePlaneColliderDetection(Unity.Mathematics.float3x2& nextPosE, Unity.Mathematics.float2& radiusE, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal)
  System.Void EdgeColliderCollisionConstraintKernel$BurstManaged(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index)
  System.Void EdgeColliderCollisionConstraintRangeKernel$BurstManaged(System.Int32* stepEdgeCollisionIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* edgeTeamIdArray, Unity.Mathematics.int2* edges, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, BeyondDynamicBone.ExBitFlag8* colliderFlagArray, BeyondDynamicBone.ColliderManager.WorkData* colliderWorkDataArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr)
END_CLASS

CLASS: SolveEdgeBufferAndClearKernel_000000E5$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000038
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: SolveEdgeBufferAndClearKernel_000000E5$BurstDirectCall
TYPE:  class
TOKEN: 0x2000039
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index)
END_CLASS

CLASS: SolveEdgeBufferAndClearRangeKernel_000000E6$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200003A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: SolveEdgeBufferAndClearRangeKernel_000000E6$BurstDirectCall
TYPE:  class
TOKEN: 0x200003B
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr)
END_CLASS

CLASS: SolveEdgeBufferAndClearJobKernels
TYPE:  class
TOKEN: 0x2000037
FIELDS:
METHODS:
  System.Void SolveEdgeBufferAndClearKernel(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index)
  System.Void SolveEdgeBufferAndClearRangeKernel(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr)
  System.Void SolveEdgeBufferAndClearKernel$BurstManaged(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32 index)
  System.Void SolveEdgeBufferAndClearRangeKernel$BurstManaged(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, Unity.Mathematics.float3* velocityPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* tempFrictionArray, System.Int32* tempNormalArray, System.Int32* lengthPtr)
END_CLASS

CLASS: Mode
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.ColliderCollisionConstraint.ModeNone  // 0x0
  public    static  BeyondDynamicBone.ColliderCollisionConstraint.ModePoint  // 0x0
  public    static  BeyondDynamicBone.ColliderCollisionConstraint.ModeEdge  // 0x0
METHODS:
END_CLASS

CLASS: SerializeData
TYPE:  class
TOKEN: 0x200003D
FIELDS:
  public            BeyondDynamicBone.ColliderCollisionConstraint.Modemode  // 0x10
  public            System.Single                   friction  // 0x14
  public            System.Collections.Generic.List<BeyondDynamicBone.ColliderComponent>colliderList  // 0x18
  public            System.Collections.Generic.List<UnityEngine.Transform>collisionBones  // 0x20
  public            BeyondDynamicBone.CurveSerializeDatalimitDistance  // 0x28
METHODS:
  System.Void .ctor()
  System.Void DataValidate()
  BeyondDynamicBone.ColliderCollisionConstraint.SerializeData Clone()
  System.Int32 GetHashCode()
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
  System.Int32 get_ColliderLength()
  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: ColliderCollisionConstraintParams
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  public            BeyondDynamicBone.ColliderCollisionConstraint.Modemode  // 0x10
  public            System.Single                   dynamicFriction  // 0x14
  public            System.Single                   staticFriction  // 0x18
  public            Unity.Mathematics.float4x4      limitDistance  // 0x1C
METHODS:
  System.Void Convert(BeyondDynamicBone.ColliderCollisionConstraint.SerializeData sdata, BeyondDynamicBone.ClothProcess.ClothType clothType)
END_CLASS

CLASS: PointColliderCollisionConstraintJob
TYPE:  struct
TOKEN: 0x200003F
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>stepParticleIndexArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x40
  public            Unity.Collections.NativeArray<System.Single>vertexDepths  // 0x50
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x70
  public            Unity.Collections.NativeArray<System.Single>frictionArray  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>collisionNormalArray  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityPosArray  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosArray  // 0xB0
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>colliderFlagArray  // 0xC0
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ColliderManager.WorkData>colliderWorkDataArray  // 0xD0
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0xE0
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void UnsafeDo()
  System.Void Execute(System.Int32 index)
  System.Single PointSphereColliderDetection(Unity.Mathematics.float3& nextpos, Unity.Mathematics.float3& basePos, System.Single radius, BeyondDynamicBone.AABB& aabb, BeyondDynamicBone.ColliderManager.WorkData& cwork, System.Boolean isSpring, System.Single maxLength, Unity.Mathematics.float3& normal)
  System.Single PointPlaneColliderDetction(Unity.Mathematics.float3& nextpos, System.Single radius, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal)
  System.Single PointCapsuleColliderDetection(Unity.Mathematics.float3& nextpos, System.Single radius, BeyondDynamicBone.AABB& aabb, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal)
END_CLASS

CLASS: EdgeColliderCollisionConstraintJob
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>stepEdgeCollisionIndexArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x40
  public            Unity.Collections.NativeArray<System.Single>vertexDepths  // 0x50
  public            Unity.Collections.NativeArray<System.Int16>edgeTeamIdArray  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.int2>edges  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x80
  public            Unity.Collections.NativeArray<System.Single>frictionArray  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>collisionNormalArray  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityPosArray  // 0xB0
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>colliderFlagArray  // 0xC0
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ColliderManager.WorkData>colliderWorkDataArray  // 0xD0
  public            Unity.Collections.NativeArray<System.Int32>countArray  // 0xE0
  public            Unity.Collections.NativeArray<System.Int32>sumArray  // 0xF0
  public            Unity.Collections.NativeArray<System.Int32>tempFrictionArray  // 0x100
  public            Unity.Collections.NativeArray<System.Int32>tempNormalArray  // 0x110
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x120
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Single EdgeSphereColliderDetection(Unity.Mathematics.float3x2& nextPosE, Unity.Mathematics.float2& radiusE, BeyondDynamicBone.AABB& aabbE, System.Single cfr, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal)
  System.Single EdgeCapsuleColliderDetection(Unity.Mathematics.float3x2& nextPosE, Unity.Mathematics.float2& radiusE, BeyondDynamicBone.AABB& aabbE, System.Single cfr, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal)
  System.Single EdgePlaneColliderDetection(Unity.Mathematics.float3x2& nextPosE, Unity.Mathematics.float2& radiusE, BeyondDynamicBone.ColliderManager.WorkData& cwork, Unity.Mathematics.float3& normal)
  System.Void UnsafeDo()
END_CLASS

CLASS: SolveEdgeBufferAndClearJob
TYPE:  struct
TOKEN: 0x2000041
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>jobParticleIndexList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x20
  public            Unity.Collections.NativeArray<System.Single>frictionArray  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>collisionNormalArray  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityPosArray  // 0x50
  public            Unity.Collections.NativeArray<System.Int32>countArray  // 0x60
  public            Unity.Collections.NativeArray<System.Int32>sumArray  // 0x70
  public            Unity.Collections.NativeArray<System.Int32>tempFrictionArray  // 0x80
  public            Unity.Collections.NativeArray<System.Int32>tempNormalArray  // 0x90
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0xA0
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: SerializeData
TYPE:  class
TOKEN: 0x2000048
FIELDS:
  public            BeyondDynamicBone.CurveSerializeDatastiffness  // 0x10
METHODS:
  System.Void .ctor()
  System.Void DataValidate()
  BeyondDynamicBone.DistanceConstraint.SerializeData Clone()
END_CLASS

CLASS: DistanceConstraintParams
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  public            Unity.Mathematics.float4x4      restorationStiffness  // 0x10
  public            System.Single                   velocityAttenuation  // 0x50
METHODS:
  System.Void Convert(BeyondDynamicBone.DistanceConstraint.SerializeData sdata, BeyondDynamicBone.ClothProcess.ClothType clothType)
END_CLASS

CLASS: ConstraintData
TYPE:  class
TOKEN: 0x200004A
FIELDS:
  public            BeyondDynamicBone.ResultCode    result  // 0x10
  public            System.UInt32[]                 indexArray  // 0x18
  public            System.UInt16[]                 dataArray  // 0x20
  public            System.Single[]                 distanceArray  // 0x28
METHODS:
  System.Boolean IsValid()
  System.Void .ctor()
END_CLASS

CLASS: DistanceConstraintJob
TYPE:  struct
TOKEN: 0x200004B
FIELDS:
  public            Unity.Mathematics.float4        simulationPower  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>stepParticleIndexArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x40
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x50
  public            Unity.Collections.NativeArray<System.Single>depthArray  // 0x60
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosArray  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityPosArray  // 0xA0
  public            Unity.Collections.NativeArray<System.Single>frictionArray  // 0xB0
  public            Unity.Collections.NativeArray<System.UInt32>indexArray  // 0xC0
  public            Unity.Collections.NativeArray<System.UInt16>dataArray  // 0xD0
  public            Unity.Collections.NativeArray<System.Single>distanceArray  // 0xE0
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0xF0
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: TeleportMode
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.InertiaConstraint.TeleportModeNone  // 0x0
  public    static  BeyondDynamicBone.InertiaConstraint.TeleportModeReset  // 0x0
  public    static  BeyondDynamicBone.InertiaConstraint.TeleportModeKeep  // 0x0
METHODS:
END_CLASS

CLASS: SerializeData
TYPE:  class
TOKEN: 0x200004E
FIELDS:
  public            UnityEngine.Transform           anchor  // 0x10
  public            System.Single                   anchorInertia  // 0x18
  public            System.Single                   worldInertia  // 0x1C
  public            System.Single                   movementInertiaSmoothing  // 0x20
  public            BeyondDynamicBone.CheckSliderSerializeDatamovementSpeedLimit  // 0x28
  public            BeyondDynamicBone.CheckSliderSerializeDatarotationSpeedLimit  // 0x30
  public            System.Single                   localInertia  // 0x38
  public            BeyondDynamicBone.CheckSliderSerializeDatalocalMovementSpeedLimit  // 0x40
  public            BeyondDynamicBone.CheckSliderSerializeDatalocalRotationSpeedLimit  // 0x48
  public            System.Single                   depthInertia  // 0x50
  public            System.Single                   centrifualAcceleration  // 0x54
  public            BeyondDynamicBone.CheckSliderSerializeDataparticleSpeedLimit  // 0x58
  public            BeyondDynamicBone.InertiaConstraint.TeleportModeteleportMode  // 0x60
  public            System.Single                   teleportDistance  // 0x64
  public            System.Single                   teleportRotation  // 0x68
METHODS:
  System.Void .ctor()
  BeyondDynamicBone.InertiaConstraint.SerializeData Clone()
  System.Void DataValidate()
END_CLASS

CLASS: InertiaConstraintParams
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  public            System.Single                   anchorInertia  // 0x10
  public            System.Single                   worldInertia  // 0x14
  public            System.Single                   movementInertiaSmoothing  // 0x18
  public            System.Single                   movementSpeedLimit  // 0x1C
  public            System.Single                   rotationSpeedLimit  // 0x20
  public            System.Single                   localInertia  // 0x24
  public            System.Single                   localMovementSpeedLimit  // 0x28
  public            System.Single                   localRotationSpeedLimit  // 0x2C
  public            System.Single                   depthInertia  // 0x30
  public            System.Single                   centrifualAcceleration  // 0x34
  public            System.Single                   particleSpeedLimit  // 0x38
  public            BeyondDynamicBone.InertiaConstraint.TeleportModeteleportMode  // 0x3C
  public            System.Single                   teleportDistance  // 0x40
  public            System.Single                   teleportRotation  // 0x44
METHODS:
  System.Void Convert(BeyondDynamicBone.InertiaConstraint.SerializeData sdata)
END_CLASS

CLASS: CenterData
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  public            Unity.Mathematics.float3        anchorPosition  // 0x10
  public            Unity.Mathematics.quaternion    anchorRotation  // 0x1C
  public            Unity.Mathematics.float3        oldAnchorPosition  // 0x2C
  public            Unity.Mathematics.quaternion    oldAnchorRotation  // 0x38
  public            Unity.Mathematics.float3        anchorComponentLocalPosition  // 0x48
  public            System.Int32                    centerTransformIndex  // 0x54
  public            Unity.Mathematics.float3        componentWorldPosition  // 0x58
  public            Unity.Mathematics.quaternion    componentWorldRotation  // 0x64
  public            Unity.Mathematics.float3        componentWorldScale  // 0x74
  public            Unity.Mathematics.float3        oldComponentWorldPosition  // 0x80
  public            Unity.Mathematics.quaternion    oldComponentWorldRotation  // 0x8C
  public            Unity.Mathematics.float3        oldComponentWorldScale  // 0x9C
  public            Unity.Mathematics.float3        frameComponentShiftVector  // 0xA8
  public            Unity.Mathematics.quaternion    frameComponentShiftRotation  // 0xB4
  public            System.Single                   frameMovingSpeed  // 0xC4
  public            Unity.Mathematics.float3        frameMovingDirection  // 0xC8
  public            Unity.Mathematics.float3        frameWorldPosition  // 0xD4
  public            Unity.Mathematics.quaternion    frameWorldRotation  // 0xE0
  public            Unity.Mathematics.float3        frameWorldScale  // 0xF0
  public            Unity.Mathematics.float3        frameLocalPosition  // 0xFC
  public            Unity.Mathematics.float3        oldFrameWorldPosition  // 0x108
  public            Unity.Mathematics.quaternion    oldFrameWorldRotation  // 0x114
  public            Unity.Mathematics.float3        oldFrameWorldScale  // 0x124
  public            Unity.Mathematics.float3        nowWorldPosition  // 0x130
  public            Unity.Mathematics.quaternion    nowWorldRotation  // 0x13C
  public            Unity.Mathematics.float3        oldWorldPosition  // 0x14C
  public            Unity.Mathematics.quaternion    oldWorldRotation  // 0x158
  public            System.Single                   stepMoveInertiaRatio  // 0x168
  public            System.Single                   stepRotationInertiaRatio  // 0x16C
  public            Unity.Mathematics.float3        stepVector  // 0x170
  public            Unity.Mathematics.quaternion    stepRotation  // 0x17C
  public            Unity.Mathematics.float3        inertiaVector  // 0x18C
  public            Unity.Mathematics.quaternion    inertiaRotation  // 0x198
  public            System.Single                   stepMovingSpeed  // 0x1A8
  public            Unity.Mathematics.float3        stepMovingDirection  // 0x1AC
  public            System.Single                   angularVelocity  // 0x1B8
  public            Unity.Mathematics.float3        rotationAxis  // 0x1BC
  public            Unity.Mathematics.float3        initLocalGravityDirection  // 0x1C8
  public            Unity.Mathematics.float3        smoothingVelocity  // 0x1D4
  public            Unity.Mathematics.float4x4      negativeScaleMatrix  // 0x1E0
METHODS:
  System.Void Initialize()
END_CLASS

CLASS: ConstraintData
TYPE:  class
TOKEN: 0x2000051
FIELDS:
  public            BeyondDynamicBone.ResultCode    result  // 0x10
  public            BeyondDynamicBone.InertiaConstraint.CenterDatacenterData  // 0x18
  public            Unity.Mathematics.float3        initLocalGravityDirection  // 0x228
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SerializeData
TYPE:  class
TOKEN: 0x2000058
FIELDS:
  public            System.Boolean                  useMaxDistance  // 0x10
  public            BeyondDynamicBone.CurveSerializeDatamaxDistance  // 0x18
  public            System.Boolean                  useBackstop  // 0x20
  public            System.Single                   backstopRadius  // 0x24
  public            BeyondDynamicBone.CurveSerializeDatabackstopDistance  // 0x28
  public            System.Single                   stiffness  // 0x30
METHODS:
  System.Void .ctor()
  System.Void DataValidate()
  BeyondDynamicBone.MotionConstraint.SerializeData Clone()
END_CLASS

CLASS: MotionConstraintParams
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  public            System.Boolean                  useMaxDistance  // 0x10
  public            Unity.Mathematics.float4x4      maxDistanceCurveData  // 0x14
  public            System.Boolean                  useBackstop  // 0x54
  public            System.Single                   backstopRadius  // 0x58
  public            Unity.Mathematics.float4x4      backstopDistanceCurveData  // 0x5C
  public            System.Single                   stiffness  // 0x9C
METHODS:
  System.Void Convert(BeyondDynamicBone.MotionConstraint.SerializeData sdata, BeyondDynamicBone.ClothProcess.ClothType clothType)
END_CLASS

CLASS: MotionConstraintJob
TYPE:  struct
TOKEN: 0x200005A
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>stepParticleIndexArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x40
  public            Unity.Collections.NativeArray<System.Single>vertexDepths  // 0x50
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosArray  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>baseRotArray  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityPosArray  // 0xA0
  public            Unity.Collections.NativeArray<System.Single>frictionArray  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>collisionNormalArray  // 0xC0
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0xD0
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: IntersectUpdatePrimitiveKernel_00000145$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200005D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: IntersectUpdatePrimitiveKernel_00000145$BurstDirectCall
TYPE:  class
TOKEN: 0x200005E
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32 index)
END_CLASS

CLASS: IntersectUpdatePrimitiveRangeKernel_00000146$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200005F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: IntersectUpdatePrimitiveRangeKernel_00000146$BurstDirectCall
TYPE:  class
TOKEN: 0x2000060
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32* lengthPtr)
END_CLASS

CLASS: IntersectUpdatePrimitiveJobKernels
TYPE:  class
TOKEN: 0x200005C
FIELDS:
METHODS:
  System.Void IntersectUpdatePrimitiveKernel(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32 index)
  System.Void IntersectUpdatePrimitiveRangeKernel(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32* lengthPtr)
  System.Void IntersectUpdatePrimitiveKernel$BurstManaged(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32 index)
  System.Void IntersectUpdatePrimitiveRangeKernel$BurstManaged(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, System.UInt32* processingArray, System.Int32* lengthPtr)
END_CLASS

CLASS: UpdatePrimitiveKernel_00000147$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000062
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: UpdatePrimitiveKernel_00000147$BurstDirectCall
TYPE:  class
TOKEN: 0x2000063
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32 index)
END_CLASS

CLASS: UpdatePrimitiveRangeKernel_00000148$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000064
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: UpdatePrimitiveRangeKernel_00000148$BurstDirectCall
TYPE:  class
TOKEN: 0x2000065
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32* lengthPtr)
END_CLASS

CLASS: UpdatePrimitiveJobKernels
TYPE:  class
TOKEN: 0x2000061
FIELDS:
METHODS:
  System.Void UpdatePrimitiveKernel(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32 index)
  System.Void UpdatePrimitiveRangeKernel(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32* lengthPtr)
  System.Void UpdatePrimitiveKernel$BurstManaged(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32 index)
  System.Void UpdatePrimitiveRangeKernel$BurstManaged(System.UInt32 kind, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, System.Single* frictionArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.UInt32* processingArray, System.Int32* lengthPtr)
END_CLASS

CLASS: ClearBufferKernel_00000149$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000067
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: ClearBufferKernel_00000149$BurstDirectCall
TYPE:  class
TOKEN: 0x2000068
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke()
END_CLASS

CLASS: ClearBufferJobKernels
TYPE:  class
TOKEN: 0x2000066
FIELDS:
METHODS:
  System.Void ClearBufferKernel()
  System.Void ClearBufferKernel$BurstManaged()
END_CLASS

CLASS: SortKernel_0000014A$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200006A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: SortKernel_0000014A$BurstDirectCall
TYPE:  class
TOKEN: 0x200006B
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 index)
END_CLASS

CLASS: SortRangeKernel_0000014B$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200006C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 length)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: SortRangeKernel_0000014B$BurstDirectCall
TYPE:  class
TOKEN: 0x200006D
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 length)
END_CLASS

CLASS: SortJobKernels
TYPE:  class
TOKEN: 0x2000069
FIELDS:
METHODS:
  System.Void SortKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 index)
  System.Void SortRangeKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 length)
  System.Void SortKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 index)
  System.Void SortRangeKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.SelfCollisionConstraint.Primitive* primitiveArray, BeyondDynamicBone.SelfCollisionConstraint.SortData* sortAndSweepArray, System.Int32 length)
END_CLASS

CLASS: SelfCollisionMode
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionModeNone  // 0x0
  public    static  BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionModeFullMesh  // 0x0
METHODS:
END_CLASS

CLASS: SerializeData
TYPE:  class
TOKEN: 0x200006F
FIELDS:
  public            BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionModeselfMode  // 0x10
  public            BeyondDynamicBone.CurveSerializeDatasurfaceThickness  // 0x18
  public            BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionModesyncMode  // 0x20
  public            BeyondDynamicBone.BeyondBoneClothsyncPartner  // 0x28
  public            System.Single                   clothMass  // 0x30
METHODS:
  System.Void .ctor()
  System.Void DataValidate()
  BeyondDynamicBone.SelfCollisionConstraint.SerializeData Clone()
  BeyondDynamicBone.BeyondBoneCloth GetSyncPartner()
END_CLASS

CLASS: SelfCollisionConstraintParams
TYPE:  struct
TOKEN: 0x2000070
FIELDS:
  public            BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionModeselfMode  // 0x10
  public            Unity.Mathematics.float4x4      surfaceThicknessCurveData  // 0x14
  public            BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionModesyncMode  // 0x54
  public            System.Single                   clothMass  // 0x58
METHODS:
  System.Void Convert(BeyondDynamicBone.SelfCollisionConstraint.SerializeData sdata, BeyondDynamicBone.ClothProcess.ClothType clothType)
END_CLASS

CLASS: Primitive
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  public            System.UInt32                   flagAndTeamId  // 0x10
  public            System.Int32                    sortIndex  // 0x14
  public            Unity.Mathematics.int3          particleIndices  // 0x18
  public            Unity.Mathematics.float3x3      nextPos  // 0x24
  public            Unity.Mathematics.float3x3      oldPos  // 0x48
  public            Unity.Mathematics.float3        invMass  // 0x6C
  public            System.Single                   thickness  // 0x78
METHODS:
  System.Boolean IsIgnore()
  System.Boolean HasParticle(System.Int32 p)
  System.UInt32 GetKind()
  System.Int32 GetTeamId()
  System.Single GetSolveThickness(BeyondDynamicBone.SelfCollisionConstraint.Primitive& pri)
  System.Boolean AnyParticle(BeyondDynamicBone.SelfCollisionConstraint.Primitive& pri)
END_CLASS

CLASS: SortData
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  public            System.UInt32                   flagAndTeamId  // 0x10
  public            System.Int32                    primitiveIndex  // 0x14
  public            Unity.Mathematics.float2        firstMinMax  // 0x18
  public            Unity.Mathematics.float2        secondMinMax  // 0x20
  public            Unity.Mathematics.float2        thirdMinMax  // 0x28
METHODS:
  System.Int32 CompareTo(BeyondDynamicBone.SelfCollisionConstraint.SortData other)
  System.UInt32 GetKind()
END_CLASS

CLASS: EdgeEdgeContact
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  public            System.UInt32                   flagAndTeamId0  // 0x10
  public            System.UInt32                   flagAndTeamId1  // 0x14
  public            Unity.Mathematics.half          thickness  // 0x18
  public            Unity.Mathematics.half          s  // 0x1A
  public            Unity.Mathematics.half          t  // 0x1C
  public            Unity.Mathematics.half3         n  // 0x1E
  public            Unity.Mathematics.half2         edgeInvMass0  // 0x24
  public            Unity.Mathematics.half2         edgeInvMass1  // 0x28
  public            Unity.Mathematics.int2          edgeParticleIndex0  // 0x2C
  public            Unity.Mathematics.int2          edgeParticleIndex1  // 0x34
METHODS:
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: PointTriangleContact
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  public            System.UInt32                   flagAndTeamId0  // 0x10
  public            System.UInt32                   flagAndTeamId1  // 0x14
  public            Unity.Mathematics.half          thickness  // 0x18
  public            Unity.Mathematics.half          sign  // 0x1A
  public            System.Int32                    pointParticleIndex  // 0x1C
  public            Unity.Mathematics.int3          triangleParticleIndex  // 0x20
  public            Unity.Mathematics.half          pointInvMass  // 0x2C
  public            Unity.Mathematics.half3         triangleInvMass  // 0x2E
METHODS:
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: InitPrimitiveJob
TYPE:  struct
TOKEN: 0x2000075
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            BeyondDynamicBone.TeamManager.TeamDatatdata  // 0x18
  public            System.UInt32                   kind  // 0x1E8
  public            System.Int32                    startPrimitive  // 0x1EC
  public            System.Int32                    startSort  // 0x1F0
  public            Unity.Collections.NativeArray<Unity.Mathematics.int2>edges  // 0x1F8
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>triangles  // 0x208
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive>primitiveArray  // 0x218
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData>sortArray  // 0x228
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: ClearBufferJob
TYPE:  struct
TOKEN: 0x2000076
FIELDS:
  public            Unity.Collections.NativeQueue<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact>edgeEdgeContactQueue  // 0x10
  public            Unity.Collections.NativeQueue<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact>pointTriangleContactQueue  // 0x28
METHODS:
  System.Void Execute()
END_CLASS

CLASS: UpdatePrimitiveJob
TYPE:  struct
TOKEN: 0x2000077
FIELDS:
  public            System.UInt32                   kind  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x18
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x28
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x38
  public            Unity.Collections.NativeArray<System.Single>depthArray  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosArray  // 0x68
  public            Unity.Collections.NativeArray<System.Single>frictionArray  // 0x78
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive>primitiveArray  // 0x88
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData>sortAndSweepArray  // 0x98
  public            Unity.Collections.NativeArray<System.UInt32>processingArray  // 0xA8
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0xB8
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: SortJob
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive>primitiveArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData>sortAndSweepArray  // 0x30
  public            System.Int32                    _indexCount  // 0x40
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: PointTriangleBroadPhaseJob
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  public            System.UInt32                   mainKind  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>triangles  // 0x28
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosArray  // 0x58
  public            Unity.Collections.NativeArray<System.Single>frictionArray  // 0x68
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive>primitiveArray  // 0x78
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData>sortAndSweepArray  // 0x88
  public            Unity.Collections.NativeArray<System.UInt32>processingPointTriangleArray  // 0x98
  public            Unity.Collections.NativeQueue.ParallelWriter<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact>pointTriangleContactQueue  // 0xA8
  public            Unity.Collections.NativeArray<System.Byte>intersectFlagArray  // 0xC0
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0xD0
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void SweepTest(System.Int32 sortIndex, BeyondDynamicBone.SelfCollisionConstraint.Primitive& primitive0, BeyondDynamicBone.SelfCollisionConstraint.SortData& sd0, BeyondDynamicBone.DataChunk& subChunk, System.Boolean connectionCheck)
  System.Void BroadPointTriangle(BeyondDynamicBone.SelfCollisionConstraint.Primitive& p_pri, BeyondDynamicBone.SelfCollisionConstraint.Primitive& t_pri, System.Single thickness, System.Single scr, System.Single ang)
END_CLASS

CLASS: EdgeEdgeBroadPhaseJob
TYPE:  struct
TOKEN: 0x200007A
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive>primitiveArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData>sortAndSweepArray  // 0x30
  public            Unity.Collections.NativeArray<System.UInt32>processingEdgeEdgeArray  // 0x40
  public            Unity.Collections.NativeQueue.ParallelWriter<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact>edgeEdgeContactQueue  // 0x50
  public            Unity.Collections.NativeArray<System.Byte>intersectFlagArray  // 0x68
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x78
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void SweepTest(System.Int32 sortIndex, BeyondDynamicBone.SelfCollisionConstraint.Primitive& primitive0, BeyondDynamicBone.SelfCollisionConstraint.SortData& sd0, BeyondDynamicBone.DataChunk& subChunk, System.Boolean connectionCheck)
  System.Void BroadEdgeEdge(BeyondDynamicBone.SelfCollisionConstraint.Primitive& pri0, BeyondDynamicBone.SelfCollisionConstraint.Primitive& pri1, System.Single thickness, System.Single scr)
END_CLASS

CLASS: EdgeEdgeToListJob
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public            Unity.Collections.NativeQueue<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact>edgeEdgeContactQueue  // 0x10
  public            Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact>edgeEdgeContactList  // 0x28
METHODS:
  System.Void Execute()
END_CLASS

CLASS: PointTriangleToListJob
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  public            Unity.Collections.NativeQueue<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact>pointTriangleContactQueue  // 0x10
  public            Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact>pointTriangleContactList  // 0x28
METHODS:
  System.Void Execute()
END_CLASS

CLASS: UpdateEdgeEdgeBroadPhaseJob
TYPE:  struct
TOKEN: 0x200007D
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosArray  // 0x20
  public            Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact>edgeEdgeContactList  // 0x30
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: UpdatePointTriangleBroadPhaseJob
TYPE:  struct
TOKEN: 0x200007E
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosArray  // 0x20
  public            Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact>pointTriangleContactList  // 0x30
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: SolverEdgeEdgeJob
TYPE:  struct
TOKEN: 0x200007F
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact>edgeEdgeContactArray  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>countArray  // 0x30
  public            Unity.Collections.NativeArray<System.Int32>sumArray  // 0x40
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: SolverPointTriangleJob
TYPE:  struct
TOKEN: 0x2000080
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact>pointTriangleContactArray  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>countArray  // 0x30
  public            Unity.Collections.NativeArray<System.Int32>sumArray  // 0x40
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: IntersectUpdatePrimitiveJob
TYPE:  struct
TOKEN: 0x2000081
FIELDS:
  public            System.UInt32                   kind  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x28
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive>primitiveArray  // 0x38
  public            Unity.Collections.NativeArray<System.UInt32>processingArray  // 0x48
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x58
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: IntersectEdgeTriangleJob
TYPE:  struct
TOKEN: 0x2000082
FIELDS:
  public            System.UInt32                   mainKind  // 0x10
  public            System.Int32                    execNumber  // 0x14
  public            System.Int32                    div  // 0x18
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive>primitiveArray  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData>sortAndSweepArray  // 0x40
  public            Unity.Collections.NativeArray<System.UInt32>processingEdgeEdgeArray  // 0x50
  public            Unity.Collections.NativeArray<System.Byte>intersectFlagArray  // 0x60
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x70
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void SweepTest(BeyondDynamicBone.SelfCollisionConstraint.Primitive& primitive0, BeyondDynamicBone.SelfCollisionConstraint.SortData& sd0, BeyondDynamicBone.DataChunk& subChunk, System.Boolean connectionCheck)
  System.Void IntersectTest(BeyondDynamicBone.SelfCollisionConstraint.Primitive& epri, BeyondDynamicBone.SelfCollisionConstraint.Primitive& tpri)
END_CLASS

CLASS: SolverPointTriangleCrossFrameKernel_0000017E$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000084
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: SolverPointTriangleCrossFrameKernel_0000017E$BurstDirectCall
TYPE:  class
TOKEN: 0x2000085
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
END_CLASS

CLASS: SolverPointTriangleCrossFrameRangeKernel_0000017F$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000086
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
  System.IAsyncResult BeginInvoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: SolverPointTriangleCrossFrameRangeKernel_0000017F$BurstDirectCall
TYPE:  class
TOKEN: 0x2000087
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
END_CLASS

CLASS: SolverPointTriangleCrossFrameJobKernels
TYPE:  class
TOKEN: 0x2000083
FIELDS:
METHODS:
  System.Void SolverPointTriangleCrossFrameKernel(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.Void SolverPointTriangleCrossFrameRangeKernel(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
  System.Void SolverPointTriangleCrossFrameKernel$BurstManaged(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.Void SolverPointTriangleCrossFrameRangeKernel$BurstManaged(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact* pointTriangleContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
END_CLASS

CLASS: SolverEdgeEdgeCrossFrameKernel_00000180$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000089
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: SolverEdgeEdgeCrossFrameKernel_00000180$BurstDirectCall
TYPE:  class
TOKEN: 0x200008A
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
END_CLASS

CLASS: SolverEdgeEdgeCrossFrameRangeKernel_00000181$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200008B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
  System.IAsyncResult BeginInvoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: SolverEdgeEdgeCrossFrameRangeKernel_00000181$BurstDirectCall
TYPE:  class
TOKEN: 0x200008C
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
END_CLASS

CLASS: SolverEdgeEdgeCrossFrameJobKernels
TYPE:  class
TOKEN: 0x2000088
FIELDS:
METHODS:
  System.Void SolverEdgeEdgeCrossFrameKernel(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.Void SolverEdgeEdgeCrossFrameRangeKernel(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
  System.Void SolverEdgeEdgeCrossFrameKernel$BurstManaged(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.Void SolverEdgeEdgeCrossFrameRangeKernel$BurstManaged(Unity.Mathematics.float3* nextPosArray, BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact* edgeEdgeContactArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
END_CLASS

CLASS: UpdateEdgeEdgeBroadPhaseCrossFrameJob
TYPE:  struct
TOKEN: 0x200008D
FIELDS:
  public            Unity.Collections.NativeReference<System.Int32>indexCount  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosArray  // 0x30
  public            Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact>edgeEdgeContactList  // 0x40
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void Execute()
END_CLASS

CLASS: UpdatePointTriangleBroadPhaseCrossFrameJob
TYPE:  struct
TOKEN: 0x200008E
FIELDS:
  public            Unity.Collections.NativeReference<System.Int32>indexCount  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosArray  // 0x30
  public            Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact>pointTriangleContactList  // 0x40
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void Execute()
END_CLASS

CLASS: SolverEdgeEdgeCrossFrameJob
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact>edgeEdgeContactArray  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>countArray  // 0x30
  public            Unity.Collections.NativeArray<System.Int32>sumArray  // 0x40
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void Execute()
  System.Void UnsafeDo()
END_CLASS

CLASS: SolverPointTriangleCrossFrameJob
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact>pointTriangleContactArray  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>countArray  // 0x30
  public            Unity.Collections.NativeArray<System.Int32>sumArray  // 0x40
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void Execute()
  System.Void UnsafeDo()
END_CLASS

CLASS: SerializeData
TYPE:  class
TOKEN: 0x2000092
FIELDS:
  public            System.Boolean                  useSpring  // 0x10
  public            System.Single                   springPower  // 0x14
  public            System.Single                   limitDistance  // 0x18
  public            System.Single                   normalLimitRatio  // 0x1C
  public            System.Single                   springNoise  // 0x20
METHODS:
  System.Void .ctor()
  System.Void DataValidate()
  BeyondDynamicBone.SpringConstraint.SerializeData Clone()
END_CLASS

CLASS: SpringConstraintParams
TYPE:  struct
TOKEN: 0x2000093
FIELDS:
  public            System.Single                   springPower  // 0x10
  public            System.Single                   limitDistance  // 0x14
  public            System.Single                   normalLimitRatio  // 0x18
  public            System.Single                   springNoise  // 0x1C
METHODS:
  System.Void Convert(BeyondDynamicBone.SpringConstraint.SerializeData sdata, BeyondDynamicBone.ClothProcess.ClothType clothType)
END_CLASS

CLASS: SerializeData
TYPE:  class
TOKEN: 0x200009A
FIELDS:
  public            System.Single                   distanceCompression  // 0x10
METHODS:
  System.Void .ctor()
  System.Void DataValidate()
  BeyondDynamicBone.TetherConstraint.SerializeData Clone()
END_CLASS

CLASS: TetherConstraintParams
TYPE:  struct
TOKEN: 0x200009B
FIELDS:
  public            System.Single                   compressionLimit  // 0x10
  public            System.Single                   stretchLimit  // 0x14
METHODS:
  System.Void Convert(BeyondDynamicBone.TetherConstraint.SerializeData sdata, BeyondDynamicBone.ClothProcess.ClothType clothType)
END_CLASS

CLASS: TethreConstraintJob
TYPE:  struct
TOKEN: 0x200009C
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>stepParticleIndexArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData>centerDataArray  // 0x40
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x50
  public            Unity.Collections.NativeArray<System.Single>vertexDepths  // 0x60
  public            Unity.Collections.NativeArray<System.Int32>vertexRootIndices  // 0x70
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityPosArray  // 0xA0
  public            Unity.Collections.NativeArray<System.Single>frictionArray  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>stepBasicPositionBuffer  // 0xC0
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0xD0
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: TriangleBendingKernel_000001AA$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200009F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index)
  System.IAsyncResult BeginInvoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: TriangleBendingKernel_000001AA$BurstDirectCall
TYPE:  class
TOKEN: 0x20000A0
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index)
END_CLASS

CLASS: TriangleBendingRangeKernel_000001AB$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000A1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: TriangleBendingRangeKernel_000001AB$BurstDirectCall
TYPE:  class
TOKEN: 0x20000A2
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr)
END_CLASS

CLASS: TriangleBendingJobKernels
TYPE:  class
TOKEN: 0x200009E
FIELDS:
METHODS:
  System.Void TriangleBendingKernel(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index)
  System.Void TriangleBendingRangeKernel(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr)
  System.Boolean Volume(Unity.Mathematics.float3x4& nextPosBuffer, Unity.Mathematics.float4& invMassBuffer, System.Single volumeRest, System.Single stiffness, Unity.Mathematics.float3x4& addPosBuffer)
  System.Boolean DihedralAngle(System.Single sign, Unity.Mathematics.float3x4& nextPosBuffer, Unity.Mathematics.float4& invMassBuffer, System.Single restAngle, System.Single stiffness, Unity.Mathematics.float3x4& addPosBuffer)
  System.Void TriangleBendingKernel$BurstManaged(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index)
  System.Void TriangleBendingRangeKernel$BurstManaged(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepTriangleBendIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* nextPosArray, System.Single* frictionArray, System.UInt64* trianglePairArray, System.Single* restAngleOrVolumeArray, System.SByte* signOrVolumeArray, System.UInt32* writeDataArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr)
END_CLASS

CLASS: SolveAggregateBufferKernel_000001AE$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000A4
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: SolveAggregateBufferKernel_000001AE$BurstDirectCall
TYPE:  class
TOKEN: 0x20000A5
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index)
END_CLASS

CLASS: SolveAggregateBufferRangeKernel_000001AF$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000A6
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: SolveAggregateBufferRangeKernel_000001AF$BurstDirectCall
TYPE:  class
TOKEN: 0x20000A7
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr)
END_CLASS

CLASS: SolveAggregateBufferJobKernels
TYPE:  class
TOKEN: 0x20000A3
FIELDS:
METHODS:
  System.Void SolveAggregateBufferKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index)
  System.Void SolveAggregateBufferRangeKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr)
  System.Void SolveAggregateBufferKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32 index)
  System.Void SolveAggregateBufferRangeKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, System.UInt32* writeIndexArray, Unity.Mathematics.float3* writeBuffer, System.Int32* lengthPtr)
END_CLASS

CLASS: Method
TYPE:  struct
TOKEN: 0x20000A8
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.TriangleBendingConstraint.MethodNone  // 0x0
  public    static  BeyondDynamicBone.TriangleBendingConstraint.MethodDihedralAngle  // 0x0
  public    static  BeyondDynamicBone.TriangleBendingConstraint.MethodDirectionDihedralAngle  // 0x0
METHODS:
END_CLASS

CLASS: SerializeData
TYPE:  class
TOKEN: 0x20000A9
FIELDS:
  public            System.Single                   stiffness  // 0x10
METHODS:
  System.Void .ctor()
  System.Void DataValidate()
  BeyondDynamicBone.TriangleBendingConstraint.SerializeData Clone()
END_CLASS

CLASS: TriangleBendingConstraintParams
TYPE:  struct
TOKEN: 0x20000AA
FIELDS:
  public            BeyondDynamicBone.TriangleBendingConstraint.Methodmethod  // 0x10
  public            System.Single                   stiffness  // 0x14
METHODS:
  System.Void Convert(BeyondDynamicBone.TriangleBendingConstraint.SerializeData sdata)
END_CLASS

CLASS: ConstraintData
TYPE:  class
TOKEN: 0x20000AB
FIELDS:
  public            BeyondDynamicBone.ResultCode    result  // 0x10
  public            System.UInt64[]                 trianglePairArray  // 0x18
  public            System.Single[]                 restAngleOrVolumeArray  // 0x20
  public            System.SByte[]                  signOrVolumeArray  // 0x28
  public            System.Int32                    writeBufferCount  // 0x30
  public            System.UInt32[]                 writeDataArray  // 0x38
  public            System.UInt32[]                 writeIndexArray  // 0x40
METHODS:
  System.Boolean IsValid()
  System.Void .ctor()
END_CLASS

CLASS: TriangleBendingJob
TYPE:  struct
TOKEN: 0x20000AC
FIELDS:
  public            Unity.Mathematics.float4        simulationPower  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>stepTriangleBendIndexArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x40
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x50
  public            Unity.Collections.NativeArray<System.Single>depthArray  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x70
  public            Unity.Collections.NativeArray<System.Single>frictionArray  // 0x80
  public            Unity.Collections.NativeArray<System.UInt64>trianglePairArray  // 0x90
  public            Unity.Collections.NativeArray<System.Single>restAngleOrVolumeArray  // 0xA0
  public            Unity.Collections.NativeArray<System.SByte>signOrVolumeArray  // 0xB0
  public            Unity.Collections.NativeArray<System.UInt32>writeDataArray  // 0xC0
  public            Unity.Collections.NativeArray<System.UInt32>writeIndexArray  // 0xD0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>writeBuffer  // 0xE0
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0xF0
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Boolean Volume(Unity.Mathematics.float3x4& nextPosBuffer, Unity.Mathematics.float4& invMassBuffer, System.Single volumeRest, System.Single stiffness, Unity.Mathematics.float3x4& addPosBuffer)
  System.Boolean DihedralAngle(System.Single sign, Unity.Mathematics.float3x4& nextPosBuffer, Unity.Mathematics.float4& invMassBuffer, System.Single restAngle, System.Single stiffness, Unity.Mathematics.float3x4& addPosBuffer)
  System.Void UnsafeDo()
END_CLASS

CLASS: SolveAggregateBufferJob
TYPE:  struct
TOKEN: 0x20000AD
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>stepParticleIndexArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x30
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x50
  public            Unity.Collections.NativeArray<System.UInt32>writeIndexArray  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>writeBuffer  // 0x70
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x80
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: CameraCullingMode
TYPE:  struct
TOKEN: 0x20000AF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.CullingSettings.CameraCullingModeOff  // 0x0
  public    static  BeyondDynamicBone.CullingSettings.CameraCullingModeReset  // 0x0
  public    static  BeyondDynamicBone.CullingSettings.CameraCullingModeKeep  // 0x0
  public    static  BeyondDynamicBone.CullingSettings.CameraCullingModeAnimatorLinkage  // 0x0
METHODS:
END_CLASS

CLASS: CameraCullingMethod
TYPE:  struct
TOKEN: 0x20000B0
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.CullingSettings.CameraCullingMethodAutomaticRenderer  // 0x0
  public    static  BeyondDynamicBone.CullingSettings.CameraCullingMethodManualRenderer  // 0x0
METHODS:
END_CLASS

CLASS: CullingParams
TYPE:  struct
TOKEN: 0x20000B1
FIELDS:
  public            System.Boolean                  useDistanceCulling  // 0x10
  public            System.Single                   distanceCullingLength  // 0x14
  public            System.Single                   distanceCullingFadeRatio  // 0x18
METHODS:
  System.Void Convert(BeyondDynamicBone.CullingSettings cullingSettings)
END_CLASS

CLASS: AlignmentMode
TYPE:  struct
TOKEN: 0x20000B7
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.NormalAlignmentSettings.AlignmentModeNone  // 0x0
  public    static  BeyondDynamicBone.NormalAlignmentSettings.AlignmentModeBoundingBoxCenter  // 0x0
  public    static  BeyondDynamicBone.NormalAlignmentSettings.AlignmentModeTransform  // 0x0
METHODS:
END_CLASS

CLASS: TransformPositionJob
TYPE:  struct
TOKEN: 0x20000B9
FIELDS:
  public            Unity.Mathematics.float4x4      transformMatrix  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x50
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: CreateGridMapJob
TYPE:  struct
TOKEN: 0x20000BA
FIELDS:
  public            System.Boolean                  move  // 0x10
  public            System.Boolean                  fix  // 0x11
  public            System.Boolean                  ignore  // 0x12
  public            System.Boolean                  invalid  // 0x13
  public            Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32>gridMap  // 0x18
  public            System.Single                   gridSize  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positions  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attribute  // 0x40
METHODS:
  System.Void Execute()
END_CLASS

CLASS: ConvertSelectionJob
TYPE:  struct
TOKEN: 0x20000BB
FIELDS:
  public            System.Single                   gridSize  // 0x10
  public            System.Single                   radius  // 0x14
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>toPositions  // 0x18
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>toAttributes  // 0x28
  public            Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32>gridMap  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>fromPositions  // 0x48
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>fromAttributes  // 0x58
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Mode
TYPE:  struct
TOKEN: 0x20000BD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.BeyondBoneWindZone.ModeGlobalDirection  // 0x0
  public    static  BeyondDynamicBone.BeyondBoneWindZone.ModeSphereDirection  // 0x0
  public    static  BeyondDynamicBone.BeyondBoneWindZone.ModeBoxDirection  // 0x0
  public    static  BeyondDynamicBone.BeyondBoneWindZone.ModeSphereRadial  // 0x0
METHODS:
END_CLASS

CLASS: Result
TYPE:  struct
TOKEN: 0x20000C1
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.Define.Result None  // 0x0
  public    static  BeyondDynamicBone.Define.Result Empty  // 0x0
  public    static  BeyondDynamicBone.Define.Result Success  // 0x0
  public    static  BeyondDynamicBone.Define.Result Cancel  // 0x0
  public    static  BeyondDynamicBone.Define.Result Process  // 0x0
  public    static  BeyondDynamicBone.Define.Result Warning  // 0x0
  public    static  BeyondDynamicBone.Define.Result RenderMesh_UnknownWarning  // 0x0
  public    static  BeyondDynamicBone.Define.Result RenderMesh_VertexWeightIs5BonesOrMore  // 0x0
  public    static  BeyondDynamicBone.Define.Result Init_NonUniformScale  // 0x0
  public    static  BeyondDynamicBone.Define.Result Error  // 0x0
  public    static  BeyondDynamicBone.Define.Result SerializeData_InvalidData  // 0x0
  public    static  BeyondDynamicBone.Define.Result SerializeData_Over31Renderers  // 0x0
  public    static  BeyondDynamicBone.Define.Result Init_InvalidData  // 0x0
  public    static  BeyondDynamicBone.Define.Result Init_InvalidPaintMap  // 0x0
  public    static  BeyondDynamicBone.Define.Result Init_PaintMapNotReadable  // 0x0
  public    static  BeyondDynamicBone.Define.Result Init_ScaleIsZero  // 0x0
  public    static  BeyondDynamicBone.Define.Result Init_NegativeScale  // 0x0
  public    static  BeyondDynamicBone.Define.Result RenderSetup_Exception  // 0x0
  public    static  BeyondDynamicBone.Define.Result RenderSetup_UnknownError  // 0x0
  public    static  BeyondDynamicBone.Define.Result RenderSetup_InvalidSource  // 0x0
  public    static  BeyondDynamicBone.Define.Result RenderSetup_NoMeshOnRenderer  // 0x0
  public    static  BeyondDynamicBone.Define.Result RenderSetup_InvalidType  // 0x0
  public    static  BeyondDynamicBone.Define.Result RenderSetup_Unreadable  // 0x0
  public    static  BeyondDynamicBone.Define.Result RenderSetup_Over65535vertices  // 0x0
  public    static  BeyondDynamicBone.Define.Result VirtualMesh_UnknownError  // 0x0
  public    static  BeyondDynamicBone.Define.Result VirtualMesh_InvalidSetup  // 0x0
  public    static  BeyondDynamicBone.Define.Result VirtualMesh_InvalidRenderData  // 0x0
  public    static  BeyondDynamicBone.Define.Result VirtualMesh_ImportError  // 0x0
  public    static  BeyondDynamicBone.Define.Result VirtualMesh_SelectionException  // 0x0
  public    static  BeyondDynamicBone.Define.Result VirtualMesh_SelectionUnknownError  // 0x0
  public    static  BeyondDynamicBone.Define.Result VirtualMesh_InvalidSelection  // 0x0
  public    static  BeyondDynamicBone.Define.Result CreateCloth_Exception  // 0x0
  public    static  BeyondDynamicBone.Define.Result CreateCloth_UnknownError  // 0x0
  public    static  BeyondDynamicBone.Define.Result CreateCloth_InvalidCloth  // 0x0
  public    static  BeyondDynamicBone.Define.Result CreateCloth_InvalidSerializeData  // 0x0
  public    static  BeyondDynamicBone.Define.Result CreateCloth_InvalidSetupList  // 0x0
  public    static  BeyondDynamicBone.Define.Result CreateCloth_NoRenderer  // 0x0
  public    static  BeyondDynamicBone.Define.Result CreateCloth_InvalidPaintMap  // 0x0
  public    static  BeyondDynamicBone.Define.Result CreateCloth_PaintMapNotReadable  // 0x0
  public    static  BeyondDynamicBone.Define.Result CreateCloth_PaintMapCountMismatch  // 0x0
  public    static  BeyondDynamicBone.Define.Result CreateCloth_CanNotStart  // 0x0
  public    static  BeyondDynamicBone.Define.Result CreateCloth_VertexAttributeListCountMismatch  // 0x0
  public    static  BeyondDynamicBone.Define.Result CreateCloth_VertexAttributeListIsNull  // 0x0
  public    static  BeyondDynamicBone.Define.Result CreateCloth_VertexAttributeListDataMismatch  // 0x0
  public    static  BeyondDynamicBone.Define.Result CreateCloth_InvalidVertexAttributeData  // 0x0
  public    static  BeyondDynamicBone.Define.Result Reduction_Exception  // 0x0
  public    static  BeyondDynamicBone.Define.Result Reduction_UnknownError  // 0x0
  public    static  BeyondDynamicBone.Define.Result Reduction_InitError  // 0x0
  public    static  BeyondDynamicBone.Define.Result Reduction_SameDistanceException  // 0x0
  public    static  BeyondDynamicBone.Define.Result Reduction_SimpleDistanceException  // 0x0
  public    static  BeyondDynamicBone.Define.Result Reduction_ShapeDistanceException  // 0x0
  public    static  BeyondDynamicBone.Define.Result Reduction_MaxSideLengthZero  // 0x0
  public    static  BeyondDynamicBone.Define.Result Reduction_OrganizationError  // 0x0
  public    static  BeyondDynamicBone.Define.Result Reduction_StoreVirtualMeshError  // 0x0
  public    static  BeyondDynamicBone.Define.Result Reduction_CalcAverageException  // 0x0
  public    static  BeyondDynamicBone.Define.Result Optimize_Exception  // 0x0
  public    static  BeyondDynamicBone.Define.Result ProxyMesh_Exception  // 0x0
  public    static  BeyondDynamicBone.Define.Result ProxyMesh_UnknownError  // 0x0
  public    static  BeyondDynamicBone.Define.Result ProxyMesh_ApplySelectionError  // 0x0
  public    static  BeyondDynamicBone.Define.Result ProxyMesh_ConvertError  // 0x0
  public    static  BeyondDynamicBone.Define.Result ProxyMesh_Over32767Vertices  // 0x0
  public    static  BeyondDynamicBone.Define.Result ProxyMesh_Over32767Edges  // 0x0
  public    static  BeyondDynamicBone.Define.Result ProxyMesh_Over32767Triangles  // 0x0
  public    static  BeyondDynamicBone.Define.Result MappingMesh_Exception  // 0x0
  public    static  BeyondDynamicBone.Define.Result MappingMesh_UnknownError  // 0x0
  public    static  BeyondDynamicBone.Define.Result MappingMesh_ProxyError  // 0x0
  public    static  BeyondDynamicBone.Define.Result ClothInit_Exception  // 0x0
  public    static  BeyondDynamicBone.Define.Result ClothInit_FailedAddRenderer  // 0x0
  public    static  BeyondDynamicBone.Define.Result ClothProcess_Exception  // 0x0
  public    static  BeyondDynamicBone.Define.Result ClothProcess_UnknownError  // 0x0
  public    static  BeyondDynamicBone.Define.Result ClothProcess_Invalid  // 0x0
  public    static  BeyondDynamicBone.Define.Result ClothProcess_InvalidRenderHandleList  // 0x0
  public    static  BeyondDynamicBone.Define.Result ClothProcess_GenerateSelectionError  // 0x0
  public    static  BeyondDynamicBone.Define.Result ClothProcess_OverflowTeamCount4096  // 0x0
  public    static  BeyondDynamicBone.Define.Result Constraint_Exception  // 0x0
  public    static  BeyondDynamicBone.Define.Result Constraint_UnknownError  // 0x0
  public    static  BeyondDynamicBone.Define.Result Constraint_CreateDistanceException  // 0x0
  public    static  BeyondDynamicBone.Define.Result Constraint_CreateTriangleBendingException  // 0x0
  public    static  BeyondDynamicBone.Define.Result Constraint_CreateInertiaException  // 0x0
  public    static  BeyondDynamicBone.Define.Result Constraint_CreateSelfCollisionException  // 0x0
  public    static  BeyondDynamicBone.Define.Result MagicaMesh_UnknownError  // 0x0
  public    static  BeyondDynamicBone.Define.Result MagicaMesh_Invalid  // 0x0
  public    static  BeyondDynamicBone.Define.Result MagicaMesh_InvalidRenderer  // 0x0
  public    static  BeyondDynamicBone.Define.Result MagicaMesh_InvalidMeshFilter  // 0x0
  public    static  BeyondDynamicBone.Define.Result PreBuildData_UnknownError  // 0x0
  public    static  BeyondDynamicBone.Define.Result PreBuildData_MagicaClothException  // 0x0
  public    static  BeyondDynamicBone.Define.Result PreBuildData_VirtualMeshDeserializationException  // 0x0
  public    static  BeyondDynamicBone.Define.Result PreBuildData_VerificationResult  // 0x0
  public    static  BeyondDynamicBone.Define.Result PreBuildData_VersionMismatch  // 0x0
  public    static  BeyondDynamicBone.Define.Result PreBuildData_InvalidClothData  // 0x0
  public    static  BeyondDynamicBone.Define.Result PreBuildData_Empty  // 0x0
  public    static  BeyondDynamicBone.Define.Result PreBuildData_InvalidScale  // 0x0
  public    static  BeyondDynamicBone.Define.Result PreBuild_UnknownError  // 0x0
  public    static  BeyondDynamicBone.Define.Result PreBuild_Exception  // 0x0
  public    static  BeyondDynamicBone.Define.Result PreBuild_InvalidPreBuildData  // 0x0
  public    static  BeyondDynamicBone.Define.Result PreBuild_InvalidRenderSetupData  // 0x0
  public    static  BeyondDynamicBone.Define.Result PreBuild_SetupDeserializationError  // 0x0
  public    static  BeyondDynamicBone.Define.Result Deserialization_UnknownError  // 0x0
  public    static  BeyondDynamicBone.Define.Result Deserialization_Exception  // 0x0
METHODS:
END_CLASS

CLASS: System
TYPE:  class
TOKEN: 0x20000C2
FIELDS:
  public    static  System.Int32                    LatestPreBuildVersion  // 0x0
  public    static  System.Single                   Epsilon  // 0x0
  public    static  System.Int32                    MaxRendererCount  // 0x0
  public    static  System.Single                   MinimumGridSize  // 0x0
  public    static  System.Int32                    MaximumTeamCount  // 0x0
  public    static  System.Int32                    DefaultSimulationFrequency  // 0x0
  public    static  System.Int32                    SimulationFrequency_Low  // 0x0
  public    static  System.Int32                    SimulationFrequency_Hi  // 0x0
  public    static  System.Int32                    DefaultMaxSimulationCountPerFrame  // 0x0
  public    static  System.Int32                    MaxSimulationCountPerFrame_Low  // 0x0
  public    static  System.Int32                    MaxSimulationCountPerFrame_Hi  // 0x0
  public    static  System.Single                   SameSurfaceAngle  // 0x0
  public    static  System.Single                   MaxDistanceRatioFutuerPrediction  // 0x0
  public    static  System.Boolean                  ReductionEnable  // 0x0
  public    static  System.Single                   ReductionSameDistance  // 0x0
  public    static  System.Boolean                  ReductionDontMakeLine  // 0x0
  public    static  System.Single                   ReductionJoinPositionAdjustment  // 0x0
  public    static  System.Int32                    ReductionMaxStep  // 0x0
  public    static  System.Int32                    MaxProxyMeshVertexCount  // 0x0
  public    static  System.Int32                    MaxProxyMeshEdgeCount  // 0x0
  public    static  System.Int32                    MaxProxyMeshTriangleCount  // 0x0
  public    static  System.Single                   ProxyMeshTrianglePairAngle  // 0x0
  public    static  System.Single                   ProxyMeshBoneClothTriangleAngle  // 0x0
  public    static  System.Single                   FrictionMass  // 0x0
  public    static  System.Single                   DepthMass  // 0x0
  public    static  System.Single                   FrictionDampingRate  // 0x0
  public    static  System.Single                   PositionAverageExponent  // 0x0
  public    static  System.Single                   MaxRealVelocity  // 0x0
  public    static  System.Single                   TetherCompressionStiffness  // 0x0
  public    static  System.Single                   TetherStretchStiffness  // 0x0
  public    static  System.Single                   TetherStretchLimit  // 0x0
  public    static  System.Single                   TetherStiffnessWidth  // 0x0
  public    static  System.Single                   TetherCompressionVelocityAttenuation  // 0x0
  public    static  System.Single                   TetherStretchVelocityAttenuation  // 0x0
  public    static  System.Single                   DistanceVelocityAttenuation  // 0x0
  public    static  System.Single                   DistanceVerticalStiffness  // 0x0
  public    static  System.Single                   DistanceHorizontalStiffness  // 0x0
  public    static  System.Single                   TriangleBendingMaxAngle  // 0x0
  public    static  System.Single                   VolumeMinAngle  // 0x0
  public    static  System.Single                   MaxAngleLimit  // 0x0
  public    static  System.Int32                    AngleLimitIteration  // 0x0
  public    static  System.Single                   AngleLimitAttenuation  // 0x0
  public    static  System.Single                   MaxMovementSpeedLimit  // 0x0
  public    static  System.Single                   MaxRotationSpeedLimit  // 0x0
  public    static  System.Single                   MaxParticleSpeedLimit  // 0x0
  public    static  System.Int32                    ExpandedColliderCount  // 0x0
  public    static  System.Single                   ColliderCollisionDynamicFrictionRatio  // 0x0
  public    static  System.Single                   ColliderCollisionStaticFrictionRatio  // 0x0
  public    static  System.Single                   CustomSkinningAngularAttenuation  // 0x0
  public    static  System.Single                   CustomSkinningDistanceReduction  // 0x0
  public    static  System.Single                   CustomSkinningDistancePow  // 0x0
  public    static  System.Int32                    SelfCollisionSolverIteration  // 0x0
  public    static  System.Single                   SelfCollisionFixedMass  // 0x0
  public    static  System.Single                   SelfCollisionFrictionMass  // 0x0
  public    static  System.Single                   SelfCollisionClothMass  // 0x0
  public    static  System.Single                   SelfCollisionSCR  // 0x0
  public    static readonly System.Single                   SelfCollisionPointTriangleAngleCos  // 0x0
  public    static  System.Int32                    SelfCollisionIntersectDiv  // 0x0
  public    static  System.Single                   SelfCollisionThicknessMin  // 0x0
  public    static  System.Single                   SelfCollisionThicknessMax  // 0x0
  public    static  System.Single                   WindMaxTime  // 0x0
  public    static  System.Single                   WindBaseSpeed  // 0x0
  public    static  System.Single                   BoneSpringDistanceStiffness  // 0x0
  public    static  System.Single                   BoneSpringTetherCompressionLimit  // 0x0
  public    static  System.Single                   BoneSpringCollisionFriction  // 0x0
  public    static  System.Single                   DistanceCullingMaxLength  // 0x0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: ShareDeserializationData
TYPE:  class
TOKEN: 0x20000C9
FIELDS:
  private           System.String                   buildId  // 0x10
  private           BeyondDynamicBone.ResultCode    result  // 0x18
  private           System.Int32                    referenceCount  // 0x20
  private           System.Collections.Generic.List<BeyondDynamicBone.RenderSetupData>renderSetupDataList  // 0x28
  private           BeyondDynamicBone.VirtualMesh   proxyMesh  // 0x30
  private           System.Collections.Generic.List<BeyondDynamicBone.VirtualMesh>renderMeshList  // 0x38
  private           BeyondDynamicBone.DistanceConstraint.ConstraintDatadistanceConstraintData  // 0x40
  private           BeyondDynamicBone.TriangleBendingConstraint.ConstraintDatabendingConstraintData  // 0x48
  private           BeyondDynamicBone.InertiaConstraint.ConstraintDatainertiaConstraintData  // 0x50
METHODS:
  System.Void Dispose()
  System.Void Deserialize(BeyondDynamicBone.SharePreBuildData sharePreBuilddata)
  System.Int32 get_RenderMeshCount()
  BeyondDynamicBone.VirtualMeshContainer GetProxyMeshContainer()
  BeyondDynamicBone.VirtualMeshContainer GetRenderMeshContainer(System.Int32 index)
  System.Void .ctor()
END_CLASS

CLASS: WriteAnimatorBufferDataKernel_0000025C$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000D1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: WriteAnimatorBufferDataKernel_0000025C$BurstDirectCall
TYPE:  class
TOKEN: 0x20000D2
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index)
END_CLASS

CLASS: WriteAnimatorBufferDataRangeKernel_0000025D$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000D3
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: WriteAnimatorBufferDataRangeKernel_0000025D$BurstDirectCall
TYPE:  class
TOKEN: 0x20000D4
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length)
END_CLASS

CLASS: WriteAnimatorBufferDataJobKernels
TYPE:  class
TOKEN: 0x20000D0
FIELDS:
METHODS:
  System.Void WriteAnimatorBufferDataKernel(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index)
  System.Void WriteAnimatorBufferDataRangeKernel(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length)
  System.Void WriteAnimatorBufferDataKernel$BurstManaged(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index)
  System.Void WriteAnimatorBufferDataRangeKernel$BurstManaged(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* positionArray, Unity.Mathematics.quaternion* rotationArray, Unity.Mathematics.float3* localPositionArray, Unity.Mathematics.quaternion* localRotationArray, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* teamId2AnimatorInstanceIdPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>* animatorID2RWHandlerPtr, Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Int32>* transformID2RWHandlerIDPtr, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length)
END_CLASS

CLASS: ReadAnimatorBufferDataJob
TYPE:  struct
TOKEN: 0x20000D5
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>flagList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positionArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotationArray  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>scaleList  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositionArray  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>localRotationArray  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float4x4>localToWorldMatrixArray  // 0x70
  public            Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>teamId2AnimatorInstanceId  // 0x80
  public            Unity.Collections.NativeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>animatorID2RWHandler  // 0x90
  public            Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>transformID2RWHandlerID  // 0xA0
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0xB0
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0xC0
METHODS:
  System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
  System.Void _Do(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
END_CLASS

CLASS: WriteAnimatorBufferDataJob
TYPE:  struct
TOKEN: 0x20000D6
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>flagList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positionArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotationArray  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositionArray  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>localRotationArray  // 0x50
  public            Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>teamId2AnimatorInstanceId  // 0x60
  public            Unity.Collections.NativeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>animatorID2RWHandler  // 0x70
  public            Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>transformID2RWHandlerID  // 0x80
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x90
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0xA0
METHODS:
  System.Void Execute()
  System.Void UnsafeDo()
END_CLASS

CLASS: CopyDoubleBufferJob
TYPE:  struct
TOKEN: 0x20000D7
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>worldPositions  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>worldRotations  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>localRotations  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>lastworldPositions  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>lastworldRotations  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>lastlocalPositions  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>lastlocalRotations  // 0x80
METHODS:
  System.Void Execute()
END_CLASS

CLASS: EnableTransformJob
TYPE:  struct
TOKEN: 0x20000D8
FIELDS:
  public            BeyondDynamicBone.DataChunk     chunk  // 0x10
  public            System.Boolean                  sw  // 0x18
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>flagList  // 0x20
METHODS:
  System.Void Execute()
END_CLASS

CLASS: RestoreTransformJob
TYPE:  struct
TOKEN: 0x20000D9
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>flagList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositionArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>localRotationArray  // 0x30
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x40
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x50
METHODS:
  System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
END_CLASS

CLASS: ReadTransformJob
TYPE:  struct
TOKEN: 0x20000DA
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>flagList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positionArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotationArray  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>scaleList  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositionArray  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>localRotationArray  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float4x4>localToWorldMatrixArray  // 0x70
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x80
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x90
METHODS:
  System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
END_CLASS

CLASS: ValidateTransformKernel_00000266$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000DC
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: ValidateTransformKernel_00000266$BurstDirectCall
TYPE:  class
TOKEN: 0x20000DD
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index)
END_CLASS

CLASS: ValidateTransformRangeKernel_00000267$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000DE
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: ValidateTransformRangeKernel_00000267$BurstDirectCall
TYPE:  class
TOKEN: 0x20000DF
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length)
END_CLASS

CLASS: ValidTransformKernels
TYPE:  class
TOKEN: 0x20000DB
FIELDS:
METHODS:
  System.Void ValidateTransformKernel(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index)
  System.Void ValidateTransformRangeKernel(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length)
  System.Void ValidateTransformKernel$BurstManaged(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index)
  System.Void ValidateTransformRangeKernel$BurstManaged(BeyondDynamicBone.ExBitFlag8* flagList, Unity.Mathematics.float3* worldPositions, Unity.Mathematics.float3* localPositions, System.Int16* teamIdArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length)
END_CLASS

CLASS: ValidTransformJob
TYPE:  struct
TOKEN: 0x20000E0
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>flagList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>worldPositions  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x30
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x40
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x50
  public            System.Int32                    count  // 0x60
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void UnsafeDo()
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: WriteTransformJob
TYPE:  struct
TOKEN: 0x20000E1
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>flagList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>lastpositionArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>lastrotationArray  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>lastlocalPositionArray  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>lastlocalRotationArray  // 0x50
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x60
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x70
METHODS:
  System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
END_CLASS

CLASS: ReadComponentTransformJob
TYPE:  struct
TOKEN: 0x20000E2
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positionArray  // 0x10
METHODS:
  System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
END_CLASS

CLASS: SimulationStepTeamUpdateKernel_00000294$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000E5
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 teamId)
  System.IAsyncResult BeginInvoke(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 teamId, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: SimulationStepTeamUpdateKernel_00000294$BurstDirectCall
TYPE:  class
TOKEN: 0x20000E6
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 teamId)
END_CLASS

CLASS: SimulationStepTeamUpdateRangeKernel_00000295$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000E7
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 length)
  System.IAsyncResult BeginInvoke(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: SimulationStepTeamUpdateRangeKernel_00000295$BurstDirectCall
TYPE:  class
TOKEN: 0x20000E8
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 length)
END_CLASS

CLASS: UpdateWind_00000296$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000E9
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, BeyondDynamicBone.TeamWindData* teamWindArray, System.Single simulationDeltaTime)
  System.IAsyncResult BeginInvoke(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, BeyondDynamicBone.TeamWindData* teamWindArray, System.Single simulationDeltaTime, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: UpdateWind_00000296$BurstDirectCall
TYPE:  class
TOKEN: 0x20000EA
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, BeyondDynamicBone.TeamWindData* teamWindArray, System.Single simulationDeltaTime)
END_CLASS

CLASS: UpdateWindTime_00000297$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000EB
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.TeamWindInfo& windInfo, System.Single frequency, System.Single simulationDeltaTime)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamWindInfo& windInfo, System.Single frequency, System.Single simulationDeltaTime, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: UpdateWindTime_00000297$BurstDirectCall
TYPE:  class
TOKEN: 0x20000EC
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.TeamWindInfo& windInfo, System.Single frequency, System.Single simulationDeltaTime)
END_CLASS

CLASS: SimulationStepTeamUpdateKernels
TYPE:  class
TOKEN: 0x20000E4
FIELDS:
METHODS:
  System.Void SimulationStepTeamUpdateKernel(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 teamId)
  System.Void SimulationStepTeamUpdateRangeKernel(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 length)
  System.Void UpdateWind(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, BeyondDynamicBone.TeamWindData* teamWindArray, System.Single simulationDeltaTime)
  System.Void UpdateWindTime(BeyondDynamicBone.TeamWindInfo& windInfo, System.Single frequency, System.Single simulationDeltaTime)
  System.Void SimulationStepTeamUpdateKernel$BurstManaged(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 teamId)
  System.Void SimulationStepTeamUpdateRangeKernel$BurstManaged(System.Int32 updateIndex, System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 length)
  System.Void UpdateWind$BurstManaged(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, BeyondDynamicBone.TeamWindData* teamWindArray, System.Single simulationDeltaTime)
  System.Void UpdateWindTime$BurstManaged(BeyondDynamicBone.TeamWindInfo& windInfo, System.Single frequency, System.Single simulationDeltaTime)
END_CLASS

CLASS: PostTeamUpdateKernel_00000298$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000EE
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 teamId)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 teamId, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: PostTeamUpdateKernel_00000298$BurstDirectCall
TYPE:  class
TOKEN: 0x20000EF
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 teamId)
END_CLASS

CLASS: PostTeamUpdateRangeKernel_00000299$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000F0
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: PostTeamUpdateRangeKernel_00000299$BurstDirectCall
TYPE:  class
TOKEN: 0x20000F1
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length)
END_CLASS

CLASS: PostTeamUpdateJobKernels
TYPE:  class
TOKEN: 0x20000ED
FIELDS:
METHODS:
  System.Void PostTeamUpdateKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 teamId)
  System.Void PostTeamUpdateRangeKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length)
  System.Void PostTeamUpdateKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 teamId)
  System.Void PostTeamUpdateRangeKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length)
END_CLASS

CLASS: TeamData
TYPE:  struct
TOKEN: 0x20000F2
FIELDS:
  public            Unity.Collections.BitField64    flag  // 0x10
  public            BeyondDynamicBone.ClothUpdateModeoriginalUpdateMode  // 0x18
  public            BeyondDynamicBone.ClothUpdateModeupdateMode  // 0x1C
  public            System.Single                   frameDeltaTime  // 0x20
  public            System.Single                   time  // 0x24
  public            System.Single                   oldTime  // 0x28
  public            System.Single                   nowUpdateTime  // 0x2C
  public            System.Single                   oldUpdateTime  // 0x30
  public            System.Single                   frameUpdateTime  // 0x34
  public            System.Single                   frameOldTime  // 0x38
  public            System.Single                   timeScale  // 0x3C
  public            System.Single                   nowTimeScale  // 0x40
  public            System.Int32                    updateCount  // 0x44
  public            System.Int32                    skipCount  // 0x48
  public            System.Single                   frameInterpolation  // 0x4C
  public            System.Single                   gravityRatio  // 0x50
  public            System.Single                   gravityDot  // 0x54
  public            System.Int32                    centerTransformIndex  // 0x58
  public            System.Int32                    distanceReferenceObjectId  // 0x5C
  public            System.Int32                    componentTransformIndex  // 0x60
  public            Unity.Mathematics.float3        initScale  // 0x64
  public            System.Single                   scaleRatio  // 0x70
  public            System.Single                   negativeScaleSign  // 0x74
  public            Unity.Mathematics.float3        negativeScaleDirection  // 0x78
  public            Unity.Mathematics.float3        negativeScaleChange  // 0x84
  public            Unity.Mathematics.float2        negativeScaleTriangleSign  // 0x90
  public            Unity.Mathematics.float4        negativeScaleQuaternionValue  // 0x98
  public            System.Int32                    componentId  // 0xA8
  public            System.Int32                    useRelativeTransform  // 0xAC
  public            Unity.Mathematics.float3        relativeTransformPos  // 0xB0
  public            Unity.Mathematics.quaternion    relativeTransformRot  // 0xBC
  public            System.Int32                    syncTeamId  // 0xCC
  public            Unity.Collections.FixedList32Bytes<System.Int32>syncParentTeamId  // 0xD0
  public            System.Int32                    syncCenterTransformIndex  // 0xF0
  public            System.Int32                    interlockingAnimatorId  // 0xF4
  public            System.Single                   animationPoseRatio  // 0xF8
  public            System.Single                   clothSimulateWeight  // 0xFC
  public            System.Single                   clothLodFadeWeight  // 0x100
  public            System.Single                   clothLodFadeTime  // 0x104
  public            System.Single                   velocityWeight  // 0x108
  public            System.Single                   distanceWeight  // 0x10C
  public            System.Single                   blendWeight  // 0x110
  public            BeyondDynamicBone.ClothForceModeforceMode  // 0x114
  public            Unity.Mathematics.float3        impactForce  // 0x118
  public            BeyondDynamicBone.VirtualMesh.MeshTypeproxyMeshType  // 0x124
  public            BeyondDynamicBone.DataChunk     proxyTransformChunk  // 0x128
  public            BeyondDynamicBone.DataChunk     proxyCommonChunk  // 0x130
  public            BeyondDynamicBone.DataChunk     proxyVertexChildDataChunk  // 0x138
  public            BeyondDynamicBone.DataChunk     proxyTriangleChunk  // 0x140
  public            BeyondDynamicBone.DataChunk     proxyEdgeChunk  // 0x148
  public            BeyondDynamicBone.DataChunk     proxyMeshChunk  // 0x150
  public            BeyondDynamicBone.DataChunk     proxyBoneChunk  // 0x158
  public            BeyondDynamicBone.DataChunk     proxySkinBoneChunk  // 0x160
  public            BeyondDynamicBone.DataChunk     baseLineChunk  // 0x168
  public            BeyondDynamicBone.DataChunk     baseLineDataChunk  // 0x170
  public            BeyondDynamicBone.DataChunk     fixedDataChunk  // 0x178
  public            BeyondDynamicBone.DataChunk     particleChunk  // 0x180
  public            BeyondDynamicBone.DataChunk     colliderChunk  // 0x188
  public            BeyondDynamicBone.DataChunk     colliderTransformChunk  // 0x190
  public            System.Int32                    colliderCount  // 0x198
  public            BeyondDynamicBone.DataChunk     distanceStartChunk  // 0x19C
  public            BeyondDynamicBone.DataChunk     distanceDataChunk  // 0x1A4
  public            BeyondDynamicBone.DataChunk     bendingPairChunk  // 0x1AC
  public            BeyondDynamicBone.DataChunk     bendingWriteIndexChunk  // 0x1B4
  public            BeyondDynamicBone.DataChunk     bendingBufferChunk  // 0x1BC
  public            BeyondDynamicBone.DataChunk     selfPointChunk  // 0x1C4
  public            BeyondDynamicBone.DataChunk     selfEdgeChunk  // 0x1CC
  public            BeyondDynamicBone.DataChunk     selfTriangleChunk  // 0x1D4
METHODS:
  System.Boolean get_bUseRelativeTransform()
  System.Boolean get_IsFixedUpdate()
  System.Boolean get_IsUnscaled()
  System.Boolean get_IsValid()
  System.Boolean get_IsEnable()
  System.Boolean get_IsLODCulled()
  System.Boolean get_IsProcess()
  System.Boolean get_IsReset()
  System.Boolean get_IsKeepReset()
  System.Boolean get_IsInertiaShift()
  System.Boolean get_IsRunning()
  System.Boolean get_IsStepRunning()
  System.Boolean get_IsCameraCullingInvisible()
  System.Boolean get_IsCameraCullingKeep()
  System.Boolean get_IsDistanceCullingInvisible()
  System.Boolean get_IsCullingInvisible()
  System.Boolean get_IsSpring()
  System.Boolean get_IsNegativeScale()
  System.Boolean get_IsNegativeScaleTeleport()
  System.Boolean get_IsTangent()
  System.Int32 get_ParticleCount()
  System.Int32 get_ColliderCount()
  System.Int32 get_BaseLineCount()
  System.Int32 get_TriangleCount()
  System.Int32 get_EdgeCount()
  System.Single get_InitScale()
END_CLASS

CLASS: MappingData
TYPE:  struct
TOKEN: 0x20000F3
FIELDS:
  public            System.Int32                    teamId  // 0x10
  public            System.Int32                    centerTransformIndex  // 0x14
  public            BeyondDynamicBone.DataChunk     mappingCommonChunk  // 0x18
  public            Unity.Mathematics.float4x4      toProxyMatrix  // 0x20
  public            Unity.Mathematics.quaternion    toProxyRotation  // 0x60
  public            System.Boolean                  sameSpace  // 0x70
  public            Unity.Mathematics.float4x4      toMappingMatrix  // 0x74
  public            Unity.Mathematics.quaternion    toMappingRotation  // 0xB4
  public            System.Single                   scaleRatio  // 0xC4
METHODS:
  System.Boolean IsValid()
  System.Int32 get_VertexCount()
END_CLASS

CLASS: AlwaysTeamUpdatePreJob
TYPE:  struct
TOKEN: 0x20000F4
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x20
  public            Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>comp2SuspendCounterMap  // 0x30
  public            Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>comp2TeamIdMap  // 0x40
  public            Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>comp2SyncPartnerCompMap  // 0x50
  public            Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>comp2SyncTopCompMap  // 0x60
  public            Unity.Collections.NativeParallelHashSet<System.Int32>selfCollisionUpdateSet  // 0x70
  public            Unity.Collections.NativeReference<System.Int32>edgeColliderCollisionCountBuff  // 0x80
METHODS:
  System.Void Execute()
END_CLASS

CLASS: AlwaysTeamUpdatePostJob
TYPE:  struct
TOKEN: 0x20000F5
FIELDS:
  public            System.Int32                    teamCount  // 0x10
  public            System.Single                   unityFrameDeltaTime  // 0x14
  public            System.Single                   unityFrameFixedDeltaTime  // 0x18
  public            System.Single                   unityFrameUnscaledDeltaTime  // 0x1C
  public            System.Single                   globalTimeScale  // 0x20
  public            System.Single                   simulationDeltaTime  // 0x24
  public            System.Int32                    maxSimmulationCountPerFrame  // 0x28
  public            Unity.Collections.NativeReference<System.Int32>maxUpdateCount  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x40
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x50
  public            Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData>centerDataArray  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>componentPositionArray  // 0x70
  public            System.Boolean                  hasMainCamera  // 0x80
  public            Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>comp2TeamIdMap  // 0x88
  public            Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>comp2SyncTopCompMap  // 0x98
  public            Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>animatorUpdateModeMap  // 0xA8
  public            Unity.Collections.NativeArray<System.Int32>teamAnchorTransformIndexArray  // 0xB8
  public            Unity.Collections.NativeArray<System.Int32>teamDistanceTransformIndexArray  // 0xC8
  public            Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Mathematics.float3>transformPositionMap  // 0xD8
  public            Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Mathematics.quaternion>transformRotationMap  // 0xE8
  public            Unity.Collections.NativeList<System.Int32>cullingDirtyList  // 0xF8
METHODS:
  System.Void Execute()
  System.Void DistanceCullingUpdate(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata)
END_CLASS

CLASS: CalcCenterAndInertiaAndWindKernel_000002B9$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000F7
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 teamId)
  System.IAsyncResult BeginInvoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 teamId, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcCenterAndInertiaAndWindKernel_000002B9$BurstDirectCall
TYPE:  class
TOKEN: 0x20000F8
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 teamId)
END_CLASS

CLASS: CalcCenterAndInertiaAndWindRangeKernel_000002BA$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000F9
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 length)
  System.IAsyncResult BeginInvoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcCenterAndInertiaAndWindRangeKernel_000002BA$BurstDirectCall
TYPE:  class
TOKEN: 0x20000FA
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 length)
END_CLASS

CLASS: Wind_000002BB$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20000FB
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32 teamId, BeyondDynamicBone.ClothParameters* param, Unity.Mathematics.float3* centerWorldPos, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray)
  System.IAsyncResult BeginInvoke(System.Int32 teamId, BeyondDynamicBone.ClothParameters* param, Unity.Mathematics.float3* centerWorldPos, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Wind_000002BB$BurstDirectCall
TYPE:  class
TOKEN: 0x20000FC
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32 teamId, BeyondDynamicBone.ClothParameters* param, Unity.Mathematics.float3* centerWorldPos, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray)
END_CLASS

CLASS: CalcCenterAndInertiaAndWindKernels
TYPE:  class
TOKEN: 0x20000F6
FIELDS:
METHODS:
  System.Void CalcCenterAndInertiaAndWindKernel(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 teamId)
  System.Void CalcCenterAndInertiaAndWindRangeKernel(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 length)
  System.Void Wind(System.Int32 teamId, BeyondDynamicBone.ClothParameters* param, Unity.Mathematics.float3* centerWorldPos, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray)
  System.Void CalcCenterAndInertiaAndWindKernel$BurstManaged(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 teamId)
  System.Void CalcCenterAndInertiaAndWindRangeKernel$BurstManaged(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.ClothParameters* parameterArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexBindPoseRotations, System.UInt16* fixedArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32 length)
  System.Void Wind$BurstManaged(System.Int32 teamId, BeyondDynamicBone.ClothParameters* param, Unity.Mathematics.float3* centerWorldPos, BeyondDynamicBone.TeamWindData* teamWindArray, System.Int32 windZoneCount, BeyondDynamicBone.WindManager.WindData* windDataArray)
END_CLASS

CLASS: CalcCenterAndInertiaAndWindJob
TYPE:  struct
TOKEN: 0x20000FD
FIELDS:
  public            System.Single                   simulationDeltaTime  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x18
  public            Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData>centerDataArray  // 0x28
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamWindData>teamWindArray  // 0x38
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positions  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotations  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>vertexBindPoseRotations  // 0x78
  public            Unity.Collections.NativeArray<System.UInt16>fixedArray  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformPositionArray  // 0x98
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformRotationArray  // 0xA8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformScaleArray  // 0xB8
  public            System.Int32                    windZoneCount  // 0xC8
  public            Unity.Collections.NativeArray<BeyondDynamicBone.WindManager.WindData>windDataArray  // 0xD0
  public            System.Int32                    _indexCount  // 0xE0
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 teamId)
  System.Void Wind(System.Int32 teamId, BeyondDynamicBone.ClothParameters& param, Unity.Mathematics.float3& centerWorldPos)
  System.Void UnsafeDo()
END_CLASS

CLASS: SimulationStepTeamUpdateJob
TYPE:  struct
TOKEN: 0x20000FE
FIELDS:
  public            System.Int32                    updateIndex  // 0x10
  public            System.Single                   simulationDeltaTime  // 0x14
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x18
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x28
  public            Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData>centerDataArray  // 0x38
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamWindData>teamWindArray  // 0x48
  public            System.Int32                    _indexCount  // 0x58
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 teamId)
  System.Void UpdateWind(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata)
  System.Void UpdateWindTime(BeyondDynamicBone.TeamWindInfo& windInfo, System.Single frequency, System.Single simulationDeltaTime)
  System.Void UnsafeDo()
END_CLASS

CLASS: PostTeamUpdateJob
TYPE:  struct
TOKEN: 0x20000FF
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData>centerDataArray  // 0x20
  public            System.Int32                    _indexCount  // 0x30
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 teamId)
  System.Void UnsafeDo()
END_CLASS

CLASS: CalcProxyMeshSkinningKernel_000002E4$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000103
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcProxyMeshSkinningKernel_000002E4$BurstDirectCall
TYPE:  class
TOKEN: 0x2000104
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32 index)
END_CLASS

CLASS: CalcProxyMeshSkinningRangeKernel_000002E5$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000105
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcProxyMeshSkinningRangeKernel_000002E5$BurstDirectCall
TYPE:  class
TOKEN: 0x2000106
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32* lengthPtr)
END_CLASS

CLASS: CalcProxyMeshSkinningKernels
TYPE:  class
TOKEN: 0x2000102
FIELDS:
METHODS:
  System.Void CalcProxyMeshSkinningKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32 index)
  System.Void CalcProxyMeshSkinningRangeKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32* lengthPtr)
  System.Void CalcProxyMeshSkinningKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32 index)
  System.Void CalcProxyMeshSkinningRangeKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* localPositions, Unity.Mathematics.float3* localNormals, Unity.Mathematics.float3* localTangents, BeyondDynamicBone.VirtualMeshBoneWeight* boneWeights, System.Int32* skinBoneTransformIndices, Unity.Mathematics.float4x4* skinBoneBindPoses, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float4x4* transformLocalToWorldMatrixArray, System.Int32* lengthPtr)
END_CLASS

CLASS: CreatePostProxyMeshUpdateListKernel_000002E6$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000108
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 teamId)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 teamId, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CreatePostProxyMeshUpdateListKernel_000002E6$BurstDirectCall
TYPE:  class
TOKEN: 0x2000109
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 teamId)
END_CLASS

CLASS: CreatePostProxyMeshUpdateListRangeKernel_000002E7$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200010A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 length)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CreatePostProxyMeshUpdateListRangeKernel_000002E7$BurstDirectCall
TYPE:  class
TOKEN: 0x200010B
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 length)
END_CLASS

CLASS: CreatePostProxyMeshUpdateListJobKernels
TYPE:  class
TOKEN: 0x2000107
FIELDS:
METHODS:
  System.Void CreatePostProxyMeshUpdateListKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 teamId)
  System.Void CreatePostProxyMeshUpdateListRangeKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 length)
  System.Void CreatePostProxyMeshUpdateListKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 teamId)
  System.Void CreatePostProxyMeshUpdateListRangeKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter0, System.Int32* processingList0, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32* processingCounter2, System.Int32* processingList2, System.Int32* processingCounter3, System.Int32* processingList3, System.Int32 length)
END_CLASS

CLASS: CalcLineNormalTangentKernel_000002E8$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200010D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcLineNormalTangentKernel_000002E8$BurstDirectCall
TYPE:  class
TOKEN: 0x200010E
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32 index)
END_CLASS

CLASS: CalcLineNormalTangentRangeKernel_000002E9$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200010F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcLineNormalTangentRangeKernel_000002E9$BurstDirectCall
TYPE:  class
TOKEN: 0x2000110
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32* lengthPtr)
END_CLASS

CLASS: CalcLineNormalTangentJobKernels
TYPE:  class
TOKEN: 0x200010C
FIELDS:
METHODS:
  System.Void CalcLineNormalTangentKernel(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32 index)
  System.Void CalcLineNormalTangentRangeKernel(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32* lengthPtr)
  System.Void CalcLineNormalTangentKernel$BurstManaged(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32 index)
  System.Void CalcLineNormalTangentRangeKernel$BurstManaged(System.Int32* jobBaseLineList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.Int32* parentIndices, System.UInt32* childIndexArray, System.UInt16* childDataArray, BeyondDynamicBone.ExBitFlag8* baseLineFlags, System.Int16* baseLineTeamIds, System.UInt16* baseLineStartIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, System.Int32* lengthPtr)
END_CLASS

CLASS: WriteTransformDataKernel_000002EA$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000112
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: WriteTransformDataKernel_000002EA$BurstDirectCall
TYPE:  class
TOKEN: 0x2000113
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32 index)
END_CLASS

CLASS: WriteTransformDataRangeKernel_000002EB$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000114
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: WriteTransformDataRangeKernel_000002EB$BurstDirectCall
TYPE:  class
TOKEN: 0x2000115
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32* lengthPtr)
END_CLASS

CLASS: WriteTransformDataJobKernels
TYPE:  class
TOKEN: 0x2000111
FIELDS:
METHODS:
  System.Void WriteTransformDataKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32 index)
  System.Void WriteTransformDataRangeKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32* lengthPtr)
  System.Void WriteTransformDataKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32 index)
  System.Void WriteTransformDataRangeKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, System.Int16* teamIds, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, Unity.Mathematics.quaternion* vertexToTransformRotations, System.Int32* lengthPtr)
END_CLASS

CLASS: WriteTransformLocalDataKernel_000002EC$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000117
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: WriteTransformLocalDataKernel_000002EC$BurstDirectCall
TYPE:  class
TOKEN: 0x2000118
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32 index)
END_CLASS

CLASS: WriteTransformLocalDataRangeKernel_000002ED$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000119
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: WriteTransformLocalDataRangeKernel_000002ED$BurstDirectCall
TYPE:  class
TOKEN: 0x200011A
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32* lengthPtr)
END_CLASS

CLASS: WriteTransformLocalDataJobKernels
TYPE:  class
TOKEN: 0x2000116
FIELDS:
METHODS:
  System.Void WriteTransformLocalDataKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32 index)
  System.Void WriteTransformLocalDataRangeKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32* lengthPtr)
  System.Void WriteTransformLocalDataKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32 index)
  System.Void WriteTransformLocalDataRangeKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, Unity.Mathematics.float3* transformLocalPositionArray, Unity.Mathematics.quaternion* transformLocalRotationArray, System.Int32* lengthPtr)
END_CLASS

CLASS: CalcProxySkinningKernel_000002EE$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200011C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 mvindex)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 mvindex, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcProxySkinningKernel_000002EE$BurstDirectCall
TYPE:  class
TOKEN: 0x200011D
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 mvindex)
END_CLASS

CLASS: CalcProxySkinningRangeKernel_000002EF$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200011E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 length)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcProxySkinningRangeKernel_000002EF$BurstDirectCall
TYPE:  class
TOKEN: 0x200011F
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 length)
END_CLASS

CLASS: CalcProxySkinningJobKernels
TYPE:  class
TOKEN: 0x200011B
FIELDS:
METHODS:
  System.Void CalcProxySkinningKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 mvindex)
  System.Void CalcProxySkinningRangeKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 length)
  System.Void CalcProxySkinningKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 mvindex)
  System.Void CalcProxySkinningRangeKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, System.Int16* mappingIdArray, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingLocalPositions, Unity.Mathematics.float3* mappingLocalNormals, Unity.Mathematics.float3* mappingLocalTangents, BeyondDynamicBone.VirtualMeshBoneWeight* mappingBoneWeights, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, Unity.Mathematics.float3* proxyPositions, Unity.Mathematics.quaternion* proxyRotations, Unity.Mathematics.float3* proxyVertexBindPosePositions, Unity.Mathematics.quaternion* proxyVertexBindPoseRotations, System.Int32 length)
END_CLASS

CLASS: CalcMeshConvertMatrixKernel_000002F0$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000121
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcMeshConvertMatrixKernel_000002F0$BurstDirectCall
TYPE:  class
TOKEN: 0x2000122
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 index)
END_CLASS

CLASS: CalcMeshConvertMatrixRangeKernel_000002F1$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000123
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 length)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcMeshConvertMatrixRangeKernel_000002F1$BurstDirectCall
TYPE:  class
TOKEN: 0x2000124
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 length)
END_CLASS

CLASS: CalcMeshConvertMatrixJobKernels
TYPE:  class
TOKEN: 0x2000120
FIELDS:
METHODS:
  System.Void CalcMeshConvertMatrixKernel(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 index)
  System.Void CalcMeshConvertMatrixRangeKernel(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 length)
  System.Void CalcMeshConvertMatrixKernel$BurstManaged(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 index)
  System.Void CalcMeshConvertMatrixRangeKernel$BurstManaged(BeyondDynamicBone.TeamManager.MappingData* mappingDataArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, System.Int32 length)
END_CLASS

CLASS: CalcTriangleNormalTangentKernel_000002F2$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000126
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcTriangleNormalTangentKernel_000002F2$BurstDirectCall
TYPE:  class
TOKEN: 0x2000127
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32 index)
END_CLASS

CLASS: CalcTriangleNormalTangentRangeKernel_000002F3$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000128
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcTriangleNormalTangentRangeKernel_000002F3$BurstDirectCall
TYPE:  class
TOKEN: 0x2000129
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32* lengthPtr)
END_CLASS

CLASS: CalcTriangleNormalTangentJobKernels
TYPE:  class
TOKEN: 0x2000125
FIELDS:
METHODS:
  System.Void CalcTriangleNormalTangentKernel(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32 index)
  System.Void CalcTriangleNormalTangentRangeKernel(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32* lengthPtr)
  System.Void CalcTriangleNormalTangentKernel$BurstManaged(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32 index)
  System.Void CalcTriangleNormalTangentRangeKernel$BurstManaged(System.Int32* jobTriangleList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* triangleTeamIdArray, Unity.Mathematics.int3* triangles, Unity.Mathematics.float3* outTriangleNormals, Unity.Mathematics.float3* outTriangleTangents, Unity.Mathematics.float3* positions, Unity.Mathematics.float2* uv, System.Int32* lengthPtr)
END_CLASS

CLASS: CalcVertexNormalTangentFromTriangleKernel_000002F4$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200012B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcVertexNormalTangentFromTriangleKernel_000002F4$BurstDirectCall
TYPE:  class
TOKEN: 0x200012C
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32 index)
END_CLASS

CLASS: CalcVertexNormalTangentFromTriangleRangeKernel_000002F5$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200012D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcVertexNormalTangentFromTriangleRangeKernel_000002F5$BurstDirectCall
TYPE:  class
TOKEN: 0x200012E
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32* lengthPtr)
END_CLASS

CLASS: CalcVertexNormalTangentFromTriangleJobKernels
TYPE:  class
TOKEN: 0x200012A
FIELDS:
METHODS:
  System.Void CalcVertexNormalTangentFromTriangleKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32 index)
  System.Void CalcVertexNormalTangentFromTriangleRangeKernel(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32* lengthPtr)
  System.Void CalcVertexNormalTangentFromTriangleKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32 index)
  System.Void CalcVertexNormalTangentFromTriangleRangeKernel$BurstManaged(System.Int32* jobVertexIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIds, Unity.Mathematics.float3* triangleNormals, Unity.Mathematics.float3* triangleTangents, Unity.Collections.FixedList32Bytes<System.UInt32>* vertexToTriangles, Unity.Mathematics.quaternion* normalAdjustmentRotations, Unity.Mathematics.quaternion* outRotations, System.Int32* lengthPtr)
END_CLASS

CLASS: ClearProxyMeshUpdateBufferKernel_000002F6$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000130
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* processingCounter0, System.Int32* processingCounter1, System.Int32* processingCounter2, System.Int32* processingCounter3)
  System.IAsyncResult BeginInvoke(System.Int32* processingCounter0, System.Int32* processingCounter1, System.Int32* processingCounter2, System.Int32* processingCounter3, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: ClearProxyMeshUpdateBufferKernel_000002F6$BurstDirectCall
TYPE:  class
TOKEN: 0x2000131
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* processingCounter0, System.Int32* processingCounter1, System.Int32* processingCounter2, System.Int32* processingCounter3)
END_CLASS

CLASS: ClearProxyMeshUpdateBufferJobKernels
TYPE:  class
TOKEN: 0x200012F
FIELDS:
METHODS:
  System.Void ClearProxyMeshUpdateBufferKernel(System.Int32* processingCounter0, System.Int32* processingCounter1, System.Int32* processingCounter2, System.Int32* processingCounter3)
  System.Void ClearProxyMeshUpdateBufferKernel$BurstManaged(System.Int32* processingCounter0, System.Int32* processingCounter1, System.Int32* processingCounter2, System.Int32* processingCounter3)
END_CLASS

CLASS: ClearProxyMeshUpdateBufferJob
TYPE:  struct
TOKEN: 0x2000132
FIELDS:
  public            Unity.Collections.NativeReference<System.Int32>processingCounter0  // 0x10
  public            Unity.Collections.NativeReference<System.Int32>processingCounter1  // 0x20
  public            Unity.Collections.NativeReference<System.Int32>processingCounter2  // 0x30
  public            Unity.Collections.NativeReference<System.Int32>processingCounter3  // 0x40
METHODS:
  System.Void Execute()
  System.Void UnsafeDo()
END_CLASS

CLASS: CreateProxyMeshUpdateVertexList
TYPE:  struct
TOKEN: 0x2000133
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x10
  public            Unity.Collections.NativeReference<System.Int32>processingCounter1  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>processingList1  // 0x30
  public            System.Int32                    _indexCount  // 0x40
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 teamId)
  System.Void UnsafeDo()
END_CLASS

CLASS: CalcProxyMeshSkinningJob
TYPE:  struct
TOKEN: 0x2000134
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>jobVertexIndexList  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<System.Int16>teamIds  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localNormals  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localTangents  // 0x70
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0x80
  public            Unity.Collections.NativeArray<System.Int32>skinBoneTransformIndices  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float4x4>skinBoneBindPoses  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positions  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotations  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float4x4>transformLocalToWorldMatrixArray  // 0xD0
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0xE0
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: CreatePostProxyMeshUpdateListJob
TYPE:  struct
TOKEN: 0x2000135
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x10
  public            Unity.Collections.NativeReference<System.Int32>processingCounter0  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>processingList0  // 0x30
  public            Unity.Collections.NativeReference<System.Int32>processingCounter1  // 0x40
  public            Unity.Collections.NativeArray<System.Int32>processingList1  // 0x50
  public            Unity.Collections.NativeReference<System.Int32>processingCounter2  // 0x60
  public            Unity.Collections.NativeArray<System.Int32>processingList2  // 0x70
  public            Unity.Collections.NativeReference<System.Int32>processingCounter3  // 0x80
  public            Unity.Collections.NativeArray<System.Int32>processingList3  // 0x90
  public            System.Int32                    _indexCount  // 0xA0
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 teamId)
  System.Void UnsafeDo()
END_CLASS

CLASS: CalcLineNormalTangentJob
TYPE:  struct
TOKEN: 0x2000136
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>jobBaseLineList  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positions  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotations  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>vertexLocalPositions  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>vertexLocalRotations  // 0x80
  public            Unity.Collections.NativeArray<System.Int32>parentIndices  // 0x90
  public            Unity.Collections.NativeArray<System.UInt32>childIndexArray  // 0xA0
  public            Unity.Collections.NativeArray<System.UInt16>childDataArray  // 0xB0
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>baseLineFlags  // 0xC0
  public            Unity.Collections.NativeArray<System.Int16>baseLineTeamIds  // 0xD0
  public            Unity.Collections.NativeArray<System.UInt16>baseLineStartIndices  // 0xE0
  public            Unity.Collections.NativeArray<System.UInt16>baseLineDataCounts  // 0xF0
  public            Unity.Collections.NativeArray<System.UInt16>baseLineData  // 0x100
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x110
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: CalcTriangleNormalTangentJob
TYPE:  struct
TOKEN: 0x2000137
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>jobTriangleList  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<System.Int16>triangleTeamIdArray  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>triangles  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>outTriangleNormals  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>outTriangleTangents  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positions  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float2>uv  // 0x80
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x90
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: CalcVertexNormalTangentFromTriangleJob
TYPE:  struct
TOKEN: 0x2000138
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>jobVertexIndexList  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<System.Int16>teamIds  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>triangleNormals  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>triangleTangents  // 0x50
  public            Unity.Collections.NativeArray<Unity.Collections.FixedList32Bytes<System.UInt32>>vertexToTriangles  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>normalAdjustmentRotations  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>outRotations  // 0x80
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x90
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: WriteTransformDataJob
TYPE:  struct
TOKEN: 0x2000139
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>jobVertexIndexList  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformPositionArray  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformRotationArray  // 0x40
  public            Unity.Collections.NativeArray<System.Int16>teamIds  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positions  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotations  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>vertexToTransformRotations  // 0x80
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x90
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: WriteTransformLocalDataJob
TYPE:  struct
TOKEN: 0x200013A
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>jobVertexIndexList  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<System.Int16>teamIds  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x40
  public            Unity.Collections.NativeArray<System.Int32>vertexParentIndices  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformPositionArray  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformRotationArray  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformScaleArray  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformLocalPositionArray  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformLocalRotationArray  // 0xA0
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0xB0
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: CalcMeshConvertMatrixJob
TYPE:  struct
TOKEN: 0x200013B
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.MappingData>mappingDataArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformPositionArray  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformRotationArray  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformScaleArray  // 0x50
  public            System.Int32                    _indexCount  // 0x60
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: CalcProxySkinningJob
TYPE:  struct
TOKEN: 0x200013C
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.MappingData>mappingDataArray  // 0x20
  public            Unity.Collections.NativeArray<System.Int16>mappingIdArray  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>mappingAttributes  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>mappingLocalPositions  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>mappingLocalNormals  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>mappingLocalTangents  // 0x70
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>mappingBoneWeights  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>mappingPositions  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>mappingNormals  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>mappingTangents  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>proxyPositions  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>proxyRotations  // 0xD0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>proxyVertexBindPosePositions  // 0xE0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>proxyVertexBindPoseRotations  // 0xF0
  public            System.Int32                    _indexCount  // 0x100
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 mvindex)
  System.Void UnsafeDo()
END_CLASS

CLASS: UpdateMethod
TYPE:  class
TOKEN: 0x200013F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke()
  System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: InitializationLocation
TYPE:  struct
TOKEN: 0x2000140
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.MagicaManager.InitializationLocationStart  // 0x0
  public    static  BeyondDynamicBone.MagicaManager.InitializationLocationAwake  // 0x0
METHODS:
END_CLASS

CLASS: RefreshMode
TYPE:  struct
TOKEN: 0x2000144
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.MagicaSettings.RefreshModeOnAwake  // 0x0
  public    static  BeyondDynamicBone.MagicaSettings.RefreshModeEveryFrame  // 0x0
  public    static  BeyondDynamicBone.MagicaSettings.RefreshModeOnStart  // 0x0
  public    static  BeyondDynamicBone.MagicaSettings.RefreshModeManual  // 0x0
METHODS:
END_CLASS

CLASS: UpdatePositionNormalJob
TYPE:  struct
TOKEN: 0x2000155
FIELDS:
  public            System.Int32                    startIndex  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>meshLocalPositions  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>meshLocalNormals  // 0x28
  public            Unity.Collections.NativeArray<System.Int32>mappingReferenceIndices  // 0x38
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>mappingAttributes  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>mappingPositions  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>mappingNormals  // 0x68
  public            System.Int32                    _indexCount  // 0x78
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: UpdatePositionNormalTangentJob
TYPE:  struct
TOKEN: 0x2000156
FIELDS:
  public            System.Int32                    startIndex  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>meshLocalPositions  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>meshLocalNormals  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.float4>meshLocalTangents  // 0x38
  public            Unity.Collections.NativeArray<System.Int32>mappingReferenceIndices  // 0x48
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>mappingAttributes  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>mappingPositions  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>mappingNormals  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>mappingTangents  // 0x88
  public            System.Int32                    _indexCount  // 0x98
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: UpdateBoneWeightJob2
TYPE:  struct
TOKEN: 0x2000157
FIELDS:
  public            System.Int32                    startIndex  // 0x10
  public            UnityEngine.BoneWeight          centerBoneWeight  // 0x14
  public            Unity.Collections.NativeArray<UnityEngine.BoneWeight>meshBoneWeights  // 0x38
  public            Unity.Collections.NativeArray<System.Int32>mappingReferenceIndices  // 0x48
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>mappingAttributes  // 0x58
  public            System.Int32                    _indexCount  // 0x68
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: SetupType
TYPE:  struct
TOKEN: 0x200015B
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.RenderSetupData.SetupTypeMeshCloth  // 0x0
  public    static  BeyondDynamicBone.RenderSetupData.SetupTypeBoneCloth  // 0x0
  public    static  BeyondDynamicBone.RenderSetupData.SetupTypeBoneSpring  // 0x0
METHODS:
END_CLASS

CLASS: BoneConnectionMode
TYPE:  struct
TOKEN: 0x200015C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.RenderSetupData.BoneConnectionModeLine  // 0x0
  public    static  BeyondDynamicBone.RenderSetupData.BoneConnectionModeAutomaticMesh  // 0x0
  public    static  BeyondDynamicBone.RenderSetupData.BoneConnectionModeSequentialLoopMesh  // 0x0
  public    static  BeyondDynamicBone.RenderSetupData.BoneConnectionModeSequentialNonLoopMesh  // 0x0
METHODS:
END_CLASS

CLASS: VertexWeight5BoneCheckJob
TYPE:  struct
TOKEN: 0x200015D
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            Unity.Collections.NativeArray<System.Byte>bonesPerVertexArray  // 0x18
  public            Unity.Collections.NativeReference<BeyondDynamicBone.Define.Result>result  // 0x28
METHODS:
  System.Void Execute()
END_CLASS

CLASS: ReadTransformJob
TYPE:  struct
TOKEN: 0x200015E
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positions  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotations  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>scales  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>localRotations  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>inverseRotations  // 0x60
METHODS:
  System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
END_CLASS

CLASS: GetBoneWeightJos
TYPE:  struct
TOKEN: 0x200015F
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            Unity.Collections.NativeArray<System.Byte>bonesPerVertexArray  // 0x18
  public            Unity.Collections.NativeArray<UnityEngine.BoneWeight1>boneWeightArray  // 0x28
  public            Unity.Collections.NativeArray<UnityEngine.BoneWeight>boneWeights  // 0x38
METHODS:
  System.Void Execute()
END_CLASS

CLASS: ShareSerializationData
TYPE:  class
TOKEN: 0x2000160
FIELDS:
  public            BeyondDynamicBone.ResultCode    result  // 0x10
  public            System.String                   name  // 0x18
  public            BeyondDynamicBone.RenderSetupData.SetupTypesetupType  // 0x20
  public            UnityEngine.Mesh                originalMesh  // 0x28
  public            System.Int32                    vertexCount  // 0x30
  public            System.Boolean                  hasSkinnedMesh  // 0x34
  public            System.Boolean                  hasBoneWeight  // 0x35
  public            System.Int32                    skinRootBoneIndex  // 0x38
  public            System.Int32                    skinBoneCount  // 0x3C
  public            System.Collections.Generic.List<UnityEngine.Matrix4x4>bindPoseList  // 0x40
  public            System.Byte[]                   bonesPerVertexArray  // 0x48
  public            System.Byte[]                   boneWeightArray  // 0x50
  public            UnityEngine.Vector3[]           localPositions  // 0x58
  public            UnityEngine.Vector3[]           localNormals  // 0x60
  public            UnityEngine.Vector4[]           localTangents  // 0x68
  public            BeyondDynamicBone.RenderSetupData.BoneConnectionModeboneConnectionMode  // 0x70
  public            System.Int32                    renderTransformIndex  // 0x74
METHODS:
  System.Boolean get_HasTangent()
  System.Void .ctor()
END_CLASS

CLASS: UniqueSerializationData
TYPE:  class
TOKEN: 0x2000161
FIELDS:
  public            BeyondDynamicBone.ResultCode    result  // 0x10
  public            UnityEngine.Renderer            renderer  // 0x18
  public            UnityEngine.SkinnedMeshRenderer skinRenderer  // 0x20
  public            UnityEngine.MeshFilter          meshFilter  // 0x28
  public            UnityEngine.Mesh                originalMesh  // 0x30
  public            System.Collections.Generic.List<UnityEngine.Transform>transformList  // 0x38
METHODS:
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
  System.Void .ctor()
END_CLASS

CLASS: PreSimulationUpdateKernel_000003D1$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200016A
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: PreSimulationUpdateKernel_000003D1$BurstDirectCall
TYPE:  class
TOKEN: 0x200016B
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 index)
END_CLASS

CLASS: PreSimulationUpdateRangeKernel_000003D2$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200016C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: PreSimulationUpdateRangeKernel_000003D2$BurstDirectCall
TYPE:  class
TOKEN: 0x200016D
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length)
END_CLASS

CLASS: ColliderKernels
TYPE:  class
TOKEN: 0x2000169
FIELDS:
METHODS:
  System.Void PreSimulationUpdateKernel(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 index)
  System.Void PreSimulationUpdateRangeKernel(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length)
  System.Void PreSimulationUpdateKernel$BurstManaged(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 index)
  System.Void PreSimulationUpdateRangeKernel$BurstManaged(BeyondDynamicBone.ExBitFlag8* flagArray, System.Int16* teamIdArray, Unity.Mathematics.float3* centerArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, Unity.Mathematics.float3* transformPositionArray, Unity.Mathematics.quaternion* transformRotationArray, Unity.Mathematics.float3* transformScaleArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int32 length)
END_CLASS

CLASS: CreateUpdatecolliderListKernel_000003D3$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200016F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 teamId)
  System.IAsyncResult BeginInvoke(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 teamId, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CreateUpdatecolliderListKernel_000003D3$BurstDirectCall
TYPE:  class
TOKEN: 0x2000170
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 teamId)
END_CLASS

CLASS: CreateUpdatecolliderListRangeKernel_000003D4$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000171
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 length)
  System.IAsyncResult BeginInvoke(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CreateUpdatecolliderListRangeKernel_000003D4$BurstDirectCall
TYPE:  class
TOKEN: 0x2000172
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 length)
END_CLASS

CLASS: CreateUpdatecolliderListJobKernels
TYPE:  class
TOKEN: 0x200016E
FIELDS:
METHODS:
  System.Void CreateUpdatecolliderListKernel(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 teamId)
  System.Void CreateUpdatecolliderListRangeKernel(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 length)
  System.Void CreateUpdatecolliderListKernel$BurstManaged(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 teamId)
  System.Void CreateUpdatecolliderListRangeKernel$BurstManaged(System.Int32 updateIndex, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* jobColliderCounter, System.Int32* jobColliderIndexList, System.Int32 length)
END_CLASS

CLASS: StartSimulationStepKernel_000003D5$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000174
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: StartSimulationStepKernel_000003D5$BurstDirectCall
TYPE:  class
TOKEN: 0x2000175
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32 index)
END_CLASS

CLASS: StartSimulationStepRangeKernel_000003D6$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000176
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: StartSimulationStepRangeKernel_000003D6$BurstDirectCall
TYPE:  class
TOKEN: 0x2000177
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32* lengthPtr)
END_CLASS

CLASS: StartSimulationStepJobKernels
TYPE:  class
TOKEN: 0x2000173
FIELDS:
METHODS:
  System.Void StartSimulationStepKernel(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32 index)
  System.Void StartSimulationStepRangeKernel(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32* lengthPtr)
  System.Void StartSimulationStepKernel$BurstManaged(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32 index)
  System.Void StartSimulationStepRangeKernel$BurstManaged(System.Int32* jobColliderIndexList, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, System.Int16* teamIdArray, BeyondDynamicBone.ExBitFlag8* flagArray, Unity.Mathematics.float3* sizeArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* frameScales, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, BeyondDynamicBone.ColliderManager.WorkData* workDataArray, System.Int32* lengthPtr)
END_CLASS

CLASS: PostSimulationUpdateKernel_000003D7$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000179
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: PostSimulationUpdateKernel_000003D7$BurstDirectCall
TYPE:  class
TOKEN: 0x200017A
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index)
END_CLASS

CLASS: PostSimulationUpdateRangeKernel_000003D8$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200017B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length)
  System.IAsyncResult BeginInvoke(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: PostSimulationUpdateRangeKernel_000003D8$BurstDirectCall
TYPE:  class
TOKEN: 0x200017C
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length)
END_CLASS

CLASS: PostSimulationUpdateJobKernels
TYPE:  class
TOKEN: 0x2000178
FIELDS:
METHODS:
  System.Void PostSimulationUpdateKernel(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index)
  System.Void PostSimulationUpdateRangeKernel(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length)
  System.Void PostSimulationUpdateKernel$BurstManaged(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 index)
  System.Void PostSimulationUpdateRangeKernel$BurstManaged(System.Int16* teamIdArray, Unity.Mathematics.float3* framePositions, Unity.Mathematics.quaternion* frameRotations, Unity.Mathematics.float3* oldFramePositions, Unity.Mathematics.quaternion* oldFrameRotations, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32 length)
END_CLASS

CLASS: ColliderType
TYPE:  struct
TOKEN: 0x200017D
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  BeyondDynamicBone.ColliderManager.ColliderTypeNone  // 0x0
  public    static  BeyondDynamicBone.ColliderManager.ColliderTypeSphere  // 0x0
  public    static  BeyondDynamicBone.ColliderManager.ColliderTypeCapsuleX_Center  // 0x0
  public    static  BeyondDynamicBone.ColliderManager.ColliderTypeCapsuleY_Center  // 0x0
  public    static  BeyondDynamicBone.ColliderManager.ColliderTypeCapsuleZ_Center  // 0x0
  public    static  BeyondDynamicBone.ColliderManager.ColliderTypeCapsuleX_Start  // 0x0
  public    static  BeyondDynamicBone.ColliderManager.ColliderTypeCapsuleY_Start  // 0x0
  public    static  BeyondDynamicBone.ColliderManager.ColliderTypeCapsuleZ_Start  // 0x0
  public    static  BeyondDynamicBone.ColliderManager.ColliderTypePlane  // 0x0
  public    static  BeyondDynamicBone.ColliderManager.ColliderTypeBox  // 0x0
METHODS:
END_CLASS

CLASS: WorkData
TYPE:  struct
TOKEN: 0x200017E
FIELDS:
  public            BeyondDynamicBone.AABB          aabb  // 0x10
  public            Unity.Mathematics.float2        radius  // 0x28
  public            Unity.Mathematics.float3x2      oldPos  // 0x30
  public            Unity.Mathematics.float3x2      nextPos  // 0x48
  public            Unity.Mathematics.quaternion    inverseOldRot  // 0x60
  public            Unity.Mathematics.quaternion    rot  // 0x70
METHODS:
END_CLASS

CLASS: PreSimulationUpdateJob
TYPE:  struct
TOKEN: 0x200017F
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData>centerDataArray  // 0x20
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>flagArray  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>centerArray  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>framePositions  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>frameRotations  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>frameScales  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldFramePositions  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldFrameRotations  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nowPositions  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>nowRotations  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPositions  // 0xD0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldRotations  // 0xE0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformPositionArray  // 0xF0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformRotationArray  // 0x100
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformScaleArray  // 0x110
  public            System.Int32                    _indexCount  // 0x120
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: CreateUpdatecolliderListJob
TYPE:  struct
TOKEN: 0x2000180
FIELDS:
  public            System.Int32                    updateIndex  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x18
  public            Unity.Collections.NativeReference<System.Int32>jobColliderCounter  // 0x28
  public            Unity.Collections.NativeArray<System.Int32>jobColliderIndexList  // 0x38
  public            System.Int32                    _indexCount  // 0x48
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 teamId)
  System.Void UnsafeDo()
END_CLASS

CLASS: StartSimulationStepJob
TYPE:  struct
TOKEN: 0x2000181
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>jobColliderIndexList  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData>centerDataArray  // 0x30
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x40
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>flagArray  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>sizeArray  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>framePositions  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>frameRotations  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>frameScales  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldFramePositions  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldFrameRotations  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nowPositions  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>nowRotations  // 0xD0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPositions  // 0xE0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldRotations  // 0xF0
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ColliderManager.WorkData>workDataArray  // 0x100
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x110
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: EndSimulationStepJob
TYPE:  struct
TOKEN: 0x2000182
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>jobColliderIndexList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nowPositions  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>nowRotations  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPositions  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldRotations  // 0x50
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x60
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: PostSimulationUpdateJob
TYPE:  struct
TOKEN: 0x2000183
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x10
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>framePositions  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>frameRotations  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldFramePositions  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldFrameRotations  // 0x60
  public            System.Int32                    _indexCount  // 0x70
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: CreateUpdateParticleListKernel_00000401$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000186
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 teamId)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 teamId, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CreateUpdateParticleListKernel_00000401$BurstDirectCall
TYPE:  class
TOKEN: 0x2000187
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 teamId)
END_CLASS

CLASS: CreateUpdateParticleListRangeKernel_00000402$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000188
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 length)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CreateUpdateParticleListRangeKernel_00000402$BurstDirectCall
TYPE:  class
TOKEN: 0x2000189
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 length)
END_CLASS

CLASS: CreateUpdateParticleListKernels
TYPE:  class
TOKEN: 0x2000185
FIELDS:
METHODS:
  System.Void CreateUpdateParticleListKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 teamId)
  System.Void CreateUpdateParticleListRangeKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 length)
  System.Void CreateUpdateParticleListKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 teamId)
  System.Void CreateUpdateParticleListRangeKernel$BurstManaged(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, System.Int32* stepParticleIndexArray, System.Int32* stepBaseLineIndexArray, System.Int32* stepTriangleBendIndexArray, System.Int32* stepEdgeCollisionIndexArray, System.Int32* motionParticleIndexArray, System.Int32* selfParticleIndexArray, System.UInt32* selfPointTriangleIndexArray, System.UInt32* selfEdgeEdgeIndexArray, System.UInt32* selfTrianglePointIndexArray, System.Int32* stepParticleIndexCounter, System.Int32* stepBaseLineIndexCounter, System.Int32* stepTriangleBendIndexCounter, System.Int32* stepEdgeCollisionIndexCounter, System.Int32* motionParticleIndexCounter, System.Int32* selfParticleCounter, System.Int32* selfPointTriangleCounter, System.Int32* selfEdgeEdgeCounter, System.Int32* selfTrianglePointCounter, System.Int32 length)
END_CLASS

CLASS: PreSimulationUpdateKernel_00000403$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200018B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 pindex)
  System.IAsyncResult BeginInvoke(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 pindex, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: PreSimulationUpdateKernel_00000403$BurstDirectCall
TYPE:  class
TOKEN: 0x200018C
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 pindex)
END_CLASS

CLASS: PreSimulationUpdateRangeKernel_00000404$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200018D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 length)
  System.IAsyncResult BeginInvoke(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: PreSimulationUpdateRangeKernel_00000404$BurstDirectCall
TYPE:  class
TOKEN: 0x200018E
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 length)
END_CLASS

CLASS: PreSimulationUpdateJobKernels
TYPE:  class
TOKEN: 0x200018A
FIELDS:
METHODS:
  System.Void PreSimulationUpdateKernel(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 pindex)
  System.Void PreSimulationUpdateRangeKernel(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 length)
  System.Void PreSimulationUpdateKernel$BurstManaged(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 pindex)
  System.Void PreSimulationUpdateRangeKernel$BurstManaged(System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.quaternion* oldRotArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, Unity.Mathematics.float3* dispPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32 length)
END_CLASS

CLASS: StartSimulationStepKernel_00000405$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000190
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: StartSimulationStepKernel_00000405$BurstDirectCall
TYPE:  class
TOKEN: 0x2000191
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index)
END_CLASS

CLASS: StartSimulationStepRangeKernel_00000406$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000192
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: StartSimulationStepRangeKernel_00000406$BurstDirectCall
TYPE:  class
TOKEN: 0x2000193
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr)
END_CLASS

CLASS: Spring_00000407$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000194
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.SpringConstraint.SpringConstraintParams& springParams, BeyondDynamicBone.ClothNormalAxis normalAxis, Unity.Mathematics.float3& nextPos, Unity.Mathematics.float3& basePos, Unity.Mathematics.quaternion& baseRot, System.Single noiseTime, System.Single scaleRatio)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.SpringConstraint.SpringConstraintParams& springParams, BeyondDynamicBone.ClothNormalAxis normalAxis, Unity.Mathematics.float3& nextPos, Unity.Mathematics.float3& basePos, Unity.Mathematics.quaternion& baseRot, System.Single noiseTime, System.Single scaleRatio, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Spring_00000407$BurstDirectCall
TYPE:  class
TOKEN: 0x2000195
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.SpringConstraint.SpringConstraintParams& springParams, BeyondDynamicBone.ClothNormalAxis normalAxis, Unity.Mathematics.float3& nextPos, Unity.Mathematics.float3& basePos, Unity.Mathematics.quaternion& baseRot, System.Single noiseTime, System.Single scaleRatio)
END_CLASS

CLASS: Wind_00000408$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000196
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, System.Int32 vindex, System.Int32 pindex, System.Single depth, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32* vertexRootIndices, System.Single* frictionArray, Unity.Mathematics.float3& result)
  System.IAsyncResult BeginInvoke(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, System.Int32 vindex, System.Int32 pindex, System.Single depth, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32* vertexRootIndices, System.Single* frictionArray, Unity.Mathematics.float3& result, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Wind_00000408$BurstDirectCall
TYPE:  class
TOKEN: 0x2000197
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, System.Int32 vindex, System.Int32 pindex, System.Single depth, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32* vertexRootIndices, System.Single* frictionArray, Unity.Mathematics.float3& result)
END_CLASS

CLASS: WindForceBlend_00000409$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000198
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(BeyondDynamicBone.TeamWindInfo& windInfo, BeyondDynamicBone.WindParams& windParams, Unity.Mathematics.float3& windPos, System.Single windTurbulence, Unity.Mathematics.float3& result)
  System.IAsyncResult BeginInvoke(BeyondDynamicBone.TeamWindInfo& windInfo, BeyondDynamicBone.WindParams& windParams, Unity.Mathematics.float3& windPos, System.Single windTurbulence, Unity.Mathematics.float3& result, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: WindForceBlend_00000409$BurstDirectCall
TYPE:  class
TOKEN: 0x2000199
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(BeyondDynamicBone.TeamWindInfo& windInfo, BeyondDynamicBone.WindParams& windParams, Unity.Mathematics.float3& windPos, System.Single windTurbulence, Unity.Mathematics.float3& result)
END_CLASS

CLASS: StartSimulationStepJobKernels
TYPE:  class
TOKEN: 0x200018F
FIELDS:
METHODS:
  System.Void StartSimulationStepKernel(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index)
  System.Void StartSimulationStepRangeKernel(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr)
  System.Void Spring(BeyondDynamicBone.SpringConstraint.SpringConstraintParams& springParams, BeyondDynamicBone.ClothNormalAxis normalAxis, Unity.Mathematics.float3& nextPos, Unity.Mathematics.float3& basePos, Unity.Mathematics.quaternion& baseRot, System.Single noiseTime, System.Single scaleRatio)
  System.Void Wind(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, System.Int32 vindex, System.Int32 pindex, System.Single depth, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32* vertexRootIndices, System.Single* frictionArray, Unity.Mathematics.float3& result)
  System.Void WindForceBlend(BeyondDynamicBone.TeamWindInfo& windInfo, BeyondDynamicBone.WindParams& windParams, Unity.Mathematics.float3& windPos, System.Single windTurbulence, Unity.Mathematics.float3& result)
  System.Void StartSimulationStepKernel$BurstManaged(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index)
  System.Void StartSimulationStepRangeKernel$BurstManaged(System.Single simulationPowerX, System.Single simulationPowerY, System.Single simulationPowerZ, System.Single simulationPowerW, System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr)
  System.Void Spring$BurstManaged(BeyondDynamicBone.SpringConstraint.SpringConstraintParams& springParams, BeyondDynamicBone.ClothNormalAxis normalAxis, Unity.Mathematics.float3& nextPos, Unity.Mathematics.float3& basePos, Unity.Mathematics.quaternion& baseRot, System.Single noiseTime, System.Single scaleRatio)
  System.Void Wind$BurstManaged(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, System.Int32 vindex, System.Int32 pindex, System.Single depth, BeyondDynamicBone.TeamWindData* teamWindArray, BeyondDynamicBone.WindManager.WindData* windDataArray, System.Int32* vertexRootIndices, System.Single* frictionArray, Unity.Mathematics.float3& result)
  System.Void WindForceBlend$BurstManaged(BeyondDynamicBone.TeamWindInfo& windInfo, BeyondDynamicBone.WindParams& windParams, Unity.Mathematics.float3& windPos, System.Single windTurbulence, Unity.Mathematics.float3& result)
END_CLASS

CLASS: UpdateStepBasicPotureKernel_0000040A$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200019B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: UpdateStepBasicPotureKernel_0000040A$BurstDirectCall
TYPE:  class
TOKEN: 0x200019C
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index)
END_CLASS

CLASS: UpdateStepBasicPotureRangeKernel_0000040B$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200019D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: UpdateStepBasicPotureRangeKernel_0000040B$BurstDirectCall
TYPE:  class
TOKEN: 0x200019E
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr)
END_CLASS

CLASS: UpdateStepBasicPotureJobKernels
TYPE:  class
TOKEN: 0x200019A
FIELDS:
METHODS:
  System.Void UpdateStepBasicPotureKernel(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index)
  System.Void UpdateStepBasicPotureRangeKernel(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr)
  System.Void UpdateStepBasicPotureKernel$BurstManaged(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32 index)
  System.Void UpdateStepBasicPotureRangeKernel$BurstManaged(System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Int32* vertexParentIndices, Unity.Mathematics.float3* vertexLocalPositions, Unity.Mathematics.quaternion* vertexLocalRotations, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* stepBasicPositionArray, Unity.Mathematics.quaternion* stepBasicRotationArray, System.Int32* lengthPtr)
END_CLASS

CLASS: EndSimulationStepKernel_0000040C$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001A0
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: EndSimulationStepKernel_0000040C$BurstDirectCall
TYPE:  class
TOKEN: 0x20001A1
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index)
END_CLASS

CLASS: EndSimulationStepRangeKernel_0000040D$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001A2
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: EndSimulationStepRangeKernel_0000040D$BurstDirectCall
TYPE:  class
TOKEN: 0x20001A3
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr)
END_CLASS

CLASS: EndSimulationStepJobKernels
TYPE:  class
TOKEN: 0x200019F
FIELDS:
METHODS:
  System.Void EndSimulationStepKernel(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index)
  System.Void EndSimulationStepRangeKernel(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr)
  System.Void EndSimulationStepKernel$BurstManaged(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index)
  System.Void EndSimulationStepRangeKernel$BurstManaged(System.Single simulationDeltaTime, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* velocityArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.Single* staticFrictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr)
END_CLASS

CLASS: CalcDisplayPositionKernel_0000040E$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001A5
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 pindex)
  System.IAsyncResult BeginInvoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 pindex, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcDisplayPositionKernel_0000040E$BurstDirectCall
TYPE:  class
TOKEN: 0x20001A6
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 pindex)
END_CLASS

CLASS: CalcDisplayPositionRangeKernel_0000040F$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001A7
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 length)
  System.IAsyncResult BeginInvoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: CalcDisplayPositionRangeKernel_0000040F$BurstDirectCall
TYPE:  class
TOKEN: 0x20001A8
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 length)
END_CLASS

CLASS: CalcDisplayPositionJobKernels
TYPE:  class
TOKEN: 0x20001A4
FIELDS:
METHODS:
  System.Void CalcDisplayPositionKernel(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 pindex)
  System.Void CalcDisplayPositionRangeKernel(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 length)
  System.Void CalcDisplayPositionKernel$BurstManaged(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 pindex)
  System.Void CalcDisplayPositionRangeKernel$BurstManaged(System.Single simulationDeltaTime, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int16* teamIdArray, Unity.Mathematics.float3* oldPosArray, Unity.Mathematics.float3* realVelocityArray, Unity.Mathematics.float3* oldPositionArray, Unity.Mathematics.quaternion* oldRotationArray, Unity.Mathematics.float3* dispPosArray, BeyondDynamicBone.VertexAttribute* attributes, Unity.Mathematics.float3* positions, Unity.Mathematics.quaternion* rotations, System.Int32* vertexRootIndices, System.Int32 length)
END_CLASS

CLASS: ClearStepCounterKernel_00000410$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001AA
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* processingStepParticle, System.Int32* processingStepTriangleBending, System.Int32* processingStepEdgeCollision, System.Int32* processingStepCollider, System.Int32* processingStepBaseLine, System.Int32* processingStepMotionParticle, System.Int32* processingSelfParticle, System.Int32* processingSelfPointTriangle, System.Int32* processingSelfEdgeEdge, System.Int32* processingSelfTrianglePoint)
  System.IAsyncResult BeginInvoke(System.Int32* processingStepParticle, System.Int32* processingStepTriangleBending, System.Int32* processingStepEdgeCollision, System.Int32* processingStepCollider, System.Int32* processingStepBaseLine, System.Int32* processingStepMotionParticle, System.Int32* processingSelfParticle, System.Int32* processingSelfPointTriangle, System.Int32* processingSelfEdgeEdge, System.Int32* processingSelfTrianglePoint, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: ClearStepCounterKernel_00000410$BurstDirectCall
TYPE:  class
TOKEN: 0x20001AB
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* processingStepParticle, System.Int32* processingStepTriangleBending, System.Int32* processingStepEdgeCollision, System.Int32* processingStepCollider, System.Int32* processingStepBaseLine, System.Int32* processingStepMotionParticle, System.Int32* processingSelfParticle, System.Int32* processingSelfPointTriangle, System.Int32* processingSelfEdgeEdge, System.Int32* processingSelfTrianglePoint)
END_CLASS

CLASS: ClearStepCounterKernels
TYPE:  class
TOKEN: 0x20001A9
FIELDS:
METHODS:
  System.Void ClearStepCounterKernel(System.Int32* processingStepParticle, System.Int32* processingStepTriangleBending, System.Int32* processingStepEdgeCollision, System.Int32* processingStepCollider, System.Int32* processingStepBaseLine, System.Int32* processingStepMotionParticle, System.Int32* processingSelfParticle, System.Int32* processingSelfPointTriangle, System.Int32* processingSelfEdgeEdge, System.Int32* processingSelfTrianglePoint)
  System.Void ClearStepCounterKernel$BurstManaged(System.Int32* processingStepParticle, System.Int32* processingStepTriangleBending, System.Int32* processingStepEdgeCollision, System.Int32* processingStepCollider, System.Int32* processingStepBaseLine, System.Int32* processingStepMotionParticle, System.Int32* processingSelfParticle, System.Int32* processingSelfPointTriangle, System.Int32* processingSelfEdgeEdge, System.Int32* processingSelfTrianglePoint)
END_CLASS

CLASS: PreSimulationUpdateJob
TYPE:  struct
TOKEN: 0x20001AC
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData>centerDataArray  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positions  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotations  // 0x50
  public            Unity.Collections.NativeArray<System.Single>vertexDepths  // 0x60
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosArray  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldRotArray  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosArray  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>baseRotArray  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPositionArray  // 0xD0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldRotationArray  // 0xE0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityPosArray  // 0xF0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>dispPosArray  // 0x100
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityArray  // 0x110
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>realVelocityArray  // 0x120
  public            Unity.Collections.NativeArray<System.Single>frictionArray  // 0x130
  public            Unity.Collections.NativeArray<System.Single>staticFrictionArray  // 0x140
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>collisionNormalArray  // 0x150
  public            System.Int32                    _indexCount  // 0x160
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 pindex)
  System.Void UnsafeDo()
END_CLASS

CLASS: ClearStepCounter
TYPE:  struct
TOKEN: 0x20001AD
FIELDS:
  public            Unity.Collections.NativeReference<System.Int32>processingStepParticle  // 0x10
  public            Unity.Collections.NativeReference<System.Int32>processingStepTriangleBending  // 0x20
  public            Unity.Collections.NativeReference<System.Int32>processingStepEdgeCollision  // 0x30
  public            Unity.Collections.NativeReference<System.Int32>processingStepCollider  // 0x40
  public            Unity.Collections.NativeReference<System.Int32>processingStepBaseLine  // 0x50
  public            Unity.Collections.NativeReference<System.Int32>processingStepMotionParticle  // 0x60
  public            Unity.Collections.NativeReference<System.Int32>processingSelfParticle  // 0x70
  public            Unity.Collections.NativeReference<System.Int32>processingSelfPointTriangle  // 0x80
  public            Unity.Collections.NativeReference<System.Int32>processingSelfEdgeEdge  // 0x90
  public            Unity.Collections.NativeReference<System.Int32>processingSelfTrianglePoint  // 0xA0
METHODS:
  System.Void Execute()
  System.Void UnsafeDo()
END_CLASS

CLASS: CreateUpdateParticleList
TYPE:  struct
TOKEN: 0x20001AE
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x20
  public            Unity.Collections.NativeReference<System.Int32>stepParticleIndexCounter  // 0x30
  public            Unity.Collections.NativeArray<System.Int32>stepParticleIndexArray  // 0x40
  public            Unity.Collections.NativeReference<System.Int32>stepBaseLineIndexCounter  // 0x50
  public            Unity.Collections.NativeArray<System.Int32>stepBaseLineIndexArray  // 0x60
  public            Unity.Collections.NativeReference<System.Int32>stepTriangleBendIndexCounter  // 0x70
  public            Unity.Collections.NativeArray<System.Int32>stepTriangleBendIndexArray  // 0x80
  public            Unity.Collections.NativeReference<System.Int32>stepEdgeCollisionIndexCounter  // 0x90
  public            Unity.Collections.NativeArray<System.Int32>stepEdgeCollisionIndexArray  // 0xA0
  public            Unity.Collections.NativeReference<System.Int32>motionParticleIndexCounter  // 0xB0
  public            Unity.Collections.NativeArray<System.Int32>motionParticleIndexArray  // 0xC0
  public            Unity.Collections.NativeReference<System.Int32>selfParticleCounter  // 0xD0
  public            Unity.Collections.NativeArray<System.Int32>selfParticleIndexArray  // 0xE0
  public            Unity.Collections.NativeReference<System.Int32>selfPointTriangleCounter  // 0xF0
  public            Unity.Collections.NativeArray<System.UInt32>selfPointTriangleIndexArray  // 0x100
  public            Unity.Collections.NativeReference<System.Int32>selfEdgeEdgeCounter  // 0x110
  public            Unity.Collections.NativeArray<System.UInt32>selfEdgeEdgeIndexArray  // 0x120
  public            Unity.Collections.NativeReference<System.Int32>selfTrianglePointCounter  // 0x130
  public            Unity.Collections.NativeArray<System.UInt32>selfTrianglePointIndexArray  // 0x140
  public            System.Int32                    _indexCount  // 0x150
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 teamId)
  System.Void UnsafeDo()
END_CLASS

CLASS: StartSimulationStepJob
TYPE:  struct
TOKEN: 0x20001AF
FIELDS:
  public            Unity.Mathematics.float4        simulationPower  // 0x10
  public            System.Single                   simulationDeltaTime  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>stepParticleIndexArray  // 0x28
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x38
  public            Unity.Collections.NativeArray<System.Single>depthArray  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positions  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotations  // 0x68
  public            Unity.Collections.NativeArray<System.Int32>vertexRootIndices  // 0x78
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x88
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x98
  public            Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData>centerDataArray  // 0xA8
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamWindData>teamWindArray  // 0xB8
  public            Unity.Collections.NativeArray<BeyondDynamicBone.WindManager.WindData>windDataArray  // 0xC8
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0xD8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosArray  // 0xE8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityArray  // 0xF8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x108
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosArray  // 0x118
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>baseRotArray  // 0x128
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPositionArray  // 0x138
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldRotationArray  // 0x148
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityPosArray  // 0x158
  public            Unity.Collections.NativeArray<System.Single>frictionArray  // 0x168
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>stepBasicPositionArray  // 0x178
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>stepBasicRotationArray  // 0x188
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x198
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void Spring(BeyondDynamicBone.SpringConstraint.SpringConstraintParams& springParams, BeyondDynamicBone.ClothNormalAxis normalAxis, Unity.Mathematics.float3& nextPos, Unity.Mathematics.float3& basePos, Unity.Mathematics.quaternion& baseRot, System.Single noiseTime, System.Single scaleRatio)
  System.Void Wind(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData& tdata, BeyondDynamicBone.WindParams& windParams, BeyondDynamicBone.InertiaConstraint.CenterData& cdata, System.Int32 vindex, System.Int32 pindex, System.Single depth, Unity.Mathematics.float3& result)
  System.Void WindForceBlend(BeyondDynamicBone.TeamWindInfo& windInfo, BeyondDynamicBone.WindParams& windParams, Unity.Mathematics.float3& windPos, System.Single windTurbulence, Unity.Mathematics.float3& result)
  System.Void UnsafeDo()
END_CLASS

CLASS: UpdateStepBasicPotureJob
TYPE:  struct
TOKEN: 0x20001B0
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>stepBaseLineIndexArray  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x30
  public            Unity.Collections.NativeArray<System.Int32>vertexParentIndices  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>vertexLocalPositions  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>vertexLocalRotations  // 0x60
  public            Unity.Collections.NativeArray<System.UInt16>baseLineStartDataIndices  // 0x70
  public            Unity.Collections.NativeArray<System.UInt16>baseLineDataCounts  // 0x80
  public            Unity.Collections.NativeArray<System.UInt16>baseLineData  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>basePosArray  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>baseRotArray  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>stepBasicPositionArray  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>stepBasicRotationArray  // 0xD0
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0xE0
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: EndSimulationStepJob
TYPE:  struct
TOKEN: 0x20001B1
FIELDS:
  public            System.Single                   simulationDeltaTime  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>stepParticleIndexArray  // 0x18
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x28
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x38
  public            Unity.Collections.NativeArray<BeyondDynamicBone.InertiaConstraint.CenterData>centerDataArray  // 0x48
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x58
  public            Unity.Collections.NativeArray<System.Single>vertexDepths  // 0x68
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosArray  // 0x98
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityArray  // 0xA8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>realVelocityArray  // 0xB8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityPosArray  // 0xC8
  public            Unity.Collections.NativeArray<System.Single>frictionArray  // 0xD8
  public            Unity.Collections.NativeArray<System.Single>staticFrictionArray  // 0xE8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>collisionNormalArray  // 0xF8
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x108
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: CalcDisplayPositionJob
TYPE:  struct
TOKEN: 0x20001B2
FIELDS:
  public            System.Single                   simulationDeltaTime  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x18
  public            Unity.Collections.NativeArray<System.Int16>teamIdArray  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPosArray  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>realVelocityArray  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldPositionArray  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>oldRotationArray  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>dispPosArray  // 0x78
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positions  // 0x98
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotations  // 0xA8
  public            Unity.Collections.NativeArray<System.Int32>vertexRootIndices  // 0xB8
  public            System.Int32                    _indexCount  // 0xC8
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 pindex)
  System.Void UnsafeDo()
END_CLASS

CLASS: FeedbackTempPosJob
TYPE:  struct
TOKEN: 0x20001B3
FIELDS:
  public            Unity.Collections.NativeList<System.Int32>jobParticleIndexList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>tempFloat3Buffer  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x30
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: FeedbackTempPosJob2
TYPE:  struct
TOKEN: 0x20001B4
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>particleIndexArray  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>tempFloat3Buffer  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x30
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: UpdateLocation
TYPE:  struct
TOKEN: 0x20001B6
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.TimeManager.UpdateLocationAfterLateUpdate  // 0x0
  public    static  BeyondDynamicBone.TimeManager.UpdateLocationBeforeLateUpdate  // 0x0
METHODS:
END_CLASS

CLASS: WindData
TYPE:  struct
TOKEN: 0x20001B8
FIELDS:
  public            Unity.Collections.BitField32    flag  // 0x10
  public            BeyondDynamicBone.BeyondBoneWindZone.Modemode  // 0x14
  public            Unity.Mathematics.float3        size  // 0x18
  public            System.Single                   main  // 0x24
  public            System.Single                   turbulence  // 0x28
  public            System.Single                   zoneVolume  // 0x2C
  public            Unity.Mathematics.float3        worldWindDirection  // 0x30
  public            Unity.Mathematics.float3        worldPositin  // 0x3C
  public            Unity.Mathematics.quaternion    worldRotation  // 0x48
  public            Unity.Mathematics.float3        worldScale  // 0x58
  public            Unity.Mathematics.float4x4      worldToLocalMatrix  // 0x64
  public            Unity.Mathematics.float4x4      attenuation  // 0xA4
METHODS:
  System.Boolean IsValid()
  System.Boolean IsEnable()
  System.Boolean IsAddition()
END_CLASS

CLASS: RestoreTransformJob
TYPE:  struct
TOKEN: 0x20001BC
FIELDS:
  public            System.Int32                    count  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>flagList  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositionArray  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>localRotationArray  // 0x38
METHODS:
  System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
END_CLASS

CLASS: ReadTransformJob
TYPE:  struct
TOKEN: 0x20001BD
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>flagList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positionArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotationArray  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>scaleList  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositionArray  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>localRotationArray  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>inverseRotationArray  // 0x70
METHODS:
  System.Void Execute(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
END_CLASS

CLASS: ShareSerializationData
TYPE:  class
TOKEN: 0x20001BE
FIELDS:
  public            BeyondDynamicBone.ExSimpleNativeArray.SerializationData<BeyondDynamicBone.ExBitFlag8>flagArray  // 0x10
  public            BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.float3>initLocalPositionArray  // 0x18
  public            BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.quaternion>initLocalRotationArray  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: UniqueSerializationData
TYPE:  class
TOKEN: 0x20001BF
FIELDS:
  public            UnityEngine.Transform[]         transformArray  // 0x10
METHODS:
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
  System.Void .ctor()
END_CLASS

CLASS: InitGridJob
TYPE:  struct
TOKEN: 0x20001CC
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            System.Single                   gridSize  // 0x14
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x18
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x28
  public            Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32>gridMap  // 0x38
METHODS:
  System.Void Execute()
END_CLASS

CLASS: SearchJoinJob
TYPE:  struct
TOKEN: 0x20001CD
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            System.Single                   gridSize  // 0x14
  public            System.Single                   radius  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x30
  public            Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32>gridMap  // 0x40
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>joinPairMap  // 0x50
METHODS:
  System.Void Execute()
END_CLASS

CLASS: JoinJob2
TYPE:  struct
TOKEN: 0x20001CE
FIELDS:
  public            System.Int32                    vertexCount  // 0x10
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>joinPairMap  // 0x18
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x28
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>vertexToVertexMap  // 0x38
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0x48
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x58
  public            Unity.Collections.NativeReference<System.Int32>result  // 0x68
  public            Unity.Collections.NativeList<System.UInt16>tempList  // 0x78
METHODS:
  System.Void Execute()
END_CLASS

CLASS: UpdateJoinIndexJob
TYPE:  struct
TOKEN: 0x20001CF
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x10
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: UpdateLinkIndexJob
TYPE:  struct
TOKEN: 0x20001D0
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x10
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>vertexToVertexMap  // 0x20
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: FinalMergeVertexJob
TYPE:  struct
TOKEN: 0x20001D1
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localNormals  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0x30
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: SearchJoinEdgeJob
TYPE:  struct
TOKEN: 0x20001D3
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            System.Single                   radius  // 0x14
  public            System.Boolean                  dontMakeLine  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x30
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>vertexToVertexMap  // 0x40
  public            Unity.Collections.NativeList<BeyondDynamicBone.StepReductionBase.JoinEdge>joinEdgeList  // 0x50
METHODS:
  System.Void Execute()
END_CLASS

CLASS: InitGridJob
TYPE:  struct
TOKEN: 0x20001D5
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            System.Single                   gridSize  // 0x14
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x18
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x28
  public            Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32>gridMap  // 0x38
METHODS:
  System.Void Execute()
END_CLASS

CLASS: SearchJoinEdgeJob
TYPE:  struct
TOKEN: 0x20001D6
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            System.Single                   gridSize  // 0x14
  public            System.Single                   radius  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x30
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>vertexToVertexMap  // 0x40
  public            Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32>gridMap  // 0x50
  public            Unity.Collections.NativeList<BeyondDynamicBone.StepReductionBase.JoinEdge>joinEdgeList  // 0x60
METHODS:
  System.Void Execute()
END_CLASS

CLASS: JoinEdge
TYPE:  struct
TOKEN: 0x20001D8
FIELDS:
  public            Unity.Mathematics.int2          vertexPair  // 0x10
  public            System.Single                   cost  // 0x18
METHODS:
  System.Boolean Contains(Unity.Mathematics.int2& pair)
  System.Int32 CompareTo(BeyondDynamicBone.StepReductionBase.JoinEdge other)
END_CLASS

CLASS: DeterminJoinEdgeJob
TYPE:  struct
TOKEN: 0x20001D9
FIELDS:
  public            System.Int32                    stepIndex  // 0x10
  public            System.Single                   mergeLength  // 0x14
  public            Unity.Collections.NativeList<BeyondDynamicBone.StepReductionBase.JoinEdge>joinEdgeList  // 0x18
  public            Unity.Collections.NativeParallelHashSet<System.Int32>completeVertexSet  // 0x28
  public            Unity.Collections.NativeList<Unity.Mathematics.int2>removePairList  // 0x38
  public            Unity.Collections.NativeArray<System.Int32>resultArray  // 0x48
METHODS:
  System.Void Execute()
END_CLASS

CLASS: JoinPairJob
TYPE:  struct
TOKEN: 0x20001DA
FIELDS:
  public            System.Single                   joinPositionAdjustment  // 0x10
  public            Unity.Collections.NativeList<Unity.Mathematics.int2>removePairList  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localNormals  // 0x38
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>vertexToVertexMap  // 0x48
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0x58
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x68
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x78
METHODS:
  System.Void Execute()
END_CLASS

CLASS: UpdateJoinIndexJob
TYPE:  struct
TOKEN: 0x20001DB
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x10
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: UpdateLinkIndexJob
TYPE:  struct
TOKEN: 0x20001DC
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x10
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>vertexToVertexMap  // 0x20
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: FinalMergeVertexJob
TYPE:  struct
TOKEN: 0x20001DD
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localNormals  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0x30
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: DebugAxis
TYPE:  struct
TOKEN: 0x20001DF
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.ClothDebugSettings.DebugAxisNone  // 0x0
  public    static  BeyondDynamicBone.ClothDebugSettings.DebugAxisNormal  // 0x0
  public    static  BeyondDynamicBone.ClothDebugSettings.DebugAxisAll  // 0x0
METHODS:
END_CLASS

CLASS: GridEnumerator
TYPE:  struct
TOKEN: 0x20001E3
FIELDS:
  private           Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T>gridMap  // 0x0
  private           Unity.Mathematics.int3          startGrid  // 0x0
  private           Unity.Mathematics.int3          endGrid  // 0x0
  private           Unity.Mathematics.int3          currentGrid  // 0x0
  private           System.Boolean                  isFirst  // 0x0
METHODS:
  Unity.Mathematics.int3 get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  BeyondDynamicBone.GridMap.GridEnumerator<T> GetEnumerator()
END_CLASS

CLASS: FillJob`1
TYPE:  struct
TOKEN: 0x20001E5
FIELDS:
  public            T                               value  // 0x0
  public            Unity.Collections.NativeArray<T>array  // 0x0
  public            System.Int32                    _indexCount  // 0x0
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
END_CLASS

CLASS: FillJob2`1
TYPE:  struct
TOKEN: 0x20001E6
FIELDS:
  public            T                               value  // 0x0
  public            System.Int32                    startIndex  // 0x0
  public            Unity.Collections.NativeArray<T>array  // 0x0
  public            System.Int32                    _indexCount  // 0x0
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void SetIndexCount(System.Int32 indexCount)
  System.Void Execute()
END_CLASS

CLASS: FillRefJob`1
TYPE:  struct
TOKEN: 0x20001E7
FIELDS:
  public            T                               value  // 0x0
  public            Unity.Collections.NativeReference<T>reference  // 0x0
METHODS:
  System.Void Execute()
END_CLASS

CLASS: SerialNumberJob
TYPE:  struct
TOKEN: 0x20001E8
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>array  // 0x10
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: ConvertHashSetToListJob`1
TYPE:  struct
TOKEN: 0x20001E9
FIELDS:
  public            Unity.Collections.NativeParallelHashSet<T>hashSet  // 0x0
  public            Unity.Collections.NativeList<T> list  // 0x0
METHODS:
  System.Void Execute()
END_CLASS

CLASS: ConvertHashSetKeyToListJob`1
TYPE:  struct
TOKEN: 0x20001EA
FIELDS:
  public            Unity.Collections.NativeParallelHashSet<T>hashSet  // 0x0
  public            Unity.Collections.NativeList<T> list  // 0x0
METHODS:
  System.Void Execute()
END_CLASS

CLASS: CalcAABBJob
TYPE:  struct
TOKEN: 0x20001EB
FIELDS:
  public            System.Int32                    length  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positions  // 0x18
  public            Unity.Collections.NativeReference<BeyondDynamicBone.AABB>outAABB  // 0x28
METHODS:
  System.Void Execute()
END_CLASS

CLASS: CalcAABBDeferJob
TYPE:  struct
TOKEN: 0x20001EC
FIELDS:
  public            Unity.Collections.NativeList<Unity.Mathematics.float3>positions  // 0x10
  public            Unity.Collections.NativeReference<BeyondDynamicBone.AABB>outAABB  // 0x20
METHODS:
  System.Void Execute()
END_CLASS

CLASS: CalcUVJob
TYPE:  struct
TOKEN: 0x20001ED
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positions  // 0x10
  public            Unity.Collections.NativeReference<BeyondDynamicBone.AABB>aabb  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float2>uvs  // 0x30
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: AddIntDataCopyJob
TYPE:  struct
TOKEN: 0x20001EE
FIELDS:
  public            System.Int32                    dstOffset  // 0x10
  public            System.Int32                    addData  // 0x14
  public            Unity.Collections.NativeArray<System.Int32>srcData  // 0x18
  public            Unity.Collections.NativeArray<System.Int32>dstData  // 0x28
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: AddInt2DataCopyJob
TYPE:  struct
TOKEN: 0x20001EF
FIELDS:
  public            System.Int32                    dstOffset  // 0x10
  public            Unity.Mathematics.int2          addData  // 0x14
  public            Unity.Collections.NativeArray<Unity.Mathematics.int2>srcData  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.int2>dstData  // 0x30
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: AddInt3DataCopyJob
TYPE:  struct
TOKEN: 0x20001F0
FIELDS:
  public            System.Int32                    dstOffset  // 0x10
  public            Unity.Mathematics.int3          addData  // 0x14
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>srcData  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>dstData  // 0x30
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: TransformPositionJob
TYPE:  struct
TOKEN: 0x20001F1
FIELDS:
  public            Unity.Mathematics.float4x4      toM  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positions  // 0x50
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: TransformPositionJob2
TYPE:  struct
TOKEN: 0x20001F2
FIELDS:
  public            Unity.Mathematics.float4x4      toM  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>srcPositions  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>dstPositions  // 0x60
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: ConvertArrayToMapJob`1
TYPE:  struct
TOKEN: 0x20001F3
FIELDS:
  public            Unity.Collections.NativeArray<System.UInt32>indexArray  // 0x0
  public            Unity.Collections.NativeArray<TData>dataArray  // 0x0
  public            Unity.Collections.NativeParallelMultiHashMap<System.Int32,TData>map  // 0x0
METHODS:
  System.Void Execute()
END_CLASS

CLASS: ClearReferenceJob
TYPE:  struct
TOKEN: 0x20001F4
FIELDS:
  public            Unity.Collections.NativeReference<System.Int32>reference  // 0x10
METHODS:
  System.Void Execute()
END_CLASS

CLASS: AggregateKernel_00000564$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001F7
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: AggregateKernel_00000564$BurstDirectCall
TYPE:  class
TOKEN: 0x20001F8
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
END_CLASS

CLASS: AggregateRangeKernel_00000565$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001F9
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
  System.IAsyncResult BeginInvoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: AggregateRangeKernel_00000565$BurstDirectCall
TYPE:  class
TOKEN: 0x20001FA
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
END_CLASS

CLASS: AggregateJobKernels
TYPE:  class
TOKEN: 0x20001F6
FIELDS:
METHODS:
  System.Void AggregateKernel(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.Void AggregateRangeKernel(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
  System.Void AggregateKernel$BurstManaged(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.Void AggregateRangeKernel$BurstManaged(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
END_CLASS

CLASS: AggregateWithVelocityKernel_00000566$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001FC
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: AggregateWithVelocityKernel_00000566$BurstDirectCall
TYPE:  class
TOKEN: 0x20001FD
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
END_CLASS

CLASS: AggregateWithVelocityRangeKernel_00000567$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001FE
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
  System.IAsyncResult BeginInvoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: AggregateWithVelocityRangeKernel_00000567$BurstDirectCall
TYPE:  class
TOKEN: 0x20001FF
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
END_CLASS

CLASS: AggregateWithVelocityJobKernels
TYPE:  class
TOKEN: 0x20001FB
FIELDS:
METHODS:
  System.Void AggregateWithVelocityKernel(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.Void AggregateWithVelocityRangeKernel(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
  System.Void AggregateWithVelocityKernel$BurstManaged(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.Void AggregateWithVelocityRangeKernel$BurstManaged(System.Int32* jobParticleIndexList, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 length)
END_CLASS

CLASS: AggregateJob2Kernel_00000568$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000201
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: AggregateJob2Kernel_00000568$BurstDirectCall
TYPE:  class
TOKEN: 0x2000202
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
END_CLASS

CLASS: AggregateJob2RangeKernel_00000569$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000203
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: AggregateJob2RangeKernel_00000569$BurstDirectCall
TYPE:  class
TOKEN: 0x2000204
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr)
END_CLASS

CLASS: AggregateJob2Kernels
TYPE:  class
TOKEN: 0x2000200
FIELDS:
METHODS:
  System.Void AggregateJob2Kernel(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.Void AggregateJob2RangeKernel(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr)
  System.Void AggregateJob2Kernel$BurstManaged(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.Void AggregateJob2RangeKernel$BurstManaged(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr)
END_CLASS

CLASS: AggregateWithVelocityJob2Kernel_0000056A$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000206
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: AggregateWithVelocityJob2Kernel_0000056A$BurstDirectCall
TYPE:  class
TOKEN: 0x2000207
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
END_CLASS

CLASS: AggregateWithVelocityJob2RangeKernel_0000056B$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000208
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: AggregateWithVelocityJob2RangeKernel_0000056B$BurstDirectCall
TYPE:  class
TOKEN: 0x2000209
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr)
END_CLASS

CLASS: AggregateWithVelocityJob2Kernels
TYPE:  class
TOKEN: 0x2000205
FIELDS:
METHODS:
  System.Void AggregateWithVelocityJob2Kernel(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.Void AggregateWithVelocityJob2RangeKernel(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr)
  System.Void AggregateWithVelocityJob2Kernel$BurstManaged(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32 index)
  System.Void AggregateWithVelocityJob2RangeKernel$BurstManaged(System.Int32* particleIndexArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single velocityAttenuation, System.Int32* countArray, System.Int32* sumArray, System.Int32* lengthPtr)
END_CLASS

CLASS: AggregateJob
TYPE:  struct
TOKEN: 0x200020A
FIELDS:
  public            Unity.Collections.NativeList<System.Int32>jobParticleIndexList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>countArray  // 0x30
  public            Unity.Collections.NativeArray<System.Int32>sumArray  // 0x40
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: AggregateWithVelocityJob
TYPE:  struct
TOKEN: 0x200020B
FIELDS:
  public            Unity.Collections.NativeList<System.Int32>jobParticleIndexList  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityPosArray  // 0x30
  public            System.Single                   velocityAttenuation  // 0x40
  public            Unity.Collections.NativeArray<System.Int32>countArray  // 0x48
  public            Unity.Collections.NativeArray<System.Int32>sumArray  // 0x58
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: AggregateJob2
TYPE:  struct
TOKEN: 0x200020C
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>particleIndexArray  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>countArray  // 0x30
  public            Unity.Collections.NativeArray<System.Int32>sumArray  // 0x40
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x50
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: AggregateWithVelocityJob2
TYPE:  struct
TOKEN: 0x200020D
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>particleIndexArray  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityPosArray  // 0x30
  public            System.Single                   velocityAttenuation  // 0x40
  public            Unity.Collections.NativeArray<System.Int32>countArray  // 0x48
  public            Unity.Collections.NativeArray<System.Int32>sumArray  // 0x58
  public            Unity.Collections.NativeReference<System.Int32>_indexCount  // 0x68
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Void UnsafeDo()
END_CLASS

CLASS: AggregateWithVelocityCrossFrameJob2
TYPE:  struct
TOKEN: 0x200020E
FIELDS:
  public            Unity.Collections.NativeReference<System.Int32>indexCount  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>particleIndexArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>velocityPosArray  // 0x40
  public            System.Single                   velocityAttenuation  // 0x50
  public            Unity.Collections.NativeArray<System.Int32>countArray  // 0x58
  public            Unity.Collections.NativeArray<System.Int32>sumArray  // 0x68
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void Execute()
END_CLASS

CLASS: AggregateCrossFrameJob2
TYPE:  struct
TOKEN: 0x200020F
FIELDS:
  public            Unity.Collections.NativeReference<System.Int32>indexCount  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>particleIndexArray  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>nextPosArray  // 0x30
  public            Unity.Collections.NativeArray<System.Int32>countArray  // 0x40
  public            Unity.Collections.NativeArray<System.Int32>sumArray  // 0x50
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void Execute()
END_CLASS

CLASS: SerializationData
TYPE:  class
TOKEN: 0x2000221
FIELDS:
  public            System.Int32                    count  // 0x0
  public            System.Int32                    length  // 0x0
  public            System.Byte[]                   arrayBytes  // 0x0
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: SetParallelMultiHashMapJob`2
TYPE:  struct
TOKEN: 0x200022A
FIELDS:
  public            Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>map  // 0x0
  public            Unity.Collections.NativeArray<TKey>keyArray  // 0x0
  public            Unity.Collections.NativeArray<TValue>valueArray  // 0x0
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Import_GenerateTangentJob
TYPE:  struct
TOKEN: 0x2000235
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localNormals  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localTangents  // 0x20
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Import_CalcSkinningJob
TYPE:  struct
TOKEN: 0x2000236
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localNormals  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localTangents  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0x40
  public            Unity.Collections.NativeArray<System.Int32>skinBoneTransformIndices  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float4x4>bindPoses  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformPositionArray  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformRotationArray  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformScaleArray  // 0x90
  public            Unity.Mathematics.float4x4      toM  // 0xA0
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Import_BoneWeightJob1
TYPE:  struct
TOKEN: 0x2000237
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            Unity.Collections.NativeArray<System.Byte>bonesPerVertexArray  // 0x18
  public            Unity.Collections.NativeArray<System.Int32>startBoneWeightIndices  // 0x28
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Import_BoneWeightJob2
TYPE:  struct
TOKEN: 0x2000238
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>startBoneWeightIndices  // 0x10
  public            Unity.Collections.NativeArray<UnityEngine.BoneWeight1>boneWeightArray  // 0x20
  public            Unity.Collections.NativeArray<System.Byte>bonesPerVertexArray  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0x40
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Import_BoneVertexJob
TYPE:  struct
TOKEN: 0x2000239
FIELDS:
  public            Unity.Mathematics.float4x4      WtoL  // 0x10
  public            Unity.Mathematics.float4x4      LtoW  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformPositions  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformRotations  // 0xA0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformScales  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0xC0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localNormals  // 0xD0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localTangents  // 0xE0
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0xF0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float4x4>skinBoneBindPoses  // 0x100
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Select_PackVertexJob
TYPE:  struct
TOKEN: 0x200023A
FIELDS:
  public            System.Int32                    vertexCount  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>newVertexRemapIndices  // 0x18
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localNormals  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localTangents  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float2>uv  // 0x68
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0x78
  public            Unity.Collections.NativeArray<System.Int32>newReferenceIndices  // 0x88
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>newAttributes  // 0x98
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>newLocalPositions  // 0xA8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>newLocalNormals  // 0xB8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>newLocalTangents  // 0xC8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float2>newUv  // 0xD8
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>newBoneWeights  // 0xE8
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Select_GridJob
TYPE:  struct
TOKEN: 0x200023B
FIELDS:
  public            System.Single                   gridSize  // 0x10
  public            Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32>gridMap  // 0x18
  public            System.Int32                    selectionCount  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>selectionPositions  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>selectionAttributes  // 0x40
  public            System.Int32                    vertexCount  // 0x50
  public            System.Int32                    triangleCount  // 0x54
  public            System.Single                   searchRadius  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>meshPositions  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>meshTriangles  // 0x70
  public            Unity.Collections.NativeList<Unity.Mathematics.int3>newTriangles  // 0x80
  public            Unity.Collections.NativeArray<System.Int32>newVertexRemapIndices  // 0x90
  public            Unity.Collections.NativeReference<System.Int32>newVertexCount  // 0xA0
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Add_CalcBindPoseJob
TYPE:  struct
TOKEN: 0x200023C
FIELDS:
  public            System.Int32                    skinBoneOffset  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>srcSkinBoneTransformIndices  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>srcTransformPositionArray  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>srcTransformRotationArray  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>srcTransformScaleArray  // 0x48
  public            Unity.Mathematics.float4x4      dstCenterLocalToWorldMatrix  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float4x4>dstSkinBoneBindPoses  // 0x98
METHODS:
  System.Void Execute(System.Int32 boneIndex)
END_CLASS

CLASS: Add_CopyVerticesJob
TYPE:  struct
TOKEN: 0x200023D
FIELDS:
  public            System.Int32                    vertexOffset  // 0x10
  public            System.Int32                    skinBoneOffset  // 0x14
  public            Unity.Mathematics.float4x4      toM  // 0x18
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>srcAttributes  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>srclocalPositions  // 0x68
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>srclocalNormals  // 0x78
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>srclocalTangents  // 0x88
  public            Unity.Collections.NativeArray<Unity.Mathematics.float2>srcUV  // 0x98
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>srcBoneWeights  // 0xA8
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>dstAttributes  // 0xB8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>dstlocalPositions  // 0xC8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>dstlocalNormals  // 0xD8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>dstlocalTangents  // 0xE8
  public            Unity.Collections.NativeArray<Unity.Mathematics.float2>dstUV  // 0xF8
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>dstBoneWeights  // 0x108
  public            Unity.Collections.NativeArray<System.Int32>dstSkinBoneIndices  // 0x118
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: MappingWorkData
TYPE:  struct
TOKEN: 0x200023E
FIELDS:
  public            Unity.Mathematics.float3        position  // 0x10
  public            System.Int32                    vertexIndex  // 0x1C
  public            System.Int32                    proxyVertexIndex  // 0x20
  public            System.Single                   proxyVertexDistance  // 0x24
METHODS:
END_CLASS

CLASS: Mapping_DirectConnectionVertexDataJob
TYPE:  struct
TOKEN: 0x200023F
FIELDS:
  public            Unity.Mathematics.float4x4      toP  // 0x10
  public            System.Int32                    vcnt  // 0x50
  public            BeyondDynamicBone.DataChunk     mergeChunk  // 0x54
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x60
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x70
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x80
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>proxyAttributes  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>proxyLocalPositions  // 0xA0
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMesh.MappingWorkData>mappingWorkData  // 0xB0
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Mapping_CalcDirectWeightJob
TYPE:  struct
TOKEN: 0x2000240
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            System.Single                   weightLength  // 0x14
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMesh.MappingWorkData>mappingWorkData  // 0x18
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x28
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>proxyLocalPositions  // 0x48
  public            Unity.Collections.NativeArray<System.UInt32>proxyVertexToVertexIndexArray  // 0x58
  public            Unity.Collections.NativeArray<System.UInt16>proxyVertexToVertexDataArray  // 0x68
  public            Unity.Collections.NativeParallelHashSet<System.UInt16>useSet  // 0x78
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Mapping_CalcConnectionVertexDataJob
TYPE:  struct
TOKEN: 0x2000241
FIELDS:
  public            System.Single                   gridSize  // 0x10
  public            System.Single                   searchRadius  // 0x14
  public            Unity.Mathematics.float4x4      toP  // 0x18
  public            System.Int32                    vcnt  // 0x58
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x60
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0x70
  public            Unity.Collections.NativeArray<System.Int32>transformIds  // 0x80
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x90
  public            Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32>gridMap  // 0xA0
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>proxyAttributes  // 0xB0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>proxyLocalPositions  // 0xC0
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>proxyBoneWeights  // 0xD0
  public            Unity.Collections.NativeArray<System.Int32>proxyTransformIds  // 0xE0
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMesh.MappingWorkData>mappingWorkData  // 0xF0
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Mapping_CalcWeightJob
TYPE:  struct
TOKEN: 0x2000242
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMesh.MappingWorkData>mappingWorkData  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>proxyAttributes  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>proxyLocalPositions  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>proxyLocalNormals  // 0x60
  public            Unity.Collections.NativeArray<System.UInt32>proxyVertexToVertexIndexArray  // 0x70
  public            Unity.Collections.NativeArray<System.UInt16>proxyVertexToVertexDataArray  // 0x80
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Optimize_EdgeToTrianlgeJob
TYPE:  struct
TOKEN: 0x2000243
FIELDS:
  public            System.Int32                    tcnt  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>triangles  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x28
  public            Unity.Collections.NativeParallelHashMap<Unity.Mathematics.int2,Unity.Collections.FixedList128Bytes<System.Int32>>edgeToTriangleList  // 0x38
  public            Unity.Collections.NativeList<Unity.Mathematics.int3>newTriangles  // 0x48
  public            Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int4>useQuadSet  // 0x58
  public            Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int3>removeTriangleSet  // 0x68
METHODS:
  System.Void Execute()
END_CLASS

CLASS: ProxyNormalRadiationAdjustmentJob
TYPE:  struct
TOKEN: 0x2000244
FIELDS:
  public            Unity.Mathematics.float3        center  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x20
  public            Unity.Collections.NativeArray<System.Int32>vertexParentIndices  // 0x30
  public            Unity.Collections.NativeArray<System.UInt32>vertexChildIndexArray  // 0x40
  public            Unity.Collections.NativeArray<System.UInt16>vertexChildDataArray  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localNormals  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localTangents  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>normalAdjustmentRotations  // 0x80
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: ProxyCreateFixedListAndAABBJob
TYPE:  struct
TOKEN: 0x2000245
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x28
  public            Unity.Collections.NativeArray<System.UInt32>vertexToVertexIndexArray  // 0x38
  public            Unity.Collections.NativeArray<System.UInt16>vertexToVertexDataArray  // 0x48
  public            Unity.Collections.NativeReference<BeyondDynamicBone.AABB>outAABB  // 0x58
  public            Unity.Collections.NativeList<System.UInt16>fixedList  // 0x68
  public            Unity.Collections.NativeReference<Unity.Mathematics.float3>localCenterPosition  // 0x78
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Proxy_CalcTriangleNormalJob
TYPE:  struct
TOKEN: 0x2000246
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>triangles  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositins  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>triangleNormals  // 0x30
METHODS:
  System.Void Execute(System.Int32 tindex)
END_CLASS

CLASS: Proxy_CalcTriangleTangentJob
TYPE:  struct
TOKEN: 0x2000247
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>triangles  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositins  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float2>uv  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>triangleTangents  // 0x40
METHODS:
  System.Void Execute(System.Int32 tindex)
END_CLASS

CLASS: Proxy_CreateVertexToTrianglesJob
TYPE:  struct
TOKEN: 0x2000248
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>triangles  // 0x10
  public            Unity.Collections.NativeArray<Unity.Collections.FixedList32Bytes<System.UInt32>>vertexToTriangles  // 0x20
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Proxy_OrganizeVertexToTrianglsJob
TYPE:  struct
TOKEN: 0x2000249
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Collections.FixedList32Bytes<System.UInt32>>vertexToTriangles  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>triangleNormals  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>triangleTangents  // 0x30
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x40
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Proxy_CalcVertexNormalTangentFromTriangleJob
TYPE:  struct
TOKEN: 0x200024A
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>triangleNormals  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>triangleTangents  // 0x20
  public            Unity.Collections.NativeArray<Unity.Collections.FixedList32Bytes<System.UInt32>>vertexToTriangles  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localNormals  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localTangents  // 0x50
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Proxy_CalcVertexToTransformJob
TYPE:  struct
TOKEN: 0x200024B
FIELDS:
  public            Unity.Mathematics.quaternion    invRot  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localNormals  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localTangents  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>vertexToTransformRotations  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformRotations  // 0x50
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Proxy_CalcEdgeToTriangleJob
TYPE:  struct
TOKEN: 0x200024C
FIELDS:
  public            System.Int32                    tcnt  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>triangles  // 0x18
  public            Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int2,System.UInt16>edgeToTriangles  // 0x28
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Proxy_CalcVertexBindPoseJob2
TYPE:  struct
TOKEN: 0x200024D
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localNormals  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localTangents  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>vertexBindPosePositions  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>vertexBindPoseRotations  // 0x50
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Proxy_CalcVertexToVertexFromTriangleJob
TYPE:  struct
TOKEN: 0x200024E
FIELDS:
  public            System.Int32                    triangleCount  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>triangles  // 0x18
  public            Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.UInt16>vertexToVertexMap  // 0x28
  public            Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int2>edgeSet  // 0x38
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Proxy_CalcVertexToVertexFromLineJob
TYPE:  struct
TOKEN: 0x200024F
FIELDS:
  public            System.Int32                    lineCount  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.int2>lines  // 0x18
  public            Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.UInt16>vertexToVertexMap  // 0x28
  public            Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int2>edgeSet  // 0x38
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Proxy_CreateEdgeFlagJob
TYPE:  struct
TOKEN: 0x2000250
FIELDS:
  public            Unity.Collections.NativeArray<Unity.Mathematics.int2>edges  // 0x10
  public            Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int2,System.UInt16>edgeToTriangles  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>edgeFlags  // 0x30
METHODS:
  System.Void Execute(System.Int32 eindex)
END_CLASS

CLASS: SkinningBoneInfo
TYPE:  struct
TOKEN: 0x2000251
FIELDS:
  public            System.Int32                    parentTransformIndex  // 0x10
  public            Unity.Mathematics.float3        parentPos  // 0x14
  public            System.Int32                    childTransformIndex  // 0x20
  public            Unity.Mathematics.float3        childPos  // 0x24
METHODS:
END_CLASS

CLASS: Proxy_CalcCustomSkinningWeightsJobV2
TYPE:  struct
TOKEN: 0x2000252
FIELDS:
  public            System.Boolean                  isBoneCloth  // 0x10
  public            System.Single                   angularAttenuation  // 0x14
  public            System.Single                   distanceReduction  // 0x18
  public            System.Single                   distancePow  // 0x1C
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x30
  public            Unity.Collections.NativeList<BeyondDynamicBone.VirtualMesh.SkinningBoneInfo>boneInfoList  // 0x40
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0x50
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Proxy_ApplySelectionJob
TYPE:  struct
TOKEN: 0x2000253
FIELDS:
  public            System.Single                   gridSize  // 0x10
  public            System.Single                   radius  // 0x14
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x18
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x28
  public            Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32>gridMap  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>selectionPositions  // 0x48
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>selectionAttributes  // 0x58
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Proxy_BoneClothApplayTransformFlagJob
TYPE:  struct
TOKEN: 0x2000254
FIELDS:
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>transformFlags  // 0x20
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: BaseLineWork
TYPE:  struct
TOKEN: 0x2000255
FIELDS:
  public            System.Int32                    vindex  // 0x10
  public            System.Single                   dist  // 0x14
METHODS:
  System.Int32 CompareTo(BeyondDynamicBone.VirtualMesh.BaseLineWork other)
END_CLASS

CLASS: BaseLine_Mesh_CreateParentJob2
TYPE:  struct
TOKEN: 0x2000256
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            System.Single                   avgDist  // 0x14
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attribues  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x28
  public            Unity.Collections.NativeArray<System.UInt32>vertexToVertexIndexArray  // 0x38
  public            Unity.Collections.NativeArray<System.UInt16>vertexToVertexDataArray  // 0x48
  public            Unity.Collections.NativeArray<System.Int32>vertexParentIndices  // 0x58
  public            Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.UInt16>vertexChildMap  // 0x68
  public            Unity.Collections.NativeList<System.Int32>fixedList  // 0x78
  public            Unity.Collections.NativeList<BeyondDynamicBone.VirtualMesh.BaseLineWork>nextList  // 0x88
  public            Unity.Collections.NativeArray<System.Byte>markBuff  // 0x98
  public            Unity.Collections.NativeParallelHashMap<System.Int32,BeyondDynamicBone.VirtualMesh.BaseLineWork>vertexMap  // 0xA8
METHODS:
  System.Void Execute()
END_CLASS

CLASS: BaseLine_Mesh_CareteFixedListJob
TYPE:  struct
TOKEN: 0x2000257
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attribues  // 0x18
  public            Unity.Collections.NativeList<System.Int32>fixedList  // 0x28
METHODS:
  System.Void Execute()
END_CLASS

CLASS: BaseLine_Bone_CreateBoneChildInfoJob
TYPE:  struct
TOKEN: 0x2000258
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>parentIndices  // 0x18
  public            Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.UInt16>childMap  // 0x28
METHODS:
  System.Void Execute()
END_CLASS

CLASS: BaseLine_CalcLocalPositionRotationJob
TYPE:  struct
TOKEN: 0x2000259
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>parentIndices  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x20
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localNormals  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localTangents  // 0x40
  public            Unity.Collections.NativeArray<System.UInt16>baseLineIndices  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>vertexLocalPositions  // 0x60
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>vertexLocalRotations  // 0x70
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: BaseLine_CalcMaxBaseLineLengthJob
TYPE:  struct
TOKEN: 0x200025A
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>attribues  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x28
  public            Unity.Collections.NativeArray<System.Int32>vertexParentIndices  // 0x38
  public            Unity.Collections.NativeArray<System.Single>vertexDepths  // 0x48
  public            Unity.Collections.NativeArray<System.Int32>vertexRootIndices  // 0x58
  public            Unity.Collections.NativeArray<System.Single>rootLengthArray  // 0x68
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Reduction_InitVertexToVertexJob2
TYPE:  struct
TOKEN: 0x200025B
FIELDS:
  public            System.Int32                    triangleCount  // 0x10
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>triangles  // 0x18
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>vertexToVertexMap  // 0x28
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Organize_RemapVertexJob
TYPE:  struct
TOKEN: 0x200025C
FIELDS:
  public            System.Int32                    oldVertexCount  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x18
  public            Unity.Collections.NativeArray<System.Int32>vertexRemapIndices  // 0x28
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Organize_CollectUseSkinBoneJob
TYPE:  struct
TOKEN: 0x200025D
FIELDS:
  public            System.Int32                    oldVertexCount  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x18
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>oldBoneWeights  // 0x28
  public            Unity.Collections.NativeArray<Unity.Mathematics.float4x4>oldBindPoses  // 0x38
  public            Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>useSkinBoneMap  // 0x48
  public            Unity.Collections.NativeList<System.Int32>newSkinBoneTransformIndices  // 0x58
  public            Unity.Collections.NativeList<Unity.Mathematics.float4x4>newSkinBoneBindPoses  // 0x68
  public            Unity.Collections.NativeReference<System.Int32>newSkinBoneCount  // 0x78
  public            Unity.Collections.NativeList<System.Int32>useSkinBoneMapKeyList  // 0x88
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Organize_CopyVertexJob
TYPE:  struct
TOKEN: 0x200025E
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>vertexRemapIndices  // 0x20
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>oldAttributes  // 0x30
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldLocalPositions  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldLocalNormals  // 0x50
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>oldLocalTangents  // 0x60
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>newAttributes  // 0x70
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>newLocalPositions  // 0x80
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>newLocalNormals  // 0x90
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>newLocalTangents  // 0xA0
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: Organize_RemapBoneWeightJob
TYPE:  struct
TOKEN: 0x200025F
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>vertexRemapIndices  // 0x20
  public            Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>useSkinBoneMap  // 0x30
  public            Unity.Collections.NativeArray<System.Int32>oldSkinBoneIndices  // 0x40
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>oldBoneWeights  // 0x50
  public            Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>newBoneWeights  // 0x60
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Organize_RemapLinkPointArrayJob
TYPE:  struct
TOKEN: 0x2000260
FIELDS:
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>vertexRemapIndices  // 0x20
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>oldVertexToVertexMap  // 0x30
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>newVertexToVertexMap  // 0x40
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Organize_CreateLineTriangleJob
TYPE:  struct
TOKEN: 0x2000261
FIELDS:
  public            System.Int32                    newVertexCount  // 0x10
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>newVertexToVertexMap  // 0x18
  public            Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int2>edgeSet  // 0x28
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Organize_CreateLineTriangleJob2
TYPE:  struct
TOKEN: 0x2000262
FIELDS:
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>newVertexToVertexMap  // 0x10
  public            Unity.Collections.NativeList<Unity.Mathematics.int2>newLineList  // 0x20
  public            Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int2>edgeSet  // 0x30
  public            Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int3>triangleSet  // 0x40
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Organize_CreateNewTriangleJob3
TYPE:  struct
TOKEN: 0x2000263
FIELDS:
  public            Unity.Collections.NativeList<Unity.Mathematics.int3>newTriangleList  // 0x10
  public            Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int3>triangleSet  // 0x20
METHODS:
  System.Void Execute()
END_CLASS

CLASS: ShareSerializationData
TYPE:  class
TOKEN: 0x2000264
FIELDS:
  public            System.String                   name  // 0x10
  public            BeyondDynamicBone.VirtualMesh.MeshTypemeshType  // 0x18
  public            System.Boolean                  isBoneCloth  // 0x1C
  public            BeyondDynamicBone.ExSimpleNativeArray.SerializationData<System.Int32>referenceIndices  // 0x20
  public            BeyondDynamicBone.ExSimpleNativeArray.SerializationData<BeyondDynamicBone.VertexAttribute>attributes  // 0x28
  public            BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.float3>localPositions  // 0x30
  public            BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.float3>localNormals  // 0x38
  public            BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.float3>localTangents  // 0x40
  public            BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.float2>uv  // 0x48
  public            BeyondDynamicBone.ExSimpleNativeArray.SerializationData<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0x50
  public            BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.int3>triangles  // 0x58
  public            BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.int2>lines  // 0x60
  public            System.Int32                    centerTransformIndex  // 0x68
  public            Unity.Mathematics.float4x4      initLocalToWorld  // 0x6C
  public            Unity.Mathematics.float4x4      initWorldToLocal  // 0xAC
  public            Unity.Mathematics.quaternion    initRotation  // 0xEC
  public            Unity.Mathematics.quaternion    initInverseRotation  // 0xFC
  public            Unity.Mathematics.float3        initScale  // 0x10C
  public            System.Int32                    skinRootIndex  // 0x118
  public            BeyondDynamicBone.ExSimpleNativeArray.SerializationData<System.Int32>skinBoneTransformIndices  // 0x120
  public            BeyondDynamicBone.ExSimpleNativeArray.SerializationData<Unity.Mathematics.float4x4>skinBoneBindPoses  // 0x128
  public            BeyondDynamicBone.TransformData.ShareSerializationDatatransformData  // 0x130
  public            BeyondDynamicBone.AABB          boundingBox  // 0x138
  public            System.Single                   averageVertexDistance  // 0x150
  public            System.Single                   maxVertexDistance  // 0x154
  public            System.Byte[]                   vertexToTriangles  // 0x158
  public            System.Byte[]                   vertexToVertexIndexArray  // 0x160
  public            System.Byte[]                   vertexToVertexDataArray  // 0x168
  public            System.Byte[]                   edges  // 0x170
  public            System.Byte[]                   edgeFlags  // 0x178
  public            Unity.Mathematics.int2[]        edgeToTrianglesKeys  // 0x180
  public            System.UInt16[]                 edgeToTrianglesValues  // 0x188
  public            System.Byte[]                   vertexBindPosePositions  // 0x190
  public            System.Byte[]                   vertexBindPoseRotations  // 0x198
  public            System.Byte[]                   vertexToTransformRotations  // 0x1A0
  public            System.Byte[]                   vertexDepths  // 0x1A8
  public            System.Byte[]                   vertexRootIndices  // 0x1B0
  public            System.Byte[]                   vertexParentIndices  // 0x1B8
  public            System.Byte[]                   vertexChildIndexArray  // 0x1C0
  public            System.Byte[]                   vertexChildDataArray  // 0x1C8
  public            System.Byte[]                   vertexLocalPositions  // 0x1D0
  public            System.Byte[]                   vertexLocalRotations  // 0x1D8
  public            System.Byte[]                   normalAdjustmentRotations  // 0x1E0
  public            System.Byte[]                   baseLineFlags  // 0x1E8
  public            System.Byte[]                   baseLineStartDataIndices  // 0x1F0
  public            System.Byte[]                   baseLineDataCounts  // 0x1F8
  public            System.Byte[]                   baseLineData  // 0x200
  public            System.Int32[]                  customSkinningBoneIndices  // 0x208
  public            System.UInt16[]                 centerFixedList  // 0x210
  public            Unity.Mathematics.float3        localCenterPosition  // 0x218
  public            Unity.Mathematics.float3        centerWorldPosition  // 0x224
  public            Unity.Mathematics.quaternion    centerWorldRotation  // 0x230
  public            Unity.Mathematics.float3        centerWorldScale  // 0x240
  public            Unity.Mathematics.float4x4      toProxyMatrix  // 0x24C
  public            Unity.Mathematics.quaternion    toProxyRotation  // 0x28C
METHODS:
  System.String ToString()
  System.Void .ctor()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: UniqueSerializationData
TYPE:  class
TOKEN: 0x2000265
FIELDS:
  public            BeyondDynamicBone.TransformData.UniqueSerializationDatatransformData  // 0x10
METHODS:
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
  System.Void .ctor()
END_CLASS

CLASS: Work_AverageTriangleDistanceJob
TYPE:  struct
TOKEN: 0x2000266
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            System.Int32                    tcnt  // 0x14
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>triangles  // 0x28
  public            Unity.Collections.NativeReference<System.Single>averageVertexDistance  // 0x38
  public            Unity.Collections.NativeReference<System.Int32>averageCount  // 0x48
  public            Unity.Collections.NativeReference<System.Single>maxVertexDistance  // 0x58
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Work_AverageLineDistanceJob
TYPE:  struct
TOKEN: 0x2000267
FIELDS:
  public            System.Int32                    vcnt  // 0x10
  public            System.Int32                    lcnt  // 0x14
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x18
  public            Unity.Collections.NativeArray<Unity.Mathematics.int2>lines  // 0x28
  public            Unity.Collections.NativeReference<System.Single>averageVertexDistance  // 0x38
  public            Unity.Collections.NativeReference<System.Int32>averageCount  // 0x48
  public            Unity.Collections.NativeReference<System.Single>maxVertexDistance  // 0x58
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Work_AddVertexIndexGirdMapJob
TYPE:  struct
TOKEN: 0x2000268
FIELDS:
  public            System.Single                   gridSize  // 0x10
  public            System.Int32                    vcnt  // 0x14
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>positins  // 0x18
  public            Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,System.Int32>gridMap  // 0x28
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Work_IntersectTriangleJob
TYPE:  struct
TOKEN: 0x2000269
FIELDS:
  public            Unity.Mathematics.float3        localRayPos  // 0x10
  public            Unity.Mathematics.float3        localRayDir  // 0x1C
  public            Unity.Mathematics.float3        localRayEndPos  // 0x28
  public            System.Boolean                  doubleSide  // 0x34
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x38
  public            Unity.Collections.NativeArray<Unity.Mathematics.int3>triangles  // 0x48
  public            Unity.Collections.NativeList.ParallelWriter<BeyondDynamicBone.VirtualMeshRaycastHit>hitList  // 0x58
METHODS:
  System.Void Execute(System.Int32 tindex)
END_CLASS

CLASS: Work_IntersectEdgeJob
TYPE:  struct
TOKEN: 0x200026A
FIELDS:
  public            Unity.Mathematics.float3        localRayPos  // 0x10
  public            Unity.Mathematics.float3        localRayDir  // 0x1C
  public            Unity.Mathematics.float3        localRayEndPos  // 0x28
  public            Unity.Mathematics.float3        rayDir  // 0x34
  public            System.Single                   localEdgeRadius  // 0x40
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x48
  public            Unity.Collections.NativeArray<Unity.Mathematics.int2>edges  // 0x58
  public            Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int2,System.UInt16>edgeToTriangles  // 0x68
  public            Unity.Collections.NativeList.ParallelWriter<BeyondDynamicBone.VirtualMeshRaycastHit>hitList  // 0x78
METHODS:
  System.Void Execute(System.Int32 eindex)
END_CLASS

CLASS: Work_IntersectPointJob
TYPE:  struct
TOKEN: 0x200026B
FIELDS:
  public            Unity.Mathematics.float3        localRayPos  // 0x10
  public            Unity.Mathematics.float3        localRayDir  // 0x1C
  public            Unity.Mathematics.float3        rayDir  // 0x28
  public            System.Single                   localPointRadius  // 0x34
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>localPositions  // 0x38
  public            Unity.Collections.NativeArray<Unity.Collections.FixedList32Bytes<System.Int32>>vertexToTriangles  // 0x48
  public            Unity.Collections.NativeList.ParallelWriter<BeyondDynamicBone.VirtualMeshRaycastHit>hitList  // 0x58
METHODS:
  System.Void Execute(System.Int32 vindex)
END_CLASS

CLASS: Work_IntersetcSortJob
TYPE:  struct
TOKEN: 0x200026C
FIELDS:
  public            Unity.Collections.NativeList<BeyondDynamicBone.VirtualMeshRaycastHit>hitList  // 0x10
METHODS:
  System.Void Execute()
END_CLASS

CLASS: MeshType
TYPE:  struct
TOKEN: 0x200026D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.VirtualMesh.MeshTypeNormalMesh  // 0x0
  public    static  BeyondDynamicBone.VirtualMesh.MeshTypeNormalBoneMesh  // 0x0
  public    static  BeyondDynamicBone.VirtualMesh.MeshTypeProxyMesh  // 0x0
  public    static  BeyondDynamicBone.VirtualMesh.MeshTypeProxyBoneMesh  // 0x0
  public    static  BeyondDynamicBone.VirtualMesh.MeshTypeMapping  // 0x0
METHODS:
END_CLASS

CLASS: __JobReflectionRegistrationOutput__496319927
TYPE:  class
TOKEN: 0x2000274
FIELDS:
METHODS:
  System.Void CreateJobReflectionData()
  System.Void EarlyInit()
END_CLASS

CLASS: $BurstDirectCallInitializer
TYPE:  class
TOKEN: 0x2000275
FIELDS:
METHODS:
  System.Void Initialize()
END_CLASS

CLASS: BeyondDynamicBone.BeyondBoneCloth
TYPE:  class
TOKEN: 0x2000004
EXTENDS: ClothBehaviour
FIELDS:
  public            System.Int32                    clothAnimatorAbilityLODThresholdProperty  // 0x20
  private           System.Int32                    _clothAnimatorAbilityLODThresholdProperty  // 0x24
  public            System.Int32                    clothAnimatorLODThresholdProperty  // 0x28
  private           System.Int32                    _clothAnimatorLODThresholdProperty  // 0x2C
  public            System.Single                   clothLODFadeTimeProperty  // 0x30
  private           System.Single                   _clothLODFadeTimeProperty  // 0x34
  public            System.Single                   animationPoseRatioProperty  // 0x38
  private           System.Single                   _animationPoseRatioProperty  // 0x3C
  public            System.Single                   clothSimulateWeightProperty  // 0x40
  private           System.Single                   _clothSimulateWeightProperty  // 0x44
  public            System.Single                   gravityProperty  // 0x48
  private           System.Single                   _gravityProperty  // 0x4C
  public            System.Single                   dampingProperty  // 0x50
  private           System.Single                   _dampingProperty  // 0x54
  public            System.Single                   worldInertiaProperty  // 0x58
  private           System.Single                   _worldInertiaProperty  // 0x5C
  public            System.Single                   localInertiaProperty  // 0x60
  private           System.Single                   _localInertiaProperty  // 0x64
  public            System.Single                   windInfluenceProperty  // 0x68
  private           System.Single                   _windInfluenceProperty  // 0x6C
  public            System.Single                   blendWeightProperty  // 0x70
  private           System.Single                   _blendWeightProperty  // 0x74
  private           System.Boolean                  <bUseRelativeTransform>k__BackingField  // 0x78
  public            Unity.Mathematics.float3        relativeTransformPos  // 0x7C
  public            Unity.Mathematics.quaternion    relativeTransformRot  // 0x88
  private           BeyondDynamicBone.ClothSerializeDataserializeData  // 0x98
  private           BeyondDynamicBone.ClothSerializeData2serializeData2  // 0xA0
  private           BeyondDynamicBone.ClothProcess  process  // 0xA8
  public            System.Action<System.Boolean>   OnBuildComplete  // 0xB0
METHODS:
  System.Void InitAnimationProperty()
  System.Void OnDidApplyAnimationProperties()
  System.Boolean get_bUseRelativeTransform()
  System.Void set_bUseRelativeTransform(System.Boolean value)
  System.Void SetRelativeTransform(System.Boolean useRelativeTransform, Unity.Mathematics.float3 newPos, Unity.Mathematics.quaternion newRot)
  BeyondDynamicBone.ClothSerializeData get_SerializeData()
  System.Void set_SerializeData(BeyondDynamicBone.ClothSerializeData value)
  BeyondDynamicBone.ClothProcess get_Process()
  UnityEngine.Transform get_ClothTransform()
  BeyondDynamicBone.BeyondBoneCloth get_SyncPartnerCloth()
  System.Boolean IsValid()
  System.Void Reset()
  System.Void OnValidate()
  System.Void Awake()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void Start()
  System.Void OnDestroy()
  System.Int32 GetMagicaHashCode()
  BeyondDynamicBone.ClothSerializeData2 GetSerializeData2()
  System.Void Initialize()
  System.Void DisableAutoBuild()
  System.Void SetClothSimulateWeight(System.Single weight)
  System.Void SetClothSimulateWeightIgnorePlaying(System.Single weight)
  System.Void SetClothStablizationTimeAfterResetIgnorePlaying(System.Single time)
  System.Void SetAnimationPoseRatio(System.Single ratio)
  System.Void SetCodeParamaterDirty()
  System.Void SetCodeParamaterDirtyIgnorePlaying()
  System.Boolean BuildAndRun()
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.String,UnityEngine.Transform> targetTransformDict)
  System.Void SetParameterChange()
  System.Void SetTimeScale(System.Single timeScale)
  System.Single GetTimeScale()
  System.Void ResetCloth(System.Boolean keepPose)
  System.Void SoftResetCloth(System.Boolean keepPose)
  UnityEngine.Vector3 GetCenterPosition()
  System.Void AddForce(UnityEngine.Vector3 forceDirection, System.Single forceVelocity, BeyondDynamicBone.ClothForceMode fmode)
  System.Void SetSkipWriting(System.Boolean sw)
  System.Void .ctor()
  System.Int32 <>iFixBaseProxy_GetMagicaHashCode()
END_CLASS

CLASS: BeyondDynamicBone.CheckSliderSerializeData
TYPE:  class
TOKEN: 0x2000005
FIELDS:
  public            System.Single                   value  // 0x10
  public            System.Boolean                  use  // 0x14
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Boolean use, System.Single value)
  System.Single GetValue(System.Single unusedValue)
  System.Void SetValue(System.Boolean use, System.Single value)
  System.Void DataValidate(System.Single min, System.Single max)
  BeyondDynamicBone.CheckSliderSerializeData Clone()
END_CLASS

CLASS: BeyondDynamicBone.ClothBehaviour
TYPE:  class
TOKEN: 0x2000006
EXTENDS: MonoBehaviour
FIELDS:
  private           System.Boolean                  <IsGizmoVisible>k__BackingField  // 0x18
METHODS:
  System.Int32 GetMagicaHashCode()
  System.Boolean get_IsGizmoVisible()
  System.Void set_IsGizmoVisible(System.Boolean value)
  System.Void OnDrawGizmos()
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.ClothForceMode
TYPE:  struct
TOKEN: 0x2000007
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.ClothForceModeNone  // 0x0
  public    static  BeyondDynamicBone.ClothForceModeVelocityAdd  // 0x0
  public    static  BeyondDynamicBone.ClothForceModeVelocityChange  // 0x0
  public    static  BeyondDynamicBone.ClothForceModeVelocityAddWithoutDepth  // 0x0
  public    static  BeyondDynamicBone.ClothForceModeVelocityChangeWithoutDepth  // 0x0
METHODS:
END_CLASS

CLASS: BeyondDynamicBone.ClothMeshWriteMode
TYPE:  struct
TOKEN: 0x2000008
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.ClothMeshWriteModePositionAndNormal  // 0x0
  public    static  BeyondDynamicBone.ClothMeshWriteModePositionAndNormalTangent  // 0x0
METHODS:
END_CLASS

CLASS: BeyondDynamicBone.ClothNormalAxis
TYPE:  struct
TOKEN: 0x2000009
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.ClothNormalAxisRight  // 0x0
  public    static  BeyondDynamicBone.ClothNormalAxisUp  // 0x0
  public    static  BeyondDynamicBone.ClothNormalAxisForward  // 0x0
  public    static  BeyondDynamicBone.ClothNormalAxisInverseRight  // 0x0
  public    static  BeyondDynamicBone.ClothNormalAxisInverseUp  // 0x0
  public    static  BeyondDynamicBone.ClothNormalAxisInverseForward  // 0x0
METHODS:
END_CLASS

CLASS: BeyondDynamicBone.ClothParameters
TYPE:  struct
TOKEN: 0x200000A
FIELDS:
  public            System.Single                   gravity  // 0x10
  public            Unity.Mathematics.float3        worldGravityDirection  // 0x14
  public            System.Single                   gravityFalloff  // 0x20
  public            System.Single                   stablizationTimeAfterReset  // 0x24
  public            System.Single                   blendWeight  // 0x28
  public            Unity.Mathematics.float4x4      dampingCurveData  // 0x2C
  public            Unity.Mathematics.float4x4      radiusCurveData  // 0x6C
  public            BeyondDynamicBone.ClothNormalAxisnormalAxis  // 0xAC
  public            System.Single                   rotationalInterpolation  // 0xB0
  public            System.Single                   rootRotation  // 0xB4
  public            BeyondDynamicBone.CullingSettings.CullingParamsculling  // 0xB8
  public            BeyondDynamicBone.InertiaConstraint.InertiaConstraintParamsinertiaConstraint  // 0xC4
  public            BeyondDynamicBone.TetherConstraint.TetherConstraintParamstetherConstraint  // 0xFC
  public            BeyondDynamicBone.DistanceConstraint.DistanceConstraintParamsdistanceConstraint  // 0x104
  public            BeyondDynamicBone.TriangleBendingConstraint.TriangleBendingConstraintParamstriangleBendingConstraint  // 0x148
  public            BeyondDynamicBone.AngleConstraint.AngleConstraintParamsangleConstraint  // 0x150
  public            BeyondDynamicBone.MotionConstraint.MotionConstraintParamsmotionConstraint  // 0x1E4
  public            BeyondDynamicBone.ColliderCollisionConstraint.ColliderCollisionConstraintParamscolliderCollisionConstraint  // 0x274
  public            BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionConstraintParamsselfCollisionConstraint  // 0x2C0
  public            BeyondDynamicBone.WindParams    wind  // 0x30C
  public            BeyondDynamicBone.SpringConstraint.SpringConstraintParamsspringConstraint  // 0x328
METHODS:
END_CLASS

CLASS: BeyondDynamicBone.ClothProcess
TYPE:  class
TOKEN: 0x200000B
FIELDS:
  private   static readonly Unity.Profiling.ProfilerMarker  initProfiler  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  preBuildProfiler  // 0x8
  private   static readonly Unity.Profiling.ProfilerMarker  preBuildDeserializationProfiler  // 0x10
  private   static readonly Unity.Profiling.ProfilerMarker  preBuildRegistrationProfiler  // 0x18
  private           BeyondDynamicBone.BeyondBoneCloth<cloth>k__BackingField  // 0x10
  private           BeyondDynamicBone.BeyondBoneCloth<SyncTopCloth>k__BackingField  // 0x18
  public    static  System.Int32                    State_Valid  // 0x0
  public    static  System.Int32                    State_Enable  // 0x0
  public    static  System.Int32                    State_InitSuccess  // 0x0
  public    static  System.Int32                    State_InitComplete  // 0x0
  public    static  System.Int32                    State_Build  // 0x0
  public    static  System.Int32                    State_Running  // 0x0
  public    static  System.Int32                    State_DisableAutoBuild  // 0x0
  public    static  System.Int32                    State_CameraCullingInvisible  // 0x0
  public    static  System.Int32                    State_CameraCullingKeep  // 0x0
  public    static  System.Int32                    State_SkipWriting  // 0x0
  public    static  System.Int32                    State_UsePreBuild  // 0x0
  public    static  System.Int32                    State_DistanceCullingInvisible  // 0x0
  public    static  System.Int32                    State_UpdateTangent  // 0x0
  public    static  System.Int32                    State_Component  // 0x0
  public    static  System.Int32                    State_Verification  // 0x0
  public    static  System.Int32                    State_LOD_Culled  // 0x0
  private           Unity.Collections.BitField32    stateFlag  // 0x20
  private           BeyondDynamicBone.TransformRecord<clothTransformRecord>k__BackingField  // 0x28
  private           System.Collections.Generic.List<System.Int32>renderHandleList  // 0x30
  private           BeyondDynamicBone.RenderSetupDataboneClothSetupData  // 0x38
  private           System.Collections.Generic.List<BeyondDynamicBone.ClothProcess.RenderMeshInfo>renderMeshInfoList  // 0x40
  private           System.Collections.Generic.List<BeyondDynamicBone.TransformRecord>customSkinningBoneRecords  // 0x48
  private           BeyondDynamicBone.TransformRecord<normalAdjustmentTransformRecord>k__BackingField  // 0x50
  private           BeyondDynamicBone.ResultCode    result  // 0x58
  private           BeyondDynamicBone.ClothProcess.ClothType<clothType>k__BackingField  // 0x60
  private           BeyondDynamicBone.ReductionSettingsreductionSettings  // 0x68
  private           BeyondDynamicBone.ClothParameters<parameters>k__BackingField  // 0x70
  private           BeyondDynamicBone.VirtualMeshContainer<ProxyMeshContainer>k__BackingField  // 0x398
  private           System.Collections.Generic.List<BeyondDynamicBone.ColliderComponent>colliderList  // 0x3A0
  private           System.Int32                    <TeamId>k__BackingField  // 0x3A8
  private           BeyondDynamicBone.InertiaConstraint.ConstraintDatainertiaConstraintData  // 0x3B0
  private           BeyondDynamicBone.DistanceConstraint.ConstraintDatadistanceConstraintData  // 0x3B8
  private           BeyondDynamicBone.TriangleBendingConstraint.ConstraintDatabendingConstraintData  // 0x3C0
  private           UnityEngine.Animator            interlockingAnimator  // 0x3C8
  private           System.Collections.Generic.List<UnityEngine.Renderer>interlockingAnimatorRenderers  // 0x3D0
  private           System.Int32                    anchorTransformId  // 0x3D8
  private           System.Int32                    distanceReferenceObjectId  // 0x3DC
  private           UnityEngine.Animator            cameraCullingAnimator  // 0x3E0
  private           System.Collections.Generic.List<UnityEngine.Renderer>cameraCullingRenderers  // 0x3E8
  private           BeyondDynamicBone.CullingSettings.CameraCullingModecameraCullingMode  // 0x3F0
  private           System.Boolean                  cameraCullingOldInvisible  // 0x3F4
  private           System.Threading.CancellationTokenSourcects  // 0x3F8
  private           System.Object                   lockObject  // 0x400
  private           System.Boolean                  isDestory  // 0x408
  private           System.Boolean                  isDestoryInternal  // 0x409
  private           System.Boolean                  isBuild  // 0x40A
METHODS:
  System.Void Init()
  System.Int32 AddRenderer(UnityEngine.Renderer ren, BeyondDynamicBone.RenderSetupData referenceSetupData, BeyondDynamicBone.RenderSetupData.UniqueSerializationData referenceUniqueSetupData)
  System.Void CreateBoneRenderSetupData(BeyondDynamicBone.ClothProcess.ClothType ctype, System.Collections.Generic.List<UnityEngine.Transform> rootTransforms, System.Collections.Generic.List<UnityEngine.Transform> ignoreFromRootBones, System.Collections.Generic.List<UnityEngine.Transform> collisionBones, BeyondDynamicBone.RenderSetupData.BoneConnectionMode connectionMode)
  System.Void StartUse()
  System.Void EndUse()
  System.Void UpdateUse()
  System.Void DataUpdate()
  System.Boolean StartRuntimeBuild()
  System.Boolean AutoBuild()
  System.Threading.Tasks.Task RuntimeBuildAsync(System.Threading.CancellationToken ct)
  BeyondDynamicBone.ResultCode GenerateSelectionDataFromPaintMap(BeyondDynamicBone.TransformRecord clothTransformRecord, BeyondDynamicBone.VirtualMesh renderMesh, BeyondDynamicBone.ClothProcess.PaintMapData paintMapData, BeyondDynamicBone.SelectionData& selectionData)
  BeyondDynamicBone.ResultCode GeneratePaintMapDataList(System.Collections.Generic.List<BeyondDynamicBone.ClothProcess.PaintMapData> dataList)
  BeyondDynamicBone.ResultCode GenerateSelectionDataFromVertexAttributeData(BeyondDynamicBone.TransformRecord clothTransformRecord, BeyondDynamicBone.VirtualMesh renderMesh, BeyondDynamicBone.VertexAttribute[] vertexAttributeArray, BeyondDynamicBone.SelectionData& selectionData)
  System.Boolean PreBuildDataConstruction()
  System.Int32 GetColliderIndex(BeyondDynamicBone.ColliderComponent col)
  System.Void UpdateCullingAnimatorAndRenderers()
  System.Void UpdateRendererUse()
  BeyondDynamicBone.BeyondBoneCloth get_cloth()
  System.Void set_cloth(BeyondDynamicBone.BeyondBoneCloth value)
  BeyondDynamicBone.BeyondBoneCloth get_SyncTopCloth()
  System.Void set_SyncTopCloth(BeyondDynamicBone.BeyondBoneCloth value)
  BeyondDynamicBone.TransformRecord get_clothTransformRecord()
  System.Void set_clothTransformRecord(BeyondDynamicBone.TransformRecord value)
  BeyondDynamicBone.TransformRecord get_normalAdjustmentTransformRecord()
  System.Void set_normalAdjustmentTransformRecord(BeyondDynamicBone.TransformRecord value)
  BeyondDynamicBone.ResultCode get_Result()
  BeyondDynamicBone.ClothProcess.ClothType get_clothType()
  System.Void set_clothType(BeyondDynamicBone.ClothProcess.ClothType value)
  BeyondDynamicBone.ClothParameters get_parameters()
  System.Void set_parameters(BeyondDynamicBone.ClothParameters value)
  BeyondDynamicBone.VirtualMeshContainer get_ProxyMeshContainer()
  System.Void set_ProxyMeshContainer(BeyondDynamicBone.VirtualMeshContainer value)
  System.Int32 get_ColliderCapacity()
  System.Int32 get_TeamId()
  System.Void set_TeamId(System.Int32 value)
  Unity.Collections.BitField32 GetStateFlag()
  System.Boolean IsState(System.Int32 state)
  System.Void SetState(System.Int32 state, System.Boolean sw)
  System.Boolean IsValid()
  System.Boolean IsRunning()
  System.Boolean IsCameraCullingInvisible()
  System.Boolean IsLodCulled()
  System.Boolean IsCameraCullingKeep()
  System.Boolean IsDistanceCullingInvisible()
  System.Boolean IsSkipWriting()
  System.Boolean IsUpdateTangent()
  System.Boolean get_IsEnable()
  System.Boolean get_HasProxyMesh()
  System.String get_Name()
  System.Void .ctor()
  System.Void Dispose()
  System.Void DisposeInternal()
  System.Void IncrementSuspendCounter()
  System.Void DecrementSuspendCounter()
  System.Int32 GetSuspendCounter()
  BeyondDynamicBone.ClothProcess.RenderMeshInfo GetRenderMeshInfo(System.Int32 index)
  System.Void SyncParameters()
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
  System.Void SetSkipWriting(System.Boolean sw)
  BeyondDynamicBone.ClothUpdateMode GetClothUpdateMode()
  BeyondDynamicBone.ResultCode GenerateStatusCheck()
  System.Boolean GenerateInitialization()
  System.Boolean GenerateBoneClothSelection()
  System.Void .cctor()
END_CLASS

CLASS: BeyondDynamicBone.ClothSerializeData
TYPE:  class
TOKEN: 0x2000016
FIELDS:
  public            BeyondDynamicBone.ClothProcess.ClothTypeclothType  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Renderer>sourceRenderers  // 0x18
  public            BeyondDynamicBone.ClothMeshWriteModemeshWriteMode  // 0x20
  public            BeyondDynamicBone.ClothSerializeData.PaintModepaintMode  // 0x24
  public            System.Collections.Generic.List<UnityEngine.Texture2D>paintMaps  // 0x28
  public            System.Collections.Generic.List<UnityEngine.Transform>rootBones  // 0x30
  public            System.Collections.Generic.List<UnityEngine.Transform>ignoreFromRootBones  // 0x38
  public            BeyondDynamicBone.RenderSetupData.BoneConnectionModeconnectionMode  // 0x40
  public            System.Single                   rotationalInterpolation  // 0x44
  public            System.Single                   rootRotation  // 0x48
  public            BeyondDynamicBone.ClothUpdateModeupdateMode  // 0x4C
  public            BeyondDynamicBone.ClothSerializeData.AnimatorAbilityLevelclothAnimatorAbilityLODThreshold  // 0x50
  public            System.Int32                    clothAnimatorLODThreshold  // 0x54
  public            System.Single                   clothLodFadeTime  // 0x58
  public            System.Single                   clothSimulateWeight  // 0x5C
  public            System.Single                   animationPoseRatio  // 0x60
  public            BeyondDynamicBone.ReductionSettingsreductionSetting  // 0x68
  public            BeyondDynamicBone.CustomSkinningSettingscustomSkinningSetting  // 0x70
  public            BeyondDynamicBone.NormalAlignmentSettingsnormalAlignmentSetting  // 0x78
  public            BeyondDynamicBone.CullingSettingscullingSettings  // 0x80
  public            BeyondDynamicBone.ClothNormalAxisnormalAxis  // 0x88
  public            System.Single                   gravity  // 0x8C
  public            Unity.Mathematics.float3        gravityDirection  // 0x90
  public            System.Single                   gravityFalloff  // 0x9C
  public            System.Single                   stablizationTimeAfterReset  // 0xA0
  public            System.Single                   blendWeight  // 0xA4
  public            BeyondDynamicBone.CurveSerializeDatadamping  // 0xA8
  public            BeyondDynamicBone.CurveSerializeDataradius  // 0xB0
  public            BeyondDynamicBone.InertiaConstraint.SerializeDatainertiaConstraint  // 0xB8
  public            BeyondDynamicBone.TetherConstraint.SerializeDatatetherConstraint  // 0xC0
  public            BeyondDynamicBone.DistanceConstraint.SerializeDatadistanceConstraint  // 0xC8
  public            BeyondDynamicBone.TriangleBendingConstraint.SerializeDatatriangleBendingConstraint  // 0xD0
  public            BeyondDynamicBone.AngleConstraint.RestorationSerializeDataangleRestorationConstraint  // 0xD8
  public            BeyondDynamicBone.AngleConstraint.LimitSerializeDataangleLimitConstraint  // 0xE0
  public            BeyondDynamicBone.MotionConstraint.SerializeDatamotionConstraint  // 0xE8
  public            BeyondDynamicBone.ColliderCollisionConstraint.SerializeDatacolliderCollisionConstraint  // 0xF0
  public            BeyondDynamicBone.SelfCollisionConstraint.SerializeDataselfCollisionConstraint  // 0xF8
  public            BeyondDynamicBone.WindSettings  wind  // 0x100
  public            BeyondDynamicBone.SpringConstraint.SerializeDataspringConstraint  // 0x108
  private           BeyondDynamicBone.ResultCode    verificationResult  // 0x110
METHODS:
  BeyondDynamicBone.Define.Result get_VerificationResult()
  System.Void .ctor()
  System.Boolean IsValid()
  System.Void DataValidate()
  System.Int32 GetHashCode()
  BeyondDynamicBone.ClothParameters GetClothParameters()
  System.String ExportJson()
  System.Boolean ImportJson(System.String json)
  System.Void Import(BeyondDynamicBone.ClothSerializeData sdata, System.Boolean deepCopy)
  System.Void Import(BeyondDynamicBone.BeyondBoneCloth src, System.Boolean deepCopy)
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
  System.Boolean IsBoneSpring()
  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: BeyondDynamicBone.ClothSerializeData2
TYPE:  class
TOKEN: 0x200001B
FIELDS:
  public            BeyondDynamicBone.SelectionData selectionData  // 0x10
  public            System.Collections.Generic.Dictionary<UnityEngine.Transform,BeyondDynamicBone.VertexAttribute>boneAttributeDict  // 0x18
  public            System.Collections.Generic.List<BeyondDynamicBone.VertexAttribute[]>vertexAttributeList  // 0x20
  public            BeyondDynamicBone.PreBuildSerializeDatapreBuildData  // 0x28
METHODS:
  System.Void .ctor()
  System.Boolean IsValid()
  System.Void DataValidate()
  System.Int32 GetHashCode()
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: BeyondDynamicBone.ClothUpdateMode
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.ClothUpdateModeNormal  // 0x0
  public    static  BeyondDynamicBone.ClothUpdateModeUnityPhysics  // 0x0
  public    static  BeyondDynamicBone.ClothUpdateModeUnscaled  // 0x0
  public    static  BeyondDynamicBone.ClothUpdateModeAnimatorLinkage  // 0x0
METHODS:
END_CLASS

CLASS: BeyondDynamicBone.BeyondBoneCapsuleCollider
TYPE:  class
TOKEN: 0x200001D
EXTENDS: ColliderComponent
FIELDS:
  public            BeyondDynamicBone.BeyondBoneCapsuleCollider.Directiondirection  // 0x40
  public            System.Boolean                  reverseDirection  // 0x44
  public            System.Boolean                  radiusSeparation  // 0x45
  public            System.Boolean                  alignedOnCenter  // 0x46
METHODS:
  BeyondDynamicBone.ColliderManager.ColliderType GetColliderType()
  System.Void SetSize(System.Single startRadius, System.Single endRadius, System.Single length)
  UnityEngine.Vector3 GetSize()
  UnityEngine.Vector3 GetLocalDir()
  UnityEngine.Vector3 GetLocalUp()
  System.Boolean IsReverseDirection()
  System.Void DataValidate()
  System.Void .ctor()
  UnityEngine.Vector3 <>iFixBaseProxy_GetSize()
  System.Boolean <>iFixBaseProxy_IsReverseDirection()
END_CLASS

CLASS: BeyondDynamicBone.BeyondBonePlaneCollider
TYPE:  class
TOKEN: 0x200001F
EXTENDS: ColliderComponent
FIELDS:
METHODS:
  BeyondDynamicBone.ColliderManager.ColliderType GetColliderType()
  System.Void DataValidate()
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.BeyondBoneSphereCollider
TYPE:  class
TOKEN: 0x2000020
EXTENDS: ColliderComponent
FIELDS:
METHODS:
  BeyondDynamicBone.ColliderManager.ColliderType GetColliderType()
  System.Void DataValidate()
  System.Void SetSize(System.Single radius)
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.ColliderComponent
TYPE:  class
TOKEN: 0x2000021
EXTENDS: ClothBehaviour
FIELDS:
  public            UnityEngine.Vector3             center  // 0x20
  protected         UnityEngine.Vector3             size  // 0x2C
  private           System.Collections.Generic.HashSet<System.Int32>teamIdSet  // 0x38
METHODS:
  BeyondDynamicBone.ColliderManager.ColliderType GetColliderType()
  System.Void DataValidate()
  UnityEngine.Vector3 GetSize()
  System.Void SetSize(UnityEngine.Vector3 size)
  System.Void SetSizeX(System.Single size)
  System.Void SetSizeY(System.Single size)
  System.Void SetSizeZ(System.Single size)
  System.Single GetScale()
  System.Boolean IsReverseDirection()
  System.Void Register(System.Int32 teamId)
  System.Void Exit(System.Int32 teamId)
  System.Void UpdateParameters()
  System.Void Start()
  System.Void OnValidate()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.AngleConstraintKernel_000000C4$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000023
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.AngleConstraintKernel_000000C4$BurstDirectCall
TYPE:  class
TOKEN: 0x2000024
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32 index)
END_CLASS

CLASS: BeyondDynamicBone.AngleConstraintRangeKernel_000000C5$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000025
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.AngleConstraintRangeKernel_000000C5$BurstDirectCall
TYPE:  class
TOKEN: 0x2000026
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32* lengthPtr)
END_CLASS

CLASS: BeyondDynamicBone.AngleConstraintJobKernels
TYPE:  class
TOKEN: 0x2000022
FIELDS:
METHODS:
  System.Void AngleConstraintKernel(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32 index)
  System.Void AngleConstraintRangeKernel(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32* lengthPtr)
  System.Void AngleConstraintKernel$BurstManaged(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32 index)
  System.Void AngleConstraintRangeKernel$BurstManaged(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepBaseLineIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexParentIndices, System.UInt16* baseLineStartDataIndices, System.UInt16* baseLineDataCounts, System.UInt16* baseLineData, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, Unity.Mathematics.quaternion* stepBasicRotationBuffer, System.Single* lengthBufferArray, Unity.Mathematics.float3* localPosBufferArray, Unity.Mathematics.quaternion* localRotBufferArray, Unity.Mathematics.quaternion* rotationBufferArray, Unity.Mathematics.float3* restorationVectorBufferArray, System.Int32* lengthPtr)
END_CLASS

CLASS: BeyondDynamicBone.AngleConstraint
TYPE:  class
TOKEN: 0x2000027
FIELDS:
  private           Unity.Collections.NativeArray<System.Single>lengthBuffer  // 0x10
  private           Unity.Collections.NativeArray<Unity.Mathematics.float3>localPosBuffer  // 0x20
  private           Unity.Collections.NativeArray<Unity.Mathematics.quaternion>localRotBuffer  // 0x30
  private           Unity.Collections.NativeArray<Unity.Mathematics.quaternion>rotationBuffer  // 0x40
  private           Unity.Collections.NativeArray<Unity.Mathematics.float3>restorationVectorBuffer  // 0x50
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Void WorkBufferUpdate()
  System.String ToString()
  Unity.Jobs.JobHandle SolverConstraint(Unity.Jobs.JobHandle jobHandle)
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.ColliderCollisionConstraint
TYPE:  class
TOKEN: 0x200002C
FIELDS:
  private           Unity.Collections.NativeArray<System.Int32>tempFrictionArray  // 0x10
  private           Unity.Collections.NativeArray<System.Int32>tempNormalArray  // 0x20
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.Void WorkBufferUpdate()
  System.String ToString()
  Unity.Jobs.JobHandle SolverConstraint(Unity.Jobs.JobHandle jobHandle)
  System.Void Initialize$PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintKernel_000000DB$BurstDirectCall()
  System.Void Initialize$PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintRangeKernel_000000DC$BurstDirectCall()
  System.Void Initialize$EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintKernel_000000E0$BurstDirectCall()
  System.Void Initialize$EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintRangeKernel_000000E1$BurstDirectCall()
  System.Void Initialize$SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearKernel_000000E5$BurstDirectCall()
  System.Void Initialize$SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearRangeKernel_000000E6$BurstDirectCall()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.DistanceConstraintKernel_00000101$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000043
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.DistanceConstraintKernel_00000101$BurstDirectCall
TYPE:  class
TOKEN: 0x2000044
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32 index)
END_CLASS

CLASS: BeyondDynamicBone.DistanceConstraintRangeKernel_00000102$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000045
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.DistanceConstraintRangeKernel_00000102$BurstDirectCall
TYPE:  class
TOKEN: 0x2000046
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32* lengthPtr)
END_CLASS

CLASS: BeyondDynamicBone.DistanceConstraintJobKernels
TYPE:  class
TOKEN: 0x2000042
FIELDS:
METHODS:
  System.Void DistanceConstraintKernel(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32 index)
  System.Void DistanceConstraintRangeKernel(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32* lengthPtr)
  System.Void DistanceConstraintKernel$BurstManaged(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32 index)
  System.Void DistanceConstraintRangeKernel$BurstManaged(Unity.Mathematics.float4* simulationPowerPtr, System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* depthArray, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, System.UInt32* indexArray, System.UInt16* dataArray, System.Single* distanceArray, System.Int32* lengthPtr)
END_CLASS

CLASS: BeyondDynamicBone.DistanceConstraint
TYPE:  class
TOKEN: 0x2000047
FIELDS:
  public    static  System.Int32                    TypeCount  // 0x0
  public            BeyondDynamicBone.ExNativeArray<System.UInt32>indexArray  // 0x10
  public            BeyondDynamicBone.ExNativeArray<System.UInt16>dataArray  // 0x18
  public            BeyondDynamicBone.ExNativeArray<System.Single>distanceArray  // 0x20
METHODS:
  System.Int32 get_DataCount()
  System.Void .ctor()
  System.Void Dispose()
  System.String ToString()
  BeyondDynamicBone.DistanceConstraint.ConstraintData CreateData(BeyondDynamicBone.VirtualMesh proxyMesh, BeyondDynamicBone.ClothParameters& parameters)
  System.Void Register(BeyondDynamicBone.ClothProcess cprocess)
  System.Void Exit(BeyondDynamicBone.ClothProcess cprocess)
  Unity.Jobs.JobHandle SolverConstraint(Unity.Jobs.JobHandle jobHandle)
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.InertiaConstraint
TYPE:  class
TOKEN: 0x200004C
FIELDS:
  private           BeyondDynamicBone.ExNativeArray<System.UInt16>fixedArray  // 0x10
METHODS:
  System.Void .ctor()
  System.Void Dispose()
  System.String ToString()
  BeyondDynamicBone.InertiaConstraint.ConstraintData CreateData(BeyondDynamicBone.VirtualMesh proxyMesh, BeyondDynamicBone.ClothParameters& parameters)
  System.Void Register(BeyondDynamicBone.ClothProcess cprocess)
  System.Void Exit(BeyondDynamicBone.ClothProcess cprocess)
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.MotionConstraintKernel_00000121$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000053
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.MotionConstraintKernel_00000121$BurstDirectCall
TYPE:  class
TOKEN: 0x2000054
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index)
END_CLASS

CLASS: BeyondDynamicBone.MotionConstraintRangeKernel_00000122$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000055
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.MotionConstraintRangeKernel_00000122$BurstDirectCall
TYPE:  class
TOKEN: 0x2000056
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr)
END_CLASS

CLASS: BeyondDynamicBone.MotionConstraintJobKernels
TYPE:  class
TOKEN: 0x2000052
FIELDS:
METHODS:
  System.Void MotionConstraintKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index)
  System.Void MotionConstraintRangeKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr)
  System.Void MotionConstraintKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32 index)
  System.Void MotionConstraintRangeKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int16* teamIdArray, Unity.Mathematics.float3* basePosArray, Unity.Mathematics.quaternion* baseRotArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* collisionNormalArray, System.Int32* lengthPtr)
END_CLASS

CLASS: BeyondDynamicBone.MotionConstraint
TYPE:  class
TOKEN: 0x2000057
FIELDS:
METHODS:
  System.Void Dispose()
  Unity.Jobs.JobHandle SolverConstraint(Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.SelfCollisionConstraint
TYPE:  class
TOKEN: 0x200005B
FIELDS:
  public    static  System.UInt32                   KindPoint  // 0x0
  public    static  System.UInt32                   KindEdge  // 0x0
  public    static  System.UInt32                   KindTriangle  // 0x0
  public    static  System.UInt32                   Flag_KindMask  // 0x0
  public    static  System.UInt32                   Flag_Fix0  // 0x0
  public    static  System.UInt32                   Flag_Fix1  // 0x0
  public    static  System.UInt32                   Flag_Fix2  // 0x0
  public    static  System.UInt32                   Flag_AllFix  // 0x0
  public    static  System.UInt32                   Flag_Ignore  // 0x0
  public    static  System.UInt32                   Flag_Enable  // 0x0
  private           BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.SelfCollisionConstraint.Primitive>primitiveArray  // 0x10
  private           BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData>sortAndSweepArray  // 0x18
  private           System.Int32                    <PointPrimitiveCount>k__BackingField  // 0x20
  private           System.Int32                    <EdgePrimitiveCount>k__BackingField  // 0x24
  private           System.Int32                    <TrianglePrimitiveCount>k__BackingField  // 0x28
  private           Unity.Collections.NativeQueue<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact>edgeEdgeContactQueue  // 0x30
  private           Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact>edgeEdgeContactList  // 0x48
  private           Unity.Collections.NativeQueue<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact>pointTriangleContactQueue  // 0x58
  private           Unity.Collections.NativeList<BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact>pointTriangleContactList  // 0x70
  private           Unity.Collections.NativeArray<System.Byte>intersectFlagArray  // 0x80
  private           System.Int32                    <IntersectCount>k__BackingField  // 0x90
METHODS:
  System.Int32 get_PointPrimitiveCount()
  System.Void set_PointPrimitiveCount(System.Int32 value)
  System.Int32 get_EdgePrimitiveCount()
  System.Void set_EdgePrimitiveCount(System.Int32 value)
  System.Int32 get_TrianglePrimitiveCount()
  System.Void set_TrianglePrimitiveCount(System.Int32 value)
  System.Int32 get_IntersectCount()
  System.Void set_IntersectCount(System.Int32 value)
  System.Void .ctor()
  System.Void Dispose()
  System.Boolean HasPrimitive()
  System.String ToString()
  System.Void Register(BeyondDynamicBone.ClothProcess cprocess)
  System.Void Exit(BeyondDynamicBone.ClothProcess cprocess)
  System.Void UpdateTeam(System.Int32 teamId)
  System.Void InitPrimitive(System.Int32 teamId, BeyondDynamicBone.TeamManager.TeamData tdata, System.UInt32 kind, System.Int32 startPrimitive, System.Int32 startSort, System.Int32 length)
  System.Void WorkBufferUpdate()
  System.Int32 BinarySearchSortAndlSweep(Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData>& sortAndSweepArray, BeyondDynamicBone.SelfCollisionConstraint.SortData& sd, BeyondDynamicBone.DataChunk& chunk)
  Unity.Jobs.JobHandle SolverConstraint(System.Int32 updateIndex, Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle SolverRuntimeSelfCollision(System.Int32 updateIndex, Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle SolverBroadPhase(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle UpdateBroadPhase(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle SolveIntersect(Unity.Jobs.JobHandle jobHandle)
  System.Void Initialize$IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveKernel_00000145$BurstDirectCall()
  System.Void Initialize$IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveRangeKernel_00000146$BurstDirectCall()
  System.Void Initialize$UpdatePrimitiveJobKernels_UpdatePrimitiveKernel_00000147$BurstDirectCall()
  System.Void Initialize$UpdatePrimitiveJobKernels_UpdatePrimitiveRangeKernel_00000148$BurstDirectCall()
  System.Void Initialize$ClearBufferJobKernels_ClearBufferKernel_00000149$BurstDirectCall()
  System.Void Initialize$SortJobKernels_SortKernel_0000014A$BurstDirectCall()
  System.Void Initialize$SortJobKernels_SortRangeKernel_0000014B$BurstDirectCall()
  System.Void Initialize$SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameKernel_0000017E$BurstDirectCall()
  System.Void Initialize$SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameRangeKernel_0000017F$BurstDirectCall()
  System.Void Initialize$SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameKernel_00000180$BurstDirectCall()
  System.Void Initialize$SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameRangeKernel_00000181$BurstDirectCall()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.SpringConstraint
TYPE:  class
TOKEN: 0x2000091
FIELDS:
METHODS:
  System.Void Dispose()
  Unity.Jobs.JobHandle SolverConstraint(Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.TethreConstraintKernel_00000193$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000095
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.TethreConstraintKernel_00000193$BurstDirectCall
TYPE:  class
TOKEN: 0x2000096
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32 index)
END_CLASS

CLASS: BeyondDynamicBone.TethreConstraintRangeKernel_00000194$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000097
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.TethreConstraintRangeKernel_00000194$BurstDirectCall
TYPE:  class
TOKEN: 0x2000098
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32* lengthPtr)
END_CLASS

CLASS: BeyondDynamicBone.TethreConstraintJobKernels
TYPE:  class
TOKEN: 0x2000094
FIELDS:
METHODS:
  System.Void TethreConstraintKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32 index)
  System.Void TethreConstraintRangeKernel(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32* lengthPtr)
  System.Void TethreConstraintKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32 index)
  System.Void TethreConstraintRangeKernel$BurstManaged(System.Int32* stepParticleIndexArray, BeyondDynamicBone.TeamManager.TeamData* teamDataArray, BeyondDynamicBone.ClothParameters* parameterArray, BeyondDynamicBone.InertiaConstraint.CenterData* centerDataArray, BeyondDynamicBone.VertexAttribute* attributes, System.Single* vertexDepths, System.Int32* vertexRootIndices, System.Int16* teamIdArray, Unity.Mathematics.float3* nextPosArray, Unity.Mathematics.float3* velocityPosArray, System.Single* frictionArray, Unity.Mathematics.float3* stepBasicPositionBuffer, System.Int32* lengthPtr)
END_CLASS

CLASS: BeyondDynamicBone.TetherConstraint
TYPE:  class
TOKEN: 0x2000099
FIELDS:
METHODS:
  System.Void Dispose()
  Unity.Jobs.JobHandle SolverConstraint(Unity.Jobs.JobHandle jobHandle)
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.TriangleBendingConstraint
TYPE:  class
TOKEN: 0x200009D
FIELDS:
  private   static  System.SByte                    VOLUME_SIGN  // 0x0
  public            BeyondDynamicBone.ExNativeArray<System.UInt64>trianglePairArray  // 0x10
  public            BeyondDynamicBone.ExNativeArray<System.Single>restAngleOrVolumeArray  // 0x18
  public            BeyondDynamicBone.ExNativeArray<System.SByte>signOrVolumeArray  // 0x20
  public            BeyondDynamicBone.ExNativeArray<System.UInt32>writeDataArray  // 0x28
  public            BeyondDynamicBone.ExNativeArray<System.UInt32>writeIndexArray  // 0x30
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>writeBuffer  // 0x38
  private   static  System.Single                   VolumeScale  // 0x0
METHODS:
  System.Int32 get_DataCount()
  System.Void .ctor()
  System.Void Dispose()
  System.String ToString()
  BeyondDynamicBone.TriangleBendingConstraint.ConstraintData CreateData(BeyondDynamicBone.VirtualMesh proxyMesh, BeyondDynamicBone.ClothParameters& parameters)
  System.Void InitVolume(BeyondDynamicBone.VirtualMesh proxyMesh, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3, System.Single& volumeRest, System.SByte& signFlag)
  System.Void InitDihedralAngle(BeyondDynamicBone.VirtualMesh proxyMesh, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3, System.Single& restAngle, System.SByte& signFlag)
  System.Void Register(BeyondDynamicBone.ClothProcess cprocess)
  System.Void Exit(BeyondDynamicBone.ClothProcess cprocess)
  Unity.Jobs.JobHandle SolverConstraint(Unity.Jobs.JobHandle jobHandle)
  System.Void Initialize$TriangleBendingJobKernels_TriangleBendingKernel_000001AA$BurstDirectCall()
  System.Void Initialize$TriangleBendingJobKernels_TriangleBendingRangeKernel_000001AB$BurstDirectCall()
  System.Void Initialize$SolveAggregateBufferJobKernels_SolveAggregateBufferKernel_000001AE$BurstDirectCall()
  System.Void Initialize$SolveAggregateBufferJobKernels_SolveAggregateBufferRangeKernel_000001AF$BurstDirectCall()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.CullingSettings
TYPE:  class
TOKEN: 0x20000AE
FIELDS:
  public            BeyondDynamicBone.CullingSettings.CameraCullingModecameraCullingMode  // 0x10
  public            BeyondDynamicBone.CullingSettings.CameraCullingMethodcameraCullingMethod  // 0x14
  public            System.Collections.Generic.List<UnityEngine.Renderer>cameraCullingRenderers  // 0x18
  public            BeyondDynamicBone.CheckSliderSerializeDatadistanceCullingLength  // 0x20
  public            System.Single                   distanceCullingFadeRatio  // 0x28
  public            UnityEngine.GameObject          distanceCullingReferenceObject  // 0x30
METHODS:
  System.Void .ctor()
  System.Void DataValidate()
  BeyondDynamicBone.CullingSettings Clone()
  System.Int32 GetHashCode()
  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: BeyondDynamicBone.CurveSerializeData
TYPE:  class
TOKEN: 0x20000B2
FIELDS:
  public            System.Single                   value  // 0x10
  public            System.Boolean                  useCurve  // 0x14
  public            UnityEngine.AnimationCurve      curve  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Single value)
  System.Void .ctor(System.Single value, System.Single curveStart, System.Single curveEnd, System.Boolean useCurve)
  System.Void .ctor(System.Single value, UnityEngine.AnimationCurve curve)
  System.Void SetValue(System.Single value)
  System.Void SetValue(System.Single value, System.Single curveStart, System.Single curveEnd, System.Boolean useCurve)
  System.Void SetValue(System.Single value, UnityEngine.AnimationCurve curve)
  System.Void DataValidate(System.Single min, System.Single max)
  System.Single Evaluate(System.Single time)
  Unity.Mathematics.float4x4 ConvertFloatArray()
  BeyondDynamicBone.CurveSerializeData Clone()
END_CLASS

CLASS: BeyondDynamicBone.CustomSkinningSettings
TYPE:  class
TOKEN: 0x20000B3
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Collections.Generic.List<UnityEngine.Transform>skinningBones  // 0x18
METHODS:
  System.Void DataValidate()
  System.Boolean IsValid()
  BeyondDynamicBone.CustomSkinningSettings Clone()
  System.Int32 GetHashCode()
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
  System.Void .ctor()
  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: BeyondDynamicBone.GizmoSerializeData
TYPE:  class
TOKEN: 0x20000B5
FIELDS:
  public            System.Boolean                  always  // 0x10
  public            BeyondDynamicBone.ClothDebugSettingsclothDebugSettings  // 0x18
METHODS:
  System.Void .ctor()
  System.Boolean IsAlways()
END_CLASS

CLASS: BeyondDynamicBone.NormalAlignmentSettings
TYPE:  class
TOKEN: 0x20000B6
FIELDS:
  public            BeyondDynamicBone.NormalAlignmentSettings.AlignmentModealignmentMode  // 0x10
  public            UnityEngine.Transform           adjustmentTransform  // 0x18
METHODS:
  System.Void DataValidate()
  System.Boolean IsValid()
  BeyondDynamicBone.NormalAlignmentSettings Clone()
  System.Int32 GetHashCode()
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
  System.Void .ctor()
  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: BeyondDynamicBone.SelectionData
TYPE:  class
TOKEN: 0x20000B8
FIELDS:
  public            Unity.Mathematics.float3[]      positions  // 0x10
  public            BeyondDynamicBone.VertexAttribute[]attributes  // 0x18
  public            System.Single                   maxConnectionDistance  // 0x20
  public            System.Boolean                  userEdit  // 0x24
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 cnt)
  System.Void .ctor(BeyondDynamicBone.VirtualMesh vmesh, Unity.Mathematics.float4x4 transformMatrix)
  System.Int32 get_Count()
  System.Boolean IsValid()
  System.Boolean IsUserEdit()
  BeyondDynamicBone.SelectionData Clone()
  System.Boolean Compare(BeyondDynamicBone.SelectionData sdata)
  System.Void AddRange(Unity.Mathematics.float3[] addPositions, BeyondDynamicBone.VertexAttribute[] addAttributes)
  System.Void Fill(BeyondDynamicBone.VertexAttribute attr)
  Unity.Collections.NativeArray<Unity.Mathematics.float3> GetPositionNativeArray()
  Unity.Collections.NativeArray<Unity.Mathematics.float3> GetPositionNativeArray(Unity.Mathematics.float4x4 transformMatrix)
  Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> GetAttributeNativeArray()
  BeyondDynamicBone.GridMap<System.Int32> CreateGridMapRun(System.Single gridSize, Unity.Collections.NativeArray<Unity.Mathematics.float3>& positions, Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>& attributes, System.Boolean move, System.Boolean fix, System.Boolean ignore, System.Boolean invalid)
  System.Void Merge(BeyondDynamicBone.SelectionData from)
  System.Void ConvertFrom(BeyondDynamicBone.SelectionData from)
END_CLASS

CLASS: BeyondDynamicBone.BeyondBoneWindZone
TYPE:  class
TOKEN: 0x20000BC
EXTENDS: ClothBehaviour
FIELDS:
  public            BeyondDynamicBone.BeyondBoneWindZone.Modemode  // 0x20
  public            UnityEngine.Vector3             size  // 0x24
  public            System.Single                   radius  // 0x30
  public            System.Single                   main  // 0x34
  public            System.Single                   turbulence  // 0x38
  public            System.Single                   directionAngleX  // 0x3C
  public            System.Single                   directionAngleY  // 0x40
  public            UnityEngine.AnimationCurve      attenuation  // 0x48
  public            System.Boolean                  isAddition  // 0x50
  private           System.Int32                    <WindId>k__BackingField  // 0x54
METHODS:
  System.Int32 get_WindId()
  System.Void set_WindId(System.Int32 value)
  System.Void Awake()
  System.Void Start()
  System.Void OnEnable()
  System.Void OnDisable()
  System.Void OnDestroy()
  System.Boolean IsDirection()
  System.Boolean IsRadial()
  System.Boolean IsAddition()
  UnityEngine.Vector3 GetWindDirection(System.Boolean localSpace)
  System.Void SetWindDirection(UnityEngine.Vector3 dir, System.Boolean localSpace)
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.WindParams
TYPE:  struct
TOKEN: 0x20000BE
FIELDS:
  public            System.Single                   influence  // 0x10
  public            System.Single                   frequency  // 0x14
  public            System.Single                   turbulence  // 0x18
  public            System.Single                   blend  // 0x1C
  public            System.Single                   synchronization  // 0x20
  public            System.Single                   depthWeight  // 0x24
  public            System.Single                   movingWind  // 0x28
METHODS:
  System.Void Convert(BeyondDynamicBone.WindSettings sdata, BeyondDynamicBone.ClothProcess.ClothType clothType)
  System.Boolean IsValid()
END_CLASS

CLASS: BeyondDynamicBone.WindSettings
TYPE:  class
TOKEN: 0x20000BF
FIELDS:
  public            System.Single                   influence  // 0x10
  public            System.Single                   frequency  // 0x14
  public            System.Single                   turbulence  // 0x18
  public            System.Single                   blend  // 0x1C
  public            System.Single                   synchronization  // 0x20
  public            System.Single                   depthWeight  // 0x24
  public            System.Single                   movingWind  // 0x28
METHODS:
  System.Boolean IsValid()
  System.Void DataValidate()
  BeyondDynamicBone.WindSettings Clone()
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.Define
TYPE:  class
TOKEN: 0x20000C0
FIELDS:
METHODS:
END_CLASS

CLASS: BeyondDynamicBone.ICount
TYPE:  interface
TOKEN: 0x20000C3
FIELDS:
METHODS:
  System.Int32 Count()
END_CLASS

CLASS: BeyondDynamicBone.IDataValidate
TYPE:  interface
TOKEN: 0x20000C4
FIELDS:
METHODS:
  System.Void DataValidate()
END_CLASS

CLASS: BeyondDynamicBone.ITransform
TYPE:  interface
TOKEN: 0x20000C5
FIELDS:
METHODS:
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
END_CLASS

CLASS: BeyondDynamicBone.IValid
TYPE:  interface
TOKEN: 0x20000C6
FIELDS:
METHODS:
  System.Boolean IsValid()
END_CLASS

CLASS: BeyondDynamicBone.ClothManager
TYPE:  class
TOKEN: 0x20000C7
FIELDS:
  private           System.Collections.Generic.HashSet<BeyondDynamicBone.ClothProcess>clothSet  // 0x10
  private           System.Collections.Generic.HashSet<BeyondDynamicBone.ClothProcess>boneClothSet  // 0x18
  private           System.Collections.Generic.HashSet<BeyondDynamicBone.ClothProcess>meshClothSet  // 0x20
  private           System.Collections.Generic.Dictionary<System.Int32,System.Boolean>animatorVisibleDict  // 0x28
  private           System.Collections.Generic.Dictionary<System.Int32,System.Boolean>rendererVisibleDict  // 0x30
  private           Unity.Jobs.JobHandle            masterJob  // 0x38
  private           System.Boolean                  isValid  // 0x48
  private   static readonly Unity.Profiling.ProfilerMarker  startClothUpdateTimeProfiler  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  startClothUpdateTeamProfiler  // 0x8
  private   static readonly Unity.Profiling.ProfilerMarker  startClothUpdatePrePareProfiler  // 0x10
  private   static readonly Unity.Profiling.ProfilerMarker  startClothUpdateScheduleProfiler  // 0x18
  private   static readonly Unity.Profiling.ProfilerMarker  startClothUpdateScheduleStep1Profiler  // 0x20
  private   static readonly Unity.Profiling.ProfilerMarker  startClothUpdateScheduleStep2Profiler  // 0x28
  private   static readonly Unity.Profiling.ProfilerMarker  startClothUpdateScheduleStep3Profiler  // 0x30
  private   static readonly Unity.Profiling.ProfilerMarker  startClothUpdateScheduleStep4Profiler  // 0x38
  private   static readonly Unity.Profiling.ProfilerMarker  startClothUpdateScheduleStep5Profiler  // 0x40
  private   static readonly Unity.Profiling.ProfilerMarker  startClothUpdateWaitMasterJobProfiler  // 0x48
METHODS:
  System.Void Dispose()
  System.Void EnterdEditMode()
  System.Void Initialize()
  System.Boolean IsValid()
  System.Void ClearMasterJob()
  System.Void CompleteMasterJob()
  System.Void ForceCompleteAllJob()
  System.Int32 AddCloth(BeyondDynamicBone.ClothProcess cprocess, BeyondDynamicBone.ClothParameters& clothParams)
  System.Void RemoveCloth(BeyondDynamicBone.ClothProcess cprocess)
  System.Void OnEarlyClothUpdate()
  System.Void OnAfterUpdate()
  System.Void OnApplicationQuit()
  System.Void OnBeforeLateUpdate()
  System.Void OnAfterLateUpdate()
  System.Void ClothUpdate()
  System.Void ClearVisibleDict()
  System.Boolean CheckVisible(UnityEngine.Animator ani, System.Collections.Generic.List<UnityEngine.Renderer> renderers)
  System.Boolean CheckLODVisible(UnityEngine.Animator ani, System.Int32 clothAnimatorAbilityLODThresholdProperty, System.Int32 clothAnimatorLODThresholdProperty)
  System.Boolean CheckRendererVisible(System.Collections.Generic.List<UnityEngine.Renderer> renderers)
  System.Void InformationLog(System.Text.StringBuilder allsb)
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: BeyondDynamicBone.PreBuildManager
TYPE:  class
TOKEN: 0x20000C8
FIELDS:
  private           System.Collections.Generic.Dictionary<BeyondDynamicBone.SharePreBuildData,BeyondDynamicBone.PreBuildManager.ShareDeserializationData>deserializationDict  // 0x10
  private           System.Boolean                  isValid  // 0x18
  private   static readonly Unity.Profiling.ProfilerMarker  deserializationProfiler  // 0x0
METHODS:
  System.Void Dispose()
  System.Void EnterdEditMode()
  System.Void Initialize()
  System.Boolean IsValid()
  System.Void InformationLog(System.Text.StringBuilder allsb)
  BeyondDynamicBone.PreBuildManager.ShareDeserializationData RegisterPreBuildData(BeyondDynamicBone.SharePreBuildData sdata, System.Boolean referenceIncrement)
  BeyondDynamicBone.PreBuildManager.ShareDeserializationData GetPreBuildData(BeyondDynamicBone.SharePreBuildData sdata)
  System.Void UnregisterPreBuildData(BeyondDynamicBone.SharePreBuildData sdata)
  System.Void UnloadUnusedData()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: BeyondDynamicBone.DoAllInOneJob
TYPE:  struct
TOKEN: 0x20000CA
FIELDS:
  public            System.Runtime.InteropServices.GCHandlebmHandle  // 0x10
  public            System.Runtime.InteropServices.GCHandletmHandle  // 0x18
  public            System.Runtime.InteropServices.GCHandlevmHandle  // 0x20
  public            System.Runtime.InteropServices.GCHandlesmHandle  // 0x28
  public            System.Runtime.InteropServices.GCHandlewmHandle  // 0x30
  public            System.Runtime.InteropServices.GCHandlemeshClothSetHandle  // 0x38
METHODS:
  System.Void Execute()
END_CLASS

CLASS: BeyondDynamicBone.ICrossFrameParallelForJob
TYPE:  interface
TOKEN: 0x20000CB
FIELDS:
METHODS:
  System.Void SetIndexCount(System.Int32 indexCount)
END_CLASS

CLASS: BeyondDynamicBone.ICrossFrameParallelForDeferJob
TYPE:  interface
TOKEN: 0x20000CC
FIELDS:
METHODS:
  System.Void SetIndexCount(Unity.Collections.NativeReference<System.Int32> indexCount)
END_CLASS

CLASS: BeyondDynamicBone.IUnsafeJob
TYPE:  interface
TOKEN: 0x20000CD
FIELDS:
METHODS:
  System.Void UnsafeDo()
END_CLASS

CLASS: BeyondDynamicBone.CrossFrameJobUtils
TYPE:  class
TOKEN: 0x20000CE
FIELDS:
  public    static  System.Int32                    s_MainThreadId  // 0x0
METHODS:
  Unity.Jobs.JobHandle ScheduleNoUseRun(T& jobData, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle Schedule2(T& jobData, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle Schedule(T& jobData, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle Schedule(T& jobData, System.Int32 arrayLength, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle Schedule2(T& jobData, System.Int32 arrayLength, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle Schedule2(T& jobData, System.Int32* forEachCount, Unity.Collections.NativeReference<System.Int32> forEachCountRef, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle Schedule(T& jobData, System.Int32* forEachCount, Unity.Collections.NativeReference<System.Int32> forEachCountRef, System.Int32 innerloopBatchCount, Unity.Jobs.JobHandle dependsOn)
END_CLASS

CLASS: BeyondDynamicBone.DynamicBoneTransformManager
TYPE:  class
TOKEN: 0x20000CF
FIELDS:
  private   static  System.Byte                     Flag_Read  // 0x0
  private   static  System.Byte                     Flag_WorldRotWrite  // 0x0
  private   static  System.Byte                     Flag_LocalPosRotWrite  // 0x0
  private   static  System.Byte                     Flag_Restore  // 0x0
  private   static  System.Byte                     Flag_Enable  // 0x0
  private           BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.ExBitFlag8>flagArray  // 0x10
  private           BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>initLocalPositionArray  // 0x18
  private           BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>initLocalRotationArray  // 0x20
  private           BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>positionArray  // 0x28
  private           BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>lastpositionArray  // 0x30
  private           BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>rotationArray  // 0x38
  private           BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>lastrotationArray  // 0x40
  private           BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>scaleArray  // 0x48
  private           BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>localPositionArray  // 0x50
  private           BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>lastlocalPositionArray  // 0x58
  private           BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>localRotationArray  // 0x60
  private           BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>lastlocalRotationArray  // 0x68
  private           BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float4x4>localToWorldMatrixArray  // 0x70
  private           BeyondDynamicBone.ExNativeArray<System.Int16>teamIdArray  // 0x78
  private           UnityEngine.Jobs.TransformAccessArraytransformAccessArray  // 0x80
  private           System.Collections.Generic.Dictionary<UnityEngine.Animator,System.Collections.Generic.List<System.Int32>>animatorTransformMap  // 0x88
  private           BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>componentPositionArray  // 0x90
  private           UnityEngine.Jobs.TransformAccessArraycomponentTransformAccessArray  // 0x98
  private           System.Boolean                  isValid  // 0xA0
METHODS:
  Unity.Jobs.JobHandle WriteAnimatorBufferData(Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>& teamId2AnimatorInstnceId, Unity.Collections.NativeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>& animatorID2RWHandler, Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>& transformID2RWHandlerID)
  Unity.Jobs.JobHandle ReadAnimatorBufferData(Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>& teamId2AnimatorInstnceId, Unity.Collections.NativeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>& animatorID2RWHandler, Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>& transformID2RWHandlerID)
  Unity.Jobs.JobHandle CopyDoubleBuffer(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle WriteDoubleBufferTransform(Unity.Jobs.JobHandle jobHandle)
  System.Int32 get_Count()
  System.Void Dispose()
  System.Void EnterdEditMode()
  System.Void Initialize()
  System.Boolean IsValid()
  BeyondDynamicBone.DataChunk AddTransform(BeyondDynamicBone.VirtualMeshContainer cmesh, System.Int32 teamId)
  BeyondDynamicBone.DataChunk AddTransform(System.Int32 count, System.Int32 teamId)
  BeyondDynamicBone.DataChunk AddTransform(UnityEngine.Transform t, BeyondDynamicBone.ExBitFlag8 flag, System.Int32 teamId)
  System.Void SetTransform(UnityEngine.Transform t, BeyondDynamicBone.ExBitFlag8 flag, System.Int32 index, System.Int32 teamId)
  System.Void CopyTransform(System.Int32 fromIndex, System.Int32 toIndex)
  System.Void RemoveTransform(BeyondDynamicBone.DataChunk c)
  System.Void EnableTransform(BeyondDynamicBone.DataChunk c, System.Boolean sw)
  System.Void EnableTransform(System.Int32 index, System.Boolean sw)
  BeyondDynamicBone.DataChunk Expand(BeyondDynamicBone.DataChunk c, System.Int32 newLength)
  Unity.Jobs.JobHandle RestoreTransform(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle ReadTransform(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle WriteTransform(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle ValidPosition(Unity.Jobs.JobHandle jobHandle)
  System.Int32 AddComponentTransform(UnityEngine.Transform t)
  System.Void RemoveComponentTransform(System.Int32 index)
  Unity.Jobs.JobHandle ReadComponentTransform(Unity.Jobs.JobHandle jobHandle)
  System.Void InformationLog(System.Text.StringBuilder allsb)
  System.Void .ctor()
  System.Void Initialize$WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataKernel_0000025C$BurstDirectCall()
  System.Void Initialize$WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataRangeKernel_0000025D$BurstDirectCall()
END_CLASS

CLASS: BeyondDynamicBone.TeamManager
TYPE:  class
TOKEN: 0x20000E3
FIELDS:
  public    static  System.Int32                    Flag_Valid  // 0x0
  public    static  System.Int32                    Flag_Enable  // 0x0
  public    static  System.Int32                    Flag_Reset  // 0x0
  public    static  System.Int32                    Flag_TimeReset  // 0x0
  public    static  System.Int32                    Flag_SyncSuspend  // 0x0
  public    static  System.Int32                    Flag_Running  // 0x0
  public    static  System.Int32                    Flag_Synchronization  // 0x0
  public    static  System.Int32                    Flag_StepRunning  // 0x0
  public    static  System.Int32                    Flag_Exit  // 0x0
  public    static  System.Int32                    Flag_KeepTeleport  // 0x0
  public    static  System.Int32                    Flag_InertiaShift  // 0x0
  public    static  System.Int32                    Flag_CameraCullingInvisible  // 0x0
  public    static  System.Int32                    Flag_CameraCullingKeep  // 0x0
  public    static  System.Int32                    Flag_Spring  // 0x0
  public    static  System.Int32                    Flag_SkipWriting  // 0x0
  public    static  System.Int32                    Flag_Anchor  // 0x0
  public    static  System.Int32                    Flag_AnchorReset  // 0x0
  public    static  System.Int32                    Flag_NegativeScale  // 0x0
  public    static  System.Int32                    Flag_NegativeScaleTeleport  // 0x0
  public    static  System.Int32                    Flag_DistanceCullingInvisible  // 0x0
  public    static  System.Int32                    Flag_RestoreTransformOnlyOnec  // 0x0
  public    static  System.Int32                    Flag_Tangent  // 0x0
  public    static  System.Int32                    Flag_Self_PointPrimitive  // 0x0
  public    static  System.Int32                    Flag_Self_EdgePrimitive  // 0x0
  public    static  System.Int32                    Flag_Self_TrianglePrimitive  // 0x0
  public    static  System.Int32                    Flag_Self_EdgeEdge  // 0x0
  public    static  System.Int32                    Flag_Sync_EdgeEdge  // 0x0
  public    static  System.Int32                    Flag_PSync_EdgeEdge  // 0x0
  public    static  System.Int32                    Flag_Self_PointTriangle  // 0x0
  public    static  System.Int32                    Flag_Sync_PointTriangle  // 0x0
  public    static  System.Int32                    Flag_PSync_PointTriangle  // 0x0
  public    static  System.Int32                    Flag_Self_TrianglePoint  // 0x0
  public    static  System.Int32                    Flag_Sync_TrianglePoint  // 0x0
  public    static  System.Int32                    Flag_PSync_TrianglePoint  // 0x0
  public    static  System.Int32                    Flag_Self_EdgeTriangleIntersect  // 0x0
  public    static  System.Int32                    Flag_Sync_EdgeTriangleIntersect  // 0x0
  public    static  System.Int32                    Flag_PSync_EdgeTriangleIntersect  // 0x0
  public    static  System.Int32                    Flag_Self_TriangleEdgeIntersect  // 0x0
  public    static  System.Int32                    Flag_Sync_TriangleEdgeIntersect  // 0x0
  public    static  System.Int32                    Flag_PSync_TriangleEdgeIntersect  // 0x0
  public    static  System.Int32                    Flag_Lod_LodOut  // 0x0
  public    static  System.Int32                    Flag_Lod_Culled  // 0x0
  public            BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.TeamManager.TeamData>teamDataArray  // 0x10
  public            BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.TeamWindData>teamWindArray  // 0x18
  public            BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.TeamManager.MappingData>mappingDataArray  // 0x20
  public            BeyondDynamicBone.ExNativeArray<Unity.Collections.FixedList64Bytes<System.Int16>>teamMappingIndexArray  // 0x28
  public            Unity.Collections.NativeReference<System.Int32>maxUpdateCount  // 0x30
  public            BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.ClothParameters>parameterArray  // 0x40
  public            BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.InertiaConstraint.CenterData>centerDataArray  // 0x48
  private           System.Collections.Generic.HashSet<System.Int32>enableTeamSet  // 0x50
  private           System.Collections.Generic.Dictionary<System.Int32,BeyondDynamicBone.ClothProcess>clothProcessDict  // 0x58
  private           System.Boolean                  isValid  // 0x60
  private           System.Int32                    edgeColliderCollisionCount  // 0x64
  private           Unity.Collections.NativeReference<System.Int32>edgeColliderCollisionCountBuff  // 0x68
  private           Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>comp2SuspendCounterMap  // 0x78
  private           Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>comp2TeamIdMap  // 0x88
  private           Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>comp2SyncPartnerCompMap  // 0x98
  private           Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>comp2SyncTopCompMap  // 0xA8
  private           Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>teamId2AnimatorInstnceId  // 0xB8
  private           Unity.Collections.NativeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>animatorID2RWHandler  // 0xC8
  private           Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>transformID2RWHandlerID  // 0xD8
  private           System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Animator>teamId2Animator  // 0xE8
  private           System.Collections.Generic.HashSet<System.Int32>dirtyAnimatorTransformTeams  // 0xF0
  private           System.Collections.Generic.HashSet<System.Int32>m_tempList  // 0xF8
  private           System.Collections.Generic.List<BeyondDynamicBone.ClothProcess>parameterDirtyList  // 0x100
  private           System.Collections.Generic.List<BeyondDynamicBone.ClothProcess>skipWritingDirtyList  // 0x108
  private           System.Collections.Generic.List<BeyondDynamicBone.ClothProcess>codeParameterDirtyList  // 0x110
  private           Unity.Collections.NativeList<System.Int32>cullingDirtyList  // 0x118
  private           Unity.Collections.NativeParallelHashSet<System.Int32>alwaysTeamUpdateSelfCollisionUpdateSet  // 0x128
  private           Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>animatorUpdateModeMap  // 0x138
  private           BeyondDynamicBone.ExSimpleNativeArray<System.Int32>teamAnchorTransformIndexArray  // 0x148
  private           BeyondDynamicBone.ExSimpleNativeArray<System.Int32>teamDistanceTransformIndexArray  // 0x150
  private           Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Mathematics.float3>transformPositionMap  // 0x158
  private           Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Mathematics.quaternion>transformRotationMap  // 0x168
  private           System.Collections.Generic.HashSet<BeyondDynamicBone.BeyondBoneCloth>cameraCullingClothSet  // 0x178
  private   static readonly Unity.Profiling.ProfilerMarker  teamCameraCullingPreProfiler  // 0x0
  private   static readonly Unity.Profiling.ProfilerMarker  teamCameraCullingProfiler  // 0x8
  private   static readonly Unity.Profiling.ProfilerMarker  startClothUpdateComponentProfiler  // 0x10
  private   static readonly Unity.Profiling.ProfilerMarker  alwaysTeamUpdateParameterDirtyProfiler  // 0x18
  private   static readonly Unity.Profiling.ProfilerMarker  alwaysTeamUpdateStep2Profiler  // 0x20
  private   static readonly Unity.Profiling.ProfilerMarker  alwaysTeamUpdateStep3Profiler  // 0x28
  private   static readonly Unity.Profiling.ProfilerMarker  alwaysTeamUpdateEdgeColliderProfiler  // 0x30
  private   static readonly Unity.Profiling.ProfilerMarker  alwaysTeamUpdateSelfCollisionStepProfiler  // 0x38
  private           System.Collections.Generic.HashSet<BeyondDynamicBone.ClothProcess>monitoringProcessSet  // 0x180
  private           System.Collections.Generic.List<BeyondDynamicBone.ClothProcess>disposeProcessList  // 0x188
METHODS:
  System.Int32 get_MappingCount()
  System.Int32 get_TeamCount()
  System.Int32 get_TrueTeamCount()
  System.Int32 get_ActiveTeamCount()
  System.Void UpdateTeamAnimatorData(BeyondDynamicBone.ExNativeArray<System.Int16> teamIdArray, UnityEngine.Jobs.TransformAccessArray transformArray)
  System.Void ClearTeamAnimatorData(System.Int32 teamId)
  System.Void AddTeamAnimatorData(System.Int32 teamId, BeyondDynamicBone.ClothProcess cprocess)
  System.Void AddAnimatorTransform(System.Int32 teamId, UnityEngine.Transform t)
  System.Void MarkAnimatorTransformDirty(System.Int32 teamId, UnityEngine.Transform t)
  System.Void Dispose()
  System.Void EnterdEditMode()
  System.Void Initialize()
  System.Boolean IsValid()
  System.Int32 AddTeam(BeyondDynamicBone.ClothProcess cprocess, BeyondDynamicBone.ClothParameters clothParams)
  System.Void RemoveTeam(System.Int32 teamId)
  System.Void SetEnable(System.Int32 teamId, System.Boolean sw)
  System.Boolean IsEnable(System.Int32 teamId)
  System.Void SetSkipWriting(System.Int32 teamId, System.Boolean sw)
  System.Boolean ContainsTeamData(System.Int32 teamId)
  BeyondDynamicBone.TeamManager.TeamData& GetTeamDataRef(System.Int32 teamId)
  Unity.Collections.FixedList64Bytes<System.Int16>& GetTeamMappingRef(System.Int32 teamId)
  BeyondDynamicBone.ClothParameters& GetParametersRef(System.Int32 teamId)
  BeyondDynamicBone.InertiaConstraint.CenterData& GetCenterDataRef(System.Int32 teamId)
  BeyondDynamicBone.ClothProcess GetClothProcess(System.Int32 teamId)
  System.Void CameraCullingPreProcess()
  System.Void CameraCullingPostProcess()
  System.Void AlwaysTeamUpdate()
  System.Void RemoveSyncParent(BeyondDynamicBone.TeamManager.TeamData& tdata, System.Int32 parentTeamId)
  Unity.Jobs.JobHandle CalcCenterAndInertiaAndWind(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle SimulationStepTeamUpdate(System.Int32 updateIndex, Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle PostTeamUpdate(Unity.Jobs.JobHandle jobHandle)
  System.Void AddMonitoringProcess(BeyondDynamicBone.ClothProcess cprocess)
  System.Void RemoveMonitoringProcess(BeyondDynamicBone.ClothProcess cprocess)
  System.Void MonitoringProcess(System.Boolean force)
  System.Void MonitoringProcessUpdate()
  System.Void InformationLog(System.Text.StringBuilder allsb)
  System.Void .ctor()
  System.Void .cctor()
  System.Void Initialize$PostTeamUpdateJobKernels_PostTeamUpdateKernel_00000298$BurstDirectCall()
  System.Void Initialize$PostTeamUpdateJobKernels_PostTeamUpdateRangeKernel_00000299$BurstDirectCall()
END_CLASS

CLASS: BeyondDynamicBone.VirtualMeshManager
TYPE:  class
TOKEN: 0x2000101
FIELDS:
  public            BeyondDynamicBone.ExNativeArray<System.Int16>teamIds  // 0x10
  public            BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x18
  public            BeyondDynamicBone.ExNativeArray<Unity.Collections.FixedList32Bytes<System.UInt32>>vertexToTriangles  // 0x20
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>vertexBindPosePositions  // 0x28
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>vertexBindPoseRotations  // 0x30
  public            BeyondDynamicBone.ExNativeArray<System.Single>vertexDepths  // 0x38
  public            BeyondDynamicBone.ExNativeArray<System.Int32>vertexRootIndices  // 0x40
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>vertexLocalPositions  // 0x48
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>vertexLocalRotations  // 0x50
  public            BeyondDynamicBone.ExNativeArray<System.Int32>vertexParentIndices  // 0x58
  public            BeyondDynamicBone.ExNativeArray<System.UInt32>vertexChildIndexArray  // 0x60
  public            BeyondDynamicBone.ExNativeArray<System.UInt16>vertexChildDataArray  // 0x68
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>normalAdjustmentRotations  // 0x70
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float2>uv  // 0x78
  public            BeyondDynamicBone.ExNativeArray<System.Int16>triangleTeamIdArray  // 0x80
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.int3>triangles  // 0x88
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>triangleNormals  // 0x90
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>triangleTangents  // 0x98
  public            BeyondDynamicBone.ExNativeArray<System.Int16>edgeTeamIdArray  // 0xA0
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.int2>edges  // 0xA8
  public            BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.ExBitFlag8>edgeFlags  // 0xB0
  public            BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.ExBitFlag8>baseLineFlags  // 0xB8
  public            BeyondDynamicBone.ExNativeArray<System.Int16>baseLineTeamIds  // 0xC0
  public            BeyondDynamicBone.ExNativeArray<System.UInt16>baseLineStartDataIndices  // 0xC8
  public            BeyondDynamicBone.ExNativeArray<System.UInt16>baseLineDataCounts  // 0xD0
  public            BeyondDynamicBone.ExNativeArray<System.UInt16>baseLineData  // 0xD8
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>localPositions  // 0xE0
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>localNormals  // 0xE8
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>localTangents  // 0xF0
  public            BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0xF8
  public            BeyondDynamicBone.ExNativeArray<System.Int32>skinBoneTransformIndices  // 0x100
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float4x4>skinBoneBindPoses  // 0x108
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>vertexToTransformRotations  // 0x110
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>positions  // 0x118
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>rotations  // 0x120
  public            BeyondDynamicBone.ExNativeArray<System.Int16>mappingIdArray  // 0x128
  public            BeyondDynamicBone.ExNativeArray<System.Int32>mappingReferenceIndices  // 0x130
  public            BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.VertexAttribute>mappingAttributes  // 0x138
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>mappingLocalPositins  // 0x140
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>mappingLocalNormals  // 0x148
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>mappingLocalTangents  // 0x150
  public            BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>mappingBoneWeights  // 0x158
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>mappingPositions  // 0x160
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>mappingNormals  // 0x168
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>mappingTangents  // 0x170
  private           System.Boolean                  isValid  // 0x178
METHODS:
  System.Void CreateProxyMeshUpdateVertexListKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32 teamId)
  System.Void CreateProxyMeshUpdateVertexListRangeKernel(BeyondDynamicBone.TeamManager.TeamData* teamDataArray, System.Int32* processingCounter1, System.Int32* processingList1, System.Int32 length)
  System.Int32 get_ProxyVertexCount()
  System.Int32 get_ProxyTriangleCount()
  System.Int32 get_ProxyEdgeCount()
  System.Int32 get_ProxyBaseLineCount()
  System.Int32 get_ProxyLocalPositionCount()
  System.Int32 get_MappingVertexCount()
  System.Void Dispose()
  System.Void EnterdEditMode()
  System.Void Initialize()
  System.Boolean IsValid()
  System.Void RegisterProxyMesh(System.Int32 teamId, BeyondDynamicBone.VirtualMeshContainer proxyMeshContainer)
  System.Void ExitProxyMesh(System.Int32 teamId)
  BeyondDynamicBone.DataChunk RegisterMappingMesh(System.Int32 teamId, BeyondDynamicBone.VirtualMeshContainer mappingMeshContainer)
  System.Void ExitMappingMesh(System.Int32 teamId, System.Int32 mappingIndex)
  System.Void UpdateBuffer()
  Unity.Jobs.JobHandle PreProxyMeshUpdate(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle PostProxyMeshUpdate(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle PostMappingMeshUpdate(Unity.Jobs.JobHandle jobHandle)
  System.Void InformationLog(System.Text.StringBuilder allsb)
  System.Void .ctor()
  System.Void Initialize$CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListKernel_000002E6$BurstDirectCall()
  System.Void Initialize$CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListRangeKernel_000002E7$BurstDirectCall()
  System.Void Initialize$CalcLineNormalTangentJobKernels_CalcLineNormalTangentKernel_000002E8$BurstDirectCall()
  System.Void Initialize$CalcLineNormalTangentJobKernels_CalcLineNormalTangentRangeKernel_000002E9$BurstDirectCall()
  System.Void Initialize$WriteTransformDataJobKernels_WriteTransformDataKernel_000002EA$BurstDirectCall()
  System.Void Initialize$WriteTransformDataJobKernels_WriteTransformDataRangeKernel_000002EB$BurstDirectCall()
  System.Void Initialize$WriteTransformLocalDataJobKernels_WriteTransformLocalDataKernel_000002EC$BurstDirectCall()
  System.Void Initialize$WriteTransformLocalDataJobKernels_WriteTransformLocalDataRangeKernel_000002ED$BurstDirectCall()
  System.Void Initialize$CalcProxySkinningJobKernels_CalcProxySkinningKernel_000002EE$BurstDirectCall()
  System.Void Initialize$CalcProxySkinningJobKernels_CalcProxySkinningRangeKernel_000002EF$BurstDirectCall()
  System.Void Initialize$CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixKernel_000002F0$BurstDirectCall()
  System.Void Initialize$CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixRangeKernel_000002F1$BurstDirectCall()
  System.Void Initialize$CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentKernel_000002F2$BurstDirectCall()
  System.Void Initialize$CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentRangeKernel_000002F3$BurstDirectCall()
  System.Void Initialize$CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleKernel_000002F4$BurstDirectCall()
  System.Void Initialize$CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleRangeKernel_000002F5$BurstDirectCall()
  System.Void Initialize$ClearProxyMeshUpdateBufferJobKernels_ClearProxyMeshUpdateBufferKernel_000002F6$BurstDirectCall()
END_CLASS

CLASS: BeyondDynamicBone.IManager
TYPE:  interface
TOKEN: 0x200013D
FIELDS:
METHODS:
  System.Void Initialize()
  System.Void EnterdEditMode()
  System.Void InformationLog(System.Text.StringBuilder allsb)
END_CLASS

CLASS: BeyondDynamicBone.MagicaManager
TYPE:  class
TOKEN: 0x200013E
FIELDS:
  private   static  System.Collections.Generic.List<BeyondDynamicBone.IManager>managers  // 0x0
  public    static  System.Boolean                  EnableTick  // 0x8
  public    static  System.Boolean                  UseCrossFrameJob  // 0x9
  public    static  System.Boolean                  UseAnimatorTransform  // 0xA
  public    static  BeyondDynamicBone.MagicaManager.UpdateMethodafterEarlyUpdateDelegate  // 0x10
  public    static  BeyondDynamicBone.MagicaManager.UpdateMethodafterFixedUpdateDelegate  // 0x18
  public    static  BeyondDynamicBone.MagicaManager.UpdateMethodafterUpdateDelegate  // 0x20
  public    static  BeyondDynamicBone.MagicaManager.UpdateMethodbeforeLateUpdateDelegate  // 0x28
  public    static  BeyondDynamicBone.MagicaManager.UpdateMethodafterLateUpdateDelegate  // 0x30
  public    static  BeyondDynamicBone.MagicaManager.UpdateMethodafterDelayedDelegate  // 0x38
  public    static  BeyondDynamicBone.MagicaManager.UpdateMethodafterRenderingDelegate  // 0x40
  public    static  BeyondDynamicBone.MagicaManager.UpdateMethoddefaultUpdateDelegate  // 0x48
  public    static  BeyondDynamicBone.MagicaManager.UpdateMethodonApplicationQuitDelegate  // 0x50
  private   static  System.Boolean                  isPlaying  // 0x58
  public    static  System.Action                   OnPreSimulation  // 0x60
  public    static  System.Action                   OnPostSimulation  // 0x68
  private   static  BeyondDynamicBone.MagicaManager.InitializationLocationinitializationLocation  // 0x70
METHODS:
  BeyondDynamicBone.TimeManager get_Time()
  BeyondDynamicBone.TeamManager get_Team()
  BeyondDynamicBone.ClothManager get_Cloth()
  BeyondDynamicBone.RenderManager get_Render()
  BeyondDynamicBone.DynamicBoneTransformManager get_Bone()
  BeyondDynamicBone.VirtualMeshManager get_VMesh()
  BeyondDynamicBone.SimulationManager get_Simulation()
  BeyondDynamicBone.ColliderManager get_Collider()
  BeyondDynamicBone.WindManager get_Wind()
  BeyondDynamicBone.PreBuildManager get_PreBuild()
  System.Void Initialize()
  System.Void Dispose()
  System.Boolean IsPlaying()
  System.Void SetUseCrossFrameJob(System.Boolean value)
  System.Void InitCustomGameLoop()
  System.Void SetCustomGameLoop(UnityEngine.LowLevel.PlayerLoopSystem& playerLoop)
  System.Boolean CheckRegist(UnityEngine.LowLevel.PlayerLoopSystem& playerLoop)
  System.Void SetGlobalTimeScale(System.Single timeScale)
  System.Single GetGlobalTimeScale()
  System.Void SetSimulationFrequency(System.Int32 freq)
  System.Void SetAOVMode(System.Boolean enable, System.Single deltaTime)
  System.Void DoAOVUpdate()
  System.Void DoAOVAfterAnimatorUpdate()
  System.Int32 GetSimulationFrequency()
  System.Void SetMaxSimulationCountPerFrame(System.Int32 count)
  System.Int32 GetMaxSimulationCountPerFrame()
  System.Void SetUpdateLocation(BeyondDynamicBone.TimeManager.UpdateLocation updateLocation)
  BeyondDynamicBone.TimeManager.UpdateLocation GetUpdateLocation()
  System.Void UnloadUnusedData()
  System.Void SetInitializationLocation(BeyondDynamicBone.MagicaManager.InitializationLocation initLocation)
  System.Void .cctor()
END_CLASS

CLASS: BeyondDynamicBone.MagicaSettings
TYPE:  class
TOKEN: 0x2000143
EXTENDS: ClothBehaviour
FIELDS:
  public            BeyondDynamicBone.MagicaSettings.RefreshModerefreshMode  // 0x20
  public            System.Int32                    simulationFrequency  // 0x24
  public            System.Int32                    maxSimulationCountPerFrame  // 0x28
  public            BeyondDynamicBone.MagicaManager.InitializationLocationinitializationLocation  // 0x2C
  public            BeyondDynamicBone.TimeManager.UpdateLocationupdateLocation  // 0x30
  public            System.Boolean                  monitorPlayerLoop  // 0x34
METHODS:
  System.Void Awake()
  System.Void Start()
  System.Void Update()
  System.Void OnValidate()
  System.Void Refresh()
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.UpdatePositionNormalKernel_00000359$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000146
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.UpdatePositionNormalKernel_00000359$BurstDirectCall
TYPE:  class
TOKEN: 0x2000147
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 index)
END_CLASS

CLASS: BeyondDynamicBone.UpdatePositionNormalRangeKernel_0000035A$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000148
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 length)
  System.IAsyncResult BeginInvoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.UpdatePositionNormalRangeKernel_0000035A$BurstDirectCall
TYPE:  class
TOKEN: 0x2000149
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 length)
END_CLASS

CLASS: BeyondDynamicBone.UpdatePositionNormalJobKernels
TYPE:  class
TOKEN: 0x2000145
FIELDS:
METHODS:
  System.Void UpdatePositionNormalKernel(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 index)
  System.Void UpdatePositionNormalRangeKernel(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 length)
  System.Void UpdatePositionNormalKernel$BurstManaged(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 index)
  System.Void UpdatePositionNormalRangeKernel$BurstManaged(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, System.Int32 length)
END_CLASS

CLASS: BeyondDynamicBone.UpdatePositionNormalTangentKernel_0000035B$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200014B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.UpdatePositionNormalTangentKernel_0000035B$BurstDirectCall
TYPE:  class
TOKEN: 0x200014C
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 index)
END_CLASS

CLASS: BeyondDynamicBone.UpdatePositionNormalTangentRangeKernel_0000035C$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200014D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 length)
  System.IAsyncResult BeginInvoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.UpdatePositionNormalTangentRangeKernel_0000035C$BurstDirectCall
TYPE:  class
TOKEN: 0x200014E
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 length)
END_CLASS

CLASS: BeyondDynamicBone.UpdatePositionNormalTangentJobKernels
TYPE:  class
TOKEN: 0x200014A
FIELDS:
METHODS:
  System.Void UpdatePositionNormalTangentKernel(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 index)
  System.Void UpdatePositionNormalTangentRangeKernel(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 length)
  System.Void UpdatePositionNormalTangentKernel$BurstManaged(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 index)
  System.Void UpdatePositionNormalTangentRangeKernel$BurstManaged(System.Int32 startIndex, Unity.Mathematics.float3* meshLocalPositions, Unity.Mathematics.float3* meshLocalNormals, Unity.Mathematics.float4* meshLocalTangents, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, Unity.Mathematics.float3* mappingPositions, Unity.Mathematics.float3* mappingNormals, Unity.Mathematics.float3* mappingTangents, System.Int32 length)
END_CLASS

CLASS: BeyondDynamicBone.UpdateBoneWeight2Kernel_0000035D$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000150
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeightptr, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeightptr, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.UpdateBoneWeight2Kernel_0000035D$BurstDirectCall
TYPE:  class
TOKEN: 0x2000151
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeightptr, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 index)
END_CLASS

CLASS: BeyondDynamicBone.UpdateBoneWeight2RangeKernel_0000035E$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000152
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeight, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 length)
  System.IAsyncResult BeginInvoke(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeight, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.UpdateBoneWeight2RangeKernel_0000035E$BurstDirectCall
TYPE:  class
TOKEN: 0x2000153
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeight, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 length)
END_CLASS

CLASS: BeyondDynamicBone.UpdateBoneWeightJob2Kernels
TYPE:  class
TOKEN: 0x200014F
FIELDS:
METHODS:
  System.Void UpdateBoneWeight2Kernel(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeightptr, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 index)
  System.Void UpdateBoneWeight2RangeKernel(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeight, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 length)
  System.Void UpdateBoneWeight2Kernel$BurstManaged(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeightptr, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 index)
  System.Void UpdateBoneWeight2RangeKernel$BurstManaged(System.Int32 startIndex, UnityEngine.BoneWeight* centerBoneWeight, UnityEngine.BoneWeight* meshBoneWeights, System.Int32* mappingReferenceIndices, BeyondDynamicBone.VertexAttribute* mappingAttributes, System.Int32 length)
END_CLASS

CLASS: BeyondDynamicBone.RenderData
TYPE:  class
TOKEN: 0x2000154
FIELDS:
  private           System.Int32                    <ReferenceCount>k__BackingField  // 0x10
  private           System.Collections.Generic.HashSet<BeyondDynamicBone.ClothProcess>useProcessSet  // 0x18
  private           System.Boolean                  isSkipWriting  // 0x20
  private           BeyondDynamicBone.RenderSetupDatasetupData  // 0x28
  private           BeyondDynamicBone.RenderSetupData.UniqueSerializationDatapreBuildUniqueSerializeData  // 0x30
  private           UnityEngine.Mesh                originalMesh  // 0x38
  private           UnityEngine.SkinnedMeshRenderer skinnedMeshRendere  // 0x40
  private           UnityEngine.MeshFilter          meshFilter  // 0x48
  private           System.Collections.Generic.List<UnityEngine.Transform>transformList  // 0x50
  private           UnityEngine.Mesh                customMesh  // 0x58
  private           Unity.Collections.NativeArray<UnityEngine.Vector3>localPositions  // 0x60
  private           Unity.Collections.NativeArray<UnityEngine.Vector3>localNormals  // 0x70
  private           Unity.Collections.NativeArray<UnityEngine.Vector4>localTangents  // 0x80
  private           Unity.Collections.NativeArray<UnityEngine.BoneWeight>boneWeights  // 0x90
  private           UnityEngine.BoneWeight          centerBoneWeight  // 0xA0
  private   static  System.Int32                    Flag_UseCustomMesh  // 0x0
  private   static  System.Int32                    Flag_ChangePositionNormal  // 0x0
  private   static  System.Int32                    Flag_ChangeBoneWeight  // 0x0
  private   static  System.Int32                    Flag_ModifyBoneWeight  // 0x0
  private   static  System.Int32                    Flag_HasMeshTangent  // 0x0
  private   static  System.Int32                    Flag_HasTangent  // 0x0
  private   static  System.Int32                    Flag_ChangeTangent  // 0x0
  private           Unity.Collections.BitField32    flag  // 0xC0
METHODS:
  System.Int32 get_ReferenceCount()
  System.Void set_ReferenceCount(System.Int32 value)
  System.String get_Name()
  System.Boolean get_HasSkinnedMesh()
  System.Boolean get_HasBoneWeight()
  System.Boolean get_UseCustomMesh()
  System.Boolean get_HasMeshTangent()
  System.Boolean get_HasTangent()
  System.Void Dispose()
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
  System.Void Initialize(UnityEngine.Renderer ren, BeyondDynamicBone.RenderSetupData referenceSetupData, BeyondDynamicBone.RenderSetupData.UniqueSerializationData referencePreBuildUniqueSetupData)
  BeyondDynamicBone.ResultCode get_Result()
  System.Int32 AddReferenceCount()
  System.Int32 RemoveReferenceCount()
  System.Void SwapCustomMesh()
  System.Void ResetCustomMeshWorkData()
  System.Void SwapOriginalMesh()
  System.Void SetMesh(UnityEngine.Mesh mesh)
  System.Void StartUse(BeyondDynamicBone.ClothProcess cprocess)
  System.Void EndUse(BeyondDynamicBone.ClothProcess cprocess)
  System.Void UpdateUse(BeyondDynamicBone.ClothProcess cprocess, System.Int32 add)
  System.Void UpdateSkipWriting()
  System.Void WriteMesh()
  Unity.Jobs.JobHandle UpdatePositionNormal(System.Boolean updateTangent, BeyondDynamicBone.DataChunk mappingChunk, Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle UpdateBoneWeight(BeyondDynamicBone.DataChunk mappingChunk, Unity.Jobs.JobHandle jobHandle)
  System.String ToString()
  System.Void .ctor()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.RenderManager
TYPE:  class
TOKEN: 0x2000159
FIELDS:
  private           System.Collections.Generic.Dictionary<System.Int32,BeyondDynamicBone.RenderData>renderDataDict  // 0x10
  private           System.Boolean                  isValid  // 0x18
METHODS:
  System.Void Initialize()
  System.Void EnterdEditMode()
  System.Void Dispose()
  System.Boolean IsValid()
  System.Int32 AddRenderer(UnityEngine.Renderer ren, BeyondDynamicBone.RenderSetupData referenceSetupData, BeyondDynamicBone.RenderSetupData.UniqueSerializationData referenceUniqueSetupData)
  System.Boolean RemoveRenderer(System.Int32 handle)
  BeyondDynamicBone.RenderData GetRendererData(System.Int32 handle)
  System.Void StartUse(BeyondDynamicBone.ClothProcess cprocess, System.Int32 handle)
  System.Void EndUse(BeyondDynamicBone.ClothProcess cprocess, System.Int32 handle)
  System.Void PreRenderingUpdate()
  System.Void InformationLog(System.Text.StringBuilder allsb)
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.RenderSetupData
TYPE:  class
TOKEN: 0x200015A
FIELDS:
  public            BeyondDynamicBone.ResultCode    result  // 0x10
  public            System.String                   name  // 0x18
  public            System.Boolean                  isManaged  // 0x20
  public            BeyondDynamicBone.RenderSetupData.SetupTypesetupType  // 0x24
  public            UnityEngine.Renderer            renderer  // 0x28
  public            UnityEngine.SkinnedMeshRenderer skinRenderer  // 0x30
  public            UnityEngine.MeshFilter          meshFilter  // 0x38
  public            UnityEngine.Mesh                originalMesh  // 0x40
  public            System.Int32                    vertexCount  // 0x48
  public            System.Boolean                  hasSkinnedMesh  // 0x4C
  public            System.Boolean                  hasBoneWeight  // 0x4D
  public            UnityEngine.Mesh.MeshDataArray  meshDataArray  // 0x50
  public            System.Int32                    skinRootBoneIndex  // 0x60
  public            System.Int32                    skinBoneCount  // 0x64
  public            System.Collections.Generic.List<UnityEngine.Matrix4x4>bindPoseList  // 0x68
  public            Unity.Collections.NativeArray<System.Byte>bonesPerVertexArray  // 0x70
  public            Unity.Collections.NativeArray<UnityEngine.BoneWeight1>boneWeightArray  // 0x80
  public            Unity.Collections.NativeArray<UnityEngine.Vector3>localPositions  // 0x90
  public            Unity.Collections.NativeArray<UnityEngine.Vector3>localNormals  // 0xA0
  public            Unity.Collections.NativeArray<UnityEngine.Vector4>localTangents  // 0xB0
  public            System.Collections.Generic.List<System.Int32>rootTransformIdList  // 0xC0
  public            BeyondDynamicBone.RenderSetupData.BoneConnectionModeboneConnectionMode  // 0xC8
  public            System.Collections.Generic.List<System.Int32>collisionBoneIndexList  // 0xD0
  public            System.Collections.Generic.List<UnityEngine.Transform>transformList  // 0xD8
  public            System.Collections.Generic.List<System.Int32>transformIdList  // 0xE0
  public            System.Collections.Generic.List<System.Int32>transformParentIdList  // 0xE8
  public            System.Collections.Generic.List<Unity.Collections.FixedList512Bytes<System.Int32>>transformChildIdList  // 0xF0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformPositions  // 0xF8
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformRotations  // 0x108
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformLocalPositins  // 0x118
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformLocalRotations  // 0x128
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>transformScales  // 0x138
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>transformInverseRotations  // 0x148
  public            System.Int32                    renderTransformIndex  // 0x158
  public            Unity.Mathematics.float4x4      initRenderLocalToWorld  // 0x15C
  public            Unity.Mathematics.float4x4      initRenderWorldtoLocal  // 0x19C
  public            Unity.Mathematics.quaternion    initRenderRotation  // 0x1DC
  public            Unity.Mathematics.float3        initRenderScale  // 0x1EC
METHODS:
  System.Boolean IsSuccess()
  System.Boolean IsFaild()
  System.Int32 get_TransformCount()
  System.Boolean get_HasMeshDataArray()
  System.Boolean get_HasLocalPositions()
  System.Boolean get_HasTangent()
  System.Void .ctor()
  System.Void .ctor(UnityEngine.Renderer ren)
  System.Void .ctor(BeyondDynamicBone.RenderSetupData.SetupType setType, UnityEngine.Transform renderTransform, System.Collections.Generic.List<UnityEngine.Transform> rootTransforms, System.Collections.Generic.List<UnityEngine.Transform> ignoreFromRootBones, System.Collections.Generic.List<UnityEngine.Transform> collisionBones, BeyondDynamicBone.RenderSetupData.BoneConnectionMode connectionMode, System.String name)
  System.Void ReadTransformInformation(System.Boolean includeChilds)
  System.Void Dispose()
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
  UnityEngine.Transform GetRendeerTransform()
  System.Int32 GetRenderTransformId()
  Unity.Mathematics.float4x4 GetRendeerLocalToWorldMatrix()
  UnityEngine.Transform GetSkinRootTransform()
  System.Int32 GetSkinRootTransformId()
  System.Int32 GetTransformIndexFromId(System.Int32 id)
  System.Int32 GetParentTransformIndex(System.Int32 index, System.Boolean centerExcluded)
  System.Void GetBoneWeightsRun(Unity.Collections.NativeArray<UnityEngine.BoneWeight> weights)
  BeyondDynamicBone.RenderSetupData.ShareSerializationData ShareSerialize()
  BeyondDynamicBone.RenderSetupData ShareDeserialize(BeyondDynamicBone.RenderSetupData.ShareSerializationData sdata)
  BeyondDynamicBone.RenderSetupData.UniqueSerializationData UniqueSerialize()
END_CLASS

CLASS: BeyondDynamicBone.EndSimulationStepKernel_000003B8$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000164
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32 index)
  System.IAsyncResult BeginInvoke(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32 index, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.EndSimulationStepKernel_000003B8$BurstDirectCall
TYPE:  class
TOKEN: 0x2000165
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32 index)
END_CLASS

CLASS: BeyondDynamicBone.EndSimulationStepRangeKernel_000003B9$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000166
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32* lengthPtr)
  System.IAsyncResult BeginInvoke(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32* lengthPtr, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: BeyondDynamicBone.EndSimulationStepRangeKernel_000003B9$BurstDirectCall
TYPE:  class
TOKEN: 0x2000167
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32* lengthPtr)
END_CLASS

CLASS: BeyondDynamicBone.EndSimulationStepJobKernels
TYPE:  class
TOKEN: 0x2000163
FIELDS:
METHODS:
  System.Void EndSimulationStepKernel(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32 index)
  System.Void EndSimulationStepRangeKernel(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32* lengthPtr)
  System.Void EndSimulationStepKernel$BurstManaged(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32 index)
  System.Void EndSimulationStepRangeKernel$BurstManaged(System.Int32* jobColliderIndexList, Unity.Mathematics.float3* nowPositions, Unity.Mathematics.quaternion* nowRotations, Unity.Mathematics.float3* oldPositions, Unity.Mathematics.quaternion* oldRotations, System.Int32* lengthPtr)
END_CLASS

CLASS: BeyondDynamicBone.ColliderManager
TYPE:  class
TOKEN: 0x2000168
FIELDS:
  public            BeyondDynamicBone.ExNativeArray<System.Int16>teamIdArray  // 0x10
  public    static  System.Byte                     Flag_Valid  // 0x0
  public    static  System.Byte                     Flag_Enable  // 0x0
  public    static  System.Byte                     Flag_Reset  // 0x0
  public    static  System.Byte                     Flag_Reverse  // 0x0
  public            BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.ExBitFlag8>flagArray  // 0x18
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>centerArray  // 0x20
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>sizeArray  // 0x28
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>framePositions  // 0x30
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>frameRotations  // 0x38
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>frameScales  // 0x40
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>oldFramePositions  // 0x48
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>oldFrameRotations  // 0x50
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>nowPositions  // 0x58
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>nowRotations  // 0x60
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>oldPositions  // 0x68
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>oldRotations  // 0x70
  public            System.Collections.Generic.HashSet<BeyondDynamicBone.ColliderComponent>colliderSet  // 0x78
  private           System.Boolean                  isValid  // 0x80
  private           BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.ColliderManager.WorkData>workDataArray  // 0x88
METHODS:
  System.Int32 get_DataCount()
  System.Int32 get_ColliderCount()
  System.Void Dispose()
  System.Void EnterdEditMode()
  System.Void Initialize()
  System.Boolean IsValid()
  System.Void Register(BeyondDynamicBone.ClothProcess cprocess)
  System.Void Exit(BeyondDynamicBone.ClothProcess cprocess)
  System.Void InitColliders(BeyondDynamicBone.ClothProcess cprocess)
  System.Void UpdateColliders(BeyondDynamicBone.ClothProcess cprocess)
  System.Void AddCollider(BeyondDynamicBone.ClothProcess cprocess, BeyondDynamicBone.ColliderComponent col)
  System.Void RemoveCollider(BeyondDynamicBone.ColliderComponent col, System.Int32 teamId)
  System.Void AddColliderInternal(BeyondDynamicBone.ClothProcess cprocess, BeyondDynamicBone.ColliderComponent col, System.Int32 index, System.Int32 arrayIndex, System.Int32 transformIndex)
  System.Void EnableCollider(BeyondDynamicBone.ColliderComponent col, System.Int32 teamId, System.Boolean sw)
  System.Void EnableTeamCollider(System.Int32 teamId)
  System.Void UpdateParameters(BeyondDynamicBone.ColliderComponent col, System.Int32 teamId)
  Unity.Jobs.JobHandle PreSimulationUpdate(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle CreateUpdateColliderList(System.Int32 updateIndex, Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle StartSimulationStep(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle EndSimulationStep(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle PostSimulationUpdate(Unity.Jobs.JobHandle jobHandle)
  System.Void InformationLog(System.Text.StringBuilder allsb)
  System.Void .ctor()
  System.Void Initialize$CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListKernel_000003D3$BurstDirectCall()
  System.Void Initialize$CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListRangeKernel_000003D4$BurstDirectCall()
  System.Void Initialize$PostSimulationUpdateJobKernels_PostSimulationUpdateKernel_000003D7$BurstDirectCall()
  System.Void Initialize$PostSimulationUpdateJobKernels_PostSimulationUpdateRangeKernel_000003D8$BurstDirectCall()
END_CLASS

CLASS: BeyondDynamicBone.SimulationManager
TYPE:  class
TOKEN: 0x2000184
FIELDS:
  public            BeyondDynamicBone.ExNativeArray<System.Int16>teamIdArray  // 0x10
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>nextPosArray  // 0x18
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>oldPosArray  // 0x20
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>oldRotArray  // 0x28
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>basePosArray  // 0x30
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>baseRotArray  // 0x38
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>oldPositionArray  // 0x40
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.quaternion>oldRotationArray  // 0x48
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>velocityPosArray  // 0x50
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>dispPosArray  // 0x58
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>velocityArray  // 0x60
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>realVelocityArray  // 0x68
  public            BeyondDynamicBone.ExNativeArray<System.Single>frictionArray  // 0x70
  public            BeyondDynamicBone.ExNativeArray<System.Single>staticFrictionArray  // 0x78
  public            BeyondDynamicBone.ExNativeArray<Unity.Mathematics.float3>collisionNormalArray  // 0x80
  public            BeyondDynamicBone.DistanceConstraintdistanceConstraint  // 0x88
  public            BeyondDynamicBone.TriangleBendingConstraintbendingConstraint  // 0x90
  public            BeyondDynamicBone.TetherConstrainttetherConstraint  // 0x98
  public            BeyondDynamicBone.AngleConstraintangleConstraint  // 0xA0
  public            BeyondDynamicBone.InertiaConstraintinertiaConstraint  // 0xA8
  public            BeyondDynamicBone.ColliderCollisionConstraintcolliderCollisionConstraint  // 0xB0
  public            BeyondDynamicBone.MotionConstraintmotionConstraint  // 0xB8
  public            BeyondDynamicBone.SelfCollisionConstraintselfCollisionConstraint  // 0xC0
  private           BeyondDynamicBone.ExProcessingList<System.Int32>processingStepParticle  // 0xC8
  private           BeyondDynamicBone.ExProcessingList<System.Int32>processingStepTriangleBending  // 0xD0
  private           BeyondDynamicBone.ExProcessingList<System.Int32>processingStepEdgeCollision  // 0xD8
  private           BeyondDynamicBone.ExProcessingList<System.Int32>processingStepCollider  // 0xE0
  private           BeyondDynamicBone.ExProcessingList<System.Int32>processingStepBaseLine  // 0xE8
  private           BeyondDynamicBone.ExProcessingList<System.Int32>processingStepMotionParticle  // 0xF0
  private           BeyondDynamicBone.ExProcessingList<System.Int32>processingSelfParticle  // 0xF8
  private           BeyondDynamicBone.ExProcessingList<System.UInt32>processingSelfPointTriangle  // 0x100
  private           BeyondDynamicBone.ExProcessingList<System.UInt32>processingSelfEdgeEdge  // 0x108
  private           BeyondDynamicBone.ExProcessingList<System.UInt32>processingSelfTrianglePoint  // 0x110
  private           Unity.Collections.NativeArray<Unity.Mathematics.float3>tempFloat3Buffer  // 0x118
  private           Unity.Collections.NativeArray<System.Int32>countArray  // 0x128
  private           Unity.Collections.NativeArray<System.Int32>sumArray  // 0x138
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>stepBasicPositionBuffer  // 0x148
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>stepBasicRotationBuffer  // 0x158
  private           System.Int32                    <SimulationStepCount>k__BackingField  // 0x168
  private           System.Boolean                  isValid  // 0x16C
METHODS:
  System.Int32 get_ParticleCount()
  System.Int32 get_SimulationStepCount()
  System.Void set_SimulationStepCount(System.Int32 value)
  System.Int32 get_WorkerCount()
  System.Void Dispose()
  System.Void EnterdEditMode()
  System.Void Initialize()
  System.Boolean IsValid()
  System.Void RegisterProxyMesh(BeyondDynamicBone.ClothProcess cprocess)
  System.Void RegisterConstraint(BeyondDynamicBone.ClothProcess cprocess)
  System.Void ExitProxyMesh(BeyondDynamicBone.ClothProcess cprocess)
  System.Void WorkBufferUpdate()
  Unity.Jobs.JobHandle PreSimulationUpdate(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle SimulationStepUpdate(System.Int32 updateCount, System.Int32 updateIndex, Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle CalcDisplayPosition(Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle FeedbackTempFloat3Buffer(Unity.Collections.NativeList<System.Int32>& particleList, Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle FeedbackTempFloat3Buffer(BeyondDynamicBone.ExProcessingList<System.Int32>& processingList, Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle FeedbackTempFloat3Buffer(Unity.Collections.NativeArray<System.Int32>& particleArray, Unity.Collections.NativeReference<System.Int32>& counter, Unity.Jobs.JobHandle jobHandle)
  System.Void InformationLog(System.Text.StringBuilder allsb)
  System.Void .ctor()
  System.Void Initialize$StartSimulationStepJobKernels_StartSimulationStepKernel_00000405$BurstDirectCall()
  System.Void Initialize$StartSimulationStepJobKernels_StartSimulationStepRangeKernel_00000406$BurstDirectCall()
  System.Void Initialize$StartSimulationStepJobKernels_Spring_00000407$BurstDirectCall()
  System.Void Initialize$StartSimulationStepJobKernels_Wind_00000408$BurstDirectCall()
  System.Void Initialize$StartSimulationStepJobKernels_WindForceBlend_00000409$BurstDirectCall()
  System.Void Initialize$UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureKernel_0000040A$BurstDirectCall()
  System.Void Initialize$UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureRangeKernel_0000040B$BurstDirectCall()
  System.Void Initialize$EndSimulationStepJobKernels_EndSimulationStepKernel_0000040C$BurstDirectCall()
  System.Void Initialize$EndSimulationStepJobKernels_EndSimulationStepRangeKernel_0000040D$BurstDirectCall()
  System.Void Initialize$CalcDisplayPositionJobKernels_CalcDisplayPositionKernel_0000040E$BurstDirectCall()
  System.Void Initialize$CalcDisplayPositionJobKernels_CalcDisplayPositionRangeKernel_0000040F$BurstDirectCall()
  System.Void Initialize$ClearStepCounterKernels_ClearStepCounterKernel_00000410$BurstDirectCall()
END_CLASS

CLASS: BeyondDynamicBone.TimeManager
TYPE:  class
TOKEN: 0x20001B5
FIELDS:
  private           System.Int32                    simulationFrequency  // 0x10
  private           System.Int32                    maxSimulationCountPerFrame  // 0x14
  private           BeyondDynamicBone.TimeManager.UpdateLocationupdateLocation  // 0x18
  private           System.Boolean                  isValid  // 0x1C
  private           System.Int32                    <FixedUpdateCount>k__BackingField  // 0x20
  private           System.Single                   GlobalTimeScale  // 0x24
  private           System.Single                   <SimulationDeltaTime>k__BackingField  // 0x28
  private           System.Single                   <MaxDeltaTime>k__BackingField  // 0x2C
  private           Unity.Mathematics.float4        <SimulationPower>k__BackingField  // 0x30
  private   static  System.Single                   <DeltaTime>k__BackingField  // 0x0
  private   static  System.Single                   <FixedDeltaTime>k__BackingField  // 0x4
  private   static  System.Single                   <UnscaledDeltaTime>k__BackingField  // 0x8
  private   static  System.Boolean                  <EnableAOVMode>k__BackingField  // 0xC
METHODS:
  System.Int32 get_FixedUpdateCount()
  System.Void set_FixedUpdateCount(System.Int32 value)
  System.Single get_SimulationDeltaTime()
  System.Void set_SimulationDeltaTime(System.Single value)
  System.Single get_MaxDeltaTime()
  System.Void set_MaxDeltaTime(System.Single value)
  Unity.Mathematics.float4 get_SimulationPower()
  System.Void set_SimulationPower(Unity.Mathematics.float4 value)
  System.Single get_DeltaTime()
  System.Void set_DeltaTime(System.Single value)
  System.Single get_FixedDeltaTime()
  System.Void set_FixedDeltaTime(System.Single value)
  System.Single get_UnscaledDeltaTime()
  System.Void set_UnscaledDeltaTime(System.Single value)
  System.Boolean get_EnableAOVMode()
  System.Void set_EnableAOVMode(System.Boolean value)
  System.Void Dispose()
  System.Void EnterdEditMode()
  System.Void Initialize()
  System.Boolean IsValid()
  System.Void AfterFixedUpdate()
  System.Void AfterRenderring()
  System.Single GetDeltaTime()
  System.Single GetFixedDeltaTime()
  System.Single GetUnscaledDeltaTime()
  System.Void FrameUpdate()
  System.Void InformationLog(System.Text.StringBuilder allsb)
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.WindManager
TYPE:  class
TOKEN: 0x20001B7
FIELDS:
  public    static  System.Int32                    Flag_Valid  // 0x0
  public    static  System.Int32                    Flag_Enable  // 0x0
  public    static  System.Int32                    Flag_Addition  // 0x0
  public            BeyondDynamicBone.ExNativeArray<BeyondDynamicBone.WindManager.WindData>windDataArray  // 0x10
  private           System.Boolean                  isValid  // 0x18
  private           System.Collections.Generic.Dictionary<System.Int32,BeyondDynamicBone.BeyondBoneWindZone>windZoneDict  // 0x20
METHODS:
  System.Int32 get_WindCount()
  System.Void Dispose()
  System.Void EnterdEditMode()
  System.Void Initialize()
  System.Boolean IsValid()
  System.Int32 AddWind(BeyondDynamicBone.BeyondBoneWindZone windZone)
  System.Void RemoveWind(System.Int32 windId)
  System.Void SetEnable(System.Int32 windId, System.Boolean sw)
  System.Void AlwaysWindUpdate()
  System.Void InformationLog(System.Text.StringBuilder allsb)
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.TeamWindInfo
TYPE:  struct
TOKEN: 0x20001B9
FIELDS:
  public            System.Int32                    windId  // 0x10
  public            System.Single                   time  // 0x14
  public            System.Single                   main  // 0x18
  public            Unity.Mathematics.float3        direction  // 0x1C
METHODS:
  System.Boolean IsValid()
  System.String ToString()
  System.Void DebugLog()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.TeamWindData
TYPE:  struct
TOKEN: 0x20001BA
FIELDS:
  public            Unity.Collections.FixedList128Bytes<BeyondDynamicBone.TeamWindInfo>windZoneList  // 0x10
  public            BeyondDynamicBone.TeamWindInfo  movingWind  // 0x90
METHODS:
  System.Int32 get_ZoneCount()
  System.Int32 IndexOf(System.Int32 windId)
  System.Void ClearZoneList()
  System.Void AddOrReplaceWindZone(BeyondDynamicBone.TeamWindInfo windInfo, BeyondDynamicBone.TeamWindData& oldWindData)
  System.Void RemoveWindZone(System.Int32 windId)
END_CLASS

CLASS: BeyondDynamicBone.TransformData
TYPE:  class
TOKEN: 0x20001BB
FIELDS:
  private           System.Collections.Generic.List<UnityEngine.Transform>transformList  // 0x10
  private           BeyondDynamicBone.ExSimpleNativeArray<BeyondDynamicBone.ExBitFlag8>flagArray  // 0x18
  private           BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3>initLocalPositionArray  // 0x20
  private           BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.quaternion>initLocalRotationArray  // 0x28
  private           BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3>positionArray  // 0x30
  private           BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.quaternion>rotationArray  // 0x38
  private           BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.quaternion>inverseRotationArray  // 0x40
  private           BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3>scaleArray  // 0x48
  private           BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3>localPositionArray  // 0x50
  private           BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.quaternion>localRotationArray  // 0x58
  private           BeyondDynamicBone.ExSimpleNativeArray<System.Int32>idArray  // 0x60
  private           BeyondDynamicBone.ExSimpleNativeArray<System.Int32>parentIdArray  // 0x68
  private           System.Collections.Generic.List<System.Int32>rootIdList  // 0x70
  private           System.Boolean                  isDirty  // 0x78
  private           UnityEngine.Jobs.TransformAccessArraytransformAccessArray  // 0x80
  private           System.Collections.Generic.Queue<System.Int32>emptyStack  // 0x88
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 capacity)
  System.Void Init(System.Int32 capacity)
  System.Void Dispose()
  System.Int32 get_Count()
  System.Int32 get_RootCount()
  System.Boolean get_IsDirty()
  System.Boolean get_IsEmpty()
  System.Int32 AddTransform(UnityEngine.Transform t, System.Int32 tid, System.Int32 pid, System.Byte flag, System.Boolean checkDuplicate)
  System.Int32 AddTransform(BeyondDynamicBone.TransformRecord record, System.Int32 pid, System.Byte flag, System.Boolean checkDuplicate)
  System.Int32 AddTransform(BeyondDynamicBone.TransformData srcData, System.Int32 srcIndex, System.Boolean checkDuplicate)
  System.Int32[] AddTransformRange(System.Collections.Generic.List<UnityEngine.Transform> tlist, System.Collections.Generic.List<System.Int32> idList, System.Collections.Generic.List<System.Int32> pidList, System.Int32 copyCount)
  System.Int32[] AddTransformRange(BeyondDynamicBone.TransformData stdata, System.Int32 copyCount)
  System.Int32[] AddTransformRange(System.Collections.Generic.List<UnityEngine.Transform> tlist, System.Collections.Generic.List<System.Int32> idList, System.Collections.Generic.List<System.Int32> pidList, System.Collections.Generic.List<System.Int32> rootIds, Unity.Collections.NativeArray<Unity.Mathematics.float3> localPositions, Unity.Collections.NativeArray<Unity.Mathematics.quaternion> localRotations, Unity.Collections.NativeArray<Unity.Mathematics.float3> positions, Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotations, Unity.Collections.NativeArray<Unity.Mathematics.float3> scales, Unity.Collections.NativeArray<Unity.Mathematics.quaternion> inverseRotations)
  System.Void RemoveTransformIndex(System.Int32 index)
  System.Int32 ReplaceTransform(System.Int32 index, UnityEngine.Transform t, System.Int32 tid, System.Int32 pid, System.Byte flag)
  System.Int32 ReferenceIndexOf(System.Collections.Generic.List<T> list, T item)
  System.Void UpdateWorkData()
  Unity.Jobs.JobHandle RestoreTransform(System.Int32 count, Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle ReadTransform(Unity.Jobs.JobHandle jobHandle)
  System.Void ReadTransformRun()
  System.Void OrganizeReductionTransform(BeyondDynamicBone.VirtualMesh vmesh, BeyondDynamicBone.ReductionWorkData workData)
  UnityEngine.Transform GetTransformFromIndex(System.Int32 index)
  System.Int32 GetTransformIndexFormId(System.Int32 id)
  System.Int32 GetTransformIdFromIndex(System.Int32 index)
  System.Int32 GetParentIdFromIndex(System.Int32 index)
  Unity.Mathematics.float4x4 GetLocalToWorldMatrix(System.Int32 index)
  Unity.Mathematics.float4x4 GetWorldToLocalMatrix(System.Int32 index)
  System.String ToString()
  BeyondDynamicBone.TransformData.ShareSerializationData ShareSerialize()
  BeyondDynamicBone.TransformData ShareDeserialize(BeyondDynamicBone.TransformData.ShareSerializationData sdata)
  BeyondDynamicBone.TransformData.UniqueSerializationData UniqueSerialize()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.TransformRecord
TYPE:  class
TOKEN: 0x20001C0
FIELDS:
  public            UnityEngine.Transform           transform  // 0x10
  public            System.Int32                    id  // 0x18
  public            UnityEngine.Vector3             localPosition  // 0x1C
  public            UnityEngine.Quaternion          localRotation  // 0x28
  public            UnityEngine.Vector3             position  // 0x38
  public            UnityEngine.Quaternion          rotation  // 0x44
  public            UnityEngine.Vector3             scale  // 0x54
  public            UnityEngine.Matrix4x4           localToWorldMatrix  // 0x60
  public            UnityEngine.Matrix4x4           worldToLocalMatrix  // 0xA0
  public            System.Int32                    pid  // 0xE0
METHODS:
  System.Void .ctor(UnityEngine.Transform t)
  UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3 dir)
  System.Boolean IsValid()
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
END_CLASS

CLASS: BeyondDynamicBone.PreBuildScriptableObject
TYPE:  class
TOKEN: 0x20001C1
EXTENDS: ScriptableObject
FIELDS:
  public            System.Collections.Generic.List<BeyondDynamicBone.SharePreBuildData>sharePreBuildDataList  // 0x18
METHODS:
  System.Boolean HasPreBuildData(System.String buildId)
  BeyondDynamicBone.SharePreBuildData GetPreBuildData(System.String buildId)
  System.Void AddPreBuildData(BeyondDynamicBone.SharePreBuildData sdata)
  System.Void Warmup()
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.PreBuildSerializeData
TYPE:  class
TOKEN: 0x20001C4
FIELDS:
  public            System.Boolean                  enabled  // 0x10
  public            BeyondDynamicBone.SharePreBuildDatapreBuildData  // 0x18
  public            BeyondDynamicBone.UniquePreBuildDatauniquePreBuildData  // 0x20
METHODS:
  System.Boolean UsePreBuild()
  BeyondDynamicBone.ResultCode DataValidate()
  BeyondDynamicBone.SharePreBuildData GetSharePreBuildData()
  System.String GenerateBuildID()
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.SharePreBuildData
TYPE:  class
TOKEN: 0x20001C5
FIELDS:
  public            System.Int32                    version  // 0x10
  public            System.String                   buildId  // 0x18
  public            BeyondDynamicBone.ResultCode    buildResult  // 0x20
  public            UnityEngine.Vector3             buildScale  // 0x28
  public            System.Collections.Generic.List<BeyondDynamicBone.RenderSetupData.ShareSerializationData>renderSetupDataList  // 0x38
  public            BeyondDynamicBone.VirtualMesh.ShareSerializationDataproxyMesh  // 0x40
  public            System.Collections.Generic.List<BeyondDynamicBone.VirtualMesh.ShareSerializationData>renderMeshList  // 0x48
  public            BeyondDynamicBone.DistanceConstraint.ConstraintDatadistanceConstraintData  // 0x50
  public            BeyondDynamicBone.TriangleBendingConstraint.ConstraintDatabendingConstraintData  // 0x58
  public            BeyondDynamicBone.InertiaConstraint.ConstraintDatainertiaConstraintData  // 0x60
METHODS:
  BeyondDynamicBone.ResultCode DataValidate()
  System.Boolean CheckBuildId(System.String buildId)
  System.String ToString()
  System.Void .ctor()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.UniquePreBuildData
TYPE:  class
TOKEN: 0x20001C6
FIELDS:
  public            System.Int32                    version  // 0x10
  public            BeyondDynamicBone.ResultCode    buildResult  // 0x14
  public            System.Collections.Generic.List<BeyondDynamicBone.RenderSetupData.UniqueSerializationData>renderSetupDataList  // 0x20
  public            BeyondDynamicBone.VirtualMesh.UniqueSerializationDataproxyMesh  // 0x28
  public            System.Collections.Generic.List<BeyondDynamicBone.VirtualMesh.UniqueSerializationData>renderMeshList  // 0x30
METHODS:
  BeyondDynamicBone.ResultCode DataValidate()
  System.Void GetUsedTransform(System.Collections.Generic.HashSet<UnityEngine.Transform> transformSet)
  System.Void ReplaceTransform(System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Transform> replaceDict)
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.ReductionSettings
TYPE:  class
TOKEN: 0x20001C9
FIELDS:
  public            System.Single                   simpleDistance  // 0x10
  public            System.Single                   shapeDistance  // 0x14
METHODS:
  System.Boolean get_IsEnabled()
  System.Single GetMaxConnectionDistance()
  BeyondDynamicBone.ReductionSettings Clone()
  System.Void DataValidate()
  System.Int32 GetHashCode()
  System.String ToString()
  System.Void .ctor()
  System.Int32 <>iFixBaseProxy_GetHashCode()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.ReductionWorkData
TYPE:  class
TOKEN: 0x20001CA
FIELDS:
  public            BeyondDynamicBone.VirtualMesh   vmesh  // 0x10
  public            Unity.Collections.NativeArray<System.Int32>vertexJoinIndices  // 0x18
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>vertexToVertexMap  // 0x28
  public            Unity.Collections.NativeArray<System.Int32>vertexRemapIndices  // 0x38
  public            Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>useSkinBoneMap  // 0x48
  public            Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>newVertexToVertexMap  // 0x58
  public            Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int2>edgeSet  // 0x68
  public            Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int3>triangleSet  // 0x78
  public            System.Int32                    oldVertexCount  // 0x88
  public            System.Int32                    newVertexCount  // 0x8C
  public            System.Int32                    removeVertexCount  // 0x90
  public            BeyondDynamicBone.ExSimpleNativeArray<BeyondDynamicBone.VertexAttribute>newAttributes  // 0x98
  public            BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3>newLocalPositions  // 0xA0
  public            BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3>newLocalNormals  // 0xA8
  public            BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3>newLocalTangents  // 0xB0
  public            BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float2>newUv  // 0xB8
  public            BeyondDynamicBone.ExSimpleNativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>newBoneWeights  // 0xC0
  public            Unity.Collections.NativeReference<System.Int32>newSkinBoneCount  // 0xC8
  public            Unity.Collections.NativeList<System.Int32>newSkinBoneTransformIndices  // 0xD8
  public            Unity.Collections.NativeList<Unity.Mathematics.float4x4>newSkinBoneBindPoseList  // 0xE8
  public            Unity.Collections.NativeList<Unity.Mathematics.int2>newLineList  // 0xF8
  public            Unity.Collections.NativeList<Unity.Mathematics.int3>newTriangleList  // 0x108
METHODS:
  System.Void .ctor(BeyondDynamicBone.VirtualMesh vmesh)
  System.Void Dispose()
END_CLASS

CLASS: BeyondDynamicBone.SameDistanceReduction
TYPE:  class
TOKEN: 0x20001CB
FIELDS:
  private           System.String                   name  // 0x10
  private           BeyondDynamicBone.VirtualMesh   vmesh  // 0x18
  private           BeyondDynamicBone.ReductionWorkDataworkData  // 0x20
  private           BeyondDynamicBone.ResultCode    result  // 0x28
  private           System.Single                   mergeLength  // 0x30
  private           BeyondDynamicBone.GridMap<System.Int32>gridMap  // 0x38
  private           Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>joinPairMap  // 0x40
  private           Unity.Collections.NativeReference<System.Int32>resultRef  // 0x50
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String name, BeyondDynamicBone.VirtualMesh mesh, BeyondDynamicBone.ReductionWorkData workingData, System.Single mergeLength)
  System.Void Dispose()
  BeyondDynamicBone.ResultCode get_Result()
  BeyondDynamicBone.ResultCode Reduction()
  System.Void UpdateJoinAndLink()
  System.Void UpdateReductionResultJob()
END_CLASS

CLASS: BeyondDynamicBone.ShapeDistanceReduction
TYPE:  class
TOKEN: 0x20001D2
EXTENDS: StepReductionBase
FIELDS:
METHODS:
  System.Void .ctor(System.String name, BeyondDynamicBone.VirtualMesh mesh, BeyondDynamicBone.ReductionWorkData workingData, System.Single startMergeLength, System.Single endMergeLength, System.Int32 maxStep, System.Boolean dontMakeLine, System.Single joinPositionAdjustment)
  System.Void Dispose()
  System.Void StepInitialize()
  System.Void CustomReductionStep()
  System.Void <>iFixBaseProxy_Dispose()
  System.Void <>iFixBaseProxy_StepInitialize()
  System.Void <>iFixBaseProxy_CustomReductionStep()
END_CLASS

CLASS: BeyondDynamicBone.SimpleDistanceReduction
TYPE:  class
TOKEN: 0x20001D4
EXTENDS: StepReductionBase
FIELDS:
  private           BeyondDynamicBone.GridMap<System.Int32>gridMap  // 0x90
METHODS:
  System.Void .ctor(System.String name, BeyondDynamicBone.VirtualMesh mesh, BeyondDynamicBone.ReductionWorkData workingData, System.Single startMergeLength, System.Single endMergeLength, System.Int32 maxStep, System.Boolean dontMakeLine, System.Single joinPositionAdjustment)
  System.Void Dispose()
  System.Void StepInitialize()
  System.Void CustomReductionStep()
  System.Void <>iFixBaseProxy_Dispose()
  System.Void <>iFixBaseProxy_StepInitialize()
  System.Void <>iFixBaseProxy_CustomReductionStep()
END_CLASS

CLASS: BeyondDynamicBone.StepReductionBase
TYPE:  class
TOKEN: 0x20001D7
FIELDS:
  protected         System.String                   name  // 0x10
  protected         BeyondDynamicBone.VirtualMesh   vmesh  // 0x18
  protected         BeyondDynamicBone.ReductionWorkDataworkData  // 0x20
  protected         BeyondDynamicBone.ResultCode    result  // 0x28
  protected         System.Single                   startMergeLength  // 0x30
  protected         System.Single                   endMergeLength  // 0x34
  protected         System.Int32                    maxStep  // 0x38
  protected         System.Boolean                  dontMakeLine  // 0x3C
  protected         System.Single                   joinPositionAdjustment  // 0x40
  protected         System.Int32                    nowStepIndex  // 0x44
  protected         System.Single                   nowMergeLength  // 0x48
  protected         System.Single                   nowStepScale  // 0x4C
  protected         Unity.Collections.NativeList<BeyondDynamicBone.StepReductionBase.JoinEdge>joinEdgeList  // 0x50
  private           Unity.Collections.NativeParallelHashSet<System.Int32>completeVertexSet  // 0x60
  private           Unity.Collections.NativeList<Unity.Mathematics.int2>removePairList  // 0x70
  private           Unity.Collections.NativeArray<System.Int32>resultArray  // 0x80
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String name, BeyondDynamicBone.VirtualMesh mesh, BeyondDynamicBone.ReductionWorkData workingData, System.Single startMergeLength, System.Single endMergeLength, System.Int32 maxStep, System.Boolean dontMakeLine, System.Single joinPositionAdjustment)
  System.Void Dispose()
  BeyondDynamicBone.ResultCode get_Result()
  BeyondDynamicBone.ResultCode Reduction()
  System.Void InitStep()
  System.Boolean IsEndStep()
  System.Void NextStep()
  System.Void ReductionStep()
  System.Void StepInitialize()
  System.Void CustomReductionStep()
  System.Void PreReductionStep()
  System.Void PostReductionStep()
  System.Void SortJoinEdge()
  System.Void DetermineJoinEdge()
  System.Void RunJoinEdge()
  System.Void UpdateJoinAndLink()
  System.Void UpdateReductionResultJob()
  System.Boolean CheckJoin2(Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>& vertexToVertexMap, System.Int32 vindex, System.Int32 tvindex, System.Boolean dontMakeLine)
  System.Boolean CheckJoin(Unity.Collections.NativeArray<Unity.Collections.FixedList128Bytes<System.UInt16>>& vertexToVertexArray, System.Int32 vindex, System.Int32 tvindex, Unity.Collections.FixedList128Bytes<System.UInt16>& vlist, Unity.Collections.FixedList128Bytes<System.UInt16>& tvlist, System.Boolean dontMakeLine)
END_CLASS

CLASS: BeyondDynamicBone.ClothDebugSettings
TYPE:  class
TOKEN: 0x20001DE
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Boolean                  ztest  // 0x11
  public            System.Boolean                  position  // 0x12
  public            BeyondDynamicBone.ClothDebugSettings.DebugAxisaxis  // 0x14
  public            System.Boolean                  shape  // 0x18
  public            System.Boolean                  baseLine  // 0x19
  public            System.Boolean                  depth  // 0x1A
  public            System.Boolean                  collider  // 0x1B
  public            System.Boolean                  animatedPosition  // 0x1C
  public            BeyondDynamicBone.ClothDebugSettings.DebugAxisanimatedAxis  // 0x20
  public            System.Boolean                  animatedShape  // 0x24
  public            System.Boolean                  inertiaCenter  // 0x25
  public            System.Boolean                  customSkinningBone  // 0x26
METHODS:
  System.Boolean CheckParticleDrawing(System.Int32 index)
  System.Boolean CheckTriangleDrawing(System.Int32 index)
  System.Boolean CheckRadiusDrawing()
  System.Single GetPointSize()
  System.Single GetLineSize()
  System.Single GetInertiaCenterRadius()
  System.Single GetCustomSkinningRadius()
  System.Boolean IsReferOldPos()
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.DataUtility
TYPE:  class
TOKEN: 0x20001E0
FIELDS:
METHODS:
  Unity.Mathematics.int2 PackInt2(System.Int32 d0, System.Int32 d1)
  Unity.Mathematics.int2 PackInt2(Unity.Mathematics.int2& d)
  Unity.Mathematics.int3 PackInt3(System.Int32 d0, System.Int32 d1, System.Int32 d2)
  Unity.Mathematics.int3 PackInt3(Unity.Mathematics.int3& d)
  Unity.Mathematics.int4 PackInt4(System.Int32 d0, System.Int32 d1, System.Int32 d2, System.Int32 d3)
  Unity.Mathematics.int4 PackInt4(Unity.Mathematics.int4 d)
  System.UInt32 Pack32(System.Int32 hi, System.Int32 low)
  System.UInt32 Pack32Sort(System.Int32 a, System.Int32 b)
  System.Int32 Unpack32Hi(System.UInt32 pack)
  System.Int32 Unpack32Low(System.UInt32 pack)
  System.UInt32 Pack12_20(System.Int32 hi, System.Int32 low)
  System.Int32 Unpack12_20Hi(System.UInt32 pack)
  System.Int32 Unpack12_20Low(System.UInt32 pack)
  System.Void Unpack12_20(System.UInt32 pack, System.Int32& hi, System.Int32& low)
  System.UInt64 Pack64(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w)
  System.UInt64 Pack64(Unity.Mathematics.int4& a)
  Unity.Mathematics.int4 Unpack64(System.UInt64& pack)
  System.Int32 Unpack64X(System.UInt64& pack)
  System.Int32 Unpack64Y(System.UInt64& pack)
  System.Int32 Unpack64Z(System.UInt64& pack)
  System.Int32 Unpack64W(System.UInt64& pack)
  System.UInt32 Pack32(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w)
  System.UInt64 Pack32(Unity.Mathematics.int4& a)
  Unity.Mathematics.int4 Unpack32(System.UInt32& pack)
  System.Int32 RemainingData(Unity.Mathematics.int3& data, Unity.Mathematics.int2& use)
  Unity.Mathematics.float4x4 ConvertAnimationCurve(UnityEngine.AnimationCurve curve)
  System.Single EvaluateCurve(Unity.Mathematics.float4x4& curve, System.Single time)
  BeyondDynamicBone.ColliderManager.ColliderType GetColliderType(BeyondDynamicBone.ExBitFlag8& flag)
  BeyondDynamicBone.ExBitFlag8 SetColliderType(BeyondDynamicBone.ExBitFlag8 flag, BeyondDynamicBone.ColliderManager.ColliderType ctype)
  System.Void ArrayCopy(T[] src, T[]& dst)
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.MultiDataBuilder`1
TYPE:  class
TOKEN: 0x20001E1
FIELDS:
  private           System.Int32                    indexCount  // 0x0
  public            Unity.Collections.NativeParallelMultiHashMap<System.Int32,T>Map  // 0x0
METHODS:
  System.Void .ctor(System.Int32 indexCount, System.Int32 dataCapacity)
  System.Void Dispose()
  System.Int32 Count()
  System.Int32 GetDataCount(System.Int32 index)
  System.Void Add(System.Int32 key, T data)
  System.Int32 CountValuesForKey(System.Int32 key)
  System.ValueTuple<T[],System.UInt32[]> ToArray()
  System.UInt32[] ToIndexArray()
  System.Void ToNativeArray(Unity.Collections.NativeArray<System.UInt32>& indexArray, Unity.Collections.NativeArray<T>& dataArray)
END_CLASS

CLASS: BeyondDynamicBone.GridMap`1
TYPE:  class
TOKEN: 0x20001E2
FIELDS:
  private           Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T>gridMap  // 0x0
METHODS:
  System.Void .ctor(System.Int32 capacity)
  System.Void Dispose()
  Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> GetMultiHashMap()
  System.Int32 get_DataCount()
  BeyondDynamicBone.GridMap.GridEnumerator<T> GetArea(Unity.Mathematics.int3 startGrid, Unity.Mathematics.int3 endGrid, Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> gridMap)
  BeyondDynamicBone.GridMap.GridEnumerator<T> GetArea(Unity.Mathematics.float3 pos, System.Single radius, Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> gridMap, System.Single gridSize)
  Unity.Mathematics.int3 GetGrid(Unity.Mathematics.float3 pos, System.Single gridSize)
  System.Void AddGrid(Unity.Mathematics.int3 grid, T data, Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> gridMap)
  Unity.Mathematics.int3 AddGrid(Unity.Mathematics.float3 pos, T data, Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> gridMap, System.Single gridSize)
  Unity.Mathematics.int3 AddGrid(Unity.Mathematics.float3 pos, T data, Unity.Collections.NativeParallelMultiHashMap.ParallelWriter<Unity.Mathematics.int3,T> gridMap, System.Single gridSize)
  System.Boolean RemoveGrid(Unity.Mathematics.int3 grid, T data, Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> gridMap)
  System.Boolean MoveGrid(Unity.Mathematics.int3 fromGrid, Unity.Mathematics.int3 toGrid, T data, Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int3,T> gridMap)
END_CLASS

CLASS: BeyondDynamicBone.ClothJobUtility
TYPE:  class
TOKEN: 0x20001E4
FIELDS:
METHODS:
  Unity.Jobs.JobHandle Fill(Unity.Collections.NativeArray<System.Byte> array, System.Int32 length, System.Byte value, Unity.Jobs.JobHandle dependsOn)
  System.Void FillRun(Unity.Collections.NativeArray<System.Int32> array, System.Int32 length, System.Int32 value)
  System.Void FillRun(Unity.Collections.NativeArray<Unity.Mathematics.quaternion> array, System.Int32 length, Unity.Mathematics.quaternion value)
  System.Void FillRun(Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> array, System.Int32 length, BeyondDynamicBone.VirtualMeshBoneWeight value)
  Unity.Jobs.JobHandle Fill(Unity.Collections.NativeArray<System.Int32> array, System.Int32 startIndex, System.Int32 length, System.Int32 value, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle Fill(Unity.Collections.NativeReference<System.Int32> reference, System.Int32 value, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle SerialNumber(Unity.Collections.NativeArray<System.Int32> array, System.Int32 length, Unity.Jobs.JobHandle dependsOn)
  System.Void SerialNumberRun(Unity.Collections.NativeArray<System.Int32> array, System.Int32 length)
  Unity.Jobs.JobHandle ConvertHashSetToNativeList(Unity.Collections.NativeParallelHashSet<System.Int32> hashSet, Unity.Collections.NativeList<System.Int32> list, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle ConvertHashSetKeyToNativeList(Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int2> hashSet, Unity.Collections.NativeList<Unity.Mathematics.int2> keyList, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle ConvertHashSetKeyToNativeList(Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int4> hashSet, Unity.Collections.NativeList<Unity.Mathematics.int4> keyList, Unity.Jobs.JobHandle dependsOn)
  Unity.Jobs.JobHandle CalcAABB(Unity.Collections.NativeArray<Unity.Mathematics.float3> positions, System.Int32 length, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> outAABB, Unity.Jobs.JobHandle dependsOn)
  System.Void CalcAABBRun(Unity.Collections.NativeArray<Unity.Mathematics.float3> positions, System.Int32 length, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> outAABB)
  Unity.Jobs.JobHandle CalcAABB(Unity.Collections.NativeList<Unity.Mathematics.float3> positions, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> outAABB, Unity.Jobs.JobHandle dependsOn)
  System.Void CalcAABBRun(Unity.Collections.NativeList<Unity.Mathematics.float3> positions, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> outAABB)
  BeyondDynamicBone.AABB CalcAABBInternal(Unity.Collections.NativeArray<Unity.Mathematics.float3>& positions, System.Int32 length)
  Unity.Jobs.JobHandle CalcUVWithSphereMapping(Unity.Collections.NativeArray<Unity.Mathematics.float3> positions, System.Int32 length, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> aabb, Unity.Collections.NativeArray<Unity.Mathematics.float2> outUVs, Unity.Jobs.JobHandle dependsOn)
  System.Void CalcUVWithSphereMappingRun(Unity.Collections.NativeArray<Unity.Mathematics.float3> positions, System.Int32 length, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> aabb, Unity.Collections.NativeArray<Unity.Mathematics.float2> outUVs)
  Unity.Jobs.JobHandle TransformPosition(Unity.Collections.NativeArray<Unity.Mathematics.float3> positions, System.Int32 length, Unity.Mathematics.float4x4& toM, Unity.Jobs.JobHandle dependsOn)
  System.Void TransformPositionRun(Unity.Collections.NativeArray<Unity.Mathematics.float3> positions, System.Int32 length, Unity.Mathematics.float4x4& toM)
  Unity.Jobs.JobHandle TransformPosition(Unity.Collections.NativeArray<Unity.Mathematics.float3> srcPositions, Unity.Collections.NativeArray<Unity.Mathematics.float3> dstPositions, System.Int32 length, Unity.Mathematics.float4x4& toM, Unity.Jobs.JobHandle dependsOn)
  System.Void TransformPositionRun(Unity.Collections.NativeArray<Unity.Mathematics.float3> srcPositions, Unity.Collections.NativeArray<Unity.Mathematics.float3> dstPositions, System.Int32 length, Unity.Mathematics.float4x4& toM)
  Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.UInt16> ToNativeMultiHashMap(Unity.Collections.NativeArray<System.UInt32>& indexArray, Unity.Collections.NativeArray<System.UInt16>& dataArray)
  Unity.Jobs.JobHandle ClearReference(Unity.Collections.NativeReference<System.Int32> reference, Unity.Jobs.JobHandle jobHandle)
END_CLASS

CLASS: BeyondDynamicBone.InterlockUtility
TYPE:  class
TOKEN: 0x20001F5
FIELDS:
  private   static  System.Int32                    ToFixed  // 0x0
  private   static  System.Single                   ToFloat  // 0x0
METHODS:
  System.Void AddFloat3(System.Int32 index, Unity.Mathematics.float3 add, System.Int32* cntPt, System.Int32* sumPt)
  System.Void AddFloat3(System.Int32 index, Unity.Mathematics.float3 add, System.Int32* sumPt)
  System.Void Increment(System.Int32 index, System.Int32* cntPt)
  System.Void Max(System.Int32 index, System.Single value, System.Int32* pt)
  Unity.Mathematics.float3 ReadAverageFloat3(System.Int32 index, Unity.Collections.NativeArray<System.Int32>& countArray, Unity.Collections.NativeArray<System.Int32>& sumArray)
  Unity.Mathematics.float3 ReadAverageFloat3(System.Int32 index, System.Int32* countArray, System.Int32* sumArray)
  Unity.Mathematics.float3 ReadFloat3(System.Int32 index, Unity.Collections.NativeArray<System.Int32>& bufferArray)
  Unity.Mathematics.float3 ReadFloat3(System.Int32 index, System.Int32* bufferArray)
  System.Single ReadFloat(System.Int32 index, Unity.Collections.NativeArray<System.Int32>& bufferArray)
  System.Single ReadFloat(System.Int32 index, System.Int32* bufferArray)
  Unity.Jobs.JobHandle SolveAggregateBufferAndClear(Unity.Collections.NativeList<System.Int32>& particleList, System.Single velocityAttenuation, Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle SolveAggregateBufferAndClear(BeyondDynamicBone.ExProcessingList<System.Int32>& processingList, System.Single velocityAttenuation, Unity.Jobs.JobHandle jobHandle)
  Unity.Jobs.JobHandle SolveAggregateBufferAndClear(Unity.Collections.NativeArray<System.Int32>& particleArray, Unity.Collections.NativeReference<System.Int32>& counter, System.Single velocityAttenuation, Unity.Jobs.JobHandle jobHandle)
  System.Void Initialize$AggregateJobKernels_AggregateKernel_00000564$BurstDirectCall()
  System.Void Initialize$AggregateJobKernels_AggregateRangeKernel_00000565$BurstDirectCall()
  System.Void Initialize$AggregateWithVelocityJobKernels_AggregateWithVelocityKernel_00000566$BurstDirectCall()
  System.Void Initialize$AggregateWithVelocityJobKernels_AggregateWithVelocityRangeKernel_00000567$BurstDirectCall()
  System.Void Initialize$AggregateJob2Kernels_AggregateJob2Kernel_00000568$BurstDirectCall()
  System.Void Initialize$AggregateJob2Kernels_AggregateJob2RangeKernel_00000569$BurstDirectCall()
  System.Void Initialize$AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2Kernel_0000056A$BurstDirectCall()
  System.Void Initialize$AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2RangeKernel_0000056B$BurstDirectCall()
END_CLASS

CLASS: BeyondDynamicBone.AABB
TYPE:  struct
TOKEN: 0x2000210
FIELDS:
  public            Unity.Mathematics.float3        Min  // 0x10
  public            Unity.Mathematics.float3        Max  // 0x1C
METHODS:
  System.Void .ctor(Unity.Mathematics.float3& min, Unity.Mathematics.float3& max)
  BeyondDynamicBone.AABB CreateFromCenterAndExtents(Unity.Mathematics.float3 center, Unity.Mathematics.float3 extents)
  BeyondDynamicBone.AABB CreateFromCenterAndHalfExtents(Unity.Mathematics.float3 center, Unity.Mathematics.float3 halfExtents)
  Unity.Mathematics.float3 get_Extents()
  Unity.Mathematics.float3 get_HalfExtents()
  Unity.Mathematics.float3 get_Center()
  System.Single get_MaxSideLength()
  System.Boolean get_IsValid()
  System.Single get_SurfaceArea()
  System.Boolean Contains(Unity.Mathematics.float3& point)
  System.Boolean Contains(BeyondDynamicBone.AABB& aabb)
  System.Boolean Overlaps(BeyondDynamicBone.AABB& aabb)
  System.Void Expand(System.Single signedDistance)
  System.Void Encapsulate(BeyondDynamicBone.AABB& aabb)
  System.Void Encapsulate(Unity.Mathematics.float3& point)
  System.Boolean Equals(BeyondDynamicBone.AABB other)
  System.Void Transform(Unity.Mathematics.float4x4& toM)
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.IntAABB
TYPE:  struct
TOKEN: 0x2000211
FIELDS:
  public            Unity.Mathematics.int3          Min  // 0x10
  public            Unity.Mathematics.int3          Max  // 0x1C
METHODS:
  System.Void .ctor(Unity.Mathematics.int3 min, Unity.Mathematics.int3 max)
  Unity.Mathematics.int3 get_Extents()
  Unity.Mathematics.int3 get_Center()
  System.Boolean get_IsValid()
  System.Boolean Contains(Unity.Mathematics.int3 point)
  System.Boolean Contains(BeyondDynamicBone.IntAABB aabb)
  System.Boolean Overlaps(BeyondDynamicBone.IntAABB aabb)
  System.Void Expand(System.Int32 signedDistance)
  System.Void Encapsulate(BeyondDynamicBone.IntAABB aabb)
  System.Void Encapsulate(Unity.Mathematics.int3 point)
  System.Boolean Equals(BeyondDynamicBone.IntAABB other)
  System.String ToString()
END_CLASS

CLASS: BeyondDynamicBone.MathExtensions
TYPE:  class
TOKEN: 0x2000212
FIELDS:
METHODS:
  System.Single MC2GetValue(Unity.Mathematics.float4x4& m, System.Int32 index)
  System.Void MC2SetValue(Unity.Mathematics.float4x4& m, System.Int32 index, System.Single value)
  System.Single MC2EvaluateCurveClamp01(Unity.Mathematics.float4x4& m, System.Single time)
  System.Single MC2EvaluateCurve(Unity.Mathematics.float4x4& m, System.Single time)
END_CLASS

CLASS: BeyondDynamicBone.MathUtility
TYPE:  class
TOKEN: 0x2000213
FIELDS:
METHODS:
  System.Void ComputeVirtualParentWithoutLocal(Unity.Mathematics.float3 fromPos, Unity.Mathematics.quaternion fromRot, Unity.Mathematics.float3 toPos, Unity.Mathematics.quaternion toRot, Unity.Mathematics.float3& dPos, Unity.Mathematics.quaternion& dRot)
  System.Single Clamp1(System.Single a)
  Unity.Mathematics.float3 Project(Unity.Mathematics.float3& v, Unity.Mathematics.float3& n)
  Unity.Mathematics.float3 ProjectOnPlane(Unity.Mathematics.float3& v, Unity.Mathematics.float3& n)
  System.Single Angle(Unity.Mathematics.float3& v1, Unity.Mathematics.float3& v2)
  Unity.Mathematics.float3 ClampVector(Unity.Mathematics.float3 v, System.Single minlength, System.Single maxlength)
  Unity.Mathematics.float3 ClampVector(Unity.Mathematics.float3 v, System.Single maxlength)
  Unity.Mathematics.float3 ClampDistance(Unity.Mathematics.float3 from, Unity.Mathematics.float3 to, System.Single maxlength)
  System.Boolean ClampAngle(Unity.Mathematics.float3& dir, Unity.Mathematics.float3& basedir, System.Single maxAngle, Unity.Mathematics.float3& outdir)
  Unity.Mathematics.quaternion FromToRotation(Unity.Mathematics.float3& from, Unity.Mathematics.float3& to, System.Single t)
  Unity.Mathematics.quaternion FromToRotation(Unity.Mathematics.quaternion& from, Unity.Mathematics.quaternion& to)
  System.Single Angle(Unity.Mathematics.quaternion& a, Unity.Mathematics.quaternion& b)
  Unity.Mathematics.quaternion ClampAngle(Unity.Mathematics.quaternion from, Unity.Mathematics.quaternion to, System.Single maxAngle)
  Unity.Mathematics.quaternion ToRotation(Unity.Mathematics.float3& nor, Unity.Mathematics.float3& tan)
  System.Void ToNormalTangent(Unity.Mathematics.quaternion& rot, Unity.Mathematics.float3& nor, Unity.Mathematics.float3& tan)
  Unity.Mathematics.float3 ToNormal(Unity.Mathematics.quaternion& rot)
  Unity.Mathematics.float3 ToTangent(Unity.Mathematics.quaternion& rot)
  Unity.Mathematics.float3 ToBinormal(Unity.Mathematics.quaternion& rot)
  Unity.Mathematics.float3 Binormal(Unity.Mathematics.float3& nor, Unity.Mathematics.float3& tan)
  Unity.Mathematics.float3 AxisToEuler(Unity.Mathematics.float3& axis)
  Unity.Mathematics.quaternion AxisQuaternion(Unity.Mathematics.float3 dir)
  System.Void ToAngleAxis(Unity.Mathematics.quaternion& q, System.Single& angle, Unity.Mathematics.float3& axis)
  System.Single ClosestPtPointSegmentRatio(Unity.Mathematics.float3& c, Unity.Mathematics.float3& a, Unity.Mathematics.float3& b)
  System.Single ClosestPtPointSegmentRatioNoClamp(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b)
  Unity.Mathematics.float3 ClosestPtPointSegment(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b)
  Unity.Mathematics.float3 ClosestPtPointSegmentNoClamp(Unity.Mathematics.float3 c, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b)
  System.Single ClosestPtSegmentSegment(Unity.Mathematics.float3& p1, Unity.Mathematics.float3& q1, Unity.Mathematics.float3& p2, Unity.Mathematics.float3& q2, System.Single& s, System.Single& t, Unity.Mathematics.float3& c1, Unity.Mathematics.float3& c2)
  System.Void ClosestPtSegmentSegment2(Unity.Mathematics.float3& p1, Unity.Mathematics.float3& q1, Unity.Mathematics.float3& p2, Unity.Mathematics.float3& q2, System.Single& s, System.Single& t)
  Unity.Mathematics.float3 ClosestPtPointTriangle(Unity.Mathematics.float3& p, Unity.Mathematics.float3& a, Unity.Mathematics.float3& b, Unity.Mathematics.float3& c, Unity.Mathematics.float3& uvw)
  System.Boolean PointInTriangleUVW(Unity.Mathematics.float3 uvw)
  Unity.Mathematics.float3 TriangleCenter(Unity.Mathematics.float3& p0, Unity.Mathematics.float3& p1, Unity.Mathematics.float3& p2)
  Unity.Mathematics.float3 TriangleNormal(Unity.Mathematics.float3& p0, Unity.Mathematics.float3& p1, Unity.Mathematics.float3& p2)
  System.Single TriangleArea(Unity.Mathematics.float3& p0, Unity.Mathematics.float3& p1, Unity.Mathematics.float3& p2)
  System.Boolean IsSafeTriangle(Unity.Mathematics.float3& p0, Unity.Mathematics.float3& p1, Unity.Mathematics.float3& p2)
  Unity.Mathematics.float3 TriangleTangent(Unity.Mathematics.float3& p0, Unity.Mathematics.float3& p1, Unity.Mathematics.float3& p2, Unity.Mathematics.float2& uv0, Unity.Mathematics.float2& uv1, Unity.Mathematics.float2& uv2)
  System.Single TriangleAngle(Unity.Mathematics.float3& v0, Unity.Mathematics.float3& v1, Unity.Mathematics.float3& v2, Unity.Mathematics.float3& v3)
  System.Single DistanceTriangleCenter(Unity.Mathematics.float3 p, Unity.Mathematics.float3 p0, Unity.Mathematics.float3 p1, Unity.Mathematics.float3 p2)
  System.Single DirectionPointTriangle(Unity.Mathematics.float3 p, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c)
  Unity.Mathematics.int2 GetRestTriangleVertex(Unity.Mathematics.int3 tri1, Unity.Mathematics.int3 tri2, Unity.Mathematics.int2 edge)
  Unity.Mathematics.int2 GetCommonEdgeFromTrianglePair(Unity.Mathematics.int3 tri1, Unity.Mathematics.int3 tri2)
  Unity.Mathematics.int4 GetTrianglePairIndices(Unity.Mathematics.int3 tri1, Unity.Mathematics.int3 tri2)
  System.Int32 GetUnuseTriangleIndex(Unity.Mathematics.int3 tri, Unity.Mathematics.int2 edge)
  System.Single GetTrianglePairAngle(Unity.Mathematics.float3 pos0, Unity.Mathematics.float3 pos1, Unity.Mathematics.float3 pos2, Unity.Mathematics.float3 pos3)
  Unity.Mathematics.int3 FlipTriangle(Unity.Mathematics.int3& tri)
  System.Void GetTriangleSphere(Unity.Mathematics.float3 pos0, Unity.Mathematics.float3 pos1, Unity.Mathematics.float3 pos2, Unity.Mathematics.float3& sc, System.Single& sr)
  Unity.Mathematics.float4x4 LocalToWorldMatrix(Unity.Mathematics.float3& wpos, Unity.Mathematics.quaternion& wrot, Unity.Mathematics.float3& wscl)
  Unity.Mathematics.float4x4 WorldToLocalMatrix(Unity.Mathematics.float3& wpos, Unity.Mathematics.quaternion& wrot, Unity.Mathematics.float3& wscl)
  Unity.Mathematics.float3 TransformPoint(Unity.Mathematics.float3& pos, Unity.Mathematics.float3& wpos, Unity.Mathematics.quaternion& wrot, Unity.Mathematics.float3& wscl)
  Unity.Mathematics.float3 TransformPoint(Unity.Mathematics.float3& pos, Unity.Mathematics.float4x4& m)
  Unity.Mathematics.float3 TransformVector(Unity.Mathematics.float3& vec, Unity.Mathematics.float4x4& m)
  Unity.Mathematics.float3 TransformDirection(Unity.Mathematics.float3& dir, Unity.Mathematics.float4x4& m)
  Unity.Mathematics.quaternion TransformRotation(Unity.Mathematics.quaternion& rot, Unity.Mathematics.float4x4& m, Unity.Mathematics.float3& normalTangentFlip)
  System.Single TransformDistance(System.Single& dist, Unity.Mathematics.float4x4& localToWorldMatrix)
  System.Void TransformPositionNormalTangent(Unity.Mathematics.float3& tpos, Unity.Mathematics.quaternion& trot, Unity.Mathematics.float3& tscl, Unity.Mathematics.float3& pos, Unity.Mathematics.float3& nor, Unity.Mathematics.float3& tan)
  System.Single TransformLength(System.Single length, Unity.Mathematics.float4x4& matrix)
  Unity.Mathematics.float3 InverseTransformPoint(Unity.Mathematics.float3& pos, Unity.Mathematics.float4x4& worldToLocalMatrix)
  Unity.Mathematics.float3 InverseTransformPoint(Unity.Mathematics.float3& pos, Unity.Mathematics.float3& wpos, Unity.Mathematics.quaternion& wrot, Unity.Mathematics.float3& wscl)
  Unity.Mathematics.float3 InverseTransformVector(Unity.Mathematics.float3& vec, Unity.Mathematics.float4x4& worldToLocalMatrix)
  Unity.Mathematics.float3 InverseTransformVector(Unity.Mathematics.float3& vec, Unity.Mathematics.quaternion& rot)
  Unity.Mathematics.float3 InverseTransformDirection(Unity.Mathematics.float3& dir, Unity.Mathematics.float4x4& worldToLocalMatrix)
  Unity.Mathematics.float4x4 Transform(Unity.Mathematics.float4x4& fromLocalToWorldMatrix, Unity.Mathematics.float4x4& toWorldToLocalMatrix)
  System.Boolean CompareMatrix(Unity.Mathematics.float4x4& m1, Unity.Mathematics.float4x4& m2)
  System.Boolean CompareTransform(Unity.Mathematics.float3& pos1, Unity.Mathematics.quaternion& rot1, Unity.Mathematics.float3& scl1, Unity.Mathematics.float3& pos2, Unity.Mathematics.quaternion& rot2, Unity.Mathematics.float3& scl2)
  System.Boolean IntersectSegmentTriangle(Unity.Mathematics.float3& p, Unity.Mathematics.float3& q, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c, System.Boolean doubleSide, System.Single& u, System.Single& v, System.Single& w, System.Single& t)
  System.Boolean IntersectSegmentTriangle(Unity.Mathematics.float3& p, Unity.Mathematics.float3& q, Unity.Mathematics.float3 a, Unity.Mathematics.float3 b, Unity.Mathematics.float3 c)
  System.Single IntersectPointPlaneDist(Unity.Mathematics.float3& planePos, Unity.Mathematics.float3& planeDir, Unity.Mathematics.float3& pos, Unity.Mathematics.float3& outPos)
  System.Boolean IntersectRaySphere(Unity.Mathematics.float3& p, Unity.Mathematics.float3& d, Unity.Mathematics.float3& sc, System.Single& sr, System.Single& t, Unity.Mathematics.float3& q)
  System.Single SqDistPointSegment(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c)
  System.Boolean IsNaN(Unity.Mathematics.float3 v)
  System.Boolean IsNaN(Unity.Mathematics.float4 v)
  System.Boolean IsNaN(Unity.Mathematics.quaternion q)
  Unity.Mathematics.float3 Lerp(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y, System.Single s)
  Unity.Mathematics.float3 ShiftPosition(Unity.Mathematics.float3& oldPos, Unity.Mathematics.float3& oldPivotPosition, Unity.Mathematics.float3& shiftVector, Unity.Mathematics.quaternion& shiftRotation)
  System.Single CalcMass(System.Single depth)
  System.Single CalcInverseMass(System.Single friction)
  System.Single CalcInverseMass(System.Single friction, System.Single depth)
  System.Single CalcInverseMass(System.Single friction, System.Single depth, System.Boolean fix, System.Single fixMass)
  System.Single CalcSelfCollisionInverseMass(System.Single friction, System.Boolean fix, System.Single clothMass)
END_CLASS

CLASS: BeyondDynamicBone.MinimumData`2
TYPE:  class
TOKEN: 0x2000214
FIELDS:
  private           T1                              minDist  // 0x0
  private           T2                              minData  // 0x0
  private           System.Boolean                  isValid  // 0x0
METHODS:
  System.Void Add(T1 distance, T2 data)
  System.Void Clear()
  System.Boolean get_IsValid()
  T1 get_MinDistance()
  T2 get_MinData()
  System.String ToString()
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.FTransform
TYPE:  struct
TOKEN: 0x2000215
FIELDS:
  public            UnityEngine.Vector3             position  // 0x10
  public            UnityEngine.Quaternion          rotation  // 0x1C
  public            UnityEngine.Vector3             scale  // 0x2C
METHODS:
  BeyondDynamicBone.FTransform Default()
END_CLASS

CLASS: BeyondDynamicBone.MeshUtility
TYPE:  class
TOKEN: 0x2000216
FIELDS:
METHODS:
  UnityEngine.Mesh GetSharedMesh(UnityEngine.Renderer ren)
  System.Boolean SetMesh(UnityEngine.Renderer ren, UnityEngine.Mesh mesh, UnityEngine.Transform[] skinBones)
  System.Int32 GetTransformCount(UnityEngine.Renderer ren)
END_CLASS

CLASS: BeyondDynamicBone.Develop
TYPE:  class
TOKEN: 0x2000217
FIELDS:
METHODS:
  System.Void Log(System.Object& mes)
  System.Void LogWarning(System.Object& mes)
  System.Void LogError(System.Object& mes)
  System.Void DebugLog(System.Object& mes)
  System.Void DebugLogWarning(System.Object& mes)
  System.Void DebugLogError(System.Object& mes)
  System.Void Assert(System.Boolean condition)
END_CLASS

CLASS: BeyondDynamicBone.StaticStringBuilder
TYPE:  class
TOKEN: 0x2000218
FIELDS:
  private   static  System.Text.StringBuilder       stringBuilder  // 0x0
METHODS:
  System.Text.StringBuilder get_Instance()
  System.Void Clear()
  System.Text.StringBuilder Append(System.Object[] args)
  System.Text.StringBuilder AppendLine(System.Object[] args)
  System.Text.StringBuilder AppendLine()
  System.String AppendToString(System.Object[] args)
  System.String ToString()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: BeyondDynamicBone.DataChunk
TYPE:  struct
TOKEN: 0x2000219
FIELDS:
  public            System.Int32                    startIndex  // 0x10
  public            System.Int32                    dataLength  // 0x14
METHODS:
  System.Boolean get_IsValid()
  BeyondDynamicBone.DataChunk get_Empty()
  System.Void .ctor(System.Int32 sindex, System.Int32 length)
  System.Void .ctor(System.Int32 sindex)
  System.Void Clear()
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.ExBitFlag16
TYPE:  struct
TOKEN: 0x200021A
FIELDS:
  public            System.UInt16                   Value  // 0x10
METHODS:
  System.Void .ctor(System.UInt16 initialValue)
  System.Void Clear()
  System.Void SetFlag(System.UInt16 flag, System.Boolean sw)
  System.Boolean IsSet(System.UInt16 flag)
END_CLASS

CLASS: BeyondDynamicBone.ExBitFlag8
TYPE:  struct
TOKEN: 0x200021B
FIELDS:
  public            System.Byte                     Value  // 0x10
METHODS:
  System.Void .ctor(System.Byte initialValue)
  System.Void Clear()
  System.Void SetFlag(System.Byte flag, System.Boolean sw)
  System.Boolean IsSet(System.Byte flag)
END_CLASS

CLASS: BeyondDynamicBone.ExCostSortedList1
TYPE:  struct
TOKEN: 0x200021C
FIELDS:
  private           System.Single                   cost  // 0x10
  private           System.Int32                    data  // 0x14
METHODS:
  System.Void .ctor(System.Single invalidCost)
  System.Void .ctor(System.Single invalidCost, System.Int32 initData)
  System.Boolean get_IsValid()
  System.Int32 get_Count()
  System.Single get_Cost()
  System.Int32 get_Data()
  System.Void Add(System.Single cost, System.Int32 item)
  System.Int32 CompareTo(BeyondDynamicBone.ExCostSortedList1 other)
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.ExCostSortedList4
TYPE:  struct
TOKEN: 0x200021D
FIELDS:
  private           Unity.Mathematics.float4        costs  // 0x10
  private           Unity.Mathematics.int4          data  // 0x20
METHODS:
  System.Void .ctor(System.Single invalidCost)
  System.Int32 get_Count()
  System.Boolean get_IsValid()
  System.Boolean Add(System.Single cost, System.Int32 item)
  System.Boolean Contains(System.Int32 item)
  System.Int32 indexOf(System.Int32 item)
  System.Void RemoveItem(System.Int32 item)
  System.Single get_MinCost()
  System.Single get_MaxCost()
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.ExNativeArray`1
TYPE:  class
TOKEN: 0x200021E
FIELDS:
  private           Unity.Collections.NativeArray<T>nativeArray  // 0x0
  private           System.Collections.Generic.List<BeyondDynamicBone.DataChunk>emptyChunks  // 0x0
  private           System.Int32                    useCount  // 0x0
METHODS:
  System.Void Dispose()
  System.Boolean get_IsValid()
  System.Int32 get_Length()
  System.Int32 get_Count()
  System.Void .ctor()
  System.Void .ctor(System.Int32 emptyLength, System.Boolean create)
  System.Void .ctor(System.Int32 emptyLength, T fillData)
  System.Void .ctor(Unity.Collections.NativeArray<T> dataArray)
  System.Void .ctor(T[] dataArray)
  BeyondDynamicBone.DataChunk AddRange(System.Int32 dataLength)
  BeyondDynamicBone.DataChunk AddRange(System.Int32 dataLength, T fillData)
  BeyondDynamicBone.DataChunk AddRange(T[] array)
  BeyondDynamicBone.DataChunk AddRange(Unity.Collections.NativeArray<T> narray, System.Int32 length)
  BeyondDynamicBone.DataChunk AddRange(BeyondDynamicBone.ExNativeArray<T> exarray)
  BeyondDynamicBone.DataChunk AddRange(BeyondDynamicBone.ExSimpleNativeArray<T> exarray)
  BeyondDynamicBone.DataChunk AddRange(U[] array)
  BeyondDynamicBone.DataChunk AddRange(Unity.Collections.NativeArray<U> udata)
  BeyondDynamicBone.DataChunk AddRangeTypeChange(U[] array)
  BeyondDynamicBone.DataChunk AddRangeStride(U[] array)
  BeyondDynamicBone.DataChunk Add(T data)
  BeyondDynamicBone.DataChunk Expand(BeyondDynamicBone.DataChunk c, System.Int32 newDataLength)
  BeyondDynamicBone.DataChunk ExpandAndFill(BeyondDynamicBone.DataChunk c, System.Int32 newDataLength, T fillData, T clearData)
  T[] ToArray()
  System.Void CopyTo(T[] array)
  System.Void CopyTo(U[] array)
  System.Void CopyFrom(Unity.Collections.NativeArray<T> array)
  System.Void CopyFrom(Unity.Collections.NativeArray<U> array)
  System.Void CopyTypeChange(U[] array)
  System.Void CopyTypeChangeStride(U[] array)
  System.Void AddEmpty(System.Int32 dataLength)
  System.Void Remove(BeyondDynamicBone.DataChunk chunk)
  System.Void Remove(System.Int32 index)
  System.Void RemoveAndFill(BeyondDynamicBone.DataChunk chunk, T clearData)
  System.Void Fill(T fillData)
  System.Void Fill(BeyondDynamicBone.DataChunk chunk, T fillData)
  System.Void FillInternal(System.Int32 start, System.Int32 size, T fillData)
  System.Void Clear()
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  T& GetRef(System.Int32 index)
  Unity.Collections.NativeArray<T> GetNativeArray()
  Unity.Collections.NativeArray<U> GetNativeArray()
  BeyondDynamicBone.DataChunk GetEmptyChunk(System.Int32 dataLength)
  System.Void AddEmptyChunk(BeyondDynamicBone.DataChunk chunk)
  System.String ToString()
  System.String ToSummary()
END_CLASS

CLASS: BeyondDynamicBone.ExProcessingList`1
TYPE:  class
TOKEN: 0x200021F
FIELDS:
  public            Unity.Collections.NativeReference<System.Int32>Counter  // 0x0
  public            Unity.Collections.NativeArray<T>Buffer  // 0x0
METHODS:
  System.Void Dispose()
  System.Boolean IsValid()
  System.Void .ctor()
  System.Void UpdateBuffer(System.Int32 capacity)
  System.Int32* GetJobSchedulePtr()
  System.String ToString()
END_CLASS

CLASS: BeyondDynamicBone.ExSimpleNativeArray`1
TYPE:  class
TOKEN: 0x2000220
FIELDS:
  private           Unity.Collections.NativeArray<T>nativeArray  // 0x0
  private           System.Int32                    count  // 0x0
  private           System.Int32                    length  // 0x0
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.Int32 dataLength, System.Boolean areaOnly)
  System.Void .ctor(T[] dataArray)
  System.Void .ctor(Unity.Collections.NativeArray<T> array)
  System.Void .ctor(Unity.Collections.NativeList<T> array)
  System.Void .ctor(BeyondDynamicBone.ExSimpleNativeArray.SerializationData<T> sdata)
  System.Void Dispose()
  System.Boolean get_IsValid()
  System.Int32 get_Count()
  System.Int32 get_Length()
  System.Void SetCount(System.Int32 newCount)
  System.Void SetLength(System.Int32 newLength)
  System.Void AddRange(System.Int32 dataLength)
  System.Void AddRange(T[] dataArray)
  System.Void AddRange(T[] dataArray, System.Int32 cnt)
  System.Void AddRange(System.Int32 dataLength, T fillData)
  System.Void AddRange(Unity.Collections.NativeArray<T> narray)
  System.Void AddRange(Unity.Collections.NativeList<T> nlist)
  System.Void AddRange(BeyondDynamicBone.ExSimpleNativeArray<T> exarray)
  System.Void AddRange(U[] array)
  System.Void AddRangeTypeChange(U[] array)
  System.Void AddRangeTypeChange(Unity.Collections.NativeArray<U> array)
  System.Void AddRangeStride(U[] array)
  System.Void Add(T data)
  T[] ToArray()
  System.Void CopyTo(T[] array)
  System.Void CopyTo(U[] array)
  System.Void CopyToWithTypeChange(U[] array)
  System.Void CopyToWithTypeChangeStride(U[] array)
  System.Void CopyFrom(Unity.Collections.NativeArray<T> array)
  System.Void CopyFrom(Unity.Collections.NativeArray<U> array)
  System.Void CopyFromWithTypeChangeStride(Unity.Collections.NativeArray<U> array)
  System.Void Fill(System.Int32 startIndex, System.Int32 dataLength, T fillData)
  System.Void FillInternal(System.Int32 start, System.Int32 size, T fillData)
  T get_Item(System.Int32 index)
  System.Void set_Item(System.Int32 index, T value)
  Unity.Collections.NativeArray<T> GetNativeArray()
  Unity.Collections.NativeArray<U> GetNativeArray()
  System.Void Expand(System.Int32 dataLength, System.Boolean force, System.Boolean copy)
  System.String ToString()
  BeyondDynamicBone.ExSimpleNativeArray.SerializationData<T> Serialize()
  System.Boolean Deserialize(BeyondDynamicBone.ExSimpleNativeArray.SerializationData<T> data)
END_CLASS

CLASS: BeyondDynamicBone.ExTransformAccessArray
TYPE:  class
TOKEN: 0x2000222
FIELDS:
  private           UnityEngine.Jobs.TransformAccessArraytransformArray  // 0x10
  private           System.Int32                    nativeLength  // 0x18
  private           System.Collections.Generic.Queue<System.Int32>emptyStack  // 0x20
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>useIndexDict  // 0x28
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>indexDict  // 0x30
  private           System.Collections.Generic.Dictionary<System.Int32,System.Int32>referenceDict  // 0x38
METHODS:
  System.Void .ctor(System.Int32 capacity, System.Int32 desiredJobCount)
  System.Void Dispose()
  UnityEngine.Jobs.TransformAccessArray GetTransformAccessArray()
  System.Int32 Add(UnityEngine.Transform element)
  System.Void Remove(System.Int32 index)
  System.Boolean Exist(System.Int32 index)
  System.Boolean Exist(UnityEngine.Transform element)
  System.Int32 get_Count()
  System.Int32 get_Length()
  UnityEngine.Transform get_Item(System.Int32 index)
  System.Int32 GetIndex(UnityEngine.Transform element)
  System.Void Clear()
END_CLASS

CLASS: BeyondDynamicBone.FixedList128BytesExtensions
TYPE:  class
TOKEN: 0x2000223
FIELDS:
METHODS:
  System.Boolean MC2IsCapacity(Unity.Collections.FixedList128Bytes<T>& fixedList)
  System.Void MC2Set(Unity.Collections.FixedList128Bytes<T>& fixedList, T item)
  System.Void MC2SetLimit(Unity.Collections.FixedList128Bytes<T>& fixedList, T item)
  System.Void MC2RemoveItemAtSwapBack(Unity.Collections.FixedList128Bytes<T>& fixedList, T item)
  System.Void MC2Push(Unity.Collections.FixedList128Bytes<T>& fixedList, T item)
  T MC2Pop(Unity.Collections.FixedList128Bytes<T>& fixedList)
  System.Void MC2Enqueue(Unity.Collections.FixedList128Bytes<T>& fixedList, T item)
  T MC2Dequque(Unity.Collections.FixedList128Bytes<T>& fixedList)
END_CLASS

CLASS: BeyondDynamicBone.FixedList32BytesExtensions
TYPE:  class
TOKEN: 0x2000224
FIELDS:
METHODS:
  System.Boolean MC2IsCapacity(Unity.Collections.FixedList32Bytes<T>& fixedList)
  System.Void MC2Set(Unity.Collections.FixedList32Bytes<T>& fixedList, T item)
  System.Void MC2SetLimit(Unity.Collections.FixedList32Bytes<T>& fixedList, T item)
  System.Void MC2RemoveItemAtSwapBack(Unity.Collections.FixedList32Bytes<T>& fixedList, T item)
  System.Void MC2Push(Unity.Collections.FixedList32Bytes<T>& fixedList, T item)
  T MC2Pop(Unity.Collections.FixedList32Bytes<T>& fixedList)
  System.Void MC2Enqueue(Unity.Collections.FixedList32Bytes<T>& fixedList, T item)
  T MC2Dequque(Unity.Collections.FixedList32Bytes<T>& fixedList)
END_CLASS

CLASS: BeyondDynamicBone.FixedList4096BytesExtensions
TYPE:  class
TOKEN: 0x2000225
FIELDS:
METHODS:
  System.Boolean MC2IsCapacity(Unity.Collections.FixedList4096Bytes<T>& fixedList)
  System.Void MC2Set(Unity.Collections.FixedList4096Bytes<T>& fixedList, T item)
  System.Void MC2SetLimit(Unity.Collections.FixedList4096Bytes<T>& fixedList, T item)
  System.Void MC2RemoveItemAtSwapBack(Unity.Collections.FixedList4096Bytes<T>& fixedList, T item)
  System.Void MC2Push(Unity.Collections.FixedList4096Bytes<T>& fixedList, T item)
  T MC2Pop(Unity.Collections.FixedList4096Bytes<T>& fixedList)
  System.Void MC2Enqueue(Unity.Collections.FixedList4096Bytes<T>& fixedList, T item)
  T MC2Dequque(Unity.Collections.FixedList4096Bytes<T>& fixedList)
END_CLASS

CLASS: BeyondDynamicBone.FixedList512BytesExtensions
TYPE:  class
TOKEN: 0x2000226
FIELDS:
METHODS:
  System.Boolean MC2IsCapacity(Unity.Collections.FixedList512Bytes<T>& fixedList)
  System.Void MC2Set(Unity.Collections.FixedList512Bytes<T>& fixedList, T item)
  System.Void MC2SetLimit(Unity.Collections.FixedList512Bytes<T>& fixedList, T item)
  System.Void MC2RemoveItemAtSwapBack(Unity.Collections.FixedList512Bytes<T>& fixedList, T item)
  System.Void MC2Push(Unity.Collections.FixedList512Bytes<T>& fixedList, T item)
  T MC2Pop(Unity.Collections.FixedList512Bytes<T>& fixedList)
  System.Void MC2Enqueue(Unity.Collections.FixedList512Bytes<T>& fixedList, T item)
  T MC2Dequque(Unity.Collections.FixedList512Bytes<T>& fixedList)
END_CLASS

CLASS: BeyondDynamicBone.FixedList64BytesExtensions
TYPE:  class
TOKEN: 0x2000227
FIELDS:
METHODS:
  System.Boolean MC2IsCapacity(Unity.Collections.FixedList64Bytes<T>& fixedList)
  System.Void MC2Set(Unity.Collections.FixedList64Bytes<T>& fixedList, T item)
  System.Void MC2SetLimit(Unity.Collections.FixedList64Bytes<T>& fixedList, T item)
  System.Void MC2RemoveItemAtSwapBack(Unity.Collections.FixedList64Bytes<T>& fixedList, T item)
  System.Void MC2Push(Unity.Collections.FixedList64Bytes<T>& fixedList, T item)
  T MC2Pop(Unity.Collections.FixedList64Bytes<T>& fixedList)
  System.Void MC2Enqueue(Unity.Collections.FixedList64Bytes<T>& fixedList, T item)
  T MC2Dequque(Unity.Collections.FixedList64Bytes<T>& fixedList)
END_CLASS

CLASS: BeyondDynamicBone.NativeArrayExtensions
TYPE:  class
TOKEN: 0x2000228
FIELDS:
METHODS:
  System.Void MC2DisposeSafe(Unity.Collections.NativeArray<T>& array)
  System.Void MC2Resize(Unity.Collections.NativeArray<T>& array, System.Int32 size, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options)
  System.Byte[] MC2ToRawBytes(Unity.Collections.NativeArray<T>& array)
  Unity.Collections.NativeArray<T> MC2FromRawBytes(System.Byte[] bytes, Unity.Collections.Allocator allocator)
END_CLASS

CLASS: BeyondDynamicBone.NativeMultiHashMapExtensions
TYPE:  class
TOKEN: 0x2000229
FIELDS:
METHODS:
  System.Boolean MC2Contains(Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>& map, TKey key, TValue value)
  System.Void MC2UniqueAdd(Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>& map, TKey key, TValue value)
  System.Boolean MC2RemoveValue(Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>& map, TKey key, TValue value)
  Unity.Collections.FixedList512Bytes<TValue> MC2ToFixedList512Bytes(Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>& map, TKey key)
  Unity.Collections.FixedList128Bytes<TValue> MC2ToFixedList128Bytes(Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>& map, TKey key)
  System.ValueTuple<TKey[],TValue[]> MC2Serialize(Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>& map)
  Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int2,System.UInt16> MC2Deserialize(Unity.Mathematics.int2[] keyArray, System.UInt16[] valueArray)
  System.Void MC2DisposeSafe(Unity.Collections.NativeParallelMultiHashMap<TKey,TValue>& map)
END_CLASS

CLASS: BeyondDynamicBone.NativeParallelHashMap
TYPE:  class
TOKEN: 0x200022B
FIELDS:
METHODS:
  System.Void MC2DisposeSafe(Unity.Collections.NativeParallelHashMap<TKey,TValue>& map)
END_CLASS

CLASS: BeyondDynamicBone.NativeReferenceExtensions
TYPE:  class
TOKEN: 0x200022C
FIELDS:
METHODS:
  System.Int32 MC2InterlockedStartIndex(Unity.Collections.NativeReference<System.Int32>& counter, System.Int32 dataCount)
  System.Int32 MC2InterlockedStartIndex(System.Int32* cntPt, System.Int32 dataCount)
END_CLASS

CLASS: BeyondDynamicBone.PlayerLoopUtils
TYPE:  class
TOKEN: 0x200022D
FIELDS:
METHODS:
  System.Void AddPlayerLoop(UnityEngine.LowLevel.PlayerLoopSystem method, UnityEngine.LowLevel.PlayerLoopSystem& playerLoop, System.String categoryName, System.String systemName, System.Boolean last, System.Boolean before)
  System.Void .ctor()
END_CLASS

CLASS: BeyondDynamicBone.MagicaClothProcessingException
TYPE:  class
TOKEN: 0x200022F
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception inner)
END_CLASS

CLASS: BeyondDynamicBone.MagicaClothCanceledException
TYPE:  class
TOKEN: 0x2000230
EXTENDS: Exception
FIELDS:
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String message)
  System.Void .ctor(System.String message, System.Exception inner)
END_CLASS

CLASS: BeyondDynamicBone.ResultCode
TYPE:  struct
TOKEN: 0x2000231
FIELDS:
  private           BeyondDynamicBone.Define.Result result  // 0x10
  private           BeyondDynamicBone.Define.Result warning  // 0x14
METHODS:
  BeyondDynamicBone.Define.Result get_Result()
  BeyondDynamicBone.ResultCode get_None()
  BeyondDynamicBone.ResultCode get_Empty()
  BeyondDynamicBone.ResultCode get_Success()
  BeyondDynamicBone.ResultCode get_Error()
  System.Void .ctor(BeyondDynamicBone.Define.Result initResult)
  System.Void Clear()
  System.Void SetResult(BeyondDynamicBone.Define.Result code)
  System.Void SetSuccess()
  System.Void SetCancel()
  System.Void SetError(BeyondDynamicBone.Define.Result code)
  System.Void SetWarning(BeyondDynamicBone.Define.Result code)
  System.Void Merge(BeyondDynamicBone.ResultCode src)
  System.Void SetProcess()
  System.Boolean IsResult(BeyondDynamicBone.Define.Result code)
  System.Boolean IsNone()
  System.Boolean IsSuccess()
  System.Boolean IsFaild()
  System.Boolean IsCancel()
  System.Boolean IsNormal()
  System.Boolean IsError()
  System.Boolean IsProcess()
  System.Boolean IsWarning()
  System.String GetResultString()
  System.String GetWarningString()
  System.String GetResultInformation()
  System.String GetWarningInformation()
  System.Void DebugLog(System.Boolean error, System.Boolean warning, System.Boolean normal)
END_CLASS

CLASS: BeyondDynamicBone.TimeSpan
TYPE:  class
TOKEN: 0x2000232
FIELDS:
  private           System.String                   name  // 0x10
  private           System.DateTime                 stime  // 0x18
  private           System.DateTime                 etime  // 0x20
METHODS:
  System.Void .ctor()
  System.Void .ctor(System.String name)
  System.Void Start()
  System.Void Finish()
  System.Double TotalSeconds()
  System.Double TotalMilliSeconds()
  System.String ToString()
  System.Void DebugLog()
  System.Void Log()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.UnityTimeSpan
TYPE:  class
TOKEN: 0x2000233
FIELDS:
  private           System.String                   name  // 0x10
  private           System.Single                   stime  // 0x18
  private           System.Single                   etime  // 0x1C
  private           System.Boolean                  isFinish  // 0x20
METHODS:
  System.Void .ctor(System.String name)
  System.Void Finish()
  System.Single TotalSeconds()
  System.Single TotalMilliSeconds()
  System.String ToString()
  System.Void DebugLog()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.VirtualMesh
TYPE:  class
TOKEN: 0x2000234
FIELDS:
  public            System.String                   name  // 0x10
  public            BeyondDynamicBone.ResultCode    result  // 0x18
  public            System.Boolean                  isManaged  // 0x20
  public            BeyondDynamicBone.VirtualMesh.MeshTypemeshType  // 0x24
  public            System.Boolean                  isBoneCloth  // 0x28
  public            BeyondDynamicBone.ExSimpleNativeArray<System.Int32>referenceIndices  // 0x30
  public            BeyondDynamicBone.ExSimpleNativeArray<BeyondDynamicBone.VertexAttribute>attributes  // 0x38
  public            BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3>localPositions  // 0x40
  public            BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3>localNormals  // 0x48
  public            BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float3>localTangents  // 0x50
  public            BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float2>uv  // 0x58
  public            BeyondDynamicBone.ExSimpleNativeArray<BeyondDynamicBone.VirtualMeshBoneWeight>boneWeights  // 0x60
  public            BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.int3>triangles  // 0x68
  public            BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.int2>lines  // 0x70
  public            System.Int32                    centerTransformIndex  // 0x78
  public            Unity.Mathematics.float4x4      initLocalToWorld  // 0x7C
  public            Unity.Mathematics.float4x4      initWorldToLocal  // 0xBC
  public            Unity.Mathematics.quaternion    initRotation  // 0xFC
  public            Unity.Mathematics.quaternion    initInverseRotation  // 0x10C
  public            Unity.Mathematics.float3        initScale  // 0x11C
  public            System.Int32                    skinRootIndex  // 0x128
  public            BeyondDynamicBone.ExSimpleNativeArray<System.Int32>skinBoneTransformIndices  // 0x130
  public            BeyondDynamicBone.ExSimpleNativeArray<Unity.Mathematics.float4x4>skinBoneBindPoses  // 0x138
  public            BeyondDynamicBone.TransformData transformData  // 0x140
  public            Unity.Collections.NativeReference<BeyondDynamicBone.AABB>boundingBox  // 0x148
  public            Unity.Collections.NativeReference<System.Single>averageVertexDistance  // 0x158
  public            Unity.Collections.NativeReference<System.Single>maxVertexDistance  // 0x168
  public            BeyondDynamicBone.DataChunk     mergeChunk  // 0x178
  public            Unity.Collections.NativeArray<System.Int32>joinIndices  // 0x180
  public            Unity.Collections.NativeArray<Unity.Collections.FixedList32Bytes<System.UInt32>>vertexToTriangles  // 0x190
  public            Unity.Collections.NativeArray<System.UInt32>vertexToVertexIndexArray  // 0x1A0
  public            Unity.Collections.NativeArray<System.UInt16>vertexToVertexDataArray  // 0x1B0
  public            Unity.Collections.NativeArray<Unity.Mathematics.int2>edges  // 0x1C0
  public    static  System.Byte                     EdgeFlag_Cut  // 0x0
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>edgeFlags  // 0x1D0
  public            Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int2,System.UInt16>edgeToTriangles  // 0x1E0
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>vertexBindPosePositions  // 0x1F0
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>vertexBindPoseRotations  // 0x200
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>vertexToTransformRotations  // 0x210
  public            Unity.Collections.NativeArray<System.Single>vertexDepths  // 0x220
  public            Unity.Collections.NativeArray<System.Int32>vertexRootIndices  // 0x230
  public            Unity.Collections.NativeArray<System.Int32>vertexParentIndices  // 0x240
  public            Unity.Collections.NativeArray<System.UInt32>vertexChildIndexArray  // 0x250
  public            Unity.Collections.NativeArray<System.UInt16>vertexChildDataArray  // 0x260
  public            Unity.Collections.NativeArray<Unity.Mathematics.float3>vertexLocalPositions  // 0x270
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>vertexLocalRotations  // 0x280
  public            Unity.Collections.NativeArray<Unity.Mathematics.quaternion>normalAdjustmentRotations  // 0x290
  public    static  System.Byte                     BaseLineFlag_IncludeLine  // 0x0
  public            Unity.Collections.NativeArray<BeyondDynamicBone.ExBitFlag8>baseLineFlags  // 0x2A0
  public            Unity.Collections.NativeArray<System.UInt16>baseLineStartDataIndices  // 0x2B0
  public            Unity.Collections.NativeArray<System.UInt16>baseLineDataCounts  // 0x2C0
  public            Unity.Collections.NativeArray<System.UInt16>baseLineData  // 0x2D0
  public            System.Int32[]                  customSkinningBoneIndices  // 0x2E0
  public            System.UInt16[]                 centerFixedList  // 0x2E8
  public            Unity.Collections.NativeReference<Unity.Mathematics.float3>localCenterPosition  // 0x2F0
  public            BeyondDynamicBone.VirtualMesh   mappingProxyMesh  // 0x300
  public            Unity.Mathematics.float3        centerWorldPosition  // 0x308
  public            Unity.Mathematics.quaternion    centerWorldRotation  // 0x314
  public            Unity.Mathematics.float3        centerWorldScale  // 0x324
  public            Unity.Mathematics.float4x4      toProxyMatrix  // 0x330
  public            Unity.Mathematics.quaternion    toProxyRotation  // 0x370
  public            System.Int32                    mappingId  // 0x380
METHODS:
  System.Void ImportFrom(BeyondDynamicBone.RenderSetupData rsetup)
  System.Void ImportMeshType(BeyondDynamicBone.RenderSetupData rsetup, System.Int32[] transformIndices)
  System.Void ImportMeshSkinning()
  System.Void ImportBoneType(BeyondDynamicBone.RenderSetupData rsetup, System.Int32[] transformIndices)
  System.Void ImportFrom(BeyondDynamicBone.RenderData renderData)
  System.Void SelectionMesh(BeyondDynamicBone.SelectionData selectionData, Unity.Mathematics.float4x4 selectionLocalToWorldMatrix, System.Single mergin)
  System.Single CalcSelectionMergin(BeyondDynamicBone.ReductionSettings settings)
  System.Void AddMesh(BeyondDynamicBone.VirtualMesh cmesh)
  System.Void SetTransform(UnityEngine.Transform center, UnityEngine.Transform skinRoot, System.Int32 centerId, System.Int32 skinRootId)
  System.Void SetTransform(BeyondDynamicBone.TransformRecord centerRecord, BeyondDynamicBone.TransformRecord skinRootRecord)
  System.Void SetCenterTransform(UnityEngine.Transform t, System.Int32 tid)
  System.Void SetSkinRoot(UnityEngine.Transform t, System.Int32 tid)
  UnityEngine.Transform GetCenterTransform()
  System.Void SetCustomSkinningBones(BeyondDynamicBone.TransformRecord clothTransformRecord, System.Collections.Generic.List<BeyondDynamicBone.TransformRecord> bones)
  System.Boolean CompareSpace(BeyondDynamicBone.VirtualMesh target)
  Unity.Mathematics.float4x4 CenterTransformTo(BeyondDynamicBone.VirtualMesh to)
  System.Void Mapping(BeyondDynamicBone.VirtualMesh proxyMesh)
  Unity.Mathematics.float4 CalcVertexWeights(Unity.Mathematics.float4 distances)
  System.Void Optimization()
  System.Void RemoveDuplicateTriangles()
  System.Boolean CheckTwoTriangleOpen(Unity.Mathematics.int3& tri1, Unity.Mathematics.int3& tri2, Unity.Mathematics.int2& edge, Unity.Mathematics.float3& tri1n)
  System.Single CalcTwoTriangleAngle(Unity.Mathematics.int3& tri1, Unity.Mathematics.int3& tri2, Unity.Mathematics.int2& edge)
  System.Void ConvertProxyMesh(BeyondDynamicBone.ClothSerializeData sdata, BeyondDynamicBone.TransformRecord clothTransformRecord, System.Collections.Generic.List<BeyondDynamicBone.TransformRecord> customSkinningBoneRecords, BeyondDynamicBone.TransformRecord normalAdjustmentTransformRecord)
  System.Void ProxyNormalAdjustment(BeyondDynamicBone.ClothSerializeData sdata, BeyondDynamicBone.TransformRecord normalAdjustmentTransformRecord)
  System.Void ProxyCreateFixedListAndAABB()
  System.Void OptimizeTriangleDirection(Unity.Collections.NativeArray<Unity.Mathematics.float3> triangleNormals, System.Single sameSurfaceAngle)
  System.Void CreateCustomSkinning(BeyondDynamicBone.CustomSkinningSettings setting, System.Collections.Generic.List<BeyondDynamicBone.TransformRecord> bones)
  System.Void ApplySelectionAttribute(BeyondDynamicBone.SelectionData selectionData)
  System.Void CreateMeshBaseLine()
  System.Void CreateTransformBaseLine()
  System.Void DoBaseLine_Bone_CreateBoneChildInfo(System.Int32 vcnt, Unity.Collections.NativeArray<System.Int32> parentIndices, Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.UInt16> childMap)
  System.Void CreateBaseLinePose()
  System.Void CreateVertexRootAndDepth()
  System.Void Reduction(BeyondDynamicBone.ReductionSettings settings, System.Threading.CancellationToken ct)
  System.Void InitReductionWorkData(BeyondDynamicBone.ReductionWorkData workData)
  System.Void Organization(BeyondDynamicBone.ReductionSettings setting, BeyondDynamicBone.ReductionWorkData workData)
  System.Void OrganizationInit(BeyondDynamicBone.ReductionSettings setting, BeyondDynamicBone.ReductionWorkData workData)
  System.Void OrganizationCreateRemapData(BeyondDynamicBone.ReductionWorkData workData)
  System.Void OrganizationCreateBasicData(BeyondDynamicBone.ReductionWorkData workData)
  System.Void OrganizationCreateLineTriangle(BeyondDynamicBone.ReductionWorkData workData)
  System.Void OrganizeStoreVirtualMesh(BeyondDynamicBone.ReductionWorkData workData)
  BeyondDynamicBone.VirtualMesh.ShareSerializationData ShareSerialize()
  BeyondDynamicBone.VirtualMesh ShareDeserialize(BeyondDynamicBone.VirtualMesh.ShareSerializationData sdata)
  BeyondDynamicBone.VirtualMesh.UniqueSerializationData UniqueSerialize()
  System.Void CalcAverageAndMaxVertexDistanceRun()
  BeyondDynamicBone.GridMap<System.Int32> CreateVertexIndexGridMapRun(System.Single gridSize)
  BeyondDynamicBone.VirtualMeshRaycastHit IntersectRayMesh(Unity.Mathematics.float3 rayPos, Unity.Mathematics.float3 rayDir, System.Boolean doubleSide, System.Single pointRadius)
  System.Single get_InitCalcScale()
  System.Boolean get_IsSuccess()
  System.Boolean get_IsError()
  System.Boolean get_IsProcess()
  System.Int32 get_VertexCount()
  System.Int32 get_TriangleCount()
  System.Int32 get_LineCount()
  System.Int32 get_SkinBoneCount()
  System.Int32 get_TransformCount()
  System.Boolean get_IsProxy()
  System.Boolean get_IsMapping()
  System.Int32 get_BaseLineCount()
  System.Int32 get_EdgeCount()
  System.Int32 get_CustomSkinningBoneCount()
  System.Int32 get_CenterFixedPointCount()
  System.Int32 get_NormalAdjustmentRotationCount()
  System.Void .ctor()
  System.Void .ctor(System.Boolean initialize)
  System.Void .ctor(System.String name)
  System.Void Dispose()
  System.Void SetName(System.String newName)
  System.Boolean IsValid()
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.VertexAttribute
TYPE:  struct
TOKEN: 0x200026E
FIELDS:
  public    static  System.Byte                     Flag_Fixed  // 0x0
  public    static  System.Byte                     Flag_Move  // 0x0
  public    static  System.Byte                     Flag_InvalidMotion  // 0x0
  public    static  System.Byte                     Flag_DisableCollision  // 0x0
  public    static  System.Byte                     Flag_Triangle  // 0x0
  public    static readonly BeyondDynamicBone.VertexAttributeInvalid  // 0x0
  public    static readonly BeyondDynamicBone.VertexAttributeFixed  // 0x1
  public    static readonly BeyondDynamicBone.VertexAttributeMove  // 0x2
  public    static readonly BeyondDynamicBone.VertexAttributeDisableCollision  // 0x3
  public            System.Byte                     Value  // 0x10
METHODS:
  System.Void .ctor(System.Byte initialValue)
  System.Void Clear()
  System.Void SetFlag(System.Byte flag, System.Boolean sw)
  System.Void SetFlag(BeyondDynamicBone.VertexAttribute attr, System.Boolean sw)
  System.Boolean IsSet(System.Byte flag)
  System.Boolean IsInvalid()
  System.Boolean IsFixed()
  System.Boolean IsMove()
  System.Boolean IsDontMove()
  System.Boolean IsMotion()
  System.Boolean IsDisableCollision()
  BeyondDynamicBone.VertexAttribute JoinAttribute(BeyondDynamicBone.VertexAttribute attr1, BeyondDynamicBone.VertexAttribute attr2)
  System.Boolean Equals(BeyondDynamicBone.VertexAttribute other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  System.Boolean op_Equality(BeyondDynamicBone.VertexAttribute lhs, BeyondDynamicBone.VertexAttribute rhs)
  System.Boolean op_Inequality(BeyondDynamicBone.VertexAttribute lhs, BeyondDynamicBone.VertexAttribute rhs)
  System.Void .cctor()
  System.Boolean <>iFixBaseProxy_Equals(System.Object P0)
  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: BeyondDynamicBone.VirtualMeshBoneWeight
TYPE:  struct
TOKEN: 0x200026F
FIELDS:
  public            Unity.Mathematics.float4        weights  // 0x10
  public            Unity.Mathematics.int4          boneIndices  // 0x20
METHODS:
  System.Boolean get_IsValid()
  System.Void .ctor(Unity.Mathematics.int4 boneIndices, Unity.Mathematics.float4 weights)
  System.Int32 get_Count()
  System.Void AddWeight(System.Int32 boneIndex, System.Single weight)
  System.Void AddWeight(BeyondDynamicBone.VirtualMeshBoneWeight& bw)
  System.Void AdjustWeight()
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.VirtualMeshContainer
TYPE:  class
TOKEN: 0x2000270
FIELDS:
  public            BeyondDynamicBone.VirtualMesh   shareVirtualMesh  // 0x10
  public            BeyondDynamicBone.VirtualMesh.UniqueSerializationDatauniqueData  // 0x18
METHODS:
  System.Void .ctor()
  System.Void .ctor(BeyondDynamicBone.VirtualMesh vmesh)
  System.Void Dispose()
  System.Boolean get_hasUniqueData()
  System.Int32 GetTransformCount()
  UnityEngine.Transform GetTransformFromIndex(System.Int32 index)
  UnityEngine.Transform GetCenterTransform()
END_CLASS

CLASS: BeyondDynamicBone.VirtualMeshPrimitive
TYPE:  struct
TOKEN: 0x2000271
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  BeyondDynamicBone.VirtualMeshPrimitiveNone  // 0x0
  public    static  BeyondDynamicBone.VirtualMeshPrimitivePoint  // 0x0
  public    static  BeyondDynamicBone.VirtualMeshPrimitiveEdge  // 0x0
  public    static  BeyondDynamicBone.VirtualMeshPrimitiveTriangle  // 0x0
METHODS:
END_CLASS

CLASS: BeyondDynamicBone.VirtualMeshRaycastHit
TYPE:  struct
TOKEN: 0x2000272
FIELDS:
  public            BeyondDynamicBone.VirtualMeshPrimitivetype  // 0x10
  public            System.Int32                    index  // 0x14
  public            Unity.Mathematics.float3        position  // 0x18
  public            Unity.Mathematics.float3        normal  // 0x24
  public            System.Single                   distance  // 0x30
METHODS:
  System.Int32 CompareTo(BeyondDynamicBone.VirtualMeshRaycastHit other)
  System.Boolean IsValid()
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: BeyondDynamicBone.VirtualMeshTransform
TYPE:  struct
TOKEN: 0x2000273
FIELDS:
  public            Unity.Collections.FixedString32Bytesname  // 0x10
  public            System.Int32                    index  // 0x30
  public            Unity.Mathematics.float4x4      localToWorldMatrix  // 0x34
  public            Unity.Mathematics.float4x4      worldToLocalMatrix  // 0x74
  public            System.Int32                    parentIndex  // 0xB4
METHODS:
  System.Void .ctor(UnityEngine.Transform t)
  System.Void .ctor(UnityEngine.Transform t, System.Int32 index)
  BeyondDynamicBone.VirtualMeshTransform Clone()
  BeyondDynamicBone.VirtualMeshTransform get_Origin()
  System.Int32 GetHashCode()
  System.Void Update(UnityEngine.Transform t)
  Unity.Mathematics.float3 TransformPoint(Unity.Mathematics.float3 pos)
  Unity.Mathematics.float3 TransformVector(Unity.Mathematics.float3 vec)
  Unity.Mathematics.float3 TransformDirection(Unity.Mathematics.float3 dir)
  Unity.Mathematics.float3 InverseTransformPoint(Unity.Mathematics.float3 pos)
  Unity.Mathematics.float3 InverseTransformVector(Unity.Mathematics.float3 vec)
  Unity.Mathematics.float3 InverseTransformDirection(Unity.Mathematics.float3 dir)
  Unity.Mathematics.quaternion InverseTransformRotation(Unity.Mathematics.quaternion rot)
  BeyondDynamicBone.VirtualMeshTransform Transform(BeyondDynamicBone.VirtualMeshTransform& to)
  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x2000276
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Void __Gen_Wrap_0(System.Object P0)
  System.Boolean __Gen_Wrap_1()
  System.Boolean __Gen_Wrap_2(System.Object P0, System.Int32 P1)
  System.Boolean __Gen_Wrap_3(System.Object P0)
  System.Void __Gen_Wrap_4(System.Object P0, System.Single P1, System.Single P2)
  System.Void __Gen_Wrap_5(System.Object P0, System.Boolean P1, Unity.Mathematics.float3 P2, Unity.Mathematics.quaternion P3)
  BeyondDynamicBone.BeyondBoneCloth __Gen_Wrap_6(System.Object P0)
  System.Void __Gen_Wrap_7(BeyondDynamicBone.ResultCode& P0, BeyondDynamicBone.Define.Result P1)
  System.Void __Gen_Wrap_8(BeyondDynamicBone.ResultCode& P0)
  System.Void __Gen_Wrap_9(System.Object& P0)
  BeyondDynamicBone.ClothSerializeData2 __Gen_Wrap_10(System.Object P0)
  System.Void __Gen_Wrap_11(System.Object P0, System.Int32 P1, System.Boolean P2)
  System.Boolean __Gen_Wrap_12(UnityEngine.Transform P0)
  System.Boolean __Gen_Wrap_13(UnityEngine.Renderer P0)
  BeyondDynamicBone.ResultCode __Gen_Wrap_14(System.Object P0)
  System.Boolean __Gen_Wrap_15(BeyondDynamicBone.ResultCode& P0)
  System.Void __Gen_Wrap_16(BeyondDynamicBone.ResultCode& P0, BeyondDynamicBone.ResultCode P1)
  BeyondDynamicBone.SharePreBuildData __Gen_Wrap_17(System.Object P0)
  Unity.Mathematics.float4x4 __Gen_Wrap_18(System.Object P0)
  System.Void __Gen_Wrap_19(BeyondDynamicBone.CullingSettings.CullingParams& P0, System.Object P1)
  System.Single __Gen_Wrap_20(System.Object P0, System.Single P1)
  System.Void __Gen_Wrap_21(BeyondDynamicBone.InertiaConstraint.InertiaConstraintParams& P0, System.Object P1)
  System.Void __Gen_Wrap_22(BeyondDynamicBone.TetherConstraint.TetherConstraintParams& P0, System.Object P1, BeyondDynamicBone.ClothProcess.ClothType P2)
  System.Void __Gen_Wrap_23(BeyondDynamicBone.DistanceConstraint.DistanceConstraintParams& P0, System.Object P1, BeyondDynamicBone.ClothProcess.ClothType P2)
  System.Void __Gen_Wrap_24(BeyondDynamicBone.TriangleBendingConstraint.TriangleBendingConstraintParams& P0, System.Object P1)
  System.Void __Gen_Wrap_25(BeyondDynamicBone.AngleConstraint.AngleConstraintParams& P0, System.Object P1, System.Object P2)
  System.Void __Gen_Wrap_26(BeyondDynamicBone.MotionConstraint.MotionConstraintParams& P0, System.Object P1, BeyondDynamicBone.ClothProcess.ClothType P2)
  System.Void __Gen_Wrap_27(BeyondDynamicBone.ColliderCollisionConstraint.ColliderCollisionConstraintParams& P0, System.Object P1, BeyondDynamicBone.ClothProcess.ClothType P2)
  System.Void __Gen_Wrap_28(BeyondDynamicBone.SelfCollisionConstraint.SelfCollisionConstraintParams& P0, System.Object P1, BeyondDynamicBone.ClothProcess.ClothType P2)
  System.Void __Gen_Wrap_29(BeyondDynamicBone.WindParams& P0, System.Object P1, BeyondDynamicBone.ClothProcess.ClothType P2)
  System.Void __Gen_Wrap_30(BeyondDynamicBone.SpringConstraint.SpringConstraintParams& P0, System.Object P1, BeyondDynamicBone.ClothProcess.ClothType P2)
  BeyondDynamicBone.ClothParameters __Gen_Wrap_31(System.Object P0)
  BeyondDynamicBone.RenderSetupData __Gen_Wrap_32(System.Object P0)
  BeyondDynamicBone.TransformData __Gen_Wrap_33(System.Object P0)
  Unity.Collections.NativeParallelMultiHashMap<Unity.Mathematics.int2,System.UInt16> __Gen_Wrap_34(System.Object P0, System.Object P1)
  BeyondDynamicBone.VirtualMesh __Gen_Wrap_35(System.Object P0)
  System.Void __Gen_Wrap_36(System.Object P0, System.Object P1)
  BeyondDynamicBone.PreBuildManager.ShareDeserializationData __Gen_Wrap_37(System.Object P0, System.Object P1, System.Boolean P2)
  System.Void __Gen_Wrap_38(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  System.Int32 __Gen_Wrap_39(System.Object P0)
  System.Int32 __Gen_Wrap_40(System.Object P0, System.Object P1, System.Object P2, System.Object P3)
  BeyondDynamicBone.RenderData __Gen_Wrap_41(System.Object P0, System.Int32 P1)
  System.Void __Gen_Wrap_42(System.Object P0, BeyondDynamicBone.ClothProcess.ClothType P1, System.Object P2, System.Object P3, System.Object P4, BeyondDynamicBone.RenderSetupData.BoneConnectionMode P5)
  BeyondDynamicBone.TeamManager.TeamData& __Gen_Wrap_43(System.Object P0, System.Int32 P1)
  System.Boolean __Gen_Wrap_44(BeyondDynamicBone.TeamManager.TeamData& P0)
  System.Void __Gen_Wrap_45(System.Object P0, System.Int32 P1)
  System.Void __Gen_Wrap_46(System.Object P0, BeyondDynamicBone.DataChunk P1, System.Boolean P2)
  System.Boolean __Gen_Wrap_47(BeyondDynamicBone.ClothProcess P0)
  System.Void __Gen_Wrap_48(System.Object P0, Unity.Collections.NativeArray<UnityEngine.BoneWeight> P1)
  System.Void __Gen_Wrap_49(System.Object P0, System.Object P1, System.Int32 P2)
  BeyondDynamicBone.PreBuildManager.ShareDeserializationData __Gen_Wrap_50(System.Object P0, System.Object P1)
  System.Int32 __Gen_Wrap_51(System.Object P0, System.Object P1)
  System.Void __Gen_Wrap_52(System.Object P0, System.Int32 P1, System.Object P2)
  System.Int32 __Gen_Wrap_53(System.Object P0, System.Object P1, BeyondDynamicBone.ClothParameters P2)
  System.Int32 __Gen_Wrap_54(System.Object P0, System.Object P1, BeyondDynamicBone.ClothParameters& P2)
  UnityEngine.Transform __Gen_Wrap_55(System.Object P0, System.Int32 P1)
  BeyondDynamicBone.DataChunk __Gen_Wrap_56(System.Object P0, System.Object P1, System.Int32 P2)
  BeyondDynamicBone.DataChunk __Gen_Wrap_57(System.Object P0, System.Int32 P1, System.Int32 P2)
  UnityEngine.Vector3 __Gen_Wrap_58(System.Object P0)
  System.Void __Gen_Wrap_59(System.Object P0, System.Object P1, BeyondDynamicBone.ExBitFlag8 P2, System.Int32 P3, System.Int32 P4)
  System.Void __Gen_Wrap_60(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3, System.Int32 P4, System.Int32 P5)
  BeyondDynamicBone.ClothParameters& __Gen_Wrap_61(System.Object P0, System.Int32 P1)
  System.Void __Gen_Wrap_62(System.Object P0, System.Int32 P1, BeyondDynamicBone.TeamManager.TeamData P2, System.UInt32 P3, System.Int32 P4, System.Int32 P5, System.Int32 P6)
  System.Void __Gen_Wrap_63(BeyondDynamicBone.DataChunk& P0)
  Unity.Collections.FixedList64Bytes<System.Int16>& __Gen_Wrap_64(System.Object P0, System.Int32 P1)
  UnityEngine.Transform __Gen_Wrap_65(System.Object P0)
  BeyondDynamicBone.DataChunk __Gen_Wrap_66(System.Object P0, System.Object P1, BeyondDynamicBone.ExBitFlag8 P2, System.Int32 P3)
  BeyondDynamicBone.DataChunk __Gen_Wrap_67(System.Object P0, System.Int32 P1, System.Object P2)
  System.Void __Gen_Wrap_68(BeyondDynamicBone.VirtualMeshContainer P0)
  System.String __Gen_Wrap_69(BeyondDynamicBone.ResultCode& P0)
  Unity.Collections.NativeParallelMultiHashMap<System.Int32,System.UInt16> __Gen_Wrap_70(Unity.Collections.NativeArray<System.UInt32>& P0, Unity.Collections.NativeArray<System.UInt16>& P1)
  System.Int32 __Gen_Wrap_71(Unity.Mathematics.int3 P0, Unity.Mathematics.int2 P1)
  BeyondDynamicBone.DistanceConstraint.ConstraintData __Gen_Wrap_72(System.Object P0, BeyondDynamicBone.ClothParameters& P1)
  Unity.Mathematics.int2 __Gen_Wrap_73(Unity.Mathematics.int3 P0, Unity.Mathematics.int3 P1, Unity.Mathematics.int2 P2)
  System.Void __Gen_Wrap_74(System.Object P0, System.Int32 P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, System.Single& P5, System.SByte& P6)
  Unity.Mathematics.int4 __Gen_Wrap_75(System.Int32 P0, System.Int32 P1, System.Int32 P2, System.Int32 P3)
  Unity.Mathematics.int4 __Gen_Wrap_76(Unity.Mathematics.int4 P0)
  BeyondDynamicBone.TriangleBendingConstraint.ConstraintData __Gen_Wrap_77(System.Object P0, BeyondDynamicBone.ClothParameters& P1)
  System.Void __Gen_Wrap_78(BeyondDynamicBone.InertiaConstraint.CenterData& P0)
  BeyondDynamicBone.InertiaConstraint.ConstraintData __Gen_Wrap_79(System.Object P0, BeyondDynamicBone.ClothParameters& P1)
  System.Int32 __Gen_Wrap_80(System.Object P0, System.Object P1, System.Int32 P2, System.Byte P3, System.Boolean P4)
  System.Void __Gen_Wrap_81(System.Object P0, System.Object P1, System.Object P2)
  System.String __Gen_Wrap_82(System.Object P0)
  System.Int32[] __Gen_Wrap_83(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4, Unity.Collections.NativeArray<Unity.Mathematics.float3> P5, Unity.Collections.NativeArray<Unity.Mathematics.quaternion> P6, Unity.Collections.NativeArray<Unity.Mathematics.float3> P7, Unity.Collections.NativeArray<Unity.Mathematics.quaternion> P8, Unity.Collections.NativeArray<Unity.Mathematics.float3> P9, Unity.Collections.NativeArray<Unity.Mathematics.quaternion> P10)
  System.Void __Gen_Wrap_84(Unity.Collections.NativeArray<System.Int32> P0, System.Int32 P1)
  System.Void __Gen_Wrap_85(Unity.Collections.NativeArray<BeyondDynamicBone.VirtualMeshBoneWeight> P0, System.Int32 P1, BeyondDynamicBone.VirtualMeshBoneWeight P2)
  System.Int32 __Gen_Wrap_86(System.Object P0, System.Int32 P1, System.Boolean P2)
  Unity.Mathematics.int3 __Gen_Wrap_87(System.Int32 P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_88(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, System.Int32 P1, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> P2)
  System.Void __Gen_Wrap_89(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, System.Int32 P1, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> P2, Unity.Collections.NativeArray<Unity.Mathematics.float2> P3)
  System.Void __Gen_Wrap_90(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, Unity.Collections.NativeArray<Unity.Mathematics.float3> P1, System.Int32 P2, Unity.Mathematics.float4x4& P3)
  BeyondDynamicBone.ResultCode __Gen_Wrap_91(System.Object P0, System.Object P1, System.Object P2, System.Object P3, BeyondDynamicBone.SelectionData& P4)
  System.Single __Gen_Wrap_92(BeyondDynamicBone.AABB& P0)
  System.Single __Gen_Wrap_93(System.Object P0)
  System.Single __Gen_Wrap_94(System.Object P0, System.Object P1)
  Unity.Collections.NativeArray<Unity.Mathematics.float3> __Gen_Wrap_95(System.Object P0)
  Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute> __Gen_Wrap_96(System.Object P0)
  System.Void __Gen_Wrap_97(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, System.Int32 P1, Unity.Mathematics.float4x4& P2)
  BeyondDynamicBone.GridMap<System.Int32> __Gen_Wrap_98(System.Single P0, Unity.Collections.NativeArray<Unity.Mathematics.float3>& P1, Unity.Collections.NativeArray<BeyondDynamicBone.VertexAttribute>& P2, System.Boolean P3, System.Boolean P4, System.Boolean P5, System.Boolean P6)
  System.Void __Gen_Wrap_99(System.Object P0, System.Object P1, Unity.Mathematics.float4x4 P2, System.Single P3)
  System.Boolean __Gen_Wrap_100(System.Object P0, System.Object P1)
  Unity.Mathematics.float4x4 __Gen_Wrap_101(System.Object P0, System.Object P1)
  System.Int32 __Gen_Wrap_102(System.Object P0, System.Object P1, System.Int32 P2, System.Boolean P3)
  System.Void __Gen_Wrap_103(System.Object P0, BeyondDynamicBone.VertexAttribute P1)
  System.Int32 __Gen_Wrap_104(System.Object P0, System.Int32 P1)
  System.Void __Gen_Wrap_105(Unity.Collections.NativeArray<System.Int32> P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_106(System.Object P0, System.Object P1, System.Threading.CancellationToken P2)
  System.Void __Gen_Wrap_107(Unity.Collections.NativeArray<Unity.Mathematics.quaternion> P0, System.Int32 P1, Unity.Mathematics.quaternion P2)
  System.Single __Gen_Wrap_108(System.Object P0, Unity.Mathematics.int3& P1, Unity.Mathematics.int3& P2, Unity.Mathematics.int2& P3)
  System.Boolean __Gen_Wrap_109(System.Object P0, Unity.Mathematics.int3& P1, Unity.Mathematics.int3& P2, Unity.Mathematics.int2& P3, Unity.Mathematics.float3& P4)
  System.Void __Gen_Wrap_110(System.Object P0, Unity.Collections.NativeArray<Unity.Mathematics.float3> P1, System.Single P2)
  Unity.Mathematics.float3 __Gen_Wrap_111(BeyondDynamicBone.AABB& P0)
  System.Void __Gen_Wrap_112(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Object P4)
  BeyondDynamicBone.GridMap<System.Int32> __Gen_Wrap_113(System.Object P0, System.Single P1)
  BeyondDynamicBone.ResultCode __Gen_Wrap_114(System.Object P0, System.Object P1)
  BeyondDynamicBone.SelectionData __Gen_Wrap_115(System.Object P0)
  System.Void __Gen_Wrap_116()
  System.Void __Gen_Wrap_117(System.Object P0, BeyondDynamicBone.DataChunk P1)
  System.Void __Gen_Wrap_118(System.Object P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_119(System.Object P0, BeyondDynamicBone.TeamManager.TeamData& P1, System.Int32 P2)
  System.Threading.Tasks.Task __Gen_Wrap_120(System.Object P0, System.Threading.CancellationToken P1)
  System.Void __Gen_Wrap_121(System.Object P0, System.Single P1)
  System.Void __Gen_Wrap_122(UnityEngine.Transform P0)
  System.Void __Gen_Wrap_123(BeyondDynamicBone.RenderSetupData.UniqueSerializationData P0)
  System.Void __Gen_Wrap_124(BeyondDynamicBone.VirtualMesh.UniqueSerializationData P0)
  System.Void __Gen_Wrap_125(System.Int32 P0)
  System.Void __Gen_Wrap_126(BeyondDynamicBone.TransformRecord P0)
  System.Void __Gen_Wrap_127(System.Object P0, System.Boolean P1)
  BeyondDynamicBone.InertiaConstraint.CenterData& __Gen_Wrap_128(System.Object P0, System.Int32 P1)
  System.Void __Gen_Wrap_129(System.Object P0, UnityEngine.Vector3 P1, System.Single P2, BeyondDynamicBone.ClothForceMode P3)
  System.Void __Gen_Wrap_130(System.Object P0, System.Boolean P1, System.Single P2)
  BeyondDynamicBone.CheckSliderSerializeData __Gen_Wrap_131(System.Object P0)
  Unity.Collections.BitField32 __Gen_Wrap_132(System.Object P0)
  BeyondDynamicBone.ClothProcess.RenderMeshInfo __Gen_Wrap_133(System.Object P0, System.Int32 P1)
  BeyondDynamicBone.ClothUpdateMode __Gen_Wrap_134(System.Object P0)
  System.Void __Gen_Wrap_135(BeyondDynamicBone.ClothProcess.GenerateSelectionJob& P0, System.Int32 P1)
  BeyondDynamicBone.ReductionSettings __Gen_Wrap_136(System.Object P0)
  BeyondDynamicBone.CustomSkinningSettings __Gen_Wrap_137(System.Object P0)
  BeyondDynamicBone.NormalAlignmentSettings __Gen_Wrap_138(System.Object P0)
  BeyondDynamicBone.CullingSettings __Gen_Wrap_139(System.Object P0)
  BeyondDynamicBone.CurveSerializeData __Gen_Wrap_140(System.Object P0)
  BeyondDynamicBone.InertiaConstraint.SerializeData __Gen_Wrap_141(System.Object P0)
  BeyondDynamicBone.TetherConstraint.SerializeData __Gen_Wrap_142(System.Object P0)
  BeyondDynamicBone.DistanceConstraint.SerializeData __Gen_Wrap_143(System.Object P0)
  BeyondDynamicBone.TriangleBendingConstraint.SerializeData __Gen_Wrap_144(System.Object P0)
  BeyondDynamicBone.AngleConstraint.RestorationSerializeData __Gen_Wrap_145(System.Object P0)
  BeyondDynamicBone.AngleConstraint.LimitSerializeData __Gen_Wrap_146(System.Object P0)
  BeyondDynamicBone.MotionConstraint.SerializeData __Gen_Wrap_147(System.Object P0)
  BeyondDynamicBone.ColliderCollisionConstraint.SerializeData __Gen_Wrap_148(System.Object P0)
  BeyondDynamicBone.SelfCollisionConstraint.SerializeData __Gen_Wrap_149(System.Object P0)
  BeyondDynamicBone.WindSettings __Gen_Wrap_150(System.Object P0)
  System.Void __Gen_Wrap_151(System.Object P0, System.Object P1, System.Boolean P2)
  BeyondDynamicBone.ColliderManager.ColliderType __Gen_Wrap_152(System.Object P0)
  System.Void __Gen_Wrap_153(System.Object P0, UnityEngine.Vector3 P1)
  System.Void __Gen_Wrap_154(System.Object P0, System.Single P1, System.Single P2, System.Single P3)
  BeyondDynamicBone.ClothProcess __Gen_Wrap_155(System.Object P0, System.Int32 P1)
  System.Void __Gen_Wrap_156(System.Object P0, System.Object P1, System.Int32 P2, System.Boolean P3)
  Unity.Jobs.JobHandle __Gen_Wrap_157(System.Object P0, Unity.Jobs.JobHandle P1)
  System.Void __Gen_Wrap_158(BeyondDynamicBone.AngleConstraint.AngleConstraintJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Boolean __Gen_Wrap_159(Unity.Mathematics.float3& P0, Unity.Mathematics.float3& P1, System.Single P2, Unity.Mathematics.float3& P3)
  Unity.Mathematics.quaternion __Gen_Wrap_160(Unity.Mathematics.float3& P0, Unity.Mathematics.float3& P1, System.Single P2)
  System.Void __Gen_Wrap_161(BeyondDynamicBone.AngleConstraint.AngleConstraintJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_162(BeyondDynamicBone.AngleConstraint.AngleConstraintJob& P0)
  System.Single __Gen_Wrap_163(Unity.Mathematics.float3& P0, Unity.Mathematics.float3& P1, System.Single P2, BeyondDynamicBone.AABB& P3, BeyondDynamicBone.ColliderManager.WorkData& P4, System.Boolean P5, System.Single P6, Unity.Mathematics.float3& P7)
  System.Single __Gen_Wrap_164(Unity.Mathematics.float3& P0, System.Single P1, BeyondDynamicBone.ColliderManager.WorkData& P2, Unity.Mathematics.float3& P3)
  System.Single __Gen_Wrap_165(Unity.Mathematics.float3& P0, System.Single P1, BeyondDynamicBone.AABB& P2, BeyondDynamicBone.ColliderManager.WorkData& P3, Unity.Mathematics.float3& P4)
  System.Single __Gen_Wrap_166(Unity.Mathematics.float3x2& P0, Unity.Mathematics.float2& P1, BeyondDynamicBone.AABB& P2, System.Single P3, BeyondDynamicBone.ColliderManager.WorkData& P4, Unity.Mathematics.float3& P5)
  System.Single __Gen_Wrap_167(Unity.Mathematics.float3x2& P0, Unity.Mathematics.float2& P1, BeyondDynamicBone.ColliderManager.WorkData& P2, Unity.Mathematics.float3& P3)
  System.Void __Gen_Wrap_168(BeyondDynamicBone.ColliderCollisionConstraint.PointColliderCollisionConstraintJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Single __Gen_Wrap_169(BeyondDynamicBone.ColliderCollisionConstraint.PointColliderCollisionConstraintJob& P0, Unity.Mathematics.float3& P1, Unity.Mathematics.float3& P2, System.Single P3, BeyondDynamicBone.AABB& P4, BeyondDynamicBone.ColliderManager.WorkData& P5, System.Boolean P6, System.Single P7, Unity.Mathematics.float3& P8)
  System.Single __Gen_Wrap_170(BeyondDynamicBone.ColliderCollisionConstraint.PointColliderCollisionConstraintJob& P0, Unity.Mathematics.float3& P1, System.Single P2, BeyondDynamicBone.AABB& P3, BeyondDynamicBone.ColliderManager.WorkData& P4, Unity.Mathematics.float3& P5)
  System.Single __Gen_Wrap_171(BeyondDynamicBone.ColliderCollisionConstraint.PointColliderCollisionConstraintJob& P0, Unity.Mathematics.float3& P1, System.Single P2, BeyondDynamicBone.ColliderManager.WorkData& P3, Unity.Mathematics.float3& P4)
  System.Void __Gen_Wrap_172(BeyondDynamicBone.ColliderCollisionConstraint.PointColliderCollisionConstraintJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_173(BeyondDynamicBone.ColliderCollisionConstraint.PointColliderCollisionConstraintJob& P0)
  System.Void __Gen_Wrap_174(BeyondDynamicBone.ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Single __Gen_Wrap_175(BeyondDynamicBone.ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob& P0, Unity.Mathematics.float3x2& P1, Unity.Mathematics.float2& P2, BeyondDynamicBone.AABB& P3, System.Single P4, BeyondDynamicBone.ColliderManager.WorkData& P5, Unity.Mathematics.float3& P6)
  System.Single __Gen_Wrap_176(BeyondDynamicBone.ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob& P0, Unity.Mathematics.float3x2& P1, Unity.Mathematics.float2& P2, BeyondDynamicBone.ColliderManager.WorkData& P3, Unity.Mathematics.float3& P4)
  System.Void __Gen_Wrap_177(BeyondDynamicBone.ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_178(BeyondDynamicBone.ColliderCollisionConstraint.EdgeColliderCollisionConstraintJob& P0)
  System.Void __Gen_Wrap_179(BeyondDynamicBone.ColliderCollisionConstraint.SolveEdgeBufferAndClearJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  Unity.Mathematics.float3 __Gen_Wrap_180(System.Int32 P0, Unity.Collections.NativeArray<System.Int32>& P1, Unity.Collections.NativeArray<System.Int32>& P2)
  System.Single __Gen_Wrap_181(System.Int32 P0, Unity.Collections.NativeArray<System.Int32>& P1)
  Unity.Mathematics.float3 __Gen_Wrap_182(System.Int32 P0, Unity.Collections.NativeArray<System.Int32>& P1)
  System.Void __Gen_Wrap_183(BeyondDynamicBone.ColliderCollisionConstraint.SolveEdgeBufferAndClearJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_184(BeyondDynamicBone.ColliderCollisionConstraint.SolveEdgeBufferAndClearJob& P0)
  System.Void __Gen_Wrap_185(BeyondDynamicBone.DistanceConstraint.DistanceConstraintJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_186(BeyondDynamicBone.DistanceConstraint.DistanceConstraintJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_187(BeyondDynamicBone.DistanceConstraint.DistanceConstraintJob& P0)
  System.Void __Gen_Wrap_188(BeyondDynamicBone.MotionConstraint.MotionConstraintJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_189(BeyondDynamicBone.MotionConstraint.MotionConstraintJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_190(BeyondDynamicBone.MotionConstraint.MotionConstraintJob& P0)
  System.Int32 __Gen_Wrap_191(Unity.Collections.NativeArray<BeyondDynamicBone.SelfCollisionConstraint.SortData>& P0, BeyondDynamicBone.SelfCollisionConstraint.SortData& P1, BeyondDynamicBone.DataChunk& P2)
  Unity.Jobs.JobHandle __Gen_Wrap_192(Unity.Collections.NativeArray<System.Int32>& P0, Unity.Collections.NativeReference<System.Int32>& P1, System.Single P2, Unity.Jobs.JobHandle P3)
  Unity.Jobs.JobHandle __Gen_Wrap_193(BeyondDynamicBone.ExProcessingList<System.Int32>& P0, System.Single P1, Unity.Jobs.JobHandle P2)
  Unity.Jobs.JobHandle __Gen_Wrap_194(System.Object P0, System.Int32 P1, Unity.Jobs.JobHandle P2)
  Unity.Jobs.JobHandle __Gen_Wrap_195(Unity.Collections.NativeArray<System.Byte> P0, System.Int32 P1, System.Byte P2, Unity.Jobs.JobHandle P3)
  System.Int32 __Gen_Wrap_196(BeyondDynamicBone.SelfCollisionConstraint.SortData& P0, BeyondDynamicBone.SelfCollisionConstraint.SortData P1)
  System.String __Gen_Wrap_197(BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeContact& P0)
  System.String __Gen_Wrap_198(BeyondDynamicBone.SelfCollisionConstraint.PointTriangleContact& P0)
  System.Void __Gen_Wrap_199(BeyondDynamicBone.SelfCollisionConstraint.InitPrimitiveJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_200(BeyondDynamicBone.SelfCollisionConstraint.ClearBufferJob& P0)
  System.Void __Gen_Wrap_201(BeyondDynamicBone.SelfCollisionConstraint.UpdatePrimitiveJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_202(BeyondDynamicBone.SelfCollisionConstraint.UpdatePrimitiveJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_203(BeyondDynamicBone.SelfCollisionConstraint.UpdatePrimitiveJob& P0)
  System.Void __Gen_Wrap_204(BeyondDynamicBone.SelfCollisionConstraint.SortJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_205(BeyondDynamicBone.SelfCollisionConstraint.SortJob& P0)
  System.Void __Gen_Wrap_206(BeyondDynamicBone.SelfCollisionConstraint.PointTriangleBroadPhaseJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_207(BeyondDynamicBone.SelfCollisionConstraint.PointTriangleBroadPhaseJob& P0, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P1, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P2, System.Single P3, System.Single P4, System.Single P5)
  System.Void __Gen_Wrap_208(BeyondDynamicBone.SelfCollisionConstraint.PointTriangleBroadPhaseJob& P0, System.Int32 P1, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P2, BeyondDynamicBone.SelfCollisionConstraint.SortData& P3, BeyondDynamicBone.DataChunk& P4, System.Boolean P5)
  System.Void __Gen_Wrap_209(BeyondDynamicBone.SelfCollisionConstraint.PointTriangleBroadPhaseJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_210(BeyondDynamicBone.SelfCollisionConstraint.PointTriangleBroadPhaseJob& P0)
  System.Void __Gen_Wrap_211(BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeBroadPhaseJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_212(BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeBroadPhaseJob& P0, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P1, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P2, System.Single P3, System.Single P4)
  System.Void __Gen_Wrap_213(BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeBroadPhaseJob& P0, System.Int32 P1, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P2, BeyondDynamicBone.SelfCollisionConstraint.SortData& P3, BeyondDynamicBone.DataChunk& P4, System.Boolean P5)
  System.Void __Gen_Wrap_214(BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeBroadPhaseJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_215(BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeBroadPhaseJob& P0)
  System.Void __Gen_Wrap_216(BeyondDynamicBone.SelfCollisionConstraint.EdgeEdgeToListJob& P0)
  System.Void __Gen_Wrap_217(BeyondDynamicBone.SelfCollisionConstraint.PointTriangleToListJob& P0)
  System.Void __Gen_Wrap_218(BeyondDynamicBone.SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_219(BeyondDynamicBone.SelfCollisionConstraint.UpdatePointTriangleBroadPhaseJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_220(BeyondDynamicBone.SelfCollisionConstraint.SolverEdgeEdgeJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_221(BeyondDynamicBone.SelfCollisionConstraint.SolverPointTriangleJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_222(BeyondDynamicBone.SelfCollisionConstraint.IntersectUpdatePrimitiveJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_223(BeyondDynamicBone.SelfCollisionConstraint.IntersectUpdatePrimitiveJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_224(BeyondDynamicBone.SelfCollisionConstraint.IntersectUpdatePrimitiveJob& P0)
  System.Void __Gen_Wrap_225(BeyondDynamicBone.SelfCollisionConstraint.IntersectEdgeTriangleJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_226(BeyondDynamicBone.SelfCollisionConstraint.IntersectEdgeTriangleJob& P0, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P1, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P2)
  System.Void __Gen_Wrap_227(BeyondDynamicBone.SelfCollisionConstraint.IntersectEdgeTriangleJob& P0, BeyondDynamicBone.SelfCollisionConstraint.Primitive& P1, BeyondDynamicBone.SelfCollisionConstraint.SortData& P2, BeyondDynamicBone.DataChunk& P3, System.Boolean P4)
  System.Void __Gen_Wrap_228(BeyondDynamicBone.SelfCollisionConstraint.IntersectEdgeTriangleJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_229(BeyondDynamicBone.SelfCollisionConstraint.IntersectEdgeTriangleJob& P0)
  System.Void __Gen_Wrap_230(BeyondDynamicBone.SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseCrossFrameJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_231(BeyondDynamicBone.SelfCollisionConstraint.UpdateEdgeEdgeBroadPhaseCrossFrameJob& P0)
  System.Void __Gen_Wrap_232(BeyondDynamicBone.SelfCollisionConstraint.UpdatePointTriangleBroadPhaseCrossFrameJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_233(BeyondDynamicBone.SelfCollisionConstraint.UpdatePointTriangleBroadPhaseCrossFrameJob& P0)
  System.Void __Gen_Wrap_234(BeyondDynamicBone.SelfCollisionConstraint.SolverEdgeEdgeCrossFrameJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_235(BeyondDynamicBone.SelfCollisionConstraint.SolverEdgeEdgeCrossFrameJob& P0)
  System.Void __Gen_Wrap_236(BeyondDynamicBone.SelfCollisionConstraint.SolverPointTriangleCrossFrameJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_237(BeyondDynamicBone.SelfCollisionConstraint.SolverPointTriangleCrossFrameJob& P0)
  BeyondDynamicBone.SpringConstraint.SerializeData __Gen_Wrap_238(System.Object P0)
  System.Void __Gen_Wrap_239(BeyondDynamicBone.TetherConstraint.TethreConstraintJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_240(BeyondDynamicBone.TetherConstraint.TethreConstraintJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_241(BeyondDynamicBone.TetherConstraint.TethreConstraintJob& P0)
  System.Boolean __Gen_Wrap_242(Unity.Mathematics.float3x4& P0, Unity.Mathematics.float4& P1, System.Single P2, System.Single P3, Unity.Mathematics.float3x4& P4)
  System.Boolean __Gen_Wrap_243(System.Single P0, Unity.Mathematics.float3x4& P1, Unity.Mathematics.float4& P2, System.Single P3, System.Single P4, Unity.Mathematics.float3x4& P5)
  System.Void __Gen_Wrap_244(BeyondDynamicBone.TriangleBendingConstraint.TriangleBendingJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Boolean __Gen_Wrap_245(BeyondDynamicBone.TriangleBendingConstraint.TriangleBendingJob& P0, Unity.Mathematics.float3x4& P1, Unity.Mathematics.float4& P2, System.Single P3, System.Single P4, Unity.Mathematics.float3x4& P5)
  System.Boolean __Gen_Wrap_246(BeyondDynamicBone.TriangleBendingConstraint.TriangleBendingJob& P0, System.Single P1, Unity.Mathematics.float3x4& P2, Unity.Mathematics.float4& P3, System.Single P4, System.Single P5, Unity.Mathematics.float3x4& P6)
  System.Void __Gen_Wrap_247(BeyondDynamicBone.TriangleBendingConstraint.TriangleBendingJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_248(BeyondDynamicBone.TriangleBendingConstraint.TriangleBendingJob& P0)
  System.Void __Gen_Wrap_249(BeyondDynamicBone.TriangleBendingConstraint.SolveAggregateBufferJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_250(BeyondDynamicBone.TriangleBendingConstraint.SolveAggregateBufferJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_251(BeyondDynamicBone.TriangleBendingConstraint.SolveAggregateBufferJob& P0)
  System.Void __Gen_Wrap_252(System.Object P0, System.Single P1, System.Single P2, System.Single P3, System.Boolean P4)
  System.Void __Gen_Wrap_253(System.Object P0, System.Single P1, System.Object P2)
  Unity.Collections.NativeArray<Unity.Mathematics.float3> __Gen_Wrap_254(System.Object P0, Unity.Mathematics.float4x4 P1)
  System.Void __Gen_Wrap_255(BeyondDynamicBone.SelectionData.TransformPositionJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_256(BeyondDynamicBone.SelectionData.CreateGridMapJob& P0)
  System.Void __Gen_Wrap_257(BeyondDynamicBone.SelectionData.ConvertSelectionJob& P0, System.Int32 P1)
  UnityEngine.Vector3 __Gen_Wrap_258(System.Object P0, System.Boolean P1)
  System.Void __Gen_Wrap_259(System.Object P0, UnityEngine.Vector3 P1, System.Boolean P2)
  System.Boolean __Gen_Wrap_260(BeyondDynamicBone.WindParams& P0)
  System.Boolean __Gen_Wrap_261(System.Object P0, System.Object P1, System.Object P2)
  System.Boolean __Gen_Wrap_262(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3)
  System.Void __Gen_Wrap_263(System.Object P0, System.Object P1, UnityEngine.Jobs.TransformAccessArray P2)
  BeyondDynamicBone.DataChunk __Gen_Wrap_264(System.Object P0, BeyondDynamicBone.DataChunk P1, System.Int32 P2)
  System.Single __Gen_Wrap_265()
  Unity.Jobs.JobHandle __Gen_Wrap_266(System.Object P0, Unity.Jobs.JobHandle P1, Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>& P2, Unity.Collections.NativeParallelHashMap<System.Int32,UnityEngine.AnimationTransformRWBufferHandle>& P3, Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>& P4)
  System.Void __Gen_Wrap_267(BeyondDynamicBone.DynamicBoneTransformManager.ValidTransformJob& P0, System.Int32 P1)
  Unity.Jobs.JobHandle __Gen_Wrap_268(System.Object P0, System.Int32 P1, System.Int32 P2, Unity.Jobs.JobHandle P3)
  Unity.Jobs.JobHandle __Gen_Wrap_269(System.Object P0, System.Boolean P1, BeyondDynamicBone.DataChunk P2, Unity.Jobs.JobHandle P3)
  Unity.Jobs.JobHandle __Gen_Wrap_270(System.Object P0, BeyondDynamicBone.DataChunk P1, Unity.Jobs.JobHandle P2)
  BeyondDynamicBone.VirtualMeshContainer __Gen_Wrap_271(System.Object P0)
  BeyondDynamicBone.VirtualMeshContainer __Gen_Wrap_272(System.Object P0, System.Int32 P1)
  System.Void __Gen_Wrap_273(BeyondDynamicBone.DoAllInOneJob& P0)
  System.Void __Gen_Wrap_274(BeyondDynamicBone.DynamicBoneTransformManager.ReadAnimatorBufferDataJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2)
  System.Void __Gen_Wrap_275(BeyondDynamicBone.DynamicBoneTransformManager.WriteAnimatorBufferDataJob& P0)
  System.Void __Gen_Wrap_276(BeyondDynamicBone.DynamicBoneTransformManager.CopyDoubleBufferJob& P0)
  System.Void __Gen_Wrap_277(BeyondDynamicBone.DynamicBoneTransformManager.EnableTransformJob& P0)
  System.Void __Gen_Wrap_278(BeyondDynamicBone.DynamicBoneTransformManager.RestoreTransformJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2)
  System.Void __Gen_Wrap_279(BeyondDynamicBone.DynamicBoneTransformManager.ReadTransformJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2)
  System.Void __Gen_Wrap_280(BeyondDynamicBone.DynamicBoneTransformManager.ValidTransformJob& P0)
  System.Void __Gen_Wrap_281(BeyondDynamicBone.DynamicBoneTransformManager.WriteTransformJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2)
  System.Void __Gen_Wrap_282(BeyondDynamicBone.DynamicBoneTransformManager.ReadComponentTransformJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2)
  System.Void __Gen_Wrap_283(BeyondDynamicBone.ClothProcess P0)
  System.String __Gen_Wrap_284(BeyondDynamicBone.TeamWindInfo& P0)
  System.Boolean __Gen_Wrap_285(BeyondDynamicBone.TeamManager.MappingData& P0)
  System.Void __Gen_Wrap_286(BeyondDynamicBone.TeamManager.AlwaysTeamUpdatePreJob& P0)
  System.Void __Gen_Wrap_287(BeyondDynamicBone.TeamManager.AlwaysTeamUpdatePostJob& P0, System.Int32 P1, BeyondDynamicBone.TeamManager.TeamData& P2)
  System.Void __Gen_Wrap_288(BeyondDynamicBone.TeamManager.AlwaysTeamUpdatePostJob& P0)
  System.Void __Gen_Wrap_289(BeyondDynamicBone.TeamManager.CalcCenterAndInertiaAndWindJob& P0, System.Int32 P1)
  Unity.Mathematics.float3 __Gen_Wrap_290(Unity.Mathematics.float3& P0, Unity.Mathematics.float3& P1, Unity.Mathematics.float3& P2, Unity.Mathematics.quaternion& P3)
  System.Boolean __Gen_Wrap_291(BeyondDynamicBone.WindManager.WindData& P0)
  System.Boolean __Gen_Wrap_292(BeyondDynamicBone.TeamWindInfo& P0)
  System.Int32 __Gen_Wrap_293(BeyondDynamicBone.TeamWindData& P0, System.Int32 P1)
  System.Void __Gen_Wrap_294(BeyondDynamicBone.TeamWindData& P0, BeyondDynamicBone.TeamWindInfo P1, BeyondDynamicBone.TeamWindData& P2)
  System.Void __Gen_Wrap_295(BeyondDynamicBone.TeamWindData& P0, System.Int32 P1)
  System.Void __Gen_Wrap_296(BeyondDynamicBone.TeamManager.CalcCenterAndInertiaAndWindJob& P0, System.Int32 P1, BeyondDynamicBone.ClothParameters& P2, Unity.Mathematics.float3& P3)
  System.Void __Gen_Wrap_297(BeyondDynamicBone.TeamManager.CalcCenterAndInertiaAndWindJob& P0)
  System.Void __Gen_Wrap_298(BeyondDynamicBone.TeamManager.SimulationStepTeamUpdateJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_299(BeyondDynamicBone.TeamManager.SimulationStepTeamUpdateJob& P0, BeyondDynamicBone.TeamWindInfo& P1, System.Single P2, System.Single P3)
  System.Void __Gen_Wrap_300(BeyondDynamicBone.TeamManager.SimulationStepTeamUpdateJob& P0, System.Int32 P1, BeyondDynamicBone.TeamManager.TeamData& P2, BeyondDynamicBone.WindParams& P3, BeyondDynamicBone.InertiaConstraint.CenterData& P4)
  System.Void __Gen_Wrap_301(BeyondDynamicBone.TeamManager.SimulationStepTeamUpdateJob& P0)
  System.Void __Gen_Wrap_302(BeyondDynamicBone.TeamManager.PostTeamUpdateJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_303(BeyondDynamicBone.TeamManager.PostTeamUpdateJob& P0)
  System.Void __Gen_Wrap_304(BeyondDynamicBone.VirtualMeshManager.ClearProxyMeshUpdateBufferJob& P0)
  System.Void __Gen_Wrap_305(BeyondDynamicBone.VirtualMeshManager.CreateProxyMeshUpdateVertexList& P0, System.Int32 P1)
  System.Int32 __Gen_Wrap_306(Unity.Collections.NativeReference<System.Int32>& P0, System.Int32 P1)
  System.Void __Gen_Wrap_307(BeyondDynamicBone.VirtualMeshManager.CreateProxyMeshUpdateVertexList& P0)
  System.Void __Gen_Wrap_308(BeyondDynamicBone.VirtualMeshManager.CalcProxyMeshSkinningJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Int32 __Gen_Wrap_309(BeyondDynamicBone.VirtualMeshBoneWeight& P0)
  System.Void __Gen_Wrap_310(BeyondDynamicBone.VirtualMeshManager.CalcProxyMeshSkinningJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_311(BeyondDynamicBone.VirtualMeshManager.CalcProxyMeshSkinningJob& P0)
  System.Void __Gen_Wrap_312(BeyondDynamicBone.VirtualMeshManager.CreatePostProxyMeshUpdateListJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_313(BeyondDynamicBone.VirtualMeshManager.CreatePostProxyMeshUpdateListJob& P0)
  System.Void __Gen_Wrap_314(BeyondDynamicBone.VirtualMeshManager.CalcLineNormalTangentJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_315(BeyondDynamicBone.VirtualMeshManager.CalcLineNormalTangentJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_316(BeyondDynamicBone.VirtualMeshManager.CalcLineNormalTangentJob& P0)
  System.Void __Gen_Wrap_317(BeyondDynamicBone.VirtualMeshManager.CalcTriangleNormalTangentJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  Unity.Mathematics.float3 __Gen_Wrap_318(Unity.Mathematics.float3& P0, Unity.Mathematics.float3& P1, Unity.Mathematics.float3& P2, Unity.Mathematics.float2& P3, Unity.Mathematics.float2& P4, Unity.Mathematics.float2& P5)
  System.Void __Gen_Wrap_319(BeyondDynamicBone.VirtualMeshManager.CalcTriangleNormalTangentJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_320(BeyondDynamicBone.VirtualMeshManager.CalcTriangleNormalTangentJob& P0)
  System.Void __Gen_Wrap_321(BeyondDynamicBone.VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_322(BeyondDynamicBone.VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_323(BeyondDynamicBone.VirtualMeshManager.CalcVertexNormalTangentFromTriangleJob& P0)
  System.Void __Gen_Wrap_324(BeyondDynamicBone.VirtualMeshManager.WriteTransformDataJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_325(BeyondDynamicBone.VirtualMeshManager.WriteTransformDataJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_326(BeyondDynamicBone.VirtualMeshManager.WriteTransformDataJob& P0)
  System.Void __Gen_Wrap_327(BeyondDynamicBone.VirtualMeshManager.WriteTransformLocalDataJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_328(BeyondDynamicBone.VirtualMeshManager.WriteTransformLocalDataJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_329(BeyondDynamicBone.VirtualMeshManager.WriteTransformLocalDataJob& P0)
  System.Void __Gen_Wrap_330(BeyondDynamicBone.VirtualMeshManager.CalcMeshConvertMatrixJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_331(BeyondDynamicBone.VirtualMeshManager.CalcMeshConvertMatrixJob& P0)
  System.Void __Gen_Wrap_332(BeyondDynamicBone.VirtualMeshManager.CalcProxySkinningJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_333(BeyondDynamicBone.VirtualMeshManager.CalcProxySkinningJob& P0)
  System.Boolean __Gen_Wrap_334(UnityEngine.LowLevel.PlayerLoopSystem P0)
  System.Boolean __Gen_Wrap_335(UnityEngine.LowLevel.PlayerLoopSystem& P0)
  System.Void __Gen_Wrap_336(UnityEngine.LowLevel.PlayerLoopSystem P0, UnityEngine.LowLevel.PlayerLoopSystem& P1, System.Object P2, System.Object P3, System.Boolean P4, System.Boolean P5)
  System.Void __Gen_Wrap_337(UnityEngine.LowLevel.PlayerLoopSystem& P0)
  System.Void __Gen_Wrap_338(System.Boolean P0)
  System.Void __Gen_Wrap_339(System.Single P0)
  System.Void __Gen_Wrap_340(System.Boolean P0, System.Single P1)
  System.Int32 __Gen_Wrap_341()
  System.Void __Gen_Wrap_342(BeyondDynamicBone.TimeManager.UpdateLocation P0)
  BeyondDynamicBone.TimeManager.UpdateLocation __Gen_Wrap_343()
  System.Void __Gen_Wrap_344(BeyondDynamicBone.MagicaManager.InitializationLocation P0)
  System.Void __Gen_Wrap_345(BeyondDynamicBone.RenderData.UpdatePositionNormalJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_346(BeyondDynamicBone.RenderData.UpdatePositionNormalJob& P0)
  System.Void __Gen_Wrap_347(BeyondDynamicBone.RenderData.UpdatePositionNormalTangentJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_348(BeyondDynamicBone.RenderData.UpdatePositionNormalTangentJob& P0)
  System.Void __Gen_Wrap_349(BeyondDynamicBone.RenderData.UpdateBoneWeightJob2& P0, System.Int32 P1)
  System.Void __Gen_Wrap_350(BeyondDynamicBone.RenderData.UpdateBoneWeightJob2& P0)
  BeyondDynamicBone.RenderSetupData.ShareSerializationData __Gen_Wrap_351(System.Object P0)
  BeyondDynamicBone.RenderSetupData.UniqueSerializationData __Gen_Wrap_352(System.Object P0)
  System.Void __Gen_Wrap_353(BeyondDynamicBone.RenderSetupData.VertexWeight5BoneCheckJob& P0)
  System.Void __Gen_Wrap_354(BeyondDynamicBone.RenderSetupData.ReadTransformJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2)
  System.Void __Gen_Wrap_355(BeyondDynamicBone.RenderSetupData.GetBoneWeightJos& P0)
  System.Void __Gen_Wrap_356(BeyondDynamicBone.ColliderManager.PreSimulationUpdateJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_357(BeyondDynamicBone.ColliderManager.PreSimulationUpdateJob& P0)
  System.Void __Gen_Wrap_358(BeyondDynamicBone.ColliderManager.CreateUpdatecolliderListJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_359(BeyondDynamicBone.ColliderManager.CreateUpdatecolliderListJob& P0)
  System.Void __Gen_Wrap_360(BeyondDynamicBone.ColliderManager.StartSimulationStepJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_361(BeyondDynamicBone.ColliderManager.StartSimulationStepJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_362(BeyondDynamicBone.ColliderManager.StartSimulationStepJob& P0)
  System.Void __Gen_Wrap_363(BeyondDynamicBone.ColliderManager.EndSimulationStepJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_364(BeyondDynamicBone.ColliderManager.EndSimulationStepJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_365(BeyondDynamicBone.ColliderManager.EndSimulationStepJob& P0)
  System.Void __Gen_Wrap_366(BeyondDynamicBone.ColliderManager.PostSimulationUpdateJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_367(BeyondDynamicBone.ColliderManager.PostSimulationUpdateJob& P0)
  Unity.Jobs.JobHandle __Gen_Wrap_368(System.Object P0, Unity.Collections.NativeList<System.Int32>& P1, Unity.Jobs.JobHandle P2)
  Unity.Jobs.JobHandle __Gen_Wrap_369(System.Object P0, Unity.Collections.NativeArray<System.Int32>& P1, Unity.Collections.NativeReference<System.Int32>& P2, Unity.Jobs.JobHandle P3)
  Unity.Jobs.JobHandle __Gen_Wrap_370(System.Object P0, BeyondDynamicBone.ExProcessingList<System.Int32>& P1, Unity.Jobs.JobHandle P2)
  System.Void __Gen_Wrap_371(BeyondDynamicBone.SimulationManager.PreSimulationUpdateJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_372(BeyondDynamicBone.SimulationManager.PreSimulationUpdateJob& P0)
  System.Void __Gen_Wrap_373(BeyondDynamicBone.SimulationManager.ClearStepCounter& P0)
  System.Void __Gen_Wrap_374(BeyondDynamicBone.SimulationManager.CreateUpdateParticleList& P0, System.Int32 P1)
  System.Void __Gen_Wrap_375(BeyondDynamicBone.SimulationManager.CreateUpdateParticleList& P0)
  System.Void __Gen_Wrap_376(BeyondDynamicBone.SimulationManager.StartSimulationStepJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_377(BeyondDynamicBone.SimulationManager.StartSimulationStepJob& P0, BeyondDynamicBone.TeamWindInfo& P1, BeyondDynamicBone.WindParams& P2, Unity.Mathematics.float3& P3, System.Single P4, Unity.Mathematics.float3& P5)
  System.Void __Gen_Wrap_378(BeyondDynamicBone.SimulationManager.StartSimulationStepJob& P0, System.Int32 P1, BeyondDynamicBone.TeamManager.TeamData& P2, BeyondDynamicBone.WindParams& P3, BeyondDynamicBone.InertiaConstraint.CenterData& P4, System.Int32 P5, System.Int32 P6, System.Single P7, Unity.Mathematics.float3& P8)
  System.Void __Gen_Wrap_379(BeyondDynamicBone.SimulationManager.StartSimulationStepJob& P0, BeyondDynamicBone.SpringConstraint.SpringConstraintParams& P1, BeyondDynamicBone.ClothNormalAxis P2, Unity.Mathematics.float3& P3, Unity.Mathematics.float3& P4, Unity.Mathematics.quaternion& P5, System.Single P6, System.Single P7)
  System.Void __Gen_Wrap_380(BeyondDynamicBone.SimulationManager.StartSimulationStepJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_381(BeyondDynamicBone.SimulationManager.StartSimulationStepJob& P0)
  System.Void __Gen_Wrap_382(BeyondDynamicBone.SimulationManager.UpdateStepBasicPotureJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_383(BeyondDynamicBone.SimulationManager.UpdateStepBasicPotureJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_384(BeyondDynamicBone.SimulationManager.UpdateStepBasicPotureJob& P0)
  System.Void __Gen_Wrap_385(BeyondDynamicBone.SimulationManager.EndSimulationStepJob& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_386(BeyondDynamicBone.SimulationManager.EndSimulationStepJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_387(BeyondDynamicBone.SimulationManager.EndSimulationStepJob& P0)
  System.Void __Gen_Wrap_388(BeyondDynamicBone.SimulationManager.CalcDisplayPositionJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_389(BeyondDynamicBone.SimulationManager.CalcDisplayPositionJob& P0)
  System.Void __Gen_Wrap_390(BeyondDynamicBone.SimulationManager.FeedbackTempPosJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_391(BeyondDynamicBone.SimulationManager.FeedbackTempPosJob2& P0, System.Int32 P1)
  System.Void __Gen_Wrap_392(BeyondDynamicBone.TeamWindInfo& P0)
  System.Void __Gen_Wrap_393(BeyondDynamicBone.TeamWindData& P0)
  System.Int32 __Gen_Wrap_394(System.Object P0, System.Object P1, System.Int32 P2, System.Int32 P3, System.Byte P4, System.Boolean P5)
  System.Int32[] __Gen_Wrap_395(System.Object P0, System.Object P1, System.Object P2, System.Object P3, System.Int32 P4)
  System.Int32[] __Gen_Wrap_396(System.Object P0, System.Object P1, System.Int32 P2)
  System.Int32 __Gen_Wrap_397(System.Object P0, System.Int32 P1, System.Object P2, System.Int32 P3, System.Int32 P4, System.Byte P5)
  Unity.Mathematics.float4x4 __Gen_Wrap_398(System.Object P0, System.Int32 P1)
  BeyondDynamicBone.TransformData.ShareSerializationData __Gen_Wrap_399(System.Object P0)
  BeyondDynamicBone.TransformData.UniqueSerializationData __Gen_Wrap_400(System.Object P0)
  System.Void __Gen_Wrap_401(BeyondDynamicBone.TransformData.RestoreTransformJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2)
  System.Void __Gen_Wrap_402(BeyondDynamicBone.TransformData.ReadTransformJob& P0, System.Int32 P1, UnityEngine.Jobs.TransformAccess P2)
  UnityEngine.Vector3 __Gen_Wrap_403(System.Object P0, UnityEngine.Vector3 P1)
  BeyondDynamicBone.SharePreBuildData __Gen_Wrap_404(System.Object P0, System.Object P1)
  System.Boolean __Gen_Wrap_405(BeyondDynamicBone.SharePreBuildData P0)
  System.Void __Gen_Wrap_406(BeyondDynamicBone.SharePreBuildData P0)
  System.String __Gen_Wrap_407()
  System.Void __Gen_Wrap_408(BeyondDynamicBone.SameDistanceReduction.InitGridJob& P0)
  System.Void __Gen_Wrap_409(BeyondDynamicBone.SameDistanceReduction.SearchJoinJob& P0)
  System.Void __Gen_Wrap_410(BeyondDynamicBone.VirtualMeshBoneWeight& P0, System.Int32 P1, System.Single P2)
  System.Void __Gen_Wrap_411(BeyondDynamicBone.VirtualMeshBoneWeight& P0, BeyondDynamicBone.VirtualMeshBoneWeight& P1)
  System.Void __Gen_Wrap_412(BeyondDynamicBone.SameDistanceReduction.JoinJob2& P0)
  System.Void __Gen_Wrap_413(BeyondDynamicBone.SameDistanceReduction.UpdateJoinIndexJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_414(BeyondDynamicBone.SameDistanceReduction.UpdateLinkIndexJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_415(BeyondDynamicBone.VirtualMeshBoneWeight& P0)
  System.Void __Gen_Wrap_416(BeyondDynamicBone.SameDistanceReduction.FinalMergeVertexJob& P0, System.Int32 P1)
  System.Boolean __Gen_Wrap_417(Unity.Collections.NativeParallelMultiHashMap<System.UInt16,System.UInt16>& P0, System.Int32 P1, System.Int32 P2, System.Boolean P3)
  System.Void __Gen_Wrap_418(BeyondDynamicBone.ShapeDistanceReduction.SearchJoinEdgeJob& P0)
  System.Void __Gen_Wrap_419(BeyondDynamicBone.SimpleDistanceReduction.InitGridJob& P0)
  System.Void __Gen_Wrap_420(BeyondDynamicBone.SimpleDistanceReduction.SearchJoinEdgeJob& P0)
  System.Boolean __Gen_Wrap_421(Unity.Collections.NativeArray<Unity.Collections.FixedList128Bytes<System.UInt16>>& P0, System.Int32 P1, System.Int32 P2, Unity.Collections.FixedList128Bytes<System.UInt16>& P3, Unity.Collections.FixedList128Bytes<System.UInt16>& P4, System.Boolean P5)
  System.Boolean __Gen_Wrap_422(BeyondDynamicBone.StepReductionBase.JoinEdge& P0, Unity.Mathematics.int2& P1)
  System.Int32 __Gen_Wrap_423(BeyondDynamicBone.StepReductionBase.JoinEdge& P0, BeyondDynamicBone.StepReductionBase.JoinEdge P1)
  System.Void __Gen_Wrap_424(BeyondDynamicBone.StepReductionBase.DeterminJoinEdgeJob& P0)
  System.Void __Gen_Wrap_425(BeyondDynamicBone.StepReductionBase.JoinPairJob& P0)
  System.Void __Gen_Wrap_426(BeyondDynamicBone.StepReductionBase.UpdateJoinIndexJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_427(BeyondDynamicBone.StepReductionBase.UpdateLinkIndexJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_428(BeyondDynamicBone.StepReductionBase.FinalMergeVertexJob& P0, System.Int32 P1)
  Unity.Mathematics.int3 __Gen_Wrap_429(Unity.Mathematics.int3& P0)
  Unity.Jobs.JobHandle __Gen_Wrap_430(Unity.Collections.NativeArray<System.Int32> P0, System.Int32 P1, System.Int32 P2, System.Int32 P3, Unity.Jobs.JobHandle P4)
  Unity.Jobs.JobHandle __Gen_Wrap_431(Unity.Collections.NativeReference<System.Int32> P0, System.Int32 P1, Unity.Jobs.JobHandle P2)
  Unity.Jobs.JobHandle __Gen_Wrap_432(Unity.Collections.NativeArray<System.Int32> P0, System.Int32 P1, Unity.Jobs.JobHandle P2)
  Unity.Jobs.JobHandle __Gen_Wrap_433(Unity.Collections.NativeParallelHashSet<System.Int32> P0, Unity.Collections.NativeList<System.Int32> P1, Unity.Jobs.JobHandle P2)
  Unity.Jobs.JobHandle __Gen_Wrap_434(Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int2> P0, Unity.Collections.NativeList<Unity.Mathematics.int2> P1, Unity.Jobs.JobHandle P2)
  Unity.Jobs.JobHandle __Gen_Wrap_435(Unity.Collections.NativeParallelHashSet<Unity.Mathematics.int4> P0, Unity.Collections.NativeList<Unity.Mathematics.int4> P1, Unity.Jobs.JobHandle P2)
  Unity.Jobs.JobHandle __Gen_Wrap_436(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, System.Int32 P1, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> P2, Unity.Jobs.JobHandle P3)
  Unity.Jobs.JobHandle __Gen_Wrap_437(Unity.Collections.NativeList<Unity.Mathematics.float3> P0, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> P1, Unity.Jobs.JobHandle P2)
  System.Void __Gen_Wrap_438(Unity.Collections.NativeList<Unity.Mathematics.float3> P0, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> P1)
  BeyondDynamicBone.AABB __Gen_Wrap_439(Unity.Collections.NativeArray<Unity.Mathematics.float3>& P0, System.Int32 P1)
  Unity.Jobs.JobHandle __Gen_Wrap_440(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, System.Int32 P1, Unity.Collections.NativeReference<BeyondDynamicBone.AABB> P2, Unity.Collections.NativeArray<Unity.Mathematics.float2> P3, Unity.Jobs.JobHandle P4)
  Unity.Jobs.JobHandle __Gen_Wrap_441(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, System.Int32 P1, Unity.Mathematics.float4x4& P2, Unity.Jobs.JobHandle P3)
  Unity.Jobs.JobHandle __Gen_Wrap_442(Unity.Collections.NativeArray<Unity.Mathematics.float3> P0, Unity.Collections.NativeArray<Unity.Mathematics.float3> P1, System.Int32 P2, Unity.Mathematics.float4x4& P3, Unity.Jobs.JobHandle P4)
  Unity.Jobs.JobHandle __Gen_Wrap_443(Unity.Collections.NativeReference<System.Int32> P0, Unity.Jobs.JobHandle P1)
  System.Void __Gen_Wrap_444(BeyondDynamicBone.ClothJobUtility.SerialNumberJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_445(BeyondDynamicBone.ClothJobUtility.CalcAABBJob& P0)
  System.Void __Gen_Wrap_446(BeyondDynamicBone.ClothJobUtility.CalcAABBDeferJob& P0)
  System.Void __Gen_Wrap_447(BeyondDynamicBone.ClothJobUtility.CalcUVJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_448(BeyondDynamicBone.ClothJobUtility.AddIntDataCopyJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_449(BeyondDynamicBone.ClothJobUtility.AddInt2DataCopyJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_450(BeyondDynamicBone.ClothJobUtility.AddInt3DataCopyJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_451(BeyondDynamicBone.ClothJobUtility.TransformPositionJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_452(BeyondDynamicBone.ClothJobUtility.TransformPositionJob2& P0, System.Int32 P1)
  System.Void __Gen_Wrap_453(BeyondDynamicBone.ClothJobUtility.ClearReferenceJob& P0)
  Unity.Jobs.JobHandle __Gen_Wrap_454(Unity.Collections.NativeList<System.Int32>& P0, System.Single P1, Unity.Jobs.JobHandle P2)
  System.Void __Gen_Wrap_455(BeyondDynamicBone.InterlockUtility.AggregateJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_456(BeyondDynamicBone.InterlockUtility.AggregateJob& P0)
  System.Void __Gen_Wrap_457(BeyondDynamicBone.InterlockUtility.AggregateWithVelocityJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_458(BeyondDynamicBone.InterlockUtility.AggregateWithVelocityJob& P0)
  System.Void __Gen_Wrap_459(BeyondDynamicBone.InterlockUtility.AggregateJob2& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_460(BeyondDynamicBone.InterlockUtility.AggregateJob2& P0, System.Int32 P1)
  System.Void __Gen_Wrap_461(BeyondDynamicBone.InterlockUtility.AggregateJob2& P0)
  System.Void __Gen_Wrap_462(BeyondDynamicBone.InterlockUtility.AggregateWithVelocityJob2& P0, Unity.Collections.NativeReference<System.Int32> P1)
  System.Void __Gen_Wrap_463(BeyondDynamicBone.InterlockUtility.AggregateWithVelocityJob2& P0, System.Int32 P1)
  System.Void __Gen_Wrap_464(BeyondDynamicBone.InterlockUtility.AggregateWithVelocityJob2& P0)
  System.Void __Gen_Wrap_465(BeyondDynamicBone.InterlockUtility.AggregateWithVelocityCrossFrameJob2& P0, System.Int32 P1)
  System.Void __Gen_Wrap_466(BeyondDynamicBone.InterlockUtility.AggregateWithVelocityCrossFrameJob2& P0)
  System.Void __Gen_Wrap_467(BeyondDynamicBone.InterlockUtility.AggregateCrossFrameJob2& P0, System.Int32 P1)
  System.Void __Gen_Wrap_468(BeyondDynamicBone.InterlockUtility.AggregateCrossFrameJob2& P0)
  System.String __Gen_Wrap_469(BeyondDynamicBone.AABB& P0)
  System.Void __Gen_Wrap_470(Unity.Mathematics.float3 P0, Unity.Mathematics.quaternion P1, Unity.Mathematics.float3 P2, Unity.Mathematics.quaternion P3, Unity.Mathematics.float3& P4, Unity.Mathematics.quaternion& P5)
  Unity.Mathematics.int2 __Gen_Wrap_471(Unity.Mathematics.int3 P0, Unity.Mathematics.int3 P1)
  Unity.Mathematics.int4 __Gen_Wrap_472(Unity.Mathematics.int3 P0, Unity.Mathematics.int3 P1)
  System.Boolean __Gen_Wrap_473(Unity.Mathematics.float3& P0, Unity.Mathematics.float3& P1, Unity.Mathematics.float3 P2, Unity.Mathematics.float3 P3, Unity.Mathematics.float3 P4, System.Boolean P5, System.Single& P6, System.Single& P7, System.Single& P8, System.Single& P9)
  System.Boolean __Gen_Wrap_474(Unity.Mathematics.float3& P0, Unity.Mathematics.float3& P1, Unity.Mathematics.float3 P2, Unity.Mathematics.float3 P3, Unity.Mathematics.float3 P4)
  System.Single __Gen_Wrap_475(UnityEngine.Vector3 P0, UnityEngine.Vector3 P1, UnityEngine.Vector3 P2)
  BeyondDynamicBone.FTransform __Gen_Wrap_476()
  UnityEngine.Mesh __Gen_Wrap_477(System.Object P0)
  System.Text.StringBuilder __Gen_Wrap_478(System.Object P0)
  System.Text.StringBuilder __Gen_Wrap_479()
  System.String __Gen_Wrap_480(BeyondDynamicBone.DataChunk& P0)
  System.Void __Gen_Wrap_481(BeyondDynamicBone.ExBitFlag16& P0)
  System.Int32 __Gen_Wrap_482(BeyondDynamicBone.ExCostSortedList1& P0, BeyondDynamicBone.ExCostSortedList1 P1)
  System.String __Gen_Wrap_483(BeyondDynamicBone.ExCostSortedList1& P0)
  System.Boolean __Gen_Wrap_484(BeyondDynamicBone.ExCostSortedList4& P0, System.Single P1, System.Int32 P2)
  System.Int32 __Gen_Wrap_485(BeyondDynamicBone.ExCostSortedList4& P0, System.Int32 P1)
  System.Void __Gen_Wrap_486(BeyondDynamicBone.ExCostSortedList4& P0, System.Int32 P1)
  System.String __Gen_Wrap_487(BeyondDynamicBone.ExCostSortedList4& P0)
  UnityEngine.Jobs.TransformAccessArray __Gen_Wrap_488(System.Object P0)
  System.Boolean __Gen_Wrap_489(BeyondDynamicBone.ResultCode& P0, BeyondDynamicBone.Define.Result P1)
  System.Void __Gen_Wrap_490(BeyondDynamicBone.ResultCode& P0, System.Boolean P1, System.Boolean P2, System.Boolean P3)
  System.Double __Gen_Wrap_491(System.Object P0)
  System.Void __Gen_Wrap_492(System.Object P0, System.Object P1, System.Object P2, System.Int32 P3, System.Int32 P4)
  Unity.Mathematics.float4 __Gen_Wrap_493(Unity.Mathematics.float4 P0)
  BeyondDynamicBone.VirtualMesh.ShareSerializationData __Gen_Wrap_494(System.Object P0)
  BeyondDynamicBone.VirtualMesh.UniqueSerializationData __Gen_Wrap_495(System.Object P0)
  BeyondDynamicBone.VirtualMeshRaycastHit __Gen_Wrap_496(System.Object P0, Unity.Mathematics.float3 P1, Unity.Mathematics.float3 P2, System.Boolean P3, System.Single P4)
  System.Void __Gen_Wrap_497(BeyondDynamicBone.VirtualMesh.Import_GenerateTangentJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_498(BeyondDynamicBone.VirtualMesh.Import_CalcSkinningJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_499(BeyondDynamicBone.VirtualMesh.Import_BoneWeightJob1& P0)
  System.Void __Gen_Wrap_500(BeyondDynamicBone.VirtualMesh.Import_BoneWeightJob2& P0, System.Int32 P1)
  System.Void __Gen_Wrap_501(BeyondDynamicBone.VirtualMesh.Import_BoneVertexJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_502(BeyondDynamicBone.VirtualMesh.Select_PackVertexJob& P0)
  System.Void __Gen_Wrap_503(BeyondDynamicBone.VirtualMesh.Select_GridJob& P0)
  System.Void __Gen_Wrap_504(BeyondDynamicBone.VirtualMesh.Add_CalcBindPoseJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_505(BeyondDynamicBone.VirtualMesh.Add_CopyVerticesJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_506(BeyondDynamicBone.VirtualMesh.Mapping_DirectConnectionVertexDataJob& P0)
  System.Void __Gen_Wrap_507(BeyondDynamicBone.VirtualMesh.Mapping_CalcDirectWeightJob& P0)
  System.Void __Gen_Wrap_508(BeyondDynamicBone.VirtualMesh.Mapping_CalcConnectionVertexDataJob& P0)
  System.Void __Gen_Wrap_509(BeyondDynamicBone.VirtualMesh.Mapping_CalcWeightJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_510(BeyondDynamicBone.VirtualMesh.Optimize_EdgeToTrianlgeJob& P0)
  System.Void __Gen_Wrap_511(BeyondDynamicBone.VirtualMesh.ProxyNormalRadiationAdjustmentJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_512(BeyondDynamicBone.VirtualMesh.ProxyCreateFixedListAndAABBJob& P0)
  System.Void __Gen_Wrap_513(BeyondDynamicBone.VirtualMesh.Proxy_CalcTriangleNormalJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_514(BeyondDynamicBone.VirtualMesh.Proxy_CalcTriangleTangentJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_515(BeyondDynamicBone.VirtualMesh.Proxy_CreateVertexToTrianglesJob& P0)
  System.Void __Gen_Wrap_516(BeyondDynamicBone.VirtualMesh.Proxy_OrganizeVertexToTrianglsJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_517(BeyondDynamicBone.VirtualMesh.Proxy_CalcVertexNormalTangentFromTriangleJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_518(BeyondDynamicBone.VirtualMesh.Proxy_CalcVertexToTransformJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_519(BeyondDynamicBone.VirtualMesh.Proxy_CalcEdgeToTriangleJob& P0)
  System.Void __Gen_Wrap_520(BeyondDynamicBone.VirtualMesh.Proxy_CalcVertexBindPoseJob2& P0, System.Int32 P1)
  System.Void __Gen_Wrap_521(BeyondDynamicBone.VirtualMesh.Proxy_CalcVertexToVertexFromTriangleJob& P0)
  System.Void __Gen_Wrap_522(BeyondDynamicBone.VirtualMesh.Proxy_CalcVertexToVertexFromLineJob& P0)
  System.Void __Gen_Wrap_523(BeyondDynamicBone.VirtualMesh.Proxy_CreateEdgeFlagJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_524(BeyondDynamicBone.VirtualMesh.Proxy_CalcCustomSkinningWeightsJobV2& P0, System.Int32 P1)
  System.Void __Gen_Wrap_525(BeyondDynamicBone.VirtualMesh.Proxy_ApplySelectionJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_526(BeyondDynamicBone.VirtualMesh.Proxy_BoneClothApplayTransformFlagJob& P0, System.Int32 P1)
  System.Int32 __Gen_Wrap_527(BeyondDynamicBone.VirtualMesh.BaseLineWork& P0, BeyondDynamicBone.VirtualMesh.BaseLineWork P1)
  System.Void __Gen_Wrap_528(BeyondDynamicBone.VirtualMesh.BaseLine_Mesh_CreateParentJob2& P0)
  System.Void __Gen_Wrap_529(BeyondDynamicBone.VirtualMesh.BaseLine_Mesh_CareteFixedListJob& P0)
  System.Void __Gen_Wrap_530(BeyondDynamicBone.VirtualMesh.BaseLine_Bone_CreateBoneChildInfoJob& P0)
  System.Void __Gen_Wrap_531(BeyondDynamicBone.VirtualMesh.BaseLine_CalcLocalPositionRotationJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_532(BeyondDynamicBone.VirtualMesh.BaseLine_CalcMaxBaseLineLengthJob& P0)
  System.Void __Gen_Wrap_533(BeyondDynamicBone.VirtualMesh.Reduction_InitVertexToVertexJob2& P0)
  System.Void __Gen_Wrap_534(BeyondDynamicBone.VirtualMesh.Organize_RemapVertexJob& P0)
  System.Void __Gen_Wrap_535(BeyondDynamicBone.VirtualMesh.Organize_CollectUseSkinBoneJob& P0)
  System.Void __Gen_Wrap_536(BeyondDynamicBone.VirtualMesh.Organize_CopyVertexJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_537(BeyondDynamicBone.VirtualMesh.Organize_RemapBoneWeightJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_538(BeyondDynamicBone.VirtualMesh.Organize_RemapLinkPointArrayJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_539(BeyondDynamicBone.VirtualMesh.Organize_CreateLineTriangleJob& P0)
  System.Void __Gen_Wrap_540(BeyondDynamicBone.VirtualMesh.Organize_CreateLineTriangleJob2& P0)
  System.Void __Gen_Wrap_541(BeyondDynamicBone.VirtualMesh.Organize_CreateNewTriangleJob3& P0)
  System.Void __Gen_Wrap_542(BeyondDynamicBone.VirtualMesh.Work_AverageTriangleDistanceJob& P0)
  System.Void __Gen_Wrap_543(BeyondDynamicBone.VirtualMesh.Work_AverageLineDistanceJob& P0)
  System.Void __Gen_Wrap_544(BeyondDynamicBone.VirtualMesh.Work_AddVertexIndexGirdMapJob& P0)
  System.Void __Gen_Wrap_545(BeyondDynamicBone.VirtualMesh.Work_IntersectTriangleJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_546(BeyondDynamicBone.VirtualMesh.Work_IntersectEdgeJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_547(BeyondDynamicBone.VirtualMesh.Work_IntersectPointJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_548(BeyondDynamicBone.VirtualMesh.Work_IntersetcSortJob& P0)
  System.Boolean __Gen_Wrap_549(BeyondDynamicBone.VertexAttribute& P0, System.Object P1)
  System.Int32 __Gen_Wrap_550(BeyondDynamicBone.VertexAttribute& P0)
  System.String __Gen_Wrap_551(BeyondDynamicBone.VirtualMeshBoneWeight& P0)
  System.Int32 __Gen_Wrap_552(BeyondDynamicBone.VirtualMeshRaycastHit& P0, BeyondDynamicBone.VirtualMeshRaycastHit P1)
  System.Boolean __Gen_Wrap_553(BeyondDynamicBone.VirtualMeshRaycastHit& P0)
  System.String __Gen_Wrap_554(BeyondDynamicBone.VirtualMeshRaycastHit& P0)
  BeyondDynamicBone.VirtualMeshTransform __Gen_Wrap_555(BeyondDynamicBone.VirtualMeshTransform& P0)
  BeyondDynamicBone.VirtualMeshTransform __Gen_Wrap_556()
  System.Int32 __Gen_Wrap_557(BeyondDynamicBone.VirtualMeshTransform& P0)
  System.Void __Gen_Wrap_558(BeyondDynamicBone.VirtualMeshTransform& P0, System.Object P1)
  BeyondDynamicBone.VirtualMeshTransform __Gen_Wrap_559(BeyondDynamicBone.VirtualMeshTransform& P0, BeyondDynamicBone.VirtualMeshTransform& P1)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x2000277
EXTENDS: AnonymousStorey
FIELDS:
  private           System.Int32                    methodId_0  // 0x40
  private           System.Int32                    methodId_1  // 0x44
METHODS:
  System.Void MoveNext()
  System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine P0)
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAwaitUnsafeOnCompleteMethod()
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000278
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine)
  IFix.ILFixDynamicMethodWrapper GetPatch(System.Int32 id)
  System.Boolean IsPatched(System.Int32 id)
  System.Delegate CreateDelegate(System.Type type, System.Int32 id, System.Object anon)
  System.Object CreateWrapper(System.Int32 id)
  System.Object InitWrapperArray(System.Int32 len)
  IFix.Core.AnonymousStorey CreateBridge(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] slots, IFix.Core.VirtualMachine virtualMachine)
END_CLASS

CLASS: IFix.IDMAP0
TYPE:  struct
TOKEN: 0x2000279
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-InitAnimationProperty0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-IsPlaying0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-IsState0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ReductionSettings-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CustomSkinningSettings-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-NormalAlignmentSettings-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CheckSliderSerializeData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CullingSettings-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CurveSerializeData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InertiaConstraint-SerializeData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TetherConstraint-SerializeData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DistanceConstraint-SerializeData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-SerializeData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AngleConstraint-RestorationSerializeData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AngleConstraint-LimitSerializeData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MotionConstraint-SerializeData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SerializeData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindSettings-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData2-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-DataUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-SetParameterChange0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-OnDidApplyAnimationProperties0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-SetRelativeTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData-IsBoneSpring0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SerializeData-GetSyncPartner0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-get_SyncPartnerCloth0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-Reset0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-OnValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-SetResult0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-SetSuccess0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-Develop-LogError0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-GetSerializeData20  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-SetState0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-SetError0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-SetWarning0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-GenerateStatusCheck0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-IsError0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-IsWarning0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-Merge0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildSerializeData-UsePreBuild0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildSerializeData-GetSharePreBuildData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-IsSuccess0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-IsFaild0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SharePreBuildData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-UniquePreBuildData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildSerializeData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DataUtility-ConvertAnimationCurve0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CurveSerializeData-ConvertFloatArray0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CullingSettings-CullingParams-Convert0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CheckSliderSerializeData-GetValue0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InertiaConstraint-InertiaConstraintParams-Convert0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TetherConstraint-TetherConstraintParams-Convert0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DistanceConstraint-DistanceConstraintParams-Convert0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingConstraintParams-Convert0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AngleConstraint-AngleConstraintParams-Convert0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MotionConstraint-MotionConstraintParams-Convert0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-ColliderCollisionConstraintParams-Convert0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SelfCollisionConstraintParams-Convert0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindParams-Convert0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SpringConstraint-SpringConstraintParams-Convert0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData-GetClothParameters0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-SetProcess0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-ShareDeserialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-ShareDeserialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-NativeMultiHashMapExtensions-MC2Deserialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ShareDeserialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildManager-ShareDeserializationData-Deserialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildManager-RegisterPreBuildData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-AddReferenceCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderManager-AddRenderer0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-AddRenderer0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderManager-GetRendererData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-CreateBoneRenderSetupData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-AddMonitoringProcess0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-Init0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-RemoveMonitoringProcess0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-Awake0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-CompleteMasterJob0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-ForceCompleteAllJob0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-GetTeamDataRef0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-TeamData-get_IsEnable0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-EnableTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-EnableTeamCollider0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-EnableTransform1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-IsCameraCullingInvisible0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-IsCameraCullingKeep0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-IsDistanceCullingInvisible0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-SetMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-SwapOriginalMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-IsFaild0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-get_HasTangent0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-GetBoneWeightsRun0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-ResetCustomMeshWorkData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-SwapCustomMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdateUse0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-StartUse0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderManager-StartUse0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-EndUse0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderManager-EndUse0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-UpdateUse0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-StartUse0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-EndUse0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildManager-GetPreBuildData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-AddComponentTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-AddTeamAnimatorData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-AddTeam0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-AddCloth0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshContainer-GetTransformCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-GetTransformFromIndex0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshContainer-GetTransformFromIndex0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-AddAnimatorTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-AddTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-get_EdgeCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-get_BaseLineCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-RegisterProxyMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-RegisterProxyMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-AddTransform1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-IsReverseDirection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-GetSize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-Register0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-IsEnable0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-get_IsEnable0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-MarkAnimatorTransformDirty0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-SetTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-AddColliderInternal0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-InitColliders0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-Register0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DistanceConstraint-ConstraintData-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DistanceConstraint-Register0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-ConstraintData-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-Register0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InertiaConstraint-Register0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-ContainsTeamData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-GetParametersRef0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-InitPrimitive0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DataChunk-Clear0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-UpdateTeam0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-Register0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-RegisterConstraint0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-GetTeamMappingRef0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-GetCenterTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshContainer-GetCenterTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-AddTransform2  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-RegisterMappingMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-Clear0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshContainer-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-IsNormal0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-GetResultString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-PreBuildDataConstruction0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-ToNativeMultiHashMap0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MathUtility-GetUnuseTriangleIndex0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DistanceConstraint-CreateData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MathUtility-GetRestTriangleVertex0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-InitDihedralAngle0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DataUtility-PackInt40  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DataUtility-PackInt41  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-InitVolume0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-CreateData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InertiaConstraint-CenterData-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InertiaConstraint-CreateData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-AddTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-SetTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-get_Name0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-AddTransformRange0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-SerialNumberRun0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-FillRun0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ImportMeshType0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ImportMeshSkinning0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-GetParentTransformIndex0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DataUtility-PackInt30  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ImportBoneType0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-CalcAABBRun0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-CalcUVWithSphereMappingRun0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-CalcAverageAndMaxVertexDistanceRun0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-IsNone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ImportFrom0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ImportFrom1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-TransformPositionRun0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-GenerateSelectionDataFromVertexAttributeData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-Merge0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-GenerateSelectionDataFromPaintMap0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AABB-get_MaxSideLength0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ReductionSettings-GetMaxConnectionDistance0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-CalcSelectionMergin0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-GetPositionNativeArray0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-GetAttributeNativeArray0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-TransformPositionRun1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-CreateGridMapRun0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-SelectionMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-CompareSpace0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-CenterTransformTo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-AddTransform1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-AddMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-Fill0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-GetTransformIndexFromId0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-FillRun1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-InitReductionWorkData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SameDistanceReduction-UpdateJoinAndLink0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SameDistanceReduction-UpdateReductionResultJob0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SameDistanceReduction-Reduction0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-StepInitialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-InitStep0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-PreReductionStep0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-CustomReductionStep0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-SortJoinEdge0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-DetermineJoinEdge0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-RunJoinEdge0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-UpdateJoinAndLink0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-PostReductionStep0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-ReductionStep0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-IsEndStep0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-NextStep0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-UpdateReductionResultJob0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-Reduction0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-OrganizationInit0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-OrganizationCreateRemapData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-OrganizationCreateBasicData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-OrganizationCreateLineTriangle0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Organization0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-OrganizeReductionTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-OrganizeStoreVirtualMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-SetCancel0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Reduction0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-RemoveDuplicateTriangles0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Optimization0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ApplySelectionAttribute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformRecord-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-SetCustomSkinningBones0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-FillRun2  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-CalcTwoTriangleAngle0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-CheckTwoTriangleOpen0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-OptimizeTriangleDirection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ProxyCreateFixedListAndAABB0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-CreateTransformBaseLine0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-CreateMeshBaseLine0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AABB-get_Center0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ProxyNormalAdjustment0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-CreateBaseLinePose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-CreateVertexRootAndDepth0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-CreateCustomSkinning0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ConvertProxyMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-CreateVertexIndexGridMapRun0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Mapping0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-IncrementSuspendCounter0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-GeneratePaintMapDataList0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-Develop-LogWarning0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-DecrementSuspendCounter0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DistanceConstraint-Exit0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-Exit0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InertiaConstraint-Exit0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-Exit0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-ExitProxyMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-RemoveTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-ExitMappingMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-ExitProxyMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-Exit0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-Exit0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-RemoveSyncParent0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-RemoveComponentTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-ClearTeamAnimatorData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-RemoveTeam0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-RemoveCloth0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-RemoveReferenceCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderManager-RemoveRenderer0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildManager-UnregisterPreBuildData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-DisposeInternal0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-RuntimeBuildAsync0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-StartRuntimeBuild0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-AutoBuild0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-Start0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-GetMagicaHashCode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-DisableAutoBuild0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-SetCodeParamaterDirty0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-SetClothSimulateWeight0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-SetCodeParamaterDirtyIgnorePlaying0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-SetClothSimulateWeightIgnorePlaying0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-SetClothStablizationTimeAfterResetIgnorePlaying0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-SetAnimationPoseRatio0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-GenerateInitialization0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-IsUserEdit0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-GenerateBoneClothSelection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-BuildAndRun0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-GetUsedTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-GetUsedTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformRecord-GetUsedTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CustomSkinningSettings-GetUsedTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-NormalAlignmentSettings-GetUsedTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-GetUsedTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData-GetUsedTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-UniqueSerializationData-GetUsedTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-UniqueSerializationData-GetUsedTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-UniqueSerializationData-GetUsedTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-UniquePreBuildData-GetUsedTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildSerializeData-GetUsedTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData2-GetUsedTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-GetUsedTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformRecord-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CustomSkinningSettings-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-NormalAlignmentSettings-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-UniqueSerializationData-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-UniqueSerializationData-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-UniqueSerializationData-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-UniquePreBuildData-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildSerializeData-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData2-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-SetTimeScale0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-GetTimeScale0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-UpdateRendererUse0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-ResetCloth0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-SoftResetCloth0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-GetCenterDataRef0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-GetCenterPosition0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-AddForce0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-SetSkipWriting0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCloth-SetSkipWriting0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CheckSliderSerializeData-SetValue0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CheckSliderSerializeData-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothBehaviour-GetMagicaHashCode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothBehaviour-OnDrawGizmos0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-GetColliderIndex0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-UpdateCullingAnimatorAndRenderers0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-GetStateFlag0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-IsRunning0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-IsLodCulled0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-IsSkipWriting0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-IsUpdateTangent0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-get_HasProxyMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-get_Name0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-GetSuspendCounter0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-GetRenderMeshInfo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-SyncParameters0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-GetClothUpdateMode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothProcess-GenerateSelectionJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData-GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData-ExportJson0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData-TempBuffer-Pop0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData-ImportJson0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ReductionSettings-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CustomSkinningSettings-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-NormalAlignmentSettings-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CullingSettings-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CurveSerializeData-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InertiaConstraint-SerializeData-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TetherConstraint-SerializeData-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DistanceConstraint-SerializeData-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-SerializeData-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AngleConstraint-RestorationSerializeData-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AngleConstraint-LimitSerializeData-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MotionConstraint-SerializeData-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SerializeData-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindSettings-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData-Import0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData-Import1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData-TempBuffer-Push0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData2-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothSerializeData2-GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCapsuleCollider-GetColliderType0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-SetSize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCapsuleCollider-SetSize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCapsuleCollider-GetSize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCapsuleCollider-GetLocalDir0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCapsuleCollider-GetLocalUp0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCapsuleCollider-IsReverseDirection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneCapsuleCollider-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBonePlaneCollider-GetColliderType0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBonePlaneCollider-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneSphereCollider-GetColliderType0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneSphereCollider-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneSphereCollider-SetSize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-SetSizeX0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-SetSizeY0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-SetSizeZ0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-GetScale0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-GetClothProcess0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-UpdateParameters0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-UpdateParameters0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-Start0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-OnValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-EnableCollider0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-CopyTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-RemoveCollider0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderComponent-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AngleConstraint-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AngleConstraint-WorkBufferUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AngleConstraint-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AngleConstraint-SolverConstraint0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AngleConstraint-AngleConstraintJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MathUtility-ClampAngle0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MathUtility-FromToRotation0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AngleConstraint-AngleConstraintJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AngleConstraint-AngleConstraintJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AngleConstraint-AngleConstraintJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-WorkBufferUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-SolverConstraint0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-Initialize$PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintKernel_000000DB$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-Initialize$PointColliderCollisionConstraintJobKernels_PointColliderCollisionConstraintRangeKernel_000000DC$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-Initialize$EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintKernel_000000E0$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-Initialize$EdgeColliderCollisionConstraintJobKernels_EdgeColliderCollisionConstraintRangeKernel_000000E1$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-Initialize$SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearKernel_000000E5$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-Initialize$SolveEdgeBufferAndClearJobKernels_SolveEdgeBufferAndClearRangeKernel_000000E6$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJobKernels-PointSphereColliderDetection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJobKernels-PointPlaneColliderDetction0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJobKernels-PointCapsuleColliderDetection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJobKernels-EdgeSphereColliderDetection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJobKernels-EdgeCapsuleColliderDetection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJobKernels-EdgePlaneColliderDetection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-SerializeData-GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-PointSphereColliderDetection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-PointCapsuleColliderDetection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-PointPlaneColliderDetction0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-PointColliderCollisionConstraintJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-EdgeSphereColliderDetection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-EdgeCapsuleColliderDetection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-EdgePlaneColliderDetection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-EdgeColliderCollisionConstraintJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-ReadAverageFloat30  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-ReadFloat0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-ReadFloat30  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderCollisionConstraint-SolveEdgeBufferAndClearJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DistanceConstraint-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DistanceConstraint-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DistanceConstraint-SolverConstraint0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DistanceConstraint-DistanceConstraintJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InertiaConstraint-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InertiaConstraint-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MotionConstraint-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MotionConstraint-SolverConstraint0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MotionConstraint-MotionConstraintJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MotionConstraint-MotionConstraintJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MotionConstraint-MotionConstraintJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MotionConstraint-MotionConstraintJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-HasPrimitive0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-WorkBufferUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-BinarySearchSortAndlSweep0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SolverBroadPhase0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-UpdateBroadPhase0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-SolveAggregateBufferAndClear0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-SolveAggregateBufferAndClear1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SolverRuntimeSelfCollision0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-Fill0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SolveIntersect0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SolverConstraint0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-Initialize$IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveKernel_00000145$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-Initialize$IntersectUpdatePrimitiveJobKernels_IntersectUpdatePrimitiveRangeKernel_00000146$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-Initialize$UpdatePrimitiveJobKernels_UpdatePrimitiveKernel_00000147$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-Initialize$UpdatePrimitiveJobKernels_UpdatePrimitiveRangeKernel_00000148$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-Initialize$ClearBufferJobKernels_ClearBufferKernel_00000149$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-Initialize$SortJobKernels_SortKernel_0000014A$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-Initialize$SortJobKernels_SortRangeKernel_0000014B$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameKernel_0000017E$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverPointTriangleCrossFrameJobKernels_SolverPointTriangleCrossFrameRangeKernel_0000017F$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameKernel_00000180$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-Initialize$SolverEdgeEdgeCrossFrameJobKernels_SolverEdgeEdgeCrossFrameRangeKernel_00000181$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SortData-CompareTo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeContact-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-PointTriangleContact-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-InitPrimitiveJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-ClearBufferJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-UpdatePrimitiveJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SortJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-TeamData-get_IsProcess0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SortJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SortJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SortJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-BroadPointTriangle0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-SweepTest0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-PointTriangleBroadPhaseJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-BroadEdgeEdge0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-SweepTest0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeBroadPhaseJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-EdgeEdgeToListJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-PointTriangleToListJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-UpdateEdgeEdgeBroadPhaseJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-UpdatePointTriangleBroadPhaseJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-IntersectUpdatePrimitiveJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-IntersectTest0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-SweepTest0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-IntersectEdgeTriangleJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-UpdateEdgeEdgeBroadPhaseCrossFrameJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-UpdateEdgeEdgeBroadPhaseCrossFrameJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-UpdatePointTriangleBroadPhaseCrossFrameJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-UpdatePointTriangleBroadPhaseCrossFrameJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeCrossFrameJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeCrossFrameJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SolverEdgeEdgeCrossFrameJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleCrossFrameJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleCrossFrameJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelfCollisionConstraint-SolverPointTriangleCrossFrameJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SpringConstraint-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SpringConstraint-SolverConstraint0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SpringConstraint-SerializeData-DataValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SpringConstraint-SerializeData-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TetherConstraint-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TetherConstraint-SolverConstraint0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TetherConstraint-TethreConstraintJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TetherConstraint-TethreConstraintJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TetherConstraint-TethreConstraintJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TetherConstraint-TethreConstraintJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-SolverConstraint0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-Initialize$TriangleBendingJobKernels_TriangleBendingKernel_000001AA$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-Initialize$TriangleBendingJobKernels_TriangleBendingRangeKernel_000001AB$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-Initialize$SolveAggregateBufferJobKernels_SolveAggregateBufferKernel_000001AE$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-Initialize$SolveAggregateBufferJobKernels_SolveAggregateBufferRangeKernel_000001AF$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJobKernels-Volume0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJobKernels-DihedralAngle0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-Volume0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-DihedralAngle0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-TriangleBendingJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TriangleBendingConstraint-SolveAggregateBufferJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CullingSettings-GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CurveSerializeData-SetValue0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CurveSerializeData-SetValue1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CurveSerializeData-SetValue2  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CurveSerializeData-Evaluate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CustomSkinningSettings-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-CustomSkinningSettings-GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-GizmoSerializeData-IsAlways0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-NormalAlignmentSettings-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-NormalAlignmentSettings-GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-Compare0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-AddRange0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-GetPositionNativeArray1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-ConvertFrom0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-TransformPositionJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-CreateGridMapJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SelectionData-ConvertSelectionJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindManager-AddWind0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneWindZone-Awake0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneWindZone-Start0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindManager-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneWindZone-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneWindZone-OnDisable0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindManager-RemoveWind0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneWindZone-OnDestroy0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneWindZone-IsDirection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneWindZone-IsRadial0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneWindZone-IsAddition0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneWindZone-GetWindDirection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-BeyondBoneWindZone-SetWindDirection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindParams-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindSettings-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-ClearVisibleDict0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-CheckRendererVisible0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-CheckVisible0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-CheckLODVisible0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-CameraCullingPostProcess0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-RestoreTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-OnEarlyClothUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-UpdateTeamAnimatorData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-OnAfterUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeManager-FrameUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-Expand0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-AddCollider0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-UpdateColliders0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdateSkipWriting0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-ReadComponentTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeManager-GetDeltaTime0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeManager-GetFixedDeltaTime0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeManager-GetUnscaledDeltaTime0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-AlwaysTeamUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindManager-AlwaysWindUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-WorkBufferUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-ClearMasterJob0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-UpdateBuffer0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-ReadAnimatorBufferData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-CameraCullingPreProcess0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-ReadTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-WriteDoubleBufferTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-ValidPosition0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-PreProxyMeshUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWind0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-PreSimulationUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-PreSimulationUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-SimulationStepTeamUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-CreateUpdateColliderList0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-StartSimulationStep0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-EndSimulationStep0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-SimulationStepUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-CalcDisplayPosition0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-PostProxyMeshUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-PostMappingMeshUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdatePositionNormal0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdateBoneWeight0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-WriteAnimatorBufferData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-CopyDoubleBuffer0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-WriteTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-PostSimulationUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-PostTeamUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-ClothUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-OnAfterLateUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-OnBeforeLateUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-OnApplicationQuit0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-EnterdEditMode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothManager-InformationLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildManager-ShareDeserializationData-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildManager-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildManager-EnterdEditMode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildManager-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildManager-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildManager-InformationLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildManager-UnloadUnusedData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildManager-ShareDeserializationData-GetProxyMeshContainer0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildManager-ShareDeserializationData-GetRenderMeshContainer0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DoAllInOneJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-EnterdEditMode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-InformationLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-Initialize$WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataKernel_0000025C$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-Initialize$WriteAnimatorBufferDataJobKernels_WriteAnimatorBufferDataRangeKernel_0000025D$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-ReadAnimatorBufferDataJob-_Do0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-ReadAnimatorBufferDataJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-WriteAnimatorBufferDataJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-WriteAnimatorBufferDataJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-CopyDoubleBufferJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-EnableTransformJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-RestoreTransformJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-ReadTransformJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-ValidTransformJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-WriteTransformJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DynamicBoneTransformManager-ReadComponentTransformJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-MonitoringProcess0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-MonitoringProcessUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-EnterdEditMode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-SetSkipWriting0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamWindInfo-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-InformationLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-Initialize$PostTeamUpdateJobKernels_PostTeamUpdateKernel_00000298$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-Initialize$PostTeamUpdateJobKernels_PostTeamUpdateRangeKernel_00000299$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-MappingData-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-AlwaysTeamUpdatePreJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-AlwaysTeamUpdatePostJob-DistanceCullingUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-AlwaysTeamUpdatePostJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MathUtility-ShiftPosition0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindManager-WindData-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindManager-WindData-IsEnable0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindManager-WindData-IsAddition0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamWindInfo-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamWindData-IndexOf0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamWindData-AddOrReplaceWindZone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamWindData-RemoveWindZone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-Wind0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-CalcCenterAndInertiaAndWindJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-UpdateWindTime0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-UpdateWind0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-SimulationStepTeamUpdateJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-PostTeamUpdateJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-PostTeamUpdateJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-PostTeamUpdateJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamManager-PostTeamUpdateJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-EnterdEditMode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-InformationLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListKernel_000002E6$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$CreatePostProxyMeshUpdateListJobKernels_CreatePostProxyMeshUpdateListRangeKernel_000002E7$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$CalcLineNormalTangentJobKernels_CalcLineNormalTangentKernel_000002E8$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$CalcLineNormalTangentJobKernels_CalcLineNormalTangentRangeKernel_000002E9$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformDataJobKernels_WriteTransformDataKernel_000002EA$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformDataJobKernels_WriteTransformDataRangeKernel_000002EB$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformLocalDataJobKernels_WriteTransformLocalDataKernel_000002EC$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$WriteTransformLocalDataJobKernels_WriteTransformLocalDataRangeKernel_000002ED$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$CalcProxySkinningJobKernels_CalcProxySkinningKernel_000002EE$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$CalcProxySkinningJobKernels_CalcProxySkinningRangeKernel_000002EF$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixKernel_000002F0$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$CalcMeshConvertMatrixJobKernels_CalcMeshConvertMatrixRangeKernel_000002F1$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentKernel_000002F2$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$CalcTriangleNormalTangentJobKernels_CalcTriangleNormalTangentRangeKernel_000002F3$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleKernel_000002F4$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$CalcVertexNormalTangentFromTriangleJobKernels_CalcVertexNormalTangentFromTriangleRangeKernel_000002F5$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-Initialize$ClearProxyMeshUpdateBufferJobKernels_ClearProxyMeshUpdateBufferKernel_000002F6$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-ClearProxyMeshUpdateBufferJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-ClearProxyMeshUpdateBufferJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-NativeReferenceExtensions-MC2InterlockedStartIndex0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CreateProxyMeshUpdateVertexList-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshBoneWeight-get_Count0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcProxyMeshSkinningJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CreatePostProxyMeshUpdateListJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcLineNormalTangentJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MathUtility-TriangleTangent0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcTriangleNormalTangentJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcVertexNormalTangentFromTriangleJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-WriteTransformDataJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-WriteTransformLocalDataJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcMeshConvertMatrixJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshManager-CalcProxySkinningJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-CheckRegist0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PlayerLoopUtils-AddPlayerLoop0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-SetCustomGameLoop0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-InitCustomGameLoop0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-SetUseCrossFrameJob0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-SetGlobalTimeScale0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-GetGlobalTimeScale0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-SetSimulationFrequency0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-SetAOVMode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-DoAOVUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-DoAOVAfterAnimatorUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-GetSimulationFrequency0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-SetMaxSimulationCountPerFrame0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-GetMaxSimulationCountPerFrame0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-SetUpdateLocation0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-GetUpdateLocation0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-UnloadUnusedData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaManager-SetInitializationLocation0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaSettings-Refresh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaSettings-Awake0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaSettings-Start0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaSettings-Update0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MagicaSettings-OnValidate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-WriteMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdatePositionNormalJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdatePositionNormalJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdatePositionNormalJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdatePositionNormalJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdatePositionNormalTangentJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderData-UpdateBoneWeightJob2-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderManager-PreRenderingUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderManager-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderManager-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderManager-EnterdEditMode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderManager-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderManager-InformationLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-IsSuccess0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-GetRendeerLocalToWorldMatrix0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-ReadTransformInformation0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-GetRendeerTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-GetRenderTransformId0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-GetSkinRootTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-GetSkinRootTransformId0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-ShareSerialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-UniqueSerialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-VertexWeight5BoneCheckJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-ReadTransformJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-RenderSetupData-GetBoneWeightJos-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-EnterdEditMode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-InformationLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-Initialize$CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListKernel_000003D3$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-Initialize$CreateUpdatecolliderListJobKernels_CreateUpdatecolliderListRangeKernel_000003D4$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-Initialize$PostSimulationUpdateJobKernels_PostSimulationUpdateKernel_000003D7$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-Initialize$PostSimulationUpdateJobKernels_PostSimulationUpdateRangeKernel_000003D8$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-PreSimulationUpdateJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-CreateUpdatecolliderListJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-StartSimulationStepJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-StartSimulationStepJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-StartSimulationStepJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-StartSimulationStepJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-EndSimulationStepJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-EndSimulationStepJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-EndSimulationStepJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-EndSimulationStepJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ColliderManager-PostSimulationUpdateJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-EnterdEditMode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-FeedbackTempFloat3Buffer0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-FeedbackTempFloat3Buffer1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-FeedbackTempFloat3Buffer2  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-InformationLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_StartSimulationStepKernel_00000405$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_StartSimulationStepRangeKernel_00000406$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_Spring_00000407$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_Wind_00000408$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-Initialize$StartSimulationStepJobKernels_WindForceBlend_00000409$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-Initialize$UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureKernel_0000040A$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-Initialize$UpdateStepBasicPotureJobKernels_UpdateStepBasicPotureRangeKernel_0000040B$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-Initialize$EndSimulationStepJobKernels_EndSimulationStepKernel_0000040C$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-Initialize$EndSimulationStepJobKernels_EndSimulationStepRangeKernel_0000040D$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-Initialize$CalcDisplayPositionJobKernels_CalcDisplayPositionKernel_0000040E$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-Initialize$CalcDisplayPositionJobKernels_CalcDisplayPositionRangeKernel_0000040F$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-Initialize$ClearStepCounterKernels_ClearStepCounterKernel_00000410$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-PreSimulationUpdateJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-ClearStepCounter-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-ClearStepCounter-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-CreateUpdateParticleList-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-StartSimulationStepJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-StartSimulationStepJob-WindForceBlend0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Wind0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Spring0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-StartSimulationStepJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-StartSimulationStepJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-UpdateStepBasicPotureJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-EndSimulationStepJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-EndSimulationStepJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-EndSimulationStepJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-EndSimulationStepJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-CalcDisplayPositionJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-FeedbackTempPosJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimulationManager-FeedbackTempPosJob2-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeManager-AfterFixedUpdate0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeManager-AfterRenderring0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeManager-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeManager-EnterdEditMode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeManager-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeManager-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeManager-InformationLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindManager-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindManager-EnterdEditMode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindManager-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindManager-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-WindManager-InformationLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamWindInfo-DebugLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TeamWindData-ClearZoneList0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-Init0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-AddTransform2  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-AddTransformRange1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-AddTransformRange2  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-RemoveTransformIndex0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-ReplaceTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-UpdateWorkData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-RestoreTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-ReadTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-ReadTransformRun0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-GetTransformIndexFormId0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-GetTransformIdFromIndex0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-GetParentIdFromIndex0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-GetLocalToWorldMatrix0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-GetWorldToLocalMatrix0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-ShareSerialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-UniqueSerialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-RestoreTransformJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformData-ReadTransformJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TransformRecord-InverseTransformDirection0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SharePreBuildData-CheckBuildId0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildScriptableObject-GetPreBuildData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildScriptableObject-HasPreBuildData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildScriptableObject-AddPreBuildData0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildScriptableObject-Warmup0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-PreBuildSerializeData-GenerateBuildID0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SharePreBuildData-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ReductionSettings-GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ReductionSettings-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ReductionWorkData-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SameDistanceReduction-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SameDistanceReduction-InitGridJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SameDistanceReduction-SearchJoinJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshBoneWeight-AddWeight0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshBoneWeight-AddWeight1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SameDistanceReduction-JoinJob2-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SameDistanceReduction-UpdateJoinIndexJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SameDistanceReduction-UpdateLinkIndexJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshBoneWeight-AdjustWeight0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SameDistanceReduction-FinalMergeVertexJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ShapeDistanceReduction-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ShapeDistanceReduction-StepInitialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ShapeDistanceReduction-CustomReductionStep0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-CheckJoin20  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ShapeDistanceReduction-SearchJoinEdgeJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimpleDistanceReduction-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimpleDistanceReduction-StepInitialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimpleDistanceReduction-CustomReductionStep0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimpleDistanceReduction-InitGridJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-SimpleDistanceReduction-SearchJoinEdgeJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-CheckJoin0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-JoinEdge-Contains0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-JoinEdge-CompareTo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-DeterminJoinEdgeJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-JoinPairJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-UpdateJoinIndexJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-UpdateLinkIndexJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StepReductionBase-FinalMergeVertexJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothDebugSettings-CheckParticleDrawing0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothDebugSettings-CheckTriangleDrawing0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothDebugSettings-CheckRadiusDrawing0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothDebugSettings-GetPointSize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothDebugSettings-GetLineSize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothDebugSettings-GetInertiaCenterRadius0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothDebugSettings-GetCustomSkinningRadius0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothDebugSettings-IsReferOldPos0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DataUtility-PackInt31  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-Fill1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-Fill2  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-SerialNumber0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-ConvertHashSetToNativeList0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-ConvertHashSetKeyToNativeList0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-ConvertHashSetKeyToNativeList1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-CalcAABB0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-CalcAABB1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-CalcAABBRun1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-CalcAABBInternal0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-CalcUVWithSphereMapping0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-TransformPosition0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-TransformPosition1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-ClearReference0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-SerialNumberJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-CalcAABBJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-CalcAABBDeferJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-CalcUVJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-AddIntDataCopyJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-AddInt2DataCopyJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-AddInt3DataCopyJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-TransformPositionJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-TransformPositionJob2-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ClothJobUtility-ClearReferenceJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-SolveAggregateBufferAndClear2  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-Initialize$AggregateJobKernels_AggregateKernel_00000564$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-Initialize$AggregateJobKernels_AggregateRangeKernel_00000565$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJobKernels_AggregateWithVelocityKernel_00000566$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJobKernels_AggregateWithVelocityRangeKernel_00000567$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-Initialize$AggregateJob2Kernels_AggregateJob2Kernel_00000568$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-Initialize$AggregateJob2Kernels_AggregateJob2RangeKernel_00000569$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2Kernel_0000056A$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-Initialize$AggregateWithVelocityJob2Kernels_AggregateWithVelocityJob2RangeKernel_0000056B$BurstDirectCall0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateJob2-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateJob2-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateJob2-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateJob2-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-SetIndexCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateWithVelocityJob2-UnsafeDo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateWithVelocityCrossFrameJob2-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateWithVelocityCrossFrameJob2-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateCrossFrameJob2-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-InterlockUtility-AggregateCrossFrameJob2-Execute1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AABB-get_HalfExtents0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AABB-get_SurfaceArea0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-AABB-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MathUtility-ComputeVirtualParentWithoutLocal0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MathUtility-GetCommonEdgeFromTrianglePair0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MathUtility-GetTrianglePairIndices0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MathUtility-IntersectSegmentTriangle0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MathUtility-IntersectSegmentTriangle1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MathUtility-SqDistPointSegment0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-FTransform-Default0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MeshUtility-GetSharedMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MeshUtility-SetMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-MeshUtility-GetTransformCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-Develop-Log0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-Develop-DebugLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-Develop-DebugLogWarning0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-Develop-DebugLogError0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-Develop-Assert0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StaticStringBuilder-Clear0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StaticStringBuilder-Append0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StaticStringBuilder-AppendLine0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StaticStringBuilder-AppendLine1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StaticStringBuilder-AppendToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-StaticStringBuilder-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-DataChunk-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExBitFlag16-Clear0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExCostSortedList1-CompareTo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExCostSortedList1-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExCostSortedList4-Add0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExCostSortedList4-indexOf0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExCostSortedList4-RemoveItem0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExCostSortedList4-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExTransformAccessArray-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExTransformAccessArray-GetTransformAccessArray0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExTransformAccessArray-Add0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExTransformAccessArray-Remove0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExTransformAccessArray-Exist0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExTransformAccessArray-Exist1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExTransformAccessArray-GetIndex0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ExTransformAccessArray-Clear0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-IsResult0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-IsCancel0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-IsProcess0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-GetWarningString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-GetResultInformation0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-GetWarningInformation0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-ResultCode-DebugLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeSpan-Start0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeSpan-Finish0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeSpan-TotalSeconds0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeSpan-TotalMilliSeconds0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeSpan-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeSpan-DebugLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-TimeSpan-Log0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-UnityTimeSpan-Finish0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-UnityTimeSpan-TotalSeconds0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-UnityTimeSpan-TotalMilliSeconds0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-UnityTimeSpan-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-UnityTimeSpan-DebugLog0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-SetCenterTransform0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-SetSkinRoot0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-SetTransform1  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-CalcVertexWeights0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ShareSerialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-UniqueSerialize0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-IntersectRayMesh0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-get_NormalAdjustmentRotationCount0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-SetName0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Import_GenerateTangentJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Import_CalcSkinningJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Import_BoneWeightJob1-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Import_BoneWeightJob2-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Import_BoneVertexJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Select_PackVertexJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Select_GridJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Add_CalcBindPoseJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Add_CopyVerticesJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Mapping_DirectConnectionVertexDataJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Mapping_CalcDirectWeightJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Mapping_CalcConnectionVertexDataJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Mapping_CalcWeightJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Optimize_EdgeToTrianlgeJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ProxyNormalRadiationAdjustmentJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ProxyCreateFixedListAndAABBJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Proxy_CalcTriangleNormalJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Proxy_CalcTriangleTangentJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Proxy_CreateVertexToTrianglesJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Proxy_OrganizeVertexToTrianglsJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexNormalTangentFromTriangleJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexToTransformJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Proxy_CalcEdgeToTriangleJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexBindPoseJob2-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexToVertexFromTriangleJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Proxy_CalcVertexToVertexFromLineJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Proxy_CreateEdgeFlagJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Proxy_CalcCustomSkinningWeightsJobV2-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Proxy_ApplySelectionJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Proxy_BoneClothApplayTransformFlagJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-BaseLineWork-CompareTo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-BaseLine_Mesh_CreateParentJob2-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-BaseLine_Mesh_CareteFixedListJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-BaseLine_Bone_CreateBoneChildInfoJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-BaseLine_CalcLocalPositionRotationJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-BaseLine_CalcMaxBaseLineLengthJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Reduction_InitVertexToVertexJob2-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Organize_RemapVertexJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Organize_CollectUseSkinBoneJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Organize_CopyVertexJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Organize_RemapBoneWeightJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Organize_RemapLinkPointArrayJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Organize_CreateLineTriangleJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Organize_CreateLineTriangleJob2-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Organize_CreateNewTriangleJob3-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-ShareSerializationData-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Work_AverageTriangleDistanceJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Work_AverageLineDistanceJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Work_AddVertexIndexGirdMapJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Work_IntersectTriangleJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Work_IntersectEdgeJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Work_IntersectPointJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMesh-Work_IntersetcSortJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VertexAttribute-Equals0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VertexAttribute-GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshBoneWeight-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshRaycastHit-CompareTo0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshRaycastHit-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshRaycastHit-ToString0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshTransform-Clone0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshTransform-get_Origin0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshTransform-GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshTransform-Update0  // 0x0
  public    static  IFix.IDMAP0                     BeyondDynamicBone-VirtualMeshTransform-Transform0  // 0x0
METHODS:
END_CLASS

CLASS: Microsoft.CodeAnalysis.EmbeddedAttribute
TYPE:  class
TOKEN: 0x2000002
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: System.Runtime.CompilerServices.IsUnmanagedAttribute
TYPE:  class
TOKEN: 0x2000003
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

