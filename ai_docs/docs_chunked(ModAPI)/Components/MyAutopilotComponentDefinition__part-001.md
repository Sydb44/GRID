---
title: "Class MyAutopilotComponentDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyAutopilotComponentDefinition.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyAutopilotComponentDefinition"
---

# Class MyAutopilotComponentDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyAutopilotComponentDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyAutopilotComponentDefinition : MyComponentDefinitionBase
```

### Constructors

#### MyAutopilotComponentDefinition()

##### Declaration

```
public MyAutopilotComponentDefinition()
```

### Fields

#### AlignToGravity

##### Declaration

```
public bool AlignToGravity
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CoastingTestEnabled

##### Declaration

```
public bool CoastingTestEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CourseCorrectionMaxDistanceInPrecisionModeGridSizeMultiple

##### Declaration

```
public float CourseCorrectionMaxDistanceInPrecisionModeGridSizeMultiple
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CourseCorrectionMaxDistanceLargeGrid

##### Declaration

```
public float CourseCorrectionMaxDistanceLargeGrid
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CourseCorrectionMaxDistanceSmallGrid

##### Declaration

```
public float CourseCorrectionMaxDistanceSmallGrid
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CourseCorrectionMaxRemainingRotationBeforeThrust

##### Declaration

```
public float CourseCorrectionMaxRemainingRotationBeforeThrust
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CourseCorrectionMaxRemainingRotationBeforeThrustInPrecisionMode

##### Declaration

```
public float CourseCorrectionMaxRemainingRotationBeforeThrustInPrecisionMode
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CourseCorrectionMaxThrustPercentage

##### Declaration

```
public float CourseCorrectionMaxThrustPercentage
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DefaultPitchAngleDeg

##### Declaration

```
public float DefaultPitchAngleDeg
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DefaultRollAngleDeg

##### Declaration

```
public float DefaultRollAngleDeg
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxPitchAngleDeg

##### Declaration

```
public float MaxPitchAngleDeg
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxRollAngleDeg

##### Declaration

```
public float MaxRollAngleDeg
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxRotationSpeed

##### Declaration

```
public Nullable<float> MaxRotationSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### MaxRotationSpeedTresholdRadians

##### Declaration

```
public Nullable<float> MaxRotationSpeedTresholdRadians
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### MinHeightAboveTerrainBounds

##### Declaration

```
public MyBounds MinHeightAboveTerrainBounds
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### MinHeightAlignmentEnabled

##### Declaration

```
public bool MinHeightAlignmentEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MinRotationSpeed

##### Declaration

```
public Nullable<float> MinRotationSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### MinRotationSpeedThresholdRadians

##### Declaration

```
public Nullable<float> MinRotationSpeedThresholdRadians
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### PrecisionModeRotationVelocitySlowFactor

##### Declaration

```
public float PrecisionModeRotationVelocitySlowFactor
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RotationDeadzone

##### Declaration

```
public float RotationDeadzone
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RotationDeadzoneAdaptiveSpeed

##### Declaration

```
public float RotationDeadzoneAdaptiveSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RotationVelocitySlowFactorAutomaticBehavior

##### Declaration

```
public float RotationVelocitySlowFactorAutomaticBehavior
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RotationVelocitySlowFactorAutomaticBehaviorTreshold

##### Declaration

```
public float RotationVelocitySlowFactorAutomaticBehaviorTreshold
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### GetObjectBuilder()

##### Declaration

```
public override MyObjectBuilder_DefinitionBase GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) |     |

##### Overrides

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |
