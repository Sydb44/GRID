---
title: "Class MyObjectBuilder\\_ProjectorBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ProjectorBase.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_ProjectorBase"
---

# Class MyObjectBuilder\_ProjectorBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_ProjectorBase

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public abstract class MyObjectBuilder_ProjectorBase : MyObjectBuilder_FunctionalBlock
```

### Constructors

#### MyObjectBuilder\_ProjectorBase()

##### Declaration

```
protected MyObjectBuilder_ProjectorBase()
```

### Fields

#### GetOwnershipFromProjector

##### Declaration

```
public bool GetOwnershipFromProjector
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### InstantBuildingEnabled

##### Declaration

```
public bool InstantBuildingEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### KeepProjection

##### Declaration

```
public bool KeepProjection
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MarkMissingBlocks

##### Declaration

```
public bool MarkMissingBlocks
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MarkUnfinishedBlocks

##### Declaration

```
public bool MarkUnfinishedBlocks
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxNumberOfBlocks

##### Declaration

```
public int MaxNumberOfBlocks
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MaxNumberOfProjections

##### Declaration

```
public int MaxNumberOfProjections
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ProjectedGrid

This property is obsolete. Do not use it any more. Use Projected grids. In case of single projected grid, select index 0.

##### Declaration

```
[Serialize]
public MyObjectBuilder_CubeGrid ProjectedGrid
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_CubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeGrid.html) |     |

#### ProjectedGrids

##### Declaration

```
[Serialize]
public List<MyObjectBuilder_CubeGrid> ProjectedGrids
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_CubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeGrid.html)\> |     |

#### ProjectionOffset

##### Declaration

```
public Vector3I ProjectionOffset
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### ProjectionRotation

##### Declaration

```
public Vector3I ProjectionRotation
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### ProjectionsRemaining

##### Declaration

```
public int ProjectionsRemaining
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Scale

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ShowOnlyBuildable

##### Declaration

```
public bool ShowOnlyBuildable
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TextPanels

##### Declaration

```
[Serialize]
public List<MySerializedTextPanelData> TextPanels
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MySerializedTextPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MySerializedTextPanelData.html)\> |     |

### Methods

#### GetTextPanelsData()

##### Declaration

```
public override List<MySerializedTextPanelData> GetTextPanelsData()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MySerializedTextPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MySerializedTextPanelData.html)\> |     |

##### Overrides

#### Remap(IMyRemapHelper)

##### Declaration

```
public override void Remap(IMyRemapHelper remapHelper)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyRemapHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html) | remapHelper |     |

##### Overrides

#### SetupForProjector()

##### Declaration

```
public override void SetupForProjector()
```

##### Overrides

### Extension Methods