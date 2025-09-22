#### DebugDraw(MyEntity)

##### Declaration

```
public void DebugDraw(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

#### GetConveyorEndpointBlock(IMyEntity)

##### Declaration

```
public static IMyConveyorEndpointBlock GetConveyorEndpointBlock(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.IMyConveyorEndpointBlock |     |

#### GetElectricalGridsGroups()

##### Declaration

```
public List<List<long>> GetElectricalGridsGroups()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Collections.Generic.List<System.Int64\>> |     |

#### GetElectricalGroupIndex(ref MyDefinitionId, MyCubeGrid)

##### Declaration

```
public int GetElectricalGroupIndex(ref MyDefinitionId typeId, MyCubeGrid grid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | typeId |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | grid |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetSourceCount(MyDefinitionId, MyStringHash)

##### Declaration

```
public int GetSourceCount(MyDefinitionId resourceTypeId, MyStringHash sourceGroupType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | sourceGroupType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IsConveyorConnectionRequiredTotal(MyDefinitionId)

##### Declaration

```
public static bool IsConveyorConnectionRequiredTotal(MyDefinitionId typeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | typeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsConveyorConnectionRequiredTotal(ref MyDefinitionId)

##### Declaration

```
public static bool IsConveyorConnectionRequiredTotal(ref MyDefinitionId typeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | typeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MarkConveyoredResourcesDirty()

##### Declaration

```
public void MarkConveyoredResourcesDirty()
```

#### MarkForUpdate()

##### Declaration

```
public void MarkForUpdate()
```

#### MaxAvailableResourceByType(MyDefinitionId, MyCubeGrid)

##### Declaration

```
public float MaxAvailableResourceByType(MyDefinitionId resourceTypeId, MyCubeGrid grid = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | grid |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxAvailableResourceByType(MyDefinitionId, IMyCubeGrid)

##### Declaration

```
public float MaxAvailableResourceByType(MyDefinitionId resourceTypeId, IMyCubeGrid grid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | grid |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### PowerStateIsOk(MyResourceStateEnum)

##### Declaration

```
protected bool PowerStateIsOk(MyResourceStateEnum state)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.MyResourceStateEnum | state |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PowerStateWorks(MyResourceStateEnum)

##### Declaration

```
protected bool PowerStateWorks(MyResourceStateEnum state)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.MyResourceStateEnum | state |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RecomputeResourceDistribution(ref MyDefinitionId, Boolean)

##### Declaration

```
public void RecomputeResourceDistribution(ref MyDefinitionId typeId, bool updateChanges = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | typeId |     |
| System.Boolean | updateChanges |     |

#### RemainingFuelTimeByType(MyDefinitionId, MyCubeGrid)

Specify grid when asking for electricity.

##### Declaration

```
public float RemainingFuelTimeByType(MyDefinitionId resourceTypeId, MyCubeGrid grid = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | grid |     |
