---
title: "Interface IMyLightingComponentDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Lights.IMyLightingComponentDefinition.html"
category: "Components"
namespace: "Sandbox.Game.Lights"
class: "IMyLightingComponentDefinition"
---

# Interface IMyLightingComponentDefinition | Space Engineers ModAPI

Definition interface used for instantiation of MyLightingLogic.

###### **Namespace**: [Sandbox.Game.Lights](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Lights.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyLightingComponentDefinition
```

### Properties

#### BlinkIntervalSeconds

##### Declaration

```
MyBounds BlinkIntervalSeconds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### BlinkLength

##### Declaration

```
MyBounds BlinkLength { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### BlinkOffset

##### Declaration

```
MyBounds BlinkOffset { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### Flare

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### LightDummyName

##### Declaration

```
string LightDummyName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### LightFalloff

##### Declaration

```
MyBounds LightFalloff { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### LightIntensity

##### Declaration

```
MyBounds LightIntensity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### LightOffset

##### Declaration

```
MyBounds LightOffset { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### LightOnlyNoEffectsDummyName

##### Declaration

```
string LightOnlyNoEffectsDummyName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### LightRadius

##### Declaration

```
MyBounds LightRadius { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### LightReflectorRadius

##### Declaration

```
MyBounds LightReflectorRadius { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyBounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBounds.html) |     |

#### PointLightEmissiveMaterial

##### Declaration

```
string PointLightEmissiveMaterial { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### SpotLightEmissiveMaterial

##### Declaration

```
string SpotLightEmissiveMaterial { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |