#### add\_OnMovementStateChanged(CharacterMovementStateDelegate)

##### Declaration

```
void add_OnMovementStateChanged(CharacterMovementStateDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CharacterMovementStateDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.CharacterMovementStateDelegate.html) | value |     |

#### GetOutsideTemperature()

Returns outside temperature around character. If character is in presurrized/oxygen environment, then the temperature is always friendly.

##### Declaration

```
float GetOutsideTemperature()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single | 0 for extreme freeze, 0.5 for cozy, 1.0 for extreme hot |

#### GetSuitGasFillLevel(MyDefinitionId)

Returns the amount of gas left in the suit, values will range between 0 and 1, where 0 is no gas and 1 is full gas.

##### Declaration

```
float GetSuitGasFillLevel(MyDefinitionId gasDefinitionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | gasDefinitionId | Definition Id of the gas. Common example: new MyDefinitionId(typeof(MyObjectBuilder\_GasProperties), "Oxygen") |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Kill(Object)

Kills the character

##### Declaration

```
void Kill(object killData = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | killData |     |

#### remove\_MovementStateChanged(CharacterMovementStateChangedDelegate)

##### Declaration

```
void remove_MovementStateChanged(CharacterMovementStateChangedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CharacterMovementStateChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.CharacterMovementStateChangedDelegate.html) | value |     |

#### remove\_OnMovementStateChanged(CharacterMovementStateDelegate)

##### Declaration

```
void remove_OnMovementStateChanged(CharacterMovementStateDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CharacterMovementStateDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.CharacterMovementStateDelegate.html) | value |     |

#### SetCharacterSpeedDebuff(Single)

Sets character speed debuf

##### Declaration

```
void SetCharacterSpeedDebuff(float debuffValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | debuffValue |     |

#### TriggerCharacterAnimationEvent(String, Boolean)

Trigger animation event in the new animation system. If there is a transition leading from current animation state having same name as this event, animation state machine will change state accordingly. If not, nothing happens.

##### Declaration

```
void TriggerCharacterAnimationEvent(string eventName, bool sync)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | eventName | Event name. |
| System.Boolean | sync | Synchronize over network |

### Events

#### CharacterDied

Event triggered when character dies

##### Declaration

```
event Action<IMyCharacter> CharacterDied
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html)\> |     |

#### MovementStateChanged

Called when the movement state changes

##### Declaration

```
event CharacterMovementStateChangedDelegate MovementStateChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| [CharacterMovementStateChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.CharacterMovementStateChangedDelegate.html) |     |

#### OnMovementStateChanged

##### Declaration

```
event CharacterMovementStateDelegate OnMovementStateChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| [CharacterMovementStateDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.CharacterMovementStateDelegate.html) |     |