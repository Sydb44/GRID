---
title: "Class MySprite"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySprite.html"
category: "Misc"
namespace: "VRage.Game.GUI.TextPanel"
class: "MySprite"
---

# Class MySprite | Space Engineers ModAPI

##### Inheritance

System.Object

MySprite

###### **Namespace**: [VRage.Game.GUI.TextPanel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MySprite : ValueType, IEquatable<MySprite>
```

### Constructors

#### MySprite(SpriteType, String, Nullable<Vector2>, Nullable<Vector2>, Nullable<Color>, String, TextAlignment, Single)

##### Declaration

```
public MySprite(SpriteType type, string data = null, Nullable<Vector2> position = null, Nullable<Vector2> size = null, Nullable<Color> color = null, string fontId = null, TextAlignment alignment, float rotation = 0F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [SpriteType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.SpriteType.html) | type |     |
| System.String | data |     |
| System.Nullable<[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\> | position |     |
| System.Nullable<[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\> | size |     |
| System.Nullable<[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)\> | color |     |
| System.String | fontId |     |
| [TextAlignment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.TextAlignment.html) | alignment |     |
| System.Single | rotation |     |

### Fields

#### Alignment

Alignment for the text and sprites.

##### Declaration

```
public TextAlignment Alignment
```

##### Field Value

| Type | Description |
| --- | --- |
| [TextAlignment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.TextAlignment.html) |     |

#### Color

Color mask to be used when rendering this layer. If not set, white will be used

##### Declaration

```
[Nullable]
public Nullable<Color> Color
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)\> |     |

#### Data

Data to be rendered, depending on what the layer type is. This can be text or a texture path

##### Declaration

```
[Nullable]
public string Data
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### FontId

In case we are rendering text, what font to use.

##### Declaration

```
[Nullable]
public string FontId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Position

Render position for this layer. If not set, it will be placed in the center

##### Declaration

```
[Nullable]
public Nullable<Vector2> Position
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\> |     |

#### RotationOrScale

Rotation of sprite in radians. Used as scale for text.

##### Declaration

```
public float RotationOrScale
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Size

Render size for this layer. If not set, it will be sized to take up the whole texture

##### Declaration

```
[Nullable]
public Nullable<Vector2> Size
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\> |     |

#### Type

Type of the render layer

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [SpriteType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.SpriteType.html) |     |

### Methods

#### CreateClearClipRect()

##### Declaration

```
public static MySprite CreateClearClipRect()
```

##### Returns

| Type | Description |
| --- | --- |
| [MySprite](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySprite.html) |     |

#### CreateClipRect(Rectangle)

##### Declaration

```
public static MySprite CreateClipRect(Rectangle rect)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | rect |     |

##### Returns

| Type | Description |
| --- | --- |
| [MySprite](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySprite.html) |     |

#### CreateSprite(String, Vector2, Vector2)

##### Declaration

```
public static MySprite CreateSprite(string sprite, Vector2 position, Vector2 size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | sprite |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | position |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | size |     |

##### Returns

| Type | Description |
| --- | --- |
| [MySprite](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySprite.html) |     |

#### CreateText(String, String, Color, Single, TextAlignment)

##### Declaration

```
public static MySprite CreateText(string text, string fontId, Color color, float scale = 1F, TextAlignment alignment)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | text |     |
| System.String | fontId |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| System.Single | scale |     |
| [TextAlignment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.TextAlignment.html) | alignment |     |
