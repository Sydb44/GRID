---
title: "Class MySessionComponentBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MySessionComponentBase.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MySessionComponentBase"
---

  Class MySessionComponentBase | Space Engineers ModAPI         

[Show / Hide Table of Contents](#sidetoggle)

# Class MySessionComponentBase

##### Inheritance

System.Object

MySessionComponentBase

[MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase.html)

[MyFloatingObjects](Sandbox.Game.Entities.MyFloatingObjects.html)

[MyGamePruningStructure](Sandbox.Game.Entities.MyGamePruningStructure.html)

[MyMeteorShower](Sandbox.Game.Entities.MyMeteorShower.html)

[MySessionComponentSafeZones](Sandbox.Game.Entities.MySessionComponentSafeZones.html)

[MyLights](Sandbox.Game.Lights.MyLights.html)

[MyExplosions](Sandbox.Game.MyExplosions.html)

[MyParticlesManager](VRage.Game.MyParticlesManager.html)

[MyPrecalcComponent](VRage.Voxels.MyPrecalcComponent.html)

###### **Namespace**: [VRage.Game.Components](VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MySessionComponentBase : Object, IMyUserInputComponent
```

### Constructors

#### MySessionComponentBase()

##### Declaration

```
public MySessionComponentBase()
```

### Fields

#### ComponentType

##### Declaration

```
public readonly Type ComponentType
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Type |     |

#### DebugName

##### Declaration

```
public readonly string DebugName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Priority

##### Declaration

```
public readonly int Priority
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### Definition

##### Declaration

```
public Nullable<MyDefinitionId> Definition { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[MyDefinitionId](VRage.Game.MyDefinitionId.html)\> |     |

#### Dependencies

##### Declaration

```
public virtual Type[] Dependencies { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Type\[\] |     |

#### Initialized

##### Declaration

```
public bool Initialized { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsRequiredByGame

Indicates whether a session component should be used in current configuration. Example: MyDestructionData component returns true only when game uses Havok Destruction

##### Declaration

```
public virtual bool IsRequiredByGame { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsServerOnly

Is server only is used for client request of the world. if the component is server only, it's not sent to the client on world request.

##### Declaration

```
public bool IsServerOnly { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Loaded

##### Declaration

```
public bool Loaded { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ModContext

##### Declaration

```
public IMyModContext ModContext { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyModContext](VRage.Game.ModAPI.IMyModContext.html) |     |

#### ObjectBuilderType

##### Declaration

```
public MyObjectBuilderType ObjectBuilderType { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilderType](VRage.ObjectBuilders.MyObjectBuilderType.html) |     |

#### Session

##### Declaration

```
public IMySession Session { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMySession](VRage.Game.ModAPI.IMySession.html) |     |

#### UpdateOnPause

##### Declaration

```
public bool UpdateOnPause { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UpdateOrder

##### Declaration

```
public MyUpdateOrder UpdateOrder { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyUpdateOrder](VRage.Game.Components.MyUpdateOrder.html) |     |

### Methods

#### AfterLoadData()

##### Declaration

```
public void AfterLoadData()
```

#### BeforeStart()

##### Declaration

```
public virtual void BeforeStart()
```

#### Draw()

##### Declaration

```
public virtual void Draw()
```

#### GetObjectBuilder()

##### Declaration

```
public virtual MyObjectBuilder_SessionComponent GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_SessionComponent](VRage.Game.MyObjectBuilder_SessionComponent.html) |     |

#### HandleInput()

##### Declaration

```
public virtual void HandleInput()
```

#### Init(MyObjectBuilder\_SessionComponent)

##### Declaration

```
public virtual void Init(MyObjectBuilder_SessionComponent sessionComponent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_SessionComponent](VRage.Game.MyObjectBuilder_SessionComponent.html) | sessionComponent |     |

#### InitFromDefinition(MySessionComponentDefinition)

##### Declaration

```
public virtual void InitFromDefinition(MySessionComponentDefinition definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.Components.Session.MySessionComponentDefinition | definition |     |

#### LoadData()

##### Declaration

```
public virtual void LoadData()
```

#### SaveData()

##### Declaration

```
public virtual void SaveData()
```

#### SetUpdateOrder(MyUpdateOrder)

##### Declaration

```
public void SetUpdateOrder(MyUpdateOrder order)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyUpdateOrder](VRage.Game.Components.MyUpdateOrder.html) | order |     |

#### Simulate()

##### Declaration

```
public virtual void Simulate()
```
