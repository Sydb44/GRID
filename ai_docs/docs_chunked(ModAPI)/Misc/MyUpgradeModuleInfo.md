---
title: "Class MyUpgradeModuleInfo"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyUpgradeModuleInfo.html"
category: "Misc"
namespace: "VRage.Game.ObjectBuilders.Definitions"
class: "MyUpgradeModuleInfo"
---

# Class MyUpgradeModuleInfo | Space Engineers ModAPI

Module upgrade information

##### Inheritance

System.Object

MyUpgradeModuleInfo

###### **Namespace**: [VRage.Game.ObjectBuilders.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyUpgradeModuleInfo : ValueType
```

### Properties

#### Modifier

Modifier for upgrade (as decimal - 1 = 100%)

##### Declaration

```
public float Modifier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ModifierType

##### Declaration

```
public MyUpgradeModifierType ModifierType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyUpgradeModifierType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyUpgradeModifierType.html) |     |

#### UpgradeType

Name of upgrade

##### Declaration

```
public string UpgradeType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |