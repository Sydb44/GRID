#### HasLocalPlayerAccess()

##### Declaration

```
bool HasLocalPlayerAccess()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Can player access this block or not. (Result of [HasPlayerAccess(Int64, MyRelationsBetweenPlayerAndBlock)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html#Sandbox_ModAPI_Ingame_IMyTerminalBlock_HasPlayerAccess_System_Int64_VRage_Game_MyRelationsBetweenPlayerAndBlock_) function call) |

#### HasNobodyPlayerAccessToBlock()

Returns if Nobody has access to block.

##### Declaration

```
bool HasNobodyPlayerAccessToBlock()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True when block is has ShareAll or BigOwners of grid is Nobody |

##### See Also

#### HasPlayerAccess(Int64, MyRelationsBetweenPlayerAndBlock)

Returns if local player can use block. It is also checking for admin access.

##### Declaration

```
bool HasPlayerAccess(long playerId, MyRelationsBetweenPlayerAndBlock defaultNoUser)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId | PlayerId which you want check |
| [MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html) | defaultNoUser |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Can player access block or not |

##### See Also

#### HasPlayerAccessWithNobodyCheck(Int64, Boolean)

Returns if player can use block. If playerId is 0 (Nobody), calls HasNobodyPlayerAccessToBlock instead It is also checking for admin access.

##### Declaration

```
bool HasPlayerAccessWithNobodyCheck(long playerId, bool isForPB = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId | PlayerId which you want check |
| System.Boolean | isForPB | Is used for PB block or not (PB block has more restrictions) |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Can player access block or not |

##### See Also

#### IsSameConstructAs(IMyTerminalBlock)

Determines whether this block is [Mechanical](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html#VRage_Game_ModAPI_GridLinkTypeEnum_Mechanical) connected to the other. This is any block connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct.

Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way. Also be aware that detaching the heads of pistons and rotors will cause this connection to change.

##### Declaration

```
bool IsSameConstructAs(IMyTerminalBlock other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | other | Other block |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if blocks are on same grid, or has [Mechanical](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html#VRage_Game_ModAPI_GridLinkTypeEnum_Mechanical) linking |

#### SearchActionsOfName(String, List<ITerminalAction>, Func<ITerminalAction, Boolean>)

Get all terminal actions available for block. NOTE: First called `<param ref="collect" />` and then `<param ref="name" />` check

##### Declaration

```
void SearchActionsOfName(string name, List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | Searches for terminal action with this name |
| System.Collections.Generic.List<[ITerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalAction.html)\> | resultList | Buffer list, results would be added here. Can be null if  always returns false |
| System.Func<[ITerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalAction.html), System.Boolean\> | collect | Filter function, if function is null or returns true, terminal action would be added to |

##### See Also

#### SetCustomName(String)

Obsolete

##### Declaration

```
void SetCustomName(string text)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | text |     |

#### SetCustomName(StringBuilder)

Obsolete

##### Declaration

```
void SetCustomName(StringBuilder text)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | text |     |

### Extension Methods