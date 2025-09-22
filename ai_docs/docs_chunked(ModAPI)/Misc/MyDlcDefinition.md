---
title: "Class MyDlcDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDlcDefinition.html"
category: "Misc"
namespace: "VRage.Game.Definitions"
class: "MyDlcDefinition"
---

# Class MyDlcDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyDlcDefinition

##### Implements

##### Inherited Members

###### **Namespace**: [VRage.Game.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyDlcDefinition : MyDefinitionBase, IMyDLC
```

### Constructors

#### MyDlcDefinition()

##### Declaration

### Properties

#### AppId

##### Declaration

```
public uint AppId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### Badge

Badge of the DLC, to be displayed in main menu

##### Declaration

```
public string Badge { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Description

Description of the DLC, preferably a localized string

##### Declaration

```
public MyStringId Description { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### DisplayName

Name of the DLC, preferably a localized string

##### Declaration

```
public MyStringId DisplayName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### Icon

Icon of the DLC, to be displayed in G-screen, blueprints, etc ...

##### Declaration

```
public string Icon { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Name

##### Declaration

```
public string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Ps4ProductIds

##### Declaration

```
public PsProductIds Ps4ProductIds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.GameServices.PsProductIds |     |

#### Ps5ProductIds

##### Declaration

```
public PsProductIds Ps5ProductIds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.GameServices.PsProductIds |     |

#### XboxPackageId

##### Declaration

```
public string XboxPackageId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### XboxStoreId

##### Declaration

```
public string XboxStoreId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

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

### Implements