##### Returns

Type

Description

System.Boolean

True if intersects

#### IMyEntity.EnableColorMaskForSubparts(Boolean)

Allows subparts have different color than their parent

##### Declaration

```
void IMyEntity.EnableColorMaskForSubparts(bool value)
```

##### Parameters

Type

Name

Description

System.Boolean

value

#### IMyEntity.FastCastShadowResolve

##### Declaration

```
bool IMyEntity.FastCastShadowResolve { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.GameLogic

Gets or sets game logic for object. If there is more than 1 game logic attached it should be wrapped into **MyCompositeGameLogicComponent**.

##### Declaration

```
MyEntityComponentBase IMyEntity.GameLogic { get; set; }
```

##### Returns

Type

Description

[MyEntityComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityComponentBase.html)

##### See Also

#### IMyEntity.GetChildren(List<IMyEntity>, Func<IMyEntity, Boolean>)

Gets children of entity. Child - entity, who's [Parent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Parent) is this entity

##### Declaration

```
void IMyEntity.GetChildren(List<IMyEntity> children, Func<IMyEntity, bool> collect)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\>

children

List, that would receive results

System.Func<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html), System.Boolean\>

collect

When returns true - child added to list

#### IMyEntity.GetDiffuseColor()

Gets render diffuse color

##### Declaration

```
Vector3 IMyEntity.GetDiffuseColor()
```

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

Diffuse color

#### IMyEntity.GetDistanceBetweenCameraAndBoundingSphere()

Distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. (in meters)

##### Declaration

```
float IMyEntity.GetDistanceBetweenCameraAndBoundingSphere()
```

##### Returns

Type

Description

System.Single

Distance in meters

#### IMyEntity.GetDistanceBetweenCameraAndPosition()

Distance from camera to position of entity.

##### Declaration

```
float IMyEntity.GetDistanceBetweenCameraAndPosition()
```

##### Returns

Type

Description

System.Single

Distance in meters

#### IMyEntity.GetFriendlyName()

Not used. Actually not a friendly name

##### Declaration

```
string IMyEntity.GetFriendlyName()
```

##### Returns

Type

Description

System.String

String.Empty or "MyVoxelMap"

#### IMyEntity.GetIntersectionWithLineAndBoundingSphere(ref LineD, Single)

Calculates intersection of line with any bounding sphere in this model instance. Center of the bounding sphere will be returned. It takes boundingSphereRadiusMultiplier argument which serves for extending the influence (radius) for interaction with line.

##### Declaration

```
Nullable<Vector3D> IMyEntity.GetIntersectionWithLineAndBoundingSphere(ref LineD line, float boundingSphereRadiusMultiplier)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

Line to check

System.Single

boundingSphereRadiusMultiplier

Bounding sphere radius would be multiplied by this value

##### Returns

Type

Description

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

Position of intersection if of line and bounding sphere

#### IMyEntity.GetIntersectionWithSphere(ref BoundingSphereD)

Return true if object intersects specified sphere.

##### Declaration

```
bool IMyEntity.GetIntersectionWithSphere(ref BoundingSphereD sphere)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

Sphere to check

##### Returns

Type

Description

System.Boolean

True if intersects

#### IMyEntity.GetInventory()

Simply get the MyInventoryBase component stored in this entity.

##### Declaration

```
IMyInventory IMyEntity.GetInventory()
```

##### Returns

Type

Description

[IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventory.html)

Null, or first inventory

#### IMyEntity.GetInventory(Int32)

Search for inventory component with matching index.

##### Declaration

```
IMyInventory IMyEntity.GetInventory(int index)
```

##### Parameters

Type

Name

Description

System.Int32

index

Index of inventory, starting from 0

##### Returns

Type

Description

[IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventory.html)

Null, or inventory at matching index

#### IMyEntity.GetLargestDistanceBetweenCameraAndBoundingSphere()

Largest distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. It's actually distance between camera and opposite side of the sphere

##### Declaration

```
float IMyEntity.GetLargestDistanceBetweenCameraAndBoundingSphere()
```

##### Returns

Type

Description

System.Single

Distance in meters

#### IMyEntity.GetObjectBuilder(Boolean)

Returns object builder - object representing block state, and allows restore it. Used in game save, or syncing over network.

##### Declaration

```
MyObjectBuilder_EntityBase IMyEntity.GetObjectBuilder(bool copy)
```

##### Parameters

Type

Name

Description

System.Boolean

copy

When true, [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Name) won't be saved. Copy true comes only from MyGridClipboard/MyFloatingObjectClipboard/MyVoxelClipboard
