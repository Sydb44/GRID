---
title: "Class MyRenderComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyRenderComponent.html"
category: "Components"
namespace: "Sandbox.Game.Components"
class: "MyRenderComponent"
---

# Class MyRenderComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyRenderComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyRenderComponent : MyRenderComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyRenderComponent()

##### Declaration

```
public MyRenderComponent()
```

### Fields

#### m\_model

##### Declaration

```
protected MyModel m_model
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Game.Models.MyModel |     |

### Properties

#### Model

##### Declaration

```
public MyModel Model { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Game.Models.MyModel |     |

#### ModelStorage

##### Declaration

```
public override object ModelStorage { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Object |     |

##### Overrides

#### NeedsDraw

##### Declaration

```
public override bool NeedsDraw { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

### Methods

#### AddRenderObjects()

##### Declaration

```
public override void AddRenderObjects()
```

##### Overrides

#### Draw()

##### Declaration

```
public override void Draw()
```

##### Overrides

#### IsVisible()

##### Declaration

```
public override bool IsVisible()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### ReleaseRenderObjectID(Int32)

##### Declaration

```
public override void ReleaseRenderObjectID(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Overrides

#### SetRenderObjectID(Int32, UInt32)

##### Declaration

```
public override void SetRenderObjectID(int index, uint ID)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |
| System.UInt32 | ID  |     |

##### Overrides

### Extension Methods