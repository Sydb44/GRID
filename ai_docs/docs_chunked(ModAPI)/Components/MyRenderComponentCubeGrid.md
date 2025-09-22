---
title: "Class MyRenderComponentCubeGrid"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyRenderComponentCubeGrid.html"
category: "Components"
namespace: "Sandbox.Game.Components"
class: "MyRenderComponentCubeGrid"
---

# Class MyRenderComponentCubeGrid | Space Engineers ModAPI

##### Inheritance

System.Object

MyRenderComponentCubeGrid

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyRenderComponentCubeGrid : MyRenderComponent, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyRenderComponentCubeGrid()

##### Declaration

```
public MyRenderComponentCubeGrid()
```

### Properties

#### CubeGrid

##### Declaration

```
public MyCubeGrid CubeGrid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) |     |

#### DeferRenderRelease

##### Declaration

```
public bool DeferRenderRelease { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GridSize

##### Declaration

```
public float GridSize { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GridSizeEnum

##### Declaration

```
public MyCubeSize GridSizeEnum { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeSize](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCubeSize.html) |     |

#### IsStatic

##### Declaration

```
public bool IsStatic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RenderData

##### Declaration

```
public MyCubeGridRenderData RenderData { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Cube.MyCubeGridRenderData |     |

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

#### RebuildDirtyCells()

##### Declaration

```
public void RebuildDirtyCells()
```

#### RemoveRenderObjects()

##### Declaration

```
public override void RemoveRenderObjects()
```

##### Overrides

#### ResetLastVoxelContactTimer()

##### Declaration

```
public void ResetLastVoxelContactTimer()
```

#### UpdateRenderObjectMatrices(Matrix)

##### Declaration

```
public void UpdateRenderObjectMatrices(Matrix matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix |     |

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