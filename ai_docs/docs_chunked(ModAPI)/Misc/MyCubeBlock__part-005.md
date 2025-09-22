[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)

detachedEntity

#### OnCubeGridChanged(MyCubeGrid)

Notifies about grid change with old grid in parameter (new grid is available in property).

##### Declaration

```
public virtual void OnCubeGridChanged(MyCubeGrid oldGrid)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

oldGrid

#### OnDestroy()

Called when block is destroyed before being removed from grid

##### Declaration

```
public virtual void OnDestroy()
```

#### OnInventoryComponentAdded(MyInventoryBase)

##### Declaration

```
protected override void OnInventoryComponentAdded(MyInventoryBase inventory)
```

##### Parameters

Type

Name

Description

[MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html)

inventory

##### Overrides

#### OnInventoryComponentRemoved(MyInventoryBase)

##### Declaration

```
protected override void OnInventoryComponentRemoved(MyInventoryBase inventory)
```

##### Parameters

Type

Name

Description

[MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html)

inventory

##### Overrides

#### OnModelChange()

Called when the model referred by the block is changed

##### Declaration

```
public virtual void OnModelChange()
```

#### OnOwnershipChanged()

##### Declaration

```
protected virtual void OnOwnershipChanged()
```

#### OnRegisteredToGridSystems()

Called at the end of registration from grid systems (after block has been registered).

##### Declaration

```
public virtual void OnRegisteredToGridSystems()
```

#### OnRemovedByCubeBuilder()

Method called when user removes a cube block from grid. Useful when block has to remove some other attached block (like motors).

##### Declaration

```
public virtual void OnRemovedByCubeBuilder()
```

#### OnRemovedFromScene(Object)

##### Declaration

```
public override void OnRemovedFromScene(object source)
```

##### Parameters

Type

Name

Description

System.Object

source

##### Overrides

#### OnSubBlockClosing(MySlimBlock)

##### Declaration

```
protected void OnSubBlockClosing(MySlimBlock subBlock)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

subBlock

#### OnTeleport()

##### Declaration

```
public virtual void OnTeleport()
```

#### OnUnregisteredFromGridSystems()

Called at the end of unregistration from grid systems (after block has been unregistered).

##### Declaration

```
public virtual void OnUnregisteredFromGridSystems()
```

#### ReceivedDamage(Single, MyStringHash, Int64, Int64, Boolean, Nullable<MyStringHash>)

Block received damage from any source.

##### Declaration

```
public virtual bool ReceivedDamage(float damage, MyStringHash damageType, long attackerId, long realHitEntityId, bool shouldDetonateAmmo = true, Nullable<MyStringHash> extraInfo = null)
```

##### Parameters

Type

Name

Description

System.Single

damage

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

damageType

System.Int64

attackerId

System.Int64

realHitEntityId

System.Boolean

shouldDetonateAmmo

System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\>

extraInfo

##### Returns

Type

Description

System.Boolean

Returns true if damage should be inflicted upon the block normally.

#### RefreshModels(String, String)

##### Declaration

```
public override void RefreshModels(string modelPath, string modelCollisionPath)
```

##### Parameters

Type

Name

Description

System.String

modelPath

System.String

modelCollisionPath

##### Overrides

#### ReleaseInventory(MyInventory, Boolean)

##### Declaration

```
public void ReleaseInventory(MyInventory inventory, bool damageContent = false)
```

##### Parameters

Type

Name

Description

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

inventory

System.Boolean

damageContent

#### RemoveEffect(String, Int32)

##### Declaration

```
public int RemoveEffect(string effectName, int exception = -1)
```

##### Parameters

Type

Name

Description

System.String

effectName

System.Int32

exception

##### Returns

Type

Description

System.Int32

#### RemoveSubBlock(String, Boolean)

Removes subblock with the given name from the block.

##### Declaration

```
protected bool RemoveSubBlock(string subBlockName, bool removeFromGrid = true)
```

##### Parameters

Type

Name

Description

System.String

subBlockName

System.Boolean

removeFromGrid

##### Returns

Type

Description

System.Boolean

#### SetDamageEffect(Boolean)

##### Declaration

```
public virtual void SetDamageEffect(bool show)
```

##### Parameters

Type

Name

Description

System.Boolean

show

#### SetDamageEffectDelayed(Boolean)

##### Declaration

```
public void SetDamageEffectDelayed(bool show)
```

##### Parameters

Type

Name

Description

System.Boolean

show

#### SetEffect(String, Boolean)

##### Declaration

```
public bool SetEffect(string effectName, bool stopPrevious = false)
```

##### Parameters

Type

Name

Description

System.String

effectName

System.Boolean

stopPrevious

##### Returns

Type

Description

System.Boolean

#### SetEffect(String, Single, Boolean, Boolean, Boolean)

##### Declaration

```
public bool SetEffect(string effectName, float parameter, bool stopPrevious = false, bool ignoreParameter = false, bool removeSameNameEffects = false)
```

##### Parameters

Type

Name

Description

System.String

effectName

System.Single

parameter

System.Boolean

stopPrevious

System.Boolean

ignoreParameter

System.Boolean

removeSameNameEffects

##### Returns

Type

Description

System.Boolean

#### SetEmissiveState(MyStringHash, UInt32, String)

##### Declaration

```
public bool SetEmissiveState(MyStringHash state, uint renderObjectId, string namedPart = null)
```
