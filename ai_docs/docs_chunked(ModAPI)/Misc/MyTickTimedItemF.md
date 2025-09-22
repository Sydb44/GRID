---
title: "Class MyTickTimedItemF"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyTickTimedItemF.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyTickTimedItemF"
---

# Class MyTickTimedItemF | Space Engineers ModAPI

Item that is accessible only for defined amount of time ticks.

##### Inheritance

System.Object

MyTickTimedItemF

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public sealed class MyTickTimedItemF : ValueType
```

### [](#methods)Methods

#### [](#VRage_Utils_MyTickTimedItemF_Get)Get()

Get the stored item.

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Single | storage on success, default value of T on failure. |

#### [](#VRage_Utils_MyTickTimedItemF_Set_System_Int32_System_Single_)Set(Int32, Single)

Set the stored value.

##### Declaration

```
public void Set(int itemTickTimeout, float item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemTickTimeout | Number of time ticks for which the item is accessible. |
| System.Single | item | Item to be stored. |

#### [](#VRage_Utils_MyTickTimedItemF_TryGet_System_Single__)TryGet(out Single)

Get the stored item.

##### Declaration

```
public bool TryGet(out float outStoredItem)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | outStoredItem | item stored internally |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true on success, false on timeout |