---
title: "Interface IMyUpdateOrchestrator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyUpdateOrchestrator.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "IMyUpdateOrchestrator"
---

# Interface IMyUpdateOrchestrator | Space Engineers ModAPI

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyUpdateOrchestrator
```

### [](#properties)Properties

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_StatsFilter)StatsFilter

##### Declaration

```
string StatsFilter { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_StatsViewDirFilter)StatsViewDirFilter

##### Declaration

```
bool StatsViewDirFilter { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#methods)Methods

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_AddEntity_VRage_Game_Entity_MyEntity_)AddEntity(MyEntity)

##### Declaration

```
void AddEntity(MyEntity entity)
```

##### Parameters

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_ClearStats)ClearStats()

##### Declaration

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_DebugDraw)DebugDraw()

##### Declaration

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_DispatchAfterSimulation)DispatchAfterSimulation()

##### Declaration

```
void DispatchAfterSimulation()
```

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_DispatchBeforeSimulation)DispatchBeforeSimulation()

##### Declaration

```
void DispatchBeforeSimulation()
```

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_DispatchOnceBeforeFrame)DispatchOnceBeforeFrame()

##### Declaration

```
void DispatchOnceBeforeFrame()
```

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_DispatchSimulate)DispatchSimulate()

##### Declaration

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_DispatchUpdatingStopped)DispatchUpdatingStopped()

##### Declaration

```
void DispatchUpdatingStopped()
```

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_EntityFlagsChanged_VRage_Game_Entity_MyEntity_)EntityFlagsChanged(MyEntity)

##### Declaration

```
void EntityFlagsChanged(MyEntity entity)
```

##### Parameters

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_GetStats)GetStats()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Text.StringBuilder |     |

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_InvokeLater_System_Action_System_String_)InvokeLater(Action, String)

Schedule a callback to be invoked in the update thread at a later time.

##### Declaration

```
void InvokeLater(Action action, string debugName = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action |     |
| System.String | debugName |     |

##### Remarks

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_RemoveEntity_VRage_Game_Entity_MyEntity_System_Boolean_)RemoveEntity(MyEntity, Boolean)

##### Declaration

```
void RemoveEntity(MyEntity entity, bool immediate)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| System.Boolean | immediate |     |

#### [](#Sandbox_Game_Entities_IMyUpdateOrchestrator_Unload)Unload()

##### Declaration