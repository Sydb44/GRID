```

##### Parameters

Type

Name

Description

System.Int32

value

##### Returns

Type

Description

System.Int32

#### Log2Floor(Int32)

##### Declaration

```
public static int Log2Floor(int value)
```

##### Parameters

Type

Name

Description

System.Int32

value

##### Returns

Type

Description

System.Int32

#### Max(Double, Double)

Returns the greater of two values.

##### Declaration

```
public static double Max(double value1, double value2)
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

##### Returns

Type

Description

System.Double

#### Max(Double, Double, Double)

##### Declaration

```
public static double Max(double a, double b, double c)
```

##### Parameters

Type

Name

Description

System.Double

a

System.Double

b

System.Double

c

##### Returns

Type

Description

System.Double

#### Max(Int32, Int32, Int32)

##### Declaration

```
public static int Max(int a, int b, int c)
```

##### Parameters

Type

Name

Description

System.Int32

a

System.Int32

b

System.Int32

c

##### Returns

Type

Description

System.Int32

#### Max(Single, Single)

Returns the greater of two values.

##### Declaration

```
public static float Max(float value1, float value2)
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

##### Returns

Type

Description

System.Single

#### Max(Single, Single, Single)

##### Declaration

```
public static float Max(float a, float b, float c)
```

##### Parameters

Type

Name

Description

System.Single

a

System.Single

b

System.Single

c

##### Returns

Type

Description

System.Single

#### Min(Double, Double)

Returns the lesser of two values.

##### Declaration

```
public static double Min(double value1, double value2)
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

##### Returns

Type

Description

System.Double

#### Min(Double, Double, Double)

##### Declaration

```
public static double Min(double a, double b, double c)
```

##### Parameters

Type

Name

Description

System.Double

a

System.Double

b

System.Double

c

##### Returns

Type

Description

System.Double

#### Min(Single, Single)

Returns the lesser of two values.

##### Declaration

```
public static float Min(float value1, float value2)
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

##### Returns

Type

Description

System.Single

#### Min(Single, Single, Single)

##### Declaration

```
public static float Min(float a, float b, float c)
```

##### Parameters

Type

Name

Description

System.Single

a

System.Single

b

System.Single

c

##### Returns

Type

Description

System.Single

#### MonotonicAcos(Single)

##### Declaration

```
public static float MonotonicAcos(float cos)
```

##### Parameters

Type

Name

Description

System.Single

cos

##### Returns

Type

Description

System.Single

#### MonotonicCosine(Single)

Calculate the monotonic cosine of a value.

Monotonic cosine is an alternative cosine encoding that is monotonic in the \[-pi, pi\] interval. We use this when some parameter of an onject in a planet is constrained by latitude.

The 'monotonicity' is guaranteed by subtracting the cosine value from 2 if the angle is positive. So for instance MonotonicCos(pi/2) = 2.

This only works in the above interval of course.

##### Declaration

```
public static float MonotonicCosine(float radians)
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

The cosine of the angle if it is > 0, 2 - that value otherwise.

#### Pow2(Int32)

Returns 2^n

##### Declaration

```
public static int Pow2(int n)
```

##### Parameters

Type

Name

Description

System.Int32

n

##### Returns

Type

Description

System.Int32

#### RoundOn2(Single)

##### Declaration

```
public static float RoundOn2(float x)
```

##### Parameters

Type

Name

Description

System.Single

x

##### Returns

Type

Description

System.Single

#### RoundToInt(Double)

##### Declaration

```
public static int RoundToInt(double x)
```

##### Parameters

Type

Name

Description

System.Double

x

##### Returns

Type

Description

System.Int32

#### RoundToInt(Single)

##### Declaration

```
public static int RoundToInt(float x)
```

##### Parameters

Type

Name

Description

System.Single

x

##### Returns

Type

Description

System.Int32

#### Saturate(Double)

##### Declaration

```
public static double Saturate(double n)
```

##### Parameters

Type

Name

Description

System.Double

n

##### Returns

Type

Description

System.Double

#### Saturate(Single)

##### Declaration

```
public static float Saturate(float n)
```

##### Parameters

Type

Name

Description

System.Single

n

##### Returns

Type

Description

System.Single

#### SCurve3(Double)

##### Declaration

```
public static double SCurve3(double t)
```

##### Parameters

Type

Name

Description

System.Double

t

##### Returns

Type

Description

System.Double

#### SCurve3(Single)

##### Declaration

```
public static float SCurve3(float t)
```

##### Parameters

Type

Name

Description

System.Single

t

##### Returns

Type

Description

System.Single

#### SCurve5(Double)

##### Declaration

```
public static double SCurve5(double t)
```

##### Parameters

Type

Name

Description

System.Double

t

##### Returns

Type

Description

System.Double

#### SCurve5(Single)

##### Declaration

```
public static float SCurve5(float t)
```

##### Parameters

Type

Name

Description

System.Single

t

##### Returns

Type

Description

System.Single

#### Smooth(Int32, Int32)

##### Declaration

```
public static int Smooth(int newValue, int lastSmooth)
```

##### Parameters

Type

Name

Description

System.Int32

newValue

System.Int32

lastSmooth

##### Returns

Type

Description

System.Int32
