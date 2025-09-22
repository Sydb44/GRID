```

##### Parameters

Type

Name

Description

System.String

blockName

#### TriggerTimerBlockForNonFriendlyPlayer(String, Int64)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Calls 'TriggerNow' action on specific functional block If PlayerId belongs to not friendly player", -10510688)]
[VisualScriptingMember(true, false)]
public static void TriggerTimerBlockForNonFriendlyPlayer(string blockName, long playerId)
```

##### Parameters

Type

Name

Description

System.String

blockName

System.Int64

playerId

#### UnlockAchievementById(Int32, Int64)

##### Declaration

```
[VisualScriptingMiscData("Achievements", "Award player achievement. Id ID is -1, unlock to all, if ID is 0, unlock to local player, if anything else, it unlocks to player with that ID", -10510688)]
[VisualScriptingMember(true, false)]
public static void UnlockAchievementById(int achievementId, long playerId)
```

##### Parameters

Type

Name

Description

System.Int32

achievementId

System.Int64

playerId

#### WeaponSetShooting(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Turns on/off shooting for specific weapon block (UserControllableGun)", -10510688)]
[VisualScriptingMember(true, false)]
public static void WeaponSetShooting(string weaponName, bool shooting = true)
```

##### Parameters

Type

Name

Description

System.String

weaponName

System.Boolean

shooting

#### WeaponShootOnce(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Orders specific weapon block (UserControllableGun) to shoot once.", -10510688)]
[VisualScriptingMember(true, false)]
public static void WeaponShootOnce(string weaponName)
```

##### Parameters

Type

Name

Description

System.String

weaponName