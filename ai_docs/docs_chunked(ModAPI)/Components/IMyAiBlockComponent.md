---
title: "Interface IMyAiBlockComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyAiBlockComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI"
class: "IMyAiBlockComponent"
---

# Interface IMyAiBlockComponent | Space Engineers ModAPI

Describes AI block activator entity component. This entity component turns on/off AI Behavior.

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyAiBlockComponent
```

### Properties

#### AiBlockType

Gets or sets the AI Block Type

##### Declaration

```
MyAiBlockType AiBlockType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyAiBlockType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyAiBlockType.html) |     |

#### Entity

Gets the entity of this entity component

##### Declaration

```
IMyEntity Entity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### HudErrorStringGetter

Getter for errors on AI block. Used in detailed info.

##### Declaration

```
Func<string> HudErrorStringGetter { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Func<System.String\> |     |

#### IsActivated

Gets or sets if the component is activated. This activation turns on/off AI Behavior of the AI blocks.

##### Declaration

```
bool IsActivated { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Deactivate()

Deactivates the component

##### Declaration

### Events

#### OnActivatedChanged

Triggers when Is Activated is changed

##### Declaration

```
event Action OnActivatedChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |