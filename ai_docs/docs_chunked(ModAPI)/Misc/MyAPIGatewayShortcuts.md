---
title: "Class MyAPIGatewayShortcuts"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyAPIGatewayShortcuts.html"
category: "Misc"
namespace: "VRage.ModAPI"
class: "MyAPIGatewayShortcuts"
---

# Class MyAPIGatewayShortcuts | Space Engineers ModAPI

Links to modapi actions. Delegates are set inside MyAPIGateway. VRAGE TODO: This is probably a temporary class helping us to remove sandbox.

##### Inheritance

System.Object

MyAPIGatewayShortcuts

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public static class MyAPIGatewayShortcuts : Object
```

### Fields

#### GetLocalPlayerPosition

##### Declaration

```
public static MyAPIGatewayShortcuts.GetLocalPlayerPositionCallback GetLocalPlayerPosition
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyAPIGatewayShortcuts.GetLocalPlayerPositionCallback](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyAPIGatewayShortcuts.GetLocalPlayerPositionCallback.html) |     |

#### GetMainCamera

##### Declaration

```
public static MyAPIGatewayShortcuts.GetMainCameraCallback GetMainCamera
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyAPIGatewayShortcuts.GetMainCameraCallback](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyAPIGatewayShortcuts.GetMainCameraCallback.html) |     |

#### GetWorldBoundaries

##### Declaration

```
public static MyAPIGatewayShortcuts.GetWorldBoundariesCallback GetWorldBoundaries
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyAPIGatewayShortcuts.GetWorldBoundariesCallback](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyAPIGatewayShortcuts.GetWorldBoundariesCallback.html) |     |

#### RegisterEntityUpdate

Registers entity in update loop. Parameters: IMyEntity entity (ref to entity to be registered)

##### Declaration

```
public static Action<IMyEntity> RegisterEntityUpdate
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

#### UnregisterEntityUpdate

Unregisters entity from update loop. Parameters: IMyEntity entity (ref to entity to be unregistered), bool immediate (default is false)

##### Declaration

```
public static Action<IMyEntity, bool> UnregisterEntityUpdate
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html), System.Boolean\> |     |