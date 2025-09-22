---
title: "Class MyObjectBuilder\\_Checkpoint.ModItem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Checkpoint.ModItem.html"
category: "Misc"
namespace: "VRage.Game.MyObjectBuilder_Checkpoint"
class: "ModItem"
---

# Class MyObjectBuilder\_Checkpoint.ModItem | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Checkpoint.ModItem

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class ModItem : ValueType
```

### [](#constructors)Constructors

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem__ctor_System_String_System_UInt64_System_String_)ModItem(String, UInt64, String)

##### Declaration

```
public ModItem(string name, ulong publishedFileId, string publishedServiceName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| System.UInt64 | publishedFileId |     |
| System.String | publishedServiceName |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem__ctor_System_String_System_UInt64_System_String_System_String_)ModItem(String, UInt64, String, String)

##### Declaration

```
public ModItem(string name, ulong publishedFileId, string publishedServiceName, string friendlyName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| System.UInt64 | publishedFileId |     |
| System.String | publishedServiceName |     |
| System.String | friendlyName |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem__ctor_System_UInt64_System_String_)ModItem(UInt64, String)

##### Declaration

```
public ModItem(ulong publishedFileId, string publishedServiceName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | publishedFileId |     |
| System.String | publishedServiceName |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem__ctor_System_UInt64_System_String_System_Boolean_)ModItem(UInt64, String, Boolean)

##### Declaration

```
public ModItem(ulong publishedFileId, string publishedServiceName, bool isDependency)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | publishedFileId |     |
| System.String | publishedServiceName |     |
| System.Boolean | isDependency |     |

### [](#fields)Fields

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_FriendlyName)FriendlyName

##### Declaration

```
public string FriendlyName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_IsDependency)IsDependency

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_Name)Name

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_PublishedFileId)PublishedFileId

##### Declaration

```
public ulong PublishedFileId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_PublishedServiceName)PublishedServiceName

##### Declaration

```
public string PublishedServiceName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### [](#methods)Methods

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_Equals_VRage_Game_MyObjectBuilder_Checkpoint_ModItem_)Equals(MyObjectBuilder\_Checkpoint.ModItem)

##### Declaration

```
public bool Equals(MyObjectBuilder_Checkpoint.ModItem other)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_GetModContext)GetModContext()

##### Declaration

```
public IMyModContext GetModContext()
```

##### Returns

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_GetModData)GetModData()

##### Declaration

```
public MyWorkshopItem GetModData()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.GameServices.MyWorkshopItem |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_GetPath)GetPath()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_GetWorkshopId)GetWorkshopId()

##### Declaration

```
public WorkshopId GetWorkshopId()
```

##### Returns

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_IsModData)IsModData()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_SetModData_VRage_GameServices_MyWorkshopItem_)SetModData(MyWorkshopItem)

##### Declaration

```
public void SetModData(MyWorkshopItem workshopItem)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.GameServices.MyWorkshopItem | workshopItem |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_ShouldSerializeFriendlyName)ShouldSerializeFriendlyName()

##### Declaration

```
public bool ShouldSerializeFriendlyName()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_ShouldSerializeIsDependency)ShouldSerializeIsDependency()

##### Declaration

```
public bool ShouldSerializeIsDependency()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_ShouldSerializeName)ShouldSerializeName()

##### Declaration

```
public bool ShouldSerializeName()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_MyObjectBuilder_Checkpoint_ModItem_ShouldSerializePublishedFileId)ShouldSerializePublishedFileId()

##### Declaration

```
public bool ShouldSerializePublishedFileId()
```
