---
title: "Interface IMyHazardExposureComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyHazardExposureComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI"
class: "IMyHazardExposureComponent"
---

# Interface IMyHazardExposureComponent | Space Engineers ModAPI

Describes session component responsible for hazard exposure application

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyHazardExposureComponent
```

### Methods

#### AddSource(IMyHazardSource)

##### Declaration

```
void AddSource(IMyHazardSource src)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyHazardSource](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyHazardSource.html) | src | Hazard source implementation |

#### GetCurrentlyProcessedSources(List<IMyHazardSource>)

Gets references to sources in the processing list

##### Declaration

```
void GetCurrentlyProcessedSources(List<IMyHazardSource> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyHazardSource](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyHazardSource.html)\> | result | An empty list to hold references |

#### RemoveSource(IMyHazardSource)

Removes specific source from the processing list

##### Declaration

```
bool RemoveSource(IMyHazardSource toRemove)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyHazardSource](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyHazardSource.html) | toRemove | [IMyHazardSource](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyHazardSource.html) to be removed |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the source was found and removed |

#### RemoveSource<T>()

##### Declaration

```
void RemoveSource<T>()
    where T : IMyHazardSource
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |