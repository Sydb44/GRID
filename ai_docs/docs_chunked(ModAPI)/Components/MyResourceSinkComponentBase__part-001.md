---
title: "Class MyResourceSinkComponentBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyResourceSinkComponentBase.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyResourceSinkComponentBase"
---

# Class MyResourceSinkComponentBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyResourceSinkComponentBase

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MyResourceSinkComponentBase : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase, IMyResourceSinkComponent
```

### Constructors

#### MyResourceSinkComponentBase()

##### Declaration

```
protected MyResourceSinkComponentBase()
```

### Properties

#### AcceptedResources

##### Declaration

```
public abstract ListReader<MyDefinitionId> AcceptedResources { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> |     |

#### TemporaryConnectedEntity

##### Declaration

```
public abstract IMyEntity TemporaryConnectedEntity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

### Methods

#### CurrentInputByType(MyDefinitionId)

##### Declaration

```
public abstract float CurrentInputByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsPowerAvailable(MyDefinitionId, Single)

##### Declaration

```
public abstract bool IsPowerAvailable(MyDefinitionId resourceTypeId, float power)
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

#### IsPoweredByType(MyDefinitionId)

##### Declaration

```
public abstract bool IsPoweredByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxRequiredInputByType(MyDefinitionId)

##### Declaration

```
public abstract float MaxRequiredInputByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### RequiredInputByType(MyDefinitionId)

##### Declaration

```
public abstract float RequiredInputByType(MyDefinitionId resourceTypeId)
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

##### Declaration

```
public abstract void SetInputFromDistributor(MyDefinitionId resourceTypeId, float newResourceInput, bool isAdaptible, bool fireEvents = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| System.Single | newResourceInput |     |
| System.Boolean | isAdaptible |     |
| System.Boolean | fireEvents |     |

#### SetMaxRequiredInputByType(MyDefinitionId, Single)

##### Declaration

```
public abstract void SetMaxRequiredInputByType(MyDefinitionId resourceTypeId, float newMaxRequiredInput)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| System.Single | newMaxRequiredInput |     |

#### SetRequiredInputByType(MyDefinitionId, Single)

##### Declaration

```
public abstract void SetRequiredInputByType(MyDefinitionId resourceTypeId, float newRequiredInput)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| System.Single | newRequiredInput |     |

#### SetRequiredInputFuncByType(MyDefinitionId, Func<Single>)

##### Declaration

```
public abstract Func<float> SetRequiredInputFuncByType(MyDefinitionId resourceTypeId, Func<float> newRequiredInputFunc)
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

#### SuppliedRatioByType(MyDefinitionId)

##### Declaration

```
public abstract float SuppliedRatioByType(MyDefinitionId resourceTypeId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
