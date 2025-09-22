---
title: "Class MyLibraryUtils"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyLibraryUtils.html"
category: "Misc"
namespace: "VRage.Library.Utils"
class: "MyLibraryUtils"
---

# Class MyLibraryUtils | Space Engineers ModAPI

##### Inheritance

System.Object

MyLibraryUtils

###### **Namespace**: [VRage.Library.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyLibraryUtils : Object
```

### Constructors

#### MyLibraryUtils()

##### Declaration

### Methods

#### AssertBlittable<T>()

##### Declaration

```
public static void AssertBlittable<T>()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### DenormalizeFloat(UInt32, Single, Single, Int32)

Denormalizes uint with specified number of bits into uniform-space float within min/max. This does not preserve 0 when min = -max

##### Declaration

```
public static float DenormalizeFloat(uint value, float min, float max, int bits)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | value |     |
| System.Single | min |     |
| System.Single | max |     |
| System.Int32 | bits |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### DenormalizeFloatCenter(UInt32, Single, Single, Int32)

Denormalizes uint with specified number of bits into uniform-space float within min/max. This preserves 0 when min = -max

##### Declaration

```
public static float DenormalizeFloatCenter(uint value, float min, float max, int bits)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | value |     |
| System.Single | min |     |
| System.Single | max |     |
| System.Int32 | bits |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetDivisionCeil(Int32, Int32)

##### Declaration

```
public static int GetDivisionCeil(int num, int div)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | num |     |
| System.Int32 | div |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetDivisionCeil(Int64, Int64)

##### Declaration

```
public static long GetDivisionCeil(long num, long div)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | num |     |
| System.Int64 | div |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### NormalizeFloat(Single, Single, Single, Int32)

Normalizes uniform-spaced float within min/max into uint with specified number of bits. This does not preserve 0 when min = -max

##### Declaration

```
public static uint NormalizeFloat(float value, float min, float max, int bits)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value |     |
| System.Single | min |     |
| System.Single | max |     |
| System.Int32 | bits |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### NormalizeFloatCenter(Single, Single, Single, Int32)

Normalizes uniform-spaced float within min/max into uint with specified number of bits. This preserves 0 when min = -max

##### Declaration

```
public static uint NormalizeFloatCenter(float value, float min, float max, int bits)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value |     |
| System.Single | min |     |
| System.Single | max |     |
| System.Int32 | bits |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### ThrowNonBlittable<T>()

##### Declaration

```
public static void ThrowNonBlittable<T>()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |