#### FillFlightModeCombo(List<MyTerminalControlComboBoxItem>)

##### Declaration

```
public static void FillFlightModeCombo(List<MyTerminalControlComboBoxItem> list)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyTerminalControlComboBoxItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyTerminalControlComboBoxItem.html)\> | list |     |

#### FillGpsList(ICollection<MyGuiControlListbox.Item>, ICollection<MyGuiControlListbox.Item>)

##### Declaration

```
public void FillGpsList(ICollection<MyGuiControlListbox.Item> gpsItemList, ICollection<MyGuiControlListbox.Item> selectedGpsItemList)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.ICollection<Sandbox.Graphics.GUI.MyGuiControlListbox.Item\> | gpsItemList |     |
| System.Collections.Generic.ICollection<Sandbox.Graphics.GUI.MyGuiControlListbox.Item\> | selectedGpsItemList |     |

#### FillWaypointList(ICollection<MyGuiControlListbox.Item>, ICollection<MyGuiControlListbox.Item>)

##### Declaration

```
public void FillWaypointList(ICollection<MyGuiControlListbox.Item> waypoints, ICollection<MyGuiControlListbox.Item> selectedWaypoints)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.ICollection<Sandbox.Graphics.GUI.MyGuiControlListbox.Item\> | waypoints |     |
| System.Collections.Generic.ICollection<Sandbox.Graphics.GUI.MyGuiControlListbox.Item\> | selectedWaypoints |     |

#### ForceRotateRequested(Nullable<QuaternionD>)

##### Declaration

```
public void ForceRotateRequested(Nullable<QuaternionD> rotation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<[QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html)\> | rotation |     |

#### ForceRotateToLookAtRequested(Boolean)

##### Declaration

```
public void ForceRotateToLookAtRequested(bool shouldRotate)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | shouldRotate |     |

#### GetCurrentLookVector()

##### Declaration

```
public Nullable<Vector3D> GetCurrentLookVector()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### GetDestinationTriggerSphereScaleFactor(MyCubeSize)

##### Declaration

```
public static double GetDestinationTriggerSphereScaleFactor(MyCubeSize gridSizeEnum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeSize](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCubeSize.html) | gridSizeEnum |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### Init(MyComponentDefinitionBase)

##### Declaration

```
public override void Init(MyComponentDefinitionBase definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html) | definition |     |

##### Overrides

#### InitWithObjectBuilder(MyObjectBuilder\_RemoteControl)

##### Declaration

```
public void InitWithObjectBuilder(MyObjectBuilder_RemoteControl ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_RemoteControl](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_RemoteControl.html) | ob  |     |

#### InitWithOwnObjectBuilder()

##### Declaration

```
public void InitWithOwnObjectBuilder()
```

#### IsSerialized()

##### Declaration

```
public override bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### MoveSelectedWaypointsDown()

##### Declaration

```
public void MoveSelectedWaypointsDown()
```

#### MoveSelectedWaypointsUp()

##### Declaration

```
public void MoveSelectedWaypointsUp()
```

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### OnEvasiveManeuversChanged(Int32, Int32)

##### Declaration

```
public void OnEvasiveManeuversChanged(int interval, int duration)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | interval |     |
| System.Int32 | duration |     |

#### OnRemoveWaypoints(Int32\[\])

##### Declaration

```
[Event(null, 3282)]
[Reliable]
[Server]
[Broadcast]
public void OnRemoveWaypoints(int[] indexes)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32\[\] | indexes |     |

#### PasteAutopilotSetup()

##### Declaration

```
public void PasteAutopilotSetup()
```

#### RaisePropertiesChangedRemote()

##### Declaration

```
public void RaisePropertiesChangedRemote()
```

#### RemoveAutoPilot()

##### Declaration

```
public void RemoveAutoPilot()
```

#### RemoveSelectedWaypoints()

##### Declaration

```
public void RemoveSelectedWaypoints()
```

#### RemoveWaypoint(MyAutopilotWaypoint)

##### Declaration

```
public void RemoveWaypoint(MyAutopilotWaypoint waypoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAutopilotWaypoint.html) | waypoint |     |

#### ResetShipControls()

##### Declaration

```
public void ResetShipControls()
```

#### ResetWaypoint()

##### Declaration

```
public void ResetWaypoint()
```

#### SelectGps(List<MyGuiControlListbox.Item>)

##### Declaration

```
public void SelectGps(List<MyGuiControlListbox.Item> selection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<Sandbox.Graphics.GUI.MyGuiControlListbox.Item\> | selection |     |
