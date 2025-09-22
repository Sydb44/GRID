---
title: "Interface IMyEntityCapacitorComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyEntityCapacitorComponent.html"
category: "Components"
namespace: "VRage.Game.ModAPI.Interfaces"
class: "IMyEntityCapacitorComponent"
---

# Interface IMyEntityCapacitorComponent | Space Engineers ModAPI

Describes a component that can charge like a battery and has the ability to lose stored power.

###### **Namespace**: [VRage.Game.ModAPI.Interfaces](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyEntityCapacitorComponent
```

### Properties

#### Capacity

Gets or sets maximum capacity in MWh.

##### Declaration

```
float Capacity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsCharged

Gets whether the capacitor is fully charged.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RechargeDraw

Gets or sets maximum recharge rate in megawatts. When it is fully charged, it starts using entity default consumption.

##### Declaration

```
float RechargeDraw { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### StoredPower

Gets or sets the currently stored amount of energy. Setter should be called on server.

##### Declaration

```
float StoredPower { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### TimeRemaining

Gets or sets time in seconds until the block is fully charged. Updated every 100 frames.

##### Declaration

```
float TimeRemaining { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Events

#### OnCharged

Called on server and client when capacitor is fully charged.

##### Declaration

```
event Action<IMyEntityCapacitorComponent> OnCharged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyEntityCapacitorComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyEntityCapacitorComponent.html)\> |     |