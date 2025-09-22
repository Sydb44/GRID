---
title: "Class MyBlueprintIdTracker"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyBlueprintIdTracker.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyBlueprintIdTracker"
---

# Class MyBlueprintIdTracker | Space Engineers ModAPI

Server side tracker of ids of blocks, that could be re-used

##### Inheritance

System.Object

MyBlueprintIdTracker

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyBlueprintIdTracker : Object
```

### Constructors

#### MyBlueprintIdTracker()

##### Declaration

```
public MyBlueprintIdTracker()
```

### Methods

#### OnAdded(MyProjectorBase, HashSet<Int64>)

##### Declaration

```
public static void OnAdded(MyProjectorBase projector, HashSet<long> reservedIds)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Entities.Blocks.MyProjectorBase | projector |     |
| System.Collections.Generic.HashSet<System.Int64\> | reservedIds |     |

#### OnRemap(MyProjectorBase, IMyRemapHelper)

##### Declaration

```
public static void OnRemap(MyProjectorBase projector, IMyRemapHelper helper)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Entities.Blocks.MyProjectorBase | projector |     |
| [IMyRemapHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html) | helper |     |

#### OnRemove(MyProjectorBase, HashSet<Int64>)

##### Declaration

```
public static void OnRemove(MyProjectorBase projector, HashSet<long> reservedIds)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Entities.Blocks.MyProjectorBase | projector |     |
| System.Collections.Generic.HashSet<System.Int64\> | reservedIds |     |

### Events

#### OnTrackedIdAdded

##### Declaration

```
public static event Action<HashSet<long>, MyProjectorBase> OnTrackedIdAdded
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Collections.Generic.HashSet<System.Int64\>, Sandbox.Game.Entities.Blocks.MyProjectorBase\> |     |

#### OnTrackedIdChanged

##### Declaration

```
public static event Action<Dictionary<long, long>, MyProjectorBase> OnTrackedIdChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Collections.Generic.Dictionary<System.Int64, System.Int64\>, Sandbox.Game.Entities.Blocks.MyProjectorBase\> |     |

#### OnTrackedIdRemoved

##### Declaration

```
public static event Action<HashSet<long>, MyProjectorBase> OnTrackedIdRemoved
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Collections.Generic.HashSet<System.Int64\>, Sandbox.Game.Entities.Blocks.MyProjectorBase\> |     |