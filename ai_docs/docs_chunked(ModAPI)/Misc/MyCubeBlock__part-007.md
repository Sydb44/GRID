Type

Description

System.Action

#### OnUpgradeValuesChanged

##### Declaration

```
public event Action OnUpgradeValuesChanged
```

##### Event Type

Type

Description

System.Action

### Explicit Interface Implementations

#### IMyUpgradableBlock.FillUpgradesDictionary(Dictionary<String, Single>)

##### Declaration

```
void IMyUpgradableBlock.FillUpgradesDictionary(Dictionary<string, float> upgrades)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.Dictionary<System.String, System.Single\>

upgrades

#### IMyUpgradableBlock.GetUpgrades(out Dictionary<String, Single>)

##### Declaration

```
void IMyUpgradableBlock.GetUpgrades(out Dictionary<string, float> upgrades)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.Dictionary<System.String, System.Single\>

upgrades

#### IMyUpgradableBlock.UpgradeCount

##### Declaration

```
uint IMyUpgradableBlock.UpgradeCount { get; }
```

##### Returns

Type

Description

System.UInt32

#### IMyComponentOwner<MyIDModule>.GetComponent(out MyIDModule)

##### Declaration

```
bool IMyComponentOwner<MyIDModule>.GetComponent(out MyIDModule component)
```

##### Parameters

Type

Name

Description

[MyIDModule](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyIDModule.html)

component

##### Returns

Type

Description

System.Boolean

#### IMyCubeBlock.CalcLocalMatrix(out Matrix, out String)

##### Declaration

```
void IMyCubeBlock.CalcLocalMatrix(out Matrix localMatrix, out string currModel)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

localMatrix

System.String

currModel

#### IMyCubeBlock.CalculateCurrentModel(out Matrix)

##### Declaration

```
string IMyCubeBlock.CalculateCurrentModel(out Matrix orientation)
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

#### IMyCubeBlock.CheckConnectionAllowed

##### Declaration

```
bool IMyCubeBlock.CheckConnectionAllowed { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyCubeBlock.CubeGrid

##### Declaration

```
IMyCubeGrid IMyCubeBlock.CubeGrid { get; }
```

##### Returns

Type

Description

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)

#### IMyCubeBlock.GetObjectBuilderCubeBlock(Boolean)

##### Declaration

```
MyObjectBuilder_CubeBlock IMyCubeBlock.GetObjectBuilderCubeBlock(bool copy)
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

#### IMyCubeBlock.Init()

##### Declaration

#### IMyCubeBlock.Init(MyObjectBuilder\_CubeBlock, IMyCubeGrid)

##### Declaration

```
void IMyCubeBlock.Init(MyObjectBuilder_CubeBlock builder, IMyCubeGrid cubeGrid)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html)

builder

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)

cubeGrid

#### IMyCubeBlock.IsWorkingChanged

##### Declaration

```
event Action<IMyCubeBlock> IMyCubeBlock.IsWorkingChanged
```

##### Returns

Type

Description

System.Action<[IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeBlock.html)\>

#### IMyCubeBlock.OnBuildSuccess(Int64)

##### Declaration

```
void IMyCubeBlock.OnBuildSuccess(long builtBy)
```

##### Parameters

Type

Name

Description

System.Int64

builtBy

#### IMyCubeBlock.OnBuildSuccess(Int64, Boolean)

##### Declaration

```
void IMyCubeBlock.OnBuildSuccess(long builtBy, bool instantBuild)
```

##### Parameters

Type

Name

Description

System.Int64

builtBy

System.Boolean

instantBuild

#### IMyCubeBlock.OnDestroy()

##### Declaration

```
void IMyCubeBlock.OnDestroy()
```

#### IMyCubeBlock.OnModelChange()

##### Declaration

```
void IMyCubeBlock.OnModelChange()
```

#### IMyCubeBlock.OnRegisteredToGridSystems()

##### Declaration

```
void IMyCubeBlock.OnRegisteredToGridSystems()
```

#### IMyCubeBlock.OnRemovedByCubeBuilder()

##### Declaration

```
void IMyCubeBlock.OnRemovedByCubeBuilder()
```

#### IMyCubeBlock.OnUnregisteredFromGridSystems()

##### Declaration

```
void IMyCubeBlock.OnUnregisteredFromGridSystems()
```

#### IMyCubeBlock.RaycastDetectors(Vector3D, Vector3D)

##### Declaration

```
string IMyCubeBlock.RaycastDetectors(Vector3D worldFrom, Vector3D worldTo)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

worldFrom

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

worldTo

##### Returns

Type

Description

System.String

#### IMyCubeBlock.ReloadDetectors(Boolean)

##### Declaration

```
void IMyCubeBlock.ReloadDetectors(bool refreshNetworks)
```

##### Parameters

Type

Name

Description

System.Boolean

refreshNetworks

#### IMyCubeBlock.RemoveEffect(String, Int32)

##### Declaration

```
int IMyCubeBlock.RemoveEffect(string effectName, int exception)
```

##### Parameters

Type

Name

Description

System.String

effectName

System.Int32

exception

##### Returns

Type

Description

System.Int32

#### IMyCubeBlock.ResourceSink

##### Declaration

```
MyResourceSinkComponentBase IMyCubeBlock.ResourceSink { get; set; }
```

##### Returns

Type

Description

[MyResourceSinkComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyResourceSinkComponentBase.html)

#### IMyCubeBlock.SetDamageEffect(Boolean)

##### Declaration

```
void IMyCubeBlock.SetDamageEffect(bool start)
```
