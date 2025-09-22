---
title: "Class MyCachedServerItem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyCachedServerItem.html"
category: "Misc"
namespace: "Sandbox.Game"
class: "MyCachedServerItem"
---

# Class MyCachedServerItem | Space Engineers ModAPI

##### Inheritance

System.Object

MyCachedServerItem

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyCachedServerItem : Object
```

### Constructors

#### MyCachedServerItem()

##### Declaration

```
public MyCachedServerItem()
```

#### MyCachedServerItem(MyGameServerItem)

##### Declaration

```
public MyCachedServerItem(MyGameServerItem server)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.GameServices.MyGameServerItem | server |     |

### Fields

#### AllowedInGroup

##### Declaration

```
public readonly bool AllowedInGroup
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Rules

##### Declaration

```
public Dictionary<string, string> Rules
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.String\> |     |

#### Server

##### Declaration

```
public readonly MyGameServerItem Server
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.GameServices.MyGameServerItem |     |

### Properties

#### Description

##### Declaration

```
public string Description { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ExperimentalMode

##### Declaration

```
public bool ExperimentalMode { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Mods

##### Declaration

```
public List<WorkshopId> Mods { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[WorkshopId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.WorkshopId.html)\> |     |

#### Settings

##### Declaration

```
public MyObjectBuilder_SessionSettings Settings { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_SessionSettings](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_SessionSettings.html) |     |

#### UsedServices

##### Declaration

```
public List<string> UsedServices { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

### Methods

#### DeserializeSettings()

##### Declaration

```
public void DeserializeSettings()
```

#### SendSettingsToSteam()

##### Declaration

```
public static void SendSettingsToSteam()
```