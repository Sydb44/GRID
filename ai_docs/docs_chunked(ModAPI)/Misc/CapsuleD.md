---
title: "Class CapsuleD"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CapsuleD.html"
category: "Misc"
namespace: "VRageMath"
class: "CapsuleD"
---

# Class CapsuleD | Space Engineers ModAPI

##### Inheritance

System.Object

CapsuleD

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class CapsuleD : ValueType
```

### [](#constructors)Constructors

#### [](#VRageMath_CapsuleD__ctor_VRageMath_Vector3D_VRageMath_Vector3D_System_Single_)CapsuleD(Vector3D, Vector3D, Single)

##### Declaration

```
public CapsuleD(Vector3D p0, Vector3D p1, float radius)
```

##### Parameters

### [](#fields)Fields

#### [](#VRageMath_CapsuleD_P0)P0

##### Declaration

##### Field Value

#### [](#VRageMath_CapsuleD_P1)P1

##### Declaration

##### Field Value

#### [](#VRageMath_CapsuleD_Radius)Radius

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### [](#methods)Methods

#### [](#VRageMath_CapsuleD_Intersect_VRageMath_LineD_VRageMath_Vector3D__VRageMath_Vector3D__VRageMath_Vector3__VRageMath_Vector3__)Intersect(LineD, ref Vector3D, ref Vector3D, ref Vector3, ref Vector3)

##### Declaration

```
public bool Intersect(LineD line, ref Vector3D p1, ref Vector3D p2, ref Vector3 n1, ref Vector3 n2)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_CapsuleD_Intersect_VRageMath_RayD_VRageMath_Vector3D__VRageMath_Vector3D__VRageMath_Vector3__VRageMath_Vector3__)Intersect(RayD, ref Vector3D, ref Vector3D, ref Vector3, ref Vector3)

##### Declaration

```
public bool Intersect(RayD ray, ref Vector3D p1, ref Vector3D p2, ref Vector3 n1, ref Vector3 n2)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |