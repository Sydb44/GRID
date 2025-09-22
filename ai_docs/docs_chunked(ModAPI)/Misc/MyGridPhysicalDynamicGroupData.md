---
title: "Class MyGridPhysicalDynamicGroupData"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGridPhysicalDynamicGroupData.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyGridPhysicalDynamicGroupData"
---

# Class MyGridPhysicalDynamicGroupData | Space Engineers ModAPI

##### Inheritance

System.Object

MyGridPhysicalDynamicGroupData

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyGridPhysicalDynamicGroupData : Object, IGroupData<MyCubeGrid>
```

### Constructors

#### MyGridPhysicalDynamicGroupData()

##### Declaration

```
public MyGridPhysicalDynamicGroupData()
```

### Methods

#### OnChangeComplete()

##### Declaration

```
public void OnChangeComplete()
```

#### OnCreate<TGroupData>(MyGroups<MyCubeGrid, TGroupData>.Group)

##### Declaration

```
public void OnCreate<TGroupData>(MyGroups<MyCubeGrid, TGroupData>.Group group)
    where TGroupData : IGroupData<MyCubeGrid>, new()
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Groups.MyGroups.Group<> | group |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| TGroupData |     |

#### OnNodeAdded<TGroupData>(MyCubeGrid, TGroupData)

##### Declaration

```
public void OnNodeAdded<TGroupData>(MyCubeGrid entity, TGroupData prevGroup)
    where TGroupData : IGroupData<MyCubeGrid>, new()
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | entity |     |
| TGroupData | prevGroup |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| TGroupData |     |

#### OnNodeRemoved<TGroupData>(MyCubeGrid, TGroupData)

##### Declaration

```
public void OnNodeRemoved<TGroupData>(MyCubeGrid entity, TGroupData nextGroup)
    where TGroupData : IGroupData<MyCubeGrid>, new()
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | entity |     |
| TGroupData | nextGroup |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| TGroupData |     |

#### OnPostCreate()

##### Declaration

```
public void OnPostCreate()
```

#### OnPostNodeAdded<TGroupData>(MyCubeGrid, TGroupData)

##### Declaration

```
public void OnPostNodeAdded<TGroupData>(MyCubeGrid entity, TGroupData prevGroup)
    where TGroupData : IGroupData<MyCubeGrid>, new()
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | entity |     |
| TGroupData | prevGroup |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| TGroupData |     |

#### OnPreNodeRemoved<TGroupData>(MyCubeGrid, TGroupData)

##### Declaration

```
public void OnPreNodeRemoved<TGroupData>(MyCubeGrid entity, TGroupData nextGroup)
    where TGroupData : IGroupData<MyCubeGrid>, new()
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | entity |     |
| TGroupData | nextGroup |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| TGroupData |     |

#### OnPreRelease()

##### Declaration

```
public void OnPreRelease()
```

#### OnRelease()

##### Declaration