---
title: "Class MyWeaponBlockDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyWeaponBlockDefinition.html"
category: "Weapons"
namespace: "Sandbox.Definitions"
class: "MyWeaponBlockDefinition"
---

# Class MyWeaponBlockDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyWeaponBlockDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyWeaponBlockDefinition : MyFunctionalBlockDefinition
```

### Constructors

#### MyWeaponBlockDefinition()

##### Declaration

```
public MyWeaponBlockDefinition()
```

### Fields

#### DummyNames

##### Declaration

```
public Dictionary<int, string> DummyNames
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.Int32, System.String\> |     |

#### InventoryFillFactorMin

##### Declaration

```
public float InventoryFillFactorMin
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### InventoryMaxVolume

##### Declaration

```
public float InventoryMaxVolume
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ResourceSinkGroup

##### Declaration

```
public MyStringHash ResourceSinkGroup
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### WeaponDefinitionId

##### Declaration

```
public MyDefinitionId WeaponDefinitionId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

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