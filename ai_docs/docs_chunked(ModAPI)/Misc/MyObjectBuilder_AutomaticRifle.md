---
title: "Class MyObjectBuilder\\_AutomaticRifle"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutomaticRifle.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_AutomaticRifle"
---

# Class MyObjectBuilder\_AutomaticRifle | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_AutomaticRifle

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_AutomaticRifle : MyObjectBuilder_EntityBase, IMyObjectBuilder_GunObject<MyObjectBuilder_GunBase>, IMyStackableGunItem
```

### Constructors

#### MyObjectBuilder\_AutomaticRifle()

##### Declaration

```
public MyObjectBuilder_AutomaticRifle()
```

### Fields

#### CurrentAmmo

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GunBase

##### Declaration

```
[Serialize]
public MyObjectBuilder_GunBase GunBase
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_GunBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_GunBase.html) |     |

### Methods

#### CanStack(IMyStackableGunItem)

##### Declaration

```
public bool CanStack(IMyStackableGunItem other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyStackableGunItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.IMyStackableGunItem.html) | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanStackWithNullGun()

##### Declaration

```
public bool CanStackWithNullGun()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeCurrentAmmo()

##### Declaration

```
public bool ShouldSerializeCurrentAmmo()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Explicit Interface Implementations

#### IMyObjectBuilder\_GunObject<MyObjectBuilder\_GunBase>.DeviceBase

##### Declaration

```
MyObjectBuilder_DeviceBase IMyObjectBuilder_GunObject<MyObjectBuilder_GunBase>.DeviceBase { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_DeviceBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DeviceBase.html) |     |

### Implements

### Extension Methods