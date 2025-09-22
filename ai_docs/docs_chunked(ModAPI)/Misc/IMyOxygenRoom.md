---
title: "Interface IMyOxygenRoom"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyOxygenRoom.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyOxygenRoom"
---

# Interface IMyOxygenRoom | Space Engineers ModAPI

Represents space containing air vent. May be not airtight

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyOxygenRoom
```

### Properties

#### BlockCount

Gets blocks in room. Can be used to calculate max oxygen available for this room: BlockCount \* gridSize \* gridSize \* gridSize

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Blocks

HashSet of all the airtight positions in the room (Reference, not a copy!)

##### Declaration

```
HashSetReader<Vector3I> Blocks { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [HashSetReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.HashSetReader-1.html)<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\> |     |

#### EnvironmentOxygen

Gets current oxygen level

##### Declaration

```
float EnvironmentOxygen { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsAirtight

Gets if room is airtight

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsDirty

Gets if room state is dirty, and would be updated soon.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OxygenAmount

Gets oxygen amount in cubic meters. BlockCount \* gridSize \* gridSize \* gridSize

##### Declaration

```
float OxygenAmount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### StartingPosition

Gets oxygen room starting position

##### Declaration

```
Vector3I StartingPosition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

### Methods

#### MaxOxygen(Single)

Gets the maximum volume of oxygen in the room (m^3)

##### Declaration

```
float MaxOxygen(float gridSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | gridSize |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### MissingOxygen(Single)

Returns the volume of oxygen that is not in the room (m^3)

##### Declaration

```
float MissingOxygen(float gridSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | gridSize |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### OxygenLevel(Single)

Returns the percentage of oxygen in the room compared to the maximum possible oxygen

##### Declaration

```
float OxygenLevel(float gridSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | gridSize |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |