---
title: "Class MyResourceSourceComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSourceComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyResourceSourceComponent"
---

# Class MyResourceSourceComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyResourceSourceComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyResourceSourceComponent : MyResourceSourceComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyResourceSourceComponent()

##### Declaration

```
public MyResourceSourceComponent()
```

#### MyResourceSourceComponent(Int32)

##### Declaration

```
public MyResourceSourceComponent(int initialAllocationSize = 1)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | initialAllocationSize |     |

### Fields

#### CountTowardsRemainingEnergyTime

##### Declaration

```
public bool CountTowardsRemainingEnergyTime
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

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

#### CurrentOutput

##### Declaration

```
public float CurrentOutput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DefinedOutput

##### Declaration

```
public float DefinedOutput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Enabled

##### Declaration

```
public bool Enabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Grid

##### Declaration

```
public MyCubeGrid Grid { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) |     |

#### Group

##### Declaration

```
public MyStringHash Group { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### HasCapacityRemaining

##### Declaration

```
public bool HasCapacityRemaining { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsInfiniteCapacity

##### Declaration

```
public bool IsInfiniteCapacity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxOutput

##### Declaration

```
public float MaxOutput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ProductionEnabled

##### Declaration

```
public bool ProductionEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ProductionToCapacityMultiplier

##### Declaration

```
public float ProductionToCapacityMultiplier { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RemainingCapacity

##### Declaration

```
public float RemainingCapacity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ResourceTypes

##### Declaration

```
public ListReader<MyDefinitionId> ResourceTypes { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> |     |

#### TemporaryConnectedEntity

##### Declaration

```
public MyEntity TemporaryConnectedEntity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

### Methods

#### add\_HasCapacityRemainingChanged(MyResourceCapacityRemainingChangedDelegate)

##### Declaration

```
public void add_HasCapacityRemainingChanged(MyResourceCapacityRemainingChangedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyResourceCapacityRemainingChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceCapacityRemainingChangedDelegate.html) | value |     |

#### add\_MaxOutputChanged(MyResourceOutputChangedDelegate)

##### Declaration

```
public void add_MaxOutputChanged(MyResourceOutputChangedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyResourceOutputChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceOutputChangedDelegate.html) | value |     |

#### add\_OutputChanged(MyResourceOutputChangedDelegate)

##### Declaration

```
public void add_OutputChanged(MyResourceOutputChangedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyResourceOutputChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceOutputChangedDelegate.html) | value |     |

#### add\_ProductionEnabledChanged(MyResourceCapacityRemainingChangedDelegate)

##### Declaration

```
public void add_ProductionEnabledChanged(MyResourceCapacityRemainingChangedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyResourceCapacityRemainingChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceCapacityRemainingChangedDelegate.html) | value |     |
