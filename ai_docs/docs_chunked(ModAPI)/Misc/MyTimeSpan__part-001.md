---
title: "Class MyTimeSpan"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html"
category: "Misc"
namespace: "VRage.Library.Utils"
class: "MyTimeSpan"
---

# Class MyTimeSpan | Space Engineers ModAPI

Hi-resolution time span. Beware: the resolution can be different on different systems!

##### Inheritance

System.Object

MyTimeSpan

###### **Namespace**: [VRage.Library.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public sealed class MyTimeSpan : ValueType
```

### Constructors

#### MyTimeSpan(Int64)

##### Declaration

```
public MyTimeSpan(long stopwatchTicks)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | stopwatchTicks |     |

### Fields

#### MaxValue

##### Declaration

```
public static readonly MyTimeSpan MaxValue
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) |     |

#### Ticks

##### Declaration

```
public readonly long Ticks
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### Zero

##### Declaration

```
public static readonly MyTimeSpan Zero
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) |     |

### Properties

#### Microseconds

##### Declaration

```
public double Microseconds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### Milliseconds

##### Declaration

```
public double Milliseconds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### Minutes

##### Declaration

```
public double Minutes { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### Nanoseconds

##### Declaration

```
public double Nanoseconds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### Seconds

##### Declaration

```
public double Seconds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### TimeSpan

This may not be accurate for large values - double accuracy

##### Declaration

```
public TimeSpan TimeSpan { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.TimeSpan |     |

### Methods

#### Equals(Object)

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

#### FromMilliseconds(Double)

##### Declaration

```
public static MyTimeSpan FromMilliseconds(double milliseconds)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | milliseconds |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) |     |

#### FromMinutes(Double)

##### Declaration

```
public static MyTimeSpan FromMinutes(double minutes)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | minutes |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) |     |

#### FromSeconds(Double)

##### Declaration

```
public static MyTimeSpan FromSeconds(double seconds)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | seconds |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) |     |

#### FromTicks(Int64)

##### Declaration

```
public static MyTimeSpan FromTicks(long ticks)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | ticks |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### Operators

#### Addition(MyTimeSpan, MyTimeSpan)

##### Declaration

```
public static MyTimeSpan operator +(MyTimeSpan a, MyTimeSpan b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) | a   |     |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) |     |

#### Equality(MyTimeSpan, MyTimeSpan)

##### Declaration

```
public static bool operator ==(MyTimeSpan a, MyTimeSpan b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) | a   |     |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GreaterThan(MyTimeSpan, MyTimeSpan)

##### Declaration

```
public static bool operator>(MyTimeSpan a, MyTimeSpan b)
```
