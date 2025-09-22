---
title: "Class MyTerminalAccessScope"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyTerminalAccessScope.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "MyTerminalAccessScope"
---

# Class MyTerminalAccessScope | Space Engineers ModAPI

##### Inheritance

System.Object

MyTerminalAccessScope

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class MyTerminalAccessScope : Enum
```

### Fields

#### All

Checks for access over the entire grid terminal system, no matter how the block is connected.

##### Declaration

```
public const MyTerminalAccessScope All
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyTerminalAccessScope](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyTerminalAccessScope.html) |     |

#### Construct

Checks for access only within the current construct. This is any block connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct. Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way.

##### Declaration

```
public const MyTerminalAccessScope Construct
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyTerminalAccessScope](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyTerminalAccessScope.html) |     |

#### Grid

Checks for access only for blocks on the same grid as the programmable block.

##### Declaration

```
public const MyTerminalAccessScope Grid
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyTerminalAccessScope](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyTerminalAccessScope.html) |     |

#### value\_\_

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |