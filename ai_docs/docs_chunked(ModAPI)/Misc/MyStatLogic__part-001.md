---
title: "Class MyStatLogic"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyStatLogic.html"
category: "Misc"
namespace: "Sandbox.Game"
class: "MyStatLogic"
---

# Class MyStatLogic | Space Engineers ModAPI

##### Inheritance

System.Object

MyStatLogic

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyStatLogic : Object
```

### Constructors

#### MyStatLogic()

##### Declaration

### Fields

#### m\_stats

##### Declaration

```
protected Dictionary<MyStringHash, MyEntityStat> m_stats
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html), [MyEntityStat](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.html)\> |     |

#### STAT\_VALUE\_TOO\_LOW

##### Declaration

```
public const int STAT_VALUE_TOO_LOW = 4
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### Character

##### Declaration

```
public IMyCharacter Character { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) |     |

#### EnableAutoHealing

##### Declaration

```
protected bool EnableAutoHealing { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Name

##### Declaration

```
public string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### StatActions

##### Declaration

```
public Dictionary<string, MyStatLogic.MyStatAction> StatActions { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, [MyStatLogic.MyStatAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyStatLogic.MyStatAction.html)\> |     |

#### StatEfficiencyModifiers

##### Declaration

```
public Dictionary<string, MyStatLogic.MyStatEfficiencyModifier> StatEfficiencyModifiers { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, [MyStatLogic.MyStatEfficiencyModifier](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyStatLogic.MyStatEfficiencyModifier.html)\> |     |

#### StatRegenModifiers

##### Declaration

```
public Dictionary<string, MyStatLogic.MyStatRegenModifier> StatRegenModifiers { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, [MyStatLogic.MyStatRegenModifier](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyStatLogic.MyStatRegenModifier.html)\> |     |

### Methods

#### AddAction(String, MyStatLogic.MyStatAction)

##### Declaration

```
public void AddAction(string actionId, MyStatLogic.MyStatAction action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | actionId |     |
| [MyStatLogic.MyStatAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyStatLogic.MyStatAction.html) | action |     |

#### AddEfficiency(String, MyStatLogic.MyStatEfficiencyModifier)

##### Declaration

```
public void AddEfficiency(string modifierId, MyStatLogic.MyStatEfficiencyModifier modifier)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | modifierId |     |
| [MyStatLogic.MyStatEfficiencyModifier](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyStatLogic.MyStatEfficiencyModifier.html) | modifier |     |

#### AddModifier(String, MyStatLogic.MyStatRegenModifier)

##### Declaration

```
public void AddModifier(string modifierId, MyStatLogic.MyStatRegenModifier modifier)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | modifierId |     |
| [MyStatLogic.MyStatRegenModifier](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyStatLogic.MyStatRegenModifier.html) | modifier |     |

#### ApplyModifier(String)

##### Declaration

```
public void ApplyModifier(string modifierId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | modifierId |     |

#### CanDoAction(String, Boolean, out MyTuple<UInt16, MyStringHash>)

##### Declaration

```
public bool CanDoAction(string actionId, bool continuous, out MyTuple<ushort, MyStringHash> message)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | actionId |     |
| System.Boolean | continuous |     |
| VRage.MyTuple<System.UInt16, [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\> | message |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Close()

##### Declaration

```
public virtual void Close()
```

#### DoAction(String)

##### Declaration

```
public bool DoAction(string actionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | actionId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetEfficiencyModifier(String)

##### Declaration

```
public float GetEfficiencyModifier(string modifierId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | modifierId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Init(IMyCharacter, Dictionary<MyStringHash, MyEntityStat>, String)

##### Declaration

```
public virtual void Init(IMyCharacter character, Dictionary<MyStringHash, MyEntityStat> stats, string scriptName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) | character |     |
| System.Collections.Generic.Dictionary<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html), [MyEntityStat](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.html)\> | stats |     |
| System.String | scriptName |     |
