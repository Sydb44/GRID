---
title: "Class MyCharacterPickupComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.MyCharacterPickupComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities.Character.Components"
class: "MyCharacterPickupComponent"
---

# Class MyCharacterPickupComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyCharacterPickupComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities.Character.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyCharacterPickupComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyCharacterPickupComponent()

##### Declaration

```
public MyCharacterPickupComponent()
```

### Properties

#### Character

##### Declaration

```
public MyCharacter Character { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter |     |

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

### Methods

#### PickUp()

##### Declaration

```
public virtual void PickUp()
```

#### PickUpContinues()

##### Declaration

```
public virtual void PickUpContinues()
```

#### PickUpFinished()

##### Declaration

```
public virtual void PickUpFinished()
```

### Extension Methods