Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

cube

[MyDamageInformation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDamageInformation.html)

damageInfo

##### Returns

Type

Description

Sandbox.Game.Entities.Cube.MySlimBlock

#### GetExistingCubes(Vector3I, Vector3I, Dictionary<Vector3I, MySlimBlock>, Nullable<MyDamageInformation>)

##### Declaration

```
public void GetExistingCubes(Vector3I boneMin, Vector3I boneMax, Dictionary<Vector3I, MySlimBlock> resultSet, Nullable<MyDamageInformation> damageInfo = null)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

boneMin

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

boneMax

System.Collections.Generic.Dictionary<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html), Sandbox.Game.Entities.Cube.MySlimBlock\>

resultSet

System.Nullable<[MyDamageInformation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDamageInformation.html)\>

damageInfo

#### GetFatBlockCount<T>()

Return how much fat blocks defined by T is pressent in grid.

##### Declaration

```
public int GetFatBlockCount<T>()
    where T : MyCubeBlock
```

##### Returns

Type

Description

System.Int32

##### Type Parameters

Name

Description

T

Type of Fatblock

#### GetFatBlocks()

##### Declaration

```
public ListReader<MyCubeBlock> GetFatBlocks()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)\>

#### GetFatBlocks<T>()

##### Declaration

```
public MyFatBlockReader<T> GetFatBlocks<T>()
    where T : MyCubeBlock
```

##### Returns

Type

Description

Sandbox.Game.Entities.Cube.MyFatBlockReader<T>

##### Type Parameters

Name

Description

T

#### GetFirstBlockOfType<T>()

##### Declaration

```
public T GetFirstBlockOfType<T>()
    where T : MyCubeBlock
```

##### Returns

Type

Description

T

##### Type Parameters

Name

Description

T

#### GetGridGroup(GridLinkTypeEnum)

##### Declaration

```
public IMyGridGroupData GetGridGroup(GridLinkTypeEnum linkTypeEnum)
```

##### Parameters

Type

Name

Description

[GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html)

linkTypeEnum

##### Returns

Type

Description

[IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html)

#### GetIntersectionWithLine(ref LineD, ref MyCubeGrid.MyCubeGridHitInfo, IntersectionFlags)

##### Declaration

```
public bool GetIntersectionWithLine(ref LineD line, ref MyCubeGrid.MyCubeGridHitInfo info, IntersectionFlags flags)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

[MyCubeGrid.MyCubeGridHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyCubeGridHitInfo.html)

info

[IntersectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IntersectionFlags.html)

flags

##### Returns

Type

Description

System.Boolean

#### GetIntersectionWithLine(ref LineD, out Nullable<MyIntersectionResultLineTriangleEx>, IntersectionFlags)

##### Declaration

```
public override bool GetIntersectionWithLine(ref LineD line, out Nullable<MyIntersectionResultLineTriangleEx> tri, IntersectionFlags flags)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

System.Nullable<VRage.Game.Models.MyIntersectionResultLineTriangleEx\>

tri

[IntersectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IntersectionFlags.html)

flags

##### Returns

Type

Description

System.Boolean

##### Overrides

#### GetIntersectionWithSphere(ref BoundingSphereD)

##### Declaration

```
public override bool GetIntersectionWithSphere(ref BoundingSphereD sphere)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

##### Returns

Type

Description

System.Boolean

##### Overrides

#### GetLineIntersection(ref LineD, out MyCubeGrid, out Vector3I, out Double, Func<MyCubeGrid, Boolean>)

##### Declaration

```
public static bool GetLineIntersection(ref LineD line, out MyCubeGrid grid, out Vector3I position, out double distanceSquared, Func<MyCubeGrid, bool> condition = null)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

grid

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

System.Double

distanceSquared

System.Func<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), System.Boolean\>

condition

##### Returns

Type

Description

System.Boolean

#### GetLineIntersectionExact(ref LineD, out MyCubeGrid, out Vector3I, out Double)

##### Declaration

```
public static bool GetLineIntersectionExact(ref LineD line, out MyCubeGrid grid, out Vector3I position, out double distanceSquared)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

grid

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

System.Double

distanceSquared
