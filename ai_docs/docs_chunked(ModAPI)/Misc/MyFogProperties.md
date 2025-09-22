---
title: "Class MyFogProperties"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFogProperties.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyFogProperties"
---

# Class MyFogProperties | Space Engineers ModAPI

##### Inheritance

System.Object

MyFogProperties

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyFogProperties : ValueType
```

### Fields

#### Default

##### Declaration

```
[StructDefault]
public static readonly MyFogProperties Default
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyFogProperties](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFogProperties.html) |     |

#### FogAtmo

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FogColor

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### FogDensity

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FogMultiplier

##### Declaration

```
public float FogMultiplier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FogSkybox

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### Equals(Object)

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Lerp(ref MyFogProperties, Single)

##### Declaration

```
public MyFogProperties Lerp(ref MyFogProperties target, float ratio)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyFogProperties](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFogProperties.html) | target |     |
| System.Single | ratio |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyFogProperties](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFogProperties.html) |     |