---
title: "Class MyFloatingObjects"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyFloatingObjects.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyFloatingObjects"
---

# Class MyFloatingObjects | Space Engineers ModAPI

##### Inheritance

System.Object

MyFloatingObjects

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MySessionComponentDescriptor]
[StaticEventOwner]
public class MyFloatingObjects : MySessionComponentBase, IMyUserInputComponent
```

### Constructors

#### MyFloatingObjects()

##### Declaration

```
public MyFloatingObjects()
```

### Properties

#### Dependencies

##### Declaration

```
public override Type[] Dependencies { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Type\[\] |     |

##### Overrides

#### FloatingBagsCount

##### Declaration

```
public static int FloatingBagsCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### FloatingItemCount

##### Declaration

```
public static int FloatingItemCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### FloatingOreCount

##### Declaration

```
public static int FloatingOreCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### AddFloatingObjectAmount(MyFloatingObject, MyFixedPoint)

##### Declaration

```
public static void AddFloatingObjectAmount(MyFloatingObject obj, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyFloatingObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyFloatingObject.html) | obj |     |
| VRage.MyFixedPoint | amount |     |

#### ChangeObjectBuilder(MyComponentDefinition, MyObjectBuilder\_EntityBase)

This is used mainly for compactibility issues, it takes the builder of an entity of old object representation and creates a floating object builder for it

##### Declaration

```
public static MyObjectBuilder_FloatingObject ChangeObjectBuilder(MyComponentDefinition componentDef, MyObjectBuilder_EntityBase entityOb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyComponentDefinition.html) | componentDef |     |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | entityOb |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_FloatingObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_FloatingObject.html) |     |

#### EnqueueCargoContainerBagSpawn(Action)

##### Declaration

```
public static void EnqueueCargoContainerBagSpawn(Action action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action |     |

#### EnqueueInventoryItemSpawn(MyPhysicalInventoryItem, BoundingBoxD, Vector3D)

##### Declaration

```
public static void EnqueueInventoryItemSpawn(MyPhysicalInventoryItem inventoryItem, BoundingBoxD boundingBox, Vector3D inheritedVelocity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html) | inventoryItem |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | inheritedVelocity |     |

#### LoadData()

##### Declaration

```
public override void LoadData()
```

##### Overrides

#### ReduceCargoBags()

##### Declaration

```
public static void ReduceCargoBags()
```

#### ReduceFloatingObjects()

##### Declaration

```
public static void ReduceFloatingObjects()
```

#### RemoveFloatingObject(MyFloatingObject)

##### Declaration

```
public static void RemoveFloatingObject(MyFloatingObject obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyFloatingObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyFloatingObject.html) | obj |     |

#### RemoveFloatingObject(MyFloatingObject, Boolean)

##### Declaration

```
public static void RemoveFloatingObject(MyFloatingObject obj, bool sync)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyFloatingObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyFloatingObject.html) | obj |     |
| System.Boolean | sync |     |

#### RemoveInventoryBag(MyCargoContainerInventoryBagEntity)

##### Declaration

```
public static void RemoveInventoryBag(MyCargoContainerInventoryBagEntity obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCargoContainerInventoryBagEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCargoContainerInventoryBagEntity.html) | obj |     |

#### RemoveInventoryBag(MyCargoContainerInventoryBagEntity, Boolean)

##### Declaration

```
public static void RemoveInventoryBag(MyCargoContainerInventoryBagEntity obj, bool sync)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCargoContainerInventoryBagEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCargoContainerInventoryBagEntity.html) | obj |     |
| System.Boolean | sync |     |

#### RequestSpawnCreative(MyObjectBuilder\_FloatingObject)

Players are allowed to spawn any object in creative

##### Declaration

```
public static void RequestSpawnCreative(MyObjectBuilder_FloatingObject obj)
```
