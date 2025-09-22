---
title: "Class MyObjectBuilder\\_OxygenContainerObject"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_OxygenContainerObject.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders.Definitions"
class: "MyObjectBuilder_OxygenContainerObject"
---

# Class MyObjectBuilder\_OxygenContainerObject | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_OxygenContainerObject

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_OxygenContainerObject : MyObjectBuilder_GasContainerObject
```

### Constructors

#### MyObjectBuilder\_OxygenContainerObject()

##### Declaration

```
public MyObjectBuilder_OxygenContainerObject()
```

### Fields

#### OxygenLevel

This is not synced automatically Call SyncOxygenContainerLevel on inventory to sync it

##### Declaration

##### Field Value

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