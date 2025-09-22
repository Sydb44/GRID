```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type | Type of parent. When type is null, type check disabled |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | Entity |

#### GetTrianglesIntersectingSphere(ref BoundingSphere, Nullable<Vector3>, Nullable<Single>, List<MyTriangle\_Vertex\_Normals>, Int32)

Return list of triangles intersecting specified sphere. Angle between every triangleVertexes normal vector and 'referenceNormalVector' is calculated, and if more than 'maxAngle', we ignore such triangleVertexes. Triangles are returned in 'retTriangles', and this list must be preallocated! IMPORTANT: Sphere must be in model space, so don't transform it!

##### Declaration

```
void GetTrianglesIntersectingSphere(ref BoundingSphere sphere, Nullable<Vector3> referenceNormalVector, Nullable<float> maxAngle, List<MyTriangle_Vertex_Normals> retTriangles, int maxNeighbourTriangles)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | Sphere to check |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> | referenceNormalVector | Used in filtering triangles |
| System.Nullable<System.Single\> | maxAngle | Max angle between referenceNormalVector and every triangleVertex of model |
| System.Collections.Generic.List<[MyTriangle\_Vertex\_Normals](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyTriangle_Vertex_Normals.html)\> | retTriangles | Triangles would be added here |
| System.Int32 | maxNeighbourTriangles | Limit of added triangles |

#### GetViewMatrix()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | Matrix |

#### GetWorldMatrixNormalizedInv()

##### Declaration

```
MatrixD GetWorldMatrixNormalizedInv()
```

##### Returns

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | Matrix |

#### IsVisible()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if entity should be drawn |

#### OnAddedToScene(Object)

Adds entity to scene: init updates, render physics

##### Declaration

```
void OnAddedToScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source | Object that triggered adding from scene |

#### OnRemovedFromScene(Object)

Remove entity and it's children from scene: stops updates and render, deactivates physics. Usually called when entity deleted

##### Declaration

```
void OnRemovedFromScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source | Object that triggered removing from scene |

#### RemoveFromGamePruningStructure()

##### Declaration

```
void RemoveFromGamePruningStructure()
```

#### SetColorMaskForSubparts(Vector3)

Sets subparts custom col

##### Declaration

```
void SetColorMaskForSubparts(Vector3 colorMaskHsv)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | colorMaskHsv | Color |

#### SetEmissiveParts(String, Color, Single)

Sets the emissive value of a specific emissive material on entity.

##### Declaration

```
void SetEmissiveParts(string emissiveName, Color emissivePartColor, float emissivity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | emissiveName | The name of the emissive material (ie. "Emissive0") |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | emissivePartColor | Color to emit |
| System.Single | emissivity | Level of emissivity (0 is off, 1 is full brightness) |

#### SetEmissivePartsForSubparts(String, Color, Single)

Sets the emissive value of a specific emissive material on all entity subparts.

##### Declaration

```
void SetEmissivePartsForSubparts(string emissiveName, Color emissivePartColor, float emissivity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | emissiveName | The name of the emissive material (ie. "Emissive0") |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | emissivePartColor | Color to emit |
| System.Single | emissivity | Level of emissivity (0 is off, 1 is full brightness). |

#### SetLocalMatrix(Matrix, Object)

Sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix

##### Declaration

```
void SetLocalMatrix(Matrix localMatrix, object source = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | localMatrix | New matrix |
| System.Object | source | Object that caused this event. Not used in anyway |

#### SetPosition(Vector3D)

##### Declaration

```
void SetPosition(Vector3D pos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos | New position of entity |

#### SetTextureChangesForSubparts(Dictionary<String, MyTextureChange>)

This calling is obsolete, use another version.

##### Declaration

```
void SetTextureChangesForSubparts(Dictionary<string, MyTextureChange> value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<System.String, VRageRender.Messages.MyTextureChange\> | value |     |

#### SetTextureChangesForSubparts(Dictionary<MyStringId, MyTextureChange>)

Sets subparts custom skinning. Copy values from [TextureChanges](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyRenderComponentBase.html#VRage_Game_Components_MyRenderComponentBase_TextureChanges), then change needed keys. You can retrieve values for exact skin with following code:

```
MyDefinitionManager.Static.GetAssetModifierDefinitionForRender(skinId);
```
