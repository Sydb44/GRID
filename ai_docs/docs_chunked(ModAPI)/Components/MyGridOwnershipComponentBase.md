---
title: "Class MyGridOwnershipComponentBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyGridOwnershipComponentBase.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyGridOwnershipComponentBase"
---

# Class MyGridOwnershipComponentBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyGridOwnershipComponentBase

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyGridOwnershipComponentBase : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyGridOwnershipComponentBase()

##### Declaration

```
protected MyGridOwnershipComponentBase()
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

### Methods

#### GetBlockOwnerId(MySlimBlock)

Returns the identity id of the block's owner

##### Declaration

```
public abstract long GetBlockOwnerId(MySlimBlock block)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Entities.Cube.MySlimBlock | block |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Extension Methods