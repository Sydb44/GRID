Gets SyncObject used for synchronizing data over network with **VRage.Sync.Sync**

##### Declaration

```
MySyncComponentBase SyncObject { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MySyncComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MySyncComponentBase.html) |     |

#### Transparent

Gets or sets [Transparency](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyRenderComponentBase.html#VRage_Game_Components_MyRenderComponentBase_Transparency). When setting true entity would be 25% transparent

##### Declaration

```
bool Transparent { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Visible

##### Declaration

```
bool Visible { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### WorldMatrix

Gets or sets world matrix.

##### Declaration

```
MatrixD WorldMatrix { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

##### See Also

#### WorldMatrixInvScaled

##### Declaration

```
MatrixD WorldMatrixInvScaled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | Matrix |

#### WorldMatrixNormalizedInv

##### Declaration

```
MatrixD WorldMatrixNormalizedInv { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | Matrix |

### Methods

#### AddToGamePruningStructure()

##### Declaration

```
void AddToGamePruningStructure()
```

#### BeforeSave()

Called before method GetObjectBuilder, when saving sector

##### Declaration

#### Close()

This method marks this entity for close which means, that Close will be called after all entities are updated

##### Declaration

#### DebugDraw()

Calls debug draw of entity

##### Declaration

#### DebugDrawInvalidTriangles()

Calls special debug draw, that highlighting invalid triangles in model

##### Declaration

```
void DebugDrawInvalidTriangles()
```

#### Delete()

Performs real cleaning of entity. Should be called by game. Modders should prefer [Close()](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Close) method.

##### Declaration

#### DoOverlapSphereTest(Single, Vector3D)

Checks if intersects Works only with [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html)

##### Declaration

```
bool DoOverlapSphereTest(float sphereRadius, Vector3D spherePos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | sphereRadius | Radius of sphere |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | spherePos | World position |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if intersects |

#### EnableColorMaskForSubparts(Boolean)

Allows subparts have different color than their parent

##### Declaration

```
void EnableColorMaskForSubparts(bool enable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enable |     |

#### GetChildren(List<IMyEntity>, Func<IMyEntity, Boolean>)

Gets children of entity. Child - entity, who's [Parent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Parent) is this entity

##### Declaration

```
void GetChildren(List<IMyEntity> children, Func<IMyEntity, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> | children | List, that would receive results |
| System.Func<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html), System.Boolean\> | collect | When returns true - child added to list |

#### GetDiffuseColor()

Gets render diffuse color

##### Declaration

```
Vector3 GetDiffuseColor()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | Diffuse color |

#### GetDistanceBetweenCameraAndBoundingSphere()

Distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. (in meters)

##### Declaration

```
float GetDistanceBetweenCameraAndBoundingSphere()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Distance in meters |

#### GetDistanceBetweenCameraAndPosition()

Distance from camera to position of entity.

##### Declaration

```
float GetDistanceBetweenCameraAndPosition()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Distance in meters |

#### GetFriendlyName()

Not used. Actually not a friendly name

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.String | String.Empty or "MyVoxelMap" |

#### GetIntersectionWithAABB(ref BoundingBoxD)

Return true if object intersects specified bounding box.

##### Declaration

```
bool GetIntersectionWithAABB(ref BoundingBoxD aabb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb | Bounding box to check |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if intersects |

#### GetIntersectionWithLine(ref LineD, out Nullable<MyIntersectionResultLineTriangleEx>, IntersectionFlags)

Get intersection of model with provided line

##### Declaration

```
bool GetIntersectionWithLine(ref LineD line, out Nullable<MyIntersectionResultLineTriangleEx> tri, IntersectionFlags flags)
```
