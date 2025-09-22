---
title: "Class MyObjectBuilder\\_TurretBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_TurretBase.html"
category: "Weapons"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_TurretBase"
---

# Class MyObjectBuilder\_TurretBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_TurretBase

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_TurretBase : MyObjectBuilder_UserControllableGun
```

### Constructors

#### MyObjectBuilder\_TurretBase()

##### Declaration

```
public MyObjectBuilder_TurretBase()
```

### Fields

#### Elevation

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EnableIdleRotation

##### Declaration

```
public bool EnableIdleRotation
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FireAtLockedTarget

##### Declaration

```
public bool FireAtLockedTarget
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Flags

##### Declaration

```
[Serialize]
public MyObjectBuilder_TargetingFlags Flags
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_TargetingFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_TargetingFlags.html) |     |

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

#### Inventory

##### Declaration

```
[Nullable]
public MyObjectBuilder_Inventory Inventory
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Inventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Inventory.html) |     |

#### IsPotentialTarget

##### Declaration

```
public bool IsPotentialTarget
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PreviousControlledEntityId

##### Declaration

```
public Nullable<long> PreviousControlledEntityId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

#### PreviousIdleRotationState

##### Declaration

```
public bool PreviousIdleRotationState
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Range

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RemainingAmmo

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Rotation

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Target

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### TargetCharacters

##### Declaration

```
public bool TargetCharacters
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetingGroup

##### Declaration

```
public MyStringHash TargetingGroup
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### TargetLargeGrids

##### Declaration

```
public bool TargetLargeGrids
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetLocking

##### Declaration

```
public bool TargetLocking
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetMeteors

##### Declaration

```
public bool TargetMeteors
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetMissiles

##### Declaration

```
public bool TargetMissiles
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetNeutrals

##### Declaration

```
public bool TargetNeutrals
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetSmallGrids

##### Declaration

```
public bool TargetSmallGrids
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetStations

##### Declaration

```
public bool TargetStations
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### SetupForProjector()

##### Declaration

```
public override void SetupForProjector()
```

##### Overrides

### Extension Methods