---
title: "Class MyEntityRespawnComponentBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyEntityRespawnComponentBase"
---

# Class MyEntityRespawnComponentBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityRespawnComponentBase

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyEntityRespawnComponentBase : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase, IMyCameraController, IMyControllableEntity, IMyControllableEntity
```

### Constructors

#### MyEntityRespawnComponentBase()

##### Declaration

```
protected MyEntityRespawnComponentBase()
```

### Properties

#### AuxiliaryContext

##### Declaration

```
public MyStringId AuxiliaryContext { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### Entity

##### Declaration

```
public MyEntity Entity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### IsAutopilotControlled

##### Declaration

```
public bool IsAutopilotControlled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LastMotionIndicator

##### Declaration

```
public Vector3 LastMotionIndicator { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### LastRotationIndicator

##### Declaration

```
public Vector3 LastRotationIndicator { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

### Methods

#### GetOverridingFocusMatrix()

##### Declaration

```
public Nullable<MatrixD> GetOverridingFocusMatrix()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)\> |     |

### Explicit Interface Implementations

#### IMyControllableEntity.BeginShoot(MyShootActionEnum)

##### Declaration

```
void IMyControllableEntity.BeginShoot(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |

#### IMyControllableEntity.CanSwitchAmmoMagazine()

##### Declaration

```
bool IMyControllableEntity.CanSwitchAmmoMagazine()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyControllableEntity.CanSwitchToWeapon(Nullable<MyDefinitionId>)

##### Declaration

```
bool IMyControllableEntity.CanSwitchToWeapon(Nullable<MyDefinitionId> weaponDefinition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> | weaponDefinition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyControllableEntity.ControlContext

##### Declaration

```
MyStringId IMyControllableEntity.ControlContext { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### IMyControllableEntity.ControllerInfo

##### Declaration

```
MyControllerInfo IMyControllableEntity.ControllerInfo { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.World.MyControllerInfo |     |

#### IMyControllableEntity.EnabledBroadcasting

##### Declaration

```
bool IMyControllableEntity.EnabledBroadcasting { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyControllableEntity.EndShoot(MyShootActionEnum)

##### Declaration

```
void IMyControllableEntity.EndShoot(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |

#### IMyControllableEntity.Entity

##### Declaration

```
MyEntity IMyControllableEntity.Entity { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### IMyControllableEntity.GetCameraEntitySettings()

##### Declaration

```
MyEntityCameraSettings IMyControllableEntity.GetCameraEntitySettings()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.Multiplayer.MyEntityCameraSettings |     |

#### IMyControllableEntity.HeadLocalXAngle

##### Declaration

```
float IMyControllableEntity.HeadLocalXAngle { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyControllableEntity.HeadLocalYAngle

##### Declaration

```
float IMyControllableEntity.HeadLocalYAngle { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyControllableEntity.OnBeginShoot(MyShootActionEnum)

##### Declaration

```
void IMyControllableEntity.OnBeginShoot(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |
