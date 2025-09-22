---
title: "Class MyObjectBuilder\\_Checkpoint"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Checkpoint.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_Checkpoint"
---

# Class MyObjectBuilder\_Checkpoint | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Checkpoint

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_Checkpoint : MyObjectBuilder_Base
```

### [](#constructors)Constructors

#### [](#VRage_Game_MyObjectBuilder_Checkpoint__ctor)MyObjectBuilder\_Checkpoint()

##### Declaration

```
public MyObjectBuilder_Checkpoint()
```

### [](#fields)Fields

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_AllPlayers)AllPlayers

##### Declaration

```
public List<MyObjectBuilder_Checkpoint.PlayerItem> AllPlayers
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_AllPlayersColors)AllPlayersColors

##### Declaration

```
public SerializableDictionary<MyObjectBuilder_Checkpoint.PlayerId, List<Vector3>> AllPlayersColors
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_AllPlayersData)AllPlayersData

##### Declaration

```
public SerializableDictionary<MyObjectBuilder_Checkpoint.PlayerId, MyObjectBuilder_Player> AllPlayersData
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_AppVersion)AppVersion

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_CameraController)CameraController

##### Declaration

```
public MyCameraControllerEnum CameraController
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_CameraEntity)CameraEntity

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_CharacterToolbar)CharacterToolbar

##### Declaration

```
public MyObjectBuilder_Toolbar CharacterToolbar
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ChatHistory)ChatHistory

##### Declaration

```
public List<MyObjectBuilder_ChatHistory> ChatHistory
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_Clients)Clients

##### Declaration

```
public List<MyObjectBuilder_Client> Clients
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ConnectedPlayers)ConnectedPlayers

##### Declaration

```
public SerializableDictionary<MyObjectBuilder_Checkpoint.PlayerId, MyObjectBuilder_Player> ConnectedPlayers
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ContainerGridIds)ContainerGridIds

##### Declaration

```
public SerializableDictionary<ulong, List<long>> ContainerGridIds
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Serialization.SerializableDictionary<System.UInt64, System.Collections.Generic.List<System.Int64\>> |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ControlledEntities)ControlledEntities

##### Declaration

```
public SerializableDictionary<long, MyObjectBuilder_Checkpoint.PlayerId> ControlledEntities
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ControlledObject)ControlledObject

##### Declaration

```
public long ControlledObject
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_CreativeTools)CreativeTools

##### Declaration

```
public HashSet<ulong> CreativeTools
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<System.UInt64\> |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_CurrentSector)CurrentSector

##### Declaration

```
public SerializableVector3I CurrentSector
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.SerializableVector3I |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_CustomLoadingScreenImage)CustomLoadingScreenImage

##### Declaration

```
public string CustomLoadingScreenImage
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_CustomLoadingScreenText)CustomLoadingScreenText

##### Declaration

```
public string CustomLoadingScreenText
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_CustomSkybox)CustomSkybox

##### Declaration

```
public string CustomSkybox
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_DEFAULT_DATE)DEFAULT\_DATE

##### Declaration

```
public static DateTime DEFAULT_DATE
```

##### Field Value

| Type | Description |
| --- | --- |
| System.DateTime |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_Description)Description

##### Declaration

```
public string Description
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_DisconnectedPlayers)DisconnectedPlayers

##### Declaration

```
public SerializableDictionary<MyObjectBuilder_Checkpoint.PlayerId, long> DisconnectedPlayers
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ElapsedGameTime)ElapsedGameTime

This is long because TimeSpan is not serialized

##### Declaration

```
public long ElapsedGameTime
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_FactionChatHistory)FactionChatHistory

##### Declaration

```
public List<MyObjectBuilder_FactionChatHistory> FactionChatHistory
```

##### Field Value

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_Factions)Factions

##### Declaration

```
public MyObjectBuilder_FactionCollection Factions
```
