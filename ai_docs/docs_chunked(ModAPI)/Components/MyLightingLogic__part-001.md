---
title: "Class MyLightingLogic"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyLightingLogic.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyLightingLogic"
---

# Class MyLightingLogic | Space Engineers ModAPI

##### Inheritance

System.Object

MyLightingLogic

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyLightingLogic : Object
```

### Constructors

#### MyLightingLogic(MyFunctionalBlock, MyHeatVentBlockDefinition, IMyLightingLogicSync)

##### Declaration

```
public MyLightingLogic(MyFunctionalBlock block, MyHeatVentBlockDefinition blockDefinition, IMyLightingLogicSync sync)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Entities.Cube.MyFunctionalBlock | block |     |
| [MyHeatVentBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyHeatVentBlockDefinition.html) | blockDefinition |     |
| Sandbox.Game.Entities.Interfaces.IMyLightingLogicSync | sync |     |

#### MyLightingLogic(MyFunctionalBlock, MyLightingBlockDefinition, IMyLightingLogicSync)

##### Declaration

```
public MyLightingLogic(MyFunctionalBlock block, MyLightingBlockDefinition blockDefinition, IMyLightingLogicSync sync)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Entities.Cube.MyFunctionalBlock | block |     |
| [MyLightingBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyLightingBlockDefinition.html) | blockDefinition |     |
| Sandbox.Game.Entities.Interfaces.IMyLightingLogicSync | sync |     |

#### MyLightingLogic(MyFunctionalBlock, MySearchlightDefinition, IMyLightingLogicSync)

##### Declaration

```
public MyLightingLogic(MyFunctionalBlock block, MySearchlightDefinition blockDefinition, IMyLightingLogicSync sync)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Entities.Cube.MyFunctionalBlock | block |     |
| [MySearchlightDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MySearchlightDefinition.html) | blockDefinition |     |
| Sandbox.Game.Entities.Interfaces.IMyLightingLogicSync | sync |     |

#### MyLightingLogic(MyFunctionalBlock, IMyLightingComponentDefinition, IMyLightingLogicSync)

##### Declaration

```
public MyLightingLogic(MyFunctionalBlock block, IMyLightingComponentDefinition lightingComponentDefinition, IMyLightingLogicSync sync)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Entities.Cube.MyFunctionalBlock | block |     |
| [IMyLightingComponentDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Lights.IMyLightingComponentDefinition.html) | lightingComponentDefinition |     |
| Sandbox.Game.Entities.Interfaces.IMyLightingLogicSync | sync |     |

### Properties

#### BlinkIntervalSeconds

##### Declaration

```
public float BlinkIntervalSeconds { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BlinkIntervalSecondsBounds

##### Declaration

```
public MyBounds BlinkIntervalSecondsBounds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### BlinkLength

##### Declaration

```
public float BlinkLength { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BlinkLengthBounds

##### Declaration

```
public MyBounds BlinkLengthBounds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### BlinkOffset

##### Declaration

```
public float BlinkOffset { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BlinkOffsetBounds

##### Declaration

```
public MyBounds BlinkOffsetBounds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### BulbColor

##### Declaration

```
public Color BulbColor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### Color

##### Declaration

```
public Color Color { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### CurrentLightPower

##### Declaration

```
public float CurrentLightPower { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Falloff

##### Declaration

```
public virtual float Falloff { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FalloffBounds

##### Declaration

```
public MyBounds FalloffBounds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### HasSubPartLights

##### Declaration

```
public bool HasSubPartLights { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intensity

##### Declaration

```
public float Intensity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IntensityBounds

##### Declaration

```
public MyBounds IntensityBounds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |
