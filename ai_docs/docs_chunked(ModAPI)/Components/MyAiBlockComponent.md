---
title: "Class MyAiBlockComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyAiBlockComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyAiBlockComponent"
---

# Class MyAiBlockComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyAiBlockComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyAiBlockComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase, IMyAiBlockComponent, IMyTerminalControlsProviderComponent
```

### Constructors

#### MyAiBlockComponent()

##### Declaration

```
public MyAiBlockComponent()
```

### Properties

#### AiBlockType

##### Declaration

```
public MyAiBlockType AiBlockType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyAiBlockType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyAiBlockType.html) |     |

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### HudErrorStringGetter

##### Declaration

```
public Func<string> HudErrorStringGetter { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Func<System.String\> |     |

#### IsActivated

##### Declaration

```
public bool IsActivated { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TerminalControlCreationPriority

##### Declaration

```
public int TerminalControlCreationPriority { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### CreateTerminalControls<T>()

##### Declaration

```
public void CreateTerminalControls<T>()
    where T : MyTerminalBlock
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### Deactivate()

##### Declaration

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | builder |     |

##### Overrides

#### Init(MyComponentDefinitionBase)

##### Declaration

```
public override void Init(MyComponentDefinitionBase definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html) | definition |     |

##### Overrides

#### IsSerialized()

##### Declaration

```
public override bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### Serialize(Boolean)

##### Declaration

```
public override MyObjectBuilder_ComponentBase Serialize(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

##### Overrides

### Events

#### OnActivatedChanged

##### Declaration

```
public event Action OnActivatedChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

### Implements

### Extension Methods