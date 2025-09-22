---
title: "Class MyComponentContainer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentContainer.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyComponentContainer"
---

# Class MyComponentContainer | Space Engineers ModAPI

##### Inheritance

System.Object

MyComponentContainer

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyComponentContainer : Object, IMyComponentContainer
```

### Constructors

#### MyComponentContainer()

##### Declaration

```
public MyComponentContainer()
```

### Methods

#### Add(Type, MyComponentBase)

##### Declaration

```
public void Add(Type type, MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

#### Add<T>(T)

##### Declaration

```
public void Add<T>(T component)
    where T : MyComponentBase
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | component |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### Clear()

##### Declaration

#### Contains(Type)

Returns if any component is assignable from type

##### Declaration

```
public bool Contains(Type type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Deserialize(MyObjectBuilder\_ComponentContainer)

##### Declaration

```
public void Deserialize(MyObjectBuilder_ComponentContainer builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentContainer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentContainer.html) | builder |     |

#### Get<T>()

##### Declaration

```
public T Get<T>()
    where T : MyComponentBase
```

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### GetComponentTypes()

##### Declaration

```
public Dictionary<Type, List<MyComponentBase>>.KeyCollection GetComponentTypes()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary.KeyCollection<> |     |

#### GetEnumerator()

##### Declaration

```
public IEnumerator<MyComponentBase> GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerator<[MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html)\> |     |

#### Has<T>()

##### Declaration

```
public bool Has<T>()
    where T : MyComponentBase
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### Init(MyContainerDefinition)

##### Declaration

```
public virtual void Init(MyContainerDefinition definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContainerDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyContainerDefinition.html) | definition |     |

#### OnAddedToScene()

##### Declaration

```
public void OnAddedToScene()
```

#### OnComponentAdded(Type, MyComponentBase)

##### Declaration

```
protected virtual void OnComponentAdded(Type t, MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | t   |     |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

#### OnComponentRemoved(Type, MyComponentBase)

##### Declaration

```
protected virtual void OnComponentRemoved(Type t, MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | t   |     |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

#### OnRemovedFromScene()

##### Declaration

```
public void OnRemovedFromScene()
```

#### Remove(Type)

##### Declaration

```
public void Remove(Type t)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | t   |     |

#### Remove(Type, MyComponentBase)

##### Declaration

```
public void Remove(Type t, MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | t   |     |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

#### Remove<T>()

##### Declaration

```
public void Remove<T>()
    where T : MyComponentBase
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### Remove<T>(T)

##### Declaration

```
public void Remove<T>(T component)
    where T : MyComponentBase
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | component |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### Serialize(Boolean)

##### Declaration

```
public MyObjectBuilder_ComponentContainer Serialize(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentContainer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentContainer.html) |     |

#### TryGet(Type, Int32, out MyComponentBase)

##### Declaration

```
public bool TryGet(Type type, int index, out MyComponentBase component)
```
