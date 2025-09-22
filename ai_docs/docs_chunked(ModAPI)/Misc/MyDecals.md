---
title: "Class MyDecals"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyDecals.html"
category: "Misc"
namespace: "Sandbox.Game"
class: "MyDecals"
---

# Class MyDecals | Space Engineers ModAPI

##### Inheritance

System.Object

MyDecals

##### Implements

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyDecals : Object, IMyDecalHandler
```

### Methods

#### AddDecal(ref MyDecalRenderInfo, List<UInt32>)

Add decal raw

##### Declaration

```
public static void AddDecal(ref MyDecalRenderInfo data, List<uint> decals)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRageRender.MyDecalRenderInfo | data | Data |
| System.Collections.Generic.List<System.UInt32\> | decals | If not null, generated decal ids would be added to that list |

#### HandleAddDecal(IMyEntity, MyHitInfo, Vector3, MyStringHash, MyStringHash, Object, Single, MyStringHash, Boolean, MyDecalFlags, Int32, List<UInt32>)

Adds decal

##### Declaration

```
public static void HandleAddDecal(IMyEntity entity, MyHitInfo hitInfo, Vector3 forwardDirection, MyStringHash physicalMaterial = null, MyStringHash source = null, object customdata = null, float damage = -1F, MyStringHash voxelMaterial = null, bool isTrail = false, MyDecalFlags flags, int aliveUntil = 2147483647, List<uint> decals = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity that should have decal |
| [MyHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyHitInfo.html) | hitInfo | Describes where it should be placed |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | forwardDirection | Use for rotation of decal |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | physicalMaterial | Physical material |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | source | Decal material |
| System.Object | customdata | Extra information about how decal should be positioned |
| System.Single | damage | Not used |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | voxelMaterial | Voxel material |
| System.Boolean | isTrail | Is it trail, that wheels are leaving |
| VRageRender.MyDecalFlags | flags | VRageRender.MyDecalFlags |
| System.Int32 | aliveUntil | Time in frames. When it is less than [GameplayFrameCounter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySession.html#VRage_Game_ModAPI_IMySession_GameplayFrameCounter), it would be removed |
| System.Collections.Generic.List<System.UInt32\> | decals | If not null, generated decal ids would be added to that list |

#### RemoveDecal(UInt32, Boolean)

Removes decals with specified Id

##### Declaration

```
public static void RemoveDecal(uint decalId, bool immediately = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | decalId | Id, that was returned on [HandleAddDecal(IMyEntity, MyHitInfo, Vector3, MyStringHash, MyStringHash, Object, Single, MyStringHash, Boolean, MyDecalFlags, Int32, List<UInt32>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyDecals.html#Sandbox_Game_MyDecals_HandleAddDecal_VRage_ModAPI_IMyEntity_VRage_Game_ModAPI_MyHitInfo_VRageMath_Vector3_VRage_Utils_MyStringHash_VRage_Utils_MyStringHash_System_Object_System_Single_VRage_Utils_MyStringHash_System_Boolean_VRageRender_MyDecalFlags_System_Int32_System_Collections_Generic_List_System_UInt32__) |
| System.Boolean | immediately | When it is false - slowly disappears |

#### UpdateDecals(List<MyDecalPositionUpdate>)

Updates decals position and matrix by id

##### Declaration

```
public static void UpdateDecals(List<MyDecalPositionUpdate> decals)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<VRageRender.Messages.MyDecalPositionUpdate\> | decals | Decals to update |

### Explicit Interface Implementations

#### IMyDecalHandler.AddDecal(ref MyDecalRenderInfo, List<UInt32>)

##### Declaration

```
void IMyDecalHandler.AddDecal(ref MyDecalRenderInfo data, List<uint> ids)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRageRender.MyDecalRenderInfo | data |     |
| System.Collections.Generic.List<System.UInt32\> | ids |     |

### Implements