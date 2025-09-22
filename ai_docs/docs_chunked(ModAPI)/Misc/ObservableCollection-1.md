---
title: "Class ObservableCollection<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ObservableCollection-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "ObservableCollection-1"
---

# Class ObservableCollection<T> | Space Engineers ModAPI

Observable collection that also fix support to clear all. Don't know if ObservableCollection<T> is allocation free.

##### Inheritance

System.Object

ObservableCollection<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class ObservableCollection<T> : ObservableCollection<T>
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### ObservableCollection()

##### Declaration

```
public ObservableCollection()
```

### Fields

#### FireEvents

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### ClearItems()

Clears the items.

##### Declaration

```
protected override void ClearItems()
```

#### FindIndex(Predicate<T>)

##### Declaration

```
public int FindIndex(Predicate<T> match)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Predicate<T> | match |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetEnumerator()

Gets allocation free enumerator (returns struct)

##### Declaration

```
public ObservableCollection<T>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| [ObservableCollection.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ObservableCollection-1.Enumerator.html)<> |     |