---
title: "Interface IMyProjectileDetector"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyProjectileDetector.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyProjectileDetector"
---

# Interface IMyProjectileDetector | Space Engineers ModAPI

Describes projectile that have custom logic on handling bullets (mods interface)

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyProjectileDetector
```

### Properties

#### DetectorAABB

Gets AABB of the detector

##### Declaration

```
BoundingBoxD DetectorAABB { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | Detector AABB in world coordinates |

#### HitEntity

Gets entity which was hit for this detector. It's not used for any logic with data, just for reporting to projectile system, which entity was hit by the projectile.

##### Declaration

```
IMyEntity HitEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | Entity that projectile detector represents |

#### IsDetectorEnabled

Gets if detector is enabled

##### Declaration

```
bool IsDetectorEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetDetectorIntersectionWithLine(ref LineD, out Nullable<Vector3D>)

Gets intersection between line and detector

##### Declaration

```
bool GetDetectorIntersectionWithLine(ref LineD line, out Nullable<Vector3D> hit)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line | Line of the bullet |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | hit | World hit position |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Should return true if line intersects detector |