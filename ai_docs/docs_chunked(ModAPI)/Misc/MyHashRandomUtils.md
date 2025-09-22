---
title: "Class MyHashRandomUtils"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyHashRandomUtils.html"
category: "Misc"
namespace: "VRage.Library.Utils"
class: "MyHashRandomUtils"
---

# Class MyHashRandomUtils | Space Engineers ModAPI

##### Inheritance

System.Object

MyHashRandomUtils

###### **Namespace**: [VRage.Library.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public static class MyHashRandomUtils : Object
```

### [](#methods)Methods

#### [](#VRage_Library_Utils_MyHashRandomUtils_CreateFloatFromMantissa_System_UInt32_)CreateFloatFromMantissa(UInt32)

Create a \[0, 1) float from it's mantissa.

##### Declaration

```
public static float CreateFloatFromMantissa(uint m)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | m   | Mantissa bits. |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Library_Utils_MyHashRandomUtils_JenkinsHash_System_UInt32_)JenkinsHash(UInt32)

##### Declaration

```
public static uint JenkinsHash(uint x)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | x   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### [](#VRage_Library_Utils_MyHashRandomUtils_TestHashSample)TestHashSample()

##### Declaration

```
public static void TestHashSample()
```

#### [](#VRage_Library_Utils_MyHashRandomUtils_UniformFloatFromSeed_System_Int32_)UniformFloatFromSeed(Int32)

Compute a float in the range \[0, 1) created from the the seed.

For uniformly distributed seeds this method will produce uniformly distributed values.

##### Declaration

```
public static float UniformFloatFromSeed(int seed)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | seed | Any integer to be used as a seed. The seed needs not be super uniform since it will be hashed. |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | A float in the range \[0, 1) |