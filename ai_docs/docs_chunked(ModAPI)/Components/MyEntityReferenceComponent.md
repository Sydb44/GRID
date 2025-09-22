---
title: "Class MyEntityReferenceComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyEntityReferenceComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyEntityReferenceComponent"
---

# Class MyEntityReferenceComponent | Space Engineers ModAPI

Reference counting component for entities.

Allows simplified management of short lived entities that may be shared amongst systems.

The count is initially 0 so the first referencee becomes the owner of the entity (this is sometimes called a floating reference).

##### Inheritance

System.Object

MyEntityReferenceComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyEntityReferenceComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyEntityReferenceComponent()

##### Declaration

```
public MyEntityReferenceComponent()
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

#### Ref()

Increase the reference count of this entity.

##### Declaration

#### Unref()

Decrease the entitie's reference count.

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Weather the count reached 0 and the entity was marked for close. |

### Extension Methods