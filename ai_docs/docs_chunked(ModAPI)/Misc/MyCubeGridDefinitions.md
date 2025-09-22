---
title: "Class MyCubeGridDefinitions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeGridDefinitions.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyCubeGridDefinitions"
---

# Class MyCubeGridDefinitions | Space Engineers ModAPI

##### Inheritance

System.Object

MyCubeGridDefinitions

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[PreloadRequired]
public static class MyCubeGridDefinitions : Object
```

### Fields

#### EdgeOrientations

##### Declaration

```
public static readonly Dictionary<Vector3I, MyEdgeOrientationInfo> EdgeOrientations
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html), [MyEdgeOrientationInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEdgeOrientationInfo.html)\> |     |

#### TileGridOrientations

##### Declaration

```
public static readonly Dictionary<MyStringId, Dictionary<Vector3I, MyTileDefinition>> TileGridOrientations
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html), System.Collections.Generic.Dictionary<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html), [MyTileDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyTileDefinition.html)\>> |     |

### Properties

#### AllPossible90rotations

##### Declaration

```
public static MatrixI[] AllPossible90rotations { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html)\[\] |     |

### Methods

#### GetCubeRotationOptions(MyCubeBlockDefinition)

##### Declaration

```
public static MyRotationOptionsEnum GetCubeRotationOptions(MyCubeBlockDefinition block)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) | block |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyRotationOptionsEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyRotationOptionsEnum.html) |     |

#### GetCubeTiles(MyCubeBlockDefinition)

##### Declaration

```
public static MyTileDefinition[] GetCubeTiles(MyCubeBlockDefinition block)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) | block |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyTileDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyTileDefinition.html)\[\] |     |

#### GetRotatedBlockSize(MyCubeBlockDefinition, ref Matrix, out Vector3I)

##### Declaration

```
public static void GetRotatedBlockSize(MyCubeBlockDefinition block, ref Matrix rotation, out Vector3I size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) | block |     |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | rotation |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | size |     |

#### GetTopologyInfo(MyCubeTopology)

##### Declaration

```
public static MyCubeGridDefinitions.TableEntry GetTopologyInfo(MyCubeTopology topology)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeTopology](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCubeTopology.html) | topology |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyCubeGridDefinitions.TableEntry](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeGridDefinitions.TableEntry.html) |     |

#### GetTopologyUniqueOrientation(MyCubeTopology, MyBlockOrientation)

From 90degrees rotations combinations returns one unique topology orientation, which can differ from input, but the resulted shape of topology is same

##### Declaration

```
public static MyBlockOrientation GetTopologyUniqueOrientation(MyCubeTopology myCubeTopology, MyBlockOrientation orientation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeTopology](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCubeTopology.html) | myCubeTopology | cube topology |
| [MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html) | orientation | input orientation |

##### Returns

| Type | Description |
| --- | --- |
| [MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html) |     |