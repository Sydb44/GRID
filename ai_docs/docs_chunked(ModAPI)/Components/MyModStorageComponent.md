---
title: "Class MyModStorageComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyModStorageComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyModStorageComponent"
---

# Class MyModStorageComponent | Space Engineers ModAPI

Component that stores custom mod data for an entity. Shared by all mods. NOTE: Create an EntityComponents.sbc with your mod's GUIDs to make sure data is saved. This allows data to remain in the world file until the user removes the mod.

##### Inheritance

System.Object

MyModStorageComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyModStorageComponent : MyModStorageComponentBase, IMyEntityComponentBase, IMyComponentBase, IDictionary<Guid, string>, ICollection<KeyValuePair<Guid, string>>, IEnumerable<KeyValuePair<Guid, string>>, IEnumerable
```

### Constructors

#### MyModStorageComponent()

##### Declaration

```
public MyModStorageComponent()
```

### Properties

#### Storage

Store custom mod data here. Use a GUID unique to your mod. Use only system types, not custom types in mod script or game.

##### Declaration

```
public IReadOnlyDictionary<Guid, string> Storage { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IReadOnlyDictionary<System.Guid, System.String\> |     |

##### Remarks

### Methods

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

#### GetValue(Guid)

##### Declaration

```
public override string GetValue(Guid guid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | guid |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

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

#### RemoveValue(Guid)

##### Declaration

```
public override bool RemoveValue(Guid guid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | guid |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### SetValue(Guid, String)

##### Declaration

```
public override void SetValue(Guid guid, string value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | guid |     |
| System.String | value |     |

##### Overrides

#### TryGetValue(Guid, out String)

##### Declaration

```
public override bool TryGetValue(Guid guid, out string value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | guid |     |
| System.String | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

### Extension Methods