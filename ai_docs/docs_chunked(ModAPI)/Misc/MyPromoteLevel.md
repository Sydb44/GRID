---
title: "Class MyPromoteLevel"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyPromoteLevel.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "MyPromoteLevel"
---

# Class MyPromoteLevel | Space Engineers ModAPI

Describes what permissions a user has If you add items, always preserve order from lowest to highest permission

##### Inheritance

System.Object

MyPromoteLevel

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyPromoteLevel : Enum
```

### [](#fields)Fields

#### [](#VRage_Game_ModAPI_MyPromoteLevel_Admin)Admin

Has access to Admin tools

##### Declaration

```
public const MyPromoteLevel Admin
```

##### Field Value

#### [](#VRage_Game_ModAPI_MyPromoteLevel_Moderator)Moderator

Can kick and ban players, has access to 'Show All Players' option in Admin Tools menu

##### Declaration

```
public const MyPromoteLevel Moderator
```

##### Field Value

#### [](#VRage_Game_ModAPI_MyPromoteLevel_None)None

Normal players

##### Declaration

```
public const MyPromoteLevel None
```

##### Field Value

#### [](#VRage_Game_ModAPI_MyPromoteLevel_Owner)Owner

Admins listed in server config, cannot be demoted

##### Declaration

```
public const MyPromoteLevel Owner
```

##### Field Value

#### [](#VRage_Game_ModAPI_MyPromoteLevel_Scripter)Scripter

Can edit scripts when the scripter role is enabled

##### Declaration

```
public const MyPromoteLevel Scripter
```

##### Field Value

#### [](#VRage_Game_ModAPI_MyPromoteLevel_SpaceMaster)SpaceMaster

Has access to Space Master tools

##### Declaration

```
public const MyPromoteLevel SpaceMaster
```

##### Field Value

#### [](#VRage_Game_ModAPI_MyPromoteLevel_value__)value\_\_

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |