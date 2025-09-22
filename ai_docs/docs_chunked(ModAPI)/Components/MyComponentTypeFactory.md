---
title: "Class MyComponentTypeFactory"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentTypeFactory.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyComponentTypeFactory"
---

# Class MyComponentTypeFactory | Space Engineers ModAPI

##### Inheritance

System.Object

MyComponentTypeFactory

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[PreloadRequired]
public sealed class MyComponentTypeFactory : Object
```

### Properties

#### Static

##### Declaration

```
public static MyComponentTypeFactory Static { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyComponentTypeFactory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentTypeFactory.html) |     |

### Methods

#### GetComponentType(Type)

##### Declaration

```
public Type GetComponentType(Type type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Type |     |

#### GetId(Type)

##### Declaration

```
public uint GetId(Type type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### GetType(String)

##### Declaration

```
public Type GetType(string typeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | typeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Type |     |

#### GetType(UInt32)

##### Declaration

```
public Type GetType(uint id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Type |     |

#### IsAllowedEntityType(Type, Type)

##### Declaration

```
public bool IsAllowedEntityType(Type entityType, Type componentType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | entityType |     |
| System.Type | componentType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RegisterFromAssembly(Assembly)

##### Declaration

```
public void RegisterFromAssembly(Assembly assembly)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.Assembly | assembly |     |

#### TryGetComponentTypeFromModApiInterface(Type, out Type)

##### Declaration

```
public bool TryGetComponentTypeFromModApiInterface(Type interfaceType, out Type componentType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | interfaceType |     |
| System.Type | componentType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UnregisterFromAssembly(Assembly)

##### Declaration

```
public void UnregisterFromAssembly(Assembly assembly)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.Assembly | assembly |     |