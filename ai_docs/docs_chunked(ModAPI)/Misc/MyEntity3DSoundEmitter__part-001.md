---
title: "Class MyEntity3DSoundEmitter"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntity3DSoundEmitter.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyEntity3DSoundEmitter"
---

# Class MyEntity3DSoundEmitter | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntity3DSoundEmitter

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyEntity3DSoundEmitter : Object, IMy3DSoundEmitter
```

### Constructors

#### MyEntity3DSoundEmitter(MyEntity, Boolean, Single)

##### Declaration

```
public MyEntity3DSoundEmitter(MyEntity entity, bool useStaticList = false, float dopplerScaler = 1F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| System.Boolean | useStaticList |     |
| System.Single | dopplerScaler |     |

### Fields

#### CanPlayLoopSounds

##### Declaration

```
public bool CanPlayLoopSounds
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EmitterMethods

##### Declaration

```
public Dictionary<int, ConcurrentCachingList<Delegate>> EmitterMethods
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.Int32, [ConcurrentCachingList](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ConcurrentCachingList-1.html)<System.Delegate\>> |     |

### Properties

#### CustomMaxDistance

##### Declaration

```
public Nullable<float> CustomMaxDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### CustomVolume

##### Declaration

```
public Nullable<float> CustomVolume { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### DebugData

##### Declaration

```
public object DebugData { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Object |     |

#### DopplerScaler

##### Declaration

```
public float DopplerScaler { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Entity

##### Declaration

```
public MyEntity Entity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### Force2D

##### Declaration

```
public bool Force2D { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Force3D

##### Declaration

```
public bool Force3D { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPlaying

##### Declaration

```
public bool IsPlaying { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LastSoundData

##### Declaration

```
public MySoundData LastSoundData { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Data.Audio.MySoundData |     |

#### Loop

##### Declaration

```
public bool Loop { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Plays2D

##### Declaration

```
public bool Plays2D { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Sound

##### Declaration

```
public IMySourceVoice Sound { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Audio.IMySourceVoice |     |

#### SoundId

##### Declaration

```
public MyCueId SoundId { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Audio.MyCueId |     |

#### SoundPair

##### Declaration

```
public MySoundPair SoundPair { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

#### SourceChannels

##### Declaration

```
public int SourceChannels { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### SourcePosition

##### Declaration

```
public Vector3D SourcePosition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Velocity

##### Declaration

```
public Vector3 Velocity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### VolumeMultiplier

##### Declaration

```
public float VolumeMultiplier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### Cleanup()

##### Declaration

#### ClearEntityEmitters()

##### Declaration

```
public static void ClearEntityEmitters()
```

#### ClearSecondaryCue()

##### Declaration

```
public void ClearSecondaryCue()
```

#### FastUpdate(Boolean)

##### Declaration

```
public bool FastUpdate(bool silenced)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | silenced |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PlaySingleSound(MySoundPair, Boolean, Boolean, Boolean, Nullable<Boolean>)

##### Declaration

```
public bool PlaySingleSound(MySoundPair soundId, bool stopPrevious = false, bool skipIntro = false, bool skipToEnd = false, Nullable<bool> force3D = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) | soundId |     |
| System.Boolean | stopPrevious |     |
| System.Boolean | skipIntro |     |
| System.Boolean | skipToEnd |     |
| System.Nullable<System.Boolean\> | force3D |     |
