---
title: "Class MyHandToolBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyHandToolBase.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyHandToolBase"
---

# Class MyHandToolBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyHandToolBase

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[StaticEventOwner]
[MyEntityType]
public class MyHandToolBase : MyEntity, IMyEntity, IMyEntity, IMyHandheldGunObject<MyToolBase>, IMyGunObject<MyToolBase>, IStoppableAttackingTool
```

### Constructors

#### MyHandToolBase()

##### Declaration

### Fields

#### m\_isActionDoubleClicked

##### Declaration

```
protected Dictionary<MyShootActionEnum, bool> m_isActionDoubleClicked
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html), System.Boolean\> |     |

#### m\_lastShot

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### m\_toolComponents

##### Declaration

```
protected Dictionary<string, IMyHandToolComponent> m_toolComponents
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, [IMyHandToolComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyHandToolComponent.html)\> |     |

#### m\_toolItemDef

##### Declaration

```
protected MyToolItemDefinition m_toolItemDef
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyToolItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyToolItemDefinition.html) |     |

### Properties

#### BackkickForcePerSecond

##### Declaration

```
public float BackkickForcePerSecond { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CurrentAmmunition

##### Declaration

```
public int CurrentAmmunition { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### CurrentMagazineAmmunition

##### Declaration

```
public int CurrentMagazineAmmunition { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### CurrentMagazineAmount

##### Declaration

```
public int CurrentMagazineAmount { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### DefinitionId

##### Declaration

```
public MyDefinitionId DefinitionId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### EnabledInWorldRules

##### Declaration

```
public bool EnabledInWorldRules { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ForceAnimationInsteadOfIK

##### Declaration

```
public virtual bool ForceAnimationInsteadOfIK { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GunBase

##### Declaration

```
public MyToolBase GunBase { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Weapons.MyToolBase |     |

#### IsBlocking

##### Declaration

```
public bool IsBlocking { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsRecoiling

##### Declaration

```
public bool IsRecoiling { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsReloading

##### Declaration

```
public bool IsReloading { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsShooting

##### Declaration

```
public bool IsShooting { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsSkinnable

##### Declaration

```
public bool IsSkinnable { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsTargetLockingCapable

##### Declaration

```
public bool IsTargetLockingCapable { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaximumShotLength

Zero means that the gun should not update shoot direction at all

##### Declaration

```
public float MaximumShotLength { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single | Minimal time interval in milliseconds between two direction updates |

#### NeedsReload

##### Declaration

```
public bool NeedsReload { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsShootDirectionWhileAiming

Whether this gun needs the shoot direction at all times. Guns that do not will have their direction

##### Declaration

```
public bool NeedsShootDirectionWhileAiming { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Owner

##### Declaration

```
public MyCharacter Owner { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter |     |

#### OwnerId

##### Declaration

```
public long OwnerId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### OwnerIdentityId

##### Declaration

```
public long OwnerIdentityId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### PhysicalItemDefinition

##### Declaration

```
public MyPhysicalItemDefinition PhysicalItemDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyPhysicalItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalItemDefinition.html) |     |
