##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsCorrectRotationNeeded

##### Declaration

```
public bool IsCorrectRotationNeeded { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPathfindingVertex

##### Declaration

```
public bool IsPathfindingVertex { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Matrix

Matrix when recorded

##### Declaration

```
public MatrixD Matrix { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### Name

##### Declaration

```
public string Name { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### PathfindingVertex

##### Declaration

```
public MyPathVertex PathfindingVertex { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Game.AI.MyPathVertex |     |

#### RelatedCoordsOriginal

Related Translation when recorded

##### Declaration

```
public Vector3D RelatedCoordsOriginal { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### RelatedEntity

##### Declaration

```
public MyEntity RelatedEntity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### RelatedEntityId

##### Declaration

```
public long RelatedEntityId { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### RelatedEntityWorldOffset

##### Declaration

```
public Vector3D RelatedEntityWorldOffset { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### RelatedEntityWorldOffsetOriginal

##### Declaration

```
public Vector3D RelatedEntityWorldOffsetOriginal { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### RelatedMatrixCurrent

##### Declaration

```
public MatrixD RelatedMatrixCurrent { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### RelativeMatrix

Actual shown position

##### Declaration

```
public MatrixD RelativeMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### SelectedForDraw

##### Declaration

```
public bool SelectedForDraw { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### StoppingTimeMultiplier

##### Declaration

```
public float StoppingTimeMultiplier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Toolbar

##### Declaration

```
public MyToolbar Toolbar { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Screens.Helpers.MyToolbar |     |

### Methods

#### AreEqualByResultCoordinates(MyAutopilotWaypoint, MyAutopilotWaypoint)

##### Declaration

```
public static bool AreEqualByResultCoordinates(MyAutopilotWaypoint a, MyAutopilotWaypoint b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAutopilotWaypoint.html) | a   |     |
| [MyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAutopilotWaypoint.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetObjectBuilder()

##### Declaration

```
public MyObjectBuilder_AutopilotWaypoint GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_AutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutopilotWaypoint.html) |     |

#### InitToolbar()

##### Declaration

```
public void InitToolbar()
```

#### SetActions(List<MyObjectBuilder\_Toolbar.Slot>)

##### Declaration

```
public void SetActions(List<MyObjectBuilder_Toolbar.Slot> actionSlots)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_Toolbar.Slot](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Toolbar.Slot.html)\> | actionSlots |     |

#### SetGpsDraw()

##### Declaration

### Implements