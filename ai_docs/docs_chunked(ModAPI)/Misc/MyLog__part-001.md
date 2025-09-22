---
title: "Class MyLog"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyLog.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyLog"
---

# Class MyLog | Space Engineers ModAPI

##### Inheritance

System.Object

MyLog

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyLog : Object
```

### Constructors

#### MyLog(Boolean)

##### Declaration

```
public MyLog(bool alwaysFlush = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | alwaysFlush |     |

### Fields

#### AssertLevel

##### Declaration

```
public static MyLogSeverity AssertLevel
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyLogSeverity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyLogSeverity.html) |     |

#### OnLog

##### Declaration

```
public static Action<MyLogSeverity, StringBuilder> OnLog
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[MyLogSeverity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyLogSeverity.html), System.Text.StringBuilder\> |     |

#### ReportOutOfStorageAction

##### Declaration

```
public static Action ReportOutOfStorageAction
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action |     |

### Properties

#### Default

##### Declaration

```
public static MyLog Default { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyLog](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyLog.html) |     |

#### LogEnabled

##### Declaration

```
public bool LogEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Options

##### Declaration

```
public LoggingOptions Options { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [LoggingOptions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.LoggingOptions.html) |     |

### Methods

#### AppendToClosedLog(Exception)

##### Declaration

```
public void AppendToClosedLog(Exception e)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Exception | e   |     |

#### AppendToClosedLog(String)

##### Declaration

```
public void AppendToClosedLog(string text)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | text |     |

#### Close(Boolean)

##### Declaration

```
public void Close(bool enableWriting = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enableWriting |     |

#### DecreaseIndent()

##### Declaration

```
public void DecreaseIndent()
```

#### DecreaseIndent(LoggingOptions)

##### Declaration

```
public void DecreaseIndent(LoggingOptions option)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LoggingOptions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.LoggingOptions.html) | option |     |

#### Flush()

##### Declaration

#### GetFilePath()

##### Declaration

```
public string GetFilePath()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetTextWriter()

##### Declaration

```
public TextWriter GetTextWriter()
```

##### Returns

| Type | Description |
| --- | --- |
| System.IO.TextWriter |     |

#### IncreaseIndent()

##### Declaration

```
public void IncreaseIndent()
```

#### IncreaseIndent(LoggingOptions)

##### Declaration

```
public void IncreaseIndent(LoggingOptions option)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LoggingOptions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.LoggingOptions.html) | option |     |

#### IndentUsing(LoggingOptions)

##### Declaration

```
public MyLog.IndentToken IndentUsing(LoggingOptions options)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LoggingOptions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.LoggingOptions.html) | options |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyLog.IndentToken](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyLog.IndentToken.html) |     |

#### Init(String, StringBuilder)

##### Declaration

```
public void Init(string logFileName, StringBuilder appVersionString)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | logFileName |     |
| System.Text.StringBuilder | appVersionString |     |

#### InitWithDate(String, StringBuilder, Int32)

##### Declaration

```
public void InitWithDate(string logNameBaseName, StringBuilder appVersionString, int maxLogAgeInDays)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | logNameBaseName |     |
| System.Text.StringBuilder | appVersionString |     |
| System.Int32 | maxLogAgeInDays |     |

#### IsIndentKeyIncreased()

##### Declaration

```
public bool IsIndentKeyIncreased()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Log(MyLogSeverity, String, Object\[\])

##### Declaration

```
public void Log(MyLogSeverity severity, string format, params object[] args)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyLogSeverity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyLogSeverity.html) | severity |     |
| System.String | format |     |
| System.Object\[\] | args |     |

#### Log(MyLogSeverity, StringBuilder)

##### Declaration

```
public void Log(MyLogSeverity severity, StringBuilder builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyLogSeverity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyLogSeverity.html) | severity |     |
| System.Text.StringBuilder | builder |     |
