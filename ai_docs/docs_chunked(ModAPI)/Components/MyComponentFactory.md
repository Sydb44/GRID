---
title: "Class MyComponentFactory"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentFactory.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyComponentFactory"
---

# Class MyComponentFactory | Space Engineers ModAPI

##### Inheritance

System.Object

MyComponentFactory

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[PreloadRequired]
public sealed class MyComponentFactory : Object
```

### Properties

#### Static

##### Declaration

```
public static MyComponentFactory Static { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyComponentFactory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentFactory.html) |     |

### Methods

#### CreateInstanceByType(Type)

##### Declaration

```
public MyComponentBase CreateInstanceByType(Type type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) |     |

#### CreateInstanceByTypeId(MyObjectBuilderType)

##### Declaration

```
public MyComponentBase CreateInstanceByTypeId(MyObjectBuilderType type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) |     |

#### CreateObjectBuilder(MyComponentBase)

##### Declaration

```
public MyObjectBuilder_ComponentBase CreateObjectBuilder(MyComponentBase instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | instance |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

#### GetCreatedInstanceType(MyObjectBuilderType)

##### Declaration

```
public Type GetCreatedInstanceType(MyObjectBuilderType type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Type |     |

#### RegisterFromAssembly(Assembly)

##### Declaration

```
public void RegisterFromAssembly(Assembly assembly)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.Assembly | assembly |     |

#### TryGetCreatedInstanceType(MyObjectBuilderType)

##### Declaration

```
public Type TryGetCreatedInstanceType(MyObjectBuilderType type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Type |     |

#### UnregisterFromAssembly(Assembly)

##### Declaration

```
public void UnregisterFromAssembly(Assembly assembly)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.Assembly | assembly |     |