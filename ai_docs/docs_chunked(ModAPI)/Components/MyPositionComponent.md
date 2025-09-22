---
title: "Class MyPositionComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPositionComponent.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyPositionComponent"
---

# Class MyPositionComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyPositionComponent

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyPositionComponent : MyPositionComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyPositionComponent()

##### Declaration

```
public MyPositionComponent()
```

### Fields

#### SynchronizationEnabled

##### Declaration

```
public static bool SynchronizationEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### WorldPositionChanged

##### Declaration

```
public Action<object> WorldPositionChanged
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<System.Object\> |     |

### Properties

#### LocalAABB

Sets the local aabb.

##### Declaration

```
public override BoundingBox LocalAABB { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | The local aabb. |

##### Overrides

#### ShouldSync

##### Declaration

```
protected override bool ShouldSync { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

### Methods

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

#### OnWorldPositionChanged(Object, Boolean, Boolean)

Called when \[world position changed\].

##### Declaration

```
protected override void OnWorldPositionChanged(object source, bool updateChildren, bool forceUpdateAllChildren)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source | The source object that caused this event. |
| System.Boolean | updateChildren |     |
| System.Boolean | forceUpdateAllChildren |     |

##### Overrides

#### UpdateChildren(Object, Boolean)

Updates the children of this entity.

##### Declaration

```
protected virtual void UpdateChildren(object source, bool forceUpdateAllChildren)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |
| System.Boolean | forceUpdateAllChildren |     |

### Extension Methods