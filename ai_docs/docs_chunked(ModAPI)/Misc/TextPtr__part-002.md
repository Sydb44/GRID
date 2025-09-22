| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SkipWhitespace(Boolean)

Skips whitespace

##### Declaration

```
public TextPtr SkipWhitespace(bool skipNewline = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | skipNewline | Whether to also skip newlines |

##### Returns

| Type | Description |
| --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) |     |

#### StartsWith(String)

Determines if the current pointer location starts with the given string - in a case sensitive manner.

##### Declaration

```
public bool StartsWith(string what)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | what |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### StartsWithCaseInsensitive(String)

Determines if the current pointer location starts with the given string - in a case insensitive manner.

##### Declaration

```
public bool StartsWithCaseInsensitive(string what)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | what |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TrimEnd()

Reverses the pointer location until all whitespace is skipped - does not skip newlines

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) |     |

#### TrimStart()

Advances the pointer location until all whitespace is skipped - does not skip newlines

##### Declaration

```
public TextPtr TrimStart()
```

##### Returns

| Type | Description |
| --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) |     |

### Operators

#### Addition(TextPtr, Int32)

Add an offset to a pointer

##### Declaration

```
public static TextPtr operator +(TextPtr ptr, int offset)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) | ptr |     |
| System.Int32 | offset |     |

##### Returns

| Type | Description |
| --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) |     |

#### Decrement(TextPtr)

Decrement a pointer by one

##### Declaration

```
public static TextPtr operator --(TextPtr ptr)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) | ptr |     |

##### Returns

| Type | Description |
| --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) |     |

#### Implicit(TextPtr to Int32)

Implicitly return the index into the string

##### Declaration

```
public static implicit operator int (TextPtr ptr)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) | ptr |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Implicit(TextPtr to String)

Implicitly return the original string

##### Declaration

```
public static implicit operator string (TextPtr ptr)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) | ptr |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Increment(TextPtr)

Increment a pointer by one

##### Declaration

```
public static TextPtr operator ++(TextPtr ptr)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) | ptr |     |

##### Returns

| Type | Description |
| --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) |     |

#### Subtraction(TextPtr, Int32)

Subtract an offset from a pointer

##### Declaration

```
public static TextPtr operator -(TextPtr ptr, int offset)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) | ptr |     |
| System.Int32 | offset |     |

##### Returns

| Type | Description |
| --- | --- |
| [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html) |     |