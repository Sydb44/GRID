##### Declaration

```
public MyHierarchyComponent<MyEntity> Hierarchy { get; set; }
```

##### Property Value

Type

Description

[MyHierarchyComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyHierarchyComponent-1.html)<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### InScene

##### Declaration

```
public bool InScene { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### InvalidateOnMove

##### Declaration

```
public bool InvalidateOnMove { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### InventoryCount

Iterate through inventories and return their count.

##### Declaration

```
public int InventoryCount { get; }
```

##### Property Value

Type

Description

System.Int32

#### IsCCDForProjectiles

##### Declaration

```
public virtual bool IsCCDForProjectiles { get; }
```

##### Property Value

Type

Description

System.Boolean

#### IsPreview

##### Declaration

```
public bool IsPreview { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### IsReadyForReplication

##### Declaration

```
public bool IsReadyForReplication { get; }
```

##### Property Value

Type

Description

System.Boolean

#### IsReplicated

##### Declaration

```
public bool IsReplicated { get; }
```

##### Property Value

Type

Description

System.Boolean

#### IsVolumetric

##### Declaration

```
public virtual bool IsVolumetric { get; }
```

##### Property Value

Type

Description

System.Boolean

#### LastSnapshotFlags

##### Declaration

```
public MySnapshotFlags LastSnapshotFlags { get; set; }
```

##### Property Value

Type

Description

VRage.Game.Networking.MySnapshotFlags

#### LocationForHudMarker

##### Declaration

```
public virtual Vector3D LocationForHudMarker { get; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### MarkedForClose

##### Declaration

```
public bool MarkedForClose { get; protected set; }
```

##### Property Value

Type

Description

System.Boolean

#### MaxGlassDistSq

##### Declaration

```
public virtual float MaxGlassDistSq { get; }
```

##### Property Value

Type

Description

System.Single

#### Model

##### Declaration

```
public MyModel Model { get; }
```

##### Property Value

Type

Description

VRage.Game.Models.MyModel

#### ModelCollision

##### Declaration

```
public MyModel ModelCollision { get; }
```

##### Property Value

Type

Description

VRage.Game.Models.MyModel

#### Name

##### Declaration

```
public string Name { get; set; }
```

##### Property Value

Type

Description

System.String

#### NeedsUpdate

##### Declaration

```
public MyEntityUpdateEnum NeedsUpdate { get; set; }
```

##### Property Value

Type

Description

[MyEntityUpdateEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyEntityUpdateEnum.html)

#### NeedsWorldMatrix

##### Declaration

```
public bool NeedsWorldMatrix { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### Parent

Gets or sets the parent.

##### Declaration

```
public MyEntity Parent { get; }
```

##### Property Value

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

The parent.

#### Physics

##### Declaration

```
public MyPhysicsComponentBase Physics { get; set; }
```

##### Property Value

Type

Description

[MyPhysicsComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsComponentBase.html)

#### Pinned

##### Declaration

```
public bool Pinned { get; }
```

##### Property Value

Type

Description

System.Boolean

#### PositionComp

##### Declaration

```
public MyPositionComponentBase PositionComp { get; set; }
```

##### Property Value

Type

Description

[MyPositionComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPositionComponentBase.html)

#### Render

##### Declaration

```
public MyRenderComponentBase Render { get; set; }
```

##### Property Value

Type

Description

[MyRenderComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyRenderComponentBase.html)

#### Save

##### Declaration

```
public bool Save { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### StopPhysicsActivation

##### Declaration

```
public bool StopPhysicsActivation { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### Storage

##### Declaration

```
public MyModStorageComponentBase Storage { get; set; }
```

##### Property Value

Type

Description

[MyModStorageComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyModStorageComponentBase.html)

#### Subparts

##### Declaration

```
public Dictionary<string, MyEntitySubpart> Subparts { get; }
```

##### Property Value

Type

Description

System.Collections.Generic.Dictionary<System.String, [MyEntitySubpart](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntitySubpart.html)\>

#### SyncFlag

##### Declaration

```
public bool SyncFlag { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### SyncObject

##### Declaration

```
public MySyncComponentBase SyncObject { get; protected set; }
```

##### Property Value

Type

Description

[MySyncComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MySyncComponentBase.html)

#### UpdateDuration

##### Declaration

```
public virtual MyEntity.UpdateDurationType UpdateDuration { get; }
```

##### Property Value

Type

Description

[MyEntity.UpdateDurationType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.UpdateDurationType.html)

#### WorldMatrix

##### Declaration

```
public MatrixD WorldMatrix { get; set; }
```
