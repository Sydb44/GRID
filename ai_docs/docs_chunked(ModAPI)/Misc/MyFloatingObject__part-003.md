#### IMyUseObject.RenderObjectID

##### Declaration

```
uint IMyUseObject.RenderObjectID { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### IMyUseObject.SecondaryAction

##### Declaration

```
UseActionEnum IMyUseObject.SecondaryAction { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) |     |

#### IMyUseObject.SetInstanceID(Int32)

##### Declaration

```
void IMyUseObject.SetInstanceID(int id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | id  |     |

#### IMyUseObject.SetRenderID(UInt32)

##### Declaration

```
void IMyUseObject.SetRenderID(uint id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | id  |     |

#### IMyUseObject.ShowOverlay

##### Declaration

```
bool IMyUseObject.ShowOverlay { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyUseObject.SupportedActions

##### Declaration

```
UseActionEnum IMyUseObject.SupportedActions { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) |     |

#### IMyUseObject.Use(UseActionEnum, IMyEntity)

##### Declaration

```
void IMyUseObject.Use(UseActionEnum actionEnum, IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) | actionEnum |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

#### IMyUseObject.WorldMatrix

##### Declaration

```
MatrixD IMyUseObject.WorldMatrix { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### IMyDestroyableObject.DoDamage(Single, MyStringHash, Boolean, Nullable<MyHitInfo>, Int64, Int64, Boolean, Nullable<MyStringHash>)

##### Declaration

```
bool IMyDestroyableObject.DoDamage(float damage, MyStringHash damageType, bool sync, Nullable<MyHitInfo> hitInfo, long attackerId, long realHitEntityId, bool shouldDetonateAmmo, Nullable<MyStringHash> extraInfo)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | damage |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | damageType |     |
| System.Boolean | sync |     |
| System.Nullable<[MyHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyHitInfo.html)\> | hitInfo |     |
| System.Int64 | attackerId |     |
| System.Int64 | realHitEntityId |     |
| System.Boolean | shouldDetonateAmmo |     |
| System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\> | extraInfo |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyDestroyableObject.Integrity

##### Declaration

```
float IMyDestroyableObject.Integrity { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyDestroyableObject.OnDestroy()

##### Declaration

```
void IMyDestroyableObject.OnDestroy()
```

#### IMyDestroyableObject.UseDamageSystem

##### Declaration

```
bool IMyDestroyableObject.UseDamageSystem { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Implements

### Extension Methods