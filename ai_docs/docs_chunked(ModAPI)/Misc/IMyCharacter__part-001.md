---
title: "Interface IMyCharacter"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyCharacter"
---

# Interface IMyCharacter | Space Engineers ModAPI

Describes character (mods interface)

##### Inherited Members

[IMyDecalProxy.AddDecals(MyHitInfo, MyStringHash, Vector3, Object, IMyDecalHandler, MyStringHash, MyStringHash, Boolean, MyDecalFlags, Int32, List<UInt32>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyDecalProxy.html#VRage_Game_ModAPI_Interfaces_IMyDecalProxy_AddDecals_VRage_Game_ModAPI_MyHitInfo__VRage_Utils_MyStringHash_VRageMath_Vector3_System_Object_VRage_Game_ModAPI_Interfaces_IMyDecalHandler_VRage_Utils_MyStringHash_VRage_Utils_MyStringHash_System_Boolean_VRageRender_MyDecalFlags_System_Int32_System_Collections_Generic_List_System_UInt32__)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyCharacter : IMyEntity, IMyEntity, IMyControllableEntity, IMyCameraController, IMyDestroyableObject, IMyDecalProxy
```

### Properties

#### AimedPoint

Gets or, for non-player controlled characters, sets the aimed point direction.

##### Declaration

```
Vector3D AimedPoint { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### BaseMass

Gets the base mass of the character

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CanSprint

Gets/Sets if character can sprint

##### Declaration

```
bool CanSprint { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CharacterGeneralDamageModifier

Allows you to get or set the damage modifier of a character.

##### Declaration

```
float CharacterGeneralDamageModifier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CurrentMass

Gets the entire mass of the character, including inventory

##### Declaration

```
float CurrentMass { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CurrentMovementState

Gets the character's current movement state.

##### Declaration

```
MyCharacterMovementEnum CurrentMovementState { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCharacterMovementEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCharacterMovementEnum.html) |     |

#### Definition

The character definition. Cast to MyCharacterDefinition.

##### Declaration

```
MyDefinitionBase Definition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html) |     |

#### EnvironmentOxygenLevel

Gets the amount of oxygen in the surrounding environment

##### Declaration

```
float EnvironmentOxygenLevel { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EquippedTool

Gets currently equipped tool (IMyHandheldGunObject)

##### Declaration

```
IMyEntity EquippedTool { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IsBot

Returns true if this character is an AI character, otherwise false.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsDead

Returns true if this character is dead

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPlayer

Returns true if this character is a player character, otherwise false.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OxygenLevel

Gets the amount of oxygen at the character location from air pressure system (grids with airtightness)

##### Declaration

```
float OxygenLevel { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PreviousMovementState

Gets the character's previous movement state.

##### Declaration

```
MyCharacterMovementEnum PreviousMovementState { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCharacterMovementEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCharacterMovementEnum.html) |     |

#### SuitEnergyLevel

Returns the amount of energy the suit has, values will range between 0 and 1, where 0 is no charge and 1 is full charge.

##### Declaration

```
float SuitEnergyLevel { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### UsingEntity

Gets currently used entity by character (cockpit, cryo etc.)

##### Declaration

```
IMyEntity UsingEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

### Methods

#### add\_MovementStateChanged(CharacterMovementStateChangedDelegate)

##### Declaration

```
void add_MovementStateChanged(CharacterMovementStateChangedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CharacterMovementStateChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.CharacterMovementStateChangedDelegate.html) | value |     |

#### add\_OnMovementStateChanged(CharacterMovementStateDelegate)

##### Declaration

```
void add_OnMovementStateChanged(CharacterMovementStateDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CharacterMovementStateDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.CharacterMovementStateDelegate.html) | value |     |
