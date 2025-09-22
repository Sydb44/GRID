##### Declaration

```
void GetBlocksOfType<T>(List<IMyTerminalBlock> blocks, Func<IMyTerminalBlock, bool> collect = null)
    where T : class
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html)\> | blocks | A preallocated list to receive the blocks. |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html), System.Boolean\> | collect | Provide a filter method to determine if a given group should be added or not. |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | The type of blocks to retrieve. |

#### GetBlockWithId(Int64)

Attempts to retrieve the block with the given entity ID.

##### Declaration

```
IMyTerminalBlock GetBlockWithId(long id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | id  | Entity Id |

##### Returns

| Type | Description |
| --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | Block or `null` if no block with provided id found |

#### GetBlockWithName(String)

Returns the first block found with the given name.

##### Declaration

```
IMyTerminalBlock GetBlockWithName(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | The block must contain the given name in their name. |

##### Returns

| Type | Description |
| --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | First found block with `name` or `null` if no block with that name can be found |

#### SearchBlocksOfName(String, List<IMyTerminalBlock>, Func<IMyTerminalBlock, Boolean>)

Fills the provided list with the blocks reachable by this grid terminal system. This means all blocks on the same grid, or connected via rotors, pistons or connectors.

##### Declaration

```
void SearchBlocksOfName(string name, List<IMyTerminalBlock> blocks, Func<IMyTerminalBlock, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | The blocks must contain the given name in their name. |
| System.Collections.Generic.List<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html)\> | blocks | A preallocated list to receive the blocks. |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html), System.Boolean\> | collect | Provide a filter method to determine if a given group should be added or not. |