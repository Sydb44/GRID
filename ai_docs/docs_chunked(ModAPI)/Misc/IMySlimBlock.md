---
title: "Interface IMySlimBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMySlimBlock.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame"
class: "IMySlimBlock"
---

# Interface IMySlimBlock | Space Engineers ModAPI

Basic block interface (PB scripting interface)

###### **Namespace**: [VRage.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMySlimBlock
```

### Properties

#### AccumulatedDamage

Current accumlated damage, pending application

##### Declaration

```
float AccumulatedDamage { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BlockDefinition

Block definition ID

##### Declaration

```
SerializableDefinitionId BlockDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html) |     |

#### BuildIntegrity

Build integrity (of components)

##### Declaration

```
float BuildIntegrity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BuildLevelRatio

Ratio of BuildIntegrity and MaxIntegrity

##### Declaration

```
float BuildLevelRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ColorMaskHSV

Gets the color of the block

##### Declaration

```
Vector3 ColorMaskHSV { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### CubeGrid

Gets the grid the slimblock is on

##### Declaration

```
IMyCubeGrid CubeGrid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeGrid.html) |     |

#### CurrentDamage

BuildIntegrity - Integrity

##### Declaration

```
float CurrentDamage { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DamageRatio

##### Declaration

```
float DamageRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FatBlock

Gets the fatblock if there is one

##### Declaration

```
IMyCubeBlock FatBlock { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) |     |

#### HasDeformation

If this block is deformed (bones deformed)

##### Declaration

```
bool HasDeformation { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsDestroyed

Gets if component stack is empty

##### Declaration

```
bool IsDestroyed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsFullIntegrity

Integrity is at maximum

##### Declaration

```
bool IsFullIntegrity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsFullyDismounted

Gets if component stack is empty

##### Declaration

```
bool IsFullyDismounted { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Mass

Block mass

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxDeformation

Maximum deformation of block

##### Declaration

```
float MaxDeformation { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxIntegrity

The maximum integrity of block

##### Declaration

```
float MaxIntegrity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OwnerId

Fatblock owner, if present; otherwise grid owner

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### Position

Grid relative position of block

##### Declaration

```
Vector3I Position { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### ShowParts

Gets if sub parts are shown

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SkinSubtypeId

Gets the skin of the block

##### Declaration

```
MyStringHash SkinSubtypeId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### StockpileAllocated

A component stockpile has been allocated

##### Declaration

```
bool StockpileAllocated { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### StockpileEmpty

The component stockpile is empty (no build components)

##### Declaration

```
bool StockpileEmpty { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetMissingComponents(Dictionary<String, Int32>)

Gets the list of missing components for this block

##### Declaration

```
void GetMissingComponents(Dictionary<string, int> addToDictionary)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Int32\> | addToDictionary |     |