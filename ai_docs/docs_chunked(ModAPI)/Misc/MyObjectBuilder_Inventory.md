---
title: "Class MyObjectBuilder\\_Inventory"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Inventory.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_Inventory"
---

# Class MyObjectBuilder\_Inventory | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Inventory

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_Inventory : MyObjectBuilder_InventoryBase
```

### Constructors

#### MyObjectBuilder\_Inventory()

##### Declaration

```
public MyObjectBuilder_Inventory()
```

### Fields

#### InventoryFlags

##### Declaration

```
public Nullable<MyInventoryFlags> InventoryFlags
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[MyInventoryFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyInventoryFlags.html)\> |     |

#### Items

##### Declaration

```
public List<MyObjectBuilder_InventoryItem> Items
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_InventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_InventoryItem.html)\> |     |

#### Mass

##### Declaration

```
public Nullable<MyFixedPoint> Mass
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.MyFixedPoint\> |     |

#### MaxItemCount

##### Declaration

```
public Nullable<int> MaxItemCount
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int32\> |     |

#### nextItemId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### RemoveEntityOnEmpty

##### Declaration

```
public bool RemoveEntityOnEmpty
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Size

##### Declaration

```
public Nullable<SerializableVector3> Size
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.SerializableVector3\> |     |

#### Volume

##### Declaration

```
public Nullable<MyFixedPoint> Volume
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.MyFixedPoint\> |     |

### Methods

#### Clear()

##### Declaration

```
public override void Clear()
```

##### Overrides

#### ShouldSerializeMaxItemCount()

##### Declaration

```
public bool ShouldSerializeMaxItemCount()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods