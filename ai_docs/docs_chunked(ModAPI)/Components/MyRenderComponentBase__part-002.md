#### DrawOutsideViewDistance

##### Declaration

```
public bool DrawOutsideViewDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnableColorMaskHsv

##### Declaration

```
public bool EnableColorMaskHsv { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FastCastShadowResolve

##### Declaration

```
public bool FastCastShadowResolve { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MetalnessColorable

##### Declaration

```
public bool MetalnessColorable { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ModelStorage

Used by game to store model here. In game this is always of type MyModel. Implementation should only store and return passed object.

##### Declaration

```
public abstract object ModelStorage { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Object |     |

#### NearFlag

##### Declaration

```
public virtual bool NearFlag { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsDraw

##### Declaration

```
public virtual bool NeedsDraw { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsDrawFromParent

##### Declaration

```
public bool NeedsDrawFromParent { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsResolveCastShadow

##### Declaration

```
public bool NeedsResolveCastShadow { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OffsetInVertexShader

##### Declaration

```
public bool OffsetInVertexShader { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ParentIDs

##### Declaration

```
public uint[] ParentIDs { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32\[\] |     |

#### PersistentFlags

##### Declaration

```
public MyPersistentEntityFlags2 PersistentFlags { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyPersistentEntityFlags2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyPersistentEntityFlags2.html) |     |

#### RenderObjectIDs

##### Declaration

```
public uint[] RenderObjectIDs { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32\[\] |     |

#### ShadowBoxLod

##### Declaration

```
public bool ShadowBoxLod { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SkipIfTooSmall

##### Declaration

```
public bool SkipIfTooSmall { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TextureChanges

##### Declaration

```
public Dictionary<MyStringId, MyTextureChange> TextureChanges { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html), VRageRender.Messages.MyTextureChange\> |     |

#### Visible

##### Declaration

```
public bool Visible { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### AddRenderObjects()

##### Declaration

```
public abstract void AddRenderObjects()
```

#### CanBeAddedToRender()

##### Declaration

```
protected virtual bool CanBeAddedToRender()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Draw()

##### Declaration

```
public abstract void Draw()
```

#### GetDiffuseColor()

##### Declaration

```
public Color GetDiffuseColor()
```

##### Returns

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### GetRenderCullingOptions()

##### Declaration

```
public virtual CullingOptions GetRenderCullingOptions()
```

##### Returns

| Type | Description |
| --- | --- |
| VRageRender.CullingOptions |     |

#### GetRenderFlags()

##### Declaration

```
public virtual RenderFlags GetRenderFlags()
```

##### Returns

| Type | Description |
| --- | --- |
| VRageRender.RenderFlags |     |

#### GetRenderObjectID()

##### Declaration

```
public uint GetRenderObjectID()
```

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### InvalidateRenderObjects()

##### Declaration

```
public virtual void InvalidateRenderObjects()
```

#### IsChild(Int32)

##### Declaration

```
public bool IsChild(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsRenderObjectAssigned(Int32)

##### Declaration

```
public bool IsRenderObjectAssigned(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsVisible()

##### Declaration

```
public abstract bool IsVisible()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PropagateVisibilityUpdates(Boolean)

##### Declaration

```
protected void PropagateVisibilityUpdates(bool always = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | always |     |

#### ReleaseRenderObjectID(Int32)

##### Declaration

```
public abstract void ReleaseRenderObjectID(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

#### RemoveRenderObjects()

##### Declaration

```
public virtual void RemoveRenderObjects()
```
