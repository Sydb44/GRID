---
title: "Class PathUtils"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.PathUtils.html"
category: "Misc"
namespace: "VRage.Library.Utils"
class: "PathUtils"
---

# Class PathUtils | Space Engineers ModAPI

##### Inheritance

System.Object

PathUtils

###### **Namespace**: [VRage.Library.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public static class PathUtils : Object
```

### Methods

#### EnsureSafePath(String)

Should be called in each function that is accessible to modders and working with files: opening, deleting, moving

##### Declaration

```
public static void EnsureSafePath(string path)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path | Relative or absolute path to Mods or User Data Path |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.Security.SecurityException | Thrown when path is outside of scope |

#### GetFilesRecursively(String, String)

Gets Files Recursively from specified path with specified search pattern. Method gives access only to sub-folders of User Data Path or Mods Path.

##### Declaration

```
public static string[] GetFilesRecursively(string path, string searchPattern)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path | relative path to Mods or User Data Path |
| System.String | searchPattern | search pattern |

##### Returns

| Type | Description |
| --- | --- |
| System.String\[\] | array of names of the files |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.Security.SecurityException | Thrown when path is outside of scope |

#### Normalize(String)

This fixes paths for the current platform.

##### Declaration

```
public static string Normalize(string path)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |