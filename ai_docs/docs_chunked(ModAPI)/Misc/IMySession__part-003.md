Gets or sets name of the game

##### Declaration

```
string Name { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMySession_NegativeIntegrityTotal)NegativeIntegrityTotal

Gets or sets amount of damage applied to blocks

##### Declaration

```
float NegativeIntegrityTotal { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMySession_OnlineMode)OnlineMode

Gets current session online mode

##### Declaration

```
MyOnlineModeEnum OnlineMode { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_OxygenProviderSystem)OxygenProviderSystem

Gets ModAPI interface providing control oxygen system

##### Declaration

```
IMyOxygenProviderSystem OxygenProviderSystem { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_Password)Password

Gets or sets password, that player must enter to join server

##### Declaration

```
string Password { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMySession_Player)Player

##### Declaration

```
IMyPlayer Player { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_PositiveIntegrityTotal)PositiveIntegrityTotal

Gets or sets amount of integrity added to blocks

##### Declaration

```
float PositiveIntegrityTotal { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMySession_PromoteLevel)PromoteLevel

Gets the local player's promote level.

##### Declaration

```
MyPromoteLevel PromoteLevel { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_RefinerySpeedMultiplier)RefinerySpeedMultiplier

Gets or sets global refinery speed multiplier

##### Declaration

```
float RefinerySpeedMultiplier { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMySession_SessionSettings)SessionSettings

##### Declaration

```
MyObjectBuilder_SessionSettings SessionSettings { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_ShowPlayerNamesOnHud)ShowPlayerNamesOnHud

Gets whether player names should be drawn on hud

##### Declaration

```
bool ShowPlayerNamesOnHud { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_SurvivalMode)SurvivalMode

Gets whether current create game is in creative mode

##### Declaration

```
bool SurvivalMode { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_ThrusterDamage)ThrusterDamage

Gets whether thruster damage setting is enable

##### Declaration

```
bool ThrusterDamage { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_ThumbPath)ThumbPath

Gets current game path to thumbnail

##### Declaration

```
string ThumbPath { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMySession_TimeOnBigShip)TimeOnBigShip

Gets time spent on controlling large grid

##### Declaration

```
TimeSpan TimeOnBigShip { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.TimeSpan |     |

#### [](#VRage_Game_ModAPI_IMySession_TimeOnFoot)TimeOnFoot

Gets time spent on foot

##### Declaration

```
TimeSpan TimeOnFoot { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.TimeSpan |     |

#### [](#VRage_Game_ModAPI_IMySession_TimeOnJetpack)TimeOnJetpack

Gets time spent flying on jetpack

##### Declaration

```
TimeSpan TimeOnJetpack { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.TimeSpan |     |

#### [](#VRage_Game_ModAPI_IMySession_TimeOnSmallShip)TimeOnSmallShip

Gets time spent on controlling small ship

##### Declaration

```
TimeSpan TimeOnSmallShip { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.TimeSpan |     |

#### [](#VRage_Game_ModAPI_IMySession_TotalBotLimit)TotalBotLimit

Gets limitation on maximum bot amount

##### Declaration

```
int TotalBotLimit { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_IMySession_Version)Version

Get version of Space Engineers

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Version |     |

#### [](#VRage_Game_ModAPI_IMySession_VoxelMaps)VoxelMaps

Gets ModAPI interface providing control over voxel maps

##### Declaration

```
IMyVoxelMaps VoxelMaps { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_WeaponsEnabled)WeaponsEnabled

Gets whether weapons are enabled in current game

##### Declaration

```
bool WeaponsEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_WeatherEffects)WeatherEffects

Gets MySectorWeatherComponent ModAPI interface

##### Declaration

```
IMyWeatherEffects WeatherEffects { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_WelderSpeedMultiplier)WelderSpeedMultiplier

Gets current game welder speed global multiplier

##### Declaration

```
float WelderSpeedMultiplier { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMySession_WorkshopId)WorkshopId

Gets current game scenario workshop id

##### Declaration

```
Nullable<ulong> WorkshopId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.UInt64\> |     |

#### [](#VRage_Game_ModAPI_IMySession_WorldBoundaries)WorldBoundaries

Gets world boundaries. Not letting character leaving them
