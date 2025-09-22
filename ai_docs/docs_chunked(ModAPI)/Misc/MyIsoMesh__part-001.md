---
title: "Class MyIsoMesh"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyIsoMesh.html"
category: "Misc"
namespace: "VRage.Voxels"
class: "MyIsoMesh"
---

# Class MyIsoMesh | Space Engineers ModAPI

##### Inheritance

System.Object

MyIsoMesh

###### **Namespace**: [VRage.Voxels](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyIsoMesh : Object
```

### Constructors

#### MyIsoMesh()

##### Declaration

### Fields

#### CellEnd

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Cells

##### Declaration

```
public readonly MyList<Vector3I> Cells
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Library.Collections.MyList<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\> |     |

#### CellStart

##### Declaration

```
public Vector3I CellStart
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### ColorShiftHSV

##### Declaration

```
public readonly MyList<uint> ColorShiftHSV
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Library.Collections.MyList<System.UInt32\> |     |

#### Densities

##### Declaration

```
public readonly MyList<sbyte> Densities
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Library.Collections.MyList<System.SByte\> |     |

#### Lod

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Materials

##### Declaration

```
public readonly MyList<byte> Materials
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Library.Collections.MyList<System.Byte\> |     |

#### Normals

##### Declaration

```
public readonly MyList<Vector3> Normals
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Library.Collections.MyList<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### PositionOffset

##### Declaration

```
public Vector3D PositionOffset
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Positions

##### Declaration

```
public readonly MyList<Vector3> Positions
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Library.Collections.MyList<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### PositionScale

##### Declaration

```
public Vector3 PositionScale
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Triangles

##### Declaration

```
public readonly MyList<MyVoxelTriangle> Triangles
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Library.Collections.MyList<VRage.Game.Voxels.MyVoxelTriangle\> |     |

### Properties

#### Size

##### Declaration

```
public Vector3I Size { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### TrianglesCount

##### Declaration

```
public int TrianglesCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### VerticesCount

##### Declaration

```
public int VerticesCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### Clear()

##### Declaration

#### CopyFromNative(VrVoxelMesh)

##### Declaration

```
public void CopyFromNative(VrVoxelMesh vrMesh)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Voxels.VrVoxelMesh | vrMesh |     |

#### FromNative(VrVoxelMesh)

##### Declaration

```
public static MyIsoMesh FromNative(VrVoxelMesh nativeMesh)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Voxels.VrVoxelMesh | nativeMesh |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyIsoMesh](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyIsoMesh.html) |     |

#### GetUnpackedPosition(Int32, out Vector3)

##### Declaration

```
public void GetUnpackedPosition(int idx, out Vector3 position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | idx |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | position |     |

#### GetUnpackedVertex(Int32, out MyVoxelVertex)

##### Declaration

```
public void GetUnpackedVertex(int idx, out MyVoxelVertex vertex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | idx |     |
| VRage.Game.Voxels.MyVoxelVertex | vertex |     |

#### IsEdge(ref Vector3I)

##### Declaration

```
public bool IsEdge(ref Vector3I cell)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | cell |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsEmpty(MyIsoMesh)

##### Declaration

```
public static bool IsEmpty(MyIsoMesh self)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIsoMesh](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyIsoMesh.html) | self |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Reserve(Int32, Int32)

##### Declaration

```
public void Reserve(int vertexCount, int triangleCount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | vertexCount |     |
| System.Int32 | triangleCount |     |
