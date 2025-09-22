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

##### Declaration

```
public void SetPosition(Vector3D pos, object source = null, bool forceUpdate = false, bool updateChildren = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos | The position |
| System.Object | source |     |
| System.Boolean | forceUpdate |     |
| System.Boolean | updateChildren |     |

#### SetWorldMatrix(MatrixD, Object, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean)

##### Declaration

```
public void SetWorldMatrix(MatrixD worldMatrix, object source = null, bool forceUpdate = false, bool updateChildren = true, bool updateLocal = true, bool skipTeleportCheck = false, bool forceUpdateAllChildren = false, bool ignoreAssert = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| System.Object | source |     |
| System.Boolean | forceUpdate |     |
| System.Boolean | updateChildren |     |
| System.Boolean | updateLocal |     |
| System.Boolean | skipTeleportCheck |     |
| System.Boolean | forceUpdateAllChildren |     |
| System.Boolean | ignoreAssert |     |

#### SetWorldMatrix(ref MatrixD, Object, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean)

Sets the world matrix.

##### Declaration

```
public void SetWorldMatrix(ref MatrixD worldMatrix, object source = null, bool forceUpdate = false, bool updateChildren = true, bool updateLocal = true, bool skipTeleportCheck = false, bool forceUpdateAllChildren = false, bool ignoreAssert = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix | The world matrix. |
| System.Object | source | The source object that caused this change or null when not important. |
| System.Boolean | forceUpdate |     |
| System.Boolean | updateChildren |     |
| System.Boolean | updateLocal |     |
| System.Boolean | skipTeleportCheck |     |
| System.Boolean | forceUpdateAllChildren |     |
| System.Boolean | ignoreAssert |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### UpdateWorldMatrix(Object, Boolean, Boolean)

Updates the world matrix (change caused by this entity)

##### Declaration

```
protected virtual void UpdateWorldMatrix(object source = null, bool updateChildren = true, bool forceUpdateAllChildren = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |
| System.Boolean | updateChildren |     |
| System.Boolean | forceUpdateAllChildren |     |

#### UpdateWorldMatrix(ref MatrixD, Object, Boolean, Boolean)

Updates the world matrix (change caused by parent)

##### Declaration

```
public virtual void UpdateWorldMatrix(ref MatrixD parentWorldMatrix, object source = null, bool updateChildren = true, bool forceUpdateAllChildren = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | parentWorldMatrix |     |
| System.Object | source |     |
| System.Boolean | updateChildren |     |
| System.Boolean | forceUpdateAllChildren |     |

### Events

#### OnLocalAABBChanged

##### Declaration

```
public event Action<MyPositionComponentBase> OnLocalAABBChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyPositionComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPositionComponentBase.html)\> |     |

#### OnPositionChanged

##### Declaration

```
public event Action<MyPositionComponentBase> OnPositionChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyPositionComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPositionComponentBase.html)\> |     |

### Extension Methods