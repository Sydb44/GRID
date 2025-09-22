---
title: "Interface IMyLcdSurfaceComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyLcdSurfaceComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI"
class: "IMyLcdSurfaceComponent"
---

# Interface IMyLcdSurfaceComponent | Space Engineers ModAPI

Describes LCD surface entity component.

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyLcdSurfaceComponent
```

### Properties

#### InitializedWithBuilder

Gets whether the component got deserialized state from object builder

##### Declaration

```
bool InitializedWithBuilder { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SelectedRotationIndex

Gets LCD content rotation

##### Declaration

```
int SelectedRotationIndex { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 | Index from 0 to 3 (90 degree step) |

### Methods

#### OnRemovedFromScene(Object)

Notifies the component of containers' OnRemovedFromScene event

##### Declaration

```
void OnRemovedFromScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

#### SetRenderForAllAreas()

Assigns container block render object to all screen areas

##### Declaration

```
void SetRenderForAllAreas()
```

#### SetSelectedRotationIndex(Int32)

Sets LCD content rotation

##### Declaration

```
void SetSelectedRotationIndex(int newIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | newIndex | Index from 0 to 3 (90 degree step) |

#### UpdateVisibility()

Updates textures based on whether a screen is active or not

##### Declaration