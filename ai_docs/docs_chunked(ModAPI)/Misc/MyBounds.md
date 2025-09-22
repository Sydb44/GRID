---
title: "Class MyBounds"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html"
category: "Misc"
namespace: "VRageMath"
class: "MyBounds"
---

# Class MyBounds | Space Engineers ModAPI

##### Inheritance

System.Object

MyBounds

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class MyBounds : ValueType
```

### Constructors

#### MyBounds(Single, Single, Single)

##### Declaration

```
public MyBounds(float min, float max, float def)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | min |     |
| System.Single | max |     |
| System.Single | def |     |

### Fields

#### Default

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Max

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Min

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### Clamp(Single)

##### Declaration

```
public float Clamp(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Normalize(Single)

Normalize value inside the bounds so that 0 is Min and 1 is Max.

##### Declaration

```
public float Normalize(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |