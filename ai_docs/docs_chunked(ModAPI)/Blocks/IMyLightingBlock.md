---
title: "Interface IMyLightingBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyLightingBlock.html"
category: "Blocks"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyLightingBlock"
---

# Interface IMyLightingBlock | Space Engineers ModAPI

Describes lighting block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyLightingBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### BlinkIntervalSeconds

Gets or sets the blinking interval of this light (in seconds).

##### Declaration

```
float BlinkIntervalSeconds { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BlinkLenght

Obsolete

##### Declaration

```
float BlinkLenght { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BlinkLength

Gets or sets how much of the blinking interval should be spent with the light on, as a value between 0 and 1.

##### Declaration

```
float BlinkLength { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BlinkOffset

Adds an offset to the blinking interval, as a value between 0 and 1.

##### Declaration

```
float BlinkOffset { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Color

Gets or sets the color of the light.

##### Declaration

```
Color Color { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### Falloff

Gets or sets the current falloff of the light.

##### Declaration

```
float Falloff { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Intensity

Gets or sets the current intensity of the light.

##### Declaration

```
float Intensity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Radius

Gets or sets the basic radius of the light.

##### Declaration

```
float Radius { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReflectorRadius

Obsolete

##### Declaration

```
float ReflectorRadius { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Extension Methods