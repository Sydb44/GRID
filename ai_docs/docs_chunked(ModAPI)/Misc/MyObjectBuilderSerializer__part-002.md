| Type | Name | Description |
| --- | --- | --- |
| System.String | path |     |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) | objectBuilder |     |
| System.Type | builderType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DeserializeXML<T>(Byte\[\], out T, out UInt64)

##### Declaration

```
public static bool DeserializeXML<T>(byte[] xmlData, out T objectBuilder, out ulong fileSize)
    where T : MyObjectBuilder_Base
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte\[\] | xmlData |     |
| T   | objectBuilder |     |
| System.UInt64 | fileSize |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### DeserializeXML<T>(String, out T)

##### Declaration

```
public static bool DeserializeXML<T>(string path, out T objectBuilder)
    where T : MyObjectBuilder_Base
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path |     |
| T   | objectBuilder |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### DeserializeXML<T>(String, out T, out UInt64)

##### Declaration

```
public static bool DeserializeXML<T>(string path, out T objectBuilder, out ulong fileSize)
    where T : MyObjectBuilder_Base
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path |     |
| T   | objectBuilder |     |
| System.UInt64 | fileSize |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### SerializePB(String, Boolean, MyObjectBuilder\_Base)

##### Declaration

```
public static bool SerializePB(string path, bool compress, MyObjectBuilder_Base objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path |     |
| System.Boolean | compress |     |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) | objectBuilder |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SerializePB(String, Boolean, MyObjectBuilder\_Base, out UInt64)

##### Declaration

```
public static bool SerializePB(string path, bool compress, MyObjectBuilder_Base objectBuilder, out ulong sizeInBytes)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path |     |
| System.Boolean | compress |     |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) | objectBuilder |     |
| System.UInt64 | sizeInBytes |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SerializeXML(String, Boolean, MyObjectBuilder\_Base, Type)

##### Declaration

```
public static bool SerializeXML(string path, bool compress, MyObjectBuilder_Base objectBuilder, Type serializeAsType = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path |     |
| System.Boolean | compress |     |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) | objectBuilder |     |
| System.Type | serializeAsType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SerializeXML(String, Boolean, MyObjectBuilder\_Base, out UInt64, Type)

##### Declaration

```
public static bool SerializeXML(string path, bool compress, MyObjectBuilder_Base objectBuilder, out ulong sizeInBytes, Type serializeAsType = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path |     |
| System.Boolean | compress |     |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) | objectBuilder |     |
| System.UInt64 | sizeInBytes |     |
| System.Type | serializeAsType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |