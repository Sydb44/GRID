---
title: "Class MyPrefabDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPrefabDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyPrefabDefinition"
---

# Class MyPrefabDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyPrefabDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyPrefabDefinition : MyDefinitionBase
```

### Constructors

#### MyPrefabDefinition()

##### Declaration

```
public MyPrefabDefinition()
```

### Fields

#### Initialized

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PrefabPath

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### Properties

#### BoundingBox

##### Declaration

```
public BoundingBox BoundingBox { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### BoundingSphere

##### Declaration

```
public BoundingSphere BoundingSphere { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) |     |

#### CubeGrids

##### Declaration

```
public MyObjectBuilder_CubeGrid[] CubeGrids { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_CubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeGrid.html)\[\] |     |

#### EnvironmentType

##### Declaration

```
public MyEnvironmentTypes EnvironmentType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEnvironmentTypes](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyEnvironmentTypes.html) |     |

#### TooltipImage

##### Declaration

```
public string TooltipImage { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase baseBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | baseBuilder |     |

##### Overrides

#### InitLazy(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
public void InitLazy(MyObjectBuilder_DefinitionBase baseBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | baseBuilder |     |

#### Unload()

##### Declaration