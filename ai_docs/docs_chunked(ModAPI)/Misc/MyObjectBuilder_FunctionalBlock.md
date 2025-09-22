---
title: "Class MyObjectBuilder\\_FunctionalBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_FunctionalBlock.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_FunctionalBlock"
---

# Class MyObjectBuilder\_FunctionalBlock | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_FunctionalBlock

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_FunctionalBlock : MyObjectBuilder_TerminalBlock
```

### Constructors

#### MyObjectBuilder\_FunctionalBlock()

##### Declaration

```
public MyObjectBuilder_FunctionalBlock()
```

### Fields

#### Enabled

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TextPanelsNew

##### Declaration

```
[Serialize]
public List<MySerializedTextPanelData> TextPanelsNew
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MySerializedTextPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MySerializedTextPanelData.html)\> |     |

### Methods

#### GetTextPanelsData()

Used to get correct TextPanel stored data. v199- using `TextPanels` and v200+ using `TextPanelsNew`. LCD data should be saved into `TextPanelsNew`, but readed from TextPanels if it is not null.

##### Declaration

```
public virtual List<MySerializedTextPanelData> GetTextPanelsData()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MySerializedTextPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MySerializedTextPanelData.html)\> |     |

### Extension Methods