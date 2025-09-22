---
title: "Class MyTSSGravity"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.MyTSSGravity.html"
category: "Misc"
namespace: "Sandbox.Game.GameSystems.TextSurfaceScripts"
class: "MyTSSGravity"
---

# Class MyTSSGravity | Space Engineers ModAPI

##### Inheritance

System.Object

MyTSSGravity

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.GameSystems.TextSurfaceScripts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyTextSurfaceScript("TSS_Gravity", "DisplayName_TSS_Gravity")]
public class MyTSSGravity : MyTSSCommon, IMyTextSurfaceScript, IDisposable
```

### Constructors

#### MyTSSGravity(IMyTextSurface, IMyCubeBlock, Vector2)

##### Declaration

```
public MyTSSGravity(IMyTextSurface surface, IMyCubeBlock block, Vector2 size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTextSurface](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTextSurface.html) | surface |     |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeBlock.html) | block |     |
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

#### TEXT\_RATIO

##### Declaration

```
public static float TEXT_RATIO
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

#### Dispose()

##### Declaration

```
public override void Dispose()
```

##### Overrides

#### Run()

##### Declaration

```
public override void Run()
```

##### Overrides

### Implements