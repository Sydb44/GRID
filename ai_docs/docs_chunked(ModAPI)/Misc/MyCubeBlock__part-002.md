Type

Description

System.Boolean

#### IsFunctional

##### Declaration

```
public bool IsFunctional { get; }
```

##### Property Value

Type

Description

System.Boolean

#### IsSubBlock

##### Declaration

```
public bool IsSubBlock { get; }
```

##### Property Value

Type

Description

System.Boolean

#### IsWorking

##### Declaration

```
public bool IsWorking { get; }
```

##### Property Value

Type

Description

System.Boolean

#### Max

##### Declaration

```
public Vector3I Max { get; }
```

##### Property Value

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### Min

##### Declaration

```
public Vector3I Min { get; }
```

##### Property Value

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### NumberInGrid

##### Declaration

```
public int NumberInGrid { get; set; }
```

##### Property Value

Type

Description

System.Int32

#### Orientation

##### Declaration

```
public MyBlockOrientation Orientation { get; }
```

##### Property Value

Type

Description

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

#### OwnerBlock

If the block is subblock then OwnerBlock is set to block which owns (spawns) subblocks (subgrids)

##### Declaration

```
public MySlimBlock OwnerBlock { get; }
```

##### Property Value

Type

Description

Sandbox.Game.Entities.Cube.MySlimBlock

#### OwnerId

##### Declaration

```
public long OwnerId { get; }
```

##### Property Value

Type

Description

System.Int64

#### Physics

##### Declaration

```
public MyPhysicsBody Physics { get; set; }
```

##### Property Value

Type

Description

Sandbox.Engine.Physics.MyPhysicsBody

#### Position

##### Declaration

```
public Vector3I Position { get; }
```

##### Property Value

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### ResourceSink

##### Declaration

```
public MyResourceSinkComponent ResourceSink { get; set; }
```

##### Property Value

Type

Description

[MyResourceSinkComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSinkComponent.html)

#### SubBlockName

Name of subblock (key in the owner's subblocks map).

##### Declaration

```
public string SubBlockName { get; set; }
```

##### Property Value

Type

Description

System.String

#### UpgradeValues

##### Declaration

```
public Dictionary<string, float> UpgradeValues { get; }
```

##### Property Value

Type

Description

System.Collections.Generic.Dictionary<System.String, System.Single\>

#### UseObjectsComponent

##### Declaration

```
public MyUseObjectsComponentBase UseObjectsComponent { get; }
```

##### Property Value

Type

Description

[MyUseObjectsComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyUseObjectsComponentBase.html)

#### UsesEmissivePreset

##### Declaration

```
public bool UsesEmissivePreset { get; }
```

##### Property Value

Type

Description

System.Boolean

### Methods

#### AddSubBlock(String, MySlimBlock)

##### Declaration

```
protected void AddSubBlock(string dummyName, MySlimBlock subblock)
```

##### Parameters

Type

Name

Description

System.String

dummyName

Sandbox.Game.Entities.Cube.MySlimBlock

subblock

#### AddUpgradeValue(String, Single)

##### Declaration

```
public void AddUpgradeValue(string name, float defaultValue)
```

##### Parameters

Type

Name

Description

System.String

name

System.Single

defaultValue

#### CalcLocalMatrix(out Matrix, out String)

##### Declaration

```
public void CalcLocalMatrix(out Matrix localMatrix, out string currModel)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

localMatrix

System.String

currModel

#### CalculateCurrentModel(out Matrix)

##### Declaration

```
public virtual string CalculateCurrentModel(out Matrix orientation)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

orientation

##### Returns

Type

Description

System.String

#### CanContinueBuild()

##### Declaration

```
public bool CanContinueBuild()
```

##### Returns

Type

Description

System.Boolean

#### ChangeBlockOwnerRequest(Int64, MyOwnershipShareModeEnum)

##### Declaration

```
public void ChangeBlockOwnerRequest(long playerId, MyOwnershipShareModeEnum shareMode)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

[MyOwnershipShareModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOwnershipShareModeEnum.html)

shareMode

#### ChangeOwner(Int64, MyOwnershipShareModeEnum)

##### Declaration

```
public void ChangeOwner(long owner, MyOwnershipShareModeEnum shareMode)
```

##### Parameters

Type

Name

Description

System.Int64

owner

[MyOwnershipShareModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOwnershipShareModeEnum.html)

shareMode

#### CheckEmissiveState(Boolean)

##### Declaration

```
public virtual void CheckEmissiveState(bool force = false)
```

##### Parameters

Type

Name

Description

System.Boolean

force

#### CheckIsWorking()

##### Declaration

```
protected virtual bool CheckIsWorking()
```

##### Returns

Type

Description

System.Boolean

#### Closing()

##### Declaration

```
protected override void Closing()
```

##### Overrides

#### CommitUpgradeValues()

##### Declaration

```
public void CommitUpgradeValues()
```

#### Components\_ComponentAdded(Type, IMyEntityComponentBase)

##### Declaration

```
protected override void Components_ComponentAdded(Type t, IMyEntityComponentBase c)
```

##### Parameters

Type

Name

Description

System.Type

t

VRage.Game.Components.Interfaces.IMyEntityComponentBase

c

##### Overrides
