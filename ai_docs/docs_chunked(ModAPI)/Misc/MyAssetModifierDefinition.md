---
title: "Class MyAssetModifierDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyAssetModifierDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyAssetModifierDefinition"
---

# Class MyAssetModifierDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyAssetModifierDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyAssetModifierDefinition : MyDefinitionBase
```

### Constructors

#### MyAssetModifierDefinition()

##### Declaration

```
public MyAssetModifierDefinition()
```

### Fields

#### DefaultColor

##### Declaration

```
public Nullable<Color> DefaultColor
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)\> |     |

#### MetalnessColorable

##### Declaration

```
public bool MetalnessColorable
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Textures

##### Declaration

```
public List<MyObjectBuilder_AssetModifierDefinition.MyAssetTexture> Textures
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_AssetModifierDefinition.MyAssetTexture](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_AssetModifierDefinition.MyAssetTexture.html)\> |     |

### Methods

#### GetFilepath(String, MyTextureType)

##### Declaration

```
public string GetFilepath(string location, MyTextureType type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | location |     |
| VRageRender.Messages.MyTextureType | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

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