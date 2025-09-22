#### PhysicalItemDefinition

##### Declaration

```
public MyPhysicalItemDefinition PhysicalItemDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyPhysicalItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalItemDefinition.html) |     |

#### PhysicalObject

##### Declaration

```
public MyObjectBuilder_PhysicalGunObject PhysicalObject { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_PhysicalGunObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalGunObject.html) |     |

#### Physics

##### Declaration

```
public MyPhysicsBody Physics { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Engine.Physics.MyPhysicsBody |     |

#### Reloadable

##### Declaration

```
public bool Reloadable { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShakeAmount

##### Declaration

```
public float ShakeAmount { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ShootDirectionUpdateTime

##### Declaration

```
public int ShootDirectionUpdateTime { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### BeginFailReaction(MyShootActionEnum, MyGunStatusEnum)

##### Declaration

```
public void BeginFailReaction(MyShootActionEnum action, MyGunStatusEnum status)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |
| [MyGunStatusEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyGunStatusEnum.html) | status |     |

#### BeginFailReactionLocal(MyShootActionEnum, MyGunStatusEnum)

##### Declaration

```
public void BeginFailReactionLocal(MyShootActionEnum action, MyGunStatusEnum status)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |
| [MyGunStatusEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyGunStatusEnum.html) | status |     |

#### BeginShoot(MyShootActionEnum)

##### Declaration

```
public virtual void BeginShoot(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |

#### CanDoubleClickToStick(MyShootActionEnum)

##### Declaration

```
public bool CanDoubleClickToStick(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanHit(IMyHandToolComponent, MyCharacterDetectorComponent, ref Boolean, out Single)

##### Declaration

```
protected bool CanHit(IMyHandToolComponent toolComponent, MyCharacterDetectorComponent detectorComponent, ref bool isBlock, out float hitEfficiency)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyHandToolComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyHandToolComponent.html) | toolComponent |     |
| [MyCharacterDetectorComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.MyCharacterDetectorComponent.html) | detectorComponent |     |
| System.Boolean | isBlock |     |
| System.Single | hitEfficiency |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanReload()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanShoot(MyShootActionEnum, Int64, out MyGunStatusEnum)

##### Declaration

```
public virtual bool CanShoot(MyShootActionEnum action, long shooter, out MyGunStatusEnum status)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |
| System.Int64 | shooter |     |
| [MyGunStatusEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyGunStatusEnum.html) | status |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DirectionToTarget(Vector3D)

##### Declaration

```
public Vector3 DirectionToTarget(Vector3D target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | target |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### DoubleClicked(MyShootActionEnum)

##### Declaration

```
public void DoubleClicked(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |

#### DrawHud(IMyCameraController, Int64)

##### Declaration

```
public void DrawHud(IMyCameraController camera, long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html) | camera |     |
| System.Int64 | playerId |     |

#### DrawHud(IMyCameraController, Int64, Boolean)
