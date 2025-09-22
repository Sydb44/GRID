---
title: "Class MyAtmosphereDetectorComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyAtmosphereDetectorComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyAtmosphereDetectorComponent"
---

# Class MyAtmosphereDetectorComponent | Space Engineers ModAPI

Class used for detection of environment with air - important for realistic sounds

##### Inheritance

System.Object

MyAtmosphereDetectorComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyAtmosphereDetectorComponent : MyUpdatingEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent
```

### Constructors

#### MyAtmosphereDetectorComponent()

##### Declaration

```
public MyAtmosphereDetectorComponent()
```

### Properties

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

#### InAtmosphere

##### Declaration

```
public bool InAtmosphere { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### InShipOrStation

##### Declaration

```
public bool InShipOrStation { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### InVoid

##### Declaration

```
public bool InVoid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### InitComponent(Boolean, MyCharacter)

##### Declaration

```
public void InitComponent(bool onlyLocalPlayer, MyCharacter character)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | onlyLocalPlayer |     |
| Sandbox.Game.Entities.Character.MyCharacter | character |     |

#### UpdateBeforeSimulation100()

##### Declaration

```
public override void UpdateBeforeSimulation100()
```

##### Overrides

### Extension Methods