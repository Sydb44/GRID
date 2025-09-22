---
title: "Class MyObjectBuilder\\_ShipController"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_ShipController.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_ShipController"
---

# Class MyObjectBuilder\_ShipController | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_ShipController

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_ShipController : MyObjectBuilder_TerminalBlock
```

### Constructors

#### MyObjectBuilder\_ShipController()

##### Declaration

```
public MyObjectBuilder_ShipController()
```

### Fields

#### BuildToolbar

##### Declaration

```
[Serialize]
public MyObjectBuilder_Toolbar BuildToolbar
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Toolbar](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Toolbar.html) |     |

#### ControlGyros

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ControlThrusters

##### Declaration

```
public bool ControlThrusters
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ControlWheels

##### Declaration

```
public bool ControlWheels
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### HorizonIndicatorEnabled

##### Declaration

```
public bool HorizonIndicatorEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsMainCockpit

##### Declaration

```
public bool IsMainCockpit
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsTargetLockingEnabled

##### Declaration

```
public bool IsTargetLockingEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OnLockedToolbar

##### Declaration

```
[Serialize]
public MyObjectBuilder_Toolbar OnLockedToolbar
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Toolbar](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Toolbar.html) |     |

#### SelectedGunId

##### Declaration

```
[Serialize]
public Nullable<SerializableDefinitionId> SelectedGunId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html)\> |     |

#### Toolbar

##### Declaration

```
[Serialize]
public MyObjectBuilder_Toolbar Toolbar
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Toolbar](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Toolbar.html) |     |

#### UseSingleWeaponMode

##### Declaration

```
public bool UseSingleWeaponMode
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Remap(IMyRemapHelper)

##### Declaration

```
public override void Remap(IMyRemapHelper remapHelper)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyRemapHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html) | remapHelper |     |

##### Overrides

### Extension Methods