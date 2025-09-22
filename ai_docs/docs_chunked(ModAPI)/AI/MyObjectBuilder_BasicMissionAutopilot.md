---
title: "Class MyObjectBuilder\\_BasicMissionAutopilot"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_BasicMissionAutopilot.html"
category: "AI"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_BasicMissionAutopilot"
---

# Class MyObjectBuilder\_BasicMissionAutopilot | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_BasicMissionAutopilot

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_BasicMissionAutopilot : MyObjectBuilder_ComponentBase
```

### Constructors

#### MyObjectBuilder\_BasicMissionAutopilot()

##### Declaration

```
public MyObjectBuilder_BasicMissionAutopilot()
```

### Fields

#### CurrentWaypoint

##### Declaration

```
[Serialize]
public MyObjectBuilder_AutopilotWaypoint CurrentWaypoint
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_AutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutopilotWaypoint.html) |     |

#### Mode

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

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