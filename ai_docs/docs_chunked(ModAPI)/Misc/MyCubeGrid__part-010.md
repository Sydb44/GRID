neighborDefinition

[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\[\]

neighborMountPoints

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

neighborOrientation

System.Collections.Generic.List<[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\>

otherMountPoints

##### Returns

Type

Description

System.Boolean

#### CheckPredictionFlagScheduling()

##### Declaration

```
public void CheckPredictionFlagScheduling()
```

#### ClearSymmetries()

##### Declaration

```
public void ClearSymmetries()
```

#### ClientPredictionStaticCheck()

##### Declaration

```
public void ClientPredictionStaticCheck()
```

#### ColorBlocks(Vector3I, Vector3I, Vector3, Boolean)

Color block in area. Verry slow.

##### Declaration

```
public void ColorBlocks(Vector3I min, Vector3I max, Vector3 newHSV, bool playSound)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

newHSV

System.Boolean

playSound

#### ColorGrid(Vector3, Boolean)

##### Declaration

```
public void ColorGrid(Vector3 newHSV, bool playSound)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

newHSV

System.Boolean

playSound

#### ColorGridOrBlockRequestValidation()

##### Declaration

```
public bool ColorGridOrBlockRequestValidation()
```

##### Returns

Type

Description

System.Boolean

#### CompetetiveContainerOpened(Int64, Int32, Color)

##### Declaration

```
[Event(null, 11589)]
[Reliable]
[Server]
public void CompetetiveContainerOpened(long entityId, int time, Color color)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

System.Int32

time

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

color

#### Components\_ComponentAdded(Type, IMyEntityComponentBase)

##### Declaration

```
protected override void Components_ComponentAdded(Type t, IMyEntityComponentBase c)
```

##### Parameters

Type

Name

Description

System.Type

t

VRage.Game.Components.Interfaces.IMyEntityComponentBase

c

##### Overrides

#### Components\_ComponentRemoved(Type, IMyEntityComponentBase)

##### Declaration

```
protected override void Components_ComponentRemoved(Type t, IMyEntityComponentBase c)
```

##### Parameters

Type

Name

Description

System.Type

t

VRage.Game.Components.Interfaces.IMyEntityComponentBase

c

##### Overrides

#### ContainerOpened(Int64)

##### Declaration

```
[Event(null, 11581)]
[Reliable]
[Server]
public void ContainerOpened(long entityId)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

#### ConvertPrefabsToObjs()

##### Declaration

```
public static void ConvertPrefabsToObjs()
```

#### ConvertToStatic()

Conversion to Unsupported station. For generic conversion to static use physics component. Sets up the Unsupported station state.

##### Declaration

```
[Event(null, 5487)]
[Reliable]
[ServerInvoked]
[Broadcast]
public void ConvertToStatic()
```

#### CreateGridGroupLink(GridLinkTypeEnum, Int64, MyCubeGrid, MyCubeGrid)

##### Declaration

```
public static void CreateGridGroupLink(GridLinkTypeEnum type, long linkId, MyCubeGrid parent, MyCubeGrid child)
```

##### Parameters

Type

Name

Description

[GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html)

type

System.Int64

linkId

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

parent

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

child

#### CreateSplit(MyCubeGrid, List<MySlimBlock>, Boolean, Int64)

##### Declaration

```
public static MyCubeGrid CreateSplit(MyCubeGrid originalGrid, List<MySlimBlock> blocks, bool sync = true, long newEntityId = 0L)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

originalGrid

System.Collections.Generic.List<Sandbox.Game.Entities.Cube.MySlimBlock\>

blocks

System.Boolean

sync

System.Int64

newEntityId

##### Returns

Type

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

#### CreateSplit\_Implementation(List<Vector3I>, Int64)

##### Declaration

```
[Event(null, 1668)]
[Reliable]
[Broadcast]
public void CreateSplit_Implementation(List<Vector3I> blocks, long newEntityId)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

blocks

System.Int64

newEntityId

#### CreateSplits(MyCubeGrid, List<MySlimBlock>, List<MyDisconnectHelper.Group>, MyCubeGrid.MyTestDisconnectsReason, Boolean)

SplitBlocks list can contain null when received from network

##### Declaration

```
public static void CreateSplits(MyCubeGrid originalGrid, List<MySlimBlock> splitBlocks, List<MyDisconnectHelper.Group> groups, MyCubeGrid.MyTestDisconnectsReason reason, bool sync = true)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

originalGrid

System.Collections.Generic.List<Sandbox.Game.Entities.Cube.MySlimBlock\>

splitBlocks

System.Collections.Generic.List<Sandbox.Game.Entities.Cube.MyDisconnectHelper.Group\>

groups

[MyCubeGrid.MyTestDisconnectsReason](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyTestDisconnectsReason.html)

reason

System.Boolean

sync
