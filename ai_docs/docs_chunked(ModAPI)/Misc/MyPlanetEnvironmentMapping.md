---
title: "Class MyPlanetEnvironmentMapping"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPlanetEnvironmentMapping.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyPlanetEnvironmentMapping"
---

# Class MyPlanetEnvironmentMapping | Space Engineers ModAPI

##### Inheritance

System.Object

MyPlanetEnvironmentMapping

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyPlanetEnvironmentMapping : Object
```

### Constructors

#### MyPlanetEnvironmentMapping(PlanetEnvironmentItemMapping)

##### Declaration

```
public MyPlanetEnvironmentMapping(PlanetEnvironmentItemMapping map)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PlanetEnvironmentItemMapping](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.PlanetEnvironmentItemMapping.html) | map |     |

### Fields

#### Items

##### Declaration

```
public MyMaterialEnvironmentItem[] Items
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyMaterialEnvironmentItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyMaterialEnvironmentItem.html)\[\] |     |

#### Rule

##### Declaration

```
public MyPlanetSurfaceRule Rule
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyPlanetSurfaceRule](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyPlanetSurfaceRule.html) |     |

#### TotalFrequency

##### Declaration

```
public float TotalFrequency
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Properties

#### Valid

##### Declaration

```
public bool Valid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### ComputeDistribution()

##### Declaration

```
public void ComputeDistribution()
```

#### GetItemRated(Single)

##### Declaration

```
public int GetItemRated(float rate)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | rate |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |