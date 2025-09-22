
##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRageRender.MyBillboard | billboard |     |
| [MyQuadD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyQuadD.html) | quad |     |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | uvOffset |     |
| System.Int32 | customViewProjection |     |
| System.Single | reflectivity |     |

#### EndParticleProfilingBlock()

##### Declaration

```
public static void EndParticleProfilingBlock()
```

#### RemovePersistentBillboard(MyBillboard, Boolean)

##### Declaration

```
public static void RemovePersistentBillboard(MyBillboard billboard, bool immediate = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRageRender.MyBillboard | billboard | Billboard to remove |
| System.Boolean | immediate | When true, instantly removes (causes crash if you call it from render draw thread), when false adds to remove list first |

#### RemovePersistentBillboards(IEnumerable<MyBillboard>, Boolean)

Removes multiple persistent billboard from draw

##### Declaration

```
public static void RemovePersistentBillboards(IEnumerable<MyBillboard> billboards, bool immediate = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<VRageRender.MyBillboard\> | billboards | Billboards to remove |
| System.Boolean | immediate | When true, instantly removes (causes crash if you call it from render draw thread), when false adds to remove list first |

#### SetCamera(MyCamera)

##### Declaration

```
public static void SetCamera(MyCamera camera)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.Utils.MyCamera | camera |     |

#### StartParticleProfilingBlock(String)

##### Declaration

```
public static void StartParticleProfilingBlock(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |