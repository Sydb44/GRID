---
title: "Class MyReflectorLight"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyReflectorLight.html"
category: "Blocks"
namespace: "Sandbox.Game.Entities"
class: "MyReflectorLight"
---

# Class MyReflectorLight | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

Sandbox.Game.Entities.Cube.MyFunctionalBlock

Sandbox.Game.Entities.Blocks.MyLightingBlock

MyReflectorLight

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
[MyTerminalInterface]
public class MyReflectorLight : MyLightingBlock, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyTieredUpdateBlock, IMyUpdateTimer, IMyTextSurfaceProvider, IMyTextSurfaceProvider, IMyMultiTextPanelComponentOwner, IMyTextPanelComponentOwner, IMyParallelUpdateable, IMyLightingLogicSync, IMyReflectorLight, IMyLightingBlock, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyReflectorLight, IMyLightingBlock, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Constructors

#### MyReflectorLight()

##### Declaration

```
public MyReflectorLight()
```

### Properties

#### BlockDefinition

##### Declaration

```
public MyReflectorBlockDefinition BlockDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyReflectorBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyReflectorBlockDefinition.html) |     |

#### IsReflectorEnabled

##### Declaration

```
public bool IsReflectorEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedPerFrameUpdate

##### Declaration

```
protected override bool NeedPerFrameUpdate { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

Sandbox.Game.Entities.Blocks.MyLightingBlock.NeedPerFrameUpdate

#### ReflectorConeMaterial

##### Declaration

```
public string ReflectorConeMaterial { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### SupportsFalloff

##### Declaration

```
protected override bool SupportsFalloff { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

Sandbox.Game.Entities.Blocks.MyLightingBlock.SupportsFalloff

### Methods

#### CreateTerminalControls()

##### Declaration

```
protected override void CreateTerminalControls()
```

##### Overrides

Sandbox.Game.Entities.Blocks.MyLightingBlock.CreateTerminalControls()

#### GetObjectBuilderCubeBlock(Boolean)

##### Declaration

```
public override MyObjectBuilder_CubeBlock GetObjectBuilderCubeBlock(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html) |     |

##### Overrides

Sandbox.Game.Entities.Blocks.MyLightingBlock.GetObjectBuilderCubeBlock(System.Boolean)

#### Init(MyObjectBuilder\_CubeBlock, MyCubeGrid)

##### Declaration

```
public override void Init(MyObjectBuilder_CubeBlock objectBuilder, MyCubeGrid cubeGrid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html) | objectBuilder |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | cubeGrid |     |

##### Overrides

Sandbox.Game.Entities.Blocks.MyLightingBlock.Init(VRage.Game.MyObjectBuilder\_CubeBlock, Sandbox.Game.Entities.MyCubeGrid)

#### InitLight(MyLight, Vector4, Single, Single)

##### Declaration

```
protected override void InitLight(MyLight light, Vector4 color, float radius, float falloff)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyLight](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Lights.MyLight.html) | light |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| System.Single | radius |     |
| System.Single | falloff |     |

##### Overrides

Sandbox.Game.Entities.Blocks.MyLightingBlock.InitLight(Sandbox.Game.Lights.MyLight, VRageMath.Vector4, System.Single, System.Single)

#### OnModelChange()

##### Declaration

```
public override void OnModelChange()
```

##### Overrides

Sandbox.Game.Entities.Blocks.MyLightingBlock.OnModelChange()

#### UpdateAfterSimulationParallel()

##### Declaration

```
public override void UpdateAfterSimulationParallel()
```

##### Overrides

Sandbox.Game.Entities.Blocks.MyLightingBlock.UpdateAfterSimulationParallel()

#### UpdateEmissivity(Boolean)

##### Declaration

```
protected override void UpdateEmissivity(bool force = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | force |     |

##### Overrides

Sandbox.Game.Entities.Blocks.MyLightingBlock.UpdateEmissivity(System.Boolean)

#### UpdateEnabled(Boolean)

##### Declaration

```
protected override void UpdateEnabled(bool state)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | state |     |

##### Overrides

Sandbox.Game.Entities.Blocks.MyLightingBlock.UpdateEnabled(System.Boolean)

#### UpdateIntensity()

##### Declaration

```
protected override void UpdateIntensity()
```

##### Overrides

Sandbox.Game.Entities.Blocks.MyLightingBlock.UpdateIntensity()

#### UpdateRadius(Single)
