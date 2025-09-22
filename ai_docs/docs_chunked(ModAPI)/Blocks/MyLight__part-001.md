---
title: "Class MyLight"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Lights.MyLight.html"
category: "Blocks"
namespace: "Sandbox.Game.Lights"
class: "MyLight"
---

# Class MyLight | Space Engineers ModAPI

##### Inheritance

System.Object

MyLight

###### **Namespace**: [Sandbox.Game.Lights](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Lights.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyLight : Object
```

### Constructors

#### MyLight()

##### Declaration

### Properties

#### CastShadows

##### Declaration

```
public bool CastShadows { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Color

##### Declaration

```
public Color Color { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### DiffuseFactor

##### Declaration

```
public float DiffuseFactor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Falloff

Exponential falloff (1 = linear, 2 = quadratic, etc)

##### Declaration

```
public float Falloff { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GlareIntensity

##### Declaration

```
public float GlareIntensity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GlareMaxDistance

##### Declaration

```
public float GlareMaxDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GlareOn

##### Declaration

```
public bool GlareOn { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GlareQueryFreqMinMs

##### Declaration

```
public float GlareQueryFreqMinMs { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GlareQueryFreqRndMs

##### Declaration

```
public float GlareQueryFreqRndMs { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GlareQueryShift

##### Declaration

```
public float GlareQueryShift { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GlareQuerySize

##### Declaration

```
public float GlareQuerySize { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GlareSize

##### Declaration

```
public Vector2 GlareSize { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

#### GlareType

##### Declaration

```
public MyGlareTypeEnum GlareType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRageRender.Lights.MyGlareTypeEnum |     |

#### GlossFactor

##### Declaration

```
public float GlossFactor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Intensity

##### Declaration

```
public float Intensity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### LightOn

If true, we use the light in lighting calculation. Otherwise it's like turned off, but still in the buffer.

##### Declaration

```
public bool LightOn { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LightSourceType

##### Declaration

```
public MyLightSourceType LightSourceType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyLightSourceType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Lights.MyLightSourceType.html) |     |

#### LightType

##### Declaration

```
public MyLightType LightType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyLightType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Lights.MyLightType.html) |     |

#### ParentID

##### Declaration

```
public uint ParentID { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### PointLightOffset

##### Declaration

```
public float PointLightOffset { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Position

##### Declaration

```
public Vector3D Position { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Range

##### Declaration

```
public float Range { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReflectorColor

##### Declaration

```
public Color ReflectorColor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### ReflectorConeDegrees

Sets reflector cone angle in degrees, minimum is 0, teoretical maximum is 180

##### Declaration

```
public float ReflectorConeDegrees { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReflectorConeMaxAngleCos

##### Declaration

```
public float ReflectorConeMaxAngleCos { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReflectorConeRadians

Sets reflector cone angle in degrees, minimum is 0, teoretical maximum is PI

##### Declaration

```
public float ReflectorConeRadians { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReflectorDiffuseFactor

##### Declaration

```
public float ReflectorDiffuseFactor { get; set; }
```
