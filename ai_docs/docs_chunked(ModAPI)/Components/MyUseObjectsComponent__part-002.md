
```
public override void ProcessComponentToUseObjectsAndDistances(ref Dictionary<IMyUseObject, Tuple<float, object>> output, Vector3D from, Vector3 dir, object hit)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<[IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html), System.Tuple<System.Single, System.Object\>> | output |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | dir |     |
| System.Object | hit |     |

##### Overrides

#### RaycastDetector(IMyUseObject, Vector3D, Vector3D, out Single)

##### Declaration

```
public override IMyUseObject RaycastDetector(IMyUseObject useObject, Vector3D worldFrom, Vector3D worldTo, out float parameter)
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

##### Overrides

#### RaycastDetectors(Vector3D, Vector3D, out Single)

##### Declaration

```
public override IMyUseObject RaycastDetectors(Vector3D worldFrom, Vector3D worldTo, out float parameter)
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

##### Overrides

#### RecreatePhysics()

##### Declaration

```
public override void RecreatePhysics()
```

##### Overrides

#### RemoveDetector(UInt32)

##### Declaration

```
public override void RemoveDetector(uint id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | id  |     |

##### Overrides

#### Serialize(Boolean)

##### Declaration

```
public override MyObjectBuilder_ComponentBase Serialize(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

##### Overrides

#### SetUseObjectIDs(UInt32, Int32)

##### Declaration

```
public void SetUseObjectIDs(uint renderId, int instanceId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | renderId |     |
| System.Int32 | instanceId |     |

### Extension Methods