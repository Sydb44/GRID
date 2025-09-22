| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### Intersects(ref Plane, out Nullable<Single>)

Determines whether this Ray intersects a specified Plane.

##### Declaration

```
public void Intersects(ref Plane plane, out Nullable<float> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | plane | The Plane with which to calculate this Ray's intersection. |
| System.Nullable<System.Single\> | result | \[OutAttribute\] The distance at which this Ray intersects the specified Plane, or null if there is no intersection. |

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

#### Equality(Ray, Ray)

Determines whether two instances of Ray are equal.

##### Declaration

```
public static bool operator ==(Ray a, Ray b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | a   | The object to the left of the equality operator. |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | b   | The object to the right of the equality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Inequality(Ray, Ray)

Determines whether two instances of Ray are not equal.

##### Declaration

```
public static bool operator !=(Ray a, Ray b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | a   | The object to the left of the inequality operator. |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | b   | The object to the right of the inequality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |