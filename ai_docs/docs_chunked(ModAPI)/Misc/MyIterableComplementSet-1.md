---
title: "Class MyIterableComplementSet<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyIterableComplementSet-1.html"
category: "Misc"
namespace: "VRage.Library.Utils"
class: "MyIterableComplementSet-1"
---

# Class MyIterableComplementSet<T> | Space Engineers ModAPI

##### Inheritance

System.Object

MyIterableComplementSet<T>

###### **Namespace**: [VRage.Library.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyIterableComplementSet<T> : Object, IEnumerable<T>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### MyIterableComplementSet()

##### Declaration

```
public MyIterableComplementSet()
```

### Methods

#### Add(T)

##### Declaration

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

#### AddToComplement(T)

##### Declaration

```
public void AddToComplement(T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

#### AllToComplement()

##### Declaration

```
public void AllToComplement()
```

#### AllToSet()

##### Declaration

#### Clear()

##### Declaration

#### ClearComplement()

##### Declaration

```
public void ClearComplement()
```

#### ClearSet()

##### Declaration

#### Complement()

##### Declaration

```
public IEnumerable<T> Complement()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<T> |     |

#### Contains(T)

##### Declaration

```
public bool Contains(T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetEnumerator()

##### Declaration

```
public IEnumerator<T> GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerator<T> |     |

#### IsInComplement(T)

##### Declaration

```
public bool IsInComplement(T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MoveToComplement(T)

##### Declaration

```
public void MoveToComplement(T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

#### MoveToSet(T)

##### Declaration

```
public void MoveToSet(T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

#### Remove(T)

##### Declaration

```
public void Remove(T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

#### Set()

##### Declaration

```
public IEnumerable<T> Set()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<T> |     |

### Extension Methods