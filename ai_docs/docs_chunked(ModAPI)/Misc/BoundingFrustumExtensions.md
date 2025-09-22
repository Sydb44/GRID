---
title: "Class BoundingFrustumExtensions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumExtensions.html"
category: "Misc"
namespace: "VRageMath"
class: "BoundingFrustumExtensions"
---

# Class BoundingFrustumExtensions | Space Engineers ModAPI

##### Inheritance

System.Object

BoundingFrustumExtensions

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public static class BoundingFrustumExtensions : Object
```

### Methods

#### ToBoundingSphere(BoundingFrustum, Vector3\[\])

Creates bounding sphere from bounding frustum. Implementation taken from XNA source, replace IEnumerable with array

##### Declaration

```
public static BoundingSphere ToBoundingSphere(this BoundingFrustum frustum, Vector3[] corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum | The bounding frustum. |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] | corners | Temporary memory to save corner when getting from frustum. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | BoundingSphere |