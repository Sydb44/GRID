---
title: "Interface IMyGridProgramRuntimeInfo"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyGridProgramRuntimeInfo.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyGridProgramRuntimeInfo"
---

# Interface IMyGridProgramRuntimeInfo | Space Engineers ModAPI

Provides runtime info for a running grid program.

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyGridProgramRuntimeInfo
```

### Properties

#### CurrentCallChainDepth

Gets the current number of nested method calls.

##### Declaration

```
int CurrentCallChainDepth { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### CurrentInstructionCount

Gets the current number of significant instructions executed.

##### Declaration

```
int CurrentInstructionCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### LastRunTimeMs

Gets the number of milliseconds it took to execute the Main method the last time it was run. This property returns no valid data neither in the constructor nor the Save method.

##### Declaration

```
double LastRunTimeMs { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### LifetimeTicks

The number of ticks this program has been running for.

##### Declaration

```
long LifetimeTicks { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

##### Remarks

#### MaxCallChainDepth

Gets the maximum number of method calls that can be nested into each other.

##### Declaration

```
int MaxCallChainDepth { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MaxInstructionCount

Gets the maximum number of significant instructions that can be executing during a single run, including any other programmable blocks invoked immediately.

##### Declaration

```
int MaxInstructionCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### TimeSinceLastRun

Gets the time elapsed since the last time the Main method of this program was run. This property returns no valid data neither in the constructor nor the Save method.

##### Declaration

```
TimeSpan TimeSinceLastRun { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.TimeSpan |     |

#### UpdateFrequency

Gets or sets how frequently this script will run itself

##### Declaration

```
UpdateFrequency UpdateFrequency { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [UpdateFrequency](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateFrequency.html) |     |