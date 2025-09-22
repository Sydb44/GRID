Type

Description

[MyResourceSinkComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyResourceSinkComponentBase.html)

#### IMyCubeBlock.SetDamageEffect(Boolean)

##### Declaration

```
void IMyCubeBlock.SetDamageEffect(bool start)
```

##### Parameters

Type

Name

Description

System.Boolean

start

#### IMyCubeBlock.SetEffect(String, Boolean)

##### Declaration

```
bool IMyCubeBlock.SetEffect(string effectName, bool stopPrevious)
```

##### Parameters

Type

Name

Description

System.String

effectName

System.Boolean

stopPrevious

##### Returns

Type

Description

System.Boolean

#### IMyCubeBlock.SetEffect(String, Single, Boolean, Boolean, Boolean)

##### Declaration

```
bool IMyCubeBlock.SetEffect(string effectName, float parameter, bool stopPrevious, bool ignoreParameter, bool removeSameNameEffects)
```

##### Parameters

Type

Name

Description

System.String

effectName

System.Single

parameter

System.Boolean

stopPrevious

System.Boolean

ignoreParameter

System.Boolean

removeSameNameEffects

##### Returns

Type

Description

System.Boolean

#### IMyCubeBlock.SlimBlock

##### Declaration

```
IMySlimBlock IMyCubeBlock.SlimBlock { get; }
```

##### Returns

Type

Description

[IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySlimBlock.html)

#### IMyCubeBlock.BlockDefinition

##### Declaration

```
SerializableDefinitionId IMyCubeBlock.BlockDefinition { get; }
```

##### Returns

Type

Description

[SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html)

#### IMyCubeBlock.CubeGrid

##### Declaration

```
IMyCubeGrid IMyCubeBlock.CubeGrid { get; }
```

##### Returns

Type

Description

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeGrid.html)

#### IMyCubeBlock.GetPlayerRelationToOwner()

##### Declaration

```
MyRelationsBetweenPlayerAndBlock IMyCubeBlock.GetPlayerRelationToOwner()
```

##### Returns

Type

Description

[MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html)

#### IMyCubeBlock.GetUserRelationToOwner(Int64, MyRelationsBetweenPlayerAndBlock)

##### Declaration

```
MyRelationsBetweenPlayerAndBlock IMyCubeBlock.GetUserRelationToOwner(long playerId, MyRelationsBetweenPlayerAndBlock defaultNoUser)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

[MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html)

defaultNoUser

##### Returns

Type

Description

[MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html)

#### IMyCubeBlock.Mass

##### Declaration

```
float IMyCubeBlock.Mass { get; }
```

##### Returns

Type

Description

System.Single

#### IMyCubeBlock.UpdateIsWorking()

##### Declaration

```
void IMyCubeBlock.UpdateIsWorking()
```

#### IMyCubeBlock.UpdateVisual()

##### Declaration

```
void IMyCubeBlock.UpdateVisual()
```

### Implements

### Extension Methods