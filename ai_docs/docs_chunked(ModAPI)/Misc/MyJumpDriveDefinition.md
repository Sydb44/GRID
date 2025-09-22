---
title: "Class MyJumpDriveDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyJumpDriveDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyJumpDriveDefinition"
---

# Class MyJumpDriveDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyJumpDriveDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyJumpDriveDefinition : MyFunctionalBlockDefinition
```

### Constructors

#### MyJumpDriveDefinition()

##### Declaration

```
public MyJumpDriveDefinition()
```

### Fields

#### ChargingSound

##### Declaration

```
public MySoundPair ChargingSound
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

#### JumpInSound

##### Declaration

```
public MySoundPair JumpInSound
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

#### JumpOutSound

##### Declaration

```
public MySoundPair JumpOutSound
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

#### JumpParticleEffect

##### Declaration

```
public string JumpParticleEffect
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### MaxJumpDistance

##### Declaration

```
public double MaxJumpDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### MaxJumpMass

##### Declaration

```
public double MaxJumpMass
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### MinJumpDistance

##### Declaration

```
public double MinJumpDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### PowerEfficiency

##### Declaration

```
public float PowerEfficiency
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PowerNeededForJump

##### Declaration

```
public float PowerNeededForJump
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RequiredPowerInput

##### Declaration

```
public float RequiredPowerInput
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ResourceSinkGroup

##### Declaration

```
public MyStringHash ResourceSinkGroup
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

### Methods

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Overrides