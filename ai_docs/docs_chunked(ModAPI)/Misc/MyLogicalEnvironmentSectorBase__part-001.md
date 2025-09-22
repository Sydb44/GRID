---
title: "Class MyLogicalEnvironmentSectorBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment"
class: "MyLogicalEnvironmentSectorBase"
---

# Class MyLogicalEnvironmentSectorBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyLogicalEnvironmentSectorBase

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyLogicalEnvironmentSectorBase : Object, IMyEventProxy, IMyEventOwner
```

### Constructors

#### MyLogicalEnvironmentSectorBase()

##### Declaration

```
protected MyLogicalEnvironmentSectorBase()
```

### Fields

#### Bounds

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\] |     |

#### Id

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### WorldPos

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Properties

#### DebugData

##### Declaration

```
public abstract string DebugData { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### MinLod

##### Declaration

```
public int MinLod { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Owner

##### Declaration

```
public IMyEnvironmentOwner Owner { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEnvironmentOwner](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMyEnvironmentOwner.html) |     |

#### ServerOwned

##### Declaration

```
public abstract bool ServerOwned { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Close()

##### Declaration

```
public virtual void Close()
```

#### DebugDraw(Int32)

##### Declaration

```
public abstract void DebugDraw(int lod)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | lod |     |

#### DisableItemsInBox(Vector3D, ref BoundingBoxD)

##### Declaration

```
public abstract void DisableItemsInBox(Vector3D center, ref BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | center |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |

#### EnableItem(Int32, Boolean)

##### Declaration

```
public abstract void EnableItem(int itemId, bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |
| System.Boolean | enabled |     |

#### GetItem(Int32, out ItemInfo)

##### Declaration

```
public abstract void GetItem(int logicalItem, out ItemInfo item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | logicalItem |     |
| [ItemInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.ItemInfo.html) | item |     |

#### GetItemDefinition(UInt16, out MyRuntimeEnvironmentItemInfo)

##### Declaration

```
public abstract void GetItemDefinition(ushort index, out MyRuntimeEnvironmentItemInfo def)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | index |     |
| Sandbox.Game.WorldEnvironment.Definitions.MyRuntimeEnvironmentItemInfo | def |     |

#### GetItemDefinitionId(Int32)

##### Declaration

```
public abstract int GetItemDefinitionId(int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetItemsInAabb(ref BoundingBoxD, List<Int32>)

##### Declaration

```
public abstract void GetItemsInAabb(ref BoundingBoxD aabb, List<int> itemsInBox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb |     |
| System.Collections.Generic.List<System.Int32\> | itemsInBox |     |

#### GetObjectBuilder()

##### Declaration

```
public abstract MyObjectBuilder_EnvironmentSector GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.WorldEnvironment.ObjectBuilders.MyObjectBuilder\_EnvironmentSector |     |

#### Init(MyObjectBuilder\_EnvironmentSector)

##### Declaration

```
public abstract void Init(MyObjectBuilder_EnvironmentSector sectorBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.WorldEnvironment.ObjectBuilders.MyObjectBuilder\_EnvironmentSector | sectorBuilder |     |

#### InvalidateItem(Int32)

##### Declaration

```
public abstract void InvalidateItem(int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |

#### IterateItems(MyLogicalEnvironmentSectorBase.ItemIterator)

##### Declaration

```
public abstract void IterateItems(MyLogicalEnvironmentSectorBase.ItemIterator action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyLogicalEnvironmentSectorBase.ItemIterator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase.ItemIterator.html) | action |     |

#### RaiseItemEvent<T>(Int32, ref MyDefinitionId, T, Boolean)

##### Declaration

```
public abstract void RaiseItemEvent<T>(int logicalItem, ref MyDefinitionId modDef, T eventData, bool fromClient)
```
