---
title: "Class MyTSSArtificialHorizon"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.MyTSSArtificialHorizon.html"
category: "Misc"
namespace: "Sandbox.Game.GameSystems.TextSurfaceScripts"
class: "MyTSSArtificialHorizon"
---

# Class MyTSSArtificialHorizon | Space Engineers ModAPI

##### Inheritance

System.Object

MyTSSArtificialHorizon

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.GameSystems.TextSurfaceScripts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyTextSurfaceScript("TSS_ArtificialHorizon", "DisplayName_TSS_ArtificialHorizon")]
public class MyTSSArtificialHorizon : MyTSSCommon, IMyTextSurfaceScript, IDisposable
```

### Constructors

#### MyTSSArtificialHorizon(IMyTextSurface, IMyCubeBlock, Vector2)

##### Declaration

```
public MyTSSArtificialHorizon(IMyTextSurface surface, IMyCubeBlock block, Vector2 size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTextSurface](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextSurface.html) | surface |     |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | size |     |

### Properties

#### NeedsUpdate

##### Declaration

```
public override ScriptUpdate NeedsUpdate { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ScriptUpdate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.ScriptUpdate.html) |     |

##### Overrides

### Methods

#### Run()

##### Declaration

```
public override void Run()
```

##### Overrides

### Implements