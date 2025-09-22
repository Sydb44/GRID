---
title: "Class MyContainerTypeDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyContainerTypeDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyContainerTypeDefinition"
---

# Class MyContainerTypeDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyContainerTypeDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyContainerTypeDefinition : MyDefinitionBase
```

### Constructors

#### MyContainerTypeDefinition()

##### Declaration

```
public MyContainerTypeDefinition()
```

### Fields

#### CountMax

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### CountMin

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Items

##### Declaration

```
public MyContainerTypeDefinition.ContainerTypeItem[] Items
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyContainerTypeDefinition.ContainerTypeItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyContainerTypeDefinition.ContainerTypeItem.html)\[\] |     |

#### ItemsCumulativeFrequency

##### Declaration

```
public float ItemsCumulativeFrequency
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Sets

##### Declaration

```
public Dictionary<string, List<MyContainerTypeDefinition.ContainerTypeItem>> Sets
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<[MyContainerTypeDefinition.ContainerTypeItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyContainerTypeDefinition.ContainerTypeItem.html)\>> |     |

### Methods

#### DeselectAll()

##### Declaration

```
public void DeselectAll()
```

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

#### SelectNextRandomItem()

##### Declaration

```
public MyContainerTypeDefinition.ContainerTypeItem SelectNextRandomItem()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyContainerTypeDefinition.ContainerTypeItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyContainerTypeDefinition.ContainerTypeItem.html) |     |