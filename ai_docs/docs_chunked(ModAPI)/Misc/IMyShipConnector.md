---
title: "Interface IMyShipConnector"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyShipConnector.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyShipConnector"
---

# Interface IMyShipConnector | Space Engineers ModAPI

Describes connector block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyShipConnector : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### [](#properties)Properties

#### [](#Sandbox_ModAPI_Ingame_IMyShipConnector_CollectAll)CollectAll

Gets or sets whether this connector should be pulling items into its inventory.

##### Declaration

```
bool CollectAll { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_ModAPI_Ingame_IMyShipConnector_IsConnected)IsConnected

Gets whether the connector is connected. For more precise state use Status.

##### Declaration

```
bool IsConnected { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_ModAPI_Ingame_IMyShipConnector_IsLocked)IsLocked

Obsolete

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_ModAPI_Ingame_IMyShipConnector_IsParkingEnabled)IsParkingEnabled

Is this block triggered by the parking signal?

##### Declaration

```
bool IsParkingEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_ModAPI_Ingame_IMyShipConnector_OtherConnector)OtherConnector

Gets the connector this one is connected to when [Status](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyShipConnector.html#Sandbox_ModAPI_Ingame_IMyShipConnector_Status) is [Connected](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyShipConnectorStatus.html#Sandbox_ModAPI_Ingame_MyShipConnectorStatus_Connected).

##### Declaration

```
IMyShipConnector OtherConnector { get; }
```

##### Property Value

#### [](#Sandbox_ModAPI_Ingame_IMyShipConnector_PullStrength)PullStrength

Gets or sets the currently configured strength of the pull when the connector is within range of another.

##### Declaration

```
float PullStrength { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_Ingame_IMyShipConnector_Status)Status

Determines the current status of the connector.

##### Declaration

```
MyShipConnectorStatus Status { get; }
```

##### Property Value

#### [](#Sandbox_ModAPI_Ingame_IMyShipConnector_ThrowOut)ThrowOut

Gets or sets whether this connector should throw out anything placed in its inventory.

##### Declaration

```
bool ThrowOut { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#methods)Methods

#### [](#Sandbox_ModAPI_Ingame_IMyShipConnector_Connect)Connect()

Attempts to connect. If [Status](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyShipConnector.html#Sandbox_ModAPI_Ingame_IMyShipConnector_Status) is anything else but [Connectable](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyShipConnectorStatus.html#Sandbox_ModAPI_Ingame_MyShipConnectorStatus_Connectable), this method does nothing.

##### Declaration

#### [](#Sandbox_ModAPI_Ingame_IMyShipConnector_Disconnect)Disconnect()

Disconnects this connector.

##### Declaration

#### [](#Sandbox_ModAPI_Ingame_IMyShipConnector_ToggleConnect)ToggleConnect()

Toggles between [Connected](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyShipConnectorStatus.html#Sandbox_ModAPI_Ingame_MyShipConnectorStatus_Connected) and [Unconnected](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyShipConnectorStatus.html#Sandbox_ModAPI_Ingame_MyShipConnectorStatus_Unconnected), depending on the current status. Another connector must be in range for this method to have any effect.

##### Declaration

### [](#extensionmethods)Extension Methods