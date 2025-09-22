---
title: "Interface IMyUpgradeModule"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyUpgradeModule.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyUpgradeModule"
---

# Interface IMyUpgradeModule | Space Engineers ModAPI

Describes upgrade module block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyUpgradeModule : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### Connections

Gets number of blocks this block is connected to

##### Declaration

```
uint Connections { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### UpgradeCount

Gets number of upgrade effects this block has

##### Declaration

```
uint UpgradeCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

### Methods

#### FillUpgradeList(List<MyUpgradeModuleInfo>)

##### Declaration

```
void FillUpgradeList(List<MyUpgradeModuleInfo> upgrades)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyUpgradeModuleInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyUpgradeModuleInfo.html)\> | upgrades | List of upgrades |

#### GetUpgradeList(out List<MyUpgradeModuleInfo>)

Obsolete

##### Declaration

```
void GetUpgradeList(out List<MyUpgradeModuleInfo> upgrades)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyUpgradeModuleInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyUpgradeModuleInfo.html)\> | upgrades |     |

### Extension Methods