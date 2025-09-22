---
title: "Class MyObjectBuilder\\_Character"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Character.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_Character"
---

# Class MyObjectBuilder\_Character | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Character

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_Character : MyObjectBuilder_EntityBase
```

### Constructors

#### MyObjectBuilder\_Character()

##### Declaration

```
public MyObjectBuilder_Character()
```

### Fields

#### AIMode

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AutoenableJetpackDelay

##### Declaration

```
public float AutoenableJetpackDelay
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Battery

##### Declaration

```
public MyObjectBuilder_Battery Battery
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Battery](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Battery.html) |     |

#### BuildPlanner

##### Declaration

```
[Serialize]
public List<MyObjectBuilder_Character.BuildPlanItem> BuildPlanner
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_Character.BuildPlanItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Character.BuildPlanItem.html)\> |     |

#### CharacterGeneralDamageModifier

##### Declaration

```
public float CharacterGeneralDamageModifier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CharacterModel

##### Declaration

```
public string CharacterModel
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### CharacterModels

##### Declaration

```
public static Dictionary<string, SerializableVector3> CharacterModels
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, VRage.SerializableVector3\> |     |

#### CharacterSpeedDebuff

##### Declaration

```
public float CharacterSpeedDebuff
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ColorMaskHSV

##### Declaration

```
public SerializableVector3 ColorMaskHSV
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.SerializableVector3 |     |

#### DampenersEnabled

##### Declaration

```
public bool DampenersEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DisplayName

##### Declaration

```
public string DisplayName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### EnableBroadcasting

##### Declaration

```
public bool EnableBroadcasting
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnableBroadcastingPlayerToggle

##### Declaration

```
public bool EnableBroadcastingPlayerToggle
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnabledComponents

##### Declaration

```
[Nullable]
public List<string> EnabledComponents
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### EnvironmentOxygenLevel

##### Declaration

```
public float EnvironmentOxygenLevel
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### HandWeapon

##### Declaration

```
[Nullable]
[DynamicObjectBuilder(false)]
public MyObjectBuilder_EntityBase HandWeapon
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

#### HeadAngle

##### Declaration

```
public SerializableVector2 HeadAngle
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.SerializableVector2 |     |

#### Health

##### Declaration

```
[NoSerialize]
public Nullable<float> Health
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### Inventory

##### Declaration

```
[Serialize]
public MyObjectBuilder_Inventory Inventory
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Inventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Inventory.html) |     |

#### IsInFirstPersonView

##### Declaration

```
public bool IsInFirstPersonView
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPersistenceCharacter

##### Declaration

```
public bool IsPersistenceCharacter
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsStartingCharacterForLobby

##### Declaration

```
public bool IsStartingCharacterForLobby
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### JetpackEnabled

##### Declaration

```
public bool JetpackEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LightEnabled

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LinearVelocity

##### Declaration

```
public SerializableVector3 LinearVelocity
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.SerializableVector3 |     |

#### LootingCounter

##### Declaration

```
public float LootingCounter
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MovementState

##### Declaration

```
public MyCharacterMovementEnum MovementState
```
