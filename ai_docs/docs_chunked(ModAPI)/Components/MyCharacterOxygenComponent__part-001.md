---
title: "Class MyCharacterOxygenComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.MyCharacterOxygenComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities.Character.Components"
class: "MyCharacterOxygenComponent"
---

# Class MyCharacterOxygenComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyCharacterOxygenComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities.Character.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
public class MyCharacterOxygenComponent : MyUpdatingEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent
```

### Constructors

#### MyCharacterOxygenComponent()

##### Declaration

```
public MyCharacterOxygenComponent()
```

### Fields

#### GAS\_REFILL\_RATION

##### Declaration

```
public static readonly float GAS_REFILL_RATION
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### HydrogenId

##### Declaration

```
public static readonly MyDefinitionId HydrogenId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### LOW\_OXYGEN\_RATIO

##### Declaration

```
public static readonly float LOW_OXYGEN_RATIO
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OxygenId

##### Declaration

```
public static readonly MyDefinitionId OxygenId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

### Properties

#### Character

##### Declaration

```
public MyCharacter Character { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter |     |

#### CharacterGasSink

##### Declaration

```
public MyResourceSinkComponent CharacterGasSink { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyResourceSinkComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSinkComponent.html) |     |

#### CharacterGasSource

##### Declaration

```
public MyResourceSourceComponent CharacterGasSource { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyResourceSourceComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSourceComponent.html) |     |

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### EnvironmentOxygenLevel

Get Environment Oxygen Level - backwards compatibility

##### Declaration

```
public float EnvironmentOxygenLevel { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### HelmetEnabled

##### Declaration

```
public bool HelmetEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsOxygenFromSuit

##### Declaration

```
public bool NeedsOxygenFromSuit { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OxygenCapacity

##### Declaration

```
public float OxygenCapacity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OxygenConsumptionRate

##### Declaration

```
public float OxygenConsumptionRate { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OxygenConsumptionRateMutliplier

##### Declaration

```
public float OxygenConsumptionRateMutliplier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OxygenLevelAtCharacterLocation

Get Oxygen Level at Character Location - backwards compatibility

##### Declaration

```
public float OxygenLevelAtCharacterLocation { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SuitOxygenAmount

##### Declaration

```
public float SuitOxygenAmount { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SuitOxygenAmountMissing

##### Declaration

```
public float SuitOxygenAmountMissing { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SuitOxygenLevel

##### Declaration

```
public float SuitOxygenLevel { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### AppendSinkData(List<MyResourceSinkInfo>)

##### Declaration

```
public void AppendSinkData(List<MyResourceSinkInfo> sinkData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyResourceSinkInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyResourceSinkInfo.html)\> | sinkData |     |

#### AppendSourceData(List<MyResourceSourceInfo>)

##### Declaration

```
public void AppendSourceData(List<MyResourceSourceInfo> sourceData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyResourceSourceInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSourceInfo.html)\> | sourceData |     |

#### ContainsGasStorage(MyDefinitionId)

##### Declaration

```
public bool ContainsGasStorage(MyDefinitionId gasId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | gasId |     |
