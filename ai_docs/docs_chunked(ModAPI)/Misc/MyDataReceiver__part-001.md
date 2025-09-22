---
title: "Class MyDataReceiver"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataReceiver.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyDataReceiver"
---

# Class MyDataReceiver | Space Engineers ModAPI

##### Inheritance

System.Object

MyDataReceiver

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyDataReceiver : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyDataReceiver()

##### Declaration

```
protected MyDataReceiver()
```

### Fields

#### m\_broadcastersInRange

##### Declaration

```
protected HashSet<MyDataBroadcaster> m_broadcastersInRange
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<[MyDataBroadcaster](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataBroadcaster.html)\> |     |

#### m\_lastBroadcastersInRange

##### Declaration

```
protected List<MyDataBroadcaster> m_lastBroadcastersInRange
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyDataBroadcaster](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataBroadcaster.html)\> |     |

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

#### Broadcaster

##### Declaration

```
public MyDataBroadcaster Broadcaster { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDataBroadcaster](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataBroadcaster.html) |     |

#### BroadcastersInRange

##### Declaration

```
public HashSet<MyDataBroadcaster> BroadcastersInRange { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<[MyDataBroadcaster](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataBroadcaster.html)\> |     |

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

#### Enabled

##### Declaration

```
public bool Enabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### add\_OnBroadcasterFound(MyDataReceiver.BroadcasterChangeInfo)

##### Declaration

```
public void add_OnBroadcasterFound(MyDataReceiver.BroadcasterChangeInfo value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDataReceiver.BroadcasterChangeInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataReceiver.BroadcasterChangeInfo.html) | value |     |

#### add\_OnBroadcasterLost(MyDataReceiver.BroadcasterChangeInfo)

##### Declaration

```
public void add_OnBroadcasterLost(MyDataReceiver.BroadcasterChangeInfo value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDataReceiver.BroadcasterChangeInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataReceiver.BroadcasterChangeInfo.html) | value |     |

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

#### Clear()

##### Declaration

#### GetBroadcastersContactingMe(ref HashSet<MyDataBroadcaster>)

##### Declaration

```
protected abstract void GetBroadcastersContactingMe(ref HashSet<MyDataBroadcaster> broadcastersInRange)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.HashSet<[MyDataBroadcaster](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataBroadcaster.html)\> | broadcastersInRange |     |

#### HasAccessToLogicalGroup(MyGridLogicalGroupData)

##### Declaration

```
public bool HasAccessToLogicalGroup(MyGridLogicalGroupData group)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyGridLogicalGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGridLogicalGroupData.html) | group |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### remove\_OnBroadcasterFound(MyDataReceiver.BroadcasterChangeInfo)

##### Declaration

```
public void remove_OnBroadcasterFound(MyDataReceiver.BroadcasterChangeInfo value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDataReceiver.BroadcasterChangeInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataReceiver.BroadcasterChangeInfo.html) | value |     |

#### remove\_OnBroadcasterLost(MyDataReceiver.BroadcasterChangeInfo)

##### Declaration

```
public void remove_OnBroadcasterLost(MyDataReceiver.BroadcasterChangeInfo value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDataReceiver.BroadcasterChangeInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDataReceiver.BroadcasterChangeInfo.html) | value |     |

#### UpdateBroadcastersInRange()

##### Declaration

```
public void UpdateBroadcastersInRange()
```

#### UpdateHud(Boolean)

##### Declaration

```
public void UpdateHud(bool showMyself = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | showMyself |     |
