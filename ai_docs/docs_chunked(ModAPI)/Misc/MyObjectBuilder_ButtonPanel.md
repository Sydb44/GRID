---
title: "Class MyObjectBuilder\\_ButtonPanel"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_ButtonPanel.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_ButtonPanel"
---

# Class MyObjectBuilder\_ButtonPanel | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_ButtonPanel

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_ButtonPanel : MyObjectBuilder_FunctionalBlock
```

### Constructors

#### MyObjectBuilder\_ButtonPanel()

##### Declaration

```
public MyObjectBuilder_ButtonPanel()
```

### Fields

#### AnyoneCanUse

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CustomButtonNames

##### Declaration

```
[NoSerialize]
public SerializableDictionary<int, string> CustomButtonNames
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Serialization.SerializableDictionary<System.Int32, System.String\> |     |

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

#### Toolbar

##### Declaration

```
public MyObjectBuilder_Toolbar Toolbar
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Toolbar](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Toolbar.html) |     |

### Properties

#### CustomButtonNames\_BinarySerialization

##### Declaration

```
[Serialize]
[NullableItem]
[Nullable]
public Dictionary<int, string> CustomButtonNames_BinarySerialization { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.Int32, System.String\> |     |

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

#### Remap(IMyRemapHelper)

##### Declaration

```
public override void Remap(IMyRemapHelper remapHelper)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyRemapHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html) | remapHelper |     |

##### Overrides

### Extension Methods