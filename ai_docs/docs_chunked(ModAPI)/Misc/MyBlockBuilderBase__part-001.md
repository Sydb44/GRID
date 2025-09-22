---
title: "Class MyBlockBuilderBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyBlockBuilderBase.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyBlockBuilderBase"
---

# Class MyBlockBuilderBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyBlockBuilderBase

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyBlockBuilderBase : MySessionComponentBase, IMyUserInputComponent
```

### Constructors

#### MyBlockBuilderBase()

##### Declaration

```
protected MyBlockBuilderBase()
```

### Fields

#### m\_cubeBuilderDefinition

##### Declaration

```
protected static MyCubeBuilderDefinition m_cubeBuilderDefinition
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeBuilderDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.SessionComponents.MyCubeBuilderDefinition.html) |     |

#### m\_currentGrid

##### Declaration

```
protected MyCubeGrid m_currentGrid
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) |     |

#### m\_currentVoxelBase

##### Declaration

```
protected MyVoxelBase m_currentVoxelBase
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) |     |

#### m\_hitInfo

##### Declaration

```
protected Nullable<MyPhysics.HitInfo> m_hitInfo
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<Sandbox.Engine.Physics.MyPhysics.HitInfo\> |     |

#### m\_invGridWorldMatrix

##### Declaration

```
protected MatrixD m_invGridWorldMatrix
```

##### Field Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### m\_rotationControls

##### Declaration

```
protected static readonly MyStringId[] m_rotationControls
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\[\] |     |

#### m\_rotationDirections

##### Declaration

```
protected static readonly int[] m_rotationDirections
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32\[\] |     |

### Properties

#### CameraControllerSpectator

##### Declaration

```
public static bool CameraControllerSpectator { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CubeBuilderDefinition

##### Declaration

```
public static MyCubeBuilderDefinition CubeBuilderDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeBuilderDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.SessionComponents.MyCubeBuilderDefinition.html) |     |

#### CurrentBlockDefinition

##### Declaration

```
public abstract MyCubeBlockDefinition CurrentBlockDefinition { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) |     |

#### CurrentGrid

##### Declaration

```
protected abstract MyCubeGrid CurrentGrid { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) |     |

#### CurrentVoxelBase

##### Declaration

```
protected abstract MyVoxelBase CurrentVoxelBase { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) |     |

#### FreePlacementTarget

##### Declaration

```
public Vector3D FreePlacementTarget { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### HitInfo

##### Declaration

```
public Nullable<MyPhysics.HitInfo> HitInfo { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<Sandbox.Engine.Physics.MyPhysics.HitInfo\> |     |

#### IntersectionDirection

##### Declaration

```
public static Vector3D IntersectionDirection { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### IntersectionDistance

##### Declaration

```
public static float IntersectionDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IntersectionStart

##### Declaration

```
public static Vector3D IntersectionStart { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### IsActivated

##### Declaration

```
public abstract bool IsActivated { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PlacementProvider

##### Declaration

```
public static IMyPlacementProvider PlacementProvider { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Cube.IMyPlacementProvider |     |

#### SpectatorIsBuilding

##### Declaration

```
public static bool SpectatorIsBuilding { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Activate(Nullable<MyDefinitionId>, Boolean)
