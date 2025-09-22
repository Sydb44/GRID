---
title: "Interface IMyMechanicalConnectionBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyMechanicalConnectionBlock.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyMechanicalConnectionBlock"
---

# Interface IMyMechanicalConnectionBlock | Space Engineers ModAPI

Describes blocks linked with [Mechanical](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html#VRage_Game_ModAPI_GridLinkTypeEnum_Mechanical) connection (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyMechanicalConnectionBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### IsAttached

Gets if the block base is attached to something

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsLocked

Gets if the block is safety locked (welded)

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PendingAttachment

Gets if the block is looking for a top part

##### Declaration

```
bool PendingAttachment { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SafetyLock

Gets if the block is safety locked (welded)

##### Declaration

```
bool SafetyLock { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SafetyLockSpeed

Gets or sets the speed at which this device will engage it's safety lock ([IsLocked](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyMechanicalConnectionBlock.html#Sandbox_ModAPI_Ingame_IMyMechanicalConnectionBlock_IsLocked)).

##### Declaration

```
float SafetyLockSpeed { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Top

Gets the attached top part entity

##### Declaration

```
IMyAttachableTopBlock Top { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyAttachableTopBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAttachableTopBlock.html) |     |

#### TopGrid

Gets the grid of the attached top part

##### Declaration

```
IMyCubeGrid TopGrid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeGrid.html) |     |

### Methods

#### Attach()

Attaches a nearby top part to the block

##### Declaration

#### Detach()

Detaches the top from the base

##### Declaration

### Extension Methods