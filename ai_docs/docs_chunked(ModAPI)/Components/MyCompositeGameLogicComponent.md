---
title: "Class MyCompositeGameLogicComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCompositeGameLogicComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities"
class: "MyCompositeGameLogicComponent"
---

# Class MyCompositeGameLogicComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyCompositeGameLogicComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyCompositeGameLogicComponent : MyGameLogicComponent, IMyEntityComponentBase, IMyComponentBase, IMyGameLogicComponent
```

### Methods

#### Add<T>(T)

##### Declaration

```
public void Add<T>(T component)
    where T : MyGameLogicComponent
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | component |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### Close()

##### Declaration

```
public override void Close()
```

##### Overrides

#### Create(ICollection<MyGameLogicComponent>, MyEntity)

##### Declaration

```
public static MyGameLogicComponent Create(ICollection<MyGameLogicComponent> logicComponents, MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.ICollection<[MyGameLogicComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyGameLogicComponent.html)\> | logicComponents |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyGameLogicComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyGameLogicComponent.html) |     |

#### GetAs(String)

##### Declaration

```
public MyGameLogicComponent GetAs(string typeName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | typeName |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyGameLogicComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyGameLogicComponent.html) |     |

#### GetAs<T>()

##### Declaration

```
public override T GetAs<T>()
    where T : class
```

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

##### Overrides

#### GetComponents()

##### Declaration

```
public IReadOnlyCollection<MyGameLogicComponent> GetComponents()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IReadOnlyCollection<[MyGameLogicComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyGameLogicComponent.html)\> |     |

#### GetObjectBuilder(Boolean)

##### Declaration

```
public override MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

##### Overrides

#### Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
public override void Init(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |

##### Overrides

#### MarkForClose()

##### Declaration

```
public override void MarkForClose()
```

##### Overrides

#### Remove(String)

##### Declaration

```
public bool Remove(string typeName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | typeName |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Remove<T>(T)

##### Declaration

```
public bool Remove<T>(T component)
    where T : MyGameLogicComponent
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | component |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Extension Methods