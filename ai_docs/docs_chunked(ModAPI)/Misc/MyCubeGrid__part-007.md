System.Boolean

isProjection

##### Returns

Type

Description

System.Boolean

#### CanPlaceBlock(Vector3I, Vector3I, MyBlockOrientation, MyCubeBlockDefinition, ref MyGridPlacementSettings, UInt64, Nullable<Int32>, Boolean, Boolean)

##### Declaration

```
public bool CanPlaceBlock(Vector3I min, Vector3I max, MyBlockOrientation orientation, MyCubeBlockDefinition definition, ref MyGridPlacementSettings gridSettings, ulong placingPlayer = 0UL, Nullable<int> ignoreMultiblockId = null, bool ignoreFracturedPieces = false, bool isProjection = false)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

orientation

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

definition

VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings

gridSettings

System.UInt64

placingPlayer

System.Nullable<System.Int32\>

ignoreMultiblockId

System.Boolean

ignoreFracturedPieces

System.Boolean

isProjection

##### Returns

Type

Description

System.Boolean

#### ChangeColorAndSkin(MySlimBlock, Nullable<Vector3>, Nullable<MyStringHash>)

##### Declaration

```
public bool ChangeColorAndSkin(MySlimBlock block, Nullable<Vector3> newHSV = null, Nullable<MyStringHash> skinSubtypeId = null)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

newHSV

System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\>

skinSubtypeId

##### Returns

Type

Description

System.Boolean

#### ChangeDisplayNameRequest(String)

##### Declaration

```
public void ChangeDisplayNameRequest(string displayName)
```

##### Parameters

Type

Name

Description

System.String

displayName

#### ChangeGridOwner(Int64, MyOwnershipShareModeEnum)

##### Declaration

```
public void ChangeGridOwner(long playerId, MyOwnershipShareModeEnum shareMode)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

[MyOwnershipShareModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOwnershipShareModeEnum.html)

shareMode

#### ChangeGridOwnership(Int64, MyOwnershipShareModeEnum)

##### Declaration

```
public void ChangeGridOwnership(long playerId, MyOwnershipShareModeEnum shareMode)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

[MyOwnershipShareModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOwnershipShareModeEnum.html)

shareMode

#### ChangeOwner(MyCubeBlock, Int64, Int64)

##### Declaration

```
public void ChangeOwner(MyCubeBlock block, long oldOwner, long newOwner)
```

##### Parameters

Type

Name

Description

[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)

block

System.Int64

oldOwner

System.Int64

newOwner

#### ChangeOwnerRequest(MyCubeGrid, MyCubeBlock, Int64, MyOwnershipShareModeEnum)

##### Declaration

```
public void ChangeOwnerRequest(MyCubeGrid grid, MyCubeBlock block, long playerId, MyOwnershipShareModeEnum shareMode)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

grid

[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)

block

System.Int64

playerId

[MyOwnershipShareModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOwnershipShareModeEnum.html)

shareMode

#### ChangeOwnersRequest(MyOwnershipShareModeEnum, Dictionary<MyCubeGrid, List<MyCubeGrid.MySingleOwnershipRequest>>)

##### Declaration

```
public static void ChangeOwnersRequest(MyOwnershipShareModeEnum shareMode, Dictionary<MyCubeGrid, List<MyCubeGrid.MySingleOwnershipRequest>> requests)
```

##### Parameters

Type

Name

Description

[MyOwnershipShareModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOwnershipShareModeEnum.html)

shareMode

System.Collections.Generic.Dictionary<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), System.Collections.Generic.List<[MyCubeGrid.MySingleOwnershipRequest](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MySingleOwnershipRequest.html)\>>

requests

#### ChangePowerProducerState(MyMultipleEnabledEnum, Boolean)

##### Declaration

```
public void ChangePowerProducerState(MyMultipleEnabledEnum enabledState, bool localGridOnly = false)
```

##### Parameters

Type

Name

Description

VRage.MyMultipleEnabledEnum

enabledState

System.Boolean

localGridOnly

#### ChangePowerProducerStateInternal(MyMultipleEnabledEnum, Int64, Boolean)

##### Declaration

```
public void ChangePowerProducerStateInternal(MyMultipleEnabledEnum enabledState, long identityId, bool localGridOnly = false)
```

##### Parameters

Type

Name

Description

VRage.MyMultipleEnabledEnum

enabledState

System.Int64

identityId

System.Boolean

localGridOnly

#### ChangeShareRequest(MyOwnershipShareModeEnum, Dictionary<MyCubeGrid, List<MyCubeGrid.MySingleOwnershipRequest>>)

##### Declaration

```
public static void ChangeShareRequest(MyOwnershipShareModeEnum shareMode, Dictionary<MyCubeGrid, List<MyCubeGrid.MySingleOwnershipRequest>> requests)
```

##### Parameters

Type

Name

Description

[MyOwnershipShareModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOwnershipShareModeEnum.html)

shareMode

System.Collections.Generic.Dictionary<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), System.Collections.Generic.List<[MyCubeGrid.MySingleOwnershipRequest](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MySingleOwnershipRequest.html)\>>

requests
