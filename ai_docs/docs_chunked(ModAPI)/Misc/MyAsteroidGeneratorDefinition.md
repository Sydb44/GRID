---
title: "Class MyAsteroidGeneratorDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyAsteroidGeneratorDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyAsteroidGeneratorDefinition"
---

# Class MyAsteroidGeneratorDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyAsteroidGeneratorDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyAsteroidGeneratorDefinition : MyDefinitionBase
```

### Constructors

#### MyAsteroidGeneratorDefinition()

##### Declaration

```
public MyAsteroidGeneratorDefinition()
```

### Fields

#### AllowPartialClusterObjectOverlap

Allows objects in clusters to partially overlap (in terms of their AABBs)

##### Declaration

```
public bool AllowPartialClusterObjectOverlap
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ClusterDispersionAbsolute

Enables absolute positioning in cluster

##### Declaration

```
public bool ClusterDispersionAbsolute
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ObjectDensityCluster

Probability that generated object in cluster will be used

##### Declaration

```
public double ObjectDensityCluster
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### ObjectMaxDistanceInClusterMax

##### Declaration

```
public int ObjectMaxDistanceInClusterMax
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ObjectMaxDistanceInClusterMin

##### Declaration

```
public int ObjectMaxDistanceInClusterMin
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ObjectMaxInCluster

Maximal number of asteroids per cluster

##### Declaration

```
public int ObjectMaxInCluster
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ObjectMinDistanceInCluster

Controls positional dispersion of cluster objects. Behavior is controlled by [ClusterDispersionAbsolute](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyAsteroidGeneratorDefinition.html#Sandbox_Definitions_MyAsteroidGeneratorDefinition_ClusterDispersionAbsolute)

##### Declaration

```
public int ObjectMinDistanceInCluster
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ObjectSizeMax

Maximal size of lone asteroids

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ObjectSizeMaxCluster

Maximal size of individual cluster asteroids

##### Declaration

```
public int ObjectSizeMaxCluster
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ObjectSizeMin

Minimal size of lone asteroids

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ObjectSizeMinCluster

Minimal size of individual cluster asteroids

##### Declaration

```
public int ObjectSizeMinCluster
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### RotateAsteroids

Enable asteroid rotation

##### Declaration

```
public bool RotateAsteroids
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SeedClusterTypeProbability

##### Declaration

```
public DictionaryReader<MyObjectSeedType, double> SeedClusterTypeProbability
```

##### Field Value

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<[MyObjectSeedType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectSeedType.html), System.Double\> |     |

#### SeedTypeProbability

##### Declaration

```
public DictionaryReader<MyObjectSeedType, double> SeedTypeProbability
```

##### Field Value

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<[MyObjectSeedType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectSeedType.html), System.Double\> |     |

#### SubCells

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### SubcellSize

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### UseClusterDefAsAsteroid

Backwards comp for incorrect cluster object size

##### Declaration

```
public bool UseClusterDefAsAsteroid
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UseClusterVariableSize

##### Declaration

```
public bool UseClusterVariableSize
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UseGeneratorSeed

##### Declaration

```
public bool UseGeneratorSeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UseLinearPowOfTwoSizeDistribution

##### Declaration

```
public bool UseLinearPowOfTwoSizeDistribution
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Version

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