#### Intersects(BoundingFrustumD)

##### Declaration

```
public bool Intersects(BoundingFrustumD frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingSphereD)

##### Declaration

```
public bool Intersects(ref BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref LineD)

##### Declaration

```
public Nullable<double> Intersects(ref LineD line)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Double\> |     |

#### Intersects(ref MyOrientedBoundingBoxD)

##### Declaration

```
public bool Intersects(ref MyOrientedBoundingBoxD other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref PlaneD)

##### Declaration

```
public PlaneIntersectionType Intersects(ref PlaneD plane)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | plane |     |

##### Returns

| Type | Description |
| --- | --- |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) |     |

#### Intersects(ref RayD)

##### Declaration

```
public Nullable<double> Intersects(ref RayD ray)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html) | ray |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Double\> |     |

#### IntersectsOrContains(ref LineD)

##### Declaration

```
public Nullable<double> IntersectsOrContains(ref LineD line)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Double\> |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Transform(Single, Quaternion, Vector3D)

##### Declaration

```
public MyOrientedBoundingBoxD Transform(float scale, Quaternion rotation, Vector3D translation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | scale |     |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | rotation |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | translation |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) |     |

#### Transform(MatrixD)

##### Declaration

```
public void Transform(MatrixD matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix |     |

#### Transform(ref MatrixD)

##### Declaration

```
public void Transform(ref MatrixD matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix |     |

#### Transform(Quaternion, Vector3D)

##### Declaration

```
public MyOrientedBoundingBoxD Transform(Quaternion rotation, Vector3D translation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | rotation |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | translation |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) |     |

### Operators

#### Equality(MyOrientedBoundingBoxD, MyOrientedBoundingBoxD)

##### Declaration

```
public static bool operator ==(MyOrientedBoundingBoxD a, MyOrientedBoundingBoxD b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) | a   |     |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Inequality(MyOrientedBoundingBoxD, MyOrientedBoundingBoxD)

##### Declaration

```
public static bool operator !=(MyOrientedBoundingBoxD a, MyOrientedBoundingBoxD b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) | a   |     |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) | b   |     |
