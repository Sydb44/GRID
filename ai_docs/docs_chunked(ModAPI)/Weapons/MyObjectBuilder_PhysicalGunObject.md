---
title: "Class MyObjectBuilder\\_PhysicalGunObject"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalGunObject.html"
category: "Weapons"
namespace: "VRage.Game"
class: "MyObjectBuilder_PhysicalGunObject"
---

# Class MyObjectBuilder\_PhysicalGunObject | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_PhysicalGunObject

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_PhysicalGunObject : MyObjectBuilder_PhysicalObject
```

### Constructors

#### MyObjectBuilder\_PhysicalGunObject()

##### Declaration

```
public MyObjectBuilder_PhysicalGunObject()
```

#### MyObjectBuilder\_PhysicalGunObject(MyObjectBuilder\_EntityBase)

##### Declaration

```
public MyObjectBuilder_PhysicalGunObject(MyObjectBuilder_EntityBase gunEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | gunEntity |     |

### Properties

#### GunEntity

##### Declaration

```
[Serialize]
public MyObjectBuilder_EntityBase GunEntity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

### Methods

#### CanStack(MyObjectBuilder\_PhysicalObject)

##### Declaration

```
public override bool CanStack(MyObjectBuilder_PhysicalObject a)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html) | a   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### GetInstanceOnStackSplit()

##### Declaration

```
public override MyObjectBuilder_PhysicalObject GetInstanceOnStackSplit()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html) |     |

##### Overrides

### Extension Methods