---
title: "Class MyVoxelDataConstants"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyVoxelDataConstants.html"
category: "Misc"
namespace: "VRage.Voxels"
class: "MyVoxelDataConstants"
---

# Class MyVoxelDataConstants | Space Engineers ModAPI

##### Inheritance

System.Object

MyVoxelDataConstants

###### **Namespace**: [VRage.Voxels](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public static class MyVoxelDataConstants : Object
```

### Fields

#### ContentEmpty

##### Declaration

```
public const byte ContentEmpty = 0
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### ContentFull

##### Declaration

```
public const byte ContentFull = 255
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### ContentReciprocal

##### Declaration

```
public const float ContentReciprocal = 0.003921569F
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### HalfContent

##### Declaration

```
public const float HalfContent = 127.5F
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### HalfContentReciprocal

##### Declaration

```
public const float HalfContentReciprocal = 0.007843138F
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsoLevel

##### Declaration

```
public const byte IsoLevel = 127
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### LodCount

There are 16 lods, 0 through 15.

##### Declaration

```
public const int LodCount = 16
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### NullMaterial

The byte describing the absence of material.

This byte should never accur in areas where content is non-zero.

##### Declaration

```
public const byte NullMaterial = 255
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### StorageV2Extension

##### Declaration

```
public const string StorageV2Extension = ".vx2"
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### DefaultValue(MyStorageDataTypeEnum)

Lookup the default value for a given storage data type.

##### Declaration

```
public static byte DefaultValue(MyStorageDataTypeEnum type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageDataTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeEnum.html) | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Byte |     |