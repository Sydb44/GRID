---
title: "Class MyObjectBuilder\\_Base"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html"
category: "Misc"
namespace: "VRage.ObjectBuilders"
class: "MyObjectBuilder_Base"
---

# Class MyObjectBuilder\_Base | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Base

###### **Namespace**: [VRage.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MyObjectBuilder_Base : Object
```

### Constructors

#### MyObjectBuilder\_Base()

##### Declaration

```
protected MyObjectBuilder_Base()
```

### Properties

#### SubtypeId

##### Declaration

```
public MyStringHash SubtypeId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### SubtypeName

##### Declaration

```
[NoSerialize]
public string SubtypeName { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### TypeId

##### Declaration

```
public MyObjectBuilderType TypeId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) |     |

### Methods

#### Clone()

##### Declaration

```
public virtual MyObjectBuilder_Base Clone()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) |     |

#### Equals(MyObjectBuilder\_Base)

##### Declaration

```
public virtual bool Equals(MyObjectBuilder_Base obj2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) | obj2 |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeSubtypeId()

##### Declaration

```
public bool ShouldSerializeSubtypeId()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods