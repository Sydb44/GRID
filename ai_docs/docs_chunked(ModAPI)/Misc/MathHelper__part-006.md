newValue

System.Int32

lastSmooth

##### Returns

Type

Description

System.Int32

#### Smooth(Single, Single)

##### Declaration

```
public static float Smooth(float newValue, float lastSmooth)
```

##### Parameters

Type

Name

Description

System.Single

newValue

System.Single

lastSmooth

##### Returns

Type

Description

System.Single

#### SmoothStep(Double, Double, Double)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static double SmoothStep(double value1, double value2, double amount)
```

##### Parameters

Type

Name

Description

System.Double

value1

Source value.

System.Double

value2

Source value.

System.Double

amount

Weighting value.

##### Returns

Type

Description

System.Double

#### SmoothStep(Single, Single, Single)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static float SmoothStep(float value1, float value2, float amount)
```

##### Parameters

Type

Name

Description

System.Single

value1

Source value.

System.Single

value2

Source value.

System.Single

amount

Weighting value.

##### Returns

Type

Description

System.Single

#### SmoothStepStable(Double)

Interpolates between zero and one using cubic equiation, solved by de Casteljau.

##### Declaration

```
public static double SmoothStepStable(double amount)
```

##### Parameters

Type

Name

Description

System.Double

amount

Weighting value \[0..1\].

##### Returns

Type

Description

System.Double

#### SmoothStepStable(Single)

Interpolates between zero and one using cubic equiation, solved by de Casteljau.

##### Declaration

```
public static float SmoothStepStable(float amount)
```

##### Parameters

Type

Name

Description

System.Single

amount

Weighting value \[0..1\].

##### Returns

Type

Description

System.Single

#### ToDegrees(Double)

##### Declaration

```
public static double ToDegrees(double radians)
```

##### Parameters

Type

Name

Description

System.Double

radians

##### Returns

Type

Description

System.Double

#### ToDegrees(Single)

Converts radians to degrees.

##### Declaration

```
public static float ToDegrees(float radians)
```

##### Parameters

Type

Name

Description

System.Single

radians

The angle in radians.

##### Returns

Type

Description

System.Single

#### ToRadians(Double)

Converts degrees to radians.

##### Declaration

```
public static double ToRadians(double degrees)
```

##### Parameters

Type

Name

Description

System.Double

degrees

The angle in degrees.

##### Returns

Type

Description

System.Double

#### ToRadians(Single)

Converts degrees to radians.

##### Declaration

```
public static float ToRadians(float degrees)
```

##### Parameters

Type

Name

Description

System.Single

degrees

The angle in degrees.

##### Returns

Type

Description

System.Single

#### ToRadians(Vector3)

##### Declaration

```
public static Vector3 ToRadians(Vector3 v)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### WrapAngle(Single)

Reduces a given angle to a value between π and -π.

##### Declaration

```
public static float WrapAngle(float angle)
```

##### Parameters

Type

Name

Description

System.Single

angle

The angle to reduce, in radians.

##### Returns

Type

Description

System.Single