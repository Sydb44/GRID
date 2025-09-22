#### ThrustOverrideChanged

##### Declaration

```
public event Action<MyThrust, float> ThrustOverrideChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyThrust](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyThrust.html), System.Single\> |     |

### Explicit Interface Implementations

#### IMyThrust.PowerConsumptionMultiplier

##### Declaration

```
float IMyThrust.PowerConsumptionMultiplier { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyThrust.ThrustMultiplier

##### Declaration

```
float IMyThrust.ThrustMultiplier { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyThrust.ThrustOverrideChanged

##### Declaration

```
event Action<IMyThrust, float> IMyThrust.ThrustOverrideChanged
```

##### Returns

| Type | Description |
| --- | --- |
| System.Action<[IMyThrust](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyThrust.html), System.Single\> |     |

#### IMyThrust.CurrentThrust

##### Declaration

```
float IMyThrust.CurrentThrust { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyThrust.CurrentThrustPercentage

##### Declaration

```
float IMyThrust.CurrentThrustPercentage { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyThrust.GridThrustDirection

##### Declaration

```
Vector3I IMyThrust.GridThrustDirection { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### IMyThrust.MaxEffectiveThrust

##### Declaration

```
float IMyThrust.MaxEffectiveThrust { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyThrust.MaxThrust

##### Declaration

```
float IMyThrust.MaxThrust { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyThrust.ThrustOverride

##### Declaration

```
float IMyThrust.ThrustOverride { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyThrust.ThrustOverridePercentage

##### Declaration

```
float IMyThrust.ThrustOverridePercentage { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

### Implements

### Extension Methods