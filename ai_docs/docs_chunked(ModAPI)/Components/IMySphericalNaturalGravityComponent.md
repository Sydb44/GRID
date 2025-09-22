---
title: "Interface IMySphericalNaturalGravityComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySphericalNaturalGravityComponent.html"
category: "Components"
namespace: "VRage.Game.ModAPI"
class: "IMySphericalNaturalGravityComponent"
---

# Interface IMySphericalNaturalGravityComponent | Space Engineers ModAPI

Describes spherical natural gravity provider

##### Inherited Members

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMySphericalNaturalGravityComponent : IMyNaturalGravityComponent
```

### Properties

#### Falloff

Gravity falloff between minRadius and maxRadius

##### Declaration

```
double Falloff { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### Intensity

Gravity strength

##### Declaration

```
double Intensity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### MaxRadius

Max gravity radius at lowest intensity

##### Declaration

```
double MaxRadius { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### MinRadius

Minimum gravity radius before gravity intensity begins to decrease

##### Declaration

```
double MinRadius { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |