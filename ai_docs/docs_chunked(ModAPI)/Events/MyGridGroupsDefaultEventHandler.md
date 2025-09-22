---
title: "Class MyGridGroupsDefaultEventHandler"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyGridGroupsDefaultEventHandler.html"
category: "Events"
namespace: "VRage.Game.ModAPI"
class: "MyGridGroupsDefaultEventHandler"
---

# Class MyGridGroupsDefaultEventHandler | Space Engineers ModAPI

Implements abstract base for grid group event handler

##### Inheritance

System.Object

MyGridGroupsDefaultEventHandler

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MyGridGroupsDefaultEventHandler : Object
```

### Constructors

#### MyGridGroupsDefaultEventHandler(IMyGridGroupData)

Constructor

##### Declaration

```
protected MyGridGroupsDefaultEventHandler(IMyGridGroupData obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html) | obj | group data instance |

### Properties

#### GridGroup

Gets the grid group

##### Declaration

```
protected IMyGridGroupData GridGroup { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html) |     |

#### IsClosed

Determines if it's closed

##### Declaration

```
public bool IsClosed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetGuid()

Gets Guid

##### Declaration

```
protected abstract Guid GetGuid()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Guid | unique guid |

#### OnGridAdded(IMyCubeGrid, IMyGridGroupData)

##### Declaration

```
protected virtual void OnGridAdded(IMyCubeGrid arg2, IMyGridGroupData prevGroup)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | arg2 |     |
| [IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html) | prevGroup |     |

#### OnGridMerged(IMyCubeGrid, IMyCubeGrid)

##### Declaration

```
protected virtual void OnGridMerged(IMyCubeGrid baseGrid, IMyCubeGrid merged)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | baseGrid |     |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | merged |     |

#### OnGridRemoved(IMyCubeGrid, IMyGridGroupData)

##### Declaration

```
protected virtual void OnGridRemoved(IMyCubeGrid arg2, IMyGridGroupData nextGroup)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | arg2 |     |
| [IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html) | nextGroup |     |

#### OnGridSplited(IMyCubeGrid, IMyCubeGrid)

##### Declaration

```
protected virtual void OnGridSplited(IMyCubeGrid basegrid, IMyCubeGrid removedGrid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | basegrid |     |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | removedGrid |     |

#### OnReleased()

##### Declaration

```
protected virtual void OnReleased()
```

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |