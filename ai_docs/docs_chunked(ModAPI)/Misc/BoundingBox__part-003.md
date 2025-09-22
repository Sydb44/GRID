| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> | points | A list of points the BoundingBox should contain. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### CreateFromSphere(BoundingSphere)

Creates the smallest BoundingBox that will contain the specified BoundingSphere.

##### Declaration

```
public static BoundingBox CreateFromSphere(BoundingSphere sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to contain. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### CreateFromSphere(ref BoundingSphere, out BoundingBox)

Creates the smallest BoundingBox that will contain the specified BoundingSphere.

##### Declaration

```
public static void CreateFromSphere(ref BoundingSphere sphere, out BoundingBox result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to contain. |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | result | \[OutAttribute\] The created BoundingBox. |

#### CreateInvalid()

##### Declaration

```
public static BoundingBox CreateInvalid()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### CreateMerged(BoundingBox, BoundingBox)

Creates the smallest BoundingBox that contains the two specified BoundingBox instances.

##### Declaration

```
public static BoundingBox CreateMerged(BoundingBox original, BoundingBox additional)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | original | One of the BoundingBoxs to contain. |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | additional | One of the BoundingBoxs to contain. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### CreateMerged(ref BoundingBox, ref BoundingBox, out BoundingBox)

Creates the smallest BoundingBox that contains the two specified BoundingBox instances.

##### Declaration

```
public static void CreateMerged(ref BoundingBox original, ref BoundingBox additional, out BoundingBox result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | original | One of the BoundingBox instances to contain. |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | additional | One of the BoundingBox instances to contain. |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | result | \[OutAttribute\] The created BoundingBox. |

#### Distance(Vector3)

##### Declaration

```
public float Distance(Vector3 point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### DistanceSquared(Vector3)

##### Declaration

```
public float DistanceSquared(Vector3 point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Equals(Object)

Determines whether two instances of BoundingBox are equal.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | The Object to compare with the current BoundingBox. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(BoundingBox)

Determines whether two instances of BoundingBox are equal.

##### Declaration

```
public bool Equals(BoundingBox other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | other | The BoundingBox to compare with the current BoundingBox. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(BoundingBox, Single)

##### Declaration

```
public bool Equals(BoundingBox other, float epsilon)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | other |     |
| System.Single | epsilon |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetCorners()

Gets an array of points that make up the corners of the BoundingBox. ALLOCATION!

##### Declaration

```
public Vector3[] GetCorners()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] |     |

#### GetCorners(Vector3\[\])

Gets the array of points that make up the corners of the BoundingBox.

##### Declaration

```
public void GetCorners(Vector3[] corners)
```
