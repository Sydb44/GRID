---
title: "Interface IMyHandToolComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyHandToolComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities"
class: "IMyHandToolComponent"
---

# Interface IMyHandToolComponent | Space Engineers ModAPI

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyHandToolComponent
```

### Methods

#### DrawHud()

##### Declaration

#### GetStateForTarget(MyEntity, UInt32)

##### Declaration

```
string GetStateForTarget(MyEntity targetEntity, uint shapeKey)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | targetEntity |     |
| System.UInt32 | shapeKey |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Hit(MyEntity, MyHitInfo, UInt32, Single)

##### Declaration

```
bool Hit(MyEntity entity, MyHitInfo hitInfo, uint shapeKey, float efficiency)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| [MyHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyHitInfo.html) | hitInfo |     |
| System.UInt32 | shapeKey |     |
| System.Single | efficiency |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OnControlAcquired(MyCharacter)

##### Declaration

```
void OnControlAcquired(MyCharacter owner)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter | owner |     |

#### OnControlReleased()

##### Declaration

#### Shoot()

##### Declaration

#### Update()

##### Declaration