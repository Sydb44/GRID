---
title: "Interface IMyCamera"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyCamera.html"
category: "Misc"
namespace: "VRage.ModAPI"
class: "IMyCamera"
---

# Interface IMyCamera | Space Engineers ModAPI

Describes camera (mods interface)

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyCamera
```

### Properties

#### FarPlaneDistance

Gets farplane is set by MyObjectBuilder\_SessionSettings.ViewDistance

##### Declaration

```
float FarPlaneDistance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FieldOfViewAngle

Gets field of view angle in degrees

##### Declaration

```
float FieldOfViewAngle { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FieldOfViewAngleForNearObjects

##### Declaration

```
float FieldOfViewAngleForNearObjects { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FovWithZoom

Gets field of view with zoom

##### Declaration

```
float FovWithZoom { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FovWithZoomForNearObjects

##### Declaration

```
float FovWithZoomForNearObjects { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### NearPlaneDistance

Gets near plane distance

##### Declaration

```
float NearPlaneDistance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Position

Gets camera position

##### Declaration

```
Vector3D Position { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### PreviousPosition

Gets camera previous position

##### Declaration

```
Vector3D PreviousPosition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### ProjectionMatrix

Gets projection matrix

##### Declaration

```
MatrixD ProjectionMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### ProjectionMatrixForNearObjects

##### Declaration

```
MatrixD ProjectionMatrixForNearObjects { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### ViewMatrix

Gets view matrix when camera in real position

##### Declaration

```
MatrixD ViewMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### ViewportOffset

Gets camera viewport offset

##### Declaration

```
Vector2 ViewportOffset { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

#### ViewportSize

Gets camera viewport size

##### Declaration

```
Vector2 ViewportSize { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

#### WorldMatrix

Gets camera world matrix

##### Declaration

```
MatrixD WorldMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

### Methods

#### GetDistanceWithFOV(Vector3D)

##### Declaration

```
double GetDistanceWithFOV(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | Another point |

##### Returns

| Type | Description |
| --- | --- |
| System.Double | Distance in meters |

#### IsInFrustum(BoundingBoxD)

Checks if specified bounding box is in actual bounding frustum IMPORTANT: If you observe bad result of this test, check how you transform your bounding box. Don't use BoundingBox.Transform. Instead transform box manualy and then create new box.

##### Declaration

```
bool IsInFrustum(BoundingBoxD boundingBox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox | Bounding box to check |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether specified bounding box is in actual bounding frustum |

#### IsInFrustum(ref BoundingBoxD)

Checks if specified bounding box is in actual bounding frustum IMPORTANT: If you observe bad result of this test, check how you transform your bounding box. Don't use BoundingBox.Transform. Instead transform box manualy and then create new box.

##### Declaration

```
bool IsInFrustum(ref BoundingBoxD boundingBox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox | Bounding box to check |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether specified bounding box is in actual bounding frustum |

#### IsInFrustum(ref BoundingSphereD)

Checks if specified bounding sphere is in actual bounding frustum IMPORTANT: If you observe bad result of this test, check how you transform your bounding sphere. Don't use BoundingSphere.Transform. Instead transform sphere center manualy and then create new sphere.
