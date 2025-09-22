```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

coords

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### WorldToGridScaledLocal(Vector3D)

##### Declaration

```
public Vector3D WorldToGridScaledLocal(Vector3D coords)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

coords

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

### Events

#### GridPresenceTierChanged

##### Declaration

```
public event Action<MyCubeGrid> GridPresenceTierChanged
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### IsPoweredChanged

##### Declaration

```
public event Action<bool> IsPoweredChanged
```

##### Event Type

Type

Description

System.Action<System.Boolean\>

#### OnBlockAdded

##### Declaration

```
public event Action<MySlimBlock> OnBlockAdded
```

##### Event Type

Type

Description

System.Action<Sandbox.Game.Entities.Cube.MySlimBlock\>

#### OnBlockAddedGlobally

Called only for single block changes

##### Declaration

```
public static event Action<MySlimBlock> OnBlockAddedGlobally
```

##### Event Type

Type

Description

System.Action<Sandbox.Game.Entities.Cube.MySlimBlock\>

#### OnBlockClosed

##### Declaration

```
public event Action<MySlimBlock> OnBlockClosed
```

##### Event Type

Type

Description

System.Action<Sandbox.Game.Entities.Cube.MySlimBlock\>

#### OnBlockIntegrityChanged

##### Declaration

```
public event Action<MySlimBlock> OnBlockIntegrityChanged
```

##### Event Type

Type

Description

System.Action<Sandbox.Game.Entities.Cube.MySlimBlock\>

#### OnBlockOwnershipChanged

##### Declaration

```
public event Action<MyCubeGrid> OnBlockOwnershipChanged
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### OnBlockRemoved

##### Declaration

```
public event Action<MySlimBlock> OnBlockRemoved
```

##### Event Type

Type

Description

System.Action<Sandbox.Game.Entities.Cube.MySlimBlock\>

#### OnBlockRemovedGlobally

Not called on grid split, or when closing grid

##### Declaration

```
public static event Action<MySlimBlock> OnBlockRemovedGlobally
```

##### Event Type

Type

Description

System.Action<Sandbox.Game.Entities.Cube.MySlimBlock\>

#### OnBlocksChangeFinishedGlobally

Called on multi block changes. Both arguments may be null. First from where blocks where removed, second - where added

##### Declaration

```
public static event Action<MyCubeGrid, MyCubeGrid> OnBlocksChangeFinishedGlobally
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### OnConnectionChangeCompleted

Event triggered, when one of GridLinkTypeEnum connections changed. Used to determine changes in connections. Use may also need react to OnGridMerge/OnGridSplit Event different from OnConnectivityChanged.

1.  It is called when all group changes
2.  It is called AFTER all group changes, so GetConnectedGrids returning correct results

##### Declaration

```
public event Action<MyCubeGrid, GridLinkTypeEnum> OnConnectionChangeCompleted
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html)\>

#### OnConnectionChanged

Event triggered, when one of GridLinkTypeEnum connections changed. Used to determine changes in connections. Use may also need react to OnGridMerge/OnGridSplit

##### Declaration

```
public event Action<MyCubeGrid, GridLinkTypeEnum> OnConnectionChanged
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html)\>

#### OnDeschedule

##### Declaration

```
public event Action OnDeschedule
```

##### Event Type

Type

Description

System.Action

#### OnDynamicNPCGridOrSubgridShooting

##### Declaration

```
public event Action<MyCubeGrid> OnDynamicNPCGridOrSubgridShooting
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### OnFatBlockAdded

##### Declaration

```
public event Action<MyCubeBlock> OnFatBlockAdded
```

##### Event Type

Type

Description

System.Action<[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)\>

#### OnFatBlockClosed

##### Declaration

```
public event Action<MyCubeBlock> OnFatBlockClosed
```

##### Event Type

Type

Description

System.Action<[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)\>

#### OnFatBlockRemoved

##### Declaration

```
public event Action<MyCubeBlock> OnFatBlockRemoved
```

##### Event Type

Type

Description

System.Action<[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)\>

#### OnGridBlockDamaged

##### Declaration

```
public event Action<IMySlimBlock, float, Nullable<MyHitInfo>, long> OnGridBlockDamaged
```

##### Event Type

Type

Description

System.Action<[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html), System.Single, System.Nullable<[MyHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyHitInfo.html)\>, System.Int64\>
