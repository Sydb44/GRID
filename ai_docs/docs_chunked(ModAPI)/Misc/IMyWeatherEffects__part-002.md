| Type | Description |
| --- | --- |
| System.Single | Solar multiplier |

#### GetSolarMultiplier(Vector3D, MyObjectBuilder\_WeatherEffect)

Gets weather solar multiplier in point for provided weather

##### Declaration

```
float GetSolarMultiplier(Vector3D position, MyObjectBuilder_WeatherEffect weatherEffect)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World coordinates |
| [MyObjectBuilder\_WeatherEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_WeatherEffect.html) | weatherEffect | Object builder of exact weather |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Solar multiplier |

#### GetTemperatureMultiplier(Vector3D)

Gets weather temperature multiplier in point for provided weather

##### Declaration

```
float GetTemperatureMultiplier(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Temperature multiplier |

#### GetTemperatureMultiplier(Vector3D, MyObjectBuilder\_WeatherEffect)

Gets weather temperature multiplier in point for provided weather

##### Declaration

```
float GetTemperatureMultiplier(Vector3D position, MyObjectBuilder_WeatherEffect weatherEffect)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World coordinates |
| [MyObjectBuilder\_WeatherEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_WeatherEffect.html) | weatherEffect | Object builder of exact weather |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Temperature multiplier |

#### GetWeather(Vector3D)

Gets weather name at provided position

##### Declaration

```
string GetWeather(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World position |

##### Returns

| Type | Description |
| --- | --- |
| System.String | SubtypeName of weather |

#### GetWeather(Vector3D, out MyObjectBuilder\_WeatherEffect)

Gets object builder of weather at provided position

##### Declaration

```
bool GetWeather(Vector3D position, out MyObjectBuilder_WeatherEffect weatherEffect)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World position |
| [MyObjectBuilder\_WeatherEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_WeatherEffect.html) | weatherEffect | Object builder |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True there is weather in that point |

#### GetWeatherIntensity(Vector3D)

Gets weather intensity at world coordinates

##### Declaration

```
float GetWeatherIntensity(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Weather intensity |

#### GetWeatherIntensity(Vector3D, MyObjectBuilder\_WeatherEffect)

Gets weather intensity in point for provided weather

##### Declaration

```
float GetWeatherIntensity(Vector3D position, MyObjectBuilder_WeatherEffect weatherEffect)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World coordinates |
| [MyObjectBuilder\_WeatherEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_WeatherEffect.html) | weatherEffect | Object builder of exact weather |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Weather intensity |

#### GetWeatherPlanetData()

Gets list (not a copy) of all weathers that are currently running

##### Declaration

```
List<MyObjectBuilder_WeatherPlanetData> GetWeatherPlanetData()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_WeatherPlanetData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_WeatherPlanetData.html)\> | List of weathers |

#### GetWindMultiplier(Vector3D)

Gets weather temperature multiplier in point for provided weather

##### Declaration

```
float GetWindMultiplier(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Wind multiplier |

#### GetWindMultiplier(Vector3D, MyObjectBuilder\_WeatherEffect)

Gets weather solar multiplier in point for provided weather

##### Declaration

```
float GetWindMultiplier(Vector3D position, MyObjectBuilder_WeatherEffect weatherEffect)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World coordinates |
| [MyObjectBuilder\_WeatherEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_WeatherEffect.html) | weatherEffect | Object builder of exact weather |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Wind multiplier |

#### RemoveWeather(MyObjectBuilder\_WeatherEffect)

Removes weather by its object builder
