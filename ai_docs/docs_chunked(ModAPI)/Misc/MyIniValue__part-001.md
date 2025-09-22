---
title: "Class MyIniValue"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame.Utilities"
class: "MyIniValue"
---

# Class MyIniValue | Space Engineers ModAPI

Represents the value of a single configuration item.

##### Inheritance

System.Object

MyIniValue

###### **Namespace**: [VRage.Game.ModAPI.Ingame.Utilities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyIniValue : ValueType
```

### Constructors

#### MyIniValue(MyIniKey, String)

##### Declaration

```
public MyIniValue(MyIniKey key, string value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | key |     |
| System.String | value |     |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.ArgumentException | Configuration value cannot use an empty key |

### Fields

#### EMPTY

##### Declaration

```
public static readonly MyIniValue EMPTY
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyIniValue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.html) |     |

#### Key

Gets the [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) this value was retrieved from

##### Declaration

```
public readonly MyIniKey Key
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) |     |

### Properties

#### IsEmpty

Determines whether this value is empty. Be aware that an empty string is not considered to be an empty value.

##### Declaration

```
public bool IsEmpty { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetLines(List<String>)

Retrieves each individual line of this value into the provided list.

##### Declaration

```
public void GetLines(List<string> lines)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.String\> | lines |     |

#### ToBoolean(Boolean)

Attempts to get this value as a System.Boolean. If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

##### Declaration

```
public bool ToBoolean(bool defaultValue = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | defaultValue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ToByte(Byte)

Attempts to get this value as a System.Byte. If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

##### Declaration

```
public byte ToByte(byte defaultValue = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte | defaultValue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Byte |     |

#### ToChar(Char)

Attempts to get this value as a System.Char. If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

##### Declaration

```
public char ToChar(char defaultValue = '\0')
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Char | defaultValue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Char |     |

#### ToDecimal(Decimal)

Attempts to get this value as a System.Decimal. If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

##### Declaration

```
public Decimal ToDecimal(Decimal defaultValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Decimal | defaultValue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Decimal |     |

#### ToDouble(Double)

Attempts to get this value as a System.Double. If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

##### Declaration

```
public double ToDouble(double defaultValue = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | defaultValue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### ToInt16(Int16)

Attempts to get this value as a System.Int16. If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

##### Declaration

```
public short ToInt16(short defaultValue = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int16 | defaultValue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int16 |     |

#### ToInt32(Int32)

Attempts to get this value as a System.Int32. If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

##### Declaration

```
public int ToInt32(int defaultValue = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | defaultValue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ToInt64(Int64)

Attempts to get this value as a System.Int64. If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

##### Declaration

```
public long ToInt64(long defaultValue = 0L)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | defaultValue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### ToSByte(SByte)

Attempts to get this value as a System.SByte. If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.
