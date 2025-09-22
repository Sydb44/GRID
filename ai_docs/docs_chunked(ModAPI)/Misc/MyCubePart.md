---
title: "Class MyCubePart"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubePart.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyCubePart"
---

# Class MyCubePart | Space Engineers ModAPI

##### Inheritance

System.Object

MyCubePart

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyCubePart : Object
```

### Constructors

#### MyCubePart()

##### Declaration

### Fields

#### InstanceData

##### Declaration

```
public MyCubeInstanceData InstanceData
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.MyCubeInstanceData |     |

#### Model

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Game.Models.MyModel |     |

#### SkinSubtypeId

##### Declaration

```
public MyStringHash SkinSubtypeId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

### Methods

#### Init(MyModel, MyStringHash, Matrix, Single)

##### Declaration

```
public void Init(MyModel model, MyStringHash skinSubtypeId, Matrix matrix, float rescaleModel = 1F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.Models.MyModel | model |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | skinSubtypeId |     |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix |     |
| System.Single | rescaleModel |     |