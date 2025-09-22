---
title: "Interface IMyIdentity"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyIdentity.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyIdentity"
---

# Interface IMyIdentity | Space Engineers ModAPI

Describes player or bot (mods interface)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyIdentity
```

### Properties

#### ColorMask

The player's model color mask

##### Declaration

```
Nullable<Vector3> ColorMask { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### DisplayName

Name of player.

##### Declaration

```
string DisplayName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### IdentityId

Player's unique identity id.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### IsDead

Gets if the player is dead

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Model

Gets the model the player is using.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### PlayerId

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Events

#### CharacterChanged

Triggered when the player's character changes.

##### Declaration

```
event Action<IMyCharacter, IMyCharacter> CharacterChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html), [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html)\> |     |