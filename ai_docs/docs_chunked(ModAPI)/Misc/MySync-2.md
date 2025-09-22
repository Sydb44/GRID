---
title: "Class MySync<T, TSyncDirection>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Network.MySync-2.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Network"
class: "MySync-2"
---

# Class MySync<T, TSyncDirection> | Space Engineers ModAPI

Implementation of synchronized property value.

##### Inheritance

System.Object

VRage.Sync.SyncBase

VRage.Sync.Sync<T, TSyncDirection>

MySync<T, TSyncDirection>

###### **Namespace**: [VRage.Game.ModAPI.Network](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Network.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MySync<T, TSyncDirection> : Sync<T, TSyncDirection>, IBitSerializable, ISyncType where TSyncDirection : SyncDirection
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | Property type |
| TSyncDirection | Allowed synchronization direction, can be VRage.Sync.SyncDirection.BothWays or VRage.Sync.SyncDirection.FromServer. |

### Properties

#### Enabled

Only synchronizes with server/client if enabled. Default is true.

##### Declaration

```
public bool Enabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Id

The unique Id for this Sync object. This is allocated per-entity.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Validate

Validate handler is raised on server after deserialization.

##### Declaration

```
public SyncValidate<T> Validate { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Sync.SyncValidate<T> |     |

#### Value

Value setter/getter. Does not validate.

##### Declaration

```
public T Value { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| T   |     |

#### ValueType

The type of the [Value](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Network.MySync-2.html#VRage_Game_ModAPI_Network_MySync_2_Value) property.

##### Declaration

```
public Type ValueType { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Type |     |

### Methods

#### RaiseValueChanged(Boolean)

##### Declaration

```
protected override void RaiseValueChanged(bool notify)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | notify |     |

##### Overrides

VRage.Sync.SyncBase.RaiseValueChanged(System.Boolean)

#### SetLocalValue(T)

Sets new value only locally if on client. USE ONLY WITH VALUES YOU GOT FROM THE SERVER VIA OTHER CHANNELS! (e.g. when initializing from object builder) Behaves like regular set on the server

##### Declaration

```
public void SetLocalValue(T newValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | newValue |     |

#### ValidateAndSet(T)

Validates the value and sets it (when valid).

##### Declaration

```
public void ValidateAndSet(T newValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | newValue |     |

### Events

#### ValueChanged

ValueChanged event is raised when value is set locally (setting [Value](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Network.MySync-2.html#VRage_Game_ModAPI_Network_MySync_2_Value) property) or remotely (through deserialization). If validation fails, value is not changed and ValueChanged is not raised.

##### Declaration

```
public event Action<MySync<T, TSyncDirection>> ValueChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MySync](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Network.MySync-2.html)<T, TSyncDirection>> |     |

### Operators

#### Implicit(MySync<T, TSyncDirection> to T)

##### Declaration

```
public static implicit operator T(MySync<T, TSyncDirection> sync)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySync](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Network.MySync-2.html)<T, TSyncDirection> | sync |     |

##### Returns

| Type | Description |
| --- | --- |
| T   |     |