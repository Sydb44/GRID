
```
void IMyVoxelMaps.MakeCrater(IMyVoxelBase voxelMap, BoundingSphereD sphere, Vector3 direction, byte materialIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap |     |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | direction |     |
| System.Byte | materialIdx |     |

#### IMyVoxelMaps.PaintInShape(IMyVoxelBase, IMyVoxelShape, Byte)

##### Declaration

```
void IMyVoxelMaps.PaintInShape(IMyVoxelBase voxelMap, IMyVoxelShape voxelShape, byte materialIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap |     |
| [IMyVoxelShape](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShape.html) | voxelShape |     |
| System.Byte | materialIdx |     |

#### IMyVoxelMaps.RevertShape(IMyVoxelBase, IMyVoxelShape)

##### Declaration

```
void IMyVoxelMaps.RevertShape(IMyVoxelBase voxelMap, IMyVoxelShape voxelShape)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap |     |
| [IMyVoxelShape](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShape.html) | voxelShape |     |

#### IMyVoxelMaps.SpawnPlanet(String, Single, Int32, Vector3D)

##### Declaration

```
IMyVoxelBase IMyVoxelMaps.SpawnPlanet(string planetName, float size, int seed, Vector3D pos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | planetName |     |
| System.Single | size |     |
| System.Int32 | seed |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) |     |

#### IMyVoxelMaps.VoxelMaterialCount

##### Declaration

```
int IMyVoxelMaps.VoxelMaterialCount { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Implements