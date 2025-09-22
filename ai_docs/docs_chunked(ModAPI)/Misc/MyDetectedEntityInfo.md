---
title: "Class MyDetectedEntityInfo"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityInfo.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "MyDetectedEntityInfo"
---

# Class MyDetectedEntityInfo | Space Engineers ModAPI

Describes detected entity info

##### Inheritance

System.Object

MyDetectedEntityInfo

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class MyDetectedEntityInfo : ValueType
```

### Constructors

#### MyDetectedEntityInfo(Int64, String, MyDetectedEntityType, Nullable<Vector3D>, MatrixD, Vector3, MyRelationsBetweenPlayerAndBlock, BoundingBoxD, Int64)

Implements MyDetectedEntityInfo constructor

##### Declaration

```
public MyDetectedEntityInfo(long entityId, string name, MyDetectedEntityType type, Nullable<Vector3D> hitPosition, MatrixD orientation, Vector3 velocity, MyRelationsBetweenPlayerAndBlock relationship, BoundingBoxD boundingBox, long timeStamp)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId | entity id |
| System.String | name | name |
| [MyDetectedEntityType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityType.html) | type | type |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | hitPosition | hit position |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | orientation | orientation |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | velocity | velocity |
| [MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html) | relationship | relationship |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox | bounding box |
| System.Int64 | timeStamp | time stamp |

### Fields

#### BoundingBox

The entity's world-aligned bounding box

##### Declaration

```
public readonly BoundingBoxD BoundingBox
```

##### Field Value

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### EntityId

The entity's EntityId

##### Declaration

```
public readonly long EntityId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### HitPosition

Position where the raycast hit the entity. (can be null if the sensor didn't use a raycast)

##### Declaration

```
public readonly Nullable<Vector3D> HitPosition
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### Name

The entity's display name if it is friendly, or a generic descriptor if it is not

##### Declaration

```
public readonly string Name
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Orientation

The entity's absolute orientation at the time it was detected

##### Declaration

```
public readonly MatrixD Orientation
```

##### Field Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### Relationship

Relationship between the entity and the owner of the sensor

##### Declaration

```
public readonly MyRelationsBetweenPlayerAndBlock Relationship
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html) |     |

#### TimeStamp

Time when the entity was detected. This field counts milliseconds, compensated for simspeed

##### Declaration

```
public readonly long TimeStamp
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### Type

Enum describing the type of entity

##### Declaration

```
public readonly MyDetectedEntityType Type
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDetectedEntityType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityType.html) |     |

#### Velocity

The entity's absolute velocity at the time it was detected

##### Declaration

```
public readonly Vector3 Velocity
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

### Properties

#### Position

The entity's position (center of the Bounding Box)

##### Declaration

```
public Vector3D Position { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Methods

#### IsEmpty()

Determines if this structure is empty; meaning it does not contain any meaningful data

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |