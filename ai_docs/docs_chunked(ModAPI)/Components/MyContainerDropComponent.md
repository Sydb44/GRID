---
title: "Class MyContainerDropComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyContainerDropComponent.html"
category: "Components"
namespace: "Sandbox.Game.Components"
class: "MyContainerDropComponent"
---

# Class MyContainerDropComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyContainerDropComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentBuilder]
public class MyContainerDropComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyContainerDropComponent()

##### Declaration

```
public MyContainerDropComponent()
```

#### MyContainerDropComponent(Boolean, String, Int64, String)

##### Declaration

```
public MyContainerDropComponent(bool competetive, string gpsName, long owner, string sound)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | competetive |     |
| System.String | gpsName |     |
| System.Int64 | owner |     |
| System.String | sound |     |

### Properties

#### Competetive

##### Declaration

```
public bool Competetive { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### GPSName

##### Declaration

```
public string GPSName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### GridEntityId

##### Declaration

```
public long GridEntityId { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### Owner

##### Declaration

```
public long Owner { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Methods

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase baseBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | baseBuilder |     |

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

#### OnAddedToScene()

##### Declaration

```
public override void OnAddedToScene()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### OnRemovedFromScene()

##### Declaration

```
public override void OnRemovedFromScene()
```

##### Overrides

#### PlaySound(String)

##### Declaration

```
public bool PlaySound(string soundName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | soundName |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### StopSound()

##### Declaration

#### UpdateSound()

##### Declaration

```
public void UpdateSound()
```

### Extension Methods