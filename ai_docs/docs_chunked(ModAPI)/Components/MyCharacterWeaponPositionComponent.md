---
title: "Class MyCharacterWeaponPositionComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.MyCharacterWeaponPositionComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities.Character.Components"
class: "MyCharacterWeaponPositionComponent"
---

# Class MyCharacterWeaponPositionComponent | Space Engineers ModAPI

Weapon positioning.

##### Inheritance

System.Object

MyCharacterWeaponPositionComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities.Character.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
public class MyCharacterWeaponPositionComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyCharacterWeaponPositionComponent()

##### Declaration

```
public MyCharacterWeaponPositionComponent()
```

### Properties

#### ArmsIkWeight

##### Declaration

```
public float ArmsIkWeight { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Character

##### Declaration

```
public MyCharacter Character { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter |     |

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

#### GraphicalPositionWorld

##### Declaration

```
public Vector3D GraphicalPositionWorld { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### IsInIronSight

##### Declaration

```
public bool IsInIronSight { get; }
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

#### LogicalCrosshairPoint

##### Declaration

```
public Vector3D LogicalCrosshairPoint { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### LogicalOrientationWorld

##### Declaration

```
public Vector3D LogicalOrientationWorld { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### LogicalPositionLocalSpace

##### Declaration

```
public Vector3D LogicalPositionLocalSpace { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### LogicalPositionWorld

##### Declaration

```
public Vector3D LogicalPositionWorld { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### ShouldSupressShootAnimation

##### Declaration

```
public bool ShouldSupressShootAnimation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### AddBackkick(Single)

##### Declaration

```
public void AddBackkick(float backkickForce)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | backkickForce |     |

#### Init(MyObjectBuilder\_Character)

Initialize from character object builder.

##### Declaration

```
public virtual void Init(MyObjectBuilder_Character characterBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_Character](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Character.html) | characterBuilder |     |

#### Update(Boolean)

Update weapon position, either logical and graphical.

##### Declaration

```
public void Update(bool timeAdvanced = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | timeAdvanced |     |

### Extension Methods