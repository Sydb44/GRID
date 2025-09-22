---
title: "Interface IMyHudNotification"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyHudNotification.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyHudNotification"
---

# Interface IMyHudNotification | Space Engineers ModAPI

Describes interface of notification (mods interface)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyHudNotification
```

### Properties

#### AliveTime

Get or set the time for the notification to be shown, in milliseconds.

##### Declaration

```
int AliveTime { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Font

Get or set the font for this notification. Setting it will immediately update it if the notification is shown.

##### Declaration

```
string Font { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Text

Get or set the notification text. Setting the text will immediately update it if the notification is shown.

##### Declaration

```
string Text { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### Hide()

Hides the notification on the HUD even if it was supposed to show for longer.

##### Declaration

#### ResetAliveTime()

Reset the alive time for the text. This is called when setting AliveTime as well.

##### Declaration

#### Show()

Shows the notification on the HUD.

##### Declaration