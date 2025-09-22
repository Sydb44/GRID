---
title: "Class MySpriteCollection"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySpriteCollection.html"
category: "Misc"
namespace: "VRage.Game.GUI.TextPanel"
class: "MySpriteCollection"
---

# Class MySpriteCollection | Space Engineers ModAPI

##### Inheritance

System.Object

MySpriteCollection

###### **Namespace**: [VRage.Game.GUI.TextPanel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MySpriteCollection : ValueType
```

### Constructors

#### MySpriteCollection(MySprite\[\])

##### Declaration

```
public MySpriteCollection(MySprite[] sprites)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySprite](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySprite.html)\[\] | sprites |     |

### Fields

#### Sprites

##### Declaration

```
[Nullable]
public MySprite[] Sprites
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySprite](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySprite.html)\[\] |     |

### Operators

#### Implicit(MySerializableSpriteCollection to MySpriteCollection)

##### Declaration

```
public static implicit operator MySpriteCollection(MySerializableSpriteCollection collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySerializableSpriteCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySerializableSpriteCollection.html) | collection |     |

##### Returns

| Type | Description |
| --- | --- |
| [MySpriteCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySpriteCollection.html) |     |

#### Implicit(MySpriteCollection to MySerializableSpriteCollection)

##### Declaration

```
public static implicit operator MySerializableSpriteCollection(MySpriteCollection collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySpriteCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySpriteCollection.html) | collection |     |

##### Returns

| Type | Description |
| --- | --- |
| [MySerializableSpriteCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySerializableSpriteCollection.html) |     |