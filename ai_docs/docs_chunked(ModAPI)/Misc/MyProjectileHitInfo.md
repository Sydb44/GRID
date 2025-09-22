---
title: "Class MyProjectileHitInfo"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileHitInfo.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "MyProjectileHitInfo"
---

# Class MyProjectileHitInfo | Space Engineers ModAPI

Describes information projectile about projectile hit. (mods interface) You can change values

##### Inheritance

System.Object

MyProjectileHitInfo

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public class MyProjectileHitInfo : Object
```

### Constructors

#### MyProjectileHitInfo()

##### Declaration

```
public MyProjectileHitInfo()
```

### Fields

#### AddDecals

When it is false, decals wont be added (default = true)

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AddHitIndicator

When it is false, player wont see hit indicator

##### Declaration

```
public bool AddHitIndicator
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AddHitParticles

When it is false, player wont see hit particles (default = true)

##### Declaration

```
public bool AddHitParticles
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AddSZNotification

When it is false, player wont see safe zone notification (default = true)

##### Declaration

```
public bool AddSZNotification
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Damage

Damage that would

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### HitEntity

Entity that was hitted by projectile

##### Declaration

```
public IMyEntity HitEntity
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### HitMaterial

Material that hitted by projectile

##### Declaration

```
public MyStringHash HitMaterial
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### HitNormal

Hit normal

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### HitPosition

World coordinates of projectile hit

##### Declaration

```
public Vector3D HitPosition
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### HitShapeKey

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### HitVoxelMaterial

Voxel Material that hit by projectile

##### Declaration

```
public MyStringHash HitVoxelMaterial
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### Impulse

Impulse, that would be applied to [HitEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileHitInfo.html#Sandbox_ModAPI_MyProjectileHitInfo_HitEntity)

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### PlayHitSound

When it is false, player wont hear hit sound (default = true)

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Velocity

Velocity of projectile before hit

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Methods

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |