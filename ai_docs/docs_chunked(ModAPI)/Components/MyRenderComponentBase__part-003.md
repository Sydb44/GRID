##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

#### RemoveRenderObjects()

##### Declaration

```
public virtual void RemoveRenderObjects()
```

#### ResizeRenderObjectArray(Int32)

##### Declaration

```
public void ResizeRenderObjectArray(int newSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | newSize |     |

#### SetParent(Int32, UInt32, Nullable<Matrix>)

##### Declaration

```
public void SetParent(int index, uint cellParentCullObject, Nullable<Matrix> childToParent = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |
| System.UInt32 | cellParentCullObject |     |
| System.Nullable<[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)\> | childToParent |     |

#### SetRenderObjectID(Int32, UInt32)

##### Declaration

```
public abstract void SetRenderObjectID(int index, uint ID)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |
| System.UInt32 | ID  |     |

#### SetVisibilityUpdates(Boolean)

##### Declaration

```
public void SetVisibilityUpdates(bool state)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | state |     |

#### UpdateRenderEntity(Vector3)

##### Declaration

```
public virtual void UpdateRenderEntity(Vector3 colorMaskHSV)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | colorMaskHSV |     |

#### UpdateRenderObject(Boolean, Boolean)

##### Declaration

```
public void UpdateRenderObject(bool visible, bool updateChildren = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | visible |     |
| System.Boolean | updateChildren |     |

#### UpdateRenderObjectLocal(Matrix)

##### Declaration

```
public void UpdateRenderObjectLocal(Matrix renderLocalMatrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | renderLocalMatrix |     |

#### UpdateRenderObjectVisibility(Boolean)

##### Declaration

```
protected virtual void UpdateRenderObjectVisibility(bool visible)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | visible |     |

#### UpdateRenderTextureChanges(Dictionary<MyStringId, MyTextureChange>)

##### Declaration

```
public virtual void UpdateRenderTextureChanges(Dictionary<MyStringId, MyTextureChange> skinTextureChanges)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html), VRageRender.Messages.MyTextureChange\> | skinTextureChanges |     |

#### UpdateTransparency()

##### Declaration

```
public void UpdateTransparency()
```

### Extension Methods