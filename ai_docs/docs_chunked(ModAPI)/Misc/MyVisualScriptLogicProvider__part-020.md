##### Declaration

```
public static SerializableDictionary<string, (int, bool)> GetTimers()
```

##### Returns

Type

Description

VRage.Serialization.SerializableDictionary<System.String, System.ValueTuple<System.Int32, System.Boolean\>>

#### GetToolbarConfigGridItemIndexAndControl(MyDefinitionId, out MyGuiControlBase, out Int32)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Gets whole item grid and find index of specific item in it. If no item was found, method will still return the item grid and index will be set to last index in it (GetItemsCount() - 1). Works only when ToolbarConfig screen is opened and focused.", -10510688)]
[VisualScriptingMember(false, false)]
public static void GetToolbarConfigGridItemIndexAndControl(MyDefinitionId itemDefinition, out MyGuiControlBase control, out int index)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemDefinition

Sandbox.Graphics.GUI.MyGuiControlBase

control

System.Int32

index

#### GetUserControlKey(String)

##### Declaration

```
[VisualScriptingMiscData("Misc", "Gets name of the control element (keyboard, mouse, gamepad buttons) that is binded to the specific action called 'keyName'. Names are defined in class MyControlsSpace, such as 'STRAFE_LEFT' or 'CUBE_ROTATE_ROLL_POSITIVE'.", -10510688)]
[VisualScriptingMember(false, false)]
public static string GetUserControlKey(string keyName)
```

##### Parameters

Type

Name

Description

System.String

keyName

##### Returns

Type

Description

System.String

#### GetVoiceChatVolume()

##### Declaration

```
[VisualScriptingMiscData("Audio", "Get voice chat volume.", -10510688)]
[VisualScriptingMember(false, false)]
public static float GetVoiceChatVolume()
```

##### Returns

Type

Description

System.Single

#### GetWeather(Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Get weather based on position", -10510688)]
[VisualScriptingMember(true, false)]
public static string GetWeather(Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

##### Returns

Type

Description

System.String

#### GetWeatherIntensity(Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Get weather intensity based on position", -10510688)]
[VisualScriptingMember(true, false)]
public static float GetWeatherIntensity(Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

##### Returns

Type

Description

System.Single

#### GoToPostMatchState()

##### Declaration

```
[VisualScriptingMiscData("Other", "Go to post-match state", -10510688)]
[VisualScriptingMember(true, false)]
public static void GoToPostMatchState()
```

#### HasOperationalCockpit(String)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns true if the specific grid has at least one cockpit that enables ship control.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool HasOperationalCockpit(string gridName)
```

##### Parameters

Type

Name

Description

System.String

gridName

##### Returns

Type

Description

System.Boolean

#### HasOperationalGyro(String)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns true if the specific grid has at least one gyro that is enabled, powered and not-overridden.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool HasOperationalGyro(string gridName)
```

##### Parameters

Type

Name

Description

System.String

gridName

##### Returns

Type

Description

System.Boolean

#### HasPower(String)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns true if grid has enough power or is in 'adaptable-overload'. (grid is overloaded by adaptable block, that won't cause blackout, such as thrusters or batteries)", -10510688)]
[VisualScriptingMember(false, false)]
public static bool HasPower(string gridName)
```

##### Parameters

Type

Name

Description

System.String

gridName

##### Returns

Type

Description

System.Boolean

#### HasThrusterInAllDirections(String)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns true if entity has thrusters in all directions.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool HasThrusterInAllDirections(string entityName)
```

##### Parameters

Type

Name

Description

System.String

entityName

##### Returns

Type

Description

System.Boolean

#### HasWorkingRemote(String)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns true if the specified grid has at least one Remote in functional state.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool HasWorkingRemote(string gridName)
```

##### Parameters

Type

Name

Description

System.String

gridName

##### Returns

Type

Description

System.Boolean

#### HighlightGuiControl(MyGuiControlBase, List<Int32>, String)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Highlights specific GUI element. If the element is of type MyGuiControlGrid, 'indicies' may be used to select which items should be highlighted. 'customToolTipMessage' can be used for custom tooltip of highlighted element.", -10510688)]
[VisualScriptingMember(true, false)]
public static void HighlightGuiControl(MyGuiControlBase control, List<int> indicies = null, string customToolTipMessage = null)
```

##### Parameters

Type

Name

Description

Sandbox.Graphics.GUI.MyGuiControlBase

control

System.Collections.Generic.List<System.Int32\>

indicies

System.String

customToolTipMessage

#### HighlightGuiControl(String, String)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Highlights specific GUI element in specific screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void HighlightGuiControl(string controlName, string activeScreenName)
```
