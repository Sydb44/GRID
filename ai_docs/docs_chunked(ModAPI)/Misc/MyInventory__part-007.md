src

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

dst

#### TransferByPlanner(MyInventory, MyInventory, SerializableDefinitionId, MyItemFlags, Nullable<MyFixedPoint>, Boolean)

##### Declaration

```
public static void TransferByPlanner(MyInventory src, MyInventory dst, SerializableDefinitionId contentId, MyItemFlags flags, Nullable<MyFixedPoint> amount = null, bool spawn = false)
```

##### Parameters

Type

Name

Description

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

src

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

dst

[SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html)

contentId

[MyItemFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyItemFlags.html)

flags

System.Nullable<VRage.MyFixedPoint\>

amount

System.Boolean

spawn

#### TransferByUser(MyInventory, MyInventory, UInt32, Int32, Nullable<MyFixedPoint>)

##### Declaration

```
public static void TransferByUser(MyInventory src, MyInventory dst, uint srcItemId, int dstIdx = -1, Nullable<MyFixedPoint> amount = null)
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

#### TransferItemFrom(MyInventory, Int32, Nullable<Int32>, Nullable<Boolean>, Nullable<MyFixedPoint>)

##### Declaration

```
public void TransferItemFrom(MyInventory sourceInventory, int sourceItemIndex, Nullable<int> targetItemIndex = null, Nullable<bool> stackIfPossible = null, Nullable<MyFixedPoint> amount = null)
```

##### Parameters

Type

Name

Description

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

sourceInventory

System.Int32

sourceItemIndex

System.Nullable<System.Int32\>

targetItemIndex

System.Nullable<System.Boolean\>

stackIfPossible

System.Nullable<VRage.MyFixedPoint\>

amount

#### TryConsumeItem(MyCharacter, MyInventory, MyDefinitionId, out Boolean, Boolean)

##### Declaration

```
public static bool TryConsumeItem(MyCharacter character, MyInventory inventory, MyDefinitionId itemId, out bool available, bool showNotification = true)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Character.MyCharacter

character

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

inventory

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

System.Boolean

available

System.Boolean

showNotification

##### Returns

Type

Description

System.Boolean

#### TryTransferAll(MyInventory, MyInventory)

##### Declaration

```
public static bool TryTransferAll(MyInventory src, MyInventory dst)
```

##### Parameters

Type

Name

Description

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

src

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

dst

##### Returns

Type

Description

System.Boolean

#### UpdateItem(MyDefinitionId, Nullable<UInt32>, Nullable<Single>, Nullable<Single>)

##### Declaration

```
public void UpdateItem(MyDefinitionId contentId, Nullable<uint> itemId = null, Nullable<float> amount = null, Nullable<float> itemHP = null)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

contentId

System.Nullable<System.UInt32\>

itemId

System.Nullable<System.Single\>

amount

System.Nullable<System.Single\>

itemHP

#### UpdateItemAmoutClient(UInt32, MyFixedPoint, Single)

##### Declaration

```
public void UpdateItemAmoutClient(uint itemId, MyFixedPoint amount, float gasAmount)
```

##### Parameters

Type

Name

Description

System.UInt32

itemId

VRage.MyFixedPoint

amount

System.Single

gasAmount

### Events

#### OnTransferByUser

##### Declaration

```
public static event Action<IMyInventory, IMyInventory, IMyInventoryItem, MyFixedPoint> OnTransferByUser
```

##### Event Type

Type

Description

System.Action<[IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html), [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html), [IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventoryItem.html), VRage.MyFixedPoint\>

#### OnVolumeChanged

##### Declaration

```
public event Action<IMyInventory, float, float> OnVolumeChanged
```

##### Event Type

Type

Description

System.Action<[IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventory.html), System.Single, System.Single\>

### Explicit Interface Implementations

#### IMyInventory.AddItems(MyFixedPoint, MyObjectBuilder\_PhysicalObject, Int32)

##### Declaration

```
void IMyInventory.AddItems(MyFixedPoint amount, MyObjectBuilder_PhysicalObject objectBuilder, int index)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html)

objectBuilder

System.Int32

index

#### IMyInventory.CanAddItemAmount(IMyInventoryItem, MyFixedPoint)

##### Declaration

```
bool IMyInventory.CanAddItemAmount(IMyInventoryItem item, MyFixedPoint amount)
```

##### Parameters

Type

Name

Description

[IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventoryItem.html)

item

VRage.MyFixedPoint

amount
