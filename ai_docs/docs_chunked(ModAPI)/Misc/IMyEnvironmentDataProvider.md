---
title: "Interface IMyEnvironmentDataProvider"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMyEnvironmentDataProvider.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment"
class: "IMyEnvironmentDataProvider"
---

# Interface IMyEnvironmentDataProvider | Space Engineers ModAPI

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyEnvironmentDataProvider
```

### Properties

#### LogicalSectors

##### Declaration

```
IEnumerable<MyLogicalEnvironmentSectorBase> LogicalSectors { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<[MyLogicalEnvironmentSectorBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase.html)\> |     |

### Methods

#### DebugDraw()

##### Declaration

#### GetItemView(Int32, ref Vector2I, ref Vector2I, ref Vector3D)

##### Declaration

```
MyEnvironmentDataView GetItemView(int lod, ref Vector2I start, ref Vector2I end, ref Vector3D localOrigin)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | lod |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | start |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | end |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | localOrigin |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyEnvironmentDataView](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentDataView.html) |     |

#### GetLogicalSector(Int64)

##### Declaration

```
MyLogicalEnvironmentSectorBase GetLogicalSector(long sectorId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | sectorId |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyLogicalEnvironmentSectorBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase.html) |     |

#### GetObjectBuilder()

##### Declaration

```
MyObjectBuilder_EnvironmentDataProvider GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.WorldEnvironment.ObjectBuilders.MyObjectBuilder\_EnvironmentDataProvider |     |

#### RevalidateItem(Int64, Int32)

##### Declaration

```
void RevalidateItem(long sectorId, int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | sectorId |     |
| System.Int32 | itemId |     |