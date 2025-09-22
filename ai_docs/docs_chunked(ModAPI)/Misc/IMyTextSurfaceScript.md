---
title: "Interface IMyTextSurfaceScript"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript.html"
category: "Misc"
namespace: "Sandbox.Game.GameSystems.TextSurfaceScripts"
class: "IMyTextSurfaceScript"
---

# Interface IMyTextSurfaceScript | Space Engineers ModAPI

###### **Namespace**: [Sandbox.Game.GameSystems.TextSurfaceScripts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyTextSurfaceScript : IDisposable
```

### Properties

#### BackgroundColor

##### Declaration

```
Color BackgroundColor { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### Block

##### Declaration

```
IMyCubeBlock Block { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) |     |

#### ForegroundColor

##### Declaration

```
Color ForegroundColor { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### NeedsUpdate

##### Declaration

```
ScriptUpdate NeedsUpdate { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ScriptUpdate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.ScriptUpdate.html) |     |

#### Surface

##### Declaration

```
IMyTextSurface Surface { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyTextSurface](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextSurface.html) |     |

### Methods

#### Run()

##### Declaration