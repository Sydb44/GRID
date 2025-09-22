Removes control from entity

##### Declaration

```
void RemoveControlledEntity(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity that should loose control |

#### RequestChangeBalance(Int64, Int64)

Requests change of the balance (money) for specific identity id

##### Declaration

```
void RequestChangeBalance(long identityId, long amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identityId | identity id |
| System.Int64 | amount | amount to be added/subtracted |

#### SetControlledEntity(UInt64, IMyEntity)

##### Declaration

```
void SetControlledEntity(ulong steamUserId, IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamUserId | Player steam user id |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity that should gain control |

#### TryExtendControl(IMyControllableEntity, IMyEntity)

Control extension and reduction is a mechanism that saves the control of other entities than IMyControllableEntities. A typical example is a cockpit inside a cube grid - you control the cockpit, but you want to "extend" the control to the cube grid as well. You can extend the control multiple times, but you always have to extend from the "base" entity, i.e. the cockpit in our example. The same goes for control reduction: always reduce to the "base" entity

##### Declaration

```
void TryExtendControl(IMyControllableEntity entityWithControl, IMyEntity entityGettingControl)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyControllableEntity.html) | entityWithControl | Entity that already control. Example: cockpit |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entityGettingControl | Entity that would get control. Example: grid |

#### TryGetIdentityId(Int64)

Gets player for identity

##### Declaration

```
IMyPlayer TryGetIdentityId(long identity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identity | Identity id of player |

##### Returns

| Type | Description |
| --- | --- |
| [IMyPlayer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPlayer.html) | Player, or null |

#### TryGetIdentityId(UInt64)

Gets identity for steamId

##### Declaration

```
long TryGetIdentityId(ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId | Player steam id |

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 | IdentityId, or 0 |

#### TryGetSteamId(Int64)

Gets steamId for passed identityId

##### Declaration

```
ulong TryGetSteamId(long identityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identityId | [Identity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPlayer.html#VRage_Game_ModAPI_IMyPlayer_Identity) or [IdentityId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyIdentity.html#VRage_Game_ModAPI_IMyIdentity_IdentityId) |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt64 | Steam Id |

#### TryReduceControl(IMyControllableEntity, IMyEntity)

Control extension and reduction is a mechanism that saves the control of other entities than IMyControllableEntities. A typical example is a cockpit inside a cube grid - you control the cockpit, but you want to "extend" the control to the cube grid as well. You can extend the control multiple times, but you always have to extend from the "base" entity, i.e. the cockpit in our example. The same goes for control reduction: always reduce to the "base" entity

##### Declaration

```
bool TryReduceControl(IMyControllableEntity entityWhichKeepsControl, IMyEntity entityWhichLoosesControl)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyControllableEntity.html) | entityWhichKeepsControl |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entityWhichLoosesControl |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if control was reduced |

### Events

#### ItemConsumed

Called when consumable item was consumed

##### Declaration

```
event Action<IMyCharacter, MyDefinitionId> ItemConsumed
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html), [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> |     |