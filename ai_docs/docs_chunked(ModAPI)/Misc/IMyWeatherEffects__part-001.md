---
title: "Interface IMyWeatherEffects"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyWeatherEffects.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyWeatherEffects"
---

# Interface IMyWeatherEffects | Space Engineers ModAPI

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyWeatherEffects
```

### Properties

#### FogAtmoOverride

Gets or sets sector's FogAtmo. When value is null, used default sector value

##### Declaration

```
Nullable<float> FogAtmoOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### FogColorOverride

Gets or sets sector's FogColor. When value is null, used default sector value

##### Declaration

```
Nullable<Vector3> FogColorOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### FogDensityOverride

Gets or sets sector's FogDensity. When value is null, used default sector value

##### Declaration

```
Nullable<float> FogDensityOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### FogMultiplierOverride

Gets or sets sector's FogMultiplier. When value is null, used default sector value

##### Declaration

```
Nullable<float> FogMultiplierOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### FogSkyboxOverride

Gets or sets sector's FogSkybox. When value is null, used default sector value

##### Declaration

```
Nullable<float> FogSkyboxOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### ParticleDirectionOverride

Gets or sets sector's ParticleDirection. When value is null, used default sector value

##### Declaration

```
Nullable<MatrixD> ParticleDirectionOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)\> |     |

#### ParticleVelocityOverride

Gets or sets sector's ParticleVelocity. When value is null, used default sector value

##### Declaration

```
Nullable<Vector3> ParticleVelocityOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### SunIntensityOverride

Gets or sets sector's SunIntensity. When value is null, used default sector value

##### Declaration

```
Nullable<float> SunIntensityOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

### Methods

#### CreateLightning(Vector3D, MyObjectBuilder\_WeatherLightning, Boolean)

Creates lightning

##### Declaration

```
void CreateLightning(Vector3D position, MyObjectBuilder_WeatherLightning lightning, bool doDamage = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World position. Side effect: changing [Position](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_WeatherLightning.html#VRage_Game_MyObjectBuilder_WeatherLightning_Position) |
| [MyObjectBuilder\_WeatherLightning](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_WeatherLightning.html) | lightning | Settings of lightning |
| System.Boolean | doDamage | When false - changing [ExplosionRadius](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_WeatherLightning.html#VRage_Game_MyObjectBuilder_WeatherLightning_ExplosionRadius) to zero |

#### GetOxygenMultiplier(Vector3D)

Gets weather oxygen multiplier at world coordinates

##### Declaration

```
float GetOxygenMultiplier(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Oxygen multiplier |

#### GetOxygenMultiplier(Vector3D, MyObjectBuilder\_WeatherEffect)

Gets weather oxygen multiplier in point for provided weather

##### Declaration

```
float GetOxygenMultiplier(Vector3D position, MyObjectBuilder_WeatherEffect weatherEffect)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World coordinates |
| [MyObjectBuilder\_WeatherEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_WeatherEffect.html) | weatherEffect | Object builder of exact weather |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Oxygen multiplier |

#### GetSolarMultiplier(Vector3D)

Gets solar multiplier at world coordinates

##### Declaration

```
float GetSolarMultiplier(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Solar multiplier |

#### GetSolarMultiplier(Vector3D, MyObjectBuilder\_WeatherEffect)

Gets weather solar multiplier in point for provided weather

##### Declaration

```
float GetSolarMultiplier(Vector3D position, MyObjectBuilder_WeatherEffect weatherEffect)
```
