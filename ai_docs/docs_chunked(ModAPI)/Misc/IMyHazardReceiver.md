---
title: "Interface IMyHazardReceiver"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyHazardReceiver.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyHazardReceiver"
---

# Interface IMyHazardReceiver | Space Engineers ModAPI

Describes a subject of hazard exposure

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyHazardReceiver
```

### Methods

#### Apply(Single, MyStringHash, MyStringHash)

Affects corresponding entity stat. Does not check admin protection. For Radiation, checks immunity stat. Positive value increases stat (except Health, which is reduced by positive damage value).

##### Declaration

```
void Apply(float amount, MyStringHash statId, MyStringHash damageType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | amount | Momentary exposure amount |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | statId | ID of the affected entity stat |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | damageType | If the hazard affects Health stat, [MyDamageType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDamageType.html) is used to differentiate kinds of damage |

#### CanBeAffected()

Is it sheltered from the exposure?

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetEntity()

Gets the associated entity

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyEntity.html) |     |

#### GetPosition()

Gets world position

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |