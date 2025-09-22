Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

m

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

normalized

#### Normalize(Vector3)

Protected normalize with assert

##### Declaration

```
public static Vector3 Normalize(Vector3 vec)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vec

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Normalize(ref Vector3, out Vector3)

Protected normalize with assert

##### Declaration

```
public static void Normalize(ref Vector3 vec, out Vector3 normalized)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vec

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

normalized

#### Normalize(Vector3D)

##### Declaration

```
public static Vector3D Normalize(Vector3D vec)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vec

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Normalize(ref Vector3D, out Vector3D)

##### Declaration

```
public static void Normalize(ref Vector3D vec, out Vector3D normalized)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vec

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

normalized

#### PrepareCollection<TCollection, TElement>(ref TCollection)

##### Declaration

```
public static TCollection PrepareCollection<TCollection, TElement>(ref TCollection collection)
    where TCollection : class, ICollection<TElement>, new()
```

##### Parameters

Type

Name

Description

TCollection

collection

##### Returns

Type

Description

TCollection

##### Type Parameters

Name

Description

TCollection

TElement

#### ReuseCollection<TElement>(ref HashSet<TElement>)

##### Declaration

```
public static MyUtils.ClearCollectionToken<HashSet<TElement>, TElement> ReuseCollection<TElement>(ref HashSet<TElement> collection)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.HashSet<TElement>

collection

##### Returns

Type

Description

[MyUtils.ClearCollectionToken](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyUtils.ClearCollectionToken-2.html)<System.Collections.Generic.HashSet<TElement>, TElement>

##### Type Parameters

Name

Description

TElement

#### ReuseCollection<TElement>(ref List<TElement>)

##### Declaration

```
public static MyUtils.ClearCollectionToken<List<TElement>, TElement> ReuseCollection<TElement>(ref List<TElement> collection)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<TElement>

collection

##### Returns

Type

Description

[MyUtils.ClearCollectionToken](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyUtils.ClearCollectionToken-2.html)<System.Collections.Generic.List<TElement>, TElement>

##### Type Parameters

Name

Description

TElement

#### ReuseCollection<TElement>(ref MyList<TElement>)

##### Declaration

```
public static MyUtils.ClearCollectionToken<MyList<TElement>, TElement> ReuseCollection<TElement>(ref MyList<TElement> collection)
```

##### Parameters

Type

Name

Description

VRage.Library.Collections.MyList<TElement>

collection

##### Returns

Type

Description

[MyUtils.ClearCollectionToken](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyUtils.ClearCollectionToken-2.html)<VRage.Library.Collections.MyList<TElement>, TElement>

##### Type Parameters

Name

Description

TElement

#### ReuseCollection<TCollection, TElement>(ref TCollection)

##### Declaration

```
public static MyUtils.ClearCollectionToken<TCollection, TElement> ReuseCollection<TCollection, TElement>(ref TCollection collection)
    where TCollection : class, ICollection<TElement>, new()
```

##### Parameters

Type

Name

Description

TCollection

collection

##### Returns

Type

Description

[MyUtils.ClearCollectionToken](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyUtils.ClearCollectionToken-2.html)<TCollection, TElement>

##### Type Parameters

Name

Description

TCollection

TElement

#### ReuseCollection<TKey, TValue>(ref Dictionary<TKey, TValue>)

##### Declaration

```
public static MyUtils.ClearCollectionToken<Dictionary<TKey, TValue>, KeyValuePair<TKey, TValue>> ReuseCollection<TKey, TValue>(ref Dictionary<TKey, TValue> collection)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.Dictionary<TKey, TValue>

collection

##### Returns

Type

Description

[MyUtils.ClearCollectionToken](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyUtils.ClearCollectionToken-2.html)<System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.Generic.KeyValuePair<TKey, TValue>>

##### Type Parameters

Name

Description

TKey

TValue

#### ReuseCollectionNested<TElement>(ref List<TElement>)

##### Declaration

```
public static MyUtils.ClearRangeToken<TElement> ReuseCollectionNested<TElement>(ref List<TElement> collection)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<TElement>

collection

##### Returns

Type

Description

[MyUtils.ClearRangeToken](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyUtils.ClearRangeToken-1.html)<TElement>

##### Type Parameters

Name

Description

TElement

#### RotationMatrixToYawPitchRoll(ref Matrix, out Single, out Single, out Single)

##### Declaration

```
public static void RotationMatrixToYawPitchRoll(ref Matrix mx, out float yaw, out float pitch, out float roll)
```
