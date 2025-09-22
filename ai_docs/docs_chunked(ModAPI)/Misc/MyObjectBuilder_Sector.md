---
title: "Class MyObjectBuilder\\_Sector"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Sector.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_Sector"
---

# Class MyObjectBuilder\_Sector | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Sector

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_Sector : MyObjectBuilder_Base
```

### Constructors

#### MyObjectBuilder\_Sector()

##### Declaration

```
public MyObjectBuilder_Sector()
```

### Fields

#### AppVersion

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Encounters

##### Declaration

```
public MyObjectBuilder_Encounters Encounters
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Encounters](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Encounters.html) |     |

#### Environment

##### Declaration

```
public MyObjectBuilder_EnvironmentSettings Environment
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EnvironmentSettings](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_EnvironmentSettings.html) |     |

#### Position

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### SectorEvents

##### Declaration

```
public MyObjectBuilder_GlobalEvents SectorEvents
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_GlobalEvents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_GlobalEvents.html) |     |

#### VoxelHandVolumeChanged

##### Declaration

```
public ulong VoxelHandVolumeChanged
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

### Properties

#### SectorObjects

##### Declaration

```
[DynamicObjectBuilder(false)]
public List<MyObjectBuilder_EntityBase> SectorObjects { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)\> |     |

### Methods

#### ShouldSerializeEnvironment()

##### Declaration

```
public bool ShouldSerializeEnvironment()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods