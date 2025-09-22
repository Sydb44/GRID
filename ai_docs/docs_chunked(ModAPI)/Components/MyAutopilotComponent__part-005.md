#### SelectGps(List<MyGuiControlListbox.Item>)

##### Declaration

```
public void SelectGps(List<MyGuiControlListbox.Item> selection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<Sandbox.Graphics.GUI.MyGuiControlListbox.Item\> | selection |     |

#### SelectWaypoint(List<MyGuiControlListbox.Item>)

##### Declaration

```
public void SelectWaypoint(List<MyGuiControlListbox.Item> selection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<Sandbox.Graphics.GUI.MyGuiControlListbox.Item\> | selection |     |

#### Serialize(Boolean)

##### Declaration

```
public override MyObjectBuilder_ComponentBase Serialize(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

##### Overrides

#### SetAutopilot(Boolean)

##### Declaration

```
public void SetAutopilot(bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enabled |     |

#### SetAutoPilotEnabled(Boolean)

##### Declaration

```
public void SetAutoPilotEnabled(bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enabled |     |

#### SetCustomAdjustWaypointAboveMinHeightFunction(CustomAdjustWaypointAboveMinHeightFunction)

##### Declaration

```
public void SetCustomAdjustWaypointAboveMinHeightFunction(CustomAdjustWaypointAboveMinHeightFunction function)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CustomAdjustWaypointAboveMinHeightFunction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.CustomAdjustWaypointAboveMinHeightFunction.html) | function |     |

#### SetCustomMovementFunction(CustomMovementFunction)

##### Declaration

```
public void SetCustomMovementFunction(CustomMovementFunction function)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CustomMovementFunction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.CustomMovementFunction.html) | function |     |

#### SetWaitForFreeWay(Boolean)

##### Declaration

```
public void SetWaitForFreeWay(bool waitForFreeWay)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | waitForFreeWay |     |

#### SetWaypoint(MyAutopilotWaypoint)

##### Declaration

```
public void SetWaypoint(MyAutopilotWaypoint waypoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAutopilotWaypoint.html) | waypoint |     |

#### SetWaypoints(List<MyAutopilotWaypoint>, Boolean, Boolean, Boolean)

##### Declaration

```
public void SetWaypoints(List<MyAutopilotWaypoint> newWaypoints, bool continueOnCurrentCourse, bool continueOnReversedCourse, bool fly)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAutopilotWaypoint.html)\> | newWaypoints |     |
| System.Boolean | continueOnCurrentCourse |     |
| System.Boolean | continueOnReversedCourse |     |
| System.Boolean | fly |     |

#### Toolbar\_ItemChanged(MyToolbar, MyToolbar.IndexArgs, Boolean)

##### Declaration

```
public void Toolbar_ItemChanged(MyToolbar self, MyToolbar.IndexArgs index, bool isGamepad)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Screens.Helpers.MyToolbar | self |     |
| Sandbox.Game.Screens.Helpers.MyToolbar.IndexArgs | index |     |
| System.Boolean | isGamepad |     |

#### UpdateAfterSimulation10()

##### Declaration

```
public void UpdateAfterSimulation10()
```

#### UpdateAutopilot()

##### Declaration

```
public void UpdateAutopilot()
```

#### UpdateOnceBeforeFrame()

##### Declaration

```
public void UpdateOnceBeforeFrame()
```

#### UpdateWaypointMatrix(MatrixD)

##### Declaration

```
public void UpdateWaypointMatrix(MatrixD matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix |     |

### Events

#### OnBlockReachedWaypoint

##### Declaration

```
public event Action<MyCubeBlock> OnBlockReachedWaypoint
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)\> |     |

#### OnCurrentWaypointChanged

##### Declaration

```
public event Action OnCurrentWaypointChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnCurrentWaypointIndexChanged

##### Declaration

```
public event Action OnCurrentWaypointIndexChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnMinHeightAboveTerrainChanged

##### Declaration

```
public event Action OnMinHeightAboveTerrainChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnSpeedLimitChanged

##### Declaration

```
public event Action<float> OnSpeedLimitChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Single\> |     |

#### OnWaypointReached

##### Declaration

```
public event Action<MyAutopilotWaypoint> OnWaypointReached
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAutopilotWaypoint.html)\> |     |
