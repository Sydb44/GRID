---
title: "Class MyObjectBuilder\\_TextPanel"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_TextPanel.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_TextPanel"
---

# Class MyObjectBuilder\_TextPanel | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_TextPanel

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_TextPanel : MyObjectBuilder_FunctionalBlock
```

### Constructors

#### MyObjectBuilder\_TextPanel()

##### Declaration

```
public MyObjectBuilder_TextPanel()
```

### Fields

#### AccessFlag

##### Declaration

```
public TextPanelAccessFlag AccessFlag
```

##### Field Value

| Type | Description |
| --- | --- |
| [TextPanelAccessFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.TextPanelAccessFlag.html) |     |

#### Alignment

##### Declaration

```
public TextAlignmentEnum Alignment
```

##### Field Value

| Type | Description |
| --- | --- |
| [TextAlignmentEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.TextAlignmentEnum.html) |     |

#### BackgroundColor

##### Declaration

```
[Serialize]
public Nullable<Color> BackgroundColor
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)\> |     |

#### ChangeInterval

##### Declaration

```
public float ChangeInterval
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ContentType

##### Declaration

```
public ContentType ContentType
```

##### Field Value

| Type | Description |
| --- | --- |
| [ContentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.ContentType.html) |     |

#### CurrentShownTexture

##### Declaration

```
public int CurrentShownTexture
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### CustomizeScripts

##### Declaration

```
public bool CustomizeScripts
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Description

##### Declaration

```
public string Description
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Font

##### Declaration

```
public SerializableDefinitionId Font
```

##### Field Value

| Type | Description |
| --- | --- |
| [SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html) |     |

#### FontColor

##### Declaration

```
[Serialize]
public Nullable<Color> FontColor
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)\> |     |

#### FontSize

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PreserveAspectRatio

##### Declaration

```
public bool PreserveAspectRatio
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PublicDescription

##### Declaration

```
public string PublicDescription
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### PublicTitle

##### Declaration

```
public string PublicTitle
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ScriptBackgroundColor

##### Declaration

```
[Serialize]
public Nullable<Color> ScriptBackgroundColor
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)\> |     |

#### ScriptForegroundColor

##### Declaration

```
[Serialize]
public Nullable<Color> ScriptForegroundColor
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)\> |     |

#### SelectedImages

##### Declaration

```
[Serialize]
public List<string> SelectedImages
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### SelectedRotationIndex

##### Declaration

```
[Serialize]
public Nullable<int> SelectedRotationIndex
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int32\> |     |

#### SelectedScript

##### Declaration

```
[Serialize]
public string SelectedScript
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ShowText

##### Declaration

```
public ShowTextOnScreenFlag ShowText
```

##### Field Value

| Type | Description |
| --- | --- |
| [ShowTextOnScreenFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.ShowTextOnScreenFlag.html) |     |

#### Sprites

##### Declaration

```
public MySerializableSpriteCollection Sprites
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySerializableSpriteCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySerializableSpriteCollection.html) |     |

#### TextPadding

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

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
