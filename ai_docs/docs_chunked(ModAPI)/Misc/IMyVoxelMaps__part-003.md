
##### Declaration

```
void RevertShape(IMyVoxelBase voxelMap, IMyVoxelShape voxelShape)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap |     |
| [IMyVoxelShape](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShape.html) | voxelShape |     |

#### SpawnPlanet(String, Single, Int32, Vector3D)

Creates a Planet Entity

##### Declaration

```
IMyVoxelBase SpawnPlanet(string planetName, float size, int seed, Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | planetName | SubtypeId of the Planet (eg: Earthlike, Moon, Mars, etc) |
| System.Single | size | Diameter (in meters) of the planet |
| System.Int32 | seed | Voxel generation seed (similar to the slider you would set in Shift+F10 menu) |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | Position of where the planet is placed (placed using PositionLeftBottomCorner) |

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | Planet as IMyVoxelBase |