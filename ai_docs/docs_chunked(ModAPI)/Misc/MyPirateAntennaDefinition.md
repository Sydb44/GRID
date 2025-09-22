---
title: "Class MyPirateAntennaDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPirateAntennaDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyPirateAntennaDefinition"
---

# Class MyPirateAntennaDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyPirateAntennaDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyPirateAntennaDefinition : MyDefinitionBase
```

### Constructors

#### MyPirateAntennaDefinition()

##### Declaration

```
public MyPirateAntennaDefinition()
```

### Fields

#### DroneSpawnStrategy

##### Declaration

```
public MyPirateAntennaDefinition.SpawnStrategy DroneSpawnStrategy
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyPirateAntennaDefinition.SpawnStrategy](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPirateAntennaDefinition.SpawnStrategy.html) |     |

#### FirstSpawnTimeMs

##### Declaration

```
public int FirstSpawnTimeMs
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MaxDrones

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Name

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### SpawnDistance

##### Declaration

```
public float SpawnDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SpawnGroupSampler

##### Declaration

```
public MyDiscreteSampler<MySpawnGroupDefinition> SpawnGroupSampler
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDiscreteSampler](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyDiscreteSampler-1.html)<[MySpawnGroupDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MySpawnGroupDefinition.html)\> |     |

#### SpawnTimeMs

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

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

#### Postprocess()

##### Declaration

```
public override void Postprocess()
```

##### Overrides