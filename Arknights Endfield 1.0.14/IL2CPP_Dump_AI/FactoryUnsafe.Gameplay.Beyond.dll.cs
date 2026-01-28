// ========================================================
// Dumped by @desirepro
// Assembly: FactoryUnsafe.Gameplay.Beyond.dll
// Classes:  625
// Date:     Jan 27 2026 21:51:21
// ========================================================

# AI-FRIENDLY STRUCTURED DUMP
# Optimized for LLM parsing / code generation

CLASS: EntityCommandCallback
TYPE:  class
TOKEN: 0x200000C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.EntityCommandBufferData& buffer)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.EntityCommandBufferData& buffer, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.EntityCommandBufferData& buffer, System.IAsyncResult result)
END_CLASS

CLASS: VirtualEntityMap
TYPE:  struct
TOKEN: 0x200000D
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityvirtualEntity  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityrealEntity  // 0x18
METHODS:
END_CLASS

CLASS: VirtualEntityMap
TYPE:  struct
TOKEN: 0x2000013
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityvirtualEntity  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityrealEntity  // 0x18
METHODS:
END_CLASS

CLASS: EntityCommandBufferParallelWriter
TYPE:  struct
TOKEN: 0x2000014
FIELDS:
  public            System.Int64                    tempIdx  // 0x10
  public            Unity.Collections.NativeQueue.ParallelWriter<UnityEngine.HyperGryph.ECS.EntityCommandBufferData>buffersWriter  // 0x18
  public            Unity.Collections.NativeParallelHashMap.ParallelWriter<System.UInt64,UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.VirtualEntityMap>tempEntitiesWriter  // 0x30
METHODS:
END_CLASS

CLASS: EntityTransformData
TYPE:  struct
TOKEN: 0x2000019
FIELDS:
  public            System.UInt32                   next  // 0x10
  public            Beyond.Gameplay.Factory.LocalTransformlocalTrans  // 0x14
  public            System.Int32                    parentIndex  // 0x34
  public            System.Boolean                  dirty  // 0x38
METHODS:
END_CLASS

CLASS: Node
TYPE:  struct
TOKEN: 0x200001A
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformDatavalue  // 0x10
  public            System.UInt32                   next  // 0x10
METHODS:
END_CLASS

CLASS: Type
TYPE:  struct
TOKEN: 0x200001D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  UnityEngine.HyperGryph.ECS.EntityQueryBuilder.BuilderData.TypeINCLUDE  // 0x0
  public    static  UnityEngine.HyperGryph.ECS.EntityQueryBuilder.BuilderData.TypeEXCLUDE  // 0x0
METHODS:
END_CLASS

CLASS: BuilderData
TYPE:  struct
TOKEN: 0x200001C
FIELDS:
  private           Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.ComponentType>all  // 0x10
  private           Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.ComponentType>none  // 0x30
METHODS:
  UnityEngine.HyperGryph.ECS.ComponentMask ComponentMask(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.EntityQueryBuilder.BuilderData.Type type)
END_CLASS

CLASS: BlockRange
TYPE:  struct
TOKEN: 0x200001F
FIELDS:
  public            System.Int32                    beginGroupIdx  // 0x10
  public            System.Int32                    endGroupIdx  // 0x14
  public            System.Int32                    beginGroupElemBeginIdx  // 0x18
  public            System.Int32                    endGroupElemEndIdx  // 0x1C
METHODS:
END_CLASS

CLASS: QueryResultDefer
TYPE:  struct
TOKEN: 0x2000020
FIELDS:
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.GroupType>*groups  // 0x10
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange>*blockRanges  // 0x18
  public            System.Int32                    rangeCount  // 0x20
METHODS:
  System.Boolean get_valid()
  System.Void InitList(Unity.Collections.Allocator allocator, System.Int32 initialCapacity)
  System.Void ReleaseList()
  System.Void Reset()
  UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange& BlockRangeAt(System.Int32 index)
  UnityEngine.HyperGryph.ECS.GroupType& GroupAt(System.Int32 index)
  System.Int32* get_rangeCountPtr()
  System.Void Foreach(System.Func<UnityEngine.HyperGryph.ECS.GroupType,System.Boolean> callback)
  System.Int32 EntityCount()
  System.Void Dispose()
  System.Void Dispose(Unity.Jobs.JobHandle jobHandle, System.Boolean inCrossFrame)
  System.String ToString()
END_CLASS

CLASS: QueryResult
TYPE:  struct
TOKEN: 0x2000021
FIELDS:
  public            Unity.Collections.NativeList<UnityEngine.HyperGryph.ECS.GroupType>groups  // 0x10
  public            Unity.Collections.NativeList<UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange>blockRanges  // 0x20
METHODS:
  System.Int32 get_rangeCount()
  System.Boolean get_isEmpty()
  System.String ToString()
  System.Void Foreach(System.Func<UnityEngine.HyperGryph.ECS.GroupType,System.Boolean> callback)
  System.Int32 EntityCount()
  System.Void Dispose()
  System.Void Dispose(Unity.Jobs.JobHandle jobHandle, System.Boolean inCrossFrame)
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000031
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.AdditiveEffectRequestStack<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.AdditiveEffectRequestStack<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: ConveyorExt
TYPE:  struct
TOKEN: 0x2000034
FIELDS:
  public            System.Int32                    outCargoIndex  // 0x10
  public            System.Int32                    cargoBeginIndex  // 0x14
  public            System.Int32                    cargoEndIndex  // 0x18
METHODS:
  System.Void Reset()
END_CLASS

CLASS: Node
TYPE:  struct
TOKEN: 0x2000035
FIELDS:
  public            Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExtvalue  // 0x10
  public            System.UInt32                   next  // 0x10
METHODS:
END_CLASS

CLASS: Info
TYPE:  struct
TOKEN: 0x2000037
FIELDS:
  public            System.Byte                     protoType  // 0x10
  public            System.Boolean                  isCorner  // 0x11
  public            System.Single                   adjustHeight  // 0x14
  public            Unity.Mathematics.float3        position  // 0x18
  public            Unity.Mathematics.float3        rotation  // 0x24
  public            System.Single                   bend  // 0x30
  public            System.UInt32                   lightMode  // 0x34
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200003E
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.EntityData4<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.EntityData4<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000041
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.EntityData8<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.EntityData8<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000044
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.EntityData32<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.EntityData32<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000047
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.EntityData64<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.EntityData64<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200004A
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.EntityData128<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.EntityData128<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200004D
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.EntityData256<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.EntityData256<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000050
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.EntityData512<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.EntityData512<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000053
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.EntityData1024<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.EntityData1024<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000056
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.Float4Data6<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.Float4Data6<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000059
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.Float4Data16<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.Float4Data16<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200005C
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.IntData8<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.IntData8<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200005F
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.IntData32<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.IntData32<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: LogisticsExtData
TYPE:  struct
TOKEN: 0x2000062
FIELDS:
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000065
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.PortData16<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.PortData16<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000068
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.PortData32<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.PortData32<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200006B
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.PortData128<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.PortData128<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200006E
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.PortData256<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.PortData256<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: SharedExtData
TYPE:  struct
TOKEN: 0x2000071
FIELDS:
  public            System.UInt32                   next  // 0x10
  public            System.Int32                    pendingSlotId  // 0x14
  public            System.UInt32                   nodeId  // 0x18
  public            Beyond.Gameplay.Factory.ChapterTagFragmentchapter  // 0x1C
  public            Beyond.Gameplay.Factory.StaticMountInfoCollection<Beyond.Gameplay.Factory.StaticMountInfo>staticMountInfos  // 0x2C
  public            System.Boolean                  adjustMapValid  // 0x534
  public            System.Single                   adjustMapHeight  // 0x538
  public            System.Boolean                  bAdjustedMap  // 0x53C
  public            System.Boolean                  bAdjustedOnce  // 0x53D
  public            System.Boolean                  culled  // 0x53E
  public            System.Boolean                  buildingNameCulled  // 0x53F
  public            System.Boolean                  stateUICulled  // 0x540
  public            System.UInt32                   dirtyBitmask  // 0x544
  public            Beyond.Gameplay.Factory.Visibilityvisibility  // 0x548
  public            Beyond.Gameplay.Factory.VisibilityadditiveMatVisibility  // 0x560
  public            Beyond.Gameplay.Factory.AdditiveEffectFragmentadditiveEffect  // 0x578
  public            System.Boolean                  inMainRegion  // 0xD20
METHODS:
  System.Boolean get_visible()
  System.Boolean get_visibleAdditiveMat()
  System.Boolean IsDirty(Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlag f)
  System.Void SetDirty(Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlag f, System.Boolean d)
  System.Boolean IsPendingUnit()
END_CLASS

CLASS: DirtyFlag
TYPE:  struct
TOKEN: 0x2000072
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlagNONE  // 0x0
  public    static  Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlagALL  // 0x0
  public    static  Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlagSTATUS_CHANGE  // 0x0
  public    static  Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlagVAT_UPDATE  // 0x0
  public    static  Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlagUPDATE_STATUS_EFFECT  // 0x0
  public    static  Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlagCULL_STATUS_CHANGE  // 0x0
METHODS:
END_CLASS

CLASS: Node
TYPE:  struct
TOKEN: 0x2000073
FIELDS:
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtDatavalue  // 0x10
  public            System.UInt32                   next  // 0x10
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000076
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.StaticMountInfoCollection<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.StaticMountInfoCollection<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000079
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.UnitExtendConfig12<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.UnitExtendConfig12<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200007D
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.WireRendererInfoCollection<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.WireRendererInfoCollection<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Request
TYPE:  struct
TOKEN: 0x2000084
FIELDS:
  public            Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypetype  // 0x10
  public            System.Int16                    typeValue  // 0x10
  public            Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypelastType  // 0x12
  public            System.Int16                    lastTypeValue  // 0x12
METHODS:
END_CLASS

CLASS: AdditiveEffectType
TYPE:  struct
TOKEN: 0x2000085
FIELDS:
  public            System.Int16                    value__  // 0x10
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeNONE  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeSOLO_SELECT  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeBUILD_DISMISS  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeBLUEPRINT_BUILD  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeCUTOFF  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeREPAIR  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeHIGH_LIGHT  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeHINT  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeFIGURE  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeOVERLOAD  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeOVERLOAD_INVALID  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeBLUEPRINT  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypePRE_SELECT  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeCONTINUATION  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeSOCIAL_SHARING  // 0x0
  public    static  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypePOWER_INTERACTION  // 0x0
METHODS:
END_CLASS

CLASS: BuildEffectType
TYPE:  struct
TOKEN: 0x2000088
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.Factory.BuildDismissState.BuildEffectTypeDEFAULT  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildDismissState.BuildEffectTypeTYPE1  // 0x0
METHODS:
END_CLASS

CLASS: EffectType
TYPE:  struct
TOKEN: 0x2000093
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.Factory.BlueprintState.EffectTypeNONE  // 0x0
  public    static  Beyond.Gameplay.Factory.BlueprintState.EffectTypeTO_BE_BUILD  // 0x0
  public    static  Beyond.Gameplay.Factory.BlueprintState.EffectTypeTO_BE_BUILD_SELECT  // 0x0
  public    static  Beyond.Gameplay.Factory.BlueprintState.EffectTypeMOVING  // 0x0
  public    static  Beyond.Gameplay.Factory.BlueprintState.EffectTypeMOVING_INVALID  // 0x0
  public    static  Beyond.Gameplay.Factory.BlueprintState.EffectTypeTO_BUILD_INVALID  // 0x0
METHODS:
END_CLASS

CLASS: ItemUV
TYPE:  struct
TOKEN: 0x20000A9
FIELDS:
  public            System.Boolean                  isLiquid  // 0x10
  public            Unity.Mathematics.int4          itemAtlasRect  // 0x14
  public            Unity.Mathematics.int4          liquidAtlasRect  // 0x24
METHODS:
END_CLASS

CLASS: RendererType
TYPE:  struct
TOKEN: 0x20000AE
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.Factory.ConnectionFragment.RendererTypeNORMAL  // 0x0
  public    static  Beyond.Gameplay.Factory.ConnectionFragment.RendererTypeHS  // 0x0
METHODS:
END_CLASS

CLASS: ProtoType
TYPE:  struct
TOKEN: 0x20000B0
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.Factory.ConveyorFragment.ProtoTypeLEFT  // 0x0
  public    static  Beyond.Gameplay.Factory.ConveyorFragment.ProtoTypeMID  // 0x0
  public    static  Beyond.Gameplay.Factory.ConveyorFragment.ProtoTypeRIGHT  // 0x0
METHODS:
END_CLASS

CLASS: EntityTarget
TYPE:  struct
TOKEN: 0x20000DC
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.Factory.UnitPreviewFragment.EntityTargetBUILDING  // 0x0
  public    static  Beyond.Gameplay.Factory.UnitPreviewFragment.EntityTargetPEDESTAL_LOGISTIC  // 0x0
  public    static  Beyond.Gameplay.Factory.UnitPreviewFragment.EntityTargetPEDESTAL_NO_LOGISTIC  // 0x0
METHODS:
END_CLASS

CLASS: EntityType
TYPE:  struct
TOKEN: 0x20000DD
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.Factory.UnitPreviewFragment.EntityTypeNORMAL  // 0x0
  public    static  Beyond.Gameplay.Factory.UnitPreviewFragment.EntityTypeBLUEPRINT  // 0x0
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000146
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.CargoRendererInfoCollection<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.CargoRendererInfoCollection<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200014A
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200014F
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.PipeRendererInfoCollection<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.PipeRendererInfoCollection<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000152
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x2000157
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: EFlag
TYPE:  struct
TOKEN: 0x200015C
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.Factory.Visibility.EFlagBASIC  // 0x0
  public    static  Beyond.Gameplay.Factory.Visibility.EFlagFIGURE  // 0x0
  public    static  Beyond.Gameplay.Factory.Visibility.EFlagOTHER_MAP  // 0x0
  public    static  Beyond.Gameplay.Factory.Visibility.EFlagPHOTO  // 0x0
  public    static  Beyond.Gameplay.Factory.Visibility.EFlagBUILD_MODE  // 0x0
  public    static  Beyond.Gameplay.Factory.Visibility.EFlagUI  // 0x0
  public    static  Beyond.Gameplay.Factory.Visibility.EFlagHINT_EFFECT  // 0x0
  public    static  Beyond.Gameplay.Factory.Visibility.EFlagEXTERNAL  // 0x0
  public    static  Beyond.Gameplay.Factory.Visibility.EFlagALL  // 0x0
METHODS:
END_CLASS

CLASS: Type
TYPE:  struct
TOKEN: 0x200015D
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.Factory.Visibility.TypeBASE  // 0x0
  public    static  Beyond.Gameplay.Factory.Visibility.TypeADDITIVE_MAT  // 0x0
METHODS:
END_CLASS

CLASS: Type
TYPE:  struct
TOKEN: 0x2000160
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.Factory.WireRendererFragment.TypeNORMAL  // 0x0
  public    static  Beyond.Gameplay.Factory.WireRendererFragment.TypeHS_NORMAL  // 0x0
  public    static  Beyond.Gameplay.Factory.WireRendererFragment.TypeDISABLE  // 0x0
  public    static  Beyond.Gameplay.Factory.WireRendererFragment.TypeSTRENGTHEN  // 0x0
  public    static  Beyond.Gameplay.Factory.WireRendererFragment.TypeHS_STRENGTHEN  // 0x0
  public    static  Beyond.Gameplay.Factory.WireRendererFragment.TypeSTRENGTHEN_DISABLE  // 0x0
METHODS:
END_CLASS

CLASS: CullingGlobalSetting
TYPE:  struct
TOKEN: 0x2000162
FIELDS:
  public            System.Boolean                  bOverride  // 0x10
  public            Beyond.Gameplay.Factory.GlobalSharedData.CullingDisSettingsetting  // 0x14
  public            Beyond.Gameplay.Factory.GlobalSharedData.CullingDisSettingoverrideSetting  // 0x24
METHODS:
  System.Void ResetOverride()
  System.Void set_sqrCullDis(System.Single value)
  System.Single get_sqrCullDis()
  System.Void set_sqrUI(System.Single value)
  System.Single get_sqrUI()
  System.Void set_sqrBuildingName(System.Single value)
  System.Single get_sqrBuildingName()
  System.Void set_sqrWireCullDis(System.Single value)
  System.Single get_sqrWireCullDis()
END_CLASS

CLASS: CullingDisSetting
TYPE:  struct
TOKEN: 0x2000163
FIELDS:
  public            System.Single                   sqrCullDis  // 0x10
  public            System.Single                   sqrBuildingName  // 0x14
  public            System.Single                   sqrUI  // 0x18
  public            System.Single                   sqrWireCullDis  // 0x1C
METHODS:
END_CLASS

CLASS: SystemIntervalGlobalSetting
TYPE:  struct
TOKEN: 0x2000164
FIELDS:
  public            System.Boolean                  bOverride  // 0x10
  public            Beyond.Gameplay.Factory.GlobalSharedData.SystemIntervalSettingsetting  // 0x14
  public            Beyond.Gameplay.Factory.GlobalSharedData.SystemIntervalSettingoverrideSetting  // 0x3C
METHODS:
  System.Void Disable()
  System.Void ResetOverride()
  System.Void set_crossCollectFrameInterval(System.Int32 value)
  System.Int32 get_crossCollectFrameInterval()
  System.Void set_cullingSystemInterval(System.Int32 value)
  System.Int32 get_cullingSystemInterval()
  System.Void set_unitPreviewSystemInterval(System.Int32 value)
  System.Int32 get_unitPreviewSystemInterval()
  System.Void set_portPreviewRenderSystemInterval(System.Int32 value)
  System.Int32 get_portPreviewRenderSystemInterval()
  System.Void set_buildingStateSystemInterval(System.Int32 value)
  System.Int32 get_buildingStateSystemInterval()
  System.Void set_portBlockSystemInterval(System.Int32 value)
  System.Int32 get_portBlockSystemInterval()
  System.Void set_outputUISystemInterval(System.Int32 value)
  System.Int32 get_outputUISystemInterval()
  System.Void set_buildingNameSystemInterval(System.Int32 value)
  System.Int32 get_buildingNameSystemInterval()
  System.Void set_adjustGroundSystemInterval(System.Int32 value)
  System.Int32 get_adjustGroundSystemInterval()
  System.Void set_gridSystemInterval(System.Int32 value)
  System.Int32 get_gridSystemInterval()
END_CLASS

CLASS: SystemIntervalSetting
TYPE:  struct
TOKEN: 0x2000165
FIELDS:
  private   static  System.Int32                    MIN_INTERVAL  // 0x0
  private   static  System.Int32                    MAX_INTERVAL  // 0x0
  public            System.Int32                    crossCollectFrameInterval  // 0x10
  public            System.Int32                    cullingSystemInterval  // 0x14
  public            System.Int32                    unitPreviewSystemInterval  // 0x18
  public            System.Int32                    portPreviewRenderSystemInterval  // 0x1C
  public            System.Int32                    buildingStateSystemInterval  // 0x20
  public            System.Int32                    portBlockSystemInterval  // 0x24
  public            System.Int32                    outputUISystemInterval  // 0x28
  public            System.Int32                    buildingNameSystemInterval  // 0x2C
  public            System.Int32                    adjustGroundSystemInterval  // 0x30
  public            System.Int32                    gridSystemInterval  // 0x34
METHODS:
END_CLASS

CLASS: NearByDistanceGlobalSetting
TYPE:  struct
TOKEN: 0x2000166
FIELDS:
  public            System.Boolean                  bOverride  // 0x10
  public            Beyond.Gameplay.Factory.GlobalSharedData.NearByDistanceSettingsetting  // 0x14
  public            Beyond.Gameplay.Factory.GlobalSharedData.NearByDistanceSettingoverrideSetting  // 0x30
METHODS:
  System.Void ResetOverride()
  System.Void Disable()
  System.Void set_nearByCheck(System.Boolean value)
  System.Boolean get_nearByCheck()
  System.Void set_portPreviewCheckDistance(System.Single value)
  System.Single get_portPreviewCheckDistance()
  System.Void set_pedestalFlashCheckDistance(System.Single value)
  System.Single get_pedestalFlashCheckDistance()
  System.Void set_logisticEffectCheckDistance(System.Single value)
  System.Single get_logisticEffectCheckDistance()
  System.Void set_unitRendererCheckDistance(System.Single value)
  System.Single get_unitRendererCheckDistance()
  System.Void set_l2wCheckDistance(System.Single value)
  System.Single get_l2wCheckDistance()
  System.Void set_additiveEffectCheckDistance(System.Single value)
  System.Single get_additiveEffectCheckDistance()
END_CLASS

CLASS: NearByDistanceSetting
TYPE:  struct
TOKEN: 0x2000167
FIELDS:
  public            System.Boolean                  nearByCheck  // 0x10
  public            System.Single                   portPreviewCheckDistance  // 0x14
  public            System.Single                   pedestalFlashCheckDistance  // 0x18
  public            System.Single                   logisticEffectCheckDistance  // 0x1C
  public            System.Single                   unitRendererCheckDistance  // 0x20
  public            System.Single                   l2wCheckDistance  // 0x24
  public            System.Single                   additiveEffectCheckDistance  // 0x28
METHODS:
END_CLASS

CLASS: World3DUiGlobalSetting
TYPE:  struct
TOKEN: 0x2000168
FIELDS:
  public            System.Boolean                  bOverride  // 0x10
  public            Beyond.Gameplay.Factory.GlobalSharedData.World3DUiSettingsetting  // 0x11
  public            Beyond.Gameplay.Factory.GlobalSharedData.World3DUiSettingoverrideSetting  // 0x12
METHODS:
  System.Void Disable()
  System.Void ResetOverride()
  System.Void set_buildingNameShadowDisable(System.Boolean value)
  System.Boolean get_buildingNameShadowDisable()
END_CLASS

CLASS: World3DUiSetting
TYPE:  struct
TOKEN: 0x2000169
FIELDS:
  public            System.Boolean                  buildingNameShadowDisable  // 0x10
METHODS:
END_CLASS

CLASS: CurveGlobalSetting
TYPE:  struct
TOKEN: 0x200016A
FIELDS:
  public            System.Void*                    buildCurve  // 0x10
  public            System.Void*                    buildAlphaCurve0  // 0x18
  public            System.Void*                    buildAlphaCurve1  // 0x20
  public            System.Void*                    repairCurve0  // 0x28
  public            System.Void*                    repairCurve1  // 0x30
METHODS:
  System.Void SetBuildCurve(Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1)
  System.Void SetRepairCurve0(Beyond.Gameplay.Factory.FPtrNativeCurve& curve)
  System.Void SetRepairCurve1(Beyond.Gameplay.Factory.FPtrNativeCurve& curve)
END_CLASS

CLASS: SelectType
TYPE:  struct
TOKEN: 0x200016D
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo.SelectTypeNORMAL  // 0x0
  public    static  Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo.SelectTypeBLUEPRINT  // 0x0
METHODS:
END_CLASS

CLASS: MapGridInfo
TYPE:  struct
TOKEN: 0x200016C
FIELDS:
  public            Beyond.Gameplay.Factory.LocalTransformtrans  // 0x10
  public            Unity.Mathematics.int3          gridVoxelIndex  // 0x30
  public            System.Boolean                  selected  // 0x3C
  public            Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo.SelectTypeselectedRenderType  // 0x40
  public            System.Boolean                  hover  // 0x44
  public            System.Boolean                  water  // 0x45
  public            System.Boolean                  invalid  // 0x46
METHODS:
END_CLASS

CLASS: MapGridRendererData
TYPE:  struct
TOKEN: 0x200016B
FIELDS:
  public    static  System.Int32                    MAX_COUNT  // 0x0
  public            System.Int16                    gridCountRegion  // 0x10
  public            System.Int16                    gridCountField  // 0x12
  public            System.Int16                    gridCount  // 0x14
  public            Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.<infos>e__FixedBufferinfos  // 0x16
METHODS:
  System.Void UpdateGrid(Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo[]& gridInfosRegion, Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo[]& gridInfosField)
  System.Void Reset()
  Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo get_Item(System.Int32 idx)
  Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo* GetGridInfoPtr(System.Int32 idx)
END_CLASS

CLASS: PerDrawPassGlobalSetting
TYPE:  struct
TOKEN: 0x2000170
FIELDS:
  public            System.Int32                    count  // 0x10
  public            Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.PerDrawPassGlobalSetting.<config>e__FixedBufferconfig  // 0x14
METHODS:
  Beyond.Gameplay.Factory.PerDrawPassConfig GetPerDrawPassConfig(System.Int32 idx)
  Beyond.Gameplay.Factory.PerDrawPassConfig get_Item(System.Int32 idx)
  System.Void set_Item(System.Int32 idx, Beyond.Gameplay.Factory.PerDrawPassConfig value)
END_CLASS

CLASS: PerDrawColorGlobalSetting
TYPE:  struct
TOKEN: 0x2000172
FIELDS:
  public            System.Int32                    count  // 0x10
  public            Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.PerDrawColorGlobalSetting.<configs>e__FixedBufferconfigs  // 0x14
METHODS:
  Beyond.Gameplay.Factory.PerDrawConfig GetPerDrawConfig(System.Int32 idx)
  Beyond.Gameplay.Factory.PerDrawConfig get_Item(System.Int32 idx)
  System.Void set_Item(System.Int32 idx, Beyond.Gameplay.Factory.PerDrawConfig value)
END_CLASS

CLASS: PerDrawGlobalSetting
TYPE:  struct
TOKEN: 0x200016F
FIELDS:
  public    static  System.Int32                    COLOR_DATA_CAPACITY  // 0x0
  public    static  System.Int32                    PASS_DATA_CAPACITY  // 0x0
  public            Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.<colorData>e__FixedBuffercolorData  // 0x10
  public            Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.<passData>e__FixedBufferpassData  // 0xE16A
METHODS:
  System.Void Apply(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binder, Beyond.Gameplay.Factory.LogicEntityState entityState, Beyond.Gameplay.Factory.LogicEntityType entityType)
  System.Void Apply(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, Beyond.Gameplay.Factory.LogicEntityState entityState, Beyond.Gameplay.Factory.LogicEntityType entityType)
  System.Void Apply(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length)
  System.Void ApplyPass(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binder, Beyond.Gameplay.Factory.LogicEntityState entityState, Beyond.Gameplay.Factory.LogicEntityType entityType, System.UInt32 currentLightMode)
  System.Void ApplyPass(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, Beyond.Gameplay.Factory.LogicEntityState entityState, Beyond.Gameplay.Factory.LogicEntityType entityType, System.UInt32 currentLightMode)
  System.Void ApplyPass(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, Beyond.Gameplay.Factory.PerDrawPassConfig* perDrawConfigs, System.Int32 length, System.UInt32 currentLightMode)
  System.Void Parse(Beyond.SerializeFieldDictionary<Beyond.Gameplay.Factory.LogicEntityState,Beyond.SerializeFieldDictionary<Beyond.Gameplay.Factory.LogicEntityType,Beyond.Gameplay.Factory.PerDrawConfigArray>> setting)
  System.Int32 _GetKey(Beyond.Gameplay.Factory.LogicEntityState entityState, Beyond.Gameplay.Factory.LogicEntityType entityType)
END_CLASS

CLASS: UIEffectPathConfig
TYPE:  struct
TOKEN: 0x2000176
FIELDS:
  public    static  System.Int32                    s_max  // 0x0
  public            Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Collections.FixedString32Bytes>atlasNames  // 0x10
  public            Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Mathematics.float4>atlasColors  // 0x20
  public            Unity.Collections.NativeParallelHashMap<System.Int32,Unity.Mathematics.float4>atlasUVs  // 0x30
METHODS:
  System.Void Parse(Beyond.SerializeFieldDictionary<Beyond.GEnums.FacBuildingState,System.String> config, Beyond.SerializeFieldDictionary<Beyond.GEnums.FacBuildingState,UnityEngine.Color> factoryStateIconColorConfig, FactoryUIAtlas.FactoryUIAtlasSOData uvConfig)
  System.Boolean Get(Beyond.GEnums.FacBuildingState state, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color)
  System.Void .cctor()
END_CLASS

CLASS: ApplyRender
TYPE:  class
TOKEN: 0x200017B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binder, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binder, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(System.IAsyncResult result)
END_CLASS

CLASS: FacRegionPosValid
TYPE:  class
TOKEN: 0x200017C
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(UnityEngine.HyperGryph.ECS.EntityManager* entityManager, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.UnitFragment*& unitFragment)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager* entityManager, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.UnitFragment*& unitFragment, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(Beyond.Gameplay.Factory.UnitFragment*& unitFragment, System.IAsyncResult result)
END_CLASS

CLASS: QueryStateIconPath
TYPE:  class
TOKEN: 0x200017D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Boolean Invoke(Beyond.GEnums.FacBuildingState stateUI, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color)
  System.IAsyncResult BeginInvoke(Beyond.GEnums.FacBuildingState stateUI, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color, System.AsyncCallback callback, System.Object object)
  System.Boolean EndInvoke(Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color, System.IAsyncResult result)
END_CLASS

CLASS: QueryBuildingState
TYPE:  class
TOKEN: 0x200017E
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  Beyond.GEnums.FacBuildingState Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState, System.AsyncCallback callback, System.Object object)
  Beyond.GEnums.FacBuildingState EndInvoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState, System.IAsyncResult result)
END_CLASS

CLASS: SetEntityFlashStatue
TYPE:  class
TOKEN: 0x200017F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object object, System.IntPtr method)
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingState statue)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingState statue, System.AsyncCallback callback, System.Object object)
  System.Void EndInvoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, System.IAsyncResult result)
END_CLASS

CLASS: FAggregateEmitterTempData
TYPE:  struct
TOKEN: 0x20001E6
FIELDS:
  public            Unity.Mathematics.float3        sumPos  // 0x10
  public            System.Single                   sumWeight  // 0x1C
  public            System.Int32                    count  // 0x20
METHODS:
END_CLASS

CLASS: FGroupEmitterTempData
TYPE:  struct
TOKEN: 0x20001E7
FIELDS:
  public            Unity.Mathematics.float3x3      sumPos  // 0x10
  public            Unity.Mathematics.float3        sumWeight  // 0x34
  public            Unity.Mathematics.float3        count  // 0x40
  public            System.Int32                    inMainRegionActiveCount  // 0x4C
METHODS:
END_CLASS

CLASS: AudioDistanceAndCullingJob
TYPE:  struct
TOKEN: 0x20001E8
FIELDS:
  public            System.Single                   cullingCullDistanceSq  // 0x10
  public            System.Single                   cullingRestoreDistanceSq  // 0x14
  public            Unity.Mathematics.float3        listenerPos  // 0x18
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x28
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: AudioGroupEmitterJob
TYPE:  struct
TOKEN: 0x20001E9
FIELDS:
  public            Unity.Mathematics.float3        listenerPos  // 0x10
  public            System.Single                   innerRadiusSq  // 0x1C
  public            System.Single                   outerRadiusSq  // 0x20
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x28
  public            Unity.Collections.NativeArray<Beyond.Gameplay.Factory.AudioJobs.FGroupEmitterTempData>tempEmitterData  // 0x48
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x58
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: WaterPipeEmitterJob
TYPE:  struct
TOKEN: 0x20001EA
FIELDS:
  public            Unity.Mathematics.float3        listenerPos  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x20
  public            Unity.Collections.NativeArray<Beyond.Gameplay.Factory.AudioJobs.FAggregateEmitterTempData>tempEmitterData  // 0x40
  public            System.Single                   outerRadiusSq  // 0x50
  public            Beyond.Gameplay.Factory.GlobalEnv*envPtr  // 0x58
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void _DoCalculate(System.Int32 index, Beyond.Gameplay.Factory.PipeFragment& unit)
  System.Void SetGlobalEnv(Beyond.Gameplay.Factory.GlobalEnv& env)
END_CLASS

CLASS: BuildingInfoWrap
TYPE:  struct
TOKEN: 0x20001FE
FIELDS:
  public            Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfobuildingInfo  // 0x10
  private           Beyond.Gameplay.Factory.UnitConfigFragment<unitConfig>k__BackingField  // 0x64
METHODS:
  Beyond.Gameplay.Factory.UnitConfigFragment get_unitConfig()
  System.Void set_unitConfig(Beyond.Gameplay.Factory.UnitConfigFragment value)
  System.Void SwapTo(Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfoWrap* other)
END_CLASS

CLASS: BuildingInfo
TYPE:  struct
TOKEN: 0x20001FF
FIELDS:
  public            System.Boolean                  valid  // 0x10
  public            System.Int32                    chapterId  // 0x14
  public            System.Int32                    pendingSlotId  // 0x18
  public            System.UInt32                   nodeId  // 0x1C
  public            System.UInt32                   sharedDataHandle  // 0x20
  public            System.Int32                    subIndex  // 0x24
  public            System.Single                   adjustMapHeight  // 0x28
  public            Unity.Mathematics.float3        position  // 0x2C
  public            Unity.Mathematics.float3        rotation  // 0x38
  public            Unity.Mathematics.float3        subPosition  // 0x44
  public            Unity.Mathematics.float3        subRotation  // 0x50
  public            System.Single                   subDist  // 0x5C
  public            System.Int32                    templateNameFastString  // 0x60
METHODS:
  System.String get_templateName()
  System.String ToString()
  System.Void SetData(Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& info)
  System.Boolean IsPending()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: LogisticInfo
TYPE:  struct
TOKEN: 0x2000200
FIELDS:
  public            System.Boolean                  valid  // 0x10
  public            System.Boolean                  isConveyor  // 0x11
  public            System.Int32                    pendingSlotId  // 0x14
  public            System.Int32                    chapterId  // 0x18
  public            System.UInt32                   nodeId  // 0x1C
  public            System.Int32                    uintIndex  // 0x20
  public            Unity.Mathematics.float3        position  // 0x24
METHODS:
  System.Boolean IsPending()
  System.Void SwapTo(Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo* other)
END_CLASS

CLASS: LogicStateConfig
TYPE:  struct
TOKEN: 0x2000235
FIELDS:
  public            UnityEngine.Color               color  // 0x10
  public            System.Single                   intensity  // 0x20
  public            System.Single                   alpha  // 0x24
  public            System.Single                   flowAlpha  // 0x28
  public            UnityEngine.Color               c  // 0x2C
METHODS:
  System.Void _OnColorChanged()
END_CLASS

CLASS: VATAnimatorRequestType
TYPE:  struct
TOKEN: 0x200023D
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATAnimatorRequestTypeSetParameter  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATAnimatorRequestTypePauseOrResume  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATAnimatorRequestTypeSetSpeed  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATAnimatorRequestTypeForceSetState  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATAnimatorRequestTypeReset  // 0x0
METHODS:
END_CLASS

CLASS: SetAnimatorParamRequest
TYPE:  struct
TOKEN: 0x200023E
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityrenderEntity  // 0x10
  public            System.Boolean                  waitForStateFinish  // 0x18
  public            Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATAnimatorRequestTypetype  // 0x1C
  public            System.Boolean                  isPause  // 0x20
  public            System.Single                   speed  // 0x20
  public            System.Int32                    stateIndex  // 0x20
  public            System.Single                   stateProgress  // 0x24
  public            System.Int32                    paramIndex  // 0x20
  public            System.Single                   paramValue  // 0x24
METHODS:
  System.Void SetParamToAnimator(Beyond.Gameplay.Factory.GlobalEnv* envPtr, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& fragment, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition* sharedDataPtr)
END_CLASS

CLASS: VATFSMAudioData
TYPE:  struct
TOKEN: 0x200023F
FIELDS:
  public            UnityEngine.HyperGryph.ECS.Entityentity  // 0x10
  public            System.Int32                    hashStateName  // 0x18
METHODS:
END_CLASS

CLASS: Enumerator
TYPE:  struct
TOKEN: 0x200024C
FIELDS:
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_index  // 0x0
  private           Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition20<T>m_data  // 0x0
METHODS:
  System.Void .ctor(Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition20<T>& data, System.Int32 count)
  System.Void Dispose()
  System.Boolean MoveNext()
  System.Void Reset()
  T get_Current()
  System.Object System.Collections.IEnumerator.get_Current()
END_CLASS

CLASS: Node
TYPE:  struct
TOKEN: 0x2000253
FIELDS:
  public            Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionvalue  // 0x10
  public            System.UInt32                   next  // 0x10
METHODS:
END_CLASS

CLASS: Allocation
TYPE:  struct
TOKEN: 0x2000265
FIELDS:
  public            System.Int32                    start  // 0x10
  public            System.Int32                    end  // 0x14
  public            System.Boolean                  reallocated  // 0x18
METHODS:
END_CLASS

CLASS: __JobReflectionRegistrationOutput__755451273
TYPE:  class
TOKEN: 0x200026C
FIELDS:
METHODS:
  System.Void CreateJobReflectionData()
  System.Void EarlyInit()
END_CLASS

CLASS: $BurstDirectCallInitializer
TYPE:  class
TOKEN: 0x200026D
FIELDS:
METHODS:
  System.Void Initialize()
END_CLASS

CLASS: Beyond.FixedStack`1
TYPE:  struct
TOKEN: 0x2000025
FIELDS:
  private           T*                              m_items  // 0x0
  private   readonly System.Int32                    m_capacity  // 0x0
  private           System.Int32                    m_size  // 0x0
  private           System.Boolean                  m_disposed  // 0x0
METHODS:
  System.Void .ctor(System.Int32 capacity)
  System.Int32 get_count()
  System.Int32 get_capacity()
  System.Boolean get_isEmpty()
  System.Boolean get_isFull()
  System.Void Push(T item)
  T Pop()
  T Peek()
  System.Void Clear()
  System.Void Dispose()
END_CLASS

CLASS: Beyond.HGArray`1
TYPE:  struct
TOKEN: 0x2000026
FIELDS:
  private           T*                              m_ptr  // 0x0
  private   readonly Unity.Collections.Allocator     m_allocator  // 0x0
  private           System.UInt32                   m_size  // 0x0
  private           System.UInt32                   m_capacity  // 0x0
METHODS:
  System.UInt32 Size()
  System.UInt32 Capacity()
  T* Ptr()
  System.Void _Grow(System.UInt32 targetSize)
  System.Void .ctor(Unity.Collections.Allocator label)
  System.Void Dispose()
  System.Void Resize(System.UInt32 newSize)
  System.Void PushBack(T& v0)
  System.Void PushBack(T v0)
  T& EmplaceBack()
  System.Void Clear()
  System.Void PopBack()
  T& Back()
  System.Void SwapAndPopBack(System.UInt32 indexA)
  System.Void Reserve(System.UInt32 newCapacity)
  T& get_Item(System.Int32 index)
  T& get_Item(System.UInt32 index)
  System.Span<T> AsSpan()
END_CLASS

CLASS: Beyond.AssetInstanceParseUtil
TYPE:  class
TOKEN: 0x2000027
FIELDS:
METHODS:
  Unity.Collections.NativeArray<System.Int32> Parse(UnityEngine.Object[] objects)
  System.Int32 Parse(UnityEngine.Object obj)
  System.Object Get(System.Int32 id)
  T Get(System.Int32 id)
END_CLASS

CLASS: Beyond.Gameplay.FactorySetting
TYPE:  class
TOKEN: 0x200002D
EXTENDS: ScriptableObject
FIELDS:
  public            Beyond.Gameplay.Factory.GlobalSharedData.CullingDisSettingcullingDisSetting  // 0x18
  public            Beyond.Gameplay.FactoryEffectSettinglowFactoryEffectSetting  // 0x28
  public            Beyond.Gameplay.FactoryEffectSettingmidFactoryEffectSetting  // 0x30
  public            Beyond.Gameplay.FactoryEffectSettinghighFactoryEffectSetting  // 0x38
  public            Beyond.Gameplay.FactoryEffectSettinghighestFactoryEffectSetting  // 0x40
  public            System.Single                   uiEffectOffsetY  // 0x48
  public            System.Single                   uiFactoryOutputOffsetY  // 0x4C
  public            System.Single                   conveyorOffsetY  // 0x50
  public            System.Single                   conveyorPortBlockOffsetY  // 0x54
  public            System.Single                   pipePortBlockOffsetY  // 0x58
  public            System.Int32                    outputPoolSize  // 0x5C
  public            System.Int32                    buildingStatePoolSize  // 0x60
  public            System.Int32                    portBlockPoolSize  // 0x64
  public            System.Int32                    portArrowPoolSize  // 0x68
  public            System.Int32                    cargoPoolSize  // 0x6C
  public            Unity.Mathematics.int3          conveyorPoolSize  // 0x70
  public            Unity.Mathematics.int3          pipePoolSize  // 0x7C
  public            Unity.Mathematics.int3          figurePoolSize  // 0x88
  public            System.Int32                    figurePipeHolderPoolSize  // 0x94
  public            System.Int32                    wirePoolSize  // 0x98
  public            System.Int32                    pipeRendererMaxSize  // 0x9C
  public            System.Int32                    portRendererMaxSize  // 0xA0
  public            System.Boolean                  disableSystemInterval  // 0xA4
  public            Beyond.Gameplay.Factory.GlobalSharedData.SystemIntervalSettingsystemIntervalSetting  // 0xA8
  public            Beyond.Gameplay.Factory.GlobalSharedData.NearByDistanceSettingnearByDistanceSetting  // 0xD0
  public            Beyond.Gameplay.Factory.FactoryBaseColorLutConfigfactoryLutConfig  // 0xF0
  public            Beyond.Gameplay.Factory.FFactoryStateColorConfigfactoryStateIconColorConfig  // 0xF8
  public            FactoryUIAtlas.FactoryUIAtlasSODatafactoryItemIconAtlasUVConfig  // 0x118
  public            FactoryUIAtlas.FactoryUIAtlasSODatafactoryStateIconAtlasUVConfig  // 0x120
  public            FactoryUIAtlas.FactoryUIAtlasSODatafactorySocialIconAtlasUVConfig  // 0x128
  public            FactoryUIAtlas.FactoryLiquidAtlasSODatafactoryLiquidAtlasUVConfig  // 0x130
  public            UnityEngine.AnimationCurve      buildCutoffYCurve  // 0x138
  public            UnityEngine.AnimationCurve      buildAlphaCurveType0  // 0x140
  public            UnityEngine.AnimationCurve      buildAlphaCurveType1  // 0x148
  public            UnityEngine.AnimationCurve      repairCurve0  // 0x150
  public            UnityEngine.AnimationCurve      repairCurve1  // 0x158
  public            System.Single                   buildingDither  // 0x160
  public            System.Single                   pedestalDither  // 0x164
  public            System.Single                   ditherTargetField  // 0x168
  public            System.Single                   ditherDistance  // 0x16C
  public            System.Single                   lowFrameRate  // 0x170
METHODS:
  System.Void OnEnable()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.FactoryEffectSetting
TYPE:  struct
TOKEN: 0x200002E
FIELDS:
  public            System.Int32                    maxEffectCount  // 0x10
  public            System.Single                   effectInterval  // 0x14
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.Archetypes
TYPE:  class
TOKEN: 0x200002F
FIELDS:
METHODS:
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_empty()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_env()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_connection()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_buildingUnit()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_buildingFakeUnit()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_buildingRenderOnlyUnit()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_buildingPreviewUnit()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_buildingGuideHintUnit()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_conveyor()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_guideConveyor()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_pipe()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_pipeHolder()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_cargo()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_buildingRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_pedestalRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_conveyorLeftRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_conveyorRightRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_conveyorMidRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_figurePipeHolderRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_figureLeftRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_figureRightRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_figureMidRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_conveyorPreviewRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_pipePreviewRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_pipeComRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_pipeLeftRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_pipeMidRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_pipeRightRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_pipeTrackLeftPreviewRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_pipeTrackMidPreviewRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_pipeTrackRightPreviewRender()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_outputUIRenderer()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_wireRenderer()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_unitStatusUIRenderer()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_portPreviewUIRenderer()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_gridRenderer()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_gridMainRegionRenderer()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_portStatusUIRenderer()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> get_scope()
END_CLASS

CLASS: Beyond.Gameplay.Factory.AdditiveEffectRequestStack`1
TYPE:  struct
TOKEN: 0x2000030
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.AdditiveEffectRequestStack.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.AdditiveEffectRequestStack.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorExtContainer
TYPE:  struct
TOKEN: 0x2000033
FIELDS:
  private           Beyond.HGArray<Beyond.Gameplay.Factory.ConveyorExtContainer.Node>m_nodes  // 0x10
METHODS:
  System.Void .ctor(Unity.Collections.Allocator allocator)
  System.Void Dispose()
  System.UInt32 Size()
  System.Span<Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt> AsSpan()
  System.UInt32 Create(Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& value)
  System.Void Destroy(System.UInt32 handle)
  System.Void Reset()
  System.Void Reserve(System.UInt32 newCapacity)
  System.IntPtr Data()
  Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& get_Item(System.Int32 index)
  Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& get_Item(System.UInt32 index)
  Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& Get(System.UInt32 handle)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorInfoAllocator
TYPE:  struct
TOKEN: 0x2000036
FIELDS:
  private           Beyond.Gameplay.Factory.Unsafe.LinearAllocatorUnmanagedm_allocator  // 0x10
METHODS:
  Beyond.Gameplay.Factory.ConveyorInfoAllocator* Create(System.Int32 capacity)
  System.Void Destroy(Beyond.Gameplay.Factory.ConveyorInfoAllocator* allocator)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Allocate(System.Int32 count)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Resize(Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation allocation, System.Int32 newCount)
  System.Void Free(System.UInt32 memoryOffset)
  System.Int64 CalculateSize(System.UInt32 memoryOffset)
  Beyond.Gameplay.Factory.ConveyorInfoAllocator.Info* GetInfo(System.Int64 offset)
  System.Void* get_memoryPtr()
  System.Void DebugPrint()
END_CLASS

CLASS: Beyond.Gameplay.Factory.Data2`1
TYPE:  struct
TOKEN: 0x2000038
FIELDS:
  public            T                               port0  // 0x0
  public            T                               port1  // 0x0
METHODS:
  System.Int32 get_length()
  T get_Item(System.Int32 idx)
  System.Void set_Item(System.Int32 idx, T value)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Data4`1
TYPE:  struct
TOKEN: 0x2000039
FIELDS:
  public            Beyond.Gameplay.Factory.Data2<T>port0  // 0x0
  public            Beyond.Gameplay.Factory.Data2<T>port1  // 0x0
METHODS:
  System.Int32 get_length()
  T get_Item(System.Int32 idx)
  System.Void set_Item(System.Int32 idx, T value)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Data8`1
TYPE:  struct
TOKEN: 0x200003A
FIELDS:
  public            Beyond.Gameplay.Factory.Data4<T>port0  // 0x0
  public            Beyond.Gameplay.Factory.Data4<T>port1  // 0x0
METHODS:
  System.Int32 get_length()
  T get_Item(System.Int32 idx)
  System.Void set_Item(System.Int32 idx, T value)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Data16`1
TYPE:  struct
TOKEN: 0x200003B
FIELDS:
  public            Beyond.Gameplay.Factory.Data8<T>port0  // 0x0
  public            Beyond.Gameplay.Factory.Data8<T>port1  // 0x0
METHODS:
  System.Int32 get_length()
  T get_Item(System.Int32 idx)
  System.Void set_Item(System.Int32 idx, T value)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Data32`1
TYPE:  struct
TOKEN: 0x200003C
FIELDS:
  public            Beyond.Gameplay.Factory.Data16<T>port0  // 0x0
  public            Beyond.Gameplay.Factory.Data16<T>port1  // 0x0
METHODS:
  System.Int32 get_length()
  T get_Item(System.Int32 idx)
  System.Void set_Item(System.Int32 idx, T value)
END_CLASS

CLASS: Beyond.Gameplay.Factory.EntityData4`1
TYPE:  struct
TOKEN: 0x200003D
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.EntityData4.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.EntityData4.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.EntityData8`1
TYPE:  struct
TOKEN: 0x2000040
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.EntityData8.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.EntityData8.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.EntityData32`1
TYPE:  struct
TOKEN: 0x2000043
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.EntityData32.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.EntityData32.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.EntityData64`1
TYPE:  struct
TOKEN: 0x2000046
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.EntityData64.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.EntityData64.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.EntityData128`1
TYPE:  struct
TOKEN: 0x2000049
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.EntityData128.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.EntityData128.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.EntityData256`1
TYPE:  struct
TOKEN: 0x200004C
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.EntityData256.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.EntityData256.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.EntityData512`1
TYPE:  struct
TOKEN: 0x200004F
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.EntityData512.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.EntityData512.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.EntityData1024`1
TYPE:  struct
TOKEN: 0x2000052
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.EntityData1024.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.EntityData1024.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Float4Data6`1
TYPE:  struct
TOKEN: 0x2000055
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.Float4Data6.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.Float4Data6.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Float4Data16`1
TYPE:  struct
TOKEN: 0x2000058
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.Float4Data16.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.Float4Data16.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.IntData8`1
TYPE:  struct
TOKEN: 0x200005B
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.IntData8.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.IntData8.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.IntData32`1
TYPE:  struct
TOKEN: 0x200005E
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.IntData32.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.IntData32.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.LogisticsExtContainer
TYPE:  struct
TOKEN: 0x2000061
FIELDS:
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.OutputRendererInfo
TYPE:  struct
TOKEN: 0x2000063
FIELDS:
  public            Unity.Mathematics.float3        outputPos  // 0x10
  public            System.Boolean                  enableLiquidIcon  // 0x1C
  public            System.Boolean                  depthBlendDisabled  // 0x1D
  public            Unity.Mathematics.half4         color  // 0x20
  public            Unity.Mathematics.half4         atlasRect  // 0x28
  public            Unity.Mathematics.half4         liquidAtlasUV  // 0x30
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.PortData16`1
TYPE:  struct
TOKEN: 0x2000064
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.PortData16.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.PortData16.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PortData32`1
TYPE:  struct
TOKEN: 0x2000067
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.PortData32.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.PortData32.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PortData128`1
TYPE:  struct
TOKEN: 0x200006A
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.PortData128.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.PortData128.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PortData256`1
TYPE:  struct
TOKEN: 0x200006D
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.PortData256.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.PortData256.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.SharedDataContainer
TYPE:  struct
TOKEN: 0x2000070
FIELDS:
  private           Beyond.HGArray<Beyond.Gameplay.Factory.SharedDataContainer.Node>m_nodes  // 0x10
METHODS:
  System.Void .ctor(Unity.Collections.Allocator allocator)
  System.Void Dispose()
  System.UInt32 Size()
  System.Span<Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData> AsSpan()
  System.UInt32 Create(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& value)
  System.Void Destroy(System.UInt32 handle)
  System.Void Reset()
  System.Void Reserve(System.UInt32 newCapacity)
  System.IntPtr Data()
  Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& get_Item(System.Int32 index)
  Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& get_Item(System.UInt32 index)
  Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& Get(System.UInt32 handle)
END_CLASS

CLASS: Beyond.Gameplay.Factory.StaticMountInfo
TYPE:  struct
TOKEN: 0x2000074
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityrendererEntity  // 0x10
  public            Beyond.Gameplay.Factory.FactoryUnitExtendConfigmountConfig  // 0x18
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.StaticMountInfoCollection`1
TYPE:  struct
TOKEN: 0x2000075
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.StaticMountInfoCollection.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  T* GetDataPtr()
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.StaticMountInfoCollection.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitExtendConfig12`1
TYPE:  struct
TOKEN: 0x2000078
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.UnitExtendConfig12.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.UnitExtendConfig12.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.WireRendererInfo
TYPE:  struct
TOKEN: 0x200007B
FIELDS:
  public            Unity.Mathematics.float3        fromPos  // 0x10
  public            Unity.Mathematics.float3        toPos  // 0x1C
  public            System.UInt64                   connectionId  // 0x28
  public            System.Single                   alpha  // 0x30
METHODS:
  Unity.Mathematics.float3 get_pos()
  Unity.Mathematics.quaternion get_rot()
  System.Single get_scale()
END_CLASS

CLASS: Beyond.Gameplay.Factory.WireRendererInfoCollection`1
TYPE:  struct
TOKEN: 0x200007C
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  T* GetDataPtr()
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.WireRendererInfoCollection.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.EntitySearcher
TYPE:  class
TOKEN: 0x200007F
FIELDS:
  private           Unity.Collections.NativeParallelHashMap<Beyond.Gameplay.Factory.UnitId,UnityEngine.HyperGryph.ECS.Entity>m_logicEntityMap  // 0x10
METHODS:
  Unity.Collections.NativeParallelHashMap<Beyond.Gameplay.Factory.UnitId,UnityEngine.HyperGryph.ECS.Entity> GetLogicEntityMap()
  System.Void RegisterLogicEntity(System.Int32 chapterId, System.UInt32 nodeId, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Boolean UnregisterLogicEntity(System.Int32 chapterId, System.UInt32 nodeId)
  System.Boolean GetLogicEntity(System.Int32 chapterId, System.UInt32 nodeId, UnityEngine.HyperGryph.ECS.Entity& entity)
  System.Void _DestroyAllEntities()
  System.Void DestroyAll()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.MiscExtensions
TYPE:  class
TOKEN: 0x2000080
FIELDS:
METHODS:
  System.Void SafeDispose(Unity.Collections.NativeList<T> list)
  System.Void SafeDispose(Unity.Collections.NativeArray<T> array)
  System.Void SafeDispose(Unity.Collections.NativeQueue<T> queue)
  System.Void SafeDispose(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list)
  System.Void SafeDispose(Unity.Collections.NativeParallelHashMap<TKey,TValue> list)
  System.Void SafeDispose(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<TKey,TValue> list)
END_CLASS

CLASS: Beyond.Gameplay.Factory.FactoryProfilerMakers
TYPE:  class
TOKEN: 0x2000081
FIELDS:
  public    static readonly Unity.Profiling.ProfilerMarker  S_PROFILER_PRE_EXECUTE  // 0x0
  public    static readonly Unity.Profiling.ProfilerMarker  S_PROFILER_EXECUTE  // 0x8
  public    static readonly Unity.Profiling.ProfilerMarker  S_PROFILER_FLUSH_REPEATER  // 0x10
  public    static readonly Unity.Profiling.ProfilerMarker  S_PROFILER_BLUEPRINT_UPDATE  // 0x18
  public    static readonly Unity.Profiling.ProfilerMarker  S_PROFILER_LATE_EXECUTE  // 0x20
  public    static readonly Unity.Profiling.ProfilerMarker  S_PROFILER_CLEAN  // 0x28
  public    static readonly Unity.Profiling.ProfilerMarker  S_MODIFY_REGION_NODES  // 0x30
  public    static readonly Unity.Profiling.ProfilerMarker  S_DITHER_PREPARE_ENTITY_POS  // 0x38
  public    static readonly Unity.Profiling.ProfilerMarker  S_SEARCH_DITHER_ENTITY  // 0x40
  public    static readonly Unity.Profiling.ProfilerMarker  S_EXECUTE_DITHER  // 0x48
  public    static readonly Unity.Profiling.ProfilerMarker  S_PROTO_LOGISTIC  // 0x50
  public    static readonly Unity.Profiling.ProfilerMarker  S_PROTO_EXECUTE_LOGISTIC_EFFECT  // 0x58
  public    static readonly Unity.Profiling.ProfilerMarker  S_PROTO_CARGO  // 0x60
  public    static readonly Unity.Profiling.ProfilerMarker  S_PROTO_PARSE_CARGO  // 0x68
  public    static readonly Unity.Profiling.ProfilerMarker  S_PROTO_PARSE_CARGO_PREPARE  // 0x70
  public    static readonly Unity.Profiling.ProfilerMarker  S_CARGO_ENQUEUE  // 0x78
  public    static readonly Unity.Profiling.ProfilerMarker  S_CARGO_DEQUEUE  // 0x80
  public    static readonly Unity.Profiling.ProfilerMarker  S_CARGO_ADJUST  // 0x88
  public    static readonly Unity.Profiling.ProfilerMarker  S_ECS_INSTANCE  // 0x90
  public    static readonly Unity.Profiling.ProfilerMarker  S_TRY_NUM_TO_STR_ITEM  // 0x98
  public    static readonly Unity.Profiling.ProfilerMarker  S_TRY_STR_TO_NUM_ITEM  // 0xA0
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FactorySharedDataManager
TYPE:  class
TOKEN: 0x2000082
FIELDS:
  private   static  Beyond.Gameplay.Factory.ConveyorExtContainers_conveyorExtData  // 0x0
  private   static  Beyond.Gameplay.Factory.SharedDataContainers_sharedData  // 0x18
  private   static  UnityEngine.HyperGryph.ECS.EntityHierarchyContainers_hierarchy  // 0x30
  private   static  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainers_vatFsm  // 0x38
METHODS:
  System.Void InitExtData()
  System.Void ResetExtData()
  System.Void ReleaseExtData()
  System.UInt32 CreateConveyorExtHandle()
  System.Void DestroyConveyorExtHandle(System.UInt32 handle)
  Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& GetConveyorExt(System.UInt32 handle)
  System.IntPtr GetConveyorExtData()
  System.UInt32 CreateSharedData(System.Boolean adjustMapValid)
  Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& GetSharedData(System.UInt32 handle)
  System.Void DestroySharedData(System.UInt32 handle)
  System.IntPtr GetSharedData()
  System.UInt32 CreateTransHierarchy()
  UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& GetHierarchyData(System.UInt32 handle)
  UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& GetHierarchyData(System.Int32 handle)
  Unity.Mathematics.float4x4 WorldTrans(UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& transform)
  System.Void DestroyHierarchyData(System.UInt32 handle)
  System.IntPtr GetHierarchyData()
  System.UInt32 CreateVATFSMDefinitionContainer(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& definition)
  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& GetVATFSMDefinition(System.UInt32 handle)
  System.Void DestroyVATFSMDefinition(System.UInt32 handle)
  System.IntPtr GetVATFSMDefinition()
END_CLASS

CLASS: Beyond.Gameplay.Factory.AdditiveEffectFragment
TYPE:  struct
TOKEN: 0x2000083
FIELDS:
  public            System.Byte                     entityType  // 0x10
  public            System.UInt32                   lightMode  // 0x14
  public            Beyond.Gameplay.Factory.SoloSelectStatesoloSelectState  // 0x18
  public            Beyond.Gameplay.Factory.BuildDismissStatebuildDismissState  // 0x20
  public            Beyond.Gameplay.Factory.CutoffStatecutoffState  // 0x38
  public            Beyond.Gameplay.Factory.RepairStaterepairState  // 0x48
  public            Beyond.Gameplay.Factory.HighLightStatehighLightState  // 0x70
  public            Beyond.Gameplay.Factory.HintStatehintState  // 0xFC
  public            Beyond.Gameplay.Factory.FigureStatefigureState  // 0x108
  public            Beyond.Gameplay.Factory.OverloadStateoverloadState  // 0x114
  public            Beyond.Gameplay.Factory.OverloadInvalidStateoverloadInvalidState  // 0x120
  public            Beyond.Gameplay.Factory.BlueprintStateblueprintState  // 0x130
  public            Beyond.Gameplay.Factory.PreSelectStatepreSelectState  // 0x360
  public            Beyond.Gameplay.Factory.ContinuationStatecontinuationState  // 0x562
  public            Beyond.Gameplay.Factory.SocialSharingStatesocialSharingState  // 0x764
  public            Beyond.Gameplay.Factory.PowerInteractionStatepowerInteractionState  // 0x765
  public            Beyond.Gameplay.Factory.AdditiveEffectFragment.RequestcurEffectRequest  // 0x766
  public            Beyond.Gameplay.Factory.AdditiveEffectRequestStack<Beyond.Gameplay.Factory.AdditiveEffectFragment.Request>stateWaitStack  // 0x76C
METHODS:
  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType get_curEffectType()
  System.Void set_curEffectType(Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType value)
  System.Void PushState(Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType state)
  System.Void InsertState(System.Int32 index, Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType state)
  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType ShiftState()
  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType PopState()
  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType PeekState()
  System.Void DisableState(Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType state)
  System.Void _Shrink()
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Gameplay.Factory.CutoffState
TYPE:  struct
TOKEN: 0x2000086
FIELDS:
  private           System.Boolean                  m_enable  // 0x10
  public            System.UInt32                   mode  // 0x14
  public            System.Single                   cutOffY  // 0x18
  private           System.Boolean                  <enable>k__BackingField  // 0x1C
METHODS:
  System.Void set_enable(System.Boolean value)
  System.Boolean get_enable()
  System.Void SetEnable(System.Boolean v)
  System.Void SetCutoffY(System.Single v)
  System.Void SetMode(System.UInt32 v)
END_CLASS

CLASS: Beyond.Gameplay.Factory.BuildDismissState
TYPE:  struct
TOKEN: 0x2000087
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Boolean                  started  // 0x11
  public            System.Boolean                  build  // 0x12
  public            System.Byte                     effectType  // 0x13
  public            System.Single                   duration  // 0x14
  public            System.Single                   startY  // 0x18
  public            System.Single                   deltaY  // 0x1C
  public            System.Int64                    startTms  // 0x20
METHODS:
  System.Void SetEnable(System.Boolean v)
END_CLASS

CLASS: Beyond.Gameplay.Factory.RepairState
TYPE:  struct
TOKEN: 0x2000089
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            Beyond.Gameplay.Factory.RepairState0state0  // 0x18
  public            Beyond.Gameplay.Factory.RepairState1state1  // 0x28
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.RepairState0
TYPE:  struct
TOKEN: 0x200008A
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Single                   duration  // 0x14
  public            System.Int64                    startTms  // 0x18
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.RepairState1
TYPE:  struct
TOKEN: 0x200008B
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Single                   duration  // 0x14
  public            System.Int64                    startTms  // 0x18
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.HighLightState
TYPE:  struct
TOKEN: 0x200008C
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Boolean                  invalid  // 0x11
  public            System.Boolean                  social  // 0x12
  public            Unity.Collections.FixedList128Bytes<System.Byte>indexList  // 0x14
  public            Beyond.Gameplay.Factory.DitherStateditherState  // 0x94
METHODS:
  System.Void SetEnable(System.Boolean isEnable)
  System.Void SetData(System.Boolean isInvalid, System.Boolean isSocial)
  Beyond.Gameplay.Factory.LogicEntityState GetEffectType()
  System.Boolean IsHighlight(System.Byte index)
  System.Void HighlightWithSubIndex(System.Byte index, System.Boolean en)
  System.Void ClearHighlightableIndexList()
END_CLASS

CLASS: Beyond.Gameplay.Factory.HintState
TYPE:  struct
TOKEN: 0x200008D
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Boolean                  showSelf  // 0x11
  public            Beyond.Gameplay.Factory.DitherStateditherState  // 0x14
METHODS:
  System.Void SetEnable(System.Boolean v)
END_CLASS

CLASS: Beyond.Gameplay.Factory.FigureState
TYPE:  struct
TOKEN: 0x200008E
FIELDS:
  public            System.Boolean                  valid  // 0x10
  public            System.Boolean                  enable  // 0x11
  public            Beyond.Gameplay.Factory.DitherStateditherState  // 0x14
METHODS:
  System.Void SetEnable(System.Boolean v)
END_CLASS

CLASS: Beyond.Gameplay.Factory.OverloadState
TYPE:  struct
TOKEN: 0x200008F
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            Beyond.Gameplay.Factory.DitherStateditherState  // 0x14
METHODS:
  System.Void SetEnable(System.Boolean v)
END_CLASS

CLASS: Beyond.Gameplay.Factory.OverloadInvalidState
TYPE:  struct
TOKEN: 0x2000090
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            Beyond.Gameplay.Factory.DitherStateditherState  // 0x14
METHODS:
  System.Void SetEnable(System.Boolean v)
END_CLASS

CLASS: Beyond.Gameplay.Factory.DitherState
TYPE:  struct
TOKEN: 0x2000091
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Single                   ditherVal  // 0x14
METHODS:
  System.Void SetEnable(System.Boolean v)
END_CLASS

CLASS: Beyond.Gameplay.Factory.BlueprintState
TYPE:  struct
TOKEN: 0x2000092
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            Beyond.Gameplay.Factory.BlueprintState.EffectTypeeffectType  // 0x11
  public            Unity.Collections.FixedList512Bytes<System.Byte>indexList  // 0x12
  public            Beyond.Gameplay.Factory.CutoffStatecutoffState  // 0x214
  public            Beyond.Gameplay.Factory.BuildDismissStatebuildState  // 0x228
METHODS:
  System.Void SetEnable(System.Boolean v)
  System.Void SetEnable(System.Boolean v, Beyond.Gameplay.Factory.BlueprintState.EffectType type)
  System.Boolean IsLighten(System.Byte index)
  System.Void LightenWithSubIndex(System.Byte index, System.Boolean en)
  System.Void ClearLightenIndexList()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PreSelectState
TYPE:  struct
TOKEN: 0x2000094
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            Unity.Collections.FixedList512Bytes<System.Byte>indexList  // 0x12
METHODS:
  System.Void SetEnable(System.Boolean v)
  System.Boolean IsLighten(System.Byte index)
  System.Void LightenWithSubIndex(System.Byte index, System.Boolean en)
  System.Void ClearLightenIndexList()
END_CLASS

CLASS: Beyond.Gameplay.Factory.SoloSelectState
TYPE:  struct
TOKEN: 0x2000095
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.Int32                    selectedIndex  // 0x14
METHODS:
  System.Void SetEnable(System.Boolean v)
  System.Boolean IsLighten(System.Int32 index)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ContinuationState
TYPE:  struct
TOKEN: 0x2000096
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            Unity.Collections.FixedList512Bytes<System.Byte>indexList  // 0x12
METHODS:
  System.Void SetEnable(System.Boolean v)
  System.Boolean IsLighten(System.Byte index)
  System.Void LightenWithSubIndex(System.Byte index, System.Boolean en)
  System.Void ClearLightenIndexList()
END_CLASS

CLASS: Beyond.Gameplay.Factory.SocialSharingState
TYPE:  struct
TOKEN: 0x2000097
FIELDS:
  public            System.Boolean                  enable  // 0x10
METHODS:
  System.Void SetEnable(System.Boolean v)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PowerInteractionState
TYPE:  struct
TOKEN: 0x2000098
FIELDS:
  public            System.Boolean                  enable  // 0x10
METHODS:
  System.Void SetEnable(System.Boolean v)
END_CLASS

CLASS: Beyond.Gameplay.Factory.AdditiveEffectRendererFragment
TYPE:  struct
TOKEN: 0x2000099
FIELDS:
  public            System.Boolean                  anyEffectStateChanged  // 0x10
  private           System.Boolean                  m_buildDismissEnabledState  // 0x11
  private           System.Boolean                  m_blueprintBuildEnabledState  // 0x12
  private           System.Boolean                  m_blueprintBuildCutoffYEnabledState  // 0x13
  private           System.Boolean                  m_cutOffYIgnoredState  // 0x14
  private           System.Boolean                  m_cutoffYEnabledState  // 0x15
  private           System.Boolean                  m_highLightEnabledState  // 0x16
  private           System.Boolean                  m_figureEnabledState  // 0x17
  private           System.Boolean                  m_hintEnabledState  // 0x18
  private           System.Boolean                  m_overloadEnabledState  // 0x19
  private           System.Boolean                  m_overloadInvalidEnabledState  // 0x1A
  private           System.Boolean                  m_repair0EnabledState  // 0x1B
  private           System.Boolean                  m_repair1EnabledState  // 0x1C
  private           System.Boolean                  m_blueprintEnabledState  // 0x1D
  private           System.Boolean                  m_preSelectEnabledState  // 0x1E
  private           System.Boolean                  m_continuationEnabledState  // 0x1F
  private           System.Boolean                  m_socialSharingEnabledState  // 0x20
  private           System.Boolean                  m_powerInteractionEnabledState  // 0x21
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Boolean get_buildDismissEnabled()
  System.Void set_buildDismissEnabled(System.Boolean value)
  System.Boolean get_blueprintBuildEnabled()
  System.Void set_blueprintBuildEnabled(System.Boolean value)
  System.Boolean get_blueprintBuildCutoffYEnabled()
  System.Void set_blueprintBuildCutoffYEnabled(System.Boolean value)
  System.Boolean get_cutOffYIgnored()
  System.Void set_cutOffYIgnored(System.Boolean value)
  System.Boolean get_cutoffYEnabled()
  System.Void set_cutoffYEnabled(System.Boolean value)
  System.Boolean get_highLightEnabled()
  System.Void set_highLightEnabled(System.Boolean value)
  System.Boolean get_figureEnabled()
  System.Void set_figureEnabled(System.Boolean value)
  System.Boolean get_hintEnabled()
  System.Void set_hintEnabled(System.Boolean value)
  System.Boolean get_overloadEnabled()
  System.Void set_overloadEnabled(System.Boolean value)
  System.Boolean get_overloadInvalidEnabled()
  System.Void set_overloadInvalidEnabled(System.Boolean value)
  System.Boolean get_repair0Enabled()
  System.Void set_repair0Enabled(System.Boolean value)
  System.Boolean get_repair1Enabled()
  System.Void set_repair1Enabled(System.Boolean value)
  System.Boolean get_blueprintEnabled()
  System.Void set_blueprintEnabled(System.Boolean value)
  System.Boolean get_preSelectEnabled()
  System.Void set_preSelectEnabled(System.Boolean value)
  System.Boolean get_continuationEnabled()
  System.Void set_continuationEnabled(System.Boolean value)
  System.Boolean get_socialSharingEnabled()
  System.Void set_socialSharingEnabled(System.Boolean value)
  System.Boolean get_powerInteractionEnabled()
  System.Void set_powerInteractionEnabled(System.Boolean value)
  System.Boolean get_anyEffect()
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.BattleFragment
TYPE:  struct
TOKEN: 0x200009A
FIELDS:
  public            System.Boolean                  overload  // 0x10
  public            System.Single                   currentEnergy  // 0x14
  public            System.Single                   maxEnergy  // 0x18
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.BindRenderEntityFragment
TYPE:  struct
TOKEN: 0x200009B
FIELDS:
  public            Beyond.Gameplay.Factory.EntityData512<UnityEngine.HyperGryph.ECS.Entity>renderEntities  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Void BindRenderEntity(UnityEngine.HyperGryph.ECS.Entity renderEntity)
  System.Void BindRenderEntities(UnityEngine.HyperGryph.ECS.Entity[] renderEntityList)
  System.Void BindRenderEntities(Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> renderEntityList)
  System.Void UnbindRenderEntity(UnityEngine.HyperGryph.ECS.Entity renderEntity)
  System.Void ClearBindRenderEntities()
  System.Boolean Binded(UnityEngine.HyperGryph.ECS.Entity renderEntity)
  System.Boolean HasRenderer()
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.BurnPowerFragment
TYPE:  struct
TOKEN: 0x200009C
FIELDS:
  public            System.Int64                    currentLeastProgress  // 0x10
  public            System.Int64                    powerGenPerSec  // 0x18
  public            Unity.Collections.FixedString64BytesburningItemId  // 0x20
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.BusFragment
TYPE:  struct
TOKEN: 0x200009D
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.BusFreeFragment
TYPE:  struct
TOKEN: 0x200009E
FIELDS:
  public            System.Boolean                  connectToStart  // 0x10
  public            System.Boolean                  enabled  // 0x11
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.CacheFragment
TYPE:  struct
TOKEN: 0x200009F
FIELDS:
  private   static  System.Int32                    CONTAINER_OFFSET  // 0x0
  private   static  System.Int32                    ITEM_SIZE  // 0x0
  public            Beyond.Gameplay.Factory.CacheFragment.<cacheSizePtr>e__FixedBuffercacheSizePtr  // 0x10
  public            System.Byte                     cacheIn0Size  // 0x10
  public            System.Byte                     cacheIn1Size  // 0x11
  public            System.Byte                     cacheIn2Size  // 0x12
  public            System.Byte                     cacheIn3Size  // 0x13
  public            System.Byte                     cacheOut0Size  // 0x14
  public            System.Byte                     cacheOut1Size  // 0x15
  public            System.Byte                     cacheOut2Size  // 0x16
  public            System.Byte                     cacheOut3Size  // 0x17
  public            Beyond.Gameplay.Factory.CacheFragment.<cacheFluidSizePtr>e__FixedBuffercacheFluidSizePtr  // 0x18
  public            System.Byte                     cacheFluidIn0Size  // 0x18
  public            System.Byte                     cacheFluidIn1Size  // 0x19
  public            System.Byte                     cacheFluidIn2Size  // 0x1A
  public            System.Byte                     cacheFluidIn3Size  // 0x1B
  public            System.Byte                     cacheFluidOut0Size  // 0x1C
  public            System.Byte                     cacheFluidOut1Size  // 0x1D
  public            System.Byte                     cacheFluidOut2Size  // 0x1E
  public            System.Byte                     cacheFluidOut3Size  // 0x1F
  public            Beyond.Gameplay.Factory.CacheFragment.<cacheContentPtr>e__FixedBuffercacheContentPtr  // 0x20
  public            Beyond.Gameplay.Factory.CacheFragment.<itemInPtr>e__FixedBufferitemInPtr  // 0x20
  public            Beyond.Gameplay.Factory.FactoryItemin0  // 0x20
  public            Beyond.Gameplay.Factory.FactoryItemin1  // 0x30
  public            Beyond.Gameplay.Factory.FactoryItemin2  // 0x40
  public            Beyond.Gameplay.Factory.FactoryItemin3  // 0x50
  public            Beyond.Gameplay.Factory.FactoryItemin4  // 0x60
  public            Beyond.Gameplay.Factory.FactoryItemin5  // 0x70
  public            Beyond.Gameplay.Factory.FactoryItemin6  // 0x80
  public            Beyond.Gameplay.Factory.FactoryItemin7  // 0x90
  public            Beyond.Gameplay.Factory.CacheFragment.<itemOutPtr>e__FixedBufferitemOutPtr  // 0xA0
  public            Beyond.Gameplay.Factory.FactoryItemout0  // 0xA0
  public            Beyond.Gameplay.Factory.FactoryItemout1  // 0xB0
  public            Beyond.Gameplay.Factory.FactoryItemout2  // 0xC0
  public            Beyond.Gameplay.Factory.FactoryItemout3  // 0xD0
  public            Beyond.Gameplay.Factory.FactoryItemout4  // 0xE0
  public            Beyond.Gameplay.Factory.FactoryItemout5  // 0xF0
  public            Beyond.Gameplay.Factory.FactoryItemout6  // 0x100
  public            Beyond.Gameplay.Factory.FactoryItemout7  // 0x110
  public            Beyond.Gameplay.Factory.CacheFragment.<fluidInPtr>e__FixedBufferfluidInPtr  // 0x120
  public            Beyond.Gameplay.Factory.FactoryItemfluidIn0  // 0x120
  public            Beyond.Gameplay.Factory.FactoryItemfluidIn1  // 0x130
  public            Beyond.Gameplay.Factory.FactoryItemfluidIn2  // 0x140
  public            Beyond.Gameplay.Factory.FactoryItemfluidIn3  // 0x150
  public            Beyond.Gameplay.Factory.FactoryItemfluidIn4  // 0x160
  public            Beyond.Gameplay.Factory.FactoryItemfluidIn5  // 0x170
  public            Beyond.Gameplay.Factory.FactoryItemfluidIn6  // 0x180
  public            Beyond.Gameplay.Factory.FactoryItemfluidIn7  // 0x190
  public            Beyond.Gameplay.Factory.CacheFragment.<fluidOutPtr>e__FixedBufferfluidOutPtr  // 0x1A0
  public            Beyond.Gameplay.Factory.FactoryItemfluidOut0  // 0x1A0
  public            Beyond.Gameplay.Factory.FactoryItemfluidOut1  // 0x1B0
  public            Beyond.Gameplay.Factory.FactoryItemfluidOut2  // 0x1C0
  public            Beyond.Gameplay.Factory.FactoryItemfluidOut3  // 0x1D0
  public            Beyond.Gameplay.Factory.FactoryItemfluidOut4  // 0x1E0
  public            Beyond.Gameplay.Factory.FactoryItemfluidOut5  // 0x1F0
  public            Beyond.Gameplay.Factory.FactoryItemfluidOut6  // 0x200
  public            Beyond.Gameplay.Factory.FactoryItemfluidOut7  // 0x210
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Void GetCacheItem(System.Boolean inOut, System.Boolean isFluid, System.Int32 cacheIndex, System.Int32 indexInCache, System.UInt32& itemId, System.Int32& itemAmount, System.Int64& tms)
  System.Void SetCacheItem(System.Boolean inOut, System.Boolean isFluid, System.Int32 cacheIndex, System.Int32 indexInCache, System.UInt32 itemId, System.Int32 itemAmount, System.Int64 tms)
  System.Void SetCacheSize(System.Boolean inOut, System.Boolean isFluid, System.Int32 cacheIndex, System.Int32 sizeCount)
  System.Int32 CalcIndex(System.Boolean inOut, System.Boolean isFluid, System.Int32 cacheIndex, System.Int32 indexInCache, Beyond.Gameplay.Factory.FactoryItem*& ptr)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.CacheTransportFragment
TYPE:  struct
TOKEN: 0x20000A7
FIELDS:
  public            System.Boolean                  autoTransport  // 0x10
  public            System.Boolean                  inUse  // 0x11
  public            System.Single                   currentProgress  // 0x14
  public            System.Single                   totalProgress  // 0x18
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.CargoFragment
TYPE:  struct
TOKEN: 0x20000A8
FIELDS:
  public            System.Boolean                  serverArrived  // 0x10
  public            System.Boolean                  arrived  // 0x11
  public            System.Boolean                  enter  // 0x12
  public            System.Boolean                  isLiquidItem  // 0x13
  public            System.UInt32                   conveyorId  // 0x14
  public            System.Single                   moveSpeed  // 0x18
  public            System.Int32                    minDist  // 0x1C
  public            System.Int32                    conveyorLength  // 0x20
  public            System.Single                   predictPos  // 0x24
  public            Unity.Mathematics.float3        position  // 0x28
  public            Unity.Mathematics.float4        itemUV  // 0x34
  public            Unity.Mathematics.float4        itemLiquidUV  // 0x44
  public            Unity.Mathematics.quaternion    rotation  // 0x54
  public            System.Int32                    itemFastId  // 0x64
  public            System.Int64                    tms  // 0x68
  public            System.Single                   adjustTms  // 0x70
  public            System.UInt32                   conveyorExtHandle  // 0x74
  public            System.Int32                    cargoIndex  // 0x78
  public            System.Int32                    indexInRendererList  // 0x7C
  public            System.Int32                    unitConfigAssetInstanceId  // 0x80
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.String get_itemId()
  System.Void set_itemId(System.String value)
  System.Single PredictPos(System.Int64 serverTime)
  System.Single PredictPosWithDeltaTime(System.Int64 deltaTime)
  System.Int32 CompareTo(Beyond.Gameplay.Factory.CargoFragment other)
  System.Boolean get_recyclable()
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
  System.Boolean GetVisible(Beyond.Gameplay.Factory.CargoRendererInfoCollection<Beyond.Gameplay.Factory.CargoRendererInfo>* rendererList)
  Beyond.Gameplay.Factory.CargoFragment Create(System.UInt32 unitId, Unity.Mathematics.int4 itemAtlasRect, Unity.Mathematics.int4 liquidAtlasRect, System.Int32 itemFastId, System.Int32 conveyorSpeed, System.Int64 tms, System.Int32 conveyorLength, System.Single minDis, System.Boolean isLiquidItem)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.CargoRendererFragment
TYPE:  struct
TOKEN: 0x20000AA
FIELDS:
  public            System.Int32                    unitConfigAssetInstanceId  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ChapterFragment
TYPE:  struct
TOKEN: 0x20000AB
FIELDS:
  public            System.Int64                    powerCost  // 0x10
  public            System.Int64                    powerGen  // 0x18
  public            System.Int64                    powerSaveCurrent  // 0x20
  public            System.Int64                    powerSaveMax  // 0x28
  public            System.Boolean                  isStopByPower  // 0x30
  public            System.Int32                    chapterId  // 0x34
  public            Beyond.Gameplay.Factory.BlueprintSlotInfoblueprintSlotInfo  // 0x38
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.CollectorFragment
TYPE:  struct
TOKEN: 0x20000AC
FIELDS:
  public            System.Int64                    currentProgress  // 0x10
  public            System.UInt32                   collectItem  // 0x18
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConnectionFragment
TYPE:  struct
TOKEN: 0x20000AD
FIELDS:
  public            System.UInt64                   connectionId  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityfromEntity  // 0x18
  public            System.Int64                    fromNodeEntityId  // 0x18
  public            UnityEngine.HyperGryph.ECS.EntitytoEntity  // 0x20
  public            System.Int64                    toNodeEntityId  // 0x20
  public            System.Boolean                  strengthenConnection  // 0x28
  public            Beyond.Gameplay.Factory.ConnectionFragment.RendererTyperendererType  // 0x29
  public            System.Int32                    chapterId  // 0x2A
  public            System.Single                   alpha  // 0x2E
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Boolean get_valid()
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorFragment
TYPE:  struct
TOKEN: 0x20000AF
FIELDS:
  public            System.UInt32                   factoryUnitId  // 0x10
  public            System.Single                   speed  // 0x14
  public            UnityEngine.Rect                bounds  // 0x18
  private           System.Int32                    <length>k__BackingField  // 0x28
  public            System.UInt32                   startMemoryOffsetHandle  // 0x2C
  public            System.UInt32                   endMemoryOffsetHandle  // 0x30
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Void set_length(System.Int32 value)
  System.Int32 get_length()
  System.Void SetInflection(Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Collections.NativeList<Unity.Mathematics.float3>& p, Unity.Collections.NativeList<Unity.Mathematics.float3>& r, Unity.Collections.NativeArray<System.Byte>& proto)
  System.Void CalcRect(Unity.Collections.NativeList<Unity.Mathematics.float3> posList, UnityEngine.Rect& b)
  System.Boolean Sample(Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Mathematics.float2 p, System.UInt32& unitId, System.Int32& indexInConveyor)
  System.Boolean IsInRect(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax)
  System.Boolean GetInRectUnitIndex(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, Beyond.PoolCore.PooledList<System.Int32>& unitIndex)
  System.Boolean FillRectTargets(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, System.ValueTuple<System.UInt32,System.Int32>[,]& rectTargets)
  System.Void DrawDebug(System.Single groundY)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ILogisticSample
TYPE:  interface
TOKEN: 0x20000B1
FIELDS:
METHODS:
  System.Boolean Sample(Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Mathematics.float2 p, System.UInt32& unitId, System.Int32& indexInLogistic)
  System.Boolean IsInRect(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax)
  System.Boolean GetInRectUnitIndex(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, Beyond.PoolCore.PooledList<System.Int32>& unitIndex)
  System.Boolean FillRectTargets(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, System.ValueTuple<System.UInt32,System.Int32>[,]& rectTargets)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorLogisticsUnitFragment
TYPE:  struct
TOKEN: 0x20000B2
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorRenderFragment
TYPE:  struct
TOKEN: 0x20000B3
FIELDS:
  public            System.Int32                    unitConfigAssetInstanceId  // 0x10
  public            System.Int32                    indexInConveyor  // 0x14
  public            UnityEngine.HyperGryph.HGFactoryEntityTransformDatatransformData  // 0x18
  public            Unity.Mathematics.float3        position  // 0x18
  public            System.Single                   scale  // 0x24
  public            Unity.Mathematics.quaternion    rotation  // 0x28
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorRenderLeftFragment
TYPE:  struct
TOKEN: 0x20000B4
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorRenderRightFragment
TYPE:  struct
TOKEN: 0x20000B5
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorRenderMidFragment
TYPE:  struct
TOKEN: 0x20000B6
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.CullResultFragment
TYPE:  struct
TOKEN: 0x20000B7
FIELDS:
  public            System.Boolean                  culled  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.DebugFragment
TYPE:  struct
TOKEN: 0x20000B8
FIELDS:
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.EvtDestroyUnit
TYPE:  struct
TOKEN: 0x20000B9
FIELDS:
  public            System.Int64                    targetDestroyTime  // 0x10
  public            System.Int64                    checkedTime  // 0x18
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Boolean get_timeout()
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.DisabledTag
TYPE:  struct
TOKEN: 0x20000BA
FIELDS:
  public    static  System.Int32                    WORD_BITS  // 0x0
  public    static  System.Int32                    WORD_BITS_LOG2  // 0x0
  public    static  System.Int32                    WORD_MASK  // 0x0
  public            Beyond.Gameplay.Factory.DisabledTag.<disableMaskWords>e__FixedBufferdisableMaskWords  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Boolean ContainsComponentId(System.Int32 componentId)
  System.Void And(System.Int32 componentId)
  System.Void Or(System.Int32 componentId)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ShowStateUI
TYPE:  struct
TOKEN: 0x20000BC
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ShowNameUI
TYPE:  struct
TOKEN: 0x20000BD
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.HasRenderer
TYPE:  struct
TOKEN: 0x20000BE
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.EvtUpdatePipeEffect
TYPE:  struct
TOKEN: 0x20000BF
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityevtEntity  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  UnityEngine.HyperGryph.ECS.Entity get_eventEntity()
  System.Void set_eventEntity(UnityEngine.HyperGryph.ECS.Entity value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.EvtChangeTemplate
TYPE:  struct
TOKEN: 0x20000C0
FIELDS:
  public            System.Boolean                  playBuildEffect  // 0x10
  public            System.Single                   playBuildEffectDuration  // 0x14
  public            System.Boolean                  updatePedestal  // 0x18
  public            System.Boolean                  updateBuilding  // 0x19
  public            Unity.Collections.FixedString32BytesnewTemplate  // 0x1A
  public            UnityEngine.HyperGryph.ECS.EntityevtEntity  // 0x3C
  public    static  System.Int32                    ID  // 0x0
METHODS:
  UnityEngine.HyperGryph.ECS.Entity get_eventEntity()
  System.Void set_eventEntity(UnityEngine.HyperGryph.ECS.Entity value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.EvtCreateUnitRenderer
TYPE:  struct
TOKEN: 0x20000C1
FIELDS:
  public            System.UInt64                   evtEntityId  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityevtEntity  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  UnityEngine.HyperGryph.ECS.Entity get_eventEntity()
  System.Void set_eventEntity(UnityEngine.HyperGryph.ECS.Entity value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.EvtUpdateStatusEffect
TYPE:  struct
TOKEN: 0x20000C2
FIELDS:
  public            System.UInt64                   evtEntityId  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityevtEntity  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  UnityEngine.HyperGryph.ECS.Entity get_eventEntity()
  System.Void set_eventEntity(UnityEngine.HyperGryph.ECS.Entity value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.EvtPendingCreateRenderer
TYPE:  struct
TOKEN: 0x20000C3
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityevtEntity  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  UnityEngine.HyperGryph.ECS.Entity get_eventEntity()
  System.Void set_eventEntity(UnityEngine.HyperGryph.ECS.Entity value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.EvtUpdateRendererProperty
TYPE:  struct
TOKEN: 0x20000C4
FIELDS:
  public            System.Boolean                  evtColliderToggle  // 0x10
  public            System.Boolean                  colliderToggle  // 0x11
  public            System.Boolean                  evtVisible  // 0x12
  public            System.Boolean                  visible  // 0x13
  public            System.Boolean                  additiveVisible  // 0x14
  public            UnityEngine.HyperGryph.ECS.EntityevtEntity  // 0x18
  public    static  System.Int32                    ID  // 0x0
METHODS:
  UnityEngine.HyperGryph.ECS.Entity get_eventEntity()
  System.Void set_eventEntity(UnityEngine.HyperGryph.ECS.Entity value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.EvtStatusChange
TYPE:  struct
TOKEN: 0x20000C5
FIELDS:
  public            System.Boolean                  forceUpdate  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityevtEntity  // 0x14
  public    static  System.Int32                    ID  // 0x0
METHODS:
  UnityEngine.HyperGryph.ECS.Entity get_eventEntity()
  System.Void set_eventEntity(UnityEngine.HyperGryph.ECS.Entity value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.EvtCreateInteract
TYPE:  struct
TOKEN: 0x20000C6
FIELDS:
  public            System.UInt64                   interactObjectId  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityevtEntity  // 0x18
  public            System.UInt64                   evtEntityId  // 0x18
  public    static  System.Int32                    ID  // 0x0
METHODS:
  UnityEngine.HyperGryph.ECS.Entity get_eventEntity()
  System.Void set_eventEntity(UnityEngine.HyperGryph.ECS.Entity value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.EvtVatUpdate
TYPE:  struct
TOKEN: 0x20000C7
FIELDS:
  public            System.UInt64                   evtEntityId  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityevtEntity  // 0x10
  public            System.Byte                     placeHolder  // 0x18
  public    static  System.Int32                    ID  // 0x0
METHODS:
  UnityEngine.HyperGryph.ECS.Entity get_eventEntity()
  System.Void set_eventEntity(UnityEngine.HyperGryph.ECS.Entity value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.EvtUpdatePedestalColorLUT
TYPE:  struct
TOKEN: 0x20000C8
FIELDS:
  public            System.Boolean                  light  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityevtEntity  // 0x14
  public    static  System.Int32                    ID  // 0x0
METHODS:
  UnityEngine.HyperGryph.ECS.Entity get_eventEntity()
  System.Void set_eventEntity(UnityEngine.HyperGryph.ECS.Entity value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.EvtAudioType
TYPE:  struct
TOKEN: 0x20000C9
FIELDS:
  public            System.Int16                    value__  // 0x10
  public    static  Beyond.Gameplay.Factory.EvtAudioTypeBUILDING_STATUS  // 0x0
  public    static  Beyond.Gameplay.Factory.EvtAudioTypeBUILDING_DESTROY  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.AudioCullingState
TYPE:  struct
TOKEN: 0x20000CA
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.Factory.AudioCullingStateAUDIBLE  // 0x0
  public    static  Beyond.Gameplay.Factory.AudioCullingStatePENDING_CULL  // 0x0
  public    static  Beyond.Gameplay.Factory.AudioCullingStateCULLED  // 0x0
  public    static  Beyond.Gameplay.Factory.AudioCullingStatePENDING_RESTORE  // 0x0
  public    static  Beyond.Gameplay.Factory.AudioCullingStateAUDIBLE_CUR_FRAME  // 0x0
  public    static  Beyond.Gameplay.Factory.AudioCullingStateCULLED_CUR_FRAME  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.AudioDebugGizmosType
TYPE:  struct
TOKEN: 0x20000CB
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.Factory.AudioDebugGizmosTypeNONE  // 0x0
  public    static  Beyond.Gameplay.Factory.AudioDebugGizmosTypeGROUP_EMITTER_AREA1  // 0x0
  public    static  Beyond.Gameplay.Factory.AudioDebugGizmosTypeGROUP_EMITTER_AREA2  // 0x0
  public    static  Beyond.Gameplay.Factory.AudioDebugGizmosTypeGROUP_EMITTER_AREA3  // 0x0
  public    static  Beyond.Gameplay.Factory.AudioDebugGizmosTypeGROUP_EMITTER_OUT_OF_RANGE  // 0x0
  public    static  Beyond.Gameplay.Factory.AudioDebugGizmosTypeGROUP_EMITTER_NOT_CONSIDERED_TYPE  // 0x0
  public    static  Beyond.Gameplay.Factory.AudioDebugGizmosTypeGROUP_EMITTER_NOT_CONSIDERED_STATUS  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.EvtAudio
TYPE:  struct
TOKEN: 0x20000CC
FIELDS:
  public            System.UInt64                   evtEntityId  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityevtEntity  // 0x10
  public            Beyond.Gameplay.Factory.EvtAudioTypeevtType  // 0x18
  public    static  System.Int32                    ID  // 0x0
METHODS:
  UnityEngine.HyperGryph.ECS.Entity get_eventEntity()
  System.Void set_eventEntity(UnityEngine.HyperGryph.ECS.Entity value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.AudioFragment
TYPE:  struct
TOKEN: 0x20000CD
FIELDS:
  public            System.UInt32                   audioFragmentId  // 0x10
  public            System.Single                   distSqToListener  // 0x14
  public            Beyond.Gameplay.Factory.AudioCullingStatecullingState  // 0x18
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ReleaseTagFragment
TYPE:  struct
TOKEN: 0x20000CE
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.CurMapUnitTag
TYPE:  struct
TOKEN: 0x20000CF
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.StaticMountOffset
TYPE:  struct
TOKEN: 0x20000D0
FIELDS:
  public            System.Boolean                  outputPosValid  // 0x10
  public            Unity.Mathematics.float4x4      outputPos  // 0x14
  public            System.Boolean                  nameUIPosValid  // 0x54
  public            Unity.Mathematics.float4x4      nameUIPos  // 0x58
  public            Unity.Mathematics.bool4         statusPosValid  // 0x98
  public            Unity.Mathematics.float4x4      statusPos0  // 0x9C
  public            Unity.Mathematics.float4x4      statusPos1  // 0xDC
  public            Unity.Mathematics.float4x4      statusPos2  // 0x11C
  public            Unity.Mathematics.float4x4      statusPos3  // 0x15C
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitFragment
TYPE:  struct
TOKEN: 0x20000D1
FIELDS:
  public            System.UInt32                   nodeId  // 0x10
  public            System.Int32                    level  // 0x14
  public            System.Int32                    nodeType  // 0x18
  public            System.Boolean                  inPower  // 0x1C
  public            System.Int64                    powerCost  // 0x20
  public            System.Boolean                  inBlock  // 0x28
  public            System.Boolean                  isActive  // 0x29
  public            Unity.Mathematics.bool2         buildDismissEffectEnabled  // 0x2A
  public            System.UInt32                   flag  // 0x2C
  public            System.Boolean                  formulaManMode  // 0x30
  public            System.Int32                    rvoObstacleId  // 0x34
  public            System.Int32                    navObstacleId  // 0x38
  public            System.Int32                    navSourceId  // 0x3C
  public            System.Int32                    nameInstanceId  // 0x40
  public            System.Int32                    templateIdFastString  // 0x44
  public            System.Int32                    rendererTemplateIdFastString  // 0x48
  public            System.Int32                    instKeyFastString  // 0x4C
  public            Beyond.Gameplay.Factory.StaticMountOffsetstaticMountOffset  // 0x50
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Boolean get_needRepair()
  System.Boolean get_battleBroken()
  System.Boolean get_socialUnit()
  System.String get_templateId()
  System.Void set_templateId(System.String value)
  System.String get_rendererTemplateId()
  System.Void set_rendererTemplateId(System.String value)
  System.String get_instKey()
  System.Void set_instKey(System.String value)
  Beyond.Gameplay.Factory.UnitFragment Create(System.UInt32 nodeId, System.String templateId, System.Int32 nodeType, Unity.Mathematics.bool2 buildDismissEnabled, System.Int32 level, System.UInt32 nodeFlag, System.String rendererTemplateId, System.Boolean inBlock, System.Boolean inPower, System.Boolean inActive, System.Int64 powerCost, System.Boolean formulaManMode, System.String instKey)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitRenderPipeLogisticsFigureReplaceFragment
TYPE:  struct
TOKEN: 0x20000D2
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.BusRenderFragment
TYPE:  struct
TOKEN: 0x20000D3
FIELDS:
  public            System.Int32                    idx  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitRenderBuildingFragment
TYPE:  struct
TOKEN: 0x20000D4
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitRenderPedestalFragment
TYPE:  struct
TOKEN: 0x20000D5
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitRendererRegularFragment
TYPE:  struct
TOKEN: 0x20000D6
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitOnlyRendererFragment
TYPE:  struct
TOKEN: 0x20000D7
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FakeUnitFragment
TYPE:  struct
TOKEN: 0x20000D8
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UIUnitFragment
TYPE:  struct
TOKEN: 0x20000D9
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.GuideHintFragment
TYPE:  struct
TOKEN: 0x20000DA
FIELDS:
  public            System.Int32                    hashKey  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitPreviewFragment
TYPE:  struct
TOKEN: 0x20000DB
FIELDS:
  public            System.Int32                    previewTemplateIdFastId  // 0x10
  public            System.Boolean                  formulaManMode  // 0x14
  public            System.Int32                    nodeType  // 0x18
  public            Beyond.Gameplay.Factory.UnitPreviewFragment.EntityTargetentityTarget  // 0x1C
  public            Beyond.Gameplay.Factory.UnitPreviewFragment.EntityTypeentityType  // 0x20
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.String get_previewTemplateId()
  System.Void set_previewTemplateId(System.String value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorRegularFragment
TYPE:  struct
TOKEN: 0x20000DE
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorGuideFragment
TYPE:  struct
TOKEN: 0x20000DF
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeRegularFragment
TYPE:  struct
TOKEN: 0x20000E0
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorPreviewRendererFragment
TYPE:  struct
TOKEN: 0x20000E1
FIELDS:
  public            System.Boolean                  valid  // 0x10
  public            Beyond.Gameplay.Factory.UnitPreviewFragment.EntityTypeentityType  // 0x14
  public            System.Int32                    length  // 0x18
  public            System.UInt32                   startMemoryOffsetHandle  // 0x1C
  public            System.UInt32                   endMemoryOffsetHandle  // 0x20
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipePreviewRendererFragment
TYPE:  struct
TOKEN: 0x20000E2
FIELDS:
  public            System.Boolean                  valid  // 0x10
  public            System.Single                   pipeHeight  // 0x14
  public            System.Single                   gridPathHeightStart  // 0x18
  public            System.Single                   gridPathHeightEnd  // 0x1C
  public            System.Int32                    length  // 0x20
  public            System.UInt32                   startMemoryOffsetHandle  // 0x24
  public            System.UInt32                   endMemoryOffsetHandle  // 0x28
  public            System.Boolean                  trackValid  // 0x2C
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipePreviewFragment
TYPE:  struct
TOKEN: 0x20000E3
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FigureRenderFragment
TYPE:  struct
TOKEN: 0x20000E4
FIELDS:
  public            System.Int32                    unitConfigAssetInstanceId  // 0x10
  public            Unity.Mathematics.float3        position  // 0x14
  public            Unity.Mathematics.quaternion    rotation  // 0x20
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FigureRenderLeftFragment
TYPE:  struct
TOKEN: 0x20000E5
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FigureRenderRightFragment
TYPE:  struct
TOKEN: 0x20000E6
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FigureRenderMidFragment
TYPE:  struct
TOKEN: 0x20000E7
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FigureRenderPipeHolderFragment
TYPE:  struct
TOKEN: 0x20000E8
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FluidConsumeFragment
TYPE:  struct
TOKEN: 0x20000E9
FIELDS:
  public            System.Int64                    progress  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FluidContainerFragment
TYPE:  struct
TOKEN: 0x20000EA
FIELDS:
  public            System.Int32                    itemId0  // 0x10
  public            System.Int32                    itemId1  // 0x14
  public            System.Int32                    itemId2  // 0x18
  public            System.Int32                    itemId3  // 0x1C
  public            System.Int32                    itemId4  // 0x20
  public            System.Int32                    itemId5  // 0x24
  public            System.Int32                    itemId6  // 0x28
  public            System.Int32                    itemId7  // 0x2C
  public            Unity.Mathematics.int2x4        itemAmount  // 0x30
  public            System.Int32                    itemAmount_0  // 0x30
  public            System.Int32                    itemAmount_1  // 0x40
  public            System.Int32                    itemAmount0  // 0x30
  public            System.Int32                    itemAmount1  // 0x34
  public            System.Int32                    itemAmount2  // 0x38
  public            System.Int32                    itemAmount3  // 0x3C
  public            System.Int32                    itemAmount4  // 0x40
  public            System.Int32                    itemAmount5  // 0x44
  public            System.Int32                    itemAmount6  // 0x48
  public            System.Int32                    itemAmount7  // 0x4C
  public            Unity.Mathematics.float2x4      renderItemAmount  // 0x50
  public            Unity.Mathematics.float4        renderItemAmount_0  // 0x50
  public            Unity.Mathematics.float4        renderItemAmount_1  // 0x60
  public            System.Single                   renderItemAmount0  // 0x50
  public            System.Single                   renderItemAmount1  // 0x54
  public            System.Single                   renderItemAmount2  // 0x58
  public            System.Single                   renderItemAmount3  // 0x5C
  public            System.Single                   renderItemAmount4  // 0x60
  public            System.Single                   renderItemAmount5  // 0x64
  public            System.Single                   renderItemAmount6  // 0x68
  public            System.Single                   renderItemAmount7  // 0x6C
  public            System.Int32                    itemSubType0  // 0x70
  public            System.Int32                    itemSubType1  // 0x74
  public            System.Int32                    itemSubType2  // 0x78
  public            System.Int32                    itemSubType3  // 0x7C
  public            System.Int32                    itemSubType4  // 0x80
  public            System.Int32                    itemSubType5  // 0x84
  public            System.Int32                    itemSubType6  // 0x88
  public            System.Int32                    itemSubType7  // 0x8C
  public            Unity.Mathematics.float2x4      capacity  // 0x90
  public            System.Int32                    capacity0  // 0x90
  public            System.Int32                    capacity1  // 0x94
  public            System.Int32                    capacity2  // 0x98
  public            System.Int32                    capacity3  // 0x9C
  public            System.Int32                    capacity4  // 0xA0
  public            System.Int32                    capacity5  // 0xA4
  public            System.Int32                    capacity6  // 0xA8
  public            System.Int32                    capacity7  // 0xAC
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Void Set(System.Int32 index, System.Int32 itemId, System.Int32 itemAmount, System.Int32 itemSubType, System.Int32 capacity)
  System.Void SetAmount(System.Int32 index, System.Int32 amount)
  System.Boolean Get(System.Int32 index, System.Int32& itemId, System.Int32& itemAmount, System.Single& renderItemAmount, System.Int32& itemSubType, System.Int32& cap)
  System.Boolean HasLiquid()
  System.Void CalcRenderItemAmount(System.Single step)
  System.ValueTuple<System.Int32,System.UInt32> GetOffsetData()
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FluidPumpInFragment
TYPE:  struct
TOKEN: 0x20000EB
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FluidPumpOutFragment
TYPE:  struct
TOKEN: 0x20000EC
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FluidReactionFragment
TYPE:  struct
TOKEN: 0x20000ED
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FluidSprayFragment
TYPE:  struct
TOKEN: 0x20000EE
FIELDS:
  public            System.Int64                    progress  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FormulaManualFragment
TYPE:  struct
TOKEN: 0x20000EF
FIELDS:
  public            System.Int32                    currentGroup  // 0x10
  public            System.Int32                    currentMode  // 0x14
  public            System.Int32                    lockedFormulaId  // 0x18
  public            System.Boolean                  formulaManMode  // 0x1C
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.EvtLogisticFigureRenderer
TYPE:  struct
TOKEN: 0x20000F0
FIELDS:
  public            System.Boolean                  triggered  // 0x10
  public            System.Int32                    figureType  // 0x14
  public    static readonly System.Byte                     S_NONE  // 0x0
  public    static readonly System.Byte                     S_PIPE  // 0x1
  public    static readonly System.Byte                     S_CONVEYOR  // 0x2
  public    static readonly System.Byte                     S_CONVEYOR_GUIDE  // 0x3
METHODS:
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.OutOfBufferWarning
TYPE:  struct
TOKEN: 0x20000F1
FIELDS:
  public            System.Boolean                  pipe  // 0x10
  public            System.Boolean                  wire  // 0x11
  public            System.Boolean                  conveyor  // 0x12
  public            System.Boolean                  cargo  // 0x13
  public            System.Boolean                  operated  // 0x14
METHODS:
  System.Void ResetFlags()
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Gameplay.Factory.GlobalEnv
TYPE:  struct
TOKEN: 0x20000F2
FIELDS:
  public            Beyond.Gameplay.Factory.OutOfBufferWarningoutOfBufferWarning  // 0x10
  public            System.Boolean                  teardown  // 0x15
  public            System.Boolean                  isSquadInFight  // 0x16
  public            System.Boolean                  isTowerDefence  // 0x17
  public            System.Boolean                  shipMode  // 0x18
  public            Unity.Mathematics.float3        playerPosition  // 0x1C
  public            Unity.Mathematics.float3        playerForward  // 0x28
  public            Unity.Mathematics.float3        playerRight  // 0x34
  public            Unity.Mathematics.float3        cameraPosition  // 0x40
  public            UnityEngine.HyperGryph.ECS.EntitycurrentScopeEntity  // 0x4C
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDeferunitPreviewQueryResult  // 0x58
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefercargoPredictQueryResult  // 0x70
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDeferlookAtQueryResult  // 0x88
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDeferpipeThicknessQueryResult  // 0xA0
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDeferl2wQueryResult  // 0xB8
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDeferunitRendererQueryResult  // 0xD0
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDeferliquidRendererQueryResult  // 0xE8
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDeferpumpRendererQueryResult  // 0x100
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDeferadditiveEffectQueryResult  // 0x118
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDeferhintEffectQueryResult  // 0x130
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDeferadditiveEffectRendererQueryResult  // 0x148
  public            Unity.Jobs.JobHandle            baseTickChainJobHandle  // 0x160
  public            Unity.Jobs.JobHandle            crossFrameJobHandle  // 0x170
  public            Unity.Jobs.JobHandle            cullingJobHandle  // 0x180
  public            Unity.Jobs.JobHandle            l2wJobHandle  // 0x190
  public            Unity.Jobs.JobHandle            cargoPredictJobHandle  // 0x1A0
  public            Unity.Jobs.JobHandle            cargoRenderJobHandle  // 0x1B0
  public            Unity.Jobs.JobHandle            lookAtJobHandle  // 0x1C0
  public            Unity.Jobs.JobHandle            conveyorFigureRenderJobHandle  // 0x1D0
  public            Unity.Jobs.JobHandle            portArrowRenderJobHandle  // 0x1E0
  public            Unity.Jobs.JobHandle            portConveyorInsideRenderJobHandle  // 0x1F0
  public            System.Int64                    anyTransChangedFrame  // 0x200
  public            System.Boolean                  evtLevelLoadStatus  // 0x208
  public            System.Boolean                  evtTopViewChanged  // 0x209
  public            System.Boolean                  evtPipeDirty  // 0x20A
  public            System.Boolean                  evtOutputDirty  // 0x20B
  public            System.Boolean                  evtForceUpdatePreviewPortRenderer  // 0x20C
  public            System.Boolean                  firstEnterGameScene  // 0x20D
  public            Beyond.Gameplay.Factory.EvtLogisticFigureRendererevtLogisticFigureRenderer  // 0x210
  public            System.Boolean                  systemUnlockedPipe  // 0x218
  public            System.Boolean                  systemUnlockedConveyor  // 0x219
  public            System.Boolean                  useDistanceFilter  // 0x21A
  public            Unity.Mathematics.float2        distanceFilterCenterPos  // 0x21C
  public            System.Single                   distanceThreshold  // 0x224
  public            Unity.Mathematics.float4x4      arrowUV  // 0x228
  public            Unity.Mathematics.float2        arrowOffset  // 0x268
  public            System.Single                   conveyorOffsetY  // 0x270
  public            System.Boolean                  UIBuildingAnimationEnabled  // 0x274
  public            System.Boolean                  vatEnableEnvDirty  // 0x275
  public            System.Boolean                  buildingNameInvalid  // 0x276
  public            System.Boolean                  topViewEnable  // 0x277
  public            System.Boolean                  showOutputUI  // 0x278
  public            System.Boolean                  inBuildMode  // 0x279
  public            System.Boolean                  buildConveyor  // 0x27A
  public            System.Boolean                  buildPipe  // 0x27B
  public            System.Boolean                  simpleConveyor  // 0x27C
  public            System.Boolean                  simplePipe  // 0x27D
  public            System.Boolean                  inputDisable  // 0x27E
  public            System.Boolean                  outputDisable  // 0x27F
  public            System.Boolean                  inputFluidDisable  // 0x280
  public            System.Boolean                  outputFluidDisable  // 0x281
  public            Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfoWrap*interactBuilding  // 0x288
  public            Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo*conveyorInfo  // 0x290
  public            Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo*pipeInfo  // 0x298
  public            Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfoWrap*interactBuildingLast  // 0x2A0
  public            Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo*conveyorInfoLast  // 0x2A8
  public            Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo*pipeInfoLast  // 0x2B0
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>*portBlockPosListPtr  // 0x2B8
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList<Beyond.Gameplay.Factory.OutputRendererInfo>*outputUIPosListPtr  // 0x2C0
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>*buildingStatePosListPtr  // 0x2C8
  public            Beyond.Gameplay.Factory.CargoRendererInfoCollection<Beyond.Gameplay.Factory.CargoRendererInfo>*cargoMatricesBufferWriter  // 0x2D0
  public            Beyond.Gameplay.Factory.CargoRendererInfoCollection<Beyond.Gameplay.Factory.CargoRendererInfo>*cargoMatricesBufferReader  // 0x2D8
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*conveyorLPosMatricesBufferWriter  // 0x2E0
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*conveyorMPosMatricesBufferWriter  // 0x2E8
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*conveyorRPosMatricesBufferWriter  // 0x2F0
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*conveyorLPosMatricesBufferReader  // 0x2F8
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*conveyorMPosMatricesBufferReader  // 0x300
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*conveyorRPosMatricesBufferReader  // 0x308
  public            System.Boolean                  bConflictCheck  // 0x310
  public            System.IntPtr                   arrowPlacedDicPtr  // 0x318
  public            Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<Beyond.Gameplay.Factory.PortArrowRendererInfo>*portArrowMatricesWriter  // 0x320
  public            Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<Beyond.Gameplay.Factory.PortArrowRendererInfo>*portArrowMatricesReader  // 0x328
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*conveyorPreviewLPosMatricesWriter  // 0x330
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*conveyorPreviewMPosMatricesWriter  // 0x338
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*conveyorPreviewRPosMatricesWriter  // 0x340
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*conveyorPreviewLPosMatricesReader  // 0x348
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*conveyorPreviewMPosMatricesReader  // 0x350
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*conveyorPreviewRPosMatricesReader  // 0x358
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>*conveyorInsideMatricesPtr  // 0x360
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*guideFigureLPosMatricesBufferWriter  // 0x368
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*guideFigureMPosMatricesBufferWriter  // 0x370
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*guideFigureRPosMatricesBufferWriter  // 0x378
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*guideFigureLPosMatricesBufferReader  // 0x380
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*guideFigureMPosMatricesBufferReader  // 0x388
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*guideFigureRPosMatricesBufferReader  // 0x390
  public            Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>*pipeLPosMatricesBufferWriter  // 0x398
  public            Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>*pipeMPosMatricesBufferWriter  // 0x3A0
  public            Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>*pipeRPosMatricesBufferWriter  // 0x3A8
  public            Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>*pipeLPosMatricesBufferReader  // 0x3B0
  public            Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>*pipeMPosMatricesBufferReader  // 0x3B8
  public            Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>*pipeRPosMatricesBufferReader  // 0x3C0
  public            Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>*pipeTrackLPosMatricesBufferWriter  // 0x3C8
  public            Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>*pipeTrackMPosMatricesBufferWriter  // 0x3D0
  public            Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>*pipeTrackRPosMatricesBufferWriter  // 0x3D8
  public            Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>*pipeTrackLPosMatricesBufferReader  // 0x3E0
  public            Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>*pipeTrackMPosMatricesBufferReader  // 0x3E8
  public            Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>*pipeTrackRPosMatricesBufferReader  // 0x3F0
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.Matrix4x4>*pipeHolderPosMatricesPtr  // 0x3F8
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>*comPosMatricesPtr  // 0x400
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*wireNormalBufferWriter  // 0x408
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*wireHsNormalBufferWriter  // 0x410
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*wireDisableBufferWriter  // 0x418
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*wireStrengthenBufferWriter  // 0x420
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*wireHsStrengthenBufferWriter  // 0x428
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*wireStrengthenDisableBufferWriter  // 0x430
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*wireNormalBufferReader  // 0x438
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*wireHsNormalBufferReader  // 0x440
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*wireDisableBufferReader  // 0x448
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*wireStrengthenBufferReader  // 0x450
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*wireHsStrengthenBufferReader  // 0x458
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*wireStrengthenDisableBufferReader  // 0x460
  public            System.Boolean                  levelShowForceUpdate  // 0x468
  public            System.Boolean                  conveyorEffectDirty  // 0x469
  public            System.Boolean                  pipeEffectDirty  // 0x46A
  public            Beyond.Gameplay.Factory.ConveyorInfoAllocator*conveyorInfoAllocator  // 0x470
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest>*animatorParamRequestQueue  // 0x478
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATFSMAudioData>*animatorAudioQueue  // 0x480
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Void CreateQueryResult()
  System.Void DisposeQueryResult()
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4> get_portBlockPosListReader()
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Beyond.Gameplay.Factory.OutputRendererInfo> get_outputUIPosListReader()
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4> get_buildingStatePosListReader()
  System.IntPtr get_cargoMatricesBufferIntPtrReader()
  System.Int32 get_cargoRendererCount()
  System.Void SwapCargoBuffer()
  System.Boolean get_cargoDirty()
  System.IntPtr get_conveyorLPosMatricesBufferIntPtrReader()
  System.IntPtr get_conveyorMPosMatricesBufferIntPtrReader()
  System.IntPtr get_conveyorRPosMatricesBufferIntPtrReader()
  System.Int32 get_lConveyorRenderCount()
  System.Int32 get_mConveyorRenderCount()
  System.Int32 get_rConveyorRenderCount()
  System.Void SetConveyorBuffers(System.Void* lBuffer0, System.Void* lBuffer1, System.Void* mBuffer0, System.Void* mBuffer1, System.Void* rBuffer0, System.Void* rBuffer1)
  System.Void SwapConveyorBuffer()
  System.Boolean get_conveyorDirty()
  System.IntPtr get_portArrowMatricesIntPtrReader()
  System.Int32 get_portArrowRenderCount()
  System.Void SetPortArrowBuffers(System.Void* buffer0, System.Void* buffer1)
  System.Void SwapPortArrowBuffer()
  System.Boolean get_portArrowDirty()
  System.IntPtr get_conveyorPreviewLPosMatricesIntPtrReader()
  System.IntPtr get_conveyorPreviewMPosMatricesIntPtrReader()
  System.IntPtr get_conveyorPreviewRPosMatricesIntPtrReader()
  System.Int32 get_lConveyorPreviewRenderCount()
  System.Int32 get_mConveyorPreviewRenderCount()
  System.Int32 get_rConveyorPreviewRenderCount()
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4> get_conveyorInsideMatricesReader()
  System.Void SetPreviewConveyorBuffers(System.Void* lBuffer0, System.Void* lBuffer1, System.Void* mBuffer0, System.Void* mBuffer1, System.Void* rBuffer0, System.Void* rBuffer1)
  System.Void SwapPreviewConveyorBuffer()
  System.Boolean get_previewConveyorDirty()
  System.IntPtr get_guideFigureLPosMatricesBufferIntPtrReader()
  System.IntPtr get_guideFigureMPosMatricesBufferIntPtrReader()
  System.IntPtr get_guideFigureRPosMatricesBufferIntPtrReader()
  System.Int32 get_lGuideFigureRenderCount()
  System.Int32 get_mGuideFigureRenderCount()
  System.Int32 get_rGuideFigureRenderCount()
  System.Void SeGuideFigureBuffers(System.Void* lBuffer0, System.Void* lBuffer1, System.Void* mBuffer0, System.Void* mBuffer1, System.Void* rBuffer0, System.Void* rBuffer1)
  System.Void SwapGuideFigureBuffer()
  System.Boolean get_guideFigureDirty()
  System.IntPtr get_pipeLPosMatricesBufferIntPtrReader()
  System.IntPtr get_pipeMPosMatricesBufferIntPtrReader()
  System.IntPtr get_pipeRPosMatricesBufferIntPtrReader()
  System.Int32 get_lPipeRenderCount()
  System.Int32 get_mPipeRenderCount()
  System.Int32 get_rPipeRenderCount()
  System.IntPtr get_pipeTrackLPosMatricesBufferIntPtrReader()
  System.IntPtr get_pipeTrackMPosMatricesBufferIntPtrReader()
  System.IntPtr get_pipeTrackRPosMatricesBufferIntPtrReader()
  System.Int32 get_lPipeTrackRenderCount()
  System.Int32 get_mPipeTrackRenderCount()
  System.Int32 get_rPipeTrackRenderCount()
  System.Void SetPipeBuffers(System.Void* lBuffer0, System.Void* lBuffer1, System.Void* mBuffer0, System.Void* mBuffer1, System.Void* rBuffer0, System.Void* rBuffer1, System.Void* trackLBuffer0, System.Void* trackLBuffer1, System.Void* trackMBuffer0, System.Void* trackMBuffer1, System.Void* trackRBuffer0, System.Void* trackRBuffer1)
  System.Void SwapPipeBuffer()
  System.Boolean get_pipeDirty()
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<UnityEngine.Matrix4x4> get_pipeHolderPosMatricesReader()
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4> get_comPosMatricesReader()
  System.IntPtr get_wireNormalBufferIntPtrReader()
  System.IntPtr get_wireHsNormalBufferIntPtrReader()
  System.IntPtr get_wireDisableBufferIntPtrReader()
  System.IntPtr get_wireStrengthenBufferIntPtrReader()
  System.IntPtr get_wireHsStrengthenBufferIntPtrReader()
  System.IntPtr get_wireStrengthenDisableBufferIntPtrReader()
  System.Int32 get_wireNormalRendererCount()
  System.Int32 get_wireHsNormalRendererCount()
  System.Int32 get_wireDisableRendererCount()
  System.Int32 get_wireStrengthenRendererCount()
  System.Int32 get_wireHsStrengthenRendererCount()
  System.Int32 get_wireStrengthenDisableRendererCount()
  System.Void SetWireBuffer(System.Void* normal0, System.Void* normal1, System.Void* hsNormal0, System.Void* hsNormal1, System.Void* disable0, System.Void* disable1, System.Void* strengthen0, System.Void* strengthen1, System.Void* hsStrengthen0, System.Void* hsStrengthen1, System.Void* strengthenDisable0, System.Void* strengthenDisable1)
  System.Void SwapWireBuffer()
  System.Boolean get_wireNormalDirty()
  System.Boolean get_wireHsNormalDirty()
  System.Boolean get_wireDisableDirty()
  System.Boolean get_wireStrengthenDirty()
  System.Boolean get_wireHsStrengthenDirty()
  System.Boolean get_wireStrengthenDisableDirty()
  System.Void GetConveyorRendererInfo(System.UInt32 memoryStartOffset, System.Int32 countIdx, Beyond.Gameplay.Factory.ConveyorInfoAllocator.Info*& info)
  Beyond.Gameplay.Factory.ConveyorInfoAllocator.Info& GetConveyorRendererInfo(System.UInt32 memoryStartOffset, System.Int32 countIdx)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation AllocateConveyorInfo(System.Int32 count)
  System.Int64 CalculateConveyorInfoSize(System.UInt32 memoryOffset)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation ResizeConveyorInfo(System.UInt32 startIndex, System.Int32 count)
  System.Void FreeConveyorInfo(System.UInt32 startIndex)
  System.Void DebugAllocatorPrint()
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest> get_animatorParamRequestQueueReader()
  System.Void AddSetAnimatorParamRequest(UnityEngine.HyperGryph.ECS.Entity logicEntity, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest rq)
  System.Void _AddAnimatorParamRequest(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity renderEntity, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest& rq)
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATFSMAudioData> get_animatorAudioQueueWriter()
  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATFSMAudioData& GetAudioVATDataAt(System.Int32 index)
  System.Int32 GetAudioVATDataLength()
  System.Void ClearAudioVATData()
  System.Void ResetFlags()
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.HealthPoleFragment
TYPE:  struct
TOKEN: 0x20000F3
FIELDS:
  public            System.Int64                    currentProgress  // 0x10
  public            System.Int32                    currentPoint  // 0x18
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.InventoryFragment
TYPE:  struct
TOKEN: 0x20000F4
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.IPositionFragment
TYPE:  interface
TOKEN: 0x20000F5
FIELDS:
METHODS:
  Unity.Mathematics.float3 get_Position()
END_CLASS

CLASS: Beyond.Gameplay.Factory.IReactiveComponent
TYPE:  interface
TOKEN: 0x20000F6
FIELDS:
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.INotificationComponent
TYPE:  interface
TOKEN: 0x20000F7
FIELDS:
METHODS:
  UnityEngine.HyperGryph.ECS.Entity get_eventEntity()
  System.Void set_eventEntity(UnityEngine.HyperGryph.ECS.Entity value)
END_CLASS

CLASS: Beyond.Gameplay.Factory.IRotateFragment
TYPE:  interface
TOKEN: 0x20000F8
FIELDS:
METHODS:
  Unity.Mathematics.float3 get_Rotation()
  Unity.Mathematics.quaternion get_RotationQuaternion()
END_CLASS

CLASS: Beyond.Gameplay.Factory.IUnitConfigRef
TYPE:  interface
TOKEN: 0x20000F9
FIELDS:
METHODS:
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
END_CLASS

CLASS: Beyond.Gameplay.Factory.LogisticEffectFragment
TYPE:  struct
TOKEN: 0x20000FA
FIELDS:
  public            Unity.Mathematics.bool4         portStatusBits  // 0x10
  public            System.Boolean                  port0  // 0x10
  public            System.Boolean                  port1  // 0x11
  public            System.Boolean                  port2  // 0x12
  public            System.Boolean                  port3  // 0x13
  public            Unity.Mathematics.bool4         portDirectionBits  // 0x14
  public            System.Boolean                  portDirection0  // 0x14
  public            System.Boolean                  portDirection1  // 0x15
  public            System.Boolean                  portDirection2  // 0x16
  public            System.Boolean                  portDirection3  // 0x17
  public            Unity.Mathematics.bool4         currentPortStatusBits  // 0x18
  public            System.Boolean                  currentPort0  // 0x18
  public            System.Boolean                  currentPort1  // 0x19
  public            System.Boolean                  currentPort2  // 0x1A
  public            System.Boolean                  currentPort3  // 0x1B
  public            Unity.Mathematics.float4        duration  // 0x1C
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.LogisticEntityBindFragment
TYPE:  struct
TOKEN: 0x20000FB
FIELDS:
  public            Beyond.Gameplay.Factory.EntityData256<UnityEngine.HyperGryph.ECS.Entity>cargoEntities  // 0x10
  public            System.UInt32                   conveyorExtHandle  // 0x818
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Void EnqueueCargoEntityImpl(UnityEngine.HyperGryph.ECS.Entity cargoEntity, System.UInt32 conveyorSharedDataIndex)
  System.Boolean DequeueCargoEntityImpl(UnityEngine.HyperGryph.ECS.Entity& cargoEntity)
  System.Void Arrive(Beyond.Gameplay.Factory.CargoFragment& cargo, Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt* conveyorExtData)
  System.Void Arrive(UnityEngine.HyperGryph.ECS.Entity cargoEntity, Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt* conveyorExtData)
  System.Int32 get_cargoCount()
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.MapGridRendererFragment
TYPE:  struct
TOKEN: 0x20000FC
FIELDS:
  private           System.Int32                    <unitAssetInstanceId>k__BackingField  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.OutputFragment
TYPE:  struct
TOKEN: 0x20000FD
FIELDS:
  public            Unity.Mathematics.int3          itemAll  // 0x10
  public            Unity.Mathematics.float4x3      rarityColorAll  // 0x1C
  public            Unity.Mathematics.float4x3      atlasRectAll  // 0x4C
  public            System.Byte                     enableLiquidIcon  // 0x7C
  public            Unity.Mathematics.float4x3      liquidAtlasUV  // 0x7D
  public    static readonly System.Int32                    MAX_OUTPUT  // 0x0
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Void Clean()
  System.Void set_Item(System.Int32 index, System.Int32 value)
  System.Int32 get_Item(System.Int32 index)
  Unity.Mathematics.float4& GetColor(System.Int32 index)
  System.Void SetColor(System.Int32 index, Unity.Mathematics.float4 color)
  System.Void SetColor(System.Int32 index, UnityEngine.Color color)
  System.Void SetAtlasRect(System.Int32 index, Unity.Mathematics.float4 rect)
  System.Void SetAtlasRect(System.Int32 index, UnityEngine.RectInt rect)
  Unity.Mathematics.float4& GetAtlasRect(System.Int32 index)
  System.Boolean GetEnableLiquidIcon(System.Int32 index)
  System.Void SetEnableLiquidIcon(System.Int32 index, System.Boolean enable)
  Unity.Mathematics.float4& GetLiquidIconUV(System.Int32 index)
  System.Void SetLiquidIconUV(System.Int32 index, UnityEngine.RectInt rect)
  System.Boolean get_hasOutput()
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.OutputUIRendererFragment
TYPE:  struct
TOKEN: 0x20000FE
FIELDS:
  public            System.Int32                    unitConfigAssetInstanceId  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PedestalLightFlashFragment
TYPE:  struct
TOKEN: 0x20000FF
FIELDS:
  public            System.Byte                     status  // 0x10
  public            System.Single                   intensity  // 0x14
  public            System.Single                   flashIntensity  // 0x18
  public            System.Single                   flashDuration  // 0x1C
  public            System.Boolean                  flash  // 0x20
  public            System.Int32                    flashSpeed  // 0x24
  public            System.Single                   flashStatusLerpTime  // 0x28
  public            Unity.Mathematics.float4        color  // 0x2C
  public            Unity.Mathematics.float4        flashColor  // 0x3C
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment
TYPE:  struct
TOKEN: 0x2000100
FIELDS:
  public            Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment.<intensity>e__FixedBufferintensity  // 0x10
  public            Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment.<flashIntensity>e__FixedBufferflashIntensity  // 0x50
  public            Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment.<flashDuration>e__FixedBufferflashDuration  // 0x90
  public            Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment.<flash>e__FixedBufferflash  // 0xD0
  public            Beyond.Gameplay.Factory.Float4Data16<Unity.Mathematics.float4>color  // 0xE0
  public            Beyond.Gameplay.Factory.Float4Data16<Unity.Mathematics.float4>flashColor  // 0x1E8
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Boolean IsValid()
  System.Void SetIntensity(System.Int32 idx, System.Single value)
  System.Void SetFlashIntensity(System.Int32 idx, System.Single value)
  System.Void SetFlash(System.Int32 idx, System.Boolean value)
  System.Void SetFlashDuration(System.Int32 idx, System.Single value)
  System.Void SetColor(System.Int32 idx, UnityEngine.Color value)
  System.Void SetFlashColor(System.Int32 idx, UnityEngine.Color value)
  System.Single GetIntensity(System.Int32 idx)
  System.Single GetFlashIntensity(System.Int32 idx)
  System.Boolean GetFlash(System.Int32 idx)
  System.Single GetFlashDuration(System.Int32 idx)
  Unity.Mathematics.float4 GetColor(System.Int32 idx)
  Unity.Mathematics.float4 GetFlashColor(System.Int32 idx)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeEffectFragment
TYPE:  struct
TOKEN: 0x2000105
FIELDS:
  public            Beyond.Gameplay.Factory.IntData32<System.UInt32>pipeEffectInstanceId  // 0x10
  public            Unity.Collections.FixedString64BytesinEffectName  // 0x98
  public            Unity.Collections.FixedString64BytesoutEffectName  // 0xD8
  public            Unity.Collections.FixedString64BytesinEffectConnectedName  // 0x118
  public            Unity.Collections.FixedString64BytesoutEffectConnectedName  // 0x158
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeFragment
TYPE:  struct
TOKEN: 0x2000106
FIELDS:
  public    static readonly System.Single                   PIPE_HEIGHT  // 0x0
  public            System.UInt32                   factoryUnitId  // 0x10
  public            System.Boolean                  validMode  // 0x14
  public            System.Single                   pipeHeight  // 0x18
  public            System.Single                   currentWaterThickness  // 0x1C
  public            System.Single                   waterFlowDeltaTime  // 0x20
  public            System.Single                   waterThickness  // 0x24
  public            System.Single                   speed  // 0x28
  public            System.Int32                    waterDirection  // 0x2C
  public            System.Int32                    subItemType  // 0x30
  public            System.Boolean                  entranceConnected  // 0x34
  public            System.Boolean                  exitConnected  // 0x35
  public            Unity.Mathematics.float3        entranceGroundAdjustPos  // 0x38
  public            Unity.Mathematics.float3        exitGroundAdjustPos  // 0x44
  public            Unity.Mathematics.float3        entrancePortDirection  // 0x50
  public            Unity.Mathematics.float3        exitPortDirection  // 0x5C
  public            System.Single                   bend  // 0x68
  public            UnityEngine.Rect                bounds  // 0x6C
  public            System.UInt32                   itemId  // 0x7C
  private           System.Int32                    <length>k__BackingField  // 0x80
  public            System.UInt32                   startMemoryOffsetHandle  // 0x84
  public            System.UInt32                   endMemoryOffsetHandle  // 0x88
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Void set_length(System.Int32 value)
  System.Int32 get_length()
  System.Boolean SetInflection(Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Collections.NativeList<Unity.Mathematics.float3>& p, Unity.Collections.NativeList<Unity.Mathematics.float3>& r, Unity.Collections.NativeList<System.Byte>& proto)
  System.Void Bend(Beyond.Gameplay.Factory.GlobalEnv& env, System.Int32 pipeLength, System.UInt32 startMemoryOffsetHandle, System.Single pipeHeight, System.Boolean bOverrideEntranceY, System.Single overrideEntranceY, System.Boolean bOverrideExitY, System.Single overrideExitY)
  System.ValueTuple<System.Int32[],System.Int32> GetCornerIndexList(Beyond.Gameplay.Factory.GlobalEnv& env, System.UInt32 startMemoryOffsetHandle, System.Int32 length)
  System.Boolean Sample(Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Mathematics.float2 p, System.UInt32& unitId, System.Int32& indexInPipe)
  System.Boolean IsInRect(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax)
  System.Boolean GetInRectUnitIndex(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, Beyond.PoolCore.PooledList<System.Int32>& unitIndex)
  System.Boolean FillRectTargets(Beyond.Gameplay.Factory.GlobalEnv& env, System.Single xMin, System.Single xMax, System.Single yMin, System.Single yMax, System.ValueTuple<System.UInt32,System.Int32>[,]& rectTargets)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeHolderFragment
TYPE:  struct
TOKEN: 0x2000107
FIELDS:
  public            System.Int32                    indexInPipe  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntitypipeEntity  // 0x14
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeLogisticsUnitFragment
TYPE:  struct
TOKEN: 0x2000108
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeComRenderFragment
TYPE:  struct
TOKEN: 0x2000109
FIELDS:
  public            System.Int32                    unitConfigAssetInstanceId  // 0x10
  public            Unity.Mathematics.float3        position  // 0x14
  public            Unity.Mathematics.quaternion    rotation  // 0x20
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeRenderFragment
TYPE:  struct
TOKEN: 0x200010A
FIELDS:
  public            System.Int32                    unitConfigAssetInstanceId  // 0x10
  public            System.Int32                    indexInPipe  // 0x14
  public            Unity.Collections.FixedString32Bytesprototype  // 0x18
  public            Unity.Mathematics.float3        position  // 0x38
  public            System.Single                   scale  // 0x44
  public            Unity.Mathematics.quaternion    rotation  // 0x48
  public            UnityEngine.HyperGryph.HGFactoryEntityTransformDatatransformData  // 0x38
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeTrackRenderFragment
TYPE:  struct
TOKEN: 0x200010B
FIELDS:
  public            System.Int32                    unitConfigAssetInstanceId  // 0x10
  public            Unity.Mathematics.float3        position  // 0x14
  public            Unity.Mathematics.quaternion    rotation  // 0x20
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeRenderLeftFragment
TYPE:  struct
TOKEN: 0x200010C
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeRenderRightFragment
TYPE:  struct
TOKEN: 0x200010D
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeRenderMidFragment
TYPE:  struct
TOKEN: 0x200010E
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ComplexPortFragment
TYPE:  struct
TOKEN: 0x200010F
FIELDS:
  public            Beyond.Gameplay.Factory.PortData32<Beyond.Gameplay.Factory.PortData>ports  // 0x10
  public            Unity.Mathematics.int2          pedestalPortCount  // 0x818
  public            Unity.Mathematics.int2          pipePortCount  // 0x820
  public            System.Boolean                  dataInit  // 0x828
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Boolean BindComponentId(System.UInt32 componentId, System.Int32 idx, System.Boolean isInput, System.Boolean isBlock, System.UInt32 touchComId, System.Boolean& pipeChanged)
  System.Boolean BlockPortsWithComponentId(System.UInt32 componentId, System.Boolean isBlock, System.Int32[] portIndices)
  System.Boolean BlockPorts(System.Boolean isBlock, System.Collections.Generic.List<System.Int32> portIndices, System.Boolean input)
  System.Void FollowUnit(Unity.Mathematics.float3 worldPos, Unity.Mathematics.float3 worldDir, Beyond.Gameplay.Factory.UnitConfigFragment& unitConfig, System.Single effectOffset)
  System.Boolean AnyPortBlocked()
  System.Boolean AnyPortConnected()
  System.String ToString()
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PortData
TYPE:  struct
TOKEN: 0x2000110
FIELDS:
  public            System.Byte                     idx  // 0x10
  public            System.Boolean                  isInput  // 0x11
  public            System.Boolean                  isPipe  // 0x12
  public            System.Boolean                  isBlock  // 0x13
  public            System.Boolean                  valid  // 0x14
  public            System.Boolean                  evaluated  // 0x15
  public            System.UInt32                   touchComId  // 0x18
  public            System.UInt32                   bindComId  // 0x1C
  public            System.UInt32                   touchNodeId  // 0x20
  public            Unity.Mathematics.float3        worldPos  // 0x24
  public            Unity.Mathematics.quaternion    worldDir  // 0x30
METHODS:
  Unity.Mathematics.float4x4 TRS()
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PortPreviewUIRendererFragment
TYPE:  struct
TOKEN: 0x2000111
FIELDS:
  public            System.Int32                    unitConfigAssetInstanceId  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PortStatusUIFragment
TYPE:  struct
TOKEN: 0x2000112
FIELDS:
  public            System.Int32                    unitConfigAssetInstanceId  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PowerPoleFragment
TYPE:  struct
TOKEN: 0x2000113
FIELDS:
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ProducerFragment
TYPE:  struct
TOKEN: 0x2000114
FIELDS:
  public            System.UInt32                   componentId  // 0x10
  public            System.Int64                    currentProgress  // 0x18
  public            System.UInt32                   formulaId  // 0x20
  public            System.UInt32                   lastFormulaId  // 0x24
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.UInt32 get_outputFormulaId()
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.SharedDataFragment
TYPE:  struct
TOKEN: 0x2000115
FIELDS:
  public            System.UInt32                   dataHandle  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& GetExtData()
  System.Void DestroyData()
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.SocialBuildingStates
TYPE:  struct
TOKEN: 0x2000116
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  Beyond.Gameplay.Factory.SocialBuildingStatesInvalid  // 0x0
  public    static  Beyond.Gameplay.Factory.SocialBuildingStatesDisable  // 0x0
  public    static  Beyond.Gameplay.Factory.SocialBuildingStatesUnlocked  // 0x0
  public    static  Beyond.Gameplay.Factory.SocialBuildingStatesActivated  // 0x0
  public    static  Beyond.Gameplay.Factory.SocialBuildingStatesLocked  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.SocialFragment
TYPE:  struct
TOKEN: 0x2000117
FIELDS:
  public            System.UInt32                   socialState  // 0x10
  public            System.UInt64                   ownerId  // 0x14
  public            System.UInt32                   socialNodeId  // 0x1C
  public            System.UInt64                   like  // 0x20
  public            System.Int64                    lastSetLikeTs  // 0x28
  public            System.Int64                    expirationTs  // 0x30
  public            Beyond.Gameplay.Factory.SignDatasignData  // 0x38
  public            System.Boolean                  isPreset  // 0x44
  public    static  System.Int32                    ID  // 0x0
METHODS:
  Beyond.Gameplay.Factory.SocialFragment Create(System.UInt64 ownerId, System.UInt32 socialNodeId, System.UInt64 like, System.Int64 lastSetLikeTs, System.Int64 expirationTs, System.UInt32 socialState, System.Boolean isPreset)
  System.Boolean IsHighLiked()
  System.Boolean IsLiked()
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.SignData
TYPE:  struct
TOKEN: 0x2000118
FIELDS:
  public            Unity.Mathematics.uint3         content  // 0x10
  public    static  System.Int32                    CONTENT_LENGTH  // 0x0
METHODS:
  System.String GetText()
  System.Single GetCustomPerDrawData(FactoryUIAtlas.FactoryUIAtlasSOData config, Unity.Mathematics.uint3 content)
  System.Void SetSignBuildingIcon(FactoryUIAtlas.FactoryUIAtlasSOData data, UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity logicEntity)
  System.Void SetSignBuildingIconWithRenderEntity(FactoryUIAtlas.FactoryUIAtlasSOData config, UnityEngine.HyperGryph.ECS.Entity rEntity, Unity.Mathematics.uint3 iconId)
END_CLASS

CLASS: Beyond.Gameplay.Factory.LocalTransform
TYPE:  struct
TOKEN: 0x2000119
FIELDS:
  public            Unity.Mathematics.float3        position  // 0x10
  public            System.Single                   scale  // 0x1C
  public            Unity.Mathematics.quaternion    rotation  // 0x20
  public            UnityEngine.HyperGryph.HGFactoryEntityTransformDataentityTransformData  // 0x10
  public    static readonly Beyond.Gameplay.Factory.LocalTransformIdentity  // 0x0
  public    static  System.Int32                    ID  // 0x0
METHODS:
  Beyond.Gameplay.Factory.LocalTransform FromMatrix(Unity.Mathematics.float4x4 matrix)
  Beyond.Gameplay.Factory.LocalTransform FromMatrixSafe(Unity.Mathematics.float4x4 matrix)
  Beyond.Gameplay.Factory.LocalTransform FromPositionRotation(Unity.Mathematics.float3 position, Unity.Mathematics.quaternion rotation)
  Beyond.Gameplay.Factory.LocalTransform FromPositionRotationScale(Unity.Mathematics.float3 position, Unity.Mathematics.quaternion rotation, System.Single scale)
  Beyond.Gameplay.Factory.LocalTransform FromPosition(Unity.Mathematics.float3 position)
  Beyond.Gameplay.Factory.LocalTransform FromPosition(System.Single x, System.Single y, System.Single z)
  Beyond.Gameplay.Factory.LocalTransform FromRotation(Unity.Mathematics.quaternion rotation)
  Beyond.Gameplay.Factory.LocalTransform FromScale(System.Single scale)
  System.String ToString()
  Unity.Mathematics.float3 Right()
  Unity.Mathematics.float3 Up()
  Unity.Mathematics.float3 Forward()
  Unity.Mathematics.float3 TransformPoint(Unity.Mathematics.float3 point)
  Unity.Mathematics.float3 InverseTransformPoint(Unity.Mathematics.float3 point)
  Unity.Mathematics.float3 TransformDirection(Unity.Mathematics.float3 direction)
  Unity.Mathematics.float3 InverseTransformDirection(Unity.Mathematics.float3 direction)
  Unity.Mathematics.quaternion TransformRotation(Unity.Mathematics.quaternion rotation)
  Unity.Mathematics.quaternion InverseTransformRotation(Unity.Mathematics.quaternion rotation)
  System.Single TransformScale(System.Single scale)
  System.Single InverseTransformScale(System.Single scale)
  Beyond.Gameplay.Factory.LocalTransform TransformTransform(Beyond.Gameplay.Factory.LocalTransform& transformData)
  Beyond.Gameplay.Factory.LocalTransform InverseTransformTransform(Beyond.Gameplay.Factory.LocalTransform& transformData)
  Beyond.Gameplay.Factory.LocalTransform Inverse()
  Unity.Mathematics.float4x4 ToMatrix()
  Unity.Mathematics.float4x4 ToInverseMatrix()
  Beyond.Gameplay.Factory.LocalTransform WithPosition(Unity.Mathematics.float3 p)
  Beyond.Gameplay.Factory.LocalTransform WithPosition(System.Single x, System.Single y, System.Single z)
  Beyond.Gameplay.Factory.LocalTransform WithRotation(Unity.Mathematics.quaternion r)
  Beyond.Gameplay.Factory.LocalTransform WithScale(System.Single s)
  Beyond.Gameplay.Factory.LocalTransform Translate(Unity.Mathematics.float3 translation)
  Beyond.Gameplay.Factory.LocalTransform ApplyScale(System.Single scale)
  Beyond.Gameplay.Factory.LocalTransform Rotate(Unity.Mathematics.quaternion rotation)
  Beyond.Gameplay.Factory.LocalTransform RotateX(System.Single angle)
  Beyond.Gameplay.Factory.LocalTransform RotateY(System.Single angle)
  Beyond.Gameplay.Factory.LocalTransform RotateZ(System.Single angle)
  System.Boolean Equals(Beyond.Gameplay.Factory.LocalTransform& other)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
  System.Void .cctor()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Gameplay.Factory.Root
TYPE:  struct
TOKEN: 0x200011A
FIELDS:
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.Parent
TYPE:  struct
TOKEN: 0x200011B
FIELDS:
  public            UnityEngine.HyperGryph.ECS.Entityvalue  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.Child
TYPE:  struct
TOKEN: 0x200011C
FIELDS:
  public            Beyond.Gameplay.Factory.EntityData32<UnityEngine.HyperGryph.ECS.Entity>value  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.LocalToWorld
TYPE:  struct
TOKEN: 0x200011D
FIELDS:
  public            Unity.Mathematics.float4x4      READ_ONLY_VAL  // 0x10
  public            Unity.Mathematics.float4x4      PRE_FRAME_READ_ONLY_VAL  // 0x50
  public            System.UInt32                   hierarchyHandle  // 0x90
  public            System.Boolean                  dirty  // 0x94
  public            System.Int32                    calcFrameCount  // 0x98
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Boolean SetValue(Unity.Mathematics.float4x4 value, System.Int32 frameCount)
  Unity.Mathematics.float3 get_right()
  Unity.Mathematics.float3 get_up()
  Unity.Mathematics.float3 get_forward()
  Unity.Mathematics.float3 get_position()
  Unity.Mathematics.quaternion get_rotation()
  Unity.Mathematics.float3 get_prePosition()
  Unity.Mathematics.quaternion get_preRotation()
  Unity.Mathematics.float4x4* get_READ_ONLY_VAL_PTR()
  Unity.Mathematics.float4x4* get_PRE_FRAME_READ_ONLY_VAL_PTR()
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UdPipeFragment
TYPE:  struct
TOKEN: 0x200011E
FIELDS:
  public            System.UInt64                   connectedCompId  // 0x10
  public            System.Int32                    offset  // 0x18
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitConfigFragment
TYPE:  struct
TOKEN: 0x200011F
FIELDS:
  public            System.Int32                    unitConfigAssetInstanceId  // 0x10
  public            System.Int32                    powerCost  // 0x14
  public            System.Boolean                  isShowOutputUI  // 0x18
  public            System.Boolean                  needPower  // 0x19
  public            System.Boolean                  hidePreviewArrow  // 0x1A
  public            System.Int16                    inputPortCount  // 0x1C
  public            System.Int16                    outputPortCount  // 0x1E
  public            System.Int32                    facBuildingType  // 0x20
  public            Unity.Mathematics.float3        bounds  // 0x24
  public            System.Int32                    unitNameFastString  // 0x30
  public            System.Int32                    iconOnPanelFastString  // 0x34
  public            Beyond.Gameplay.Factory.UnitConfigInternalbaseConfig  // 0x38
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.String get_iconOnPanel()
  System.Void set_iconOnPanel(System.String value)
  System.String get_unitName()
  System.Void set_unitName(System.String value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitConfigInternal
TYPE:  struct
TOKEN: 0x2000120
FIELDS:
  public            UnityEngine.Bounds              bounds  // 0x10
  public            UnityEngine.Bounds              buildingBounds  // 0x28
  public            System.UInt16                   inputPortCount  // 0x40
  public            System.UInt16                   outputPortCount  // 0x42
  public            Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>portIn  // 0x44
  public            Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>portOut  // 0x244
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.FactoryUnitPortConfig
TYPE:  struct
TOKEN: 0x2000121
FIELDS:
  public            System.Int32                    portIdx  // 0x10
  public            System.Int32                    globalPortIdx  // 0x14
  public            System.Boolean                  inOut  // 0x18
  public            System.Boolean                  isPipe  // 0x19
  public            Unity.Mathematics.float3        pos  // 0x1C
  public            Unity.Mathematics.float3        dir  // 0x28
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.FactoryUnitExtendConfig
TYPE:  struct
TOKEN: 0x2000122
FIELDS:
  public            Unity.Collections.FixedString32BytesnameRaw  // 0x10
  public            Unity.Mathematics.float3        pos  // 0x30
  public            Unity.Mathematics.quaternion    rot  // 0x3C
  private           System.Int32                    <unLoaderIndex>k__BackingField  // 0x4C
  private           System.Boolean                  <isUnLoader>k__BackingField  // 0x50
METHODS:
  System.String get_name()
  System.Int32 get_unLoaderIndex()
  System.Void set_unLoaderIndex(System.Int32 value)
  System.Boolean get_isUnLoader()
  System.Void set_isUnLoader(System.Boolean value)
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitInteractFragment
TYPE:  struct
TOKEN: 0x2000123
FIELDS:
  public            System.UInt64                   interactObjectId  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitRenderFragment
TYPE:  struct
TOKEN: 0x2000124
FIELDS:
  public            System.UInt32                   logicNodeId  // 0x10
  public            System.Int32                    partGuid  // 0x14
  public            UnityEngine.HyperGryph.ECS.EntitylogicEntity  // 0x18
  public            System.Int32                    assetHashGuid  // 0x20
  public            System.Boolean                  isSkipVATAnimation  // 0x24
  public            System.Single                   frameRate  // 0x28
  public            Unity.Mathematics.float3        bounds  // 0x2C
  public            UnityEngine.Bounds              buildingBounds  // 0x38
  public            Unity.Mathematics.bool2         buildDismissEffectEnabled  // 0x50
  public            Unity.Mathematics.float4        customArg0  // 0x54
  public            System.Int32                    unitConfigAssetInstanceId  // 0x64
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.RenderLookAtFragment
TYPE:  struct
TOKEN: 0x2000125
FIELDS:
  public            System.Boolean                  lookAtEnable  // 0x10
  public            System.Boolean                  lookAtArrived  // 0x11
  public            System.Boolean                  yawEnabled  // 0x12
  public            System.Boolean                  pitchEnabled  // 0x13
  public            Unity.Mathematics.quaternion    deltaQuaternion  // 0x14
  public            Unity.Mathematics.float3        targetPos  // 0x24
  public            Unity.Mathematics.half          interpolation  // 0x30
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ChapterTagFragment
TYPE:  struct
TOKEN: 0x2000126
FIELDS:
  public            System.Int32                    chapterId  // 0x10
  public            System.Int32                    mapId  // 0x14
  public            System.Int32                    panelIndex  // 0x18
  public            System.Int32                    sceneId  // 0x1C
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitStatusFragment
TYPE:  struct
TOKEN: 0x2000127
FIELDS:
  public            System.Byte                     preStatus  // 0x10
  public            System.Byte                     status  // 0x11
  public            System.Byte                     subStatus  // 0x12
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitOverrideStatusFragment
TYPE:  struct
TOKEN: 0x2000128
FIELDS:
  public            System.Boolean                  working  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitStatusEffectFragment
TYPE:  struct
TOKEN: 0x2000129
FIELDS:
  public            Beyond.Gameplay.Factory.StatusNormalEffectnormal  // 0x10
  public            Beyond.Gameplay.Factory.StatusClosedEffectclosed  // 0x210
  public            Beyond.Gameplay.Factory.StatusIdleEffectidle  // 0x410
  public            Beyond.Gameplay.Factory.StatusBlockedEffectblocked  // 0x610
  public            Beyond.Gameplay.Factory.StatusNoPowerEffectnoPower  // 0x810
  public            Beyond.Gameplay.Factory.StatusNotInPowerNetEffectnotInPowerNet  // 0xA10
  public            Beyond.Gameplay.Factory.StatusFixableEffectfixable  // 0xC10
  public            Beyond.Gameplay.Factory.StatusBrokenEffectbroken  // 0xE10
  public            Beyond.Gameplay.Factory.StatusOverloadEffectoverload  // 0x1010
  public            Beyond.Gameplay.Factory.StatusBusDisconnectEffectbusDisconnect  // 0x1210
  public            Unity.Mathematics.int3          effectInstanceIdList  // 0x1410
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Void SetEffects(Beyond.Gameplay.Factory.BuildingStatus buildingStatus, Beyond.Gameplay.Factory.FacEffectCfgList cfgList)
  Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect> GetEffect(Beyond.GEnums.FacBuildingState status)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.StatusNormalEffect
TYPE:  struct
TOKEN: 0x200012A
FIELDS:
  public            Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect>effectSetting  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.StatusClosedEffect
TYPE:  struct
TOKEN: 0x200012B
FIELDS:
  public            Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect>effectSetting  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.StatusIdleEffect
TYPE:  struct
TOKEN: 0x200012C
FIELDS:
  public            Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect>effectSetting  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.StatusBlockedEffect
TYPE:  struct
TOKEN: 0x200012D
FIELDS:
  public            Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect>effectSetting  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.StatusNoPowerEffect
TYPE:  struct
TOKEN: 0x200012E
FIELDS:
  public            Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect>effectSetting  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.StatusNotInPowerNetEffect
TYPE:  struct
TOKEN: 0x200012F
FIELDS:
  public            Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect>effectSetting  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.StatusFixableEffect
TYPE:  struct
TOKEN: 0x2000130
FIELDS:
  public            Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect>effectSetting  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.StatusBrokenEffect
TYPE:  struct
TOKEN: 0x2000131
FIELDS:
  public            Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect>effectSetting  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.StatusOverloadEffect
TYPE:  struct
TOKEN: 0x2000132
FIELDS:
  public            Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect>effectSetting  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.StatusBusDisconnectEffect
TYPE:  struct
TOKEN: 0x2000133
FIELDS:
  public            Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect>effectSetting  // 0x10
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.StatusSingleEffect
TYPE:  struct
TOKEN: 0x2000134
FIELDS:
  public            Beyond.Gameplay.Factory.BuildingSubStatesubState  // 0x10
  public            Unity.Collections.FixedString64Bytesname  // 0x12
  public            Unity.Mathematics.float3        offset  // 0x54
  public            System.Boolean                  needAlignToBuilding  // 0x60
METHODS:
  System.String get_effectName()
  System.Void set_effectName(System.String value)
END_CLASS

CLASS: Beyond.Gameplay.Factory.FacEffectCfgList
TYPE:  class
TOKEN: 0x2000135
FIELDS:
  public            System.Collections.Generic.List<Beyond.Gameplay.Factory.StatusSingleEffect>list  // 0x10
METHODS:
  System.Int32 get_cfgCount()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.BuildingStatus
TYPE:  struct
TOKEN: 0x2000136
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.Factory.BuildingStatusINVALID  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingStatusCLOSED  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingStatusUNKNOWN  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingStatusIDLE  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingStatusNORMAL  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingStatusBLOCKED  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingStatusNO_POWER  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingStatusNOT_IN_POWER_NET  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingStatusFIXABLE  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingStatusBROKEN  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingStatusOVERLOAD  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingStatusBUS_DISCONNECT  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingStatusMAX  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.BuildingSubState
TYPE:  struct
TOKEN: 0x2000137
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.Factory.BuildingSubStateANY  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingSubStateNONE  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingSubStateSUB_STATE_1  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingSubStateSUB_STATE_2  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingSubStateSUB_STATE_3  // 0x0
  public    static  Beyond.Gameplay.Factory.BuildingSubStateSUB_STATE_4  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitStatusUIRendererFragment
TYPE:  struct
TOKEN: 0x2000138
FIELDS:
  private           System.Int32                    <unitConfigAssetInstanceId>k__BackingField  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_unitConfigAssetInstanceId()
  System.Void set_unitConfigAssetInstanceId(System.Int32 value)
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitTransFragment
TYPE:  struct
TOKEN: 0x2000139
FIELDS:
  public            Unity.Mathematics.float3        __position  // 0x10
  public            Unity.Mathematics.float3        __rotation  // 0x1C
  public            Unity.Mathematics.float3        cornerLD  // 0x28
  public            Unity.Mathematics.float3        cornerRU  // 0x34
  public    static  System.Int32                    ID  // 0x0
METHODS:
  Unity.Mathematics.quaternion get_RotationQuaternion()
  System.Void set_Position(Unity.Mathematics.float3 value)
  Unity.Mathematics.float3 get_Position()
  System.Void set_Rotation(Unity.Mathematics.float3 value)
  Unity.Mathematics.float3 get_Rotation()
  System.Boolean InBound(Unity.Mathematics.float3 pos, System.Boolean ignoreY)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ValveFragment
TYPE:  struct
TOKEN: 0x200013A
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.UInt32                   selectedItemId  // 0x14
  public            System.Int32                    passed  // 0x18
  public            System.Int32                    currentPassed  // 0x1C
  public            Beyond.Gameplay.Factory.FactoryItemholdItem  // 0x20
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.BoxValve
TYPE:  struct
TOKEN: 0x200013B
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FluidValve
TYPE:  struct
TOKEN: 0x200013C
FIELDS:
  public            System.Byte                     placeHolder  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.BlueprintSlotInfo
TYPE:  struct
TOKEN: 0x200013D
FIELDS:
  public    static  System.Int32                    RELATED_SLOT_ID  // 0x0
  public    static  System.Int32                    SLOT_MAX_COUNT  // 0x0
  public    static  System.Int32                    UNIT_MAX_COUNT_PER_SLOT  // 0x0
  private           Beyond.Gameplay.Factory.BlueprintSlotInfo.<m_blueprintSlotInfo0>e__FixedBufferm_blueprintSlotInfo0  // 0x10
  private           Beyond.Gameplay.Factory.BlueprintSlotInfo.<m_blueprintSlotInfo1>e__FixedBufferm_blueprintSlotInfo1  // 0x810
  private           Beyond.Gameplay.Factory.BlueprintSlotInfo.<m_blueprintSlotInfo2>e__FixedBufferm_blueprintSlotInfo2  // 0x1010
  private           Beyond.Gameplay.Factory.BlueprintSlotInfo.<m_blueprintSlotInfo3>e__FixedBufferm_blueprintSlotInfo3  // 0x1810
  private           Beyond.Gameplay.Factory.BlueprintSlotInfo.<m_blueprintSlotInfo4>e__FixedBufferm_blueprintSlotInfo4  // 0x2010
  private           Beyond.Gameplay.Factory.BlueprintSlotInfo.<m_blueprintSlotInfo5>e__FixedBufferm_blueprintSlotInfo5  // 0x2810
  private           Beyond.Gameplay.Factory.BlueprintSlotInfo.<m_blueprintRelatedSlotInfo>e__FixedBufferm_blueprintRelatedSlotInfo  // 0x3010
METHODS:
  System.Boolean ContainsNodeId(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int32 slotId, System.Int32 nodeId)
  System.Void RemoveEntityFromSlot(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int32 slotId, UnityEngine.HyperGryph.ECS.Entity overdueEntity)
  System.Int32 FindEmptySlotIdx()
  System.Int32 GetSuitableSlotIdx(System.Int32 slotId)
  System.Void SetSlotId(System.Int32 index, System.Int32 slotId)
  System.UInt64[] GetSlotIds()
  System.Void AppendSlotInfo(System.Int32 slotId, UnityEngine.HyperGryph.ECS.Entity logicEntity)
  UnityEngine.HyperGryph.ECS.Entity[] ClearSlotInfo(System.Int32 slotId)
  UnityEngine.HyperGryph.ECS.Entity[] _ClearSlotInfo(System.UInt64* slotGroupPtr)
  System.Void DiffSlotInfo(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int32 slotId, Beyond.PoolCore.PooledList<System.UInt32>& baseList, Beyond.PoolCore.PooledList<System.UInt32>& newList, Beyond.PoolCore.PooledList<UnityEngine.HyperGryph.ECS.Entity>& overdueList)
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> GetAllPendingEntitiesInSlot(System.Int32 slotId)
  UnityEngine.HyperGryph.ECS.Entity GetSlotInfo(System.Int32 slotId, System.Int32 index)
  System.UInt64 GetPendingEntityCountInSlot(System.Int32 slotId)
  System.UInt64* GetSlotGroupWithSlotId(System.Int32 slotId, System.Int32& slotIdx, System.Boolean includeInvalid)
  System.UInt64* GetRelatedSlotGroup()
  System.UInt64* GetSlotGroup(System.Int32 index)
  Beyond.Gameplay.Factory.BlueprintSlotInfo CreateDefault()
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Gameplay.Factory.CargoRendererInfoCollection`1
TYPE:  struct
TOKEN: 0x2000145
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.CargoRendererInfoCollection.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  T* GetDataPtr()
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.CargoRendererInfoCollection.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.CargoRendererInfo
TYPE:  struct
TOKEN: 0x2000148
FIELDS:
  public            Unity.Mathematics.float4        positionAndScale  // 0x10
  public            Unity.Mathematics.float3        position  // 0x10
  public            System.Single                   scale  // 0x1C
  public            Unity.Mathematics.quaternion    rotation  // 0x20
  public            UnityEngine.HyperGryph.HGFactoryEntityTransformDatatransform  // 0x10
  public            Unity.Mathematics.float4        itemUV  // 0x30
  public            Unity.Mathematics.float4        itemLiquidUV  // 0x40
  public            System.Single                   isLiquidItem  // 0x50
  public            System.Byte                     preFrameVisible  // 0x54
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorRendererInfoCollection`1
TYPE:  struct
TOKEN: 0x2000149
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  T* GetDataPtr()
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.ConveyorRendererInfoCollection.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorRendererInfo
TYPE:  struct
TOKEN: 0x200014C
FIELDS:
  public            System.Int32                    index  // 0x10
  public            System.Int32                    totalLength  // 0x14
  public            System.Single                   speed  // 0x18
  public            System.Single                   adjustMapHeight  // 0x1C
  public            System.Boolean                  isPreview  // 0x20
  public            System.Boolean                  isCorner  // 0x21
  public            System.Boolean                  valid  // 0x22
  public            System.Boolean                  highLight  // 0x23
  public            System.UInt32                   sharedDataHandle  // 0x24
  public            Unity.Mathematics.float3        position  // 0x28
  public            Unity.Mathematics.float3        rotation  // 0x34
  public            System.UInt32                   lightMode  // 0x40
  public            Beyond.Gameplay.Factory.BlueprintState.EffectTypeblueprintType  // 0x44
METHODS:
  System.String ToString()
  System.String <>iFixBaseProxy_ToString()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FactoryItem
TYPE:  struct
TOKEN: 0x200014D
FIELDS:
  public            System.UInt32                   itemId  // 0x10
  public            System.Int32                    itemAmount  // 0x14
  public            System.Int64                    tms  // 0x18
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeRendererInfoCollection`1
TYPE:  struct
TOKEN: 0x200014E
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.PipeRendererInfoCollection.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  T* GetDataPtr()
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.PipeRendererInfoCollection.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection`1
TYPE:  struct
TOKEN: 0x2000151
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  T* GetDataPtr()
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeRendererInfo
TYPE:  struct
TOKEN: 0x2000154
FIELDS:
  public            System.Int32                    index  // 0x10
  public            System.Int32                    totalLength  // 0x14
  public            System.Single                   waterDirection  // 0x18
  public            System.Single                   pipeHeight  // 0x1C
  public            System.Single                   waterThickness  // 0x20
  public            System.Single                   waterFlowDeltaTime  // 0x24
  public            System.Boolean                  isPreview  // 0x28
  public            System.Boolean                  valid  // 0x29
  public            System.Boolean                  highLight  // 0x2A
  public            System.Byte                     proto  // 0x2B
  public            System.Int32                    subItemType  // 0x2C
  public            System.UInt32                   sharedDataHandle  // 0x30
  public            System.Single                   bend  // 0x34
  public            System.UInt32                   lightMode  // 0x38
  public            Unity.Mathematics.float3        position  // 0x40
  public            Unity.Mathematics.float3        rotation  // 0x4C
  public            Beyond.Gameplay.Factory.BlueprintState.EffectTypeblueprintType  // 0x58
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeTrackRendererInfo
TYPE:  struct
TOKEN: 0x2000155
FIELDS:
  public            System.Int32                    index  // 0x10
  public            System.Int32                    totalLength  // 0x14
  public            System.Single                   pipeHeight  // 0x18
  public            System.Single                   gridPathHeight  // 0x1C
  public            System.Single                   gridPathHeightEnd  // 0x20
  public            Unity.Mathematics.float3        position  // 0x24
  public            Unity.Mathematics.float3        rotation  // 0x30
  public            System.Boolean                  valid  // 0x3C
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.PortArrowRendererInfoCollection`1
TYPE:  struct
TOKEN: 0x2000156
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.PortArrowRendererInfoCollection.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  T* GetDataPtr()
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.PortArrowRendererInfoCollection.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PortArrowRendererInfo
TYPE:  struct
TOKEN: 0x2000159
FIELDS:
  public            Unity.Mathematics.float3        pos  // 0x10
  public            System.Boolean                  isForbidden  // 0x1C
  public            Unity.Mathematics.quaternion    rot  // 0x20
  public            Unity.Mathematics.float4        renderColor  // 0x30
  public            Unity.Mathematics.float4        atlasUV  // 0x40
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitId
TYPE:  struct
TOKEN: 0x200015A
FIELDS:
  public            System.Int32                    mapId  // 0x10
  public            System.UInt32                   factoryUnitId  // 0x14
METHODS:
  System.Boolean Equals(Beyond.Gameplay.Factory.UnitId other)
  System.Boolean Equals(System.Object obj)
  System.Int32 GetHashCode()
  Beyond.Gameplay.Factory.UnitId Create(System.Int32 mapId, System.UInt32 factoryUnitId)
  System.Boolean <>iFixBaseProxy_Equals(System.Object P0)
  System.Int32 <>iFixBaseProxy_GetHashCode()
END_CLASS

CLASS: Beyond.Gameplay.Factory.Visibility
TYPE:  struct
TOKEN: 0x200015B
FIELDS:
  public    static  Beyond.Gameplay.Factory.Visibilitys_defaultVal  // 0x0
  public            System.UInt32                   visibleFlags  // 0x10
  public            System.Int16                    invisibleSubCount  // 0x14
  public            Beyond.Gameplay.Factory.Visibility.<invisibleSubBits>e__FixedBufferinvisibleSubBits  // 0x16
  public    static  System.Int32                    SUB_INDEX_MAX_COUNT  // 0x0
  public    static  System.Int32                    SUB_BIT_BYTE_COUNT  // 0x0
METHODS:
  System.Boolean get_isVisible()
  System.Boolean SetVisible(Beyond.Gameplay.Factory.Visibility.EFlag flag, System.Boolean visible)
  System.Boolean SetVisible(Beyond.Gameplay.Factory.Visibility.EFlag flag, System.Boolean visible, System.Int16* invisibleIndexListPtr, System.Int16 invisibleIndexCount)
  System.Boolean GetVisible(Beyond.Gameplay.Factory.Visibility.EFlag flag)
  System.Boolean IsSubRendererInvisible(System.Int32 subIndex)
  System.Void _SetSubInvisible(System.Byte* head, System.Int32 index, System.Boolean invisible)
  System.Boolean _GetSubInvisible(System.Byte* head, System.Int32 index)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.WireRendererFragment
TYPE:  struct
TOKEN: 0x200015F
FIELDS:
  public            System.Int32                    unitConfigAssetInstanceId  // 0x10
  public    static  System.Int32                    ID  // 0x0
METHODS:
  System.Int32 get_unitAssetInstanceId()
  System.Void set_unitAssetInstanceId(System.Int32 value)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.GlobalSharedData
TYPE:  struct
TOKEN: 0x2000161
FIELDS:
  public    static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.CullingGlobalSetting>CULLING_SETTING  // 0x0
  public    static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.SystemIntervalGlobalSetting>SYSTEM_INTERVAL_SETTING  // 0x8
  public    static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.NearByDistanceGlobalSetting>NEAR_BY_DISTANCE_SETTING  // 0x10
  public    static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.World3DUiGlobalSetting>WORLD_3D_UI_SETTING  // 0x18
  public    static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.CurveGlobalSetting>CURVE_SETTING  // 0x20
  public    static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData>GRID_RENDERER_DATA  // 0x28
  public    static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting>PERDRAW_SETTING  // 0x30
  public    static readonly Unity.Burst.SharedStatic<Beyond.Gameplay.Factory.GlobalSharedData.UIEffectPathConfig>STATE_UI_PATH  // 0x38
METHODS:
  System.Void Reset()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.BaseProcessor
TYPE:  class
TOKEN: 0x2000177
FIELDS:
  protected         Beyond.Gameplay.FactorySetting  m_factorySetting  // 0x10
  private           System.Single                   <interval>k__BackingField  // 0x18
  private           System.Single                   <curInterval>k__BackingField  // 0x1C
METHODS:
  System.Void Initialize(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.FactorySetting factorySetting)
  Unity.Jobs.JobHandle PreExecute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 deltaTime, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies)
  Unity.Jobs.JobHandle Execute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 deltaTime, System.Single tickDeltaTime, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies)
  Unity.Jobs.JobHandle LateExecute(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Unity.Jobs.JobHandle jobHandle)
  System.Void CleanUp(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Action<UnityEngine.HyperGryph.ECS.EntityManager,UnityEngine.HyperGryph.ECS.Entity> hook)
  System.Void TearDown(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env)
  System.Single get_interval()
  System.Void set_interval(System.Single value)
  System.Single get_curInterval()
  System.Void set_curInterval(System.Single value)
  System.String get_name()
  System.Boolean get_lowFrameEnable()
  System.Void StructuralSync(Unity.Jobs.JobHandle& jh, Unity.Collections.NativeList<Unity.Jobs.JobHandle>& noneDependencies)
  System.Void ScheduleNoneDependencies(Unity.Collections.NativeList<Unity.Jobs.JobHandle>& noneDependencies)
  System.Boolean InLowFrameMode(Beyond.Gameplay.Factory.GlobalEnv& env)
  System.Boolean SpecialEntityExisted(UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.IProcessor
TYPE:  interface
TOKEN: 0x2000178
FIELDS:
METHODS:
  System.Void Initialize(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.FactorySetting factorySetting)
  Unity.Jobs.JobHandle PreExecute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 dt, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies)
  Unity.Jobs.JobHandle Execute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 dt, System.Single tickDeltaTime, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies)
  Unity.Jobs.JobHandle LateExecute(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Unity.Jobs.JobHandle jobHandle)
  System.Void CleanUp(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Action<UnityEngine.HyperGryph.ECS.EntityManager,UnityEngine.HyperGryph.ECS.Entity> hook)
  System.Void TearDown(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env)
  System.Single get_interval()
  System.Single get_curInterval()
  System.Void set_curInterval(System.Single value)
  System.String get_name()
  System.Boolean get_lowFrameEnable()
  System.Boolean InLowFrameMode(Beyond.Gameplay.Factory.GlobalEnv& env)
END_CLASS

CLASS: Beyond.Gameplay.Factory.StructuralChangedAttribute
TYPE:  class
TOKEN: 0x2000179
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ApplyPerDrawRender_0000080E$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000180
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binderPtr, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binderPtr, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory.ApplyPerDrawRender_0000080E$BurstDirectCall
TYPE:  class
TOKEN: 0x2000181
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binderPtr, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length)
END_CLASS

CLASS: Beyond.Gameplay.Factory.GetQueryStateIconPath_00000810$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000182
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Boolean Invoke(Beyond.GEnums.FacBuildingState state, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color)
  System.IAsyncResult BeginInvoke(Beyond.GEnums.FacBuildingState state, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color, System.AsyncCallback , System.Object )
  System.Boolean EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory.GetQueryStateIconPath_00000810$BurstDirectCall
TYPE:  class
TOKEN: 0x2000183
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Boolean Invoke(Beyond.GEnums.FacBuildingState state, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color)
END_CLASS

CLASS: Beyond.Gameplay.Factory.GetLogicEntityWithPos_00000812$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000184
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Boolean Invoke(UnityEngine.HyperGryph.ECS.EntityManager* em, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.UnitFragment*& unitFragment)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager* em, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.UnitFragment*& unitFragment, System.AsyncCallback , System.Object )
  System.Boolean EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory.GetLogicEntityWithPos_00000812$BurstDirectCall
TYPE:  class
TOKEN: 0x2000185
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Boolean Invoke(UnityEngine.HyperGryph.ECS.EntityManager* em, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.UnitFragment*& unitFragment)
END_CLASS

CLASS: Beyond.Gameplay.Factory.QueryBuildingStateFunc_00000814$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000186
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  Beyond.GEnums.FacBuildingState Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState, System.AsyncCallback , System.Object )
  Beyond.GEnums.FacBuildingState EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory.QueryBuildingStateFunc_00000814$BurstDirectCall
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
  Beyond.GEnums.FacBuildingState Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState)
END_CLASS

CLASS: Beyond.Gameplay.Factory.SetEntityFlashStatueFunc_00000816$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000188
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingState statue)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingState statue, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory.SetEntityFlashStatueFunc_00000816$BurstDirectCall
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
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingState statue)
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnsafeJobFuncPointers
TYPE:  class
TOKEN: 0x200017A
FIELDS:
METHODS:
  Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.ApplyRender> GetApplyRenderPointer()
  Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.FacRegionPosValid> GetFacRegionValid()
  System.Void ApplyPerDrawRender(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binderPtr, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length)
  Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.QueryStateIconPath> GetQueryStateIconPathFuncPtr()
  System.Boolean GetQueryStateIconPath(Beyond.GEnums.FacBuildingState state, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color)
  System.Boolean GetLogicEntityWithPosAdapter(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.UnitFragment& unitFragment)
  System.Boolean GetLogicEntityWithPos(UnityEngine.HyperGryph.ECS.EntityManager* em, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.UnitFragment*& unitFragment)
  Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.QueryBuildingState> GetQueryBuildingStatePointer()
  Beyond.GEnums.FacBuildingState QueryBuildingStateFunc(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState)
  Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.SetEntityFlashStatue> GetSetEntityFlashStatuePointer()
  System.Void SetEntityFlashStatueFunc(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingState statue)
  System.Void .ctor()
  System.Void ApplyPerDrawRender$BurstManaged(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent* binderPtr, Beyond.Gameplay.Factory.PerDrawConfig* perDrawConfigs, System.Int32 length)
  System.Boolean GetQueryStateIconPath$BurstManaged(Beyond.GEnums.FacBuildingState state, Unity.Collections.FixedString32Bytes& path, Unity.Mathematics.float4& uv, Unity.Mathematics.float4& color)
  System.Boolean GetLogicEntityWithPos$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager* em, System.Single x, System.Single y, System.Single z, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.UnitFragment*& unitFragment)
  Beyond.GEnums.FacBuildingState QueryBuildingStateFunc$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingSubState& subState)
  System.Void SetEntityFlashStatueFunc$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, Beyond.GEnums.FacBuildingState statue)
END_CLASS

CLASS: Beyond.Gameplay.Factory._BuildDismissState_00000834$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200018B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Boolean Invoke(Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.BuildDismissState& buildState, Beyond.Gameplay.Factory.CutoffState& cutoffState, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.IAsyncResult BeginInvoke(Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.BuildDismissState& buildState, Beyond.Gameplay.Factory.CutoffState& cutoffState, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time, System.AsyncCallback , System.Object )
  System.Boolean EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._BuildDismissState_00000834$BurstDirectCall
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
  System.Boolean Invoke(Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.BuildDismissState& buildState, Beyond.Gameplay.Factory.CutoffState& cutoffState, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
END_CLASS

CLASS: Beyond.Gameplay.Factory._Repair0_00000836$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200018D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Boolean Invoke(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
  System.IAsyncResult BeginInvoke(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time, System.AsyncCallback , System.Object )
  System.Boolean EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._Repair0_00000836$BurstDirectCall
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
  System.Boolean Invoke(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
END_CLASS

CLASS: Beyond.Gameplay.Factory._Repair1_00000837$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200018F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Boolean Invoke(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
  System.IAsyncResult BeginInvoke(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time, System.AsyncCallback , System.Object )
  System.Boolean EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._Repair1_00000837$BurstDirectCall
TYPE:  class
TOKEN: 0x2000190
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Boolean Invoke(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
END_CLASS

CLASS: Beyond.Gameplay.Factory.AdditiveEffectJob
TYPE:  struct
TOKEN: 0x200018A
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*qr  // 0x10
  public            System.Int64                    time  // 0x18
  public            Beyond.Gameplay.Factory.FPtrNativeCurvebuildCurve  // 0x20
  public            Beyond.Gameplay.Factory.FPtrNativeCurvebuildAlphaCurve0  // 0x38
  public            Beyond.Gameplay.Factory.FPtrNativeCurvebuildAlphaCurve1  // 0x50
  public            Beyond.Gameplay.Factory.FPtrNativeCurverepairCurve0  // 0x68
  public            Beyond.Gameplay.Factory.FPtrNativeCurverepairCurve1  // 0x80
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x98
  public            System.Int32                    threadId  // 0xA8
  public            System.Int32                    frameCount  // 0xAC
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedExtDataPtr  // 0xB0
  public            Unity.Collections.NativeQueue.ParallelWriter<Beyond.Gameplay.Factory.FactoryBuildingEffectData>finishedEffectQueue  // 0xB8
METHODS:
  System.Void SetSharedExtData(System.IntPtr data)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void Execute(System.Int32 index)
  System.Void _OnStackEmpty(Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData)
  System.Void _CancelPreState(Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType preState, Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData)
  System.Void _ResumeState(Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType state, Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData)
  System.Void _SetStateValid(Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType state, Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, System.Boolean valid)
  System.Void _UpdateInternalStateLifeCycle(Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData)
  System.Boolean _BuildDismissState(Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.BuildDismissState& buildState, Beyond.Gameplay.Factory.CutoffState& cutoffState, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.Void _InitBuildState(Beyond.Gameplay.Factory.CutoffState& cutoffState, Beyond.Gameplay.Factory.BuildDismissState& buildDismissState)
  System.Boolean _Repair0(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
  System.Boolean _Repair1(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data)
  Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount)
  Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandleDep0, Unity.Jobs.JobHandle jobHandleDep1, System.Int32 innerLoopBatchCount)
  System.Boolean _BuildDismissState$BurstManaged(Beyond.Gameplay.Factory.AdditiveEffectFragment& additiveEffect, Beyond.Gameplay.Factory.BuildDismissState& buildState, Beyond.Gameplay.Factory.CutoffState& cutoffState, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.Boolean _Repair0$BurstManaged(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
  System.Boolean _Repair1$BurstManaged(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
END_CLASS

CLASS: Beyond.Gameplay.Factory.AdditiveEffectQueryJob
TYPE:  struct
TOKEN: 0x2000191
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            System.Int32                    jobCount  // 0x20
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_additiveEffectQr  // 0x28
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_hintEffectQr  // 0x30
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_additiveEffectRendererQr  // 0x38
METHODS:
  System.Void Execute()
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& additiveEffectQr, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& hintQr, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& additiveEffectRendererQr, System.Boolean resetQr)
END_CLASS

CLASS: Beyond.Gameplay.Factory._BPBuildStart_00000840$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000193
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._BPBuildStart_00000840$BurstDirectCall
TYPE:  class
TOKEN: 0x2000194
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
END_CLASS

CLASS: Beyond.Gameplay.Factory._BPBuildProcess_00000841$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000195
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._BPBuildProcess_00000841$BurstDirectCall
TYPE:  class
TOKEN: 0x2000196
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
END_CLASS

CLASS: Beyond.Gameplay.Factory._BPBuildEnd_00000842$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000197
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._BPBuildEnd_00000842$BurstDirectCall
TYPE:  class
TOKEN: 0x2000198
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
END_CLASS

CLASS: Beyond.Gameplay.Factory._BPBuildCutoffStateStart_00000843$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000199
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._BPBuildCutoffStateStart_00000843$BurstDirectCall
TYPE:  class
TOKEN: 0x200019A
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._BPBuildCutoffStateEnd_00000844$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200019B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._BPBuildCutoffStateEnd_00000844$BurstDirectCall
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
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._BPBuildCutoffStateProcess_00000845$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200019D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._BPBuildCutoffStateProcess_00000845$BurstDirectCall
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
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._CutoffStateStart_00000849$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200019F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._CutoffStateStart_00000849$BurstDirectCall
TYPE:  class
TOKEN: 0x20001A0
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._CutoffStateEnd_0000084A$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001A1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._CutoffStateEnd_0000084A$BurstDirectCall
TYPE:  class
TOKEN: 0x20001A2
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._CutoffStateProcess_0000084B$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001A3
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._CutoffStateProcess_0000084B$BurstDirectCall
TYPE:  class
TOKEN: 0x20001A4
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._BuildStateProcess_0000084E$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001A5
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._BuildStateProcess_0000084E$BurstDirectCall
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
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
END_CLASS

CLASS: Beyond.Gameplay.Factory._HighLightStart_0000084F$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001A7
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._HighLightStart_0000084F$BurstDirectCall
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
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._HighLightEnd_00000850$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001A9
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._HighLightEnd_00000850$BurstDirectCall
TYPE:  class
TOKEN: 0x20001AA
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._HighLightProcess_00000851$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001AB
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._HighLightProcess_00000851$BurstDirectCall
TYPE:  class
TOKEN: 0x20001AC
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._FigureStart_00000852$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001AD
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._FigureStart_00000852$BurstDirectCall
TYPE:  class
TOKEN: 0x20001AE
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._FigureProcess_00000853$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001AF
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._FigureProcess_00000853$BurstDirectCall
TYPE:  class
TOKEN: 0x20001B0
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._FigureEnd_00000854$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001B1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._FigureEnd_00000854$BurstDirectCall
TYPE:  class
TOKEN: 0x20001B2
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._HintStart_00000855$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001B3
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.Single colorTypeAlpha)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.Single colorTypeAlpha, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._HintStart_00000855$BurstDirectCall
TYPE:  class
TOKEN: 0x20001B4
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.Single colorTypeAlpha)
END_CLASS

CLASS: Beyond.Gameplay.Factory._HintEnd_00000856$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001B5
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._HintEnd_00000856$BurstDirectCall
TYPE:  class
TOKEN: 0x20001B6
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._HintProcess_00000857$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001B7
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._HintProcess_00000857$BurstDirectCall
TYPE:  class
TOKEN: 0x20001B8
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._OverloadStart_00000858$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001B9
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._OverloadStart_00000858$BurstDirectCall
TYPE:  class
TOKEN: 0x20001BA
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._OverloadEnd_00000859$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001BB
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._OverloadEnd_00000859$BurstDirectCall
TYPE:  class
TOKEN: 0x20001BC
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._OverloadProcess_0000085A$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001BD
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._OverloadProcess_0000085A$BurstDirectCall
TYPE:  class
TOKEN: 0x20001BE
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._OverloadInvalidStart_0000085B$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001BF
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._OverloadInvalidStart_0000085B$BurstDirectCall
TYPE:  class
TOKEN: 0x20001C0
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._OverloadInvalidEnd_0000085C$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001C1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._OverloadInvalidEnd_0000085C$BurstDirectCall
TYPE:  class
TOKEN: 0x20001C2
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._OverloadInvalidProcess_0000085D$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001C3
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._OverloadInvalidProcess_0000085D$BurstDirectCall
TYPE:  class
TOKEN: 0x20001C4
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._Repair0Process_00000860$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001C5
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._Repair0Process_00000860$BurstDirectCall
TYPE:  class
TOKEN: 0x20001C6
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
END_CLASS

CLASS: Beyond.Gameplay.Factory._Repair1Start_00000861$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001C7
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._Repair1Start_00000861$BurstDirectCall
TYPE:  class
TOKEN: 0x20001C8
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._Repair1End_00000862$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001C9
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._Repair1End_00000862$BurstDirectCall
TYPE:  class
TOKEN: 0x20001CA
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._Repair1Process_00000863$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001CB
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._Repair1Process_00000863$BurstDirectCall
TYPE:  class
TOKEN: 0x20001CC
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
END_CLASS

CLASS: Beyond.Gameplay.Factory._BlueprintProcessInternal_00000865$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001CD
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._BlueprintProcessInternal_00000865$BurstDirectCall
TYPE:  class
TOKEN: 0x20001CE
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._BlueprintEnd_00000866$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001CF
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._BlueprintEnd_00000866$BurstDirectCall
TYPE:  class
TOKEN: 0x20001D0
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer)
END_CLASS

CLASS: Beyond.Gameplay.Factory._BlueprintStart_00000867$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001D1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._BlueprintStart_00000867$BurstDirectCall
TYPE:  class
TOKEN: 0x20001D2
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._PreSelectStart_00000868$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001D3
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._PreSelectStart_00000868$BurstDirectCall
TYPE:  class
TOKEN: 0x20001D4
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._PreSelectEnd_00000869$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001D5
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._PreSelectEnd_00000869$BurstDirectCall
TYPE:  class
TOKEN: 0x20001D6
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._PreSelectProcess_0000086A$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001D7
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._PreSelectProcess_0000086A$BurstDirectCall
TYPE:  class
TOKEN: 0x20001D8
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._ContinuationStart_0000086B$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001D9
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._ContinuationStart_0000086B$BurstDirectCall
TYPE:  class
TOKEN: 0x20001DA
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._ContinuationEnd_0000086C$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001DB
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._ContinuationEnd_0000086C$BurstDirectCall
TYPE:  class
TOKEN: 0x20001DC
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._ContinuationProcess_0000086D$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001DD
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._ContinuationProcess_0000086D$BurstDirectCall
TYPE:  class
TOKEN: 0x20001DE
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._SocialSharingStart_0000086E$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001DF
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._SocialSharingStart_0000086E$BurstDirectCall
TYPE:  class
TOKEN: 0x20001E0
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._PowerInteractionStart_0000086F$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001E1
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._PowerInteractionStart_0000086F$BurstDirectCall
TYPE:  class
TOKEN: 0x20001E2
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory._PowerInteractionEnd_00000870$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x20001E3
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory._PowerInteractionEnd_00000870$BurstDirectCall
TYPE:  class
TOKEN: 0x20001E4
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory.AdditiveEffectRenderJob
TYPE:  struct
TOKEN: 0x2000192
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*qr  // 0x10
  public            System.Int64                    time  // 0x18
  public            UnityEngine.HyperGryph.ECS.EntityManagerrEntityManager  // 0x20
  public            Beyond.Gameplay.Factory.FPtrNativeCurvebuildCurve  // 0x30
  public            Beyond.Gameplay.Factory.FPtrNativeCurvebuildAlphaCurve0  // 0x48
  public            Beyond.Gameplay.Factory.FPtrNativeCurvebuildAlphaCurve1  // 0x60
  public            Beyond.Gameplay.Factory.FPtrNativeCurverepairCurve0  // 0x78
  public            Beyond.Gameplay.Factory.FPtrNativeCurverepairCurve1  // 0x90
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedExtDataPtr  // 0xA8
METHODS:
  System.Void _BPNormalEffectExecute(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _BPBuildEffectExecute(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _BPBuildCutoffEffectExecute(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _BPBuildStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.Void _BPBuildProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.Void _BPBuildEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.Void _BPBuildCutoffStateStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.Void _BPBuildCutoffStateEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.Void _BPBuildCutoffStateProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.Void SetSharedExtData(System.IntPtr data)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void Execute(System.Int32 index)
  System.Void _CutoffStateStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.Void _CutoffStateEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.Void _CutoffStateProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.Void _BuildStateStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.Void _BuildStateEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.Void _BuildStateProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.Void _HighLightStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _HighLightEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _HighLightProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _FigureStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _FigureProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _FigureEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _HintStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.Single colorTypeAlpha)
  System.Void _HintEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _HintProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _OverloadStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _OverloadEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _OverloadProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _OverloadInvalidStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _OverloadInvalidEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _OverloadInvalidProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _Repair0Start(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _Repair0End(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _Repair0Process(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
  System.Void _Repair1Start(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _Repair1End(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _Repair1Process(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
  System.Void _BlueprintProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer)
  System.Void _BlueprintProcessInternal(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _BlueprintEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer)
  System.Void _BlueprintStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _PreSelectStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _PreSelectEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _PreSelectProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _ContinuationStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _ContinuationEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _ContinuationProcess(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _SocialSharingStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _PowerInteractionStart(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _PowerInteractionEnd(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void ResetMaterial(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, System.Boolean resetRenderPass, System.Boolean resetAdditiveMat)
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data)
  Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount)
  Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandleDep0, Unity.Jobs.JobHandle jobHandleDep1, System.Int32 innerLoopBatchCount)
  System.Void _BPBuildStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.Void _BPBuildProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.Void _BPBuildEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.Void _BPBuildCutoffStateStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.Void _BPBuildCutoffStateEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.Void _BPBuildCutoffStateProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.Void _CutoffStateStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.Void _CutoffStateEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.Void _CutoffStateProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& binder)
  System.Void _BuildStateProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve0, Beyond.Gameplay.Factory.FPtrNativeCurve& alphaCurve1, System.Int64 time)
  System.Void _HighLightStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _HighLightEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _HighLightProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _FigureStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _FigureProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _FigureEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _HintStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, System.Single colorTypeAlpha)
  System.Void _HintEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _HintProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _OverloadStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _OverloadEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _OverloadProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _OverloadInvalidStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _OverloadInvalidEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _OverloadInvalidProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _Repair0Process$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
  System.Void _Repair1Start$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _Repair1End$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _Repair1Process$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.FPtrNativeCurve& curve, System.Int64 time)
  System.Void _BlueprintProcessInternal$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _BlueprintEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& effectRenderer)
  System.Void _BlueprintStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _PreSelectStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _PreSelectEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _PreSelectProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _ContinuationStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _ContinuationEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _ContinuationProcess$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _SocialSharingStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _PowerInteractionStart$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
  System.Void _PowerInteractionEnd$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder)
END_CLASS

CLASS: Beyond.Gameplay.Factory.AudioJobs
TYPE:  class
TOKEN: 0x20001E5
FIELDS:
METHODS:
  System.Void _EntityIdx(System.Int32 groupIdx, UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange blockRange, UnityEngine.HyperGryph.ECS.GroupType group, System.Int32& startEntityIdx, System.Int32& endEntityIdx)
  System.Void _SetDebugGizmosType(Beyond.Gameplay.Factory.AudioFragment& audioFrag, Beyond.Gameplay.Factory.AudioDebugGizmosType t)
END_CLASS

CLASS: Beyond.Gameplay.Factory.BatchArrowJob
TYPE:  struct
TOKEN: 0x20001EB
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            Unity.Mathematics.float4        forbiddenColor  // 0x20
  public            Unity.Mathematics.float4        evaluatedColor  // 0x30
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultnormalQr  // 0x40
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultpreviewQr  // 0x60
  public            Beyond.Gameplay.Factory.GlobalEnvglobalEnv  // 0x80
  public            Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<Beyond.Gameplay.Factory.PortArrowRendererInfo>*outputMatrices  // 0x4F8
  public            Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.FacRegionPosValid>regionPosValidFuncPtr  // 0x500
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x508
  public            Unity.Mathematics.float4        normalColor  // 0x510
  private           System.Int32                    m_threadIndex  // 0x520
METHODS:
  System.Void _ExecutePort(System.Int32 index, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr)
  System.Void _ExecutePreview(System.Int32 index, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr)
  System.Void Execute(System.Int32 index)
  System.Void _BatchPortArrow(System.Boolean formulaManMode, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& portConfigs, Unity.Mathematics.quaternion rot, Unity.Mathematics.float3 pos, Beyond.Gameplay.Factory.ComplexPortFragment ports, Unity.Mathematics.float4x4 uvList, System.Single mapHeightValue, System.Boolean inOut, System.Boolean preview, System.Boolean inBuildMode, System.Boolean inMainRegion, System.Boolean buildingBelt, System.Boolean buildingPipe, System.Boolean blueprintSelectedUnit, System.Boolean inputDisabled, System.Boolean outputDisabled, System.Boolean inputFluidDisabled, System.Boolean outputFluidDisabled)
  System.Void SetSharedExtData(System.IntPtr data)
  System.Void Execute()
END_CLASS

CLASS: Beyond.Gameplay.Factory.BatchInsideConveyorJob
TYPE:  struct
TOKEN: 0x20001EC
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultnormalQr  // 0x10
  public            Beyond.Gameplay.Factory.GlobalEnvglobalEnv  // 0x30
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Unity.Mathematics.float4x4>conveyorInsideMatrices  // 0x4A8
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x4B0
  private           System.Int32                    m_threadIndex  // 0x4B8
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void _CollectInsideConveyor(System.Int32 index, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr)
  System.Void _BatchPortInside(System.UInt32 nodeId, Unity.Mathematics.float3 pos, Unity.Mathematics.quaternion rot, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& portConfigs, Beyond.Gameplay.Factory.ComplexPortFragment& ports, System.Boolean bInOut, System.Single mapHeightValue, System.Boolean blueprintSelectedUnit)
  System.Void SetSharedExtData(System.IntPtr data)
  System.Void Execute()
END_CLASS

CLASS: Beyond.Gameplay.Factory.BatchNormalArrowJob
TYPE:  struct
TOKEN: 0x20001ED
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            Unity.Mathematics.float4        forbiddenColor  // 0x20
  public            Unity.Mathematics.float4        evaluatedColor  // 0x30
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultnormalQr  // 0x40
  public            Beyond.Gameplay.Factory.GlobalEnvglobalEnv  // 0x60
  public            Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<Beyond.Gameplay.Factory.PortArrowRendererInfo>*outputMatrices  // 0x4D8
  public            Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.FacRegionPosValid>regionPosValidFuncPtr  // 0x4E0
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x4E8
  public            Unity.Mathematics.float4        normalColor  // 0x4F0
  public            Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap.ParallelWriter<System.Int32,System.Boolean>arrowPlacedDic  // 0x500
  private           System.Int32                    m_threadIndex  // 0x510
METHODS:
  System.Void _ExecutePort(System.Int32 index, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr)
  System.Void _BatchPortArrow(System.UInt32 nodeId, System.Boolean formulaManMode, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& portConfigs, Unity.Mathematics.quaternion rot, Unity.Mathematics.float3 pos, Beyond.Gameplay.Factory.ComplexPortFragment ports, Unity.Mathematics.float4x4 uvList, System.Single mapHeightValue, System.Boolean inOut, System.Boolean inBuildMode, System.Boolean inMainRegion, System.Boolean buildingBelt, System.Boolean buildingPipe, System.Boolean inputDisabled, System.Boolean outputDisabled, System.Boolean inputFluidDisabled, System.Boolean outputFluidDisabled)
  System.Void Execute(System.Int32 index)
  System.Void Execute()
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.BatchPreviewArrowJob
TYPE:  struct
TOKEN: 0x20001EE
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultpreviewQr  // 0x20
  public            Beyond.Gameplay.Factory.GlobalEnvglobalEnv  // 0x40
  public            Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<Beyond.Gameplay.Factory.PortArrowRendererInfo>*outputMatrices  // 0x4B8
  public            Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.FacRegionPosValid>regionPosValidFuncPtr  // 0x4C0
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x4C8
  public            Unity.Mathematics.float4        normalColor  // 0x4D0
  public            Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap.ParallelWriter<System.Int32,System.Boolean>arrowPlacedDic  // 0x4E0
  private           System.Int32                    m_threadIndex  // 0x4F0
METHODS:
  System.Void Execute()
  System.Void _ExecutePreview(System.Int32 index, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult qr)
  System.Void _BatchPortArrow(System.Boolean formulaManMode, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& portConfigs, Unity.Mathematics.quaternion rot, Unity.Mathematics.float3 pos, Beyond.Gameplay.Factory.ComplexPortFragment ports, Unity.Mathematics.float4x4 uvList, System.Single mapHeightValue, System.Boolean inOut, System.Boolean inBuildMode, System.Boolean inMainRegion)
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.BufferSwapJob
TYPE:  struct
TOKEN: 0x20001EF
FIELDS:
  public            Beyond.Gameplay.Factory.GlobalEnv*globalEnvPtr  // 0x10
  public            System.Boolean                  bConveyorSwap  // 0x18
  public            System.Boolean                  bGuideFigureSwap  // 0x19
  public            System.Boolean                  bPreviewConveyorSwap  // 0x1A
  public            System.Boolean                  bPipeSwap  // 0x1B
  public            System.Boolean                  bPortArrowSwap  // 0x1C
  public            System.Boolean                  bCargoSwap  // 0x1D
  public            System.Boolean                  bWireSwap  // 0x1E
METHODS:
  System.Void Execute()
END_CLASS

CLASS: Beyond.Gameplay.Factory.BuildingLiquidRenderJob
TYPE:  struct
TOKEN: 0x20001F0
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_qr  // 0x20
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x28
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data)
  Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount)
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.BuildingStatePosCollectJob
TYPE:  struct
TOKEN: 0x20001F1
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x10
  public            System.Single                   offsetY  // 0x30
  public            Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.QueryStateIconPath>queryStateIconPath  // 0x38
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Unity.Mathematics.float4x4>statePosList  // 0x40
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x48
  public            System.Boolean                  isInFight  // 0x50
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void _Collect(Beyond.Gameplay.Factory.UnitFragment& unit, Beyond.Gameplay.Factory.UnitTransFragment& trans, Beyond.Gameplay.Factory.UnitConfigFragment& config, Beyond.Gameplay.Factory.UnitStatusFragment& status, Beyond.Gameplay.Factory.SharedDataFragment& sharedData)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void Execute()
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.BuildingStateRendererJob
TYPE:  struct
TOKEN: 0x20001F2
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity>rendererEntities  // 0x20
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4>statePosList  // 0x30
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: Beyond.Gameplay.Factory.CargoCollectJob
TYPE:  struct
TOKEN: 0x20001F3
FIELDS:
  public            System.Single                   offsetY  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x18
  public            Beyond.Gameplay.Factory.CargoRendererInfoCollection<Beyond.Gameplay.Factory.CargoRendererInfo>*rendererList  // 0x38
  public            Beyond.Gameplay.Factory.GlobalEnv*env  // 0x40
  public            Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt*conveyorExtData  // 0x48
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x50
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void _Collect(Beyond.Gameplay.Factory.CargoFragment* cargoFrag, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& conveyorExt)
  System.Void Execute()
  System.Void SetGlobalEnvRef(Beyond.Gameplay.Factory.GlobalEnv& envRef)
  System.Void SetConveyorExtData(System.IntPtr data)
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.CargoPredictJob
TYPE:  struct
TOKEN: 0x20001F4
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*qr  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x18
  public            System.Int64                    serverTime  // 0x28
  public            Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt*conveyorExtData  // 0x30
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x38
  public            Beyond.Gameplay.Factory.GlobalEnv*env  // 0x40
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void SetConveyorExtData(System.IntPtr data)
  System.Void SetSharedExtData(System.IntPtr data)
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data)
  Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount)
END_CLASS

CLASS: Beyond.Gameplay.Factory.CargoPredictQueryJob
TYPE:  struct
TOKEN: 0x20001F5
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            System.Int32                    jobCount  // 0x20
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_queryResult  // 0x28
METHODS:
  System.Void Execute()
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& qr, System.Boolean resetQr)
END_CLASS

CLASS: Beyond.Gameplay.Factory.CargoRenderJob
TYPE:  struct
TOKEN: 0x20001F6
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity>rendererEntities  // 0x20
  public            Beyond.Gameplay.Factory.CargoRendererInfoCollection<Beyond.Gameplay.Factory.CargoRendererInfo>*rendererList  // 0x30
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void SetRendererList(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.CargoRenderQueryJob
TYPE:  struct
TOKEN: 0x20001F7
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            System.Int32                    jobCount  // 0x20
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_queryResult  // 0x28
METHODS:
  System.Void Execute()
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& qr, System.Boolean resetQr)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorCollectJob
TYPE:  struct
TOKEN: 0x20001F8
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x10
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*lPosList  // 0x30
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*mPosList  // 0x38
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*rPosList  // 0x40
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x48
  public            Beyond.Gameplay.Factory.GlobalEnv*globalEnvPtr  // 0x50
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void _Collect(Beyond.Gameplay.Factory.ConveyorFragment& conveyor, Beyond.Gameplay.Factory.SharedDataFragment& sharedDataFrag, System.Boolean preview, System.Boolean valid)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void Execute()
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorFigureRendererJob
TYPE:  struct
TOKEN: 0x20001F9
FIELDS:
  public            System.Int32                    startOffsetIndex  // 0x10
  public            System.Single                   conveyorOffsetY  // 0x14
  public            System.Single                   simpleDrawingType  // 0x18
  public            System.IntPtr                   dataMatrices  // 0x20
  public            Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity>rendererEntities  // 0x28
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x38
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x48
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void _UpdateCachedConveyor(UnityEngine.HyperGryph.ECS.Entity cachedEntity, System.UInt32 sharedDataHandle, System.Single adjustGroundHeight, Unity.Mathematics.float3 pos, Unity.Mathematics.float3 rot, System.Single conveyorIdx, System.Single conveyorLength, System.Single speed, System.Boolean preview, System.Single offsetY, System.Boolean valid, System.Boolean highlight, System.Boolean selectTypeInvalid)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorInsideRenderJob
TYPE:  struct
TOKEN: 0x20001FA
FIELDS:
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4>matrices  // 0x10
  public            Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity>renderEntities  // 0x20
  public            UnityEngine.Color               beltInsideColor  // 0x30
  public            System.Single                   speed  // 0x40
  public            System.Single                   offsetY  // 0x44
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x48
  public            Unity.Collections.NativeArray<Beyond.Gameplay.Factory.PerDrawConfig>perDrawConfigs  // 0x58
  public            Unity.Collections.NativeArray<Beyond.Gameplay.Factory.PerDrawConfig>blueprintPerDrawConfigs  // 0x68
  public            Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.ApplyRender>applyRenderFunc  // 0x78
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorPreviewCollectJob
TYPE:  struct
TOKEN: 0x20001FB
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x10
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*lPosList  // 0x30
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*mPosList  // 0x38
  public            Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>*rPosList  // 0x40
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x48
  public            Beyond.Gameplay.Factory.GlobalEnv*globalEnvPtr  // 0x50
  public            System.Void*                    conveyorInfoAllocatorPtr  // 0x58
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void _Collect(Beyond.Gameplay.Factory.ConveyorPreviewRendererFragment& conveyor, Beyond.Gameplay.Factory.SharedDataFragment& sharedData, System.Boolean preview, System.Boolean valid)
  System.Void Execute()
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ConveyorRendererJob
TYPE:  struct
TOKEN: 0x20001FC
FIELDS:
  public            System.Single                   conveyorOffsetY  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x18
  public            Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity>rendererEntities  // 0x28
  public            System.IntPtr                   dataMatrices  // 0x38
  public            System.IntPtr                   previewDataMatrices  // 0x40
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x48
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void _UpdateCachedConveyor(UnityEngine.HyperGryph.ECS.Entity cachedEntity, System.Single adjustGroundHeight, System.UInt32 sharedDataHandle, Unity.Mathematics.float3 pos, Unity.Mathematics.float3 rot, System.Single conveyorIdx, System.Single conveyorLength, System.Single speed, System.Boolean preview, Beyond.Gameplay.Factory.BlueprintState.EffectType blueprintRenderType, System.Single offsetY, System.UInt32 lightMode, System.Boolean valid, System.Boolean highlight, System.Boolean selectTypeInvalid)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.InteractFacCollectJob
TYPE:  struct
TOKEN: 0x20001FD
FIELDS:
  public            Unity.Mathematics.float3        targetPosition  // 0x10
  public            Unity.Mathematics.float3        targetForward  // 0x1C
  public            System.Single                   maxAngle  // 0x28
  public            System.Single                   maxDist  // 0x2C
  public            System.Single                   radiusExpand  // 0x30
  public    static  System.Single                   ROLE_HIGH_ADDED_VALUE  // 0x0
  public    static  System.Single                   PIPE_HEIGHT_RANGE  // 0x0
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x38
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultbuildingQr  // 0x48
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultpipeRendererQr  // 0x68
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultconveyorRendererQr  // 0x88
  public            Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfoWrap*mNearBuildingInfo  // 0xA8
  public            Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo*mConveyorInfo  // 0xB0
  public            Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo*mPipeInfo  // 0xB8
  public            Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfoWrap*mNearBuildingInfoLast  // 0xC0
  public            Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo*mConveyorInfoLast  // 0xC8
  public            Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo*mPipeInfoLast  // 0xD0
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0xD8
  private   static readonly Unity.Collections.FixedList512Bytes<Unity.Mathematics.float3>LOGISTIC_INTERACT_SAMPLE_OFFSETS  // 0x0
METHODS:
  System.Void _SwapBuffer()
  System.Void Execute()
  System.Void _ExecuteBuilding()
  System.Void _ExecuteConveyor()
  System.Void _ExecutePipe()
  System.Boolean _CheckDist(Unity.Mathematics.float3 pos, System.Single distSqThreshold, System.Int32& minSearchIndex)
  Unity.Mathematics.float3 _SnapDirectionToAxis(Unity.Mathematics.float3 direction)
  System.Void SetSharedExtData(System.IntPtr data)
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.LocalToWorldJob
TYPE:  struct
TOKEN: 0x2000201
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*qr  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData*hierarchyDataPtr  // 0x18
  public            System.Int32                    frameCount  // 0x20
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void TransTRS(Beyond.Gameplay.Factory.LocalToWorld& localToWorld, System.IntPtr hierarchyIntPtr, System.Int32 frameCount)
  System.Void TransTRS(Beyond.Gameplay.Factory.LocalToWorld& localToWorld, UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData* hierarchyPtr, System.Int32 frameCount)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void SetHierarchyData(System.IntPtr data)
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data)
  Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount)
END_CLASS

CLASS: Beyond.Gameplay.Factory.LocalToWorldQueryJob
TYPE:  struct
TOKEN: 0x2000202
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            System.Int32                    jobCount  // 0x20
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_queryResult  // 0x28
METHODS:
  System.Void Execute()
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& qr, System.Boolean resetQr)
END_CLASS

CLASS: Beyond.Gameplay.Factory.LogisticEffectJob
TYPE:  struct
TOKEN: 0x2000203
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x10
  public            System.Int64                    deltaTime  // 0x30
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: Beyond.Gameplay.Factory.LookAtJob
TYPE:  struct
TOKEN: 0x2000204
FIELDS:
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_qr  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData*hierarchyDataPtr  // 0x18
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void SetHierarchyData(System.IntPtr data)
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data)
  Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount)
END_CLASS

CLASS: Beyond.Gameplay.Factory.LookAtQueryJob
TYPE:  struct
TOKEN: 0x2000205
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            System.Int32                    jobCount  // 0x20
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_queryResult  // 0x28
METHODS:
  System.Void Execute()
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& qr, System.Boolean resetQr)
END_CLASS

CLASS: Beyond.Gameplay.Factory.OutputCollectJob
TYPE:  struct
TOKEN: 0x2000206
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x10
  public            System.Single                   offsetY  // 0x30
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Beyond.Gameplay.Factory.OutputRendererInfo>posList  // 0x38
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x40
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void _Collect(Beyond.Gameplay.Factory.UnitFragment& unit, Beyond.Gameplay.Factory.UnitTransFragment& trans, Beyond.Gameplay.Factory.UnitConfigFragment& config, Beyond.Gameplay.Factory.OutputFragment& output, Beyond.Gameplay.Factory.SharedDataFragment& sharedData)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void Execute()
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.OutputRenderJob
TYPE:  struct
TOKEN: 0x2000207
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity>rendererEntities  // 0x20
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Beyond.Gameplay.Factory.OutputRendererInfo>posList  // 0x30
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PedestalFlashJob
TYPE:  struct
TOKEN: 0x2000208
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x10
  public            System.Int64                    time  // 0x30
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedExtDataPtr  // 0x38
METHODS:
  System.Void Execute(System.Int32 index)
  Unity.Mathematics.float4 _Flash(Beyond.Gameplay.Factory.PedestalLightFlashFragment& flashConfig, System.Single deltaTime)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeCollectJob
TYPE:  struct
TOKEN: 0x2000209
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultpipeQr  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultpreviewPipeQr  // 0x30
  public            Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>*pipeLPosMatrices  // 0x50
  public            Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>*pipeMPosMatrices  // 0x58
  public            Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>*pipeRPosMatrices  // 0x60
  public            Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>*trackLPosMatrices  // 0x68
  public            Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>*trackMPosMatrices  // 0x70
  public            Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>*trackRPosMatrices  // 0x78
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Unity.Mathematics.float4x4>comPosMatrices  // 0x80
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x88
  public            Beyond.Gameplay.Factory.GlobalEnv*envPtr  // 0x90
METHODS:
  System.Int32 get_pipeCount()
  System.Void Execute(System.Int32 index)
  System.Void _ExecutePipe(UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange blockRange, Unity.Collections.NativeList<UnityEngine.HyperGryph.ECS.GroupType> groups)
  System.Void _ExecutePreviewPipe(UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange blockRange, Unity.Collections.NativeList<UnityEngine.HyperGryph.ECS.GroupType> groups)
  System.Void _CollectPipe(System.Int32 pipeLength, System.UInt32 memoryStartOffset, System.UInt32 memoryEndOffset, System.Int32 subItemType, System.Single waterThickness, System.Single waterFlowDeltaTime, System.Single waterDirection, System.Single pipeHeight, System.UInt32 sharedDataHandle, System.Boolean isPreview, System.Boolean valid, System.Boolean highLight)
  System.Void _CollectPipeCom(Beyond.Gameplay.Factory.PipeFragment& pipe, System.UInt32 sharedDataHandle)
  System.Void _CollectTrack(System.Int32 pipeLength, System.UInt32 memoryStartOffset, System.UInt32 memoryEndOffset, System.Single pipeHeight, System.Single gridPathHeightStart, System.Single gridPathHeightEnd, System.UInt32 sharedDataHandle, System.Boolean pipeValid)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void Execute()
  System.Void SetGlobalEnvRef(Beyond.Gameplay.Factory.GlobalEnv& envRef)
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeComRendererJob
TYPE:  struct
TOKEN: 0x200020A
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4>comPosArr  // 0x20
  public            Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity>rendererEntities  // 0x30
  public            System.Boolean                  useDistanceFilter  // 0x40
  public            Unity.Mathematics.float2        distanceFilterCenterPos  // 0x44
  public            System.Single                   distanceThreshold  // 0x4C
METHODS:
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeFigureRendererJob
TYPE:  struct
TOKEN: 0x200020B
FIELDS:
  public            System.Int32                    startOffsetIndex  // 0x10
  public            System.Single                   simpleDrawingType  // 0x14
  public            System.IntPtr                   dataMatrices  // 0x18
  public            Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity>rendererEntities  // 0x20
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x30
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void _UpdateCachedPipe(UnityEngine.HyperGryph.ECS.Entity cachedEntity, System.Byte protoType, Unity.Mathematics.float3 pos, Unity.Mathematics.float3 rot, System.Single indexInPipe, System.Single pipeLength, System.Single waterDirection, System.Single waterThickness, System.Single pipeHeight, System.Single subItemType, System.Boolean isPreview, System.Boolean valid, System.Boolean highLight)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeHolderFigureRendererJob
TYPE:  struct
TOKEN: 0x200020C
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            System.Single                   offsetY  // 0x20
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<UnityEngine.Matrix4x4>dataMatrices  // 0x28
  public            Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity>rendererEntities  // 0x38
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeHolderHideRendererJob
TYPE:  struct
TOKEN: 0x200020D
FIELDS:
  public            System.Boolean                  drawPipe  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultholderQr  // 0x18
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x38
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeLogisticsPosCollectJob
TYPE:  struct
TOKEN: 0x200020E
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x10
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x30
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<UnityEngine.Matrix4x4>posList  // 0x38
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void SetSharedExtData(System.IntPtr data)
  System.Void Execute()
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeRendererJob
TYPE:  struct
TOKEN: 0x200020F
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityManagerrendererEntityManager  // 0x20
  public            System.Boolean                  inTopView  // 0x30
  public            System.Boolean                  useDistanceFilter  // 0x31
  public            Unity.Mathematics.float2        distanceFilterCenterPos  // 0x34
  public            System.Single                   distanceThreshold  // 0x3C
  public            System.IntPtr                   dataMatrices  // 0x40
  public            Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity>rendererEntities  // 0x48
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x58
METHODS:
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void _UpdateCachedPipe(UnityEngine.HyperGryph.ECS.Entity cachedEntity, System.Byte protoType, Unity.Mathematics.float3 pos, Unity.Mathematics.float3 rot, System.Single bend, System.UInt32 sharedDataHandle, System.Int32 indexInPipe, System.Int32 pipeLength, System.Single waterDirection, System.Single waterThickness, System.Single subItemType, Beyond.Gameplay.Factory.BlueprintState.EffectType blueprintRenderType, System.Single waterFlowDeltaTime, System.UInt32 lightMode, System.Boolean isPreview, System.Boolean valid, System.Boolean highLight)
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeTrackRendererJob
TYPE:  struct
TOKEN: 0x2000210
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            System.IntPtr                   leftArr  // 0x20
  public            System.IntPtr                   rightArr  // 0x28
  public            System.IntPtr                   middleArr  // 0x30
  public            Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity>rendererLEntities  // 0x38
  public            Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity>rendererREntities  // 0x48
  public            Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity>rendererMEntities  // 0x58
  public            System.Boolean                  useDistanceFilter  // 0x68
  public            Unity.Mathematics.float2        distanceFilterCenterPos  // 0x6C
  public            System.Single                   distanceThreshold  // 0x74
  public            System.Boolean                  inTopView  // 0x78
METHODS:
  System.Void Execute()
  System.Void _UpdateCachedTrack(UnityEngine.HyperGryph.ECS.Entity cachedEntity, Unity.Mathematics.float3 pos, Unity.Mathematics.float3 rot, System.Single indexInPipe, System.Single pipeLength, System.Single pipeHeight, System.Single gridPathHeight, System.Single gridPathHeightEnd, System.Boolean valid)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeWaterThicknessQueryJob
TYPE:  struct
TOKEN: 0x2000211
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            System.Int32                    jobCount  // 0x20
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_queryResult  // 0x28
METHODS:
  System.Void Execute()
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& qr, System.Boolean resetQr)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PipeWaterThicknessRiseJob
TYPE:  struct
TOKEN: 0x2000212
FIELDS:
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_qr  // 0x10
  public            System.Single                   deltaTime  // 0x18
  public            Beyond.Gameplay.Factory.GlobalEnv*globalEnv  // 0x20
METHODS:
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void Execute(System.Int32 index)
  System.Void SetGlobalEnv(Beyond.Gameplay.Factory.GlobalEnv& env)
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data)
  Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PortArrowRenderJob
TYPE:  struct
TOKEN: 0x2000213
FIELDS:
  public            System.IntPtr                   arrowMatricesReaderIntPtr  // 0x10
  public            Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity>renderEntities  // 0x18
  public            System.Boolean                  buildMode  // 0x28
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x30
  public            System.IntPtr                   arrowPlacedDicPtr  // 0x40
  public            System.Boolean                  bConflictCheck  // 0x48
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PortStateCollectJob
TYPE:  struct
TOKEN: 0x2000214
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x10
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Unity.Mathematics.float4x4>portStatePosList  // 0x30
  public            System.Single                   pipePortBlockOffsetY  // 0x38
  public            System.Single                   conveyorPortBlockOffsetY  // 0x3C
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x40
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void _Collect(Beyond.Gameplay.Factory.ComplexPortFragment& complexPortFrag, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData)
  System.Void SetSharedExtData(System.IntPtr data)
  System.Void Execute()
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PortStateRendererJob
TYPE:  struct
TOKEN: 0x2000215
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity>rendererEntities  // 0x20
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4>posList  // 0x30
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PreviewUnitQueryJob
TYPE:  struct
TOKEN: 0x2000216
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            System.Int32                    jobCount  // 0x20
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_previewUnitQr  // 0x28
METHODS:
  System.Void Execute()
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& previewUnitQr, System.Boolean resetQr)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PumpInEffectJob
TYPE:  struct
TOKEN: 0x2000217
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_qr  // 0x20
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x28
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data)
  Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount)
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.StatusChangeJob
TYPE:  struct
TOKEN: 0x2000218
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x20
  public            UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriterecb  // 0x40
  public            Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.QueryBuildingState>queryBuildingState  // 0x70
  public            Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.SetEntityFlashStatue>setEntityFlashStatue  // 0x78
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitCullingJob
TYPE:  struct
TOKEN: 0x2000219
FIELDS:
  public            System.Boolean                  inTopView  // 0x10
  public            Unity.Mathematics.float3        playerPos  // 0x14
  public            Unity.Mathematics.float3        mainCameraPos  // 0x20
  public            System.Single                   stateDistanceSqrt  // 0x2C
  public            System.Single                   buildingNameDistanceSqrt  // 0x30
  public            System.Single                   renderDistanceSqr  // 0x34
  public            System.Single                   maxConveyorLengthSqr  // 0x38
  public            System.Single                   maxPipeLengthSqr  // 0x3C
  public            Beyond.Gameplay.Factory.GlobalEnv*env  // 0x40
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x48
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x68
METHODS:
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void Execute(System.Int32 index)
  System.Void SetGlobalEnvRef(Beyond.Gameplay.Factory.GlobalEnv& envRef)
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitPreviewRenderJob
TYPE:  struct
TOKEN: 0x200021A
FIELDS:
  public            Beyond.Gameplay.Factory.GlobalEnv*env  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*qr  // 0x18
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x20
METHODS:
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void Execute(System.Int32 index)
  System.Void SetGlobalEnvRef(Beyond.Gameplay.Factory.GlobalEnv& envRef)
  System.Void SetSharedExtData(System.IntPtr data)
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data)
  Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount)
END_CLASS

CLASS: Beyond.Gameplay.Factory.UnitRendererQueryJob
TYPE:  struct
TOKEN: 0x200021B
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x10
  public            System.Int32                    jobCount  // 0x20
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_unitQueryResult  // 0x28
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_liquidQueryResult  // 0x30
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_liquidPumpQueryResult  // 0x38
METHODS:
  System.Void Execute()
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& unitQr, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& liquidQr, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& pumpQr, System.Boolean resetQr)
END_CLASS

CLASS: Beyond.Gameplay.Factory.UpdateUnitRendererTRSJob
TYPE:  struct
TOKEN: 0x200021C
FIELDS:
  private           UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer*m_qr  // 0x10
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x18
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void _Transform(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& rendererBinder, Beyond.Gameplay.Factory.LocalToWorld& localToWorld, Beyond.Gameplay.Factory.SharedDataFragment& sharedData)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
  System.Void SetSharedExtData(System.IntPtr data)
  System.Void SetQueryResult(UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& data)
  Unity.Jobs.JobHandle ScheduleDefer(Unity.Jobs.JobHandle jobHandle, System.Int32 innerLoopBatchCount)
END_CLASS

CLASS: Beyond.Gameplay.Factory.WireCollectJob
TYPE:  struct
TOKEN: 0x200021D
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x30
  public            Beyond.Gameplay.Factory.GlobalEnv*env  // 0x40
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x48
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*normalRenderers  // 0x50
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*hsNormalRenderers  // 0x58
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*hsStrengthenRenderers  // 0x60
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*strengthenRenderers  // 0x68
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*disableRenderers  // 0x70
  public            Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>*strengthenDisableRenderers  // 0x78
  public            Unity.Collections.FixedString32BytesfactoryPowerPoleMountPoint  // 0x80
  public            System.Single                   wireCullDistance  // 0xA0
METHODS:
  System.Void Execute(System.Int32 index)
  System.Boolean _IsNormalConnection(Beyond.GEnums.FacBuildingState state)
  System.Boolean _IsDisabledConnection(Beyond.GEnums.FacBuildingState state)
  System.Void Execute()
  System.Void SetGlobalEnvRef(Beyond.Gameplay.Factory.GlobalEnv& envRef)
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.WireRenderJob
TYPE:  struct
TOKEN: 0x200021E
FIELDS:
  public            System.IntPtr                   dataMatrices  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityManagerem  // 0x18
  public            Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity>rendererEntities  // 0x28
METHODS:
  System.Void Execute(System.Int32 index)
  System.Void _UpdateCachedWire(UnityEngine.HyperGryph.ECS.Entity cachedEntity, Beyond.Gameplay.Factory.WireRendererInfo arg)
  System.Void Execute(System.Int32 startIndex, System.Int32 count)
END_CLASS

CLASS: Beyond.Gameplay.Factory.FactoryBuildingEffectData
TYPE:  struct
TOKEN: 0x200021F
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntitybuildingLogicEntity  // 0x10
  public            Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectTypeeffectType  // 0x18
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.FPtrNativeCurve
TYPE:  struct
TOKEN: 0x2000220
FIELDS:
  private           System.Single*                  m_values  // 0x10
  private           System.Int32                    m_valuesLength  // 0x18
  private           UnityEngine.WrapMode            m_preWrapMode  // 0x1C
  private           UnityEngine.WrapMode            m_postWrapMode  // 0x20
METHODS:
  System.Boolean IsValid()
  Unity.Collections.NativeArray<System.Single> CreateCurve(UnityEngine.AnimationCurve curve, System.Int32 resolution)
  System.Single Evaluate(System.Single t)
  System.Single _Repeat(System.Single t, System.Single length)
  System.Single _Pingpong(System.Single t, System.Single length)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PerDrawConfigArray
TYPE:  struct
TOKEN: 0x2000221
FIELDS:
  public    static  System.Int32                    MAX_COUNT  // 0x0
  public            Beyond.Gameplay.Factory.PerDrawConfig[]perDrawConfigArray  // 0x10
  public            Beyond.Gameplay.Factory.PerDrawPassConfig[]passConfigArray  // 0x18
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.PerDrawPassConfig
TYPE:  struct
TOKEN: 0x2000222
FIELDS:
  public            System.Boolean                  enable  // 0x10
  public            System.UInt32                   lightModeRaw  // 0x11
METHODS:
  Beyond.Gameplay.Factory.PerDrawLightMode get_lightMode()
  System.Void set_lightMode(Beyond.Gameplay.Factory.PerDrawLightMode value)
  System.Int32 Size()
  System.Void Apply(UnityEngine.HyperGryph.ECS.Entity rendererEntity, System.UInt32& currentLightMode)
  System.Void Apply(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent binder, System.UInt32& currentLightMode)
  UnityEngine.HyperGryph.HGShaderLightMode _ParseToHGShaderLightMode(Beyond.Gameplay.Factory.PerDrawLightMode value)
END_CLASS

CLASS: Beyond.Gameplay.Factory.PerDrawConfig
TYPE:  struct
TOKEN: 0x2000223
FIELDS:
  public            Beyond.Gameplay.Factory.PerDrawOffsetoffset  // 0x10
  public            System.Int32                    valueType  // 0x14
  public            Unity.Mathematics.float4        valueRaw  // 0x18
  private           Unity.Mathematics.float4        m_value0  // 0x28
  private           System.Single                   m_value1  // 0x38
  private           UnityEngine.Color               m_value2  // 0x3C
METHODS:
  System.Int32 Size()
  System.Void OnValidate()
  System.Void _OnPerDrawTypeChanged()
  System.Void _OnColorChanged(UnityEngine.Color c)
  System.Void _OnFloat4Changed(Unity.Mathematics.float4 f)
  System.Void _OnFloatChanged(System.Single f)
  System.Void Apply(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent binder)
END_CLASS

CLASS: Beyond.Gameplay.Factory.LogicEntityState
TYPE:  struct
TOKEN: 0x2000224
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.Factory.LogicEntityStateNORMAL  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateINVALID  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStatePREVIEW  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateMULTI_SELECT  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateSOLO_SELECT  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStatePRE_SELECT  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateWATER_AREA  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateBLUEPRINT_TOBEBUILD  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateBLUEPRINT_TOBEBUILD_SELECT  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateBLUEPRINT_MOVING  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateBLUEPRINT_MOVING_INVALID  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateCONTINUATION  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateDEFAULT  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateSHARING  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateSHARING_INVALID  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStatePOWER_INTERACTION  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateBLUEPRINT_TOBUILD_INVALID  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateOVERLOAD_INVALID  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityStateMAX  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.PerDrawDataOffsetAttribute
TYPE:  class
TOKEN: 0x2000225
EXTENDS: Attribute
FIELDS:
  public            System.Type                     type  // 0x10
  public            System.Int32                    typeValue  // 0x18
METHODS:
  System.Void .ctor(System.Type type, System.Int32 typeValue)
END_CLASS

CLASS: Beyond.Gameplay.Factory.LogicEntityType
TYPE:  struct
TOKEN: 0x2000226
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.Factory.LogicEntityTypeCONVEYOR  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityTypePIPE  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityTypeBUILDING  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityTypeINDICATOR  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityTypeGRID  // 0x0
  public    static  Beyond.Gameplay.Factory.LogicEntityTypeMAX  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.PerDrawOffset
TYPE:  struct
TOKEN: 0x2000227
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.Factory.PerDrawOffsetBASE_COLOR  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawOffsetTINT_COLOR  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawOffsetFLOW_ALPHA  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawOffsetBELT_COLOR_INTENSITY  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawOffsetBELT_COLOR_ALPHA  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawOffsetGRID_MODE  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawOffsetRENDER_ON_WATER  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawOffsetBLUEPRINT_NOISE_ALPHA  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawOffsetCONVEYOR_INDICATOR  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.PerDrawLightMode
TYPE:  struct
TOKEN: 0x2000228
FIELDS:
  public            System.UInt32                   value__  // 0x10
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeNone  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeGBuffer  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeGBufferMobile  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeErosion  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeErosionMobile  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeErosionClear  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeForwardOnly  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeForward  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeForwardCharacterOnly  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeForwardReflection  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeCharacterOutline  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeShadowCaster  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeDepthOnly  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeDepthCharacterOnly  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeSRPDefaultUnlit  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeForwardDecal  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeVFXDecal  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeDistortion  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeFullScreenDebug  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeOccludedDisplay  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeTerrainVTDecal  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeTerrainVTDecalMobile  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeRayTracingReflection  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeStencilAlphaBlend  // 0x0
  public    static  Beyond.Gameplay.Factory.PerDrawLightModeWaterMarkUI  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.PerDrawDataOffset
TYPE:  class
TOKEN: 0x2000229
FIELDS:
  public    static  System.Int32                    BASE_COLOR  // 0x0
  public    static  System.Int32                    EMISSIVE_COLOR  // 0x0
  public    static  System.Int32                    SOCIAL_SIGN_ICON_INDEX  // 0x0
  public    static  System.Int32                    CUTOFF_POS_Y  // 0x0
  public    static  System.Int32                    EMISSIVE_LUT_INDEX  // 0x0
  public    static  System.Int32                    EMISSIVE_LUT_BIT_MASK  // 0x0
  public    static  System.Int32                    LIQUID_HEIGHT_INDEX  // 0x0
  public    static  System.Int32                    FACTORY_COLOR_TYPE  // 0x0
  public    static  System.Int32                    ENABLE_CUTOFF  // 0x0
  public    static  System.Int32                    EMISSIVE_ANIMATION_MODE  // 0x0
  public    static  System.Int32                    LIQUID_COLOR_INDEX  // 0x0
  public    static  System.Int32                    UI_ATLAS_UV  // 0x0
  public    static  System.Int32                    UI_LIQUID_ATLAS_UV  // 0x0
  public    static  System.Int32                    ENABLE_LIQUID_ICON  // 0x0
  public    static  System.Int32                    RARITY_COLOR  // 0x0
  public    static  System.Int32                    TINT_COLOR  // 0x0
  public    static  System.Int32                    INDICATOR_DATA  // 0x0
  public    static  System.Int32                    DISABLE_ICON_DEPTH_BLEND  // 0x0
  public    static  System.Int32                    GRID_MODE  // 0x0
  public    static  System.Int32                    RENDER_ON_WATER  // 0x0
  public    static  System.Int32                    OVERLOOK  // 0x0
  public    static  System.Int32                    ARROW_STEP_COUNT  // 0x0
  public    static  System.Int32                    SIMPLE_DRAWING_TYPE  // 0x0
  public    static  System.Int32                    TIME_OFFSET  // 0x0
  public    static  System.Int32                    ARROW_UV_SPEED  // 0x0
  public    static  System.Int32                    ENABLE_CONVEYOR_INDICATOR  // 0x0
  public    static  System.Int32                    ARROW_DATA  // 0x0
  public    static  System.Int32                    BELT_COLOR  // 0x0
  public    static  System.Int32                    FLOW_INTENSITY  // 0x0
  public    static  System.Int32                    BELT_COLOR_INTENSITY  // 0x0
  public    static  System.Int32                    BELT_COLOR_ALPHA  // 0x0
  public    static  System.Int32                    ELECTRIC_WIRE_ALPHA  // 0x0
  public    static  System.Int32                    VFX_TINT_COLOR_ALPHA  // 0x0
  public    static  System.Int32                    ELECTRIC_WIRE_LENGTH  // 0x0
  public    static  System.Int32                    WATER_THICKNESS  // 0x0
  public    static  System.Int32                    WATER_DELTA_TIME  // 0x0
  public    static  System.Int32                    TUBE_INDEX  // 0x0
  public    static  System.Int32                    TUBE_COUNT  // 0x0
  public    static  System.Int32                    WATER_DIRECTION  // 0x0
  public    static  System.Int32                    ENABLE_OVERLOOK_ARROW  // 0x0
  public    static  System.Int32                    TUBE_BEND_X_DEGREE  // 0x0
  public    static  System.Int32                    TUBE_BEND_TAG  // 0x0
  public    static  System.Int32                    GLASS_COLOR  // 0x0
  public    static  System.Int32                    ATLAS_UV_INDEX  // 0x0
  public    static  System.Int32                    ENABLE_TUBE_INDICATOR  // 0x0
  public    static  System.Int32                    DITHER_TRANSPARENT_ALPHA  // 0x0
  public    static  System.Int32                    BLUEPRINT_NOISE_ALPHA  // 0x0
  public    static  System.Int32                    FACTORY_VAT_FRAME  // 0x0
  public    static  System.Int32                    FACTORY_VAT_LAST_FRAME  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.ProcessorInterval
TYPE:  class
TOKEN: 0x200022A
FIELDS:
METHODS:
  System.Boolean CheckInterval(Beyond.Gameplay.Factory.IProcessor& processor, System.Single delta, System.Single rate)
  System.Boolean _CheckInterval(System.Single frameInterval, System.Single intervalSetting, System.Single& curInterval, System.Single delta, System.Single rate)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.CargoPredictProcessor
TYPE:  class
TOKEN: 0x200022B
EXTENDS: BaseProcessor
FIELDS:
METHODS:
  Unity.Jobs.JobHandle Execute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 dt, System.Single tickDeltaTime, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies)
  System.Boolean get_lowFrameEnable()
  System.String get_name()
  System.Void .ctor()
  Unity.Jobs.JobHandle <>iFixBaseProxy_Execute(UnityEngine.HyperGryph.ECS.EntityManager& P0, System.Int64 P1, System.Int64 P2, System.Single P3, System.Int32 P4, System.Int32 P5, System.Int32 P6, Beyond.Gameplay.Factory.GlobalEnv& P7, Unity.Jobs.JobHandle P8, Unity.Collections.NativeList<Unity.Jobs.JobHandle> P9)
END_CLASS

CLASS: Beyond.Gameplay.Factory.CrossFrameProcessor
TYPE:  class
TOKEN: 0x200022C
EXTENDS: BaseProcessor
FIELDS:
  private           Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfom_nearBuildingInfo  // 0x20
  private           Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfom_nearConveyorInfo  // 0x74
  private           Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfom_nearPipeInfo  // 0x94
  private           Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfom_nearBuildingInfoLast  // 0xB4
  private           Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfom_nearConveyorInfoLast  // 0x108
  private           Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfom_nearPipeInfoLast  // 0x128
  private   static  System.Single                   MAX_BUILDING_INTERACT_RADIUS  // 0x0
  private   static  System.Single                   BUILDING_INTERACT_RADIUS_EXPAND  // 0x0
METHODS:
  System.Void Initialize(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.FactorySetting factorySetting)
  Unity.Jobs.JobHandle LateExecute(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Unity.Jobs.JobHandle jobHandle)
  System.Void TearDown(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env)
  System.String get_name()
  System.Boolean get_lowFrameEnable()
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Initialize(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, Beyond.Gameplay.FactorySetting P2)
  Unity.Jobs.JobHandle <>iFixBaseProxy_LateExecute(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, Unity.Jobs.JobHandle P5)
  System.Void <>iFixBaseProxy_TearDown(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1)
END_CLASS

CLASS: Beyond.Gameplay.Factory.EntityDestroyReactiveProcessor`1
TYPE:  class
TOKEN: 0x200022D
EXTENDS: ReactiveProcessor`1
FIELDS:
  private           Unity.Collections.NativeList<UnityEngine.HyperGryph.ECS.Entity>m_removedEntities  // 0x0
METHODS:
  System.Void Initialize(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.FactorySetting factorySetting)
  System.Void CleanUp(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Action<UnityEngine.HyperGryph.ECS.EntityManager,UnityEngine.HyperGryph.ECS.Entity> hook)
  System.Void TearDown(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FacRendererCollectProcessor
TYPE:  class
TOKEN: 0x200022E
EXTENDS: BaseProcessor
FIELDS:
  public    static  System.Boolean                  s_statusRenderEnabled  // 0x0
  public    static  System.Boolean                  s_portStatusRenderEnabled  // 0x1
  private           System.Single                   m_conveyorOffsetY  // 0x20
  private           System.Single                   m_conveyorPortBlockOffsetY  // 0x24
  private           System.Single                   m_pipePortBlockOffsetY  // 0x28
  private           Unity.Mathematics.float4        m_portForbiddenColor  // 0x2C
  private           Unity.Mathematics.float4        m_portEvaluatedColor  // 0x3C
  private           Unity.Mathematics.float4        m_portNormalColor  // 0x4C
  private           Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>*m_portBlockPosList  // 0x60
  private           Unity.Collections.LowLevel.Unsafe.UnsafeList<Beyond.Gameplay.Factory.OutputRendererInfo>*m_outputPosList  // 0x68
  private           Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>*m_buildingStatePosList  // 0x70
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorLPosList0  // 0x78
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorMPosList0  // 0x40080
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorRPosList0  // 0x80088
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorLPosList1  // 0xC0090
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorMPosList1  // 0x100098
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorRPosList1  // 0x1400A0
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorPreviewLPosList0  // 0x1800A8
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorPreviewMPosList0  // 0x1C00B0
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorPreviewRPosList0  // 0x2000B8
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorPreviewLPosList1  // 0x2400C0
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorPreviewMPosList1  // 0x2800C8
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorPreviewRPosList1  // 0x2C00D0
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorGuideLPosList0  // 0x3000D8
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorGuideMPosList0  // 0x3400E0
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorGuideRPosList0  // 0x3800E8
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorGuideLPosList1  // 0x3C00F0
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorGuideMPosList1  // 0x4000F8
  private           Beyond.Gameplay.Factory.ConveyorRendererInfoCollection<Beyond.Gameplay.Factory.ConveyorRendererInfo>m_conveyorGuideRPosList1  // 0x440100
  private           Beyond.Gameplay.Factory.CargoRendererInfoCollection<Beyond.Gameplay.Factory.CargoRendererInfo>m_cargoList0  // 0x480108
  private           Beyond.Gameplay.Factory.CargoRendererInfoCollection<Beyond.Gameplay.Factory.CargoRendererInfo>m_cargoList1  // 0x4C8110
  private           Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>m_pipeLPosList0  // 0x510118
  private           Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>m_pipeMPosList0  // 0x570120
  private           Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>m_pipeRPosList0  // 0x5D0128
  private           Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>m_pipeLPosList1  // 0x630130
  private           Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>m_pipeMPosList1  // 0x690138
  private           Beyond.Gameplay.Factory.PipeRendererInfoCollection<Beyond.Gameplay.Factory.PipeRendererInfo>m_pipeRPosList1  // 0x6F0140
  private           Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>m_trackLPosList0  // 0x750148
  private           Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>m_trackMPosList0  // 0x752150
  private           Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>m_trackRPosList0  // 0x754158
  private           Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>m_trackLPosList1  // 0x756160
  private           Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>m_trackMPosList1  // 0x758168
  private           Beyond.Gameplay.Factory.PipeTrackRendererInfoCollection<Beyond.Gameplay.Factory.PipeTrackRendererInfo>m_trackRPosList1  // 0x75A170
  private           Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>m_wireNormalList0  // 0x75C178
  private           Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>m_wireNormalList1  // 0x762180
  private           Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>m_wireHsNormalList0  // 0x768188
  private           Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>m_wireHsNormalList1  // 0x76E190
  private           Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>m_wireDisableList0  // 0x774198
  private           Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>m_wireDisableList1  // 0x77A1A0
  private           Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>m_wireStrengthenList0  // 0x7801A8
  private           Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>m_wireStrengthenList1  // 0x7861B0
  private           Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>m_wireHsStrengthenList0  // 0x78C1B8
  private           Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>m_wireHsStrengthenList1  // 0x7921C0
  private           Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>m_wireStrengthenDisableList0  // 0x7981C8
  private           Beyond.Gameplay.Factory.WireRendererInfoCollection<Beyond.Gameplay.Factory.WireRendererInfo>m_wireStrengthenDisableList1  // 0x79E1D0
  private           Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.Matrix4x4>*m_pipeHolderPosList  // 0x7A41D8
  private           Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>*m_comPosList  // 0x7A41E0
  private           Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<Beyond.Gameplay.Factory.PortArrowRendererInfo>m_portArrowList0  // 0x7A41E8
  private           Beyond.Gameplay.Factory.PortArrowRendererInfoCollection<Beyond.Gameplay.Factory.PortArrowRendererInfo>m_portArrowList1  // 0x7C41F0
  private           Unity.Collections.LowLevel.Unsafe.UnsafeList<Unity.Mathematics.float4x4>*m_conveyorInsideMatrices  // 0x7E41F8
  private           Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.FacRegionPosValid>m_facRegionPosValidFuncPtr  // 0x7E4200
  public            Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.QueryStateIconPath>queryStateIconPathFuncPtr  // 0x7E4208
  private           System.Int32                    m_lowFrameInterval  // 0x7E4210
  private           Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<System.Int32,System.Boolean>m_arrowPlacedDic  // 0x7E4218
METHODS:
  Unity.Jobs.JobHandle _CollectConveyor(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& conveyorCollectJobHandle)
  Unity.Jobs.JobHandle _CollectPreviewConveyor(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& conveyorPreviewCollectJobHandle)
  Unity.Jobs.JobHandle _CollectGuideConveyor(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& conveyorCollectJobHandle)
  System.String get_name()
  System.Void Initialize(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.FactorySetting factorySetting)
  System.Void _CreateAllocator(Beyond.Gameplay.Factory.GlobalEnv& env)
  System.Void _CreateCurrent(Beyond.Gameplay.Factory.GlobalEnv& env)
  Unity.Jobs.JobHandle _CollectPortState(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& portCollectJobHandle)
  Unity.Jobs.JobHandle _CollectBuildingState(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& buildingStateCollectJobHandle)
  Unity.Jobs.JobHandle _CollectOutput(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& outputCollectJobHandle)
  Unity.Jobs.JobHandle _CollectCargo(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& cargoCollectJobHandle)
  Unity.Jobs.JobHandle _CollectWire(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& wireCollectJobHandle)
  Unity.Jobs.JobHandle LateExecute(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Unity.Jobs.JobHandle jobHandle)
  System.Void TearDown(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env)
  Unity.Jobs.JobHandle _CollectPipe(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& pipeCollectJobHandle)
  Unity.Jobs.JobHandle _CollectPipeLogistics(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& pipeHolderCollectJobHandle)
  System.Void _InitArrowPlaced(Beyond.Gameplay.Factory.GlobalEnv& env)
  Unity.Jobs.JobHandle _CollectPortArrow(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& portArrowCollectJobHandle)
  Unity.Jobs.JobHandle _CollectPortArrowWithDiff(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle& jobHandle, Unity.Jobs.JobHandle& portArrowCollectJobHandle)
  System.Void .ctor()
  System.Void .cctor()
  System.Void <>iFixBaseProxy_Initialize(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, Beyond.Gameplay.FactorySetting P2)
  Unity.Jobs.JobHandle <>iFixBaseProxy_LateExecute(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, Unity.Jobs.JobHandle P5)
  System.Void <>iFixBaseProxy_TearDown(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ReactiveProcessor`1
TYPE:  class
TOKEN: 0x200022F
EXTENDS: BaseProcessor
FIELDS:
  private   readonly System.String                   <name>k__BackingField  // 0x0
METHODS:
  Unity.Jobs.JobHandle PreExecute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 dt, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies)
  Unity.Jobs.JobHandle Execute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 dt, System.Single tickDeltaTime, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies)
  System.Void Perform(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& ecb, UnityEngine.HyperGryph.ECS.ECSSpan<T>& dataSpans, Beyond.Gameplay.Factory.GlobalEnv& env, UnityEngine.HyperGryph.ECS.GroupType group, System.Int64 time)
  System.Boolean CleanUpEntityFilter(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void CleanUp(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, System.Action<UnityEngine.HyperGryph.ECS.EntityManager,UnityEngine.HyperGryph.ECS.Entity> hook)
  System.Void TearDown(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env)
  System.String get_name()
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.AdditiveMaterialBitIndex
TYPE:  class
TOKEN: 0x2000230
FIELDS:
  public    static readonly System.Int32                    PREVIEW  // 0x0
  public    static readonly System.Int32                    HIGHLIGHT  // 0x4
  public    static readonly System.Int32                    OUTLINE  // 0x8
  public    static readonly System.Int32                    CUTOFF  // 0xC
  public    static readonly System.Int32                    PRECESS  // 0x10
  public    static readonly System.Int32                    REPAIR1  // 0x14
  public    static readonly System.Int32                    REPAIR2  // 0x18
  public    static readonly System.Int32                    REPAIR3  // 0x1C
  public    static readonly System.Int32                    OVERLOAD  // 0x20
  public    static readonly System.Int32                    BLUEPRINT_BUILD  // 0x24
  public    static readonly System.Int32                    BLUEPRINT_MOVE  // 0x28
  public    static readonly System.Int32                    BLUEPRINT_BUILD_OUTLINE  // 0x2C
  public    static readonly System.Int32                    BLUEPRINT_MOVE_OUTLINE  // 0x30
  public    static readonly System.Int32                    PRESELECT_PREVIEW  // 0x34
  public    static readonly System.Int32                    SOCIAL_SHARING  // 0x38
  public    static readonly System.Int32                    POWER_INTERACTION  // 0x3C
  public    static readonly System.Int32                    MAX  // 0x40
METHODS:
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FactoryBaseColorLutConfig
TYPE:  class
TOKEN: 0x2000231
EXTENDS: ScriptableObject
FIELDS:
  public            Beyond.SerializeFieldDictionary<Beyond.Gameplay.Factory.FacBuildingBaseBuffer,UnityEngine.Color>factoryBuildingBaseStateConfig  // 0x18
  public            Beyond.SerializeFieldDictionary<Beyond.Gameplay.Factory.BuildAndMode,System.Int32>factoryBuildingCrafterData  // 0x20
  public            System.Int32                    factoryBuildingCount  // 0x28
METHODS:
  System.Boolean GetColor(System.Int32 sort, UnityEngine.Color& col)
  System.Boolean GetIndex(System.String id, System.String group, System.Int32& index)
  Beyond.Gameplay.Factory.FactoryBaseColorLutConfig CreateOrGet(System.String path)
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.FacBuildingBaseBuffer
TYPE:  struct
TOKEN: 0x2000232
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.Factory.FacBuildingBaseBufferInputBuffer1  // 0x0
  public    static  Beyond.Gameplay.Factory.FacBuildingBaseBufferInputBuffer2  // 0x0
  public    static  Beyond.Gameplay.Factory.FacBuildingBaseBufferInputBuffer3  // 0x0
  public    static  Beyond.Gameplay.Factory.FacBuildingBaseBufferOutputBuffer1  // 0x0
  public    static  Beyond.Gameplay.Factory.FacBuildingBaseBufferOutputBuffer2  // 0x0
  public    static  Beyond.Gameplay.Factory.FacBuildingBaseBufferOutputBuffer3  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.BuildAndMode
TYPE:  struct
TOKEN: 0x2000233
FIELDS:
  public            System.String                   build  // 0x10
  public            System.String                   mode  // 0x18
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.FFactoryStateColorConfig
TYPE:  struct
TOKEN: 0x2000234
FIELDS:
  public            Beyond.SerializeFieldDictionary<Beyond.GEnums.FacBuildingState,UnityEngine.Color>factoryStateIconColorConfig  // 0x10
  public            Beyond.SerializeFieldDictionary<Beyond.GEnums.FacBuildingState,UnityEngine.Color>factoryIndicatorColorConfig  // 0x18
  public            Beyond.SerializeFieldDictionary<Beyond.GEnums.FacBuildingState,System.String>factoryUIEffectConfig  // 0x20
  public            Beyond.SerializeFieldDictionary<Beyond.Gameplay.Factory.LogicEntityState,Beyond.SerializeFieldDictionary<Beyond.Gameplay.Factory.LogicEntityType,Beyond.Gameplay.Factory.PerDrawConfigArray>>factoryLogicEntityColorConfig2  // 0x28
METHODS:
  System.Boolean GetStateColor(Beyond.GEnums.FacBuildingState enumKey, UnityEngine.Color& col)
  System.Boolean GetIndicatorColor(Beyond.GEnums.FacBuildingState enumKey, UnityEngine.Color& col)
  System.Boolean GetStateName(Beyond.GEnums.FacBuildingState enumKey, System.String& name)
  System.Boolean GetPerDrawList(Beyond.Gameplay.Factory.LogicEntityState entityState, Beyond.Gameplay.Factory.LogicEntityType entityType, Beyond.Gameplay.Factory.PerDrawConfigArray& perDrawList)
  System.Void OnEnable()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment
TYPE:  struct
TOKEN: 0x2000236
FIELDS:
  public            Beyond.Gameplay.Factory.ECSVATFSM.FSMStatecurrentState  // 0x10
  public            Beyond.Gameplay.Factory.ECSVATFSM.FSMStatenextState  // 0x2C
  public            Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSetparameters  // 0x48
  public            Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitiontransition  // 0x6C
  public            System.Single                   speed  // 0x78
  public            System.UInt32                   definitionHandle  // 0x7C
  public            System.UInt32                   binderSharedDataIndex  // 0x80
  public            System.Boolean                  isTransitioning  // 0x84
  public            System.Boolean                  isPause  // 0x85
  public    static  System.Int32                    ID  // 0x0
METHODS:
  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& get_def()
  System.Void Init(System.UInt32 defHandle, System.UInt32 binderHandle)
  System.Void SetState(Beyond.Gameplay.Factory.ECSVATFSM.FSMStateDefinition& stateDef)
  System.Void ToNextState()
  System.Void SetTransition(Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition& transDef, Beyond.Gameplay.Factory.ECSVATFSM.FSMStateDefinition& nextStateDef)
  System.Int32 get_id()
  System.Void __AOT_FOR_FIX__()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.FSMState
TYPE:  struct
TOKEN: 0x2000237
FIELDS:
  public            System.Byte                     index  // 0x10
  public            System.Single                   duration  // 0x14
  public            System.Single                   speed  // 0x18
  public            System.Boolean                  isLoop  // 0x1C
  public            System.UInt32                   prevFrame  // 0x20
  private           System.Single                   m_elapsedTime  // 0x24
  private           System.Boolean                  m_isFinish  // 0x28
METHODS:
  System.Single get_process()
  System.Boolean get_isFinished()
  System.Void Enter()
  System.Void Update(System.Single deltaTime, System.Single fsmSpeed)
  System.Void Exit()
  System.Void SetProgress(System.Single normalized)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.FSMTransition
TYPE:  struct
TOKEN: 0x2000238
FIELDS:
  public            System.Single                   duration  // 0x10
  private           System.Single                   m_elapsedTime  // 0x14
  private           System.Boolean                  m_isFinish  // 0x18
METHODS:
  System.Boolean get_isFinished()
  System.Single get_fromStateWeight()
  System.Single get_toStateWeight()
  System.Void Enter()
  System.Void Update(System.Single deltaTime, System.Single fsmSpeed)
  System.Void Exit()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet
TYPE:  struct
TOKEN: 0x2000239
FIELDS:
  public            Unity.Collections.FixedList32Bytes<System.Single>floats  // 0x10
  public            System.Byte                     bools  // 0x30
  public            System.Byte                     triggers  // 0x31
METHODS:
  System.Single GetFloat(System.Byte index)
  System.Void SetFloat(System.Byte index, System.Single value)
  System.Int32 GetInt(System.Byte index)
  System.Void SetInt(System.Byte index, System.Int32 value)
  System.Boolean GetBool(System.Byte index)
  System.Void SetBool(System.Byte index, System.Boolean value)
  System.Boolean GetTrigger(System.Byte index)
  System.Void SetTrigger(System.Byte index)
  System.Void ResetTrigger(System.Byte index)
  System.Void ResetAllTriggers()
  System.Void SetValue(System.Byte index, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type, System.Single value)
  System.Single GetValue(System.Byte index, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType type)
  System.Void ResetParametersByDef(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& def)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.VATFSMSetParamRequestHandlerJob
TYPE:  struct
TOKEN: 0x200023A
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityManagerrenderEm  // 0x10
  public            Unity.Collections.NativeArray.ReadOnly<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest>setParamRequestList  // 0x20
  public            Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition*sharedDataPtr  // 0x30
  public            Beyond.Gameplay.Factory.GlobalEnv*envPtr  // 0x38
METHODS:
  System.Void Execute(System.Int32 index)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateUpdateJob
TYPE:  struct
TOKEN: 0x200023B
FIELDS:
  public            System.Single                   deltaTime  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultqr  // 0x18
  public            Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition*fsmDefinitionPtr  // 0x38
  public            Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData*sharedDataPtr  // 0x40
  public            Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATFSMAudioData>animatorAudioQueue  // 0x48
  private   static  System.Int32                    S_CURRENT_FRAME_OFFSET  // 0x0
  private   static  System.Int32                    S_PREVIOUS_FRAME_OFFSET  // 0x0
METHODS:
  System.Void Execute()
  System.Void Execute(System.Int32 index)
  System.Boolean _CheckTransitions(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& fsm, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& fsmDef)
  System.Void _ComputeVATFrameData(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& state, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& fsmDef)
  System.Void _AddVATAudioData(UnityEngine.HyperGryph.ECS.Entity renderEntity, Beyond.Gameplay.Factory.ECSVATFSM.FSMState& newState, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& fsmDef)
  System.Void SetSharedExtData(System.IntPtr data)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor
TYPE:  class
TOKEN: 0x200023C
EXTENDS: BaseProcessor
FIELDS:
  public            Unity.Collections.NativeList<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest>animatorParamRequestQueue  // 0x20
  private           Unity.Collections.NativeParallelHashMap<UnityEngine.HyperGryph.ECS.Entity,System.Int32>m_requestMaskPerEntity  // 0x30
METHODS:
  System.String get_name()
  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition* get_fsmDefinitionPtr()
  System.Void Initialize(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.FactorySetting factorySetting)
  Unity.Jobs.JobHandle Execute(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int64 time, System.Int64 deltaTime, System.Single tickDeltaTime, System.Int32 frameCount, System.Int32 curChapterId, System.Int32 curMapId, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle, Unity.Collections.NativeList<Unity.Jobs.JobHandle> noneDependencies)
  System.Void TearDown(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env)
  Unity.Jobs.JobHandle _HandleSetAnimatorParamRequest(UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.GlobalEnv& env, Unity.Jobs.JobHandle jobHandle)
  System.Void _RemoveDuplicationRequest(UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Void .ctor()
  System.Void <>iFixBaseProxy_Initialize(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, Beyond.Gameplay.FactorySetting P2)
  Unity.Jobs.JobHandle <>iFixBaseProxy_Execute(UnityEngine.HyperGryph.ECS.EntityManager& P0, System.Int64 P1, System.Int64 P2, System.Single P3, System.Int32 P4, System.Int32 P5, System.Int32 P6, Beyond.Gameplay.Factory.GlobalEnv& P7, Unity.Jobs.JobHandle P8, Unity.Collections.NativeList<Unity.Jobs.JobHandle> P9)
  System.Void <>iFixBaseProxy_TearDown(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.GlobalEnv& P1)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.ECSVATFSMDefinitionData
TYPE:  class
TOKEN: 0x2000240
FIELDS:
  public            System.String                   fsmName  // 0x10
  public            System.String                   defaultStateName  // 0x18
  public            System.Collections.Generic.List<Beyond.Gameplay.Factory.ECSVATFSM.StateData>states  // 0x20
  public            System.Collections.Generic.List<Beyond.Gameplay.Factory.ECSVATFSM.TransitionData>transitions  // 0x28
  public            System.Collections.Generic.List<Beyond.Gameplay.Factory.ECSVATFSM.ParameterData>parameters  // 0x30
  public            System.Collections.Generic.List<Beyond.Gameplay.Factory.ECSVATFSM.AnimationClipData>animationClips  // 0x38
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.StateData
TYPE:  class
TOKEN: 0x2000241
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Single                   speed  // 0x18
  public            System.String                   clipName  // 0x20
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.TransitionInterruptionSource
TYPE:  struct
TOKEN: 0x2000242
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.TransitionInterruptionSourceNone  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.TransitionInterruptionSourceSource  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.TransitionInterruptionSourceDestination  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.TransitionInterruptionSourceSourceThenDestination  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.TransitionInterruptionSourceDestinationThenSource  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.TransitionData
TYPE:  class
TOKEN: 0x2000243
FIELDS:
  public            System.String                   fromState  // 0x10
  public            System.String                   toState  // 0x18
  public            System.Single                   exitTime  // 0x20
  public            System.Single                   duration  // 0x24
  public            Beyond.Gameplay.Factory.ECSVATFSM.TransitionInterruptionSourceinterruptionSource  // 0x28
  public            System.Collections.Generic.List<Beyond.Gameplay.Factory.ECSVATFSM.ConditionData>condition  // 0x30
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionMode
TYPE:  struct
TOKEN: 0x2000244
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionModeIf  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionModeIfNot  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionModeGreater  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionModeLess  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionModeEquals  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionModeNotEqual  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.ConditionData
TYPE:  class
TOKEN: 0x2000245
FIELDS:
  public            System.String                   parameterName  // 0x10
  public            Beyond.Gameplay.Factory.ECSVATFSM.AnimatorConditionModecomparison  // 0x18
  public            System.Single                   threshold  // 0x1C
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.ParameterData
TYPE:  class
TOKEN: 0x2000246
FIELDS:
  public            System.String                   name  // 0x10
  public            UnityEngine.AnimatorControllerParameterTypetype  // 0x18
  public            System.Single                   defaultFloat  // 0x1C
  public            System.Int32                    defaultInt  // 0x20
  public            System.Boolean                  defaultBool  // 0x24
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.AnimationClipData
TYPE:  class
TOKEN: 0x2000247
FIELDS:
  public            System.String                   name  // 0x10
  public            System.Boolean                  isLoop  // 0x18
  public            System.Single                   length  // 0x1C
  public            System.Int32                    startFrame  // 0x20
  public            System.Int32                    totalFrames  // 0x24
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition
TYPE:  struct
TOKEN: 0x2000248
FIELDS:
  public            System.Byte                     defaultStateIndex  // 0x10
  public            Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.ECSVATFSM.FSMStateDefinition>states  // 0x12
  public            Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition20<Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition>transitions  // 0x214
  public            Unity.Collections.FixedList128Bytes<Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterDefinition>parameters  // 0xA1C
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.ConditionMode
TYPE:  struct
TOKEN: 0x2000249
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.ConditionModeIf  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.ConditionModeIfNot  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.ConditionModeGreater  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.ConditionModeLess  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.ConditionModeEquals  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.ConditionModeNotEqual  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.FSMCondition
TYPE:  struct
TOKEN: 0x200024A
FIELDS:
  public            System.Byte                     parameterIndex  // 0x10
  public            Beyond.Gameplay.Factory.ECSVATFSM.ConditionModecomparison  // 0x11
  public            System.Single                   threshold  // 0x14
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition20`1
TYPE:  struct
TOKEN: 0x200024B
FIELDS:
  public    static  System.Int32                    T_SIZE  // 0x0
  public    static  System.Int32                    CAPACITY  // 0x0
  public    static  System.Int32                    CAPACITY_MINUS_ONE  // 0x0
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           System.Int32                    m_beginIndex  // 0x0
  private           System.Int32                    m_endIndex  // 0x0
  public            Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition20.<data>e__FixedBuffer<T>data  // 0x0
METHODS:
  System.Int32 get_length()
  System.Boolean get_ring()
  System.Int32 get_beginIndex()
  System.Int32 get_endIndex()
  System.Void .ctor(System.Int32 initialCapacity, System.Boolean autoExtend)
  System.Byte* GetPtr()
  System.IntPtr GetDataAsIntPtr()
  System.Int32 Enqueue(T value)
  T Dequeue()
  System.Int32 Unshift(T value)
  T Shift()
  System.Int32 Push(T value)
  T Pop()
  T First()
  T Last()
  System.Void InsertAt(System.Int32 index, T value)
  T RemoveAt(System.Int32 index)
  System.Int32 Find(T value)
  System.Boolean get_isEmpty()
  System.Void Extend(System.Int32 count)
  System.Void Extend()
  System.Void Clear()
  Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition20.Enumerator<T> GetEnumerator()
  System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  T& get_Item(System.Int32 index)
  T* GetElementAt(System.Int32 index)
  T GetValue(System.Int32 index)
  T GetValueWithGlobalIndex(System.Int32 globalIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition
TYPE:  struct
TOKEN: 0x200024E
FIELDS:
  public            System.Byte                     fromStateIndex  // 0x10
  public            System.Byte                     toStateIndex  // 0x11
  public            System.Single                   exitTime  // 0x12
  public            System.Single                   duration  // 0x16
  public            Unity.Collections.FixedList32Bytes<Beyond.Gameplay.Factory.ECSVATFSM.FSMCondition>conditions  // 0x1A
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.ParameterType
TYPE:  struct
TOKEN: 0x200024F
FIELDS:
  public            System.Byte                     value__  // 0x10
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.ParameterTypeFloat  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.ParameterTypeInt  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.ParameterTypeBool  // 0x0
  public    static  Beyond.Gameplay.Factory.ECSVATFSM.ParameterTypeTrigger  // 0x0
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterDefinition
TYPE:  struct
TOKEN: 0x2000250
FIELDS:
  public            System.Int32                    nameHash  // 0x10
  public            Beyond.Gameplay.Factory.ECSVATFSM.ParameterTypetype  // 0x14
  public            System.Byte                     index  // 0x15
  public            System.Single                   defaultFloat  // 0x18
  public            System.Int32                    defaultInt  // 0x18
  public            System.Byte                     defaultBool  // 0x18
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.FSMStateDefinition
TYPE:  struct
TOKEN: 0x2000251
FIELDS:
  public            System.Int32                    nameHash  // 0x10
  public            System.Single                   length  // 0x14
  public            System.Single                   speed  // 0x18
  public            System.Int32                    clipNameHash  // 0x1C
  public            System.UInt32                   startFrame  // 0x20
  public            System.UInt32                   totalFrames  // 0x24
  public            System.Byte                     index  // 0x28
  public            System.Boolean                  isLoop  // 0x29
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer
TYPE:  struct
TOKEN: 0x2000252
FIELDS:
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           Beyond.HGArray<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer.Node>m_nodes  // 0x10
METHODS:
  System.Void .ctor(Unity.Collections.Allocator allocator)
  System.Void Dispose()
  System.UInt32 Size()
  System.Span<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition> AsSpan()
  System.UInt32 Create(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& value)
  System.Void Destroy(System.UInt32 handle)
  System.Void Reset()
  System.Void Reserve(System.UInt32 newCapacity)
  System.IntPtr Data()
  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& get_Item(System.Int32 index)
  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& get_Item(System.UInt32 index)
  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& Get(System.UInt32 handle)
  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& Get(System.Int32 handle)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionHelper
TYPE:  class
TOKEN: 0x2000254
FIELDS:
METHODS:
  System.Boolean _Evaluate(Beyond.Gameplay.Factory.ECSVATFSM.FSMCondition& cond, Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& param, Unity.Collections.FixedList128Bytes<Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterDefinition>& paramDefs)
  System.Boolean TryGetValidTransition(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& state, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& def, System.Int32& transitionIndex)
  System.Boolean TryGetParameterIndexAndType(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition def, System.Int32 nameHash, System.Byte& index, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType& type)
  System.Void ResetUsedTriggers(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& param, Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition& transition, Unity.Collections.FixedList128Bytes<Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterDefinition>& paramDefs)
END_CLASS

CLASS: Beyond.Gameplay.Factory.ECSVATFSM.FSMDefinitionLibrary
TYPE:  class
TOKEN: 0x2000255
FIELDS:
  public    static  System.Int32                    MAX_FSM_DEFINITION_COUNT  // 0x0
  public    static  System.Int32                    MAX_STATE_COUNT  // 0x0
  public    static  System.Int32                    MAX_TRANSITION_COUNT  // 0x0
  public    static  System.Int32                    MAX_CONDITION_PRE_TRANSITION_COUNT  // 0x0
  public    static  System.Int32                    MAX_PARAMETER_COUNT  // 0x0
  public    static  System.Byte                     ANY_STATE_INDEX  // 0x0
  public    static  Unity.Collections.NativeParallelHashMap<System.Int32,System.UInt32>s_assetHashGuidToHandle  // 0x0
  public    static  Unity.Collections.NativeParallelHashMap<Unity.Mathematics.int2,System.Byte>s_stateNameHashToIndex  // 0x10
  public    static  Unity.Collections.NativeParallelHashMap<Unity.Mathematics.int2,System.Byte>s_parameterNameHashToIndex  // 0x20
METHODS:
  System.Void Initialize()
  System.Void InitFSMDefinition(System.Int32 guid, Beyond.Gameplay.Factory.ECSVATFSM.ECSVATFSMDefinitionData data)
  System.Void RegisterFSM(UnityEngine.HyperGryph.ECS.Entity rEntity, UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.String GetStateName(System.UInt32 fsmHandler, System.Byte stateIndex)
  System.Byte GetStateIndex(System.UInt32 fsmHandler, System.Int32 stateNameHash)
  System.Void Dispose()
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.SamplePredictCargo_000009FA$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000258
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(Beyond.Gameplay.Factory.ConveyorFragment* conveyor, Beyond.Gameplay.Factory.GlobalEnv* env, System.Single predictDistance, Unity.Mathematics.float3& position, Unity.Mathematics.quaternion& rotation)
  System.IAsyncResult BeginInvoke(Beyond.Gameplay.Factory.ConveyorFragment* conveyor, Beyond.Gameplay.Factory.GlobalEnv* env, System.Single predictDistance, Unity.Mathematics.float3& position, Unity.Mathematics.quaternion& rotation, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.SamplePredictCargo_000009FA$BurstDirectCall
TYPE:  class
TOKEN: 0x2000259
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(Beyond.Gameplay.Factory.ConveyorFragment* conveyor, Beyond.Gameplay.Factory.GlobalEnv* env, System.Single predictDistance, Unity.Mathematics.float3& position, Unity.Mathematics.quaternion& rotation)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.BurstBridge
TYPE:  class
TOKEN: 0x2000257
FIELDS:
METHODS:
  System.Void BeginProfilerSample(System.String name)
  System.Void EndProfilerSample()
  System.Void SamplePredictCargo(Beyond.Gameplay.Factory.ConveyorFragment* conveyor, Beyond.Gameplay.Factory.GlobalEnv* env, System.Single predictDistance, Unity.Mathematics.float3& position, Unity.Mathematics.quaternion& rotation)
  System.Void SamplePredictCargo$BurstManaged(Beyond.Gameplay.Factory.ConveyorFragment* conveyor, Beyond.Gameplay.Factory.GlobalEnv* env, System.Single predictDistance, Unity.Mathematics.float3& position, Unity.Mathematics.quaternion& rotation)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.QueryBuildingState_000009FE$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200025B
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  Beyond.GEnums.FacBuildingState Invoke(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingSubState& subState)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingSubState& subState, System.AsyncCallback , System.Object )
  Beyond.GEnums.FacBuildingState EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.QueryBuildingState_000009FE$BurstDirectCall
TYPE:  class
TOKEN: 0x200025C
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  Beyond.GEnums.FacBuildingState Invoke(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingSubState& subState)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.SetFlashStatue_00000A00$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200025D
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingState statue)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingState statue, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.SetFlashStatue_00000A00$BurstDirectCall
TYPE:  class
TOKEN: 0x200025E
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingState statue)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe._SetRenderEntityFlashStatue_00000A01$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x200025F
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& rendererEntity, System.Byte statue)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& rendererEntity, System.Byte statue, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe._SetRenderEntityFlashStatue_00000A01$BurstDirectCall
TYPE:  class
TOKEN: 0x2000260
FIELDS:
  private   static  System.IntPtr                   Pointer  // 0x0
  private   static  System.IntPtr                   DeferredCompilation  // 0x8
METHODS:
  System.Void GetFunctionPointerDiscard(System.IntPtr& )
  System.IntPtr GetFunctionPointer()
  System.Void Constructor()
  System.Void Initialize()
  System.Void .cctor()
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& rendererEntity, System.Byte statue)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.EntityExtensions
TYPE:  class
TOKEN: 0x200025A
FIELDS:
METHODS:
  Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& GetExtData(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.HyperGryph.ECS.EntityManager& em)
  Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& GetExtData(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr)
  System.Boolean QueryBuildingStateIsClosed(UnityEngine.HyperGryph.ECS.Entity logicEntity)
  Beyond.GEnums.FacBuildingState QueryBuildingState(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingSubState& subState)
  System.Boolean _IsPowerBuilding(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& logicEntity)
  System.Void SetFlashStatue(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingState statue)
  System.Void _SetRenderEntityFlashStatue(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& rendererEntity, System.Byte statue)
  System.Boolean CulledWithLogicEntity(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Boolean CulledWithRendererEntity(UnityEngine.HyperGryph.ECS.Entity rendererEntity, UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Boolean GetVisibility(UnityEngine.HyperGryph.ECS.Entity logicEntity, Beyond.Gameplay.Factory.Visibility.Type type)
  System.Boolean GetVisibility(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.Visibility.Type type)
  System.Boolean GetVisibility(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Beyond.Gameplay.Factory.Visibility.Type type)
  System.Boolean SetVisibility(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, System.Boolean visible, Beyond.Gameplay.Factory.Visibility.EFlag reasonFlag, Beyond.Gameplay.Factory.Visibility.Type type, System.Int16[] invisibleSubIndexList)
  System.Boolean SetVisibility(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& extData, System.Boolean visible, Beyond.Gameplay.Factory.Visibility.EFlag reasonFlag, Beyond.Gameplay.Factory.Visibility.Type type, System.Int16* subIndexListPtr, System.Int16 subIndexCount)
  System.Void SetVisibilityWithNotify(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, System.Boolean visible, Beyond.Gameplay.Factory.Visibility.EFlag reasonFlag, Beyond.Gameplay.Factory.Visibility.Type type, System.Int16[] invisibleSubIndexList)
  System.Boolean SetVisibility(UnityEngine.HyperGryph.ECS.Entity logicEntity, System.Boolean visible, Beyond.Gameplay.Factory.Visibility.EFlag reasonFlag, Beyond.Gameplay.Factory.Visibility.Type type, UnityEngine.HyperGryph.ECS.EntityCommandBuffer& ecb)
  System.Void SetInMainRegion(UnityEngine.HyperGryph.ECS.Entity logicEntity, System.Boolean value)
  System.Boolean IsInMainRegionFuzzy(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Boolean IsInMainRegion(Beyond.Gameplay.Factory.SharedDataFragment sharedData, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr)
  System.Void UpdatePipeEffect(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Void UpdatePipeEffect(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& ecb)
  System.Boolean GetBuildingExtendConfig(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Unity.Collections.FixedString32Bytes extendKey, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Unity.Mathematics.float3& pos, Unity.Mathematics.quaternion& rot, UnityEngine.HyperGryph.ECS.Entity& posRendererEntity)
  System.Boolean GetBuildingExtendConfig(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Unity.Collections.FixedString32Bytes extendKey, Unity.Mathematics.float3& pos, Unity.Mathematics.quaternion& rot, UnityEngine.HyperGryph.ECS.Entity& posRendererEntity)
  System.Boolean GetBuildingStaticMountWorldTRS(UnityEngine.HyperGryph.ECS.Entity entity, System.String extendKey, Unity.Mathematics.float3& pos, Unity.Mathematics.quaternion& rot)
  System.Boolean GetBuildingStaticMountWorldTRS(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.HyperGryph.ECS.EntityManager& em, Unity.Collections.FixedString32Bytes extendKey, Unity.Mathematics.float3& pos, Unity.Mathematics.quaternion& rot)
  System.Boolean GetBuildingStaticMountWorldTRS(UnityEngine.HyperGryph.ECS.Entity entity, UnityEngine.HyperGryph.ECS.EntityManager& em, Unity.Collections.FixedString32Bytes extendKey, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData* sharedDataPtr, Unity.Mathematics.float3& pos, Unity.Mathematics.quaternion& rot)
  Beyond.GEnums.FacBuildingState QueryBuildingState$BurstManaged(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingSubState& subState)
  System.Void SetFlashStatue$BurstManaged(UnityEngine.HyperGryph.ECS.Entity& logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, Beyond.GEnums.FacBuildingState statue)
  System.Void _SetRenderEntityFlashStatue$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& rendererEntity, System.Byte statue)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.GameplayExtensions
TYPE:  class
TOKEN: 0x2000261
FIELDS:
METHODS:
  Beyond.Gameplay.Factory.ChapterFragment& GetChapterEntity(UnityEngine.HyperGryph.ECS.EntityManager em, System.Int32 chapterId, System.Boolean& existed, UnityEngine.HyperGryph.ECS.Entity& chapterEntity)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.GlobalEnvExtensions
TYPE:  class
TOKEN: 0x2000262
FIELDS:
METHODS:
  Beyond.Gameplay.Factory.GlobalEnv* GetGlobalEnv(UnityEngine.HyperGryph.ECS.EntityManager em)
  System.IntPtr GetGlobalEnvPtr(UnityEngine.HyperGryph.ECS.EntityManager em)
  System.Boolean IsGlobalEnvValid(UnityEngine.HyperGryph.ECS.EntityManager em)
  Beyond.Gameplay.Factory.GlobalEnv& GetGlobalEnvRef(UnityEngine.HyperGryph.ECS.EntityManager em)
  System.Void SetNearBuildingPtr(Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& info, Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& infoLast)
  System.Void SetNearConveyorPtr(Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& info, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& infoLast)
  System.Void SetNearPipePtr(Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& info, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& infoLast)
  System.Boolean GetInteractFac(Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& info)
  System.Boolean GetInteractConveyor(Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& info)
  System.Boolean GetInteractPipe(Beyond.Gameplay.Factory.GlobalEnv& env, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& info)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.IAllocator
TYPE:  interface
TOKEN: 0x2000263
FIELDS:
METHODS:
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Allocate(System.Int32 size)
  System.Void Reserve(System.Int32 newCapacity)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Expand(System.Int32 startIndex, System.Int32 additionalSize)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Resize(System.Int32 startIndex, System.Int32 newSize)
  System.Void Free(System.Int32 startIndex)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.LinearAllocator
TYPE:  class
TOKEN: 0x2000264
FIELDS:
  private   static  System.Int32                    INITIAL_CAPACITY  // 0x0
  private           System.Int32                    m_totalCapacity  // 0x10
  private           System.Byte*                    m_memory  // 0x18
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Int32><freeBlocks>k__BackingField  // 0x20
  private   readonly System.Collections.Generic.Dictionary<System.Int32,System.Int32>m_allocations  // 0x28
METHODS:
  System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_freeBlocks()
  System.Void .ctor(System.Int32 capacity)
  System.Void _ExpandMemory()
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Allocate(System.Int32 size)
  System.Void Reserve(System.Int32 newCapacity)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Expand(System.Int32 startIndex, System.Int32 additionalSize)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Resize(System.Int32 startIndex, System.Int32 newSize)
  System.Void _MergeAdjacentFreeBlocks()
  System.Void Free(System.Int32 startIndex)
  System.Void* GetPointer(System.Int32 offset)
  System.Void Dispose()
  System.Void PrintAllocations()
  System.Void Finalize()
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.LinearAllocatorUnmanaged
TYPE:  struct
TOKEN: 0x2000267
FIELDS:
  private   static  System.Int32                    INITIAL_CAPACITY  // 0x0
  private           System.Int32                    m_totalCapacity  // 0x10
  private           System.Byte*                    m_memory  // 0x18
  private           Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32><freeBlocks>k__BackingField  // 0x20
  private           Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32>m_allocations  // 0x30
  private           System.Boolean                  m_initialized  // 0x40
  private           Unity.Collections.Allocator     m_allocator  // 0x44
METHODS:
  Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> get_freeBlocks()
  System.Void set_freeBlocks(Unity.Collections.NativeParallelHashMap<System.Int32,System.Int32> value)
  System.Void Initialize(System.Int32 capacity, Unity.Collections.Allocator allocator)
  System.Void _ExpandMemory()
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Allocate(System.Int32 size)
  System.Void Reserve(System.Int32 newCapacity)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Expand(System.Int32 startIndex, System.Int32 additionalSize)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation Resize(System.Int32 startIndex, System.Int32 newSize)
  System.Void _MergeAdjacentFreeBlocks()
  System.Void Free(System.Int32 startIndex)
  System.Void* GetPointer(System.Int64 offset)
  System.Void Dispose()
  System.Void PrintAllocations()
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader
TYPE:  struct
TOKEN: 0x2000269
FIELDS:
  public    static  System.Int32                    ALIGNMENT  // 0x0
  public            Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader*prev  // 0x10
  public            Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader*next  // 0x18
  public            Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader*prePhys  // 0x20
  public            System.UInt32                   size  // 0x28
  public            System.Boolean                  isFree  // 0x2C
METHODS:
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.TLSFAllocator
TYPE:  class
TOKEN: 0x200026A
FIELDS:
  private   static  System.Int32                    FIRST_LEVEL_INDEX_COUNT  // 0x0
  private   static  System.Int32                    SECOND_LEVEL_INDEX_COUNT  // 0x0
  private   static  System.Int32                    SMALL_BLOCK_SIZE  // 0x0
  private   static  System.Int32                    ALIGNMENT  // 0x0
  private           System.UInt32                   _flBitmap  // 0x10
  private           System.UInt32[]                 _slBitmap  // 0x18
  private           Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader*[,]_freeList  // 0x20
  private           System.IntPtr                   _memoryPool  // 0x28
  private           System.UInt32                   _poolSize  // 0x30
  private           Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader*_firstBlock  // 0x38
METHODS:
  System.Void .ctor(System.UInt32 size)
  System.Void Finalize()
  System.Void* Allocate(System.UInt32 size)
  System.Void Free(System.Void* ptr)
  System.UInt32 GetFreeSpace()
  Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* FindSuitableBlock(System.UInt32 size)
  System.Void InsertFreeBlock(Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* block)
  System.Void RemoveFreeBlock(Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* block)
  System.Void SplitBlock(Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* block, System.UInt32 size)
  Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* MergeBlock(Beyond.Gameplay.Factory.Unsafe.TLSFBlockHeader* block)
  System.Void MappingInsert(System.UInt32 size, System.Int32& fl, System.Int32& sl)
  System.Int32 MostSignificantBit(System.UInt32 value)
  System.Int32 FindFirstSet(System.UInt32 value)
  System.UInt32 AlignSize(System.UInt32 size)
END_CLASS

CLASS: Beyond.Gameplay.Factory.Unsafe.FactoryUnsafeUtil
TYPE:  class
TOKEN: 0x200026B
FIELDS:
  private   static  System.UInt32                   NO_NODE_ID_RANGE_MIN  // 0x0
  private   static  System.UInt32                   NO_NODE_ID_RANGE_MAX  // 0x0
  private   static  System.UInt32                   s_nodeId  // 0x0
METHODS:
  System.Boolean IsManualNodeId(System.UInt32 id)
  System.UInt32 AllocManualNodeId()
  System.Boolean IsPointInSector(Unity.Mathematics.float3 point, Unity.Mathematics.float3 center, Unity.Mathematics.float3 dir, System.Single checkRad, System.Single checkDist, System.Single& curDistanceSq, System.Single& curCosTheta, System.Boolean ignoreY)
  System.Void SwapPointer(T*& p1, T*& p2)
  System.IntPtr AddressOf(Beyond.Gameplay.Factory.GlobalEnv& env)
  System.Void CallFromLuaCheck()
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: Beyond.Gameplay.Factory.Util.JobHandlerExtensions
TYPE:  class
TOKEN: 0x2000256
FIELDS:
METHODS:
  System.Void SafeComplete(Unity.Jobs.JobHandle jobHandle)
END_CLASS

CLASS: Beyond.PoolCore.ListPoolInitializer_FactoryUnsafe_Gameplay_Beyond
TYPE:  class
TOKEN: 0x200002C
FIELDS:
  private   static  System.Boolean                  s_initialized  // 0x0
METHODS:
  System.Void InitializeAtRuntime()
  System.Void Initialize()
END_CLASS

CLASS: Beyond.SourceGenerator.CameraControlConfigAttribute
TYPE:  class
TOKEN: 0x2000028
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.ECSComponentAttribute
TYPE:  class
TOKEN: 0x2000029
EXTENDS: Attribute
FIELDS:
  public            System.Runtime.InteropServices.LayoutKindlayoutKind  // 0x10
  public            System.Boolean                  isTag  // 0x14
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.DataNAttribute
TYPE:  class
TOKEN: 0x200002A
EXTENDS: Attribute
FIELDS:
  public            System.Int32                    capacity  // 0x10
  public            System.Int32                    tSize  // 0x14
  public            System.Boolean                  ring  // 0x18
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: Beyond.SourceGenerator.AnimatorBlackboardAttribute
TYPE:  class
TOKEN: 0x200002B
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: FactoryUIAtlas.FactoryLiquidAtlasSOData
TYPE:  class
TOKEN: 0x2000005
EXTENDS: ScriptableObject
FIELDS:
  public            Beyond.SerializeFieldDictionary<System.String,Beyond.GEnums.FacItemSubType>m_liquidMaterial  // 0x18
  public            Beyond.SerializeFieldDictionary<Beyond.GEnums.FacItemSubType,System.Int32>m_liquidMatIndex  // 0x20
METHODS:
  System.Boolean GetMaterial(System.String mat, Beyond.GEnums.FacItemSubType& matName)
  System.Boolean GetAtlasMaterialSort(Beyond.GEnums.FacItemSubType matName, System.Int32& sort)
  FactoryUIAtlas.FactoryLiquidAtlasSOData CreateOrGet(System.String path)
  System.Void .ctor()
END_CLASS

CLASS: FactoryUIAtlas.FactoryUIAtlasSOData
TYPE:  class
TOKEN: 0x2000006
EXTENDS: ScriptableObject
FIELDS:
  public            Beyond.SerializeFieldDictionary<System.String,UnityEngine.RectInt>m_insertName  // 0x18
  public            Beyond.SerializeFieldDictionary<System.String,System.Int32>m_insertIndex  // 0x20
METHODS:
  System.Boolean GetRect(System.String texName, UnityEngine.RectInt& rect)
  System.Boolean GetIndex(System.String texName, System.Int32& index)
  FactoryUIAtlas.FactoryUIAtlasSOData CreateOrGet(System.String path)
  System.Void .ctor()
END_CLASS

CLASS: HG.Rendering.Runtime.HGConstantBufferLayoutAttribute
TYPE:  class
TOKEN: 0x2000004
EXTENDS: Attribute
FIELDS:
METHODS:
  System.Void .ctor()
END_CLASS

CLASS: IFix.ILFixDynamicMethodWrapper
TYPE:  class
TOKEN: 0x200026E
FIELDS:
  private           IFix.Core.VirtualMachine        virtualMachine  // 0x10
  private           System.Int32                    methodId  // 0x18
  private           System.Object                   anonObj  // 0x20
  public    static  IFix.ILFixDynamicMethodWrapper[]wrapperArray  // 0x0
METHODS:
  System.Void .ctor(IFix.Core.VirtualMachine virtualMachine, System.Int32 methodId, System.Object anonObj)
  System.Int32 __Gen_Wrap_0(System.Object P0)
  Unity.Collections.NativeArray<System.Int32> __Gen_Wrap_1(System.Object P0)
  System.Object __Gen_Wrap_2(System.Int32 P0)
  System.Void __Gen_Wrap_3()
  System.Void __Gen_Wrap_4(Beyond.Gameplay.Factory.PerDrawConfig& P0)
  System.Void __Gen_Wrap_5(Beyond.Gameplay.Factory.FFactoryStateColorConfig& P0)
  System.Void __Gen_Wrap_6(System.Object P0)
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> __Gen_Wrap_7()
  System.Void __Gen_Wrap_8(Beyond.Gameplay.Factory.ConveyorExtContainer& P0)
  System.UInt32 __Gen_Wrap_9(Beyond.Gameplay.Factory.ConveyorExtContainer& P0)
  System.Span<Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt> __Gen_Wrap_10(Beyond.Gameplay.Factory.ConveyorExtContainer& P0)
  System.UInt32 __Gen_Wrap_11(Beyond.Gameplay.Factory.ConveyorExtContainer& P0, Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& P1)
  System.Void __Gen_Wrap_12(Beyond.Gameplay.Factory.ConveyorExtContainer& P0, System.UInt32 P1)
  System.IntPtr __Gen_Wrap_13(Beyond.Gameplay.Factory.ConveyorExtContainer& P0)
  Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& __Gen_Wrap_14(Beyond.Gameplay.Factory.ConveyorExtContainer& P0, System.UInt32 P1)
  System.Void __Gen_Wrap_15(Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& P0)
  System.Void __Gen_Wrap_16(Beyond.Gameplay.Factory.Unsafe.LinearAllocatorUnmanaged& P0)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_17(Beyond.Gameplay.Factory.Unsafe.LinearAllocatorUnmanaged& P0, System.Int32 P1)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_18(Beyond.Gameplay.Factory.ConveyorInfoAllocator& P0, System.Int32 P1)
  System.Void __Gen_Wrap_19(Beyond.Gameplay.Factory.Unsafe.LinearAllocatorUnmanaged& P0, System.Int32 P1)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_20(Beyond.Gameplay.Factory.Unsafe.LinearAllocatorUnmanaged& P0, System.Int32 P1, System.Int32 P2)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_21(Beyond.Gameplay.Factory.ConveyorInfoAllocator& P0, Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation P1, System.Int32 P2)
  System.Void __Gen_Wrap_22(Beyond.Gameplay.Factory.ConveyorInfoAllocator& P0, System.UInt32 P1)
  System.Int64 __Gen_Wrap_23(Beyond.Gameplay.Factory.ConveyorInfoAllocator& P0, System.UInt32 P1)
  System.Int32 __Gen_Wrap_24(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> P0)
  System.Void __Gen_Wrap_25(Beyond.Gameplay.Factory.ConveyorInfoAllocator& P0)
  System.Void __Gen_Wrap_26(Beyond.Gameplay.Factory.SharedDataContainer& P0)
  System.UInt32 __Gen_Wrap_27(Beyond.Gameplay.Factory.SharedDataContainer& P0)
  System.Span<Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData> __Gen_Wrap_28(Beyond.Gameplay.Factory.SharedDataContainer& P0)
  System.UInt32 __Gen_Wrap_29(Beyond.Gameplay.Factory.SharedDataContainer& P0, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P1)
  System.Void __Gen_Wrap_30(Beyond.Gameplay.Factory.SharedDataContainer& P0, System.UInt32 P1)
  System.IntPtr __Gen_Wrap_31(Beyond.Gameplay.Factory.SharedDataContainer& P0)
  Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& __Gen_Wrap_32(Beyond.Gameplay.Factory.SharedDataContainer& P0, System.UInt32 P1)
  System.Boolean __Gen_Wrap_33(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P0, Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlag P1)
  System.Void __Gen_Wrap_34(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P0, Beyond.Gameplay.Factory.SharedDataContainer.DirtyFlag P1, System.Boolean P2)
  System.Boolean __Gen_Wrap_35(Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P0)
  Unity.Mathematics.float3 __Gen_Wrap_36(Beyond.Gameplay.Factory.WireRendererInfo& P0)
  Unity.Mathematics.quaternion __Gen_Wrap_37(Beyond.Gameplay.Factory.WireRendererInfo& P0)
  Unity.Collections.NativeParallelHashMap<Beyond.Gameplay.Factory.UnitId,UnityEngine.HyperGryph.ECS.Entity> __Gen_Wrap_38(System.Object P0)
  Beyond.Gameplay.Factory.UnitId __Gen_Wrap_39(System.Int32 P0, System.UInt32 P1)
  System.Void __Gen_Wrap_40(System.Object P0, System.Int32 P1, System.UInt32 P2, UnityEngine.HyperGryph.ECS.Entity P3)
  System.Boolean __Gen_Wrap_41(System.Object P0, System.Int32 P1, System.UInt32 P2)
  System.Boolean __Gen_Wrap_42(System.Object P0, System.Int32 P1, System.UInt32 P2, UnityEngine.HyperGryph.ECS.Entity& P3)
  System.Void __Gen_Wrap_43(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0)
  System.UInt32 __Gen_Wrap_44()
  System.Void __Gen_Wrap_45(System.UInt32 P0)
  Beyond.Gameplay.Factory.ConveyorExtContainer.ConveyorExt& __Gen_Wrap_46(System.UInt32 P0)
  System.IntPtr __Gen_Wrap_47()
  System.UInt32 __Gen_Wrap_48(System.Boolean P0)
  Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& __Gen_Wrap_49(System.UInt32 P0)
  UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& __Gen_Wrap_50(System.UInt32 P0)
  UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& __Gen_Wrap_51(System.Int32 P0)
  Unity.Mathematics.float4x4 __Gen_Wrap_52(Beyond.Gameplay.Factory.LocalTransform& P0)
  Unity.Mathematics.float4x4 __Gen_Wrap_53(UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& P0)
  System.UInt32 __Gen_Wrap_54(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& P1)
  System.UInt32 __Gen_Wrap_55(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& P0)
  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& __Gen_Wrap_56(System.UInt32 P0)
  System.Void __Gen_Wrap_57(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0, System.UInt32 P1)
  System.IntPtr __Gen_Wrap_58(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0)
  Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType __Gen_Wrap_59(Beyond.Gameplay.Factory.AdditiveEffectFragment& P0)
  System.Void __Gen_Wrap_60(Beyond.Gameplay.Factory.AdditiveEffectFragment& P0)
  System.Void __Gen_Wrap_61(Beyond.Gameplay.Factory.AdditiveEffectFragment& P0, Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType P1)
  System.Void __Gen_Wrap_62(Beyond.Gameplay.Factory.AdditiveEffectFragment& P0, System.Int32 P1, Beyond.Gameplay.Factory.AdditiveEffectFragment.AdditiveEffectType P2)
  System.String __Gen_Wrap_63(Beyond.Gameplay.Factory.AdditiveEffectFragment& P0)
  System.Void __Gen_Wrap_64(Beyond.Gameplay.Factory.CutoffState& P0, System.Boolean P1)
  System.Void __Gen_Wrap_65(Beyond.Gameplay.Factory.CutoffState& P0, System.Single P1)
  System.Void __Gen_Wrap_66(Beyond.Gameplay.Factory.CutoffState& P0, System.UInt32 P1)
  System.Void __Gen_Wrap_67(Beyond.Gameplay.Factory.BuildDismissState& P0, System.Boolean P1)
  System.Void __Gen_Wrap_68(Beyond.Gameplay.Factory.HighLightState& P0, System.Boolean P1)
  System.Void __Gen_Wrap_69(Beyond.Gameplay.Factory.HighLightState& P0, System.Boolean P1, System.Boolean P2)
  Beyond.Gameplay.Factory.LogicEntityState __Gen_Wrap_70(Beyond.Gameplay.Factory.HighLightState& P0)
  System.Boolean __Gen_Wrap_71(Beyond.Gameplay.Factory.HighLightState& P0, System.Byte P1)
  System.Void __Gen_Wrap_72(Beyond.Gameplay.Factory.HighLightState& P0, System.Byte P1, System.Boolean P2)
  System.Void __Gen_Wrap_73(Beyond.Gameplay.Factory.HighLightState& P0)
  System.Void __Gen_Wrap_74(Beyond.Gameplay.Factory.HintState& P0, System.Boolean P1)
  System.Void __Gen_Wrap_75(Beyond.Gameplay.Factory.FigureState& P0, System.Boolean P1)
  System.Void __Gen_Wrap_76(Beyond.Gameplay.Factory.OverloadState& P0, System.Boolean P1)
  System.Void __Gen_Wrap_77(Beyond.Gameplay.Factory.OverloadInvalidState& P0, System.Boolean P1)
  System.Void __Gen_Wrap_78(Beyond.Gameplay.Factory.DitherState& P0, System.Boolean P1)
  System.Void __Gen_Wrap_79(Beyond.Gameplay.Factory.BlueprintState& P0, System.Boolean P1)
  System.Void __Gen_Wrap_80(Beyond.Gameplay.Factory.BlueprintState& P0, System.Boolean P1, Beyond.Gameplay.Factory.BlueprintState.EffectType P2)
  System.Boolean __Gen_Wrap_81(Beyond.Gameplay.Factory.BlueprintState& P0, System.Byte P1)
  System.Void __Gen_Wrap_82(Beyond.Gameplay.Factory.BlueprintState& P0, System.Byte P1, System.Boolean P2)
  System.Void __Gen_Wrap_83(Beyond.Gameplay.Factory.BlueprintState& P0)
  System.Void __Gen_Wrap_84(Beyond.Gameplay.Factory.PreSelectState& P0, System.Boolean P1)
  System.Boolean __Gen_Wrap_85(Beyond.Gameplay.Factory.PreSelectState& P0, System.Byte P1)
  System.Void __Gen_Wrap_86(Beyond.Gameplay.Factory.PreSelectState& P0, System.Byte P1, System.Boolean P2)
  System.Void __Gen_Wrap_87(Beyond.Gameplay.Factory.PreSelectState& P0)
  System.Void __Gen_Wrap_88(Beyond.Gameplay.Factory.SoloSelectState& P0, System.Boolean P1)
  System.Boolean __Gen_Wrap_89(Beyond.Gameplay.Factory.SoloSelectState& P0, System.Int32 P1)
  System.Void __Gen_Wrap_90(Beyond.Gameplay.Factory.ContinuationState& P0, System.Boolean P1)
  System.Boolean __Gen_Wrap_91(Beyond.Gameplay.Factory.ContinuationState& P0, System.Byte P1)
  System.Void __Gen_Wrap_92(Beyond.Gameplay.Factory.ContinuationState& P0, System.Byte P1, System.Boolean P2)
  System.Void __Gen_Wrap_93(Beyond.Gameplay.Factory.ContinuationState& P0)
  System.Void __Gen_Wrap_94(Beyond.Gameplay.Factory.SocialSharingState& P0, System.Boolean P1)
  System.Void __Gen_Wrap_95(Beyond.Gameplay.Factory.PowerInteractionState& P0, System.Boolean P1)
  System.Boolean __Gen_Wrap_96(Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& P0)
  System.Void __Gen_Wrap_97(Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& P0)
  System.Void __Gen_Wrap_98(Beyond.Gameplay.Factory.BattleFragment& P0)
  System.Boolean __Gen_Wrap_99(Beyond.Gameplay.Factory.BindRenderEntityFragment& P0, UnityEngine.HyperGryph.ECS.Entity P1)
  System.Void __Gen_Wrap_100(Beyond.Gameplay.Factory.BindRenderEntityFragment& P0, UnityEngine.HyperGryph.ECS.Entity P1)
  System.Void __Gen_Wrap_101(Beyond.Gameplay.Factory.BindRenderEntityFragment& P0, System.Object P1)
  System.Void __Gen_Wrap_102(Beyond.Gameplay.Factory.BindRenderEntityFragment& P0, Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> P1)
  System.Void __Gen_Wrap_103(Beyond.Gameplay.Factory.BindRenderEntityFragment& P0)
  System.Boolean __Gen_Wrap_104(Beyond.Gameplay.Factory.BindRenderEntityFragment& P0)
  System.Void __Gen_Wrap_105(Beyond.Gameplay.Factory.BurnPowerFragment& P0)
  System.Void __Gen_Wrap_106(Beyond.Gameplay.Factory.BusFragment& P0)
  System.Void __Gen_Wrap_107(Beyond.Gameplay.Factory.BusFreeFragment& P0)
  System.Int32 __Gen_Wrap_108(Beyond.Gameplay.Factory.CacheFragment& P0, System.Boolean P1, System.Boolean P2, System.Int32 P3, System.Int32 P4, Beyond.Gameplay.Factory.FactoryItem*& P5)
  System.Void __Gen_Wrap_109(Beyond.Gameplay.Factory.CacheFragment& P0, System.Boolean P1, System.Boolean P2, System.Int32 P3, System.Int32 P4, System.UInt32& P5, System.Int32& P6, System.Int64& P7)
  System.Void __Gen_Wrap_110(Beyond.Gameplay.Factory.CacheFragment& P0, System.Boolean P1, System.Boolean P2, System.Int32 P3, System.Int32 P4, System.UInt32 P5, System.Int32 P6, System.Int64 P7)
  System.Void __Gen_Wrap_111(Beyond.Gameplay.Factory.CacheFragment& P0, System.Boolean P1, System.Boolean P2, System.Int32 P3, System.Int32 P4)
  System.Void __Gen_Wrap_112(Beyond.Gameplay.Factory.CacheFragment& P0)
  System.Void __Gen_Wrap_113(Beyond.Gameplay.Factory.CacheTransportFragment& P0)
  System.Single __Gen_Wrap_114(Beyond.Gameplay.Factory.CargoFragment& P0, System.Int64 P1)
  System.Int32 __Gen_Wrap_115(Beyond.Gameplay.Factory.CargoFragment& P0, Beyond.Gameplay.Factory.CargoFragment P1)
  Beyond.Gameplay.Factory.CargoFragment __Gen_Wrap_116(System.UInt32 P0, Unity.Mathematics.int4 P1, Unity.Mathematics.int4 P2, System.Int32 P3, System.Int32 P4, System.Int64 P5, System.Int32 P6, System.Single P7, System.Boolean P8)
  System.Void __Gen_Wrap_117(Beyond.Gameplay.Factory.CargoFragment& P0)
  System.Void __Gen_Wrap_118(Beyond.Gameplay.Factory.CargoRendererFragment& P0)
  System.Void __Gen_Wrap_119(Beyond.Gameplay.Factory.ChapterFragment& P0)
  System.Void __Gen_Wrap_120(Beyond.Gameplay.Factory.CollectorFragment& P0)
  System.Boolean __Gen_Wrap_121(Beyond.Gameplay.Factory.ConnectionFragment& P0)
  System.Void __Gen_Wrap_122(Beyond.Gameplay.Factory.ConnectionFragment& P0)
  System.Void __Gen_Wrap_123(Beyond.Gameplay.Factory.GlobalEnv& P0, System.UInt32 P1, System.Int32 P2, Beyond.Gameplay.Factory.ConveyorInfoAllocator.Info*& P3)
  System.Void __Gen_Wrap_124(Unity.Collections.NativeList<Unity.Mathematics.float3> P0, UnityEngine.Rect& P1)
  System.Void __Gen_Wrap_125(Beyond.Gameplay.Factory.ConveyorFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, Unity.Collections.NativeList<Unity.Mathematics.float3>& P2, Unity.Collections.NativeList<Unity.Mathematics.float3>& P3, Unity.Collections.NativeArray<System.Byte>& P4)
  System.Boolean __Gen_Wrap_126(Beyond.Gameplay.Factory.ConveyorFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, Unity.Mathematics.float2 P2, System.UInt32& P3, System.Int32& P4)
  System.Boolean __Gen_Wrap_127(Beyond.Gameplay.Factory.ConveyorFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Single P2, System.Single P3, System.Single P4, System.Single P5)
  System.Boolean __Gen_Wrap_128(Beyond.Gameplay.Factory.ConveyorFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Single P2, System.Single P3, System.Single P4, System.Single P5, Beyond.PoolCore.PooledList<System.Int32>& P6)
  System.Boolean __Gen_Wrap_129(Beyond.Gameplay.Factory.ConveyorFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Single P2, System.Single P3, System.Single P4, System.Single P5, System.ValueTuple<System.UInt32,System.Int32>[,]& P6)
  System.Void __Gen_Wrap_130(Beyond.Gameplay.Factory.ConveyorFragment& P0, System.Single P1)
  System.Void __Gen_Wrap_131(Beyond.Gameplay.Factory.ConveyorFragment& P0)
  System.Void __Gen_Wrap_132(Beyond.Gameplay.Factory.ConveyorLogisticsUnitFragment& P0)
  System.Void __Gen_Wrap_133(Beyond.Gameplay.Factory.ConveyorRenderFragment& P0)
  System.Void __Gen_Wrap_134(Beyond.Gameplay.Factory.ConveyorRenderLeftFragment& P0)
  System.Void __Gen_Wrap_135(Beyond.Gameplay.Factory.ConveyorRenderRightFragment& P0)
  System.Void __Gen_Wrap_136(Beyond.Gameplay.Factory.ConveyorRenderMidFragment& P0)
  System.Void __Gen_Wrap_137(Beyond.Gameplay.Factory.CullResultFragment& P0)
  System.Void __Gen_Wrap_138(Beyond.Gameplay.Factory.DebugFragment& P0)
  System.Void __Gen_Wrap_139(Beyond.Gameplay.Factory.EvtDestroyUnit& P0)
  System.Boolean __Gen_Wrap_140(Beyond.Gameplay.Factory.DisabledTag& P0, System.Int32 P1)
  System.Void __Gen_Wrap_141(Beyond.Gameplay.Factory.DisabledTag& P0, System.Int32 P1)
  System.Void __Gen_Wrap_142(Beyond.Gameplay.Factory.DisabledTag& P0)
  System.Void __Gen_Wrap_143(Beyond.Gameplay.Factory.ShowStateUI& P0)
  System.Void __Gen_Wrap_144(Beyond.Gameplay.Factory.ShowNameUI& P0)
  System.Void __Gen_Wrap_145(Beyond.Gameplay.Factory.HasRenderer& P0)
  System.Void __Gen_Wrap_146(Beyond.Gameplay.Factory.EvtUpdatePipeEffect& P0)
  System.Void __Gen_Wrap_147(Beyond.Gameplay.Factory.EvtChangeTemplate& P0)
  System.Void __Gen_Wrap_148(Beyond.Gameplay.Factory.EvtCreateUnitRenderer& P0)
  System.Void __Gen_Wrap_149(Beyond.Gameplay.Factory.EvtUpdateStatusEffect& P0)
  System.Void __Gen_Wrap_150(Beyond.Gameplay.Factory.EvtPendingCreateRenderer& P0)
  System.Void __Gen_Wrap_151(Beyond.Gameplay.Factory.EvtUpdateRendererProperty& P0)
  System.Void __Gen_Wrap_152(Beyond.Gameplay.Factory.EvtStatusChange& P0)
  System.Void __Gen_Wrap_153(Beyond.Gameplay.Factory.EvtCreateInteract& P0)
  System.Void __Gen_Wrap_154(Beyond.Gameplay.Factory.EvtVatUpdate& P0)
  System.Void __Gen_Wrap_155(Beyond.Gameplay.Factory.EvtUpdatePedestalColorLUT& P0)
  System.Void __Gen_Wrap_156(Beyond.Gameplay.Factory.EvtAudio& P0)
  System.Void __Gen_Wrap_157(Beyond.Gameplay.Factory.AudioFragment& P0)
  System.Void __Gen_Wrap_158(Beyond.Gameplay.Factory.ReleaseTagFragment& P0)
  System.Void __Gen_Wrap_159(Beyond.Gameplay.Factory.CurMapUnitTag& P0)
  Beyond.Gameplay.Factory.UnitFragment __Gen_Wrap_160(System.UInt32 P0, System.Object P1, System.Int32 P2, Unity.Mathematics.bool2 P3, System.Int32 P4, System.UInt32 P5, System.Object P6, System.Boolean P7, System.Boolean P8, System.Boolean P9, System.Int64 P10, System.Boolean P11, System.Object P12)
  System.Void __Gen_Wrap_161(Beyond.Gameplay.Factory.UnitFragment& P0)
  System.Void __Gen_Wrap_162(Beyond.Gameplay.Factory.UnitRenderPipeLogisticsFigureReplaceFragment& P0)
  System.Void __Gen_Wrap_163(Beyond.Gameplay.Factory.BusRenderFragment& P0)
  System.Void __Gen_Wrap_164(Beyond.Gameplay.Factory.UnitRenderBuildingFragment& P0)
  System.Void __Gen_Wrap_165(Beyond.Gameplay.Factory.UnitRenderPedestalFragment& P0)
  System.Void __Gen_Wrap_166(Beyond.Gameplay.Factory.UnitRendererRegularFragment& P0)
  System.Void __Gen_Wrap_167(Beyond.Gameplay.Factory.UnitOnlyRendererFragment& P0)
  System.Void __Gen_Wrap_168(Beyond.Gameplay.Factory.FakeUnitFragment& P0)
  System.Void __Gen_Wrap_169(Beyond.Gameplay.Factory.UIUnitFragment& P0)
  System.Void __Gen_Wrap_170(Beyond.Gameplay.Factory.GuideHintFragment& P0)
  System.Void __Gen_Wrap_171(Beyond.Gameplay.Factory.UnitPreviewFragment& P0)
  System.Void __Gen_Wrap_172(Beyond.Gameplay.Factory.ConveyorRegularFragment& P0)
  System.Void __Gen_Wrap_173(Beyond.Gameplay.Factory.ConveyorGuideFragment& P0)
  System.Void __Gen_Wrap_174(Beyond.Gameplay.Factory.PipeRegularFragment& P0)
  System.Void __Gen_Wrap_175(Beyond.Gameplay.Factory.ConveyorPreviewRendererFragment& P0)
  System.Void __Gen_Wrap_176(Beyond.Gameplay.Factory.PipePreviewRendererFragment& P0)
  System.Void __Gen_Wrap_177(Beyond.Gameplay.Factory.PipePreviewFragment& P0)
  System.Void __Gen_Wrap_178(Beyond.Gameplay.Factory.FigureRenderFragment& P0)
  System.Void __Gen_Wrap_179(Beyond.Gameplay.Factory.FigureRenderLeftFragment& P0)
  System.Void __Gen_Wrap_180(Beyond.Gameplay.Factory.FigureRenderRightFragment& P0)
  System.Void __Gen_Wrap_181(Beyond.Gameplay.Factory.FigureRenderMidFragment& P0)
  System.Void __Gen_Wrap_182(Beyond.Gameplay.Factory.FigureRenderPipeHolderFragment& P0)
  System.Void __Gen_Wrap_183(Beyond.Gameplay.Factory.FluidConsumeFragment& P0)
  System.Void __Gen_Wrap_184(Beyond.Gameplay.Factory.FluidContainerFragment& P0, System.Int32 P1, System.Int32 P2, System.Int32 P3, System.Int32 P4, System.Int32 P5)
  System.Void __Gen_Wrap_185(Beyond.Gameplay.Factory.FluidContainerFragment& P0, System.Int32 P1, System.Int32 P2)
  System.Boolean __Gen_Wrap_186(Beyond.Gameplay.Factory.FluidContainerFragment& P0, System.Int32 P1, System.Int32& P2, System.Int32& P3, System.Single& P4, System.Int32& P5, System.Int32& P6)
  System.Boolean __Gen_Wrap_187(Beyond.Gameplay.Factory.FluidContainerFragment& P0)
  System.Void __Gen_Wrap_188(Beyond.Gameplay.Factory.FluidContainerFragment& P0, System.Single P1)
  System.ValueTuple<System.Int32,System.UInt32> __Gen_Wrap_189(Beyond.Gameplay.Factory.FluidContainerFragment& P0)
  System.Void __Gen_Wrap_190(Beyond.Gameplay.Factory.FluidContainerFragment& P0)
  System.Void __Gen_Wrap_191(Beyond.Gameplay.Factory.FluidPumpInFragment& P0)
  System.Void __Gen_Wrap_192(Beyond.Gameplay.Factory.FluidPumpOutFragment& P0)
  System.Void __Gen_Wrap_193(Beyond.Gameplay.Factory.FluidReactionFragment& P0)
  System.Void __Gen_Wrap_194(Beyond.Gameplay.Factory.FluidSprayFragment& P0)
  System.Void __Gen_Wrap_195(Beyond.Gameplay.Factory.FormulaManualFragment& P0)
  System.Void __Gen_Wrap_196(Beyond.Gameplay.Factory.OutOfBufferWarning& P0)
  System.String __Gen_Wrap_197(Beyond.Gameplay.Factory.OutOfBufferWarning& P0)
  System.Void __Gen_Wrap_198(Beyond.Gameplay.Factory.GlobalEnv& P0)
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Unity.Mathematics.float4x4> __Gen_Wrap_199(Beyond.Gameplay.Factory.GlobalEnv& P0)
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Beyond.Gameplay.Factory.OutputRendererInfo> __Gen_Wrap_200(Beyond.Gameplay.Factory.GlobalEnv& P0)
  System.Boolean __Gen_Wrap_201(Beyond.Gameplay.Factory.GlobalEnv& P0)
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<UnityEngine.Matrix4x4> __Gen_Wrap_202(Beyond.Gameplay.Factory.GlobalEnv& P0)
  Beyond.Gameplay.Factory.ConveyorInfoAllocator.Info& __Gen_Wrap_203(Beyond.Gameplay.Factory.GlobalEnv& P0, System.UInt32 P1, System.Int32 P2)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_204(Beyond.Gameplay.Factory.GlobalEnv& P0, System.Int32 P1)
  System.Int64 __Gen_Wrap_205(Beyond.Gameplay.Factory.GlobalEnv& P0, System.UInt32 P1)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_206(Beyond.Gameplay.Factory.GlobalEnv& P0, System.UInt32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_207(Beyond.Gameplay.Factory.GlobalEnv& P0, System.UInt32 P1)
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest> __Gen_Wrap_208(Beyond.Gameplay.Factory.GlobalEnv& P0)
  System.Boolean __Gen_Wrap_209(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition P0, System.Int32 P1, System.Byte& P2, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType& P3)
  System.Byte __Gen_Wrap_210(System.UInt32 P0, System.Int32 P1)
  System.Void __Gen_Wrap_211(Beyond.Gameplay.Factory.GlobalEnv& P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, UnityEngine.HyperGryph.ECS.Entity P2, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest& P3)
  System.Void __Gen_Wrap_212(Beyond.Gameplay.Factory.GlobalEnv& P0, UnityEngine.HyperGryph.ECS.Entity P1, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.SetAnimatorParamRequest P2)
  Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATFSMAudioData> __Gen_Wrap_213(Beyond.Gameplay.Factory.GlobalEnv& P0)
  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMProcessor.VATFSMAudioData& __Gen_Wrap_214(Beyond.Gameplay.Factory.GlobalEnv& P0, System.Int32 P1)
  System.Int32 __Gen_Wrap_215(Beyond.Gameplay.Factory.GlobalEnv& P0)
  System.Void __Gen_Wrap_216(Beyond.Gameplay.Factory.HealthPoleFragment& P0)
  System.Void __Gen_Wrap_217(Beyond.Gameplay.Factory.InventoryFragment& P0)
  System.Void __Gen_Wrap_218(Beyond.Gameplay.Factory.LogisticEffectFragment& P0)
  System.Void __Gen_Wrap_219(Beyond.Gameplay.Factory.LogisticEntityBindFragment& P0, UnityEngine.HyperGryph.ECS.Entity P1, System.UInt32 P2)
  System.Boolean __Gen_Wrap_220(Beyond.Gameplay.Factory.LogisticEntityBindFragment& P0, UnityEngine.HyperGryph.ECS.Entity& P1)
  System.Void __Gen_Wrap_221(Beyond.Gameplay.Factory.LogisticEntityBindFragment& P0)
  System.Void __Gen_Wrap_222(Beyond.Gameplay.Factory.MapGridRendererFragment& P0)
  System.Void __Gen_Wrap_223(Beyond.Gameplay.Factory.OutputFragment& P0)
  Unity.Mathematics.float4& __Gen_Wrap_224(Beyond.Gameplay.Factory.OutputFragment& P0, System.Int32 P1)
  System.Void __Gen_Wrap_225(Beyond.Gameplay.Factory.OutputFragment& P0, System.Int32 P1, Unity.Mathematics.float4 P2)
  System.Void __Gen_Wrap_226(Beyond.Gameplay.Factory.OutputFragment& P0, System.Int32 P1, UnityEngine.Color P2)
  System.Void __Gen_Wrap_227(Beyond.Gameplay.Factory.OutputFragment& P0, System.Int32 P1, UnityEngine.RectInt P2)
  System.Boolean __Gen_Wrap_228(Beyond.Gameplay.Factory.OutputFragment& P0, System.Int32 P1)
  System.Void __Gen_Wrap_229(Beyond.Gameplay.Factory.OutputFragment& P0, System.Int32 P1, System.Boolean P2)
  System.Boolean __Gen_Wrap_230(Beyond.Gameplay.Factory.OutputFragment& P0)
  System.Void __Gen_Wrap_231(Beyond.Gameplay.Factory.OutputUIRendererFragment& P0)
  System.Void __Gen_Wrap_232(Beyond.Gameplay.Factory.PedestalLightFlashFragment& P0)
  System.Boolean __Gen_Wrap_233(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0)
  System.Void __Gen_Wrap_234(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0, System.Int32 P1, System.Single P2)
  System.Void __Gen_Wrap_235(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0, System.Int32 P1, System.Boolean P2)
  System.Void __Gen_Wrap_236(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0, System.Int32 P1, UnityEngine.Color P2)
  System.Single __Gen_Wrap_237(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0, System.Int32 P1)
  System.Boolean __Gen_Wrap_238(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0, System.Int32 P1)
  Unity.Mathematics.float4 __Gen_Wrap_239(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0, System.Int32 P1)
  System.Void __Gen_Wrap_240(Beyond.Gameplay.Factory.PedestalLightFlashConfigFragment& P0)
  System.Void __Gen_Wrap_241(Beyond.Gameplay.Factory.PipeEffectFragment& P0)
  System.Boolean __Gen_Wrap_242(Beyond.Gameplay.Factory.PipeFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, Unity.Collections.NativeList<Unity.Mathematics.float3>& P2, Unity.Collections.NativeList<Unity.Mathematics.float3>& P3, Unity.Collections.NativeList<System.Byte>& P4)
  System.Void __Gen_Wrap_243(Beyond.Gameplay.Factory.GlobalEnv& P0, System.Int32 P1, System.UInt32 P2, System.Single P3, System.Boolean P4, System.Single P5, System.Boolean P6, System.Single P7)
  System.ValueTuple<System.Int32[],System.Int32> __Gen_Wrap_244(Beyond.Gameplay.Factory.GlobalEnv& P0, System.UInt32 P1, System.Int32 P2)
  System.Boolean __Gen_Wrap_245(Beyond.Gameplay.Factory.PipeFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, Unity.Mathematics.float2 P2, System.UInt32& P3, System.Int32& P4)
  System.Boolean __Gen_Wrap_246(Beyond.Gameplay.Factory.PipeFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Single P2, System.Single P3, System.Single P4, System.Single P5)
  System.Boolean __Gen_Wrap_247(Beyond.Gameplay.Factory.PipeFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Single P2, System.Single P3, System.Single P4, System.Single P5, Beyond.PoolCore.PooledList<System.Int32>& P6)
  System.Boolean __Gen_Wrap_248(Beyond.Gameplay.Factory.PipeFragment& P0, Beyond.Gameplay.Factory.GlobalEnv& P1, System.Single P2, System.Single P3, System.Single P4, System.Single P5, System.ValueTuple<System.UInt32,System.Int32>[,]& P6)
  System.Void __Gen_Wrap_249(Beyond.Gameplay.Factory.PipeFragment& P0)
  System.Void __Gen_Wrap_250(Beyond.Gameplay.Factory.PipeHolderFragment& P0)
  System.Void __Gen_Wrap_251(Beyond.Gameplay.Factory.PipeLogisticsUnitFragment& P0)
  System.Void __Gen_Wrap_252(Beyond.Gameplay.Factory.PipeComRenderFragment& P0)
  System.Void __Gen_Wrap_253(Beyond.Gameplay.Factory.PipeRenderFragment& P0)
  System.Void __Gen_Wrap_254(Beyond.Gameplay.Factory.PipeTrackRenderFragment& P0)
  System.Void __Gen_Wrap_255(Beyond.Gameplay.Factory.PipeRenderLeftFragment& P0)
  System.Void __Gen_Wrap_256(Beyond.Gameplay.Factory.PipeRenderRightFragment& P0)
  System.Void __Gen_Wrap_257(Beyond.Gameplay.Factory.PipeRenderMidFragment& P0)
  System.Boolean __Gen_Wrap_258(Beyond.Gameplay.Factory.ComplexPortFragment& P0, System.UInt32 P1, System.Int32 P2, System.Boolean P3, System.Boolean P4, System.UInt32 P5, System.Boolean& P6)
  System.Boolean __Gen_Wrap_259(Beyond.Gameplay.Factory.ComplexPortFragment& P0, System.UInt32 P1, System.Boolean P2, System.Object P3)
  System.Boolean __Gen_Wrap_260(Beyond.Gameplay.Factory.ComplexPortFragment& P0, System.Boolean P1, System.Object P2, System.Boolean P3)
  System.Void __Gen_Wrap_261(Beyond.Gameplay.Factory.ComplexPortFragment& P0, Unity.Mathematics.float3 P1, Unity.Mathematics.float3 P2, Beyond.Gameplay.Factory.UnitConfigFragment& P3, System.Single P4)
  System.Boolean __Gen_Wrap_262(Beyond.Gameplay.Factory.ComplexPortFragment& P0)
  System.String __Gen_Wrap_263(Beyond.Gameplay.Factory.PortData& P0)
  System.String __Gen_Wrap_264(Beyond.Gameplay.Factory.ComplexPortFragment& P0)
  System.Void __Gen_Wrap_265(Beyond.Gameplay.Factory.ComplexPortFragment& P0)
  Unity.Mathematics.float4x4 __Gen_Wrap_266(Beyond.Gameplay.Factory.PortData& P0)
  System.Void __Gen_Wrap_267(Beyond.Gameplay.Factory.PortPreviewUIRendererFragment& P0)
  System.Void __Gen_Wrap_268(Beyond.Gameplay.Factory.PortStatusUIFragment& P0)
  System.Void __Gen_Wrap_269(Beyond.Gameplay.Factory.PowerPoleFragment& P0)
  System.Void __Gen_Wrap_270(Beyond.Gameplay.Factory.ProducerFragment& P0)
  Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& __Gen_Wrap_271(Beyond.Gameplay.Factory.SharedDataFragment& P0)
  System.Void __Gen_Wrap_272(Beyond.Gameplay.Factory.SharedDataFragment& P0)
  Beyond.Gameplay.Factory.SocialFragment __Gen_Wrap_273(System.UInt64 P0, System.UInt32 P1, System.UInt64 P2, System.Int64 P3, System.Int64 P4, System.UInt32 P5, System.Boolean P6)
  System.Boolean __Gen_Wrap_274(Beyond.Gameplay.Factory.SocialFragment& P0)
  System.Void __Gen_Wrap_275(Beyond.Gameplay.Factory.SocialFragment& P0)
  System.String __Gen_Wrap_276(Beyond.Gameplay.Factory.SignData& P0)
  System.Single __Gen_Wrap_277(System.Object P0, Unity.Mathematics.uint3 P1)
  System.Void __Gen_Wrap_278(System.Object P0, UnityEngine.HyperGryph.ECS.Entity P1, Unity.Mathematics.uint3 P2)
  System.Void __Gen_Wrap_279(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, UnityEngine.HyperGryph.ECS.Entity P2)
  Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_280(Unity.Mathematics.float4x4 P0)
  Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_281(Unity.Mathematics.float3 P0, Unity.Mathematics.quaternion P1)
  Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_282(Unity.Mathematics.float3 P0, Unity.Mathematics.quaternion P1, System.Single P2)
  Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_283(Unity.Mathematics.float3 P0)
  Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_284(System.Single P0, System.Single P1, System.Single P2)
  Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_285(Unity.Mathematics.quaternion P0)
  Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_286(System.Single P0)
  System.String __Gen_Wrap_287(Beyond.Gameplay.Factory.LocalTransform& P0)
  Unity.Mathematics.float3 __Gen_Wrap_288(Beyond.Gameplay.Factory.LocalTransform& P0, Unity.Mathematics.float3 P1)
  Unity.Mathematics.float3 __Gen_Wrap_289(Beyond.Gameplay.Factory.LocalTransform& P0)
  Unity.Mathematics.quaternion __Gen_Wrap_290(Beyond.Gameplay.Factory.LocalTransform& P0, Unity.Mathematics.quaternion P1)
  System.Single __Gen_Wrap_291(Beyond.Gameplay.Factory.LocalTransform& P0, System.Single P1)
  Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_292(Beyond.Gameplay.Factory.LocalTransform& P0, Beyond.Gameplay.Factory.LocalTransform& P1)
  Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_293(Beyond.Gameplay.Factory.LocalTransform& P0)
  Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_294(Beyond.Gameplay.Factory.LocalTransform& P0, Unity.Mathematics.float3 P1)
  Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_295(Beyond.Gameplay.Factory.LocalTransform& P0, System.Single P1, System.Single P2, System.Single P3)
  Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_296(Beyond.Gameplay.Factory.LocalTransform& P0, Unity.Mathematics.quaternion P1)
  Beyond.Gameplay.Factory.LocalTransform __Gen_Wrap_297(Beyond.Gameplay.Factory.LocalTransform& P0, System.Single P1)
  System.Boolean __Gen_Wrap_298(Beyond.Gameplay.Factory.LocalTransform& P0, Beyond.Gameplay.Factory.LocalTransform& P1)
  System.Void __Gen_Wrap_299(Beyond.Gameplay.Factory.LocalTransform& P0)
  System.Void __Gen_Wrap_300(Beyond.Gameplay.Factory.Root& P0)
  System.Void __Gen_Wrap_301(Beyond.Gameplay.Factory.Parent& P0)
  System.Void __Gen_Wrap_302(Beyond.Gameplay.Factory.Child& P0)
  System.Boolean __Gen_Wrap_303(Beyond.Gameplay.Factory.LocalToWorld& P0, Unity.Mathematics.float4x4 P1, System.Int32 P2)
  Unity.Mathematics.float3 __Gen_Wrap_304(Beyond.Gameplay.Factory.LocalToWorld& P0)
  System.Void __Gen_Wrap_305(Beyond.Gameplay.Factory.LocalToWorld& P0)
  System.Void __Gen_Wrap_306(Beyond.Gameplay.Factory.UdPipeFragment& P0)
  System.Void __Gen_Wrap_307(Beyond.Gameplay.Factory.UnitConfigFragment& P0)
  System.String __Gen_Wrap_308(Beyond.Gameplay.Factory.FactoryUnitExtendConfig& P0)
  System.Void __Gen_Wrap_309(Beyond.Gameplay.Factory.UnitInteractFragment& P0)
  System.Void __Gen_Wrap_310(Beyond.Gameplay.Factory.UnitRenderFragment& P0)
  System.Void __Gen_Wrap_311(Beyond.Gameplay.Factory.RenderLookAtFragment& P0)
  System.Void __Gen_Wrap_312(Beyond.Gameplay.Factory.ChapterTagFragment& P0)
  System.Void __Gen_Wrap_313(Beyond.Gameplay.Factory.UnitStatusFragment& P0)
  System.Void __Gen_Wrap_314(Beyond.Gameplay.Factory.UnitOverrideStatusFragment& P0)
  System.Void __Gen_Wrap_315(Beyond.Gameplay.Factory.UnitStatusEffectFragment& P0, Beyond.Gameplay.Factory.BuildingStatus P1, System.Object P2)
  Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.StatusSingleEffect> __Gen_Wrap_316(Beyond.Gameplay.Factory.UnitStatusEffectFragment& P0, Beyond.GEnums.FacBuildingState P1)
  System.Void __Gen_Wrap_317(Beyond.Gameplay.Factory.UnitStatusEffectFragment& P0)
  System.Void __Gen_Wrap_318(Beyond.Gameplay.Factory.UnitStatusUIRendererFragment& P0)
  System.Boolean __Gen_Wrap_319(Beyond.Gameplay.Factory.UnitTransFragment& P0, Unity.Mathematics.float3 P1, System.Boolean P2)
  System.Void __Gen_Wrap_320(Beyond.Gameplay.Factory.UnitTransFragment& P0)
  System.Void __Gen_Wrap_321(Beyond.Gameplay.Factory.ValveFragment& P0)
  System.Void __Gen_Wrap_322(Beyond.Gameplay.Factory.BoxValve& P0)
  System.Void __Gen_Wrap_323(Beyond.Gameplay.Factory.FluidValve& P0)
  Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& __Gen_Wrap_324(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1)
  System.Boolean __Gen_Wrap_325(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, System.Int32 P2, System.Int32 P3)
  System.Void __Gen_Wrap_326(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, System.Int32 P2, UnityEngine.HyperGryph.ECS.Entity P3)
  System.Int32 __Gen_Wrap_327(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0)
  System.Int32 __Gen_Wrap_328(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, System.Int32 P1)
  System.Void __Gen_Wrap_329(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, System.Int32 P1, System.Int32 P2)
  System.UInt64[] __Gen_Wrap_330(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0)
  System.Void __Gen_Wrap_331(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, System.Int32 P1, UnityEngine.HyperGryph.ECS.Entity P2)
  UnityEngine.HyperGryph.ECS.Entity[] __Gen_Wrap_332(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, System.Int32 P1)
  System.Void __Gen_Wrap_333(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, System.Int32 P2, Beyond.PoolCore.PooledList<System.UInt32>& P3, Beyond.PoolCore.PooledList<System.UInt32>& P4, Beyond.PoolCore.PooledList<UnityEngine.HyperGryph.ECS.Entity>& P5)
  System.UInt64 __Gen_Wrap_334(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, System.Int32 P1)
  UnityEngine.HyperGryph.ECS.Entity __Gen_Wrap_335(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, System.Int32 P1, System.Int32 P2)
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> __Gen_Wrap_336(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0, System.Int32 P1)
  Beyond.Gameplay.Factory.BlueprintSlotInfo __Gen_Wrap_337()
  System.String __Gen_Wrap_338(Beyond.Gameplay.Factory.BlueprintSlotInfo& P0)
  System.String __Gen_Wrap_339(Beyond.Gameplay.Factory.ConveyorRendererInfo& P0)
  System.Boolean __Gen_Wrap_340(Beyond.Gameplay.Factory.UnitId& P0, Beyond.Gameplay.Factory.UnitId P1)
  System.Boolean __Gen_Wrap_341(Beyond.Gameplay.Factory.UnitId& P0, System.Object P1)
  System.Int32 __Gen_Wrap_342(Beyond.Gameplay.Factory.UnitId& P0)
  System.Boolean __Gen_Wrap_343(Beyond.Gameplay.Factory.Visibility& P0, Beyond.Gameplay.Factory.Visibility.EFlag P1)
  System.Boolean __Gen_Wrap_344(Beyond.Gameplay.Factory.Visibility& P0)
  System.Boolean __Gen_Wrap_345(Beyond.Gameplay.Factory.Visibility& P0, Beyond.Gameplay.Factory.Visibility.EFlag P1, System.Boolean P2)
  System.Void __Gen_Wrap_346(Beyond.Gameplay.Factory.WireRendererFragment& P0)
  System.Void __Gen_Wrap_347(Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData& P0)
  System.Void __Gen_Wrap_348(Beyond.Gameplay.Factory.GlobalSharedData& P0)
  System.Void __Gen_Wrap_349(Beyond.Gameplay.Factory.GlobalSharedData.CullingGlobalSetting& P0)
  System.Single __Gen_Wrap_350(Beyond.Gameplay.Factory.GlobalSharedData.CullingGlobalSetting& P0)
  System.Void __Gen_Wrap_351(Beyond.Gameplay.Factory.GlobalSharedData.SystemIntervalGlobalSetting& P0)
  System.Int32 __Gen_Wrap_352(Beyond.Gameplay.Factory.GlobalSharedData.SystemIntervalGlobalSetting& P0)
  System.Void __Gen_Wrap_353(Beyond.Gameplay.Factory.GlobalSharedData.NearByDistanceGlobalSetting& P0)
  System.Boolean __Gen_Wrap_354(Beyond.Gameplay.Factory.GlobalSharedData.NearByDistanceGlobalSetting& P0)
  System.Single __Gen_Wrap_355(Beyond.Gameplay.Factory.GlobalSharedData.NearByDistanceGlobalSetting& P0)
  System.Void __Gen_Wrap_356(Beyond.Gameplay.Factory.GlobalSharedData.World3DUiGlobalSetting& P0)
  System.Boolean __Gen_Wrap_357(Beyond.Gameplay.Factory.GlobalSharedData.World3DUiGlobalSetting& P0)
  System.Void __Gen_Wrap_358(Beyond.Gameplay.Factory.GlobalSharedData.CurveGlobalSetting& P0, Beyond.Gameplay.Factory.FPtrNativeCurve& P1, Beyond.Gameplay.Factory.FPtrNativeCurve& P2, Beyond.Gameplay.Factory.FPtrNativeCurve& P3)
  System.Void __Gen_Wrap_359(Beyond.Gameplay.Factory.GlobalSharedData.CurveGlobalSetting& P0, Beyond.Gameplay.Factory.FPtrNativeCurve& P1)
  System.Void __Gen_Wrap_360(Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData& P0, Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo[]& P1, Beyond.Gameplay.Factory.GlobalSharedData.MapGridRendererData.MapGridInfo[]& P2)
  System.Int32 __Gen_Wrap_361(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting& P0, Beyond.Gameplay.Factory.LogicEntityState P1, Beyond.Gameplay.Factory.LogicEntityType P2)
  System.Void __Gen_Wrap_362(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting& P0, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& P1, Beyond.Gameplay.Factory.LogicEntityState P2, Beyond.Gameplay.Factory.LogicEntityType P3)
  System.Void __Gen_Wrap_363(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting& P0, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& P1, Beyond.Gameplay.Factory.LogicEntityState P2, Beyond.Gameplay.Factory.LogicEntityType P3, System.UInt32 P4)
  System.Void __Gen_Wrap_364(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.PerDrawColorGlobalSetting& P0, System.Int32 P1, Beyond.Gameplay.Factory.PerDrawConfig P2)
  System.Void __Gen_Wrap_365(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.PerDrawPassGlobalSetting& P0, System.Int32 P1, Beyond.Gameplay.Factory.PerDrawPassConfig P2)
  System.Void __Gen_Wrap_366(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting& P0, System.Object P1)
  Beyond.Gameplay.Factory.PerDrawPassConfig __Gen_Wrap_367(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.PerDrawPassGlobalSetting& P0, System.Int32 P1)
  Beyond.Gameplay.Factory.PerDrawConfig __Gen_Wrap_368(Beyond.Gameplay.Factory.GlobalSharedData.PerDrawGlobalSetting.PerDrawColorGlobalSetting& P0, System.Int32 P1)
  System.Void __Gen_Wrap_369(Beyond.Gameplay.Factory.GlobalSharedData.UIEffectPathConfig& P0, System.Object P1, System.Object P2, System.Object P3)
  System.Boolean __Gen_Wrap_370(Beyond.Gameplay.Factory.GlobalSharedData.UIEffectPathConfig& P0, Beyond.GEnums.FacBuildingState P1, Unity.Collections.FixedString32Bytes& P2, Unity.Mathematics.float4& P3, Unity.Mathematics.float4& P4)
  System.Void __Gen_Wrap_371(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Beyond.Gameplay.Factory.GlobalEnv& P2, System.Object P3)
  Unity.Jobs.JobHandle __Gen_Wrap_372(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, System.Int64 P2, System.Int64 P3, System.Int32 P4, System.Int32 P5, System.Int32 P6, Beyond.Gameplay.Factory.GlobalEnv& P7, Unity.Jobs.JobHandle P8, Unity.Collections.NativeList<Unity.Jobs.JobHandle> P9)
  Unity.Jobs.JobHandle __Gen_Wrap_373(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, System.Int64 P2, System.Int64 P3, System.Single P4, System.Int32 P5, System.Int32 P6, System.Int32 P7, Beyond.Gameplay.Factory.GlobalEnv& P8, Unity.Jobs.JobHandle P9, Unity.Collections.NativeList<Unity.Jobs.JobHandle> P10)
  Unity.Jobs.JobHandle __Gen_Wrap_374(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Beyond.Gameplay.Factory.GlobalEnv& P2, System.Int32 P3, System.Int32 P4, System.Int32 P5, Unity.Jobs.JobHandle P6)
  System.Void __Gen_Wrap_375(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Beyond.Gameplay.Factory.GlobalEnv& P2)
  System.Void __Gen_Wrap_376(System.Object P0, Unity.Collections.NativeList<Unity.Jobs.JobHandle>& P1)
  System.Void __Gen_Wrap_377(System.Object P0, Unity.Jobs.JobHandle& P1, Unity.Collections.NativeList<Unity.Jobs.JobHandle>& P2)
  System.Boolean __Gen_Wrap_378(System.Object P0, Beyond.Gameplay.Factory.GlobalEnv& P1)
  System.Boolean __Gen_Wrap_379(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1)
  Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.ApplyRender> __Gen_Wrap_380()
  Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.FacRegionPosValid> __Gen_Wrap_381()
  Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.QueryStateIconPath> __Gen_Wrap_382()
  System.Boolean __Gen_Wrap_383(UnityEngine.HyperGryph.ECS.EntityManager& P0, System.Single P1, System.Single P2, System.Single P3, Beyond.Gameplay.Factory.UnitFragment& P4)
  Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.QueryBuildingState> __Gen_Wrap_384()
  Unity.Burst.FunctionPointer<Beyond.Gameplay.Factory.UnsafeJobFuncPointers.SetEntityFlashStatue> __Gen_Wrap_385()
  System.Void __Gen_Wrap_386(Beyond.Gameplay.Factory.AdditiveEffectJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_387(Beyond.Gameplay.Factory.AdditiveEffectJob& P0, Beyond.Gameplay.Factory.AdditiveEffectFragment& P1, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P2)
  System.Void __Gen_Wrap_388(Beyond.Gameplay.Factory.CutoffState& P0, Beyond.Gameplay.Factory.BuildDismissState& P1)
  System.Void __Gen_Wrap_389(Beyond.Gameplay.Factory.AdditiveEffectJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_390(Beyond.Gameplay.Factory.AdditiveEffectJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_391(Beyond.Gameplay.Factory.AdditiveEffectJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1)
  Unity.Jobs.JobHandle __Gen_Wrap_392(Beyond.Gameplay.Factory.AdditiveEffectJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2)
  Unity.Jobs.JobHandle __Gen_Wrap_393(Beyond.Gameplay.Factory.AdditiveEffectJob& P0, Unity.Jobs.JobHandle P1, Unity.Jobs.JobHandle P2, System.Int32 P3)
  System.Void __Gen_Wrap_394(Beyond.Gameplay.Factory.AdditiveEffectQueryJob& P0)
  System.Void __Gen_Wrap_395(Beyond.Gameplay.Factory.AdditiveEffectQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P2, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P3, System.Boolean P4)
  System.Void __Gen_Wrap_396(Beyond.Gameplay.Factory.AdditiveEffectRenderJob& P0, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P1, Beyond.Gameplay.Factory.AdditiveEffectRendererFragment& P2, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& P3)
  System.Void __Gen_Wrap_397(Beyond.Gameplay.Factory.AdditiveEffectRenderJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_398(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& P0, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P1, System.Boolean P2, System.Boolean P3)
  System.Void __Gen_Wrap_399(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P1, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& P2, Beyond.Gameplay.Factory.FPtrNativeCurve& P3, Beyond.Gameplay.Factory.FPtrNativeCurve& P4, Beyond.Gameplay.Factory.FPtrNativeCurve& P5, System.Int64 P6)
  System.Void __Gen_Wrap_400(UnityEngine.HyperGryph.ECS.EntityManager& P0, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P1, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent& P2)
  System.Void __Gen_Wrap_401(Beyond.Gameplay.Factory.AdditiveEffectRenderJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_402(Beyond.Gameplay.Factory.AdditiveEffectRenderJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_403(Beyond.Gameplay.Factory.AdditiveEffectRenderJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1)
  Unity.Jobs.JobHandle __Gen_Wrap_404(Beyond.Gameplay.Factory.AdditiveEffectRenderJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2)
  Unity.Jobs.JobHandle __Gen_Wrap_405(Beyond.Gameplay.Factory.AdditiveEffectRenderJob& P0, Unity.Jobs.JobHandle P1, Unity.Jobs.JobHandle P2, System.Int32 P3)
  System.Void __Gen_Wrap_406(Beyond.Gameplay.Factory.AudioJobs.AudioDistanceAndCullingJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_407(Beyond.Gameplay.Factory.AudioJobs.AudioGroupEmitterJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_408(Beyond.Gameplay.Factory.AudioJobs.AudioGroupEmitterJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_409(Beyond.Gameplay.Factory.AudioJobs.WaterPipeEmitterJob& P0, System.Int32 P1, Beyond.Gameplay.Factory.PipeFragment& P2)
  System.Void __Gen_Wrap_410(Beyond.Gameplay.Factory.AudioJobs.WaterPipeEmitterJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_411(Beyond.Gameplay.Factory.AudioJobs.WaterPipeEmitterJob& P0, Beyond.Gameplay.Factory.GlobalEnv& P1)
  System.Void __Gen_Wrap_412(Beyond.Gameplay.Factory.BatchArrowJob& P0, System.Boolean P1, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& P2, Unity.Mathematics.quaternion P3, Unity.Mathematics.float3 P4, Beyond.Gameplay.Factory.ComplexPortFragment P5, Unity.Mathematics.float4x4 P6, System.Single P7, System.Boolean P8, System.Boolean P9, System.Boolean P10, System.Boolean P11, System.Boolean P12, System.Boolean P13, System.Boolean P14, System.Boolean P15, System.Boolean P16, System.Boolean P17, System.Boolean P18)
  System.Void __Gen_Wrap_413(Beyond.Gameplay.Factory.BatchArrowJob& P0, System.Int32 P1, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult P2)
  System.Void __Gen_Wrap_414(Beyond.Gameplay.Factory.BatchArrowJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_415(Beyond.Gameplay.Factory.BatchArrowJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_416(Beyond.Gameplay.Factory.BatchArrowJob& P0)
  System.Void __Gen_Wrap_417(Beyond.Gameplay.Factory.BatchInsideConveyorJob& P0, System.UInt32 P1, Unity.Mathematics.float3 P2, Unity.Mathematics.quaternion P3, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& P4, Beyond.Gameplay.Factory.ComplexPortFragment& P5, System.Boolean P6, System.Single P7, System.Boolean P8)
  System.Void __Gen_Wrap_418(Beyond.Gameplay.Factory.BatchInsideConveyorJob& P0, System.Int32 P1, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult P2)
  System.Void __Gen_Wrap_419(Beyond.Gameplay.Factory.BatchInsideConveyorJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_420(Beyond.Gameplay.Factory.BatchInsideConveyorJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_421(Beyond.Gameplay.Factory.BatchInsideConveyorJob& P0)
  System.Void __Gen_Wrap_422(Beyond.Gameplay.Factory.BatchNormalArrowJob& P0, System.UInt32 P1, System.Boolean P2, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& P3, Unity.Mathematics.quaternion P4, Unity.Mathematics.float3 P5, Beyond.Gameplay.Factory.ComplexPortFragment P6, Unity.Mathematics.float4x4 P7, System.Single P8, System.Boolean P9, System.Boolean P10, System.Boolean P11, System.Boolean P12, System.Boolean P13, System.Boolean P14, System.Boolean P15, System.Boolean P16, System.Boolean P17)
  System.Void __Gen_Wrap_423(Beyond.Gameplay.Factory.BatchNormalArrowJob& P0, System.Int32 P1, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult P2)
  System.Void __Gen_Wrap_424(Beyond.Gameplay.Factory.BatchNormalArrowJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_425(Beyond.Gameplay.Factory.BatchNormalArrowJob& P0)
  System.Void __Gen_Wrap_426(Beyond.Gameplay.Factory.BatchNormalArrowJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_427(Beyond.Gameplay.Factory.BatchPreviewArrowJob& P0, System.Boolean P1, Unity.Collections.FixedList512Bytes<Beyond.Gameplay.Factory.FactoryUnitPortConfig>& P2, Unity.Mathematics.quaternion P3, Unity.Mathematics.float3 P4, Beyond.Gameplay.Factory.ComplexPortFragment P5, Unity.Mathematics.float4x4 P6, System.Single P7, System.Boolean P8, System.Boolean P9, System.Boolean P10)
  System.Void __Gen_Wrap_428(Beyond.Gameplay.Factory.BatchPreviewArrowJob& P0, System.Int32 P1, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult P2)
  System.Void __Gen_Wrap_429(Beyond.Gameplay.Factory.BatchPreviewArrowJob& P0)
  System.Void __Gen_Wrap_430(Beyond.Gameplay.Factory.BatchPreviewArrowJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_431(Beyond.Gameplay.Factory.BufferSwapJob& P0)
  System.Void __Gen_Wrap_432(Beyond.Gameplay.Factory.BuildingLiquidRenderJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_433(Beyond.Gameplay.Factory.BuildingLiquidRenderJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_434(Beyond.Gameplay.Factory.BuildingLiquidRenderJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1)
  Unity.Jobs.JobHandle __Gen_Wrap_435(Beyond.Gameplay.Factory.BuildingLiquidRenderJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2)
  System.Void __Gen_Wrap_436(Beyond.Gameplay.Factory.BuildingLiquidRenderJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_437(Beyond.Gameplay.Factory.BuildingStatePosCollectJob& P0, Beyond.Gameplay.Factory.UnitFragment& P1, Beyond.Gameplay.Factory.UnitTransFragment& P2, Beyond.Gameplay.Factory.UnitConfigFragment& P3, Beyond.Gameplay.Factory.UnitStatusFragment& P4, Beyond.Gameplay.Factory.SharedDataFragment& P5)
  System.Void __Gen_Wrap_438(Beyond.Gameplay.Factory.BuildingStatePosCollectJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_439(Beyond.Gameplay.Factory.BuildingStatePosCollectJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_440(Beyond.Gameplay.Factory.BuildingStatePosCollectJob& P0)
  System.Void __Gen_Wrap_441(Beyond.Gameplay.Factory.BuildingStatePosCollectJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_442(Beyond.Gameplay.Factory.BuildingStateRendererJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_443(Beyond.Gameplay.Factory.CargoCollectJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_444(Beyond.Gameplay.Factory.CargoCollectJob& P0)
  System.Void __Gen_Wrap_445(Beyond.Gameplay.Factory.CargoCollectJob& P0, Beyond.Gameplay.Factory.GlobalEnv& P1)
  System.Void __Gen_Wrap_446(Beyond.Gameplay.Factory.CargoCollectJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_447(Beyond.Gameplay.Factory.CargoPredictJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_448(Beyond.Gameplay.Factory.CargoPredictJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_449(Beyond.Gameplay.Factory.CargoPredictJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1)
  Unity.Jobs.JobHandle __Gen_Wrap_450(Beyond.Gameplay.Factory.CargoPredictJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2)
  System.Void __Gen_Wrap_451(Beyond.Gameplay.Factory.CargoPredictQueryJob& P0)
  System.Void __Gen_Wrap_452(Beyond.Gameplay.Factory.CargoPredictQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, System.Boolean P2)
  System.Void __Gen_Wrap_453(Beyond.Gameplay.Factory.CargoRenderJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_454(Beyond.Gameplay.Factory.CargoRenderJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_455(Beyond.Gameplay.Factory.CargoRenderQueryJob& P0)
  System.Void __Gen_Wrap_456(Beyond.Gameplay.Factory.CargoRenderQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, System.Boolean P2)
  System.Void __Gen_Wrap_457(Beyond.Gameplay.Factory.ConveyorCollectJob& P0, Beyond.Gameplay.Factory.ConveyorFragment& P1, Beyond.Gameplay.Factory.SharedDataFragment& P2, System.Boolean P3, System.Boolean P4)
  System.Void __Gen_Wrap_458(Beyond.Gameplay.Factory.ConveyorCollectJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_459(Beyond.Gameplay.Factory.ConveyorCollectJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_460(Beyond.Gameplay.Factory.ConveyorCollectJob& P0)
  System.Void __Gen_Wrap_461(Beyond.Gameplay.Factory.ConveyorCollectJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_462(Beyond.Gameplay.Factory.ConveyorFigureRendererJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_463(Beyond.Gameplay.Factory.ConveyorFigureRendererJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_464(Beyond.Gameplay.Factory.ConveyorFigureRendererJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_465(Beyond.Gameplay.Factory.ConveyorInsideRenderJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_466(Beyond.Gameplay.Factory.ConveyorPreviewCollectJob& P0, Beyond.Gameplay.Factory.ConveyorPreviewRendererFragment& P1, Beyond.Gameplay.Factory.SharedDataFragment& P2, System.Boolean P3, System.Boolean P4)
  System.Void __Gen_Wrap_467(Beyond.Gameplay.Factory.ConveyorPreviewCollectJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_468(Beyond.Gameplay.Factory.ConveyorPreviewCollectJob& P0)
  System.Void __Gen_Wrap_469(Beyond.Gameplay.Factory.ConveyorPreviewCollectJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_470(Beyond.Gameplay.Factory.ConveyorRendererJob& P0, UnityEngine.HyperGryph.ECS.Entity P1, System.Single P2, System.UInt32 P3, Unity.Mathematics.float3 P4, Unity.Mathematics.float3 P5, System.Single P6, System.Single P7, System.Single P8, System.Boolean P9, Beyond.Gameplay.Factory.BlueprintState.EffectType P10, System.Single P11, System.UInt32 P12, System.Boolean P13, System.Boolean P14, System.Boolean P15)
  System.Void __Gen_Wrap_471(Beyond.Gameplay.Factory.ConveyorRendererJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_472(Beyond.Gameplay.Factory.ConveyorRendererJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_473(Beyond.Gameplay.Factory.ConveyorRendererJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_474(Beyond.Gameplay.Factory.InteractFacCollectJob& P0)
  System.Boolean __Gen_Wrap_475(Unity.Mathematics.float3 P0, Unity.Mathematics.float3 P1, Unity.Mathematics.float3 P2, System.Single P3, System.Single P4, System.Single& P5, System.Single& P6, System.Boolean P7)
  System.Void __Gen_Wrap_476(Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& P0, Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& P1)
  Unity.Mathematics.float3 __Gen_Wrap_477(Unity.Mathematics.float3 P0)
  System.Boolean __Gen_Wrap_478(Beyond.Gameplay.Factory.InteractFacCollectJob& P0, Unity.Mathematics.float3 P1, System.Single P2, System.Int32& P3)
  System.Void __Gen_Wrap_479(Beyond.Gameplay.Factory.InteractFacCollectJob& P0, System.IntPtr P1)
  System.String __Gen_Wrap_480(Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& P0)
  System.Boolean __Gen_Wrap_481(Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& P0)
  System.Boolean __Gen_Wrap_482(Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& P0)
  System.Void __Gen_Wrap_483(Beyond.Gameplay.Factory.LocalToWorldJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_484(Beyond.Gameplay.Factory.LocalToWorld& P0, System.IntPtr P1, System.Int32 P2)
  System.Void __Gen_Wrap_485(Beyond.Gameplay.Factory.LocalToWorldJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_486(Beyond.Gameplay.Factory.LocalToWorldJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_487(Beyond.Gameplay.Factory.LocalToWorldJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1)
  Unity.Jobs.JobHandle __Gen_Wrap_488(Beyond.Gameplay.Factory.LocalToWorldJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2)
  System.Void __Gen_Wrap_489(Beyond.Gameplay.Factory.LocalToWorldQueryJob& P0)
  System.Void __Gen_Wrap_490(Beyond.Gameplay.Factory.LocalToWorldQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, System.Boolean P2)
  System.Void __Gen_Wrap_491(Beyond.Gameplay.Factory.LogisticEffectJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_492(Beyond.Gameplay.Factory.LookAtJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_493(Beyond.Gameplay.Factory.LookAtJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_494(Beyond.Gameplay.Factory.LookAtJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1)
  Unity.Jobs.JobHandle __Gen_Wrap_495(Beyond.Gameplay.Factory.LookAtJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2)
  System.Void __Gen_Wrap_496(Beyond.Gameplay.Factory.LookAtQueryJob& P0)
  System.Void __Gen_Wrap_497(Beyond.Gameplay.Factory.LookAtQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, System.Boolean P2)
  System.Void __Gen_Wrap_498(Beyond.Gameplay.Factory.OutputCollectJob& P0, Beyond.Gameplay.Factory.UnitFragment& P1, Beyond.Gameplay.Factory.UnitTransFragment& P2, Beyond.Gameplay.Factory.UnitConfigFragment& P3, Beyond.Gameplay.Factory.OutputFragment& P4, Beyond.Gameplay.Factory.SharedDataFragment& P5)
  System.Void __Gen_Wrap_499(Beyond.Gameplay.Factory.OutputCollectJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_500(Beyond.Gameplay.Factory.OutputCollectJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_501(Beyond.Gameplay.Factory.OutputCollectJob& P0)
  System.Void __Gen_Wrap_502(Beyond.Gameplay.Factory.OutputCollectJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_503(Beyond.Gameplay.Factory.OutputRenderJob& P0, System.Int32 P1)
  Unity.Mathematics.float4 __Gen_Wrap_504(Beyond.Gameplay.Factory.PedestalFlashJob& P0, Beyond.Gameplay.Factory.PedestalLightFlashFragment& P1, System.Single P2)
  System.Void __Gen_Wrap_505(Beyond.Gameplay.Factory.PedestalFlashJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_506(Beyond.Gameplay.Factory.PedestalFlashJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_507(Beyond.Gameplay.Factory.PedestalFlashJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_508(Beyond.Gameplay.Factory.PipeCollectJob& P0, System.Int32 P1, System.UInt32 P2, System.UInt32 P3, System.Int32 P4, System.Single P5, System.Single P6, System.Single P7, System.Single P8, System.UInt32 P9, System.Boolean P10, System.Boolean P11, System.Boolean P12)
  System.Void __Gen_Wrap_509(Beyond.Gameplay.Factory.PipeCollectJob& P0, Beyond.Gameplay.Factory.PipeFragment& P1, System.UInt32 P2)
  System.Void __Gen_Wrap_510(Beyond.Gameplay.Factory.PipeCollectJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange P1, Unity.Collections.NativeList<UnityEngine.HyperGryph.ECS.GroupType> P2)
  System.Void __Gen_Wrap_511(Beyond.Gameplay.Factory.PipeCollectJob& P0, System.Int32 P1, System.UInt32 P2, System.UInt32 P3, System.Single P4, System.Single P5, System.Single P6, System.UInt32 P7, System.Boolean P8)
  System.Void __Gen_Wrap_512(Beyond.Gameplay.Factory.PipeCollectJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_513(Beyond.Gameplay.Factory.PipeCollectJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_514(Beyond.Gameplay.Factory.PipeCollectJob& P0)
  System.Void __Gen_Wrap_515(Beyond.Gameplay.Factory.PipeCollectJob& P0, Beyond.Gameplay.Factory.GlobalEnv& P1)
  System.Void __Gen_Wrap_516(Beyond.Gameplay.Factory.PipeCollectJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_517(Beyond.Gameplay.Factory.PipeComRendererJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_518(Beyond.Gameplay.Factory.PipeFigureRendererJob& P0, UnityEngine.HyperGryph.ECS.Entity P1, System.Byte P2, Unity.Mathematics.float3 P3, Unity.Mathematics.float3 P4, System.Single P5, System.Single P6, System.Single P7, System.Single P8, System.Single P9, System.Single P10, System.Boolean P11, System.Boolean P12, System.Boolean P13)
  System.Void __Gen_Wrap_519(Beyond.Gameplay.Factory.PipeFigureRendererJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_520(Beyond.Gameplay.Factory.PipeFigureRendererJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_521(Beyond.Gameplay.Factory.PipeHolderFigureRendererJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_522(Beyond.Gameplay.Factory.PipeHolderFigureRendererJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_523(Beyond.Gameplay.Factory.PipeHolderHideRendererJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_524(Beyond.Gameplay.Factory.PipeHolderHideRendererJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_525(Beyond.Gameplay.Factory.PipeHolderHideRendererJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_526(Beyond.Gameplay.Factory.PipeLogisticsPosCollectJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_527(Beyond.Gameplay.Factory.PipeLogisticsPosCollectJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_528(Beyond.Gameplay.Factory.PipeLogisticsPosCollectJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_529(Beyond.Gameplay.Factory.PipeLogisticsPosCollectJob& P0)
  System.Void __Gen_Wrap_530(Beyond.Gameplay.Factory.PipeRendererJob& P0, UnityEngine.HyperGryph.ECS.Entity P1, System.Byte P2, Unity.Mathematics.float3 P3, Unity.Mathematics.float3 P4, System.Single P5, System.UInt32 P6, System.Int32 P7, System.Int32 P8, System.Single P9, System.Single P10, System.Single P11, Beyond.Gameplay.Factory.BlueprintState.EffectType P12, System.Single P13, System.UInt32 P14, System.Boolean P15, System.Boolean P16, System.Boolean P17)
  System.Void __Gen_Wrap_531(Beyond.Gameplay.Factory.PipeRendererJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_532(Beyond.Gameplay.Factory.PipeRendererJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_533(Beyond.Gameplay.Factory.PipeTrackRendererJob& P0, UnityEngine.HyperGryph.ECS.Entity P1, Unity.Mathematics.float3 P2, Unity.Mathematics.float3 P3, System.Single P4, System.Single P5, System.Single P6, System.Single P7, System.Single P8, System.Boolean P9)
  System.Void __Gen_Wrap_534(Beyond.Gameplay.Factory.PipeTrackRendererJob& P0)
  System.Void __Gen_Wrap_535(Beyond.Gameplay.Factory.PipeWaterThicknessQueryJob& P0)
  System.Void __Gen_Wrap_536(Beyond.Gameplay.Factory.PipeWaterThicknessQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, System.Boolean P2)
  System.Void __Gen_Wrap_537(Beyond.Gameplay.Factory.PipeWaterThicknessRiseJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_538(Beyond.Gameplay.Factory.PipeWaterThicknessRiseJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_539(Beyond.Gameplay.Factory.PipeWaterThicknessRiseJob& P0, Beyond.Gameplay.Factory.GlobalEnv& P1)
  System.Void __Gen_Wrap_540(Beyond.Gameplay.Factory.PipeWaterThicknessRiseJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1)
  Unity.Jobs.JobHandle __Gen_Wrap_541(Beyond.Gameplay.Factory.PipeWaterThicknessRiseJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2)
  System.Void __Gen_Wrap_542(Beyond.Gameplay.Factory.PortArrowRenderJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_543(Beyond.Gameplay.Factory.PortStateCollectJob& P0, Beyond.Gameplay.Factory.ComplexPortFragment& P1, Beyond.Gameplay.Factory.SharedDataContainer.SharedExtData& P2)
  System.Void __Gen_Wrap_544(Beyond.Gameplay.Factory.PortStateCollectJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_545(Beyond.Gameplay.Factory.PortStateCollectJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_546(Beyond.Gameplay.Factory.PortStateCollectJob& P0)
  System.Void __Gen_Wrap_547(Beyond.Gameplay.Factory.PortStateCollectJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_548(Beyond.Gameplay.Factory.PortStateRendererJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_549(Beyond.Gameplay.Factory.PreviewUnitQueryJob& P0)
  System.Void __Gen_Wrap_550(Beyond.Gameplay.Factory.PreviewUnitQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, System.Boolean P2)
  System.Void __Gen_Wrap_551(Beyond.Gameplay.Factory.PumpInEffectJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_552(Beyond.Gameplay.Factory.PumpInEffectJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_553(Beyond.Gameplay.Factory.PumpInEffectJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1)
  Unity.Jobs.JobHandle __Gen_Wrap_554(Beyond.Gameplay.Factory.PumpInEffectJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2)
  System.Void __Gen_Wrap_555(Beyond.Gameplay.Factory.PumpInEffectJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_556(Beyond.Gameplay.Factory.StatusChangeJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_557(Beyond.Gameplay.Factory.UnitCullingJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_558(Beyond.Gameplay.Factory.UnitCullingJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_559(Beyond.Gameplay.Factory.UnitCullingJob& P0, Beyond.Gameplay.Factory.GlobalEnv& P1)
  System.Void __Gen_Wrap_560(Beyond.Gameplay.Factory.UnitCullingJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_561(Beyond.Gameplay.Factory.UnitPreviewRenderJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_562(Beyond.Gameplay.Factory.UnitPreviewRenderJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_563(Beyond.Gameplay.Factory.UnitPreviewRenderJob& P0, Beyond.Gameplay.Factory.GlobalEnv& P1)
  System.Void __Gen_Wrap_564(Beyond.Gameplay.Factory.UnitPreviewRenderJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_565(Beyond.Gameplay.Factory.UnitPreviewRenderJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1)
  Unity.Jobs.JobHandle __Gen_Wrap_566(Beyond.Gameplay.Factory.UnitPreviewRenderJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2)
  System.Void __Gen_Wrap_567(Beyond.Gameplay.Factory.UnitRendererQueryJob& P0)
  System.Void __Gen_Wrap_568(Beyond.Gameplay.Factory.UnitRendererQueryJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P2, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P3, System.Boolean P4)
  System.Void __Gen_Wrap_569(Beyond.Gameplay.Factory.UpdateUnitRendererTRSJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_570(Beyond.Gameplay.Factory.UpdateUnitRendererTRSJob& P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_571(Beyond.Gameplay.Factory.UpdateUnitRendererTRSJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_572(Beyond.Gameplay.Factory.UpdateUnitRendererTRSJob& P0, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& P1)
  Unity.Jobs.JobHandle __Gen_Wrap_573(Beyond.Gameplay.Factory.UpdateUnitRendererTRSJob& P0, Unity.Jobs.JobHandle P1, System.Int32 P2)
  System.Void __Gen_Wrap_574(Beyond.Gameplay.Factory.WireCollectJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_575(Beyond.Gameplay.Factory.WireCollectJob& P0)
  System.Void __Gen_Wrap_576(Beyond.Gameplay.Factory.WireCollectJob& P0, Beyond.Gameplay.Factory.GlobalEnv& P1)
  System.Void __Gen_Wrap_577(Beyond.Gameplay.Factory.WireCollectJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_578(Beyond.Gameplay.Factory.WireRenderJob& P0, UnityEngine.HyperGryph.ECS.Entity P1, Beyond.Gameplay.Factory.WireRendererInfo P2)
  System.Void __Gen_Wrap_579(Beyond.Gameplay.Factory.WireRenderJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_580(Beyond.Gameplay.Factory.WireRenderJob& P0, System.Int32 P1, System.Int32 P2)
  System.Boolean __Gen_Wrap_581(Beyond.Gameplay.Factory.FPtrNativeCurve& P0)
  Unity.Collections.NativeArray<System.Single> __Gen_Wrap_582(Beyond.Gameplay.Factory.FPtrNativeCurve& P0, System.Object P1, System.Int32 P2)
  System.Single __Gen_Wrap_583(Beyond.Gameplay.Factory.FPtrNativeCurve& P0, System.Single P1)
  System.Int32 __Gen_Wrap_584(Beyond.Gameplay.Factory.PerDrawPassConfig& P0)
  UnityEngine.HyperGryph.HGShaderLightMode __Gen_Wrap_585(Beyond.Gameplay.Factory.PerDrawPassConfig& P0, Beyond.Gameplay.Factory.PerDrawLightMode P1)
  System.Void __Gen_Wrap_586(Beyond.Gameplay.Factory.PerDrawPassConfig& P0, UnityEngine.HyperGryph.ECS.Entity P1, System.UInt32& P2)
  System.Void __Gen_Wrap_587(Beyond.Gameplay.Factory.PerDrawPassConfig& P0, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent P1, System.UInt32& P2)
  System.Int32 __Gen_Wrap_588()
  System.Void __Gen_Wrap_589(Beyond.Gameplay.Factory.PerDrawConfig& P0, UnityEngine.Color P1)
  System.Void __Gen_Wrap_590(Beyond.Gameplay.Factory.PerDrawConfig& P0, Unity.Mathematics.float4 P1)
  System.Void __Gen_Wrap_591(Beyond.Gameplay.Factory.PerDrawConfig& P0, System.Single P1)
  System.Void __Gen_Wrap_592(Beyond.Gameplay.Factory.PerDrawConfig& P0, UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent P1)
  System.Boolean __Gen_Wrap_593(System.Single P0, System.Single P1, System.Single& P2, System.Single P3, System.Single P4)
  System.Boolean __Gen_Wrap_594(Beyond.Gameplay.Factory.IProcessor& P0, System.Single P1, System.Single P2)
  System.Void __Gen_Wrap_595(Beyond.Gameplay.Factory.GlobalEnv& P0, Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& P1, Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& P2)
  System.Void __Gen_Wrap_596(Beyond.Gameplay.Factory.GlobalEnv& P0, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& P1, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& P2)
  Unity.Jobs.JobHandle __Gen_Wrap_597(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Beyond.Gameplay.Factory.GlobalEnv& P2, Unity.Jobs.JobHandle& P3, Unity.Jobs.JobHandle& P4)
  System.Boolean __Gen_Wrap_598(Beyond.Gameplay.Factory.FFactoryStateColorConfig& P0, Beyond.GEnums.FacBuildingState P1, UnityEngine.Color& P2)
  System.Void __Gen_Wrap_599(System.Object P0, Beyond.Gameplay.Factory.GlobalEnv& P1)
  System.Boolean __Gen_Wrap_600(System.Object P0, System.Int32 P1, UnityEngine.Color& P2)
  System.Boolean __Gen_Wrap_601(System.Object P0, System.Object P1, System.Object P2, System.Int32& P3)
  Beyond.Gameplay.Factory.FactoryBaseColorLutConfig __Gen_Wrap_602(System.Object P0)
  System.Boolean __Gen_Wrap_603(Beyond.Gameplay.Factory.FFactoryStateColorConfig& P0, Beyond.GEnums.FacBuildingState P1, System.String& P2)
  System.Boolean __Gen_Wrap_604(Beyond.Gameplay.Factory.FFactoryStateColorConfig& P0, Beyond.Gameplay.Factory.LogicEntityState P1, Beyond.Gameplay.Factory.LogicEntityType P2, Beyond.Gameplay.Factory.PerDrawConfigArray& P3)
  System.Void __Gen_Wrap_605(Beyond.Gameplay.Factory.FFactoryStateColorConfig.LogicStateConfig& P0)
  System.Void __Gen_Wrap_606(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1, System.Single P2)
  System.Void __Gen_Wrap_607(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1, System.Int32 P2)
  System.Void __Gen_Wrap_608(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1, System.Boolean P2)
  System.Void __Gen_Wrap_609(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0)
  System.Void __Gen_Wrap_610(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& P1)
  System.Void __Gen_Wrap_611(Beyond.Gameplay.Factory.ECSVATFSM.FSMState& P0)
  System.Void __Gen_Wrap_612(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& P0, System.UInt32 P1, System.UInt32 P2)
  System.Void __Gen_Wrap_613(Beyond.Gameplay.Factory.ECSVATFSM.FSMTransition& P0)
  System.Void __Gen_Wrap_614(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& P0, Beyond.Gameplay.Factory.ECSVATFSM.FSMStateDefinition& P1)
  System.Void __Gen_Wrap_615(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& P0)
  System.Void __Gen_Wrap_616(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& P0, Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition& P1, Beyond.Gameplay.Factory.ECSVATFSM.FSMStateDefinition& P2)
  System.Single __Gen_Wrap_617(Beyond.Gameplay.Factory.ECSVATFSM.FSMState& P0)
  System.Void __Gen_Wrap_618(Beyond.Gameplay.Factory.ECSVATFSM.FSMState& P0, System.Single P1, System.Single P2)
  System.Void __Gen_Wrap_619(Beyond.Gameplay.Factory.ECSVATFSM.FSMState& P0, System.Single P1)
  System.Single __Gen_Wrap_620(Beyond.Gameplay.Factory.ECSVATFSM.FSMTransition& P0)
  System.Void __Gen_Wrap_621(Beyond.Gameplay.Factory.ECSVATFSM.FSMTransition& P0, System.Single P1, System.Single P2)
  System.Single __Gen_Wrap_622(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1)
  System.Int32 __Gen_Wrap_623(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1)
  System.Boolean __Gen_Wrap_624(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1)
  System.Void __Gen_Wrap_625(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1)
  System.Void __Gen_Wrap_626(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType P2, System.Single P3)
  System.Single __Gen_Wrap_627(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, System.Byte P1, Beyond.Gameplay.Factory.ECSVATFSM.ParameterType P2)
  System.Void __Gen_Wrap_628(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMSetParamRequestHandlerJob& P0, System.Int32 P1)
  System.Boolean __Gen_Wrap_629(Beyond.Gameplay.Factory.ECSVATFSM.FSMCondition& P0, Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P1, Unity.Collections.FixedList128Bytes<Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterDefinition>& P2)
  System.Boolean __Gen_Wrap_630(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& P0, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& P1, System.Int32& P2)
  System.Void __Gen_Wrap_631(Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterSet& P0, Beyond.Gameplay.Factory.ECSVATFSM.FSMTransitionDefinition& P1, Unity.Collections.FixedList128Bytes<Beyond.Gameplay.Factory.ECSVATFSM.FSMParameterDefinition>& P2)
  System.Boolean __Gen_Wrap_632(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateUpdateJob& P0, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& P1, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& P2)
  System.Void __Gen_Wrap_633(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateUpdateJob& P0, UnityEngine.HyperGryph.ECS.Entity P1, Beyond.Gameplay.Factory.ECSVATFSM.FSMState& P2, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& P3)
  System.Void __Gen_Wrap_634(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateUpdateJob& P0, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateFragment& P1, Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& P2)
  System.Void __Gen_Wrap_635(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateUpdateJob& P0, System.Int32 P1)
  System.Void __Gen_Wrap_636(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateUpdateJob& P0)
  System.Void __Gen_Wrap_637(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMStateUpdateJob& P0, System.IntPtr P1)
  System.Void __Gen_Wrap_638(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1)
  Unity.Jobs.JobHandle __Gen_Wrap_639(System.Object P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Beyond.Gameplay.Factory.GlobalEnv& P2, Unity.Jobs.JobHandle P3)
  System.UInt32 __Gen_Wrap_640(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0)
  System.Span<Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition> __Gen_Wrap_641(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0)
  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& __Gen_Wrap_642(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0, System.UInt32 P1)
  Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinition& __Gen_Wrap_643(Beyond.Gameplay.Factory.ECSVATFSM.VATFSMDefinitionContainer& P0, System.Int32 P1)
  System.Void __Gen_Wrap_644(System.Int32 P0, System.Object P1)
  System.Void __Gen_Wrap_645(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1)
  System.String __Gen_Wrap_646(System.UInt32 P0, System.Byte P1)
  System.Void __Gen_Wrap_647(Unity.Jobs.JobHandle P0)
  System.Boolean __Gen_Wrap_648(UnityEngine.HyperGryph.ECS.Entity P0)
  System.Boolean __Gen_Wrap_649(UnityEngine.HyperGryph.ECS.EntityManager& P0, UnityEngine.HyperGryph.ECS.Entity& P1)
  System.Boolean __Gen_Wrap_650(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1)
  System.Boolean __Gen_Wrap_651(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Beyond.Gameplay.Factory.Visibility.Type P2)
  System.Boolean __Gen_Wrap_652(UnityEngine.HyperGryph.ECS.Entity P0, Beyond.Gameplay.Factory.Visibility.Type P1)
  System.Boolean __Gen_Wrap_653(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, System.Boolean P2, Beyond.Gameplay.Factory.Visibility.EFlag P3, Beyond.Gameplay.Factory.Visibility.Type P4, System.Object P5)
  System.Void __Gen_Wrap_654(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, System.Boolean P2, Beyond.Gameplay.Factory.Visibility.EFlag P3, Beyond.Gameplay.Factory.Visibility.Type P4, System.Object P5)
  System.Boolean __Gen_Wrap_655(UnityEngine.HyperGryph.ECS.Entity P0, System.Boolean P1, Beyond.Gameplay.Factory.Visibility.EFlag P2, Beyond.Gameplay.Factory.Visibility.Type P3, UnityEngine.HyperGryph.ECS.EntityCommandBuffer& P4)
  System.Void __Gen_Wrap_656(UnityEngine.HyperGryph.ECS.Entity P0, System.Boolean P1)
  System.Void __Gen_Wrap_657(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& P1)
  System.Boolean __Gen_Wrap_658(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Unity.Collections.FixedString32Bytes P2, Unity.Mathematics.float3& P3, Unity.Mathematics.quaternion& P4, UnityEngine.HyperGryph.ECS.Entity& P5)
  System.Boolean __Gen_Wrap_659(UnityEngine.HyperGryph.ECS.Entity P0, UnityEngine.HyperGryph.ECS.EntityManager& P1, Unity.Collections.FixedString32Bytes P2, Unity.Mathematics.float3& P3, Unity.Mathematics.quaternion& P4)
  System.Boolean __Gen_Wrap_660(UnityEngine.HyperGryph.ECS.Entity P0, System.Object P1, Unity.Mathematics.float3& P2, Unity.Mathematics.quaternion& P3)
  Beyond.Gameplay.Factory.ChapterFragment& __Gen_Wrap_661(UnityEngine.HyperGryph.ECS.EntityManager P0, System.Int32 P1, System.Boolean& P2, UnityEngine.HyperGryph.ECS.Entity& P3)
  System.IntPtr __Gen_Wrap_662(UnityEngine.HyperGryph.ECS.EntityManager P0)
  System.Boolean __Gen_Wrap_663(UnityEngine.HyperGryph.ECS.EntityManager P0)
  Beyond.Gameplay.Factory.GlobalEnv& __Gen_Wrap_664(UnityEngine.HyperGryph.ECS.EntityManager P0)
  System.Boolean __Gen_Wrap_665(Beyond.Gameplay.Factory.GlobalEnv& P0, Beyond.Gameplay.Factory.InteractFacCollectJob.BuildingInfo& P1)
  System.Boolean __Gen_Wrap_666(Beyond.Gameplay.Factory.GlobalEnv& P0, Beyond.Gameplay.Factory.InteractFacCollectJob.LogisticInfo& P1)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_667(System.Object P0, System.Int32 P1)
  System.Void __Gen_Wrap_668(System.Object P0, System.Int32 P1)
  Beyond.Gameplay.Factory.Unsafe.LinearAllocator.Allocation __Gen_Wrap_669(System.Object P0, System.Int32 P1, System.Int32 P2)
  System.Void __Gen_Wrap_670(Beyond.Gameplay.Factory.Unsafe.LinearAllocatorUnmanaged& P0, System.Int32 P1, Unity.Collections.Allocator P2)
  System.UInt32 __Gen_Wrap_671(System.Object P0)
  System.Void __Gen_Wrap_672(System.Object P0, System.UInt32 P1, System.Int32& P2, System.Int32& P3)
  System.IntPtr __Gen_Wrap_673(Beyond.Gameplay.Factory.GlobalEnv& P0)
  System.Void .cctor()
END_CLASS

CLASS: IFix.ILFixInterfaceBridge
TYPE:  class
TOKEN: 0x200026F
EXTENDS: AnonymousStorey
FIELDS:
METHODS:
  System.Void .ctor(System.Int32 fieldNum, System.Int32[] fieldTypes, System.Int32 typeIndex, System.Int32[] vTable, System.Int32[] methodIdArray, IFix.Core.VirtualMachine virtualMachine)
  System.Void RefAsyncBuilderStartMethod()
END_CLASS

CLASS: IFix.WrappersManagerImpl
TYPE:  class
TOKEN: 0x2000270
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
TOKEN: 0x2000271
FIELDS:
  public            System.Int32                    value__  // 0x10
  public    static  IFix.IDMAP0                     Beyond-AssetInstanceParseUtil-Parse0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-AssetInstanceParseUtil-Parse1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-AssetInstanceParseUtil-Get0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-PoolCore-ListPoolInitializer_FactoryUnsafe_Gameplay_Beyond-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-PoolCore-ListPoolInitializer_FactoryUnsafe_Gameplay_Beyond-InitializeAtRuntime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PerDrawConfig-_OnPerDrawTypeChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PerDrawConfig-OnValidate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FFactoryStateColorConfig-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-FactorySetting-OnEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_empty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_env0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_connection0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_buildingUnit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_buildingFakeUnit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_buildingRenderOnlyUnit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_buildingPreviewUnit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_buildingGuideHintUnit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_conveyor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_guideConveyor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_pipe0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_pipeHolder0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_cargo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_buildingRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_pedestalRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_conveyorLeftRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_conveyorRightRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_conveyorMidRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_figurePipeHolderRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_figureLeftRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_figureRightRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_figureMidRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_conveyorPreviewRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_pipePreviewRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_pipeComRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_pipeLeftRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_pipeMidRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_pipeRightRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_pipeTrackLeftPreviewRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_pipeTrackMidPreviewRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_pipeTrackRightPreviewRender0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_outputUIRenderer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_wireRenderer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_unitStatusUIRenderer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_portPreviewUIRenderer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_gridRenderer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_gridMainRegionRenderer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_portStatusUIRenderer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Archetypes-get_scope0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorExtContainer-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorExtContainer-Size0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorExtContainer-AsSpan0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorExtContainer-Create0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorExtContainer-Destroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorExtContainer-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorExtContainer-Reserve0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorExtContainer-Data0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorExtContainer-Get0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorExtContainer-ConveyorExt-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-_MergeAdjacentFreeBlocks0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-_ExpandMemory0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Allocate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorInfoAllocator-Allocate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Free0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Expand0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Reserve0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Resize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorInfoAllocator-Resize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorInfoAllocator-Free0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorInfoAllocator-CalculateSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-PrintAllocations0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorInfoAllocator-DebugPrint0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataContainer-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataContainer-Size0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataContainer-AsSpan0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataContainer-Create0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataContainer-Destroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataContainer-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataContainer-Reserve0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataContainer-Data0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataContainer-Get0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataContainer-SharedExtData-IsDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataContainer-SharedExtData-SetDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataContainer-SharedExtData-IsPendingUnit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-WireRendererInfo-get_pos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-WireRendererInfo-get_rot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EntitySearcher-GetLogicEntityMap0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitId-Create0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EntitySearcher-RegisterLogicEntity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EntitySearcher-UnregisterLogicEntity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EntitySearcher-GetLogicEntity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EntitySearcher-_DestroyAllEntities0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EntitySearcher-DestroyAll0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-InitExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-ResetExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-ReleaseExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-CreateConveyorExtHandle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-DestroyConveyorExtHandle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-GetConveyorExt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-GetConveyorExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-CreateSharedData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-GetSharedData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-DestroySharedData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-GetSharedData1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-CreateTransHierarchy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-GetHierarchyData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-GetHierarchyData1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-ToMatrix0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-WorldTrans0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-DestroyHierarchyData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-GetHierarchyData2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Create0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-CreateVATFSMDefinitionContainer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-GetVATFSMDefinition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Destroy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-DestroyVATFSMDefinition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Data0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactorySharedDataManager-GetVATFSMDefinition1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectFragment-PeekState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectFragment-PopState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectFragment-ShiftState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectFragment-_Shrink0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectFragment-PushState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectFragment-InsertState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectFragment-DisableState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectFragment-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CutoffState-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CutoffState-SetCutoffY0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CutoffState-SetMode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BuildDismissState-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-HighLightState-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-HighLightState-SetData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-HighLightState-GetEffectType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-HighLightState-IsHighlight0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-HighLightState-HighlightWithSubIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-HighLightState-ClearHighlightableIndexList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-HintState-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FigureState-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OverloadState-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OverloadInvalidState-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-DitherState-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintState-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintState-SetEnable1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintState-IsLighten0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintState-LightenWithSubIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintState-ClearLightenIndexList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PreSelectState-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PreSelectState-IsLighten0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PreSelectState-LightenWithSubIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PreSelectState-ClearLightenIndexList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SoloSelectState-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SoloSelectState-IsLighten0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ContinuationState-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ContinuationState-IsLighten0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ContinuationState-LightenWithSubIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ContinuationState-ClearLightenIndexList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SocialSharingState-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PowerInteractionState-SetEnable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-get_anyEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRendererFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BattleFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BindRenderEntityFragment-Binded0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BindRenderEntityFragment-BindRenderEntity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BindRenderEntityFragment-BindRenderEntities0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BindRenderEntityFragment-BindRenderEntities1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BindRenderEntityFragment-UnbindRenderEntity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BindRenderEntityFragment-ClearBindRenderEntities0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BindRenderEntityFragment-HasRenderer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BindRenderEntityFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BurnPowerFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BusFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BusFreeFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CacheFragment-CalcIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CacheFragment-GetCacheItem0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CacheFragment-SetCacheItem0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CacheFragment-SetCacheSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CacheFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CacheTransportFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoFragment-PredictPos0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoFragment-PredictPosWithDeltaTime0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoFragment-CompareTo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoFragment-Create0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoRendererFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ChapterFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CollectorFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConnectionFragment-get_valid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConnectionFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-GetConveyorRendererInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorFragment-CalcRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorFragment-SetInflection0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorFragment-Sample0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorFragment-IsInRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorFragment-GetInRectUnitIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorFragment-FillRectTargets0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorFragment-DrawDebug0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorLogisticsUnitFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorRenderFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorRenderLeftFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorRenderRightFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorRenderMidFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CullResultFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-DebugFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EvtDestroyUnit-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-DisabledTag-ContainsComponentId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-DisabledTag-And0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-DisabledTag-Or0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-DisabledTag-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ShowStateUI-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ShowNameUI-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-HasRenderer-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EvtUpdatePipeEffect-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EvtChangeTemplate-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EvtCreateUnitRenderer-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EvtUpdateStatusEffect-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EvtPendingCreateRenderer-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EvtUpdateRendererProperty-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EvtStatusChange-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EvtCreateInteract-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EvtVatUpdate-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EvtUpdatePedestalColorLUT-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-EvtAudio-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AudioFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ReleaseTagFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CurMapUnitTag-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitFragment-Create0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitRenderPipeLogisticsFigureReplaceFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BusRenderFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitRenderBuildingFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitRenderPedestalFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitRendererRegularFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitOnlyRendererFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FakeUnitFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UIUnitFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GuideHintFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitPreviewFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorRegularFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorGuideFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeRegularFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorPreviewRendererFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipePreviewRendererFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipePreviewFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FigureRenderFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FigureRenderLeftFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FigureRenderRightFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FigureRenderMidFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FigureRenderPipeHolderFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FluidConsumeFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FluidContainerFragment-Set0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FluidContainerFragment-SetAmount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FluidContainerFragment-Get0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FluidContainerFragment-HasLiquid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FluidContainerFragment-CalcRenderItemAmount0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FluidContainerFragment-GetOffsetData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FluidContainerFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FluidPumpInFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FluidPumpOutFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FluidReactionFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FluidSprayFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FormulaManualFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutOfBufferWarning-ResetFlags0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutOfBufferWarning-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-CreateQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-DisposeQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_portBlockPosListReader0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_outputUIPosListReader0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_buildingStatePosListReader0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-SwapCargoBuffer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_cargoDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-SwapConveyorBuffer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_conveyorDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-SwapPortArrowBuffer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_portArrowDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_conveyorInsideMatricesReader0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-SwapPreviewConveyorBuffer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_previewConveyorDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-SwapGuideFigureBuffer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_guideFigureDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-SwapPipeBuffer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_pipeDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_pipeHolderPosMatricesReader0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_comPosMatricesReader0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-SwapWireBuffer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_wireNormalDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_wireHsNormalDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_wireDisableDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_wireStrengthenDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_wireHsStrengthenDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_wireStrengthenDisableDirty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-GetConveyorRendererInfo1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-AllocateConveyorInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-CalculateConveyorInfoSize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-ResizeConveyorInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-FreeConveyorInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-DebugAllocatorPrint0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_animatorParamRequestQueueReader0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-TryGetParameterIndexAndType0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-GetStateIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-_AddAnimatorParamRequest0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-AddSetAnimatorParamRequest0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-get_animatorAudioQueueWriter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-GetAudioVATDataAt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-GetAudioVATDataLength0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-ClearAudioVATData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-ResetFlags0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalEnv-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-HealthPoleFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-InventoryFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LogisticEffectFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LogisticEntityBindFragment-EnqueueCargoEntityImpl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LogisticEntityBindFragment-DequeueCargoEntityImpl0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LogisticEntityBindFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-MapGridRendererFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputFragment-Clean0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputFragment-GetColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputFragment-SetColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputFragment-SetColor1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputFragment-SetAtlasRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputFragment-SetAtlasRect1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputFragment-GetAtlasRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputFragment-GetEnableLiquidIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputFragment-SetEnableLiquidIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputFragment-GetLiquidIconUV0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputFragment-SetLiquidIconUV0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputFragment-get_hasOutput0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputUIRendererFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetIntensity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashIntensity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlash0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashDuration0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-SetFlashColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetIntensity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashIntensity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlash0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashDuration0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-GetFlashColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalLightFlashConfigFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeEffectFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeFragment-SetInflection0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeFragment-Bend0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeFragment-GetCornerIndexList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeFragment-Sample0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeFragment-IsInRect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeFragment-GetInRectUnitIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeFragment-FillRectTargets0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeHolderFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeLogisticsUnitFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeComRenderFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeRenderFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeTrackRenderFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeRenderLeftFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeRenderRightFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeRenderMidFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ComplexPortFragment-BindComponentId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ComplexPortFragment-BlockPortsWithComponentId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ComplexPortFragment-BlockPorts0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ComplexPortFragment-FollowUnit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ComplexPortFragment-AnyPortBlocked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ComplexPortFragment-AnyPortConnected0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PortData-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ComplexPortFragment-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ComplexPortFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PortData-TRS0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PortPreviewUIRendererFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PortStatusUIFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PowerPoleFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ProducerFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataFragment-GetExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataFragment-DestroyData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SharedDataFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SocialFragment-Create0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SocialFragment-IsHighLiked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SocialFragment-IsLiked0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SocialFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SignData-GetText0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SignData-GetCustomPerDrawData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SignData-SetSignBuildingIconWithRenderEntity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-SignData-SetSignBuildingIcon0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-FromMatrix0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-FromMatrixSafe0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-FromPositionRotation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-FromPositionRotationScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-FromPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-FromPosition1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-FromRotation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-FromScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-TransformDirection0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-Right0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-Up0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-Forward0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-TransformPoint0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-InverseTransformPoint0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-InverseTransformDirection0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-TransformRotation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-InverseTransformRotation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-TransformScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-InverseTransformScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-TransformTransform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-InverseTransformTransform0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-Inverse0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-ToInverseMatrix0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-WithPosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-WithPosition1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-WithRotation0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-WithScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-Translate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-ApplyScale0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-Rotate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-RotateX0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-RotateY0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-RotateZ0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-Equals0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalTransform-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Root-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Parent-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Child-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorld-SetValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorld-get_right0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorld-get_up0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorld-get_forward0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorld-get_position0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorld-get_prePosition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorld-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UdPipeFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitConfigFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactoryUnitExtendConfig-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitInteractFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitRenderFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-RenderLookAtFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ChapterTagFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitStatusFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitOverrideStatusFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitStatusEffectFragment-SetEffects0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitStatusEffectFragment-GetEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitStatusEffectFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitStatusUIRendererFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitTransFragment-InBound0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitTransFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ValveFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BoxValve-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FluidValve-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintSlotInfo-ContainsNodeId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintSlotInfo-RemoveEntityFromSlot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintSlotInfo-FindEmptySlotIdx0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSuitableSlotIdx0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintSlotInfo-SetSlotId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSlotIds0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintSlotInfo-AppendSlotInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintSlotInfo-ClearSlotInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintSlotInfo-DiffSlotInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintSlotInfo-GetPendingEntityCountInSlot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintSlotInfo-GetSlotInfo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintSlotInfo-GetAllPendingEntitiesInSlot0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintSlotInfo-CreateDefault0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BlueprintSlotInfo-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorRendererInfo-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitId-Equals0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitId-Equals1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitId-GetHashCode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Visibility-GetVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Visibility-get_isVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Visibility-SetVisible0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-WireRendererFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-MapGridRendererData-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-Reset0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-ResetOverride0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrCullDis0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrUI0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrBuildingName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-CullingGlobalSetting-get_sqrWireCullDis0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-Disable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-ResetOverride0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_crossCollectFrameInterval0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_cullingSystemInterval0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_unitPreviewSystemInterval0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_portPreviewRenderSystemInterval0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_buildingStateSystemInterval0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_portBlockSystemInterval0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_outputUISystemInterval0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_buildingNameSystemInterval0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_adjustGroundSystemInterval0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-SystemIntervalGlobalSetting-get_gridSystemInterval0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-ResetOverride0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-Disable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_nearByCheck0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_portPreviewCheckDistance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_pedestalFlashCheckDistance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_logisticEffectCheckDistance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_unitRendererCheckDistance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_l2wCheckDistance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-NearByDistanceGlobalSetting-get_additiveEffectCheckDistance0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-Disable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-ResetOverride0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-World3DUiGlobalSetting-get_buildingNameShadowDisable0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetBuildCurve0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetRepairCurve00  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-CurveGlobalSetting-SetRepairCurve10  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-MapGridRendererData-UpdateGrid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-_GetKey0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-ApplyPass0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-set_Item0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-set_Item0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-Parse0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-get_Item0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawPassGlobalSetting-GetPerDrawPassConfig0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-get_Item0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-PerDrawGlobalSetting-PerDrawColorGlobalSetting-GetPerDrawConfig0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-UIEffectPathConfig-Parse0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-GlobalSharedData-UIEffectPathConfig-Get0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BaseProcessor-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BaseProcessor-PreExecute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BaseProcessor-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BaseProcessor-LateExecute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BaseProcessor-CleanUp0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BaseProcessor-TearDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BaseProcessor-ScheduleNoneDependencies0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BaseProcessor-StructuralSync0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BaseProcessor-InLowFrameMode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BaseProcessor-SpecialEntityExisted0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetApplyRenderPointer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetFacRegionValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetQueryStateIconPathFuncPtr0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetLogicEntityWithPosAdapter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetQueryBuildingStatePointer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnsafeJobFuncPointers-GetSetEntityFlashStatuePointer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectJob-_OnStackEmpty0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectJob-_UpdateInternalStateLifeCycle0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectJob-_InitBuildState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectJob-ScheduleDefer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectJob-ScheduleDefer1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectQueryJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectQueryJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPNormalEffectExecute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPBuildEffectExecute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BPBuildCutoffEffectExecute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRenderJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ResetMaterial0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BuildStateStart0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_BuildStateEnd0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_Repair0Start0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRenderJob-_Repair0End0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRenderJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRenderJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRenderJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ScheduleDefer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AdditiveEffectRenderJob-ScheduleDefer1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AudioJobs-AudioDistanceAndCullingJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AudioJobs-AudioGroupEmitterJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AudioJobs-AudioGroupEmitterJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-_DoCalculate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-AudioJobs-WaterPipeEmitterJob-SetGlobalEnv0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchArrowJob-_BatchPortArrow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchArrowJob-_ExecutePort0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchArrowJob-_ExecutePreview0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchArrowJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchArrowJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchArrowJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchInsideConveyorJob-_BatchPortInside0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchInsideConveyorJob-_CollectInsideConveyor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchInsideConveyorJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchInsideConveyorJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchInsideConveyorJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchNormalArrowJob-_BatchPortArrow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchNormalArrowJob-_ExecutePort0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchNormalArrowJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchNormalArrowJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchNormalArrowJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchPreviewArrowJob-_BatchPortArrow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchPreviewArrowJob-_ExecutePreview0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchPreviewArrowJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BatchPreviewArrowJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BufferSwapJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BuildingLiquidRenderJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BuildingLiquidRenderJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BuildingLiquidRenderJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BuildingLiquidRenderJob-ScheduleDefer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BuildingLiquidRenderJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BuildingStatePosCollectJob-_Collect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BuildingStatePosCollectJob-Execute2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BuildingStatePosCollectJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-BuildingStateRendererJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoCollectJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoCollectJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoCollectJob-SetGlobalEnvRef0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoCollectJob-SetConveyorExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoCollectJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoPredictJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoPredictJob-SetConveyorExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoPredictJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoPredictJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoPredictJob-ScheduleDefer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoPredictQueryJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoPredictQueryJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoRenderJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoRenderJob-SetRendererList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoRenderQueryJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoRenderQueryJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorCollectJob-_Collect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorCollectJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorCollectJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorCollectJob-Execute2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorCollectJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorFigureRendererJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorFigureRendererJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorFigureRendererJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorInsideRenderJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-_Collect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorPreviewCollectJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorRendererJob-_UpdateCachedConveyor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorRendererJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorRendererJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ConveyorRendererJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-InteractFacCollectJob-_SwapBuffer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-IsPointInSector0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-SetData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecuteBuilding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-InteractFacCollectJob-_SnapDirectionToAxis0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-InteractFacCollectJob-_CheckDist0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecuteConveyor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-InteractFacCollectJob-_ExecutePipe0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-InteractFacCollectJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-InteractFacCollectJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-ToString0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-InteractFacCollectJob-BuildingInfo-IsPending0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-InteractFacCollectJob-LogisticInfo-IsPending0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorldJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorldJob-TransTRS0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorldJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorldJob-SetHierarchyData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorldJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorldJob-ScheduleDefer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorldQueryJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LocalToWorldQueryJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LogisticEffectJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LookAtJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LookAtJob-SetHierarchyData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LookAtJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LookAtJob-ScheduleDefer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LookAtQueryJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-LookAtQueryJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputCollectJob-_Collect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputCollectJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputCollectJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputCollectJob-Execute2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputCollectJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-OutputRenderJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalFlashJob-_Flash0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalFlashJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalFlashJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PedestalFlashJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeCollectJob-_CollectPipe0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeCollectJob-_CollectPipeCom0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeCollectJob-_ExecutePipe0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeCollectJob-_CollectTrack0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeCollectJob-_ExecutePreviewPipe0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeCollectJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeCollectJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeCollectJob-Execute2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeCollectJob-SetGlobalEnvRef0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeCollectJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeComRendererJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeFigureRendererJob-_UpdateCachedPipe0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeFigureRendererJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeFigureRendererJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeHolderFigureRendererJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeHolderFigureRendererJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeHolderHideRendererJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeHolderHideRendererJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeHolderHideRendererJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeLogisticsPosCollectJob-Execute2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeRendererJob-_UpdateCachedPipe0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeRendererJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeRendererJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeTrackRendererJob-_UpdateCachedTrack0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeTrackRendererJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeWaterThicknessQueryJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeWaterThicknessQueryJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-SetGlobalEnv0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PipeWaterThicknessRiseJob-ScheduleDefer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PortArrowRenderJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PortStateCollectJob-_Collect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PortStateCollectJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PortStateCollectJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PortStateCollectJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PortStateCollectJob-Execute2  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PortStateRendererJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PreviewUnitQueryJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PreviewUnitQueryJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PumpInEffectJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PumpInEffectJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PumpInEffectJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PumpInEffectJob-ScheduleDefer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PumpInEffectJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-StatusChangeJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitCullingJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitCullingJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitCullingJob-SetGlobalEnvRef0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitCullingJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitPreviewRenderJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitPreviewRenderJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetGlobalEnvRef0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitPreviewRenderJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitPreviewRenderJob-ScheduleDefer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitRendererQueryJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UnitRendererQueryJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-SetQueryResult0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-UpdateUnitRendererTRSJob-ScheduleDefer0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-WireCollectJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-WireCollectJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-WireCollectJob-SetGlobalEnvRef0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-WireCollectJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-WireRenderJob-_UpdateCachedWire0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-WireRenderJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-WireRenderJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FPtrNativeCurve-IsValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FPtrNativeCurve-CreateCurve0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FPtrNativeCurve-Evaluate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PerDrawPassConfig-Size0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PerDrawPassConfig-_ParseToHGShaderLightMode0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PerDrawPassConfig-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PerDrawPassConfig-Apply1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PerDrawConfig-Size0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PerDrawConfig-_OnColorChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PerDrawConfig-_OnFloat4Changed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PerDrawConfig-_OnFloatChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-PerDrawConfig-Apply0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ProcessorInterval-_CheckInterval0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ProcessorInterval-CheckInterval0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CargoPredictProcessor-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearBuildingPtr0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearConveyorPtr0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-SetNearPipePtr0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CrossFrameProcessor-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CrossFrameProcessor-LateExecute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-CrossFrameProcessor-TearDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectConveyor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPreviewConveyor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectGuideConveyor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetStateColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CreateCurrent0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CreateAllocator0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_InitArrowPlaced0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectBuildingState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectOutput0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectCargo0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectWire0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPipe0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPipeLogistics0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortArrowWithDiff0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-_CollectPortArrow0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-LateExecute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FacRendererCollectProcessor-TearDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-GetColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-GetIndex0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FactoryBaseColorLutConfig-CreateOrGet0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetIndicatorColor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetStateName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FFactoryStateColorConfig-GetPerDrawList0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-FFactoryStateColorConfig-LogicStateConfig-_OnColorChanged0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetFloat0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetInt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetBool0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetAllTriggers0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetParametersByDef0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Enter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-Init0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Exit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-SetState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Exit0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-ToNextState0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Enter0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-SetTransition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateFragment-__AOT_FOR_FIX__0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMState-get_process0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMState-Update0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMState-SetProgress0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-get_fromStateWeight0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMTransition-Update0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetFloat0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetInt0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetBool0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetTrigger0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetTrigger0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-ResetTrigger0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-SetValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMParameterSet-GetValue0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMSetParamRequestHandlerJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-_Evaluate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-TryGetValidTransition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionHelper-ResetUsedTriggers0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-_CheckTransitions0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-_AddVATAudioData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-_ComputeVATFrameData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-Execute1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMStateUpdateJob-SetSharedExtData0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-_RemoveDuplicationRequest0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-_HandleSetAnimatorParamRequest0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-Execute0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMProcessor-TearDown0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Size0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-AsSpan0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Reserve0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Get0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-VATFSMDefinitionContainer-Get1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-InitFSMDefinition0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-RegisterFSM0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-ECSVATFSM-FSMDefinitionLibrary-GetStateName0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Util-JobHandlerExtensions-SafeComplete0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-BurstBridge-BeginProfilerSample0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-BurstBridge-EndProfilerSample0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-QueryBuildingStateIsClosed0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-_IsPowerBuilding0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-CulledWithLogicEntity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-CulledWithRendererEntity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetVisibility0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetVisibility1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibility0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-UpdatePipeEffect0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibilityWithNotify0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetVisibility1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-SetInMainRegion0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-IsInMainRegionFuzzy0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-UpdatePipeEffect1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingExtendConfig0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingStaticMountWorldTRS0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-EntityExtensions-GetBuildingStaticMountWorldTRS1  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-GameplayExtensions-GetChapterEntity0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetGlobalEnvPtr0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-IsGlobalEnvValid0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetGlobalEnvRef0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractFac0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractConveyor0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-GlobalEnvExtensions-GetInteractPipe0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocator-_MergeAdjacentFreeBlocks0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocator-_ExpandMemory0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Allocate0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Reserve0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Free0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Expand0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Resize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocator-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocator-PrintAllocations0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Initialize0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-LinearAllocatorUnmanaged-Dispose0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-TLSFAllocator-GetFreeSpace0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-TLSFAllocator-MappingInsert0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-AllocManualNodeId0  // 0x0
  public    static  IFix.IDMAP0                     Beyond-Gameplay-Factory-Unsafe-FactoryUnsafeUtil-AddressOf0  // 0x0
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

CLASS: UnityEngine.HyperGryph.ECS.ColliderComponentExtensions
TYPE:  class
TOKEN: 0x2000007
FIELDS:
METHODS:
  System.Void ToggleCollision(UnityEngine.HyperGryph.ECS.Entity logicEntity, System.Boolean enable, UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Void UpdateCollisionTRS(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Void UpdateCollisionTRS(UnityEngine.HyperGryph.ECS.ECSColliderComponent c, Unity.Mathematics.float3 pos, Unity.Mathematics.quaternion rot)
  System.Void DestroyCollisionWithRenderEntity(UnityEngine.HyperGryph.ECS.Entity rEntity, UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Void DestroyCollision(UnityEngine.HyperGryph.ECS.Entity logicEntity, UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Void <ToggleCollision>g__Toggle|0_0(UnityEngine.HyperGryph.ECS.Entity rendererEntity, UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.ColliderComponentExtensions.<>c__DisplayClass0_0& )
  System.Void <UpdateCollisionTRS>g__UpdateTRS|1_0(UnityEngine.HyperGryph.ECS.Entity rendererEntity, UnityEngine.HyperGryph.ECS.EntityManager& em)
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.ECSExtensions
TYPE:  class
TOKEN: 0x2000009
FIELDS:
METHODS:
  UnityEngine.HyperGryph.ECS.Entity GetEntity(UnityEngine.HyperGryph.ECS.GroupType group, System.Int32 index)
  System.Boolean HasComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity& entity, System.Int32 componentId)
  System.Void SetComponentEnabled(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity entity, System.Boolean flag)
  System.Void CreateEntities(UnityEngine.HyperGryph.ECS.EntityManager& em, Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> archetypes, Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> result)
  UnityEngine.HyperGryph.ECS.Entity CreateEntity(UnityEngine.HyperGryph.ECS.EntityManager& entityManager)
  UnityEngine.HyperGryph.ECS.Entity CreateEntity(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.ComponentType> archetypes)
  System.Void Is(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity, System.Boolean flag)
  System.Void AddComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void AddComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity, System.Int32 componentId, System.IntPtr& component, System.Int32 componentSize)
  System.Void AddOrSetComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity, T t)
  System.Void AddOrSetComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity, T1 t1, T2 t2)
  System.Void SetComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity, System.Int32 componentId, System.IntPtr& component, System.Int32 componentSize)
  System.Void SetComponents(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity& entity, T0& t0, T1& t1, T2& t2)
  System.Void SetComponents(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity& entity, T0& t0, T1& t1, T2& t2, T3& t3)
  System.Void SetComponents(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity& entity, T0& t0, T1& t1, T2& t2, T3& t3, T4& t4)
  System.Void _SetComponentImpl(UnityEngine.HyperGryph.ECS.EntityInstanceData& entityData, UnityEngine.HyperGryph.ECS.EntityTypeInstanceData& entityTypeData, System.Int32 componentId, System.IntPtr& component, System.Int32 componentSize)
  UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.EntityQueryBuilder& queryBuilder)
  UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em)
  UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em)
  UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em)
  UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em)
  UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em)
  UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em)
  UnityEngine.HyperGryph.ECS.EntityManagerRange Iterate(UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Void GetComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity, System.Int32 componentId, System.Int32 componentSize, System.Void* componentPtr)
  System.Boolean MoveComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity src, UnityEngine.HyperGryph.ECS.Entity des)
  System.Void RemoveComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity, System.Int32 componentId)
  System.Void SafeRemoveComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void RemoveComponent(UnityEngine.HyperGryph.ECS.EntityManager& entityManager)
  System.Boolean GetInstance(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity& entity, TR& component)
  System.Boolean GetFirst(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity& entity, TR& component)
  System.Boolean GetFirst(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.Entity& entity, TR& component)
  System.Void NotifyEvent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity logicEntity)
  System.Void NotifyEvent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity logicEntity, T t)
  System.Void NotifyEvent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity logicEntity, T1 t1, T2 t2)
  System.Void DispatchEvent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void DispatchEvent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity entity, T t)
  System.Void DispatchEvent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity entity, T1 t1, T2 t2)
  System.Void DestroyEntitiesWithArchetype(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, UnityEngine.HyperGryph.ECS.ComponentMask& entityMask)
  System.Void DestroyEntities(UnityEngine.HyperGryph.ECS.EntityManager& entityManager)
  System.Void DestroyEntities(UnityEngine.HyperGryph.ECS.EntityManager& entityManager)
  System.Boolean HasEntity(UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Boolean HasEntity(UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int32 compId)
  System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em, System.Int32 compId0, System.Int32 compId1)
  System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Int32 GetEntityCount(UnityEngine.HyperGryph.ECS.EntityManager& em)
  System.Void EnsureComponent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void EnsureComponent(UnityEngine.HyperGryph.ECS.EntityManager& em, UnityEngine.HyperGryph.ECS.Entity entity, T& comp)
  UnityEngine.HyperGryph.ECS.ECSSpan<T> GetComponentAsSpan(UnityEngine.HyperGryph.ECS.GroupType groupType)
  UnityEngine.HyperGryph.ECS.ECSSpan<T> GetComponentAsSpan(UnityEngine.HyperGryph.ECS.GroupType groupType, System.Int32 componentId)
  UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(UnityEngine.HyperGryph.ECS.EntityManager em, System.Int32 id0, System.Int32 id1, System.Int32 id2, System.Int32 id3, System.Int32 id4, System.Int32 id5, System.Int32 id6)
  UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(UnityEngine.HyperGryph.ECS.EntityManager em, System.Int32 id0, System.Int32 id1, System.Int32 id2, System.Int32 id3, System.Int32 id4, System.Int32 id5, System.Int32 id6, System.Int32 id7)
  UnityEngine.HyperGryph.ECS.ComponentMask ComposeComponentMaskAll(UnityEngine.HyperGryph.ECS.EntityManager em, System.Int32 id0, System.Int32 id1, System.Int32 id2, System.Int32 id3, System.Int32 id4, System.Int32 id5, System.Int32 id6, System.Int32 id7, System.Int32 id8)
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderExtensions
TYPE:  class
TOKEN: 0x200000A
FIELDS:
METHODS:
  System.Void RenderWithTRS(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent binder, Beyond.Gameplay.Factory.LocalToWorld& localToWorld)
  System.Void RenderWithTRS(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent binder, Unity.Mathematics.float4x4 value)
  System.Void EnableDither(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent binder, System.Boolean enable, System.Single alphaValue, UnityEngine.HyperGryph.HGObjectFlags objectFlags)
  System.Void EnableDither(UnityEngine.HyperGryph.ECS.HGFactoryRendererBinderComponent binder, UnityEngine.HyperGryph.ECS.EntityManager& rEntityManager, System.Boolean enable, System.Single alphaValue, UnityEngine.HyperGryph.HGObjectFlags objectFlags)
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityCommandBuffer
TYPE:  struct
TOKEN: 0x200000B
FIELDS:
  public            UnityEngine.HyperGryph.ECS.EntityCommandBuffer.EntityCommandCallbackonEntityCreate  // 0x10
  public            UnityEngine.HyperGryph.ECS.EntityCommandBuffer.EntityCommandCallbackonEntityDestroy  // 0x18
  public            UnityEngine.HyperGryph.ECS.EntityCommandBuffer.EntityCommandCallbackonComponentUpdate  // 0x20
  public            UnityEngine.HyperGryph.ECS.EntityCommandBuffer.EntityCommandCallbackonComponentAdd  // 0x28
  public            UnityEngine.HyperGryph.ECS.EntityCommandBuffer.EntityCommandCallbackonComponentRemove  // 0x30
  public    static  System.UInt32                   TempIdx  // 0x0
  public            Unity.Collections.NativeQueue<UnityEngine.HyperGryph.ECS.EntityCommandBufferData>buffers  // 0x38
  public            Unity.Collections.NativeParallelHashMap<System.UInt64,UnityEngine.HyperGryph.ECS.EntityCommandBuffer.VirtualEntityMap>tempEntities  // 0x50
  private   readonly UnityEngine.HyperGryph.ECS.EntityManager<entityManager>k__BackingField  // 0x60
METHODS:
  System.Void .ctor(UnityEngine.HyperGryph.ECS.EntityManager& entityManager, Unity.Collections.Allocator allocator)
  UnityEngine.HyperGryph.ECS.EntityManager get_entityManager()
  System.ValueTuple<System.Boolean,UnityEngine.HyperGryph.ECS.Entity> GetRealEntity(UnityEngine.HyperGryph.ECS.Entity virtualEntity)
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityCommand
TYPE:  class
TOKEN: 0x200000E
FIELDS:
METHODS:
  UnityEngine.HyperGryph.ECS.EntityCommandBuffer CreateCommandBuffer(UnityEngine.HyperGryph.ECS.EntityManager entityManager, Unity.Collections.Allocator allocator)
  UnityEngine.HyperGryph.ECS.Entity CreateEntity(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb)
  System.Void DestroyEntity(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void AddComponent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void AddComponent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity, T component)
  System.Void RemoveComponent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void SetComponent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity, T component)
  System.Void Is(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity, System.Boolean flag)
  System.Void GetComponent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity, T& component)
  System.Void* _ComponentCpy(T component)
  System.Void NotifyEvent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void NotifyEvent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity, T t)
  System.Void DispatchEvent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void DispatchEvent(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, UnityEngine.HyperGryph.ECS.Entity entity, T component)
  System.Void Playback(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb, System.Boolean autoDispose)
  System.Void Dispose(UnityEngine.HyperGryph.ECS.EntityCommandBuffer ecb)
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityCommandOp
TYPE:  class
TOKEN: 0x200000F
FIELDS:
  public    static readonly System.Int32                    CREATE  // 0x0
  public    static readonly System.Int32                    ADD  // 0x4
  public    static readonly System.Int32                    REMOVE  // 0x8
  public    static readonly System.Int32                    MODIFY  // 0xC
  public    static readonly System.Int32                    DESTROY  // 0x10
  public    static readonly System.Int32                    QUERY  // 0x14
METHODS:
  System.Void .ctor()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityCommandBufferData
TYPE:  struct
TOKEN: 0x2000010
FIELDS:
  public            System.Int32                    op  // 0x10
  public            UnityEngine.HyperGryph.ECS.Entityentity  // 0x14
  public            UnityEngine.HyperGryph.ECS.CommandBufferComponentcomponentData  // 0x20
METHODS:
  System.Void Free()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.CommandBufferComponent
TYPE:  struct
TOKEN: 0x2000011
FIELDS:
  public            System.Int32                    componentId  // 0x10
  public            System.Int32                    componentSize  // 0x14
  public            System.Void*                    component  // 0x18
METHODS:
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityCommandBufferV2
TYPE:  struct
TOKEN: 0x2000012
FIELDS:
  public    static  System.Int32                    s_mapSize  // 0x0
  public            Unity.Collections.NativeQueue<UnityEngine.HyperGryph.ECS.EntityCommandBufferData>buffers  // 0x10
  public            Unity.Collections.NativeParallelHashMap<System.UInt64,UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.VirtualEntityMap>tempEntities  // 0x28
METHODS:
  System.Void .ctor(Unity.Collections.Allocator allocator)
  System.ValueTuple<System.Boolean,UnityEngine.HyperGryph.ECS.Entity> GetRealEntity(UnityEngine.HyperGryph.ECS.Entity virtualEntity)
  System.Void Reset()
  System.Void Dispose()
  Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle dependsOn)
  System.Boolean get_isEmpty()
  UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter AsParallelWriter()
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityCommandV2
TYPE:  class
TOKEN: 0x2000015
FIELDS:
  private   static readonly System.Collections.Generic.Queue<UnityEngine.HyperGryph.ECS.EntityCommandBufferV2>S_POOL  // 0x0
METHODS:
  UnityEngine.HyperGryph.ECS.EntityCommandBufferV2 CreateConcurrentCommandBufferV2(UnityEngine.HyperGryph.ECS.EntityManager em)
  System.Void DisposePool()
  System.Void Recycle(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2& buffer)
  UnityEngine.HyperGryph.ECS.Entity CreateEntity(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer)
  System.Void DestroyEntity(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void AddComponent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void AddComponent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity, T component)
  System.Void RemoveComponent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void SetComponent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity, T component)
  System.Void GetComponent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity, T& component)
  T* _ComponentCpy(T component)
  System.Void NotifyEvent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void NotifyEvent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity, T t)
  System.Void DispatchEvent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity)
  System.Void DispatchEvent(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2.EntityCommandBufferParallelWriter& writer, UnityEngine.HyperGryph.ECS.Entity entity, T component)
  System.Void Playback(UnityEngine.HyperGryph.ECS.EntityCommandBufferV2 ecb, System.Boolean autoRecycle)
  System.Void .cctor()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.ECSSpan`1
TYPE:  struct
TOKEN: 0x2000016
FIELDS:
  public            System.Void*                    buffer  // 0x0
  public            System.Int32                    length  // 0x0
METHODS:
  T& get_Item(System.Int32 index)
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityPool`3
TYPE:  struct
TOKEN: 0x2000017
FIELDS:
  private           System.Int32                    <defaultSize>k__BackingField  // 0x0
  private           System.Int32                    m_count  // 0x0
  private           System.Int32                    m_usedCount  // 0x0
  public            Unity.Mathematics.float4x4      customData  // 0x0
  private           Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity>m_pool  // 0x0
  private           System.Action<UnityEngine.HyperGryph.ECS.Entity,Unity.Mathematics.float3,Unity.Mathematics.float3,UnityEngine.Matrix4x4,Unity.Mathematics.float4x4>m_onSpawn  // 0x0
  private           System.Action<UnityEngine.HyperGryph.ECS.Entity,Unity.Mathematics.float4x4>m_onRecycle  // 0x0
  private           System.Action<Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity>,System.Int32,Unity.Mathematics.float4x4>m_onAllocate  // 0x0
  private           System.Action<Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity>,System.Int32,Unity.Mathematics.float4x4>m_onDeallocate  // 0x0
  private           Unity.Collections.Allocator     m_allocator  // 0x0
METHODS:
  System.Int32 get_defaultSize()
  System.Void set_defaultSize(System.Int32 value)
  System.Boolean DecreasePool()
  System.Boolean NeedToResize(System.Int32 count)
  UnityEngine.HyperGryph.ECS.Entity Spawn(Unity.Mathematics.float3 pos, Unity.Mathematics.float3 rot, UnityEngine.Matrix4x4 fArgs)
  UnityEngine.HyperGryph.ECS.Entity Spawn(System.Boolean& resized)
  System.Boolean Spawn(System.Int32 n)
  System.Void Recycle(System.Int32 count)
  UnityEngine.HyperGryph.ECS.Entity Recycle(UnityEngine.HyperGryph.ECS.Entity entity)
  UnityEngine.HyperGryph.ECS.Entity get_Item(System.Int32 index)
  UnityEngine.HyperGryph.ECS.EntityPool<T0,T1,T2> Alloc(System.Int32 count, System.Action<UnityEngine.HyperGryph.ECS.Entity,Unity.Mathematics.float3,Unity.Mathematics.float3,UnityEngine.Matrix4x4,Unity.Mathematics.float4x4> onSpawn, System.Action<UnityEngine.HyperGryph.ECS.Entity,Unity.Mathematics.float4x4> onRecycle, System.Action<Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity>,System.Int32,Unity.Mathematics.float4x4> onAllocate, System.Action<Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity>,System.Int32,Unity.Mathematics.float4x4> onDeallocate, Unity.Mathematics.float4x4 customData, Unity.Collections.Allocator allocator, System.Boolean autoAllocate)
  System.Void Free()
  System.Void _Resize()
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> op_Implicit(UnityEngine.HyperGryph.ECS.EntityPool<T0,T1,T2> pool)
  Unity.Collections.NativeArray<UnityEngine.HyperGryph.ECS.Entity> get_entities()
  Unity.Collections.NativeArray.ReadOnly<UnityEngine.HyperGryph.ECS.Entity> AsReadOnly()
  System.Boolean get_initialized()
  System.Int32 get_length()
  System.Int32 get_cacheSize()
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityHierarchyContainer
TYPE:  class
TOKEN: 0x2000018
FIELDS:
  public    static  System.Int32                    INVALID_INDEX  // 0x0
  private           Beyond.HGArray<UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.Node>m_nodes  // 0x10
METHODS:
  System.Void .ctor(Unity.Collections.Allocator allocator)
  System.Void Dispose()
  System.UInt32 Size()
  System.Span<UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData> AsSpan()
  Beyond.Gameplay.Factory.LocalTransform WorldTrans(System.UInt32 handle)
  Beyond.Gameplay.Factory.LocalTransform WorldTrans(UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData transform)
  Beyond.Gameplay.Factory.LocalTransform WorldTrans(UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData transform, UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData* hierarchyContainer)
  System.UInt32 Create(UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& value)
  System.Void Destroy(System.UInt32 handle)
  System.Void Reset()
  System.Void Reserve(System.UInt32 newCapacity)
  System.IntPtr Data()
  UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& get_Item(System.Int32 index)
  UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& get_Item(System.UInt32 index)
  UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& Get(System.UInt32 handle)
  UnityEngine.HyperGryph.ECS.EntityHierarchyContainer.EntityTransformData& Get(System.Int32 handle)
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityQueryBuilder
TYPE:  struct
TOKEN: 0x200001B
FIELDS:
  private           UnityEngine.HyperGryph.ECS.EntityQueryBuilder.BuilderData*builderDataPtr  // 0x10
METHODS:
  System.Void .ctor(System.Int32 maxCount)
  UnityEngine.HyperGryph.ECS.EntityQueryBuilder Create(System.Int32 maxCount)
  UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithAll()
  UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithAll()
  UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithAll()
  UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithAll()
  UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithAll()
  UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithAll()
  UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithAll()
  UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithNone()
  UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithNone()
  UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithNone()
  UnityEngine.HyperGryph.ECS.EntityQueryBuilder WithNone()
  UnityEngine.HyperGryph.ECS.EntityManagerRange Build(UnityEngine.HyperGryph.ECS.EntityManager& em)
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.EntityQueryV2
TYPE:  class
TOKEN: 0x200001E
FIELDS:
METHODS:
  UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, UnityEngine.HyperGryph.ECS.EntityQueryBuilder& builder, Unity.Collections.Allocator allocator, System.Int32 jobCount)
  UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& QueryDefer(UnityEngine.HyperGryph.ECS.EntityManager em, UnityEngine.HyperGryph.ECS.EntityQueryBuilder& builder, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& qrd, System.Int32 jobCount)
  UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount)
  UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount)
  UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount)
  UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount)
  UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount)
  UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount)
  UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount)
  UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount)
  UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult Query(UnityEngine.HyperGryph.ECS.EntityManager em, Unity.Collections.Allocator allocator, System.Int32 jobCount)
  UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer GetBlockRangesDefer(UnityEngine.HyperGryph.ECS.EntityManagerRange range, System.Int32 jobCount, UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResultDefer& qr)
  UnityEngine.HyperGryph.ECS.EntityQueryV2.QueryResult GetBlockRanges(UnityEngine.HyperGryph.ECS.EntityManagerRange range, Unity.Collections.Allocator allocator, System.Int32 jobCount)
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.Wrapper_000000D7$PostfixBurstDelegate
TYPE:  class
TOKEN: 0x2000023
EXTENDS: MulticastDelegate
FIELDS:
METHODS:
  System.Void .ctor(System.Object , System.IntPtr )
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManagerRange* range, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.GroupType>* groups, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange>* blockRange, System.Int32 workerCount)
  System.IAsyncResult BeginInvoke(UnityEngine.HyperGryph.ECS.EntityManagerRange* range, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.GroupType>* groups, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange>* blockRange, System.Int32 workerCount, System.AsyncCallback , System.Object )
  System.Void EndInvoke(System.IAsyncResult )
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.Wrapper_000000D7$BurstDirectCall
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
  System.Void Invoke(UnityEngine.HyperGryph.ECS.EntityManagerRange* range, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.GroupType>* groups, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange>* blockRange, System.Int32 workerCount)
END_CLASS

CLASS: UnityEngine.HyperGryph.ECS.QueryResultWrapper
TYPE:  class
TOKEN: 0x2000022
FIELDS:
METHODS:
  System.Void Wrapper(UnityEngine.HyperGryph.ECS.EntityManagerRange* range, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.GroupType>* groups, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange>* blockRange, System.Int32 workerCount)
  System.Void Wrapper$BurstManaged(UnityEngine.HyperGryph.ECS.EntityManagerRange* range, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.GroupType>* groups, Unity.Collections.LowLevel.Unsafe.UnsafeList<UnityEngine.HyperGryph.ECS.EntityQueryV2.BlockRange>* blockRange, System.Int32 workerCount)
END_CLASS

