---
title: "Class MyShipVelocities"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyShipVelocities.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "MyShipVelocities"
---

# Class MyShipVelocities | Space Engineers ModAPI

Describes ship velocities

##### Inheritance

System.Object

MyShipVelocities

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class MyShipVelocities : ValueType
```

### Constructors

#### MyShipVelocities(Vector3D, Vector3D)

Implements MyShipVelocities constructor

##### Declaration

```
public MyShipVelocities(Vector3D linearVelocity, Vector3D angularVelocity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | linearVelocity |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | angularVelocity |     |

### Fields

#### AngularVelocity

Gets the ship's angular velocity (rotation).

##### Declaration

```
public readonly Vector3D AngularVelocity
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### LinearVelocity

Gets the ship's linear velocity (motion).

##### Declaration

```
public readonly Vector3D LinearVelocity
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |