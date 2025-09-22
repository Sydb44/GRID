---
title: "Interface IMyMissileGunObject"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyMissileGunObject.html"
category: "Weapons"
namespace: "Sandbox.Game.Entities"
class: "IMyMissileGunObject"
---

# Interface IMyMissileGunObject | Space Engineers ModAPI

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyMissileGunObject : IMyGunObject<MyGunBase>, IMyShootOrigin
```

### Methods

#### RemoveMissile(Int64)

##### Declaration

```
void RemoveMissile(long entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |

#### ShootMissile(MyObjectBuilder\_Missile)

##### Declaration

```
void ShootMissile(MyObjectBuilder_Missile builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_Missile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_Missile.html) | builder |     |