---
title: "Class ModAPIMass"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.ModAPIMass.html"
category: "Misc"
namespace: "VRage.ModAPI"
class: "ModAPIMass"
---

# Class ModAPIMass | Space Engineers ModAPI

ModAPI struct, that is available for modders. Copy of Havok.HkMassProperties. Created with IMyPhysics.CreateMassCombined, IMyPhysics.CreateMassForBox, IMyPhysics.CreateMassForCapsule, IMyPhysics.CreateMassForCylinder, IMyPhysics.CreateMassForSphere.

##### Inheritance

System.Object

ModAPIMass

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class ModAPIMass : ValueType
```

### Constructors

#### ModAPIMass(Single, Single, Vector3, Matrix)

##### Declaration

```
public ModAPIMass(float volume, float mass, Vector3 centerOfMass, Matrix inertiaTensor)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | volume |     |
| System.Single | mass |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | centerOfMass |     |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | inertiaTensor |     |

### Fields

#### CenterOfMass

Center of mass for physical shape (CoM)

##### Declaration

```
public Vector3 CenterOfMass
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### InertiaTensor

Intertia tensor for physical shape

##### Declaration

```
public Matrix InertiaTensor
```

##### Field Value

| Type | Description |
| --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) |     |

#### Mass

Mass of physical shape

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Volume

Volume of physical shape

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### FromHkMass(HkMassProperties)

##### Declaration

```
public static ModAPIMass FromHkMass(HkMassProperties mass)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Havok.HkMassProperties | mass |     |

##### Returns

| Type | Description |
| --- | --- |
| [ModAPIMass](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.ModAPIMass.html) |     |