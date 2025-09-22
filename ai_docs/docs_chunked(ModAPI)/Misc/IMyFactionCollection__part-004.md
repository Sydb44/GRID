#### FactionAutoAcceptChanged

##### Declaration

```
event Action<long, bool, bool> FactionAutoAcceptChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Int64, System.Boolean, System.Boolean\> |     |

#### FactionCreated

Called when new faction created. FactionId is used as argument

##### Declaration

```
event Action<long> FactionCreated
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Int64\> |     |

#### FactionEdited

Called when faction somehow changes.

##### Declaration

```
event Action<long> FactionEdited
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Int64\> |     |

#### FactionStateChanged

Called when on of factions changed Arguments: action, fromFactionId, faction Id toFactionId, faction Id, or 0 playerId - IdentityId on whom action was applied, or 0 senderId - IdentityId who triggered state change, or 0

##### Declaration

```
event Action<MyFactionStateChange, long, long, long, long> FactionStateChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyFactionStateChange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyFactionStateChange.html), System.Int64, System.Int64, System.Int64, System.Int64\> |     |

#### ReputationChanged

Called when a reputation change is applied between an identity and a faction

##### Declaration

```
event Action<long, long, int, ReputationChangeReason> ReputationChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Int64, System.Int64, System.Int32, [ReputationChangeReason](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.ReputationChangeReason.html)\> |     |