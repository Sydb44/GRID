---
title: "Class MySessionComponentMapping"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MySessionComponentMapping.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MySessionComponentMapping"
---

# Class MySessionComponentMapping | Space Engineers ModAPI

##### Inheritance

System.Object

MySessionComponentMapping

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public static class MySessionComponentMapping : Object
```

### Methods

#### Clear()

##### Declaration

```
public static void Clear()
```

#### GetMappedSessionObjectBuilders(List<MyObjectBuilder\_SessionComponent>)

##### Declaration

```
public static Dictionary<Type, MyObjectBuilder_SessionComponent> GetMappedSessionObjectBuilders(List<MyObjectBuilder_SessionComponent> objectBuilders)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_SessionComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_SessionComponent.html)\> | objectBuilders |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.Type, [MyObjectBuilder\_SessionComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_SessionComponent.html)\> |     |

#### Map(Type, MyObjectBuilderType)

##### Declaration

```
public static bool Map(Type type, MyObjectBuilderType objectBuilderType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | objectBuilderType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TryGetMappedObjectBuilderType(Type)

##### Declaration

```
public static MyObjectBuilderType TryGetMappedObjectBuilderType(Type type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) |     |

#### TryGetMappedSessionComponentType(MyObjectBuilderType)

##### Declaration

```
public static Type TryGetMappedSessionComponentType(MyObjectBuilderType objectBuilderType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | objectBuilderType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Type |     |