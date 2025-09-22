```
void ChangeOrSwitchToColor(Vector3 color)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | color | New current painting color |

#### GetBalanceShortString()

Gets balance of an account associated with player. Format is 'BALANCE CURRENCYSHORTNAME'.

##### Declaration

```
string GetBalanceShortString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String | Current balance of the account in form of formatted string. If Banking System does not exist method returns null. |

#### GetPosition()

Gets the position of controlled entity. Grid/Character

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | World coordinates of controlled entity |

#### GetRelationTo(Int64)

Gets the relationship between this player and another.

##### Declaration

```
MyRelationsBetweenPlayerAndBlock GetRelationTo(long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId | Player to test relationship against |

##### Returns

| Type | Description |
| --- | --- |
| [MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html) | Relations |

#### RemoveGrid(Int64)

Removes a grid from the player's Grids list.

##### Declaration

```
void RemoveGrid(long gridEntityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | gridEntityId | [EntityId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_EntityId) |

#### RequestChangeBalance(Int64)

Changes the balance of the account of this player by given amount. Sends a message to server with the request.

##### Declaration

```
void RequestChangeBalance(long amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | amount | Amount by which to change te balance. |

#### SetDefaultColors()

Sets build colors back to defaults.

##### Declaration

#### SpawnAt(MatrixD, Vector3, IMyEntity)

Spawns the player at a specific place. Must be called on server.

##### Declaration

```
void SpawnAt(MatrixD worldMatrix, Vector3 velocity, IMyEntity spawnedBy)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix | Spawn position |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | velocity | Velocity to provide to player |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | spawnedBy | Entity triggering respawn (can be null) |

#### SpawnAt(MatrixD, Vector3, IMyEntity, Boolean, String, Nullable<Color>)

Spawns the player at a specific place. Must be called on server.

##### Declaration

```
void SpawnAt(MatrixD worldMatrix, Vector3 velocity, IMyEntity spawnedBy, bool findFreePlace = true, string modelName = null, Nullable<Color> color = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix | Spawn position |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | velocity | Velocity to provide to player |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | spawnedBy | Entity triggering respawn (can be null) |
| System.Boolean | findFreePlace | Find a safe place to spawn near the position |
| System.String | modelName | Model of character. Use **null** for using player's default color |
| System.Nullable<[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)\> | color | Character color. Use **null** for using player's default color |

#### SpawnIntoCharacter(IMyCharacter)

Spawns the player as a new character (changes the model).

##### Declaration

```
void SpawnIntoCharacter(IMyCharacter character)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) | character | New character to use |

#### TryGetBalanceInfo(out Int64)

Gets balance of an account associated with player.

##### Declaration

```
bool TryGetBalanceInfo(out long balance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | balance | Returns current balance of the account. (If called on client, can return delayed value, as changes to balance have to be synchronized first) |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if account was found. Otherwise false. |

### Events

#### IdentityChanged

Event triggered when the player's identity changed (eg. died w/permadeath on)

##### Declaration

```
event Action<IMyPlayer, IMyIdentity> IdentityChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyPlayer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPlayer.html), [IMyIdentity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyIdentity.html)\> |     |