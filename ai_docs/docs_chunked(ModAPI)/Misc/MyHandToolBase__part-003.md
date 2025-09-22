
```
public void DrawHud(IMyCameraController camera, long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html) | camera |     |
| System.Int64 | playerId |     |

#### DrawHud(IMyCameraController, Int64, Boolean)

##### Declaration

```
public void DrawHud(IMyCameraController camera, long playerId, bool fullUpdate)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html) | camera |     |
| System.Int64 | playerId |     |
| System.Boolean | fullUpdate |     |

#### EndShoot(MyShootActionEnum)

##### Declaration

```
public virtual void EndShoot(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |

#### GetAmmunitionAmount()

##### Declaration

```
public int GetAmmunitionAmount()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetMagazineAmount()

##### Declaration

```
public int GetMagazineAmount()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetMuzzlePosition()

##### Declaration

```
public Vector3D GetMuzzlePosition()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### GetObjectBuilder(Boolean)

##### Declaration

```
public override MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

##### Overrides

#### GetReloadDuration()

##### Declaration

```
public float GetReloadDuration()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetShakeOnAction(MyShootActionEnum)

##### Declaration

```
public bool GetShakeOnAction(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetShootDirection()

##### Declaration

```
public Vector3 GetShootDirection()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### GetTotalAmmunitionAmount()

##### Declaration

```
public int GetTotalAmmunitionAmount()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
public override void Init(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |

##### Overrides

#### InitToolComponents()

##### Declaration

```
protected virtual void InitToolComponents()
```

#### IsToolbarUsable()

##### Declaration

```
public bool IsToolbarUsable()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OnControlAcquired(IMyCharacter)

##### Declaration

```
public virtual void OnControlAcquired(IMyCharacter owner)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) | owner |     |

#### OnControlReleased()

##### Declaration

```
public virtual void OnControlReleased()
```

#### PlayReloadSound()

##### Declaration

```
public void PlayReloadSound()
```

#### Reload()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Shoot(MyShootActionEnum, Vector3, Nullable<Vector3D>, String)

##### Declaration

```
public virtual void Shoot(MyShootActionEnum shootAction, Vector3 direction, Nullable<Vector3D> overrideWeaponPos, string gunAction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | shootAction |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | direction |     |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | overrideWeaponPos |     |
| System.String | gunAction |     |

#### ShootFailReactionLocal(MyShootActionEnum, MyGunStatusEnum)

##### Declaration

```
public void ShootFailReactionLocal(MyShootActionEnum action, MyGunStatusEnum status)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |
| [MyGunStatusEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyGunStatusEnum.html) | status |     |

#### ShouldEndShootOnPause(MyShootActionEnum)

##### Declaration

```
public bool ShouldEndShootOnPause(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |
