| --- | --- | --- |
| [MyCargoContainerInventoryBagEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCargoContainerInventoryBagEntity.html) | obj |     |
| System.Boolean | sync |     |

#### RequestSpawnCreative(MyObjectBuilder\_FloatingObject)

Players are allowed to spawn any object in creative

##### Declaration

```
public static void RequestSpawnCreative(MyObjectBuilder_FloatingObject obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_FloatingObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_FloatingObject.html) | obj |     |

#### Spawn(MyPhysicalItemDefinition, Vector3D, Vector3D, Vector3D, Int32, Single)

##### Declaration

```
public static void Spawn(MyPhysicalItemDefinition itemDefinition, Vector3D translation, Vector3D forward, Vector3D up, int amount = 1, float scale = 1F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPhysicalItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalItemDefinition.html) | itemDefinition |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | translation |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | forward |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | up  |     |
| System.Int32 | amount |     |
| System.Single | scale |     |

#### Spawn(MyPhysicalInventoryItem, BoundingSphereD, MyPhysicsComponentBase, MyVoxelMaterialDefinition, Action<MyEntity>)

##### Declaration

```
public static void Spawn(MyPhysicalInventoryItem item, BoundingSphereD sphere, MyPhysicsComponentBase motionInheritedFrom, MyVoxelMaterialDefinition voxelMaterial, Action<MyEntity> OnDone)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html) | item |     |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| [MyPhysicsComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsComponentBase.html) | motionInheritedFrom |     |
| [MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html) | voxelMaterial |     |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | OnDone |     |

#### Spawn(MyPhysicalInventoryItem, MatrixD, MyPhysicsComponentBase, Action<MyEntity>)

##### Declaration

```
public static void Spawn(MyPhysicalInventoryItem item, MatrixD worldMatrix, MyPhysicsComponentBase motionInheritedFrom, Action<MyEntity> completionCallback)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html) | item |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [MyPhysicsComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsComponentBase.html) | motionInheritedFrom |     |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | completionCallback |     |

#### Spawn(MyPhysicalInventoryItem, Vector3D, Vector3D, Vector3D, MyPhysicsComponentBase, Action<MyEntity>)

##### Declaration

```
public static void Spawn(MyPhysicalInventoryItem item, Vector3D position, Vector3D forward, Vector3D up, MyPhysicsComponentBase motionInheritedFrom = null, Action<MyEntity> completionCallback = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html) | item |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | forward |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | up  |     |
| [MyPhysicsComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsComponentBase.html) | motionInheritedFrom |     |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | completionCallback |     |

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides