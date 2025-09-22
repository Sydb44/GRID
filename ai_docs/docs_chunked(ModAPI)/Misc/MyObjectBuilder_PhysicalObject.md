---
title: "Class MyObjectBuilder\\_PhysicalObject"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_PhysicalObject"
---

# Class MyObjectBuilder\_PhysicalObject | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_PhysicalObject

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_PhysicalObject : MyObjectBuilder_Base
```

### Constructors

#### MyObjectBuilder\_PhysicalObject()

##### Declaration

```
public MyObjectBuilder_PhysicalObject()
```

#### MyObjectBuilder\_PhysicalObject(MyItemFlags)

##### Declaration

```
public MyObjectBuilder_PhysicalObject(MyItemFlags flags)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyItemFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyItemFlags.html) | flags |     |

### Fields

#### DurabilityHP

This is used for GUI to show the amount of health points (durability) of the weapons and tools. This is updated through Durability entity component if entity exists..

##### Declaration

```
public Nullable<float> DurabilityHP
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### Flags

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [MyItemFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyItemFlags.html) |     |

### Methods

#### CanStack(MyObjectBuilder\_PhysicalObject)

##### Declaration

```
public virtual bool CanStack(MyObjectBuilder_PhysicalObject a)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html) | a   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanStack(MyObjectBuilderType, MyStringHash, MyItemFlags)

##### Declaration

```
public virtual bool CanStack(MyObjectBuilderType typeId, MyStringHash subtypeId, MyItemFlags flags)
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

#### GetInstanceOnStackSplit()

Since 204 items like gas containers can stack. All items that has data, that can change should override this method, and return a clone.

##### Declaration

```
public virtual MyObjectBuilder_PhysicalObject GetInstanceOnStackSplit()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html) | This or clone of this object |

#### GetObjectId()

##### Declaration

```
public virtual MyDefinitionId GetObjectId()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### ShouldSerializeDurabilityHP()

##### Declaration

```
public bool ShouldSerializeDurabilityHP()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods