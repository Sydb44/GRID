---
title: "Class MyEntityGameLogic"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyEntityGameLogic.html"
category: "Components"
namespace: "Sandbox.Game.Components"
class: "MyEntityGameLogic"
---

# Class MyEntityGameLogic | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityGameLogic

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyEntityGameLogic : MyGameLogicComponent, IMyEntityComponentBase, IMyComponentBase, IMyGameLogicComponent
```

### Constructors

#### MyEntityGameLogic()

##### Declaration

```
public MyEntityGameLogic()
```

### Fields

#### m\_entity

##### Declaration

```
protected MyEntity m_entity
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

### Properties

#### GameLogic

##### Declaration

```
public MyGameLogicComponent GameLogic { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyGameLogicComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyGameLogicComponent.html) |     |

### Methods

#### CallAndClearOnClose()

##### Declaration

```
protected void CallAndClearOnClose()
```

#### CallAndClearOnClosing()

##### Declaration

```
protected void CallAndClearOnClosing()
```

#### Close()

##### Declaration

```
public override void Close()
```

##### Overrides

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

#### Init(StringBuilder, String, MyEntity, Nullable<Single>, String)

##### Declaration

```
public void Init(StringBuilder displayName, string model, MyEntity parentObject, Nullable<float> scale, string modelCollision = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | displayName |     |
| System.String | model |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | parentObject |     |
| System.Nullable<System.Single\> | scale |     |
| System.String | modelCollision |     |

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

This method marks this entity for close which means, that Close will be called after all entities are updated

##### Declaration

```
public override void MarkForClose()
```

##### Overrides

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

#### UpdateAfterSimulation10()

##### Declaration

```
public override void UpdateAfterSimulation10()
```

##### Overrides

#### UpdateAfterSimulation100()

##### Declaration

```
public override void UpdateAfterSimulation100()
```

##### Overrides

#### UpdateBeforeSimulation()

##### Declaration

```
public override void UpdateBeforeSimulation()
```

##### Overrides

#### UpdateBeforeSimulation10()

Called each 10th frame if registered for update10

##### Declaration

```
public override void UpdateBeforeSimulation10()
```

##### Overrides

#### UpdateBeforeSimulation100()

Called each 100th frame if registered for update100

##### Declaration

```
public override void UpdateBeforeSimulation100()
```

##### Overrides

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

#### UpdatingStopped()

##### Declaration

```
public override void UpdatingStopped()
```

##### Overrides

### Events

#### OnClose

##### Declaration

```
public event Action<MyEntity> OnClose
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

#### OnClosing

##### Declaration

```
public event Action<MyEntity> OnClosing
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

#### OnMarkForClose

This event may not be invoked at all, when calling MyEntities.CloseAll, marking is bypassed

##### Declaration

```
public event Action<MyEntity> OnMarkForClose
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

### Extension Methods