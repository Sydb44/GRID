##### Declaration

```
public Vector3 Size { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

### Methods

#### AddContainedToList()

##### Declaration

```
public void AddContainedToList()
```

#### AddShape(List<MyOrientedBoundingBoxD>, List<BoundingSphereD>)

##### Declaration

```
public void AddShape(List<MyOrientedBoundingBoxD> safeZonesObb, List<BoundingSphereD> safeZonesSpheres)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html)\> | safeZonesObb |     |
| System.Collections.Generic.List<[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)\> | safeZonesSpheres |     |

#### CheckAdminIgnoreSafezones(UInt64)

##### Declaration

```
public static bool CheckAdminIgnoreSafezones(ulong id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Closing()

##### Declaration

```
protected override void Closing()
```

##### Overrides

#### Contains(BoundingBoxD)

##### Declaration

```
public bool Contains(BoundingBoxD aabb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Contains(BoundingSphereD, ContainmentType)

##### Declaration

```
public bool Contains(BoundingSphereD boundingSphere, ContainmentType containmentType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | boundingSphere |     |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | containmentType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Contains(Vector3D)

##### Declaration

```
public bool Contains(Vector3D point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetDetectorIntersectionWithLine(ref LineD, out Nullable<Vector3D>)

##### Declaration

```
public bool GetDetectorIntersectionWithLine(ref LineD line, out Nullable<Vector3D> hit)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line |     |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | hit |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetIntersectionWithLine(ref LineD, out Nullable<Vector3D>, Boolean, IntersectionFlags)

##### Declaration

```
public override bool GetIntersectionWithLine(ref LineD line, out Nullable<Vector3D> v, bool useCollisionModel = true, IntersectionFlags flags)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line |     |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | v   |     |
| System.Boolean | useCollisionModel |     |
| [IntersectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IntersectionFlags.html) | flags |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### GetObjectBuilder(Boolean)

##### Declaration

```
public override MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

##### Overrides

#### Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
public override void Init(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |

##### Overrides

#### IsActionAllowed(MyEntity, MySafeZoneAction, Int64)

##### Declaration

```
public bool IsActionAllowed(MyEntity entity, MySafeZoneAction action, long sourceEntityId = 0L)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| VRage.Game.ObjectBuilders.Components.MySafeZoneAction | action |     |
| System.Int64 | sourceEntityId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsActionAllowed(MySafeZoneAction, Int64, Nullable<BoundingBoxD>, Nullable<BoundingSphereD>, Nullable<Vector3D>)

##### Declaration

```
public bool IsActionAllowed(MySafeZoneAction action, long sourceEntityId, Nullable<BoundingBoxD> aabb = null, Nullable<BoundingSphereD> boundingSphere = null, Nullable<Vector3D> point = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.ObjectBuilders.Components.MySafeZoneAction | action |     |
| System.Int64 | sourceEntityId |     |
| System.Nullable<[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)\> | aabb |     |
| System.Nullable<[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)\> | boundingSphere |     |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | point |     |
