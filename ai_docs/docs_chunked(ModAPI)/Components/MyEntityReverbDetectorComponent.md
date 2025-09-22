---
title: "Class MyEntityReverbDetectorComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyEntityReverbDetectorComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyEntityReverbDetectorComponent"
---

# Class MyEntityReverbDetectorComponent | Space Engineers ModAPI

class used for detection of environment with air - important for realistic sounds

##### Inheritance

System.Object

MyEntityReverbDetectorComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyEntityReverbDetectorComponent : MyUpdatingEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent
```

### Constructors

#### MyEntityReverbDetectorComponent()

##### Declaration

```
public MyEntityReverbDetectorComponent()
```

### Properties

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

#### CurrentReverbPreset

##### Declaration

```
public static string CurrentReverbPreset { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Grids

##### Declaration

```
public int Grids { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Initialized

##### Declaration

```
public bool Initialized { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Voxels

##### Declaration

```
public int Voxels { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### GetDetectedAverage(Boolean)

##### Declaration

```
public float GetDetectedAverage(bool onlyDetected = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | onlyDetected |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetDetectedNumberOfObjects(MyEntityReverbDetectorComponent.ReverbDetectedType)

##### Declaration

```
public int GetDetectedNumberOfObjects(MyEntityReverbDetectorComponent.ReverbDetectedType type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityReverbDetectorComponent.ReverbDetectedType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyEntityReverbDetectorComponent.ReverbDetectedType.html) | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetDetectedNumberOfObjects(out Int32, out Int32)

##### Declaration

```
public void GetDetectedNumberOfObjects(out int gridCount, out int voxelCount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | gridCount |     |
| System.Int32 | voxelCount |     |

#### InitComponent(MyEntity, Boolean)

##### Declaration

```
public void InitComponent(MyEntity entity, bool sendInformationToAudio)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| System.Boolean | sendInformationToAudio |     |

#### UpdateBeforeSimulation()

##### Declaration

```
public override void UpdateBeforeSimulation()
```

##### Overrides

### Extension Methods