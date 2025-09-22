---
title: "Class MyDoorBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDoorBase.html"
category: "Blocks"
namespace: "Sandbox.Game.Entities"
class: "MyDoorBase"
---

# Class MyDoorBase | Space Engineers ModAPI

GR: Added this class to be used as a base for all door classes. Added only very basic functionallity no new definitions or object builders. The main issue was that door actions (open / close) couldn't be used in groups because they were not inheriting from same class. Instead were inheriting directly from MyFunctionalBlock so this class is used in between for common attributes.

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

Sandbox.Game.Entities.Cube.MyFunctionalBlock

MyDoorBase

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
public abstract class MyDoorBase : MyFunctionalBlock, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyTieredUpdateBlock, IMyUpdateTimer, IMyTextSurfaceProvider, IMyTextSurfaceProvider, IMyMultiTextPanelComponentOwner, IMyTextPanelComponentOwner, IMyFunctionalBlock, IMyFunctionalBlock, IMyTerminalBlock, IMyTerminalBlock, IMyCubeBlock, IMyCubeBlock, IMyEntity, IMyEntity
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_Entities_MyDoorBase__ctor)MyDoorBase()

##### Declaration

### [](#properties)Properties

#### [](#Sandbox_Game_Entities_MyDoorBase_AnyoneCanUse)AnyoneCanUse

##### Declaration

```
public bool AnyoneCanUse { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyDoorBase_HighlightMode)HighlightMode

##### Declaration

```
public override MyCubeBlockHighlightModes HighlightMode { get; }
```

##### Property Value

##### Overrides

#### [](#Sandbox_Game_Entities_MyDoorBase_Open)Open

##### Declaration

```
public bool Open { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#methods)Methods

#### [](#Sandbox_Game_Entities_MyDoorBase_ContactCallbackInternal)ContactCallbackInternal()

##### Declaration

```
public virtual void ContactCallbackInternal()
```

#### [](#Sandbox_Game_Entities_MyDoorBase_CreateSubpartConstraint_VRage_Game_Entity_MyEntity_Havok_HkFixedConstraintData__Havok_HkConstraint__)CreateSubpartConstraint(MyEntity, out HkFixedConstraintData, out HkConstraint)

##### Declaration

```
protected void CreateSubpartConstraint(MyEntity subpart, out HkFixedConstraintData constraintData, out HkConstraint constraint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | subpart |     |
| Havok.HkFixedConstraintData | constraintData |     |
| Havok.HkConstraint | constraint |     |

#### [](#Sandbox_Game_Entities_MyDoorBase_CreateTerminalControls)CreateTerminalControls()

##### Declaration

```
protected override void CreateTerminalControls()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.CreateTerminalControls()

#### [](#Sandbox_Game_Entities_MyDoorBase_DisposeSubpartConstraint_Havok_HkConstraint__Havok_HkFixedConstraintData__)DisposeSubpartConstraint(ref HkConstraint, ref HkFixedConstraintData)

##### Declaration

```
protected void DisposeSubpartConstraint(ref HkConstraint constraint, ref HkFixedConstraintData constraintData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Havok.HkConstraint | constraint |     |
| Havok.HkFixedConstraintData | constraintData |     |

#### [](#Sandbox_Game_Entities_MyDoorBase_EnableContactCallbacks)EnableContactCallbacks()

##### Declaration

```
public virtual bool EnableContactCallbacks()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyDoorBase_GetObjectBuilderCubeBlock_System_Boolean_)GetObjectBuilderCubeBlock(Boolean)

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

Sandbox.Game.Entities.Cube.MyFunctionalBlock.GetObjectBuilderCubeBlock(System.Boolean)

#### [](#Sandbox_Game_Entities_MyDoorBase_Init_VRage_Game_MyObjectBuilder_CubeBlock_Sandbox_Game_Entities_MyCubeGrid_)Init(MyObjectBuilder\_CubeBlock, MyCubeGrid)

##### Declaration

```
public override void Init(MyObjectBuilder_CubeBlock objectBuilder, MyCubeGrid cubeGrid)
```

##### Parameters

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.Init(VRage.Game.MyObjectBuilder\_CubeBlock, Sandbox.Game.Entities.MyCubeGrid)

#### [](#Sandbox_Game_Entities_MyDoorBase_IsClosing)IsClosing()

##### Declaration

```
public abstract bool IsClosing()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyDoorBase_OnOpenChanged_VRage_Sync_SyncBase_)OnOpenChanged(SyncBase)

##### Declaration

```
protected virtual void OnOpenChanged(SyncBase obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Sync.SyncBase | obj |     |

#### [](#Sandbox_Game_Entities_MyDoorBase_SetOpenLocalValue_System_Boolean_)SetOpenLocalValue(Boolean)

##### Declaration

```
protected void SetOpenLocalValue(bool value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | value |     |

#### [](#Sandbox_Game_Entities_MyDoorBase_SetOpenRequest_System_Boolean_System_Int64_)SetOpenRequest(Boolean, Int64)

##### Declaration

```
public void SetOpenRequest(bool open, long identityId)
```
