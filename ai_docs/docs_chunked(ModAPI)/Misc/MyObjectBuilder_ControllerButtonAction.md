---
title: "Class MyObjectBuilder\\_ControllerButtonAction"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_ControllerButtonAction.html"
category: "Misc"
namespace: "VRage.Game.ObjectBuilders.Definitions"
class: "MyObjectBuilder_ControllerButtonAction"
---

# Class MyObjectBuilder\_ControllerButtonAction | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_ControllerButtonAction

##### Inherited Members

###### **Namespace**: [VRage.Game.ObjectBuilders.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyObjectBuilder_ControllerButtonAction : MyObjectBuilder_Action
```

### Constructors

#### MyObjectBuilder\_ControllerButtonAction()

##### Declaration

```
public MyObjectBuilder_ControllerButtonAction()
```

#### MyObjectBuilder\_ControllerButtonAction(MyJoystickButtonsEnum, ButtonAction)

##### Declaration

```
public MyObjectBuilder_ControllerButtonAction(MyJoystickButtonsEnum joystickButtonTranslated, ButtonAction action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Input.MyJoystickButtonsEnum | joystickButtonTranslated |     |
| [ButtonAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.ButtonAction.html) | action |     |

### Fields

#### GamepadButton

##### Declaration

```
public MyGamepadButtons GamepadButton
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Input.MyGamepadButtons |     |

### Properties

#### JoystickButton

##### Declaration

```
[NoSerialize]
public MyJoystickButtonsEnum JoystickButton { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Input.MyJoystickButtonsEnum |     |