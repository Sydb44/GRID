```
public static bool SpectatorIsBuilding { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Activate(Nullable<MyDefinitionId>, Boolean)

##### Declaration

```
public abstract void Activate(Nullable<MyDefinitionId> blockDefinitionId = null, bool groupwideDLCCheck = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> | blockDefinitionId |     |
| System.Boolean | groupwideDLCCheck |     |

#### AddFastBuildModelWithSubparts(ref MatrixD, List<MatrixD>, List<String>, MyCubeBlockDefinition, Single)

##### Declaration

```
protected static void AddFastBuildModelWithSubparts(ref MatrixD matrix, List<MatrixD> matrices, List<string> models, MyCubeBlockDefinition blockDefinition, float gridScale)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix |     |
| System.Collections.Generic.List<[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)\> | matrices |     |
| System.Collections.Generic.List<System.String\> | models |     |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) | blockDefinition |     |
| System.Single | gridScale |     |

#### ChooseHitObject()

##### Declaration

```
protected virtual void ChooseHitObject()
```

#### ComputeSteps(Vector3I, Vector3I, Vector3I, out Vector3I, out Vector3I, out Int32)

##### Declaration

```
public static void ComputeSteps(Vector3I start, Vector3I end, Vector3I rotatedSize, out Vector3I stepDelta, out Vector3I counter, out int stepCount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | start |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | end |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | rotatedSize |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | stepDelta |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | counter |     |
| System.Int32 | stepCount |     |

#### Deactivate()

##### Declaration

```
public abstract void Deactivate()
```

#### FindClosestGrid()

##### Declaration

```
public MyCubeGrid FindClosestGrid()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) |     |

#### FindClosestPlacementObject(out MyCubeGrid, out MyVoxelBase)

Finds closest object (grid or voxel map) for placement of blocks .

##### Declaration

```
public bool FindClosestPlacementObject(out MyCubeGrid closestGrid, out MyVoxelBase closestVoxelMap)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | closestGrid |     |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) | closestVoxelMap |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetBlockAddPosition(Single, Boolean, out MySlimBlock, out Vector3D, out Vector3D, out Vector3I, out Vector3I, out Nullable<UInt16>)

##### Declaration

```
protected bool GetBlockAddPosition(float gridSize, bool placingSmallGridOnLargeStatic, out MySlimBlock intersectedBlock, out Vector3D intersectedBlockPos, out Vector3D intersectExactPos, out Vector3I addPositionBlock, out Vector3I addDirectionBlock, out Nullable<ushort> compoundBlockId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | gridSize |     |
| System.Boolean | placingSmallGridOnLargeStatic |     |
| Sandbox.Game.Entities.Cube.MySlimBlock | intersectedBlock |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | intersectedBlockPos |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | intersectExactPos |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | addPositionBlock |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | addDirectionBlock |     |
| System.Nullable<System.UInt16\> | compoundBlockId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetCubeAddAndRemovePositions(Vector3I, Boolean, out Vector3I, out Vector3I, out Vector3I)

##### Declaration

```
protected bool GetCubeAddAndRemovePositions(Vector3I intersectedCube, bool placingSmallGridOnLargeStatic, out Vector3I addPos, out Vector3I addDir, out Vector3I removePos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | intersectedCube |     |
| System.Boolean | placingSmallGridOnLargeStatic |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | addPos |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | addDir |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | removePos |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetCubeBoundingBox(Vector3I)

##### Declaration

```
protected BoundingBoxD GetCubeBoundingBox(Vector3I cubePos)
```
