---
title: "Class MySpaceStatEffect"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MySpaceStatEffect.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MySpaceStatEffect"
---

# Class MySpaceStatEffect | Space Engineers ModAPI

##### Inheritance

System.Object

MySpaceStatEffect

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyStatLogicDescriptor("SpaceStatEffect")]
public class MySpaceStatEffect : MyStatLogic
```

### Constructors

#### MySpaceStatEffect()

##### Declaration

```
public MySpaceStatEffect()
```

### Fields

#### MAX\_REGEN\_HEALTH\_RATIO

##### Declaration

```
public static readonly float MAX_REGEN_HEALTH_RATIO
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### Close()

##### Declaration

```
public override void Close()
```

##### Overrides

#### GetAutoHealingEffect()

##### Declaration

```
public MyEntityStatRegenEffect GetAutoHealingEffect()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyEntityStatRegenEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStatRegenEffect.html) |     |

#### Init(IMyCharacter, Dictionary<MyStringHash, MyEntityStat>, String)

##### Declaration

```
public override void Init(IMyCharacter character, Dictionary<MyStringHash, MyEntityStat> stats, string scriptName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) | character |     |
| System.Collections.Generic.Dictionary<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html), [MyEntityStat](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.html)\> | stats |     |
| System.String | scriptName |     |

##### Overrides

#### Update10()

##### Declaration

```
public override void Update10()
```

##### Overrides