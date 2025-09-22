---
title: "Class MyShipSoundComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyShipSoundComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyShipSoundComponent"
---

# Class MyShipSoundComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyShipSoundComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentBuilder]
public class MyShipSoundComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyShipSoundComponent()

##### Declaration

```
public MyShipSoundComponent()
```

### Fields

#### ShipHasChanged

##### Declaration

```
public bool ShipHasChanged
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

### Methods

#### ActualizeGroups()

##### Declaration

```
public static void ActualizeGroups()
```

#### AddShipSounds(MyShipSoundsDefinition)

##### Declaration

```
public static void AddShipSounds(MyShipSoundsDefinition shipSoundGroup)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShipSoundsDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyShipSoundsDefinition.html) | shipSoundGroup |     |

#### ClearShipSounds()

##### Declaration

```
public static void ClearShipSounds()
```

#### DeSchedule()

##### Declaration

```
protected void DeSchedule()
```

#### DestroyComponent()

##### Declaration

```
public void DestroyComponent()
```

#### InitComponent(MyCubeGrid)

##### Declaration

```
public bool InitComponent(MyCubeGrid shipGrid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | shipGrid |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Schedule()

##### Declaration

```
protected void Schedule()
```

#### SetDefinition(MyShipSoundSystemDefinition)

##### Declaration

```
public static void SetDefinition(MyShipSoundSystemDefinition def)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShipSoundSystemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyShipSoundSystemDefinition.html) | def |     |

#### Update()

##### Declaration

#### Update100()

##### Declaration

### Extension Methods