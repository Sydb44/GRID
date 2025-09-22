---
title: "Class MyGameDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyGameDefinition.html"
category: "Misc"
namespace: "VRage.Game.Definitions"
class: "MyGameDefinition"
---

# Class MyGameDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyGameDefinition

##### Inherited Members

###### **Namespace**: [VRage.Game.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyGameDefinition : MyDefinitionBase
```

### Constructors

#### MyGameDefinition()

##### Declaration

```
public MyGameDefinition()
```

### Fields

#### Default

##### Declaration

```
public static readonly MyDefinitionId Default
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### DefaultDefinition

##### Declaration

```
public static readonly MyGameDefinition DefaultDefinition
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyGameDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyGameDefinition.html) |     |

#### ExplosionAmmoVolumeMax

##### Declaration

```
public float ExplosionAmmoVolumeMax
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ExplosionAmmoVolumeMin

##### Declaration

```
public float ExplosionAmmoVolumeMin
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ExplosionDamageMax

##### Declaration

```
public float ExplosionDamageMax
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ExplosionDamagePerLiter

##### Declaration

```
public float ExplosionDamagePerLiter
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ExplosionRadiusMax

##### Declaration

```
public float ExplosionRadiusMax
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ExplosionRadiusMin

##### Declaration

```
public float ExplosionRadiusMin
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RandomColorsForPrefabSpawn

##### Declaration

```
public List<ColorDefinitionRGBA> RandomColorsForPrefabSpawn
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[ColorDefinitionRGBA](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ColorDefinitionRGBA.html)\> |     |

#### SessionComponents

##### Declaration

```
public Dictionary<string, Nullable<MyDefinitionId>> SessionComponents
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\>> |     |

### Methods

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Overrides