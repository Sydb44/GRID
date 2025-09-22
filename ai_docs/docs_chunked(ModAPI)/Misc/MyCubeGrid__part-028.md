##### Declaration

```
public event Action<IMySlimBlock, float, Nullable<MyHitInfo>, long> OnGridBlockDamaged
```

##### Event Type

Type

Description

System.Action<[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html), System.Single, System.Nullable<[MyHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyHitInfo.html)\>, System.Int64\>

#### OnGridChanged

##### Declaration

```
public event Action<MyCubeGrid> OnGridChanged
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### OnGridMarkedDirty

##### Declaration

```
public event Action<MyCubeGrid> OnGridMarkedDirty
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### OnGridMerge

Called, when 2 grids are merged with merge block. First grid - grid that will stay, second - will be merged into first, and deleted. Called for both grids

##### Declaration

```
public event Action<MyCubeGrid, MyCubeGrid> OnGridMerge
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### OnGridSplit

##### Declaration

```
public event Action<MyCubeGrid, MyCubeGrid> OnGridSplit
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### OnHavokSystemIDChanged

##### Declaration

```
public event Action<int> OnHavokSystemIDChanged
```

##### Event Type

Type

Description

System.Action<System.Int32\>

#### OnHierarchyUpdated

##### Declaration

```
public event Action<MyCubeGrid> OnHierarchyUpdated
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### OnIsStaticChanged

##### Declaration

```
public event Action<bool> OnIsStaticChanged
```

##### Event Type

Type

Description

System.Action<System.Boolean\>

#### OnMassPropertiesChanged

##### Declaration

```
public event Action<MyCubeGrid> OnMassPropertiesChanged
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### OnMaxThrustChanged

May be called from parallel thread

##### Declaration

```
public event Action<MyCubeGrid> OnMaxThrustChanged
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### OnMinMaxChanged

##### Declaration

```
public event Action<MyCubeGrid, Vector3I, Vector3I> OnMinMaxChanged
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html), [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

#### OnNameChanged

##### Declaration

```
public event Action<MyCubeGrid> OnNameChanged
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### OnNaturalGravityChanged

##### Declaration

```
public event Action<IMyCubeGrid> OnNaturalGravityChanged
```

##### Event Type

Type

Description

System.Action<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\>

#### OnSolarOccludedChanged

##### Declaration

```
public event Action<MyCubeGrid> OnSolarOccludedChanged
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### OnSplitGridCreated

##### Declaration

```
public static event Action<MyCubeGrid> OnSplitGridCreated
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### OnStaticChanged

##### Declaration

```
public event Action<MyCubeGrid, bool> OnStaticChanged
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), System.Boolean\>

#### OnTargetLocked

##### Declaration

```
public event Action<IMyCharacter> OnTargetLocked
```

##### Event Type

Type

Description

System.Action<[IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html)\>

#### OnTargetLockLost

##### Declaration

```
public event Action OnTargetLockLost
```

##### Event Type

Type

Description

System.Action

#### PlayerPresenceTierChanged

##### Declaration

```
public event Action<MyCubeGrid> PlayerPresenceTierChanged
```

##### Event Type

Type

Description

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### SpeedChanged

##### Declaration

```
public event Action<IMyCubeGrid> SpeedChanged
```

##### Event Type

Type

Description

System.Action<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\>

#### SyncPropertyChanged

##### Declaration

```
public event Action<SyncBase> SyncPropertyChanged
```
