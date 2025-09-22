Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

mySlimBlock

System.Collections.Generic.List<[MyStockpileItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyStockpileItem.html)\>

list

#### SerializeControls(BitStream)

##### Declaration

```
public override void SerializeControls(BitStream stream)
```

##### Parameters

Type

Name

Description

VRage.Library.Collections.BitStream

stream

##### Overrides

#### SetBlockDirty(MySlimBlock)

##### Declaration

```
public void SetBlockDirty(MySlimBlock cubeBlock)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

cubeBlock

#### SetCubeDirty(Vector3I)

##### Declaration

```
public void SetCubeDirty(Vector3I pos)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

pos

#### SetMainCockpit(MyTerminalBlock)

##### Declaration

```
public void SetMainCockpit(MyTerminalBlock cockpit)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MyTerminalBlock

cockpit

#### SetMainRemoteControl(MyTerminalBlock)

##### Declaration

```
public void SetMainRemoteControl(MyTerminalBlock remoteControl)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MyTerminalBlock

remoteControl

#### SetSolarOcclusion(Boolean)

##### Declaration

```
public void SetSolarOcclusion(bool isOccluded)
```

##### Parameters

Type

Name

Description

System.Boolean

isOccluded

#### ShowMessageGridsRemovedWhilePasting()

##### Declaration

```
[Event(null, 1842)]
[Reliable]
[Client]
public static void ShowMessageGridsRemovedWhilePasting()
```

#### ShowMessageGridsRemovedWhilePastingInternal()

##### Declaration

```
public static void ShowMessageGridsRemovedWhilePastingInternal()
```

#### ShowPasteFailedOperation()

##### Declaration

```
[Event(null, 9725)]
[Reliable]
[Client]
public static void ShowPasteFailedOperation()
```

#### SkinBlocks(Vector3I, Vector3I, Nullable<Vector3>, Nullable<MyStringHash>, Boolean)

Skin block in area. Verry slow.

##### Declaration

```
public void SkinBlocks(Vector3I min, Vector3I max, Nullable<Vector3> newHSV, Nullable<MyStringHash> newSkin, bool playSound)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

newHSV

System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\>

newSkin

System.Boolean

playSound

#### SkinGrid(Vector3, MyStringHash, Boolean, Boolean, Boolean)

##### Declaration

```
public void SkinGrid(Vector3 newHSV, MyStringHash newSkin, bool playSound, bool applyColor, bool applySkin)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

newHSV

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

newSkin

System.Boolean

playSound

System.Boolean

applyColor

System.Boolean

applySkin

#### SplitByPlane(PlaneD)

##### Declaration

```
public MyCubeGrid SplitByPlane(PlaneD plane)
```

##### Parameters

Type

Name

Description

[PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html)

plane

##### Returns

Type

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

#### StartConverting(Boolean)

##### Declaration

```
public static void StartConverting(bool placeOnly)
```

##### Parameters

Type

Name

Description

System.Boolean

placeOnly

#### StartReplay()

##### Declaration

```
public void StartReplay()
```

#### StaticGlobalGrid\_UGToWorld(Vector3D, Single, Boolean)

Converts static global uniform grid coordinate to world coordinate. Grid size is already used inside calculation.

##### Declaration

```
public static Vector3D StaticGlobalGrid_UGToWorld(Vector3D ugPos, float gridSize, bool staticGridAlignToCenter)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

ugPos

System.Single

gridSize

System.Boolean

staticGridAlignToCenter

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### StaticGlobalGrid\_WorldToUG(Vector3D, Single, Boolean)

Converts world coordinate to static global grid uniform coordinate (virtual large grid in whole world which every large grid is snapped to). Grid size is already used inside calculation.

##### Declaration

```
public static Vector3D StaticGlobalGrid_WorldToUG(Vector3D worldPos, float gridSize, bool staticGridAlignToCenter)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

worldPos

System.Single

gridSize

System.Boolean

staticGridAlignToCenter

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### StaticGlobalGrid\_WorldToUGInt(Vector3D, Single, Boolean)

Converts world coordinate to static global grid uniform coordinate (virtual large grid in whole world which every large grid is snapped to). Grid size is already used inside calculation.

##### Declaration

```
public static Vector3I StaticGlobalGrid_WorldToUGInt(Vector3D worldPos, float gridSize, bool staticGridAlignToCenter)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

worldPos

System.Single

gridSize

System.Boolean

staticGridAlignToCenter
