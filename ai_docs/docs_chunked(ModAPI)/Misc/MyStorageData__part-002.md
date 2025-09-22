##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte | p   |     |

#### ComputeContentConstitution()

##### Declaration

```
public MyVoxelContentConstitution ComputeContentConstitution()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyVoxelContentConstitution](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyVoxelContentConstitution.html) |     |

#### ComputeLinear(ref Vector3I)

##### Declaration

```
public int ComputeLinear(ref Vector3I p)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ComputePosition(Int32, out Vector3I)

##### Declaration

```
public void ComputePosition(int linear, out Vector3I p)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | linear |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p   |     |

#### ContainsIsoSurface()

##### Declaration

```
public bool ContainsIsoSurface()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ContainsVoxelsAboveIsoLevel()

##### Declaration

```
public bool ContainsVoxelsAboveIsoLevel()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Content(Int32)

##### Declaration

```
public byte Content(int linearIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | linearIdx |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Content(Int32, Byte)

##### Declaration

```
public void Content(int linearIdx, byte content)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | linearIdx |     |
| System.Byte | content |     |

#### Content(Int32, Int32, Int32)

##### Declaration

```
public byte Content(int x, int y, int z)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | x   |     |
| System.Int32 | y   |     |
| System.Int32 | z   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Content(ref Vector3I)

##### Declaration

```
public byte Content(ref Vector3I p)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Content(ref Vector3I, Byte)

##### Declaration

```
public void Content(ref Vector3I p, byte content)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p   |     |
| System.Byte | content |     |

#### CopyRange(MyStorageData, Vector3I, Vector3I, Vector3I, MyStorageDataTypeEnum)

##### Declaration

```
public void CopyRange(MyStorageData src, Vector3I min, Vector3I max, Vector3I offset, MyStorageDataTypeEnum dataType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageData.html) | src |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | min |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | max |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | offset |     |
| [MyStorageDataTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeEnum.html) | dataType |     |

#### FromBase64(String)

##### Declaration

```
public static MyStorageData FromBase64(string str)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | str |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyStorageData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageData.html) |     |

#### Get(MyStorageDataTypeEnum, Int32)

##### Declaration

```
public byte Get(MyStorageDataTypeEnum type, int linearIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageDataTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeEnum.html) | type |     |
| System.Int32 | linearIdx |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Get(MyStorageDataTypeEnum, Int32, Int32, Int32)

##### Declaration

```
public byte Get(MyStorageDataTypeEnum type, int x, int y, int z)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageDataTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeEnum.html) | type |     |
| System.Int32 | x   |     |
| System.Int32 | y   |     |
| System.Int32 | z   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Get(MyStorageDataTypeEnum, ref Vector3I)

##### Declaration

```
public byte Get(MyStorageDataTypeEnum type, ref Vector3I p)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageDataTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeEnum.html) | type |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Material(Int32)

##### Declaration

```
public byte Material(int linearIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | linearIdx |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Byte |     |
