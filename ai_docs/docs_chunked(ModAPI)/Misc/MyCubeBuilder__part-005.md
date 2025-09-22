cubeSize

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

def

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

drawMatrix

[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\[\]

mountPoints

#### DrawMountPoints(Single, MyCubeBlockDefinition, ref MatrixD)

##### Declaration

```
public static void DrawMountPoints(float cubeSize, MyCubeBlockDefinition def, ref MatrixD drawMatrix)
```

##### Parameters

Type

Name

Description

System.Single

cubeSize

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

def

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

drawMatrix

#### DrawRemovingCubes(Nullable<Vector3I>, Nullable<Vector3I>, MySlimBlock)

##### Declaration

```
protected static void DrawRemovingCubes(Nullable<Vector3I> startRemove, Nullable<Vector3I> continueBuild, MySlimBlock removeBlock)
```

##### Parameters

Type

Name

Description

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

startRemove

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

continueBuild

Sandbox.Game.Entities.Cube.MySlimBlock

removeBlock

#### DrawSemiTransparentBox(MyCubeGrid, MySlimBlock, Color, Boolean, Nullable<MyStringId>, Nullable<Vector4>)

##### Declaration

```
public static void DrawSemiTransparentBox(MyCubeGrid grid, MySlimBlock block, Color color, bool onlyWireframe = false, Nullable<MyStringId> lineMaterial = null, Nullable<Vector4> lineColor = null)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

grid

Sandbox.Game.Entities.Cube.MySlimBlock

block

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

color

System.Boolean

onlyWireframe

System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\>

lineMaterial

System.Nullable<[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)\>

lineColor

#### DrawSemiTransparentBox(Vector3I, Vector3I, MyCubeGrid, Color, Boolean, Nullable<MyStringId>, Nullable<Vector4>)

##### Declaration

```
public static void DrawSemiTransparentBox(Vector3I minPosition, Vector3I maxPosition, MyCubeGrid grid, Color color, bool onlyWireframe = false, Nullable<MyStringId> lineMaterial = null, Nullable<Vector4> lineColor = null)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

minPosition

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

maxPosition

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

grid

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

color

System.Boolean

onlyWireframe

System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\>

lineMaterial

System.Nullable<[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)\>

lineColor

#### GetAddAndRemovePositions(Single, Boolean, out Vector3I, out Nullable<Vector3>, out Vector3I, out Vector3I, out MySlimBlock, out Nullable<UInt16>, HashSet<Tuple<MySlimBlock, Nullable<UInt16>>>)

##### Declaration

```
public virtual bool GetAddAndRemovePositions(float gridSize, bool placingSmallGridOnLargeStatic, out Vector3I addPos, out Nullable<Vector3> addPosSmallOnLarge, out Vector3I addDir, out Vector3I removePos, out MySlimBlock removeBlock, out Nullable<ushort> compoundBlockId, HashSet<Tuple<MySlimBlock, Nullable<ushort>>> removeBlocksInMultiBlock)
```

##### Parameters

Type

Name

Description

System.Single

gridSize

System.Boolean

placingSmallGridOnLargeStatic

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

addPos

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

addPosSmallOnLarge

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

addDir

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

removePos

Sandbox.Game.Entities.Cube.MySlimBlock

removeBlock

System.Nullable<System.UInt16\>

compoundBlockId

System.Collections.Generic.HashSet<System.Tuple<Sandbox.Game.Entities.Cube.MySlimBlock, System.Nullable<System.UInt16\>>>

removeBlocksInMultiBlock

##### Returns

Type

Description

System.Boolean

#### GetAddPosition(out Vector3D)

##### Declaration

```
public void GetAddPosition(out Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### GetAllBlocksPositions(HashSet<Tuple<MySlimBlock, Nullable<UInt16>>>, HashSet<Vector3I>)

##### Declaration

```
public static void GetAllBlocksPositions(HashSet<Tuple<MySlimBlock, Nullable<ushort>>> blockInCompoundIDs, HashSet<Vector3I> outPositions)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.HashSet<System.Tuple<Sandbox.Game.Entities.Cube.MySlimBlock, System.Nullable<System.UInt16\>>>

blockInCompoundIDs

System.Collections.Generic.HashSet<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

outPositions

#### GetBuildBoundingBox(Single)

##### Declaration

```
public MyOrientedBoundingBoxD GetBuildBoundingBox(float inflate = 0F)
```
