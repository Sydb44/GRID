---
title: "Class MyIniKey"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame.Utilities"
class: "MyIniKey"
---

# Class MyIniKey | Space Engineers ModAPI

Represents the combination of a section and a key in a [MyIni](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIni.html) structure.

##### Inheritance

System.Object

MyIniKey

###### **Namespace**: [VRage.Game.ModAPI.Ingame.Utilities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyIniKey : ValueType, IEquatable<MyIniKey>
```

### Constructors

#### MyIniKey(String, String)

Creates a new instance of [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html)

##### Declaration

```
public MyIniKey(string section, string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |
| System.String | name |     |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.ArgumentException | Section cannot be empty. |
| System.ArgumentException | Section contains illegal characters |
| System.ArgumentException | Key cannot be empty. |
| System.ArgumentException | Key contains illegal characters |

### Fields

#### EMPTY

##### Declaration

```
public static readonly MyIniKey EMPTY
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) |     |

### Properties

#### IsEmpty

Determines whether this [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) is empty.

##### Declaration

```
public bool IsEmpty { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Name

Gets the Key part of this [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html)

##### Declaration

```
public string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Section

Gets the Section part of this [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html)

##### Declaration

```
public string Section { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### Equals(Object)

Compares this [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) with another. Note that this is equality in the sense of a configuration key, which means the comparison is implicitly case insensitive.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(MyIniKey)

Compares this [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) with another. Note that this is equality in the sense of a configuration key, which means the comparison is implicitly case insensitive.

##### Declaration

```
public bool Equals(MyIniKey other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetHashCode()

Gets the hash code representing this [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html)

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Parse(String)

Parses a string in the form of `section/key` into a [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) object.

##### Declaration

```
public static MyIniKey Parse(string input)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | input |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) |     |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.ArgumentException | invalid configuration key format |

#### ToString()

Generates a string representing this [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) in the form of `section/key`.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### TryParse(String, out MyIniKey)

Parses a string in the form of `section/key` into a [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) object.

##### Declaration

```
public static bool TryParse(string input, out MyIniKey key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | input |     |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | key |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Operators

#### Equality(MyIniKey, MyIniKey)

Checks the two given [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html)s for equality. Note that this is equality in the sense of a configuration key, which means the comparison is implicitly case insensitive.
