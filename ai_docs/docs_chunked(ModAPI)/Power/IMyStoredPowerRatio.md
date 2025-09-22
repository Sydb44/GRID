---
title: "Interface IMyStoredPowerRatio"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyStoredPowerRatio.html"
category: "Power"
namespace: "Sandbox.ModAPI"
class: "IMyStoredPowerRatio"
---

# Interface IMyStoredPowerRatio | Space Engineers ModAPI

Describes stored power ration interface for block, which are storing power

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyStoredPowerRatio
```

### Properties

#### StoredPowerRatio

Gets stored power ration (current / max)

##### Declaration

```
float StoredPowerRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Events

#### StoredPowerRatioChanged

Event when stored power ratio is changed (block, old value, new value)

##### Declaration

```
event Action<IMyStoredPowerRatio, float, float> StoredPowerRatioChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyStoredPowerRatio](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyStoredPowerRatio.html), System.Single, System.Single\> |     |