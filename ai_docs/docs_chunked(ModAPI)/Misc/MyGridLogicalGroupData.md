---
title: "Class MyGridLogicalGroupData"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGridLogicalGroupData.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyGridLogicalGroupData"
---

# Class MyGridLogicalGroupData | Space Engineers ModAPI

##### Inheritance

System.Object

MyGridLogicalGroupData

##### Implements

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyGridLogicalGroupData : MyGridGroupData<MyGridLogicalGroupData>, IGroupData<MyCubeGrid>, IMyGridGroupData
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_Entities_MyGridLogicalGroupData__ctor)MyGridLogicalGroupData()

##### Declaration

```
public MyGridLogicalGroupData()
```

### [](#properties)Properties

#### [](#Sandbox_Game_Entities_MyGridLogicalGroupData_Root)Root

##### Declaration

```
public MyCubeGrid Root { get; }
```

##### Property Value

### [](#methods)Methods

#### [](#Sandbox_Game_Entities_MyGridLogicalGroupData_OnCreate__1_VRage_Groups_MyGroups_Sandbox_Game_Entities_MyCubeGrid___0__Group_)OnCreate<TGroupData>(MyGroups<MyCubeGrid, TGroupData>.Group)

##### Declaration

```
public override void OnCreate<TGroupData>(MyGroups<MyCubeGrid, TGroupData>.Group group)
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

##### Overrides

Sandbox.Game.Entities.Cube.MyGridGroupData<Sandbox.Game.Entities.MyGridLogicalGroupData>.OnCreate<TGroupData>(VRage.Groups.MyGroups.Group<>)

#### [](#Sandbox_Game_Entities_MyGridLogicalGroupData_OnNodeAdded__1_Sandbox_Game_Entities_MyCubeGrid___0_)OnNodeAdded<TGroupData>(MyCubeGrid, TGroupData)

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

Sandbox.Game.Entities.Cube.MyGridGroupData<Sandbox.Game.Entities.MyGridLogicalGroupData>.OnNodeAdded<TGroupData>(Sandbox.Game.Entities.MyCubeGrid, TGroupData)

#### [](#Sandbox_Game_Entities_MyGridLogicalGroupData_OnNodeRemoved__1_Sandbox_Game_Entities_MyCubeGrid___0_)OnNodeRemoved<TGroupData>(MyCubeGrid, TGroupData)

##### Declaration

```
public override void OnNodeRemoved<TGroupData>(MyCubeGrid entity, TGroupData nextGroup)
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

##### Overrides

Sandbox.Game.Entities.Cube.MyGridGroupData<Sandbox.Game.Entities.MyGridLogicalGroupData>.OnNodeRemoved<TGroupData>(Sandbox.Game.Entities.MyCubeGrid, TGroupData)

#### [](#Sandbox_Game_Entities_MyGridLogicalGroupData_OnRelease)OnRelease()

##### Declaration

```
public override void OnRelease()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyGridGroupData<Sandbox.Game.Entities.MyGridLogicalGroupData>.OnRelease()

### [](#implements)Implements