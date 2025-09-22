---
title: "Interface IMyVoxelBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html"
category: "Misc"
namespace: "VRage.ModAPI"
class: "IMyVoxelBase"
---

# Interface IMyVoxelBase | Space Engineers ModAPI

Describes

##### Inherited Members

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyVoxelBase : IMyEntity, IMyEntity
```

### Properties

#### PositionLeftBottomCorner

##### Declaration

```
Vector3D PositionLeftBottomCorner { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Storage

##### Declaration

```
IMyStorage Storage { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyStorage](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyStorage.html) |     |

#### StorageName

##### Declaration

```
string StorageName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### IsBoxIntersectingBoundingBoxOfThisVoxelMap(ref BoundingBoxD)

##### Declaration

```
bool IsBoxIntersectingBoundingBoxOfThisVoxelMap(ref BoundingBoxD boundingBox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |