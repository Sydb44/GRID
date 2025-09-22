---
title: "Interface IMyGunBaseUser"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyGunBaseUser.html"
category: "Weapons"
namespace: "Sandbox.Game.Entities"
class: "IMyGunBaseUser"
---

# Interface IMyGunBaseUser | Space Engineers ModAPI

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyGunBaseUser
```

### Properties

#### AmmoInventory

The inventory in which the weapon searches for additional ammo

##### Declaration

```
MyInventory AmmoInventory { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html) |     |

#### ConstraintDisplayName

##### Declaration

```
string ConstraintDisplayName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### IgnoreEntities

##### Declaration

```
MyEntity[] IgnoreEntities { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\[\] |     |

#### Launcher

##### Declaration

```
IMyMissileGunObject Launcher { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyMissileGunObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyMissileGunObject.html) |     |

#### Owner

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### OwnerId

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### PhysicalItemId

The physical item that is being searched for in the weapon inventory. Can be ignored if WeaponInventory is null

##### Declaration

```
MyDefinitionId PhysicalItemId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### Weapon

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### WeaponInventory

The inventory in which the weapon searches for it's object builder (e.g. an automatic rifle in character's inventory) Can be null if the object builder is not to be searched

##### Declaration

```
MyInventory WeaponInventory { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html) |     |

### Extension Methods