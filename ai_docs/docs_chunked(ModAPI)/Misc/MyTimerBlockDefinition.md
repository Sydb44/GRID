---
title: "Class MyTimerBlockDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyTimerBlockDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyTimerBlockDefinition"
---

# Class MyTimerBlockDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyTimerBlockDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyTimerBlockDefinition : MyFunctionalBlockDefinition
```

### Constructors

#### MyTimerBlockDefinition()

##### Declaration

```
public MyTimerBlockDefinition()
```

### Fields

#### MaxDelay

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MinDelay

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ResourceSinkGroup

##### Declaration

```
public MyStringHash ResourceSinkGroup
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### TimerSoundEnd

##### Declaration

```
public string TimerSoundEnd
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### TimerSoundMid

##### Declaration

```
public string TimerSoundMid
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### TimerSoundStart

##### Declaration

```
public string TimerSoundStart
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

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