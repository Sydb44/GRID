---
title: "Interface IMyIngameScripting"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyIngameScripting.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyIngameScripting"
---

# Interface IMyIngameScripting | Space Engineers ModAPI

Allows mods change programmable block script settings

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyIngameScripting
```

### Properties

#### ScriptBlacklist

Provides the ability for mods to add and remove items from a type and member blacklist, giving the ability to remove even more API for scripts. Intended for server admins to restrict what people are able to do with scripts to keep their simspeed up.

##### Declaration

```
IMyScriptBlacklist ScriptBlacklist { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyScriptBlacklist](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyScriptBlacklist.html) |     |

### Methods

#### Clean()

##### Declaration