---
title: "Class MyEnvironmentItemsDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEnvironmentItemsDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyEnvironmentItemsDefinition"
---

# Class MyEnvironmentItemsDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyEnvironmentItemsDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyEnvironmentItemsDefinition : MyDefinitionBase
```

### Constructors

#### MyEnvironmentItemsDefinition()

##### Declaration

```
public MyEnvironmentItemsDefinition()
```

### Properties

#### Channel

##### Declaration

```
public int Channel { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ItemDefinitionCount

##### Declaration

```
public int ItemDefinitionCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ItemDefinitionType

##### Declaration

```
public MyObjectBuilderType ItemDefinitionType { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) |     |

#### ItemSize

##### Declaration

```
public float ItemSize { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Material

##### Declaration

```
public MyStringHash Material { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### MaxViewDistance

##### Declaration

```
public float MaxViewDistance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SectorSize

##### Declaration

```
public float SectorSize { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### AddItemDefinition(MyStringHash, Single, Boolean)

##### Declaration

```
public void AddItemDefinition(MyStringHash definition, float frequency, bool recompute = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | definition |     |
| System.Single | frequency |     |
| System.Boolean | recompute |     |

#### ContainsItemDefinition(MyEnvironmentItemDefinition)

##### Declaration

```
public bool ContainsItemDefinition(MyEnvironmentItemDefinition itemDefinition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEnvironmentItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEnvironmentItemDefinition.html) | itemDefinition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ContainsItemDefinition(MyDefinitionId)

##### Declaration

```
public bool ContainsItemDefinition(MyDefinitionId definitionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | definitionId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ContainsItemDefinition(MyStringHash)

##### Declaration

```
public bool ContainsItemDefinition(MyStringHash subtypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetItemDefinition(Int32)

##### Declaration

```
public MyEnvironmentItemDefinition GetItemDefinition(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyEnvironmentItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEnvironmentItemDefinition.html) |     |

#### GetItemDefinition(MyStringHash)

##### Declaration

```
public MyEnvironmentItemDefinition GetItemDefinition(MyStringHash subtypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyEnvironmentItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEnvironmentItemDefinition.html) |     |

#### GetRandomItemDefinition()

##### Declaration

```
public MyEnvironmentItemDefinition GetRandomItemDefinition()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyEnvironmentItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEnvironmentItemDefinition.html) |     |

#### GetRandomItemDefinition(MyRandom)

##### Declaration

```
public MyEnvironmentItemDefinition GetRandomItemDefinition(MyRandom instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyRandom](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyRandom.html) | instance |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyEnvironmentItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEnvironmentItemDefinition.html) |     |

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |
