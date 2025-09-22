Type

Name

Description

System.Int32

page

System.Int64

playerId

#### SetToolbarSlotToItem(Int32, MyDefinitionId, Int64)

##### Declaration

```
[VisualScriptingMiscData("Toolbar", "Sets item to the specified slot for the player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetToolbarSlotToItem(int slot, MyDefinitionId itemId, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

slot

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

System.Int64

playerId

#### SetToolbarSlotToItemLocal(Int32, SerializableDefinitionId, Int64)

##### Declaration

```
public static void SetToolbarSlotToItemLocal(int slot, SerializableDefinitionId itemId, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

slot

[SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html)

itemId

System.Int64

playerId

#### SetToolbarSlotToItemSync(Int32, SerializableDefinitionId, Int64)

##### Declaration

```
[Event(null, 7851)]
[Reliable]
[ServerInvoked]
[Broadcast]
public static void SetToolbarSlotToItemSync(int slot, SerializableDefinitionId itemId, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

slot

[SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html)

itemId

System.Int64

playerId

#### SetTooltip(MyGuiControlBase, String)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Sets tooltip of specific GUI element.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetTooltip(this MyGuiControlBase control, string text)
```

##### Parameters

Type

Name

Description

Sandbox.Graphics.GUI.MyGuiControlBase

control

System.String

text

#### SetVolume(Single, Single, Single)

##### Declaration

```
[VisualScriptingMiscData("Audio", "Set volume for game audio. Use -1 for no change. 0 min, 1 max.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetVolume(float gameVolume = -1F, float musicVolume = -1F, float voiceChatVolume = -1F)
```

##### Parameters

Type

Name

Description

System.Single

gameVolume

System.Single

musicVolume

System.Single

voiceChatVolume

#### SetVolumeLocal(Single, Single, Single)

##### Declaration

```
public static void SetVolumeLocal(float gameVolume = -1F, float musicVolume = -1F, float voiceChatVolume = -1F)
```

##### Parameters

Type

Name

Description

System.Single

gameVolume

System.Single

musicVolume

System.Single

voiceChatVolume

#### SetWeatherC(String, String, Single)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Set weather based on character position", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetWeatherC(string weatherCommand, string weatherEffect, float radius)
```

##### Parameters

Type

Name

Description

System.String

weatherCommand

System.String

weatherEffect

System.Single

radius

#### SetWeatherP(String, String, Single, Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Set weather based on exact position", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetWeatherP(string weatherCommand, string weatherEffect, float radius, Vector3D position)
```

##### Parameters

Type

Name

Description

System.String

weatherCommand

System.String

weatherEffect

System.Single

radius

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### ShowHud(Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Effects", "False to force minimize HUD, true to disable force minimization. (Force minimization overrides HUD state without actually changing it so you can revert back safely.)", -10510688)]
[VisualScriptingMember(true, false)]
public static void ShowHud(bool flag = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Boolean

flag

System.Int64

playerId

#### ShowNotification(String, Int32, String, Int64)

##### Declaration

```
[VisualScriptingMiscData("Notifications", "Shows a notification with specific message and font for the specific player for a defined time. If playerId is equal to 0, notification will be show to local player, otherwise it will be shown to specific player. If playerId is -1, notification is shown to all players.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ShowNotification(string message, int disappearTimeMs, string font = "White", long playerId = 0L)
```

##### Parameters

Type

Name

Description

System.String

message

System.Int32

disappearTimeMs

System.String

font

System.Int64

playerId

#### ShowNotificationLocal(String, Int32, String)

##### Declaration

```
public static void ShowNotificationLocal(string message, int disappearTimeMs, string font = "White")
```

##### Parameters

Type

Name

Description

System.String

message

System.Int32

disappearTimeMs

System.String

font

#### ShowNotificationToAll(String, Int32, String)

##### Declaration

```
[VisualScriptingMiscData("Notifications", "Shows a notification with specific message and font to all players for a defined time.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ShowNotificationToAll(string message, int disappearTimeMs, string font = "White")
```

##### Parameters

Type

Name

Description

System.String

message

System.Int32

disappearTimeMs

System.String

font

#### ShowOrderInColumn(String, String, Int64)

##### Declaration

```
[VisualScriptingMiscData("Board screen", "Set row ranking used for sorting.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ShowOrderInColumn(string boardId, string columnId, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

boardId

System.String

columnId

System.Int64

playerId
