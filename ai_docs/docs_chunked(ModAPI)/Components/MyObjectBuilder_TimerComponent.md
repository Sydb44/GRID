---
title: "Class MyObjectBuilder\\_TimerComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_TimerComponent.html"
category: "Components"
namespace: "VRage.Game.ObjectBuilders.ComponentSystem"
class: "MyObjectBuilder_TimerComponent"
---

# Class MyObjectBuilder\_TimerComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_TimerComponent

##### Inherited Members

###### **Namespace**: [VRage.Game.ObjectBuilders.ComponentSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_TimerComponent : MyObjectBuilder_ComponentBase
```

### Constructors

#### MyObjectBuilder\_TimerComponent()

##### Declaration

```
public MyObjectBuilder_TimerComponent()
```

### Fields

#### RemoveEntityOnTimer

##### Declaration

```
public bool RemoveEntityOnTimer
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Repeat

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SetTimeMinutes

##### Declaration

```
public float SetTimeMinutes
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### TimerEnabled

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TimerType

##### Declaration

```
public MyTimerTypes TimerType
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyTimerTypes](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyTimerTypes.html) |     |

#### TimeToEvent

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Properties

#### FramesFromLastTrigger

##### Declaration

```
public uint FramesFromLastTrigger { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### IsSessionUpdateEnabled

##### Declaration

```
public bool IsSessionUpdateEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TimerTickInFrames

##### Declaration

```
public uint TimerTickInFrames { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

### Extension Methods