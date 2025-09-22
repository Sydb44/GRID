---
title: "Class MyDamageInformation"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDamageInformation.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "MyDamageInformation"
---

# Class MyDamageInformation | Space Engineers ModAPI

This structure contains all information about damage being done.

##### Inheritance

System.Object

MyDamageInformation

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyDamageInformation : ValueType
```

### [](#constructors)Constructors

#### [](#VRage_Game_ModAPI_MyDamageInformation__ctor_System_Boolean_System_Single_VRage_Utils_MyStringHash_System_Int64_System_Nullable_VRage_Utils_MyStringHash__)MyDamageInformation(Boolean, Single, MyStringHash, Int64, Nullable<MyStringHash>)

Damage information constructor

##### Declaration

```
public MyDamageInformation(bool isDeformation, float amount, MyStringHash type, long attackerId, Nullable<MyStringHash> extraInfo = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | isDeformation | true if deformation should happen |
| System.Single | amount | damage amount |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | type | type of the damage |
| System.Int64 | attackerId | id of the attacker |
| System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\> | extraInfo | Extra info about what caused damage. For projectiles and missiles direct damage it is storing ammo SubtypeName that caused damage |

### [](#fields)Fields

#### [](#VRage_Game_ModAPI_MyDamageInformation_Amount)Amount

Gets or Sets the amount of the damage

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_MyDamageInformation_AttackerId)AttackerId

Gets or Sets the id of the attacker

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

Gets or Sets the type of the damage

##### Declaration

```
public Nullable<MyStringHash> ExtraInfo
```

##### Field Value

#### [](#VRage_Game_ModAPI_MyDamageInformation_IsDeformation)IsDeformation

Determines whether deformation is enabled

##### Declaration

```
public bool IsDeformation
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_MyDamageInformation_Type)Type

Gets or Sets the type of the damage

##### Declaration

##### Field Value