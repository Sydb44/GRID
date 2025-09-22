---
title: "Class MyCasterComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyCasterComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyCasterComponent"
---

# Class MyCasterComponent | Space Engineers ModAPI

Component used for finding object by casting. It is possible to create this component with different types of casting: Box, Raycast, Shape

##### Inheritance

System.Object

MyCasterComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyCasterComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyCasterComponent(MyDrillSensorBase)

##### Declaration

```
public MyCasterComponent(MyDrillSensorBase caster)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Weapons.Guns.MyDrillSensorBase | caster |     |

### Properties

#### Caster

##### Declaration

```
public MyDrillSensorBase Caster { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Weapons.Guns.MyDrillSensorBase |     |

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

#### DistanceToHitSq

##### Declaration

```
public double DistanceToHitSq { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### EnvironmentItem

##### Declaration

```
public int EnvironmentItem { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### HitBlock

Gets block that is hit by a raycaster.

##### Declaration

```
public MySlimBlock HitBlock { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Cube.MySlimBlock |     |

#### HitCharacter

##### Declaration

```
public MyCharacter HitCharacter { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter |     |

#### HitCubeGrid

##### Declaration

```
public MyCubeGrid HitCubeGrid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) |     |

#### HitDestroyableObj

##### Declaration

```
public IMyDestroyableObject HitDestroyableObj { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyDestroyableObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyDestroyableObject.html) |     |

#### HitEnvironmentSector

##### Declaration

```
public MyEnvironmentSector HitEnvironmentSector { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEnvironmentSector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSector.html) |     |

#### HitFloatingObject

##### Declaration

```
public MyFloatingObject HitFloatingObject { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyFloatingObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyFloatingObject.html) |     |

#### HitPosition

##### Declaration

```
public Vector3D HitPosition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### PointOfReference

##### Declaration

```
public Vector3D PointOfReference { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Methods

#### GetCastLength()

##### Declaration

```
public float GetCastLength()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

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

#### OnWorldPosChanged(ref MatrixD)

##### Declaration

```
public void OnWorldPosChanged(ref MatrixD newTransform)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | newTransform |     |

#### SetPointOfReference(Vector3D)

##### Declaration

```
public void SetPointOfReference(Vector3D pointOfRef)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pointOfRef |     |

### Extension Methods