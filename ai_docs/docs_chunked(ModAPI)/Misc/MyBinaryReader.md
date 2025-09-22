---
title: "Class MyBinaryReader"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyBinaryReader.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyBinaryReader"
---

# Class MyBinaryReader | Space Engineers ModAPI

##### Inheritance

System.Object

MyBinaryReader

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyBinaryReader : BinaryReader
```

### Constructors

#### MyBinaryReader(Stream)

##### Declaration

```
public MyBinaryReader(Stream stream)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IO.Stream | stream |     |

#### MyBinaryReader(Stream, Encoding)

##### Declaration

```
public MyBinaryReader(Stream stream, Encoding encoding)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IO.Stream | stream |     |
| System.Text.Encoding | encoding |     |

### Methods

#### Read7BitEncodedInt()

##### Declaration

```
public int Read7BitEncodedInt()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ReadStringIncomplete(out Boolean)

##### Declaration

```
public string ReadStringIncomplete(out bool isComplete)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | isComplete |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |