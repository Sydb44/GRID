##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsActive

##### Declaration

```
public abstract bool IsActive { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsInWorld

##### Declaration

```
public virtual bool IsInWorld { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsKinematic

Gets or sets a value indicating whether this is kinematic.

##### Declaration

```
public virtual bool IsKinematic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean | `true` if kinematic; otherwise, `false`. |

#### IsMoving

##### Declaration

```
public abstract bool IsMoving { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsStatic

Gets or sets a value indicating whether this is static.

##### Declaration

```
public virtual bool IsStatic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean | `true` if static; otherwise, `false`. |

#### LinearAcceleration

##### Declaration

```
public virtual Vector3 LinearAcceleration { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### LinearDamping

Gets or sets the linear damping.

##### Declaration

```
public abstract float LinearDamping { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single | The linear damping. |

#### LinearVelocity

Gets or sets the linear velocity.

##### Declaration

```
public virtual Vector3 LinearVelocity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | The linear velocity. |

#### LinearVelocityLocal

##### Declaration

```
public virtual Vector3 LinearVelocityLocal { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### LinearVelocityUnsafe

##### Declaration

```
public virtual Vector3 LinearVelocityUnsafe { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Mass

Gets or sets the mass.

##### Declaration

```
public abstract float Mass { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single | The mass. |

#### MaterialType

Gets or sets the type of the material.

##### Declaration

```
public MyStringHash MaterialType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | The type of the material. |

#### PlayCollisionCueEnabled

Gets or sets a value indicating whether \[play collision cue enabled\].

##### Declaration

```
public bool PlayCollisionCueEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean | `true` if \[play collision cue enabled\]; otherwise, `false`. |

#### ReportAllContacts

##### Declaration

```
public bool ReportAllContacts { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RigidBody

Obtain/set (default) rigid body of this physics object.

##### Declaration

```
public abstract HkRigidBody RigidBody { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Havok.HkRigidBody |     |

#### RigidBody2

Obtain/set secondary rigid body of this physics object (not used by default, it is used sometimes on grids for kinematic layer).

##### Declaration

```
public abstract HkRigidBody RigidBody2 { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Havok.HkRigidBody |     |

#### ShapeChangeInProgress

##### Declaration

```
public virtual bool ShapeChangeInProgress { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Speed

Gets or sets the speed.

##### Declaration

```
public abstract float Speed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single | The speed. |

#### SupportNormal

##### Declaration

```
public virtual Vector3 SupportNormal { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

### Methods

#### Activate()

Activates this rigid body in physics.

##### Declaration

```
public abstract void Activate()
```

#### AddForce(MyPhysicsForceType, Nullable<Vector3>, Nullable<Vector3D>, Nullable<Vector3>, Nullable<Single>, Boolean, Boolean)

Applies external force to the physics object.

##### Declaration

```
public abstract void AddForce(MyPhysicsForceType type, Nullable<Vector3> force, Nullable<Vector3D> position, Nullable<Vector3> torque, Nullable<float> maxSpeed = null, bool applyImmediately = true, bool activeOnly = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPhysicsForceType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsForceType.html) | type | The type. |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> | force | The force. |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | position | The position. |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> | torque | The torque. |
| System.Nullable<System.Single\> | maxSpeed | Clamp max speed |
| System.Boolean | applyImmediately | Apply immediately or enqueue to apply right before simulation |
| System.Boolean | activeOnly | Only apply if the object is already active |
