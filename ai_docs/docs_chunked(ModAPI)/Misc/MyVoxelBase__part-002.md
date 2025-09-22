##### Property Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_StorageMin)StorageMin

##### Declaration

```
public Vector3I StorageMin { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_StorageName)StorageName

##### Declaration

```
public string StorageName { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_VoxelSize)VoxelSize

##### Declaration

```
public float VoxelSize { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### [](#methods)Methods

#### [](#Sandbox_Game_Entities_MyVoxelBase_add_RangeChanged_Sandbox_Game_Entities_MyVoxelBase_StorageChanged_)add\_RangeChanged(MyVoxelBase.StorageChanged)

##### Declaration

```
public void add_RangeChanged(MyVoxelBase.StorageChanged value)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyVoxelBase_AreAllAabbCornersInside_VRageMath_MatrixD__VRageMath_BoundingBoxD_)AreAllAabbCornersInside(ref MatrixD, BoundingBoxD)

##### Declaration

```
public bool AreAllAabbCornersInside(ref MatrixD aabbWorldTransform, BoundingBoxD aabb)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_BeforeDelete)BeforeDelete()

##### Declaration

```
protected override void BeforeDelete()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyVoxelBase_BroadcastShipCutout_Sandbox_Game_GameSystems_MyShipMiningSystem_NetworkCutoutData__)BroadcastShipCutout(in MyShipMiningSystem.NetworkCutoutData)

##### Declaration

```
public void BroadcastShipCutout(in MyShipMiningSystem.NetworkCutoutData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.GameSystems.MyShipMiningSystem.NetworkCutoutData | data |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_CountPointsInside_VRageMath_Vector3D__System_Int32_System_Boolean_)CountPointsInside(Vector3D\*, Int32, Boolean)

##### Declaration

```
public int CountPointsInside(Vector3D*worldPoints, int pointCount, bool stopWhenFound = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\* | worldPoints |     |
| System.Int32 | pointCount |     |
| System.Boolean | stopWhenFound |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_CreateVoxelMeteorCrater_VRageMath_Vector3D_System_Single_VRageMath_Vector3_VRage_Game_MyVoxelMaterialDefinition_)CreateVoxelMeteorCrater(Vector3D, Single, Vector3, MyVoxelMaterialDefinition)

##### Declaration

```
public void CreateVoxelMeteorCrater(Vector3D center, float radius, Vector3 direction, MyVoxelMaterialDefinition material)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyVoxelBase_CutOutShapeWithProperties_Sandbox_Engine_Voxels_MyShape_System_Single__VRage_Game_MyVoxelMaterialDefinition__System_Collections_Generic_Dictionary_VRage_Game_MyVoxelMaterialDefinition_System_Int32__System_Boolean_System_Boolean_System_Boolean_System_Boolean_)CutOutShapeWithProperties(MyShape, out Single, out MyVoxelMaterialDefinition, Dictionary<MyVoxelMaterialDefinition, Int32>, Boolean, Boolean, Boolean, Boolean)

##### Declaration

```
public void CutOutShapeWithProperties(MyShape shape, out float voxelsCountInPercent, out MyVoxelMaterialDefinition voxelMaterial, Dictionary<MyVoxelMaterialDefinition, int> exactCutOutMaterials = null, bool updateSync = false, bool onlyCheck = false, bool applyDamageMaterial = false, bool onlyApplyMaterial = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Engine.Voxels.MyShape | shape |     |
| System.Single | voxelsCountInPercent |     |
| [MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html) | voxelMaterial |     |
| System.Collections.Generic.Dictionary<[MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html), System.Int32\> | exactCutOutMaterials |     |
| System.Boolean | updateSync |     |
| System.Boolean | onlyCheck |     |
| System.Boolean | applyDamageMaterial |     |
| System.Boolean | onlyApplyMaterial |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_CutOutShapeWithPropertiesAsync_Sandbox_Game_Entities_MyVoxelBase_OnCutOutResults_Sandbox_Engine_Voxels_MyShape_System_Boolean_System_Boolean_System_Boolean_System_Boolean_System_Boolean_)CutOutShapeWithPropertiesAsync(MyVoxelBase.OnCutOutResults, MyShape, Boolean, Boolean, Boolean, Boolean, Boolean)

##### Declaration

```
public void CutOutShapeWithPropertiesAsync(MyVoxelBase.OnCutOutResults results, MyShape shape, bool updateSync = false, bool onlyCheck = false, bool applyDamageMaterial = false, bool onlyApplyMaterial = false, bool skipCache = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyVoxelBase.OnCutOutResults](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.OnCutOutResults.html) | results |     |
| Sandbox.Engine.Voxels.MyShape | shape |     |
| System.Boolean | updateSync |     |
| System.Boolean | onlyCheck |     |
| System.Boolean | applyDamageMaterial |     |
| System.Boolean | onlyApplyMaterial |     |
| System.Boolean | skipCache |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_DoOverlapSphereTest_System_Single_VRageMath_Vector3D_)DoOverlapSphereTest(Single, Vector3D)

##### Declaration

```
public override bool DoOverlapSphereTest(float sphereRadius, Vector3D spherePos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | sphereRadius |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | spherePos |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |
