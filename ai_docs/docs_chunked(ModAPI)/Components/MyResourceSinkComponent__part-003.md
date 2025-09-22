#### remove\_ResourceAvailable(MyResourceAvailableDelegate)

##### Declaration

```
public void remove_ResourceAvailable(MyResourceAvailableDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyResourceAvailableDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceAvailableDelegate.html) | value |     |

#### RemoveType(ref MyDefinitionId)

##### Declaration

```
public void RemoveType(ref MyDefinitionId resourceType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceType |     |

#### RequiredInputByType(MyDefinitionId)

##### Declaration

```
public override float RequiredInputByType(MyDefinitionId resourceTypeId)
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

#### ResourceAvailableByType(MyDefinitionId)

##### Declaration

```
public float ResourceAvailableByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### SetInputFromDistributor(MyDefinitionId, Single, Boolean, Boolean)

This should be called only from MyResourceDistributor.

##### Declaration

```
public override void SetInputFromDistributor(MyDefinitionId resourceTypeId, float newResourceInput, bool isAdaptible, bool fireEvents = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| System.Single | newResourceInput |     |
| System.Boolean | isAdaptible |     |
| System.Boolean | fireEvents |     |

##### Overrides

#### SetMaxRequiredInputByType(MyDefinitionId, Single)

##### Declaration

```
public override void SetMaxRequiredInputByType(MyDefinitionId resourceTypeId, float newMaxRequiredInput)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| System.Single | newMaxRequiredInput |     |

##### Overrides

#### SetRequiredInputByType(MyDefinitionId, Single)

##### Declaration

```
public override void SetRequiredInputByType(MyDefinitionId resourceTypeId, float newRequiredInput)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| System.Single | newRequiredInput |     |

##### Overrides

#### SetRequiredInputFuncByType(MyDefinitionId, Func<Single>)

Change the required input function (callback) for given type of resource. It does not call it immediatelly to update required input value.

##### Declaration

```
public override Func<float> SetRequiredInputFuncByType(MyDefinitionId resourceTypeId, Func<float> newRequiredInputFunc)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| System.Func<System.Single\> | newRequiredInputFunc |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Func<System.Single\> |     |

##### Overrides

#### SuppliedRatioByType(MyDefinitionId)

##### Declaration

```
public override float SuppliedRatioByType(MyDefinitionId resourceTypeId)
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

#### Update()

##### Declaration

### Events

#### CurrentInputChanged

##### Declaration

```
public event MyCurrentResourceInputChangedDelegate CurrentInputChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| [MyCurrentResourceInputChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyCurrentResourceInputChangedDelegate.html) |     |

#### IsPoweredChanged

##### Declaration

```
public event Action IsPoweredChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnAddType

##### Declaration

```
public event Action<MyResourceSinkComponent, MyDefinitionId> OnAddType
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyResourceSinkComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSinkComponent.html), [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> |     |

#### OnRemoveType

##### Declaration

```
public event Action<MyResourceSinkComponent, MyDefinitionId> OnRemoveType
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyResourceSinkComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSinkComponent.html), [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> |     |

#### RequiredInputChanged

##### Declaration

```
public event MyRequiredResourceChangeDelegate RequiredInputChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| [MyRequiredResourceChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyRequiredResourceChangeDelegate.html) |     |
