---
title: "Class MyResourceSinkComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSinkComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyResourceSinkComponent"
---

# Class MyResourceSinkComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyResourceSinkComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyResourceSinkComponent : MyResourceSinkComponentBase, IMyEntityComponentBase, IMyComponentBase, IMyResourceSinkComponent
```

### Constructors

#### MyResourceSinkComponent()

##### Declaration

```
public MyResourceSinkComponent()
```

#### MyResourceSinkComponent(Int32)

##### Declaration

```
public MyResourceSinkComponent(int initialAllocationSize = 1)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | initialAllocationSize |     |

### Fields

#### ParentBlock

##### Declaration

```
public MyCubeBlock ParentBlock
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html) |     |

### Properties

#### AcceptedResources

##### Declaration

```
public override ListReader<MyDefinitionId> AcceptedResources { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> |     |

##### Overrides

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

#### CurrentInput

##### Declaration

```
public float CurrentInput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Entity

##### Declaration

```
public MyEntity Entity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### Grid

Grid of assigned entity. If no entity is assigned gets manualy set grid

##### Declaration

```
public MyCubeGrid Grid { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) |     |

#### IsPowered

##### Declaration

```
public bool IsPowered { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxRequiredInput

##### Declaration

```
public float MaxRequiredInput { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RequiredInput

##### Declaration

```
public float RequiredInput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SuppliedRatio

##### Declaration

```
public float SuppliedRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### TemporaryConnectedEntity

##### Declaration

```
public override IMyEntity TemporaryConnectedEntity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

##### Overrides

### Methods

#### add\_CurrentInputChanged(MyCurrentResourceInputChangedDelegate)

##### Declaration

```
public void add_CurrentInputChanged(MyCurrentResourceInputChangedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCurrentResourceInputChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyCurrentResourceInputChangedDelegate.html) | value |     |

#### add\_RequiredInputChanged(MyRequiredResourceChangeDelegate)

##### Declaration

```
public void add_RequiredInputChanged(MyRequiredResourceChangeDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyRequiredResourceChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyRequiredResourceChangeDelegate.html) | value |     |

#### add\_ResourceAvailable(MyResourceAvailableDelegate)

##### Declaration

```
public void add_ResourceAvailable(MyResourceAvailableDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyResourceAvailableDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceAvailableDelegate.html) | value |     |

#### AddType(ref MyResourceSinkInfo)

##### Declaration

```
public void AddType(ref MyResourceSinkInfo sinkData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyResourceSinkInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyResourceSinkInfo.html) | sinkData |     |

#### ClearAllData()

##### Declaration

```
public void ClearAllData()
```

#### CurrentInputByType(MyDefinitionId)

##### Declaration

```
public override float CurrentInputByType(MyDefinitionId resourceTypeId)
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
