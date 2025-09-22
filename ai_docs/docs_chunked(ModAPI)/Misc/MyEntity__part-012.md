Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

colorMaskHsv

Color

#### IMyEntity.SetEmissiveParts(String, Color, Single)

Sets the emissive value of a specific emissive material on entity.

##### Declaration

```
void IMyEntity.SetEmissiveParts(string emissiveName, Color emissivePartColor, float emissivity)
```

##### Parameters

Type

Name

Description

System.String

emissiveName

The name of the emissive material (ie. "Emissive0")

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

emissivePartColor

Color to emit

System.Single

emissivity

Level of emissivity (0 is off, 1 is full brightness)

#### IMyEntity.SetEmissivePartsForSubparts(String, Color, Single)

Sets the emissive value of a specific emissive material on all entity subparts.

##### Declaration

```
void IMyEntity.SetEmissivePartsForSubparts(string emissiveName, Color emissivePartColor, float emissivity)
```

##### Parameters

Type

Name

Description

System.String

emissiveName

The name of the emissive material (ie. "Emissive0")

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

emissivePartColor

Color to emit

System.Single

emissivity

Level of emissivity (0 is off, 1 is full brightness).

#### IMyEntity.SetLocalMatrix(Matrix, Object)

Sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix

##### Declaration

```
void IMyEntity.SetLocalMatrix(Matrix localMatrix, object source)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

localMatrix

New matrix

System.Object

source

Object that caused this event. Not used in anyway

#### IMyEntity.SetPosition(Vector3D)

##### Declaration

```
void IMyEntity.SetPosition(Vector3D pos)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

pos

New position of entity

#### IMyEntity.SetTextureChangesForSubparts(Dictionary<String, MyTextureChange>)

This calling is obsolete, use another version.

##### Declaration

```
void IMyEntity.SetTextureChangesForSubparts(Dictionary<string, MyTextureChange> textureChanges)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.Dictionary<System.String, VRageRender.Messages.MyTextureChange\>

textureChanges

#### IMyEntity.SetTextureChangesForSubparts(Dictionary<MyStringId, MyTextureChange>)

##### Declaration

```
void IMyEntity.SetTextureChangesForSubparts(Dictionary<MyStringId, MyTextureChange> textureChanges)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.Dictionary<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html), VRageRender.Messages.MyTextureChange\>

textureChanges

#### IMyEntity.SetWorldMatrix(MatrixD, Object)

Sets world matrix of entity.

##### Declaration

```
void IMyEntity.SetWorldMatrix(MatrixD worldMatrix, object source)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

New world matrix

System.Object

source

Object that triggered set of new matrix

#### IMyEntity.ShadowBoxLod

##### Declaration

```
bool IMyEntity.ShadowBoxLod { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.SkipIfTooSmall

##### Declaration

```
bool IMyEntity.SkipIfTooSmall { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.Storage

Custom storage for mods. Shared with all mods.

##### Declaration

```
MyModStorageComponentBase IMyEntity.Storage { get; set; }
```

##### Returns

Type

Description

[MyModStorageComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyModStorageComponentBase.html)

#### IMyEntity.Synchronized

Gets or sets if the entity should be synced.

##### Declaration

```
bool IMyEntity.Synchronized { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.Transparent

Gets or sets [Transparency](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyRenderComponentBase.html#VRage_Game_Components_MyRenderComponentBase_Transparency). When setting true entity would be 25% transparent

##### Declaration

```
bool IMyEntity.Transparent { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.Visible

##### Declaration

```
bool IMyEntity.Visible { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.WorldMatrix

Gets or sets world matrix.

##### Declaration

```
MatrixD IMyEntity.WorldMatrix { get; set; }
```

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

##### See Also

#### IMyEntity.WorldMatrixInvScaled

##### Declaration

```
MatrixD IMyEntity.WorldMatrixInvScaled { get; }
```

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

Matrix

#### IMyEntity.WorldMatrixNormalizedInv

##### Declaration

```
MatrixD IMyEntity.WorldMatrixNormalizedInv { get; }
```

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

Matrix

### Implements

### Extension Methods