Transforms this QuaternionD into its conjugate.

##### Declaration

#### Conjugate(QuaternionD)

Returns the conjugate of a specified QuaternionD.

##### Declaration

```
public static QuaternionD Conjugate(QuaternionD value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | value | The QuaternionD of which to return the conjugate. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### Conjugate(ref QuaternionD, out QuaternionD)

Returns the conjugate of a specified QuaternionD.

##### Declaration

```
public static void Conjugate(ref QuaternionD value, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | value | The QuaternionD of which to return the conjugate. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] An existing QuaternionD filled in to be the conjugate of the specified one. |

#### CreateFromAxisAngle(Vector3D, Double)

Creates a QuaternionD from a vector and an angle to rotate about the vector.

##### Declaration

```
public static QuaternionD CreateFromAxisAngle(Vector3D axis, double angle)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | axis | The vector to rotate around. |
| System.Double | angle | The angle to rotate around the vector. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### CreateFromAxisAngle(ref Vector3D, Double, out QuaternionD)

Creates a QuaternionD from a vector and an angle to rotate about the vector.

##### Declaration

```
public static void CreateFromAxisAngle(ref Vector3D axis, double angle, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | axis | The vector to rotate around. |
| System.Double | angle | The angle to rotate around the vector. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] The created QuaternionD. |

#### CreateFromForwardUp(Vector3D, Vector3D)

Works for normalized vectors only

##### Declaration

```
public static QuaternionD CreateFromForwardUp(Vector3D forward, Vector3D up)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | forward |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | up  |     |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### CreateFromRotationMatrix(MatrixD)

Creates a QuaternionD from a rotation MatrixD.

##### Declaration

```
public static QuaternionD CreateFromRotationMatrix(MatrixD matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix | The rotation MatrixD to create the QuaternionD from. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### CreateFromRotationMatrix(ref MatrixD, out QuaternionD)

Creates a QuaternionD from a rotation MatrixD.

##### Declaration

```
public static void CreateFromRotationMatrix(ref MatrixD matrix, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix | The rotation MatrixD to create the QuaternionD from. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] The created QuaternionD. |

#### CreateFromTwoVectors(Vector3D, Vector3D)

##### Declaration

```
public static QuaternionD CreateFromTwoVectors(Vector3D firstVector, Vector3D secondVector)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | firstVector |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | secondVector |     |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### CreateFromTwoVectors(ref Vector3D, ref Vector3D, out QuaternionD)

##### Declaration

```
public static void CreateFromTwoVectors(ref Vector3D firstVector, ref Vector3D secondVector, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | firstVector |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | secondVector |     |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result |     |

#### CreateFromYawPitchRoll(Double, Double, Double)

Creates a new QuaternionD from specified yaw, pitch, and roll angles.

##### Declaration

```
public static QuaternionD CreateFromYawPitchRoll(double yaw, double pitch, double roll)
```
