---
title: "Class MyObjectBuilder\\_BasicMissionFollowHome"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_BasicMissionFollowHome.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_BasicMissionFollowHome"
---

# Class MyObjectBuilder\_BasicMissionFollowHome | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_BasicMissionFollowHome

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_BasicMissionFollowHome : MyObjectBuilder_ComponentBase
```

### Constructors

#### MyObjectBuilder\_BasicMissionFollowHome()

##### Declaration

```
public MyObjectBuilder_BasicMissionFollowHome()
```

### Fields

#### HomePosition

##### Declaration

```
public Vector3D HomePosition
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### HomeTargetWaypoint

##### Declaration

```
[Serialize]
public MyObjectBuilder_AutopilotWaypoint HomeTargetWaypoint
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_AutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutopilotWaypoint.html) |     |

#### IsWanderEnabled

##### Declaration

```
public bool IsWanderEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxRange

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinRange

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### NextWanderWaypoint

##### Declaration

```
[Serialize]
public MyObjectBuilder_AutopilotWaypoint NextWanderWaypoint
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_AutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutopilotWaypoint.html) |     |

#### SelectedBeaconEntityId

##### Declaration

```
public long SelectedBeaconEntityId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### SelectedGpsHash

##### Declaration

```
[Nullable]
public Nullable<int> SelectedGpsHash
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int32\> |     |

#### SelectedGpsHashNew

##### Declaration

```
[Nullable]
public Nullable<GpsInfo> SelectedGpsHashNew
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.Game.ObjectBuilders.AI.GpsInfo\> |     |

### Extension Methods