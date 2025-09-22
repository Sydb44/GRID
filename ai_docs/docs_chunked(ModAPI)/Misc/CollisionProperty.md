---
title: "Class MyPhysicalMaterialDefinition.CollisionProperty"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalMaterialDefinition.CollisionProperty.html"
category: "Misc"
namespace: "Sandbox.Definitions.MyPhysicalMaterialDefinition"
class: "CollisionProperty"
---

# Class MyPhysicalMaterialDefinition.CollisionProperty | Space Engineers ModAPI

##### Inheritance

System.Object

MyPhysicalMaterialDefinition.CollisionProperty

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class CollisionProperty : ValueType
```

### Constructors

#### CollisionProperty(String, String, List<AlternativeImpactSounds>, MyObjectBuilder\_MaterialPropertiesDefinition.EffectHitAngle)

##### Declaration

```
public CollisionProperty(string soundCue, string particleEffectName, List<AlternativeImpactSounds> impactsounds, MyObjectBuilder_MaterialPropertiesDefinition.EffectHitAngle effectHitAngle)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | soundCue |     |
| System.String | particleEffectName |     |
| System.Collections.Generic.List<[AlternativeImpactSounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.AlternativeImpactSounds.html)\> | impactsounds |     |
| [MyObjectBuilder\_MaterialPropertiesDefinition.EffectHitAngle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_MaterialPropertiesDefinition.EffectHitAngle.html) | effectHitAngle |     |

### Fields

#### EffectHitAngle

##### Declaration

```
public MyObjectBuilder_MaterialPropertiesDefinition.EffectHitAngle EffectHitAngle
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_MaterialPropertiesDefinition.EffectHitAngle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_MaterialPropertiesDefinition.EffectHitAngle.html) |     |

#### ImpactSoundCues

##### Declaration

```
public List<MyPhysicalMaterialDefinition.ImpactSounds> ImpactSoundCues
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyPhysicalMaterialDefinition.ImpactSounds](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalMaterialDefinition.ImpactSounds.html)\> |     |

#### ParticleEffect

##### Declaration

```
public string ParticleEffect
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Sound

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |