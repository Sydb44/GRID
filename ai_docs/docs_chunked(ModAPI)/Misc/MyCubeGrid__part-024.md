settings

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

localAabb

System.Boolean

dynamicBuildMode

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoredEntity

##### Returns

Type

Description

System.Boolean

#### TestPlacementAreaCube(MyCubeGrid, ref MyGridPlacementSettings, Vector3I, Vector3I, MyBlockOrientation, MyCubeBlockDefinition, out MyCubeGrid, UInt64, MyEntity, Boolean, Boolean, Boolean, Boolean)

Test cube block placement area in grid.

##### Declaration

```
public static bool TestPlacementAreaCube(MyCubeGrid targetGrid, ref MyGridPlacementSettings settings, Vector3I min, Vector3I max, MyBlockOrientation blockOrientation, MyCubeBlockDefinition blockDefinition, out MyCubeGrid touchingGrid, ulong placingPlayer = 0UL, MyEntity ignoredEntity = null, bool ignoreFracturedPieces = false, bool isProjected = false, bool forceCheck = false, bool wheelsAsCylinders = true)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

targetGrid

VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings

settings

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

blockOrientation

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

blockDefinition

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

touchingGrid

System.UInt64

placingPlayer

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoredEntity

System.Boolean

ignoreFracturedPieces

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

#### TestPlacementAreaCube(MyCubeGrid, ref MyGridPlacementSettings, Vector3I, Vector3I, MyBlockOrientation, MyCubeBlockDefinition, UInt64, MyEntity, Boolean, Boolean, Boolean)

##### Declaration

```
public static bool TestPlacementAreaCube(MyCubeGrid targetGrid, ref MyGridPlacementSettings settings, Vector3I min, Vector3I max, MyBlockOrientation blockOrientation, MyCubeBlockDefinition blockDefinition, ulong placingPlayer = 0UL, MyEntity ignoredEntity = null, bool ignoreFracturedPieces = false, bool isProjected = false, bool forceCheck = false)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

targetGrid

VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings

settings

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

blockOrientation

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

blockDefinition

System.UInt64

placingPlayer

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoredEntity

System.Boolean

ignoreFracturedPieces

System.Boolean

isProjected

System.Boolean

forceCheck

##### Returns

Type

Description

System.Boolean

#### TestPlacementAreaCubeNoAABBInflate(MyCubeGrid, ref MyGridPlacementSettings, Vector3I, Vector3I, MyBlockOrientation, MyCubeBlockDefinition, out MyCubeGrid, UInt64, MyEntity, Boolean, Boolean)

##### Declaration

```
public static bool TestPlacementAreaCubeNoAABBInflate(MyCubeGrid targetGrid, ref MyGridPlacementSettings settings, Vector3I min, Vector3I max, MyBlockOrientation blockOrientation, MyCubeBlockDefinition blockDefinition, out MyCubeGrid touchingGrid, ulong placingPlayer = 0UL, MyEntity ignoredEntity = null, bool isProjected = false, bool wheelsAsCylinders = true)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

targetGrid

VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings

settings

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

blockOrientation

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

blockDefinition

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

touchingGrid

System.UInt64

placingPlayer

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoredEntity

System.Boolean

isProjected

System.Boolean

wheelsAsCylinders

##### Returns

Type

Description

System.Boolean

#### TestPlacementForWheel(HkShape, Quaternion, MatrixD, HkBodyCollision, MatrixD, MyCubeBlockDefinition)

##### Declaration

```
public static bool TestPlacementForWheel(HkShape shape, Quaternion shapeRotation, MatrixD worldMatrix, HkBodyCollision collison, MatrixD wheelMatrix, MyCubeBlockDefinition definition)
```

##### Parameters

Type

Name

Description

Havok.HkShape

shape

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

shapeRotation

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

Havok.HkBodyCollision

collison

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

wheelMatrix

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

definition
