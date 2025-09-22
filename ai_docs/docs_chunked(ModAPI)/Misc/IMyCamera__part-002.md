| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox | Bounding box to check |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether specified bounding box is in actual bounding frustum |

#### IsInFrustum(ref BoundingSphereD)

Checks if specified bounding sphere is in actual bounding frustum IMPORTANT: If you observe bad result of this test, check how you transform your bounding sphere. Don't use BoundingSphere.Transform. Instead transform sphere center manualy and then create new sphere.

##### Declaration

```
bool IsInFrustum(ref BoundingSphereD boundingSphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | boundingSphere |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether specified bounding box is in actual bounding frustum |

#### WorldLineFromScreen(Vector2)

Gets normalized world space line from screen space coordinates.

##### Declaration

```
LineD WorldLineFromScreen(Vector2 screenCoords)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | screenCoords |     |

##### Returns

| Type | Description |
| --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | Gets normalized world space line |

#### WorldToScreen(ref Vector3D)

Gets screen coordinates of 3d world pos in 0 - 1 distance where 1.0 is screen width(for X) or height(for Y). WARNING: Y is from bottom to top.

##### Declaration

```
Vector3D WorldToScreen(ref Vector3D worldPos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPos | World position. |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | Screen coordinate in 0-1 distance. |