---
title: "Interface IMyScriptBlacklist"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyScriptBlacklist.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyScriptBlacklist"
---

# Interface IMyScriptBlacklist | Space Engineers ModAPI

Exposes blacklist functionality to allow mods to disallow parts of the scripting API that has been allowed by the system whitelist.

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyScriptBlacklist
```

### Methods

#### GetBlacklistedIngameEntries()

Gets the entries that have been blacklisted for the ingame scripts.

##### Declaration

```
HashSetReader<string> GetBlacklistedIngameEntries()
```

##### Returns

| Type | Description |
| --- | --- |
| [HashSetReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.HashSetReader-1.html)<System.String\> | Reader of blacklisted "ingame" entries |

#### GetWhitelist()

Gets the entries that have been whitelisted by the system. Each entry may represent a whole namespace, a single type and all its members, or a single member of a type.

##### Declaration

```
DictionaryReader<string, MyWhitelistTarget> GetWhitelist()
```

##### Returns

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<System.String, VRage.Scripting.MyWhitelistTarget\> |     |

#### OpenIngameBlacklistBatch()

Opens a batch to add or remove members to the blacklist.

##### Declaration

```
IMyScriptBlacklistBatch OpenIngameBlacklistBatch()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyScriptBlacklistBatch](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyScriptBlacklistBatch.html) | Black list batch editor |