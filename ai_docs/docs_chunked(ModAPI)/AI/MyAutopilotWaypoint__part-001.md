---
title: "Class MyAutopilotWaypoint"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAutopilotWaypoint.html"
category: "AI"
namespace: "Sandbox.Game.Entities"
class: "MyAutopilotWaypoint"
---

# Class MyAutopilotWaypoint | Space Engineers ModAPI

##### Inheritance

System.Object

MyAutopilotWaypoint

##### Implements

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyAutopilotWaypoint : Object, IMyAutopilotWaypoint
```

### Constructors

#### MyAutopilotWaypoint(MyObjectBuilder\_AutopilotWaypoint)

##### Declaration

```
public MyAutopilotWaypoint(MyObjectBuilder_AutopilotWaypoint builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_AutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutopilotWaypoint.html) | builder |     |

#### MyAutopilotWaypoint(MatrixD, String, List<MyObjectBuilder\_ToolbarItem>, List<Int32>, Boolean)

##### Declaration

```
public MyAutopilotWaypoint(MatrixD matrix, string name, List<MyObjectBuilder_ToolbarItem> actionBuilders, List<int> indexes, bool draw)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix |     |
| System.String | name |     |
| System.Collections.Generic.List<[MyObjectBuilder\_ToolbarItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ToolbarItem.html)\> | actionBuilders |     |
| System.Collections.Generic.List<System.Int32\> | indexes |     |
| System.Boolean | draw |     |

#### MyAutopilotWaypoint(Vector3D, String)

##### Declaration

```
public MyAutopilotWaypoint(Vector3D coords, string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | coords |     |
| System.String | name |     |

#### MyAutopilotWaypoint(Vector3D, String, List<MyObjectBuilder\_ToolbarItem>, List<Int32>, Boolean)

##### Declaration

```
public MyAutopilotWaypoint(Vector3D coords, string name, List<MyObjectBuilder_ToolbarItem> actionBuilders, List<int> indexes, bool draw)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | coords |     |
| System.String | name |     |
| System.Collections.Generic.List<[MyObjectBuilder\_ToolbarItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ToolbarItem.html)\> | actionBuilders |     |
| System.Collections.Generic.List<System.Int32\> | indexes |     |
| System.Boolean | draw |     |

#### MyAutopilotWaypoint(Vector3D, MyPositionAndOrientation, Int64, MyPositionAndOrientation, Vector3D, String)

##### Declaration

```
public MyAutopilotWaypoint(Vector3D coords, MyPositionAndOrientation matrix, long relatedEntityId, MyPositionAndOrientation relatedEntityMatrix, Vector3D relatedEntityWorldOffset, string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | coords |     |
| VRage.MyPositionAndOrientation | matrix |     |
| System.Int64 | relatedEntityId |     |
| VRage.MyPositionAndOrientation | relatedEntityMatrix |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | relatedEntityWorldOffset |     |
| System.String | name |     |

### Fields

#### RelatedMatrixOriginal

Related matrix when recorded. Same as Matrix when no related entity was present

##### Declaration

```
public MatrixD RelatedMatrixOriginal
```

##### Field Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### SerializeForCopy

##### Declaration

```
public bool SerializeForCopy
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

#### Actions

##### Declaration

```
public MyToolbarItem[] Actions { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Screens.Helpers.MyToolbarItem\[\] |     |

#### AdaptiveRotationSpeed

##### Declaration

```
public bool AdaptiveRotationSpeed { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AreaUp

##### Declaration

```
public Vector3D AreaUp { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### CanDraw

##### Declaration

```
public bool CanDraw { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Coords

Translation when recorded

##### Declaration

```
public Vector3D Coords { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### DistancePrecisionMultiplier

##### Declaration

```
public float DistancePrecisionMultiplier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DrawObject

##### Declaration

```
public MyGps DrawObject { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Screens.Helpers.MyGps |     |

#### ForceRotation

##### Declaration

```
public bool ForceRotation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsCorrectRotationNeeded

##### Declaration

```
public bool IsCorrectRotationNeeded { get; set; }
```
