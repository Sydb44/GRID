---
title: "Class MyCommandLine"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame.Utilities"
class: "MyCommandLine"
---

# Class MyCommandLine | Space Engineers ModAPI

A utility class to parse arguments from a command line string. Switches are defined with hyphen (-switch). Quotes can be placed around an argument to parse verbatim, but inner quotes will be copied verbatim. For example, "one"two" will result in the string one"two.

##### Inheritance

System.Object

MyCommandLine

###### **Namespace**: [VRage.Game.ModAPI.Ingame.Utilities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyCommandLine : Object
```

### Constructors

#### MyCommandLine()

##### Declaration

### Properties

#### ArgumentCount

Returns the number of non-switch arguments

##### Declaration

```
public int ArgumentCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Items

Contains all items, both arguments and switches

##### Declaration

```
public MyCommandLine.ItemCollection Items { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCommandLine.ItemCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.ItemCollection.html) |     |

#### Switches

Contains a list of all detected switches

##### Declaration

```
public MyCommandLine.SwitchCollection Switches { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCommandLine.SwitchCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.SwitchCollection.html) |     |

### Methods

#### Argument(Int32)

Returns the argument at the given index. Switches are not counted.

##### Declaration

```
public string Argument(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Clear()

Clears all arguments

##### Declaration

#### Switch(String)

Determines whether the given switch is set. Switches are specified without their prefixed hyphen.

##### Declaration

```
public bool Switch(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Switch(String, Int32)

Gets an argument of a switch. For example, using `Switch("key", 0)` on the command line `someOtherArgument -key value` will return `value`.

##### Declaration

```
public string Switch(string name, int relativeArgument)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| System.Int32 | relativeArgument |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### TryParse(String)

Attempts to parse the given string as a command line

##### Declaration

```
public bool TryParse(string argument)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | argument |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | `true` if there were arguments in the string, `false` otherwise |