---
title: "Class MyTriggerComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyTriggerComponent.html"
category: "Components"
namespace: "Sandbox.Game.Components"
class: "MyTriggerComponent"
---

# Class MyTriggerComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyTriggerComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentBuilder]
public class MyTriggerComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyTriggerComponent()

##### Declaration

```
public MyTriggerComponent()
```

#### MyTriggerComponent(MyTriggerComponent.TriggerType, UInt32)

##### Declaration

```
public MyTriggerComponent(MyTriggerComponent.TriggerType type, uint updateFrequency = 300U)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTriggerComponent.TriggerType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyTriggerComponent.TriggerType.html) | type |     |
| System.UInt32 | updateFrequency |     |

### Fields

#### m\_AABB

##### Declaration

```
protected BoundingBoxD m_AABB
```

##### Field Value

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### m\_boundingSphere

##### Declaration

```
protected BoundingSphereD m_boundingSphere
```

##### Field Value

| Type | Description |
| --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) |     |

#### m\_orientedBoundingBox

##### Declaration

```
protected MyOrientedBoundingBoxD m_orientedBoundingBox
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) |     |

#### m\_queryResult

##### Declaration

```
protected readonly List<MyEntity> m_queryResult
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

#### m\_relativeOffset

##### Declaration

```
protected Vector3 m_relativeOffset
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### m\_triggerType

##### Declaration

```
protected MyTriggerComponent.TriggerType m_triggerType
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyTriggerComponent.TriggerType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyTriggerComponent.TriggerType.html) |     |

### Properties

#### Center

Trigger BB center position.

##### Declaration

```
public Vector3D Center { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

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

#### CustomDebugColor

##### Declaration

```
public Nullable<Color> CustomDebugColor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)\> |     |

#### DoQuery

##### Declaration

```
protected bool DoQuery { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Enabled

##### Declaration

```
public virtual bool Enabled { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OBB

##### Declaration

```
public MyOrientedBoundingBoxD OBB { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) |     |

#### QueryResult

##### Declaration

```
protected List<MyEntity> QueryResult { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

#### TriggerAreaType

##### Declaration

```
public MyTriggerComponent.TriggerType TriggerAreaType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyTriggerComponent.TriggerType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyTriggerComponent.TriggerType.html) |     |

#### UpdateFrequency

##### Declaration

```
public uint UpdateFrequency { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

### Methods

#### Contains(Vector3D)

##### Declaration

```
public bool Contains(Vector3D point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DebugDraw()

##### Declaration

```
public virtual void DebugDraw()
```

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | builder |     |
