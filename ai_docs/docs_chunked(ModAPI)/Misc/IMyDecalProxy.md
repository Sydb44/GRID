---
title: "Interface IMyDecalProxy"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyDecalProxy.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Interfaces"
class: "IMyDecalProxy"
---

# Interface IMyDecalProxy | Space Engineers ModAPI

###### **Namespace**: [VRage.Game.ModAPI.Interfaces](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyDecalProxy
```

### Methods

#### AddDecals(ref MyHitInfo, MyStringHash, Vector3, Object, IMyDecalHandler, MyStringHash, MyStringHash, Boolean, MyDecalFlags, Int32, List<UInt32>)

Called from Sandbox.Game.MyDecals

##### Declaration

```
void AddDecals(ref MyHitInfo hitInfo, MyStringHash source, Vector3 forwardDirection, object customdata, IMyDecalHandler decalHandler, MyStringHash physicalMaterial, MyStringHash voxelMaterial, bool isTrail, MyDecalFlags flags, int aliveUntil = 2147483647, List<uint> outids = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyHitInfo.html) | hitInfo | Describes where it should be placed |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | source | Decal material |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | forwardDirection | Use for rotation of decal |
| System.Object | customdata | Custom information about how to position decals |
| [IMyDecalHandler](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyDecalHandler.html) | decalHandler | Sandbox.Game.MyDecals instance. |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | physicalMaterial | Physical material |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | voxelMaterial | Voxel material |
| System.Boolean | isTrail | Is it trail, that wheels are leaving |
| VRageRender.MyDecalFlags | flags | VRageRender.MyDecalFlags |
| System.Int32 | aliveUntil | Time in frames. When it is less than [GameplayFrameCounter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySession.html#VRage_Game_ModAPI_IMySession_GameplayFrameCounter), it would be removed |
| System.Collections.Generic.List<System.UInt32\> | outids | If not null, generated decal ids would be added to that list |