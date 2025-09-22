---
title: "Class MyRenderComponentBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyRenderComponentBase.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyRenderComponentBase"
---

# Class MyRenderComponentBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyRenderComponentBase

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MyRenderComponentBase : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyRenderComponentBase()

##### Declaration

```
protected MyRenderComponentBase()
```

### Fields

#### DepthBias

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### FadeIn

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FadeOut

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LastMomentUpdateIndex

##### Declaration

```
public int LastMomentUpdateIndex
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### m\_colorMaskHsv

##### Declaration

```
protected Vector3 m_colorMaskHsv
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### m\_diffuseColor

##### Declaration

```
protected Color m_diffuseColor
```

##### Field Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### m\_enableColorMaskHsv

##### Declaration

```
protected bool m_enableColorMaskHsv
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### m\_parentIDs

##### Declaration

```
protected uint[] m_parentIDs
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt32\[\] |     |

#### m\_renderObjectIDs

##### Declaration

```
protected uint[] m_renderObjectIDs
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt32\[\] |     |

#### m\_textureChanges

##### Declaration

```
protected Dictionary<MyStringId, MyTextureChange> m_textureChanges
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html), VRageRender.Messages.MyTextureChange\> |     |

#### NeedForDrawFromParentChanged

##### Declaration

```
public Action NeedForDrawFromParentChanged
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action |     |

#### OldBlackToHSV

##### Declaration

```
public static readonly Vector3 OldBlackToHSV
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### OldBlueToHSV

##### Declaration

```
public static readonly Vector3 OldBlueToHSV
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### OldGrayToHSV

##### Declaration

```
public static readonly Vector3 OldGrayToHSV
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### OldGreenToHSV

##### Declaration

```
public static readonly Vector3 OldGreenToHSV
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### OldRedToHSV

##### Declaration

```
public static readonly Vector3 OldRedToHSV
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### OldWhiteToHSV

##### Declaration

```
public static readonly Vector3 OldWhiteToHSV
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### OldYellowToHSV

##### Declaration

```
public static readonly Vector3 OldYellowToHSV
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Transparency

##### Declaration

```
public float Transparency
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### UNINITIALIZED\_IDs

##### Declaration

```
public static uint[] UNINITIALIZED_IDs
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt32\[\] |     |

### Properties

#### CastShadows

##### Declaration

```
public bool CastShadows { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ColorMaskHsv

##### Declaration

```
public Vector3 ColorMaskHsv { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

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

#### DrawInAllCascades

##### Declaration

```
public bool DrawInAllCascades { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DrawOutsideViewDistance

##### Declaration

```
public bool DrawOutsideViewDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |
