---
title: "Interface IMyTargetLockingCapableEntity"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.IMyTargetLockingCapableEntity.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "IMyTargetLockingCapableEntity"
---

# Interface IMyTargetLockingCapableEntity | Space Engineers ModAPI

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyTargetLockingCapableEntity : IMyEntity, IMyEntity
```

### Properties

#### TargetLockData

##### Declaration

```
Sync<MyCharacter.MyTargetData, SyncDirection.FromServer> TargetLockData { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Sync.Sync<Sandbox.Game.Entities.Character.MyCharacter.MyTargetData, VRage.Sync.SyncDirection.FromServer\> |     |