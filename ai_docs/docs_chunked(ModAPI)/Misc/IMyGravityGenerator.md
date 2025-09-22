---
title: "Interface IMyGravityGenerator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMyGravityGenerator.html"
category: "Misc"
namespace: "SpaceEngineers.Game.ModAPI.Ingame"
class: "IMyGravityGenerator"
---

# Interface IMyGravityGenerator | Space Engineers ModAPI

##### Inherited Members

###### **Namespace**: [SpaceEngineers.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.html)

###### **Assembly**: SpaceEngineers.Game.dll

##### Syntax

```
public interface IMyGravityGenerator : IMyGravityGeneratorBase, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### FieldDepth

##### Declaration

```
float FieldDepth { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FieldHeight

##### Declaration

```
float FieldHeight { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FieldSize

Gets or sets the gravity field as a Vector3(W,H,D).

##### Declaration

```
Vector3 FieldSize { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### FieldWidth

##### Declaration

```
float FieldWidth { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Extension Methods