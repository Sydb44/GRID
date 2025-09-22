---
title: "Class MyPhysicsComponentBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsComponentBase.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyPhysicsComponentBase"
---

# Class MyPhysicsComponentBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyPhysicsComponentBase

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyComponentType]
public abstract class MyPhysicsComponentBase : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyPhysicsComponentBase()

##### Declaration

```
protected MyPhysicsComponentBase()
```

### Fields

#### ContactPointDelay

Must be set before creating rigid body

##### Declaration

```
public ushort ContactPointDelay
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### EnabledChanged

##### Declaration

```
public Action EnabledChanged
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action |     |

#### Flags

##### Declaration

```
public RigidBodyFlag Flags
```

##### Field Value

| Type | Description |
| --- | --- |
| [RigidBodyFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html) |     |

#### IsPhantom

Use something from Havok to detect this

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### m\_enabled

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### m\_lastAngularVelocity

##### Declaration

```
protected Vector3 m_lastAngularVelocity
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### m\_lastLinearVelocity

##### Declaration

```
protected Vector3 m_lastLinearVelocity
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

### Properties

#### AngularAcceleration

##### Declaration

```
public virtual Vector3 AngularAcceleration { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### AngularDamping

Gets or sets the angular damping.

##### Declaration

```
public abstract float AngularDamping { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single | The angular damping. |

#### AngularVelocity

##### Declaration

```
public virtual Vector3 AngularVelocity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### AngularVelocityLocal

##### Declaration

```
public virtual Vector3 AngularVelocityLocal { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### CanUpdateAccelerations

##### Declaration

```
public bool CanUpdateAccelerations { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Center

##### Declaration

```
public Vector3 Center { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### CenterOfMassLocal

##### Declaration

```
public abstract Vector3 CenterOfMassLocal { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### CenterOfMassWorld

##### Declaration

```
public abstract Vector3D CenterOfMassWorld { get; }
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

#### Definition

##### Declaration

```
public MyPhysicsComponentDefinitionBase Definition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyPhysicsComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyPhysicsComponentDefinitionBase.html) |     |

#### Enabled

Gets or sets a value indicating whether this is enabled.

##### Declaration

```
public virtual bool Enabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean | `true` if enabled; otherwise, `false`. |

#### Entity

##### Declaration

```
public IMyEntity Entity { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### Friction

##### Declaration

```
public abstract float Friction { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Gravity

##### Declaration

```
public abstract Vector3 Gravity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### HasRigidBody

##### Declaration

```
public abstract bool HasRigidBody { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsActive

##### Declaration

```
public abstract bool IsActive { get; }
```
