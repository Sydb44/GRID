---
title: "Class MySerializableSprite"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySerializableSprite.html"
category: "Misc"
namespace: "VRage.Game.GUI.TextPanel"
class: "MySerializableSprite"
---

# Class MySerializableSprite | Space Engineers ModAPI

##### Inheritance

System.Object

MySerializableSprite

###### **Namespace**: [VRage.Game.GUI.TextPanel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MySerializableSprite : ValueType
```

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
public Nullable<uint> Color
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.UInt32\> |     |

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

#### Index

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Position

Render position for this layer. If not set, it will be placed in the center

##### Declaration

```
[Nullable]
public Nullable<SerializableVector2> Position
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.SerializableVector2\> |     |

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
public Nullable<SerializableVector2> Size
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.SerializableVector2\> |     |

#### Type

Type of the render layer

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [SpriteType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.SpriteType.html) |     |