---
title: "Class MyTimerComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyTimerComponent.html"
category: "Components"
namespace: "Sandbox.Game.Components"
class: "MyTimerComponent"
---

# Class MyTimerComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyTimerComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyTimerComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyTimerComponent()

##### Declaration

```
public MyTimerComponent()
```

### Properties

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

#### EventToTrigger

##### Declaration

```
public Action<IMyEntityComponentContainer> EventToTrigger { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<VRage.Game.Components.Interfaces.IMyEntityComponentContainer\> |     |

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

Get or sets is session update enabled. Usefull if you don't want this timer to be updated by Timer Component System (session component).

##### Declaration

```
public bool IsSessionUpdateEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveEntityOnTimer

##### Declaration

```
public bool RemoveEntityOnTimer { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Repeat

##### Declaration

```
public bool Repeat { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TimerEnabled

##### Declaration

```
public bool TimerEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TimerTick

Tick in minutes

##### Declaration

```
public float TimerTick { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### TimerTickInFrames

##### Declaration

```
public uint TimerTickInFrames { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### TimerType

##### Declaration

```
public MyTimerTypes TimerType { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyTimerTypes](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyTimerTypes.html) |     |

#### TimeToEvent

##### Declaration

```
public float TimeToEvent { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### ChangeTimerTick(UInt32)

##### Declaration

```
public void ChangeTimerTick(uint timeTickInFrames)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | timeTickInFrames |     |

#### ClearEvent()

##### Declaration

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase baseBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | baseBuilder |     |

##### Overrides

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

#### IsSerialized()

##### Declaration

```
public override bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### Pause()

##### Declaration

#### Resume(Boolean)

##### Declaration

```
public void Resume(bool forceTrigger = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | forceTrigger |     |

#### Serialize(Boolean)

##### Declaration

```
public override MyObjectBuilder_ComponentBase Serialize(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

##### Overrides

#### SetRemoveEntityTimer(Single)

##### Declaration

```
public void SetRemoveEntityTimer(float timeMin)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | timeMin |     |

#### SetTimer(Single, Action<IMyEntityComponentContainer>, Boolean, Boolean)

##### Declaration

```
public void SetTimer(float timeMin, Action<IMyEntityComponentContainer> triggerEvent, bool start = true, bool repeat = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | timeMin |     |
| System.Action<VRage.Game.Components.Interfaces.IMyEntityComponentContainer\> | triggerEvent |     |
| System.Boolean | start |     |
| System.Boolean | repeat |     |
