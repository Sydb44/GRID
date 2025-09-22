---
title: "Interface IMyFarmPlotLogic"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyFarmPlotLogic.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyFarmPlotLogic"
---

# Interface IMyFarmPlotLogic | Space Engineers ModAPI

Describes the exposed farm plot logic (PB scripting interface).

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyFarmPlotLogic
```

### Properties

#### AmountOfSeedsRequired

The amount of seeds that are needed to start growing a plant at this farm plot.

##### Declaration

```
int AmountOfSeedsRequired { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IsAlive

Whether the plant is alive.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPlantFullyGrown

Whether the plant is fully grown.

##### Declaration

```
bool IsPlantFullyGrown { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPlantPlanted

Whether a plant is planted, dead or alive.

##### Declaration

```
bool IsPlantPlanted { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OutputItem

The item that the currently planted seed will produce when fully grown.

##### Declaration

```
MyDefinitionId OutputItem { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### OutputItemAmount

The amount of items that the currently planted seed will produce when fully grown. Returns 0 if the plant is not yet fully grown.

##### Declaration

```
int OutputItemAmount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### GetDetailedInfoWithoutRequiredInput()

Obtains detailed info that does not include the required power input. Used by the plant management screen.

##### Declaration

```
string GetDetailedInfoWithoutRequiredInput()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |