---
title: "Class MyResourceDistributorComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceDistributorComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyResourceDistributorComponent"
---

# Class MyResourceDistributorComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyResourceDistributorComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyResourceDistributorComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase, IMyResourceDistributorComponent
```

### Constructors

#### MyResourceDistributorComponent(String)

##### Declaration

```
public MyResourceDistributorComponent(string debugName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | debugName |     |

### Fields

#### DebugName

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ElectricityId

##### Declaration

```
public static readonly MyDefinitionId ElectricityId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### HydrogenId

##### Declaration

```
public static readonly MyDefinitionId HydrogenId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### m\_initializedTypes

##### Declaration

```
protected readonly HashSet<MyDefinitionId> m_initializedTypes
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> |     |

#### OxygenId

##### Declaration

```
public static readonly MyDefinitionId OxygenId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### ShowTrace

For debugging purposes. Enables trace messages and watches for this instance.

##### Declaration

```
public static bool ShowTrace
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### WaterId

##### Declaration

```
public static readonly MyDefinitionId WaterId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

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

#### ResourceState

##### Declaration

```
public MyResourceStateEnum ResourceState { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.MyResourceStateEnum |     |

#### SinkGroupPrioritiesTotal

##### Declaration

```
public static int SinkGroupPrioritiesTotal { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### SinkSubtypesToPriority

##### Declaration

```
public static DictionaryReader<MyStringHash, int> SinkSubtypesToPriority { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html), System.Int32\> |     |

#### SourcesEnabled

##### Declaration

```
public MyMultipleEnabledEnum SourcesEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.MyMultipleEnabledEnum |     |

### Methods

#### AddSink(MyResourceSinkComponent)

##### Declaration

```
public void AddSink(MyResourceSinkComponent sink)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyResourceSinkComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSinkComponent.html) | sink |     |

#### AddSource(MyResourceSourceComponent)

##### Declaration

```
public void AddSource(MyResourceSourceComponent source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyResourceSourceComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyResourceSourceComponent.html) | source |     |

#### ChangeSourcesState(MyDefinitionId, MyMultipleEnabledEnum, Int64, MyCubeGrid)

##### Declaration

```
public void ChangeSourcesState(MyDefinitionId resourceTypeId, MyMultipleEnabledEnum state, long playerId, MyCubeGrid onlyForThisGrid = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceTypeId |     |
| VRage.MyMultipleEnabledEnum | state |     |
| System.Int64 | playerId |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | onlyForThisGrid |     |

#### Clear()

##### Declaration

```
public static void Clear()
```

#### ClearData()

##### Declaration

#### ConveyorSystem\_OnPoweredChanged()

##### Declaration

```
public void ConveyorSystem_OnPoweredChanged()
```

#### DebugDraw(MyEntity)

##### Declaration

```
public void DebugDraw(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
