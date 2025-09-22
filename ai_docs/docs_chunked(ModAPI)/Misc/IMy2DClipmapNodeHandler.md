---
title: "Interface IMy2DClipmapNodeHandler"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMy2DClipmapNodeHandler.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment"
class: "IMy2DClipmapNodeHandler"
---

# Interface IMy2DClipmapNodeHandler | Space Engineers ModAPI

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMy2DClipmapNodeHandler
```

### Methods

#### Close()

##### Declaration

#### Init(IMy2DClipmapManager, Int32, Int32, Int32, ref BoundingBox2D)

##### Declaration

```
void Init(IMy2DClipmapManager parent, int x, int y, int lod, ref BoundingBox2D bounds)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMy2DClipmapManager](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMy2DClipmapManager.html) | parent |     |
| System.Int32 | x   |     |
| System.Int32 | y   |     |
| System.Int32 | lod |     |
| [BoundingBox2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html) | bounds |     |

#### InitJoin(IMy2DClipmapNodeHandler\[\])

##### Declaration

```
void InitJoin(IMy2DClipmapNodeHandler[] children)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMy2DClipmapNodeHandler](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMy2DClipmapNodeHandler.html)\[\] | children |     |

#### Split(BoundingBox2D\*, ref IMy2DClipmapNodeHandler\[\])

##### Declaration

```
void Split(BoundingBox2D*childBoxes, ref IMy2DClipmapNodeHandler[] children)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html)\* | childBoxes |     |
| [IMy2DClipmapNodeHandler](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMy2DClipmapNodeHandler.html)\[\] | children |     |