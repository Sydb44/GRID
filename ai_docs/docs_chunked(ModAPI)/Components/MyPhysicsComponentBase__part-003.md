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

#### ApplyImpulse(Vector3, Vector3D)

Applies the impulse.

##### Declaration

```
public abstract void ApplyImpulse(Vector3 dir, Vector3D pos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | dir | The dir. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos | The pos. |

#### Clear()

Clear all dynamic values of physics object.

##### Declaration

```
public abstract void Clear()
```

#### ClearSpeed()

Clears the speeds.

##### Declaration

```
public abstract void ClearSpeed()
```

#### Close()

##### Declaration

```
public virtual void Close()
```

#### CloseRigidBody()

##### Declaration

```
protected abstract void CloseRigidBody()
```

#### ClusterToWorld(Vector3)

Converts local cluster position to global space.

##### Declaration

```
public abstract Vector3D ClusterToWorld(Vector3 clusterPos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | clusterPos |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### CreateCharacterCollision(Vector3, Single, Single, Single, Single, Single, Single, MatrixD, Single, UInt16, Boolean, Single, Single, Single, Boolean, Nullable<Single>)

##### Declaration

```
public abstract void CreateCharacterCollision(Vector3 center, float characterWidth, float characterHeight, float crouchHeight, float ladderHeight, float headSize, float headHeight, MatrixD worldTransform, float mass, ushort collisionLayer, bool isOnlyVertical, float maxSlope, float maxLimit, float maxSpeedRelativeToShip, bool networkProxy, Nullable<float> maxForce)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | center |     |
| System.Single | characterWidth |     |
| System.Single | characterHeight |     |
| System.Single | crouchHeight |     |
| System.Single | ladderHeight |     |
| System.Single | headSize |     |
| System.Single | headHeight |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldTransform |     |
| System.Single | mass |     |
| System.UInt16 | collisionLayer |     |
| System.Boolean | isOnlyVertical |     |
| System.Single | maxSlope |     |
| System.Single | maxLimit |     |
| System.Single | maxSpeedRelativeToShip |     |
| System.Boolean | networkProxy |     |
| System.Nullable<System.Single\> | maxForce |     |

#### Deactivate()

Deactivates this rigid body in physics.

##### Declaration

```
public abstract void Deactivate()
```

#### DebugDraw()

Debug draw of this physics object.

##### Declaration

```
public abstract void DebugDraw()
```

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase baseBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | baseBuilder |     |

##### Overrides

#### ForceActivate()

##### Declaration

```
public abstract void ForceActivate()
```

#### GetMaterialAt(Vector3D)

##### Declaration

```
public virtual MyStringHash GetMaterialAt(Vector3D worldPos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPos |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### GetVelocityAtPoint(Vector3D)

##### Declaration

```
public abstract Vector3 GetVelocityAtPoint(Vector3D worldPos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPos |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### GetVelocityAtPointLocal(ref Vector3D, out Vector3)

##### Declaration

```
public abstract void GetVelocityAtPointLocal(ref Vector3D worldPos, out Vector3 linearVelocity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPos |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | linearVelocity |     |

#### GetWorldMatrix()

##### Declaration

```
public MatrixD GetWorldMatrix()
```

##### Returns

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |
