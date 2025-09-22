---
title: "Class TerminalActionParameter"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.TerminalActionParameter.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "TerminalActionParameter"
---

# Class TerminalActionParameter | Space Engineers ModAPI

Implements terminal action parameter

##### Inheritance

System.Object

TerminalActionParameter

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class TerminalActionParameter : ValueType
```

### Fields

#### Empty

Gets an empty parameter.

##### Declaration

```
public static readonly TerminalActionParameter Empty
```

##### Field Value

| Type | Description |
| --- | --- |
| [TerminalActionParameter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.TerminalActionParameter.html) |     |

#### TypeCode

Gets the type code

##### Declaration

```
public readonly TypeCode TypeCode
```

##### Field Value

| Type | Description |
| --- | --- |
| System.TypeCode |     |

#### Value

Gets the value

##### Declaration

```
public readonly object Value
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Object |     |

### Properties

#### IsEmpty

Gets whether this action is empty

##### Declaration

```
public bool IsEmpty { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Deserialize(String, TypeCode)

##### Declaration

```
public static TerminalActionParameter Deserialize(string serializedValue, TypeCode typeCode)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | serializedValue |     |
| System.TypeCode | typeCode |     |

##### Returns

| Type | Description |
| --- | --- |
| [TerminalActionParameter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.TerminalActionParameter.html) |     |

#### Get(Object)

##### Declaration

```
public static TerminalActionParameter Get(object value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | value |     |

##### Returns

| Type | Description |
| --- | --- |
| [TerminalActionParameter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.TerminalActionParameter.html) |     |

#### GetObjectBuilder()

Gets object builder for the action

##### Declaration

```
public MyObjectBuilder_ToolbarItemActionParameter GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ToolbarItemActionParameter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ToolbarItemActionParameter.html) | instance of object builder |