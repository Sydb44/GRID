##### Parameters

Type

Name

Description

System.Collections.Generic.List<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

locations

#### IMyCubeGrid.RazeBlocks(ref Vector3I, ref Vector3UByte)

##### Declaration

```
void IMyCubeGrid.RazeBlocks(ref Vector3I pos, ref Vector3UByte size)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

pos

[Vector3UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html)

size

#### IMyCubeGrid.RemoveBlock(IMySlimBlock, Boolean)

##### Declaration

```
void IMyCubeGrid.RemoveBlock(IMySlimBlock block, bool updatePhysics)
```

##### Parameters

Type

Name

Description

[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)

block

System.Boolean

updatePhysics

#### IMyCubeGrid.RemoveDestroyedBlock(IMySlimBlock)

##### Declaration

```
void IMyCubeGrid.RemoveDestroyedBlock(IMySlimBlock block)
```

##### Parameters

Type

Name

Description

[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)

block

#### IMyCubeGrid.ResourceDistributor

##### Declaration

```
IMyResourceDistributorComponent IMyCubeGrid.ResourceDistributor { get; }
```

##### Returns

Type

Description

[IMyResourceDistributorComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyResourceDistributorComponent.html)

#### IMyCubeGrid.SkinBlocks(Vector3I, Vector3I, Nullable<Vector3>, String)

##### Declaration

```
void IMyCubeGrid.SkinBlocks(Vector3I min, Vector3I max, Nullable<Vector3> newHSV, string newSkin)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

newHSV

System.String

newSkin

#### IMyCubeGrid.SmallOwners

##### Declaration

```
List<long> IMyCubeGrid.SmallOwners { get; }
```

##### Returns

Type

Description

System.Collections.Generic.List<System.Int64\>

#### IMyCubeGrid.Split(List<IMySlimBlock>, Boolean)

##### Declaration

```
IMyCubeGrid IMyCubeGrid.Split(List<IMySlimBlock> blocks, bool sync)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)\>

blocks

System.Boolean

sync

##### Returns

Type

Description

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)

#### IMyCubeGrid.SplitByPlane(PlaneD)

##### Declaration

```
IMyCubeGrid IMyCubeGrid.SplitByPlane(PlaneD plane)
```

##### Parameters

Type

Name

Description

[PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html)

plane

##### Returns

Type

Description

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)

#### IMyCubeGrid.UpdateBlockNeighbours(IMySlimBlock)

##### Declaration

```
void IMyCubeGrid.UpdateBlockNeighbours(IMySlimBlock block)
```

##### Parameters

Type

Name

Description

[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)

block

#### IMyCubeGrid.WeaponSystem

##### Declaration

```
IMyGridWeaponSystem IMyCubeGrid.WeaponSystem { get; }
```

##### Returns

Type

Description

[IMyGridWeaponSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridWeaponSystem.html)

#### IMyCubeGrid.WillRemoveBlockSplitGrid(IMySlimBlock)

##### Declaration

```
bool IMyCubeGrid.WillRemoveBlockSplitGrid(IMySlimBlock testBlock)
```

##### Parameters

Type

Name

Description

[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)

testBlock

##### Returns

Type

Description

System.Boolean

#### IMyCubeGrid.XSymmetryOdd

##### Declaration

```
bool IMyCubeGrid.XSymmetryOdd { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyCubeGrid.XSymmetryPlane

##### Declaration

```
Nullable<Vector3I> IMyCubeGrid.XSymmetryPlane { get; set; }
```

##### Returns

Type

Description

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

#### IMyCubeGrid.YSymmetryOdd

##### Declaration

```
bool IMyCubeGrid.YSymmetryOdd { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyCubeGrid.YSymmetryPlane

##### Declaration

```
Nullable<Vector3I> IMyCubeGrid.YSymmetryPlane { get; set; }
```

##### Returns

Type

Description

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

#### IMyCubeGrid.ZSymmetryOdd

##### Declaration

```
bool IMyCubeGrid.ZSymmetryOdd { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyCubeGrid.ZSymmetryPlane

##### Declaration

```
Nullable<Vector3I> IMyCubeGrid.ZSymmetryPlane { get; set; }
```

##### Returns

Type

Description

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

#### IMyCubeGrid.CustomName

##### Declaration

```
string IMyCubeGrid.CustomName { get; set; }
```

##### Returns

Type

Description

System.String

#### IMyCubeGrid.GetCubeBlock(Vector3I)

##### Declaration

```
IMySlimBlock IMyCubeGrid.GetCubeBlock(Vector3I position)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

##### Returns

Type

Description

[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMySlimBlock.html)
