---
title: "Class MyEnvironmentDataView"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentDataView.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment"
class: "MyEnvironmentDataView"
---

# Class MyEnvironmentDataView | Space Engineers ModAPI

##### Inheritance

System.Object

MyEnvironmentDataView

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyEnvironmentDataView : Object
```

### Constructors

#### MyEnvironmentDataView()

##### Declaration

```
protected MyEnvironmentDataView()
```

### Fields

#### End

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

#### IntraSectorOffsets

##### Declaration

```
public List<int> IntraSectorOffsets
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Int32\> |     |

#### Items

##### Declaration

```
public MyList<ItemInfo> Items
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Library.Collections.MyList<[ItemInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.ItemInfo.html)\> |     |

#### Listener

##### Declaration

```
public MyEnvironmentSector Listener
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyEnvironmentSector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSector.html) |     |

#### Lod

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### LogicalSectors

##### Declaration

```
public List<MyLogicalEnvironmentSectorBase> LogicalSectors
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyLogicalEnvironmentSectorBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase.html)\> |     |

#### SectorOffsets

##### Declaration

```
public List<int> SectorOffsets
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Int32\> |     |

#### Start

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

### Methods

#### Close()

##### Declaration

```
public abstract void Close()
```

#### GetLogicalSector(Int32, out Int32, out MyLogicalEnvironmentSectorBase)

##### Declaration

```
public void GetLogicalSector(int item, out int logicalItem, out MyLogicalEnvironmentSectorBase sector)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | item |     |
| System.Int32 | logicalItem |     |
| [MyLogicalEnvironmentSectorBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase.html) | sector |     |