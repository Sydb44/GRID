---
title: "Class MyRespawnShipDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyRespawnShipDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyRespawnShipDefinition"
---

# Class MyRespawnShipDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyRespawnShipDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyRespawnShipDefinition : MyDefinitionBase
```

### Constructors

#### MyRespawnShipDefinition()

##### Declaration

```
public MyRespawnShipDefinition()
```

### Fields

#### Cooldown

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### HelpTextLocalizationId

##### Declaration

```
public string HelpTextLocalizationId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### InitialAngularVelocity

##### Declaration

```
public Vector3 InitialAngularVelocity
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### InitialLinearVelocity

##### Declaration

```
public Vector3 InitialLinearVelocity
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### MinimalAirDensity

##### Declaration

```
public float MinimalAirDensity
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PlanetDeployAltitude

##### Declaration

```
public float PlanetDeployAltitude
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PlanetTypes

##### Declaration

```
public string[] PlanetTypes
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String\[\] |     |

#### Prefab

##### Declaration

```
public MyPrefabDefinition Prefab
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyPrefabDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPrefabDefinition.html) |     |

#### SpawnNearProceduralAsteroids

##### Declaration

```
public bool SpawnNearProceduralAsteroids
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SpawnPosition

##### Declaration

```
public Nullable<Vector3D> SpawnPosition
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### SpawnPositionDispersionMax

##### Declaration

```
public float SpawnPositionDispersionMax
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SpawnPositionDispersionMin

##### Declaration

```
public float SpawnPositionDispersionMin
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SpawnWithDefaultItems

##### Declaration

```
public bool SpawnWithDefaultItems
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UseForPlanetsWithAtmosphere

##### Declaration

```
public bool UseForPlanetsWithAtmosphere
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UseForPlanetsWithoutAtmosphere

##### Declaration

```
public bool UseForPlanetsWithoutAtmosphere
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UseForSpace

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

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