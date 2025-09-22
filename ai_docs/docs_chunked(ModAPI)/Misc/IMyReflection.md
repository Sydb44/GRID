---
title: "Interface IMyReflection"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyReflection.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyReflection"
---

# Interface IMyReflection | Space Engineers ModAPI

ModAPI interface giving some reflection tools

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyReflection
```

### Methods

#### BaseTypeOf(Type)

System.Type.BaseType

##### Declaration

```
Type BaseTypeOf(Type type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Type |     |

#### GetInterfaces(Type)

System.Type.GetInterfaces

##### Declaration

```
Type[] GetInterfaces(Type type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Type\[\] |     |

#### IsAssignableFrom(Type, Type)

System.Type.IsAssignableFrom(System.Type)

##### Declaration

```
bool IsAssignableFrom(Type baseType, Type derivedType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | baseType |     |
| System.Type | derivedType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsInstanceOfType(Type, Object)

System.Type.IsInstanceOfType(System.Object)

##### Declaration

```
bool IsInstanceOfType(Type type, object instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |
| System.Object | instance |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |