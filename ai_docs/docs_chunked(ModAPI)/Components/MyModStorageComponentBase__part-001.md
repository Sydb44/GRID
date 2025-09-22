---
title: "Class MyModStorageComponentBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyModStorageComponentBase.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyModStorageComponentBase"
---

# Class MyModStorageComponentBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyModStorageComponentBase

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MyModStorageComponentBase : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase, IDictionary<Guid, string>, ICollection<KeyValuePair<Guid, string>>, IEnumerable<KeyValuePair<Guid, string>>, IEnumerable
```

### Constructors

#### MyModStorageComponentBase()

##### Declaration

```
protected MyModStorageComponentBase()
```

### Fields

#### m\_storageData

##### Declaration

```
protected IDictionary<Guid, string> m_storageData
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IDictionary<System.Guid, System.String\> |     |

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

#### Count

##### Declaration

```
public int Count { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IsReadOnly

##### Declaration

```
public bool IsReadOnly { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Item\[Guid\]

##### Declaration

```
public string this[Guid key] { get; set; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | key |     |

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Keys

##### Declaration

```
public ICollection<Guid> Keys { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.ICollection<System.Guid\> |     |

#### Values

##### Declaration

```
public ICollection<string> Values { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.ICollection<System.String\> |     |

### Methods

#### Add(KeyValuePair<Guid, String>)

##### Declaration

```
public void Add(KeyValuePair<Guid, string> item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.KeyValuePair<System.Guid, System.String\> | item |     |

#### Add(Guid, String)

##### Declaration

```
public void Add(Guid key, string value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | key |     |
| System.String | value |     |

#### Clear()

##### Declaration

#### Contains(KeyValuePair<Guid, String>)

##### Declaration

```
public bool Contains(KeyValuePair<Guid, string> item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.KeyValuePair<System.Guid, System.String\> | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ContainsKey(Guid)

##### Declaration

```
public bool ContainsKey(Guid key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | key |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CopyTo(KeyValuePair<Guid, String>\[\], Int32)

##### Declaration

```
public void CopyTo(KeyValuePair<Guid, string>[] array, int arrayIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.KeyValuePair<System.Guid, System.String\>\[\] | array |     |
| System.Int32 | arrayIndex |     |

#### GetEnumerator()

##### Declaration

```
public IEnumerator<KeyValuePair<Guid, string>> GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Guid, System.String\>> |     |

#### GetValue(Guid)

Gets a value from the Storage dictionary with the specified key.

##### Declaration

```
public abstract string GetValue(Guid guid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | guid |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Remove(KeyValuePair<Guid, String>)

##### Declaration

```
public bool Remove(KeyValuePair<Guid, string> item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.KeyValuePair<System.Guid, System.String\> | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Remove(Guid)

##### Declaration

```
public bool Remove(Guid key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | key |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveValue(Guid)

Removes a value with the specified key from the Storage dictionary.

##### Declaration

```
public abstract bool RemoveValue(Guid guid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | guid |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Serialize(Boolean)

##### Declaration

```
public override MyObjectBuilder_ComponentBase Serialize(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

##### Overrides

#### SetValue(Guid, String)

Stores a value with the specified key into the Storage dictionary.
