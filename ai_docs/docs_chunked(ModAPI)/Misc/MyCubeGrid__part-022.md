Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

worldPos

System.Single

gridSize

System.Boolean

staticGridAlignToCenter

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### StopReplay()

##### Declaration

#### StopSmoke()

##### Declaration

```
[Event(null, 11565)]
[Reliable]
[ServerInvoked]
[Broadcast]
public void StopSmoke()
```

#### SwitchPower()

##### Declaration

```
public bool SwitchPower()
```

##### Returns

Type

Description

System.Boolean

#### TargetingAddId(Int64)

##### Declaration

```
public void TargetingAddId(long id)
```

##### Parameters

Type

Name

Description

System.Int64

id

#### TargetingCanAttackGrid(Int64)

##### Declaration

```
public bool TargetingCanAttackGrid(long id)
```

##### Parameters

Type

Name

Description

System.Int64

id

##### Returns

Type

Description

System.Boolean

#### TargetingRemoveId(Int64)

##### Declaration

```
public void TargetingRemoveId(long id)
```

##### Parameters

Type

Name

Description

System.Int64

id

#### TargetingSetWhitelist(Boolean)

##### Declaration

```
public void TargetingSetWhitelist(bool whitelist)
```

##### Parameters

Type

Name

Description

System.Boolean

whitelist

#### Teleport(MatrixD, Object, Boolean)

##### Declaration

```
public override void Teleport(MatrixD worldMatrix, object source = null, bool ignoreAssert = false)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

System.Object

source

System.Boolean

ignoreAssert

##### Overrides

#### TestBlockPlacementArea(MyCubeBlockDefinition, Nullable<MyBlockOrientation>, MatrixD, ref MyGridPlacementSettings, BoundingBoxD, Boolean, MyEntity, Boolean)

##### Declaration

```
public static bool TestBlockPlacementArea(MyCubeBlockDefinition blockDefinition, Nullable<MyBlockOrientation> blockOrientation, MatrixD worldMatrix, ref MyGridPlacementSettings settings, BoundingBoxD localAabb, bool dynamicBuildMode, MyEntity ignoredEntity = null, bool testVoxel = true)
```

##### Parameters

Type

Name

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

blockDefinition

System.Nullable<[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)\>

blockOrientation

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings

settings

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

localAabb

System.Boolean

dynamicBuildMode

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoredEntity

System.Boolean

testVoxel

##### Returns

Type

Description

System.Boolean

#### TestBlockPlacementArea(MyCubeGrid, ref MyGridPlacementSettings, MyBlockOrientation, MyCubeBlockDefinition, ref Vector3D, ref Quaternion, ref Vector3, ref BoundingBoxD, out MyCubeGrid, UInt64, MyEntity, Boolean, Boolean, Boolean, Boolean, Boolean)

##### Declaration

```
public static bool TestBlockPlacementArea(MyCubeGrid targetGrid, ref MyGridPlacementSettings settings, MyBlockOrientation blockOrientation, MyCubeBlockDefinition blockDefinition, ref Vector3D translationObsolete, ref Quaternion rotation, ref Vector3 halfExtentsObsolete, ref BoundingBoxD localAabb, out MyCubeGrid touchingGrid, ulong placingPlayer = 0UL, MyEntity ignoredEntity = null, bool ignoreFracturedPieces = false, bool testVoxel = true, bool isProjected = false, bool forceCheck = false, bool wheelsAsCylinders = true)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

targetGrid

VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings

settings

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

blockOrientation

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

blockDefinition

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

translationObsolete

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

halfExtentsObsolete

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

localAabb

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

touchingGrid

System.UInt64

placingPlayer

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoredEntity

System.Boolean

ignoreFracturedPieces

System.Boolean

testVoxel

System.Boolean

isProjected

System.Boolean

forceCheck

System.Boolean

wheelsAsCylinders

##### Returns

Type

Description

System.Boolean

#### TestBlockPlacementArea(MyCubeGrid, ref MyGridPlacementSettings, MyBlockOrientation, MyCubeBlockDefinition, ref Vector3D, ref Quaternion, ref Vector3, ref BoundingBoxD, UInt64, MyEntity, Boolean, Boolean)

##### Declaration

```
public static bool TestBlockPlacementArea(MyCubeGrid targetGrid, ref MyGridPlacementSettings settings, MyBlockOrientation blockOrientation, MyCubeBlockDefinition blockDefinition, ref Vector3D translation, ref Quaternion rotation, ref Vector3 halfExtents, ref BoundingBoxD localAabb, ulong placingPlayer = 0UL, MyEntity ignoredEntity = null, bool isProjected = false, bool wheelsAsCylinders = true)
```
