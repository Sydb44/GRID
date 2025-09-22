blockInCompoundIDs

System.Collections.Generic.HashSet<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

outPositions

#### GetBuildBoundingBox(Single)

##### Declaration

```
public MyOrientedBoundingBoxD GetBuildBoundingBox(float inflate = 0F)
```

##### Parameters

Type

Name

Description

System.Single

inflate

##### Returns

Type

Description

[MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html)

#### GetCurrentRayIntersection()

##### Declaration

```
public static Nullable<double> GetCurrentRayIntersection()
```

##### Returns

Type

Description

System.Nullable<System.Double\>

#### GetNextBlockVariantDefinition()

##### Declaration

```
public MyCubeBlockDefinition GetNextBlockVariantDefinition()
```

##### Returns

Type

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

#### HandleGameInput()

##### Declaration

```
public virtual bool HandleGameInput()
```

##### Returns

Type

Description

System.Boolean

#### InitFromDefinition(MySessionComponentDefinition)

##### Declaration

```
public override void InitFromDefinition(MySessionComponentDefinition definition)
```

##### Parameters

Type

Name

Description

VRage.Game.Components.Session.MySessionComponentDefinition

definition

##### Overrides

#### InputLost()

##### Declaration

#### IsBuilding()

##### Declaration

```
protected virtual bool IsBuilding()
```

##### Returns

Type

Description

System.Boolean

#### IsBuildToolActive()

##### Declaration

```
public bool IsBuildToolActive()
```

##### Returns

Type

Description

System.Boolean

#### IsDynamicOverride()

Allows to override normal behaviour of Cube builder.

##### Declaration

```
protected virtual bool IsDynamicOverride()
```

##### Returns

Type

Description

System.Boolean

#### IsOnlyColorToolActive()

##### Declaration

```
public bool IsOnlyColorToolActive()
```

##### Returns

Type

Description

System.Boolean

#### IsSymmetrySetupMode()

##### Declaration

```
public bool IsSymmetrySetupMode()
```

##### Returns

Type

Description

System.Boolean

#### LoadData()

##### Declaration

```
public override void LoadData()
```

##### Overrides

#### NotifyPlacementUnable()

##### Declaration

```
public void NotifyPlacementUnable()
```

#### OnClosedMessageBox(MyGuiScreenMessageBox.ResultEnum)

##### Declaration

```
public void OnClosedMessageBox(MyGuiScreenMessageBox.ResultEnum result)
```

##### Parameters

Type

Name

Description

Sandbox.Graphics.GUI.MyGuiScreenMessageBox.ResultEnum

result

#### OnLostFocus()

##### Declaration

```
public void OnLostFocus()
```

#### PrepareBlocksToRemove()

##### Declaration

```
protected virtual void PrepareBlocksToRemove()
```

#### PrepareCharacterCollisionPoints(List<Vector3D>)

##### Declaration

```
public static void PrepareCharacterCollisionPoints(List<Vector3D> outList)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

outList

#### Remove()

##### Declaration

#### RemoveBlock(MySlimBlock, Nullable<UInt16>, Boolean)

##### Declaration

```
protected void RemoveBlock(MySlimBlock block, Nullable<ushort> blockIdInCompound, bool checkExisting = false)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

System.Nullable<System.UInt16\>

blockIdInCompound

System.Boolean

checkExisting

#### RemoveBlockInternal(MySlimBlock, Nullable<UInt16>, Boolean)

##### Declaration

```
protected void RemoveBlockInternal(MySlimBlock block, Nullable<ushort> blockIdInCompound, bool checkExisting = false)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

System.Nullable<System.UInt16\>

blockIdInCompound

System.Boolean

checkExisting

#### RemovePlayerColors(MyPlayer.PlayerId)

##### Declaration

```
public static void RemovePlayerColors(MyPlayer.PlayerId playerId)
```

##### Parameters

Type

Name

Description

Sandbox.Game.World.MyPlayer.PlayerId

playerId

#### RemovePlayerColors\_Internal(MyPlayer.PlayerId)

##### Declaration

```
public static void RemovePlayerColors_Internal(MyPlayer.PlayerId playerId)
```

##### Parameters

Type

Name

Description

Sandbox.Game.World.MyPlayer.PlayerId

playerId

#### RotateAxis(Int32, Int32, Double, Boolean)

##### Declaration

```
protected virtual void RotateAxis(int index, int sign, double angleDelta, bool newlyPressed)
```

##### Parameters

Type

Name

Description

System.Int32

index

System.Int32

sign

System.Double

angleDelta

System.Boolean

newlyPressed

#### SelectBlockToToolbar(MySlimBlock, Boolean)

##### Declaration

```
public static void SelectBlockToToolbar(MySlimBlock block, bool selectToNextSlot = true)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

System.Boolean

selectToNextSlot

#### SetToolType(MyCubeBuilderToolType)

##### Declaration

```
public void SetToolType(MyCubeBuilderToolType type)
```

##### Parameters

Type

Name

Description

[MyCubeBuilderToolType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBuilderToolType.html)

type

#### SpawnDynamicGrid(MyCubeBlockDefinition, MyEntity, MatrixD, Vector3, MyStringHash, Int64, MyCubeBuilder.SpawnFlags, Int64, Action<MyEntity>)

##### Declaration

```
public static MyCubeGrid SpawnDynamicGrid(MyCubeBlockDefinition blockDefinition, MyEntity builder, MatrixD worldMatrix, Vector3 color, MyStringHash skinId, long entityId = 0L, MyCubeBuilder.SpawnFlags spawnFlags, long builtBy = 0L, Action<MyEntity> completionCallback = null)
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

System.Int64

entityId

[MyCubeBuilder.SpawnFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBuilder.SpawnFlags.html)

spawnFlags

System.Int64

builtBy

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

completionCallback
