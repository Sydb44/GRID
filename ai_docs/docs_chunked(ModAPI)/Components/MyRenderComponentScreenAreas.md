---
title: "Class MyRenderComponentScreenAreas"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyRenderComponentScreenAreas.html"
category: "Components"
namespace: "Sandbox.Game.Components"
class: "MyRenderComponentScreenAreas"
---

# Class MyRenderComponentScreenAreas | Space Engineers ModAPI

##### Inheritance

System.Object

MyRenderComponentScreenAreas

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyRenderComponentScreenAreas : MyRenderComponentCubeBlock, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyRenderComponentScreenAreas(MyEntity)

##### Declaration

```
public MyRenderComponentScreenAreas(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

### Properties

#### IsUpdateModelPropertiesEnabled

##### Declaration

```
public bool IsUpdateModelPropertiesEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### AddRenderObjects()

##### Declaration

```
public override void AddRenderObjects()
```

##### Overrides

#### AddScreenArea(UInt32\[\], String)

##### Declaration

```
public void AddScreenArea(uint[] renderObjectIDs, string materialName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32\[\] | renderObjectIDs |     |
| System.String | materialName |     |

#### ChangeTexture(Int32, String)

##### Declaration

```
public void ChangeTexture(int area, string path)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | area |     |
| System.String | path |     |

#### CreateTexture(Int32, Vector2I)

##### Declaration

```
public void CreateTexture(int area, Vector2I textureSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | area |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | textureSize |     |

#### GenerateOffscreenTextureName(Int64, Int32)

##### Declaration

```
public string GenerateOffscreenTextureName(long entityId, int area)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Int32 | area |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetTextureByteCount(Vector2I)

##### Declaration

```
public static int GetTextureByteCount(Vector2I textureSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | textureSize |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### HideScreenArea(Int32)

##### Declaration

```
public void HideScreenArea(int area)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | area |     |

#### ReleaseRenderObjectID(Int32)

##### Declaration

```
public override void ReleaseRenderObjectID(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Overrides

#### ReleaseTexture(Int32, Boolean)

##### Declaration

```
public void ReleaseTexture(int area, bool useEmptyTexture = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | area |     |
| System.Boolean | useEmptyTexture |     |

#### RenderSpritesToTexture(Int32, ListReader<MySprite>, Vector2I, Vector2, Color, Byte)

##### Declaration

```
public void RenderSpritesToTexture(int area, ListReader<MySprite> sprites, Vector2I textureSize, Vector2 aspectRatio, Color backgroundColor, byte backgroundAlpha)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | area |     |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MySprite](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySprite.html)\> | sprites |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | textureSize |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | aspectRatio |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | backgroundColor |     |
| System.Byte | backgroundAlpha |     |

#### UpdateModelProperties()

##### Declaration

```
public void UpdateModelProperties()
```

#### UpdateRenderAreas()

##### Declaration

```
protected void UpdateRenderAreas()
```

### Extension Methods