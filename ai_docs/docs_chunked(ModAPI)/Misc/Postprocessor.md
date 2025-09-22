---
title: "Class MyPhysicalModelDefinition.Postprocessor"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalModelDefinition.Postprocessor.html"
category: "Misc"
namespace: "Sandbox.Definitions.MyPhysicalModelDefinition"
class: "Postprocessor"
---

# Class MyPhysicalModelDefinition.Postprocessor | Space Engineers ModAPI

##### Inheritance

System.Object

MyPhysicalModelDefinition.Postprocessor

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
protected class Postprocessor : MyDefinitionPostprocessor
```

### Constructors

#### Postprocessor()

##### Declaration

### Methods

#### AfterLoaded(ref MyDefinitionPostprocessor.Bundle)

##### Declaration

```
public override void AfterLoaded(ref MyDefinitionPostprocessor.Bundle definitions)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionPostprocessor.Bundle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDefinitionPostprocessor.Bundle.html) | definitions |     |

##### Overrides

#### AfterPostprocess(MyDefinitionSet, Dictionary<MyStringHash, MyDefinitionBase>)

##### Declaration

```
public override void AfterPostprocess(MyDefinitionSet set, Dictionary<MyStringHash, MyDefinitionBase> definitions)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionSet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionSet.html) | set |     |
| System.Collections.Generic.Dictionary<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html), [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html)\> | definitions |     |

##### Overrides