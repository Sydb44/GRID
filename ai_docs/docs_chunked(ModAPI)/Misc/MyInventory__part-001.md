---
title: "Class MyInventory"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html"
category: "Misc"
namespace: "Sandbox.Game"
class: "MyInventory"
---

# Class MyInventory | Space Engineers ModAPI

##### Inheritance

System.Object

MyInventory

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentBuilder]
[StaticEventOwner]
public class MyInventory : MyInventoryBase, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyInventory, IMyInventory
```

### Constructors

#### MyInventory()

##### Declaration

#### MyInventory(Single, Single, Vector3, MyInventoryFlags)

##### Declaration

```
public MyInventory(float maxVolume, float maxMass, Vector3 size, MyInventoryFlags flags)
```

##### Parameters

Type

Name

Description

System.Single

maxVolume

System.Single

maxMass

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

size

[MyInventoryFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyInventoryFlags.html)

flags

#### MyInventory(Single, Vector3, MyInventoryFlags)

##### Declaration

```
public MyInventory(float maxVolume, Vector3 size, MyInventoryFlags flags)
```

##### Parameters

Type

Name

Description

System.Single

maxVolume

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

size

[MyInventoryFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyInventoryFlags.html)

flags

#### MyInventory(MyObjectBuilder\_InventoryDefinition, MyInventoryFlags)

##### Declaration

```
public MyInventory(MyObjectBuilder_InventoryDefinition definition, MyInventoryFlags flags)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_InventoryDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_InventoryDefinition.html)

definition

[MyInventoryFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyInventoryFlags.html)

flags

#### MyInventory(MyFixedPoint, MyFixedPoint, MyInventoryFlags, List<MyPhysicalInventoryItem>)

##### Declaration

```
public MyInventory(MyFixedPoint maxVolume, MyFixedPoint maxMass, MyInventoryFlags flags, List<MyPhysicalInventoryItem> initialInventory)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

maxVolume

VRage.MyFixedPoint

maxMass

[MyInventoryFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyInventoryFlags.html)

flags

System.Collections.Generic.List<[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html)\>

initialInventory

#### MyInventory(MyFixedPoint, MyFixedPoint, Vector3, MyInventoryFlags)

##### Declaration

```
public MyInventory(MyFixedPoint maxVolume, MyFixedPoint maxMass, Vector3 size, MyInventoryFlags flags)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

maxVolume

VRage.MyFixedPoint

maxMass

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

size

[MyInventoryFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyInventoryFlags.html)

flags

### Fields

#### Constraint

Constraint filtering items added to inventory. If null, everything is allowed. Note that setting this constraint will not affect items already in the inventory.

##### Declaration

```
public MyInventoryConstraint Constraint
```

##### Field Value

Type

Description

[MyInventoryConstraint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventoryConstraint.html)

#### ExternalMass

##### Declaration

```
public MyFixedPoint ExternalMass
```

##### Field Value

Type

Description

VRage.MyFixedPoint

#### INVENTORY\_CHANGED

##### Declaration

```
public static MyStringHash INVENTORY_CHANGED
```

##### Field Value

Type

Description

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

#### SyncType

##### Declaration

```
public readonly SyncType SyncType
```

##### Field Value

Type

Description

VRage.Sync.SyncType

#### UserData

Any attached data..

##### Declaration

##### Field Value

Type

Description

System.Object

### Properties

#### CargoPercentage

Returns a value in the range \[0,1\] that indicates how full this inventory is. 0 is empty 1 is full If there are no cargo constraints, will return empty

##### Declaration

```
public float CargoPercentage { get; }
```

##### Property Value

Type

Description

System.Single

#### CurrentMass

##### Declaration

```
public override MyFixedPoint CurrentMass { get; }
```

##### Property Value

Type

Description

VRage.MyFixedPoint

##### Overrides

#### CurrentVolume

##### Declaration

```
public override MyFixedPoint CurrentVolume { get; }
```

##### Property Value

Type

Description

VRage.MyFixedPoint

##### Overrides

#### ForcedPriority

##### Declaration

```
public override Nullable<float> ForcedPriority { get; set; }
```

##### Property Value

Type

Description

System.Nullable<System.Single\>

##### Overrides

#### InventoryIdx

##### Declaration

```
public byte InventoryIdx { get; }
```

##### Property Value

Type

Description

System.Byte

#### IsCharacterOwner

##### Declaration

```
public bool IsCharacterOwner { get; }
```

##### Property Value

Type

Description

System.Boolean

#### IsConstrained

##### Declaration

```
public bool IsConstrained { get; }
```

##### Property Value

Type

Description

System.Boolean

#### IsFull

##### Declaration

```
public bool IsFull { get; }
```

##### Property Value

Type

Description

System.Boolean

#### ItemCount

##### Declaration

```
public int ItemCount { get; }
```

##### Property Value

Type

Description

System.Int32
