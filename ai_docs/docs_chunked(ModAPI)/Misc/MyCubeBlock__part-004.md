Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

System.Nullable<VRage.Game.Models.MyIntersectionResultLineTriangleEx\>

t

[IntersectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IntersectionFlags.html)

flags

##### Returns

Type

Description

System.Boolean

##### Overrides

#### GetLocalMatrix(out Matrix)

##### Declaration

```
public void GetLocalMatrix(out Matrix localMatrix)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

localMatrix

#### GetMass()

##### Declaration

```
public virtual float GetMass()
```

##### Returns

Type

Description

System.Single

#### GetObjectBuilder(Boolean)

##### Declaration

```
public sealed override MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

Type

Name

Description

System.Boolean

copy

##### Returns

Type

Description

[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)

##### Overrides

#### GetObjectBuilderCubeBlock(Boolean)

##### Declaration

```
public virtual MyObjectBuilder_CubeBlock GetObjectBuilderCubeBlock(bool copy = false)
```

##### Parameters

Type

Name

Description

System.Boolean

copy

##### Returns

Type

Description

[MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html)

#### GetOwnerFactionTag()

##### Declaration

```
public string GetOwnerFactionTag()
```

##### Returns

Type

Description

System.String

#### GetPlayerRelationToOwner()

##### Declaration

```
public MyRelationsBetweenPlayerAndBlock GetPlayerRelationToOwner()
```

##### Returns

Type

Description

[MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html)

#### GetSubBlocks()

##### Declaration

```
public DictionaryReader<string, MySlimBlock> GetSubBlocks()
```

##### Returns

Type

Description

[DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<System.String, Sandbox.Game.Entities.Cube.MySlimBlock\>

#### GetUserRelationToOwner(Int64, MyRelationsBetweenPlayerAndBlock)

##### Declaration

```
public MyRelationsBetweenPlayerAndBlock GetUserRelationToOwner(long identityId, MyRelationsBetweenPlayerAndBlock defaultNoUser)
```

##### Parameters

Type

Name

Description

System.Int64

identityId

[MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html)

defaultNoUser

##### Returns

Type

Description

[MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html)

#### HasUnparentedSubpart()

##### Declaration

```
protected bool HasUnparentedSubpart()
```

##### Returns

Type

Description

System.Boolean

#### Init()

##### Declaration

#### Init(MyObjectBuilder\_CubeBlock, MyCubeGrid)

##### Declaration

```
public virtual void Init(MyObjectBuilder_CubeBlock builder, MyCubeGrid cubeGrid)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html)

builder

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

cubeGrid

#### Init(MyObjectBuilder\_CubeBlock, IMyCubeGrid)

##### Declaration

```
public void Init(MyObjectBuilder_CubeBlock builder, IMyCubeGrid cubeGrid)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html)

builder

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)

cubeGrid

#### InitComponents()

##### Declaration

```
public override void InitComponents()
```

##### Overrides

#### OnAddedToScene(Object)

##### Declaration

```
public override void OnAddedToScene(object source)
```

##### Parameters

Type

Name

Description

System.Object

source

##### Overrides

#### OnBuildSuccess(Int64, Boolean)

Method called when a block has been built (after adding to the grid). This is called right after placing the block and it doesn't matter whether it is fully built (creative mode) or is only construction site. Note that it is not called for blocks which do not create FatBlock at that moment.

##### Declaration

```
public virtual void OnBuildSuccess(long builtBy, bool instantBuild)
```

##### Parameters

Type

Name

Description

System.Int64

builtBy

System.Boolean

instantBuild

#### OnConstraintAdded(GridLinkTypeEnum, IMyEntity)

Called by constraint owner

##### Declaration

```
protected void OnConstraintAdded(GridLinkTypeEnum type, IMyEntity attachedEntity)
```

##### Parameters

Type

Name

Description

[GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html)

type

[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)

attachedEntity

#### OnConstraintRemoved(GridLinkTypeEnum, IMyEntity)

Called by constraint owner

##### Declaration

```
protected void OnConstraintRemoved(GridLinkTypeEnum type, IMyEntity detachedEntity)
```

##### Parameters

Type

Name

Description

[GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html)

type

[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)

detachedEntity

#### OnCubeGridChanged(MyCubeGrid)

Notifies about grid change with old grid in parameter (new grid is available in property).

##### Declaration

```
public virtual void OnCubeGridChanged(MyCubeGrid oldGrid)
```
