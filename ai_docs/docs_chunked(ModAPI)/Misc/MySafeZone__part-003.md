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

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsEmpty()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsEntityInsideAlone(Int64)

##### Declaration

```
public bool IsEntityInsideAlone(long entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OnAddedToScene(Object)

##### Declaration

```
public override void OnAddedToScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

#### OnRemovedFromScene(Object)

##### Declaration

```
public override void OnRemovedFromScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

#### RecreatePhysics(Boolean, Boolean)

When physics are recreated (shape / size), this should be triggered so entities would be re-added

##### Declaration

```
public void RecreatePhysics(bool insertEntities = true, bool triggerNotification = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | insertEntities | Should be true |
| System.Boolean | triggerNotification | Does nothing, kept for Mods |

#### RefreshGraphics()

##### Declaration

```
public void RefreshGraphics()
```

#### UpdateBeforeSimulation()

##### Declaration

```
public override void UpdateBeforeSimulation()
```

##### Overrides

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

### Implements

### Extension Methods