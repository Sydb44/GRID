---
title: "Class MyObjectBuilder\\_HandToolBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_HandToolBase.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_HandToolBase"
---

# Class MyObjectBuilder\_HandToolBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_HandToolBase

##### Implements

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_HandToolBase : MyObjectBuilder_EntityBase, IMyObjectBuilder_GunObject<MyObjectBuilder_ToolBase>
```

### Constructors

#### MyObjectBuilder\_HandToolBase()

##### Declaration

```
public MyObjectBuilder_HandToolBase()
```

### Fields

#### DeviceBase

##### Declaration

```
[Serialize]
public MyObjectBuilder_ToolBase DeviceBase
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ToolBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ToolBase.html) |     |

### Methods

#### ShouldSerializeDeviceBase()

##### Declaration

```
public bool ShouldSerializeDeviceBase()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Explicit Interface Implementations

#### IMyObjectBuilder\_GunObject<MyObjectBuilder\_ToolBase>.DeviceBase

##### Declaration

```
MyObjectBuilder_DeviceBase IMyObjectBuilder_GunObject<MyObjectBuilder_ToolBase>.DeviceBase { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_DeviceBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DeviceBase.html) |     |

### Implements

### Extension Methods