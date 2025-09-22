```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | linearIdx |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Material(Int32, Byte)

##### Declaration

```
public void Material(int linearIdx, byte materialIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | linearIdx |     |
| System.Byte | materialIdx |     |

#### Material(ref Vector3I)

##### Declaration

```
public byte Material(ref Vector3I p)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Material(ref Vector3I, Byte)

##### Declaration

```
public void Material(ref Vector3I p, byte materialIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p   |     |
| System.Byte | materialIdx |     |

#### OpRange<Op>(MyStorageData, Vector3I, Vector3I, Vector3I, MyStorageDataTypeEnum)

##### Declaration

```
public void OpRange<Op>(MyStorageData src, Vector3I min, Vector3I max, Vector3I offset, MyStorageDataTypeEnum dataType)
    where Op : struct, MyStorageData.IOperator, ValueType
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageData.html) | src |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | min |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | max |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | offset |     |
| [MyStorageDataTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeEnum.html) | dataType |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| Op  |     |

#### Resize(Vector3I)

##### Declaration

```
public void Resize(Vector3I size3D)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | size3D |     |

#### Resize(Vector3I, Vector3I)

##### Declaration

```
public void Resize(Vector3I start, Vector3I end)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | start | Inclusive. |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | end | Inclusive. |

#### Set(MyStorageDataTypeEnum, ref Vector3I, Byte)

##### Declaration

```
public void Set(MyStorageDataTypeEnum type, ref Vector3I p, byte value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageDataTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeEnum.html) | type |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p   |     |
| System.Byte | value |     |

#### ToBase64()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### ValueWhenAllEqual(MyStorageDataTypeEnum)

##### Declaration

```
public int ValueWhenAllEqual(MyStorageDataTypeEnum dataType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageDataTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeEnum.html) | dataType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### WrinkleVoxelContent(ref Vector3I, Single, Single)

##### Declaration

```
public bool WrinkleVoxelContent(ref Vector3I p, float wrinkleWeightAdd, float wrinkleWeightRemove)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p   |     |
| System.Single | wrinkleWeightAdd |     |
| System.Single | wrinkleWeightRemove |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |