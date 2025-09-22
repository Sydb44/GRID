---
title: "Class MyObjectBuilder\\_ConveyorLine"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ConveyorLine.html"
category: "Logistics"
namespace: "VRage.Game"
class: "MyObjectBuilder_ConveyorLine"
---

# Class MyObjectBuilder\_ConveyorLine | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_ConveyorLine

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_ConveyorLine : MyObjectBuilder_Base
```

### Constructors

#### MyObjectBuilder\_ConveyorLine()

##### Declaration

```
public MyObjectBuilder_ConveyorLine()
```

### Fields

#### ConveyorLineConductivity

##### Declaration

```
public MyObjectBuilder_ConveyorLine.LineConductivity ConveyorLineConductivity
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ConveyorLine.LineConductivity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ConveyorLine.LineConductivity.html) |     |

#### ConveyorLineType

##### Declaration

```
public MyObjectBuilder_ConveyorLine.LineType ConveyorLineType
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ConveyorLine.LineType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ConveyorLine.LineType.html) |     |

#### EndDirection

##### Declaration

```
public Base6Directions.Direction EndDirection
```

##### Field Value

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### EndPosition

##### Declaration

```
public SerializableVector3I EndPosition
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.SerializableVector3I |     |

#### PacketsBackward

##### Declaration

```
public List<MyObjectBuilder_ConveyorPacket> PacketsBackward
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_ConveyorPacket](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ConveyorPacket.html)\> |     |

#### PacketsForward

##### Declaration

```
public List<MyObjectBuilder_ConveyorPacket> PacketsForward
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_ConveyorPacket](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ConveyorPacket.html)\> |     |

#### Sections

##### Declaration

```
[Serialize]
public List<SerializableLineSectionInformation> Sections
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[SerializableLineSectionInformation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.SerializableLineSectionInformation.html)\> |     |

#### StartDirection

##### Declaration

```
public Base6Directions.Direction StartDirection
```

##### Field Value

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### StartPosition

##### Declaration

```
public SerializableVector3I StartPosition
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.SerializableVector3I |     |

### Methods

#### ShouldSerializePacketsBackward()

##### Declaration

```
public bool ShouldSerializePacketsBackward()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializePacketsForward()

##### Declaration

```
public bool ShouldSerializePacketsForward()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeSections()

##### Declaration

```
public bool ShouldSerializeSections()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods