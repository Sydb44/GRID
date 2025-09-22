---
title: "Class ScriptingReflection"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.ScriptingReflection.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "ScriptingReflection"
---

# Class ScriptingReflection | Space Engineers ModAPI

##### Inheritance

System.Object

ScriptingReflection

##### Implements

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class ScriptingReflection : Object, IMyReflection
```

### Constructors

#### ScriptingReflection()

##### Declaration

```
public ScriptingReflection()
```

### Methods

#### BaseTypeOf(Type)

##### Declaration

```
public Type BaseTypeOf(Type type)
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

##### Declaration

```
public Type[] GetInterfaces(Type type)
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

##### Declaration

```
public bool IsAssignableFrom(Type baseType, Type derivedType)
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

##### Declaration

```
public bool IsInstanceOfType(Type type, object instance)
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

### Implements