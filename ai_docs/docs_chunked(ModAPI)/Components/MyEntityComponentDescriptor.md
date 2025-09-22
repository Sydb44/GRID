---
title: "Class MyEntityComponentDescriptor"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityComponentDescriptor.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyEntityComponentDescriptor"
---

# Class MyEntityComponentDescriptor | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityComponentDescriptor

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyEntityComponentDescriptor : Attribute
```

### Constructors

#### MyEntityComponentDescriptor(Type, Boolean, String\[\])

##### Declaration

```
public MyEntityComponentDescriptor(Type entityBuilderType, bool useEntityUpdate, params string[] entityBuilderSubTypeNames)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | entityBuilderType |     |
| System.Boolean | useEntityUpdate |     |
| System.String\[\] | entityBuilderSubTypeNames |     |

#### MyEntityComponentDescriptor(Type, String\[\])

##### Declaration

```
public MyEntityComponentDescriptor(Type entityBuilderType, params string[] entityBuilderSubTypeNames)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | entityBuilderType |     |
| System.String\[\] | entityBuilderSubTypeNames |     |

### Fields

#### EntityBuilderSubTypeNames

##### Declaration

```
public string[] EntityBuilderSubTypeNames
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String\[\] |     |

#### EntityBuilderType

##### Declaration

```
public Type EntityBuilderType
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Type |     |

#### EntityUpdate

##### Declaration

```
public Nullable<bool> EntityUpdate
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Boolean\> |     |