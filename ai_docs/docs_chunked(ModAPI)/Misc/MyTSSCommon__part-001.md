---
title: "Class MyTSSCommon"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.MyTSSCommon.html"
category: "Misc"
namespace: "Sandbox.Game.GameSystems.TextSurfaceScripts"
class: "MyTSSCommon"
---

# Class MyTSSCommon | Space Engineers ModAPI

##### Inheritance

System.Object

MyTSSCommon

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.GameSystems.TextSurfaceScripts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyTSSCommon : MyTextSurfaceScriptBase, IMyTextSurfaceScript, IDisposable
```

### Constructors

#### MyTSSCommon(IMyTextSurface, IMyCubeBlock, Vector2)

##### Declaration

```
protected MyTSSCommon(IMyTextSurface surface, IMyCubeBlock block, Vector2 size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTextSurface](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextSurface.html) | surface |     |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | size |     |

### Fields

#### m\_fontId

##### Declaration

```
protected string m_fontId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### m\_fontScale

##### Declaration

```
protected float m_fontScale
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### AddBackground(MySpriteDrawFrame, Nullable<Color>)

##### Declaration

```
protected MySpriteDrawFrame AddBackground(MySpriteDrawFrame frame, Nullable<Color> color = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySpriteDrawFrame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySpriteDrawFrame.html) | frame |     |
| System.Nullable<[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)\> | color |     |

##### Returns

| Type | Description |
| --- | --- |
| [MySpriteDrawFrame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySpriteDrawFrame.html) |     |

#### AddBrackets(MySpriteDrawFrame, Vector2, Single, Single)

##### Declaration

```
protected MySpriteDrawFrame AddBrackets(MySpriteDrawFrame frame, Vector2 size, float scale, float offsetX = 0F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySpriteDrawFrame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySpriteDrawFrame.html) | frame |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | size |     |
| System.Single | scale |     |
| System.Single | offsetX |     |

##### Returns

| Type | Description |
| --- | --- |
| [MySpriteDrawFrame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySpriteDrawFrame.html) |     |

#### AddLine(MySpriteDrawFrame, Vector2, Vector2, Color, Single)

##### Declaration

```
protected MySpriteDrawFrame AddLine(MySpriteDrawFrame frame, Vector2 startPos, Vector2 endPos, Color color, float thicknessPx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySpriteDrawFrame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySpriteDrawFrame.html) | frame |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | startPos |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | endPos |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| System.Single | thicknessPx |     |

##### Returns

| Type | Description |
| --- | --- |
| [MySpriteDrawFrame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySpriteDrawFrame.html) |     |

#### AddProgressBar(MySpriteDrawFrame, Vector2, Vector2, Single, Color, Color, String, String)

##### Declaration

```
protected MySpriteDrawFrame AddProgressBar(MySpriteDrawFrame frame, Vector2 position, Vector2 size, float ratio, Color barBgColor, Color barFgColor, string barBgSprite = null, string barFgSprite = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySpriteDrawFrame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySpriteDrawFrame.html) | frame |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | position |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | size |     |
| System.Single | ratio |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | barBgColor |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | barFgColor |     |
| System.String | barBgSprite |     |
| System.String | barFgSprite |     |

##### Returns

| Type | Description |
| --- | --- |
| [MySpriteDrawFrame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySpriteDrawFrame.html) |     |

#### AddTextBox(MySpriteDrawFrame, Vector2, Vector2, String, String, Single, Color, Color, String, Single)

##### Declaration

```
protected MySpriteDrawFrame AddTextBox(MySpriteDrawFrame frame, Vector2 position, Vector2 size, string text, string font, float scale, Color bgColor, Color textColor, string bgSprite = null, float textOffset = 0F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySpriteDrawFrame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySpriteDrawFrame.html) | frame |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | position |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | size |     |
| System.String | text |     |
| System.String | font |     |
| System.Single | scale |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | bgColor |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | textColor |     |
| System.String | bgSprite |     |
| System.Single | textOffset |     |
