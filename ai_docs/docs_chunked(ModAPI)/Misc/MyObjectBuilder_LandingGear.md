---
title: "Class MyObjectBuilder\\_LandingGear"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_LandingGear.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_LandingGear"
---

# Class MyObjectBuilder\_LandingGear | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_LandingGear

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_LandingGear : MyObjectBuilder_FunctionalBlock
```

### Constructors

#### MyObjectBuilder\_LandingGear()

##### Declaration

```
public MyObjectBuilder_LandingGear()
```

### Fields

#### AttachedEntityId

##### Declaration

```
[Serialize]
public Nullable<long> AttachedEntityId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

#### AutoLock

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### BrakeForce

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FailedAttachSound

##### Declaration

```
[Serialize]
public string FailedAttachSound
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### FirstLockAttempt

##### Declaration

```
public bool FirstLockAttempt
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GearPivotPosition

##### Declaration

```
[Serialize]
public Nullable<Vector3> GearPivotPosition
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### IsLocked

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsParkingEnabled

##### Declaration

```
public bool IsParkingEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LockMode

##### Declaration

```
public LandingGearMode LockMode
```

##### Field Value

| Type | Description |
| --- | --- |
| [LandingGearMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.LandingGearMode.html) |     |

#### LockSound

##### Declaration

```
[Serialize]
public string LockSound
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### MasterToSlave

##### Declaration

```
[Serialize]
public Nullable<MyDeltaTransform> MasterToSlave
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.MyDeltaTransform\> |     |

#### MaxSolverImpulse

##### Declaration

```
public const float MaxSolverImpulse = 1E+08F
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OtherPivot

##### Declaration

```
[Serialize]
public Nullable<CompressedPositionOrientation> OtherPivot
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[CompressedPositionOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CompressedPositionOrientation.html)\> |     |

#### UnlockSound

##### Declaration

```
[Serialize]
public string UnlockSound
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### Extension Methods