---
title: "Class ModCrashedException"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.ModCrashedException.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "ModCrashedException"
---

# Class ModCrashedException | Space Engineers ModAPI

##### Inheritance

System.Object

ModCrashedException

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class ModCrashedException : Exception
```

### Constructors

#### ModCrashedException(Exception, IMyModContext)

##### Declaration

```
public ModCrashedException(Exception innerException, IMyModContext modContext)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Exception | innerException |     |
| [IMyModContext](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModContext.html) | modContext |     |

### Properties

#### ModContext

##### Declaration

```
public IMyModContext ModContext { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyModContext](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModContext.html) |     |