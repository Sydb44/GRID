```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vctTranlsation

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

### Operators

#### Addition(BoundingBoxD, Vector3D)

##### Declaration

```
public static BoundingBoxD operator +(BoundingBoxD a, Vector3D b)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

a

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

b

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### Equality(BoundingBoxD, BoundingBoxD)

Determines whether two instances of BoundingBox are equal.

##### Declaration

```
public static bool operator ==(BoundingBoxD a, BoundingBoxD b)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

a

BoundingBox to compare.

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

b

BoundingBox to compare.

##### Returns

Type

Description

System.Boolean

#### Explicit(BoundingBoxD to BoundingBox)

##### Declaration

```
public static explicit operator BoundingBox(BoundingBoxD b)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

b

##### Returns

Type

Description

[BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html)

#### Implicit(BoundingBox to BoundingBoxD)

##### Declaration

```
public static implicit operator BoundingBoxD(BoundingBox box)
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

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### Implicit(BoundingBoxI to BoundingBoxD)

##### Declaration

```
public static implicit operator BoundingBoxD(BoundingBoxI box)
```

##### Parameters

Type

Name

Description

[BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html)

box

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### Inequality(BoundingBoxD, BoundingBoxD)

Determines whether two instances of BoundingBox are not equal.

##### Declaration

```
public static bool operator !=(BoundingBoxD a, BoundingBoxD b)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

a

The object to the left of the inequality operator.

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

b

The object to the right of the inequality operator.

##### Returns

Type

Description

System.Boolean