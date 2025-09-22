---
title: "Class MyDataBroadcaster"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataBroadcaster.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyDataBroadcaster"
---

# Class MyDataBroadcaster | Space Engineers ModAPI

##### Inheritance

System.Object

MyDataBroadcaster

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyDataBroadcaster : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner
```

### Constructors

#### MyDataBroadcaster()

##### Declaration

```
public MyDataBroadcaster()
```

### Fields

#### m\_receiversInRange

##### Declaration

```
protected HashSet<MyDataReceiver> m_receiversInRange
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<[MyDataReceiver](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataReceiver.html)\> |     |

#### m\_tmpBroadcasters

##### Declaration

```
protected static List<MyDataBroadcaster> m_tmpBroadcasters
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyDataBroadcaster](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataBroadcaster.html)\> |     |

### Properties

#### AntennaEntityId

##### Declaration

```
public long AntennaEntityId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### BroadcastPosition

##### Declaration

```
public Vector3D BroadcastPosition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Closed

##### Declaration

```
public bool Closed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### HasRemoteControl

##### Declaration

```
public bool HasRemoteControl { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Info

##### Declaration

```
public MyAntennaSystem.BroadcasterInfo Info { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.MyAntennaSystem.BroadcasterInfo |     |

#### IsBeacon

##### Declaration

```
public bool IsBeacon { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MainRemoteControlId

##### Declaration

```
public Nullable<long> MainRemoteControlId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

#### MainRemoteControlOwner

##### Declaration

```
public Nullable<long> MainRemoteControlOwner { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

#### MainRemoteControlSharing

##### Declaration

```
public MyOwnershipShareModeEnum MainRemoteControlSharing { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyOwnershipShareModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOwnershipShareModeEnum.html) |     |

#### Owner

##### Declaration

```
public long Owner { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### Receiver

##### Declaration

```
public MyDataReceiver Receiver { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDataReceiver](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataReceiver.html) |     |

#### ReceiversInRange

##### Declaration

```
public HashSet<MyDataReceiver> ReceiversInRange { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<[MyDataReceiver](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataReceiver.html)\> |     |

#### ShowInTerminal

##### Declaration

```
public bool ShowInTerminal { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowOnHud

##### Declaration

```
public virtual bool ShowOnHud { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### CanBeUsedByPlayer(Int64)

##### Declaration

```
public bool CanBeUsedByPlayer(long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanBeUsedByPlayer(Int64, IMyEntity)

##### Declaration

```
public static bool CanBeUsedByPlayer(long playerId, IMyEntity Entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | Entity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetHudParams(Boolean)

##### Declaration

```
public List<MyHudEntityParams> GetHudParams(bool allowBlink)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | allowBlink |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<VRage.Game.Gui.MyHudEntityParams\> |     |

#### InitProxyObjectBuilder(MyObjectBuilder\_ProxyAntenna)

##### Declaration

```
public virtual void InitProxyObjectBuilder(MyObjectBuilder_ProxyAntenna ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ProxyAntenna](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ProxyAntenna.html) | ob  |     |
