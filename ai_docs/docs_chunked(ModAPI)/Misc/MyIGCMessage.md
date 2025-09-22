---
title: "Class MyIGCMessage"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyIGCMessage.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "MyIGCMessage"
---

# Class MyIGCMessage | Space Engineers ModAPI

Provides info about received message along with received data

##### Inheritance

System.Object

MyIGCMessage

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class MyIGCMessage : ValueType
```

### Constructors

#### MyIGCMessage(Object, String, Int64)

Implements MyIGCMessage constructor

##### Declaration

```
public MyIGCMessage(object data, string tag, long source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | data | data |
| System.String | tag | tag |
| System.Int64 | source | source |

### Fields

#### Data

The data received in message.

##### Declaration

```
public readonly object Data
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Object |     |

#### Source

Source/Author of this message.

##### Declaration

```
public readonly long Source
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### Tag

Tag designing type of this message.

##### Declaration

```
public readonly string Tag
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### As<TData>()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| TData |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| TData |     |