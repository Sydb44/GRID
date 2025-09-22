---
title: "Interface IMyTextPanel"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextPanel.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyTextPanel"
---

# Interface IMyTextPanel | Space Engineers ModAPI

Describes LCD block (mods interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTextPanel : IMyTextSurface, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Methods

#### GetPublicTitle()

Gets popup dialog title

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.String | Public title |

#### WritePublicTitle(String, Boolean)

Writes LCD popup dialog title If somebody opened LCD text in popup dialog, text can no longer be added.

##### Declaration

```
bool WritePublicTitle(string value, bool append = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | value |     |
| System.Boolean | append | If true, appends, else replaces text with `<code data-dev-comment-type="paramref" class="paramref">value</code>` |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | False is if somebody currently has opened LCD text in popup dialog, true in other cases |

### Extension Methods