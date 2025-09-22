---
title: "Class My5BitEncoding"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.My5BitEncoding.html"
category: "Misc"
namespace: "VRage.Utils"
class: "My5BitEncoding"
---

# Class My5BitEncoding | Space Engineers ModAPI

##### Inheritance

System.Object

My5BitEncoding

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class My5BitEncoding : Object
```

### Constructors

#### My5BitEncoding()

Initializes a new instance of the Encoding5Bit class. Uses characters 0-9 and A-Z except (0,O,1,I).

##### Declaration

#### My5BitEncoding(Char\[\])

Initializes a new instance of the Encoding5Bit class.

##### Declaration

```
public My5BitEncoding(char[] characters)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Char\[\] | characters | 32 characters which will be used when encoding bytes to string. |

### Properties

#### Default

##### Declaration

```
public static My5BitEncoding Default { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [My5BitEncoding](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.My5BitEncoding.html) |     |

### Methods

#### Decode(Char\[\])

Decodes 5bit string as bytes, not alligned characters may be lost. Only decode strings encoded with Encode.

##### Declaration

```
public byte[] Decode(char[] encoded5BitText)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Char\[\] | encoded5BitText |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Byte\[\] |     |

#### Encode(Byte\[\])

Encodes data as 5bit string.

##### Declaration

```
public char[] Encode(byte[] data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte\[\] | data |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Char\[\] |     |