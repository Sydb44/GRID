---
title: "Interface IMySpaceBall"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMySpaceBall.html"
category: "Misc"
namespace: "SpaceEngineers.Game.ModAPI.Ingame"
class: "IMySpaceBall"
---

# Interface IMySpaceBall | Space Engineers ModAPI

Spaceball interface

##### Inherited Members

###### **Namespace**: [SpaceEngineers.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.html)

###### **Assembly**: SpaceEngineers.Game.dll

##### Syntax

```
public interface IMySpaceBall : IMyVirtualMass, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### Broadcasting

Gets or sets broadcasting

##### Declaration

```
bool Broadcasting { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Friction

Ball friction

##### Declaration

```
float Friction { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsBroadcasting

Is broadcasting

##### Declaration

```
bool IsBroadcasting { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Restitution

Ball restitution

##### Declaration

```
float Restitution { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### VirtualMass

Virtual mass of ball, in kg

##### Declaration

```
float VirtualMass { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Extension Methods