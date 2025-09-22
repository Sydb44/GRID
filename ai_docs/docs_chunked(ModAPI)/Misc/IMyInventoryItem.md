---
title: "Interface IMyInventoryItem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventoryItem.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame"
class: "IMyInventoryItem"
---

# Interface IMyInventoryItem | Space Engineers ModAPI

Describes item stack in inventory (program block interface)

###### **Namespace**: [VRage.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyInventoryItem
```

### Properties

#### Amount

Gets or sets amount of items

##### Declaration

```
MyFixedPoint Amount { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

#### Content

##### Declaration

```
MyObjectBuilder_Base Content { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) |     |

#### ItemId

Item Id. Used to determine exact stack

##### Declaration

```
uint ItemId { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### Scale

Gets or sets scale of Floating object

##### Declaration

```
float Scale { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Extension Methods