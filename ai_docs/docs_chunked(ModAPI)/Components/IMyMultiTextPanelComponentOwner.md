---
title: "Interface IMyMultiTextPanelComponentOwner"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.IMyMultiTextPanelComponentOwner.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "IMyMultiTextPanelComponentOwner"
---

# Interface IMyMultiTextPanelComponentOwner | Space Engineers ModAPI

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyMultiTextPanelComponentOwner : IMyTextPanelComponentOwner
```

### Properties

#### MultiTextPanel

##### Declaration

```
MyMultiTextPanelComponent MultiTextPanel { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyMultiTextPanelComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyMultiTextPanelComponent.html) |     |

### Methods

#### SelectPanel(List<MyGuiControlListbox.Item>)

##### Declaration

```
void SelectPanel(List<MyGuiControlListbox.Item> selectedItems)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<Sandbox.Graphics.GUI.MyGuiControlListbox.Item\> | selectedItems |     |