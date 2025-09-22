Determines whether this Ray intersects a specified Plane.

##### Declaration

```
public Nullable<double> Intersects(PlaneD plane)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | plane | The Plane with which to calculate this Ray's intersection. |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Double\> |     |

#### Intersects(ref PlaneD, out Nullable<Double>)

Determines whether this Ray intersects a specified Plane.

##### Declaration

```
public void Intersects(ref PlaneD plane, out Nullable<double> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | plane | The Plane with which to calculate this Ray's intersection. |
| System.Nullable<System.Double\> | result | \[OutAttribute\] The distance at which this Ray intersects the specified Plane, or null if there is no intersection. |

#### ToString()

Returns a String that represents the current Ray.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### Operators

#### Equality(RayD, RayD)

Determines whether two instances of Ray are equal.

##### Declaration

```
public static bool operator ==(RayD a, RayD b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html) | a   | The object to the left of the equality operator. |
| [RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html) | b   | The object to the right of the equality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Inequality(RayD, RayD)

Determines whether two instances of Ray are not equal.

##### Declaration

```
public static bool operator !=(RayD a, RayD b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html) | a   | The object to the left of the inequality operator. |
| [RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html) | b   | The object to the right of the inequality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |