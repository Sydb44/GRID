---
title: "Interface IMyDestroyableObject"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyDestroyableObject.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Interfaces"
class: "IMyDestroyableObject"
---

# Interface IMyDestroyableObject | Space Engineers ModAPI

###### **Namespace**: [VRage.Game.ModAPI.Interfaces](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyDestroyableObject
```

### Properties

#### Integrity

Gets the integrity (health) of the object

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### UseDamageSystem

When set to true, it should use MyDamageSystem damage routing.

##### Declaration

```
bool UseDamageSystem { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### DoDamage(Single, MyStringHash, Boolean, Nullable<MyHitInfo>, Int64, Int64, Boolean, Nullable<MyStringHash>)

Applies damage to an object

##### Declaration

```
bool DoDamage(float damage, MyStringHash damageSource, bool sync, Nullable<MyHitInfo> hitInfo = null, long attackerId = 0L, long realHitEntityId = 0L, bool shouldDetonateAmmo = true, Nullable<MyStringHash> extraInfo = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | damage |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | damageSource |     |
| System.Boolean | sync |     |
| System.Nullable<[MyHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyHitInfo.html)\> | hitInfo |     |
| System.Int64 | attackerId |     |
| System.Int64 | realHitEntityId |     |
| System.Boolean | shouldDetonateAmmo |     |
| System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\> | extraInfo |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OnDestroy()

##### Declaration