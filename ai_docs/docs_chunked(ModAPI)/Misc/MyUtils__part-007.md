Description

System.Int32

maxValue

##### Returns

Type

Description

System.Int32

#### GetRandomInt(Int32, Int32)

Return random int in range of minValue to maxValue, the range of return values includes minValue but not maxValue

##### Declaration

```
public static int GetRandomInt(int minValue, int maxValue)
```

##### Parameters

Type

Name

Description

System.Int32

minValue

min

System.Int32

maxValue

max

##### Returns

Type

Description

System.Int32

#### GetRandomItem<T>(T\[\])

##### Declaration

```
public static T GetRandomItem<T>(this T[] list)
```

##### Parameters

Type

Name

Description

T\[\]

list

##### Returns

Type

Description

T

##### Type Parameters

Name

Description

T

#### GetRandomItemFromList<T>(List<T>)

##### Declaration

```
public static T GetRandomItemFromList<T>(this List<T> list)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<T>

list

##### Returns

Type

Description

T

##### Type Parameters

Name

Description

T

#### GetRandomLong()

##### Declaration

```
public static long GetRandomLong()
```

##### Returns

Type

Description

System.Int64

#### GetRandomPerpendicularVector(in Vector3)

##### Declaration

```
public static Vector3 GetRandomPerpendicularVector(in Vector3 axis)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

axis

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetRandomPerpendicularVector(ref Vector3D)

##### Declaration

```
public static Vector3D GetRandomPerpendicularVector(ref Vector3D axis)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

axis

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetRandomPosition(ref BoundingBox)

##### Declaration

```
public static Vector3 GetRandomPosition(ref BoundingBox box)
```

##### Parameters

Type

Name

Description

[BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html)

box

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetRandomPosition(ref BoundingBoxD)

##### Declaration

```
public static Vector3D GetRandomPosition(ref BoundingBoxD box)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

box

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetRandomRadian()

##### Declaration

```
public static float GetRandomRadian()
```

##### Returns

Type

Description

System.Single

#### GetRandomSign()

##### Declaration

```
public static float GetRandomSign()
```

##### Returns

Type

Description

System.Single

#### GetRandomTimeSpan(TimeSpan, TimeSpan)

Returns a random TimeSpan between begin (inclusive) and end (exclusive).

##### Declaration

```
public static TimeSpan GetRandomTimeSpan(TimeSpan begin, TimeSpan end)
```

##### Parameters

Type

Name

Description

System.TimeSpan

begin

System.TimeSpan

end

##### Returns

Type

Description

System.TimeSpan

#### GetRandomVector3()

Returns a uniformly-distributed random vector from inside of a box (-1,-1,-1), (1, 1, 1)

##### Declaration

```
public static Vector3 GetRandomVector3()
```

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetRandomVector3CircleNormalized()

##### Declaration

```
public static Vector3 GetRandomVector3CircleNormalized()
```

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetRandomVector3D()

Returns a uniformly-distributed random vector from inside of a box (-1,-1,-1), (1, 1, 1)

##### Declaration

```
public static Vector3D GetRandomVector3D()
```

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetRandomVector3HemisphereNormalized(Vector3)

##### Declaration

```
public static Vector3 GetRandomVector3HemisphereNormalized(Vector3 normal)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

normal

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetRandomVector3MaxAngle(Single)

##### Declaration

```
public static Vector3 GetRandomVector3MaxAngle(float maxAngle)
```

##### Parameters

Type

Name

Description

System.Single

maxAngle

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetRandomVector3Normalized()

##### Declaration

```
public static Vector3 GetRandomVector3Normalized()
```

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetSmallestDistanceToSphere(ref Vector3D, ref BoundingSphereD)

Calculates distance from point 'from' to boundary of 'sphere'. If point is inside the sphere, distance will be negative.

##### Declaration

```
public static double GetSmallestDistanceToSphere(ref Vector3D from, ref BoundingSphereD sphere)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

from

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

##### Returns

Type

Description

System.Double

#### GetSmallestDistanceToSphereAlwaysPositive(ref Vector3D, ref BoundingSphereD)
