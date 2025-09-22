---
title: "Interface IMyProjector"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyProjector.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyProjector"
---

# Interface IMyProjector | Space Engineers ModAPI

Describes projector block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyProjector : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyTextSurfaceProvider
```

### Properties

#### BuildableBlocksCount

Get count of blocks which can be welded now

##### Declaration

```
int BuildableBlocksCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IsProjecting

Checks if there is an active projection

##### Declaration

```
bool IsProjecting { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ProjectionOffset

Gets or sets projection offset

##### Declaration

```
Vector3I ProjectionOffset { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### ProjectionOffsetX

Obsolete

##### Declaration

```
int ProjectionOffsetX { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ProjectionOffsetY

Obsolete

##### Declaration

```
int ProjectionOffsetY { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ProjectionOffsetZ

Obsolete

##### Declaration

```
int ProjectionOffsetZ { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ProjectionRotation

Get or sets projection rotation. These values are not in degrees. 1 = 90 degrees, 2 = 180 degrees

##### Declaration

```
Vector3I ProjectionRotation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### ProjectionRotX

Obsolete

##### Declaration

```
int ProjectionRotX { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ProjectionRotY

Obsolete

##### Declaration

```
int ProjectionRotY { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ProjectionRotZ

Obsolete

##### Declaration

```
int ProjectionRotZ { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### RemainingArmorBlocks

Get number of armor blocks left to be welded

##### Declaration

```
int RemainingArmorBlocks { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### RemainingBlocks

Gets number of blocks left to be welded

##### Declaration

```
int RemainingBlocks { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### RemainingBlocksPerType

Gets comprehensive list of blocks left to be welded

##### Declaration

```
Dictionary<MyDefinitionBase, int> RemainingBlocksPerType { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html), System.Int32\> |     |

#### ShowOnlyBuildable

Gets or set should projection show only buildable blocks

##### Declaration

```
bool ShowOnlyBuildable { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TotalBlocks

Gets total number of blocks in the projection

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### UpdateOffsetAndRotation()

Call this after setting ProjectionOffset and ProjectionRotation to update the projection

##### Declaration

```
void UpdateOffsetAndRotation()
```

### Extension Methods