A four-component color.

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

value2

A four-component color.

System.Single

amount

Interpolation factor.

##### Returns

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Lighten(Color, Double)

##### Declaration

```
public static Color Lighten(Color inColor, double inAmount)
```

##### Parameters

Type

Name

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

inColor

System.Double

inAmount

##### Returns

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Multiply(Color, Single)

Multiply each color component by the scale factor.

##### Declaration

```
public static Color Multiply(Color value, float scale)
```

##### Parameters

Type

Name

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

value

The source, four-component color.

System.Single

scale

The scale factor.

##### Returns

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### ToGray()

##### Declaration

##### Returns

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### ToString()

Gets a string representation of this object.

##### Declaration

```
public override string ToString()
```

##### Returns

Type

Description

System.String

#### ToVector3()

Gets a three-component vector representation for this object.

##### Declaration

```
public Vector3 ToVector3()
```

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### ToVector4()

Gets a four-component vector representation for this object.

##### Declaration

```
public Vector4 ToVector4()
```

##### Returns

Type

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

### Operators

#### Addition(Color, Color)

##### Declaration

```
public static Color operator +(Color value, Color other)
```

##### Parameters

Type

Name

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

value

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

other

##### Returns

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Equality(Color, Color)

Equality operator.

##### Declaration

```
public static bool operator ==(Color a, Color b)
```

##### Parameters

Type

Name

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

a

A four-component color.

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

b

A four-component color.

##### Returns

Type

Description

System.Boolean

#### Implicit(Color to Vector3)

##### Declaration

```
public static implicit operator Vector3(Color v)
```

##### Parameters

Type

Name

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

v

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Implicit(Color to Vector4)

##### Declaration

```
public static implicit operator Vector4(Color v)
```

##### Parameters

Type

Name

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

v

##### Returns

Type

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

#### Implicit(Vector3 to Color)

##### Declaration

```
public static implicit operator Color(Vector3 v)
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

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Implicit(Vector4 to Color)

##### Declaration

```
public static implicit operator Color(Vector4 v)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

v

##### Returns

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Inequality(Color, Color)

Equality operator for Testing two color objects to see if they are equal.

##### Declaration

```
public static bool operator !=(Color a, Color b)
```

##### Parameters

Type

Name

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

a

A four-component color.

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

b

A four-component color.

##### Returns

Type

Description

System.Boolean

#### Multiply(Color, Single)

Multiply operator.

##### Declaration

```
public static Color operator *(Color value, float scale)
```

##### Parameters

Type

Name

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

value

A four-component color

System.Single

scale

Scale factor.

##### Returns

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Multiply(Color, Color)

Multiply operator.

##### Declaration

```
public static Color operator *(Color value, Color other)
```

##### Parameters

Type

Name

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

value

A four-component color

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

other

Multiplied color.

##### Returns

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)
