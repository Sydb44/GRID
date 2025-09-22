---
title: "Class MyRankedServers"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRankedServers.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyRankedServers"
---

# Class MyRankedServers | Space Engineers ModAPI

##### Inheritance

System.Object

MyRankedServers

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyRankedServers : Object
```

### Constructors

#### MyRankedServers()

##### Declaration

### Properties

#### Servers

##### Declaration

```
public List<MyRankServer> Servers { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyRankServer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRankServer.html)\> |     |

### Methods

#### GetByPrefix(String)

##### Declaration

```
public IEnumerable<MyRankServer> GetByPrefix(string prefix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | prefix |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<[MyRankServer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRankServer.html)\> |     |

#### LoadAsync(String, Action<MyRankedServers>)

##### Declaration

```
public static void LoadAsync(string url, Action<MyRankedServers> completedCallback)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | url |     |
| System.Action<[MyRankedServers](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRankedServers.html)\> | completedCallback |     |

#### SaveTestData()

##### Declaration

```
public static void SaveTestData()
```