---
title: "Class MyEntityDependencyTypeAttribute"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityDependencyTypeAttribute.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyEntityDependencyTypeAttribute"
---

# Class MyEntityDependencyTypeAttribute | Space Engineers ModAPI

Entity Dependency type is required for entity component. If entity type is not equal, subclass or assignable, entity component will not be created and it's considered as error.

##### Inheritance

System.Object

MyEntityDependencyTypeAttribute

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyEntityDependencyTypeAttribute : Attribute
```

### Constructors

#### MyEntityDependencyTypeAttribute(Type)

##### Declaration

```
public MyEntityDependencyTypeAttribute(Type entityType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | entityType |     |

### Fields

#### EntityType

##### Declaration

```
public readonly Type EntityType
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Type |     |