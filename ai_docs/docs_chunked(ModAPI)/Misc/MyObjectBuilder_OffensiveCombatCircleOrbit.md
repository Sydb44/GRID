---
title: "Class MyObjectBuilder\\_OffensiveCombatCircleOrbit"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_OffensiveCombatCircleOrbit.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_OffensiveCombatCircleOrbit"
---

# Class MyObjectBuilder\_OffensiveCombatCircleOrbit | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_OffensiveCombatCircleOrbit

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_OffensiveCombatCircleOrbit : MyObjectBuilder_ComponentBase
```

### Constructors

#### MyObjectBuilder\_OffensiveCombatCircleOrbit()

##### Declaration

```
public MyObjectBuilder_OffensiveCombatCircleOrbit()
```

### Fields

#### CircleDistance

##### Declaration

```
public float CircleDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CircleInPGravity

##### Declaration

```
public bool CircleInPGravity
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FacingMode

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### FacingPriority

##### Declaration

```
public Base6Directions.DirectionFlags FacingPriority
```

##### Field Value

| Type | Description |
| --- | --- |
| [Base6Directions.DirectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.DirectionFlags.html) |     |

#### SelectedWeapons

##### Declaration

```
[Nullable]
public MySerializableList<long> SelectedWeapons
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.ObjectBuilder.MySerializableList<System.Int64\> |     |

#### WasActive

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Remap(IMyRemapHelper)

##### Declaration

```
public override void Remap(IMyRemapHelper remapHelper)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyRemapHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html) | remapHelper |     |

##### Overrides

### Extension Methods