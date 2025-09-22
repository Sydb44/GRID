---
title: "Class TextPtr"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame.Utilities"
class: "TextPtr"
---

# Class TextPtr | Space Engineers ModAPI

A parser utility structure representing a pointer to a location within a string.

##### Inheritance

System.Object

TextPtr

###### **Namespace**: [VRage.Game.ModAPI.Ingame.Utilities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class TextPtr : ValueType
```

### Constructors

#### TextPtr(String)

Create a new text pointer at the first character in the given string

##### Declaration

```
public TextPtr(string content)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | content |     |

#### TextPtr(String, Int32)

Create a new text pointer at the given index of the given string

##### Declaration

```
public TextPtr(string content, int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | content |     |
| System.Int32 | index |     |

### Fields

#### Content

The original content string

##### Declaration

```
public readonly string Content
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Index

The index being pointed at by this structure

##### Declaration

```
public readonly int Index
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### Char

Returns the character currently being pointed at, or `\0` if out of bounds

##### Declaration

```
public char Char { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Char |     |

#### IsEmpty

Determines whether this pointer is an empty pointer, i.e. not pointing at anything at all.

##### Declaration

```
public bool IsEmpty { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Find(Char)

Finds the given character

##### Declaration

```
public TextPtr Find(char ch)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Char | ch  |     |

##### Returns

| Type | Description |
| --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) |     |

#### Find(String)

Finds the given text string

##### Declaration

```
public TextPtr Find(string str)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | str |     |

##### Returns

| Type | Description |
| --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) |     |

#### FindAny(Char\[\])

Finds one of the given characters

##### Declaration

```
public TextPtr FindAny(char[] chs)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Char\[\] | chs |     |

##### Returns

| Type | Description |
| --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) |     |

#### FindAnyInLine(Char\[\])

Finds one of the given characters within the current line

##### Declaration

```
public TextPtr FindAnyInLine(char[] chs)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Char\[\] | chs |     |

##### Returns

| Type | Description |
| --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) |     |

#### FindEndOfLine(Boolean)

Finds the end of the current line

##### Declaration

```
public TextPtr FindEndOfLine(bool skipNewline = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | skipNewline | Whether the actual newline character(s) should also be skipped. Defaults to false |

##### Returns

| Type | Description |
| --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) |     |

#### FindInLine(Char)

Finds the given character within the current line

##### Declaration

```
public TextPtr FindInLine(char ch)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Char | ch  |     |

##### Returns

| Type | Description |
| --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) |     |

#### FindLineNo()

Determines what line number this pointer is currently at.

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IsEndOfLine()

Determines whether the pointer is currently at the end of a line (right before a newline character set or end of the string)

##### Declaration

```
public bool IsEndOfLine()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsNewLine()

Determines whether the pointer is currently at a newline (end of the string is not a newline)

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsOutOfBounds()

Determines whether this pointer is currently out of bounds (before or after the string content)

##### Declaration

```
public bool IsOutOfBounds()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsStartOfLine()

Determines whether the pointer is currently at the beginning of a line (right after a newline character set or start of the string)

##### Declaration

```
public bool IsStartOfLine()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SkipWhitespace(Boolean)

Skips whitespace

##### Declaration

```
public TextPtr SkipWhitespace(bool skipNewline = false)
```
