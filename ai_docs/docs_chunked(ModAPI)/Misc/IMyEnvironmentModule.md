---
title: "Interface IMyEnvironmentModule"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMyEnvironmentModule.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment"
class: "IMyEnvironmentModule"
---

# Interface IMyEnvironmentModule | Space Engineers ModAPI

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyEnvironmentModule
```

### Methods

#### Close()

##### Declaration

#### DebugDraw()

##### Declaration

#### GetObjectBuilder()

##### Declaration

```
MyObjectBuilder_EnvironmentModuleBase GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.WorldEnvironment.ObjectBuilders.MyObjectBuilder\_EnvironmentModuleBase |     |

#### HandleSyncEvent(Int32, Object, Boolean)

##### Declaration

```
void HandleSyncEvent(int logicalItem, object data, bool fromClient)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | logicalItem |     |
| System.Object | data |     |
| System.Boolean | fromClient |     |

#### Init(MyLogicalEnvironmentSectorBase, MyObjectBuilder\_Base)

##### Declaration

```
void Init(MyLogicalEnvironmentSectorBase sector, MyObjectBuilder_Base ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyLogicalEnvironmentSectorBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase.html) | sector |     |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) | ob  |     |

#### OnItemEnable(Int32, Boolean)

##### Declaration

```
void OnItemEnable(int item, bool enable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | item |     |
| System.Boolean | enable |     |

#### ProcessItems(Dictionary<Int16, MyLodEnvironmentItemSet>, Int32, Int32)

##### Declaration

```
void ProcessItems(Dictionary<short, MyLodEnvironmentItemSet> items, int changedLodMin, int changedLodMax)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<System.Int16, [MyLodEnvironmentItemSet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyLodEnvironmentItemSet.html)\> | items |     |
| System.Int32 | changedLodMin |     |
| System.Int32 | changedLodMax |     |