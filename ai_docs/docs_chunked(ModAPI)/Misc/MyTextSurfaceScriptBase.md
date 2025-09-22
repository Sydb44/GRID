---
title: "Class MyTextSurfaceScriptBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.MyTextSurfaceScriptBase.html"
category: "Misc"
namespace: "Sandbox.Game.GameSystems.TextSurfaceScripts"
class: "MyTextSurfaceScriptBase"
---

# Class MyTextSurfaceScriptBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyTextSurfaceScriptBase

##### Implements

###### **Namespace**: [Sandbox.Game.GameSystems.TextSurfaceScripts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyTextSurfaceScriptBase : Object, IMyTextSurfaceScript, IDisposable
```

### Constructors

#### MyTextSurfaceScriptBase(IMyTextSurface, IMyCubeBlock, Vector2)

##### Declaration

```
protected MyTextSurfaceScriptBase(IMyTextSurface surface, IMyCubeBlock block, Vector2 size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTextSurface](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextSurface.html) | surface |     |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | size |     |

### Fields

#### DEFAULT\_BACKGROUND\_COLOR

##### Declaration

```
public static readonly Color DEFAULT_BACKGROUND_COLOR
```

##### Field Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### DEFAULT\_FONT\_COLOR

##### Declaration

```
public static readonly Color DEFAULT_FONT_COLOR
```

##### Field Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### m\_backgroundColor

##### Declaration

```
protected Color m_backgroundColor
```

##### Field Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### m\_block

##### Declaration

```
protected IMyCubeBlock m_block
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) |     |

#### m\_foregroundColor

##### Declaration

```
protected Color m_foregroundColor
```

##### Field Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### m\_halfSize

##### Declaration

```
protected Vector2 m_halfSize
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

#### m\_scale

Scale in both direction compared to what we would expect as default (512px)

##### Declaration

```
protected Vector2 m_scale
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

#### m\_size

Size of the available texture surface

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

#### m\_surface

##### Declaration

```
protected IMyTextSurface m_surface
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyTextSurface](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextSurface.html) |     |

### Properties

#### BackgroundColor

##### Declaration

```
public Color BackgroundColor { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### Block

##### Declaration

```
public IMyCubeBlock Block { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) |     |

#### ForegroundColor

##### Declaration

```
public Color ForegroundColor { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### NeedsUpdate

##### Declaration

```
public abstract ScriptUpdate NeedsUpdate { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ScriptUpdate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.ScriptUpdate.html) |     |

#### Surface

##### Declaration

```
public IMyTextSurface Surface { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyTextSurface](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextSurface.html) |     |

### Methods

#### Dispose()

##### Declaration

```
public virtual void Dispose()
```

#### FitRect(Vector2, ref Vector2)

Rescales rectangle to fit within desired texture space.

##### Declaration

```
public static void FitRect(Vector2 texture, ref Vector2 rect)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | texture |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | rect |     |

#### Run()

##### Declaration

```
public virtual void Run()
```

### Implements