---
title: "Class MyObjectBuilder\\_GasContainerObject"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_GasContainerObject.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders.Definitions"
class: "MyObjectBuilder_GasContainerObject"
---

# Class MyObjectBuilder\_GasContainerObject | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_GasContainerObject

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_GasContainerObject : MyObjectBuilder_PhysicalObject
```

### Constructors

#### MyObjectBuilder\_GasContainerObject()

##### Declaration

```
public MyObjectBuilder_GasContainerObject()
```

### Properties

#### GasLevel

##### Declaration

```
public float GasLevel { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

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