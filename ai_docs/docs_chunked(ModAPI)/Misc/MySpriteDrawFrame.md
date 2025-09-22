---
title: "Class MySpriteDrawFrame"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySpriteDrawFrame.html"
category: "Misc"
namespace: "VRage.Game.GUI.TextPanel"
class: "MySpriteDrawFrame"
---

# Class MySpriteDrawFrame | Space Engineers ModAPI

##### Inheritance

System.Object

MySpriteDrawFrame

###### **Namespace**: [VRage.Game.GUI.TextPanel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MySpriteDrawFrame : ValueType, IDisposable
```

### [](#constructors)Constructors

#### [](#VRage_Game_GUI_TextPanel_MySpriteDrawFrame__ctor_System_Action_VRage_Game_GUI_TextPanel_MySpriteDrawFrame__)MySpriteDrawFrame(Action<MySpriteDrawFrame>)

##### Declaration

```
public MySpriteDrawFrame(Action<MySpriteDrawFrame> submitFrameCallback)
```

##### Parameters

### [](#methods)Methods

#### [](#VRage_Game_GUI_TextPanel_MySpriteDrawFrame_Add_VRage_Game_GUI_TextPanel_MySprite_)Add(MySprite)

##### Declaration

```
public void Add(MySprite sprite)
```

##### Parameters

#### [](#VRage_Game_GUI_TextPanel_MySpriteDrawFrame_AddRange_System_Collections_Generic_IEnumerable_VRage_Game_GUI_TextPanel_MySprite__)AddRange(IEnumerable<MySprite>)

##### Declaration

```
public void AddRange(IEnumerable<MySprite> sprites)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<[MySprite](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySprite.html)\> | sprites |     |

#### [](#VRage_Game_GUI_TextPanel_MySpriteDrawFrame_AddToList_System_Collections_Generic_List_VRage_Game_GUI_TextPanel_MySprite__)AddToList(List<MySprite>)

##### Declaration

```
public void AddToList(List<MySprite> list)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MySprite](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySprite.html)\> | list |     |

#### [](#VRage_Game_GUI_TextPanel_MySpriteDrawFrame_Clip_System_Int32_System_Int32_System_Int32_System_Int32_)Clip(Int32, Int32, Int32, Int32)

##### Declaration

```
public MySpriteDrawFrame.ClearClipToken Clip(int x, int y, int width, int height)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | x   |     |
| System.Int32 | y   |     |
| System.Int32 | width |     |
| System.Int32 | height |     |

##### Returns

#### [](#VRage_Game_GUI_TextPanel_MySpriteDrawFrame_Dispose)Dispose()

##### Declaration

#### [](#VRage_Game_GUI_TextPanel_MySpriteDrawFrame_ToCollection)ToCollection()

##### Declaration

```
public MySpriteCollection ToCollection()
```

##### Returns