---
title: "Interface IMyUpgradableBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyUpgradableBlock.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyUpgradableBlock"
---

# Interface IMyUpgradableBlock | Space Engineers ModAPI

Describes block, which has upgrade effects (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyUpgradableBlock : IMyCubeBlock, IMyEntity
```

### Properties

#### UpgradeCount

Gets number of upgrades applied

##### Declaration

```
uint UpgradeCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

### Methods

#### FillUpgradesDictionary(Dictionary<String, Single>)

Get list of upgrades. Read only.

##### Declaration

```
void FillUpgradesDictionary(Dictionary<string, float> upgrades)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Single\> | upgrades | String - upgrade type, float - effect value as float (1 = 100%) |

#### GetUpgrades(out Dictionary<String, Single>)

Obsolete

##### Declaration

```
void GetUpgrades(out Dictionary<string, float> upgrades)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Single\> | upgrades |     |