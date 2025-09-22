---
title: "Class MyGridPhysicalGroupData"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGridPhysicalGroupData.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyGridPhysicalGroupData"
---

# Class MyGridPhysicalGroupData | Space Engineers ModAPI

##### Inheritance

System.Object

MyGridPhysicalGroupData

##### Implements

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyGridPhysicalGroupData : MyGridGroupData<MyGridPhysicalGroupData>, IGroupData<MyCubeGrid>, IMyGridGroupData
```

### Constructors

#### MyGridPhysicalGroupData()

##### Declaration

```
public MyGridPhysicalGroupData()
```

### Methods

#### GetGroupSharedProperties(MyCubeGrid, Boolean)

##### Declaration

```
public static MyGridPhysicalGroupData.GroupSharedPxProperties GetGroupSharedProperties(MyCubeGrid localGrid, bool checkMultithreading = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | localGrid |     |
| System.Boolean | checkMultithreading |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyGridPhysicalGroupData.GroupSharedPxProperties](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGridPhysicalGroupData.GroupSharedPxProperties.html) |     |

#### InvalidateSharedMassPropertiesCache(MyCubeGrid)

##### Declaration

```
public static void InvalidateSharedMassPropertiesCache(MyCubeGrid groupRepresentative)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | groupRepresentative |     |

#### OnNodeAdded<TGroupData>(MyCubeGrid, TGroupData)

##### Declaration

```
public override void OnNodeAdded<TGroupData>(MyCubeGrid entity, TGroupData prevGroup)
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

##### Overrides

Sandbox.Game.Entities.Cube.MyGridGroupData<Sandbox.Game.Entities.MyGridPhysicalGroupData>.OnNodeAdded<TGroupData>(Sandbox.Game.Entities.MyCubeGrid, TGroupData)

#### OnNodeRemoved<TGroupData>(MyCubeGrid, TGroupData)

##### Declaration

```
public override void OnNodeRemoved<TGroupData>(MyCubeGrid entity, TGroupData prevGroup)
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

##### Overrides

Sandbox.Game.Entities.Cube.MyGridGroupData<Sandbox.Game.Entities.MyGridPhysicalGroupData>.OnNodeRemoved<TGroupData>(Sandbox.Game.Entities.MyCubeGrid, TGroupData)

#### OnRelease()

##### Declaration

```
public override void OnRelease()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyGridGroupData<Sandbox.Game.Entities.MyGridPhysicalGroupData>.OnRelease()

### Implements