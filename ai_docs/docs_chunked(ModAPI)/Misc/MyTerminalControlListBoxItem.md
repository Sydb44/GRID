---
title: "Class MyTerminalControlListBoxItem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyTerminalControlListBoxItem.html"
category: "Misc"
namespace: "VRage.ModAPI"
class: "MyTerminalControlListBoxItem"
---

# Class MyTerminalControlListBoxItem | Space Engineers ModAPI

This is a list box item in a list box terminal control

##### Inheritance

System.Object

MyTerminalControlListBoxItem

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyTerminalControlListBoxItem : Object
```

### Constructors

#### MyTerminalControlListBoxItem(MyStringId, MyStringId, Object)

Constructor

##### Declaration

```
public MyTerminalControlListBoxItem(MyStringId text, MyStringId tooltip, object userData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | text | string id of the text |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | tooltip | string id of the tool tip |
| System.Object | userData | user data |

### Properties

#### Text

Gets or Sets the text that appears for the item

##### Declaration

```
public MyStringId Text { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### Tooltip

Gets or Sets t the tool tip that is displayed when the item is hovered over

##### Declaration

```
public MyStringId Tooltip { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### UserData

Gets or Sets the user supplied data for the item

##### Declaration

```
public object UserData { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Object |     |