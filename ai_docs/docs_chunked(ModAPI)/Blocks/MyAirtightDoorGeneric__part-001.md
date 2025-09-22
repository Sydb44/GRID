---
title: "Class MyAirtightDoorGeneric"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAirtightDoorGeneric.html"
category: "Blocks"
namespace: "Sandbox.Game.Entities"
class: "MyAirtightDoorGeneric"
---

# Class MyAirtightDoorGeneric | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

Sandbox.Game.Entities.Cube.MyFunctionalBlock

MyAirtightDoorGeneric

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyTerminalInterface]
public abstract class MyAirtightDoorGeneric : MyDoorBase, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyTieredUpdateBlock, IMyUpdateTimer, IMyTextSurfaceProvider, IMyTextSurfaceProvider, IMyMultiTextPanelComponentOwner, IMyTextPanelComponentOwner, IMyAirtightDoorBase, IMyDoor, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyAirtightDoorBase, IMyDoor, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Constructors

#### MyAirtightDoorGeneric()

##### Declaration

```
public MyAirtightDoorGeneric()
```

### Fields

#### m\_currOpening

##### Declaration

```
protected float m_currOpening
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### m\_currSpeed

##### Declaration

```
protected float m_currSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### m\_emissiveTextureNames

##### Declaration

```
protected static string[] m_emissiveTextureNames
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String\[\] |     |

#### m\_openingSpeed

##### Declaration

```
protected float m_openingSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### m\_prevEmissiveColor

##### Declaration

```
protected Color m_prevEmissiveColor
```

##### Field Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### m\_prevEmissivity

##### Declaration

```
protected float m_prevEmissivity
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### m\_subpartConstraints

##### Declaration

```
protected List<HkConstraint> m_subpartConstraints
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<Havok.HkConstraint\> |     |

#### m\_subpartConstraintsData

##### Declaration

```
protected List<HkFixedConstraintData> m_subpartConstraintsData
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<Havok.HkFixedConstraintData\> |     |

#### m\_subpartMovementDistance

##### Declaration

```
protected float m_subpartMovementDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### m\_subparts

##### Declaration

```
protected List<MyEntitySubpart> m_subparts
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyEntitySubpart](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntitySubpart.html)\> |     |

### Properties

#### OpenRatio

##### Declaration

```
public float OpenRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Status

##### Declaration

```
public DoorStatus Status { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DoorStatus](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.DoorStatus.html) |     |

### Methods

#### BeforeDelete()

##### Declaration

```
protected override void BeforeDelete()
```

##### Overrides

#### ChangeOpenClose(Boolean)

##### Declaration

```
public void ChangeOpenClose(bool open)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | open |     |

#### CheckIsWorking()

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

#### Closing()

##### Declaration

```
protected override void Closing()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.Closing()

#### FillSubparts()

##### Declaration

```
protected virtual void FillSubparts()
```

#### GetIntersectionWithAABB(ref BoundingBoxD)

##### Declaration

```
public override bool GetIntersectionWithAABB(ref BoundingBoxD aabb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### GetObjectBuilderCubeBlock(Boolean)

##### Declaration

```
public override MyObjectBuilder_CubeBlock GetObjectBuilderCubeBlock(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html) |     |

##### Overrides

#### Init(MyObjectBuilder\_CubeBlock, MyCubeGrid)

##### Declaration

```
public override void Init(MyObjectBuilder_CubeBlock builder, MyCubeGrid cubeGrid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html) | builder |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | cubeGrid |     |
