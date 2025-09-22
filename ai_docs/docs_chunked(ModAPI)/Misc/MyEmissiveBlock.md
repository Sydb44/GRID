---
title: "Class MyEmissiveBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEmissiveBlock.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyEmissiveBlock"
---

# Class MyEmissiveBlock | Space Engineers ModAPI

##### Inheritance

System.Object

MyEmissiveBlock

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
public class MyEmissiveBlock : MyCubeBlock, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyCubeBlock, IMyEntity, IMyUpgradableBlock, IMyCubeBlock, IMyEntity
```

### Constructors

#### MyEmissiveBlock()

##### Declaration

### Methods

#### OnModelChange()

##### Declaration

```
public override void OnModelChange()
```

##### Overrides

#### SetEmissivity(Single)

##### Declaration

```
public void SetEmissivity(float emissivity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | emissivity |     |

### Events

#### OnModelChanged

##### Declaration

```
public event Action<MyEmissiveBlock> OnModelChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyEmissiveBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEmissiveBlock.html)\> |     |

### Implements

### Extension Methods