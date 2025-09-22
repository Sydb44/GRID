---
title: "Interface IMyStackableGunItem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.IMyStackableGunItem.html"
category: "Weapons"
namespace: "VRage.Game"
class: "IMyStackableGunItem"
---

# Interface IMyStackableGunItem | Space Engineers ModAPI

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyStackableGunItem
```

### Methods

#### CanStack(IMyStackableGunItem)

When there is GunEntity (AutomaticRifle) in both items

##### Declaration

```
bool CanStack(IMyStackableGunItem other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyStackableGunItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.IMyStackableGunItem.html) | other | Other gun |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanStackWithNullGun()

When there is no GunEntity (AutomaticRifle) in other item

##### Declaration

```
bool CanStackWithNullGun()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |