---
title: "Class MyItemType"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame"
class: "MyItemType"
---

# Class MyItemType | Space Engineers ModAPI

##### Inheritance

System.Object

MyItemType

###### **Namespace**: [VRage.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyItemType : ValueType, IComparable<MyItemType>, IEquatable<MyItemType>
```

### [](#constructors)Constructors

#### [](#VRage_Game_ModAPI_Ingame_MyItemType__ctor_System_String_System_String_)MyItemType(String, String)

##### Declaration

```
public MyItemType(string typeId, string subtypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | typeId |     |
| System.String | subtypeId |     |

#### [](#VRage_Game_ModAPI_Ingame_MyItemType__ctor_VRage_ObjectBuilders_MyObjectBuilderType_VRage_Utils_MyStringHash_)MyItemType(MyObjectBuilderType, MyStringHash)

##### Declaration

```
public MyItemType(MyObjectBuilderType typeId, MyStringHash subTypeIdHash)
```

##### Parameters

### [](#properties)Properties

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_SubtypeId)SubtypeId

Gets Subtype of Item

##### Declaration

```
public string SubtypeId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_TypeId)TypeId

Gets TypeId of Item

##### Declaration

```
public string TypeId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_CompareTo_VRage_Game_ModAPI_Ingame_MyItemType_)CompareTo(MyItemType)

##### Declaration

```
public int CompareTo(MyItemType other)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_Equals_System_Object_)Equals(Object)

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_Equals_VRage_Game_ModAPI_Ingame_MyItemType_)Equals(MyItemType)

##### Declaration

```
public bool Equals(MyItemType other)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_GetHashCode)GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_MakeAmmo_System_String_)MakeAmmo(String)

##### Declaration

```
public static MyItemType MakeAmmo(string subTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | subTypeId |     |

##### Returns

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_MakeComponent_System_String_)MakeComponent(String)

##### Declaration

```
public static MyItemType MakeComponent(string subTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | subTypeId |     |

##### Returns

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_MakeIngot_System_String_)MakeIngot(String)

##### Declaration

```
public static MyItemType MakeIngot(string subTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | subTypeId |     |

##### Returns

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_MakeOre_System_String_)MakeOre(String)

##### Declaration

```
public static MyItemType MakeOre(string subTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | subTypeId |     |

##### Returns

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_MakeTool_System_String_)MakeTool(String)

##### Declaration

```
public static MyItemType MakeTool(string subTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | subTypeId |     |

##### Returns

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_Parse_System_String_)Parse(String)

##### Declaration

```
public static MyItemType Parse(string itemType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | itemType |     |

##### Returns

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### [](#operators)Operators

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_op_Equality_VRage_Game_ModAPI_Ingame_MyItemType_VRage_Game_ModAPI_Ingame_MyItemType_)Equality(MyItemType, MyItemType)

##### Declaration

```
public static bool operator ==(MyItemType a, MyItemType b)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_op_Implicit_VRage_Game_ModAPI_Ingame_MyItemType__VRage_Game_MyDefinitionId)Implicit(MyItemType to MyDefinitionId)

##### Declaration

```
public static implicit operator MyDefinitionId(MyItemType itemType)
```

##### Parameters

##### Returns

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_op_Implicit_VRage_Game_MyDefinitionId__VRage_Game_ModAPI_Ingame_MyItemType)Implicit(MyDefinitionId to MyItemType)

##### Declaration

```
public static implicit operator MyItemType(MyDefinitionId definitionId)
```

##### Parameters

##### Returns

#### [](#VRage_Game_ModAPI_Ingame_MyItemType_op_Implicit_VRage_Game_MyObjectBuilder_PhysicalObject__VRage_Game_ModAPI_Ingame_MyItemType)Implicit(MyObjectBuilder\_PhysicalObject to MyItemType)

##### Declaration

```
public static implicit operator MyItemType(MyObjectBuilder_PhysicalObject ob)
```
