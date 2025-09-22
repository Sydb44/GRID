---
title: "Interface IMyHudObjectiveLine"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyHudObjectiveLine.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyHudObjectiveLine"
---

# Interface IMyHudObjectiveLine | Space Engineers ModAPI

Describes interface of notification (mods interface)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyHudObjectiveLine
```

### Properties

#### CurrentObjective

Gets current objective text

##### Declaration

```
string CurrentObjective { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Objectives

Gets or sets objectives

##### Declaration

```
List<string> Objectives { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### Title

Gets or sets title

##### Declaration

```
string Title { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Visible

Gets if visible

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### AdvanceObjective()

Moves to next objective

##### Declaration

#### Hide()

Hides

##### Declaration

#### Show()

Shows objective

##### Declaration