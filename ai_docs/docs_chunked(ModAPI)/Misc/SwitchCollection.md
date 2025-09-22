---
title: "Class MyCommandLine.SwitchCollection"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.SwitchCollection.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine"
class: "SwitchCollection"
---

# Class MyCommandLine.SwitchCollection | Space Engineers ModAPI

A collection of set switches

##### Inheritance

System.Object

MyCommandLine.SwitchCollection

###### **Namespace**: [VRage.Game.ModAPI.Ingame.Utilities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class SwitchCollection : Object, IReadOnlyCollection<string>, IEnumerable<string>, IEnumerable
```

### Properties

#### Count

Returns the number of set switches

##### Declaration

```
public int Count { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### GetEnumerator()

Gets an enumerator to step through the content of this list

##### Declaration

```
public MyCommandLine.SwitchEnumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyCommandLine.SwitchEnumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.SwitchEnumerator.html) |     |