---
title: "Interface IMyVoxelMap"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelMap.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyVoxelMap"
---

# Interface IMyVoxelMap | Space Engineers ModAPI

##### Inherited Members

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyVoxelMap : IMyVoxelBase, IMyEntity, IMyEntity
```

### Methods

#### ClampVoxelCoord(ref Vector3I)

##### Declaration

```
void ClampVoxelCoord(ref Vector3I voxelCoord)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | voxelCoord |     |

#### Close()

##### Declaration

#### DoOverlapSphereTest(Single, Vector3D)

##### Declaration

```
bool DoOverlapSphereTest(float sphereRadius, Vector3D spherePos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | sphereRadius |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | spherePos |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetIntersectionWithSphere(ref BoundingSphereD)

##### Declaration

```
bool GetIntersectionWithSphere(ref BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetObjectBuilder(Boolean)

##### Declaration

```
MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

#### GetVoxelContentInBoundingBox(BoundingBoxD, out Single)

##### Declaration

```
float GetVoxelContentInBoundingBox(BoundingBoxD worldAabb, out float cellCount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | worldAabb |     |
| System.Single | cellCount |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetVoxelCoordinateFromMeters(Vector3D)

##### Declaration

```
Vector3I GetVoxelCoordinateFromMeters(Vector3D pos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
void Init(MyObjectBuilder_EntityBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | builder |     |