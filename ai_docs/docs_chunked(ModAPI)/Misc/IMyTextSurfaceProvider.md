---
title: "Interface IMyTextSurfaceProvider"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextSurfaceProvider.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyTextSurfaceProvider"
---

# Interface IMyTextSurfaceProvider | Space Engineers ModAPI

Describes block, that has at least 1 text surface (PB scripting interface)

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTextSurfaceProvider
```

### Properties

#### SurfaceCount

Get surfaces count

##### Declaration

```
int SurfaceCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### UseGenericLcd

Whether generic LCD terminal controls should be created

##### Declaration

```
bool UseGenericLcd { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetSurface(Int32)

Get surface by index

##### Declaration

```
IMyTextSurface GetSurface(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyTextSurface](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextSurface.html) | TextSurface if index in \[0..SurfaceCount-1\] and null if out of bounds |