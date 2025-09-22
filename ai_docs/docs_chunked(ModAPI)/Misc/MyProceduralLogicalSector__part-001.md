---
title: "Class MyProceduralLogicalSector"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment"
class: "MyProceduralLogicalSector"
---

# Class MyProceduralLogicalSector | Space Engineers ModAPI

##### Inheritance

System.Object

MyProceduralLogicalSector

##### Inherited Members

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyProceduralLogicalSector : MyLogicalEnvironmentSectorBase, IMyEventProxy, IMyEventOwner
```

### Constructors

#### MyProceduralLogicalSector(MyProceduralEnvironmentProvider, Int32, Int32, Int32, MyObjectBuilder\_ProceduralEnvironmentSector)

##### Declaration

```
public MyProceduralLogicalSector(MyProceduralEnvironmentProvider provider, int x, int y, int localLod, MyObjectBuilder_ProceduralEnvironmentSector moduleData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyProceduralEnvironmentProvider](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyProceduralEnvironmentProvider.html) | provider |     |
| System.Int32 | x   |     |
| System.Int32 | y   |     |
| System.Int32 | localLod |     |
| Sandbox.Game.WorldEnvironment.ObjectBuilders.MyObjectBuilder\_ProceduralEnvironmentSector | moduleData |     |

### Properties

#### DebugData

##### Declaration

```
public override string DebugData { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### ServerOwned

##### Declaration

```
public override bool ServerOwned { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

### Methods

#### AddView(MyProceduralDataView, Vector3D, Int32)

##### Declaration

```
public void AddView(MyProceduralDataView view, Vector3D localOrigin, int logicalLod)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyProceduralDataView](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyProceduralDataView.html) | view |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | localOrigin |     |
| System.Int32 | logicalLod |     |

#### Close()

##### Declaration

```
public override void Close()
```

##### Overrides

#### DebugDraw(Int32)

##### Declaration

```
public override void DebugDraw(int lod)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | lod |     |

##### Overrides

#### DisableItemsInBox(Vector3D, ref BoundingBoxD)

##### Declaration

```
public override void DisableItemsInBox(Vector3D center, ref BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | center |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |

##### Overrides

#### EnableItem(Int32, Boolean)

##### Declaration

```
public override void EnableItem(int itemId, bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |
| System.Boolean | enabled |     |

##### Overrides

#### GetItem(Int32, out ItemInfo)

##### Declaration

```
public override void GetItem(int logicalItem, out ItemInfo item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | logicalItem |     |
| [ItemInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.ItemInfo.html) | item |     |

##### Overrides

#### GetItemDefinition(UInt16, out MyRuntimeEnvironmentItemInfo)

##### Declaration

```
public override void GetItemDefinition(ushort key, out MyRuntimeEnvironmentItemInfo it)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | key |     |
| Sandbox.Game.WorldEnvironment.Definitions.MyRuntimeEnvironmentItemInfo | it  |     |

##### Overrides

#### GetItemDefinitionId(Int32)

##### Declaration

```
public override int GetItemDefinitionId(int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

##### Overrides

#### GetItemsInAabb(ref BoundingBoxD, List<Int32>)

##### Declaration

```
public override void GetItemsInAabb(ref BoundingBoxD aabb, List<int> itemsInBox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb |     |
| System.Collections.Generic.List<System.Int32\> | itemsInBox |     |

##### Overrides

#### GetObjectBuilder()

##### Declaration

```
public override MyObjectBuilder_EnvironmentSector GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.WorldEnvironment.ObjectBuilders.MyObjectBuilder\_EnvironmentSector |     |

##### Overrides

#### Init(MyObjectBuilder\_EnvironmentSector)

##### Declaration

```
public override void Init(MyObjectBuilder_EnvironmentSector sectorBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.WorldEnvironment.ObjectBuilders.MyObjectBuilder\_EnvironmentSector | sectorBuilder |     |

##### Overrides

#### InvalidateItem(Int32)

##### Declaration

```
public override void InvalidateItem(int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |

##### Overrides

#### IterateItems(MyLogicalEnvironmentSectorBase.ItemIterator)

##### Declaration

```
public override void IterateItems(MyLogicalEnvironmentSectorBase.ItemIterator action)
```
