---
title: "Interface IMyHazardSource"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyHazardSource.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyHazardSource"
---

# Interface IMyHazardSource | Space Engineers ModAPI

Describes the ambient hazard source that affects entity stats

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyHazardSource
```

### Properties

#### DamageType

If the hazard affects Health stat, [MyDamageType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDamageType.html) is used to differentiate kinds of damage

##### Declaration

```
MyStringHash DamageType { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### IgnoresSheltering

Indicates whether the source penetrates [IMyHazardReceiver](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyHazardReceiver.html) sheltering logic. When true, CanBeAffected result is ignored.

##### Declaration

```
bool IgnoresSheltering { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsExposureScalingNeeded

Indicates whether the value provided by GetCurrentExposure needs adjustment based on call interval. If the stat is meant to be affected in bursts (e.g. Health damage) and the source is responsible for correct average magnitude, this should return false

##### Declaration

```
bool IsExposureScalingNeeded { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### StatId

ID of the affected entity stat

##### Declaration

```
MyStringHash StatId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

### Methods

#### GetCurrentExposure(IMyHazardReceiver)

Provides momentary hazard exposure which would be scaled according to the update rate

##### Declaration

```
float GetCurrentExposure(IMyHazardReceiver receiver)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyHazardReceiver](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyHazardReceiver.html) | receiver | The subject for exposure |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Momentary exposure amount |