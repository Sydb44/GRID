---
title: "Class MyWaypoint"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyWaypoint.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyWaypoint"
---

# Class MyWaypoint | Space Engineers ModAPI

##### Inheritance

System.Object

MyWaypoint

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyEntityType]
public class MyWaypoint : MyEntity, IMyEntity, IMyEntity, IMyEventProxy, IMyEventOwner
```

### Constructors

#### MyWaypoint()

##### Declaration

### Properties

#### Freeze

##### Declaration

```
public bool Freeze { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Path

##### Declaration

```
public string Path { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Visible

##### Declaration

```
public bool Visible { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetObjectBuilder(Boolean)

##### Declaration

```
public override MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

##### Overrides

#### Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
public override void Init(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |

##### Overrides

### Implements

### Extension Methods