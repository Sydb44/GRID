---
title: "Class MyEntityStorageComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityStorageComponent.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyEntityStorageComponent"
---

# Class MyEntityStorageComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityStorageComponent

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyEntityStorageComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyEntityStorageComponent()

##### Declaration

```
public MyEntityStorageComponent()
```

### Properties

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

### Methods

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | builder |     |

##### Overrides

#### GetBools()

##### Declaration

```
public SerializableDictionary<string, bool> GetBools()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Serialization.SerializableDictionary<System.String, System.Boolean\> |     |

#### GetBoolsByRegex(Regex)

##### Declaration

```
public Dictionary<string, bool> GetBoolsByRegex(Regex nameRegex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.RegularExpressions.Regex | nameRegex |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Boolean\> |     |

#### GetFloats()

##### Declaration

```
public SerializableDictionary<string, float> GetFloats()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Serialization.SerializableDictionary<System.String, System.Single\> |     |

#### GetInts()

##### Declaration

```
public SerializableDictionary<string, int> GetInts()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Serialization.SerializableDictionary<System.String, System.Int32\> |     |

#### GetLongs()

##### Declaration

```
public SerializableDictionary<string, long> GetLongs()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Serialization.SerializableDictionary<System.String, System.Int64\> |     |

#### GetStrings()

##### Declaration

```
public SerializableDictionary<string, string> GetStrings()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Serialization.SerializableDictionary<System.String, System.String\> |     |

#### GetVector3D()

##### Declaration

```
public SerializableDictionary<string, SerializableVector3D> GetVector3D()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Serialization.SerializableDictionary<System.String, VRage.SerializableVector3D\> |     |

#### IsSerialized()

##### Declaration

```
public override bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### ReadBool(String)

##### Declaration

```
public bool ReadBool(string variableName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | variableName |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ReadBoolList(String)

##### Declaration

```
public List<bool> ReadBoolList(string variableName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | variableName |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Boolean\> |     |

#### ReadFloat(String)

##### Declaration

```
public float ReadFloat(string variableName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | variableName |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReadFloatList(String)

##### Declaration

```
public List<float> ReadFloatList(string variableName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | variableName |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Single\> |     |

#### ReadInt(String)

##### Declaration

```
public int ReadInt(string variableName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | variableName |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ReadIntList(String)

##### Declaration

```
public List<int> ReadIntList(string variableName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | variableName |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Int32\> |     |

#### ReadLong(String)

##### Declaration

```
public long ReadLong(string variableName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | variableName |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### ReadLongList(String)

##### Declaration

```
public List<long> ReadLongList(string variableName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | variableName |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Int64\> |     |

#### ReadString(String)

##### Declaration

```
public string ReadString(string variableName)
```
