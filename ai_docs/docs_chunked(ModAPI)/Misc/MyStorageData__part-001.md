---
title: "Class MyStorageData"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageData.html"
category: "Misc"
namespace: "VRage.Voxels"
class: "MyStorageData"
---

# Class MyStorageData | Space Engineers ModAPI

##### Inheritance

System.Object

MyStorageData

###### **Namespace**: [VRage.Voxels](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyStorageData : Object
```

### Constructors

#### MyStorageData()

##### Declaration

#### MyStorageData(MyStorageDataTypeFlags)

##### Declaration

```
public MyStorageData(MyStorageDataTypeFlags typesToStore)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageDataTypeFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeFlags.html) | typesToStore |     |

#### MyStorageData(Vector3I, Byte\[\], Byte\[\])

##### Declaration

```
public MyStorageData(Vector3I size, byte[] content = null, byte[] material = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | size |     |
| System.Byte\[\] | content |     |
| System.Byte\[\] | material |     |

### Properties

#### Item\[MyStorageDataTypeEnum\]

##### Declaration

```
public byte[] this[MyStorageDataTypeEnum type] { get; set; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageDataTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeEnum.html) | type |     |

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte\[\] |     |

#### Size3D

##### Declaration

```
public Vector3I Size3D { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### SizeLinear

##### Declaration

```
public int SizeLinear { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Step

##### Declaration

```
public Vector3I Step { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### StepLinear

##### Declaration

```
public int StepLinear { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### StepX

##### Declaration

```
public int StepX { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### StepY

##### Declaration

```
public int StepY { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### StepZ

##### Declaration

```
public int StepZ { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### BlockFill(MyStorageDataTypeEnum, Vector3I, Vector3I, Byte)

##### Declaration

```
public void BlockFill(MyStorageDataTypeEnum type, Vector3I min, Vector3I max, byte content)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageDataTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeEnum.html) | type |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | min |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | max |     |
| System.Byte | content |     |

#### BlockFillContent(Vector3I, Vector3I, Byte)

##### Declaration

```
public void BlockFillContent(Vector3I min, Vector3I max, byte content)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | min |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | max |     |
| System.Byte | content |     |

#### BlockFillMaterial(Vector3I, Vector3I, Byte)

##### Declaration

```
public void BlockFillMaterial(Vector3I min, Vector3I max, byte materialIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | min |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | max |     |
| System.Byte | materialIdx |     |

#### BlockFillMaterialConsiderContent(Vector3I, Vector3I, Byte)

##### Declaration

```
public void BlockFillMaterialConsiderContent(Vector3I min, Vector3I max, byte materialIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | min |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | max |     |
| System.Byte | materialIdx |     |

#### Clear(MyStorageDataTypeEnum, Byte)

##### Declaration

```
public void Clear(MyStorageDataTypeEnum type, byte p)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageDataTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeEnum.html) | type |     |
| System.Byte | p   |     |

#### ClearContent(Byte)

##### Declaration

```
public void ClearContent(byte p)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte | p   |     |

#### ClearMaterials(Byte)

##### Declaration

```
public void ClearMaterials(byte p)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte | p   |     |

#### ComputeContentConstitution()

##### Declaration

```
public MyVoxelContentConstitution ComputeContentConstitution()
```
