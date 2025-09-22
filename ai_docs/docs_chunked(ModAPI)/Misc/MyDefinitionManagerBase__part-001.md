---
title: "Class MyDefinitionManagerBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionManagerBase.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyDefinitionManagerBase"
---

# Class MyDefinitionManagerBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyDefinitionManagerBase

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MyDefinitionManagerBase : Object
```

### Constructors

#### MyDefinitionManagerBase()

##### Declaration

```
protected MyDefinitionManagerBase()
```

### Fields

#### m\_definitions

##### Declaration

```
protected MyDefinitionSet m_definitions
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionSet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionSet.html) |     |

#### m\_postProcessors

##### Declaration

```
protected static List<MyDefinitionPostprocessor> m_postProcessors
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyDefinitionPostprocessor](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDefinitionPostprocessor.html)\> |     |

#### m\_postprocessorsByType

##### Declaration

```
protected static Dictionary<Type, MyDefinitionPostprocessor> m_postprocessorsByType
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.Type, [MyDefinitionPostprocessor](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDefinitionPostprocessor.html)\> |     |

#### m\_registeredAssemblies

##### Declaration

```
protected static HashSet<Assembly> m_registeredAssemblies
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<System.Reflection.Assembly\> |     |

#### Static

##### Declaration

```
public static MyDefinitionManagerBase Static
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionManagerBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionManagerBase.html) |     |

### Properties

#### Definitions

##### Declaration

```
public MyDefinitionSet Definitions { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionSet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionSet.html) |     |

### Methods

#### GetAllDefinitions<T>()

##### Declaration

```
public IEnumerable<T> GetAllDefinitions<T>()
    where T : MyDefinitionBase
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<T> |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### GetDefinition<T>(String)

##### Declaration

```
public T GetDefinition<T>(string subtypeId)
    where T : MyDefinitionBase
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | subtypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### GetDefinition<T>(MyDefinitionId)

##### Declaration

```
public T GetDefinition<T>(MyDefinitionId subtypeId)
    where T : MyDefinitionBase
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | subtypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### GetDefinition<T>(MyStringHash)

##### Declaration

```
public T GetDefinition<T>(MyStringHash subtypeId)
    where T : MyDefinitionBase
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### GetDefinitions<T>()

##### Declaration

```
public IEnumerable<T> GetDefinitions<T>()
    where T : MyDefinitionBase
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<T> |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### GetLoadingSet()

##### Declaration

```
public abstract MyDefinitionSet GetLoadingSet()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyDefinitionSet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionSet.html) |     |

#### GetObjectBuilderType(Type)

##### Declaration

```
public static Type GetObjectBuilderType(Type defType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | defType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Type |     |

#### GetObjectFactory()

##### Declaration

```
public static MyObjectFactory<MyDefinitionTypeAttribute, MyDefinitionBase> GetObjectFactory()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectFactory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectFactory-2.html)<[MyDefinitionTypeAttribute](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDefinitionTypeAttribute.html), [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html)\> |     |

#### GetPostProcessor(Type)

##### Declaration

```
public static MyDefinitionPostprocessor GetPostProcessor(Type obType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | obType |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyDefinitionPostprocessor](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDefinitionPostprocessor.html) |     |
