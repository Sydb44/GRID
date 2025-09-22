##### Declaration

```
protected override void CreateTerminalControls()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.CreateTerminalControls()

#### Crouch()

##### Declaration

#### Die()

##### Declaration

#### Down()

##### Declaration

#### DrawHud(IMyCameraController, Int64)

##### Declaration

```
public void DrawHud(IMyCameraController camera, long playerId)
```

##### Parameters

Type

Name

Description

[IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html)

camera

System.Int64

playerId

#### EndShoot(MyShootActionEnum)

##### Declaration

```
public void EndShoot(MyShootActionEnum action)
```

##### Parameters

Type

Name

Description

[MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html)

action

#### EndShootAll()

##### Declaration

```
protected void EndShootAll()
```

#### EndShootSync(MyShootActionEnum)

##### Declaration

```
public void EndShootSync(MyShootActionEnum action)
```

##### Parameters

Type

Name

Description

[MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html)

action

#### FindProjectedBlock()

##### Declaration

```
public MyWelder.ProjectionRaycastData FindProjectedBlock()
```

##### Returns

Type

Description

Sandbox.Game.Weapons.MyWelder.ProjectionRaycastData

#### ForceReleaseControl()

##### Declaration

```
public virtual void ForceReleaseControl()
```

#### GetActiveToolPosition()

##### Declaration

```
public Vector3D GetActiveToolPosition()
```

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetArtificialGravity()

##### Declaration

```
public Vector3D GetArtificialGravity()
```

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetCameraEntitySettings()

##### Declaration

```
public MyEntityCameraSettings GetCameraEntitySettings()
```

##### Returns

Type

Description

Sandbox.Game.Multiplayer.MyEntityCameraSettings

#### GetHeadMatrix(Boolean, Boolean, Boolean, Boolean)

##### Declaration

```
public virtual MatrixD GetHeadMatrix(bool includeY, bool includeX = true, bool forceBoneMatrix = false, bool forceHeadBone = false)
```

##### Parameters

Type

Name

Description

System.Boolean

includeY

System.Boolean

includeX

System.Boolean

forceBoneMatrix

System.Boolean

forceHeadBone

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### GetNaturalGravity()

##### Declaration

```
public Vector3D GetNaturalGravity()
```

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetNetState()

##### Declaration

```
public MyGridClientState GetNetState()
```

##### Returns

Type

Description

Sandbox.Game.Replication.ClientStates.MyGridClientState

#### GetObjectBuilderCubeBlock(Boolean)

##### Declaration

```
public override MyObjectBuilder_CubeBlock GetObjectBuilderCubeBlock(bool copy = false)
```

##### Parameters

Type

Name

Description

System.Boolean

copy

##### Returns

Type

Description

[MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html)

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.GetObjectBuilderCubeBlock(System.Boolean)

#### GetTotalGravity()

##### Declaration

```
public Vector3D GetTotalGravity()
```

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetViewMatrix()

##### Declaration

```
public override MatrixD GetViewMatrix()
```

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

##### Overrides

#### GetWorldMatrix()

##### Declaration

```
public MatrixD GetWorldMatrix()
```

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### HasPriorityOver(MyShipController, MyShipController)

##### Declaration

```
public static bool HasPriorityOver(MyShipController first, MyShipController second)
```

##### Parameters

Type

Name

Description

[MyShipController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyShipController.html)

first

[MyShipController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyShipController.html)

second

##### Returns

Type

Description

System.Boolean

#### Init(MyObjectBuilder\_CubeBlock, MyCubeGrid)

##### Declaration

```
public override void Init(MyObjectBuilder_CubeBlock objectBuilder, MyCubeGrid cubeGrid)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html)

objectBuilder

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

cubeGrid

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.Init(VRage.Game.MyObjectBuilder\_CubeBlock, Sandbox.Game.Entities.MyCubeGrid)

#### IsCameraController()

##### Declaration

```
protected virtual bool IsCameraController()
```

##### Returns

Type

Description

System.Boolean

#### IsControllingCockpit()

##### Declaration

```
protected bool IsControllingCockpit()
```

##### Returns

Type

Description

System.Boolean

#### IsLargeShip()

##### Declaration

```
public virtual bool IsLargeShip()
```

##### Returns

Type

Description

System.Boolean

#### IsMainCockpitFree()

##### Declaration

```
protected bool IsMainCockpitFree()
```

##### Returns

Type

Description

System.Boolean

#### IsShipToolSelected()
