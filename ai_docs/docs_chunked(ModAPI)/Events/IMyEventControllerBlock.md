---
title: "Interface IMyEventControllerBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyEventControllerBlock.html"
category: "Events"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyEventControllerBlock"
---

# Interface IMyEventControllerBlock | Space Engineers ModAPI

Describes Event Controller Block

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyEventControllerBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### IsAndModeEnabled

Returns whether and mode is enabled. When enabled all selected blocks have to pass the test to trigger the action.

##### Declaration

```
bool IsAndModeEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsLowerOrEqualCondition

Gets/sets if the condition is lower or equal, when false condition is Higher or equal.

##### Declaration

```
bool IsLowerOrEqualCondition { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Threshold

Gets/sets Trigger threshold, which is used to compare if the event is above or bellow

##### Declaration

```
float Threshold { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Extension Methods