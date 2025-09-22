---
title: "Class MyPhysicsComponentDefinitionBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyPhysicsComponentDefinitionBase.html"
category: "Components"
namespace: "VRage.Game"
class: "MyPhysicsComponentDefinitionBase"
---

# Class MyPhysicsComponentDefinitionBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyPhysicsComponentDefinitionBase

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyPhysicsComponentDefinitionBase : MyComponentDefinitionBase
```

### Constructors

#### MyPhysicsComponentDefinitionBase()

##### Declaration

```
public MyPhysicsComponentDefinitionBase()
```

### Fields

#### AngularDamping

##### Declaration

```
public Nullable<float> AngularDamping
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### CollisionLayer

##### Declaration

```
public string CollisionLayer
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ForceActivate

##### Declaration

```
public bool ForceActivate
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LinearDamping

##### Declaration

```
public Nullable<float> LinearDamping
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### MassPropertiesComputation

##### Declaration

```
public MyObjectBuilder_PhysicsComponentDefinitionBase.MyMassPropertiesComputationType MassPropertiesComputation
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_PhysicsComponentDefinitionBase.MyMassPropertiesComputationType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_PhysicsComponentDefinitionBase.MyMassPropertiesComputationType.html) |     |

#### RigidBodyFlags

##### Declaration

```
public RigidBodyFlag RigidBodyFlags
```

##### Field Value

| Type | Description |
| --- | --- |
| [RigidBodyFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html) |     |

#### Serialize

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UpdateFlags

##### Declaration

```
public MyObjectBuilder_PhysicsComponentDefinitionBase.MyUpdateFlags UpdateFlags
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_PhysicsComponentDefinitionBase.MyUpdateFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_PhysicsComponentDefinitionBase.MyUpdateFlags.html) |     |

### Methods

#### GetObjectBuilder()

##### Declaration

```
public override MyObjectBuilder_DefinitionBase GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) |     |

##### Overrides

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Overrides