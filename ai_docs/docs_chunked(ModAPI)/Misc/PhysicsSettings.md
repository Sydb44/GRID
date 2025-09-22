---
title: "Class PhysicsSettings"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.PhysicsSettings.html"
category: "Misc"
namespace: "VRage.ModAPI"
class: "PhysicsSettings"
---

# Class PhysicsSettings | Space Engineers ModAPI

Implements Physics Settings

##### Inheritance

System.Object

PhysicsSettings

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class PhysicsSettings : ValueType
```

### [](#fields)Fields

#### [](#VRage_ModAPI_PhysicsSettings_AngularDamping)AngularDamping

Gets or Sets the Angular Damping. SE default value is 0.1

##### Declaration

```
public float AngularDamping
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_ModAPI_PhysicsSettings_CollisionLayer)CollisionLayer

Collision layer. Makes your entity react on collisions with entities that having certain layers TargetDummyLayer = 6 BlockPlacementTestCollisionLayer = 7 MissileLayer = 8 NoVoxelCollisionLayer = 9 LightFloatingObjectCollisionLayer = 10 VoxelLod1CollisionLayer = 11 NotCollideWithStaticLayer = 12 StaticCollisionLayer = 13 CollideWithStaticLayer = 14 DefaultCollisionLayer = 15 DynamicDoubledCollisionLayer = 16 KinematicDoubledCollisionLayer = 17 CharacterCollisionLayer = 18 NoCollisionLayer = 19 DebrisCollisionLayer = 20 GravityPhantomLayer = 21 CharacterNetworkCollisionLayer = 22 FloatingObjectCollisionLayer = 23 ObjectDetectionCollisionLayer = 24 VirtualMassLayer = 25 CollectorCollisionLayer = 26 AmmoLayer = 27 VoxelCollisionLayer = 28 ExplosionRaycastLayer = 29 CollisionLayerWithoutCharacter = 30 RagdollCollisionLayer = 31

##### Declaration

```
public ushort CollisionLayer
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### [](#VRage_ModAPI_PhysicsSettings_DetectorColliderCallback)DetectorColliderCallback

If it is not null, then it would be call this callback each time entity Enters/Leaves it's collision. Also removes physical collision (Now all entities can go through it) CollisionCallback is called from parallel thread, and called once per HkBody. Grids can have more than 100 bodies. Try find best collision layer, to filter unneeded collisions and improve performance If you trying detect grids:

```
protected MyConcurrentHashSet<long> m_containedEntities = new MyConcurrentHashSet<long>();
var topEntity = entity.GetTopMostParent() as MyEntity;
if (m_containedEntities.Add(topEntity.EntityId))
{
    MyAPIGateway.Utilities.InvokeOnGameThread(() =>
    {
        //Called once in main thread
    });
}
```

##### Declaration

```
public Action<IMyEntity, bool> DetectorColliderCallback
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html), System.Boolean\> |     |

#### [](#VRage_ModAPI_PhysicsSettings_Entity)Entity

For modders: You can create your own entities with this code.

```
var entity = new MyEntity();          
entity.WorldMatrix = MatrixD.Identity;
entity.Init(new StringBuilder("Name"), "Models\\Cubes\\Large\\GeneratorLarge.mwm", null, null, "Models\\Cubes\\Large\\GeneratorLarge.mwm");
MyAPIGateway.Entities.AddEntity(entity);
```

##### Declaration

##### Field Value

#### [](#VRage_ModAPI_PhysicsSettings_IsPhantom)IsPhantom

Is mainly used, to detect if block can be placed at this position

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_ModAPI_PhysicsSettings_LinearDamping)LinearDamping

Gets or Sets the Linear Damping in meters per tick

##### Declaration

```
public float LinearDamping
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_ModAPI_PhysicsSettings_LocalCenter)LocalCenter

Gets or Sets the Center of physical shape

##### Declaration

```
public Vector3 LocalCenter
```

##### Field Value

#### [](#VRage_ModAPI_PhysicsSettings_Mass)Mass

Gets or Sets the mass of object

##### Declaration

```
public Nullable<ModAPIMass> Mass
```

##### Field Value

#### [](#VRage_ModAPI_PhysicsSettings_MaterialType)MaterialType

Gets or Sets From what material object is. Example: Rock,Metal,Ammo,Character,Wood,Thruster\_large,Thruster\_small,Missile

##### Declaration

```
public MyStringHash MaterialType
```

##### Field Value

#### [](#VRage_ModAPI_PhysicsSettings_RigidBodyFlags)RigidBodyFlags

Gets or Sets the Flags, defining behavioral features

##### Declaration

```
public RigidBodyFlag RigidBodyFlags
```

##### Field Value

#### [](#VRage_ModAPI_PhysicsSettings_WorldMatrix)WorldMatrix

Gets or Sets the World matrix of physical shape

##### Declaration

```
public MatrixD WorldMatrix
```

##### Field Value