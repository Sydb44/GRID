---
title: "Class MyAreaTriggerComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyAreaTriggerComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyAreaTriggerComponent"
---

# Class MyAreaTriggerComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyAreaTriggerComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentBuilder]
public class MyAreaTriggerComponent : MyTriggerComponent, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyAreaTriggerComponent()

##### Declaration

```
public MyAreaTriggerComponent()
```

#### MyAreaTriggerComponent(String)

##### Declaration

```
public MyAreaTriggerComponent(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |

### Fields

#### EntityEntered

##### Declaration

```
public Action<long, string> EntityEntered
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<System.Int64, System.String\> |     |

### Properties

#### Name

##### Declaration

```
public string Name { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Radius

##### Declaration

```
public double Radius { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### SizeX

##### Declaration

```
public double SizeX { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### SizeY

##### Declaration

```
public double SizeY { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### SizeZ

##### Declaration

```
public double SizeZ { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

### Methods

#### DebugDraw()

##### Declaration

```
public override void DebugDraw()
```

##### Overrides

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | builder |     |

##### Overrides

#### IsSerialized()

##### Declaration

```
public override bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### QueryEvaluator(MyEntity)

##### Declaration

```
protected override bool QueryEvaluator(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### Serialize(Boolean)

##### Declaration

```
public override MyObjectBuilder_ComponentBase Serialize(bool copy)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

##### Overrides

#### UpdateInternal()

##### Declaration

```
protected override void UpdateInternal()
```

##### Overrides

### Extension Methods