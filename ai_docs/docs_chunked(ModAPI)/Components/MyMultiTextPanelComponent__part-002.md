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

#### OnSelectImageSuccess(Int32, Int32\[\])

##### Declaration

```
[Event(null, 799)]
[Reliable]
[Broadcast]
public void OnSelectImageSuccess(int panelIndex, int[] selection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | panelIndex |     |
| System.Int32\[\] | selection |     |

#### RemoveItems(Int32, Int32\[\])

##### Declaration

```
public void RemoveItems(int panelIndex, int[] selection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | panelIndex |     |
| System.Int32\[\] | selection |     |

#### Reset()

##### Declaration

#### SelectItems(Int32, Int32\[\])

##### Declaration

```
public void SelectItems(int panelIndex, int[] selection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | panelIndex |     |
| System.Int32\[\] | selection |     |

#### SelectPanel(Int32)

##### Declaration

```
public void SelectPanel(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

#### SendAddImagesToSelectionRequest(Int32, Int32\[\])

##### Declaration

```
protected void SendAddImagesToSelectionRequest(int panelIndex, int[] selection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | panelIndex |     |
| System.Int32\[\] | selection |     |

#### SendChangeTextRequest(Int32, String)

##### Declaration

```
protected void SendChangeTextRequest(int panelIndex, string text)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | panelIndex |     |
| System.String | text |     |

#### SendRemoveSelectedImageRequest(Int32, Int32\[\])

##### Declaration

```
protected void SendRemoveSelectedImageRequest(int panelIndex, int[] selection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | panelIndex |     |
| System.Int32\[\] | selection |     |

#### SendUpdateSpriteCollection(Int32, MySerializableSpriteCollection)

##### Declaration

```
protected void SendUpdateSpriteCollection(int panelIndex, MySerializableSpriteCollection sprites)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | panelIndex |     |
| [MySerializableSpriteCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySerializableSpriteCollection.html) | sprites |     |

#### Serialize()

##### Declaration

```
public List<MySerializedTextPanelData> Serialize()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MySerializedTextPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MySerializedTextPanelData.html)\> |     |

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

#### SerializePanel(Int32)

##### Declaration

```
public MySerializedTextPanelData SerializePanel(int panelIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | panelIndex |     |

##### Returns

| Type | Description |
| --- | --- |
| [MySerializedTextPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MySerializedTextPanelData.html) |     |

#### SetPanelData(MySerializedTextPanelData, Int32)

##### Declaration

```
public void SetPanelData(MySerializedTextPanelData serializedData, int panelIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySerializedTextPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MySerializedTextPanelData.html) | serializedData |     |
| System.Int32 | panelIndex |     |

#### SetRender(MyRenderComponentScreenAreas)

##### Declaration

```
public void SetRender(MyRenderComponentScreenAreas render)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyRenderComponentScreenAreas](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyRenderComponentScreenAreas.html) | render |     |

#### UpdateAfterSimulation(Boolean)

##### Declaration

```
public void UpdateAfterSimulation(bool isWorking = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | isWorking |     |

#### UpdateScreen(Boolean)

##### Declaration

```
public void UpdateScreen(bool isWorking)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | isWorking |     |

#### UpdateSpriteCollection(Int32, MySerializableSpriteCollection)

##### Declaration

```
public void UpdateSpriteCollection(int panelIndex, MySerializableSpriteCollection sprites)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | panelIndex |     |
| [MySerializableSpriteCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySerializableSpriteCollection.html) | sprites |     |

### Explicit Interface Implementations

#### IMyTextSurfaceProvider.GetSurface(Int32)

##### Declaration

```
IMyTextSurface IMyTextSurfaceProvider.GetSurface(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyTextSurface](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextSurface.html) |     |
