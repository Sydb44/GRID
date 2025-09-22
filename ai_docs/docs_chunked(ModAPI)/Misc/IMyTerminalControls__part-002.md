Gets the controls associated with a block.

##### Declaration

```
void GetControls<TBlock>(out List<IMyTerminalControl> items)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyTerminalControl](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl.html)\> | items | The list that contains the terminal controls for this block |

##### Type Parameters

| Name | Description |
| --- | --- |
| TBlock | This is the object builder type of the associated block you want to get terminal controls for |

#### remove\_CustomActionGetter(CustomActionGetDelegate)

##### Declaration

```
void remove_CustomActionGetter(CustomActionGetDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CustomActionGetDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.CustomActionGetDelegate.html) | value |     |

#### remove\_CustomControlGetter(CustomControlGetDelegate)

##### Declaration

```
void remove_CustomControlGetter(CustomControlGetDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CustomControlGetDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.CustomControlGetDelegate.html) | value |     |

#### RemoveAction<TBlock>(IMyTerminalAction)

This allows you to remove an action from a block

##### Declaration

```
void RemoveAction<TBlock>(IMyTerminalAction action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction.html) | action | An IMyTerminalAction object |

##### Type Parameters

| Name | Description |
| --- | --- |
| TBlock | The ModAPI interface of the associated block |

#### RemoveControl<TBlock>(IMyTerminalControl)

Removes a terminal control from a block.

##### Declaration

```
void RemoveControl<TBlock>(IMyTerminalControl item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalControl](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl.html) | item | This is the control you're removing. Use GetControls to get the item itself. |

##### Type Parameters

| Name | Description |
| --- | --- |
| TBlock | This is the ModAPI interface of the associated block you want to remove a terminal control from |

### Events

#### CustomActionGetter

This event allows you to modify the list of actions available when a user wants to select an action for a block in the toolbar. Modifying the list in this event modifies the list displayed to the user so that you can customize it in specific situations (like blocks with different subtypes, or even on specific blocks by entityId)

##### Declaration

```
event CustomActionGetDelegate CustomActionGetter
```

##### Event Type

| Type | Description |
| --- | --- |
| [CustomActionGetDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.CustomActionGetDelegate.html) |     |

#### CustomControlGetter

This event allows you to modify the list of controls that the game displays when a user selects a block. Each time terminal controls are enumerated for a block, this delegate is called, which allows you to modify the control list directly, and remove/add as you see fit before the controls are displayed. This is to allow fine grain control of the controls being displayed, so you can display only controls you want to in specific situations (like blocks with different subtypes, or even on specific blocks by entityId)

##### Declaration

```
event CustomControlGetDelegate CustomControlGetter
```

##### Event Type

| Type | Description |
| --- | --- |
| [CustomControlGetDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.CustomControlGetDelegate.html) |     |