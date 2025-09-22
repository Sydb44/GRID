---
title: "Class MyGameLogic"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyGameLogic.html"
category: "Misc"
namespace: "VRage.Game.Entity"
class: "MyGameLogic"
---

# Class MyGameLogic | Space Engineers ModAPI

This is mostly a copy of the updating system present in MyEntities.

The old style of GameLogic component was tied to entity updates. This meant that when the entity removed one of its update flags, the component would stop updating with no warning.

Here we update GameLogic components separately from the containing entity.

##### Inheritance

System.Object

MyGameLogic

###### **Namespace**: [VRage.Game.Entity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public static class MyGameLogic : Object
```

### Methods

#### ChangeUpdate(MyGameLogicComponent, MyEntityUpdateEnum, Boolean)

Modifies a component's update flags without modifying lists the component is already in. Much more performant than Unregister/Register pattern!

##### Declaration

```
public static void ChangeUpdate(MyGameLogicComponent component, MyEntityUpdateEnum newUpdate, bool immediate = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyGameLogicComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyGameLogicComponent.html) | component |     |
| [MyEntityUpdateEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyEntityUpdateEnum.html) | newUpdate |     |
| System.Boolean | immediate |     |

#### RegisterForUpdate(MyGameLogicComponent)

Registers a component to the update system. Only use for first-time registration! If changing update flags, use ChangeUpdate!

##### Declaration

```
public static void RegisterForUpdate(MyGameLogicComponent component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyGameLogicComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyGameLogicComponent.html) | component |     |

#### UnloadData()

##### Declaration

```
public static void UnloadData()
```

#### UnregisterForUpdate(MyGameLogicComponent)

Unregisters a component from the update system. Only use when disposing a component! If changing update flags, use ChangeUpdate!

##### Declaration

```
public static void UnregisterForUpdate(MyGameLogicComponent component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyGameLogicComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyGameLogicComponent.html) | component |     |

#### UpdateAfterSimulation()

##### Declaration

```
public static void UpdateAfterSimulation()
```

#### UpdateBeforeSimulation()

##### Declaration

```
public static void UpdateBeforeSimulation()
```

#### UpdateOnceBeforeFrame()

##### Declaration

```
public static void UpdateOnceBeforeFrame()
```

#### UpdatingStopped()

##### Declaration

```
public static void UpdatingStopped()
```