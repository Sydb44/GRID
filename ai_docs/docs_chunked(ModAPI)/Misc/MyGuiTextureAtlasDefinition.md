---
title: "Class MyGuiTextureAtlasDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyGuiTextureAtlasDefinition.html"
category: "Misc"
namespace: "VRage.Game.Definitions"
class: "MyGuiTextureAtlasDefinition"
---

# Class MyGuiTextureAtlasDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyGuiTextureAtlasDefinition

##### Inherited Members

###### **Namespace**: [VRage.Game.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyGuiTextureAtlasDefinition : MyDefinitionBase
```

### Constructors

#### MyGuiTextureAtlasDefinition()

##### Declaration

```
public MyGuiTextureAtlasDefinition()
```

### Fields

#### CompositeTextures

##### Declaration

```
public readonly Dictionary<MyStringHash, MyObjectBuilder_CompositeTexture> CompositeTextures
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html), [MyObjectBuilder\_CompositeTexture](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_CompositeTexture.html)\> |     |

#### Textures

##### Declaration

```
public readonly Dictionary<MyStringHash, MyObjectBuilder_GuiTexture> Textures
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html), [MyObjectBuilder\_GuiTexture](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_GuiTexture.html)\> |     |

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