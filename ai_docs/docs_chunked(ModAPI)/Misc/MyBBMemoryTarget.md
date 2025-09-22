---
title: "Class MyBBMemoryTarget"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyBBMemoryTarget.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyBBMemoryTarget"
---

# Class MyBBMemoryTarget | Space Engineers ModAPI

##### Inheritance

System.Object

MyBBMemoryTarget

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyBBMemoryTarget : MyBBMemoryValue
```

### Constructors

#### MyBBMemoryTarget()

##### Declaration

```
public MyBBMemoryTarget()
```

### Fields

#### CompoundId

##### Declaration

```
public Nullable<ushort> CompoundId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.UInt16\> |     |

#### EntityId

##### Declaration

```
public Nullable<long> EntityId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

#### Position

##### Declaration

```
public Nullable<Vector3D> Position
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### TargetType

##### Declaration

```
public MyAiTargetEnum TargetType
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyAiTargetEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyAiTargetEnum.html) |     |

#### TreeId

##### Declaration

```
public Nullable<int> TreeId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int32\> |     |

### Properties

#### BlockPosition

##### Declaration

```
public Vector3I BlockPosition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### VoxelPosition

##### Declaration

```
public Vector3I VoxelPosition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

### Methods

#### SetTargetCompoundBlock(ref MyBBMemoryTarget, Vector3I, Int64, UInt16)

##### Declaration

```
public static void SetTargetCompoundBlock(ref MyBBMemoryTarget target, Vector3I blockPosition, long entityId, ushort compoundId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBBMemoryTarget](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyBBMemoryTarget.html) | target |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | blockPosition |     |
| System.Int64 | entityId |     |
| System.UInt16 | compoundId |     |

#### SetTargetCube(ref MyBBMemoryTarget, Vector3I, Int64)

##### Declaration

```
public static void SetTargetCube(ref MyBBMemoryTarget target, Vector3I blockPosition, long gridEntityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBBMemoryTarget](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyBBMemoryTarget.html) | target |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | blockPosition |     |
| System.Int64 | gridEntityId |     |

#### SetTargetEntity(ref MyBBMemoryTarget, MyAiTargetEnum, Int64, Nullable<Vector3D>)

##### Declaration

```
public static void SetTargetEntity(ref MyBBMemoryTarget target, MyAiTargetEnum targetType, long entityId, Nullable<Vector3D> position = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBBMemoryTarget](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyBBMemoryTarget.html) | target |     |
| [MyAiTargetEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyAiTargetEnum.html) | targetType |     |
| System.Int64 | entityId |     |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | position |     |

#### SetTargetPosition(ref MyBBMemoryTarget, Vector3D)

##### Declaration

```
public static void SetTargetPosition(ref MyBBMemoryTarget target, Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBBMemoryTarget](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyBBMemoryTarget.html) | target |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |

#### SetTargetTree(ref MyBBMemoryTarget, Vector3D, Int64, Int32)

##### Declaration

```
public static void SetTargetTree(ref MyBBMemoryTarget target, Vector3D treePosition, long entityId, int treeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBBMemoryTarget](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyBBMemoryTarget.html) | target |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | treePosition |     |
| System.Int64 | entityId |     |
| System.Int32 | treeId |     |

#### SetTargetVoxel(ref MyBBMemoryTarget, Vector3I, Int64)

##### Declaration

```
public static void SetTargetVoxel(ref MyBBMemoryTarget target, Vector3I voxelPosition, long entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBBMemoryTarget](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyBBMemoryTarget.html) | target |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | voxelPosition |     |
| System.Int64 | entityId |     |

#### UnsetTarget(ref MyBBMemoryTarget)

##### Declaration

```
public static void UnsetTarget(ref MyBBMemoryTarget target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBBMemoryTarget](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyBBMemoryTarget.html) | target |     |