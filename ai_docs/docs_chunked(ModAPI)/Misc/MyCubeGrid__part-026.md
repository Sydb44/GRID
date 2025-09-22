[MyCube](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCube.html)

cube

##### Returns

Type

Description

System.Boolean

#### TryPasteGrid\_Implementation(MyCubeGrid.MyPasteGridParameters)

##### Declaration

```
[Event(null, 9637)]
[Reliable]
[Server]
public static void TryPasteGrid_Implementation(MyCubeGrid.MyPasteGridParameters parameters)
```

##### Parameters

Type

Name

Description

[MyCubeGrid.MyPasteGridParameters](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyPasteGridParameters.html)

parameters

#### TryRayCastGrid(ref LineD, out MyCubeGrid, out Vector3D)

##### Declaration

```
public static bool TryRayCastGrid(ref LineD worldRay, out MyCubeGrid hitGrid, out Vector3D worldHitPos)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

worldRay

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

hitGrid

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

worldHitPos

##### Returns

Type

Description

System.Boolean

#### UnregisterDecoy(MyDecoy)

##### Declaration

```
public void UnregisterDecoy(MyDecoy block)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Blocks.MyDecoy

block

#### UnregisterInventory(MyCubeBlock)

##### Declaration

```
public void UnregisterInventory(MyCubeBlock block)
```

##### Parameters

Type

Name

Description

[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)

block

#### UnregisterOccupiedBlock(MyCockpit)

##### Declaration

```
public void UnregisterOccupiedBlock(MyCockpit block)
```

##### Parameters

Type

Name

Description

[MyCockpit](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCockpit.html)

block

#### UnregisterUnsafeBlock(MyCubeBlock)

##### Declaration

```
public void UnregisterUnsafeBlock(MyCubeBlock block)
```

##### Parameters

Type

Name

Description

[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)

block

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

#### UpdateAfterSimulation10()

##### Declaration

```
public override void UpdateAfterSimulation10()
```

##### Overrides

#### UpdateAfterSimulation100()

##### Declaration

```
public override void UpdateAfterSimulation100()
```

##### Overrides

#### UpdateAfterSimulationParallel()

##### Declaration

```
public void UpdateAfterSimulationParallel()
```

#### UpdateBeforeSimulation()

##### Declaration

```
public override void UpdateBeforeSimulation()
```

##### Overrides

#### UpdateBeforeSimulation10()

##### Declaration

```
public override void UpdateBeforeSimulation10()
```

##### Overrides

#### UpdateBeforeSimulation100()

##### Declaration

```
public override void UpdateBeforeSimulation100()
```

##### Overrides

#### UpdateBeforeSimulationParallel()

##### Declaration

```
public void UpdateBeforeSimulationParallel()
```

#### UpdateBlockNeighbours(MySlimBlock)

##### Declaration

```
public void UpdateBlockNeighbours(MySlimBlock block)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

#### UpdateDirty(Action, Boolean)

##### Declaration

```
public void UpdateDirty(Action callback = null, bool immediate = false)
```

##### Parameters

Type

Name

Description

System.Action

callback

System.Boolean

immediate

#### UpdateDirtyInternal()

##### Declaration

```
public void UpdateDirtyInternal()
```

#### UpdateInstanceData()

##### Declaration

```
public void UpdateInstanceData()
```

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

#### UpdateOwnership(Int64, Boolean)

##### Declaration

```
public void UpdateOwnership(long ownerId, bool isFunctional)
```

##### Parameters

Type

Name

Description

System.Int64

ownerId

System.Boolean

isFunctional

#### UpdateParticleContactPoint(Int64, ref Vector3, ref Vector3, ref Vector3, Single, Single, MyEntity.ContactPointData.ContactPointDataTypes)

##### Declaration

```
public void UpdateParticleContactPoint(long entityId, ref Vector3 relativePosition, ref Vector3 normal, ref Vector3 separatingVelocity, float separatingSpeed, float impulse, MyEntity.ContactPointData.ContactPointDataTypes flags)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

relativePosition

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

normal

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

separatingVelocity

System.Single

separatingSpeed

System.Single

impulse

[MyEntity.ContactPointData.ContactPointDataTypes](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.ContactPointData.ContactPointDataTypes.html)

flags

#### UpdatePredictionFlag()

##### Declaration

```
public void UpdatePredictionFlag()
```

#### UpdateTimeOnClients(Int32)

##### Declaration

```
[Event(null, 1848)]
[Reliable]
[ServerInvoked]
[BroadcastTerminalInfo]
public void UpdateTimeOnClients(int secondsRemaining)
```

##### Parameters

Type

Name

Description

System.Int32

secondsRemaining

#### WillRemoveBlockSplitGrid(MySlimBlock)

##### Declaration

```
public bool WillRemoveBlockSplitGrid(MySlimBlock testBlock)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

testBlock

##### Returns

Type

Description

System.Boolean

#### WorldToGridInteger(Vector3D)

##### Declaration

```
public Vector3I WorldToGridInteger(Vector3D coords)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

coords
