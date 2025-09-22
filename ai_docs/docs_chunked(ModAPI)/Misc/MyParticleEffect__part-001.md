---
title: "Class MyParticleEffect"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyParticleEffect.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyParticleEffect"
---

# Class MyParticleEffect | Space Engineers ModAPI

##### Inheritance

System.Object

MyParticleEffect

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyParticleEffect : Object
```

### Constructors

#### MyParticleEffect()

##### Declaration

```
public MyParticleEffect()
```

### Properties

#### Autodelete

##### Declaration

```
public bool Autodelete { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CameraSoftRadiusMultiplier

##### Declaration

```
public float CameraSoftRadiusMultiplier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Data

##### Declaration

```
public MyParticleEffectData Data { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Render.Particles.MyParticleEffectData |     |

#### DistanceMax

##### Declaration

```
public float DistanceMax { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DurationMax

##### Declaration

```
public float DurationMax { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Id

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### IsEmittingStopped

##### Declaration

```
public bool IsEmittingStopped { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsStopped

##### Declaration

```
public bool IsStopped { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Loop

##### Declaration

```
public bool Loop { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SoftParticleDistanceScaleMultiplier

##### Declaration

```
public float SoftParticleDistanceScaleMultiplier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### UserBirthMultiplier

##### Declaration

```
public float UserBirthMultiplier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### UserColorIntensityMultiplier

##### Declaration

```
public float UserColorIntensityMultiplier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### UserColorMultiplier

##### Declaration

```
public Vector4 UserColorMultiplier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) |     |

#### UserEmitterScale

##### Declaration

```
public float UserEmitterScale { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### UserFadeMultiplier

##### Declaration

```
public float UserFadeMultiplier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### UserLifeMultiplier

##### Declaration

```
public float UserLifeMultiplier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### UserRadiusMultiplier

##### Declaration

```
public float UserRadiusMultiplier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### UserScale

##### Declaration

```
public float UserScale { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### UserVelocityMultiplier

##### Declaration

```
public float UserVelocityMultiplier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Velocity

##### Declaration

```
public Vector3 Velocity { set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### WorldMatrix

##### Declaration

```
public MatrixD WorldMatrix { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

### Methods

#### AssertUnload()

##### Declaration

```
public void AssertUnload()
```

#### Clear()

##### Declaration

#### Close()

##### Declaration

#### GetElapsedTime()

##### Declaration

```
public float GetElapsedTime()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetName()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Init(MyParticleEffectData, ref MatrixD, UInt32)

##### Declaration

```
public void Init(MyParticleEffectData data, ref MatrixD effectMatrix, uint parentId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Render.Particles.MyParticleEffectData | data |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | effectMatrix |     |
| System.UInt32 | parentId |     |

#### OnRemoved()

##### Declaration

#### Pause()

This methods freezes effect and particles

##### Declaration

#### Play()

This method restores effect

##### Declaration

#### SetDirty()

##### Declaration

#### SetElapsedTime(Single)

##### Declaration

```
public void SetElapsedTime(float time)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | time |     |

#### SetTranslation(Vector3D)

##### Declaration

```
public void SetTranslation(Vector3D trans)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | trans |     |
