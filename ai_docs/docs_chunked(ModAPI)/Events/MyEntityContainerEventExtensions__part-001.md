---
title: "Class MyEntityContainerEventExtensions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityContainerEventExtensions.html"
category: "Events"
namespace: "VRage.Game.Components"
class: "MyEntityContainerEventExtensions"
---

# Class MyEntityContainerEventExtensions | Space Engineers ModAPI

TODO: This should change in future. Cestmir should already know how to change this to some kind of dispatcher that will inform components Until then, this is now used to inform MyEntityDurabilityComponent if present in the container about changes

##### Inheritance

System.Object

MyEntityContainerEventExtensions

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public static class MyEntityContainerEventExtensions : Object
```

### Methods

#### InitEntityEvents()

##### Declaration

```
public static void InitEntityEvents()
```

#### RaiseEntityEvent(MyEntityComponentBase, MyStringHash, MyEntityContainerEventExtensions.EntityEventParams)

Call this to raise event on entity, that will be processed by registered components

##### Declaration

```
public static void RaiseEntityEvent(this MyEntityComponentBase component, MyStringHash eventType, MyEntityContainerEventExtensions.EntityEventParams eventParams)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityComponentBase.html) | component | component upon which container this is going to be invoke |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | eventType | type of event |
| [MyEntityContainerEventExtensions.EntityEventParams](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityContainerEventExtensions.EntityEventParams.html) | eventParams | event params or derived type |

#### RaiseEntityEvent(MyEntity, MyStringHash, MyEntityContainerEventExtensions.EntityEventParams)

Call this to raise event on entity, that will be processed by registered components

##### Declaration

```
public static void RaiseEntityEvent(this MyEntity entity, MyStringHash eventType, MyEntityContainerEventExtensions.EntityEventParams eventParams)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity | this is entity on which is this being invoked |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | eventType | type of event |
| [MyEntityContainerEventExtensions.EntityEventParams](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityContainerEventExtensions.EntityEventParams.html) | eventParams | event params or derived type |

#### RaiseEntityEventOn(MyEntity, MyStringHash, MyEntityContainerEventExtensions.EntityEventParams)

Call this to raise event on entity, that will be processed by registered components

##### Declaration

```
public static void RaiseEntityEventOn(MyEntity entity, MyStringHash eventType, MyEntityContainerEventExtensions.EntityEventParams eventParams)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity | this is entity on which is this being invoked |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | eventType | type of event |
| [MyEntityContainerEventExtensions.EntityEventParams](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityContainerEventExtensions.EntityEventParams.html) | eventParams | event params or derived type |

#### RegisterForEntityEvent(MyEntityComponentBase, MyEntity, MyStringHash, MyEntityContainerEventExtensions.EntityEventHandler)

This will register the component to listen to some events on entity that is other than entity containing this component

##### Declaration

```
public static void RegisterForEntityEvent(this MyEntityComponentBase component, MyEntity entity, MyStringHash eventType, MyEntityContainerEventExtensions.EntityEventHandler handler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityComponentBase.html) | component | Component that is being registered |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity | Entity on which we listen to events |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | eventType | type of event |
| [MyEntityContainerEventExtensions.EntityEventHandler](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityContainerEventExtensions.EntityEventHandler.html) | handler | handler to be called |

#### RegisterForEntityEvent(MyEntityComponentBase, MyStringHash, MyEntityContainerEventExtensions.EntityEventHandler)

This will register the component to listen to some events..

##### Declaration

```
public static void RegisterForEntityEvent(this MyEntityComponentBase component, MyStringHash eventType, MyEntityContainerEventExtensions.EntityEventHandler handler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityComponentBase.html) | component | Component that is being registered |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | eventType | type of event |
| [MyEntityContainerEventExtensions.EntityEventHandler](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityContainerEventExtensions.EntityEventHandler.html) | handler | handler to be called |
