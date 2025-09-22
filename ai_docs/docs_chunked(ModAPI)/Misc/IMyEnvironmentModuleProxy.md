---
title: "Interface IMyEnvironmentModuleProxy"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMyEnvironmentModuleProxy.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment"
class: "IMyEnvironmentModuleProxy"
---

# Interface IMyEnvironmentModuleProxy | Space Engineers ModAPI

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyEnvironmentModuleProxy
```

### Methods

#### Close()

##### Declaration

#### CommitLodChange(Int32, Int32)

##### Declaration

```
void CommitLodChange(int lodBefore, int lodAfter)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | lodBefore |     |
| System.Int32 | lodAfter |     |

#### CommitPhysicsChange(Boolean)

##### Declaration

```
void CommitPhysicsChange(bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enabled |     |

#### DebugDraw()

##### Declaration

#### HandleSyncEvent(Int32, Object, Boolean)

##### Declaration

```
void HandleSyncEvent(int item, object data, bool fromClient)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | item |     |
| System.Object | data |     |
| System.Boolean | fromClient |     |

#### Init(MyEnvironmentSector, List<Int32>)

##### Declaration

```
void Init(MyEnvironmentSector sector, List<int> items)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEnvironmentSector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSector.html) | sector |     |
| System.Collections.Generic.List<System.Int32\> | items |     |

#### OnItemChange(Int32, Int16)

##### Declaration

```
void OnItemChange(int index, short newModel)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |
| System.Int16 | newModel |     |

#### OnItemChangeBatch(List<Int32>, Int32, Int16)

##### Declaration

```
void OnItemChangeBatch(List<int> items, int offset, short newModel)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.Int32\> | items |     |
| System.Int32 | offset |     |
| System.Int16 | newModel |     |