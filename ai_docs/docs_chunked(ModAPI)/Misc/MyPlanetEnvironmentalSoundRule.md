---
title: "Class MyPlanetEnvironmentalSoundRule"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPlanetEnvironmentalSoundRule.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyPlanetEnvironmentalSoundRule"
---

# Class MyPlanetEnvironmentalSoundRule | Space Engineers ModAPI

##### Inheritance

System.Object

MyPlanetEnvironmentalSoundRule

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class MyPlanetEnvironmentalSoundRule : ValueType
```

### Fields

#### EnvironmentSound

##### Declaration

```
public MyStringHash EnvironmentSound
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### Height

##### Declaration

```
public SerializableRange Height
```

##### Field Value

| Type | Description |
| --- | --- |
| [SerializableRange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.SerializableRange.html) |     |

#### Latitude

##### Declaration

```
public SymmetricSerializableRange Latitude
```

##### Field Value

| Type | Description |
| --- | --- |
| [SymmetricSerializableRange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.SymmetricSerializableRange.html) |     |

#### SunAngleFromZenith

##### Declaration

```
public SerializableRange SunAngleFromZenith
```

##### Field Value

| Type | Description |
| --- | --- |
| [SerializableRange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.SerializableRange.html) |     |

### Methods

#### Check(Single, Single, Single)

##### Declaration

```
public bool Check(float angleFromEquator, float height, float sunAngleFromZenith)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | angleFromEquator |     |
| System.Single | height |     |
| System.Single | sunAngleFromZenith |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |