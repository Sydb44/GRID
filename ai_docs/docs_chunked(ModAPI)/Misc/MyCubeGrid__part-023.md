Type

Description

System.Boolean

#### TestBlockPlacementArea(MyCubeGrid, ref MyGridPlacementSettings, MyBlockOrientation, MyCubeBlockDefinition, ref Vector3D, ref Quaternion, ref Vector3, ref BoundingBoxD, UInt64, MyEntity, Boolean, Boolean)

##### Declaration

```
public static bool TestBlockPlacementArea(MyCubeGrid targetGrid, ref MyGridPlacementSettings settings, MyBlockOrientation blockOrientation, MyCubeBlockDefinition blockDefinition, ref Vector3D translation, ref Quaternion rotation, ref Vector3 halfExtents, ref BoundingBoxD localAabb, ulong placingPlayer = 0UL, MyEntity ignoredEntity = null, bool isProjected = false, bool wheelsAsCylinders = true)
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

translation

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

halfExtents

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

localAabb

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

#### TestBlockPlacementAreaVanilla(MyCubeGrid, ref MyGridPlacementSettings, MyBlockOrientation, MyCubeBlockDefinition, ref Vector3D, ref Quaternion, ref Vector3, ref BoundingBoxD, out MyCubeGrid, UInt64, MyEntity, Boolean, Boolean, Boolean, Boolean)

##### Declaration

```
public static bool TestBlockPlacementAreaVanilla(MyCubeGrid targetGrid, ref MyGridPlacementSettings settings, MyBlockOrientation blockOrientation, MyCubeBlockDefinition blockDefinition, ref Vector3D translationObsolete, ref Quaternion rotation, ref Vector3 halfExtentsObsolete, ref BoundingBoxD localAabb, out MyCubeGrid touchingGrid, ulong placingPlayer = 0UL, MyEntity ignoredEntity = null, bool ignoreFracturedPieces = false, bool testVoxel = true, bool isProjected = false, bool forceCheck = false)
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

##### Returns

Type

Description

System.Boolean

#### TestPlacementArea(MyCubeGrid, Boolean, ref MyGridPlacementSettings, BoundingBoxD, Boolean, MyEntity, Boolean, Boolean)

##### Declaration

```
public static bool TestPlacementArea(MyCubeGrid targetGrid, bool targetGridIsStatic, ref MyGridPlacementSettings settings, BoundingBoxD localAabb, bool dynamicBuildMode, MyEntity ignoredEntity = null, bool testVoxel = true, bool testPhysics = true)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

targetGrid

System.Boolean

targetGridIsStatic

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

System.Boolean

testPhysics

##### Returns

Type

Description

System.Boolean

#### TestPlacementArea(MyCubeGrid, ref MyGridPlacementSettings, BoundingBoxD, Boolean, MyEntity)

##### Declaration

```
public static bool TestPlacementArea(MyCubeGrid targetGrid, ref MyGridPlacementSettings settings, BoundingBoxD localAabb, bool dynamicBuildMode, MyEntity ignoredEntity = null)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

targetGrid

VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings

settings

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

localAabb

System.Boolean

dynamicBuildMode

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ignoredEntity
