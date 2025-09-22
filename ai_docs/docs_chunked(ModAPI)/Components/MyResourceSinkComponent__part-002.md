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

#### ForceCallNextIsPoweredChanged()

##### Declaration

```
public void ForceCallNextIsPoweredChanged()
```

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

#### Init(MyStringHash, List<MyResourceSinkInfo>, MyCubeBlock)

##### Declaration

```
public void Init(MyStringHash group, List<MyResourceSinkInfo> sinkData, MyCubeBlock parent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | group |     |
| System.Collections.Generic.List<[MyResourceSinkInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyResourceSinkInfo.html)\> | sinkData |     |
| [MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html) | parent |     |

#### Init(MyStringHash, Single, Func<Single>, MyCubeBlock)

##### Declaration

```
public void Init(MyStringHash group, float maxRequiredInput, Func<float> requiredInputFunc, MyCubeBlock parent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | group |     |
| System.Single | maxRequiredInput |     |
| System.Func<System.Single\> | requiredInputFunc |     |
| [MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html) | parent |     |

#### Init(MyStringHash, MyResourceSinkInfo)

##### Declaration

```
public void Init(MyStringHash group, MyResourceSinkInfo sinkData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | group |     |
| [MyResourceSinkInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyResourceSinkInfo.html) | sinkData |     |

#### Init(MyStringHash, MyResourceSinkInfo, MyCubeBlock)

##### Declaration

```
public void Init(MyStringHash group, MyResourceSinkInfo sinkData, MyCubeBlock parent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | group |     |
| [MyResourceSinkInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyResourceSinkInfo.html) | sinkData |     |
| [MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html) | parent |     |

#### IsPowerAvailable(MyDefinitionId, Single)

##### Declaration

```
public override bool IsPowerAvailable(MyDefinitionId resourceTypeId, float power)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| System.Single | power |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### IsPoweredByType(MyDefinitionId)

##### Declaration

```
public override bool IsPoweredByType(MyDefinitionId resourceTypeId)
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

#### MaxRequiredInputByType(MyDefinitionId)

##### Declaration

```
public override float MaxRequiredInputByType(MyDefinitionId resourceTypeId)
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

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### remove\_CurrentInputChanged(MyCurrentResourceInputChangedDelegate)

##### Declaration

```
public void remove_CurrentInputChanged(MyCurrentResourceInputChangedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCurrentResourceInputChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyCurrentResourceInputChangedDelegate.html) | value |     |

#### remove\_RequiredInputChanged(MyRequiredResourceChangeDelegate)

##### Declaration

```
public void remove_RequiredInputChanged(MyRequiredResourceChangeDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyRequiredResourceChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyRequiredResourceChangeDelegate.html) | value |     |

#### remove\_ResourceAvailable(MyResourceAvailableDelegate)

##### Declaration

```
public void remove_ResourceAvailable(MyResourceAvailableDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyResourceAvailableDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceAvailableDelegate.html) | value |     |
