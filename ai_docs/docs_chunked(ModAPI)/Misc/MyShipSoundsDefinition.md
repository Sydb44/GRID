---
title: "Class MyShipSoundsDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyShipSoundsDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyShipSoundsDefinition"
---

# Class MyShipSoundsDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyShipSoundsDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyShipSoundsDefinition : MyDefinitionBase
```

### Constructors

#### MyShipSoundsDefinition()

##### Declaration

```
public MyShipSoundsDefinition()
```

### Fields

#### AllowLargeGrid

##### Declaration

```
public bool AllowLargeGrid
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AllowSmallGrid

##### Declaration

```
public bool AllowSmallGrid
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnginePitchRangeInSemitones

##### Declaration

```
public float EnginePitchRangeInSemitones
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EnginePitchRangeInSemitones\_h

##### Declaration

```
public float EnginePitchRangeInSemitones_h
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EngineTimeToTurnOff

##### Declaration

```
public float EngineTimeToTurnOff
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EngineTimeToTurnOn

##### Declaration

```
public float EngineTimeToTurnOn
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EngineVolumes

##### Declaration

```
public List<MyTuple<float, float>> EngineVolumes
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<VRage.MyTuple<System.Single, System.Single\>> |     |

#### MinWeight

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Sounds

##### Declaration

```
public Dictionary<ShipSystemSoundsEnum, MySoundPair> Sounds
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[ShipSystemSoundsEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.ShipSystemSoundsEnum.html), [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html)\> |     |

#### SpeedDownSoundChangeVolumeTo

##### Declaration

```
public float SpeedDownSoundChangeVolumeTo
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SpeedUpDownChangeSpeed

##### Declaration

```
public float SpeedUpDownChangeSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SpeedUpSoundChangeVolumeTo

##### Declaration

```
public float SpeedUpSoundChangeVolumeTo
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ThrusterCompositionChangeSpeed

##### Declaration

```
public float ThrusterCompositionChangeSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ThrusterCompositionMinVolume

##### Declaration

```
public float ThrusterCompositionMinVolume
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ThrusterCompositionMinVolume\_c

##### Declaration

```
public float ThrusterCompositionMinVolume_c
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ThrusterPitchRangeInSemitones

##### Declaration

```
public float ThrusterPitchRangeInSemitones
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ThrusterPitchRangeInSemitones\_h

##### Declaration

```
public float ThrusterPitchRangeInSemitones_h
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ThrusterVolumes

##### Declaration

```
public List<MyTuple<float, float>> ThrusterVolumes
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<VRage.MyTuple<System.Single, System.Single\>> |     |

#### WheelsFullSpeed

##### Declaration

```
public float WheelsFullSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### WheelsLowerThrusterVolumeBy

##### Declaration

```
public float WheelsLowerThrusterVolumeBy
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### WheelsPitchRangeInSemitones

##### Declaration

```
public float WheelsPitchRangeInSemitones
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### WheelsPitchRangeInSemitones\_h

##### Declaration

```
public float WheelsPitchRangeInSemitones_h
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### WheelsSpeedCompensation

##### Declaration

```
public float WheelsSpeedCompensation
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### WheelsVolumes

##### Declaration

```
public List<MyTuple<float, float>> WheelsVolumes
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<VRage.MyTuple<System.Single, System.Single\>> |     |

### Methods

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Overrides