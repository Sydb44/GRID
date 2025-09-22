Description

System.String

message

#### DeserializeValue(XmlReader, out Vector3)

##### Declaration

```
public static void DeserializeValue(XmlReader reader, out Vector3 value)
```

##### Parameters

Type

Name

Description

System.Xml.XmlReader

reader

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

#### DeserializeValue(XmlReader, out Vector4)

##### Declaration

```
public static void DeserializeValue(XmlReader reader, out Vector4 value)
```

##### Parameters

Type

Name

Description

System.Xml.XmlReader

reader

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value

#### FormatByteSizePrefix(ref Double)

##### Declaration

```
public static string FormatByteSizePrefix(ref double byteSize)
```

##### Parameters

Type

Name

Description

System.Double

byteSize

##### Returns

Type

Description

System.String

#### GenerateBoxColors()

##### Declaration

```
public static Color[] GenerateBoxColors()
```

##### Returns

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)\[\]

#### GenerateQuad(out MyQuadD, ref Vector3D, Single, Single, ref MatrixD)

Generate oriented quad by matrix

##### Declaration

```
public static void GenerateQuad(out MyQuadD quad, ref Vector3D position, float width, float height, ref MatrixD matrix)
```

##### Parameters

Type

Name

Description

[MyQuadD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyQuadD.html)

quad

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.Single

width

System.Single

height

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

#### GetAngleBetweenVectors(Vector3, Vector3)

Calculating the Angle between two Vectors (return in radians).

##### Declaration

```
public static float GetAngleBetweenVectors(Vector3 vectorA, Vector3 vectorB)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vectorA

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vectorB

##### Returns

Type

Description

System.Single

#### GetAngleBetweenVectorsAndNormalise(Vector3, Vector3)

##### Declaration

```
public static float GetAngleBetweenVectorsAndNormalise(Vector3 vectorA, Vector3 vectorB)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vectorA

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vectorB

##### Returns

Type

Description

System.Single

#### GetAngleBetweenVectorsForSphereCollision(Vector3, Vector3)

##### Declaration

```
public static float GetAngleBetweenVectorsForSphereCollision(Vector3 vector1, Vector3 vector2)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector1

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector2

##### Returns

Type

Description

System.Single

#### GetBillboardQuadAdvancedRotated(out MyQuadD, Vector3D, Single, Single, Single, Vector3D)

##### Declaration

```
public static bool GetBillboardQuadAdvancedRotated(out MyQuadD quad, Vector3D position, float radiusX, float radiusY, float angle, Vector3D cameraPosition)
```

##### Parameters

Type

Name

Description

[MyQuadD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyQuadD.html)

quad

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.Single

radiusX

System.Single

radiusY

System.Single

angle

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraPosition

##### Returns

Type

Description

System.Boolean

#### GetBillboardQuadAdvancedRotated(out MyQuadD, Vector3D, Single, Single, Vector3D)

##### Declaration

```
public static bool GetBillboardQuadAdvancedRotated(out MyQuadD quad, Vector3D position, float radius, float angle, Vector3D cameraPosition)
```

##### Parameters

Type

Name

Description

[MyQuadD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyQuadD.html)

quad

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.Single

radius

System.Single

angle

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

cameraPosition

##### Returns

Type

Description

System.Boolean

#### GetBillboardQuadOriented(out MyQuadD, ref Vector3D, Single, Single, ref Vector3, ref Vector3)

This billboard isn't facing the camera. It's always oriented in specified direction. May be used as thrusts, or inner light of reflector.

##### Declaration

```
public static void GetBillboardQuadOriented(out MyQuadD quad, ref Vector3D position, float width, float height, ref Vector3 leftVector, ref Vector3 upVector)
```

##### Parameters

Type

Name

Description

[MyQuadD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyQuadD.html)

quad

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.Single

width

System.Single

height

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

leftVector

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

upVector

#### GetBoolFromString(String)

##### Declaration

```
public static Nullable<bool> GetBoolFromString(string s)
```

##### Parameters

Type

Name

Description

System.String

s

##### Returns

Type

Description

System.Nullable<System.Boolean\>

#### GetBoolFromString(String, Boolean)
