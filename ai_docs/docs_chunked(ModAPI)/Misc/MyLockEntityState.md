---
title: "Class MyLockEntityState"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyLockEntityState.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "MyLockEntityState"
---

# Class MyLockEntityState | Space Engineers ModAPI

Represents camera locked entity

##### Inheritance

System.Object

MyLockEntityState

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyLockEntityState : ValueType
```

### Fields

#### LastKnownPosition

Last position of tracked entity

##### Declaration

```
public Vector3D LastKnownPosition
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### LocalDistance

##### Declaration

```
public double LocalDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### LocalMatrix

Local matrix

##### Declaration

```
public MatrixD LocalMatrix
```

##### Field Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### LocalVector

Difference between camera position and character head matrix translation or entity world volume center

##### Declaration

```
public Vector3D LocalVector
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### LockEntityDisplayName

Name of locked entity

##### Declaration

```
public string LockEntityDisplayName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### LockEntityID

EntityId of locked entity

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |