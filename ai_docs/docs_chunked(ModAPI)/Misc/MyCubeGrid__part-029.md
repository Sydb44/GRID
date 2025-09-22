Type

Description

System.Action<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\>

#### SyncPropertyChanged

##### Declaration

```
public event Action<SyncBase> SyncPropertyChanged
```

##### Event Type

Type

Description

System.Action<VRage.Sync.SyncBase\>

### Explicit Interface Implementations

#### IMyCubeGrid.AddBlock(MyObjectBuilder\_CubeBlock, Boolean)

##### Declaration

```
IMySlimBlock IMyCubeGrid.AddBlock(MyObjectBuilder_CubeBlock objectBuilder, bool testMerge)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html)

objectBuilder

System.Boolean

testMerge

##### Returns

Type

Description

[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)

#### IMyCubeGrid.ApplyDeformation(Single, Single, Single, Vector3, Vector3, MyStringHash, out Int32, Single, Single, Int64)

##### Declaration

```
bool IMyCubeGrid.ApplyDeformation(float deformationOffset, float softAreaPlanar, float softAreaVertical, Vector3 localPos, Vector3 localNormal, MyStringHash damageType, out int blocksDestroyedByThisCp, float offsetThreshold, float lowerRatioLimit, long attackerId)
```

##### Parameters

Type

Name

Description

System.Single

deformationOffset

System.Single

softAreaPlanar

System.Single

softAreaVertical

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

localPos

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

localNormal

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

damageType

System.Int32

blocksDestroyedByThisCp

System.Single

offsetThreshold

System.Single

lowerRatioLimit

System.Int64

attackerId

##### Returns

Type

Description

System.Boolean

#### IMyCubeGrid.ApplyDestructionDeformation(IMySlimBlock)

##### Declaration

```
void IMyCubeGrid.ApplyDestructionDeformation(IMySlimBlock block)
```

##### Parameters

Type

Name

Description

[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)

block

#### IMyCubeGrid.BigOwners

##### Declaration

```
List<long> IMyCubeGrid.BigOwners { get; }
```

##### Returns

Type

Description

System.Collections.Generic.List<System.Int64\>

#### IMyCubeGrid.CalculateMergeTransform(IMyCubeGrid, Vector3I)

##### Declaration

```
MatrixI IMyCubeGrid.CalculateMergeTransform(IMyCubeGrid gridToMerge, Vector3I gridOffset)
```

##### Parameters

Type

Name

Description

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)

gridToMerge

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridOffset

##### Returns

Type

Description

[MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html)

#### IMyCubeGrid.CanAddCube(Vector3I)

##### Declaration

```
bool IMyCubeGrid.CanAddCube(Vector3I pos)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

pos

##### Returns

Type

Description

System.Boolean

#### IMyCubeGrid.CanAddCubes(Vector3I, Vector3I)

##### Declaration

```
bool IMyCubeGrid.CanAddCubes(Vector3I min, Vector3I max)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

##### Returns

Type

Description

System.Boolean

#### IMyCubeGrid.CanMergeCubes(IMyCubeGrid, Vector3I)

##### Declaration

```
bool IMyCubeGrid.CanMergeCubes(IMyCubeGrid gridToMerge, Vector3I gridOffset)
```

##### Parameters

Type

Name

Description

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)

gridToMerge

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridOffset

##### Returns

Type

Description

System.Boolean

#### IMyCubeGrid.ChangeGridOwnership(Int64, MyOwnershipShareModeEnum)

##### Declaration

```
void IMyCubeGrid.ChangeGridOwnership(long playerId, MyOwnershipShareModeEnum shareMode)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

[MyOwnershipShareModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOwnershipShareModeEnum.html)

shareMode

#### IMyCubeGrid.ClearSymmetries()

##### Declaration

```
void IMyCubeGrid.ClearSymmetries()
```

#### IMyCubeGrid.ColorBlocks(Vector3I, Vector3I, Vector3)

##### Declaration

```
void IMyCubeGrid.ColorBlocks(Vector3I min, Vector3I max, Vector3 newHSV)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

newHSV

#### IMyCubeGrid.ControlSystem

##### Declaration

```
IMyGridControlSystem IMyCubeGrid.ControlSystem { get; }
```

##### Returns

Type

Description

[IMyGridControlSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridControlSystem.html)

#### IMyCubeGrid.CustomName

##### Declaration

```
string IMyCubeGrid.CustomName { get; set; }
```

##### Returns

Type

Description

System.String

#### IMyCubeGrid.FixTargetCube(out Vector3I, Vector3)

##### Declaration

```
void IMyCubeGrid.FixTargetCube(out Vector3I cube, Vector3 fractionalGridPosition)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

cube

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

fractionalGridPosition
