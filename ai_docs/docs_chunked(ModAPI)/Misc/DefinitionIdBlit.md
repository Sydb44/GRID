---
title: "Class DefinitionIdBlit"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.DefinitionIdBlit.html"
category: "Misc"
namespace: "VRage.Game"
class: "DefinitionIdBlit"
---

# Class DefinitionIdBlit | Space Engineers ModAPI

##### Inheritance

System.Object

DefinitionIdBlit

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class DefinitionIdBlit : ValueType
```

### Constructors

#### DefinitionIdBlit(MyObjectBuilderType, MyStringHash)

##### Declaration

```
public DefinitionIdBlit(MyObjectBuilderType type, MyStringHash subtypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeId |     |

#### DefinitionIdBlit(MyRuntimeObjectBuilderId, MyStringHash)

##### Declaration

```
public DefinitionIdBlit(MyRuntimeObjectBuilderId typeId, MyStringHash subtypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyRuntimeObjectBuilderId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyRuntimeObjectBuilderId.html) | typeId |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeId |     |

### Fields

#### SubtypeId

##### Declaration

```
public MyStringHash SubtypeId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### TypeId

##### Declaration

```
[NoSerialize]
public MyRuntimeObjectBuilderId TypeId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyRuntimeObjectBuilderId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyRuntimeObjectBuilderId.html) |     |

### Properties

#### IsValid

##### Declaration

```
public bool IsValid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### Operators

#### Implicit(DefinitionIdBlit to MyDefinitionId)

##### Declaration

```
public static implicit operator MyDefinitionId(DefinitionIdBlit id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [DefinitionIdBlit](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.DefinitionIdBlit.html) | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### Implicit(MyDefinitionId to DefinitionIdBlit)

##### Declaration

```
public static implicit operator DefinitionIdBlit(MyDefinitionId id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| [DefinitionIdBlit](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.DefinitionIdBlit.html) |     |