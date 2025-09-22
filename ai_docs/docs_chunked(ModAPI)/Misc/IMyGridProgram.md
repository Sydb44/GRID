---
title: "Interface IMyGridProgram"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyGridProgram.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyGridProgram"
---

# Interface IMyGridProgram | Space Engineers ModAPI

The interface for the grid program provides extra access for the game and for mods. See [MyGridProgram](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyGridProgram.html) for the class the scripts actually derive from.

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyGridProgram
```

### Properties

#### Echo

Gets or sets the action which prints out text onto the currently running programmable block's detail info area.

##### Declaration

```
Action<string> Echo { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<System.String\> |     |

#### GridTerminalSystem

Gets or sets the GridTerminalSystem available for the grid programs.

##### Declaration

```
IMyGridTerminalSystem GridTerminalSystem { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyGridTerminalSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyGridTerminalSystem.html) |     |

#### HasMainMethod

Determines whether this grid program has a valid Main method.

##### Declaration

```
bool HasMainMethod { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### HasSaveMethod

Determines whether this grid program has a valid Save method.

##### Declaration

```
bool HasSaveMethod { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IGC\_ContextGetter

##### Declaration

```
Func<IMyIntergridCommunicationSystem> IGC_ContextGetter { set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Func<[IMyIntergridCommunicationSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem.html)\> |     |

#### Me

Gets or sets the programmable block which is currently running this grid program.

##### Declaration

```
IMyProgrammableBlock Me { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyProgrammableBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyProgrammableBlock.html) |     |

#### Runtime

Gets or sets the object used to provide runtime information for the running grid program.

##### Declaration

```
IMyGridProgramRuntimeInfo Runtime { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyGridProgramRuntimeInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyGridProgramRuntimeInfo.html) |     |

#### Storage

Gets or sets the storage string for this grid program.

##### Declaration

```
string Storage { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### World

Gets or sets the object used to provide world information for the running grid progrma.

##### Declaration

```
IMyGridProgramWorldInfo World { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyGridProgramWorldInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyGridProgramWorldInfo.html) |     |

### Methods

#### Main(String)

Invokes this grid program.

##### Declaration

```
void Main(string argument)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | argument |     |

#### Main(String, UpdateType)

Invokes this grid program with the given update source.

##### Declaration

```
void Main(string argument, UpdateType updateSource)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | argument |     |
| [UpdateType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateType.html) | updateSource |     |

#### Save()

If this grid program has state saving capability, calling this method will invoke it.

##### Declaration