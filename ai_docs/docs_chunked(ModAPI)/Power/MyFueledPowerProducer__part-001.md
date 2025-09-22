---
title: "Class MyFueledPowerProducer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyFueledPowerProducer.html"
category: "Power"
namespace: "Sandbox.Game.Entities"
class: "MyFueledPowerProducer"
---

# Class MyFueledPowerProducer | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

Sandbox.Game.Entities.Cube.MyFunctionalBlock

MyFueledPowerProducer

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
public abstract class MyFueledPowerProducer : MyFunctionalBlock, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyTieredUpdateBlock, IMyUpdateTimer, IMyTextSurfaceProvider, IMyTextSurfaceProvider, IMyMultiTextPanelComponentOwner, IMyTextPanelComponentOwner, IMyConveyorEndpointBlock, IMyPowerProducer, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyPowerProducer, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Constructors

#### MyFueledPowerProducer()

##### Declaration

```
protected MyFueledPowerProducer()
```

### Fields

#### FUEL\_CONSUMPTION\_MULTIPLIER

##### Declaration

```
public static float FUEL_CONSUMPTION_MULTIPLIER
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### m\_previousCapacity

##### Declaration

```
protected float m_previousCapacity
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Properties

#### BlockDefinition

##### Declaration

```
public MyFueledPowerProducerDefinition BlockDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyFueledPowerProducerDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyFueledPowerProducerDefinition.html) |     |

#### Capacity

##### Declaration

```
public float Capacity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ConveyorEndpoint

##### Declaration

```
public IMyConveyorEndpoint ConveyorEndpoint { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.IMyConveyorEndpoint |     |

#### CurrentOutput

##### Declaration

```
public float CurrentOutput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CurrentOutputRatio

##### Declaration

```
public float CurrentOutputRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsSupplied

##### Declaration

```
public bool IsSupplied { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxOutput

##### Declaration

```
public virtual float MaxOutput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SourceComp

##### Declaration

```
public MyResourceSourceComponent SourceComp { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyResourceSourceComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSourceComponent.html) |     |

### Methods

#### AllowSelfPulling()

##### Declaration

```
public virtual bool AllowSelfPulling()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### ComponentStack\_IsFunctionalChanged()

##### Declaration

```
protected virtual void ComponentStack_IsFunctionalChanged()
```

#### ComputeMaxProduction()

##### Declaration

```
protected virtual float ComputeMaxProduction()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetMaxCapacity()

##### Declaration

```
public virtual float GetMaxCapacity()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

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

Sandbox.Game.Entities.Cube.MyFunctionalBlock.GetObjectBuilderCubeBlock(System.Boolean)

#### GetPullInformation()

##### Declaration

```
public virtual PullInformation GetPullInformation()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.PullInformation |     |

#### GetPushInformation()

##### Declaration

```
public virtual PullInformation GetPushInformation()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.PullInformation |     |

#### Init(MyObjectBuilder\_CubeBlock, MyCubeGrid)

##### Declaration

```
public override void Init(MyObjectBuilder_CubeBlock objectBuilder, MyCubeGrid cubeGrid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html) | objectBuilder |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | cubeGrid |     |
