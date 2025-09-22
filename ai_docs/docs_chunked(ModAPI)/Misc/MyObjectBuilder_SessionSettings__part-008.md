[GameRelation]
public float VoxelGridDistanceThreshold
```

##### Field Value

Type

Description

System.Single

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_VoxelPlayerDistanceThreshold)VoxelPlayerDistanceThreshold

##### Declaration

```
[GameRelation]
public float VoxelPlayerDistanceThreshold
```

##### Field Value

Type

Description

System.Single

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_VoxelTrashRemovalEnabled)VoxelTrashRemovalEnabled

##### Declaration

```
[GameRelation]
public bool VoxelTrashRemovalEnabled
```

##### Field Value

Type

Description

System.Boolean

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_WeaponsEnabled)WeaponsEnabled

##### Declaration

```
[GameRelation]
public bool WeaponsEnabled
```

##### Field Value

Type

Description

System.Boolean

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_WeatherLightingDamage)WeatherLightingDamage

##### Declaration

```
[GameRelation]
public bool WeatherLightingDamage
```

##### Field Value

Type

Description

System.Boolean

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_WeatherSystem)WeatherSystem

##### Declaration

```
[GameRelation]
public bool WeatherSystem
```

##### Field Value

Type

Description

System.Boolean

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_WelderSpeedMultiplier)WelderSpeedMultiplier

##### Declaration

```
[GameRelation]
public float WelderSpeedMultiplier
```

##### Field Value

Type

Description

System.Single

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_WorldSizeKm)WorldSizeKm

Size of the edge of the world area cube. Don't use directly, as it is error-prone (it's km instead of m and edge size instead of half-extent) Rather use MyEntities.WorldHalfExtent()

##### Declaration

```
[GameRelation]
public int WorldSizeKm
```

##### Field Value

Type

Description

System.Int32

### [](#properties)Properties

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_AutoSave)AutoSave

##### Declaration

```
public bool AutoSave { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_ClientCanSave)ClientCanSave

##### Declaration

```
[GameRelation]
[NoSerialize]
public bool ClientCanSave { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_TrashFlags)TrashFlags

##### Declaration

```
public MyTrashRemovalFlags TrashFlags { get; set; }
```

##### Property Value

### [](#methods)Methods

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_GetExperimentalReason_System_Boolean_)GetExperimentalReason(Boolean)

##### Declaration

```
public MyObjectBuilder_SessionSettings.ExperimentalReason GetExperimentalReason(bool remote)
```

##### Parameters

Type

Name

Description

System.Boolean

remote

##### Returns

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_GetInitialPCU_VRage_Game_MyObjectBuilder_SessionSettings_)GetInitialPCU(MyObjectBuilder\_SessionSettings)

If you are modifying this function, also modify MyBlockLimits.GetInitialPCU (This function cannot be moved into MyBlockLimits as using MyBlockLimits while MySession.Static == null will result in crash during intialization of statics of MyBlockLimits)

##### Declaration

```
public static int GetInitialPCU(MyObjectBuilder_SessionSettings settings)
```

##### Parameters

##### Returns

Type

Description

System.Int32

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_IsSettingsExperimental_System_Boolean_)IsSettingsExperimental(Boolean)

##### Declaration

```
public bool IsSettingsExperimental(bool remote)
```

##### Parameters

Type

Name

Description

System.Boolean

remote

##### Returns

Type

Description

System.Boolean

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_LogMembers_VRage_Utils_MyLog_VRage_Utils_LoggingOptions_)LogMembers(MyLog, LoggingOptions)

##### Declaration

```
public void LogMembers(MyLog log, LoggingOptions options)
```

##### Parameters

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_ShouldSerializeAutoSave)ShouldSerializeAutoSave()

##### Declaration

```
public bool ShouldSerializeAutoSave()
```

##### Returns

Type

Description

System.Boolean

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_ShouldSerializeEncounterDensity)ShouldSerializeEncounterDensity()

##### Declaration

```
public bool ShouldSerializeEncounterDensity()
```

##### Returns

Type

Description

System.Boolean

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_ShouldSerializeProceduralDensity)ShouldSerializeProceduralDensity()

##### Declaration

```
public bool ShouldSerializeProceduralDensity()
```

##### Returns

Type

Description

System.Boolean

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_ShouldSerializeProceduralSeed)ShouldSerializeProceduralSeed()

##### Declaration

```
public bool ShouldSerializeProceduralSeed()
```

##### Returns

Type

Description

System.Boolean

#### [](#VRage_Game_MyObjectBuilder_SessionSettings_ShouldSerializeTrashFlags)ShouldSerializeTrashFlags()

##### Declaration

```
public bool ShouldSerializeTrashFlags()
```

##### Returns

Type

Description

System.Boolean

### [](#extensionmethods)Extension Methods