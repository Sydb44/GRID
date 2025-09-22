---
title: "Class My2DClipmap<THandler>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.My2DClipmap-1.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment"
class: "My2DClipmap-1"
---

# Class My2DClipmap<THandler> | Space Engineers ModAPI

##### Inheritance

System.Object

My2DClipmap<THandler>

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class My2DClipmap<THandler> : Object where THandler : class, IMy2DClipmapNodeHandler, new()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| THandler |     |

### Constructors

#### My2DClipmap()

##### Declaration

### Fields

#### NodeAllocDeallocs

##### Declaration

```
public int NodeAllocDeallocs
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### Depth

##### Declaration

```
public int Depth { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### FaceHalf

##### Declaration

```
public double FaceHalf { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### InverseWorldMatrix

##### Declaration

```
public MatrixD InverseWorldMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### LastPosition

##### Declaration

```
public Vector3D LastPosition { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### LeafSize

##### Declaration

```
public double LeafSize { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### WorldMatrix

##### Declaration

```
public MatrixD WorldMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

### Methods

#### Clear()

##### Declaration

#### GetHandler(Vector2D)

##### Declaration

```
public THandler GetHandler(Vector2D point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| THandler |     |

#### Init(IMy2DClipmapManager, ref MatrixD, Double, Double)

##### Declaration

```
public void Init(IMy2DClipmapManager manager, ref MatrixD worldMatrix, double sectorSize, double faceSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMy2DClipmapManager](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMy2DClipmapManager.html) | manager |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| System.Double | sectorSize |     |
| System.Double | faceSize |     |

#### Update(Vector3D)

##### Declaration

```
public void Update(Vector3D localPosition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | localPosition |     |