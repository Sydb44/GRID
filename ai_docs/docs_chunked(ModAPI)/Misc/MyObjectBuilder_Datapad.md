---
title: "Class MyObjectBuilder\\_Datapad"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_Datapad.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders.Definitions"
class: "MyObjectBuilder_Datapad"
---

# Class MyObjectBuilder\_Datapad | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Datapad

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_Datapad : MyObjectBuilder_PhysicalObject
```

### Constructors

#### MyObjectBuilder\_Datapad()

##### Declaration

```
public MyObjectBuilder_Datapad()
```

### Fields

#### DATA\_CHAR\_LIMIT

##### Declaration

```
public static readonly int DATA_CHAR_LIMIT
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### NAME\_CHAR\_LIMIT

##### Declaration

```
public static readonly int NAME_CHAR_LIMIT
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### Data

##### Declaration

```
public string Data { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Name

##### Declaration

```
public string Name { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

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