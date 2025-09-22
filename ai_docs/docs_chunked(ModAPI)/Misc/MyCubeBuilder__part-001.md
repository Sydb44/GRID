---
title: "Class MyCubeBuilder"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBuilder.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyCubeBuilder"
---

# Class MyCubeBuilder | Space Engineers ModAPI

##### Inheritance

System.Object

MyCubeBuilder

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MySessionComponentDescriptor]
[StaticEventOwner]
public class MyCubeBuilder : MyBlockBuilderBase, IMyUserInputComponent, IMyFocusHolder, IMyCubeBuilder
```

### Constructors

#### MyCubeBuilder()

##### Declaration

### Fields

#### AllPlayersColors

##### Declaration

```
public static Dictionary<MyPlayer.PlayerId, List<Vector3>> AllPlayersColors
```

##### Field Value

Type

Description

System.Collections.Generic.Dictionary<Sandbox.Game.World.MyPlayer.PlayerId, System.Collections.Generic.List<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>>

#### BLOCK\_ROTATION\_SPEED

##### Declaration

```
protected static double BLOCK_ROTATION_SPEED
```

##### Field Value

Type

Description

System.Double

#### canBuild

##### Declaration

##### Field Value

Type

Description

System.Boolean

#### m\_blocksBuildQueue

##### Declaration

```
protected HashSet<MyCubeGrid.MyBlockLocation> m_blocksBuildQueue
```

##### Field Value

Type

Description

System.Collections.Generic.HashSet<[MyCubeGrid.MyBlockLocation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyBlockLocation.html)\>

#### m\_cubeBuilderState

##### Declaration

```
protected MyCubeBuilderState m_cubeBuilderState
```

##### Field Value

Type

Description

Sandbox.Game.Entities.Cube.CubeBuilder.MyCubeBuilderState

#### m\_gameInventory

##### Declaration

```
protected MySessionComponentGameInventory m_gameInventory
```

##### Field Value

Type

Description

Sandbox.Game.SessionComponents.MySessionComponentGameInventory

#### m\_gizmo

##### Declaration

```
protected MyCubeBuilderGizmo m_gizmo
```

##### Field Value

Type

Description

Sandbox.Game.Entities.Cube.MyCubeBuilderGizmo

#### m\_lastLocalCoordSysData

##### Declaration

```
protected MyCoordinateSystem.CoordSystemData m_lastLocalCoordSysData
```

##### Field Value

Type

Description

Sandbox.Game.GameSystems.CoordinateSystem.MyCoordinateSystem.CoordSystemData

#### m\_renderData

##### Declaration

```
protected MyBlockBuilderRenderData m_renderData
```

##### Field Value

Type

Description

Sandbox.Game.Entities.Cube.MyBlockBuilderRenderData

#### m\_rotationHints

##### Declaration

```
protected MyBlockBuilderRotationHints m_rotationHints
```

##### Field Value

Type

Description

Sandbox.Game.Entities.Cube.MyBlockBuilderRotationHints

#### m\_tmpBlockPositionList

##### Declaration

```
protected List<Vector3I> m_tmpBlockPositionList
```

##### Field Value

Type

Description

System.Collections.Generic.List<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

#### m\_tmpBlockPositionsSet

##### Declaration

```
protected HashSet<Vector3I> m_tmpBlockPositionsSet
```

##### Field Value

Type

Description

System.Collections.Generic.HashSet<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

#### m\_toolType

##### Declaration

```
public MyCubeBuilderToolType m_toolType
```

##### Field Value

Type

Description

[MyCubeBuilderToolType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBuilderToolType.html)

#### MaxGridDistanceFrom

##### Declaration

```
public Nullable<Vector3D> MaxGridDistanceFrom
```

##### Field Value

Type

Description

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

#### Static

##### Declaration

```
public static MyCubeBuilder Static
```

##### Field Value

Type

Description

[MyCubeBuilder](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBuilder.html)

### Properties

#### AlignToDefault

##### Declaration

```
public bool AlignToDefault { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### BlockCreationIsActivated

##### Declaration

```
public bool BlockCreationIsActivated { get; }
```

##### Property Value

Type

Description

System.Boolean

#### BuildComponent

##### Declaration

```
public static MyBuildComponentBase BuildComponent { get; set; }
```

##### Property Value

Type

Description

Sandbox.Game.World.MyBuildComponentBase

#### BuildingMode

##### Declaration

```
public static MyCubeBuilder.BuildingModeEnum BuildingMode { get; set; }
```

##### Property Value

Type

Description

[MyCubeBuilder.BuildingModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBuilder.BuildingModeEnum.html)

#### BuildInputValid

##### Declaration

```
protected bool BuildInputValid { get; }
```

##### Property Value

Type

Description

System.Boolean

#### CubeBuilderState

##### Declaration

```
public MyCubeBuilderState CubeBuilderState { get; }
```

##### Property Value

Type

Description

Sandbox.Game.Entities.Cube.CubeBuilder.MyCubeBuilderState

#### CubePlacementMode

##### Declaration

```
public MyCubeBuilder.CubePlacementModeEnum CubePlacementMode { get; set; }
```

##### Property Value

Type

Description

[MyCubeBuilder.CubePlacementModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBuilder.CubePlacementModeEnum.html)

#### CurrentBlockDefinition

##### Declaration

```
public override MyCubeBlockDefinition CurrentBlockDefinition { get; protected set; }
```

##### Property Value

Type

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)
