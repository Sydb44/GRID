---
title: "Class MyObjectBuilder\\_VoxelMap"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_VoxelMap.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_VoxelMap"
---

# Class MyObjectBuilder\_VoxelMap | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_VoxelMap

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_VoxelMap : MyObjectBuilder_EntityBase
```

### Constructors

#### MyObjectBuilder\_VoxelMap()

##### Declaration

```
public MyObjectBuilder_VoxelMap()
```

#### MyObjectBuilder\_VoxelMap(Vector3, String)

##### Declaration

```
public MyObjectBuilder_VoxelMap(Vector3 position, string storageName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | position |     |
| System.String | storageName |     |

### Fields

#### BoulderItemId

##### Declaration

```
[Nullable]
public Nullable<int> BoulderItemId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int32\> |     |

#### BoulderPlanetId

##### Declaration

```
[Nullable]
public Nullable<long> BoulderPlanetId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

#### BoulderSectorId

##### Declaration

```
[Nullable]
public Nullable<long> BoulderSectorId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

#### ContentChanged

##### Declaration

```
[Serialize]
public Nullable<bool> ContentChanged
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Boolean\> |     |

#### CreatedByUser

##### Declaration

```
public bool CreatedByUser
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Filename

##### Declaration

```
[Nullable]
public string Filename
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### IsGlobalEncounterAsteroid

##### Declaration

```
public bool IsGlobalEncounterAsteroid
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MutableStorage

##### Declaration

```
public bool MutableStorage
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

#### StorageName

##### Declaration

```
[Nullable]
public string StorageName { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### ShouldSerializeMutableStorage()

##### Declaration

```
public bool ShouldSerializeMutableStorage()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods