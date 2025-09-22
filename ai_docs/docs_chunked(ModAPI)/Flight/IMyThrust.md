---
title: "Interface IMyThrust"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyThrust.html"
category: "Flight"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyThrust"
---

# Interface IMyThrust | Space Engineers ModAPI

Describes assembler block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyThrust : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### [](#properties)Properties

#### [](#Sandbox_ModAPI_Ingame_IMyThrust_CurrentThrust)CurrentThrust

Gets the current thrust amount, in Newtons (N)

##### Declaration

```
float CurrentThrust { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_Ingame_IMyThrust_CurrentThrustPercentage)CurrentThrustPercentage

Gets the current thrust amount, in %. CurrentThrust of MaxThrust

##### Declaration

```
float CurrentThrustPercentage { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_Ingame_IMyThrust_GridThrustDirection)GridThrustDirection

Gets the direction of thrust, relative to ship controller (cockpit).

##### Declaration

```
Vector3I GridThrustDirection { get; }
```

##### Property Value

##### Remarks

#### [](#Sandbox_ModAPI_Ingame_IMyThrust_MaxEffectiveThrust)MaxEffectiveThrust

Gets the maximum effective thrust amount, in Newtons (N)

##### Declaration

```
float MaxEffectiveThrust { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_Ingame_IMyThrust_MaxThrust)MaxThrust

Gets the maximum thrust amount, in Newtons (N)

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_Ingame_IMyThrust_ThrustOverride)ThrustOverride

Gets or sets the override thrust amount, in Newtons (N)

##### Declaration

```
float ThrustOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_Ingame_IMyThrust_ThrustOverridePercentage)ThrustOverridePercentage

Gets or sets the thrust override as a percentage between 0 and 1

##### Declaration

```
float ThrustOverridePercentage { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### [](#extensionmethods)Extension Methods