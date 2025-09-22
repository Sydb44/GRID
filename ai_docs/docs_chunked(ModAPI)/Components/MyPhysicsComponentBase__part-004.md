#### GetWorldMatrix()

##### Declaration

```
public MatrixD GetWorldMatrix()
```

##### Returns

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### GetWorldMatrix(out MatrixD)

##### Declaration

```
public abstract void GetWorldMatrix(out MatrixD matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix |     |

#### Init(MyComponentDefinitionBase)

##### Declaration

```
public override void Init(MyComponentDefinitionBase definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html) | definition |     |

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

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### OnWorldPositionChanged(Object)

Called when \[world position changed\].

##### Declaration

```
public abstract void OnWorldPositionChanged(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source | The source object that caused this event. |

#### Serialize(Boolean)

##### Declaration

```
public override MyObjectBuilder_ComponentBase Serialize(bool copy = false)
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

#### SetSpeeds(Vector3, Vector3)

Set the current linear and angular velocities of this physics body.

##### Declaration

```
public void SetSpeeds(Vector3 linear, Vector3 angular)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | linear |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | angular |     |

#### UpdateAccelerations()

##### Declaration

```
public void UpdateAccelerations()
```

#### UpdateFromSystem()

##### Declaration

```
public abstract void UpdateFromSystem()
```

#### WorldToCluster(Vector3D)

Converts global space position to local cluster space.

##### Declaration

```
public abstract Vector3D WorldToCluster(Vector3D worldPos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPos |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Events

#### OnBodyActiveStateChanged

OnBodyActiveStateChanged event - arg1 - Sender, arg2 - is active

##### Declaration

```
public abstract event Action<MyPhysicsComponentBase, bool> OnBodyActiveStateChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyPhysicsComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsComponentBase.html), System.Boolean\> |     |

### Extension Methods