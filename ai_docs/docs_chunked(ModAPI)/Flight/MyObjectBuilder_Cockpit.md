---
title: "Class MyObjectBuilder\\_Cockpit"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_Cockpit.html"
category: "Flight"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_Cockpit"
---

# Class MyObjectBuilder\_Cockpit | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Cockpit

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_Cockpit : MyObjectBuilder_ShipController
```

### Constructors

#### MyObjectBuilder\_Cockpit()

##### Declaration

```
public MyObjectBuilder_Cockpit()
```

### Fields

#### Autopilot

##### Declaration

```
[Serialize]
[DynamicObjectBuilder(false)]
public MyObjectBuilder_AutopilotBase Autopilot
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_AutopilotBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutopilotBase.html) |     |

#### IsInFirstPersonView

##### Declaration

```
public bool IsInFirstPersonView
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OxygenLevel

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Panels

##### Declaration

```
[Serialize]
public List<CockpitPanelData> Panels
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[CockpitPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.CockpitPanelData.html)\> |     |

#### Pilot

##### Declaration

```
[Serialize]
public MyObjectBuilder_Character Pilot
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Character](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Character.html) |     |

#### PilotGunDefinition

##### Declaration

```
public Nullable<SerializableDefinitionId> PilotGunDefinition
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html)\> |     |

#### PilotJetpackEnabled

##### Declaration

```
[Nullable]
public Nullable<bool> PilotJetpackEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Boolean\> |     |

#### PilotRelativeWorld

##### Declaration

```
public Nullable<MyPositionAndOrientation> PilotRelativeWorld
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.MyPositionAndOrientation\> |     |

#### SitAnimation

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### TargetData

##### Declaration

```
public MyTargetData TargetData
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyTargetData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyTargetData.html) |     |

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

### Methods

#### ClearPilotAndAutopilot()

##### Declaration

```
public void ClearPilotAndAutopilot()
```

#### SetupForProjector()

##### Declaration

```
public override void SetupForProjector()
```

##### Overrides

### Extension Methods