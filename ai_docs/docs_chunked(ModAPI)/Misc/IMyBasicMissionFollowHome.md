---
title: "Interface IMyBasicMissionFollowHome"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyBasicMissionFollowHome.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyBasicMissionFollowHome"
---

# Interface IMyBasicMissionFollowHome | Space Engineers ModAPI

Describes follow home mission for Basic AI block

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyBasicMissionFollowHome
```

### Properties

#### MaxRange

Gets or sets max range from home. Controlled grid will stay between min and max range.

##### Declaration

```
float MaxRange { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinRange

Gets or sets min range from home. Controlled grid will stay between min and max range.

##### Declaration

```
float MinRange { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Wander

Gets or sets wander behavior of the controlled grid

##### Declaration

```
bool Wander { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |