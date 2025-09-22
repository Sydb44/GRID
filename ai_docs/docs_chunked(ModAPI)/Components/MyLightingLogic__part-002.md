#### IntensityBounds

##### Declaration

```
public MyBounds IntensityBounds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### IsEmissiveMaterialDirty

##### Declaration

```
public bool IsEmissiveMaterialDirty { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPositionDirty

##### Declaration

```
public bool IsPositionDirty { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPreview

##### Declaration

```
public bool IsPreview { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsReflector

##### Declaration

```
public bool IsReflector { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LightLocalDatas

##### Declaration

```
public List<MyLightingLogic.LightLocalData> LightLocalDatas { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyLightingLogic.LightLocalData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyLightingLogic.LightLocalData.html)\> |     |

#### Lights

##### Declaration

```
public List<MyLight> Lights { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyLight](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Lights.MyLight.html)\> |     |

#### NeedPerFrameUpdate

##### Declaration

```
public bool NeedPerFrameUpdate { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsRecreateLights

##### Declaration

```
public bool NeedsRecreateLights { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Offset

##### Declaration

```
public float Offset { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OffsetBounds

##### Declaration

```
public MyBounds OffsetBounds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### Radius

##### Declaration

```
public float Radius { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RadiusBounds

##### Declaration

```
public MyBounds RadiusBounds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### ReflectorConeDegrees

##### Declaration

```
public float ReflectorConeDegrees { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReflectorRadius

##### Declaration

```
public float ReflectorRadius { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReflectorRadiusBounds

##### Declaration

```
public MyBounds ReflectorRadiusBounds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

### Methods

#### CloseLights()

##### Declaration

```
public void CloseLights()
```

#### ComputeBulbColor()

##### Declaration

```
public Color ComputeBulbColor()
```

##### Returns

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### CreateLights()

##### Declaration

```
public void CreateLights()
```

#### Initialize()

This method must be called in the block's Init() after base.Init() to ensure proper initialization order.

##### Declaration

#### OnAddedToScene()

##### Declaration

```
public void OnAddedToScene()
```

#### OnModelChange()

##### Declaration

```
public void OnModelChange()
```

#### RecreateLights()

##### Declaration

```
public void RecreateLights()
```

#### UpdateAfterSimulation()

##### Declaration

```
public void UpdateAfterSimulation()
```

#### UpdateAfterSimulation(Vector3, MatrixD)

##### Declaration

```
public void UpdateAfterSimulation(Vector3 lightPosition, MatrixD lightRotation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | lightPosition |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | lightRotation |     |

#### UpdateEmissiveMaterial()

##### Declaration

```
public void UpdateEmissiveMaterial()
```

#### UpdateEnabled()

##### Declaration

```
public void UpdateEnabled()
```

#### UpdateLightBlink()

##### Declaration

```
public void UpdateLightBlink()
```

#### UpdateLightData()

##### Declaration

```
public void UpdateLightData()
```

#### UpdateLightPosition()

##### Declaration

```
public void UpdateLightPosition()
```

#### UpdateLightPosition(Vector3, MatrixD)

##### Declaration

```
public void UpdateLightPosition(Vector3 lightPosition, MatrixD lightRotation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | lightPosition |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | lightRotation |     |

#### UpdateLightProperties()

##### Declaration

```
public void UpdateLightProperties()
```

#### UpdateOnceBeforeFrame()

##### Declaration

```
public void UpdateOnceBeforeFrame()
```

#### UpdateParents()

##### Declaration

```
public void UpdateParents()
```

#### UpdateVisual()

##### Declaration

```
public void UpdateVisual()
```
