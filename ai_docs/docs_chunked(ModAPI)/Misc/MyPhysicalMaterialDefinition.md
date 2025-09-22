---
title: "Class MyPhysicalMaterialDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalMaterialDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyPhysicalMaterialDefinition"
---

# Class MyPhysicalMaterialDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyPhysicalMaterialDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyPhysicalMaterialDefinition : MyDefinitionBase
```

### Constructors

#### MyPhysicalMaterialDefinition()

##### Declaration

```
public MyPhysicalMaterialDefinition()
```

### Fields

#### CollisionMultiplier

##### Declaration

```
public float CollisionMultiplier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CollisionProperties

##### Declaration

```
public Dictionary<MyStringId, Dictionary<MyStringHash, MyPhysicalMaterialDefinition.CollisionProperty>> CollisionProperties
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html), System.Collections.Generic.Dictionary<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html), [MyPhysicalMaterialDefinition.CollisionProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalMaterialDefinition.CollisionProperty.html)\>> |     |

#### Density

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GeneralSounds

##### Declaration

```
public Dictionary<MyStringId, MySoundPair> GeneralSounds
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html), [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html)\> |     |

#### HorisontalFragility

##### Declaration

```
public float HorisontalFragility
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### HorisontalTransmissionMultiplier

##### Declaration

```
public float HorisontalTransmissionMultiplier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### InheritFrom

##### Declaration

```
public MyStringHash InheritFrom
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### SupportMultiplier

##### Declaration

```
public float SupportMultiplier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### GetPhysicalMaterial(MyPhysicalModelDefinition, String)

##### Declaration

```
public static MyPhysicalMaterialDefinition GetPhysicalMaterial(MyPhysicalModelDefinition modelDef, string physicalMaterial)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPhysicalModelDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalModelDefinition.html) | modelDef |     |
| System.String | physicalMaterial |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyPhysicalMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalMaterialDefinition.html) |     |

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