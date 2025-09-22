---
title: "Class MyDefinitionPostprocessor"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDefinitionPostprocessor.html"
category: "Misc"
namespace: "VRage.Game.Definitions"
class: "MyDefinitionPostprocessor"
---

# Class MyDefinitionPostprocessor | Space Engineers ModAPI

##### Inheritance

System.Object

MyDefinitionPostprocessor

###### **Namespace**: [VRage.Game.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MyDefinitionPostprocessor : Object
```

### Constructors

#### MyDefinitionPostprocessor()

##### Declaration

```
protected MyDefinitionPostprocessor()
```

### Fields

#### Comparer

##### Declaration

```
public static MyDefinitionPostprocessor.PostprocessorComparer Comparer
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionPostprocessor.PostprocessorComparer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDefinitionPostprocessor.PostprocessorComparer.html) |     |

#### DefinitionType

##### Declaration

```
public Type DefinitionType
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Type |     |

### Properties

#### Priority

##### Declaration

```
public virtual int Priority { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### AfterLoaded(ref MyDefinitionPostprocessor.Bundle)

##### Declaration

```
public abstract void AfterLoaded(ref MyDefinitionPostprocessor.Bundle definitions)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionPostprocessor.Bundle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDefinitionPostprocessor.Bundle.html) | definitions |     |

#### AfterPostprocess(MyDefinitionSet, Dictionary<MyStringHash, MyDefinitionBase>)

##### Declaration

```
public abstract void AfterPostprocess(MyDefinitionSet set, Dictionary<MyStringHash, MyDefinitionBase> definitions)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionSet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionSet.html) | set |     |
| System.Collections.Generic.Dictionary<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html), [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html)\> | definitions |     |

#### OverrideBy(ref MyDefinitionPostprocessor.Bundle, ref MyDefinitionPostprocessor.Bundle)

##### Declaration

```
public virtual void OverrideBy(ref MyDefinitionPostprocessor.Bundle currentDefinitions, ref MyDefinitionPostprocessor.Bundle overrideBySet)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionPostprocessor.Bundle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDefinitionPostprocessor.Bundle.html) | currentDefinitions |     |
| [MyDefinitionPostprocessor.Bundle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDefinitionPostprocessor.Bundle.html) | overrideBySet |     |