
```
public virtual void ProcessComponentToUseObjectsAndDistances(ref Dictionary<IMyUseObject, Tuple<float, object>> output, Vector3D from, Vector3 dir, object hit)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<[IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html), System.Tuple<System.Single, System.Object\>> | output |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | dir |     |
| System.Object | hit |     |

#### RaycastDetector(IMyUseObject, Vector3D, Vector3D, out Single)

##### Declaration

```
public abstract IMyUseObject RaycastDetector(IMyUseObject useObject, Vector3D worldFrom, Vector3D worldTo, out float parameter)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html) | useObject |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldFrom |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldTo |     |
| System.Single | parameter |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html) |     |

#### RaycastDetectors(Vector3D, Vector3D)

##### Declaration

```
public string RaycastDetectors(Vector3D worldFrom, Vector3D worldTo)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldFrom |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldTo |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### RaycastDetectors(Vector3D, Vector3D, out Single)

Determine whether the given ray intersects any detector. If so, returns the parametric value of the point of first intersection. PARAMATER IS NOT DISTANCE!

##### Declaration

```
public abstract IMyUseObject RaycastDetectors(Vector3D worldFrom, Vector3D worldTo, out float parameter)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldFrom |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldTo |     |
| System.Single | parameter |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html) |     |

#### RecreatePhysics()

##### Declaration

```
public abstract void RecreatePhysics()
```

#### RemoveDetector(UInt32)

##### Declaration

```
public abstract void RemoveDetector(uint id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | id  |     |

### Extension Methods