| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World coordinates |
| [MyObjectBuilder\_WeatherEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_WeatherEffect.html) | weatherEffect | Object builder of exact weather |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Wind multiplier |

#### RemoveWeather(MyObjectBuilder\_WeatherEffect)

Removes weather by its object builder

##### Declaration

```
void RemoveWeather(MyObjectBuilder_WeatherEffect weatherEffect)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_WeatherEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_WeatherEffect.html) | weatherEffect |     |

#### RemoveWeather(Vector3D)

Removes weather at specific location

##### Declaration

```
bool RemoveWeather(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World position |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if removed weather |

#### SetWeather(String, Single, Nullable<Vector3D>, Boolean, Vector3D, Int32, Single)

Sets weather

##### Declaration

```
bool SetWeather(string weatherEffect, float radius, Nullable<Vector3D> weatherPosition, bool verbose, Vector3D velocity, int length = 0, float intensity = 1F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | weatherEffect | SubtypeName of weather |
| System.Single | radius | Radius of weather |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | weatherPosition | World position of weather center |
| System.Boolean | verbose | When true, errors would be typing into the chat |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | velocity | Velocity of weather effect |
| System.Int32 | length | Duration of weather effect |
| System.Single | intensity | Intensity of weather effect |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True when weather was created |