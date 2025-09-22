---
title: "Class MyParallelUpdateFlag"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyParallelUpdateFlag.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyParallelUpdateFlag"
---

# Class MyParallelUpdateFlag | Space Engineers ModAPI

##### Inheritance

System.Object

MyParallelUpdateFlag

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class MyParallelUpdateFlag : ValueType
```

### Constructors

#### MyParallelUpdateFlag(Boolean)

##### Declaration

```
public MyParallelUpdateFlag(bool needsUpdate)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | needsUpdate |     |

### Methods

#### Disable(MyEntity)

##### Declaration

```
public void Disable(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

#### Enable(MyEntity)

##### Declaration

```
public void Enable(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

#### GetFlags(MyEntity)

##### Declaration

```
public MyParallelUpdateFlags GetFlags(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyParallelUpdateFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyParallelUpdateFlags.html) |     |

#### Set(MyEntity, Boolean)

##### Declaration

```
public void Set(MyEntity entity, bool value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| System.Boolean | value |     |