---
title: "Class MyStationsListDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyStationsListDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyStationsListDefinition"
---

# Class MyStationsListDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyStationsListDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyStationsListDefinition : MyDefinitionBase
```

### Constructors

#### MyStationsListDefinition()

##### Declaration

```
public MyStationsListDefinition()
```

### Properties

#### GeneratedItemsContainerType

##### Declaration

```
public Nullable<MyDefinitionId> GeneratedItemsContainerType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> |     |

#### SpawnDistance

##### Declaration

```
public int SpawnDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### StationNames

Stations prefab Names.

##### Declaration

```
public List<MyStringId> StationNames { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> |     |

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