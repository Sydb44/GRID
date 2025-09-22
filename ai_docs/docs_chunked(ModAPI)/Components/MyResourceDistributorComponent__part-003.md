
##### Declaration

```
public float RemainingFuelTimeByType(MyDefinitionId resourceTypeId, MyCubeGrid grid = null)
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

#### RemoveSink(MyResourceSinkComponent, Boolean, Boolean)

##### Declaration

```
public void RemoveSink(MyResourceSinkComponent sink, bool resetSinkInput = true, bool markedForClose = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyResourceSinkComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSinkComponent.html) | sink |     |
| System.Boolean | resetSinkInput |     |
| System.Boolean | markedForClose |     |

#### RemoveSource(MyResourceSourceComponent)

##### Declaration

```
public void RemoveSource(MyResourceSourceComponent source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyResourceSourceComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSourceComponent.html) | source |     |

#### ResourceStateByType(MyDefinitionId, Boolean, MyCubeGrid)

Specify grid when asking for electricity. Electricity is shared only between certain grids.

##### Declaration

```
public MyResourceStateEnum ResourceStateByType(MyDefinitionId typeId, bool withRecompute = true, MyCubeGrid grid = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | typeId |     |
| System.Boolean | withRecompute |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | grid |     |

##### Returns

| Type | Description |
| --- | --- |
| VRage.MyResourceStateEnum |     |

#### SetDataDirty(MyDefinitionId)

##### Declaration

```
public void SetDataDirty(MyDefinitionId typeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | typeId |     |

#### SetNeedRecompute(MyDefinitionId)

##### Declaration

```
public void SetNeedRecompute(MyDefinitionId typeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | typeId |     |

#### SetNeedRecomputeAll()

##### Declaration

```
public void SetNeedRecomputeAll()
```

#### SourcesEnabledByType(MyDefinitionId)

##### Declaration

```
public MyMultipleEnabledEnum SourcesEnabledByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| VRage.MyMultipleEnabledEnum |     |

#### TotalRequiredInputByType(MyDefinitionId, MyCubeGrid)

##### Declaration

```
public float TotalRequiredInputByType(MyDefinitionId resourceTypeId, MyCubeGrid grid = null)
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

#### TotalRequiredInputByType(MyDefinitionId, IMyCubeGrid)

##### Declaration

```
public float TotalRequiredInputByType(MyDefinitionId resourceTypeId, IMyCubeGrid grid)
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

#### UpdateBeforeSimulation()

##### Declaration

```
public void UpdateBeforeSimulation()
```

#### UpdateBeforeSimulation100()

##### Declaration

```
public virtual void UpdateBeforeSimulation100()
```

#### UpdateHud(MyHudSinkGroupInfo)

Computes number of groups that have enough energy to work.

##### Declaration

```
public void UpdateHud(MyHudSinkGroupInfo info)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Gui.MyHudSinkGroupInfo | info |     |

### Events

#### OnPowerGenerationChanged

##### Declaration

```
public event Action<bool> OnPowerGenerationChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Boolean\> |     |

#### SystemChanged

Event raised when any element of this system is changed, requiring the system to update.

##### Declaration

```
public event Action SystemChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

### Implements

### Extension Methods