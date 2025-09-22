---
title: "Class MyDoor"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDoor.html"
category: "Blocks"
namespace: "Sandbox.Game.Entities"
class: "MyDoor"
---

# Class MyDoor | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

Sandbox.Game.Entities.Cube.MyFunctionalBlock

MyDoor

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
[MyTerminalInterface]
public class MyDoor : MyDoorBase, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyTieredUpdateBlock, IMyUpdateTimer, IMyTextSurfaceProvider, IMyTextSurfaceProvider, IMyMultiTextPanelComponentOwner, IMyTextPanelComponentOwner, IMyDoor, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyDoor, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_Entities_MyDoor__ctor)MyDoor()

##### Declaration

### [](#fields)Fields

#### [](#Sandbox_Game_Entities_MyDoor_MaxOpen)MaxOpen

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### [](#properties)Properties

#### [](#Sandbox_Game_Entities_MyDoor_DisassembleRatio)DisassembleRatio

##### Declaration

```
public override float DisassembleRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

##### Overrides

#### [](#Sandbox_Game_Entities_MyDoor_OpenRatio)OpenRatio

##### Declaration

```
public float OpenRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### [](#methods)Methods

#### [](#Sandbox_Game_Entities_MyDoor_BeforeDelete)BeforeDelete()

##### Declaration

```
protected override void BeforeDelete()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyDoor_CheckIsWorking)CheckIsWorking()

##### Declaration

```
protected override bool CheckIsWorking()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.CheckIsWorking()

#### [](#Sandbox_Game_Entities_MyDoor_Closing)Closing()

##### Declaration

```
protected override void Closing()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.Closing()

#### [](#Sandbox_Game_Entities_MyDoor_ContactCallbackInternal)ContactCallbackInternal()

##### Declaration

```
public override void ContactCallbackInternal()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyDoor_EnableContactCallbacks)EnableContactCallbacks()

##### Declaration

```
public override bool EnableContactCallbacks()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### [](#Sandbox_Game_Entities_MyDoor_GetObjectBuilderCubeBlock_System_Boolean_)GetObjectBuilderCubeBlock(Boolean)

##### Declaration

```
public override MyObjectBuilder_CubeBlock GetObjectBuilderCubeBlock(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

##### Overrides

#### [](#Sandbox_Game_Entities_MyDoor_Init_VRage_Game_MyObjectBuilder_CubeBlock_Sandbox_Game_Entities_MyCubeGrid_)Init(MyObjectBuilder\_CubeBlock, MyCubeGrid)

##### Declaration

```
public override void Init(MyObjectBuilder_CubeBlock builder, MyCubeGrid cubeGrid)
```

##### Parameters

##### Overrides

#### [](#Sandbox_Game_Entities_MyDoor_IsClosing)IsClosing()

##### Declaration

```
public override bool IsClosing()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### [](#Sandbox_Game_Entities_MyDoor_OnAddedToScene_System_Object_)OnAddedToScene(Object)

##### Declaration

```
public override void OnAddedToScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnAddedToScene(System.Object)

#### [](#Sandbox_Game_Entities_MyDoor_OnBuildSuccess_System_Int64_System_Boolean_)OnBuildSuccess(Int64, Boolean)

##### Declaration

```
public override void OnBuildSuccess(long builtBy, bool instantBuild)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | builtBy |     |
| System.Boolean | instantBuild |     |

##### Overrides

#### [](#Sandbox_Game_Entities_MyDoor_OnCubeGridChanged_Sandbox_Game_Entities_MyCubeGrid_)OnCubeGridChanged(MyCubeGrid)

##### Declaration

```
public override void OnCubeGridChanged(MyCubeGrid oldGrid)
```

##### Parameters

##### Overrides

#### [](#Sandbox_Game_Entities_MyDoor_OnEnabledChanged)OnEnabledChanged()

##### Declaration

```
protected override void OnEnabledChanged()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnEnabledChanged()

#### [](#Sandbox_Game_Entities_MyDoor_OnModelChange)OnModelChange()

##### Declaration

```
public override void OnModelChange()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnModelChange()

#### [](#Sandbox_Game_Entities_MyDoor_OnOpenChanged_VRage_Sync_SyncBase_)OnOpenChanged(SyncBase)

##### Declaration

```
protected override void OnOpenChanged(SyncBase obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Sync.SyncBase | obj |     |

##### Overrides

#### [](#Sandbox_Game_Entities_MyDoor_OnRemovedFromScene_System_Object_)OnRemovedFromScene(Object)

##### Declaration

```
public override void OnRemovedFromScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnRemovedFromScene(System.Object)
