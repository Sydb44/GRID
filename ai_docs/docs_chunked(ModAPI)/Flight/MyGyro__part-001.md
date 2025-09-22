---
title: "Class MyGyro"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGyro.html"
category: "Flight"
namespace: "Sandbox.Game.Entities"
class: "MyGyro"
---

# Class MyGyro | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Game.Entities.Cube.MySyncedBlock

Sandbox.Game.Entities.Cube.MyTerminalBlock

Sandbox.Game.Entities.Cube.MyFunctionalBlock

MyGyro

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
[MyTerminalInterface]
public class MyGyro : MyFunctionalBlock, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyTieredUpdateBlock, IMyUpdateTimer, IMyTextSurfaceProvider, IMyTextSurfaceProvider, IMyMultiTextPanelComponentOwner, IMyTextPanelComponentOwner, IMyGyro, IMyGyro, IMyFunctionalBlock, IMyFunctionalBlock, IMyTerminalBlock, IMyTerminalBlock, IMyCubeBlock, IMyCubeBlock, IMyEntity, IMyEntity
```

### Constructors

#### MyGyro()

##### Declaration

### Properties

#### GyroOverride

##### Declaration

```
public bool GyroOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GyroOverrideVelocityGrid

##### Declaration

```
public Vector3 GyroOverrideVelocityGrid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### GyroPower

##### Declaration

```
public float GyroPower { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsAccountedByGyroSystem

##### Declaration

```
public bool IsAccountedByGyroSystem { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPowered

##### Declaration

```
public bool IsPowered { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxGyroForce

##### Declaration

```
public float MaxGyroForce { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RequiredPowerInput

##### Declaration

```
public float RequiredPowerInput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### CheckIsWorking()

##### Declaration

```
protected override bool CheckIsWorking()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.CheckIsWorking()

#### CreateTerminalControls()

##### Declaration

```
protected override void CreateTerminalControls()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.CreateTerminalControls()

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

Sandbox.Game.Entities.Cube.MyFunctionalBlock.GetObjectBuilderCubeBlock(System.Boolean)

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

Sandbox.Game.Entities.Cube.MyFunctionalBlock.Init(VRage.Game.MyObjectBuilder\_CubeBlock, Sandbox.Game.Entities.MyCubeGrid)

#### OnAddedToScene(Object)

##### Declaration

```
public override void OnAddedToScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.OnAddedToScene(System.Object)

#### SetEmissiveStateWorking()

##### Declaration

```
public override bool SetEmissiveStateWorking()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### SetGyroOverride(Boolean)

##### Declaration

```
public void SetGyroOverride(bool value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | value |     |

#### SetGyroTorque(Vector3)

##### Declaration

```
public void SetGyroTorque(Vector3 torque)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | torque |     |

#### UpdateDetailedInfo(StringBuilder)

##### Declaration

```
protected override void UpdateDetailedInfo(StringBuilder detailedInfo)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | detailedInfo |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.UpdateDetailedInfo(System.Text.StringBuilder)

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateOnceBeforeFrame()

### Events

#### OnGyroPowerChanged

##### Declaration

```
public event Action<MyTerminalBlock> OnGyroPowerChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<Sandbox.Game.Entities.Cube.MyTerminalBlock\> |     |

### Explicit Interface Implementations
