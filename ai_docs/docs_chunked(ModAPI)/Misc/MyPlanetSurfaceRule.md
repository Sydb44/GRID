---
title: "Class MyPlanetSurfaceRule"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyPlanetSurfaceRule.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyPlanetSurfaceRule"
---

# Class MyPlanetSurfaceRule | Space Engineers ModAPI

##### Inheritance

System.Object

MyPlanetSurfaceRule

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyPlanetSurfaceRule : Object, ICloneable
```

### Constructors

#### MyPlanetSurfaceRule()

##### Declaration

```
public MyPlanetSurfaceRule()
```

### Fields

#### Height

##### Declaration

```
public SerializableRange Height
```

##### Field Value

| Type | Description |
| --- | --- |
| [SerializableRange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.SerializableRange.html) |     |

#### Latitude

##### Declaration

```
public SymmetricSerializableRange Latitude
```

##### Field Value

| Type | Description |
| --- | --- |
| [SymmetricSerializableRange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.SymmetricSerializableRange.html) |     |

#### Longitude

##### Declaration

```
public SerializableRange Longitude
```

##### Field Value

| Type | Description |
| --- | --- |
| [SerializableRange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.SerializableRange.html) |     |

#### Slope

##### Declaration

```
public SerializableRange Slope
```

##### Field Value

| Type | Description |
| --- | --- |
| [SerializableRange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.SerializableRange.html) |     |

### Methods

#### Check(Single, Single, Single, Single)

##### Declaration

```
public bool Check(float height, float latitude, float longitude, float slope)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | height |     |
| System.Single | latitude |     |
| System.Single | longitude |     |
| System.Single | slope |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Clone()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Object |     |