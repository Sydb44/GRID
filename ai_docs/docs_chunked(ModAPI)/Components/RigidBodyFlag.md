---
title: "Class RigidBodyFlag"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "RigidBodyFlag"
---

# Class RigidBodyFlag | Space Engineers ModAPI

Physical shape settings

##### Inheritance

System.Object

RigidBodyFlag

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class RigidBodyFlag : Enum
```

### Fields

#### RBF\_BULLET

Used for fast moving objects Changing: MotionType = HkMotionType.Dynamic; QualityType = HkCollidableQualityType.Bullet;

##### Declaration

```
public const RigidBodyFlag RBF_BULLET
```

##### Field Value

| Type | Description |
| --- | --- |
| [RigidBodyFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html) |     |

#### RBF\_DEBRIS

Used for low quality physics Changing: MotionType = HkMotionType.Dynamic; QualityType = HkCollidableQualityType.Debris; SolverDeactivation = HkSolverDeactivation.Max;

##### Declaration

```
public const RigidBodyFlag RBF_DEBRIS
```

##### Field Value

| Type | Description |
| --- | --- |
| [RigidBodyFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html) |     |

#### RBF\_DEFAULT

Default flag

##### Declaration

```
public const RigidBodyFlag RBF_DEFAULT
```

##### Field Value

| Type | Description |
| --- | --- |
| [RigidBodyFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html) |     |

#### RBF\_DISABLE\_COLLISION\_RESPONSE

Rigid body has no collision response. Entities marked with this flag would not update position after Havok physics update. However you still can get position from Havok with code `Physics.GetWorldMatrix` Changing: MotionType = HkMotionType.Fixed; QualityType = HkCollidableQualityType.Fixed;

##### Declaration

```
public const RigidBodyFlag RBF_DISABLE_COLLISION_RESPONSE
```

##### Field Value

| Type | Description |
| --- | --- |
| [RigidBodyFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html) |     |

#### RBF\_DOUBLED\_KINEMATIC

Used for moving objects with high quality of simulation Changing: MotionType = HkMotionType.Dynamic; QualityType = HkCollidableQualityType.Moving;

##### Declaration

```
public const RigidBodyFlag RBF_DOUBLED_KINEMATIC
```

##### Field Value

| Type | Description |
| --- | --- |
| [RigidBodyFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html) |     |

#### RBF\_KEYFRAMED\_REPORTING

Changing: MotionType = HkMotionType.Keyframed; QualityType = HkCollidableQualityType.KeyframedReporting;

##### Declaration

```
public const RigidBodyFlag RBF_KEYFRAMED_REPORTING
```

##### Field Value

| Type | Description |
| --- | --- |
| [RigidBodyFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html) |     |

#### RBF\_KINEMATIC

Rigid body is kinematic (has to be updated (matrix) per frame, velocity etc is then computed..) Changing: MotionType = HkMotionType.Keyframed; QualityType = HkCollidableQualityType.Keyframed;

##### Declaration

```
public const RigidBodyFlag RBF_KINEMATIC
```

##### Field Value

| Type | Description |
| --- | --- |
| [RigidBodyFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html) |     |

#### RBF\_NO\_POSITION\_UPDATES

Don't update entity position from havok after simulation

##### Declaration

```
public const RigidBodyFlag RBF_NO_POSITION_UPDATES
```

##### Field Value

| Type | Description |
| --- | --- |
| [RigidBodyFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html) |     |

#### RBF\_STATIC

Rigid body is static, and colliding with it, won't move it (in Havok and SE worlds) Changing: MotionType = HkMotionType.Fixed; QualityType = HkCollidableQualityType.Fixed;

##### Declaration

```
public const RigidBodyFlag RBF_STATIC
```

##### Field Value

| Type | Description |
| --- | --- |
| [RigidBodyFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html) |     |

#### RBF\_UNLOCKED\_SPEEDS

Making maximum Velocity of entity to x10 of Large/Small ShipMaxLinearVelocity. Used for simulation of very fast moving objects

##### Declaration

```
public const RigidBodyFlag RBF_UNLOCKED_SPEEDS
```

##### Field Value

| Type | Description |
| --- | --- |
| [RigidBodyFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html) |     |

#### value\_\_

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |