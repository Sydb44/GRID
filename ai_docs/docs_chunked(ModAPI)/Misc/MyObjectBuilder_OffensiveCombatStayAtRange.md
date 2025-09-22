---
title: "Class MyObjectBuilder\\_OffensiveCombatStayAtRange"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_OffensiveCombatStayAtRange.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_OffensiveCombatStayAtRange"
---

# Class MyObjectBuilder\_OffensiveCombatStayAtRange | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_OffensiveCombatStayAtRange

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_OffensiveCombatStayAtRange : MyObjectBuilder_ComponentBase
```

### Constructors

#### MyObjectBuilder\_OffensiveCombatStayAtRange()

##### Declaration

```
public MyObjectBuilder_OffensiveCombatStayAtRange()
```

### Fields

#### EvasiveManeuvers

##### Declaration

```
public bool EvasiveManeuvers
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

#### MaximalDistance

##### Declaration

```
public float MaximalDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinimalDistance

##### Declaration

```
public float MinimalDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

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