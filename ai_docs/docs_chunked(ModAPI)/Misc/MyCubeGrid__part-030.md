Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

cube

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

fractionalGridPosition

#### IMyCubeGrid.GasSystem

Can be null if oxygen is disabled

##### Declaration

```
IMyGridGasSystem IMyCubeGrid.GasSystem { get; }
```

##### Returns

Type

Description

[IMyGridGasSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGasSystem.html)

#### IMyCubeGrid.GetBlocks(List<IMySlimBlock>, Func<IMySlimBlock, Boolean>)

##### Declaration

```
void IMyCubeGrid.GetBlocks(List<IMySlimBlock> blocks, Func<IMySlimBlock, bool> collect)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)\>

blocks

System.Func<[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html), System.Boolean\>

collect

#### IMyCubeGrid.GetBlocksInsideSphere(ref BoundingSphereD)

##### Declaration

```
List<IMySlimBlock> IMyCubeGrid.GetBlocksInsideSphere(ref BoundingSphereD sphere)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

##### Returns

Type

Description

System.Collections.Generic.List<[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)\>

#### IMyCubeGrid.GetClosestCorner(Vector3I, Vector3)

##### Declaration

```
Vector3 IMyCubeGrid.GetClosestCorner(Vector3I gridPos, Vector3 position)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridPos

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### IMyCubeGrid.GetCubeBlock(Vector3I)

##### Declaration

```
IMySlimBlock IMyCubeGrid.GetCubeBlock(Vector3I pos)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

pos

##### Returns

Type

Description

[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)

#### IMyCubeGrid.GetFatBlocks<T>()

##### Declaration

```
IEnumerable<T> IMyCubeGrid.GetFatBlocks<T>()
    where T : class, IMyCubeBlock
```

##### Returns

Type

Description

System.Collections.Generic.IEnumerable<T>

##### Type Parameters

Name

Description

T

#### IMyCubeGrid.GetLineIntersectionExactAll(ref LineD, out Double, out IMySlimBlock)

##### Declaration

```
Nullable<Vector3D> IMyCubeGrid.GetLineIntersectionExactAll(ref LineD line, out double distance, out IMySlimBlock intersectedBlock)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

System.Double

distance

[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)

intersectedBlock

##### Returns

Type

Description

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

#### IMyCubeGrid.GetLineIntersectionExactGrid(ref LineD, ref Vector3I, ref Double)

##### Declaration

```
bool IMyCubeGrid.GetLineIntersectionExactGrid(ref LineD line, ref Vector3I position, ref double distanceSquared)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

System.Double

distanceSquared

##### Returns

Type

Description

System.Boolean

#### IMyCubeGrid.GridPresenceTier

##### Declaration

```
MyUpdateTiersGridPresence IMyCubeGrid.GridPresenceTier { get; }
```

##### Returns

Type

Description

[MyUpdateTiersGridPresence](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyUpdateTiersGridPresence.html)

#### IMyCubeGrid.GridPresenceTierChanged

##### Declaration

```
event Action<IMyCubeGrid> IMyCubeGrid.GridPresenceTierChanged
```

##### Returns

Type

Description

System.Action<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\>

#### IMyCubeGrid.IsRespawnGrid

##### Declaration

```
bool IMyCubeGrid.IsRespawnGrid { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyCubeGrid.IsStatic

##### Declaration

```
bool IMyCubeGrid.IsStatic { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyCubeGrid.IsTouchingAnyNeighbor(Vector3I, Vector3I)

##### Declaration

```
bool IMyCubeGrid.IsTouchingAnyNeighbor(Vector3I min, Vector3I max)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

##### Returns

Type

Description

System.Boolean

#### IMyCubeGrid.JumpSystem

##### Declaration

```
IMyGridJumpDriveSystem IMyCubeGrid.JumpSystem { get; }
```

##### Returns

Type

Description

[IMyGridJumpDriveSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridJumpDriveSystem.html)

#### IMyCubeGrid.MergeGrid\_MergeBlock(IMyCubeGrid, Vector3I)

##### Declaration

```
IMyCubeGrid IMyCubeGrid.MergeGrid_MergeBlock(IMyCubeGrid gridToMerge, Vector3I gridOffset)
```

##### Parameters

Type

Name

Description

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)

gridToMerge

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridOffset
