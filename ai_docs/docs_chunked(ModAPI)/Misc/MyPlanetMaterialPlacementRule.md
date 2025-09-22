---
title: "Class MyPlanetMaterialPlacementRule"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyPlanetMaterialPlacementRule.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyPlanetMaterialPlacementRule"
---

# Class MyPlanetMaterialPlacementRule | Space Engineers ModAPI

##### Inheritance

System.Object

MyPlanetMaterialPlacementRule

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyPlanetMaterialPlacementRule : MyPlanetMaterialDefinition, ICloneable
```

### Constructors

#### MyPlanetMaterialPlacementRule()

##### Declaration

```
public MyPlanetMaterialPlacementRule()
```

#### MyPlanetMaterialPlacementRule(MyPlanetMaterialPlacementRule)

##### Declaration

```
public MyPlanetMaterialPlacementRule(MyPlanetMaterialPlacementRule copyFrom)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPlanetMaterialPlacementRule](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyPlanetMaterialPlacementRule.html) | copyFrom |     |

### Fields

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

#### Longitude

##### Declaration

```
public SerializableRange Longitude
```

##### Field Value

| Type | Description |
| --- | --- |
| [SerializableRange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.SerializableRange.html) |     |

#### Slope

##### Declaration

```
public SerializableRange Slope
```

##### Field Value

| Type | Description |
| --- | --- |
| [SerializableRange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.SerializableRange.html) |     |

### Properties

#### IsRule

##### Declaration

```
public override bool IsRule { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

### Methods

#### Check(Single, Single, Single)

##### Declaration

```
public bool Check(float height, float latitude, float slope)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | height |     |
| System.Single | latitude |     |
| System.Single | slope |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Clone()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Object |     |