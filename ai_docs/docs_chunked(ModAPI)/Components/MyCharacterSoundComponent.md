---
title: "Class MyCharacterSoundComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyCharacterSoundComponent.html"
category: "Components"
namespace: "Sandbox.Game.Components"
class: "MyCharacterSoundComponent"
---

# Class MyCharacterSoundComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyCharacterSoundComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentBuilder]
public class MyCharacterSoundComponent : MyUpdatingEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent, IMyCharacterComponent
```

### Constructors

#### MyCharacterSoundComponent()

##### Declaration

```
public MyCharacterSoundComponent()
```

### Properties

#### Character

##### Declaration

```
public MyCharacter Character { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter |     |

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### StandingOnGrid

##### Declaration

```
public MyCubeGrid StandingOnGrid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) |     |

#### StandingOnVoxel

##### Declaration

```
public MyVoxelBase StandingOnVoxel { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) |     |

### Methods

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### OnCharacterDead()

##### Declaration

```
public void OnCharacterDead()
```

#### PlayActionSound(MySoundPair, Nullable<Boolean>)

##### Declaration

```
public void PlayActionSound(MySoundPair actionSound, Nullable<bool> force3D = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) | actionSound |     |
| System.Nullable<System.Boolean\> | force3D |     |

#### PlayDamageSound(Single)

##### Declaration

```
public void PlayDamageSound(float oldHealth)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | oldHealth |     |

#### PlayDeathSound(MyStringHash, Boolean)

##### Declaration

```
public void PlayDeathSound(MyStringHash damageType, bool stopPrevious = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | damageType |     |
| System.Boolean | stopPrevious |     |

#### PlayFallSound()

##### Declaration

```
public void PlayFallSound()
```

#### PlaySecondarySound(CharacterSoundsEnum, Boolean, Boolean, Nullable<Boolean>)

##### Declaration

```
public void PlaySecondarySound(CharacterSoundsEnum soundEnum, bool stopPrevious = false, bool force2D = false, Nullable<bool> force3D = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CharacterSoundsEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.CharacterSoundsEnum.html) | soundEnum |     |
| System.Boolean | stopPrevious |     |
| System.Boolean | force2D |     |
| System.Nullable<System.Boolean\> | force3D |     |

#### Preload()

##### Declaration

#### StartSecondarySound(String, Boolean)

##### Declaration

```
public void StartSecondarySound(string cueName, bool sync = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | cueName |     |
| System.Boolean | sync |     |

#### StartSecondarySound(MyCueId, Boolean)

##### Declaration

```
public void StartSecondarySound(MyCueId cueId, bool sync = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Audio.MyCueId | cueId |     |
| System.Boolean | sync |     |

#### StopSecondarySound(Boolean)

##### Declaration

```
public bool StopSecondarySound(bool forceStop = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | forceStop |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### StopStateSound(Boolean)

##### Declaration

```
public bool StopStateSound(bool forceStop = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | forceStop |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

#### UpdateAfterSimulation100()

##### Declaration

```
public override void UpdateAfterSimulation100()
```

##### Overrides

#### UpdateAfterSimulationParallel()

##### Declaration

```
public override void UpdateAfterSimulationParallel()
```

##### Overrides

### Implements

### Extension Methods