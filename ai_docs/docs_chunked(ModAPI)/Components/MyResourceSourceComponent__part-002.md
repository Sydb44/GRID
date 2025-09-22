#### add\_ProductionEnabledChanged(MyResourceCapacityRemainingChangedDelegate)

##### Declaration

```
public void add_ProductionEnabledChanged(MyResourceCapacityRemainingChangedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyResourceCapacityRemainingChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceCapacityRemainingChangedDelegate.html) | value |     |

#### CurrentOutputByType(MyDefinitionId)

##### Declaration

```
public override float CurrentOutputByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

##### Overrides

#### DebugDraw(Matrix)

##### Declaration

```
public void DebugDraw(Matrix worldMatrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | worldMatrix |     |

#### DefinedOutputByType(MyDefinitionId)

##### Declaration

```
public override float DefinedOutputByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

##### Overrides

#### GetTypeIndex(MyDefinitionId)

##### Declaration

```
protected int GetTypeIndex(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### HasCapacityRemainingByType(MyDefinitionId)

##### Declaration

```
public bool HasCapacityRemainingByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Init(MyStringHash, MyResourceSourceInfo)

##### Declaration

```
public void Init(MyStringHash sourceGroup, MyResourceSourceInfo sourceResourceData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | sourceGroup |     |
| [MyResourceSourceInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSourceInfo.html) | sourceResourceData |     |

#### Init(MyStringHash, List<MyResourceSourceInfo>)

##### Declaration

```
public void Init(MyStringHash sourceGroup, List<MyResourceSourceInfo> sourceResourceData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | sourceGroup |     |
| System.Collections.Generic.List<[MyResourceSourceInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSourceInfo.html)\> | sourceResourceData |     |

#### MaxOutputByType(MyDefinitionId)

##### Declaration

```
public override float MaxOutputByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

##### Overrides

#### OnProductionEnabledChanged(Nullable<MyDefinitionId>)

Do not use this unless absolutely necessary.

##### Declaration

```
public void OnProductionEnabledChanged(Nullable<MyDefinitionId> resId = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> | resId |     |

#### ProductionEnabledByType(MyDefinitionId)

##### Declaration

```
public override bool ProductionEnabledByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### ProductionToCapacityMultiplierByType(MyDefinitionId)

##### Declaration

```
public float ProductionToCapacityMultiplierByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### RemainingCapacityByType(MyDefinitionId)

##### Declaration

```
public float RemainingCapacityByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### remove\_HasCapacityRemainingChanged(MyResourceCapacityRemainingChangedDelegate)

##### Declaration

```
public void remove_HasCapacityRemainingChanged(MyResourceCapacityRemainingChangedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyResourceCapacityRemainingChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceCapacityRemainingChangedDelegate.html) | value |     |
