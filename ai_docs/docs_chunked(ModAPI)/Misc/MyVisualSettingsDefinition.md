---
title: "Class MyVisualSettingsDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVisualSettingsDefinition.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyVisualSettingsDefinition"
---

# Class MyVisualSettingsDefinition | Space Engineers ModAPI

Stripped environment definition with only visual settings

##### Inheritance

System.Object

MyVisualSettingsDefinition

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyVisualSettingsDefinition : MyDefinitionBase
```

### Constructors

#### MyVisualSettingsDefinition()

##### Declaration

```
public MyVisualSettingsDefinition()
```

### Fields

#### FogProperties

##### Declaration

```
public MyFogProperties FogProperties
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyFogProperties](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFogProperties.html) |     |

#### PostProcessSettings

##### Declaration

```
public MyPostprocessSettings PostProcessSettings
```

##### Field Value

| Type | Description |
| --- | --- |
| VRageRender.MyPostprocessSettings |     |

#### SunProperties

##### Declaration

```
public MySunProperties SunProperties
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySunProperties](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MySunProperties.html) |     |

### Properties

#### ShadowSettings

##### Declaration

```
public MyShadowsSettings ShadowSettings { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRageRender.MyShadowsSettings |     |

### Methods

#### GetObjectBuilder()

##### Declaration

```
public override MyObjectBuilder_DefinitionBase GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) |     |

##### Overrides

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