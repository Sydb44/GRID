---
title: "Class MyBlocksPruningStructureComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyBlocksPruningStructureComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyBlocksPruningStructureComponent"
---

# Class MyBlocksPruningStructureComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyBlocksPruningStructureComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyBlocksPruningStructureComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyBlocksPruningStructureComponent()

##### Declaration

```
public MyBlocksPruningStructureComponent()
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

#### OnBlockAdded(MyCubeBlock)

##### Declaration

```
public void OnBlockAdded(MyCubeBlock fatBlock)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html) | fatBlock |     |

#### OnBlockRemoved(MyCubeBlock)

##### Declaration

```
public void OnBlockRemoved(MyCubeBlock fatBlock)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html) | fatBlock |     |

#### Query<T>(BoundingSphereD, List<T>)

##### Declaration

```
public void Query<T>(BoundingSphereD sphere, List<T> output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| System.Collections.Generic.List<T> | output |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### RegisterComponentTypeOwner<T>()

##### Declaration

```
public void RegisterComponentTypeOwner<T>()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### RegisterType<T>()

##### Declaration

```
public void RegisterType<T>()
    where T : MyCubeBlock
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Extension Methods