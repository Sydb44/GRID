---
title: "Interface IMyLargeTurretBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyLargeTurretBase.html"
category: "Weapons"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyLargeTurretBase"
---

# Interface IMyLargeTurretBase | Space Engineers ModAPI

Describes turret block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyLargeTurretBase : IMyUserControllableGun, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### AIEnabled

Checks is AI is enabled for turret

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Azimuth

Gets or sets azimuth of turret, this method is not synced, you need to sync azimuth manually

##### Declaration

```
float Azimuth { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CanControl

Returns true if current player can control this block. Always return false on Dedicated Server

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Elevation

Gets / sets elevation of turret, this method is not synced, you need to sync elevation manually

##### Declaration

```
float Elevation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EnableIdleRotation

Enable/disable idle rotation for turret, this method is not synced, you need to sync manually

##### Declaration

```
bool EnableIdleRotation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### HasTarget

Checks if the turret is locked onto a target

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsAimed

Returns true if turret head looking at target

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsUnderControl

Indicates whether a block is locally or remotely controlled.

##### Declaration

```
bool IsUnderControl { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Range

Gets and Sets shooting range of the turret

##### Declaration

```
float Range { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### TargetCharacters

Gets/sets if the turret should target characters.

##### Declaration

```
bool TargetCharacters { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetEnemies

Gets/sets if the turret should target enemies.

##### Declaration

```
bool TargetEnemies { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetLargeGrids

Gets/sets if the turret should target large grids.

##### Declaration

```
bool TargetLargeGrids { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetMeteors

Gets/sets if the turret should target meteors.

##### Declaration

```
bool TargetMeteors { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetMissiles

Gets/sets if the turret should target missiles.

##### Declaration

```
bool TargetMissiles { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetNeutrals

Gets/sets if the turret should target neutrals.

##### Declaration

```
bool TargetNeutrals { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetSmallGrids

Gets/sets if the turret should target small grids.

##### Declaration

```
bool TargetSmallGrids { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetStations

Gets/sets if the turret should target stations.

##### Declaration

```
bool TargetStations { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetTargetedEntity()

Gets the turret's current detected entity, if any

##### Declaration

```
MyDetectedEntityInfo GetTargetedEntity()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyDetectedEntityInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityInfo.html) |     |

#### GetTargetingGroup()

Gets current targeting group

##### Declaration

```
string GetTargetingGroup()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetTargetingGroups()

Obsolete

##### Declaration

```
List<string> GetTargetingGroups()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### GetTargetingGroups(List<String>)

Gets all available targeting groups

##### Declaration

```
void GetTargetingGroups(List<string> targetingGroups)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.String\> | targetingGroups | All targeting groups |

#### ResetTargetingToDefault()

Resets targeting to default values

##### Declaration

```
void ResetTargetingToDefault()
```

#### SetManualAzimuthAndElevation(Single, Single)

Sets azimuth and elevation of the turret, this method is not synced, you need to sync it manually. Call SyncAzimuth or SyncElevation.

##### Declaration

```
void SetManualAzimuthAndElevation(float azimuth, float elevation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | azimuth | azimuth value |
| System.Single | elevation | elevation value |
