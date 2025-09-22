---
title: "Interface IMyGridControlSystem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridControlSystem.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyGridControlSystem"
---

# Interface IMyGridControlSystem | Space Engineers ModAPI

ModAPI interface giving access to grid-group control system

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyGridControlSystem
```

### Properties

#### CurrentShipController

Gets the controllable entity of the ship controller currently controlling the grid. Can cast its Entity property to IMyShipController

##### Declaration

```
IMyControllableEntity CurrentShipController { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyControllableEntity.html) |     |

#### IsControlled

Gets whether grid-group is controlled

##### Declaration

```
bool IsControlled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Events

#### IsControlledChanged

Called when [IsControlled](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridControlSystem.html#VRage_Game_ModAPI_IMyGridControlSystem_IsControlled) changed. Invoked with grid main grid that

##### Declaration

```
event Action<bool, IMyCubeGrid> IsControlledChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Boolean, [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\> |     |