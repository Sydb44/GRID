---
title: "Interface IMyLightingComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyLightingComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyLightingComponent"
---

# Interface IMyLightingComponent | Space Engineers ModAPI

Describes a lighting Component (PB scripting interface).

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyLightingComponent
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