Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

System.Boolean

handWelded

#### OnLogHierarchy()

##### Declaration

```
[Event(null, 11335)]
[Reliable]
[Server]
public void OnLogHierarchy()
```

#### OnRemovedFromScene(Object)

##### Declaration

```
public override void OnRemovedFromScene(object source)
```

##### Parameters

Type

Name

Description

System.Object

source

##### Overrides

#### OnReplicationEnded()

##### Declaration

```
public override void OnReplicationEnded()
```

##### Overrides

#### OnReplicationStarted()

##### Declaration

```
public override void OnReplicationStarted()
```

##### Overrides

#### OnTerminalOpened()

##### Declaration

```
public void OnTerminalOpened()
```

#### PackFiles(String, String)

##### Declaration

```
public static void PackFiles(string path, string objectName)
```

##### Parameters

Type

Name

Description

System.String

path

System.String

objectName

#### PasteBlocksToGrid(List<MyObjectBuilder\_CubeGrid>, Int64, Boolean, List<UInt64>)

##### Declaration

```
public void PasteBlocksToGrid(List<MyObjectBuilder_CubeGrid> gridsToMerge, long inventoryEntityId, bool instantBuild, [Nullable] List<ulong> clientDLCIDs = null)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[MyObjectBuilder\_CubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeGrid.html)\>

gridsToMerge

System.Int64

inventoryEntityId

System.Boolean

instantBuild

System.Collections.Generic.List<System.UInt64\>

clientDLCIDs

#### PlacePrefabsToWorld()

##### Declaration

```
public static void PlacePrefabsToWorld()
```

#### PlacePrefabToWorld(MyObjectBuilder\_CubeGrid\[\], Vector3D, List<MyCubeGrid>)

##### Declaration

```
public static void PlacePrefabToWorld(MyObjectBuilder_CubeGrid[] currentPrefab, Vector3D position, List<MyCubeGrid> createdGrids = null)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_CubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeGrid.html)\[\]

currentPrefab

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.Collections.Generic.List<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

createdGrids

#### Players\_PlayerRemoved(MyPlayer.PlayerId)

##### Declaration

```
public static void Players_PlayerRemoved(MyPlayer.PlayerId obj)
```

##### Parameters

Type

Name

Description

Sandbox.Game.World.MyPlayer.PlayerId

obj

#### PlayParticleBroadcast(String, Boolean)

##### Declaration

```
[Event(null, 11517)]
[Reliable]
[ServerInvoked]
[Broadcast]
public void PlayParticleBroadcast(string particleName, bool smoke)
```

##### Parameters

Type

Name

Description

System.String

particleName

System.Boolean

smoke

#### Preload()

##### Declaration

```
public static void Preload()
```

#### PrepareForDraw()

##### Declaration

```
public override void PrepareForDraw()
```

##### Overrides

#### RaiseGridChanged()

##### Declaration

```
public void RaiseGridChanged()
```

#### RaisePhysicsChanged()

##### Declaration

```
public void RaisePhysicsChanged()
```

#### RayCastBlocks(Vector3D, Vector3D)

Obtains position of first hit block.

##### Declaration

```
public Nullable<Vector3I> RayCastBlocks(Vector3D worldStart, Vector3D worldEnd)
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

#### RayCastCells(Vector3D, Vector3D, List<Vector3I>, Nullable<Vector3I>, Boolean, Boolean)

Obtains positions of grid cells regardless of whether these cells are taken up by blocks or not.

##### Declaration

```
public void RayCastCells(Vector3D worldStart, Vector3D worldEnd, List<Vector3I> outHitPositions, Nullable<Vector3I> gridSizeInflate = null, bool havokWorld = false, bool clearOutHitPositions = true)
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

System.Boolean

clearOutHitPositions

#### RayCastStaticCells(Vector3D, Vector3D, List<Vector3I>, Single, Nullable<Vector3I>, Boolean)

Obtains positions of static grid cells regardless of whether these cells are taken up by blocks or not. Usefull when placing block on voxel.

##### Declaration

```
public static void RayCastStaticCells(Vector3D worldStart, Vector3D worldEnd, List<Vector3I> outHitPositions, float gridSize, Nullable<Vector3I> gridSizeInflate = null, bool havokWorld = false)
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

System.Single

gridSize

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

gridSizeInflate

System.Boolean

havokWorld

#### RazeBlock(Vector3I, UInt64)

user is used only if called on server, when called from client, sender steam id will be used
