---
title: "Class MyCustomRenderEntitySubpart<TCustomRenderComponent>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCustomRenderEntitySubpart-1.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyCustomRenderEntitySubpart-1"
---

# Class MyCustomRenderEntitySubpart<TCustomRenderComponent> | Space Engineers ModAPI

##### Inheritance

System.Object

MyCustomRenderEntitySubpart<TCustomRenderComponent>

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyCustomRenderEntitySubpart<TCustomRenderComponent> : MyEntitySubpart, IMyEntity, IMyEntity where TCustomRenderComponent : MyRenderComponentBase, new()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TCustomRenderComponent |     |

### Constructors

#### MyCustomRenderEntitySubpart()

##### Declaration

```
public MyCustomRenderEntitySubpart()
```

### Properties

#### Render

##### Declaration

```
public TCustomRenderComponent Render { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| TCustomRenderComponent |     |

### Methods

#### HasCustomRenderComponent(out TCustomRenderComponent)

##### Declaration

```
public bool HasCustomRenderComponent(out TCustomRenderComponent render)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TCustomRenderComponent | render |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### InitComponents()

##### Declaration

```
public override void InitComponents()
```

##### Overrides

### Implements

### Extension Methods