---
title: "Class CustomMovementFunction"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.CustomMovementFunction.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "CustomMovementFunction"
---

# Class CustomMovementFunction | Space Engineers ModAPI

##### Inheritance

System.Object

CustomMovementFunction

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class CustomMovementFunction : MulticastDelegate
```

### Constructors

#### CustomMovementFunction(Object, IntPtr)

##### Declaration

```
public CustomMovementFunction(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(MyEntityThrustComponent, Vector3D, Double, Double, Boolean, Boolean, Boolean, Double, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(MyEntityThrustComponent thrustComponent, Vector3D delta, double maxSpeed, double stoppingTimeMultiplier, bool isDockingModeEnabled, bool isAlignedToGravity, bool isMinHeightAlignmentEnabled, double minHeightAboveTerrain, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.GameSystems.MyEntityThrustComponent | thrustComponent |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | delta |     |
| System.Double | maxSpeed |     |
| System.Double | stoppingTimeMultiplier |     |
| System.Boolean | isDockingModeEnabled |     |
| System.Boolean | isAlignedToGravity |     |
| System.Boolean | isMinHeightAlignmentEnabled |     |
| System.Double | minHeightAboveTerrain |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

#### Invoke(MyEntityThrustComponent, Vector3D, Double, Double, Boolean, Boolean, Boolean, Double)

##### Declaration

```
public virtual void Invoke(MyEntityThrustComponent thrustComponent, Vector3D delta, double maxSpeed, double stoppingTimeMultiplier, bool isDockingModeEnabled, bool isAlignedToGravity, bool isMinHeightAlignmentEnabled, double minHeightAboveTerrain)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.GameSystems.MyEntityThrustComponent | thrustComponent |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | delta |     |
| System.Double | maxSpeed |     |
| System.Double | stoppingTimeMultiplier |     |
| System.Boolean | isDockingModeEnabled |     |
| System.Boolean | isAlignedToGravity |     |
| System.Boolean | isMinHeightAlignmentEnabled |     |
| System.Double | minHeightAboveTerrain |     |