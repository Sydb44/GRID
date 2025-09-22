---
title: "Class MyPathRecorderComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyPathRecorderComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyPathRecorderComponent"
---

# Class MyPathRecorderComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyPathRecorderComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyPathRecorderComponent : MyEventProxyEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyTerminalControlsProviderComponent, IMyPathRecorderComponent, IMyPathRecorderComponent
```

### Constructors

#### MyPathRecorderComponent()

##### Declaration

```
public MyPathRecorderComponent()
```

### Fields

#### DetailedInfo

##### Declaration

```
public StringBuilder DetailedInfo
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Text.StringBuilder |     |

#### ErrorsInTerminal

##### Declaration

```
public bool ErrorsInTerminal
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Waypoints

##### Declaration

```
public List<MyAutopilotWaypoint> Waypoints
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAutopilotWaypoint.html)\> |     |

### Properties

#### BeaconDisplayText

##### Declaration

```
public string BeaconDisplayText { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### BeaconWorldPosition

##### Declaration

```
public Vector3D BeaconWorldPosition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### IsPlaying

##### Declaration

```
public bool IsPlaying { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPowered

##### Declaration

```
public bool IsPowered { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsRecording

##### Declaration

```
public bool IsRecording { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MinimalDistance

##### Declaration

```
public float MinimalDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RecordInterval

##### Declaration

```
public byte RecordInterval { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### RepeatPath

##### Declaration

```
public bool RepeatPath { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowPath

##### Declaration

```
public bool ShowPath { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowSelectedPoints

##### Declaration

```
public bool ShowSelectedPoints { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TerminalControlCreationPriority

##### Declaration

```
public int TerminalControlCreationPriority { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### AddWaypoint(IMyAutopilotWaypoint)

##### Declaration

```
public void AddWaypoint(IMyAutopilotWaypoint waypoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint.html) | waypoint |     |

#### CreateTerminalControls<T>()

##### Declaration

```
public void CreateTerminalControls<T>()
    where T : MyTerminalBlock
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | builder |     |

##### Overrides

#### DrawPath()

##### Declaration

#### GetWaypoints(List<IMyAutopilotWaypoint>)

##### Declaration

```
public void GetWaypoints(List<IMyAutopilotWaypoint> points)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint.html)\> | points |     |

#### Init(MyComponentDefinitionBase)

##### Declaration

```
public override void Init(MyComponentDefinitionBase definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html) | definition |     |

##### Overrides

#### IsPathShown()

##### Declaration

```
public bool IsPathShown()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsSerialized()

##### Declaration

```
public override bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |
