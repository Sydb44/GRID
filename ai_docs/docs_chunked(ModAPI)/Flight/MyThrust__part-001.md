---
title: "Class MyThrust"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyThrust.html"
category: "Flight"
namespace: "Sandbox.Game.Entities"
class: "MyThrust"
---

# Class MyThrust | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

Sandbox.Game.Entities.Cube.MyFunctionalBlock

MyThrust

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
[MyTerminalInterface]
public class MyThrust : MyFunctionalBlock, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyTieredUpdateBlock, IMyUpdateTimer, IMyTextSurfaceProvider, IMyTextSurfaceProvider, IMyMultiTextPanelComponentOwner, IMyTextPanelComponentOwner, IMyThrust, IMyThrust, IMyFunctionalBlock, IMyFunctionalBlock, IMyTerminalBlock, IMyTerminalBlock, IMyCubeBlock, IMyCubeBlock, IMyEntity, IMyEntity, IMyConveyorEndpointBlock
```

### Constructors

#### MyThrust()

##### Declaration

### Fields

#### ThrustLengthRand

##### Declaration

```
public float ThrustLengthRand
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Properties

#### BlockDefinition

##### Declaration

```
public MyThrustDefinition BlockDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyThrustDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyThrustDefinition.html) |     |

#### ConveyorEndpoint

##### Declaration

```
public IMyConveyorEndpoint ConveyorEndpoint { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.IMyConveyorEndpoint |     |

#### CurrentStrength

##### Declaration

```
public float CurrentStrength { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FlameDamageLengthScale

##### Declaration

```
public float FlameDamageLengthScale { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FlameGlareIndex

##### Declaration

```
public int FlameGlareIndex { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### FlameLengthMaterial

##### Declaration

```
public MyStringId FlameLengthMaterial { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### FlamePointMaterial

##### Declaration

```
public MyStringId FlamePointMaterial { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### Flames

##### Declaration

```
public ListReader<MyThrustFlameAnimator.FlameInfo> Flames { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<Sandbox.RenderDirect.ActorComponents.MyThrustFlameAnimator.FlameInfo\> |     |

#### Flares

##### Declaration

```
public MyFlareDefinition Flares { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyFlareDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyFlareDefinition.html) |     |

#### FuelConverterDefinition

##### Declaration

```
public MyFuelConverterInfo FuelConverterDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyFuelConverterInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFuelConverterInfo.html) |     |

#### FuelDefinition

##### Declaration

```
public MyGasProperties FuelDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyGasProperties](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyGasProperties.html) |     |

#### GridThrustDirection

##### Declaration

```
public Vector3I GridThrustDirection { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### IsOverridden

Whether this thrust is overriden.

##### Declaration

```
public bool IsOverridden { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPowered

##### Declaration

```
public bool IsPowered { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsTieredUpdateSupported

##### Declaration

```
public override bool IsTieredUpdateSupported { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.IsTieredUpdateSupported

#### MaxPowerConsumption

##### Declaration

```
public float MaxPowerConsumption { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinPowerConsumption

##### Declaration

```
public float MinPowerConsumption { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Propeller

##### Declaration

```
public MyEntity Propeller { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### Render

##### Declaration

```
public MyRenderComponentThrust Render { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyRenderComponentThrust](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyRenderComponentThrust.html) |     |
