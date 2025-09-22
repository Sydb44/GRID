---
title: "Class MyTSSAnalogClock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.MyTSSAnalogClock.html"
category: "Misc"
namespace: "Sandbox.Game.GameSystems.TextSurfaceScripts"
class: "MyTSSAnalogClock"
---

# Class MyTSSAnalogClock | Space Engineers ModAPI

##### Inheritance

System.Object

MyTSSAnalogClock

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.GameSystems.TextSurfaceScripts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyTextSurfaceScript("TSS_ClockAnalog", "DisplayName_TSS_ClockAnalog")]
public class MyTSSAnalogClock : MyTSSCommon, IMyTextSurfaceScript, IDisposable
```

### Constructors

#### MyTSSAnalogClock(IMyTextSurface, IMyCubeBlock, Vector2)

##### Declaration

```
public MyTSSAnalogClock(IMyTextSurface surface, IMyCubeBlock block, Vector2 size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTextSurface](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextSurface.html) | surface |     |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | size |     |

### Fields

#### ASPECT\_RATIO

##### Declaration

```
public static float ASPECT_RATIO
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DECORATION\_RATIO

##### Declaration

```
public static float DECORATION_RATIO
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### INDICATOR\_WIDTH

##### Declaration

```
public static readonly float INDICATOR_WIDTH
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

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