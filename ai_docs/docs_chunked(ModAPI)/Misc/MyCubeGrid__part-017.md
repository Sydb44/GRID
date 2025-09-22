System.Boolean

isVolumetric

##### Returns

Type

Description

System.Boolean

#### IsMainCockpit(MyTerminalBlock)

##### Declaration

```
public bool IsMainCockpit(MyTerminalBlock cockpit)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MyTerminalBlock

cockpit

##### Returns

Type

Description

System.Boolean

#### IsMainRemoteControl(MyTerminalBlock)

##### Declaration

```
public bool IsMainRemoteControl(MyTerminalBlock remoteControl)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MyTerminalBlock

remoteControl

##### Returns

Type

Description

System.Boolean

#### IsRoomAtPositionAirtight(Vector3I)

##### Declaration

```
public bool IsRoomAtPositionAirtight(Vector3I pos)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

pos

##### Returns

Type

Description

System.Boolean

#### IsSameConstructAs(IMyCubeGrid)

##### Declaration

```
public bool IsSameConstructAs(IMyCubeGrid other)
```

##### Parameters

Type

Name

Description

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)

other

##### Returns

Type

Description

System.Boolean

#### IsTouchingAnyNeighbor(Vector3I, Vector3I)

##### Declaration

```
public bool IsTouchingAnyNeighbor(Vector3I min, Vector3I max)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

##### Returns

Type

Description

System.Boolean

#### JumpWithWheels(Boolean)

##### Declaration

```
public void JumpWithWheels(bool initiate)
```

##### Parameters

Type

Name

Description

System.Boolean

initiate

#### KillAllCharacters(MyCubeGrid, Boolean)

##### Declaration

```
public static void KillAllCharacters(MyCubeGrid grid, bool removePilot = true)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

grid

System.Boolean

removePilot

#### LocalToGridInteger(Vector3)

##### Declaration

```
public Vector3I LocalToGridInteger(Vector3 localCoords)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

localCoords

##### Returns

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### LogHierarchy()

##### Declaration

```
public void LogHierarchy()
```

#### MarkAsTrash()

##### Declaration

```
public void MarkAsTrash()
```

#### MechanicalConnectionBlockAttachUpdateStatusChanged(MyMechanicalConnectionBlockBase)

##### Declaration

```
public void MechanicalConnectionBlockAttachUpdateStatusChanged(MyMechanicalConnectionBlockBase mechConBlock)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Blocks.MyMechanicalConnectionBlockBase

mechConBlock

#### MergeGrid\_MergeBlock(MyCubeGrid, Vector3I, Boolean)

Called from MergeBlock to initialte merge of two grids

##### Declaration

```
public MyCubeGrid MergeGrid_MergeBlock(MyCubeGrid gridToMerge, Vector3I gridOffset, bool checkMergeOrder = true)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

gridToMerge

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridOffset

System.Boolean

checkMergeOrder

##### Returns

Type

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

#### ModifyGroup(MyBlockGroup)

##### Declaration

```
public void ModifyGroup(MyBlockGroup group)
```

##### Parameters

Type

Name

Description

Sandbox.Game.GameSystems.MyBlockGroup

group

#### MultiplyBlockSkeleton(MySlimBlock, Single, Boolean)

##### Declaration

```
public void MultiplyBlockSkeleton(MySlimBlock block, float factor, bool updateSync = false)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

System.Single

factor

System.Boolean

updateSync

#### OnAddedToScene(Object)

##### Declaration

```
public override void OnAddedToScene(object source)
```

##### Parameters

Type

Name

Description

System.Object

source

##### Overrides

#### OnChangeOwnersRequestConfirmation(Guid, Int64, Boolean)

##### Declaration

```
[Event(null, 10709)]
[Reliable]
[Server]
public static void OnChangeOwnersRequestConfirmation(Guid requestBatchGuid, long gridId, bool confirmation)
```

##### Parameters

Type

Name

Description

System.Guid

requestBatchGuid

System.Int64

gridId

System.Boolean

confirmation

#### OnClosedMessageBox(MyGuiScreenMessageBox.ResultEnum)

##### Declaration

```
public void OnClosedMessageBox(MyGuiScreenMessageBox.ResultEnum result)
```

##### Parameters

Type

Name

Description

Sandbox.Graphics.GUI.MyGuiScreenMessageBox.ResultEnum

result

#### OnConvertedToStationRequest()

##### Declaration

```
[Event(null, 10035)]
[Reliable]
[Server]
public void OnConvertedToStationRequest()
```

#### OnConvertToDynamic()

Conversion from Unsupported station. For generic conversion to dynamic use physics component. Sets up the Unsupported station state.

##### Declaration

```
[Event(null, 5456)]
[Reliable]
[ServerInvoked]
[Broadcast]
public void OnConvertToDynamic()
```

#### OnGridPresenceUpdate(Boolean)

##### Declaration

```
public void OnGridPresenceUpdate(bool isAnyGridPresent)
```

##### Parameters

Type

Name

Description

System.Boolean

isAnyGridPresent

#### OnIntegrityChanged(MySlimBlock, Boolean)

##### Declaration

```
public void OnIntegrityChanged(MySlimBlock block, bool handWelded)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

System.Boolean

handWelded
