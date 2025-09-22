---
title: "Class MyCharacterJetpackComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.MyCharacterJetpackComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities.Character.Components"
class: "MyCharacterJetpackComponent"
---

# Class MyCharacterJetpackComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyCharacterJetpackComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities.Character.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
public class MyCharacterJetpackComponent : MyUpdatingEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent, IMyCharacterComponent
```

### Constructors

#### MyCharacterJetpackComponent()

##### Declaration

```
public MyCharacterJetpackComponent()
```

### Fields

#### FuelCriticalThresholdPlayer

##### Declaration

```
public const float FuelCriticalThresholdPlayer = 0.05F
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FuelLowThresholdPlayer

##### Declaration

```
public const float FuelLowThresholdPlayer = 0.1F
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinimumInputRequirement

##### Declaration

```
public const float MinimumInputRequirement = 1E-06F
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OnPoweredChanged

##### Declaration

```
public Action<bool> OnPoweredChanged
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<System.Boolean\> |     |

#### ROTATION\_FACTOR

##### Declaration

```
public const float ROTATION_FACTOR = 0.02F
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Properties

#### CanDrawThrusts

##### Declaration

```
public bool CanDrawThrusts { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Character

##### Declaration

```
public MyCharacter Character { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter |     |

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### ConsumptionFactorPerG

##### Declaration

```
public float ConsumptionFactorPerG { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CurrentAutoEnableDelay

##### Declaration

```
public float CurrentAutoEnableDelay { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DampenersEnabled

##### Declaration

```
public bool DampenersEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DampenersTurnedOn

##### Declaration

```
public bool DampenersTurnedOn { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EffectivenessAtMaxInfluence

##### Declaration

```
public float EffectivenessAtMaxInfluence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EffectivenessAtMinInfluence

##### Declaration

```
public float EffectivenessAtMinInfluence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FinalThrust

##### Declaration

```
public Vector3 FinalThrust { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### ForceMagnitude

##### Declaration

```
public float ForceMagnitude { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

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

#### IsFlying

##### Declaration

```
public bool IsFlying { get; }
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

#### MaxPlanetaryInfluence

##### Declaration

```
public float MaxPlanetaryInfluence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxPowerConsumption

##### Declaration

```
public float MaxPowerConsumption { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinPlanetaryInfluence

##### Declaration

```
public float MinPlanetaryInfluence { get; }
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

#### NeedsAtmosphereForInfluence

##### Declaration

```
public bool NeedsAtmosphereForInfluence { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Running

##### Declaration

```
public bool Running { get; }
```
