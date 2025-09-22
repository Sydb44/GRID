---
title: "Class MyObjectBuilder\\_AutopilotComponentDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AutopilotComponentDefinition.html"
category: "Components"
namespace: "Sandbox.Common.ObjectBuilders.Definitions"
class: "MyObjectBuilder_AutopilotComponentDefinition"
---

# Class MyObjectBuilder\_AutopilotComponentDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_AutopilotComponentDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_AutopilotComponentDefinition : MyObjectBuilder_ComponentDefinitionBase
```

### Constructors

#### MyObjectBuilder\_AutopilotComponentDefinition()

##### Declaration

```
public MyObjectBuilder_AutopilotComponentDefinition()
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

Distance from direct line between two waypoints (in multiples of gridSize), at which will the autopilot try to correct with CourseCorrectionMaxThrust% thrust in precision mode

##### Declaration

```
public float CourseCorrectionMaxDistanceInPrecisionModeGridSizeMultiple
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CourseCorrectionMaxDistanceLargeGrid

Distance from direct line between two waypoints, at which will the autopilot try to correct with CourseCorrectionMaxThrust% thrust. Large grid only setting

##### Declaration

```
public float CourseCorrectionMaxDistanceLargeGrid
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CourseCorrectionMaxDistanceSmallGrid

Distance from direct line between two waypoints, at which will the autopilot try to correct with CourseCorrectionMaxThrust% thrust. Small grid only setting

##### Declaration

```
public float CourseCorrectionMaxDistanceSmallGrid
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CourseCorrectionMaxRemainingRotationBeforeThrust

Max angle in radians between vectors 'Grid.Forward' and 'NextWaypoint.Forward' or 'Grid.Position - NextWaypoint.Position' when going toward first waypoint before starting thrust

##### Declaration

```
public float CourseCorrectionMaxRemainingRotationBeforeThrust
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CourseCorrectionMaxRemainingRotationBeforeThrustInPrecisionMode

Max angle in radians between vectors 'Grid.Forward' and 'NextWaypoint.Forward' or 'Grid.Position - NextWaypoint.Position' when going toward first waypoint before starting thrust. In Precision mode

##### Declaration

```
public float CourseCorrectionMaxRemainingRotationBeforeThrustInPrecisionMode
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CourseCorrectionMaxThrustPercentage

Max percentage of thrust dedicated to correcting course toward nearest point on direct line between two traveled points

##### Declaration

```
public float CourseCorrectionMaxThrustPercentage
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DefaultPitchAngleDeg

Default value of MaxPitchAngle in degrees for newly built block

##### Declaration

```
public float DefaultPitchAngleDeg
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DefaultRollAngleDeg

Default value of MaxRollAngle in degrees for newly built block

##### Declaration

```
public float DefaultRollAngleDeg
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxPitchAngleDeg

When moving to a waypoint in P-Gravity, the grid may pitch up or down by this angle in degrees

##### Declaration

```
public float MaxPitchAngleDeg
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxRollAngleDeg

When moving to a waypoint in P-Gravity, the grid may roll left or right by this angle in degrees

##### Declaration

```
public float MaxRollAngleDeg
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxRotationSpeed

Minimum rotation speed (vanila was about 1.8)

##### Declaration

```
[Nullable]
public Nullable<float> MaxRotationSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### MaxRotationSpeedTresholdRadians

Above this value rotation speed will always be MaxRotationSpeed (vanila was infinite)

##### Declaration

```
[Nullable]
public Nullable<float> MaxRotationSpeedTresholdRadians
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### MinHeightAboveTerrainBounds

##### Declaration

```
public SerializableBounds MinHeightAboveTerrainBounds
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.SerializableBounds |     |

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

Minimum rotation speed (vanila was about 0.05)

##### Declaration

```
[Nullable]
public Nullable<float> MinRotationSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### MinRotationSpeedThresholdRadians

Under this value rotation speed will always be MinRotationSpeed (vanila was 0)
