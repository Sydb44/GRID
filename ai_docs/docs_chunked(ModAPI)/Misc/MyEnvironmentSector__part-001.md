---
title: "Class MyEnvironmentSector"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSector.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment"
class: "MyEnvironmentSector"
---

# Class MyEnvironmentSector | Space Engineers ModAPI

##### Inheritance

System.Object

MyEnvironmentSector

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyEnvironmentSector : MyEntity, IMyEntity, IMyEntity
```

### Constructors

#### MyEnvironmentSector()

##### Declaration

```
public MyEnvironmentSector()
```

### Properties

#### Bounds

##### Declaration

```
public Vector3D[] Bounds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\] |     |

#### DataView

##### Declaration

```
public MyEnvironmentDataView DataView { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEnvironmentDataView](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentDataView.html) |     |

#### EnvironmentDefinition

##### Declaration

```
public MyWorldEnvironmentDefinition EnvironmentDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.WorldEnvironment.Definitions.MyWorldEnvironmentDefinition |     |

#### HasParallelWorkInProgress

##### Declaration

```
public bool HasParallelWorkInProgress { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### HasParallelWorkPending

##### Declaration

```
public bool HasParallelWorkPending { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### HasPhysics

##### Declaration

```
public bool HasPhysics { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### HasSerialWorkPending

##### Declaration

```
public bool HasSerialWorkPending { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsClosed

##### Declaration

```
public bool IsClosed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsLoaded

##### Declaration

```
public bool IsLoaded { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPendingLodSwitch

##### Declaration

```
public bool IsPendingLodSwitch { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPendingPhysicsToggle

##### Declaration

```
public bool IsPendingPhysicsToggle { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPinned

##### Declaration

```
public bool IsPinned { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LodLevel

##### Declaration

```
public int LodLevel { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Owner

##### Declaration

```
public IMyEnvironmentOwner Owner { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEnvironmentOwner](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMyEnvironmentOwner.html) |     |

#### SectorCenter

##### Declaration

```
public Vector3D SectorCenter { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### SectorId

##### Declaration

```
public long SectorId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Methods

#### add\_OnContactPoint(MySectorContactEvent)

##### Declaration

```
public void add_OnContactPoint(MySectorContactEvent value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySectorContactEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MySectorContactEvent.html) | value |     |

#### BuildInstanceBuffers(Int32)

##### Declaration

```
public void BuildInstanceBuffers(int lod)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | lod |     |

#### CancelParallel()

##### Declaration

```
public void CancelParallel()
```

#### Close()

##### Declaration

#### Closing()

##### Declaration

```
protected override void Closing()
```

##### Overrides

#### DebugDraw()

##### Declaration

#### DoParallelWork()

##### Declaration

```
public void DoParallelWork()
```

#### DoSerialWork()

##### Declaration

```
public bool DoSerialWork()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnableItem(Int32, Boolean)

##### Declaration

```
public void EnableItem(int itemId, bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |
| System.Boolean | enabled |     |

#### EnablePhysics(Boolean)

##### Declaration

```
public void EnablePhysics(bool physics)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | physics |     |

#### ForceLoadDataView()

##### Declaration

```
public void ForceLoadDataView()
```

#### GetDefinition(Int32)

##### Declaration

```
public MyPhysicalModelDefinition GetDefinition(int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyPhysicalModelDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalModelDefinition.html) |     |
