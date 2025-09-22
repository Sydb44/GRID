---
title: "Class MyObjectBuilder\\_ProductionBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_ProductionBlock.html"
category: "Production"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_ProductionBlock"
---

# Class MyObjectBuilder\_ProductionBlock | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_ProductionBlock

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public abstract class MyObjectBuilder_ProductionBlock : MyObjectBuilder_FunctionalBlock
```

### Constructors

#### MyObjectBuilder\_ProductionBlock()

##### Declaration

```
protected MyObjectBuilder_ProductionBlock()
```

### Fields

#### InputInventory

##### Declaration

```
[Nullable]
public MyObjectBuilder_Inventory InputInventory
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Inventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Inventory.html) |     |

#### NextItemId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### OutputInventory

##### Declaration

```
[Nullable]
public MyObjectBuilder_Inventory OutputInventory
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Inventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Inventory.html) |     |

#### Queue

##### Declaration

```
[Serialize]
public MyObjectBuilder_ProductionBlock.QueueItem[] Queue
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ProductionBlock.QueueItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_ProductionBlock.QueueItem.html)\[\] |     |

#### UseConveyorSystem

##### Declaration

```
public bool UseConveyorSystem
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

#### Inventory

Don't use. Backward compatibility only. Use InputInventory and OutputInventory instead.

##### Declaration

```
[Nullable]
public MyObjectBuilder_Inventory Inventory { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Inventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Inventory.html) |     |

### Methods

#### SetupForProjector()

##### Declaration

```
public override void SetupForProjector()
```

##### Overrides

#### ShouldSerializeInventory()

##### Declaration

```
public bool ShouldSerializeInventory()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods