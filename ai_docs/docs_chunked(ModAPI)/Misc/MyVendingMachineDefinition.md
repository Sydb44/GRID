---
title: "Class MyVendingMachineDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyVendingMachineDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyVendingMachineDefinition"
---

# Class MyVendingMachineDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyVendingMachineDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyVendingMachineDefinition : MyStoreBlockDefinition
```

### Constructors

#### MyVendingMachineDefinition()

##### Declaration

```
public MyVendingMachineDefinition()
```

### Fields

#### AdditionalEmissiveMaterials

##### Declaration

```
public List<string> AdditionalEmissiveMaterials
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### DefaultItems

##### Declaration

```
public List<MyObjectBuilder_StoreItem> DefaultItems
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_StoreItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_StoreItem.html)\> |     |

#### ThrowOutDummy

##### Declaration

```
public string ThrowOutDummy
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ThrowOutItems

##### Declaration

```
public Dictionary<string, float> ThrowOutItems
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Single\> |     |

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