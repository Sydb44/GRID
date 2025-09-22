---
title: "Class MyVRageIngameScriptingAdapter"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyVRageIngameScriptingAdapter.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "MyVRageIngameScriptingAdapter"
---

  Class MyVRageIngameScriptingAdapter | Space Engineers ModAPI         

[Show / Hide Table of Contents](#sidetoggle)

# Class MyVRageIngameScriptingAdapter

Allows mods change programmable block script settings

##### Inheritance

System.Object

MyVRageIngameScriptingAdapter

##### Implements

[IMyIngameScripting](Sandbox.ModAPI.IMyIngameScripting.html)

[IMyScriptBlacklist](Sandbox.ModAPI.IMyScriptBlacklist.html)

###### **Namespace**: [Sandbox.ModAPI](Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public class MyVRageIngameScriptingAdapter : Object, IMyIngameScripting, IMyScriptBlacklist
```

### Constructors

#### MyVRageIngameScriptingAdapter(IMyIngameScripting)

Implements MyVRageIngameScriptingAdapter constructor

##### Declaration

```
public MyVRageIngameScriptingAdapter(IMyIngameScripting impl)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Scripting.IMyIngameScripting | impl | script settings |

### Properties

#### ScriptBlacklist

Provides the ability for mods to add and remove items from a type and member blacklist, giving the ability to remove even more API for scripts. Intended for server admins to restrict what people are able to do with scripts to keep their simspeed up.

##### Declaration

```
public IMyScriptBlacklist ScriptBlacklist { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyScriptBlacklist](Sandbox.ModAPI.IMyScriptBlacklist.html) |     |

### Methods

#### Clean()

Clears all [ScriptBlacklist](Sandbox.ModAPI.MyVRageIngameScriptingAdapter.html#Sandbox_ModAPI_MyVRageIngameScriptingAdapter_ScriptBlacklist) changes

##### Declaration

```
public void Clean()
```

#### GetBlacklistedIngameEntries()

Gets the entries that have been blacklisted for the ingame scripts.

##### Declaration

```
public HashSetReader<string> GetBlacklistedIngameEntries()
```

##### Returns

| Type | Description |
| --- | --- |
| [HashSetReader](VRage.Collections.HashSetReader-1.html)<System.String\> | Hashset reader of namespaces that were whitelisted |

#### GetWhitelist()

Gets information about whitelisted classes and methods

##### Declaration

```
public DictionaryReader<string, MyWhitelistTarget> GetWhitelist()
```

##### Returns

| Type | Description |
| --- | --- |
| [DictionaryReader](VRage.Collections.DictionaryReader-2.html)<System.String, VRage.Scripting.MyWhitelistTarget\> | Dictionary reader, where key - name of namespace, type of method, and value - in which context it is allowed |

#### OpenIngameBlacklistBatch()

Opens a batch to add or remove members to the blacklist.

##### Declaration

```
public IMyScriptBlacklistBatch OpenIngameBlacklistBatch()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyScriptBlacklistBatch](Sandbox.ModAPI.IMyScriptBlacklistBatch.html) | Object allowing you change blacklisted members/types/namespaces. |

### Implements

[IMyIngameScripting](Sandbox.ModAPI.IMyIngameScripting.html)

[IMyScriptBlacklist](Sandbox.ModAPI.IMyScriptBlacklist.html)

_☀_

_☾_