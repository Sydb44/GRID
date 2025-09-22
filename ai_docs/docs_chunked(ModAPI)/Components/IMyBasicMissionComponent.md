---
title: "Interface IMyBasicMissionComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyBasicMissionComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyBasicMissionComponent"
---

# Interface IMyBasicMissionComponent | Space Engineers ModAPI

Describes entity component interface for basic mission (Basic AI block)

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyBasicMissionComponent
```

### [](#properties)Properties

#### [](#Sandbox_ModAPI_Ingame_IMyBasicMissionComponent_DetailedInfo)DetailedInfo

Contains detailed info with current status/error messages

##### Declaration

```
StringBuilder DetailedInfo { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Text.StringBuilder |     |

#### [](#Sandbox_ModAPI_Ingame_IMyBasicMissionComponent_IsSelected)IsSelected

Gets or sets whether the mission is selected

##### Declaration

```
bool IsSelected { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_ModAPI_Ingame_IMyBasicMissionComponent_MissionName)MissionName

Gets mission name

##### Declaration

```
MyStringId MissionName { get; }
```

##### Property Value

#### [](#Sandbox_ModAPI_Ingame_IMyBasicMissionComponent_UniqueSelectionId)UniqueSelectionId

Gets unique selection id for the mission. You can find id of the mission in the EntityComponents.sbc.

##### Declaration

```
long UniqueSelectionId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |