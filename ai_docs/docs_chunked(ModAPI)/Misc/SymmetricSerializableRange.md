---
title: "Class SymmetricSerializableRange"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.SymmetricSerializableRange.html"
category: "Misc"
namespace: "VRageMath"
class: "SymmetricSerializableRange"
---

# Class SymmetricSerializableRange | Space Engineers ModAPI

##### Inheritance

System.Object

SymmetricSerializableRange

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class SymmetricSerializableRange : ValueType
```

### Constructors

#### SymmetricSerializableRange(Single, Single, Boolean)

##### Declaration

```
public SymmetricSerializableRange(float min, float max, bool mirror = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | min |     |
| System.Single | max |     |
| System.Boolean | mirror |     |

### Fields

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

### Properties

#### Mirror

##### Declaration

```
public bool Mirror { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### ConvertToCosine()

##### Declaration

```
public SymmetricSerializableRange ConvertToCosine()
```

##### Returns

| Type | Description |
| --- | --- |
| [SymmetricSerializableRange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.SymmetricSerializableRange.html) |     |

#### ConvertToCosineLongitude()

##### Declaration

```
public SymmetricSerializableRange ConvertToCosineLongitude()
```

##### Returns

| Type | Description |
| --- | --- |
| [SymmetricSerializableRange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.SymmetricSerializableRange.html) |     |

#### ConvertToSine()

##### Declaration

```
public SymmetricSerializableRange ConvertToSine()
```

##### Returns

| Type | Description |
| --- | --- |
| [SymmetricSerializableRange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.SymmetricSerializableRange.html) |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### ToStringAcos()

##### Declaration

```
public string ToStringAcos()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### ToStringAsin()

##### Declaration

```
public string ToStringAsin()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### ValueBetween(Single)

##### Declaration

```
public bool ValueBetween(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |