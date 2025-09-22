#### NeedsRecalculateWorldMatrix

##### Declaration

```
public bool NeedsRecalculateWorldMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Scale

##### Declaration

```
public Nullable<float> Scale { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### ShouldSync

##### Declaration

```
protected virtual bool ShouldSync { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### WorldAABB

Gets the world aabb.

##### Declaration

```
public BoundingBoxD WorldAABB { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### WorldMatrix

##### Declaration

```
public MatrixD WorldMatrix { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### WorldMatrixInvScaled

##### Declaration

```
public ref readonly MatrixD WorldMatrixInvScaled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### WorldMatrixNormalizedInv

##### Declaration

```
public ref readonly MatrixD WorldMatrixNormalizedInv { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### WorldMatrixRef

World matrix of this physic object. Use it whenever you want to do world-matrix transformations with this physic objects.

##### Declaration

```
public ref readonly MatrixD WorldMatrixRef { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### WorldVolume

Gets the world volume.

##### Declaration

```
public BoundingSphereD WorldVolume { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) |     |

### Methods

#### GetOrientation()

Gets the entity orientation.

##### Declaration

```
public MatrixD GetOrientation()
```

##### Returns

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### GetPosition()

Gets the entity position.

##### Declaration

```
public Vector3D GetPosition()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### GetViewMatrix()

##### Declaration

```
public virtual MatrixD GetViewMatrix()
```

##### Returns

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

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

#### OnWorldPositionChanged(Object, Boolean, Boolean)

Called when \[world position changed\].

##### Declaration

```
protected virtual void OnWorldPositionChanged(object source, bool updateChildren = true, bool forceUpdateAllChildren = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source | The source object that caused this event. |
| System.Boolean | updateChildren |     |
| System.Boolean | forceUpdateAllChildren |     |

#### RaiseOnPositionChanged(MyPositionComponentBase)

##### Declaration

```
protected void RaiseOnPositionChanged(MyPositionComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPositionComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPositionComponentBase.html) | component |     |

#### RecalculateWorldMatrixHRIfNeeded(Boolean)

Recursively recalculate world matrices for this entity and it's parents.

##### Declaration

```
protected bool RecalculateWorldMatrixHRIfNeeded(bool updateChildren = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | updateChildren |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if the world matrix has changed. |

#### SetLocalMatrix(ref Matrix, Object, Boolean)

##### Declaration

```
public bool SetLocalMatrix(ref Matrix localMatrix, object source = null, bool updateWorld = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | localMatrix |     |
| System.Object | source |     |
| System.Boolean | updateWorld |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true when World matrix needed recalculations as it got changed in here |

#### SetLocalMatrix(ref Matrix, Object, Boolean, ref Matrix, Boolean)

##### Declaration

```
public void SetLocalMatrix(ref Matrix localMatrix, object source, bool updateWorld, ref Matrix renderLocal, bool forceUpdateRender = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | localMatrix |     |
| System.Object | source |     |
| System.Boolean | updateWorld |     |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | renderLocal |     |
| System.Boolean | forceUpdateRender |     |

#### SetPosition(Vector3D, Object, Boolean, Boolean)

Sets the position.
