---
title: "Interface IHitInfo"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IHitInfo.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IHitInfo"
---

# Interface IHitInfo | Space Engineers ModAPI

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IHitInfo
```

### Properties

#### Fraction

How much of the ray cast distance was traveled before hitting something. Use this value to multiply your initial distance to get the distance to hit position in a cheaper way.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### HitEntity

The entity that was hit.

##### Declaration

```
IMyEntity HitEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### Normal

The direction vector of the hit surface.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Position

The position where the raycast hit.

##### Declaration

```
Vector3D Position { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |