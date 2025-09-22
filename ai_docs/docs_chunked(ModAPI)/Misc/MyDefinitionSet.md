---
title: "Class MyDefinitionSet"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionSet.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyDefinitionSet"
---

# Class MyDefinitionSet | Space Engineers ModAPI

##### Inheritance

System.Object

MyDefinitionSet

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyDefinitionSet : Object
```

### Constructors

#### MyDefinitionSet()

##### Declaration

### Fields

#### Context

##### Declaration

```
public MyModContext Context
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyModContext](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyModContext.html) |     |

#### Definitions

##### Declaration

```
public readonly Dictionary<Type, Dictionary<MyStringHash, MyDefinitionBase>> Definitions
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.Dictionary<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html), [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html)\>> |     |

### Methods

#### AddDefinition(MyDefinitionBase)

##### Declaration

```
public void AddDefinition(MyDefinitionBase def)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html) | def |     |

#### AddOrReplaceDefinition(MyDefinitionBase)

##### Declaration

```
public bool AddOrReplaceDefinition(MyDefinitionBase def)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html) | def |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Clear()

##### Declaration

#### ContainsDefinition(MyDefinitionId)

##### Declaration

```
public bool ContainsDefinition(MyDefinitionId id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetDefinition<T>(MyDefinitionId)

##### Declaration

```
public T GetDefinition<T>(MyDefinitionId id)
    where T : MyDefinitionBase
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | id  |     |

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

#### GetDefinitionsOfType<T>()

##### Declaration

```
public IEnumerable<T> GetDefinitionsOfType<T>()
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

#### GetDefinitionsOfTypeAndSubtypes<T>()

##### Declaration

```
public IEnumerable<T> GetDefinitionsOfTypeAndSubtypes<T>()
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

#### OverrideBy(MyDefinitionSet, Boolean)

##### Declaration

```
public virtual void OverrideBy(MyDefinitionSet definitionSet, bool isBasic)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionSet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionSet.html) | definitionSet |     |
| System.Boolean | isBasic |     |

#### RemoveDefinition(ref MyDefinitionId)

##### Declaration

```
public void RemoveDefinition(ref MyDefinitionId defId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | defId |     |