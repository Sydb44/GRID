| Type | Name | Description |
| --- | --- | --- |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | ray | The Ray to check for intersection with the current BoundingSphere. |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### Intersects(ref Ray, out Nullable<Single>)

Checks whether the current BoundingSphere intersects a Ray.

##### Declaration

```
public void Intersects(ref Ray ray, out Nullable<float> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | ray | The Ray to check for intersection with. |
| System.Nullable<System.Single\> | result | \[OutAttribute\] Distance at which the ray intersects the BoundingSphere or null if there is no intersection. |

#### ToString()

Returns a String that represents the current BoundingSphere.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Transform(Matrix)

Translates and scales the BoundingSphere using a given Matrix.

##### Declaration

```
public BoundingSphere Transform(Matrix matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix | A transformation matrix that might include translation, rotation, or uniform scaling. Note that BoundingSphere.Transform will not return correct results if there are non-uniform scaling, shears, or other unusual transforms in this transformation matrix. This is because there is no way to shear or non-uniformly scale a sphere. Such an operation would cause the sphere to lose its shape as a sphere. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) |     |

#### Transform(ref Matrix, out BoundingSphere)

Translates and scales the BoundingSphere using a given Matrix.

##### Declaration

```
public void Transform(ref Matrix matrix, out BoundingSphere result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix | A transformation matrix that might include translation, rotation, or uniform scaling. Note that BoundingSphere.Transform will not return correct results if there are non-uniform scaling, shears, or other unusual transforms in this transformation matrix. This is because there is no way to shear or non-uniformly scale a sphere. Such an operation would cause the sphere to lose its shape as a sphere. |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | result | \[OutAttribute\] The transformed BoundingSphere. |

#### Translate(ref Vector3)

##### Declaration

```
public BoundingSphere Translate(ref Vector3 translation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | translation |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) |     |

### Operators

#### Equality(BoundingSphere, BoundingSphere)

Determines whether two instances of BoundingSphere are equal.

##### Declaration

```
public static bool operator ==(BoundingSphere a, BoundingSphere b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | a   | The object to the left of the equality operator. |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | b   | The object to the right of the equality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Inequality(BoundingSphere, BoundingSphere)

Determines whether two instances of BoundingSphere are not equal.

##### Declaration

```
public static bool operator !=(BoundingSphere a, BoundingSphere b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | a   | The BoundingSphere to the left of the inequality operator. |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | b   | The BoundingSphere to the right of the inequality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |