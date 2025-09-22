gridSize

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

gridSizeInflate

System.Boolean

havokWorld

#### RazeBlock(Vector3I, UInt64)

user is used only if called on server, when called from client, sender steam id will be used

##### Declaration

```
public void RazeBlock(Vector3I position, ulong user = 0UL)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

System.UInt64

user

#### RazeBlocks(List<Vector3I>, Int64, UInt64)

Razes blocks (unbuild) user is used only if locally invoked, if invoked from client, sender steam id is used

##### Declaration

```
public void RazeBlocks(List<Vector3I> locations, long builderEntityId = 0L, ulong user = 0UL)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

locations

System.Int64

builderEntityId

System.UInt64

user

#### RazeBlocks(ref Vector3I, ref Vector3UByte, Int64)

##### Declaration

```
public void RazeBlocks(ref Vector3I pos, ref Vector3UByte size, long builderEntityId = 0L)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

pos

[Vector3UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html)

size

System.Int64

builderEntityId

#### RazeBlocksClient(List<Vector3I>)

##### Declaration

```
[Event(null, 4513)]
[Reliable]
[Broadcast]
public void RazeBlocksClient(List<Vector3I> locations)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

locations

#### RazeBlocksDelayed(ref Vector3I, ref Vector3UByte, Int64)

##### Declaration

```
public void RazeBlocksDelayed(ref Vector3I pos, ref Vector3UByte size, long builderEntityId)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

pos

[Vector3UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html)

size

System.Int64

builderEntityId

#### RazeBlocksRequest(List<Vector3I>, Int64, UInt64)

user is used only if locally invoked, if invoked from client, sender steam id is used

##### Declaration

```
[Event(null, 4481)]
[Reliable]
[Server]
public void RazeBlocksRequest(List<Vector3I> locations, long builderEntityId = 0L, ulong user = 0UL)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

locations

System.Int64

builderEntityId

System.UInt64

user

#### RazeGeneratedBlocks(List<MySlimBlock>)

##### Declaration

```
public void RazeGeneratedBlocks(List<MySlimBlock> generatedBlocks)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<Sandbox.Game.Entities.Cube.MySlimBlock\>

generatedBlocks

#### RazeGeneratedBlocks(List<Vector3I>)

##### Declaration

```
public void RazeGeneratedBlocks(List<Vector3I> locations)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

locations

#### RecalculateGravity()

##### Declaration

```
public void RecalculateGravity()
```

#### RecalculateOwners()

##### Declaration

```
public void RecalculateOwners()
```

#### ReceiveHandbrakeRequestResult(MyCubeGrid.HandbrakeToggleResult, String)

##### Declaration

```
[Event(null, 10143)]
[Reliable]
[Client]
public void ReceiveHandbrakeRequestResult(MyCubeGrid.HandbrakeToggleResult result, string message)
```

##### Parameters

Type

Name

Description

[MyCubeGrid.HandbrakeToggleResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.HandbrakeToggleResult.html)

result

System.String

message

#### ReceiveParkRequestResult(MyCubeGrid.HandbrakeToggleResult, String)

##### Declaration

```
[Event(null, 10197)]
[Reliable]
[Client]
public void ReceiveParkRequestResult(MyCubeGrid.HandbrakeToggleResult result, string message)
```

##### Parameters

Type

Name

Description

[MyCubeGrid.HandbrakeToggleResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.HandbrakeToggleResult.html)

result

System.String

message

#### RegisterDecoy(MyDecoy)

##### Declaration

```
public void RegisterDecoy(MyDecoy block)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Blocks.MyDecoy

block

#### RegisterInventory(MyCubeBlock)

##### Declaration

```
public void RegisterInventory(MyCubeBlock block)
```

##### Parameters

Type

Name

Description

[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)

block

#### RegisterOccupiedBlock(MyCockpit)

##### Declaration

```
public void RegisterOccupiedBlock(MyCockpit block)
```

##### Parameters

Type

Name

Description

[MyCockpit](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCockpit.html)

block

#### RegisterUnsafeBlock(MyCubeBlock)

##### Declaration

```
public void RegisterUnsafeBlock(MyCubeBlock block)
```

##### Parameters

Type

Name

Description

[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)

block

#### RemoveBlock(MySlimBlock, Boolean)

##### Declaration

```
public void RemoveBlock(MySlimBlock block, bool updatePhysics = false)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

System.Boolean

updatePhysics

#### RemoveBlocksBuiltByIDs(List<Int64>)

Remove all blocks from the grid built by specific player
