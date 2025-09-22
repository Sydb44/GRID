---
title: "Class MoveInformation"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.MoveInformation.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Interfaces"
class: "MoveInformation"
---

# Class MoveInformation | Space Engineers ModAPI

Stores information about user input

##### Inheritance

System.Object

MoveInformation

###### **Namespace**: [VRage.Game.ModAPI.Interfaces](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MoveInformation : ValueType
```

### Fields

#### MoveIndicator

Gets user input (W/A/S/D Space/C)

##### Declaration

```
public Vector3 MoveIndicator
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### RollIndicator

Gets user input (Q/E)

##### Declaration

```
public float RollIndicator
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RotationIndicator

Gets user input Mouse (X/Y)

##### Declaration

```
public Vector2 RotationIndicator
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |