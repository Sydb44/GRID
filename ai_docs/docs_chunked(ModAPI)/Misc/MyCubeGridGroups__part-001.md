---
title: "Class MyCubeGridGroups"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGridGroups.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyCubeGridGroups"
---

# Class MyCubeGridGroups | Space Engineers ModAPI

##### Inheritance

System.Object

MyCubeGridGroups

##### Implements

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyCubeGridGroups : Object, IMySceneComponent
```

### Constructors

#### MyCubeGridGroups()

##### Declaration

```
public MyCubeGridGroups()
```

### Fields

#### Electrical

##### Declaration

```
public MyGroups<MyCubeGrid, MyGridElectricalGroupData> Electrical
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Groups.MyGroups<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), Sandbox.Game.Entities.Cube.MyGridElectricalGroupData\> |     |

#### Logical

##### Declaration

```
public MyGroups<MyCubeGrid, MyGridLogicalGroupData> Logical
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Groups.MyGroups<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), [MyGridLogicalGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGridLogicalGroupData.html)\> |     |

#### Mechanical

##### Declaration

```
public MyGroups<MyCubeGrid, MyGridMechanicalGroupData> Mechanical
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Groups.MyGroups<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), [MyGridMechanicalGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGridMechanicalGroupData.html)\> |     |

#### NoContactDamage

##### Declaration

```
public MyGroups<MyCubeGrid, MyGridNoDamageGroupData> NoContactDamage
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Groups.MyGroups<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), Sandbox.Game.Entities.Cube.MyGridNoDamageGroupData\> |     |

#### Physical

##### Declaration

```
public MyGroups<MyCubeGrid, MyGridPhysicalGroupData> Physical
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Groups.MyGroups<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), [MyGridPhysicalGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGridPhysicalGroupData.html)\> |     |

#### PhysicalDynamic

##### Declaration

```
public MyGroups<MyCubeGrid, MyGridPhysicalDynamicGroupData> PhysicalDynamic
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Groups.MyGroups<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), [MyGridPhysicalDynamicGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGridPhysicalDynamicGroupData.html)\> |     |

#### SmallToLargeBlockConnections

##### Declaration

```
public MyGroups<MySlimBlock, MyBlockGroupData> SmallToLargeBlockConnections
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Groups.MyGroups<Sandbox.Game.Entities.Cube.MySlimBlock, Sandbox.Game.Entities.Cube.MyBlockGroupData\> |     |

#### Static

##### Declaration

```
public static MyCubeGridGroups Static
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeGridGroups](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGridGroups.html) |     |

### Methods

#### AddGridGroupLogic(GridLinkTypeEnum, Func<IMyGridGroupData, MyGridGroupsDefaultEventHandler>)

##### Declaration

```
public static void AddGridGroupLogic(GridLinkTypeEnum type, Func<IMyGridGroupData, MyGridGroupsDefaultEventHandler> creator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type |     |
| System.Func<[IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html), [MyGridGroupsDefaultEventHandler](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyGridGroupsDefaultEventHandler.html)\> | creator |     |

#### AddNode(GridLinkTypeEnum, MyCubeGrid)

##### Declaration

```
public void AddNode(GridLinkTypeEnum type, MyCubeGrid grid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | grid |     |

#### BreakLink(GridLinkTypeEnum, Int64, MyCubeGrid, MyCubeGrid)

Breaks link between parent and child, you can set child to null to find it by linkId. Returns true when link was removed, returns false when link was not found.

##### Declaration

```
public bool BreakLink(GridLinkTypeEnum type, long linkId, MyCubeGrid parent, MyCubeGrid child = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type |     |
| System.Int64 | linkId |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | parent |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | child |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |
