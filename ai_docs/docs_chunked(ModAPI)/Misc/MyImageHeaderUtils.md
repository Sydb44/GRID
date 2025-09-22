---
title: "Class MyImageHeaderUtils"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyImageHeaderUtils.html"
category: "Misc"
namespace: "VRage.Library.Utils"
class: "MyImageHeaderUtils"
---

# Class MyImageHeaderUtils | Space Engineers ModAPI

##### Inheritance

System.Object

MyImageHeaderUtils

###### **Namespace**: [VRage.Library.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.html)

###### **Assembly**: VRage.Library.dll

```
public static class MyImageHeaderUtils : Object
```

### [](#methods)Methods

Reads the header of standard DDS texture without reading the rest of its contents. Checks for magic constant.

##### Declaration

```
public static bool Read_DDS_HeaderData(string filePath, out MyImageHeaderUtils.DDS_HEADER header)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Success flag. |

Reads the dimensions from PNG formated texture. Checks for magic constant.

##### Declaration

```
public static bool Read_PNG_Dimensions(string filePath, out int width, out int height)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | filePath | Path to png. |
| System.Int32 | width |     |
| System.Int32 | height |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Success flag. |