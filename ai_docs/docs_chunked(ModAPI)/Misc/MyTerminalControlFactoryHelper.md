---
title: "Class MyTerminalControlFactoryHelper"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyTerminalControlFactoryHelper.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "MyTerminalControlFactoryHelper"
---

  Class MyTerminalControlFactoryHelper | Space Engineers ModAPI         

[Show / Hide Table of Contents](#sidetoggle)

# Class MyTerminalControlFactoryHelper

##### Inheritance

System.Object

MyTerminalControlFactoryHelper

##### Implements

[IMyTerminalActionsHelper](Sandbox.ModAPI.IMyTerminalActionsHelper.html)

###### **Namespace**: [Sandbox.ModAPI](Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyTerminalControlFactoryHelper : Object, IMyTerminalActionsHelper
```

### Constructors

#### MyTerminalControlFactoryHelper()

##### Declaration

```
public MyTerminalControlFactoryHelper()
```

### Properties

#### Static

##### Declaration

```
public static MyTerminalControlFactoryHelper Static { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyTerminalControlFactoryHelper](Sandbox.ModAPI.MyTerminalControlFactoryHelper.html) |     |

### Methods

#### GetProperties(Type, List<ITerminalProperty>, Func<ITerminalProperty, Boolean>)

##### Declaration

```
public void GetProperties(Type blockType, List<ITerminalProperty> resultList, Func<ITerminalProperty, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | blockType |     |
| System.Collections.Generic.List<[ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty.html)\> | resultList |     |
| System.Func<[ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty.html), System.Boolean\> | collect |     |

#### GetProperty(String, Type)

##### Declaration

```
public ITerminalProperty GetProperty(string id, Type blockType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | id  |     |
| System.Type | blockType |     |

##### Returns

| Type | Description |
| --- | --- |
| [ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty.html) |     |

### Explicit Interface Implementations

#### IMyTerminalActionsHelper.GetActions(Type, List<ITerminalAction>, Func<ITerminalAction, Boolean>)

##### Declaration

```
void IMyTerminalActionsHelper.GetActions(Type blockType, List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | blockType |     |
| System.Collections.Generic.List<[ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction.html)\> | resultList |     |
| System.Func<[ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction.html), System.Boolean\> | collect |     |

#### IMyTerminalActionsHelper.GetActionWithName(String, Type)

##### Declaration

```
ITerminalAction IMyTerminalActionsHelper.GetActionWithName(string name, Type blockType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| System.Type | blockType |     |

##### Returns

| Type | Description |
| --- | --- |
| [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction.html) |     |

#### IMyTerminalActionsHelper.GetTerminalSystemForGrid(IMyCubeGrid)

##### Declaration

```
IMyGridTerminalSystem IMyTerminalActionsHelper.GetTerminalSystemForGrid(IMyCubeGrid grid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid.html) | grid |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyGridTerminalSystem](Sandbox.ModAPI.IMyGridTerminalSystem.html) |     |

#### IMyTerminalActionsHelper.SearchActionsOfName(String, Type, List<ITerminalAction>, Func<ITerminalAction, Boolean>)

##### Declaration

```
void IMyTerminalActionsHelper.SearchActionsOfName(string name, Type blockType, List<ITerminalAction> resultList, Func<ITerminalAction, bool> collect)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| System.Type | blockType |     |
| System.Collections.Generic.List<[ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction.html)\> | resultList |     |
| System.Func<[ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction.html), System.Boolean\> | collect |     |

### Implements

[IMyTerminalActionsHelper](Sandbox.ModAPI.IMyTerminalActionsHelper.html)

_☀_

_☾_