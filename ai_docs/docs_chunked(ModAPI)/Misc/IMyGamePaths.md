---
title: "Interface IMyGamePaths"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGamePaths.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyGamePaths"
---

# Interface IMyGamePaths | Space Engineers ModAPI

ModAPI interface that, giving you information about most important game paths

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyGamePaths
```

### Properties

#### ContentPath

Return path, where original SE content folder is located. Example: D:\\SteamLibrary\\steamapps\\common\\SpaceEngineers\\Content

##### Declaration

```
string ContentPath { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ModScopeName

Gets the calling mod's assembly ScopeName. This name is used in storage paths (eg. 1234567.sbm\_TypeName).

##### Declaration

```
string ModScopeName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ModsPath

Return path, where SE mod folder is located. Example: C:\\Users{USERNAME}\\AppData\\Roaming\\SpaceEngineers\\Mods

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### SavesPath

Return path, where SE user saves path is located. Example: C:\\Users{USERNAME}\\AppData\\Roaming\\SpaceEngineers\\Saves

##### Declaration

```
string SavesPath { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### UserDataPath

Return path, where SE user folder is located. Example: C:\\Users{USERNAME}\\AppData\\Roaming\\SpaceEngineers

##### Declaration

```
string UserDataPath { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |