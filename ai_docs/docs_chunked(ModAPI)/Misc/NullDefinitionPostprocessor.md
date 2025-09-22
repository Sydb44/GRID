---
title: "Class NullDefinitionPostprocessor"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.NullDefinitionPostprocessor.html"
category: "Misc"
namespace: "VRage.Game.Definitions"
class: "NullDefinitionPostprocessor"
---

# Class NullDefinitionPostprocessor | Space Engineers ModAPI

##### Inheritance

System.Object

NullDefinitionPostprocessor

##### Inherited Members

###### **Namespace**: [VRage.Game.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class NullDefinitionPostprocessor : MyDefinitionPostprocessor
```

### Constructors

#### NullDefinitionPostprocessor()

##### Declaration

```
public NullDefinitionPostprocessor()
```

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