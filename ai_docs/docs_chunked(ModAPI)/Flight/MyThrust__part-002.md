#### Render

##### Declaration

```
public MyRenderComponentThrust Render { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyRenderComponentThrust](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyRenderComponentThrust.html) |     |

#### ThrustForce

Thrust force direction is opposite to thrust forward vector orientation

##### Declaration

```
public Vector3 ThrustForce { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### ThrustForceLength

##### Declaration

```
public float ThrustForceLength { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ThrustForwardVector

##### Declaration

```
public Vector3I ThrustForwardVector { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### ThrustOverride

Overridden thrust in Newtons

##### Declaration

```
public float ThrustOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ThrustOverrideOverForceLen

Returns ThrustOverride / ThrustForceLength. No division is actually needed after fraction simplification.

##### Declaration

```
public float ThrustOverrideOverForceLen { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### AllowSelfPulling()

##### Declaration

```
public bool AllowSelfPulling()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CheckIsWorking()

##### Declaration

```
protected override bool CheckIsWorking()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.CheckIsWorking()

#### ClearThrustComponent()

##### Declaration

```
public void ClearThrustComponent()
```

#### Closing()

##### Declaration

```
protected override void Closing()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.Closing()

#### Components\_ComponentAdded(Type, IMyEntityComponentBase)

##### Declaration

```
protected override void Components_ComponentAdded(Type t, IMyEntityComponentBase c)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | t   |     |
| VRage.Game.Components.Interfaces.IMyEntityComponentBase | c   |     |

##### Overrides

#### Components\_ComponentRemoved(Type, IMyEntityComponentBase)

##### Declaration

```
protected override void Components_ComponentRemoved(Type t, IMyEntityComponentBase c)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | t   |     |
| VRage.Game.Components.Interfaces.IMyEntityComponentBase | c   |     |

##### Overrides

#### CreateTerminalControls()

##### Declaration

```
protected override void CreateTerminalControls()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.CreateTerminalControls()

#### CubeBlock\_OnWorkingChanged(MyCubeBlock)

##### Declaration

```
public void CubeBlock_OnWorkingChanged(MyCubeBlock block)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html) | block |     |

#### DoUpdateTimerTick()

##### Declaration

```
public override void DoUpdateTimerTick()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.DoUpdateTimerTick()

#### GetDamageCapsuleLine(MyThrustFlameAnimator.FlameInfo, ref MatrixD)

##### Declaration

```
public LineD GetDamageCapsuleLine(MyThrustFlameAnimator.FlameInfo info, ref MatrixD matrixWorld)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.RenderDirect.ActorComponents.MyThrustFlameAnimator.FlameInfo | info |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrixWorld |     |

##### Returns

| Type | Description |
| --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) |     |

#### GetDefaultTimeForUpdateTimer(Int32)

##### Declaration

```
protected override uint GetDefaultTimeForUpdateTimer(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.GetDefaultTimeForUpdateTimer(System.Int32)

#### GetDelegate(Action<IMyThrust, Single>)

##### Declaration

```
public static Action<MyThrust, float> GetDelegate(Action<IMyThrust, float> value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action<[IMyThrust](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyThrust.html), System.Single\> | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Action<[MyThrust](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyThrust.html), System.Single\> |     |

#### GetObjectBuilderCubeBlock(Boolean)

##### Declaration

```
public override MyObjectBuilder_CubeBlock GetObjectBuilderCubeBlock(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html) |     |

##### Overrides

Sandbox.Game.Entities.Cube.MyFunctionalBlock.GetObjectBuilderCubeBlock(System.Boolean)

#### GetPullInformation()

##### Declaration

```
public PullInformation GetPullInformation()
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.PullInformation |     |
