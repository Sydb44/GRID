---
title: "Class MyObjectFactory<TAttribute, TCreatedObjectBase>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectFactory-2.html"
category: "Misc"
namespace: "VRage.ObjectBuilders"
class: "MyObjectFactory-2"
---

# Class MyObjectFactory<TAttribute, TCreatedObjectBase> | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectFactory<TAttribute, TCreatedObjectBase>

###### **Namespace**: [VRage.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyObjectFactory<TAttribute, TCreatedObjectBase> : Object where TAttribute : MyFactoryTagAttribute where TCreatedObjectBase : class
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TAttribute |     |
| TCreatedObjectBase |     |

### Constructors

#### MyObjectFactory()

##### Declaration

### Properties

#### Attributes

##### Declaration

```
public DictionaryValuesReader<Type, TAttribute> Attributes { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DictionaryValuesReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryValuesReader-2.html)<System.Type, TAttribute> |     |

### Methods

#### CreateInstance(MyObjectBuilderType)

##### Declaration

```
public TCreatedObjectBase CreateInstance(MyObjectBuilderType objectBuilderType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | objectBuilderType |     |

##### Returns

| Type | Description |
| --- | --- |
| TCreatedObjectBase |     |

#### CreateInstance<TBase>()

##### Declaration

```
public TBase CreateInstance<TBase>()
    where TBase : class, TCreatedObjectBase, new()
```

##### Returns

| Type | Description |
| --- | --- |
| TBase |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| TBase |     |

#### CreateInstance<TBase>(MyObjectBuilderType)

##### Declaration

```
public TBase CreateInstance<TBase>(MyObjectBuilderType objectBuilderType)
    where TBase : class, TCreatedObjectBase
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | objectBuilderType |     |

##### Returns

| Type | Description |
| --- | --- |
| TBase |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| TBase |     |

#### CreateObjectBuilder<TObjectBuilder>(TCreatedObjectBase)

##### Declaration

```
public TObjectBuilder CreateObjectBuilder<TObjectBuilder>(TCreatedObjectBase instance)
    where TObjectBuilder : MyObjectBuilder_Base
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TCreatedObjectBase | instance |     |

##### Returns

| Type | Description |
| --- | --- |
| TObjectBuilder |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| TObjectBuilder |     |

#### CreateObjectBuilder<TObjectBuilder>(Type)

##### Declaration

```
public TObjectBuilder CreateObjectBuilder<TObjectBuilder>(Type instanceType)
    where TObjectBuilder : MyObjectBuilder_Base
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | instanceType |     |

##### Returns

| Type | Description |
| --- | --- |
| TObjectBuilder |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| TObjectBuilder |     |

#### GetProducedType(MyObjectBuilderType)

##### Declaration

```
public Type GetProducedType(MyObjectBuilderType objectBuilderType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | objectBuilderType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Type |     |

#### RegisterDescriptor(TAttribute, Type)

##### Declaration

```
public void RegisterDescriptor(TAttribute descriptor, Type type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TAttribute | descriptor |     |
| System.Type | type |     |

#### RegisterFromAssembly(Assembly)

##### Declaration

```
public void RegisterFromAssembly(Assembly assembly)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.Assembly | assembly |     |

#### RegisterFromAssembly(Assembly\[\])

##### Declaration

```
public void RegisterFromAssembly(Assembly[] assemblies)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.Assembly\[\] | assemblies |     |

#### RegisterFromCreatedObjectAssembly()

##### Declaration

```
public void RegisterFromCreatedObjectAssembly()
```

#### TryGetProducedType(MyObjectBuilderType)

##### Declaration

```
public Type TryGetProducedType(MyObjectBuilderType objectBuilderType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | objectBuilderType |     |

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