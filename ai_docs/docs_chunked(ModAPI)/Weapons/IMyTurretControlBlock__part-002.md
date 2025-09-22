| Type | Description |
| --- | --- |
| System.Single |     |

#### VelocityMultiplierElevationRpm

Gets or Sets velocity multiplier for elevation \[rpm\]

##### Declaration

```
float VelocityMultiplierElevationRpm { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### AddTool(IMyFunctionalBlock)

Adds the tool for the block

##### Declaration

```
void AddTool(IMyFunctionalBlock tool)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyFunctionalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyFunctionalBlock.html) | tool | tool (weapons/tools blocks) which player can set in UI |

#### AddTools(List<IMyFunctionalBlock>)

Adds tools for the block

##### Declaration

```
void AddTools(List<IMyFunctionalBlock> tools)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyFunctionalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyFunctionalBlock.html)\> | tools | tools collection (weapons/tools blocks) which player can set in UI |

#### ClearTools()

Clears tools

##### Declaration

#### GetDirectionSource()

Get block that provides direction of shooting

##### Declaration

```
IMyTerminalBlock GetDirectionSource()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) |     |

#### GetShootDirection()

Get direction of shooting.

##### Declaration

```
Vector3 GetShootDirection()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### GetTargetedEntity()

Gets the turret's current detected entity, if any

##### Declaration

```
MyDetectedEntityInfo GetTargetedEntity()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyDetectedEntityInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityInfo.html) | empty info if target does not exist |

#### GetTargetingGroup()

Gets current targeting group

##### Declaration

```
string GetTargetingGroup()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String | current targeting group |

#### GetTargetingGroups()

Obsolete

##### Declaration

```
List<string> GetTargetingGroups()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### GetTargetingGroups(List<String>)

Gets all available targeting groups

##### Declaration

```
void GetTargetingGroups(List<string> targetingGroups)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.String\> | targetingGroups | All targeting groups |

#### GetTools(List<IMyFunctionalBlock>)

Gets tools for the block

##### Declaration

```
void GetTools(List<IMyFunctionalBlock> tools)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyFunctionalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyFunctionalBlock.html)\> | tools | tools collection (weapons/tools blocks) which player can set in UI |

#### RemoveTool(IMyFunctionalBlock)

Removes the tool for the block

##### Declaration

```
void RemoveTool(IMyFunctionalBlock tool)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyFunctionalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyFunctionalBlock.html) | tool | tool (weapons/tools blocks) which player can set in UI |

#### RemoveTools(List<IMyFunctionalBlock>)

Removes tools for the block

##### Declaration

```
void RemoveTools(List<IMyFunctionalBlock> tool)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyFunctionalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyFunctionalBlock.html)\> | tool | tools collection (weapons/tools blocks) which player can set in UI |

#### SetTargetingGroup(String)

Sets current targeting group

##### Declaration

```
void SetTargetingGroup(string groupSubtypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | groupSubtypeId | group subtype id |

### Extension Methods