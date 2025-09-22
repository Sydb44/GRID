---
title: "Class MyTSSFactionIcon"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.MyTSSFactionIcon.html"
category: "Misc"
namespace: "Sandbox.Game.GameSystems.TextSurfaceScripts"
class: "MyTSSFactionIcon"
---

# Class MyTSSFactionIcon | Space Engineers ModAPI

##### Inheritance

System.Object

MyTSSFactionIcon

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.GameSystems.TextSurfaceScripts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyTextSurfaceScript("TSS_FactionIcon", "DisplayName_TSS_FactionIcon")]
public class MyTSSFactionIcon : MyTSSCommon, IMyTextSurfaceScript, IDisposable
```

### Constructors

#### MyTSSFactionIcon(IMyTextSurface, IMyCubeBlock, Vector2)

##### Declaration

```
public MyTSSFactionIcon(IMyTextSurface surface, IMyCubeBlock block, Vector2 size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTextSurface](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTextSurface.html) | surface |     |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeBlock.html) | block |     |
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