---
title: "Class MyObjectBuilder\\_ShipConnector"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_ShipConnector.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_ShipConnector"
---

# Class MyObjectBuilder\_ShipConnector | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_ShipConnector

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_ShipConnector : MyObjectBuilder_FunctionalBlock
```

### Constructors

#### MyObjectBuilder\_ShipConnector()

##### Declaration

```
public MyObjectBuilder_ShipConnector()
```

### Fields

#### AutoUnlockTime

##### Declaration

```
public float AutoUnlockTime
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CollectAll

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Connected

When ConnectedEntityId is not null, this tells whether the connection is only approach (yellow) or locked connection (green)

##### Declaration

```
[NoSerialize]
public bool Connected
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ConnectedEntityId

##### Declaration

```
public long ConnectedEntityId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### DefaultStrength

##### Declaration

```
public const float DefaultStrength = 0.00015F
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Inventory

##### Declaration

```
[Nullable]
public MyObjectBuilder_Inventory Inventory
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Inventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Inventory.html) |     |

#### IsApproaching

##### Declaration

```
public bool IsApproaching
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsConnecting

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsMaster

##### Declaration

```
[Nullable]
public Nullable<bool> IsMaster
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Boolean\> |     |

#### IsParkingEnabled

##### Declaration

```
public bool IsParkingEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPowerTransferOverrideEnabled

##### Declaration

```
public bool IsPowerTransferOverrideEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MasterToSlaveGrid

##### Declaration

```
[Serialize]
public Nullable<MyDeltaTransform> MasterToSlaveGrid
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.MyDeltaTransform\> |     |

#### MasterToSlaveTransform

Master is connector with higher EntityId

##### Declaration

```
public Nullable<MyPositionAndOrientation> MasterToSlaveTransform
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.MyPositionAndOrientation\> |     |

#### Strength

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ThrowOut

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TimeOfConnection

##### Declaration

```
public int TimeOfConnection
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### TradingEnabled

##### Declaration

```
public bool TradingEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

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

#### SetupForProjector()

##### Declaration

```
public override void SetupForProjector()
```

##### Overrides

#### ShouldSerializeConnected()

##### Declaration

```
public bool ShouldSerializeConnected()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeConnectedEntityId()

##### Declaration

```
public bool ShouldSerializeConnectedEntityId()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods