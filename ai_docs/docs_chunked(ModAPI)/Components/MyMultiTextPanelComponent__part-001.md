---
title: "Class MyMultiTextPanelComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyMultiTextPanelComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyMultiTextPanelComponent"
---

# Class MyMultiTextPanelComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyMultiTextPanelComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyMultiTextPanelComponent : MyEventProxyEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyTextSurfaceProvider, IMyTextPanelProvider
```

### Constructors

#### MyMultiTextPanelComponent()

##### Declaration

```
public MyMultiTextPanelComponent()
```

#### MyMultiTextPanelComponent(List<MySerializedTextPanelData>, Single)

##### Declaration

```
public MyMultiTextPanelComponent(List<MySerializedTextPanelData> panelsData, float maxRenderDistance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MySerializedTextPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MySerializedTextPanelData.html)\> | panelsData |     |
| System.Single | maxRenderDistance |     |

### Properties

#### AnyPanelNeedsUpdateByOwner

##### Declaration

```
public bool AnyPanelNeedsUpdateByOwner { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### PanelComponent

##### Declaration

```
public MyTextPanelComponent PanelComponent { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Blocks.MyTextPanelComponent |     |

#### Panels

##### Declaration

```
public List<MyTextPanelComponent> Panels { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<Sandbox.Game.Entities.Blocks.MyTextPanelComponent\> |     |

#### PanelTexturesByteCount

##### Declaration

```
public int PanelTexturesByteCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### RangeIndex

##### Declaration

```
public int RangeIndex { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### SelectedPanelIndex

##### Declaration

```
public int SelectedPanelIndex { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### SurfaceCount

##### Declaration

```
public int SurfaceCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### UseGenericLcd

##### Declaration

```
public bool UseGenericLcd { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### WorldPosition

##### Declaration

```
public Vector3D WorldPosition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Methods

#### AddToScene(Nullable<Int32>)

##### Declaration

```
public void AddToScene(Nullable<int> renderObjectIndex = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<System.Int32\> | renderObjectIndex |     |

#### ChangeText(Int32, String)

##### Declaration

```
public void ChangeText(int panelIndex, string text)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | panelIndex |     |
| System.String | text |     |

#### CreateTerminalControls<T>()

##### Declaration

```
public static void CreateTerminalControls<T>()
    where T : MyTerminalBlock, IMyTextSurfaceProvider, IMyMultiTextPanelComponentOwner
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | builder |     |

##### Overrides

#### GetPanelComponent(Int32)

##### Declaration

```
public MyTextPanelComponent GetPanelComponent(int panelIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | panelIndex |     |

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Blocks.MyTextPanelComponent |     |

#### GetSurface(Int32)

##### Declaration

```
public IMyTextSurface GetSurface(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyTextSurface](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextSurface.html) |     |

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
