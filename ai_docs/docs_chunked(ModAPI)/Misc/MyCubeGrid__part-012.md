position

System.Nullable<System.UInt16\>

compoundId

#### ExportObject(MyCubeGrid, Boolean, Boolean)

##### Declaration

```
public static void ExportObject(MyCubeGrid baseGrid, bool convertModelsFromSBC, bool exportObjAndSBC = false)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

baseGrid

System.Boolean

convertModelsFromSBC

System.Boolean

exportObjAndSBC

#### FindBlocksBuiltByID(Int64)

Find all blocks built by a specific player..

##### Declaration

```
public HashSet<MySlimBlock> FindBlocksBuiltByID(long identityID)
```

##### Parameters

Type

Name

Description

System.Int64

identityID

##### Returns

Type

Description

System.Collections.Generic.HashSet<Sandbox.Game.Entities.Cube.MySlimBlock\>

#### FindBlocksBuiltByID(Int64, HashSet<MySlimBlock>)

##### Declaration

```
public HashSet<MySlimBlock> FindBlocksBuiltByID(long identityID, HashSet<MySlimBlock> builtBlocks)
```

##### Parameters

Type

Name

Description

System.Int64

identityID

System.Collections.Generic.HashSet<Sandbox.Game.Entities.Cube.MySlimBlock\>

builtBlocks

##### Returns

Type

Description

System.Collections.Generic.HashSet<Sandbox.Game.Entities.Cube.MySlimBlock\>

#### FixSkeleton(MySlimBlock, Boolean)

##### Declaration

```
public void FixSkeleton(MySlimBlock cubeBlock, bool simplePhysicsUpdateOnly = false)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

cubeBlock

System.Boolean

simplePhysicsUpdateOnly

#### FixTargetCube(out Vector3I, Vector3)

Iterate over all the neighbors of the cube and return when one of them exists.

##### Declaration

```
public void FixTargetCube(out Vector3I cube, Vector3 fractionalGridPosition)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

cube

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

fractionalGridPosition

#### FixTargetCubeLite(out Vector3I, Vector3D)

##### Declaration

```
public void FixTargetCubeLite(out Vector3I cube, Vector3D fractionalGridPosition)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

cube

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

fractionalGridPosition

#### GetArmorSkinItem(MyStringHash)

##### Declaration

```
public static MyGameInventoryItem GetArmorSkinItem(MyStringHash skinId)
```

##### Parameters

Type

Name

Description

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

skinId

##### Returns

Type

Description

VRage.GameServices.MyGameInventoryItem

#### GetBiggestGridInGroup()

Returns biggest grid in physical group by AABB volume

##### Declaration

```
public MyCubeGrid GetBiggestGridInGroup()
```

##### Returns

Type

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

#### GetBlocks()

##### Declaration

```
public HashSet<MySlimBlock> GetBlocks()
```

##### Returns

Type

Description

System.Collections.Generic.HashSet<Sandbox.Game.Entities.Cube.MySlimBlock\>

#### GetBlocksForTool(ref BoundingSphereD, HashSet<MySlimBlock>)

##### Declaration

```
public void GetBlocksForTool(ref BoundingSphereD sphere, HashSet<MySlimBlock> blocks)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

System.Collections.Generic.HashSet<Sandbox.Game.Entities.Cube.MySlimBlock\>

blocks

#### GetBlocksInsideSphere(ref BoundingSphereD, HashSet<MySlimBlock>, Boolean)

##### Declaration

```
public void GetBlocksInsideSphere(ref BoundingSphereD sphere, HashSet<MySlimBlock> blocks, bool checkTriangles = false)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

System.Collections.Generic.HashSet<Sandbox.Game.Entities.Cube.MySlimBlock\>

blocks

System.Boolean

checkTriangles

#### GetBlocksInsideSphereInternal(ref BoundingSphereD, HashSet<MySlimBlock>, MyCubeGrid.GridQueryAccuracy, Boolean, HashSet<Vector3I>)

##### Declaration

```
public void GetBlocksInsideSphereInternal(ref BoundingSphereD sphere, HashSet<MySlimBlock> blocks, MyCubeGrid.GridQueryAccuracy queryAccuracy, bool useOptimization = true, HashSet<Vector3I> visitedPositions = null)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

System.Collections.Generic.HashSet<Sandbox.Game.Entities.Cube.MySlimBlock\>

blocks

[MyCubeGrid.GridQueryAccuracy](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.GridQueryAccuracy.html)

queryAccuracy

System.Boolean

useOptimization

System.Collections.Generic.HashSet<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

visitedPositions

#### GetBlocksInsideSpheres(ref BoundingSphereD, ref BoundingSphereD, ref BoundingSphereD, HashSet<MySlimBlock>, HashSet<MySlimBlock>, HashSet<MySlimBlock>, Boolean, Single, ref MatrixD)

Optimized version where spheres are sorted from smallest to largest

##### Declaration

```
public void GetBlocksInsideSpheres(ref BoundingSphereD sphere1, ref BoundingSphereD sphere2, ref BoundingSphereD sphere3, HashSet<MySlimBlock> blocks1, HashSet<MySlimBlock> blocks2, HashSet<MySlimBlock> blocks3, bool respectDeformationRatio, float detectionBlockHalfSize, ref MatrixD invWorldGrid)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere1

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere2

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere3

System.Collections.Generic.HashSet<Sandbox.Game.Entities.Cube.MySlimBlock\>

blocks1

System.Collections.Generic.HashSet<Sandbox.Game.Entities.Cube.MySlimBlock\>

blocks2

System.Collections.Generic.HashSet<Sandbox.Game.Entities.Cube.MySlimBlock\>

blocks3

System.Boolean

respectDeformationRatio

System.Single

detectionBlockHalfSize

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

invWorldGrid
