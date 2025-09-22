---
title: "Interface IMyDamageSystem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDamageSystem.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyDamageSystem"
---

# Interface IMyDamageSystem | Space Engineers ModAPI

Mod API interface allowing you handle damage events

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyDamageSystem
```

### Methods

#### RaiseAfterDamageApplied(Object, MyDamageInformation)

Allowing mods, to raise `AfterDamageApplied` event

##### Declaration

```
void RaiseAfterDamageApplied(object target, MyDamageInformation damageInformation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | target | Object that received damage |
| [MyDamageInformation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDamageInformation.html) | damageInformation | Damage info |

#### RaiseBeforeDamageApplied(Object, ref MyDamageInformation)

Allowing mods, to raise `BeforeDamageApplied` event

##### Declaration

```
void RaiseBeforeDamageApplied(object target, ref MyDamageInformation damageInformation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | target | Object that would receive damage |
| [MyDamageInformation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDamageInformation.html) | damageInformation | Damage info |

#### RegisterAfterDamageHandler(Int32, Action<Object, MyDamageInformation>)

Registers a handler that is called after an object in game is damaged.

##### Declaration

```
void RegisterAfterDamageHandler(int priority, Action<object, MyDamageInformation> handler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | priority | Priority level. Lower means higher priority. |
| System.Action<System.Object, [MyDamageInformation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDamageInformation.html)\> | handler | Actual handler delegate |

#### RegisterBeforeDamageHandler(Int32, BeforeDamageApplied)

Registers a handler that is called before an object in game is damaged. The damage can be modified in this handler.

##### Declaration

```
void RegisterBeforeDamageHandler(int priority, BeforeDamageApplied handler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | priority | Priority level. Lower means higher priority. |
| [BeforeDamageApplied](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.BeforeDamageApplied.html) | handler | Actual handler delegate |

#### RegisterDestroyHandler(Int32, Action<Object, MyDamageInformation>)

Registers a handler for when an object in game is destroyed.

##### Declaration

```
void RegisterDestroyHandler(int priority, Action<object, MyDamageInformation> handler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | priority | Priority level. Lower means higher priority. |
| System.Action<System.Object, [MyDamageInformation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDamageInformation.html)\> | handler | Actual handler delegate |