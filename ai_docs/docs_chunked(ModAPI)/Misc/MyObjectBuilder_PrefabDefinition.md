---
title: "Class MyObjectBuilder\\_PrefabDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PrefabDefinition.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_PrefabDefinition"
---

# Class MyObjectBuilder\_PrefabDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_PrefabDefinition

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_PrefabDefinition : MyObjectBuilder_DefinitionBase
```

### Constructors

#### MyObjectBuilder\_PrefabDefinition()

##### Declaration

```
public MyObjectBuilder_PrefabDefinition()
```

### Fields

#### CubeGrid

##### Declaration

```
public MyObjectBuilder_CubeGrid CubeGrid
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_CubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeGrid.html) |     |

#### CubeGrids

##### Declaration

```
public MyObjectBuilder_CubeGrid[] CubeGrids
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_CubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeGrid.html)\[\] |     |

#### EnvironmentType

##### Declaration

```
public MyEnvironmentTypes EnvironmentType
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyEnvironmentTypes](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyEnvironmentTypes.html) |     |

#### PrefabPath

##### Declaration

```
[ModdableContentFile("sbc")]
public string PrefabPath
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### RespawnShip

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TooltipImage

##### Declaration

```
public string TooltipImage
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### ShouldSerializeCubeGrid()

##### Declaration

```
public bool ShouldSerializeCubeGrid()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeRespawnShip()

##### Declaration

```
public bool ShouldSerializeRespawnShip()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods