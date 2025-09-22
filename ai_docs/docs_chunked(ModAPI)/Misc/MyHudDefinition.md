---
title: "Class MyHudDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.GUI.MyHudDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions.GUI"
class: "MyHudDefinition"
---

# Class MyHudDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyHudDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions.GUI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.GUI.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyHudDefinition : MyDefinitionBase
```

### Constructors

#### MyHudDefinition()

##### Declaration

### Properties

#### Crosshair

##### Declaration

```
public MyObjectBuilder_CrosshairStyle Crosshair { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_CrosshairStyle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_CrosshairStyle.html) |     |

#### CustomUIScale

##### Declaration

```
public Nullable<float> CustomUIScale { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### DPad

##### Declaration

```
public MyObjectBuilder_DPadControlVisualStyle DPad { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_DPadControlVisualStyle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_DPadControlVisualStyle.html) |     |

#### GravityIndicator

##### Declaration

```
public MyObjectBuilder_GravityIndicatorVisualStyle GravityIndicator { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_GravityIndicatorVisualStyle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_GravityIndicatorVisualStyle.html) |     |

#### OptimalScreenRatio

##### Declaration

```
public Nullable<Vector2I> OptimalScreenRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html)\> |     |

#### StatControls

##### Declaration

```
public MyObjectBuilder_StatControls[] StatControls { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_StatControls](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_StatControls.html)\[\] |     |

#### TargetingMarkers

##### Declaration

```
public MyObjectBuilder_TargetingMarkersStyle TargetingMarkers { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_TargetingMarkersStyle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_TargetingMarkersStyle.html) |     |

#### Toolbar

##### Declaration

```
public MyObjectBuilder_ToolbarControlVisualStyle Toolbar { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ToolbarControlVisualStyle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_ToolbarControlVisualStyle.html) |     |

#### VisorOverlayTexture

##### Declaration

```
public Nullable<MyStringHash> VisorOverlayTexture { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\> |     |

### Methods

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Overrides