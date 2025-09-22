Type

Name

Description

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)

gridToMerge

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridOffset

##### Returns

Type

Description

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)

#### IMyCubeGrid.OnBlockAdded

##### Declaration

```
event Action<IMySlimBlock> IMyCubeGrid.OnBlockAdded
```

##### Returns

Type

Description

System.Action<[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)\>

#### IMyCubeGrid.OnBlockIntegrityChanged

##### Declaration

```
event Action<IMySlimBlock> IMyCubeGrid.OnBlockIntegrityChanged
```

##### Returns

Type

Description

System.Action<[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)\>

#### IMyCubeGrid.OnBlockOwnershipChanged

##### Declaration

```
event Action<IMyCubeGrid> IMyCubeGrid.OnBlockOwnershipChanged
```

##### Returns

Type

Description

System.Action<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\>

#### IMyCubeGrid.OnBlockRemoved

##### Declaration

```
event Action<IMySlimBlock> IMyCubeGrid.OnBlockRemoved
```

##### Returns

Type

Description

System.Action<[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)\>

#### IMyCubeGrid.OnGridChanged

##### Declaration

```
event Action<IMyCubeGrid> IMyCubeGrid.OnGridChanged
```

##### Returns

Type

Description

System.Action<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\>

#### IMyCubeGrid.OnGridMerge

Called, when 2 grids are merged with merge block. First grid - grid that will stay, second - will be merged into first, and deleted. Called for both grids

##### Declaration

```
event Action<IMyCubeGrid, IMyCubeGrid> IMyCubeGrid.OnGridMerge
```

##### Returns

Type

Description

System.Action<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html), [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\>

#### IMyCubeGrid.OnGridSplit

##### Declaration

```
event Action<IMyCubeGrid, IMyCubeGrid> IMyCubeGrid.OnGridSplit
```

##### Returns

Type

Description

System.Action<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html), [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\>

#### IMyCubeGrid.OnIsStaticChanged

##### Declaration

```
event Action<IMyCubeGrid, bool> IMyCubeGrid.OnIsStaticChanged
```

##### Returns

Type

Description

System.Action<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html), System.Boolean\>

#### IMyCubeGrid.OnMaxThrustChanged

##### Declaration

```
event Action<IMyCubeGrid> IMyCubeGrid.OnMaxThrustChanged
```

##### Returns

Type

Description

System.Action<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\>

#### IMyCubeGrid.PlayerPresenceTier

##### Declaration

```
MyUpdateTiersPlayerPresence IMyCubeGrid.PlayerPresenceTier { get; }
```

##### Returns

Type

Description

[MyUpdateTiersPlayerPresence](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyUpdateTiersPlayerPresence.html)

#### IMyCubeGrid.PlayerPresenceTierChanged

##### Declaration

```
event Action<IMyCubeGrid> IMyCubeGrid.PlayerPresenceTierChanged
```

##### Returns

Type

Description

System.Action<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\>

#### IMyCubeGrid.RayCastBlocks(Vector3D, Vector3D)

##### Declaration

```
Nullable<Vector3I> IMyCubeGrid.RayCastBlocks(Vector3D worldStart, Vector3D worldEnd)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

worldStart

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

worldEnd

##### Returns

Type

Description

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

#### IMyCubeGrid.RayCastCells(Vector3D, Vector3D, List<Vector3I>, Nullable<Vector3I>, Boolean)

##### Declaration

```
void IMyCubeGrid.RayCastCells(Vector3D worldStart, Vector3D worldEnd, List<Vector3I> outHitPositions, Nullable<Vector3I> gridSizeInflate, bool havokWorld)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

worldStart

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

worldEnd

System.Collections.Generic.List<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

outHitPositions

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

gridSizeInflate

System.Boolean

havokWorld

#### IMyCubeGrid.RazeBlock(Vector3I)

##### Declaration

```
void IMyCubeGrid.RazeBlock(Vector3I position)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

#### IMyCubeGrid.RazeBlocks(List<Vector3I>)

##### Declaration

```
void IMyCubeGrid.RazeBlocks(List<Vector3I> locations)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

locations

#### IMyCubeGrid.RazeBlocks(ref Vector3I, ref Vector3UByte)
