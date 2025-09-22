---
title: "Class MyGuiScreenProgress"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyGuiScreenProgress.html"
category: "Misc"
namespace: "Sandbox.Game"
class: "MyGuiScreenProgress"
---

# Class MyGuiScreenProgress | Space Engineers ModAPI

##### Inheritance

System.Object

MyGuiScreenProgress

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyGuiScreenProgress : MyGuiScreenProgressBase
```

### Constructors

#### MyGuiScreenProgress(StringBuilder, Nullable<MyStringId>, Boolean, Boolean)

##### Declaration

```
public MyGuiScreenProgress(StringBuilder text, Nullable<MyStringId> cancelText = null, bool isTopMostScreen = true, bool enableBackgroundFade = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | text |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | cancelText |     |
| System.Boolean | isTopMostScreen |     |
| System.Boolean | enableBackgroundFade |     |

### Properties

#### Text

##### Declaration

```
public StringBuilder Text { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Text.StringBuilder |     |

### Methods

#### Draw()

##### Declaration

```
public override bool Draw()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DrawPaused()

##### Declaration

#### GetFriendlyName()

##### Declaration

```
public override string GetFriendlyName()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### ProgressStart()

##### Declaration

```
protected override void ProgressStart()
```

#### RecreateControls(Boolean)

##### Declaration

```
public override void RecreateControls(bool constructor)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | constructor |     |

#### Update(Boolean)

##### Declaration

```
public override bool Update(bool hasFocus)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | hasFocus |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Events

#### Tick

##### Declaration

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |