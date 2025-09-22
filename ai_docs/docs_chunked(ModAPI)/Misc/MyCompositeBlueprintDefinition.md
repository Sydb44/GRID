---
title: "Class MyCompositeBlueprintDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCompositeBlueprintDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyCompositeBlueprintDefinition"
---

# Class MyCompositeBlueprintDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyCompositeBlueprintDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyCompositeBlueprintDefinition : MyBlueprintDefinitionBase
```

### Constructors

#### MyCompositeBlueprintDefinition()

##### Declaration

```
public MyCompositeBlueprintDefinition()
```

### Methods

#### GetBlueprints(List<MyBlueprintDefinitionBase.ProductionInfo>)

##### Declaration

```
public override int GetBlueprints(List<MyBlueprintDefinitionBase.ProductionInfo> blueprints)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyBlueprintDefinitionBase.ProductionInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.ProductionInfo.html)\> | blueprints |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

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

#### Postprocess()

##### Declaration

```
public override void Postprocess()
```

##### Overrides