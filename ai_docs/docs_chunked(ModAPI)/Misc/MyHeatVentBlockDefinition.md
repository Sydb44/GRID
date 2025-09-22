---
title: "Class MyHeatVentBlockDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyHeatVentBlockDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyHeatVentBlockDefinition"
---

# Class MyHeatVentBlockDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyHeatVentBlockDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyHeatVentBlockDefinition : MyFunctionalBlockDefinition
```

### Constructors

#### MyHeatVentBlockDefinition()

##### Declaration

```
public MyHeatVentBlockDefinition()
```

### Fields

#### ColorMaximalPower

##### Declaration

```
public ColorDefinitionRGBA ColorMaximalPower
```

##### Field Value

| Type | Description |
| --- | --- |
| [ColorDefinitionRGBA](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ColorDefinitionRGBA.html) |     |

#### ColorMinimalPower

##### Declaration

```
public ColorDefinitionRGBA ColorMinimalPower
```

##### Field Value

| Type | Description |
| --- | --- |
| [ColorDefinitionRGBA](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ColorDefinitionRGBA.html) |     |

#### EmissiveMaterialName

##### Declaration

```
public string EmissiveMaterialName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### LightDummyName

##### Declaration

```
public string LightDummyName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### LightFalloffBounds

##### Declaration

```
public MyBounds LightFalloffBounds
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### LightIntensityBounds

##### Declaration

```
public MyBounds LightIntensityBounds
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### LightOffsetBounds

##### Declaration

```
public MyBounds LightOffsetBounds
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### LightRadiusBounds

##### Declaration

```
public MyBounds LightRadiusBounds
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### PowerDependency

##### Declaration

```
public float PowerDependency
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReflectorConeDegrees

##### Declaration

```
public float ReflectorConeDegrees
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RequiredPowerInput

##### Declaration

```
public float RequiredPowerInput
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SubpartRotations

##### Declaration

```
public MyObjectBuilder_HeatVentBlockDefinition.SubpartRotation[] SubpartRotations
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_HeatVentBlockDefinition.SubpartRotation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_HeatVentBlockDefinition.SubpartRotation.html)\[\] |     |

### Methods

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Overrides