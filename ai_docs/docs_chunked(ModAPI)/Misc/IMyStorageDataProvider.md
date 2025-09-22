---
title: "Interface IMyStorageDataProvider"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.IMyStorageDataProvider.html"
category: "Misc"
namespace: "VRage.Voxels"
class: "IMyStorageDataProvider"
---

# Interface IMyStorageDataProvider | Space Engineers ModAPI

###### **Namespace**: [VRage.Voxels](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyStorageDataProvider
```

### Properties

#### SerializedSize

##### Declaration

```
int SerializedSize { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### Close()

##### Declaration

#### DebugDraw(ref MatrixD)

##### Declaration

```
void DebugDraw(ref MatrixD worldMatrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |

#### Intersect(BoundingBoxI, Int32)

##### Declaration

```
ContainmentType Intersect(BoundingBoxI box, int lod)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | box |     |
| System.Int32 | lod |     |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Intersect(ref LineD, out Double, out Double)

##### Declaration

```
bool Intersect(ref LineD line, out double startOffset, out double endOffset)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line |     |
| System.Double | startOffset |     |
| System.Double | endOffset |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PostProcess(VrVoxelMesh, MyStorageDataTypeFlags)

Post-process the mesh generated from the data in this storage.

##### Declaration

```
void PostProcess(VrVoxelMesh mesh, MyStorageDataTypeFlags dataTypes)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Voxels.VrVoxelMesh | mesh |     |
| [MyStorageDataTypeFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeFlags.html) | dataTypes | The types of data requested for the mesh. |

#### ReadFrom(Int32, Stream, Int32, ref Boolean)

##### Declaration

```
void ReadFrom(int storageVersion, Stream stream, int size, ref bool isOldFormat)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | storageVersion |     |
| System.IO.Stream | stream |     |
| System.Int32 | size |     |
| System.Boolean | isOldFormat |     |

#### ReadRange(MyStorageData, MyStorageDataTypeFlags, ref Vector3I, Int32, ref Vector3I, ref Vector3I)

##### Declaration

```
void ReadRange(MyStorageData target, MyStorageDataTypeFlags dataType, ref Vector3I writeOffset, int lodIndex, ref Vector3I minInLod, ref Vector3I maxInLod)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageData.html) | target |     |
| [MyStorageDataTypeFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeFlags.html) | dataType |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | writeOffset |     |
| System.Int32 | lodIndex |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | minInLod |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | maxInLod |     |

#### ReadRange(ref MyVoxelDataRequest, Boolean)

##### Declaration

```
void ReadRange(ref MyVoxelDataRequest request, bool detectOnly = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyVoxelDataRequest](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyVoxelDataRequest.html) | request |     |
| System.Boolean | detectOnly |     |

#### ReindexMaterials(Dictionary<Byte, Byte>)

##### Declaration

```
void ReindexMaterials(Dictionary<byte, byte> oldToNewIndexMap)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<System.Byte, System.Byte\> | oldToNewIndexMap |     |

#### WriteTo(Stream)

##### Declaration

```
void WriteTo(Stream stream)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IO.Stream | stream |     |