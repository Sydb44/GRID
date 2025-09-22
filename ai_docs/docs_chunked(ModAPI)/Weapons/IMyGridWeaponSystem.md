---
title: "Interface IMyGridWeaponSystem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridWeaponSystem.html"
category: "Weapons"
namespace: "VRage.Game.ModAPI"
class: "IMyGridWeaponSystem"
---

# Interface IMyGridWeaponSystem | Space Engineers ModAPI

ModAPI interface giving access to grid-group weapon system

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyGridWeaponSystem
```

### Methods

#### GetGun(MyDefinitionId)

Get first found gun object with specified definition id.

##### Declaration

```
IMyGunObject<MyDeviceBase> GetGun(MyDefinitionId defId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | defId |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyGunObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGunObject-1.html)<[MyDeviceBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDeviceBase.html)\> |     |

#### Register(IMyGunObject<MyDeviceBase>)

Registers gun in weapon system. Required for being able to use it as a ship tool or weapon: `Left mouse hold to shoot`

##### Declaration

```
void Register(IMyGunObject<MyDeviceBase> gun)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyGunObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGunObject-1.html)<[MyDeviceBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDeviceBase.html)\> | gun | Interface representing gun |

#### Unregister(IMyGunObject<MyDeviceBase>)

Unregisters gun in weapon system.

##### Declaration

```
void Unregister(IMyGunObject<MyDeviceBase> gun)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyGunObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGunObject-1.html)<[MyDeviceBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDeviceBase.html)\> | gun |     |