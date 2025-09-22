---
title: "Interface IMyDecalHandler"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyDecalHandler.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Interfaces"
class: "IMyDecalHandler"
---

# Interface IMyDecalHandler | Space Engineers ModAPI

###### **Namespace**: [VRage.Game.ModAPI.Interfaces](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyDecalHandler
```

### Methods

#### AddDecal(ref MyDecalRenderInfo, List<UInt32>)

Adds decal

##### Declaration

```
void AddDecal(ref MyDecalRenderInfo renderInfo, List<uint> ids = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRageRender.MyDecalRenderInfo | renderInfo | Information about decal |
| System.Collections.Generic.List<System.UInt32\> | ids | If not null, generated decal ids would be added to that list |