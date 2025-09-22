---
title: "Class MyCharacterMovement"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCharacterMovement.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyCharacterMovement"
---

# Class MyCharacterMovement | Space Engineers ModAPI

##### Inheritance

System.Object

MyCharacterMovement

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public static class MyCharacterMovement : Object
```

### Fields

#### Backward

##### Declaration

```
public const ushort Backward = 32
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### Crouching

##### Declaration

```
public const ushort Crouching = 2
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### Died

##### Declaration

```
public const ushort Died = 6
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### Down

##### Declaration

```
public const ushort Down = 512
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### Falling

##### Declaration

```
public const ushort Falling = 4
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### Fast

##### Declaration

```
public const ushort Fast = 1024
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### Flying

##### Declaration

```
public const ushort Flying = 3
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### Forward

##### Declaration

```
public const ushort Forward = 16
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### Jump

##### Declaration

```
public const ushort Jump = 5
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### Ladder

##### Declaration

```
public const ushort Ladder = 7
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### LadderOut

##### Declaration

```
public const ushort LadderOut = 16384
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### Left

##### Declaration

```
public const ushort Left = 64
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### MovementDirectionMask

##### Declaration

```
public const ushort MovementDirectionMask = 1008
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### MovementSpeedMask

##### Declaration

```
public const ushort MovementSpeedMask = 3072
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### MovementTypeMask

##### Declaration

```
public const ushort MovementTypeMask = 15
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### NoDirection

##### Declaration

```
public const ushort NoDirection = 0
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### NormalSpeed

##### Declaration

```
public const ushort NormalSpeed = 0
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### NotRotating

##### Declaration

```
public const ushort NotRotating = 0
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### Right

##### Declaration

```
public const ushort Right = 128
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### RotatingLeft

##### Declaration

```
public const ushort RotatingLeft = 4096
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### RotatingRight

##### Declaration

```
public const ushort RotatingRight = 8192
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### RotationMask

##### Declaration

```
public const ushort RotationMask = 12288
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### Sitting

##### Declaration

```
public const ushort Sitting = 1
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### Standing

##### Declaration

```
public const ushort Standing = 0
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### Up

##### Declaration

```
public const ushort Up = 256
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### VeryFast

##### Declaration

```
public const ushort VeryFast = 2048
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

### Methods

#### GetDirection(MyCharacterMovementEnum)

##### Declaration

```
public static ushort GetDirection(this MyCharacterMovementEnum value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCharacterMovementEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCharacterMovementEnum.html) | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### GetMode(MyCharacterMovementEnum)

##### Declaration

```
public static ushort GetMode(this MyCharacterMovementEnum value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCharacterMovementEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCharacterMovementEnum.html) | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### GetSpeed(MyCharacterMovementEnum)

##### Declaration

```
public static ushort GetSpeed(this MyCharacterMovementEnum value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCharacterMovementEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCharacterMovementEnum.html) | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt16 |     |