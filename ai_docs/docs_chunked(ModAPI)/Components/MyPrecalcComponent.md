---
title: "Class MyPrecalcComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyPrecalcComponent.html"
category: "Components"
namespace: "VRage.Voxels"
class: "MyPrecalcComponent"
---

# Class MyPrecalcComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyPrecalcComponent

##### Inherited Members

###### **Namespace**: [VRage.Voxels](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MySessionComponentDescriptor]
public class MyPrecalcComponent : MySessionComponentBase, IMyUserInputComponent
```

### Constructors

#### MyPrecalcComponent()

##### Declaration

```
public MyPrecalcComponent()
```

### Fields

#### DebugDrawSorted

Enable debug draw.

##### Declaration

```
public static bool DebugDrawSorted
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxPrecalcTime

Maximum calculation time in milliseconds

##### Declaration

```
public static long MaxPrecalcTime
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### UpdateThreadManagedId

##### Declaration

```
public static int UpdateThreadManagedId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### InvalidatedRangeInflate

##### Declaration

```
public static int InvalidatedRangeInflate { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IsoMesher

##### Declaration

```
public static IMyIsoMesher IsoMesher { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyIsoMesher](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.IMyIsoMesher.html) |     |

#### IsoMesherType

The IsoMesher type used by precalc jobs.

##### Declaration

```
public static Type IsoMesherType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Type |     |

### Methods

#### AssertUpdateThread()

##### Declaration

```
public static void AssertUpdateThread()
```

#### EnqueueBack(MyPrecalcJob)

##### Declaration

```
public static bool EnqueueBack(MyPrecalcJob job)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.Voxels.MyPrecalcJob | job |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LoadData()

##### Declaration

```
public override void LoadData()
```

##### Overrides

#### UnloadData()

##### Declaration

```
protected override void UnloadData()
```

##### Overrides

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

#### UpdatedBeforeInit()

##### Declaration

```
public override bool UpdatedBeforeInit()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### UpdateQueue()

##### Declaration

```
public void UpdateQueue()
```