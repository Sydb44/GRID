---
title: "Class MyObjectBuilder\\_GunBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_GunBase.html"
category: "Weapons"
namespace: "VRage.Game"
class: "MyObjectBuilder_GunBase"
---

# Class MyObjectBuilder\_GunBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_GunBase

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_GunBase : MyObjectBuilder_DeviceBase
```

### Constructors

#### MyObjectBuilder\_GunBase()

##### Declaration

```
public MyObjectBuilder_GunBase()
```

### Fields

#### CurrentAmmoMagazineName

##### Declaration

```
public string CurrentAmmoMagazineName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### LastShootTime

##### Declaration

```
public long LastShootTime
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### RemainingAmmo

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### RemainingAmmosList

##### Declaration

```
public List<MyObjectBuilder_GunBase.RemainingAmmoIns> RemainingAmmosList
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_GunBase.RemainingAmmoIns](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_GunBase.RemainingAmmoIns.html)\> |     |

#### RemainingMagazines

##### Declaration

```
public int RemainingMagazines
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### RemainingAmmos

##### Declaration

```
[NoSerialize]
public SerializableDictionary<string, int> RemainingAmmos { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Serialization.SerializableDictionary<System.String, System.Int32\> |     |

### Methods

#### ShouldSerializeRemainingAmmos()

##### Declaration

```
public bool ShouldSerializeRemainingAmmos()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods