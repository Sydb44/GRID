---
title: "Interface IMyCubeBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame"
class: "IMyCubeBlock"
---

# Interface IMyCubeBlock | Space Engineers ModAPI

Basic cube interface

##### Inherited Members

###### **Namespace**: [VRage.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyCubeBlock : IMyEntity
```

### Properties

#### BlockDefinition

Gets definition.Id assigned to this block

##### Declaration

```
SerializableDefinitionId BlockDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html) |     |

#### CubeGrid

Grid in which the block is placed

##### Declaration

```
IMyCubeGrid CubeGrid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeGrid.html) |     |

#### DefinitionDisplayNameText

Definition name

##### Declaration

```
string DefinitionDisplayNameText { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### DisassembleRatio

Is set in definition Ratio at which is the block disassembled (grinding) Bigger values - longer grinding

##### Declaration

```
float DisassembleRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DisplayNameText

Translated block name

##### Declaration

```
string DisplayNameText { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### IsBeingHacked

Hacking of the block is in progress

##### Declaration

```
bool IsBeingHacked { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsFunctional

Gets if integrity is above breaking threshold

##### Declaration

```
bool IsFunctional { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsWorking

True if block is able to do its work depening on block type (is functional, powered, enabled, etc...)

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Mass

Block mass

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Max

Maximum coordinates of grid cells occupied by this block

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Min

Minimum coordinates of grid cells occupied by this block

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### NumberInGrid

Order in which were the blocks of same type added to grid Used in default display name

##### Declaration

```
int NumberInGrid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Orientation

Returns block orientation in base 6 directions

##### Declaration

```
MyBlockOrientation Orientation { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html) |     |

#### OwnerId

IdentityId of player owning block (not steam Id)

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### Position

Position in grid coordinates

##### Declaration

```
Vector3I Position { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

### Methods

#### GetOwnerFactionTag()

Tag of faction owning block

##### Declaration

```
string GetOwnerFactionTag()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetPlayerRelationToOwner()

Relation of local player to the block Should not be called on Dedicated Server.

##### Declaration

```
MyRelationsBetweenPlayerAndBlock GetPlayerRelationToOwner()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html) | Relation |

#### GetUserRelationToOwner(Int64, MyRelationsBetweenPlayerAndBlock)

Gets relation to owner of block

##### Declaration

```
MyRelationsBetweenPlayerAndBlock GetUserRelationToOwner(long playerId, MyRelationsBetweenPlayerAndBlock defaultNoUser)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId | IdentityId of player to check relation with (not steam id!) |
| [MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html) | defaultNoUser |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html) | Relation of defined player to the block |

#### UpdateIsWorking()

Force refresh working state. Call if you change block state that could affect its working status.

##### Declaration

#### UpdateVisual()

Updates block visuals (ie. block emissivity)

##### Declaration