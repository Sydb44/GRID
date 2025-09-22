
##### Declaration

```
void ShootFailReactionLocal(MyShootActionEnum action, MyGunStatusEnum status)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action | The shooting action, whose shooting failed |
| [MyGunStatusEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyGunStatusEnum.html) | status | Why the shooting failed |

#### SupressShootAnimation()

When too close to object and hands shouldn't be extended

##### Declaration

```
bool SupressShootAnimation()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if too close |

#### UpdateSoundEmitter()

If device has sound emmiter(s), it(they) should be updated

##### Declaration

```
void UpdateSoundEmitter()
```