---
title: "Class MyGridExplosion"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyGridExplosion.html"
category: "Misc"
namespace: "Sandbox.Game"
class: "MyGridExplosion"
---

# Class MyGridExplosion | Space Engineers ModAPI

This class is responsible for calculating damage from explosions It works by recursively raycasting from the point it needs to calculate to the explosion center. It does two types of raycast, 3D DDA raycasts for traversing grids (ships, stations) and Havok raycasts for traversing space between grids. For each block, it builds a stack of blocks that are between it and the explosion center and then calculates the damage for all blocks in this stack. It early exits if it encounters a block that was already calculated.

##### Inheritance

System.Object

MyGridExplosion

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyGridExplosion : Object
```

### Constructors

#### MyGridExplosion()

##### Declaration

### Fields

#### AffectedCubeBlocks

##### Declaration

```
public readonly HashSet<MySlimBlock> AffectedCubeBlocks
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<Sandbox.Game.Entities.Cube.MySlimBlock\> |     |

#### AffectedCubeGrids

##### Declaration

```
public readonly HashSet<MyCubeGrid> AffectedCubeGrids
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\> |     |

### Properties

#### Damage

##### Declaration

```
public float Damage { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DamagedBlocks

##### Declaration

```
public Dictionary<MySlimBlock, float> DamagedBlocks { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<Sandbox.Game.Entities.Cube.MySlimBlock, System.Single\> |     |

#### DamageRemaining

##### Declaration

```
public Dictionary<MySlimBlock, MyGridExplosion.MyRaycastDamageInfo> DamageRemaining { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<Sandbox.Game.Entities.Cube.MySlimBlock, [MyGridExplosion.MyRaycastDamageInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyGridExplosion.MyRaycastDamageInfo.html)\> |     |

#### Sphere

##### Declaration

```
public BoundingSphereD Sphere { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) |     |

### Methods

#### Clear()

##### Declaration

#### ComputeDamagedBlocks()

Computes damage for all blocks assigned in constructor

##### Declaration

```
public void ComputeDamagedBlocks()
```

#### ComputeDamageForEntity(Vector3D)

Used to calculate damage for entities that are not grids Can be called even if ComputeDamagedBlocks was not called before, but it doesn't do any caching

##### Declaration

```
public MyGridExplosion.MyRaycastDamageInfo ComputeDamageForEntity(Vector3D worldPosition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPosition | World position from where the cast starts (usually the entity position) |

##### Returns

| Type | Description |
| --- | --- |
| [MyGridExplosion.MyRaycastDamageInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyGridExplosion.MyRaycastDamageInfo.html) |     |

#### Init(BoundingSphereD, Single)

##### Declaration

```
public void Init(BoundingSphereD explosion, float explosionDamage)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | explosion |     |
| System.Single | explosionDamage |     |