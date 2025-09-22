---
title: "Interface IMyResourceDistributorComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyResourceDistributorComponent.html"
category: "Components"
namespace: "VRage.Game.ModAPI"
class: "IMyResourceDistributorComponent"
---

# Interface IMyResourceDistributorComponent | Space Engineers ModAPI

ModAPI interface giving access to resource distributor

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyResourceDistributorComponent
```

### Properties

#### ResourceState

Gets current resource state

##### Declaration

```
MyResourceStateEnum ResourceState { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.MyResourceStateEnum |     |

#### SourcesEnabled

Gets if first found resources has enabled ResourceSource

##### Declaration

```
MyMultipleEnabledEnum SourcesEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.MyMultipleEnabledEnum |     |

### Methods

#### MaxAvailableResourceByType(MyDefinitionId, IMyCubeGrid)

Gets maximum resource available by resource type

##### Declaration

```
float MaxAvailableResourceByType(MyDefinitionId resourceTypeId, IMyCubeGrid grid = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId | Resource type. Ex: MyResourceDistributorComponent.ElectricityId |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | grid | Should be not null for electricity |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Available resource, or 0 |

#### TotalRequiredInputByType(MyDefinitionId, IMyCubeGrid)

Gets currently needed resource by resource type

##### Declaration

```
float TotalRequiredInputByType(MyDefinitionId resourceTypeId, IMyCubeGrid grid = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId | Resource type. Ex: MyResourceDistributorComponent.ElectricityId |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | grid | Should be not null for electricity |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Available resource, or 0 |

### Events

#### OnPowerGenerationChanged

Called when power generation status changed

##### Declaration

```
event Action<bool> OnPowerGenerationChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Boolean\> |     |