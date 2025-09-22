---
title: "Interface IMySearchlight"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMySearchlight.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMySearchlight"
---

# Interface IMySearchlight | Space Engineers ModAPI

Describes spotlight block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMySearchlight : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### AimingRadius

Gets/sets aiming radius

##### Declaration

```
float AimingRadius { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BlinkInterval

Gets/sets light blink interval

##### Declaration

```
float BlinkInterval { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BlinkLength

Gets/sets light blink length

##### Declaration

```
float BlinkLength { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BlinkOffset

Gets/sets light blink offset

##### Declaration

```
float BlinkOffset { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Color

Sets/sets color of the light

##### Declaration

```
Color Color { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### EnableIdleMovement

Enables idle movement

##### Declaration

```
bool EnableIdleMovement { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intensity

Gets/sets light intensity

##### Declaration

```
float Intensity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Offset

Gets/sets light offset

##### Declaration

```
float Offset { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Radius

Gets/sets light radius

##### Declaration

```
float Radius { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### TargetCharacters

Enables targeting characters

##### Declaration

```
bool TargetCharacters { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetEnemy

Enables targeting enemy entities

##### Declaration

```
bool TargetEnemy { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetFriends

Enables targeting friendly entities

##### Declaration

```
bool TargetFriends { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetLargeShips

Enables targeting large ships

##### Declaration

```
bool TargetLargeShips { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetLockEnemy

Enables target locking enemy entities

##### Declaration

```
bool TargetLockEnemy { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetMeteors

Enables targeting meteors

##### Declaration

```
bool TargetMeteors { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetNeutrals

Enables targeting neutral entities

##### Declaration

```
bool TargetNeutrals { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetOptions

Enables targeting enemy entities

##### Declaration

```
TargetingGroupOptions TargetOptions { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [TargetingGroupOptions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.TargetingGroupOptions.html) |     |

#### TargetRockets

Enables targeting rockets

##### Declaration

```
bool TargetRockets { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetSmallShips

Enables targeting small ships

##### Declaration

```
bool TargetSmallShips { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetStations

Enables targeting station

##### Declaration

```
bool TargetStations { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### SetManualAzimuthAndElevation(Single, Single)

Sets azimuth and elevation to look at

##### Declaration

```
void SetManualAzimuthAndElevation(float azimuth, float elevation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | azimuth |     |
| System.Single | elevation |     |

#### SetTargetOptions(TargetingGroupOptions)

Enables target locking for enemy targets

##### Declaration

```
void SetTargetOptions(TargetingGroupOptions Options)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [TargetingGroupOptions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.TargetingGroupOptions.html) | Options |     |

### Extension Methods