##### Declaration

```
public static PlayerSuitRechargeEvent PlayerSuitRecharging
```

##### Field Value

Type

Description

[PlayerSuitRechargeEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.PlayerSuitRechargeEvent.html)

#### PrefabSpawned

##### Declaration

```
public static SingleKeyEntityNameEvent PrefabSpawned
```

##### Field Value

Type

Description

[SingleKeyEntityNameEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.SingleKeyEntityNameEvent.html)

#### PrefabSpawnedDetailed

##### Declaration

```
public static PrefabSpawnedEvent PrefabSpawnedDetailed
```

##### Field Value

Type

Description

[PrefabSpawnedEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.PrefabSpawnedEvent.html)

#### RemoteControlChanged

##### Declaration

```
public static RemoteControlChangedEvent RemoteControlChanged
```

##### Field Value

Type

Description

[RemoteControlChangedEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.RemoteControlChangedEvent.html)

#### RespawnShipSpawned

##### Declaration

```
public static RespawnShipSpawnedEvent RespawnShipSpawned
```

##### Field Value

Type

Description

[RespawnShipSpawnedEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.RespawnShipSpawnedEvent.html)

#### RoomFullyPressurized

##### Declaration

```
public static RoomFullyPressurizedEvent RoomFullyPressurized
```

##### Field Value

Type

Description

[RoomFullyPressurizedEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.RoomFullyPressurizedEvent.html)

#### ScreenAdded

##### Declaration

```
public static ScreenManagerEvent ScreenAdded
```

##### Field Value

Type

Description

[ScreenManagerEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.ScreenManagerEvent.html)

#### ScreenRemoved

##### Declaration

```
public static ScreenManagerEvent ScreenRemoved
```

##### Field Value

Type

Description

[ScreenManagerEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.ScreenManagerEvent.html)

#### ShipDrillCollected

##### Declaration

```
public static ShipDrillCollectedEvent ShipDrillCollected
```

##### Field Value

Type

Description

[ShipDrillCollectedEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.ShipDrillCollectedEvent.html)

#### TeamBalancerPlayerSorted

##### Declaration

```
public static TeamBalancerSortEvent TeamBalancerPlayerSorted
```

##### Field Value

Type

Description

[TeamBalancerSortEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.TeamBalancerSortEvent.html)

#### TimerBlockTriggered

##### Declaration

```
public static SingleKeyEntityNameGridNameEvent TimerBlockTriggered
```

##### Field Value

Type

Description

[SingleKeyEntityNameGridNameEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.SingleKeyEntityNameGridNameEvent.html)

#### TimerBlockTriggeredEntityName

##### Declaration

```
public static SingleKeyEntityNameGridNameEvent TimerBlockTriggeredEntityName
```

##### Field Value

Type

Description

[SingleKeyEntityNameGridNameEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.SingleKeyEntityNameGridNameEvent.html)

#### ToolbarItemChanged

##### Declaration

```
public static ToolbarItemChangedEvent ToolbarItemChanged
```

##### Field Value

Type

Description

[ToolbarItemChangedEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.ToolbarItemChangedEvent.html)

#### ToolEquipped

##### Declaration

```
public static ToolEquipedEvent ToolEquipped
```

##### Field Value

Type

Description

[ToolEquipedEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.ToolEquipedEvent.html)

#### WeaponBlockActivated

##### Declaration

```
public static WeaponBlockActivatedEvent WeaponBlockActivated
```

##### Field Value

Type

Description

[WeaponBlockActivatedEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WeaponBlockActivatedEvent.html)

### Methods

#### AddAcquisitionContract(Int64, Int32, Int32, Int32, Int64, MyDefinitionId, Int32, out Int64)

##### Declaration

```
[VisualScriptingMiscData("Contract", "Create and add new Acquisition contract. Returns true if contract creation was successful. Id of newly created contract is stored in out variable id. End block is contract block where items of type 'itemType' in quantity 'itemAmount' are to be delivered.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool AddAcquisitionContract(long startBlockId, int moneyReward, int collateral, int duration, long endBlockId, MyDefinitionId itemType, int itemAmount, out long id)
```

##### Parameters

Type

Name

Description

System.Int64

startBlockId

System.Int32

moneyReward

System.Int32

collateral

System.Int32

duration

System.Int64

endBlockId

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemType

System.Int32

itemAmount

System.Int64

id

##### Returns

Type

Description

System.Boolean

#### AddBountyContract(Int64, Int32, Int32, Int32, Int64, out Int64)

##### Declaration

```
[VisualScriptingMiscData("Contract", "Create and add new Bounty contract. Returns true if contract creation was successful. Id of newly created contract is stored in out variable id.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool AddBountyContract(long startBlockId, int moneyReward, int collateral, int duration, long targetIdentityId, out long id)
```

##### Parameters

Type

Name

Description

System.Int64

startBlockId

System.Int32

moneyReward

System.Int32

collateral

System.Int32

duration

System.Int64

targetIdentityId

System.Int64

id

##### Returns

Type

Description

System.Boolean

#### AddColumn(String, String, Single, String, MyGuiDrawAlignEnum, MyGuiDrawAlignEnum, Int64)
