
```
public void ApplyDamage(float damage, MyConstructionStockpile outputStockpile = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | damage |     |
| [MyConstructionStockpile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyConstructionStockpile.html) | outputStockpile |     |

#### CanContinueBuild(MyInventoryBase, MyConstructionStockpile)

##### Declaration

```
public bool CanContinueBuild(MyInventoryBase inventory, MyConstructionStockpile stockpile)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html) | inventory |     |
| [MyConstructionStockpile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyConstructionStockpile.html) | stockpile |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DecreaseMountLevel(Single, MyConstructionStockpile, Boolean)

Dismounts component stack, dismounted items are put into output stockpile

##### Declaration

```
public void DecreaseMountLevel(float unmountAmount, MyConstructionStockpile outputStockpile = null, bool useDefaultDeconstructEfficiency = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | unmountAmount |     |
| [MyConstructionStockpile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyConstructionStockpile.html) | outputStockpile |     |
| System.Boolean | useDefaultDeconstructEfficiency |     |

#### DestroyCompletely()

##### Declaration

```
public void DestroyCompletely()
```

#### DisableLastComponentYield()

##### Declaration

```
public void DisableLastComponentYield()
```

#### GetAllMissingComponents(Dictionary<String, Int32>)

##### Declaration

```
public void GetAllMissingComponents(Dictionary<string, int> addToDictionary)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Int32\> | addToDictionary |     |

#### GetComponentStackInfo(Int32)

##### Declaration

```
public MyComponentStackInfo GetComponentStackInfo(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyComponentStackInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyComponentStackInfo.html) |     |

#### GetGroupInfo(Int32)

##### Declaration

```
public MyComponentStack.GroupInfo GetGroupInfo(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyComponentStack.GroupInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyComponentStack.GroupInfo.html) |     |

#### GetMissingComponents(Dictionary<String, Int32>, MyConstructionStockpile)

##### Declaration

```
public void GetMissingComponents(Dictionary<string, int> addToDictionary, MyConstructionStockpile availableItems = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Int32\> | addToDictionary |     |
| [MyConstructionStockpile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyConstructionStockpile.html) | availableItems |     |

#### GetMissingInfo(out Int32, out Int32)

##### Declaration

```
public void GetMissingInfo(out int groupIndex, out int componentCount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | groupIndex |     |
| System.Int32 | componentCount |     |

#### GetMountedComponents(MyComponentList, MyObjectBuilder\_CubeBlock)

##### Declaration

```
public static void GetMountedComponents(MyComponentList addToList, MyObjectBuilder_CubeBlock block)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Entities.Cube.MyComponentList | addToList |     |
| [MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html) | block |     |

#### IncreaseMountLevel(Single, MyConstructionStockpile)

##### Declaration

```
public void IncreaseMountLevel(float mountAmount, MyConstructionStockpile stockpile = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | mountAmount |     |
| [MyConstructionStockpile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyConstructionStockpile.html) | stockpile |     |

#### UpdateBuildIntegrityDown(Single)

##### Declaration

```
public void UpdateBuildIntegrityDown(float ratio)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | ratio |     |

#### UpdateBuildIntegrityUp()

##### Declaration

```
public void UpdateBuildIntegrityUp()
```

#### WillFunctionalityRise(Single)

##### Declaration

```
public Nullable<bool> WillFunctionalityRise(float mountAmount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | mountAmount | How much integrity changes |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Boolean\> | Null if no change, true if block will become functional, false if block stops being functional |

### Events

#### IsFunctionalChanged

##### Declaration

```
public event Action IsFunctionalChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

### Explicit Interface Implementations

#### IMyComponentStack.IntegrityChanged

##### Declaration

```
event Action<IMyComponentStack, float, float> IMyComponentStack.IntegrityChanged
```

##### Returns

| Type | Description |
| --- | --- |
| System.Action<[IMyComponentStack](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyComponentStack.html), System.Single, System.Single\> |     |
