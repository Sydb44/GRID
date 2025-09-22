#### OnInventoryComponentAdded(MyInventoryBase)

##### Declaration

```
protected override void OnInventoryComponentAdded(MyInventoryBase inventory)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html) | inventory |     |

##### Overrides

#### OnInventoryComponentRemoved(MyInventoryBase)

##### Declaration

```
protected override void OnInventoryComponentRemoved(MyInventoryBase inventory)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html) | inventory |     |

##### Overrides

#### UpdateAfterSimulation10()

##### Declaration

```
public override void UpdateAfterSimulation10()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.UpdateAfterSimulation10()

#### UpdateDetailedInfo(StringBuilder)

##### Declaration

```
protected override void UpdateDetailedInfo(StringBuilder detailedInfo)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | detailedInfo |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.UpdateDetailedInfo(System.Text.StringBuilder)

### Explicit Interface Implementations

#### IMyConveyorSorter.AddItem(MyInventoryItemFilter)

##### Declaration

```
void IMyConveyorSorter.AddItem(MyInventoryItemFilter item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryItemFilter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyInventoryItemFilter.html) | item |     |

#### IMyConveyorSorter.GetFilterList(List<MyInventoryItemFilter>)

##### Declaration

```
void IMyConveyorSorter.GetFilterList(List<MyInventoryItemFilter> items)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyInventoryItemFilter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyInventoryItemFilter.html)\> | items |     |

#### IMyConveyorSorter.Mode

##### Declaration

```
MyConveyorSorterMode IMyConveyorSorter.Mode { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [MyConveyorSorterMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyConveyorSorterMode.html) |     |

#### IMyConveyorSorter.RemoveItem(MyInventoryItemFilter)

##### Declaration

```
void IMyConveyorSorter.RemoveItem(MyInventoryItemFilter item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryItemFilter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyInventoryItemFilter.html) | item |     |

#### IMyConveyorSorter.SetFilter(MyConveyorSorterMode, List<MyInventoryItemFilter>)

##### Declaration

```
void IMyConveyorSorter.SetFilter(MyConveyorSorterMode mode, List<MyInventoryItemFilter> items)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyConveyorSorterMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyConveyorSorterMode.html) | mode |     |
| System.Collections.Generic.List<[MyInventoryItemFilter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyInventoryItemFilter.html)\> | items |     |

#### IMyInventoryOwner.EntityId

##### Declaration

```
long IMyInventoryOwner.EntityId { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### IMyInventoryOwner.GetInventory(Int32)

##### Declaration

```
IMyInventory IMyInventoryOwner.GetInventory(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html) |     |

#### IMyInventoryOwner.HasInventory

##### Declaration

```
bool IMyInventoryOwner.HasInventory { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyInventoryOwner.InventoryCount

##### Declaration

```
int IMyInventoryOwner.InventoryCount { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IMyInventoryOwner.UseConveyorSystem

##### Declaration

```
bool IMyInventoryOwner.UseConveyorSystem { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Implements

### Extension Methods