---
title: "Class MyProceduralEnvironmentProvider"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment"
class: "MyProceduralEnvironmentProvider"
---

# Class MyProceduralEnvironmentProvider | Space Engineers ModAPI

##### Inheritance

System.Object

MyProceduralEnvironmentProvider

##### Implements

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyProceduralEnvironmentProvider : Object, IMyEnvironmentDataProvider
```

### Constructors

#### MyProceduralEnvironmentProvider()

##### Declaration

```
public MyProceduralEnvironmentProvider()
```

### Fields

#### LodFactor

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### LogicalSectors

##### Declaration

```
public IEnumerable<MyLogicalEnvironmentSectorBase> LogicalSectors { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<[MyLogicalEnvironmentSectorBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase.html)\> |     |

#### Owner

##### Declaration

```
public IMyEnvironmentOwner Owner { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEnvironmentOwner](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMyEnvironmentOwner.html) |     |

#### ProviderId

##### Declaration

```
public int ProviderId { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### CloseView(MyProceduralDataView)

##### Declaration

```
public void CloseView(MyProceduralDataView view)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyProceduralDataView](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyProceduralDataView.html) | view |     |

#### DebugDraw()

##### Declaration

#### GeSectorWorldParameters(Int32, Int32, Int32, out Vector3D, out Vector3, out Vector3)

##### Declaration

```
public void GeSectorWorldParameters(int x, int y, int localLod, out Vector3D worldPos, out Vector3 scanBasisA, out Vector3 scanBasisB)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | x   |     |
| System.Int32 | y   |     |
| System.Int32 | localLod |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPos |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | scanBasisA |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | scanBasisB |     |

#### GetItemView(Int32, ref Vector2I, ref Vector2I, ref Vector3D)

##### Declaration

```
public MyEnvironmentDataView GetItemView(int lod, ref Vector2I start, ref Vector2I end, ref Vector3D localOrigin)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | lod |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | start |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | end |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | localOrigin |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyEnvironmentDataView](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentDataView.html) |     |

#### GetLogicalSector(Int64)

##### Declaration

```
public MyLogicalEnvironmentSectorBase GetLogicalSector(long sectorId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | sectorId |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyLogicalEnvironmentSectorBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase.html) |     |

#### GetObjectBuilder()

##### Declaration

```
public MyObjectBuilder_EnvironmentDataProvider GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.WorldEnvironment.ObjectBuilders.MyObjectBuilder\_EnvironmentDataProvider |     |

#### GetSeed()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Init(IMyEnvironmentOwner, ref Vector3D, ref Vector3D, ref Vector3D, Double, MyObjectBuilder\_Base)

##### Declaration

```
public void Init(IMyEnvironmentOwner owner, ref Vector3D origin, ref Vector3D basisA, ref Vector3D basisB, double sectorSize, MyObjectBuilder_Base ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEnvironmentOwner](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMyEnvironmentOwner.html) | owner |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | basisA |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | basisB |     |
| System.Double | sectorSize |     |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) | ob  |     |

#### RevalidateItem(Int64, Int32)

##### Declaration

```
public void RevalidateItem(long sectorId, int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | sectorId |     |
| System.Int32 | itemId |     |
