---
title: "Class MyObjectBuilder\\_BlockItem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_BlockItem.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_BlockItem"
---

# Class MyObjectBuilder\_BlockItem | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_BlockItem

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_BlockItem : MyObjectBuilder_PhysicalObject
```

### Constructors

#### MyObjectBuilder\_BlockItem()

##### Declaration

```
public MyObjectBuilder_BlockItem()
```

### Fields

#### BlockDefId

##### Declaration

```
public SerializableDefinitionId BlockDefId
```

##### Field Value

| Type | Description |
| --- | --- |
| [SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html) |     |

### Methods

#### CanStack(MyObjectBuilder\_PhysicalObject)

##### Declaration

```
public override bool CanStack(MyObjectBuilder_PhysicalObject a)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html) | a   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### CanStack(MyObjectBuilderType, MyStringHash, MyItemFlags)

##### Declaration

```
public override bool CanStack(MyObjectBuilderType typeId, MyStringHash subtypeId, MyItemFlags flags)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | typeId |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeId |     |
| [MyItemFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyItemFlags.html) | flags |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### GetObjectId()

##### Declaration

```
public override MyDefinitionId GetObjectId()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

##### Overrides

### Extension Methods