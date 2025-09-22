entityId

[MyCubeBuilder.SpawnFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBuilder.SpawnFlags.html)

spawnFlags

System.Int64

builtBy

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

completionCallback

##### Returns

Type

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

#### SpawnStaticGrid(MyCubeBlockDefinition, MyEntity, MatrixD, Vector3, MyStringHash, MyCubeBuilder.SpawnFlags, Int64, Action<MyEntity>)

Spawn static grid - must have identity rotation matrix! If dontAdd is true, grid won't be added to enitites. Also it won't have entityId set.

##### Declaration

```
public static MyCubeGrid SpawnStaticGrid(MyCubeBlockDefinition blockDefinition, MyEntity builder, MatrixD worldMatrix, Vector3 color, MyStringHash skinId, MyCubeBuilder.SpawnFlags spawnFlags, long builtBy = 0L, Action<MyEntity> completionCallback = null)
```

##### Parameters

Type

Name

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

blockDefinition

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

builder

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

color

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

skinId

[MyCubeBuilder.SpawnFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBuilder.SpawnFlags.html)

spawnFlags

System.Int64

builtBy

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

completionCallback

##### Returns

Type

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

#### SpawnStaticGrid\_nonParalel(MyCubeBlockDefinition, MyEntity, MatrixD, Vector3, MyStringHash, MyCubeBuilder.SpawnFlags, Int64)

##### Declaration

```
public static MySlimBlock SpawnStaticGrid_nonParalel(MyCubeBlockDefinition blockDefinition, MyEntity builder, MatrixD worldMatrix, Vector3 color, MyStringHash skinId, MyCubeBuilder.SpawnFlags spawnFlags, long builtBy = 0L)
```

##### Parameters

Type

Name

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

blockDefinition

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

builder

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

color

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

skinId

[MyCubeBuilder.SpawnFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBuilder.SpawnFlags.html)

spawnFlags

System.Int64

builtBy

##### Returns

Type

Description

Sandbox.Game.Entities.Cube.MySlimBlock

#### StartBuilding()

##### Declaration

```
public virtual void StartBuilding()
```

#### StartBuilding(ref Nullable<Vector3I>, Nullable<Vector3I>)

Starts continuous building. Do not put any gizmo related stuff here.

##### Declaration

```
protected void StartBuilding(ref Nullable<Vector3I> startBuild, Nullable<Vector3I> startRemove)
```

##### Parameters

Type

Name

Description

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

startBuild

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

startRemove

#### StartRemoving()

##### Declaration

```
protected virtual void StartRemoving()
```

#### StartRemoving(Nullable<Vector3I>, ref Nullable<Vector3I>)

Starts continuous removing. Do not put any gizmo related stuff here.

##### Declaration

```
protected void StartRemoving(Nullable<Vector3I> startBuild, ref Nullable<Vector3I> startRemove)
```

##### Parameters

Type

Name

Description

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

startBuild

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

startRemove

#### StartStaticGridPlacement(MyCubeSize, Boolean)

##### Declaration

```
public void StartStaticGridPlacement(MyCubeSize cubeSize, bool isStatic)
```

##### Parameters

Type

Name

Description

[MyCubeSize](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCubeSize.html)

cubeSize

System.Boolean

isStatic

#### StopBuilding()

##### Declaration

```
public virtual void StopBuilding()
```

#### StopBuilding(Boolean, ref Nullable<Vector3I>, ref Nullable<Vector3I>, ref Nullable<Vector3I>, Vector3I, Vector3I, Vector3I, ref Matrix, MyCubeBlockDefinition)

Stops continuous building/removing. Do not put any gizmo related stuff here.

##### Declaration

```
protected void StopBuilding(bool smallViewChange, ref Nullable<Vector3I> startBuild, ref Nullable<Vector3I> startRemove, ref Nullable<Vector3I> continueBuild, Vector3I blockMinPosition, Vector3I blockMaxPosition, Vector3I blockCenterPosition, ref Matrix localMatrixAdd, MyCubeBlockDefinition blockDefinition)
```

##### Parameters

Type

Name

Description

System.Boolean

smallViewChange

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

startBuild

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

startRemove

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

continueBuild

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

blockMinPosition

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

blockMaxPosition

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

blockCenterPosition

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

localMatrixAdd

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

blockDefinition
