---
title: "Class MyTSSVendingMachine"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.MyTSSVendingMachine.html"
category: "Misc"
namespace: "Sandbox.Game.GameSystems.TextSurfaceScripts"
class: "MyTSSVendingMachine"
---

# Class MyTSSVendingMachine | Space Engineers ModAPI

##### Inheritance

System.Object

MyTSSVendingMachine

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.GameSystems.TextSurfaceScripts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyTextSurfaceScript("TSS_VendingMachine", "DisplayName_TSS_VendingMachine")]
public class MyTSSVendingMachine : MyTSSCommon, IMyTextSurfaceScript, IDisposable
```

### Constructors

#### MyTSSVendingMachine(IMyTextSurface, IMyCubeBlock, Vector2)

##### Declaration

```
public MyTSSVendingMachine(IMyTextSurface surface, IMyCubeBlock block, Vector2 size)
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

#### Dispose()

##### Declaration

```
public override void Dispose()
```

##### Overrides

#### GetMessageString()

##### Declaration

```
public string GetMessageString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Run()

##### Declaration

```
public override void Run()
```

##### Overrides

### Implements