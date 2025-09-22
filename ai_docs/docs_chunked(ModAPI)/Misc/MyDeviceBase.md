---
title: "Class MyDeviceBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDeviceBase.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "MyDeviceBase"
---

# Class MyDeviceBase | Space Engineers ModAPI

Implements base abstract class for device

##### Inheritance

System.Object

MyDeviceBase

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MyDeviceBase : Object
```

### Constructors

#### MyDeviceBase()

##### Declaration

### Properties

#### InventoryItemId

Reference to the inventory item that this device originated from. Can be used to update the inventory item (when ammo changes etc...)

##### Declaration

```
public Nullable<uint> InventoryItemId { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.UInt32\> |     |

### Methods

#### CanSwitchAmmoMagazine()

Determines whether this device can switch ammo

##### Declaration

```
public abstract bool CanSwitchAmmoMagazine()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if can |

#### GetMuzzleLocalPosition()

Gets the muzzle local position

##### Declaration

```
public abstract Vector3D GetMuzzleLocalPosition()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | local vector |

#### GetMuzzleWorldPosition()

Gets the muzzle world position

##### Declaration

```
public abstract Vector3D GetMuzzleWorldPosition()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | world vector |

#### Init(MyObjectBuilder\_DeviceBase)

Initialization of the device

##### Declaration

```
public void Init(MyObjectBuilder_DeviceBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DeviceBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DeviceBase.html) | objectBuilder | device object builder instance |

#### SwitchAmmoMagazineToNextAvailable()

Switches to the next available ammo magazine

##### Declaration

```
public abstract bool SwitchAmmoMagazineToNextAvailable()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SwitchToNextAmmoMagazine()

Switches to the next ammo magazine

##### Declaration

```
public abstract bool SwitchToNextAmmoMagazine()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if success |