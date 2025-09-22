---
title: "Interface IMyTextSurface"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextSurface.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyTextSurface"
---

# Interface IMyTextSurface | Space Engineers ModAPI

Describes one of block LCDs where you can write text or draw things (PB scripting interface)

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTextSurface
```

### Properties

#### Alignment

How should the text be aligned

##### Declaration

```
TextAlignment Alignment { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [TextAlignment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.TextAlignment.html) |     |

#### BackgroundAlpha

Value for offscreen texture alpha channel

*   for PBR material it is metalness (should be 0)
*   for transparent texture it is opacity

##### Declaration

```
byte BackgroundAlpha { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### BackgroundColor

Gets or sets background color

##### Declaration

```
Color BackgroundColor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### ChangeInterval

Gets or sets the change interval for selected textures

##### Declaration

```
float ChangeInterval { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ContentType

Type of content to be displayed on the screen.

##### Declaration

```
ContentType ContentType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ContentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.ContentType.html) |     |

#### CurrentlyShownImage

Gets image that is currently shown on the screen.

Returns NULL if there are no images selected OR the screen is in text mode.

##### Declaration

```
string CurrentlyShownImage { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### DisplayName

Get localized name of this surface.

##### Declaration

```
string DisplayName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Font

Gets or sets the font

##### Declaration

```
string Font { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### FontColor

Gets or sets font color

##### Declaration

```
Color FontColor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### FontSize

Gets or sets font size

##### Declaration

```
float FontSize { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Name

Gets identifier name of this surface.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### PreserveAspectRatio

Gets or sets preserve aspect ratio of images.

##### Declaration

```
bool PreserveAspectRatio { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Script

Currently running script

##### Declaration

```
string Script { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ScriptBackgroundColor

Gets or sets background color used for scripts.

##### Declaration

```
Color ScriptBackgroundColor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### ScriptForegroundColor

Gets or sets foreground color used for scripts.

##### Declaration

```
Color ScriptForegroundColor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### SurfaceSize

Gets size of the drawing surface.

##### Declaration

```
Vector2 SurfaceSize { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

#### TextPadding

Gets or sets text padding from all sides of the panel.

##### Declaration

```
float TextPadding { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### TextureSize

Gets size of the texture the drawing surface is rendered to.

##### Declaration

```
Vector2 TextureSize { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

### Methods

#### AddImagesToSelection(List<String>, Boolean)

##### Declaration

```
void AddImagesToSelection(List<string> ids, bool checkExistence = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.String\> | ids | Ids of image |
| System.Boolean | checkExistence | If true, image can't be added twice |

#### AddImageToSelection(String, Boolean)

##### Declaration

```
void AddImageToSelection(string id, bool checkExistence = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | id  | Id of image |
| System.Boolean | checkExistence | If true, image can't be added twice |

#### ClearImagesFromSelection()

Removes images from shown images.

##### Declaration

```
void ClearImagesFromSelection()
```

#### DrawFrame()

Creates a new draw frame where you can add sprites to be rendered.
