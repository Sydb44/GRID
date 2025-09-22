---
title: "Class MyEntityInventorySpawnComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyEntityInventorySpawnComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyEntityInventorySpawnComponent"
---

# Class MyEntityInventorySpawnComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityInventorySpawnComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyEntityInventorySpawnComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyEntityInventorySpawnComponent()

##### Declaration

```
public MyEntityInventorySpawnComponent()
```

### Properties

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

### Methods

#### Init(MyComponentDefinitionBase)

##### Declaration

```
public override void Init(MyComponentDefinitionBase definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html) | definition |     |

##### Overrides

#### IsSerialized()

##### Declaration

```
public override bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### SpawnInventoryContainer(Boolean)

##### Declaration

```
public bool SpawnInventoryContainer(bool spawnAboveEntity = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | spawnAboveEntity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods