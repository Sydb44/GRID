---
title: "Class MyEventProxyEntityComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyEventProxyEntityComponent.html"
category: "Events"
namespace: "Sandbox.Game.EntityComponents"
class: "MyEventProxyEntityComponent"
---

# Class MyEventProxyEntityComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyEventProxyEntityComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyEventProxyEntityComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner
```

### Constructors

#### MyEventProxyEntityComponent()

##### Declaration

```
public MyEventProxyEntityComponent()
```

### Fields

#### SyncType

##### Declaration

```
public readonly SyncType SyncType
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Sync.SyncType |     |

### Properties

#### AttachSyncToEntity

##### Declaration

```
public override bool AttachSyncToEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

### Methods

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

### Extension Methods