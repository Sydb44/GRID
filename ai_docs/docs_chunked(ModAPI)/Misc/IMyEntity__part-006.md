##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<System.String, VRageRender.Messages.MyTextureChange\> | value |     |

#### SetTextureChangesForSubparts(Dictionary<MyStringId, MyTextureChange>)

Sets subparts custom skinning. Copy values from [TextureChanges](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyRenderComponentBase.html#VRage_Game_Components_MyRenderComponentBase_TextureChanges), then change needed keys. You can retrieve values for exact skin with following code:

```
MyDefinitionManager.Static.GetAssetModifierDefinitionForRender(skinId);
```

##### Declaration

```
void SetTextureChangesForSubparts(Dictionary<MyStringId, MyTextureChange> value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html), VRageRender.Messages.MyTextureChange\> | value | Key - name of texture, value - path to texture files |

#### SetWorldMatrix(MatrixD, Object)

Sets world matrix of entity.

##### Declaration

```
void SetWorldMatrix(MatrixD worldMatrix, object source = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix | New world matrix |
| System.Object | source | Object that triggered set of new matrix |

#### Teleport(MatrixD, Object, Boolean)

When moving entity over large distances or when entity has children, using this method preferred over [SetPosition(Vector3D)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_SetPosition_VRageMath_Vector3D_)

##### Declaration

```
void Teleport(MatrixD pos, object source = null, bool ignoreAssert = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | pos | Teleport destination |
| System.Object | source | Object that triggered |
| System.Boolean | ignoreAssert | Do extra validation |

#### TryGetSubpart(String, out MyEntitySubpart)

Gets subpart by subpart name

##### Declaration

```
bool TryGetSubpart(string name, out MyEntitySubpart subpart)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | Name of subpart. Keep in mind that subpart names, should not start with `subpart_` |
| [MyEntitySubpart](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntitySubpart.html) | subpart | Subpart if it is found |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if subpart is found |

#### UpdateGamePruningStructure()

Update position of entity in MyGamePruningStructure. Calls:

```
MyGamePruningStructure.Move(this)
```

##### Declaration

```
void UpdateGamePruningStructure()
```

### Events

#### OnClose

##### Declaration

```
event Action<IMyEntity> OnClose
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

#### OnClosing

##### Declaration

```
event Action<IMyEntity> OnClosing
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

#### OnMarkForClose

##### Declaration

```
event Action<IMyEntity> OnMarkForClose
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

#### OnPhysicsChanged

Called when havok rigid body physics are changed: inited, closed, modified.

##### Declaration

```
event Action<IMyEntity> OnPhysicsChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |