| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingSphereD, out Boolean)

Checks whether the current BoundingSphereD intersects another BoundingSphereD.

##### Declaration

```
public void Intersects(ref BoundingSphereD sphere, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | The BoundingSphereD to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingSphereD instances intersect; false otherwise. |

#### Intersects(RayD)

##### Declaration

```
public Nullable<double> Intersects(RayD ray)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html) | ray |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Double\> |     |

#### RandomToUniformPointInSphere(Double, Double, Double)

If ranX, ranY, ranZ are uniformly distributed across ranges <0,1>, Resulting point will be uniformly distributed inside sphere

##### Declaration

```
public Vector3D RandomToUniformPointInSphere(double ranX, double ranY, double ranZ)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | ranX | Random number in <0,1> affecting azimuth |
| System.Double | ranY | Random number in <0,1> affecting altitude |
| System.Double | ranZ | Random number in <0,1> affecting distance from center |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### RandomToUniformPointInSphereWithInnerCutout(Double, Double, Double, Double)

Similar to RandomToUniformPointInSphere(...) but excludes points within distance of cutoutRadius from center. (Results are randomly distributed in the shape that remains from sphere that had another sphere cut out from center. )

##### Declaration

```
public Nullable<Vector3D> RandomToUniformPointInSphereWithInnerCutout(double ranX, double ranY, double ranZ, double cutoutRadius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | ranX |     |
| System.Double | ranY |     |
| System.Double | ranZ |     |
| System.Double | cutoutRadius |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### RandomToUniformPointOnSphere(Double, Double)

##### Declaration

```
public Vector3D RandomToUniformPointOnSphere(double ranX, double ranY)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | ranX |     |
| System.Double | ranY |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### ToString()

Returns a String that represents the current BoundingSphereD.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Transform(MatrixD)

Translates and scales the BoundingSphereD using a given Matrix.

##### Declaration

```
public BoundingSphereD Transform(MatrixD matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix | A transformation matrix that might include translation, rotation, or uniform scaling. Note that BoundingSphereD.Transform will not return correct results if there are non-uniform scaling, shears, or other unusual transforms in this transformation matrix. This is because there is no way to shear or non-uniformly scale a sphere. Such an operation would cause the sphere to lose its shape as a sphere. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) |     |

#### Transform(ref MatrixD, out BoundingSphereD)

Translates and scales the BoundingSphereD using a given Matrix.

##### Declaration

```
public void Transform(ref MatrixD matrix, out BoundingSphereD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix | A transformation matrix that might include translation, rotation, or uniform scaling. Note that BoundingSphereD.Transform will not return correct results if there are non-uniform scaling, shears, or other unusual transforms in this transformation matrix. This is because there is no way to shear or non-uniformly scale a sphere. Such an operation would cause the sphere to lose its shape as a sphere. |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | result | \[OutAttribute\] The transformed BoundingSphereD. |

### Operators

#### Equality(BoundingSphereD, BoundingSphereD)

Determines whether two instances of BoundingSphereD are equal.

##### Declaration

```
public static bool operator ==(BoundingSphereD a, BoundingSphereD b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | a   | The object to the left of the equality operator. |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | b   | The object to the right of the equality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Implicit(BoundingSphere to BoundingSphereD)

##### Declaration

```
public static implicit operator BoundingSphereD(BoundingSphere b)
```
