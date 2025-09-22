##### Declaration

```
public event Action<MyEntity> OnTeleported
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### OnUpdateOnceBeforeNextFrame

##### Declaration

```
public event Action<MyEntity> OnUpdateOnceBeforeNextFrame
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### RemovedFromScene

##### Declaration

```
public event Action<MyEntity> RemovedFromScene
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

### Explicit Interface Implementations

#### IMyEntity.Closed

True if the block has been removed from the world.

##### Declaration

```
bool IMyEntity.Closed { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.DisplayName

Gets user friendly name of entity. May be null For block terminal name use [DisplayNameText](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html#VRage_Game_ModAPI_Ingame_IMyCubeBlock_DisplayNameText)

##### Declaration

```
string IMyEntity.DisplayName { get; }
```

##### Returns

Type

Description

System.String

#### IMyEntity.GetInventory()

Simply get the MyInventoryBase component stored in this entity.

##### Declaration

```
IMyInventory IMyEntity.GetInventory()
```

##### Returns

Type

Description

[IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html)

Inventory

#### IMyEntity.GetInventory(Int32)

Search for inventory component with maching index.

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

##### Returns

Type

Description

[IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html)

#### IMyEntity.GetPosition()

Gets position in world coordinates

##### Declaration

```
Vector3D IMyEntity.GetPosition()
```

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

Position

#### IMyEntity.HasInventory

Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventory() != null.

##### Declaration

```
bool IMyEntity.HasInventory { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.InventoryCount

Returns the count of the number of inventories this entity has.

##### Declaration

```
int IMyEntity.InventoryCount { get; }
```

##### Returns

Type

Description

System.Int32

#### IMyEntity.Name

##### Declaration

```
string IMyEntity.Name { get; }
```

##### Returns

Type

Description

System.String

#### IMyEntity.WorldAABB

Gets world axis-aligned bounding box

##### Declaration

```
BoundingBoxD IMyEntity.WorldAABB { get; }
```

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### IMyEntity.WorldAABBHr

Gets world axis-aligned bounding box

##### Declaration

```
BoundingBoxD IMyEntity.WorldAABBHr { get; }
```

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### IMyEntity.WorldMatrix

Gets world matrix of this entity

##### Declaration

```
MatrixD IMyEntity.WorldMatrix { get; }
```

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### IMyEntity.WorldVolume

Gets bounding sphere of this entity

##### Declaration

```
BoundingSphereD IMyEntity.WorldVolume { get; }
```

##### Returns

Type

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

#### IMyEntity.WorldVolumeHr

Gets bounding sphere of this entity

##### Declaration

```
BoundingSphereD IMyEntity.WorldVolumeHr { get; }
```

##### Returns

Type

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

#### IMyEntity.CastShadows

##### Declaration

```
bool IMyEntity.CastShadows { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.Close()

This method marks this entity for close which means, that Close will be called after all entities are updated

##### Declaration

#### IMyEntity.DebugAsyncLoading

Used for internal usage. Modders should not use it. Will be eventually removed

##### Declaration

```
bool IMyEntity.DebugAsyncLoading { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.Delete()

Performs real cleaning of entity. Should be called by game. Modders should prefer [Close()](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Close) method.

##### Declaration

#### IMyEntity.DisplayName

Gets or sets user friendly name of entity

##### Declaration

```
string IMyEntity.DisplayName { get; set; }
```

##### Returns

Type

Description

System.String

#### IMyEntity.DoOverlapSphereTest(Single, Vector3D)

Checks if intersects Works only with [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html)

##### Declaration

```
bool IMyEntity.DoOverlapSphereTest(float sphereRadius, Vector3D spherePos)
```

##### Parameters

Type

Name

Description

System.Single

sphereRadius

Radius of sphere

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

spherePos

World position

##### Returns

Type

Description

System.Boolean

True if intersects

#### IMyEntity.EnableColorMaskForSubparts(Boolean)

Allows subparts have different color than their parent
