---
title: "Class MyObjectBuilder\\_Player"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Player.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_Player"
---

# Class MyObjectBuilder\_Player | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Player

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_Player : MyObjectBuilder_Base
```

### Constructors

#### MyObjectBuilder\_Player()

##### Declaration

```
public MyObjectBuilder_Player()
```

### Fields

#### BuildArmorSkin

##### Declaration

```
[Serialize]
public string BuildArmorSkin
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### BuildColorSlot

##### Declaration

```
[Serialize]
public int BuildColorSlot
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### BuildColorSlots

##### Declaration

```
[Serialize]
public List<Vector3> BuildColorSlots
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### Connected

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CreativeToolsEnabled

##### Declaration

```
public bool CreativeToolsEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DisplayName

##### Declaration

```
[Serialize]
public string DisplayName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### EntityCameraData

##### Declaration

```
[Serialize]
public List<CameraControllerSettings> EntityCameraData
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[CameraControllerSettings](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.CameraControllerSettings.html)\> |     |

#### ForceRealPlayer

##### Declaration

```
public bool ForceRealPlayer
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GameAcronym

##### Declaration

```
[Serialize]
public string GameAcronym
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### IdentityId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### IsWildlifeAgent

##### Declaration

```
public bool IsWildlifeAgent
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LastActivity

##### Declaration

```
[NoSerialize]
public long LastActivity
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### PlatformIcon

##### Declaration

```
[Serialize]
public string PlatformIcon
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### PlayerEntity

##### Declaration

```
[NoSerialize]
public long PlayerEntity
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### PlayerId

##### Declaration

```
[NoSerialize]
public long PlayerId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### PlayerModel

##### Declaration

```
[NoSerialize]
public string PlayerModel
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### PromoteLevel

##### Declaration

```
public MyPromoteLevel PromoteLevel
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyPromoteLevel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyPromoteLevel.html) |     |

#### RemoteAdminSettings

##### Declaration

```
public int RemoteAdminSettings
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### SteamID

##### Declaration

```
[NoSerialize]
public ulong SteamID
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### Toolbar

##### Declaration

```
[Serialize]
public MyObjectBuilder_Toolbar Toolbar
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Toolbar](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Toolbar.html) |     |

### Properties

#### CameraData

##### Declaration

```
[NoSerialize]
public SerializableDictionary<long, CameraControllerSettings> CameraData { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Serialization.SerializableDictionary<System.Int64, [CameraControllerSettings](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.CameraControllerSettings.html)\> |     |

### Methods

#### ShouldSerializeBuildColorSlots()

##### Declaration

```
public bool ShouldSerializeBuildColorSlots()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeCameraData()

##### Declaration

```
public bool ShouldSerializeCameraData()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeLastActivity()

##### Declaration

```
public bool ShouldSerializeLastActivity()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializePlayerEntity()

##### Declaration

```
public bool ShouldSerializePlayerEntity()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializePlayerId()

##### Declaration

```
public bool ShouldSerializePlayerId()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializePlayerModel()

##### Declaration

```
public bool ShouldSerializePlayerModel()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |
