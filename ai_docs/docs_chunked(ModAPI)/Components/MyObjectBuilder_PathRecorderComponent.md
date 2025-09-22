---
title: "Class MyObjectBuilder\\_PathRecorderComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_PathRecorderComponent.html"
category: "Components"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_PathRecorderComponent"
---

# Class MyObjectBuilder\_PathRecorderComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_PathRecorderComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_PathRecorderComponent : MyObjectBuilder_ComponentBase
```

### Constructors

#### MyObjectBuilder\_PathRecorderComponent()

##### Declaration

```
public MyObjectBuilder_PathRecorderComponent()
```

### Fields

#### BeaconEntityId

##### Declaration

```
public long BeaconEntityId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### MinimalDistance

##### Declaration

```
public float MinimalDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Play

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RecordInterval

##### Declaration

```
public byte RecordInterval
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Repeat

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowPath

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowSelectedPoints

##### Declaration

```
public bool ShowSelectedPoints
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Waypoints

##### Declaration

```
[Serialize]
[DynamicNullableObjectBuilderItem(false)]
public List<MyObjectBuilder_AutopilotWaypoint> Waypoints
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_AutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutopilotWaypoint.html)\> |     |

### Methods

#### Remap(IMyRemapHelper)

##### Declaration

```
public override void Remap(IMyRemapHelper remapHelper)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyRemapHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html) | remapHelper |     |

##### Overrides

### Extension Methods