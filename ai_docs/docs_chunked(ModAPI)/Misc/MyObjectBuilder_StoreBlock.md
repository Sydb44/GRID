---
title: "Class MyObjectBuilder\\_StoreBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_StoreBlock.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_StoreBlock"
---

# Class MyObjectBuilder\_StoreBlock | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_StoreBlock

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_StoreBlock : MyObjectBuilder_FunctionalBlock
```

### Constructors

#### MyObjectBuilder\_StoreBlock()

##### Declaration

```
public MyObjectBuilder_StoreBlock()
```

### Fields

#### AnyoneCanUse

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PlayerItems

##### Declaration

```
[Serialize]
public List<MyObjectBuilder_StoreItem> PlayerItems
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_StoreItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_StoreItem.html)\> |     |

#### TextPanels

##### Declaration

```
[Serialize]
public List<MySerializedTextPanelData> TextPanels
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MySerializedTextPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MySerializedTextPanelData.html)\> |     |

#### UseConveyorSystem

##### Declaration

```
public bool UseConveyorSystem
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetTextPanelsData()

##### Declaration

```
public override List<MySerializedTextPanelData> GetTextPanelsData()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MySerializedTextPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MySerializedTextPanelData.html)\> |     |

##### Overrides

### Extension Methods