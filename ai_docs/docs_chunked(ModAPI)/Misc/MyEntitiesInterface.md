---
title: "Class MyEntitiesInterface"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntitiesInterface.html"
category: "Misc"
namespace: "VRage.Game.Entity"
class: "MyEntitiesInterface"
---

# Class MyEntitiesInterface | Space Engineers ModAPI

Callbacks to various MyEntities methods.

##### Inheritance

System.Object

MyEntitiesInterface

###### **Namespace**: [VRage.Game.Entity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyEntitiesInterface : Object
```

### Constructors

#### MyEntitiesInterface()

##### Declaration

```
public MyEntitiesInterface()
```

### Fields

#### Close

##### Declaration

```
public static Action<MyEntity> Close
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

#### IsCloseAllowed

Is closing of objects allowed?

##### Declaration

```
public static Func<bool> IsCloseAllowed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Func<System.Boolean\> |     |

#### IsUpdateInProgress

Is update of all entities in progress?

##### Declaration

```
public static Func<bool> IsUpdateInProgress
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Func<System.Boolean\> |     |

#### RaiseEntityRemove

##### Declaration

```
public static Action<MyEntity> RaiseEntityRemove
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

#### RegisterDraw

Register entity for drawing.

##### Declaration

```
public static Action<MyEntity> RegisterDraw
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

#### RegisterUpdate

Register entity for updating.

##### Declaration

```
public static Action<MyEntity> RegisterUpdate
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

#### Remove

##### Declaration

```
public static Func<MyEntity, bool> Remove
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Func<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html), System.Boolean\> |     |

#### RemoveFromClosedEntities

##### Declaration

```
public static Action<MyEntity> RemoveFromClosedEntities
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

#### RemoveName

##### Declaration

```
public static Action<MyEntity> RemoveName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

#### SetEntityName

Callback to public static void MyEntities.SetEntityName(MyEntity myEntity, bool possibleRename = true).

##### Declaration

```
public static Action<MyEntity, bool> SetEntityName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html), System.Boolean\> |     |

#### UnregisterDraw

Unregister entity from drawing.

##### Declaration

```
public static Action<MyEntity> UnregisterDraw
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

#### UnregisterUpdate

Unregister entity from updating.

##### Declaration

```
public static Action<MyEntity, bool> UnregisterUpdate
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html), System.Boolean\> |     |