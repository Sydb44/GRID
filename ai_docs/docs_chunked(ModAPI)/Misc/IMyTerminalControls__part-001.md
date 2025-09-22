---
title: "Interface IMyTerminalControls"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalControls.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyTerminalControls"
---

# Interface IMyTerminalControls | Space Engineers ModAPI

This interface allows you to query, add or remove terminal controls for a block. The terminal controls are the controls that appear in the terminal screen when you select a block. You may add new controls, remove existing controls, or modify existing controls.

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTerminalControls
```

### Methods

#### add\_CustomActionGetter(CustomActionGetDelegate)

##### Declaration

```
void add_CustomActionGetter(CustomActionGetDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CustomActionGetDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.CustomActionGetDelegate.html) | value |     |

#### add\_CustomControlGetter(CustomControlGetDelegate)

##### Declaration

```
void add_CustomControlGetter(CustomControlGetDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CustomControlGetDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.CustomControlGetDelegate.html) | value |     |

#### AddAction<TBlock>(IMyTerminalAction)

This allows you to add an action to an associated block

##### Declaration

```
void AddAction<TBlock>(IMyTerminalAction action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction.html) | action | An IMyTerminalAction object returned from CreateAction |

##### Type Parameters

| Name | Description |
| --- | --- |
| TBlock | The ModAPI interface of the associated block |

#### AddControl<TBlock>(IMyTerminalControl)

Adds a terminal control to a block.

##### Declaration

```
void AddControl<TBlock>(IMyTerminalControl item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalControl](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl.html) | item | This is the control you're adding, created with CreateControl or CreateProperty |

##### Type Parameters

| Name | Description |
| --- | --- |
| TBlock | This is the ModAPI interface of the associated block you want to add a terminal control to |

#### CreateAction<TBlock>(String)

This allows you to create an action to associate with a block

##### Declaration

```
IMyTerminalAction CreateAction<TBlock>(string id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | id  | A unique identifier for this action |

##### Returns

| Type | Description |
| --- | --- |
| [IMyTerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction.html) | An IMyTerminalAction object |

##### Type Parameters

| Name | Description |
| --- | --- |
| TBlock | The ModAPI interface of the associated block |

#### CreateControl<TControl, TBlock>(String)

This creates a control that can be added to a block.

##### Declaration

```
TControl CreateControl<TControl, TBlock>(string id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | id  | A unique identifier for this control |

##### Returns

| Type | Description |
| --- | --- |
| TControl | Returns an interface to the control you've created depending on TControl |

##### Type Parameters

| Name | Description |
| --- | --- |
| TControl | The type of control you're creating |
| TBlock | The ModAPI interface of the associated block |

#### CreateProperty<TValue, TBlock>(String)

This creates a property that can be added to a block. A property is not visible on the terminal screen but can hold a value that can be used in programmable blocks.

##### Declaration

```
IMyTerminalControlProperty<TValue> CreateProperty<TValue, TBlock>(string id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | id  | A unique identifier for this property |

##### Returns

| Type | Description |
| --- | --- |
| [IMyTerminalControlProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlProperty-1.html)<TValue> | Returns an IMyTerminalControlProperty that can be added to a block via AddControl |

##### Type Parameters

| Name | Description |
| --- | --- |
| TValue | The type of property you're creating |
| TBlock | The ModAPI interface of the associated block |

#### GetActions<TBlock>(out List<IMyTerminalAction>)

This allows you to get all actions associated with this block.

##### Declaration

```
void GetActions<TBlock>(out List<IMyTerminalAction> items)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyTerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction.html)\> | items | The list that contains the actions associated with this block |

##### Type Parameters

| Name | Description |
| --- | --- |
| TBlock | The ModAPI interface of the associated block |

#### GetControls<TBlock>(out List<IMyTerminalControl>)

Gets the controls associated with a block.

##### Declaration

```
void GetControls<TBlock>(out List<IMyTerminalControl> items)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyTerminalControl](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl.html)\> | items | The list that contains the terminal controls for this block |
