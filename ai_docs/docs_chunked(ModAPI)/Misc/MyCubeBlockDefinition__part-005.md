| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### ClearPreloadedConstructionModels()

##### Declaration

```
public static void ClearPreloadedConstructionModels()
```

#### ClearTargetableCache()

ModAPI: Should be called if you modify targeting groups.

##### Declaration

```
public void ClearTargetableCache()
```

#### ContainsComputer()

##### Declaration

```
public bool ContainsComputer()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FinalModelThreshold()

##### Declaration

```
public float FinalModelThreshold()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetBuildProgressModelIndex(Single)

##### Declaration

```
public int GetBuildProgressModelIndex(float percentageA)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | percentageA |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetBuildProgressModelMountPoints(Single)

##### Declaration

```
public MyCubeBlockDefinition.MountPoint[] GetBuildProgressModelMountPoints(float currentIntegrityRatio)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | currentIntegrityRatio |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\[\] |     |

#### GetGeneratedBlockDefinition(MyStringId)

##### Declaration

```
public MyCubeBlockDefinition GetGeneratedBlockDefinition(MyStringId additionalModelType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | additionalModelType |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) |     |

#### GetLimitType()

##### Declaration

```
public string GetLimitType()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetMountPointWallIndex(Base6Directions.Direction)

##### Declaration

```
public static int GetMountPointWallIndex(Base6Directions.Direction direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | direction |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetObjectBuilder()

##### Declaration

```
public override MyObjectBuilder_DefinitionBase GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) |     |

##### Overrides

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Overrides

#### InitPressurization()

##### Declaration

```
public void InitPressurization()
```

#### IsTurretTargetable()

##### Declaration

```
public bool IsTurretTargetable()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MatchingTurretTargetingGroup(MyStringHash)

##### Declaration

```
public bool MatchingTurretTargetingGroup(MyStringHash hash)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | hash |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ModelChangeIsNeeded(Single, Single)

Tells, whether a model change is needed, if the block changes integrity from A to B or vice versa.

##### Declaration

```
public bool ModelChangeIsNeeded(float was, float now)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | was |     |
| System.Single | now |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MountPointLocalNormalToBlockLocal(Vector3, Base6Directions.Direction)

##### Declaration

```
public Vector3 MountPointLocalNormalToBlockLocal(Vector3 normal, Base6Directions.Direction mountPointDirection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | normal |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | mountPointDirection |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### MountPointLocalToBlockLocal(Vector3, Base6Directions.Direction)

##### Declaration

```
public Vector3 MountPointLocalToBlockLocal(Vector3 coord, Base6Directions.Direction mountPointDirection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | coord |     |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) | mountPointDirection |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### NormalToBlockSide(Vector3I)

##### Declaration

```
public static BlockSideEnum NormalToBlockSide(Vector3I normal)
```
