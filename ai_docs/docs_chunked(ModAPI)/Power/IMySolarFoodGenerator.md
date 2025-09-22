---
title: "Interface IMySolarFoodGenerator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMySolarFoodGenerator.html"
category: "Power"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMySolarFoodGenerator"
---

# Interface IMySolarFoodGenerator | Space Engineers ModAPI

Describes an entity that generates food items from solar energy (PB scripting interface).

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMySolarFoodGenerator
```

### Properties

#### ItemsPerMinute

The current output of items per minute.

##### Declaration

```
float ItemsPerMinute { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### TimeRemainingUntilNextBatch

The remaining time in seconds until the next batch of items is ready.

##### Declaration

```
float TimeRemainingUntilNextBatch { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |