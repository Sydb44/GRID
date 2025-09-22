---
title: "Interface IMyConfig"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyConfig.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyConfig"
---

# Interface IMyConfig | Space Engineers ModAPI

This interface provides access to game settings

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyConfig
```

### Properties

#### AmbientOcclusionEnabled

Gets if ambient occlusion is enabled

##### Declaration

```
Nullable<bool> AmbientOcclusionEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Boolean\> |     |

#### AnisotropicFiltering

Gets anisotropic filtering

##### Declaration

```
Nullable<MyTextureAnisoFiltering> AnisotropicFiltering { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<VRageRender.MyTextureAnisoFiltering\> |     |

#### AntialiasingMode

Gets anti aliasing mode

##### Declaration

```
Nullable<MyAntialiasingMode> AntialiasingMode { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<VRageRender.MyAntialiasingMode\> |     |

#### CaptureMouse

Gets whether mouse should be captured by game screenshot

##### Declaration

```
bool CaptureMouse { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ControlsButtons

##### Declaration

```
DictionaryReader<string, object> ControlsButtons { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<System.String, System.Object\> |     |

#### ControlsGeneral

##### Declaration

```
DictionaryReader<string, object> ControlsGeneral { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<System.String, System.Object\> |     |

#### ControlsHints

Gets whether games should show controls hints

##### Declaration

```
bool ControlsHints { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CubeBuilderBuildingMode

SingleBlock - 0 Line - 1 Plane - 2

##### Declaration

```
int CubeBuilderBuildingMode { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### CubeBuilderUseSymmetry

Gets whether cube builder should use symmetry

##### Declaration

```
bool CubeBuilderUseSymmetry { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnableDamageEffects

Gets whether damage effects are enabled

##### Declaration

```
bool EnableDamageEffects { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnableDynamicMusic

Gets dynamic music is enabled

##### Declaration

```
bool EnableDynamicMusic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnableMuteWhenNotInFocus

Gets whether should mute sound when game window is not in focus

##### Declaration

```
bool EnableMuteWhenNotInFocus { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnablePerformanceWarnings

Gets whether should show performance warning

##### Declaration

```
bool EnablePerformanceWarnings { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnableReverb

Gets whether reverb sound feature is enabled

##### Declaration

```
bool EnableReverb { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnableTrading

Gets grass draw distance

##### Declaration

```
bool EnableTrading { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnableVoiceChat

Gets whether voice chat is enabled

##### Declaration

```
bool EnableVoiceChat { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FieldOfView

Gets game field of view setting

##### Declaration

```
float FieldOfView { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FirstTimeRun

Gets if game is run at first time

##### Declaration

```
bool FirstTimeRun { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FlaresIntensity

Gets flares intensity graphics feature

##### Declaration

```
float FlaresIntensity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GameVolume

Gets game master volume

##### Declaration

```
float GameVolume { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GraphicsRenderer

Gets graphics renderer setting

##### Declaration

```
MyGraphicsRenderer GraphicsRenderer { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRageRender.MyGraphicsRenderer |     |

#### GrassDensityFactor

Gets grass density factor

##### Declaration

```
Nullable<float> GrassDensityFactor { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### GrassDrawDistance

Gets grass draw distance

##### Declaration

```
Nullable<float> GrassDrawDistance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### HUDBkOpacity

Gets HUD Background Opacity

##### Declaration

```
float HUDBkOpacity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### HudState

Gets hud state: 0 - hidden 1 - visible with descriptions 2 - visible without descriptions
