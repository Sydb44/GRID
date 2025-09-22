---
title: "Class MyModAPIHelper.MyMultiplayer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyModAPIHelper.MyMultiplayer.html"
category: "Misc"
namespace: "Sandbox.ModAPI.MyModAPIHelper"
class: "MyMultiplayer"
---

# Class MyModAPIHelper.MyMultiplayer | Space Engineers ModAPI

##### Inheritance

System.Object

MyModAPIHelper.MyMultiplayer

##### Implements

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[StaticEventOwner]
public class MyMultiplayer : Object, IMyMultiplayer
```

### Constructors

#### MyMultiplayer()

##### Declaration

### Fields

#### Static

##### Declaration

```
public static MyModAPIHelper.MyMultiplayer Static
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyModAPIHelper.MyMultiplayer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyModAPIHelper.MyMultiplayer.html) |     |

### Properties

#### IsServer

##### Declaration

```
public bool IsServer { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MultiplayerActive

##### Declaration

```
public bool MultiplayerActive { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MyId

##### Declaration

```
public ulong MyId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### MyName

##### Declaration

```
public string MyName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Players

##### Declaration

```
public IMyPlayerCollection Players { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyPlayerCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPlayerCollection.html) |     |

#### ServerId

##### Declaration

```
public ulong ServerId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

### Methods

#### IsServerPlayer(IMyNetworkClient)

##### Declaration

```
public bool IsServerPlayer(IMyNetworkClient player)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyNetworkClient](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyNetworkClient.html) | player |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### JoinServer(String)

##### Declaration

```
public void JoinServer(string address)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | address |     |

#### RegisterMessageHandler(UInt16, Action<Byte\[\]>)

##### Declaration

```
public void RegisterMessageHandler(ushort id, Action<byte[]> messageHandler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | id  |     |
| System.Action<System.Byte\[\]> | messageHandler |     |

#### RegisterSecureMessageHandler(UInt16, Action<UInt16, Byte\[\], UInt64, Boolean>)

##### Declaration

```
public void RegisterSecureMessageHandler(ushort id, Action<ushort, byte[], ulong, bool> messageHandler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | id  |     |
| System.Action<System.UInt16, System.Byte\[\], System.UInt64, System.Boolean\> | messageHandler |     |

#### SendEntitiesCreated(List<MyObjectBuilder\_EntityBase>)

##### Declaration

```
public void SendEntitiesCreated(List<MyObjectBuilder_EntityBase> objectBuilders)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)\> | objectBuilders |     |

#### SendMessageTo(UInt16, Byte\[\], UInt64, Boolean)

##### Declaration

```
public bool SendMessageTo(ushort id, byte[] message, ulong recipient, bool reliable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | id  |     |
| System.Byte\[\] | message |     |
| System.UInt64 | recipient |     |
| System.Boolean | reliable |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SendMessageToOthers(UInt16, Byte\[\], Boolean)

##### Declaration

```
public bool SendMessageToOthers(ushort id, byte[] message, bool reliable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | id  |     |
| System.Byte\[\] | message |     |
| System.Boolean | reliable |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SendMessageToServer(UInt16, Byte\[\], Boolean)

##### Declaration

```
public bool SendMessageToServer(ushort id, byte[] message, bool reliable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | id  |     |
| System.Byte\[\] | message |     |
| System.Boolean | reliable |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UnregisterMessageHandler(UInt16, Action<Byte\[\]>)

##### Declaration

```
public void UnregisterMessageHandler(ushort id, Action<byte[]> messageHandler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | id  |     |
| System.Action<System.Byte\[\]> | messageHandler |     |

#### UnregisterSecureMessageHandler(UInt16, Action<UInt16, Byte\[\], UInt64, Boolean>)

##### Declaration

```
public void UnregisterSecureMessageHandler(ushort id, Action<ushort, byte[], ulong, bool> messageHandler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt16 | id  |     |
| System.Action<System.UInt16, System.Byte\[\], System.UInt64, System.Boolean\> | messageHandler |     |

### Implements