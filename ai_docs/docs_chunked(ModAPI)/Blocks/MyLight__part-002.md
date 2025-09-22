##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReflectorDiffuseFactor

##### Declaration

```
public float ReflectorDiffuseFactor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReflectorDirection

##### Declaration

```
public Vector3 ReflectorDirection { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### ReflectorFalloff

##### Declaration

```
public float ReflectorFalloff { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReflectorGlossFactor

##### Declaration

```
public float ReflectorGlossFactor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReflectorIntensity

Reflector parameters are also parameters for spot light

##### Declaration

```
public float ReflectorIntensity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReflectorOn

##### Declaration

```
public bool ReflectorOn { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ReflectorRange

##### Declaration

```
public float ReflectorRange { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReflectorTexture

##### Declaration

```
public string ReflectorTexture { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ReflectorUp

##### Declaration

```
public Vector3 ReflectorUp { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### RenderObjectID

##### Declaration

```
public uint RenderObjectID { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### SubGlares

##### Declaration

```
public MySubGlare[] SubGlares { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRageRender.Messages.MySubGlare\[\] |     |

### Methods

#### Clear()

Can be called only from MyLights.RemoveLight.

##### Declaration

#### MarkPositionDirty()

##### Declaration

```
public void MarkPositionDirty()
```

#### SpotlightNotTooLarge(Single, Single)

When setting Reflector properties, use this function to test whether properties are in bounds and light AABB is not too large. Properties which affects calculations are ReflectorRange and ReflectorConeMaxAngleCos (ReflectorConeDegrees, ReflectorConeRadians)

##### Declaration

```
public bool SpotlightNotTooLarge(float reflectorConeMaxAngleCos, float reflectorRange)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | reflectorConeMaxAngleCos |     |
| System.Single | reflectorRange |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Start(String)

IMPORTANT: This class isn't realy inicialized by constructor, but by Start()

##### Declaration

```
public void Start(string debugName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | debugName |     |

#### Start(Vector3D, Vector4, Single, String)

##### Declaration

```
public void Start(Vector3D position, Vector4 color, float range, string debugName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| System.Single | range |     |
| System.String | debugName |     |

#### Start(Vector4, Single, String)

##### Declaration

```
public void Start(Vector4 color, float range, string debugName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| System.Single | range |     |
| System.String | debugName |     |

#### UpdateLight()

##### Declaration

```
public void UpdateLight()
```

#### UpdateReflectorRangeAndAngle(Single, Single)

Use when setting both values and previous state of both value is undefined

##### Declaration

```
public void UpdateReflectorRangeAndAngle(float reflectorConeMaxAngleCos, float reflectorRange)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | reflectorConeMaxAngleCos |     |
| System.Single | reflectorRange |     |