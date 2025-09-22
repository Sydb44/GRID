---
title: "Class MyNullRenderComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyNullRenderComponent.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyNullRenderComponent"
---

# Class MyNullRenderComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyNullRenderComponent

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyNullRenderComponent : MyRenderComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyNullRenderComponent()

##### Declaration

```
public MyNullRenderComponent()
```

### Properties

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

### Methods

#### AddRenderObjects()

##### Declaration

```
public override void AddRenderObjects()
```

##### Overrides

#### CanBeAddedToRender()

##### Declaration

```
protected override bool CanBeAddedToRender()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### Draw()

##### Declaration

```
public override void Draw()
```

##### Overrides

#### InvalidateRenderObjects()

##### Declaration

```
public override void InvalidateRenderObjects()
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

#### RemoveRenderObjects()

##### Declaration

```
public override void RemoveRenderObjects()
```

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

#### UpdateRenderEntity(Vector3)

##### Declaration

```
public override void UpdateRenderEntity(Vector3 colorMaskHSV)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | colorMaskHSV |     |

##### Overrides

#### UpdateRenderObjectVisibility(Boolean)

##### Declaration

```
protected override void UpdateRenderObjectVisibility(bool visible)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | visible |     |

##### Overrides

### Extension Methods