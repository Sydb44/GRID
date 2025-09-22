---
title: "Interface IMyCubeBuilder"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeBuilder.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyCubeBuilder"
---

# Interface IMyCubeBuilder | Space Engineers ModAPI

Describes hand, than holding block (mods interface)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyCubeBuilder
```

### Properties

#### BlockCreationIsActivated

Returns state of building mode

##### Declaration

```
bool BlockCreationIsActivated { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FreezeGizmo

Freezes the built object preview in current position

##### Declaration

```
bool FreezeGizmo { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsActivated

Gets whether there block creation is activated

##### Declaration

```
bool IsActivated { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowRemoveGizmo

Shows the delete area preview

##### Declaration

```
bool ShowRemoveGizmo { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UseSymmetry

Enables symmetry block placing

##### Declaration

```
bool UseSymmetry { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UseTransparency

Gets or sets whether projected block should be 25% transparent

##### Declaration

```
bool UseTransparency { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Activate(Nullable<MyDefinitionId>)

Activates the building mode

##### Declaration

```
void Activate(Nullable<MyDefinitionId> blockDefinitionId = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> | blockDefinitionId |     |

#### AddConstruction(IMyEntity)

##### Declaration

```
bool AddConstruction(IMyEntity buildingEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | buildingEntity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Deactivate()

Deactivates all modes

##### Declaration

#### DeactivateBlockCreation()

Deactivates building mode

##### Declaration

```
void DeactivateBlockCreation()
```

#### FindClosestGrid()

Finds grid to build on

##### Declaration

```
IMyCubeGrid FindClosestGrid()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | Found grid |

#### StartNewGridPlacement(MyCubeSize, Boolean)

##### Declaration

```
void StartNewGridPlacement(MyCubeSize cubeSize, bool isStatic)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeSize](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCubeSize.html) | cubeSize | Ignored |
| System.Boolean | isStatic | Ignored |