spawn

System.Nullable<[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)\>

spawnPos

System.Action<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html), [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

itemSpawned

System.Boolean

refreshVolumeAndMass

#### RemoveItemsAt(Int32, Nullable<MyFixedPoint>, Boolean, Boolean, Boolean)

##### Declaration

```
public void RemoveItemsAt(int itemIndex, Nullable<MyFixedPoint> amount = null, bool sendEvent = true, bool spawn = false, bool refreshVolumeAndMass = true)
```

##### Parameters

Type

Name

Description

System.Int32

itemIndex

System.Nullable<VRage.MyFixedPoint\>

amount

System.Boolean

sendEvent

System.Boolean

spawn

System.Boolean

refreshVolumeAndMass

#### RemoveItemsOfType(MyFixedPoint, MyDefinitionId, MyItemFlags, Boolean)

##### Declaration

```
public override MyFixedPoint RemoveItemsOfType(MyFixedPoint amount, MyDefinitionId contentId, MyItemFlags flags, bool spawn = false)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

contentId

[MyItemFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyItemFlags.html)

flags

System.Boolean

spawn

##### Returns

Type

Description

VRage.MyFixedPoint

##### Overrides

#### RemoveItemsOfType(MyFixedPoint, MyObjectBuilder\_PhysicalObject, Boolean, Boolean)

##### Declaration

```
public bool RemoveItemsOfType(MyFixedPoint amount, MyObjectBuilder_PhysicalObject objectBuilder, bool spawn = false, bool onlyWhole = true)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html)

objectBuilder

System.Boolean

spawn

System.Boolean

onlyWhole

##### Returns

Type

Description

System.Boolean

#### ResetVolume()

##### Declaration

```
public void ResetVolume()
```

#### Serialize(Boolean)

##### Declaration

```
public override MyObjectBuilder_ComponentBase Serialize(bool copy = false)
```

##### Parameters

Type

Name

Description

System.Boolean

copy

##### Returns

Type

Description

[MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html)

##### Overrides

#### SetFlags(MyInventoryFlags)

##### Declaration

```
public void SetFlags(MyInventoryFlags flags)
```

##### Parameters

Type

Name

Description

[MyInventoryFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyInventoryFlags.html)

flags

#### ShowCantConsume()

##### Declaration

```
[Event(null, 2430)]
[Reliable]
[Client]
public static void ShowCantConsume()
```

#### TakeFloatingBag(MyCargoContainerInventoryBagEntity)

##### Declaration

```
public void TakeFloatingBag(MyCargoContainerInventoryBagEntity obj)
```

##### Parameters

Type

Name

Description

[MyCargoContainerInventoryBagEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCargoContainerInventoryBagEntity.html)

obj

#### TakeFloatingObject(MyFloatingObject)

##### Declaration

```
public void TakeFloatingObject(MyFloatingObject obj)
```

##### Parameters

Type

Name

Description

[MyFloatingObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyFloatingObject.html)

obj

#### Transfer(MyInventory, MyInventory, UInt32, Int32, Nullable<MyFixedPoint>, Boolean)

##### Declaration

```
public static MyFixedPoint Transfer(MyInventory src, MyInventory dst, uint srcItemId, int dstIdx = -1, Nullable<MyFixedPoint> amount = null, bool spawn = false)
```

##### Parameters

Type

Name

Description

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

src

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

dst

System.UInt32

srcItemId

System.Int32

dstIdx

System.Nullable<VRage.MyFixedPoint\>

amount

System.Boolean

spawn

##### Returns

Type

Description

VRage.MyFixedPoint

#### Transfer(MyInventory, MyInventory, MyDefinitionId, MyItemFlags, Nullable<MyFixedPoint>, Boolean)

##### Declaration

```
public static MyFixedPoint Transfer(MyInventory src, MyInventory dst, MyDefinitionId contentId, MyItemFlags flags, Nullable<MyFixedPoint> amount = null, bool spawn = false)
```

##### Parameters

Type

Name

Description

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

src

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

dst

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

contentId

[MyItemFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyItemFlags.html)

flags

System.Nullable<VRage.MyFixedPoint\>

amount

System.Boolean

spawn

##### Returns

Type

Description

VRage.MyFixedPoint

#### TransferAll(MyInventory, MyInventory)

##### Declaration

```
public static void TransferAll(MyInventory src, MyInventory dst)
```

##### Parameters

Type

Name

Description

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

src

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

dst

#### TransferByPlanner(MyInventory, MyInventory, SerializableDefinitionId, MyItemFlags, Nullable<MyFixedPoint>, Boolean)

##### Declaration

```
public static void TransferByPlanner(MyInventory src, MyInventory dst, SerializableDefinitionId contentId, MyItemFlags flags, Nullable<MyFixedPoint> amount = null, bool spawn = false)
```
