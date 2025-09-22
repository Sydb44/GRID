---
title: "Class MyGridProgram"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyGridProgram.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "MyGridProgram"
---

# Class MyGridProgram | Space Engineers ModAPI

All programmable block scripts derive from this class, meaning that all properties in this class are directly available for use in your scripts. If you use Visual Studio or other external editors to write your scripts, you can derive directly from this class and have a compatible script template.

##### Inheritance

System.Object

MyGridProgram

##### Implements

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public abstract class MyGridProgram : Object, IMyGridProgram
```

##### **Examples**

```
public void Main()
{
// Print out the time elapsed since the currently running programmable block was run
// the last time.
Echo(Me.CustomName + " was last run " + Runtime.TimeSinceLastRun.TotalSeconds + " seconds ago.");
}
```

### Constructors

#### MyGridProgram()

Implements MyGridProgram constructor

##### Declaration

```
protected MyGridProgram()
```

### Properties

#### Echo

Prints out text onto the currently running programmable block's detail info area.

##### Declaration

```
public Action<string> Echo { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<System.String\> |     |

#### GridTerminalSystem

Provides access to the grid terminal system as viewed from this programmable block.

##### Declaration

```
public IMyGridTerminalSystem GridTerminalSystem { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyGridTerminalSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyGridTerminalSystem.html) |     |

#### IGC

Gets IGC instance

##### Declaration

```
public IMyIntergridCommunicationSystem IGC { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyIntergridCommunicationSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem.html) |     |

#### Me

Gets a reference to the currently running programmable block.

##### Declaration

```
public IMyProgrammableBlock Me { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyProgrammableBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyProgrammableBlock.html) |     |

#### Runtime

Gets runtime information for the running grid program.

##### Declaration

```
public IMyGridProgramRuntimeInfo Runtime { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyGridProgramRuntimeInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyGridProgramRuntimeInfo.html) |     |

#### Storage

Allows you to store data between game sessions.

##### Declaration

```
public string Storage { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### World

Gets world information for the running grid program.

##### Declaration

```
public IMyGridProgramWorldInfo World { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyGridProgramWorldInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyGridProgramWorldInfo.html) |     |

### Explicit Interface Implementations

#### IMyGridProgram.Echo

##### Declaration

```
Action<string> IMyGridProgram.Echo { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Action<System.String\> |     |

#### IMyGridProgram.GridTerminalSystem

##### Declaration

```
IMyGridTerminalSystem IMyGridProgram.GridTerminalSystem { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyGridTerminalSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyGridTerminalSystem.html) |     |

#### IMyGridProgram.HasMainMethod

##### Declaration

```
bool IMyGridProgram.HasMainMethod { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyGridProgram.HasSaveMethod

##### Declaration

```
bool IMyGridProgram.HasSaveMethod { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyGridProgram.IGC\_ContextGetter

##### Declaration

```
Func<IMyIntergridCommunicationSystem> IMyGridProgram.IGC_ContextGetter { set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Func<[IMyIntergridCommunicationSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem.html)\> |     |

#### IMyGridProgram.Main(String)

##### Declaration

```
void IMyGridProgram.Main(string argument)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | argument |     |

#### IMyGridProgram.Main(String, UpdateType)

##### Declaration

```
void IMyGridProgram.Main(string argument, UpdateType updateSource)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | argument |     |
| [UpdateType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateType.html) | updateSource |     |

#### IMyGridProgram.Me

##### Declaration

```
IMyProgrammableBlock IMyGridProgram.Me { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyProgrammableBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyProgrammableBlock.html) |     |

#### IMyGridProgram.Runtime

##### Declaration

```
IMyGridProgramRuntimeInfo IMyGridProgram.Runtime { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyGridProgramRuntimeInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyGridProgramRuntimeInfo.html) |     |
