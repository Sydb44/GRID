---
title: "Class MyObjectBuilder\\_InventoryItem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_InventoryItem.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_InventoryItem"
---

# Class MyObjectBuilder\_InventoryItem | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_InventoryItem

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_InventoryItem : MyObjectBuilder_Base
```

### Constructors

#### MyObjectBuilder\_InventoryItem()

##### Declaration

```
public MyObjectBuilder_InventoryItem()
```

### Fields

#### Amount

##### Declaration

```
public MyFixedPoint Amount
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

#### Content

Obsolete. It is here only to keep backwards compatibility with old saves. Nulls content when unsupported.

##### Declaration

```
[DynamicObjectBuilder(false)]
[Serialize]
public MyObjectBuilder_PhysicalObject Content
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html) |     |

#### ItemId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### PhysicalContent

##### Declaration

```
[DynamicObjectBuilder(false)]
[Serialize]
public MyObjectBuilder_PhysicalObject PhysicalContent
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html) |     |

#### Scale

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Properties

#### Obsolete\_AmountDecimal

##### Declaration

```
[NoSerialize]
public Decimal Obsolete_AmountDecimal { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Decimal |     |

### Methods

#### ShouldSerializeContent()

##### Declaration

```
public bool ShouldSerializeContent()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeObsolete\_AmountDecimal()

##### Declaration

```
public bool ShouldSerializeObsolete_AmountDecimal()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeScale()

##### Declaration

```
public bool ShouldSerializeScale()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods