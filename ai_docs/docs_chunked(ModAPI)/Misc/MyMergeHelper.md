---
title: "Class MyMergeHelper"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyMergeHelper.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyMergeHelper"
---

# Class MyMergeHelper | Space Engineers ModAPI

Helper class for merge funcionality. Performs comparison between source and other values and set on self if value is different

##### Inheritance

System.Object

MyMergeHelper

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public static class MyMergeHelper : Object
```

### Methods

#### Merge<T>(T, T, T)

##### Declaration

```
public static void Merge<T>(T self, T source, T other)
    where T : class
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | self |     |
| T   | source |     |
| T   | other |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### Merge<T>(ref T, ref T, ref T)

##### Declaration

```
public static void Merge<T>(ref T self, ref T source, ref T other)
    where T : struct, ValueType
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | self |     |
| T   | source |     |
| T   | other |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |