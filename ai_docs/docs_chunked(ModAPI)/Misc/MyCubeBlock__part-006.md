Type

Description

System.Boolean

#### SetEmissiveState(MyStringHash, UInt32, String)

##### Declaration

```
public bool SetEmissiveState(MyStringHash state, uint renderObjectId, string namedPart = null)
```

##### Parameters

Type

Name

Description

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

state

System.UInt32

renderObjectId

System.String

namedPart

##### Returns

Type

Description

System.Boolean

#### SetEmissiveStateDamaged()

##### Declaration

```
public virtual bool SetEmissiveStateDamaged()
```

##### Returns

Type

Description

System.Boolean

#### SetEmissiveStateDisabled()

##### Declaration

```
public virtual bool SetEmissiveStateDisabled()
```

##### Returns

Type

Description

System.Boolean

#### SetEmissiveStateWorking()

##### Declaration

```
public virtual bool SetEmissiveStateWorking()
```

##### Returns

Type

Description

System.Boolean

#### StopDamageEffect(Boolean)

##### Declaration

```
public virtual void StopDamageEffect(bool stopSound = true)
```

##### Parameters

Type

Name

Description

System.Boolean

stopSound

#### SubBlocksInitialized(Boolean)

Function called when all subblocks have been initialized.

##### Declaration

```
protected void SubBlocksInitialized(bool spawned)
```

##### Parameters

Type

Name

Description

System.Boolean

spawned

true if subblocks have been just spawned on server, otherwise false (load)

#### TryGetSubBlock(String, out MySlimBlock)

##### Declaration

```
public bool TryGetSubBlock(string name, out MySlimBlock block)
```

##### Parameters

Type

Name

Description

System.String

name

Sandbox.Game.Entities.Cube.MySlimBlock

block

##### Returns

Type

Description

System.Boolean

#### UpdateBeforeSimulation()

##### Declaration

```
public override void UpdateBeforeSimulation()
```

##### Overrides

#### UpdateBeforeSimulation10()

##### Declaration

```
public override void UpdateBeforeSimulation10()
```

##### Overrides

#### UpdateEmissiveParts(UInt32, Single, Color, Color)

##### Declaration

```
public void UpdateEmissiveParts(uint renderObjectId, float emissivity, Color emissivePartColor, Color displayPartColor)
```

##### Parameters

Type

Name

Description

System.UInt32

renderObjectId

System.Single

emissivity

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

emissivePartColor

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

displayPartColor

#### UpdateIsWorking()

##### Declaration

```
public void UpdateIsWorking()
```

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

#### UpdateSkin(Boolean)

##### Declaration

```
public bool UpdateSkin(bool force = false)
```

##### Parameters

Type

Name

Description

System.Boolean

force

##### Returns

Type

Description

System.Boolean

#### UpdateVisual()

##### Declaration

```
public virtual void UpdateVisual()
```

#### WorldPositionChanged(Object)

##### Declaration

```
protected virtual void WorldPositionChanged(object source)
```

##### Parameters

Type

Name

Description

System.Object

source

### Events

#### CanContinueBuildCheck

##### Declaration

```
public event Func<bool> CanContinueBuildCheck
```

##### Event Type

Type

Description

System.Func<System.Boolean\>

#### CheckConnectionChanged

##### Declaration

```
public event Action<MyCubeBlock> CheckConnectionChanged
```

##### Event Type

Type

Description

System.Action<[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)\>

#### CubeGridChanged

##### Declaration

```
public event Action<IMyCubeGrid> CubeGridChanged
```

##### Event Type

Type

Description

System.Action<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\>

#### GetEmissiveStateHashFromComponent

##### Declaration

```
public event Func<Nullable<MyStringHash>> GetEmissiveStateHashFromComponent
```

##### Event Type

Type

Description

System.Func<System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\>>

#### GetIsWorking

##### Declaration

```
public event Func<bool> GetIsWorking
```

##### Event Type

Type

Description

System.Func<System.Boolean\>

#### IsWorkingChanged

##### Declaration

```
public event Action<MyCubeBlock> IsWorkingChanged
```

##### Event Type

Type

Description

System.Action<[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)\>

#### OnBlockDisableUpdates

##### Declaration

```
public event Action<MyCubeBlock> OnBlockDisableUpdates
```

##### Event Type

Type

Description

System.Action<[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)\>

#### OnBlockModelChange

##### Declaration

```
public event Action<MyCubeBlock> OnBlockModelChange
```

##### Event Type

Type

Description

System.Action<[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)\>

#### OnBlockRegisteredToGridSystems

##### Declaration

```
public event Action<MyCubeBlock> OnBlockRegisteredToGridSystems
```

##### Event Type

Type

Description

System.Action<[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)\>

#### OnBlockUpdateVisual

##### Declaration

```
public event Action<MyCubeBlock> OnBlockUpdateVisual
```

##### Event Type

Type

Description

System.Action<[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)\>

#### OnUpdateBeforenextFrame

##### Declaration

```
public event Action OnUpdateBeforenextFrame
```

##### Event Type

Type

Description

System.Action

#### OnUpgradeValuesChanged

##### Declaration

```
public event Action OnUpgradeValuesChanged
```
