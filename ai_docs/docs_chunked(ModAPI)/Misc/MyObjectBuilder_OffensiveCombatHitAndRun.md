---
title: "Class MyObjectBuilder\\_OffensiveCombatHitAndRun"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_OffensiveCombatHitAndRun.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_OffensiveCombatHitAndRun"
---

# Class MyObjectBuilder\_OffensiveCombatHitAndRun | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_OffensiveCombatHitAndRun

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_OffensiveCombatHitAndRun : MyObjectBuilder_ComponentBase
```

### Constructors

#### MyObjectBuilder\_OffensiveCombatHitAndRun()

##### Declaration

```
public MyObjectBuilder_OffensiveCombatHitAndRun()
```

### Fields

#### BreakOffDistance

##### Declaration

```
public float BreakOffDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### HitAndRunState

##### Declaration

```
[Nullable]
public HitAndRunState HitAndRunState
```

##### Field Value

| Type | Description |
| --- | --- |
| [HitAndRunState](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.HitAndRunState.html) |     |

#### RetreatAngle

##### Declaration

```
public float RetreatAngle
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RetreatDistance

##### Declaration

```
public float RetreatDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RetreatTimeout

##### Declaration

```
public float RetreatTimeout
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SelectedWeapons

##### Declaration

```
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