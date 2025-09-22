---
title: "Class MyObjectBuilder\\_AutopilotWaypoint"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutopilotWaypoint.html"
category: "AI"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_AutopilotWaypoint"
---

# Class MyObjectBuilder\_AutopilotWaypoint | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_AutopilotWaypoint

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_AutopilotWaypoint : MyObjectBuilder_Base
```

### Constructors

#### MyObjectBuilder\_AutopilotWaypoint()

##### Declaration

```
public MyObjectBuilder_AutopilotWaypoint()
```

### Fields

#### Actions

##### Declaration

```
[DynamicNullableObjectBuilderItem(false)]
[Serialize]
public List<MyObjectBuilder_ToolbarItem> Actions
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_ToolbarItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ToolbarItem.html)\> |     |

#### AdaptiveRotationSpeed

##### Declaration

```
public bool AdaptiveRotationSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AreaUp

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Coords

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### DistancePrecisionMultiplier

##### Declaration

```
public float DistancePrecisionMultiplier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Draw

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ForceRotation

##### Declaration

```
public bool ForceRotation
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Indexes

##### Declaration

```
[Serialize]
public List<int> Indexes
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Int32\> |     |

#### IsCorrectRotationNeeded

##### Declaration

```
public bool IsCorrectRotationNeeded
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Matrix

##### Declaration

```
public MyPositionAndOrientation Matrix
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.MyPositionAndOrientation |     |

#### Name

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### RelatedEntityId

##### Declaration

```
public long RelatedEntityId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### RelatedEntityMatrix

##### Declaration

```
public MyPositionAndOrientation RelatedEntityMatrix
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.MyPositionAndOrientation |     |

#### RelatedEntityWorldOffset

##### Declaration

```
public Vector3D RelatedEntityWorldOffset
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### RelatedMatrixCurrent

##### Declaration

```
[Serialize]
public Nullable<MyPositionAndOrientation> RelatedMatrixCurrent
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.MyPositionAndOrientation\> |     |

#### SerializeForCopy

##### Declaration

```
public bool SerializeForCopy
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### StoppingTimeMultiplier

##### Declaration

```
public float StoppingTimeMultiplier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### Remap(IMyRemapHelper)

##### Declaration

```
public void Remap(IMyRemapHelper remapHelper)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyRemapHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html) | remapHelper |     |

### Extension Methods