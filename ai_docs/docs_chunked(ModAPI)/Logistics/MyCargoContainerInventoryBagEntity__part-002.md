##### Declaration

```
public void SendCloseRequest()
```

#### UpdateAfterSimulation100()

##### Declaration

```
public override void UpdateAfterSimulation100()
```

##### Overrides

#### UpdateAfterSimulationParallel()

##### Declaration

```
public void UpdateAfterSimulationParallel()
```

#### UpdateBeforeSimulationParallel()

##### Declaration

```
public void UpdateBeforeSimulationParallel()
```

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

### Explicit Interface Implementations

#### IMyDestroyableObject.DoDamage(Single, MyStringHash, Boolean, Nullable<MyHitInfo>, Int64, Int64, Boolean, Nullable<MyStringHash>)

##### Declaration

```
bool IMyDestroyableObject.DoDamage(float damage, MyStringHash damageType, bool sync, Nullable<MyHitInfo> hitInfo, long attackerId, long realHitEntityId, bool shouldDetonateAmmo, Nullable<MyStringHash> extraInfo)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | damage |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | damageType |     |
| System.Boolean | sync |     |
| System.Nullable<[MyHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyHitInfo.html)\> | hitInfo |     |
| System.Int64 | attackerId |     |
| System.Int64 | realHitEntityId |     |
| System.Boolean | shouldDetonateAmmo |     |
| System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\> | extraInfo |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyDestroyableObject.Integrity

##### Declaration

```
float IMyDestroyableObject.Integrity { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyDestroyableObject.UseDamageSystem

##### Declaration

```
bool IMyDestroyableObject.UseDamageSystem { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Implements

### Extension Methods