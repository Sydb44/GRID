---
title: "Class MyConveyor"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyConveyor.html"
category: "Logistics"
namespace: "Sandbox.Game.Entities"
class: "MyConveyor"
---

# Class MyConveyor | Space Engineers ModAPI

##### Inheritance

System.Object

MyConveyor

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
public class MyConveyor : MyCubeBlock, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyConveyorEndpointBlock, IMyConveyor, IMyCubeBlock, IMyEntity, IMyConveyor, IMyCubeBlock, IMyEntity
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_Entities_MyConveyor__ctor)MyConveyor()

##### Declaration

### [](#properties)Properties

#### [](#Sandbox_Game_Entities_MyConveyor_ConveyorEndpoint)ConveyorEndpoint

##### Declaration

```
public IMyConveyorEndpoint ConveyorEndpoint { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.IMyConveyorEndpoint |     |

### [](#methods)Methods

#### [](#Sandbox_Game_Entities_MyConveyor_AllowSelfPulling)AllowSelfPulling()

##### Declaration

```
public bool AllowSelfPulling()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyConveyor_GetPullInformation)GetPullInformation()

##### Declaration

```
public PullInformation GetPullInformation()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.PullInformation |     |

#### [](#Sandbox_Game_Entities_MyConveyor_GetPushInformation)GetPushInformation()

##### Declaration

```
public PullInformation GetPushInformation()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.PullInformation |     |

#### [](#Sandbox_Game_Entities_MyConveyor_Init_VRage_Game_MyObjectBuilder_CubeBlock_Sandbox_Game_Entities_MyCubeGrid_)Init(MyObjectBuilder\_CubeBlock, MyCubeGrid)

##### Declaration

```
public override void Init(MyObjectBuilder_CubeBlock objectBuilder, MyCubeGrid cubeGrid)
```

##### Parameters

##### Overrides

#### [](#Sandbox_Game_Entities_MyConveyor_InitializeConveyorEndpoint)InitializeConveyorEndpoint()

##### Declaration

```
public void InitializeConveyorEndpoint()
```

### [](#implements)Implements

### [](#extensionmethods)Extension Methods