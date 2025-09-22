---
title: "Class MyDefinitionManagerSimple"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionManagerSimple.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyDefinitionManagerSimple"
---

# Class MyDefinitionManagerSimple | Space Engineers ModAPI

Simple definition manager class that allows loading of definitions from files and support type overrides (e.g. for loading subset of EnvironmentDefinition)

##### Inheritance

System.Object

MyDefinitionManagerSimple

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyDefinitionManagerSimple : MyDefinitionManagerBase
```

### Constructors

#### MyDefinitionManagerSimple()

##### Declaration

```
public MyDefinitionManagerSimple()
```

### Methods

#### AddDefinitionOverride(Type, String)

##### Declaration

```
public void AddDefinitionOverride(Type overridingType, string typeOverride)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | overridingType |     |
| System.String | typeOverride | The xst:type attribute overridden |

#### GetLoadingSet()

##### Declaration

```
public override MyDefinitionSet GetLoadingSet()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyDefinitionSet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionSet.html) |     |

##### Overrides

#### LoadDefinitions(String)

##### Declaration

```
public void LoadDefinitions(string path)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path |     |

#### TryGetComponentDefinition(MyObjectBuilderType, MyStringHash, out MyComponentDefinitionBase)

##### Declaration

```
public override bool TryGetComponentDefinition(MyObjectBuilderType type, MyStringHash subtypeName, out MyComponentDefinitionBase componentDefinition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeName |     |
| [MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html) | componentDefinition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### TryGetContainerDefinition(MyObjectBuilderType, MyStringHash, out MyContainerDefinition)

##### Declaration

```
public override bool TryGetContainerDefinition(MyObjectBuilderType type, MyStringHash subtypeName, out MyContainerDefinition definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeName |     |
| [MyContainerDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyContainerDefinition.html) | definition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides