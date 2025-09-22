---
title: "Class MyVariableIdentifier"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVariableIdentifier.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyVariableIdentifier"
---

# Class MyVariableIdentifier | Space Engineers ModAPI

##### Inheritance

System.Object

MyVariableIdentifier

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyVariableIdentifier : ValueType
```

### [](#constructors)Constructors

#### [](#VRage_Game_MyVariableIdentifier__ctor_System_Int32_System_String_)MyVariableIdentifier(Int32, String)

##### Declaration

```
public MyVariableIdentifier(int nodeId, string variableName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | nodeId |     |
| System.String | variableName |     |

#### [](#VRage_Game_MyVariableIdentifier__ctor_System_Int32_System_String_System_Reflection_ParameterInfo_)MyVariableIdentifier(Int32, String, ParameterInfo)

##### Declaration

```
public MyVariableIdentifier(int nodeId, string variableName, ParameterInfo parameter)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | nodeId |     |
| System.String | variableName |     |
| System.Reflection.ParameterInfo | parameter |     |

#### [](#VRage_Game_MyVariableIdentifier__ctor_System_Reflection_ParameterInfo_)MyVariableIdentifier(ParameterInfo)

##### Declaration

```
public MyVariableIdentifier(ParameterInfo parameter)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.ParameterInfo | parameter |     |

### [](#fields)Fields

#### [](#VRage_Game_MyVariableIdentifier_Default)Default

##### Declaration

```
[NoSerialize]
public static MyVariableIdentifier Default
```

##### Field Value

#### [](#VRage_Game_MyVariableIdentifier_NodeID)NodeID

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_MyVariableIdentifier_OriginName)OriginName

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_MyVariableIdentifier_OriginType)OriginType

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_MyVariableIdentifier_VariableName)VariableName

##### Declaration

```
public string VariableName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### [](#methods)Methods

#### [](#VRage_Game_MyVariableIdentifier_Equals_System_Object_)Equals(Object)

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

#### [](#VRage_Game_MyVariableIdentifier_GetHashCode)GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_MyVariableIdentifier_Signature_System_Type_)Signature(Type)

##### Declaration

```
public string Signature(Type type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |