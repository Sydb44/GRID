---
title: "Class MyCharacterShapecastDetectorComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.MyCharacterShapecastDetectorComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities.Character.Components"
class: "MyCharacterShapecastDetectorComponent"
---

# Class MyCharacterShapecastDetectorComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyCharacterShapecastDetectorComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities.Character.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyCharacterShapecastDetectorComponent : MyCharacterDetectorComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent, IMyCharacterComponent
```

### Constructors

#### MyCharacterShapecastDetectorComponent()

##### Declaration

```
public MyCharacterShapecastDetectorComponent()
```

### Fields

#### DEFAULT\_SHAPE\_RADIUS

##### Declaration

```
public const float DEFAULT_SHAPE_RADIUS = 0.1F
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

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

#### ShapeRadius

##### Declaration

```
public float ShapeRadius { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### DoDetection(Boolean)

##### Declaration

```
protected override void DoDetection(bool useHead)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | useHead |     |

##### Overrides

#### DoDetectionModel()

##### Declaration

```
public void DoDetectionModel()
```

### Implements

### Extension Methods