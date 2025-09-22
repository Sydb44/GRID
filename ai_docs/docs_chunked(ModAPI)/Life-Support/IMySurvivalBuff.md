---
title: "Interface IMySurvivalBuff"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMySurvivalBuff.html"
category: "Life-Support"
namespace: "Sandbox.ModAPI"
class: "IMySurvivalBuff"
---

# Interface IMySurvivalBuff | Space Engineers ModAPI

Describes single survival buff

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMySurvivalBuff
```

### Properties

#### Level

Curent buff level

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### NameId

Buff name id

##### Declaration

```
MyStringId NameId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### NotificationText

Buff progress notification text id

##### Declaration

```
MyStringId NotificationText { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### NotificationTitle

Buff progress notification title id

##### Declaration

```
MyStringId NotificationTitle { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### ProgressionTime

Time to progress to next buff level in seconds

##### Declaration

```
int ProgressionTime { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### DoProgressStep()

Checks whether the buff should progress to next level

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true when buff progressed to next level |

#### GetCurrentBuffValue()

Gets current value of buff

##### Declaration

```
float GetCurrentBuffValue()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetCurrentBuffValueString()

Gets current value of buff in a readable form with unit representation. Example: 120%

##### Declaration

```
string GetCurrentBuffValueString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Reset()

Resets buff progress

##### Declaration