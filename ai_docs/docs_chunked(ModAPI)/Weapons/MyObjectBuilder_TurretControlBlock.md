---
title: "Class MyObjectBuilder\\_TurretControlBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_TurretControlBlock.html"
category: "Weapons"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_TurretControlBlock"
---

# Class MyObjectBuilder\_TurretControlBlock | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_TurretControlBlock

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_TurretControlBlock : MyObjectBuilder_FunctionalBlock
```

### Constructors

#### MyObjectBuilder\_TurretControlBlock()

##### Declaration

```
public MyObjectBuilder_TurretControlBlock()
```

### Fields

#### AllowAI

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AngleDeviation

##### Declaration

```
public float AngleDeviation
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### AreWeaponsMismatched

##### Declaration

```
public bool AreWeaponsMismatched
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AzimuthId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### CameraId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### DirectionBlockId

##### Declaration

```
public long DirectionBlockId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### ElevationId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### Flags

##### Declaration

```
[Serialize]
public MyObjectBuilder_TargetingFlags Flags
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_TargetingFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_TargetingFlags.html) |     |

#### IsCorrect

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PreviousControlledEntityId

##### Declaration

```
public Nullable<long> PreviousControlledEntityId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

#### Range

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### TargetingGroup

##### Declaration

```
public MyStringHash TargetingGroup
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### TargetLocking

##### Declaration

```
public bool TargetLocking
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TextPanels

##### Declaration

```
[Serialize]
public List<MySerializedTextPanelData> TextPanels
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MySerializedTextPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MySerializedTextPanelData.html)\> |     |

#### Toolbar

##### Declaration

```
public MyObjectBuilder_Toolbar Toolbar
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Toolbar](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Toolbar.html) |     |

#### ToolIds

##### Declaration

```
public MySerializableList<long> ToolIds
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.ObjectBuilder.MySerializableList<System.Int64\> |     |

#### VelocityMultiplierAzimuth

##### Declaration

```
public float VelocityMultiplierAzimuth
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### VelocityMultiplierElevation

##### Declaration

```
public float VelocityMultiplierElevation
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### GetTextPanelsData()

##### Declaration

```
public override List<MySerializedTextPanelData> GetTextPanelsData()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MySerializedTextPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MySerializedTextPanelData.html)\> |     |

##### Overrides

#### Remap(IMyRemapHelper)

##### Declaration

```
public override void Remap(IMyRemapHelper remapHelper)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyRemapHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html) | remapHelper |     |

##### Overrides

### Extension Methods