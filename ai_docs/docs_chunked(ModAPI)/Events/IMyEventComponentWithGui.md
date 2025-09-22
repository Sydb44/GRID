---
title: "Interface IMyEventComponentWithGui"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyEventComponentWithGui.html"
category: "Events"
namespace: "Sandbox.ModAPI"
class: "IMyEventComponentWithGui"
---

# Interface IMyEventComponentWithGui | Space Engineers ModAPI

Describes interface of event controller entity component, which requires UI in the terminal panel

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyEventComponentWithGui : IMyEventControllerEntityComponent
```

### Properties

#### IsBlocksListUsed

Gets whether the block list UI is used

##### Declaration

```
bool IsBlocksListUsed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsConditionSelectionUsed

Gets whether the condition selection UI is used

##### Declaration

```
bool IsConditionSelectionUsed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsThresholdUsed

Gets whether the threshold UI is used

##### Declaration

```
bool IsThresholdUsed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### AddBlocks(List<IMyTerminalBlock>)

Adds the specified block to the monitoring of the event

##### Declaration

```
void AddBlocks(List<IMyTerminalBlock> blocks)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html)\> | blocks | block |

#### IsBlockValidForList(IMyTerminalBlock)

Gets the information if the specified block is valid for the block list UI

##### Declaration

```
bool IsBlockValidForList(IMyTerminalBlock block)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html) | block | block |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if block should be in the selection |

#### NotifyValuesChanged()

Notifies about change of some UI value, which is required for this event

##### Declaration

```
void NotifyValuesChanged()
```

#### RemoveBlocks(IEnumerable<IMyTerminalBlock>)

Removes the specified block from the monitoring

##### Declaration

```
void RemoveBlocks(IEnumerable<IMyTerminalBlock> blocks)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html)\> | blocks | block |