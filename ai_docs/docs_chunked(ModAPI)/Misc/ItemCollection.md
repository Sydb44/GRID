---
title: "Class MyCommandLine.ItemCollection"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.ItemCollection.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine"
class: "ItemCollection"
---

# Class MyCommandLine.ItemCollection | Space Engineers ModAPI

A collection of arguments

##### Inheritance

System.Object

MyCommandLine.ItemCollection

###### **Namespace**: [VRage.Game.ModAPI.Ingame.Utilities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class ItemCollection : Object, IReadOnlyList<string>, IEnumerable<string>, IEnumerable, IReadOnlyCollection<string>
```

### Properties

#### Count

Gets the number of parameters

##### Declaration

```
public int Count { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Item\[Int32\]

Gets the parameter at the given index

##### Declaration

```
public string this[int index] { get; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### GetEnumerator()

Gets an enumerator to step through the content of this list

##### Declaration

```
public MyCommandLine.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyCommandLine.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.Enumerator.html) |     |