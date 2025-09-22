---
title: "Class MyBlockVariantGroup"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlockVariantGroup.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyBlockVariantGroup"
---

# Class MyBlockVariantGroup | Space Engineers ModAPI

##### Inheritance

System.Object

MyBlockVariantGroup

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyBlockVariantGroup : MyDefinitionBase
```

### Constructors

#### MyBlockVariantGroup()

##### Declaration

```
public MyBlockVariantGroup()
```

### Fields

#### Blocks

##### Declaration

```
public MyCubeBlockDefinition[] Blocks
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)\[\] |     |

### Properties

#### BlockGroups

##### Declaration

```
public MyCubeBlockDefinitionGroup[] BlockGroups { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinitionGroup](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinitionGroup.html)\[\] |     |

#### PrimaryGUIBlock

##### Declaration

```
public MyCubeBlockDefinition PrimaryGUIBlock { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) |     |

### Methods

#### HasNewContent()

##### Declaration

```
public bool HasNewContent()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### MarkAsViewedContent()

##### Declaration

```
public void MarkAsViewedContent()
```

#### Postprocess()

##### Declaration

```
public override void Postprocess()
```

##### Overrides

#### ResolveBlocks()

##### Declaration

```
public void ResolveBlocks()
```