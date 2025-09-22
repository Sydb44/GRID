---
title: "Class MyPhysicalInventoryItem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html"
category: "Misc"
namespace: "VRage.Game.Entity"
class: "MyPhysicalInventoryItem"
---

# Class MyPhysicalInventoryItem | Space Engineers ModAPI

Implements physical item data

##### Inheritance

System.Object

MyPhysicalInventoryItem

##### Implements

###### **Namespace**: [VRage.Game.Entity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyPhysicalInventoryItem : ValueType, IMyInventoryItem, IMyInventoryItem
```

### [](#constructors)Constructors

#### [](#VRage_Game_Entity_MyPhysicalInventoryItem__ctor_VRage_Game_MyObjectBuilder_InventoryItem_)MyPhysicalInventoryItem(MyObjectBuilder\_InventoryItem)

##### Declaration

```
public MyPhysicalInventoryItem(MyObjectBuilder_InventoryItem item)
```

##### Parameters

#### [](#VRage_Game_Entity_MyPhysicalInventoryItem__ctor_VRage_MyFixedPoint_VRage_Game_MyObjectBuilder_PhysicalObject_System_Single_)MyPhysicalInventoryItem(MyFixedPoint, MyObjectBuilder\_PhysicalObject, Single)

##### Declaration

```
public MyPhysicalInventoryItem(MyFixedPoint amount, MyObjectBuilder_PhysicalObject content, float scale = 1F)
```

##### Parameters

### [](#fields)Fields

#### [](#VRage_Game_Entity_MyPhysicalInventoryItem_Amount)Amount

##### Declaration

```
public MyFixedPoint Amount
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

#### [](#VRage_Game_Entity_MyPhysicalInventoryItem_ItemId)ItemId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### [](#VRage_Game_Entity_MyPhysicalInventoryItem_Scale)Scale

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### [](#properties)Properties

#### [](#VRage_Game_Entity_MyPhysicalInventoryItem_Content)Content

##### Declaration

```
[DynamicObjectBuilder(false)]
public MyObjectBuilder_PhysicalObject Content { get; set; }
```

##### Property Value

### [](#methods)Methods

#### [](#VRage_Game_Entity_MyPhysicalInventoryItem_GetObjectBuilder)GetObjectBuilder()

##### Declaration

```
public MyObjectBuilder_InventoryItem GetObjectBuilder()
```

##### Returns

#### [](#VRage_Game_Entity_MyPhysicalInventoryItem_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### [](#eii)Explicit Interface Implementations

#### [](#VRage_Game_Entity_MyPhysicalInventoryItem_VRage_Game_ModAPI_Ingame_IMyInventoryItem_Amount)IMyInventoryItem.Amount

Gets or Sets Amount

##### Declaration

```
MyFixedPoint IMyInventoryItem.Amount { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

#### [](#VRage_Game_Entity_MyPhysicalInventoryItem_VRage_Game_ModAPI_Ingame_IMyInventoryItem_Content)IMyInventoryItem.Content

Gets or Sets Content

##### Declaration

```
MyObjectBuilder_Base IMyInventoryItem.Content { get; set; }
```

##### Returns

#### [](#VRage_Game_Entity_MyPhysicalInventoryItem_VRage_Game_ModAPI_Ingame_IMyInventoryItem_ItemId)IMyInventoryItem.ItemId

Gets or Sets Item Id

##### Declaration

```
uint IMyInventoryItem.ItemId { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### [](#VRage_Game_Entity_MyPhysicalInventoryItem_VRage_Game_ModAPI_Ingame_IMyInventoryItem_Scale)IMyInventoryItem.Scale

Gets or Sets Scale

##### Declaration

```
float IMyInventoryItem.Scale { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

### [](#implements)Implements