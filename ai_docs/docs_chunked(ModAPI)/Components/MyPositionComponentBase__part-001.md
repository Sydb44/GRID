---
title: "Class MyPositionComponentBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPositionComponentBase.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyPositionComponentBase"
---

# Class MyPositionComponentBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyPositionComponentBase

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MyPositionComponentBase : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyPositionComponentBase()

##### Declaration

```
protected MyPositionComponentBase()
```

### Fields

#### m\_invScaledMatrixDirty

##### Declaration

```
protected bool m_invScaledMatrixDirty
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### m\_lastParentWorldMatrixCounter

##### Declaration

```
public uint m_lastParentWorldMatrixCounter
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### m\_localAABB

##### Declaration

```
protected BoundingBox m_localAABB
```

##### Field Value

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### m\_localMatrix

##### Declaration

```
protected Matrix m_localMatrix
```

##### Field Value

| Type | Description |
| --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) |     |

#### m\_localVolume

##### Declaration

```
protected BoundingSphere m_localVolume
```

##### Field Value

| Type | Description |
| --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) |     |

#### m\_localVolumeOffset

##### Declaration

```
protected Vector3 m_localVolumeOffset
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### m\_normalizedInvMatrixDirty

##### Declaration

```
protected bool m_normalizedInvMatrixDirty
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### m\_worldAABB

##### Declaration

```
protected BoundingBoxD m_worldAABB
```

##### Field Value

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### m\_worldAABBDirty

##### Declaration

```
protected bool m_worldAABBDirty
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### m\_worldMatrix

##### Declaration

```
protected MatrixD m_worldMatrix
```

##### Field Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### m\_worldMatrixCounter

##### Declaration

```
public uint m_worldMatrixCounter
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### m\_worldMatrixDirty

##### Declaration

```
public bool m_worldMatrixDirty
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### m\_worldVolume

##### Declaration

```
protected BoundingSphereD m_worldVolume
```

##### Field Value

| Type | Description |
| --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) |     |

#### m\_worldVolumeDirty

##### Declaration

```
protected bool m_worldVolumeDirty
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OnReportInvalidMatrix

##### Declaration

```
public static Action<IMyEntity> OnReportInvalidMatrix
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

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

#### LocalAABB

Sets the local aabb.

##### Declaration

```
public virtual BoundingBox LocalAABB { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | The local aabb. |

#### LocalMatrix

##### Declaration

```
public Matrix LocalMatrix { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) |     |

#### LocalMatrixRef

Gets or sets the local matrix.

##### Declaration

```
public ref readonly Matrix LocalMatrixRef { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | The local matrix. |

#### LocalVolume

Sets the local volume.

##### Declaration

```
public BoundingSphere LocalVolume { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | The local volume. |

#### LocalVolumeOffset

Gets or sets the local volume offset.

##### Declaration

```
public Vector3 LocalVolumeOffset { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | The local volume offset. |

#### NeedsRecalculateWorldMatrix

##### Declaration

```
public bool NeedsRecalculateWorldMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |
